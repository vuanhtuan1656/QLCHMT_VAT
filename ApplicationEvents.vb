Namespace My

    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            ' Hiển thị form đăng nhập
            Dim loginForm As New F_DangNhap()
            If loginForm.ShowDialog() = DialogResult.OK Then
                ' Nếu đăng nhập thành công thì mở form chính
                Dim mainForm As New F_Menu()
                mainForm.ShowDialog()
            End If

            ' Sau khi form chính đóng, thoát luôn ứng dụng
            e.Cancel = True
        End Sub

    End Class

End Namespace
