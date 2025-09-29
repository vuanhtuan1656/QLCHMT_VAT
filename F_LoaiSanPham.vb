Imports System.Data.SqlClient
Public Class F_LoaiSanPham
    Dim Ket_Noi As SqlConnection
    Dim viTriHienTai As Integer = 0 ' Khai báo biến toàn cục

    Private Sub F_LoaiSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Ket_Noi = New SqlConnection("Data Source=DESKTOP-V0AMEPA;Initial Catalog=QL_CUAHANGMAYTINH;Integrated Security=True;TrustServerCertificate=True")
            Ket_Noi.Open()

            ' Load danh sách loại sản phẩm vào ComboBox
            LoadComboBoxMaLoai()
            Load_dulieu()

            viTriHienTai = 0
            CapNhatDataGridView()

        Catch ex As Exception
            MsgBox("Lỗi kết nối:  " & ex.Message, vbCritical, "Lỗi")
        End Try
    End Sub

    ' Load dữ liệu loại sản phẩm vào ComboBox
    Private Sub LoadComboBoxMaLoai()
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
            Dim da As New SqlDataAdapter("SELECT MaLoai, TenLoai, MoTa FROM LOAI_SAN_PHAM ORDER BY MaLoai", Ket_Noi)
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
                Data_DS.Columns("MaLoai").HeaderText = "Mã Loại"
                Data_DS.Columns("MaLoai").Width = 100
                Data_DS.Columns("TenLoai").HeaderText = "Tên Loại"
                Data_DS.Columns("TenLoai").Width = 200
                Data_DS.Columns("MoTa").HeaderText = "Mô Tả"
                Data_DS.Columns("MoTa").Width = 300

                ' Định dạng cột
                Data_DS.Columns("STT").ReadOnly = True
            End If

            ' Hiển thị tổng số loại sản phẩm (giả sử bạn có label tên lblTongSo)
            Try
                If Me.Controls.ContainsKey("lblTongSo") Then
                    Dim lblTongSo As Label = DirectCast(Me.Controls("lblTongSo"), Label)
                    lblTongSo.Text = "Tổng số loại sản phẩm: " & dt.Rows.Count.ToString()
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

    ' Hiển thị thông tin lên các control
    Private Sub HienThiThongTin(viTri As Integer)
        Try
            If Data_DS.Rows.Count > 0 AndAlso viTri >= 0 AndAlso viTri < Data_DS.Rows.Count Then
                Dim row As DataGridViewRow = Data_DS.Rows(viTri)

                ' Chọn item trong ComboBox MaLoai
                Dim maLoai As String = If(row.Cells("MaLoai").Value IsNot Nothing, row.Cells("MaLoai").Value.ToString(), "")
                If cboMaLoai.Items.Contains(maLoai) Then
                    cboMaLoai.SelectedItem = maLoai
                Else
                    cboMaLoai.SelectedIndex = -1
                End If

                TxtTenLoai.Text = If(row.Cells("TenLoai").Value IsNot Nothing, row.Cells("TenLoai").Value.ToString(), "")
                TxtMoTa.Text = If(row.Cells("MoTa").Value IsNot Nothing, row.Cells("MoTa").Value.ToString(), "")

                ' Hiển thị vị trí hiện tại (giả sử bạn có label tên lblViTri)
                Try
                    If Me.Controls.ContainsKey("lblViTri") Then
                        Dim lblViTri As Label = DirectCast(Me.Controls("lblViTri"), Label)
                        lblViTri.Text = "Loại SP: " & (viTri + 1).ToString() & "/" & Data_DS.Rows.Count.ToString()
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
        cboMaLoai.SelectedIndex = -1
        TxtTenLoai.Clear()
        TxtMoTa.Clear()
        cboMaLoai.Focus()
    End Sub

    ' Kiểm tra dữ liệu hợp lệ
    Private Function KiemTraDuLieu() As Boolean
        If cboMaLoai.SelectedIndex = -1 Then
            MsgBox("Vui lòng chọn mã loại", vbExclamation, "Chú ý")
            cboMaLoai.Focus()
            Return False
        End If

        If TxtTenLoai.Text.Trim() = "" Then
            MsgBox("Tên loại không được để trống", vbExclamation, "Chú ý")
            TxtTenLoai.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub THEM_Click(sender As Object, e As EventArgs) Handles THEM.Click
        ' Kiểm tra dữ liệu trước khi thêm
        If Not KiemTraDuLieu() Then Exit Sub

        Try
            ' Kiểm tra trùng mã loại
            Dim SQL_KiemTra As New SqlDataAdapter("SELECT * FROM LOAI_SAN_PHAM WHERE MaLoai=@MaLoai", Ket_Noi)
            SQL_KiemTra.SelectCommand.Parameters.AddWithValue("@MaLoai", cboMaLoai.SelectedItem.ToString())
            Dim Db_Check As New DataTable
            SQL_KiemTra.Fill(Db_Check)

            If Db_Check.Rows.Count > 0 Then
                MsgBox("Mã loại này đã tồn tại!", vbExclamation, "Thông báo")
                cboMaLoai.Focus()
                Exit Sub
            End If

            ' Kiểm tra và mở kết nối nếu chưa mở
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            ' Lệnh INSERT:
            Dim SQL_DangKy As New SqlCommand("INSERT INTO LOAI_SAN_PHAM (MaLoai, TenLoai, MoTa) VALUES (@MaLoai, @TenLoai, @MoTa)", Ket_Noi)
            SQL_DangKy.Parameters.AddWithValue("@MaLoai", cboMaLoai.SelectedItem.ToString())
            SQL_DangKy.Parameters.AddWithValue("@TenLoai", TxtTenLoai.Text.Trim())
            SQL_DangKy.Parameters.AddWithValue("@MoTa", If(TxtMoTa.Text.Trim() = "", DBNull.Value, TxtMoTa.Text.Trim()))

            SQL_DangKy.ExecuteNonQuery()
            MsgBox("Thêm loại sản phẩm thành công!", vbInformation, "Thông báo")

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
        If cboMaLoai.SelectedIndex = -1 Then
            MsgBox("Vui lòng chọn loại sản phẩm cần sửa từ danh sách", vbExclamation, "Thông báo")
            Exit Sub
        End If

        ' Kiểm tra dữ liệu
        If Not KiemTraDuLieu() Then Exit Sub

        Try
            ' Kiểm tra và mở kết nối nếu chưa mở
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            Dim Sql As String = "UPDATE LOAI_SAN_PHAM SET TenLoai=@TenLoai, MoTa=@MoTa WHERE MaLoai=@MaLoai"
            Using Cmd As New SqlCommand(Sql, Ket_Noi)
                Cmd.Parameters.AddWithValue("@MaLoai", cboMaLoai.SelectedItem.ToString())
                Cmd.Parameters.AddWithValue("@TenLoai", TxtTenLoai.Text.Trim())
                Cmd.Parameters.AddWithValue("@MoTa", If(TxtMoTa.Text.Trim() = "", DBNull.Value, TxtMoTa.Text.Trim()))

                Dim result As Integer = Cmd.ExecuteNonQuery()

                If result > 0 Then
                    MsgBox("Cập nhật thành công!", vbInformation, "Thông báo")
                    Load_dulieu() ' Làm mới DataGridView
                    XoaDuLieuForm()
                Else
                    MsgBox("Không thể cập nhật, mã loại không tồn tại!", vbExclamation, "Lỗi")
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
        Dim maLoai As String = InputBox("Nhập mã loại cần tìm:", "Tìm Kiếm Loại Sản Phẩm")

        If maLoai.Trim() = "" Then
            MessageBox.Show("Bạn chưa nhập mã loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Tìm loại sản phẩm trong database
            If Ket_Noi.State = ConnectionState.Closed Then
                Ket_Noi.Open()
            End If

            Dim query As String = "SELECT * FROM LOAI_SAN_PHAM WHERE MaLoai = @MaLoai"
            Dim command As New SqlCommand(query, Ket_Noi)
            command.Parameters.AddWithValue("@MaLoai", maLoai.Trim())

            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count > 0 Then
                ' Hiển thị lên các control
                Dim loaiSP As String = table.Rows(0)("MaLoai").ToString()
                If cboMaLoai.Items.Contains(loaiSP) Then
                    cboMaLoai.SelectedItem = loaiSP
                Else
                    cboMaLoai.SelectedIndex = -1
                End If

                TxtTenLoai.Text = If(table.Rows(0)("TenLoai") IsNot DBNull.Value, table.Rows(0)("TenLoai").ToString(), "")
                TxtMoTa.Text = If(table.Rows(0)("MoTa") IsNot DBNull.Value, table.Rows(0)("MoTa").ToString(), "")

                ' Đánh dấu dòng trong DataGridView
                For i As Integer = 0 To Data_DS.Rows.Count - 1
                    If Data_DS.Rows(i).Cells("MaLoai").Value.ToString() = maLoai.Trim() Then
                        viTriHienTai = i
                        CapNhatDataGridView()
                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("Không tìm thấy loại sản phẩm có mã này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        If cboMaLoai.SelectedIndex = -1 Then
            MessageBox.Show("Vui lòng chọn loại sản phẩm cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim maLoai As String = cboMaLoai.SelectedItem.ToString()

        ' Xác nhận xóa
        If MessageBox.Show("Bạn có chắc muốn xóa loại sản phẩm '" & maLoai & "'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                If Ket_Noi.State = ConnectionState.Closed Then
                    Ket_Noi.Open()
                End If

                ' Kiểm tra xem có sản phẩm nào đang sử dụng loại này không
                Dim checkQuery As String = "SELECT COUNT(*) FROM SAN_PHAM WHERE MaLoai = @MaLoai"
                Dim checkCmd As New SqlCommand(checkQuery, Ket_Noi)
                checkCmd.Parameters.AddWithValue("@MaLoai", maLoai)

                Dim productCount As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If productCount > 0 Then
                    MessageBox.Show("Không thể xóa loại sản phẩm này vì đang có " & productCount.ToString() & " sản phẩm thuộc loại này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ' Xóa loại sản phẩm
                Dim query As String = "DELETE FROM LOAI_SAN_PHAM WHERE MaLoai = @MaLoai"
                Dim command As New SqlCommand(query, Ket_Noi)
                command.Parameters.AddWithValue("@MaLoai", maLoai)

                Dim rowsAffected As Integer = command.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Load_dulieu() ' Cập nhật lại danh sách
                    XoaDuLieuForm()
                Else
                    MessageBox.Show("Không tìm thấy loại sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        If MessageBox.Show("Bạn có chắc muốn thoát khỏi form Quản lý Loại Sản Phẩm?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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
        If cboMaLoai.SelectedIndex = -1 Then
            MsgBox("Vui lòng chọn loại sản phẩm cần lưu", vbExclamation, "Thông báo")
            Exit Sub
        End If

    End Sub
End Class