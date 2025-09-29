Imports System.Data.SqlClient
Public Class F_SanPham
    Dim Ket_Noi As SqlConnection
    Dim viTriHienTai As Integer = 0 ' Khai báo biến toàn cục

    Private Sub F_SanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Ket_Noi = New SqlConnection("Data Source=DESKTOP-V0AMEPA;Initial Catalog=QL_CUAHANGMAYTINH;Integrated Security=True;TrustServerCertificate=True")
            Ket_Noi.Open()

            ' Load danh sách loại sản phẩm vào ComboBox
            LoadComboBoxLoai()
            Load_dulieu()

            viTriHienTai = 0
            CapNhatDataGridView()

        Catch ex As Exception
            MsgBox("Lỗi kết nối: " & ex.Message, vbCritical, "Lỗi")
        End Try
    End Sub

    ' Load dữ liệu loại sản phẩm vào ComboBox
    Private Sub LoadComboBoxLoai()
        Try
            cboMaLoai.Items.Clear()
            cboMaLoai.Items.Add("VGA")
            cboMaLoai.Items.Add("RAM")
            cboMaLoai.Items.Add("SSD")
            cboMaLoai.Items.Add("CPU")
            cboMaLoai.Items.Add("Máy Tính")
            cboMaLoai.Items.Add("Bàn Phím")
            cboMaLoai.Items.Add("Màn Hình")
            cboMaLoai.Items.Add("Tai Nghe")
            cboMaLoai.Items.Add("Loa")

            cboMaLoai.SelectedIndex = -1 ' Không chọn gì ban đầu
        Catch ex As Exception
            MsgBox("Lỗi load ComboBox: " & ex.Message, vbCritical, "Lỗi")
        End Try
    End Sub

    'Tạo 1 Thủ tục Load lại dữ liệu khi thêm mới, xoá, sửa:
    Private Sub Load_dulieu()
        Try
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter("SELECT MaSanPham, TenSanPham, MaLoai, GiaNhap, GiaBan, SoLuongTon, MoTa, TrangThai FROM SAN_PHAM ORDER BY MaSanPham", Ket_Noi)
            da.Fill(dt)

            Dim sttColumn As New DataColumn("STT", GetType(Integer))
            dt.Columns.Add(sttColumn)

            ' Thêm STT cho từng dòng
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("STT") = i + 1
            Next

            Data_DS.DataSource = dt
            Data_DS.Columns("STT").DisplayIndex = 0

            ' Thiết lập tiêu đề cột cho DataGridView
            If Data_DS.Columns.Count > 0 Then
                Data_DS.Columns("STT").HeaderText = "STT"
                Data_DS.Columns("STT").Width = 50
                Data_DS.Columns("STT").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Data_DS.Columns("MaSanPham").HeaderText = "Mã Sản Phẩm"
                Data_DS.Columns("TenSanPham").HeaderText = "Tên Sản Phẩm"
                Data_DS.Columns("MaLoai").HeaderText = "Loại"
                Data_DS.Columns("GiaNhap").HeaderText = "Giá Nhập"
                Data_DS.Columns("GiaBan").HeaderText = "Giá Bán"
                Data_DS.Columns("SoLuongTon").HeaderText = "Số Lượng Tồn"
                Data_DS.Columns("MoTa").HeaderText = "Mô Tả"
                Data_DS.Columns("TrangThai").HeaderText = "Trạng Thái"

                ' Định dạng cột 
                Data_DS.Columns("GiaNhap").DefaultCellStyle.Format = "N0"
                Data_DS.Columns("GiaNhap").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Data_DS.Columns("GiaBan").DefaultCellStyle.Format = "N0"
                Data_DS.Columns("GiaBan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Data_DS.Columns("SoLuongTon").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Data_DS.Columns("STT").ReadOnly = True

                ' Điều chỉnh độ rộng cột
                Data_DS.Columns("TenSanPham").Width = 200
                Data_DS.Columns("MoTa").Width = 150
            End If

            ' Hiển thị tổng số sản phẩm
            Try
                If Me.Controls.ContainsKey("lblTongSo") Then
                    Dim lblTongSo As Label = DirectCast(Me.Controls("lblTongSo"), Label)
                    lblTongSo.Text = "Tổng số sản phẩm: " & dt.Rows.Count.ToString()
                End If
            Catch
            End Try

            ' Cập nhật vị trí hiện tại
            If dt.Rows.Count > 0 Then
                If viTriHienTai >= dt.Rows.Count Then
                    viTriHienTai = dt.Rows.Count - 1
                End If
                CapNhatDataGridView()
            End If
        Catch ex As Exception
            MsgBox("Lỗi tải dữ liệu: " & ex.Message, vbCritical, "Lỗi")
        End Try
    End Sub

    ' Tạo thủ tục này để di chuyển giữa các bản ghi
    Private Sub CapNhatDataGridView()
        Try
            If Data_DS.Rows.Count > 0 AndAlso viTriHienTai >= 0 AndAlso viTriHienTai < Data_DS.Rows.Count Then
                Data_DS.ClearSelection()
                Data_DS.Rows(viTriHienTai).Selected = True
                Data_DS.CurrentCell = Data_DS.Rows(viTriHienTai).Cells(0)

                HienThiThongTin(viTriHienTai)
            End If
        Catch ex As Exception
            MsgBox("Lỗi cập nhật DataGridView: " & ex.Message, vbCritical, "Lỗi")
        End Try
    End Sub

    ' Hiển thị thông tin lên các TextBox
    Private Sub HienThiThongTin(viTri As Integer)
        Try
            If Data_DS.Rows.Count > 0 AndAlso viTri >= 0 AndAlso viTri < Data_DS.Rows.Count Then
                Dim row As DataGridViewRow = Data_DS.Rows(viTri)
                TxtMaSP.Text = If(row.Cells("MaSanPham").Value IsNot Nothing, row.Cells("MaSanPham").Value.ToString(), "")
                TxtTenSP.Text = If(row.Cells("TenSanPham").Value IsNot Nothing, row.Cells("TenSanPham").Value.ToString(), "")

                ' Chọn item trong ComboBox
                Dim loai As String = If(row.Cells("MaLoai").Value IsNot Nothing, row.Cells("MaLoai").Value.ToString(), "")
                If cboMaLoai.Items.Contains(loai) Then
                    cboMaLoai.SelectedItem = loai
                Else
                    cboMaLoai.SelectedIndex = -1
                End If

                TxtGiaNhap.Text = If(row.Cells("GiaNhap").Value IsNot Nothing, row.Cells("GiaNhap").Value.ToString(), "0")
                TxtGiaBan.Text = If(row.Cells("GiaBan").Value IsNot Nothing, row.Cells("GiaBan").Value.ToString(), "0")
                TxtSoLuongTon.Text = If(row.Cells("SoLuongTon").Value IsNot Nothing, row.Cells("SoLuongTon").Value.ToString(), "0")
                TxtMoTa.Text = If(row.Cells("MoTa").Value IsNot Nothing, row.Cells("MoTa").Value.ToString(), "")
                TxtTrangThai.Text = If(row.Cells("TrangThai").Value IsNot Nothing, row.Cells("TrangThai").Value.ToString(), "Hoạt động")

                ' Hiển thị vị trí hiện tại
                Try
                    If Me.Controls.ContainsKey("lblViTri") Then
                        Dim lblViTri As Label = DirectCast(Me.Controls("lblViTri"), Label)
                        lblViTri.Text = "Sản phẩm: " & (viTri + 1).ToString() & "/" & Data_DS.Rows.Count.ToString()
                    End If
                Catch
                End Try
            End If
        Catch ex As Exception
            MsgBox("Lỗi hiển thị thông tin: " & ex.Message, vbCritical, "Lỗi")
        End Try
    End Sub

    ' Xóa dữ liệu trên form
    Private Sub XoaDuLieuForm()
        TxtMaSP.Clear()
        TxtTenSP.Clear()
        cboMaLoai.SelectedIndex = -1
        TxtGiaNhap.Clear()
        TxtGiaBan.Clear()
        TxtSoLuongTon.Clear()
        TxtMoTa.Clear()
        TxtTrangThai.Text = "Hoạt động"
        TxtMaSP.Focus()
    End Sub

    ' Kiểm tra dữ liệu hợp lệ
    Private Function KiemTraDuLieu() As Boolean
        If TxtMaSP.Text.Trim() = "" Then
            MsgBox("Mã sản phẩm không được để trống", vbExclamation, "Chú ý")
            TxtMaSP.Focus()
            Return False
        End If

        If TxtTenSP.Text.Trim() = "" Then
            MsgBox("Tên sản phẩm không được để trống", vbExclamation, "Chú ý")
            TxtTenSP.Focus()
            Return False
        End If

        If cboMaLoai.SelectedIndex = -1 Then
            MsgBox("Vui lòng chọn loại sản phẩm", vbExclamation, "Chú ý")
            cboMaLoai.Focus()
            Return False
        End If

        ' Kiểm tra giá nhập
        Dim giaNhap As Decimal = 0
        If Not Decimal.TryParse(TxtGiaNhap.Text.Trim(), giaNhap) OrElse giaNhap < 0 Then
            MsgBox("Giá nhập không hợp lệ", vbExclamation, "Chú ý")
            TxtGiaNhap.Focus()
            Return False
        End If

        ' Kiểm tra giá bán
        Dim giaBan As Decimal = 0
        If Not Decimal.TryParse(TxtGiaBan.Text.Trim(), giaBan) OrElse giaBan < 0 Then
            MsgBox("Giá bán không hợp lệ", vbExclamation, "Chú ý")
            TxtGiaBan.Focus()
            Return False
        End If

        ' Kiểm tra số lượng tồn
        Dim soLuongTon As Integer = 0
        If Not Integer.TryParse(TxtSoLuongTon.Text.Trim(), soLuongTon) OrElse soLuongTon < 0 Then
            MsgBox("Số lượng tồn không hợp lệ", vbExclamation, "Chú ý")
            TxtSoLuongTon.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub THEM_Click(sender As Object, e As EventArgs) Handles THEM.Click
        ' Kiểm tra dữ liệu trước khi thêm
        If Not KiemTraDuLieu() Then Exit Sub

        Try
            ' Kiểm tra trùng mã sản phẩm
            Dim SQL_KiemTra As New SqlDataAdapter("SELECT * FROM SAN_PHAM WHERE MaSanPham=@MaSP", Ket_Noi)
            SQL_KiemTra.SelectCommand.Parameters.AddWithValue("@MaSP", TxtMaSP.Text.Trim())
            Dim Db_Check As New DataTable
            SQL_KiemTra.Fill(Db_Check)

            If Db_Check.Rows.Count > 0 Then
                MsgBox("Mã sản phẩm này đã tồn tại!", vbExclamation, "Thông báo")
                TxtMaSP.Focus()
                Exit Sub
            End If

            ' Kiểm tra và mở kết nối nếu chưa mở
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            ' Lệnh INSERT:
            Dim SQL_DangKy As New SqlCommand("INSERT INTO SAN_PHAM (MaSanPham, TenSanPham, MaLoai, GiaNhap, GiaBan, SoLuongTon, MoTa, TrangThai) VALUES (@MaSP, @TenSP, @MaLoai, @GiaNhap, @GiaBan, @SoLuongTon, @MoTa, @TrangThai)", Ket_Noi)
            SQL_DangKy.Parameters.AddWithValue("@MaSP", TxtMaSP.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@TenSP", TxtTenSP.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@MaLoai", cboMaLoai.SelectedItem.ToString())
            SQL_DangKy.Parameters.AddWithValue("@GiaNhap", Decimal.Parse(TxtGiaNhap.Text.Trim()))
            SQL_DangKy.Parameters.AddWithValue("@GiaBan", Decimal.Parse(TxtGiaBan.Text.Trim()))
            SQL_DangKy.Parameters.AddWithValue("@SoLuongTon", Integer.Parse(TxtSoLuongTon.Text.Trim()))
            SQL_DangKy.Parameters.AddWithValue("@MoTa", TxtMoTa.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@TrangThai", TxtTrangThai.Text.Trim())

            SQL_DangKy.ExecuteNonQuery()
            MsgBox("Thêm sản phẩm thành công!", vbInformation, "Thông báo")

            Load_dulieu() ' Cập nhật danh sách
            XoaDuLieuForm() ' Xóa dữ liệu trên form

        Catch ex As SqlException
            MsgBox("Lỗi SQL: " & ex.Message, vbCritical, "Lỗi")
        Catch ex As Exception
            MsgBox("Lỗi: " & ex.Message, vbCritical, "Lỗi")
        Finally
            If Ket_Noi.State = ConnectionState.Open Then
                Ket_Noi.Close()
            End If
        End Try
    End Sub

    Private Sub SUA_Click(sender As Object, e As EventArgs) Handles SUA.Click
        If TxtMaSP.Text.Trim() = "" Then
            MsgBox("Vui lòng chọn sản phẩm cần sửa từ danh sách", vbExclamation, "Thông báo")
            Exit Sub
        End If

        ' Kiểm tra dữ liệu
        If Not KiemTraDuLieu() Then Exit Sub

        Try
            ' Kiểm tra và mở kết nối nếu chưa mở
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            Dim Sql As String = "UPDATE SAN_PHAM SET TenSanPham=@TenSP, MaLoai=@MaLoai, GiaNhap=@GiaNhap, GiaBan=@GiaBan, SoLuongTon=@SoLuongTon, MoTa=@MoTa, TrangThai=@TrangThai WHERE MaSanPham=@MaSP"
            Using Cmd As New SqlCommand(Sql, Ket_Noi)
                Cmd.Parameters.AddWithValue("@MaSP", TxtMaSP.Text.Trim())
                Cmd.Parameters.AddWithValue("@TenSP", TxtTenSP.Text.Trim())
                Cmd.Parameters.AddWithValue("@MaLoai", cboMaLoai.SelectedItem.ToString())
                Cmd.Parameters.AddWithValue("@GiaNhap", Decimal.Parse(TxtGiaNhap.Text.Trim()))
                Cmd.Parameters.AddWithValue("@GiaBan", Decimal.Parse(TxtGiaBan.Text.Trim()))
                Cmd.Parameters.AddWithValue("@SoLuongTon", Integer.Parse(TxtSoLuongTon.Text.Trim()))
                Cmd.Parameters.AddWithValue("@MoTa", TxtMoTa.Text.Trim())
                Cmd.Parameters.AddWithValue("@TrangThai", TxtTrangThai.Text.Trim())

                Dim result As Integer = Cmd.ExecuteNonQuery()

                If result > 0 Then
                    MsgBox("Cập nhật thành công!", vbInformation, "Thông báo")
                    Load_dulieu() ' Làm mới DataGridView
                    XoaDuLieuForm()
                Else
                    MsgBox("Không thể cập nhật, mã sản phẩm không tồn tại!", vbExclamation, "Lỗi")
                End If
            End Using

        Catch ex As SqlException
            MsgBox("Lỗi SQL: " & ex.Message, vbCritical, "Lỗi")
        Catch ex As Exception
            MsgBox("Lỗi: " & ex.Message, vbCritical, "Lỗi")
        Finally
            If Ket_Noi.State = ConnectionState.Open Then
                Ket_Noi.Close()
            End If
        End Try
    End Sub

    Private Sub Data_DS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_DS.CellClick
        If e.RowIndex >= 0 Then
            viTriHienTai = e.RowIndex
            HienThiThongTin(viTriHienTai)
        End If
    End Sub

    Private Sub TKiem_Click(sender As Object, e As EventArgs) Handles TKiem.Click
        Dim maSanPham As String = InputBox("Nhập mã sản phẩm cần tìm:", "Tìm Kiếm Sản Phẩm")

        If maSanPham.Trim() = "" Then
            MessageBox.Show("Bạn chưa nhập mã sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Tìm sản phẩm trong database
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            Dim query As String = "SELECT * FROM SAN_PHAM WHERE MaSanPham = @MaSP"
            Dim command As New SqlCommand(query, Ket_Noi)
            command.Parameters.AddWithValue("@MaSP", maSanPham.Trim())

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                ' Hiển thị lên các control
                TxtMaSP.Text = table.Rows(0)("MaSanPham").ToString()
                TxtTenSP.Text = If(table.Rows(0)("TenSanPham") IsNot DBNull.Value, table.Rows(0)("TenSanPham").ToString(), "")

                Dim loai As String = If(table.Rows(0)("MaLoai") IsNot DBNull.Value, table.Rows(0)("MaLoai").ToString(), "")
                If cboMaLoai.Items.Contains(loai) Then
                    cboMaLoai.SelectedItem = loai
                Else
                    cboMaLoai.SelectedIndex = -1
                End If

                TxtGiaNhap.Text = If(table.Rows(0)("GiaNhap") IsNot DBNull.Value, table.Rows(0)("GiaNhap").ToString(), "0")
                TxtGiaBan.Text = If(table.Rows(0)("GiaBan") IsNot DBNull.Value, table.Rows(0)("GiaBan").ToString(), "0")
                TxtSoLuongTon.Text = If(table.Rows(0)("SoLuongTon") IsNot DBNull.Value, table.Rows(0)("SoLuongTon").ToString(), "0")
                TxtMoTa.Text = If(table.Rows(0)("MoTa") IsNot DBNull.Value, table.Rows(0)("MoTa").ToString(), "")
                TxtTrangThai.Text = If(table.Rows(0)("TrangThai") IsNot DBNull.Value, table.Rows(0)("TrangThai").ToString(), "Hoạt động")

                ' Đánh dấu dòng trong DataGridView
                For i As Integer = 0 To Data_DS.Rows.Count - 1
                    If Data_DS.Rows(i).Cells("MaSanPham").Value.ToString() = maSanPham.Trim() Then
                        viTriHienTai = i
                        CapNhatDataGridView()
                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("Không tìm thấy sản phẩm có mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Lỗi tìm kiếm: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Ket_Noi.State = ConnectionState.Open Then
                Ket_Noi.Close()
            End If
        End Try
    End Sub

    Private Sub XOA_Click(sender As Object, e As EventArgs) Handles XOA.Click
        If TxtMaSP.Text.Trim() = "" Then
            MessageBox.Show("Vui lòng chọn sản phẩm cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim maSanPham As String = TxtMaSP.Text.Trim()

        ' Xác nhận xóa
        If MessageBox.Show("Bạn có chắc muốn xóa sản phẩm '" & maSanPham & "'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                If Ket_Noi.State = ConnectionState.Closed Then
                    Ket_Noi.Open()
                End If

                ' Xóa sản phẩm
                Dim query As String = "DELETE FROM SAN_PHAM WHERE MaSanPham = @MaSP"
                Dim command As New SqlCommand(query, Ket_Noi)
                command.Parameters.AddWithValue("@MaSP", maSanPham)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_dulieu() ' Cập nhật lại danh sách
                    XoaDuLieuForm()
                Else
                    MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Catch ex As Exception
                MessageBox.Show("Lỗi khi xóa: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Ket_Noi.State = ConnectionState.Open Then
                    Ket_Noi.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub THOAT_Click(sender As Object, e As EventArgs) Handles THOAT.Click
        If MessageBox.Show("Bạn có chắc muốn thoát khỏi form Quản lý Sản phẩm?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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
        If TxtMaSP.Text.Trim() = "" Then
            MsgBox("Vui lòng chọn sản phẩm cần lưu", vbExclamation, "Thông báo")
            Exit Sub
        End If

        ' Kiểm tra dữ liệu
        If Not KiemTraDuLieu() Then Exit Sub

        Try
            ' Kiểm tra và mở kết nối nếu chưa mở
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            ' Câu lệnh UPDATE sản phẩm
            Dim sql As String = "UPDATE SAN_PHAM SET TenSanPham=@TenSP, MaLoai=@MaLoai, GiaNhap=@GiaNhap, GiaBan=@GiaBan, SoLuongTon=@SoLuongTon, MoTa=@MoTa, TrangThai=@TrangThai WHERE MaSanPham=@MaSP"

            Using cmd As New SqlCommand(sql, Ket_Noi)
                cmd.Parameters.AddWithValue("@MaSP", TxtMaSP.Text.Trim())
                cmd.Parameters.AddWithValue("@TenSP", TxtTenSP.Text.Trim())
                cmd.Parameters.AddWithValue("@MaLoai", cboMaLoai.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@GiaNhap", Decimal.Parse(TxtGiaNhap.Text.Trim()))
                cmd.Parameters.AddWithValue("@GiaBan", Decimal.Parse(TxtGiaBan.Text.Trim()))
                cmd.Parameters.AddWithValue("@SoLuongTon", Integer.Parse(TxtSoLuongTon.Text.Trim()))
                cmd.Parameters.AddWithValue("@MoTa", TxtMoTa.Text.Trim())
                cmd.Parameters.AddWithValue("@TrangThai", TxtTrangThai.Text.Trim())

                ' Thực thi câu lệnh UPDATE
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Lưu thành công!", vbInformation, "Thông báo")
                    Load_dulieu()
                    XoaDuLieuForm()
                Else
                    MsgBox("Không thể lưu! Mã sản phẩm không tồn tại.", vbExclamation, "Lỗi")
                End If
            End Using

        Catch ex As SqlException
            MsgBox("Lỗi SQL: " & ex.Message, vbCritical, "Lỗi")
        Catch ex As Exception
            MsgBox("Lỗi: " & ex.Message, vbCritical, "Lỗi")
        Finally
            ' Đảm bảo đóng kết nối
            If Ket_Noi.State = ConnectionState.Open Then
                Ket_Noi.Close()
            End If
        End Try
    End Sub

    ' Event handler cho validation số
    Private Sub TxtGiaNhap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtGiaNhap.KeyPress
        ' Chỉ cho phép nhập số, dấu thập phân và phím điều khiển
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtGiaBan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtGiaBan.KeyPress
        ' Chỉ cho phép nhập số, dấu thập phân và phím điều khiển
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtSoLuongTon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSoLuongTon.KeyPress
        ' Chỉ cho phép nhập số và phím điều khiển
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

End Class