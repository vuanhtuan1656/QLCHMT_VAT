Imports System.Data.SqlClient


Public Class F_DangNhap
    Dim Ket_Noi As SqlConnection
    Private Sub F_DangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ket_Noi = New SqlConnection("Data Source=DESKTOP-V0AMEPA;Initial Catalog=QL_CUAHANGMAYTINH;Integrated Security=True;TrustServerCertificate=True")
        Ket_Noi.Open()
    End Sub
    Private Sub DangNhap_Click(sender As Object, e As EventArgs) Handles DangNhap.Click
        If TxtTenDN.Text.Trim() = "" Or TxtMatKhau.Text.Trim() = "" Then
            MsgBox("Tên đăng nhập và mật khẩu không được để trống!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim SQL As New SqlDataAdapter("SELECT * FROM TaiKhoan WHERE TenDN=@TenDN AND MatKhau=@MatKhau", Ket_Noi)
        SQL.SelectCommand.Parameters.AddWithValue("@TenDN", TxtTenDN.Text.Trim())
        SQL.SelectCommand.Parameters.AddWithValue("@MatKhau", TxtMatKhau.Text.Trim())

        Dim Db As New DataTable
        SQL.Fill(Db)

        If Db.Rows.Count > 0 Then
            ' Đăng nhập thành công
            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK ' Để Startup kiểm tra
            Me.Close()
        Else
            ' Sai tài khoản hoặc mật khẩu
            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtMatKhau.Clear()
            TxtMatKhau.Focus()
        End If
    End Sub


    Private Sub DangKy_Click(sender As Object, e As EventArgs) Handles DangKy.Click
        F_DangKy.Show()
        Me.Hide()

    End Sub

    'đóng connection khi form đóng
    Private Sub F_DangNhap_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If Ket_Noi IsNot Nothing AndAlso Ket_Noi.State = ConnectionState.Open Then
            Ket_Noi.Close()
        End If
    End Sub
    Private Sub BtThoat_Click(sender As Object, e As EventArgs) Handles BtThoat.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class


