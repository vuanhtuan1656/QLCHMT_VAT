Public Class F_Menu

    Private Sub F_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Phần mềm Quản Lý Cửa Hàng Máy Tính"
    End Sub

    ' Hệ thống
    Private Sub mnuDangNhap_Click(sender As Object, e As EventArgs) Handles mnuDangNhap.Click
        Dim f As New F_DangNhap
        f.ShowDialog()
    End Sub

    Private Sub mnuDangKy_Click(sender As Object, e As EventArgs) Handles mnuDangKy.Click
        Dim f As New F_DangKy
        f.ShowDialog()
    End Sub

    Private Sub mnuThoat_Click(sender As Object, e As EventArgs) Handles mnuThoat.Click
        Application.Exit()
    End Sub

    ' Quản lý
    Private Sub mnuNhanVien_Click(sender As Object, e As EventArgs) Handles mnuNhanVien.Click
        Dim f As New F_NhanVien
        f.Show()
    End Sub

    Private Sub mnuKhachHang_Click(sender As Object, e As EventArgs) Handles mnuKhachHang.Click
        Dim f As New F_KhachHang
        f.Show()
    End Sub

    Private Sub mnuNhaCungCap_Click(sender As Object, e As EventArgs) Handles mnuNhaCungCap.Click
        Dim f As New F_Nha_Cung_Cap
        f.Show()
    End Sub



    Private Sub mnuBaoHanh_Click(sender As Object, e As EventArgs) Handles mnuBaoHanh.Click
        Dim f As New F_BaoHanh
        f.Show()
    End Sub

    ' Hóa đơn
    Private Sub mnuHoaDon_Click(sender As Object, e As EventArgs) Handles mnuHoaDon.Click
        Dim f As New F_HoaDon
        f.Show()
    End Sub

    Private Sub mnuHoaDonNhap_Click(sender As Object, e As EventArgs) Handles mnuHoaDonNhap.Click
        Dim f As New F_Hoa_Don_Nhap
        f.Show()
    End Sub

    Private Sub mnuChiTietHoaDon_Click(sender As Object, e As EventArgs) Handles mnuChiTietHoaDon.Click
        Dim f As New F_ChiTietHoaDon
        f.Show()
    End Sub

    Private Sub mnuChiTietHoaDonNhap_Click(sender As Object, e As EventArgs) Handles mnuChiTietHoaDonNhap.Click
        Dim f As New F_Chi_Tiet_Hoa_Don_Nhap
        f.Show()
    End Sub

    ' Báo cáo
    Private Sub mnuBaoCaoBan_Click(sender As Object, e As EventArgs) Handles mnuBaoCaoBan.Click
        ' Mở báo cáo hóa đơn bán
        Dim rpt As New Form1
        rpt.Show()
    End Sub

    Private Sub mnuBaoCaoNhap_Click(sender As Object, e As EventArgs) Handles mnuBaoCaoNhap.Click
        ' Mở báo cáo hóa đơn nhập
        Dim rpt As New Form2
        rpt.Show()
    End Sub

    ' Trợ giúp
    Private Sub mnuGioiThieu_Click(sender As Object, e As EventArgs) Handles mnuGioiThieu.Click
        MessageBox.Show("Phần mềm Quản Lý Cửa Hàng giúp quản lý bán hàng và nhập hàng một cách nhanh chóng, chính xác.  
Chức năng chính:
- Quản lý nhân viên, khách hàng, sản phẩm, nhà cung cấp
- Lập hóa đơn bán hàng và hóa đơn nhập hàng
- Quản lý bảo hành
- Xem và in báo cáo, thống kê doanh thu, tồn kho
- Phần mềm dễ sử dụng, giao diện thân thiện, phù hợp cho cửa hàng nhỏ và vừa.")
    End Sub

    Private Sub mnuHuongDan_Click(sender As Object, e As EventArgs) Handles mnuHuongDan.Click
        MessageBox.Show("1. Đăng nhập bằng tài khoản được cấp.
2. Quản lý sản phẩm: Thêm, sửa, xóa, tìm kiếm.
3. Quản lý khách hàng, nhân viên, nhà cung cấp.
4. Lập hóa đơn:
   - Hóa đơn bán: Ghi nhận giao dịch bán hàng.
   - Hóa đơn nhập: Ghi nhận hàng nhập từ nhà cung cấp.
5. Xem báo cáo và thống kê doanh thu, tồn kho.
6. Quản lý bảo hành sản phẩm.
7. Trợ giúp:
   - Menu Trợ Giúp → Giới Thiệu: Xem thông tin phần mềm.
   - Menu Trợ Giúp → Hướng Dẫn Sử Dụng: Xem hướng dẫn này
   - Hoặc có thể liên hệ qua email: vuanhtuan16052006@gmail.com để được hỗ trợ.")
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.BackColor = Color.Transparent

    End Sub

    Private Sub mnuLoaiSanPham_Click(sender As Object, e As EventArgs) Handles mnuLoaiSanPham.Click
        Dim f As New F_LoaiSanPham
        f.Show()
    End Sub

    Private Sub mnuSanPham_Click(sender As Object, e As EventArgs) Handles mnuSanPham.Click
        Dim f As New F_SanPham
        f.Show()
    End Sub

    Private Sub a_Click(sender As Object, e As EventArgs) Handles mnuDoanhThu.Click
        Dim f As New F_ChiTietHoaDon
        f.Show()
    End Sub
End Class
