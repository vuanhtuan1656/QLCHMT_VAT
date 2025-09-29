Imports System.Data.SqlClient
Public Class F_BaoHanh
    Dim Ket_Noi As SqlConnection
    Dim viTriHienTai As Integer = 0 ' Khai báo biến toàn cục

    Private Sub F_BaoHanh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Ket_Noi = New SqlConnection("Data Source=DESKTOP-V0AMEPA;Initial Catalog=QL_CUAHANGMAYTINH;Integrated Security=True;TrustServerCertificate=True")
            Ket_Noi.Open()

            ' Hiển thị dữ liệu từ bảng BAO_HANH lên DataGridView:
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
            Dim da As New SqlDataAdapter("SELECT MaBaoHanh, MaSanPham, LoaiSanPham, MaKhachHang, NgayBatDau, NgayKetThuc, TrangThai FROM BAO_HANH ORDER BY MaBaoHanh", Ket_Noi)
            da.Fill(dt)

            ' Tạo cột STT
            Dim sttColumn As New DataColumn("STT", GetType(Integer))
            dt.Columns.Add(sttColumn)

            ' Thêm STT cho từng dòng
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("STT") = i + 1
            Next

            Data_DS.DataSource = dt

            ' Đưa cột STT lên đầu
            Data_DS.Columns("STT").DisplayIndex = 0

            ' Thiết lập tiêu đề cột cho DataGridView
            If Data_DS.Columns.Count > 0 Then
                Data_DS.Columns("STT").HeaderText = "STT"
                Data_DS.Columns("STT").Width = 50
                Data_DS.Columns("STT").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Data_DS.Columns("MaBaoHanh").HeaderText = "Mã Bảo Hành"
                Data_DS.Columns("MaSanPham").HeaderText = "Mã Sản Phẩm"
                Data_DS.Columns("LoaiSanPham").HeaderText = "Loại Sản Phẩm"
                Data_DS.Columns("MaKhachHang").HeaderText = "Mã Khách Hàng"
                Data_DS.Columns("NgayBatDau").HeaderText = "Ngày Bắt Đầu"
                Data_DS.Columns("NgayKetThuc").HeaderText = "Ngày Kết Thúc"
                Data_DS.Columns("TrangThai").HeaderText = "Trạng Thái"

                ' Không cho phép chỉnh sửa cột STT
                Data_DS.Columns("STT").ReadOnly = True

                ' Định dạng cột ngày tháng
                Data_DS.Columns("NgayBatDau").DefaultCellStyle.Format = "dd/MM/yyyy"
                Data_DS.Columns("NgayKetThuc").DefaultCellStyle.Format = "dd/MM/yyyy"
                Data_DS.Columns("TrangThai").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

            ' Hiển thị tổng số bảo hành (giả sử bạn có label tên lblTongSo)
            Try
                If Me.Controls.ContainsKey("lblTongSo") Then
                    Dim lblTongSo As Label = DirectCast(Me.Controls("lblTongSo"), Label)
                    lblTongSo.Text = "Tổng số bảo hành: " & dt.Rows.Count.ToString()
                End If
            Catch
                ' Nếu không có label thì bỏ qua
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

                ' Hiển thị thông tin lên TextBox
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
                TxtMABH.Text = If(row.Cells("MaBaoHanh").Value IsNot Nothing, row.Cells("MaBaoHanh").Value.ToString(), "")
                TxtMASP.Text = If(row.Cells("MaSanPham").Value IsNot Nothing, row.Cells("MaSanPham").Value.ToString(), "")
                TxtLOAISP.Text = If(row.Cells("LoaiSanPham").Value IsNot Nothing, row.Cells("LoaiSanPham").Value.ToString(), "")
                TxtMAKH.Text = If(row.Cells("MaKhachHang").Value IsNot Nothing, row.Cells("MaKhachHang").Value.ToString(), "")

                ' Xử lý ngày tháng
                If row.Cells("NgayBatDau").Value IsNot Nothing AndAlso row.Cells("NgayBatDau").Value IsNot DBNull.Value Then
                    DtpNGAYBD.Value = Convert.ToDateTime(row.Cells("NgayBatDau").Value)
                Else
                    DtpNGAYBD.Value = DateTime.Now
                End If

                If row.Cells("NgayKetThuc").Value IsNot Nothing AndAlso row.Cells("NgayKetThuc").Value IsNot DBNull.Value Then
                    DtpNGAYKT.Value = Convert.ToDateTime(row.Cells("NgayKetThuc").Value)
                Else
                    DtpNGAYKT.Value = DateTime.Now.AddMonths(12) ' Mặc định 12 tháng
                End If

                TxtTRANGTHAI.Text = If(row.Cells("TrangThai").Value IsNot Nothing, row.Cells("TrangThai").Value.ToString(), "")

                ' Hiển thị vị trí hiện tại (giả sử bạn có label tên lblViTri)
                Try
                    If Me.Controls.ContainsKey("lblViTri") Then
                        Dim lblViTri As Label = DirectCast(Me.Controls("lblViTri"), Label)
                        lblViTri.Text = "Bảo hành: " & (viTri + 1).ToString() & "/" & Data_DS.Rows.Count.ToString()
                    End If
                Catch
                    ' Nếu không có label thì bỏ qua
                End Try
            End If
        Catch ex As Exception
            MsgBox("Lỗi hiển thị thông tin: " & ex.Message, vbCritical, "Lỗi")
        End Try
    End Sub

    ' Xóa dữ liệu trên form
    Private Sub XoaDuLieuForm()
        TxtMABH.Clear()
        TxtMASP.Clear()
        TxtLOAISP.Clear()
        TxtMAKH.Clear()
        DtpNGAYBD.Value = DateTime.Now
        DtpNGAYKT.Value = DateTime.Now.AddMonths(12)
        TxtTRANGTHAI.Clear()
        TxtMABH.Focus()
    End Sub

    ' Kiểm tra ngày hợp lệ
    Private Function KiemTraNgay() As Boolean
        If DtpNGAYKT.Value <= DtpNGAYBD.Value Then
            Return False
        End If
        Return True
    End Function

    Private Sub THEM_Click(sender As Object, e As EventArgs) Handles THEM.Click
        ' Kiểm tra dữ liệu trước khi thêm
        If TxtMABH.Text.Trim() = "" Then
            MsgBox("Mã bảo hành không được để trống", vbExclamation, "Chú ý")
            TxtMABH.Focus()
            Exit Sub
        End If

        If TxtMASP.Text.Trim() = "" Then
            MsgBox("Mã sản phẩm không được để trống", vbExclamation, "Chú ý")
            TxtMASP.Focus()
            Exit Sub
        End If

        If TxtLOAISP.Text.Trim() = "" Then
            MsgBox("Loại sản phẩm không được để trống", vbExclamation, "Chú ý")
            TxtLOAISP.Focus()
            Exit Sub
        End If

        If TxtMAKH.Text.Trim() = "" Then
            MsgBox("Mã khách hàng không được để trống", vbExclamation, "Chú ý")
            TxtMAKH.Focus()
            Exit Sub
        End If

        If TxtTRANGTHAI.Text.Trim() = "" Then
            MsgBox("Trạng thái không được để trống", vbExclamation, "Chú ý")
            TxtTRANGTHAI.Focus()
            Exit Sub
        End If

        ' Kiểm tra ngày
        If Not KiemTraNgay() Then
            MsgBox("Ngày kết thúc phải sau ngày bắt đầu", vbExclamation, "Chú ý")
            DtpNGAYKT.Focus()
            Exit Sub
        End If

        Try
            ' Kiểm tra trùng mã bảo hành
            Dim SQL_KiemTra As New SqlDataAdapter("SELECT * FROM BAO_HANH WHERE MaBaoHanh=@MaBH", Ket_Noi)
            SQL_KiemTra.SelectCommand.Parameters.AddWithValue("@MaBH", TxtMABH.Text.Trim())
            Dim Db_Check As New DataTable
            SQL_KiemTra.Fill(Db_Check)

            If Db_Check.Rows.Count > 0 Then
                MsgBox("Mã bảo hành này đã tồn tại!", vbExclamation, "Thông báo")
                TxtMABH.Focus()
                Exit Sub
            End If

            ' Kiểm tra và mở kết nối nếu chưa mở
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            ' Lệnh INSERT:
            Dim SQL_DangKy As New SqlCommand("INSERT INTO BAO_HANH (MaBaoHanh, MaSanPham, LoaiSanPham, MaKhachHang, NgayBatDau, NgayKetThuc, TrangThai) VALUES (@MaBH, @MaSP, @LoaiSP, @MaKH, @NgayBD, @NgayKT, @TrangThai)", Ket_Noi)
            SQL_DangKy.Parameters.AddWithValue("@MaBH", TxtMABH.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@MaSP", TxtMASP.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@LoaiSP", TxtLOAISP.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@MaKH", TxtMAKH.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@NgayBD", DtpNGAYBD.Value.Date)
            SQL_DangKy.Parameters.AddWithValue("@NgayKT", DtpNGAYKT.Value.Date)
            SQL_DangKy.Parameters.AddWithValue("@TrangThai", TxtTRANGTHAI.Text.Trim())

            SQL_DangKy.ExecuteNonQuery()
            MsgBox("Thêm bảo hành thành công!", vbInformation, "Thông báo")

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
        If TxtMABH.Text.Trim() = "" Then
            MsgBox("Vui lòng chọn bảo hành cần sửa từ danh sách", vbExclamation, "Thông báo")
            Exit Sub
        End If

        If TxtMASP.Text.Trim() = "" Then
            MsgBox("Mã sản phẩm không được để trống", vbExclamation, "Chú ý")
            TxtMASP.Focus()
            Exit Sub
        End If

        If TxtLOAISP.Text.Trim() = "" Then
            MsgBox("Loại sản phẩm không được để trống", vbExclamation, "Chú ý")
            TxtLOAISP.Focus()
            Exit Sub
        End If

        If TxtMAKH.Text.Trim() = "" Then
            MsgBox("Mã khách hàng không được để trống", vbExclamation, "Chú ý")
            TxtMAKH.Focus()
            Exit Sub
        End If

        If TxtTRANGTHAI.Text.Trim() = "" Then
            MsgBox("Trạng thái không được để trống", vbExclamation, "Chú ý")
            TxtTRANGTHAI.Focus()
            Exit Sub
        End If

        ' Kiểm tra ngày
        If Not KiemTraNgay() Then
            MsgBox("Ngày kết thúc phải sau ngày bắt đầu", vbExclamation, "Chú ý")
            DtpNGAYKT.Focus()
            Exit Sub
        End If

        Try
            ' Kiểm tra và mở kết nối nếu chưa mở
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            Dim Sql As String = "UPDATE BAO_HANH SET MaSanPham=@MaSP, LoaiSanPham=@LoaiSP, MaKhachHang=@MaKH, NgayBatDau=@NgayBD, NgayKetThuc=@NgayKT, TrangThai=@TrangThai WHERE MaBaoHanh=@MaBH"
            Using Cmd As New SqlCommand(Sql, Ket_Noi)
                Cmd.Parameters.AddWithValue("@MaBH", TxtMABH.Text.Trim())
                Cmd.Parameters.AddWithValue("@MaSP", TxtMASP.Text.Trim())
                Cmd.Parameters.AddWithValue("@LoaiSP", TxtLOAISP.Text.Trim())
                Cmd.Parameters.AddWithValue("@MaKH", TxtMAKH.Text.Trim())
                Cmd.Parameters.AddWithValue("@NgayBD", DtpNGAYBD.Value.Date)
                Cmd.Parameters.AddWithValue("@NgayKT", DtpNGAYKT.Value.Date)
                Cmd.Parameters.AddWithValue("@TrangThai", TxtTRANGTHAI.Text.Trim())

                Dim result As Integer = Cmd.ExecuteNonQuery()

                If result > 0 Then
                    MsgBox("Cập nhật thành công!", vbInformation, "Thông báo")
                    Load_dulieu() ' Làm mới DataGridView
                    XoaDuLieuForm()
                Else
                    MsgBox("Không thể cập nhật, mã bảo hành không tồn tại!", vbExclamation, "Lỗi")
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
        Dim maBaoHanh As String = InputBox("Nhập mã bảo hành cần tìm:", "Tìm Kiếm Bảo Hành")

        If maBaoHanh.Trim() = "" Then
            MessageBox.Show("Bạn chưa nhập mã bảo hành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Tìm bảo hành trong database
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            Dim query As String = "SELECT * FROM BAO_HANH WHERE MaBaoHanh = @MaBH"
            Dim command As New SqlCommand(query, Ket_Noi)
            command.Parameters.AddWithValue("@MaBH", maBaoHanh.Trim())

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                ' Hiển thị lên TextBox
                TxtMABH.Text = table.Rows(0)("MaBaoHanh").ToString()
                TxtMASP.Text = If(table.Rows(0)("MaSanPham") IsNot DBNull.Value, table.Rows(0)("MaSanPham").ToString(), "")
                TxtLOAISP.Text = If(table.Rows(0)("LoaiSanPham") IsNot DBNull.Value, table.Rows(0)("LoaiSanPham").ToString(), "")
                TxtMAKH.Text = If(table.Rows(0)("MaKhachHang") IsNot DBNull.Value, table.Rows(0)("MaKhachHang").ToString(), "")

                If table.Rows(0)("NgayBatDau") IsNot DBNull.Value Then
                    DtpNGAYBD.Value = Convert.ToDateTime(table.Rows(0)("NgayBatDau"))
                End If

                If table.Rows(0)("NgayKetThuc") IsNot DBNull.Value Then
                    DtpNGAYKT.Value = Convert.ToDateTime(table.Rows(0)("NgayKetThuc"))
                End If

                TxtTRANGTHAI.Text = If(table.Rows(0)("TrangThai") IsNot DBNull.Value, table.Rows(0)("TrangThai").ToString(), "")

                ' Đánh dấu dòng trong DataGridView
                For i As Integer = 0 To Data_DS.Rows.Count - 1
                    If Data_DS.Rows(i).Cells("MaBaoHanh").Value.ToString() = maBaoHanh.Trim() Then
                        viTriHienTai = i
                        CapNhatDataGridView()
                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("Không tìm thấy bảo hành có mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If TxtMABH.Text.Trim() = "" Then
            MessageBox.Show("Vui lòng chọn bảo hành cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim maBaoHanh As String = TxtMABH.Text.Trim()

        ' Xác nhận xóa
        If MessageBox.Show("Bạn có chắc muốn xóa bảo hành '" & TxtMABH.Text & "'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                If Ket_Noi.State = ConnectionState.Closed Then
                    Ket_Noi.Open()
                End If

                Dim query As String = "DELETE FROM BAO_HANH WHERE MaBaoHanh = @MaBH"
                Dim command As New SqlCommand(query, Ket_Noi)
                command.Parameters.AddWithValue("@MaBH", maBaoHanh)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_dulieu() ' Cập nhật lại danh sách
                    XoaDuLieuForm()
                Else
                    MessageBox.Show("Không tìm thấy bảo hành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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




End Class