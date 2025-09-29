Imports System.Data.SqlClient
Public Class F_KhachHang
    Dim Ket_Noi As SqlConnection
    Dim viTriHienTai As Integer = 0 ' Khai báo biến toàn cục

    Private Sub F_KhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Ket_Noi = New SqlConnection("Data Source=DESKTOP-V0AMEPA;Initial Catalog=QL_CUAHANGMAYTINH;Integrated Security=True;TrustServerCertificate=True")
            Ket_Noi.Open()

            ' Hiển thị dữ liệu từ bảng KHACHHANG lên DataGridView:
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
            Dim da As New SqlDataAdapter("SELECT MaKhachHang, HoTen, SoDienThoai, Email, DiaChi FROM KHACH_HANG ORDER BY MaKhachHang", Ket_Noi)
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
                Data_DS.Columns("MaKhachHang").HeaderText = "Mã KH"
                Data_DS.Columns("HoTen").HeaderText = "Họ Tên"
                Data_DS.Columns("SoDienThoai").HeaderText = "Điện Thoại"
                Data_DS.Columns("Email").HeaderText = "Email"
                Data_DS.Columns("DiaChi").HeaderText = "Địa Chỉ"

                ' Không cho phép chỉnh sửa cột STT
                Data_DS.Columns("STT").ReadOnly = True
            End If

            ' Hiển thị tổng số khách hàng (giả sử bạn có label tên lblTongSo)
            Try
                If Me.Controls.ContainsKey("lblTongSo") Then
                    Dim lblTongSo As Label = DirectCast(Me.Controls("lblTongSo"), Label)
                    lblTongSo.Text = "Tổng số khách hàng: " & dt.Rows.Count.ToString()
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
                TxtMAKH.Text = If(row.Cells("MaKhachHang").Value IsNot Nothing, row.Cells("MaKhachHang").Value.ToString(), "")
                TxtHT.Text = If(row.Cells("HoTen").Value IsNot Nothing, row.Cells("HoTen").Value.ToString(), "")
                TxtDT.Text = If(row.Cells("SoDienThoai").Value IsNot Nothing, row.Cells("SoDienThoai").Value.ToString(), "")
                TxtEmail.Text = If(row.Cells("Email").Value IsNot Nothing, row.Cells("Email").Value.ToString(), "")
                TxtDC.Text = If(row.Cells("DiaChi").Value IsNot Nothing, row.Cells("DiaChi").Value.ToString(), "")

                ' Hiển thị vị trí hiện tại (giả sử bạn có label tên lblViTri)
                Try
                    If Me.Controls.ContainsKey("lblViTri") Then
                        Dim lblViTri As Label = DirectCast(Me.Controls("lblViTri"), Label)
                        lblViTri.Text = "Khách hàng: " & (viTri + 1).ToString() & "/" & Data_DS.Rows.Count.ToString()
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
        TxtMAKH.Clear()
        TxtHT.Clear()
        TxtDT.Clear()
        TxtEmail.Clear()
        TxtDC.Clear()
        TxtMAKH.Focus()
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
        ' Kiểm tra dữ liệu trước khi thêm
        If TxtMAKH.Text.Trim() = "" Then
            MsgBox("Mã khách hàng không được để trống", vbExclamation, "Chú ý")
            TxtMAKH.Focus()
            Exit Sub
        End If

        If TxtHT.Text.Trim() = "" Then
            MsgBox("Họ tên không được để trống", vbExclamation, "Chú ý")
            TxtHT.Focus()
            Exit Sub
        End If

        ' Kiểm tra email nếu có nhập
        If TxtEmail.Text.Trim() <> "" AndAlso Not KiemTraEmail(TxtEmail.Text.Trim()) Then
            MsgBox("Email không hợp lệ", vbExclamation, "Chú ý")
            TxtEmail.Focus()
            Exit Sub
        End If

        Try
            ' Kiểm tra trùng mã khách hàng
            Dim SQL_KiemTra As New SqlDataAdapter("SELECT * FROM KHACH_HANG WHERE MaKhachHang=@MaKH", Ket_Noi)
            SQL_KiemTra.SelectCommand.Parameters.AddWithValue("@MaKH", TxtMAKH.Text.Trim())
            Dim Db_Check As New DataTable
            SQL_KiemTra.Fill(Db_Check)

            If Db_Check.Rows.Count > 0 Then
                MsgBox("Mã khách hàng này đã tồn tại!", vbExclamation, "Thông báo")
                TxtMAKH.Focus()
                Exit Sub
            End If

            ' Kiểm tra và mở kết nối nếu chưa mở
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            ' Lệnh INSERT:
            Dim SQL_DangKy As New SqlCommand("INSERT INTO KHACH_HANG (MaKhachHang, HoTen, SoDienThoai, Email, DiaChi) VALUES (@MaKH, @HoTen, @SoDienThoai, @Email, @DiaChi)", Ket_Noi)
            SQL_DangKy.Parameters.AddWithValue("@MaKH", TxtMAKH.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@HoTen", TxtHT.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@SoDienThoai", If(TxtDT.Text.Trim() = "", DBNull.Value, TxtDT.Text.Trim()))
            SQL_DangKy.Parameters.AddWithValue("@Email", If(TxtEmail.Text.Trim() = "", DBNull.Value, TxtEmail.Text.Trim()))
            SQL_DangKy.Parameters.AddWithValue("@DiaChi", If(TxtDC.Text.Trim() = "", DBNull.Value, TxtDC.Text.Trim()))

            SQL_DangKy.ExecuteNonQuery()
            MsgBox("Thêm khách hàng thành công!", vbInformation, "Thông báo")

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
        If TxtMAKH.Text.Trim() = "" Then
            MsgBox("Vui lòng chọn khách hàng cần sửa từ danh sách", vbExclamation, "Thông báo")
            Exit Sub
        End If

        If TxtHT.Text.Trim() = "" Then
            MsgBox("Họ tên không được để trống", vbExclamation, "Chú ý")
            TxtHT.Focus()
            Exit Sub
        End If

        ' Kiểm tra email nếu có nhập
        If TxtEmail.Text.Trim() <> "" AndAlso Not KiemTraEmail(TxtEmail.Text.Trim()) Then
            MsgBox("Email không hợp lệ", vbExclamation, "Chú ý")
            TxtEmail.Focus()
            Exit Sub
        End If

        Try
            ' Kiểm tra và mở kết nối nếu chưa mở
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            Dim Sql As String = "UPDATE KHACH_HANG SET HoTen=@HoTen, SoDienThoai=@SoDienThoai, Email=@Email, DiaChi=@DiaChi WHERE MaKhachHang=@MaKH"
            Using Cmd As New SqlCommand(Sql, Ket_Noi)
                Cmd.Parameters.AddWithValue("@MaKH", TxtMAKH.Text.Trim())
                Cmd.Parameters.AddWithValue("@HoTen", TxtHT.Text.Trim())
                Cmd.Parameters.AddWithValue("@SoDienThoai", If(TxtDT.Text.Trim() = "", DBNull.Value, TxtDT.Text.Trim()))
                Cmd.Parameters.AddWithValue("@Email", If(TxtEmail.Text.Trim() = "", DBNull.Value, TxtEmail.Text.Trim()))
                Cmd.Parameters.AddWithValue("@DiaChi", If(TxtDC.Text.Trim() = "", DBNull.Value, TxtDC.Text.Trim()))

                Dim result As Integer = Cmd.ExecuteNonQuery()

                If result > 0 Then
                    MsgBox("Cập nhật thành công!", vbInformation, "Thông báo")
                    Load_dulieu() ' Làm mới DataGridView
                    XoaDuLieuForm()
                Else
                    MsgBox("Không thể cập nhật, mã khách hàng không tồn tại!", vbExclamation, "Lỗi")
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
        Dim maKhachHang As String = InputBox("Nhập mã khách hàng cần tìm:", "Tìm Kiếm Khách Hàng")

        If maKhachHang.Trim() = "" Then
            MessageBox.Show("Bạn chưa nhập mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Tìm khách hàng trong database
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            Dim query As String = "SELECT * FROM KHACH_HANG WHERE MaKhachHang = @MaKH"
            Dim command As New SqlCommand(query, Ket_Noi)
            command.Parameters.AddWithValue("@MaKH", maKhachHang.Trim())

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                ' Hiển thị lên TextBox
                TxtMAKH.Text = table.Rows(0)("MaKhachHang").ToString()
                TxtHT.Text = If(table.Rows(0)("HoTen") IsNot DBNull.Value, table.Rows(0)("HoTen").ToString(), "")
                TxtDT.Text = If(table.Rows(0)("SoDienThoai") IsNot DBNull.Value, table.Rows(0)("SoDienThoai").ToString(), "")
                TxtEmail.Text = If(table.Rows(0)("Email") IsNot DBNull.Value, table.Rows(0)("Email").ToString(), "")
                TxtDC.Text = If(table.Rows(0)("DiaChi") IsNot DBNull.Value, table.Rows(0)("DiaChi").ToString(), "")

                ' Đánh dấu dòng trong DataGridView
                For i As Integer = 0 To Data_DS.Rows.Count - 1
                    If Data_DS.Rows(i).Cells("MaKhachHang").Value.ToString() = maKhachHang.Trim() Then
                        viTriHienTai = i
                        CapNhatDataGridView()
                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("Không tìm thấy khách hàng có mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If TxtMAKH.Text.Trim() = "" Then
            MessageBox.Show("Vui lòng chọn khách hàng cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim maKhachHang As String = TxtMAKH.Text.Trim()

        ' Xác nhận xóa
        If MessageBox.Show("Bạn có chắc muốn xóa khách hàng '" & TxtHT.Text & "'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                If Ket_Noi.State = ConnectionState.Closed Then
                    Ket_Noi.Open()
                End If

                Dim query As String = "DELETE FROM KHACH_HANG WHERE MaKhachHang = @MaKH"
                Dim command As New SqlCommand(query, Ket_Noi)
                command.Parameters.AddWithValue("@MaKH", maKhachHang)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_dulieu() ' Cập nhật lại danh sách
                    XoaDuLieuForm()
                Else
                    MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        ' Kiểm tra dữ liệu trước khi lưu
        If TxtMAKH.Text.Trim() = "" Then
            MsgBox("Vui lòng chọn khách hàng cần lưu", vbExclamation, "Thông báo")
            Exit Sub
        End If

        If TxtHT.Text.Trim() = "" Then
            MsgBox("Họ tên không được để trống", vbExclamation, "Chú ý")
            TxtHT.Focus()
            Exit Sub
        End If

        ' Kiểm tra email nếu có nhập
        If TxtEmail.Text.Trim() <> "" AndAlso Not KiemTraEmail(TxtEmail.Text.Trim()) Then
            MsgBox("Email không hợp lệ", vbExclamation, "Chú ý")
            TxtEmail.Focus()
            Exit Sub
        End If

        Try
            ' Kiểm tra và mở kết nối nếu chưa mở
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            ' Câu lệnh UPDATE khách hàng
            Dim sql As String = "UPDATE KHACH_HANG SET HoTen=@HoTen, SoDienThoai=@SoDienThoai, Email=@Email, DiaChi=@DiaChi WHERE MaKhachHang=@MaKH"

            Using cmd As New SqlCommand(sql, Ket_Noi)
                cmd.Parameters.AddWithValue("@MaKH", TxtMAKH.Text.Trim())
                cmd.Parameters.AddWithValue("@HoTen", TxtHT.Text.Trim())
                cmd.Parameters.AddWithValue("@SoDienThoai", If(TxtDT.Text.Trim() = "", DBNull.Value, TxtDT.Text.Trim()))
                cmd.Parameters.AddWithValue("@Email", If(TxtEmail.Text.Trim() = "", DBNull.Value, TxtEmail.Text.Trim()))
                cmd.Parameters.AddWithValue("@DiaChi", If(TxtDC.Text.Trim() = "", DBNull.Value, TxtDC.Text.Trim()))

                ' Thực thi câu lệnh UPDATE
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MsgBox("Lưu thành công!", vbInformation, "Thông báo")
                    Load_dulieu() ' Cập nhật lại danh sách
                    XoaDuLieuForm() ' Xóa dữ liệu trên form
                Else
                    MsgBox("Không thể lưu! Mã khách hàng không tồn tại.", vbExclamation, "Lỗi")
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