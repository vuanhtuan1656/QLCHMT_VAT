Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Data.SqlClient

Partial Public Class Form2
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Kiểm tra file báo cáo có tồn tại không
            Dim reportPath As String = "G:\doanvb.VuAnhTuan.Th29.21\QuanLyCuaHangMT\BaoCaoHoaDonN.rpt"
            If Not File.Exists(reportPath) Then
                MessageBox.Show("Không tìm thấy file báo cáo: " & reportPath)
                Return
            End If

            Dim connectionString As String = "Data Source=DESKTOP-V0AMEPA;Initial Catalog=QL_CUAHANGMAYTINH;Integrated Security=True;TrustServerCertificate=True"
            Dim dt As New DataTable()

            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM CHI_TIET_HOA_DON_NHAP"
                Using cmd As New SqlCommand(query, conn)
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

            ' Kiểm tra dữ liệu có tồn tại không
            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                MessageBox.Show("Không có dữ liệu để hiển thị")
                Return
            End If


            Dim BaoCaoHoaDonN As New ReportDocument()

            BaoCaoHoaDonN.Load(reportPath)

            BaoCaoHoaDonN.SetDataSource(dt)

            BaoCaoHoaDonN.Refresh()


            CrystalReportViewer1.ReportSource = BaoCaoHoaDonN
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message & vbCrLf & "Chi tiết: " & ex.StackTrace)
        End Try
    End Sub

    ' Giải phóng tài nguyên khi đóng form
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If CrystalReportViewer1.ReportSource IsNot Nothing Then
                CType(CrystalReportViewer1.ReportSource, ReportDocument).Close()
                CType(CrystalReportViewer1.ReportSource, ReportDocument).Dispose()
            End If
        Catch ex As Exception

            Console.WriteLine("Error disposing report: " & ex.Message)
        End Try
    End Sub


End Class