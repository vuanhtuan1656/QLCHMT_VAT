Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports System.Data.SqlClient

Partial Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Kiểm tra file báo cáo có tồn tại không
            Dim reportPath As String = "G:\doanvb.VuAnhTuan.Th29.21\QuanLyCuaHangMT\BaoCaoHoaDonB.rpt"
            If Not File.Exists(reportPath) Then
                MessageBox.Show("Không tìm thấy file báo cáo: " & reportPath)
                Return
            End If

            Dim connectionString As String = "Data Source=DESKTOP-V0AMEPA;Initial Catalog=QL_CUAHANGMAYTINH;Integrated Security=True;TrustServerCertificate=True"
            Dim dt As New DataTable()

            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM CHI_TIET_HOA_DON"
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


            Dim BaoCaoHoaDonB As New ReportDocument()

            BaoCaoHoaDonB.Load(reportPath)

            BaoCaoHoaDonB.SetDataSource(dt)

            BaoCaoHoaDonB.Refresh()

            ' Gán báo cáo vào viewer
            CrystalReportViewer2.ReportSource = BaoCaoHoaDonB
            CrystalReportViewer2.Refresh()

        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message & vbCrLf & "Chi tiết: " & ex.StackTrace)
        End Try
    End Sub

    ' Giải phóng tài nguyên khi đóng form
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If CrystalReportViewer2.ReportSource IsNot Nothing Then
                CType(CrystalReportViewer2.ReportSource, ReportDocument).Close()
                CType(CrystalReportViewer2.ReportSource, ReportDocument).Dispose()
            End If
        Catch ex As Exception
            ' Log error but don't show to user during form closing
            Console.WriteLine("Error disposing report: " & ex.Message)
        End Try
    End Sub


End Class