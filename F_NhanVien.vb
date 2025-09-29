Imports System.Data.SqlClient
Public Class F_NhanVien
    Dim Ket_Noi As SqlConnection
    Dim viTriHienTai As Integer = 0 ' Khai báo biến toàn cục

    Private Sub F_NhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Ket_Noi = New SqlConnection("Data Source=DESKTOP-V0AMEPA;Initial Catalog=QL_CUAHANGMAYTINH;Integrated Security=True;TrustServerCertificate=True")
            Ket_Noi.Open()
            Load_dulieu()

            viTriHienTai = 0
            CapNhatDataGridView()

        Catch ex As Exception
            MsgBox("Lỗi kết nối: " & ex.Message, vbCritical, "Lỗi")
        End Try
    End Sub

    'Tạo 1 Thủ tục Load lại dữ liệu khi thêm mới, xoá, sửa:
    Private Sub Load_dulieu()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(
        "SELECT MaNhanVien, TenNhanVien, SoDienThoai, Email, ChucVu, Luong 
         FROM NHAN_VIEN ORDER BY MaNhanVien",
         Ket_Noi)
        da.Fill(dt)

        ' Thêm cột STT
        Dim sttColumn As New DataColumn("STT", GetType(Integer))
        dt.Columns.Add(sttColumn)
        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(i)("STT") = i + 1
        Next
        Data_DS.DataSource = dt
        Data_DS.Columns("STT").DisplayIndex = 0

        ' Đặt tiêu đề
        Data_DS.Columns("STT").HeaderText = "STT"
        Data_DS.Columns("MaNhanVien").HeaderText = "Mã NV"
        Data_DS.Columns("TenNhanVien").HeaderText = "Tên NV"
        Data_DS.Columns("SoDienThoai").HeaderText = "Điện thoại"
        Data_DS.Columns("Email").HeaderText = "Email"
        Data_DS.Columns("ChucVu").HeaderText = "Chức vụ"
        Data_DS.Columns("Luong").HeaderText = "Lương"
        Data_DS.Columns("STT").ReadOnly = True

        ' Tính tổng nhân viên và tổng lương
        Dim tongNV As Integer = dt.Rows.Count
        Dim tongLuong As Decimal = 0
        If dt.Rows.Count > 0 Then
            tongLuong = dt.AsEnumerable().Sum(Function(r) Convert.ToDecimal(r("Luong")))
        End If
        lblTongNhanVien.Text = "Tổng nhân viên: " & tongNV
        lblTongLuong.Text = "Tổng lương: " & tongLuong.ToString("N0") & " VND"

        If tongNV > 0 Then
            If viTriHienTai >= tongNV Then viTriHienTai = tongNV - 1
            CapNhatDataGridView()
        End If
    End Sub

    ' Tạo thủ tục này để di chuyển giữa các bản ghi
    Private Sub CapNhatDataGridView()
        Try
            If Data_DS.Rows.Count > 0 AndAlso viTriHienTai >= 0 AndAlso viTriHienTai < Data_DS.Rows.Count Then
                Data_DS.ClearSelection()
                Data_DS.Rows(viTriHienTai).Selected = True
                Data_DS.CurrentCell = Data_DS.Rows(viTriHienTai).Cells(0)

                ' Hiển thị thông tin lên TextBox
                HienThiThongTin(viTriHienTai)
            End If
        Catch ex As Exception
            MsgBox("Lỗi cập nhật DataGridView: " & ex.Message, vbCritical, "Lỗi")
        End Try
    End Sub

    ' Hiển thị thông tin lên các TextBox
    Private Sub HienThiThongTin(viTri As Integer)
        If Data_DS.CurrentRow IsNot Nothing Then
            Dim row As DataGridViewRow = Data_DS.CurrentRow
            TxtMANV.Text = row.Cells("MaNhanVien").Value?.ToString()
            TxtTENNV.Text = row.Cells("TenNhanVien").Value?.ToString()
            TxtSDT.Text = row.Cells("SoDienThoai").Value?.ToString()
            TxtEmail.Text = row.Cells("Email").Value?.ToString()
            CbCV.SelectedItem = row.Cells("ChucVu").Value?.ToString()
            TxtLuong.Text = row.Cells("Luong").Value?.ToString()
        End If
    End Sub

    Private Sub XoaDuLieuForm()
        TxtMANV.Clear()
        TxtTENNV.Clear()
        TxtSDT.Clear()
        TxtEmail.Clear()
        TxtLuong.Clear()
        CbCV.SelectedIndex = -1
        TxtMANV.Focus()
    End Sub

    ' Kiểm tra email hợp lệ
    Private Function KiemTraEmail(email As String) As Boolean
        If String.IsNullOrEmpty(email) Then Return True ' Email có thể để trống

        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

    Private Sub THEM_Click(sender As Object, e As EventArgs) Handles THEM.Click
        Try
            ' Mở kết nối nếu chưa mở
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            ' Kiểm tra thông tin
            If TxtMANV.Text.Trim() = "" OrElse TxtTENNV.Text.Trim() = "" Then
                MsgBox("Vui lòng điền đủ Mã nhân viên và Tên nhân viên!", vbExclamation)
                Exit Sub
            End If
            If Not KiemTraEmail(TxtEmail.Text.Trim()) Then
                MsgBox("Email không hợp lệ!", vbExclamation)
                Exit Sub
            End If

            ' Kiểm tra trùng
            Dim check As New SqlDataAdapter("SELECT * FROM NHAN_VIEN WHERE MaNhanVien=@MaNV", Ket_Noi)
            check.SelectCommand.Parameters.AddWithValue("@MaNV", TxtMANV.Text.Trim())
            Dim temp As New DataTable
            check.Fill(temp)
            If temp.Rows.Count > 0 Then
                MsgBox("Mã nhân viên đã tồn tại!", vbExclamation)
                Exit Sub
            End If

            ' Thực hiện thêm
            Dim sql As String = "INSERT INTO NHAN_VIEN(MaNhanVien, TenNhanVien, SoDienThoai, Email, ChucVu, Luong) VALUES(@MaNV,@TenNV,@SDT,@Email,@ChucVu,@Luong)"
            Using cmd As New SqlCommand(sql, Ket_Noi)
                cmd.Parameters.AddWithValue("@MaNV", TxtMANV.Text.Trim())
                cmd.Parameters.AddWithValue("@TenNV", TxtTENNV.Text.Trim()) ' SỬA: Từ TxtSDT.Text thành TxtTENNV.Text
                cmd.Parameters.AddWithValue("@SDT", TxtSDT.Text.Trim())
                cmd.Parameters.AddWithValue("@Email", TxtEmail.Text.Trim())
                cmd.Parameters.AddWithValue("@ChucVu", If(CbCV.SelectedItem IsNot Nothing, CbCV.SelectedItem.ToString(), ""))
                cmd.Parameters.AddWithValue("@Luong", If(IsNumeric(TxtLuong.Text), Decimal.Parse(TxtLuong.Text), 0))
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Thêm nhân viên thành công!", vbInformation)
            Load_dulieu()
            XoaDuLieuForm()

        Catch ex As Exception
            MsgBox("Lỗi thêm nhân viên: " & ex.Message, vbCritical, "Lỗi")
        Finally
            If Ket_Noi.State = ConnectionState.Open Then
                Ket_Noi.Close()
            End If
        End Try
    End Sub

    Private Sub CbCV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCV.SelectedIndexChanged
        If CbCV.SelectedItem IsNot Nothing Then
            Dim chucvu As String = CbCV.Text
            Select Case chucvu
                Case "GĐ"
                    TxtLuong.Text = "150000000"
                Case "PGĐ"
                    TxtLuong.Text = "120000000"
                Case "TP"
                    TxtLuong.Text = "30000000"
                Case "KT"
                    TxtLuong.Text = "18000000"
                Case "PP"
                    TxtLuong.Text = "20000000"
                Case "NV"
                    TxtLuong.Text = "10000000"
            End Select
        End If
    End Sub

    Private Sub SUA_Click(sender As Object, e As EventArgs) Handles SUA.Click
        Try
            ' Mở kết nối nếu chưa mở
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            If TxtMANV.Text = "" Then
                MsgBox("Chọn nhân viên cần sửa!", vbExclamation)
                Exit Sub
            End If

            Dim sql As String = "UPDATE NHAN_VIEN SET TenNhanVien=@TenNV, SoDienThoai=@SDT, Email=@Email, ChucVu=@ChucVu, Luong=@Luong WHERE MaNhanVien=@MaNV"
            Using cmd As New SqlCommand(sql, Ket_Noi)
                cmd.Parameters.AddWithValue("@MaNV", TxtMANV.Text.Trim())
                cmd.Parameters.AddWithValue("@TenNV", TxtTENNV.Text.Trim())
                cmd.Parameters.AddWithValue("@SDT", TxtSDT.Text.Trim())
                cmd.Parameters.AddWithValue("@Email", TxtEmail.Text.Trim())
                cmd.Parameters.AddWithValue("@ChucVu", If(CbCV.SelectedItem IsNot Nothing, CbCV.SelectedItem.ToString(), ""))
                cmd.Parameters.AddWithValue("@Luong", If(IsNumeric(TxtLuong.Text), Decimal.Parse(TxtLuong.Text), 0))
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Cập nhật nhân viên thành công!", vbInformation)
            Load_dulieu()
            XoaDuLieuForm()

        Catch ex As Exception
            MsgBox("Lỗi cập nhật: " & ex.Message, vbCritical, "Lỗi")
        Finally
            If Ket_Noi.State = ConnectionState.Open Then
                Ket_Noi.Close()
            End If
        End Try
    End Sub

    Private Sub TKiem_Click(sender As Object, e As EventArgs) Handles TKiem.Click
        Try
            ' Mở kết nối nếu chưa mở
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            Dim keyword = InputBox("Nhập Mã nhân viên cần tìm:")
            If keyword.Trim() = "" Then Exit Sub

            Dim sql = "SELECT * FROM NHAN_VIEN WHERE MaNhanVien=@MaNV"
            Dim da As New SqlDataAdapter(sql, Ket_Noi)
            da.SelectCommand.Parameters.AddWithValue("@MaNV", keyword)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count = 0 Then
                MsgBox("Không tìm thấy nhân viên.", vbInformation)
                Exit Sub
            End If

            TxtMANV.Text = dt.Rows(0)("MaNhanVien").ToString()
            TxtTENNV.Text = dt.Rows(0)("TenNhanVien").ToString()
            TxtSDT.Text = dt.Rows(0)("SoDienThoai").ToString()
            TxtEmail.Text = dt.Rows(0)("Email").ToString()
            CbCV.SelectedItem = dt.Rows(0)("ChucVu").ToString()
            TxtLuong.Text = dt.Rows(0)("Luong").ToString()

        Catch ex As Exception
            MsgBox("Lỗi tìm kiếm: " & ex.Message, vbCritical, "Lỗi")
        Finally
            If Ket_Noi.State = ConnectionState.Open Then
                Ket_Noi.Close()
            End If
        End Try
    End Sub

    Private Sub XOA_Click(sender As Object, e As EventArgs) Handles XOA.Click
        Try
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            If TxtMANV.Text = "" Then Exit Sub
            If MsgBox("Bạn chắc chắn xóa nhân viên này?", vbYesNo) = vbYes Then
                Dim sql As String = "DELETE FROM NHAN_VIEN WHERE MaNhanVien=@MaNV"
                Using cmd As New SqlCommand(sql, Ket_Noi)
                    cmd.Parameters.AddWithValue("@MaNV", TxtMANV.Text)
                    cmd.ExecuteNonQuery()
                End Using
                Load_dulieu()
                XoaDuLieuForm()
            End If

        Catch ex As Exception
            MsgBox("Lỗi xóa: " & ex.Message, vbCritical, "Lỗi")
        Finally
            If Ket_Noi.State = ConnectionState.Open Then
                Ket_Noi.Close()
            End If
        End Try
    End Sub

    Private Sub THOAT_Click(sender As Object, e As EventArgs) Handles THOAT.Click
        If MessageBox.Show("Bạn có chắc muốn thoát khỏi form Quản lý Nhân viên?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Ket_Noi IsNot Nothing AndAlso Ket_Noi.State = ConnectionState.Open Then
                Ket_Noi.Close()
            End If
            Close()
        End If
    End Sub

    Private Sub DAU_Click(sender As Object, e As EventArgs) Handles DAU.Click
        If Data_DS.Rows.Count > 0 Then
            viTriHienTai = 0
            CapNhatDataGridView()
        End If
    End Sub

    Private Sub TRUOC_Click(sender As Object, e As EventArgs) Handles TRUOC.Click
        If Data_DS.Rows.Count > 0 Then
            If viTriHienTai > 0 Then
                viTriHienTai -= 1
                CapNhatDataGridView()
            Else
                MsgBox("Bạn đang ở dòng đầu tiên!", vbInformation, "Thông báo")
            End If
        End If
    End Sub

    Private Sub SAU_Click(sender As Object, e As EventArgs) Handles SAU.Click
        If Data_DS.Rows.Count > 0 Then
            If viTriHienTai < Data_DS.Rows.Count - 1 Then
                viTriHienTai += 1
                CapNhatDataGridView()
            Else
                MsgBox("Bạn đang ở dòng cuối cùng!", vbInformation, "Thông báo")
            End If
        End If
    End Sub

    Private Sub CUOI_Click(sender As Object, e As EventArgs) Handles CUOI.Click
        If Data_DS.Rows.Count > 0 Then
            viTriHienTai = Data_DS.Rows.Count - 1
            CapNhatDataGridView()
        End If
    End Sub

    Private Sub LUU_Click(sender As Object, e As EventArgs) Handles LUU.Click
        Try
            ' Mở kết nối nếu chưa mở
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            If TxtMANV.Text.Trim() = "" Then
                MsgBox("Vui lòng chọn nhân viên để cập nhật!", vbExclamation)
                Exit Sub
            End If

            Dim sql As String = "UPDATE NHAN_VIEN SET TenNhanVien=@TenNV, SoDienThoai=@SDT, Email=@Email, ChucVu=@ChucVu, Luong=@Luong WHERE MaNhanVien=@MaNV"
            Using cmd As New SqlCommand(sql, Ket_Noi)
                cmd.Parameters.AddWithValue("@MaNV", TxtMANV.Text.Trim())
                cmd.Parameters.AddWithValue("@TenNV", TxtTENNV.Text.Trim())
                cmd.Parameters.AddWithValue("@SDT", TxtSDT.Text.Trim())
                cmd.Parameters.AddWithValue("@Email", TxtEmail.Text.Trim())
                cmd.Parameters.AddWithValue("@ChucVu", If(CbCV.SelectedItem IsNot Nothing, CbCV.SelectedItem.ToString(), ""))
                cmd.Parameters.AddWithValue("@Luong", If(IsNumeric(TxtLuong.Text), Decimal.Parse(TxtLuong.Text), 0))

                Dim result As Integer = cmd.ExecuteNonQuery()

                If result > 0 Then
                    MsgBox("Cập nhật nhân viên thành công!", vbInformation, "Thông báo")
                    Load_dulieu()
                    XoaDuLieuForm()
                Else
                    MsgBox("Không thể lưu, có thể mã nhân viên không tồn tại!", vbExclamation, "Lỗi")
                End If
            End Using

        Catch ex As Exception
            MsgBox("Lỗi SQL: " & ex.Message, vbCritical, "Lỗi")
        Finally
            If Ket_Noi.State = ConnectionState.Open Then
                Ket_Noi.Close()
            End If
        End Try
    End Sub

End Class