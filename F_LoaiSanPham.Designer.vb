<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_LoaiSanPham
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
        Me.Data_DS = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMoTa = New System.Windows.Forms.TextBox()
        Me.SAU = New System.Windows.Forms.Button()
        Me.TRUOC = New System.Windows.Forms.Button()
        Me.TxtTenLoai = New System.Windows.Forms.TextBox()
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
        CType(Me.Data_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Data_DS
        '
        Me.Data_DS.BackgroundColor = System.Drawing.Color.White
        Me.Data_DS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_DS.Location = New System.Drawing.Point(110, 264)
        Me.Data_DS.Name = "Data_DS"
        Me.Data_DS.RowHeadersWidth = 51
        Me.Data_DS.RowTemplate.Height = 24
        Me.Data_DS.Size = New System.Drawing.Size(930, 192)
        Me.Data_DS.TabIndex = 122
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(86, 174)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 120
        Me.Label5.Text = "Mô Tả:"
        '
        'TxtMoTa
        '
        Me.TxtMoTa.Location = New System.Drawing.Point(243, 174)
        Me.TxtMoTa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMoTa.Multiline = True
        Me.TxtMoTa.Name = "TxtMoTa"
        Me.TxtMoTa.Size = New System.Drawing.Size(241, 32)
        Me.TxtMoTa.TabIndex = 121
        '
        'SAU
        '
        Me.SAU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAU.ForeColor = System.Drawing.SystemColors.Highlight
        Me.SAU.Location = New System.Drawing.Point(704, 516)
        Me.SAU.Margin = New System.Windows.Forms.Padding(4)
        Me.SAU.Name = "SAU"
        Me.SAU.Size = New System.Drawing.Size(112, 47)
        Me.SAU.TabIndex = 119
        Me.SAU.Text = ">"
        Me.SAU.UseVisualStyleBackColor = True
        '
        'TRUOC
        '
        Me.TRUOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRUOC.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TRUOC.Location = New System.Drawing.Point(312, 517)
        Me.TRUOC.Margin = New System.Windows.Forms.Padding(4)
        Me.TRUOC.Name = "TRUOC"
        Me.TRUOC.Size = New System.Drawing.Size(111, 46)
        Me.TRUOC.TabIndex = 118
        Me.TRUOC.Text = "<"
        Me.TRUOC.UseVisualStyleBackColor = True
        '
        'TxtTenLoai
        '
        Me.TxtTenLoai.Location = New System.Drawing.Point(243, 125)
        Me.TxtTenLoai.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTenLoai.Multiline = True
        Me.TxtTenLoai.Name = "TxtTenLoai"
        Me.TxtTenLoai.Size = New System.Drawing.Size(241, 32)
        Me.TxtTenLoai.TabIndex = 117
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(86, 125)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "Tên Loại:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(86, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Mã Loại:"
        '
        'LUU
        '
        Me.LUU.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LUU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUU.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LUU.Location = New System.Drawing.Point(584, 139)
        Me.LUU.Margin = New System.Windows.Forms.Padding(4)
        Me.LUU.Name = "LUU"
        Me.LUU.Size = New System.Drawing.Size(113, 47)
        Me.LUU.TabIndex = 113
        Me.LUU.Text = "Lưu"
        Me.LUU.UseVisualStyleBackColor = False
        '
        'THOAT
        '
        Me.THOAT.BackColor = System.Drawing.Color.White
        Me.THOAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.THOAT.ForeColor = System.Drawing.Color.DarkRed
        Me.THOAT.Location = New System.Drawing.Point(949, 139)
        Me.THOAT.Margin = New System.Windows.Forms.Padding(4)
        Me.THOAT.Name = "THOAT"
        Me.THOAT.Size = New System.Drawing.Size(113, 47)
        Me.THOAT.TabIndex = 112
        Me.THOAT.Text = "Thoát"
        Me.THOAT.UseVisualStyleBackColor = False
        '
        'XOA
        '
        Me.XOA.BackColor = System.Drawing.Color.White
        Me.XOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XOA.ForeColor = System.Drawing.Color.DarkRed
        Me.XOA.Location = New System.Drawing.Point(750, 139)
        Me.XOA.Margin = New System.Windows.Forms.Padding(4)
        Me.XOA.Name = "XOA"
        Me.XOA.Size = New System.Drawing.Size(113, 47)
        Me.XOA.TabIndex = 111
        Me.XOA.Text = "Xoá"
        Me.XOA.UseVisualStyleBackColor = False
        '
        'TKiem
        '
        Me.TKiem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TKiem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TKiem.Location = New System.Drawing.Point(949, 54)
        Me.TKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.TKiem.Name = "TKiem"
        Me.TKiem.Size = New System.Drawing.Size(113, 47)
        Me.TKiem.TabIndex = 110
        Me.TKiem.Text = "Tìm Kiếm"
        Me.TKiem.UseVisualStyleBackColor = False
        '
        'SUA
        '
        Me.SUA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SUA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUA.ForeColor = System.Drawing.SystemColors.Highlight
        Me.SUA.Location = New System.Drawing.Point(750, 54)
        Me.SUA.Margin = New System.Windows.Forms.Padding(4)
        Me.SUA.Name = "SUA"
        Me.SUA.Size = New System.Drawing.Size(113, 47)
        Me.SUA.TabIndex = 109
        Me.SUA.Text = "Sửa"
        Me.SUA.UseVisualStyleBackColor = False
        '
        'THEM
        '
        Me.THEM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.THEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.THEM.ForeColor = System.Drawing.SystemColors.Highlight
        Me.THEM.Location = New System.Drawing.Point(584, 54)
        Me.THEM.Margin = New System.Windows.Forms.Padding(4)
        Me.THEM.Name = "THEM"
        Me.THEM.Size = New System.Drawing.Size(113, 47)
        Me.THEM.TabIndex = 108
        Me.THEM.Text = "Thêm"
        Me.THEM.UseVisualStyleBackColor = False
        '
        'CUOI
        '
        Me.CUOI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUOI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CUOI.ForeColor = System.Drawing.SystemColors.Highlight
        Me.CUOI.Location = New System.Drawing.Point(908, 516)
        Me.CUOI.Margin = New System.Windows.Forms.Padding(4)
        Me.CUOI.Name = "CUOI"
        Me.CUOI.Size = New System.Drawing.Size(113, 47)
        Me.CUOI.TabIndex = 107
        Me.CUOI.Text = ">>"
        Me.CUOI.UseVisualStyleBackColor = False
        '
        'DAU
        '
        Me.DAU.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DAU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DAU.ForeColor = System.Drawing.SystemColors.Highlight
        Me.DAU.Location = New System.Drawing.Point(124, 515)
        Me.DAU.Margin = New System.Windows.Forms.Padding(4)
        Me.DAU.Name = "DAU"
        Me.DAU.Size = New System.Drawing.Size(113, 47)
        Me.DAU.TabIndex = 106
        Me.DAU.Text = "<<"
        Me.DAU.UseVisualStyleBackColor = False
        '
        'cboMaLoai
        '
        Me.cboMaLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaLoai.FormattingEnabled = True
        Me.cboMaLoai.Items.AddRange(New Object() {"GĐ", "PGĐ", "PP", "KT", "NV", "TP"})
        Me.cboMaLoai.Location = New System.Drawing.Point(243, 67)
        Me.cboMaLoai.Name = "cboMaLoai"
        Me.cboMaLoai.Size = New System.Drawing.Size(240, 28)
        Me.cboMaLoai.TabIndex = 123
        '
        'F_LoaiSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 634)
        Me.Controls.Add(Me.cboMaLoai)
        Me.Controls.Add(Me.Data_DS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtMoTa)
        Me.Controls.Add(Me.SAU)
        Me.Controls.Add(Me.TRUOC)
        Me.Controls.Add(Me.TxtTenLoai)
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
        Me.Name = "F_LoaiSanPham"
        Me.Text = "F_LoaiSanPham"
        CType(Me.Data_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Data_DS As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtMoTa As TextBox
    Friend WithEvents SAU As Button
    Friend WithEvents TRUOC As Button
    Friend WithEvents TxtTenLoai As TextBox
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
End Class
