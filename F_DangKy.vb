Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class F_DangKy
    Dim Ket_Noi As SqlConnection

    Private Sub F_DangKy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ket_Noi = New SqlConnection("Data Source=DESKTOP-V0AMEPA;Initial Catalog=QL_CUAHANGMAYTINH;Integrated Security=True;TrustServerCertificate=True")
        Ket_Noi.Open()
    End Sub
    Private Sub BtDangKy_Click(sender As Object, e As EventArgs) Handles BtDangKy.Click

        ' Kiểm tra ô nhập liệu có bị trống không
        If TxtTenDN.Text.Trim() = "" Then
            MsgBox("Tên đăng nhập không được để trống!")
            Exit Sub
        End If

        If TxtMatKhau.Text.Trim() = "" Then
            MsgBox("Mật khẩu không được để trống!")
            Exit Sub
        End If

        ' Kiểm tra mật khẩu có đủ mạnh không (ít nhất 6 ký tự)
        If TxtMatKhau.Text.Length < 6 Then
            MsgBox("Mật khẩu phải có ít nhất 6 ký tự!")
            Exit Sub
        End If
        ' Kiểm tra mật khẩu xác nhận có khớp không
        If TxtMatKhau.Text <> TxtXacNhanMatKhau.Text Then
            MsgBox("Mật khẩu xác nhận không khớp!")
            TxtXacNhanMatKhau.Focus()
            TxtXacNhanMatKhau.SelectAll()
            Exit Sub
        End If

        ' Kiểm tra tên đăng nhập có bị trùng không
        Dim SQL_KiemTra As New SqlDataAdapter("SELECT * FROM TaiKhoan WHERE TenDN=@TenDN", Ket_Noi)
        SQL_KiemTra.SelectCommand.Parameters.AddWithValue("@TenDN", TxtTenDN.Text.Trim())

        Dim Db_Check As New DataTable
        SQL_KiemTra.Fill(Db_Check)

        If Db_Check.Rows.Count > 0 Then
            MsgBox("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!")
            Exit Sub
        End If

        ' Nếu không trùng, tiến hành lưu vào database
        Dim SQL_DangKy As New SqlCommand("INSERT INTO TaiKhoan (TenDN, MatKhau) VALUES (@TenDN, @MatKhau)", Ket_Noi)
        SQL_DangKy.Parameters.AddWithValue("@TenDN", TxtTenDN.Text.Trim())
        SQL_DangKy.Parameters.AddWithValue("@MatKhau", TxtMatKhau.Text)

        Try
            SQL_DangKy.ExecuteNonQuery()
            MsgBox("Đăng ký thành công!")
            Me.Close() ' Đóng form đăng ký sau khi hoàn tất
        Catch ex As Exception
            MsgBox("Có lỗi xảy ra khi đăng ký: " & ex.Message)
        End Try
    End Sub


    Private Sub TxtXacNhanMatKhau_TextChanged(sender As Object, e As EventArgs) Handles TxtXacNhanMatKhau.TextChanged
        If TxtMatKhau.Text <> "" And TxtXacNhanMatKhau.Text <> "" Then
            If TxtMatKhau.Text = TxtXacNhanMatKhau.Text Then
                TxtXacNhanMatKhau.BackColor = Color.LightGreen
            Else
                TxtXacNhanMatKhau.BackColor = Color.LightCoral
            End If
        Else
            TxtXacNhanMatKhau.BackColor = Color.White
        End If
    End Sub

    Private Sub BtThoat_Click(sender As Object, e As EventArgs) Handles BtThoat.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


End Class
