Imports System.Data.SqlClient
Public Class F_HoaDon
    Dim Ket_Noi As SqlConnection
    Dim viTriHienTai As Integer = 0 ' Khai báo biến toàn cục

    Private Sub F_HoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Try
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter("SELECT MaHoaDon, MaKhachHang, NgayLap, TongTien,MaNhanVien FROM HOA_DON ORDER BY MaHoaDon", Ket_Noi)
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
                Data_DS.Columns("MaHoaDon").HeaderText = "Mã Hóa Đơn"
                Data_DS.Columns("MaKhachHang").HeaderText = "Mã Khách Hàng"
                Data_DS.Columns("NgayLap").HeaderText = "Ngày Lập"
                Data_DS.Columns("TongTien").HeaderText = "Tổng Tiền"
                Data_DS.Columns("MaNhanVien").HeaderText = "Mã Nhân Viên"

                ' Định dạng cột 
                Data_DS.Columns("TongTien").DefaultCellStyle.Format = "N0"
                Data_DS.Columns("TongTien").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Data_DS.Columns("NgayLap").DefaultCellStyle.Format = "dd/MM/yyyy"
                Data_DS.Columns("STT").ReadOnly = True
            End If

            ' Hiển thị tổng số hóa đơn (giả sử bạn có label tên lblTongSo)
            Try
                If Me.Controls.ContainsKey("lblTongSo") Then
                    Dim lblTongSo As Label = DirectCast(Me.Controls("lblTongSo"), Label)
                    lblTongSo.Text = "Tổng số hóa đơn: " & dt.Rows.Count.ToString()
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
                TxtMAHD.Text = If(row.Cells("MaHoaDon").Value IsNot Nothing, row.Cells("MaHoaDon").Value.ToString(), "")
                TxtMAKH.Text = If(row.Cells("MaKhachHang").Value IsNot Nothing, row.Cells("MaKhachHang").Value.ToString(), "")

                ' Xử lý ngày lập
                If row.Cells("NgayLap").Value IsNot Nothing AndAlso row.Cells("NgayLap").Value IsNot DBNull.Value Then
                    Dim ngayLap As DateTime = Convert.ToDateTime(row.Cells("NgayLap").Value)
                    dtpNgayLap.Value = ngayLap
                Else
                    dtpNgayLap.Value = DateTime.Now
                End If

                TxtTongTien.Text = If(row.Cells("TongTien").Value IsNot Nothing, row.Cells("TongTien").Value.ToString(), "0")
                TxtMNV.Text = If(row.Cells("MaNhanVien").Value IsNot Nothing, row.Cells("MaNhanVien").Value.ToString(), "0")
                ' Hiển thị vị trí hiện tại (giả sử bạn có label tên lblViTri)
                Try
                    If Me.Controls.ContainsKey("lblViTri") Then
                        Dim lblViTri As Label = DirectCast(Me.Controls("lblViTri"), Label)
                        lblViTri.Text = "Hóa đơn: " & (viTri + 1).ToString() & "/" & Data_DS.Rows.Count.ToString()
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
        TxtMAHD.Clear()
        TxtMAKH.Clear()
        dtpNgayLap.Value = DateTime.Now
        TxtTongTien.Clear()
        TxtMNV.clear()
        TxtMAHD.Focus()

    End Sub

    ' Kiểm tra mã khách hàng có tồn tại không
    Private Function KiemTraMaKhachHang(maKH As String) As Boolean
        Try
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            Dim query As String = "SELECT COUNT(*) FROM KHACH_HANG WHERE MaKhachHang = @MaKH"
            Dim cmd As New SqlCommand(query, Ket_Noi)
            cmd.Parameters.AddWithValue("@MaKH", maKH)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MsgBox("Lỗi kiểm tra mã khách hàng: " & ex.Message, vbCritical, "Lỗi")
            Return False
        End Try
    End Function

    Private Sub THEM_Click(sender As Object, e As EventArgs) Handles THEM.Click
        ' Kiểm tra dữ liệu trước khi thêm
        If TxtMAHD.Text.Trim() = "" Then
            MsgBox("Mã hóa đơn không được để trống", vbExclamation, "Chú ý")
            TxtMAHD.Focus()
            Exit Sub
        End If

        If TxtMAKH.Text.Trim() = "" Then
            MsgBox("Mã khách hàng không được để trống", vbExclamation, "Chú ý")
            TxtMAKH.Focus()
            Exit Sub
        End If

        ' Kiểm tra mã khách hàng có tồn tại không
        If Not KiemTraMaKhachHang(TxtMAKH.Text.Trim()) Then
            MsgBox("Mã khách hàng không tồn tại trong hệ thống", vbExclamation, "Chú ý")
            TxtMAKH.Focus()
            Exit Sub
        End If

        ' Kiểm tra tổng tiền
        Dim tongTien As Decimal = 0
        If Not Decimal.TryParse(TxtTongTien.Text.Trim(), tongTien) OrElse tongTien < 0 Then
            MsgBox("Tổng tiền không hợp lệ", vbExclamation, "Chú ý")
            TxtTongTien.Focus()
            Exit Sub
        End If

        Try
            ' Kiểm tra trùng mã hóa đơn
            Dim SQL_KiemTra As New SqlDataAdapter("SELECT * FROM HOA_DON WHERE MaHoaDon=@MaHD", Ket_Noi)
            SQL_KiemTra.SelectCommand.Parameters.AddWithValue("@MaHD", TxtMAHD.Text.Trim())
            Dim Db_Check As New DataTable
            SQL_KiemTra.Fill(Db_Check)

            If Db_Check.Rows.Count > 0 Then
                MsgBox("Mã hóa đơn này đã tồn tại!", vbExclamation, "Thông báo")
                TxtMAHD.Focus()
                Exit Sub
            End If

            ' Kiểm tra và mở kết nối nếu chưa mở
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            ' Lệnh INSERT:
            Dim SQL_DangKy As New SqlCommand("INSERT INTO HOA_DON (MaHoaDon, MaKhachHang, NgayLap, TongTien,MaNhanVien) VALUES (@MaHD, @MaKH, @NgayLap, @TongTien,@MaNhanVien)", Ket_Noi)
            SQL_DangKy.Parameters.AddWithValue("@MaHD", TxtMAHD.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@MaKH", TxtMAKH.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value.Date)
            SQL_DangKy.Parameters.AddWithValue("@TongTien", tongTien)
            SQL_DangKy.Parameters.AddWithValue("@MaNhanVien", TxtMNV.Text.Trim())

            SQL_DangKy.ExecuteNonQuery()
            MsgBox("Thêm hóa đơn thành công!", vbInformation, "Thông báo")

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
        If TxtMAHD.Text.Trim() = "" Then
            MsgBox("Vui lòng chọn hóa đơn cần sửa từ danh sách", vbExclamation, "Thông báo")
            Exit Sub
        End If

        If TxtMAKH.Text.Trim() = "" Then
            MsgBox("Mã khách hàng không được để trống", vbExclamation, "Chú ý")
            TxtMAKH.Focus()
            Exit Sub
        End If

        ' Kiểm tra mã khách hàng có tồn tại không
        If Not KiemTraMaKhachHang(TxtMAKH.Text.Trim()) Then
            MsgBox("Mã khách hàng không tồn tại trong hệ thống", vbExclamation, "Chú ý")
            TxtMAKH.Focus()
            Exit Sub
        End If

        ' Kiểm tra tổng tiền
        Dim tongTien As Decimal = 0
        If Not Decimal.TryParse(TxtTongTien.Text.Trim(), tongTien) OrElse tongTien < 0 Then
            MsgBox("Tổng tiền không hợp lệ", vbExclamation, "Chú ý")
            TxtTongTien.Focus()
            Exit Sub
        End If

        Try
            ' Kiểm tra và mở kết nối nếu chưa mở
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            Dim Sql As String = "UPDATE HOA_DON SET MaKhachHang=@MaKH, NgayLap=@NgayLap, TongTien=@TongTien,MaNhanVien=@MaNhanVien WHERE MaHoaDon=@MaHD"
            Using Cmd As New SqlCommand(Sql, Ket_Noi)
                Cmd.Parameters.AddWithValue("@MaHD", TxtMAHD.Text.Trim())
                Cmd.Parameters.AddWithValue("@MaKH", TxtMAKH.Text.Trim())
                Cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value.Date)
                Cmd.Parameters.AddWithValue("@TongTien", tongTien)
                Cmd.Parameters.AddWithValue("@MaNhanVien", TxtMNV.Text.Trim())

                Dim result As Integer = Cmd.ExecuteNonQuery()

                If result > 0 Then
                    MsgBox("Cập nhật thành công!", vbInformation, "Thông báo")
                    Load_dulieu() ' Làm mới DataGridView
                    XoaDuLieuForm()
                Else
                    MsgBox("Không thể cập nhật, mã hóa đơn không tồn tại!", vbExclamation, "Lỗi")
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
        Dim maHoaDon As String = InputBox("Nhập mã hóa đơn cần tìm:", "Tìm Kiếm Hóa Đơn")

        If maHoaDon.Trim() = "" Then
            MessageBox.Show("Bạn chưa nhập mã hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Tìm hóa đơn trong database
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            Dim query As String = "SELECT * FROM HOA_DON WHERE MaHoaDon = @MaHD"
            Dim command As New SqlCommand(query, Ket_Noi)
            command.Parameters.AddWithValue("@MaHD", maHoaDon.Trim())

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                ' Hiển thị lên TextBox
                TxtMAHD.Text = table.Rows(0)("MaHoaDon").ToString()
                TxtMAKH.Text = If(table.Rows(0)("MaKhachHang") IsNot DBNull.Value, table.Rows(0)("MaKhachHang").ToString(), "")

                If table.Rows(0)("NgayLap") IsNot DBNull.Value Then
                    dtpNgayLap.Value = Convert.ToDateTime(table.Rows(0)("NgayLap"))
                End If

                TxtTongTien.Text = If(table.Rows(0)("TongTien") IsNot DBNull.Value, table.Rows(0)("TongTien").ToString(), "0")
                TxtMNV.Text = If(table.Rows(0)("MaNhanVien") IsNot DBNull.Value, table.Rows(0)("MaNhanVien").ToString(), "0")
                ' Đánh dấu dòng trong DataGridView
                For i As Integer = 0 To Data_DS.Rows.Count - 1
                    If Data_DS.Rows(i).Cells("MaHoaDon").Value.ToString() = maHoaDon.Trim() Then
                        viTriHienTai = i
                        CapNhatDataGridView()
                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("Không tìm thấy hóa đơn có mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If TxtMAHD.Text.Trim() = "" Then
            MessageBox.Show("Vui lòng chọn hóa đơn cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim maHoaDon As String = TxtMAHD.Text.Trim()

        ' Xác nhận xóa
        If MessageBox.Show("Bạn có chắc muốn xóa hóa đơn '" & maHoaDon & "'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                If Ket_Noi.State = ConnectionState.Closed Then
                    Ket_Noi.Open()
                End If

                ' Xóa chi tiết hóa đơn trước (nếu có)
                Dim queryChiTiet As String = "DELETE FROM CHI_TIET_HOA_DON WHERE MaHoaDon = @MaHD"
                Dim commandChiTiet As New SqlCommand(queryChiTiet, Ket_Noi)
                commandChiTiet.Parameters.AddWithValue("@MaHD", maHoaDon)
                commandChiTiet.ExecuteNonQuery()

                ' Xóa hóa đơn
                Dim query As String = "DELETE FROM HOA_DON WHERE MaHoaDon = @MaHD"
                Dim command As New SqlCommand(query, Ket_Noi)
                command.Parameters.AddWithValue("@MaHD", maHoaDon)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_dulieu() ' Cập nhật lại danh sách
                    XoaDuLieuForm()
                Else
                    MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        If MessageBox.Show("Bạn có chắc muốn thoát khỏi form Quản lý Hóa đơn?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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
        If TxtMAHD.Text.Trim() = "" Then
            MsgBox("Vui lòng chọn hóa đơn cần lưu", vbExclamation, "Thông báo")
            Exit Sub
        End If

        If TxtMAKH.Text.Trim() = "" Then
            MsgBox("Mã khách hàng không được để trống", vbExclamation, "Chú ý")
            TxtMAKH.Focus()
            Exit Sub
        End If

        ' Kiểm tra mã khách hàng có tồn tại không
        If Not KiemTraMaKhachHang(TxtMAKH.Text.Trim()) Then
            MsgBox("Mã khách hàng không tồn tại trong hệ thống", vbExclamation, "Chú ý")
            TxtMAKH.Focus()
            Exit Sub
        End If

        ' Kiểm tra tổng tiền hợp lệ
        Dim tongTien As Decimal = 0
        If Not Decimal.TryParse(TxtTongTien.Text.Trim(), tongTien) OrElse tongTien < 0 Then
            MsgBox("Tổng tiền không hợp lệ", vbExclamation, "Chú ý")
            TxtTongTien.Focus()
            Exit Sub
        End If

        Try
            ' Kiểm tra và mở kết nối nếu chưa mở
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            ' Câu lệnh UPDATE hóa đơn
            Dim sql As String = "UPDATE HOA_DON SET MaKhachHang=@MaKH, NgayLap=@NgayLap, TongTien=@TongTien,MaNhanVien=@MaNhanVien WHERE MaHoaDon=@MaHD"

            Using cmd As New SqlCommand(sql, Ket_Noi)
                cmd.Parameters.AddWithValue("@MaHD", TxtMAHD.Text.Trim())
                cmd.Parameters.AddWithValue("@MaKH", TxtMAKH.Text.Trim())
                cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value.Date)
                cmd.Parameters.AddWithValue("@TongTien", tongTien)
                cmd.Parameters.AddWithValue("@MaNhanVien", TxtMNV.Text.Trim())

                ' Thực thi câu lệnh UPDATE
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Lưu thành công!", vbInformation, "Thông báo")
                    Load_dulieu()
                    XoaDuLieuForm()
                Else
                    MsgBox("Không thể lưu! Mã hóa đơn không tồn tại.", vbExclamation, "Lỗi")
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


End Class