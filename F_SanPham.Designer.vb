<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_SanPham
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtGiaNhap = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Data_DS = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SAU = New System.Windows.Forms.Button()
        Me.TRUOC = New System.Windows.Forms.Button()
        Me.TxtTenSP = New System.Windows.Forms.TextBox()
        Me.TxtMaSP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LUU = New System.Windows.Forms.Button()
        Me.THOAT = New System.Windows.Forms.Button()
        Me.XOA = New System.Windows.Forms.Button()
        Me.TKiem = New System.Windows.Forms.Button()
        Me.SUA = New System.Windows.Forms.Button()
        Me.THEM = New System.Windows.Forms.Button()
        Me.CUOI = New System.Windows.Forms.Button()
        Me.DAU = New System.Windows.Forms.Button()
        Me.cboMaLoai = New System.Windows.Forms.ComboBox()
        Me.TxtGiaBan = New System.Windows.Forms.TextBox()
        Me.TxtTrangThai = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSoLuongTon = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMoTa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.Data_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(583, 42)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Giá Bán"
        '
        'TxtGiaNhap
        '
        Me.TxtGiaNhap.Location = New System.Drawing.Point(216, 208)
        Me.TxtGiaNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGiaNhap.Multiline = True
        Me.TxtGiaNhap.Name = "TxtGiaNhap"
        Me.TxtGiaNhap.Size = New System.Drawing.Size(241, 32)
        Me.TxtGiaNhap.TabIndex = 105
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(59, 208)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Giá Nhập"
        '
        'Data_DS
        '
        Me.Data_DS.BackgroundColor = System.Drawing.Color.White
        Me.Data_DS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_DS.Location = New System.Drawing.Point(72, 323)
        Me.Data_DS.Name = "Data_DS"
        Me.Data_DS.RowHeadersWidth = 51
        Me.Data_DS.RowTemplate.Height = 24
        Me.Data_DS.Size = New System.Drawing.Size(976, 192)
        Me.Data_DS.TabIndex = 101
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(59, 149)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Mã Loại"
        '
        'SAU
        '
        Me.SAU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAU.ForeColor = System.Drawing.SystemColors.Highlight
        Me.SAU.Location = New System.Drawing.Point(666, 549)
        Me.SAU.Margin = New System.Windows.Forms.Padding(4)
        Me.SAU.Name = "SAU"
        Me.SAU.Size = New System.Drawing.Size(112, 47)
        Me.SAU.TabIndex = 98
        Me.SAU.Text = ">"
        Me.SAU.UseVisualStyleBackColor = True
        '
        'TRUOC
        '
        Me.TRUOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRUOC.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TRUOC.Location = New System.Drawing.Point(316, 550)
        Me.TRUOC.Margin = New System.Windows.Forms.Padding(4)
        Me.TRUOC.Name = "TRUOC"
        Me.TRUOC.Size = New System.Drawing.Size(111, 46)
        Me.TRUOC.TabIndex = 97
        Me.TRUOC.Text = "<"
        Me.TRUOC.UseVisualStyleBackColor = True
        '
        'TxtTenSP
        '
        Me.TxtTenSP.Location = New System.Drawing.Point(216, 100)
        Me.TxtTenSP.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTenSP.Multiline = True
        Me.TxtTenSP.Name = "TxtTenSP"
        Me.TxtTenSP.Size = New System.Drawing.Size(241, 32)
        Me.TxtTenSP.TabIndex = 96
        '
        'TxtMaSP
        '
        Me.TxtMaSP.Location = New System.Drawing.Point(216, 42)
        Me.TxtMaSP.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMaSP.Multiline = True
        Me.TxtMaSP.Name = "TxtMaSP"
        Me.TxtMaSP.Size = New System.Drawing.Size(241, 32)
        Me.TxtMaSP.TabIndex = 95
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(59, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Tên Sản Phẩm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(59, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Mã Sản Phẩm"
        '
        'LUU
        '
        Me.LUU.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LUU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUU.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LUU.Location = New System.Drawing.Point(632, 634)
        Me.LUU.Margin = New System.Windows.Forms.Padding(4)
        Me.LUU.Name = "LUU"
        Me.LUU.Size = New System.Drawing.Size(113, 47)
        Me.LUU.TabIndex = 92
        Me.LUU.Text = "Lưu"
        Me.LUU.UseVisualStyleBackColor = False
        '
        'THOAT
        '
        Me.THOAT.BackColor = System.Drawing.Color.White
        Me.THOAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.THOAT.ForeColor = System.Drawing.Color.DarkRed
        Me.THOAT.Location = New System.Drawing.Point(933, 634)
        Me.THOAT.Margin = New System.Windows.Forms.Padding(4)
        Me.THOAT.Name = "THOAT"
        Me.THOAT.Size = New System.Drawing.Size(113, 47)
        Me.THOAT.TabIndex = 91
        Me.THOAT.Text = "Thoát"
        Me.THOAT.UseVisualStyleBackColor = False
        '
        'XOA
        '
        Me.XOA.BackColor = System.Drawing.Color.White
        Me.XOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XOA.ForeColor = System.Drawing.Color.DarkRed
        Me.XOA.Location = New System.Drawing.Point(787, 634)
        Me.XOA.Margin = New System.Windows.Forms.Padding(4)
        Me.XOA.Name = "XOA"
        Me.XOA.Size = New System.Drawing.Size(113, 47)
        Me.XOA.TabIndex = 90
        Me.XOA.Text = "Xoá"
        Me.XOA.UseVisualStyleBackColor = False
        '
        'TKiem
        '
        Me.TKiem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TKiem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TKiem.Location = New System.Drawing.Point(436, 634)
        Me.TKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.TKiem.Name = "TKiem"
        Me.TKiem.Size = New System.Drawing.Size(113, 47)
        Me.TKiem.TabIndex = 89
        Me.TKiem.Text = "Tìm Kiếm"
        Me.TKiem.UseVisualStyleBackColor = False
        '
        'SUA
        '
        Me.SUA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SUA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUA.ForeColor = System.Drawing.SystemColors.Highlight
        Me.SUA.Location = New System.Drawing.Point(248, 634)
        Me.SUA.Margin = New System.Windows.Forms.Padding(4)
        Me.SUA.Name = "SUA"
        Me.SUA.Size = New System.Drawing.Size(113, 47)
        Me.SUA.TabIndex = 88
        Me.SUA.Text = "Sửa"
        Me.SUA.UseVisualStyleBackColor = False
        '
        'THEM
        '
        Me.THEM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.THEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.THEM.ForeColor = System.Drawing.SystemColors.Highlight
        Me.THEM.Location = New System.Drawing.Point(82, 634)
        Me.THEM.Margin = New System.Windows.Forms.Padding(4)
        Me.THEM.Name = "THEM"
        Me.THEM.Size = New System.Drawing.Size(113, 47)
        Me.THEM.TabIndex = 87
        Me.THEM.Text = "Thêm"
        Me.THEM.UseVisualStyleBackColor = False
        '
        'CUOI
        '
        Me.CUOI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUOI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CUOI.ForeColor = System.Drawing.SystemColors.Highlight
        Me.CUOI.Location = New System.Drawing.Point(924, 548)
        Me.CUOI.Margin = New System.Windows.Forms.Padding(4)
        Me.CUOI.Name = "CUOI"
        Me.CUOI.Size = New System.Drawing.Size(113, 47)
        Me.CUOI.TabIndex = 86
        Me.CUOI.Text = ">>"
        Me.CUOI.UseVisualStyleBackColor = False
        '
        'DAU
        '
        Me.DAU.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DAU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DAU.ForeColor = System.Drawing.SystemColors.Highlight
        Me.DAU.Location = New System.Drawing.Point(87, 548)
        Me.DAU.Margin = New System.Windows.Forms.Padding(4)
        Me.DAU.Name = "DAU"
        Me.DAU.Size = New System.Drawing.Size(113, 47)
        Me.DAU.TabIndex = 85
        Me.DAU.Text = "<<"
        Me.DAU.UseVisualStyleBackColor = False
        '
        'cboMaLoai
        '
        Me.cboMaLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaLoai.FormattingEnabled = True
        Me.cboMaLoai.Items.AddRange(New Object() {"GĐ", "PGĐ", "PP", "KT", "NV", "TP"})
        Me.cboMaLoai.Location = New System.Drawing.Point(216, 149)
        Me.cboMaLoai.Name = "cboMaLoai"
        Me.cboMaLoai.Size = New System.Drawing.Size(240, 28)
        Me.cboMaLoai.TabIndex = 106
        '
        'TxtGiaBan
        '
        Me.TxtGiaBan.Location = New System.Drawing.Point(741, 42)
        Me.TxtGiaBan.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGiaBan.Multiline = True
        Me.TxtGiaBan.Name = "TxtGiaBan"
        Me.TxtGiaBan.Size = New System.Drawing.Size(241, 32)
        Me.TxtGiaBan.TabIndex = 107
        '
        'TxtTrangThai
        '
        Me.TxtTrangThai.Location = New System.Drawing.Point(741, 218)
        Me.TxtTrangThai.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTrangThai.Multiline = True
        Me.TxtTrangThai.Name = "TxtTrangThai"
        Me.TxtTrangThai.Size = New System.Drawing.Size(241, 32)
        Me.TxtTrangThai.TabIndex = 113
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(584, 218)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Trạng thái"
        '
        'TxtSoLuongTon
        '
        Me.TxtSoLuongTon.Location = New System.Drawing.Point(741, 104)
        Me.TxtSoLuongTon.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSoLuongTon.Multiline = True
        Me.TxtSoLuongTon.Name = "TxtSoLuongTon"
        Me.TxtSoLuongTon.Size = New System.Drawing.Size(241, 32)
        Me.TxtSoLuongTon.TabIndex = 111
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(584, 112)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 20)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Số lượng tồn"
        '
        'TxtMoTa
        '
        Me.TxtMoTa.Location = New System.Drawing.Point(741, 162)
        Me.TxtMoTa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMoTa.Multiline = True
        Me.TxtMoTa.Name = "TxtMoTa"
        Me.TxtMoTa.Size = New System.Drawing.Size(241, 32)
        Me.TxtMoTa.TabIndex = 115
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(584, 174)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Mô tả"
        '
        'F_SanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 712)
        Me.Controls.Add(Me.TxtMoTa)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTrangThai)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtSoLuongTon)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtGiaBan)
        Me.Controls.Add(Me.cboMaLoai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtGiaNhap)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Data_DS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SAU)
        Me.Controls.Add(Me.TRUOC)
        Me.Controls.Add(Me.TxtTenSP)
        Me.Controls.Add(Me.TxtMaSP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LUU)
        Me.Controls.Add(Me.THOAT)
        Me.Controls.Add(Me.XOA)
        Me.Controls.Add(Me.TKiem)
        Me.Controls.Add(Me.SUA)
        Me.Controls.Add(Me.THEM)
        Me.Controls.Add(Me.CUOI)
        Me.Controls.Add(Me.DAU)
        Me.Name = "F_SanPham"
        Me.Text = "F_SanPham"
        CType(Me.Data_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents TxtGiaNhap As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Data_DS As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents SAU As Button
    Friend WithEvents TRUOC As Button
    Friend WithEvents TxtTenSP As TextBox
    Friend WithEvents TxtMaSP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LUU As Button
    Friend WithEvents THOAT As Button
    Friend WithEvents XOA As Button
    Friend WithEvents TKiem As Button
    Friend WithEvents SUA As Button
    Friend WithEvents THEM As Button
    Friend WithEvents CUOI As Button
    Friend WithEvents DAU As Button
    Friend WithEvents cboMaLoai As ComboBox
    Friend WithEvents TxtGiaBan As TextBox
    Friend WithEvents TxtTrangThai As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSoLuongTon As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtMoTa As TextBox
    Friend WithEvents Label8 As Label
End Class
