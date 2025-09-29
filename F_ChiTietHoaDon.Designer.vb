<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_ChiTietHoaDon
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_ChiTietHoaDon))
        Me.SUA = New System.Windows.Forms.Button()
        Me.Data_DS = New System.Windows.Forms.DataGridView()
        Me.TxtMaSanPham = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SAU = New System.Windows.Forms.Button()
        Me.TRUOC = New System.Windows.Forms.Button()
        Me.TxtSoLuong = New System.Windows.Forms.TextBox()
        Me.TxtMaHoaDon = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtMaChiTiet = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LUU = New System.Windows.Forms.Button()
        Me.THOAT = New System.Windows.Forms.Button()
        Me.XOA = New System.Windows.Forms.Button()
        Me.TKiem = New System.Windows.Forms.Button()
        Me.THEM = New System.Windows.Forms.Button()
        Me.CUOI = New System.Windows.Forms.Button()
        Me.DAU = New System.Windows.Forms.Button()
        Me.TxtGiaBan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtThanhTien = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtLoaiSanPham = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Data_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SUA
        '
        Me.SUA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SUA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUA.ForeColor = System.Drawing.SystemColors.Highlight
        Me.SUA.Location = New System.Drawing.Point(1136, 17)
        Me.SUA.Margin = New System.Windows.Forms.Padding(4)
        Me.SUA.Name = "SUA"
        Me.SUA.Size = New System.Drawing.Size(113, 47)
        Me.SUA.TabIndex = 109
        Me.SUA.Text = "Sửa"
        Me.SUA.UseVisualStyleBackColor = False
        '
        'Data_DS
        '
        Me.Data_DS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_DS.Location = New System.Drawing.Point(35, 300)
        Me.Data_DS.Name = "Data_DS"
        Me.Data_DS.RowHeadersWidth = 51
        Me.Data_DS.RowTemplate.Height = 24
        Me.Data_DS.Size = New System.Drawing.Size(1202, 307)
        Me.Data_DS.TabIndex = 108
        '
        'TxtMaSanPham
        '
        Me.TxtMaSanPham.Location = New System.Drawing.Point(199, 137)
        Me.TxtMaSanPham.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMaSanPham.Multiline = True
        Me.TxtMaSanPham.Name = "TxtMaSanPham"
        Me.TxtMaSanPham.Size = New System.Drawing.Size(241, 32)
        Me.TxtMaSanPham.TabIndex = 107
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(45, 137)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 20)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Mã sản phẩm:"
        '
        'SAU
        '
        Me.SAU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAU.ForeColor = System.Drawing.SystemColors.Highlight
        Me.SAU.Location = New System.Drawing.Point(775, 649)
        Me.SAU.Margin = New System.Windows.Forms.Padding(4)
        Me.SAU.Name = "SAU"
        Me.SAU.Size = New System.Drawing.Size(112, 47)
        Me.SAU.TabIndex = 105
        Me.SAU.Text = ">"
        Me.SAU.UseVisualStyleBackColor = True
        '
        'TRUOC
        '
        Me.TRUOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRUOC.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TRUOC.Location = New System.Drawing.Point(329, 651)
        Me.TRUOC.Margin = New System.Windows.Forms.Padding(4)
        Me.TRUOC.Name = "TRUOC"
        Me.TRUOC.Size = New System.Drawing.Size(111, 46)
        Me.TRUOC.TabIndex = 104
        Me.TRUOC.Text = "<"
        Me.TRUOC.UseVisualStyleBackColor = True
        '
        'TxtSoLuong
        '
        Me.TxtSoLuong.Location = New System.Drawing.Point(671, 32)
        Me.TxtSoLuong.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSoLuong.Multiline = True
        Me.TxtSoLuong.Name = "TxtSoLuong"
        Me.TxtSoLuong.Size = New System.Drawing.Size(241, 32)
        Me.TxtSoLuong.TabIndex = 103
        '
        'TxtMaHoaDon
        '
        Me.TxtMaHoaDon.Location = New System.Drawing.Point(199, 88)
        Me.TxtMaHoaDon.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMaHoaDon.Multiline = True
        Me.TxtMaHoaDon.Name = "TxtMaHoaDon"
        Me.TxtMaHoaDon.Size = New System.Drawing.Size(241, 32)
        Me.TxtMaHoaDon.TabIndex = 101
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(517, 32)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 20)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "Số lượng:"
        '
        'TxtMaChiTiet
        '
        Me.TxtMaChiTiet.Location = New System.Drawing.Point(199, 32)
        Me.TxtMaChiTiet.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMaChiTiet.Multiline = True
        Me.TxtMaChiTiet.Name = "TxtMaChiTiet"
        Me.TxtMaChiTiet.Size = New System.Drawing.Size(241, 32)
        Me.TxtMaChiTiet.TabIndex = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(517, 32)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Số lượng:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(45, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Mã hóa đơn:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(45, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Mã chi tiết:"
        '
        'LUU
        '
        Me.LUU.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LUU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUU.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LUU.Location = New System.Drawing.Point(955, 97)
        Me.LUU.Margin = New System.Windows.Forms.Padding(4)
        Me.LUU.Name = "LUU"
        Me.LUU.Size = New System.Drawing.Size(113, 47)
        Me.LUU.TabIndex = 94
        Me.LUU.Text = "Lưu"
        Me.LUU.UseVisualStyleBackColor = False
        '
        'THOAT
        '
        Me.THOAT.BackColor = System.Drawing.Color.White
        Me.THOAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.THOAT.ForeColor = System.Drawing.Color.DarkRed
        Me.THOAT.Location = New System.Drawing.Point(1136, 97)
        Me.THOAT.Margin = New System.Windows.Forms.Padding(4)
        Me.THOAT.Name = "THOAT"
        Me.THOAT.Size = New System.Drawing.Size(113, 47)
        Me.THOAT.TabIndex = 93
        Me.THOAT.Text = "Thoát"
        Me.THOAT.UseVisualStyleBackColor = False
        '
        'XOA
        '
        Me.XOA.BackColor = System.Drawing.Color.White
        Me.XOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XOA.ForeColor = System.Drawing.Color.DarkRed
        Me.XOA.Location = New System.Drawing.Point(1136, 174)
        Me.XOA.Margin = New System.Windows.Forms.Padding(4)
        Me.XOA.Name = "XOA"
        Me.XOA.Size = New System.Drawing.Size(113, 47)
        Me.XOA.TabIndex = 92
        Me.XOA.Text = "Xoá"
        Me.XOA.UseVisualStyleBackColor = False
        '
        'TKiem
        '
        Me.TKiem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TKiem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TKiem.Location = New System.Drawing.Point(955, 174)
        Me.TKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.TKiem.Name = "TKiem"
        Me.TKiem.Size = New System.Drawing.Size(113, 47)
        Me.TKiem.TabIndex = 91
        Me.TKiem.Text = "Tìm Kiếm"
        Me.TKiem.UseVisualStyleBackColor = False
        '
        'THEM
        '
        Me.THEM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.THEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.THEM.ForeColor = System.Drawing.SystemColors.Highlight
        Me.THEM.Location = New System.Drawing.Point(955, 19)
        Me.THEM.Margin = New System.Windows.Forms.Padding(4)
        Me.THEM.Name = "THEM"
        Me.THEM.Size = New System.Drawing.Size(113, 47)
        Me.THEM.TabIndex = 90
        Me.THEM.Text = "Thêm"
        Me.THEM.UseVisualStyleBackColor = False
        '
        'CUOI
        '
        Me.CUOI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUOI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CUOI.ForeColor = System.Drawing.SystemColors.Highlight
        Me.CUOI.Location = New System.Drawing.Point(1046, 649)
        Me.CUOI.Margin = New System.Windows.Forms.Padding(4)
        Me.CUOI.Name = "CUOI"
        Me.CUOI.Size = New System.Drawing.Size(113, 47)
        Me.CUOI.TabIndex = 89
        Me.CUOI.Text = ">>"
        Me.CUOI.UseVisualStyleBackColor = False
        '
        'DAU
        '
        Me.DAU.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DAU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DAU.ForeColor = System.Drawing.SystemColors.Highlight
        Me.DAU.Location = New System.Drawing.Point(70, 649)
        Me.DAU.Margin = New System.Windows.Forms.Padding(4)
        Me.DAU.Name = "DAU"
        Me.DAU.Size = New System.Drawing.Size(113, 47)
        Me.DAU.TabIndex = 88
        Me.DAU.Text = "<<"
        Me.DAU.UseVisualStyleBackColor = False
        '
        'TxtGiaBan
        '
        Me.TxtGiaBan.Location = New System.Drawing.Point(671, 88)
        Me.TxtGiaBan.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGiaBan.Multiline = True
        Me.TxtGiaBan.Name = "TxtGiaBan"
        Me.TxtGiaBan.Size = New System.Drawing.Size(241, 32)
        Me.TxtGiaBan.TabIndex = 111
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(517, 88)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 20)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "GIá bán:"
        '
        'TxtThanhTien
        '
        Me.TxtThanhTien.Location = New System.Drawing.Point(671, 150)
        Me.TxtThanhTien.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtThanhTien.Multiline = True
        Me.TxtThanhTien.Name = "TxtThanhTien"
        Me.TxtThanhTien.Size = New System.Drawing.Size(241, 32)
        Me.TxtThanhTien.TabIndex = 113
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(517, 150)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 20)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Thành tiền:"
        '
        'TxtLoaiSanPham
        '
        Me.TxtLoaiSanPham.Location = New System.Drawing.Point(200, 195)
        Me.TxtLoaiSanPham.Multiline = True
        Me.TxtLoaiSanPham.Name = "TxtLoaiSanPham"
        Me.TxtLoaiSanPham.Size = New System.Drawing.Size(240, 30)
        Me.TxtLoaiSanPham.TabIndex = 114
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(42, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 18)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Loại Sản Phẩm"
        '
        'F_ChiTietHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1317, 760)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtLoaiSanPham)
        Me.Controls.Add(Me.TxtThanhTien)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtGiaBan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SUA)
        Me.Controls.Add(Me.Data_DS)
        Me.Controls.Add(Me.TxtMaSanPham)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SAU)
        Me.Controls.Add(Me.TRUOC)
        Me.Controls.Add(Me.TxtSoLuong)
        Me.Controls.Add(Me.TxtMaHoaDon)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtMaChiTiet)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LUU)
        Me.Controls.Add(Me.THOAT)
        Me.Controls.Add(Me.XOA)
        Me.Controls.Add(Me.TKiem)
        Me.Controls.Add(Me.THEM)
        Me.Controls.Add(Me.CUOI)
        Me.Controls.Add(Me.DAU)
        Me.Name = "F_ChiTietHoaDon"
        Me.Text = "F_ChiTietHoaDon"
        CType(Me.Data_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SUA As Button
    Friend WithEvents Data_DS As DataGridView
    Friend WithEvents TxtMaSanPham As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SAU As Button
    Friend WithEvents TRUOC As Button
    Friend WithEvents TxtSoLuong As TextBox
    Friend WithEvents TxtMaHoaDon As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtMaChiTiet As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LUU As Button
    Friend WithEvents THOAT As Button
    Friend WithEvents XOA As Button
    Friend WithEvents TKiem As Button
    Friend WithEvents THEM As Button
    Friend WithEvents CUOI As Button
    Friend WithEvents DAU As Button
    Friend WithEvents TxtGiaBan As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtThanhTien As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtLoaiSanPham As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label3 As Label
End Class
