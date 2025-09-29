<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_HoaDon
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
        Me.TxtTongTien = New System.Windows.Forms.TextBox()
        Me.SAU = New System.Windows.Forms.Button()
        Me.TRUOC = New System.Windows.Forms.Button()
        Me.TxtMAKH = New System.Windows.Forms.TextBox()
        Me.TxtMAHD = New System.Windows.Forms.TextBox()
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
        Me.dtpNgayLap = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMNV = New System.Windows.Forms.TextBox()
        CType(Me.Data_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Data_DS
        '
        Me.Data_DS.BackgroundColor = System.Drawing.Color.White
        Me.Data_DS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_DS.Location = New System.Drawing.Point(69, 318)
        Me.Data_DS.Name = "Data_DS"
        Me.Data_DS.RowHeadersWidth = 51
        Me.Data_DS.RowTemplate.Height = 24
        Me.Data_DS.Size = New System.Drawing.Size(930, 192)
        Me.Data_DS.TabIndex = 80
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(23, 144)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Tổng Tiền"
        '
        'TxtTongTien
        '
        Me.TxtTongTien.Location = New System.Drawing.Point(180, 144)
        Me.TxtTongTien.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTongTien.Multiline = True
        Me.TxtTongTien.Name = "TxtTongTien"
        Me.TxtTongTien.Size = New System.Drawing.Size(241, 32)
        Me.TxtTongTien.TabIndex = 79
        '
        'SAU
        '
        Me.SAU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAU.ForeColor = System.Drawing.SystemColors.Highlight
        Me.SAU.Location = New System.Drawing.Point(688, 552)
        Me.SAU.Margin = New System.Windows.Forms.Padding(4)
        Me.SAU.Name = "SAU"
        Me.SAU.Size = New System.Drawing.Size(112, 47)
        Me.SAU.TabIndex = 77
        Me.SAU.Text = ">"
        Me.SAU.UseVisualStyleBackColor = True
        '
        'TRUOC
        '
        Me.TRUOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRUOC.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TRUOC.Location = New System.Drawing.Point(255, 553)
        Me.TRUOC.Margin = New System.Windows.Forms.Padding(4)
        Me.TRUOC.Name = "TRUOC"
        Me.TRUOC.Size = New System.Drawing.Size(111, 46)
        Me.TRUOC.TabIndex = 76
        Me.TRUOC.Text = "<"
        Me.TRUOC.UseVisualStyleBackColor = True
        '
        'TxtMAKH
        '
        Me.TxtMAKH.Location = New System.Drawing.Point(180, 95)
        Me.TxtMAKH.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMAKH.Multiline = True
        Me.TxtMAKH.Name = "TxtMAKH"
        Me.TxtMAKH.Size = New System.Drawing.Size(241, 32)
        Me.TxtMAKH.TabIndex = 75
        '
        'TxtMAHD
        '
        Me.TxtMAHD.Location = New System.Drawing.Point(180, 37)
        Me.TxtMAHD.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMAHD.Multiline = True
        Me.TxtMAHD.Name = "TxtMAHD"
        Me.TxtMAHD.Size = New System.Drawing.Size(241, 32)
        Me.TxtMAHD.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(23, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 20)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Mã Khách Hàng"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(23, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Mã Hóa Đơn"
        '
        'LUU
        '
        Me.LUU.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LUU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUU.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LUU.Location = New System.Drawing.Point(521, 109)
        Me.LUU.Margin = New System.Windows.Forms.Padding(4)
        Me.LUU.Name = "LUU"
        Me.LUU.Size = New System.Drawing.Size(113, 47)
        Me.LUU.TabIndex = 71
        Me.LUU.Text = "Lưu"
        Me.LUU.UseVisualStyleBackColor = False
        '
        'THOAT
        '
        Me.THOAT.BackColor = System.Drawing.Color.White
        Me.THOAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.THOAT.ForeColor = System.Drawing.Color.DarkRed
        Me.THOAT.Location = New System.Drawing.Point(886, 111)
        Me.THOAT.Margin = New System.Windows.Forms.Padding(4)
        Me.THOAT.Name = "THOAT"
        Me.THOAT.Size = New System.Drawing.Size(113, 47)
        Me.THOAT.TabIndex = 70
        Me.THOAT.Text = "Thoát"
        Me.THOAT.UseVisualStyleBackColor = False
        '
        'XOA
        '
        Me.XOA.BackColor = System.Drawing.Color.White
        Me.XOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XOA.ForeColor = System.Drawing.Color.DarkRed
        Me.XOA.Location = New System.Drawing.Point(687, 109)
        Me.XOA.Margin = New System.Windows.Forms.Padding(4)
        Me.XOA.Name = "XOA"
        Me.XOA.Size = New System.Drawing.Size(113, 47)
        Me.XOA.TabIndex = 69
        Me.XOA.Text = "Xoá"
        Me.XOA.UseVisualStyleBackColor = False
        '
        'TKiem
        '
        Me.TKiem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TKiem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TKiem.Location = New System.Drawing.Point(886, 24)
        Me.TKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.TKiem.Name = "TKiem"
        Me.TKiem.Size = New System.Drawing.Size(113, 47)
        Me.TKiem.TabIndex = 68
        Me.TKiem.Text = "Tìm Kiếm"
        Me.TKiem.UseVisualStyleBackColor = False
        '
        'SUA
        '
        Me.SUA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SUA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUA.ForeColor = System.Drawing.SystemColors.Highlight
        Me.SUA.Location = New System.Drawing.Point(687, 24)
        Me.SUA.Margin = New System.Windows.Forms.Padding(4)
        Me.SUA.Name = "SUA"
        Me.SUA.Size = New System.Drawing.Size(113, 47)
        Me.SUA.TabIndex = 67
        Me.SUA.Text = "Sửa"
        Me.SUA.UseVisualStyleBackColor = False
        '
        'THEM
        '
        Me.THEM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.THEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.THEM.ForeColor = System.Drawing.SystemColors.Highlight
        Me.THEM.Location = New System.Drawing.Point(521, 24)
        Me.THEM.Margin = New System.Windows.Forms.Padding(4)
        Me.THEM.Name = "THEM"
        Me.THEM.Size = New System.Drawing.Size(113, 47)
        Me.THEM.TabIndex = 66
        Me.THEM.Text = "Thêm"
        Me.THEM.UseVisualStyleBackColor = False
        '
        'CUOI
        '
        Me.CUOI.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CUOI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CUOI.ForeColor = System.Drawing.SystemColors.Highlight
        Me.CUOI.Location = New System.Drawing.Point(864, 553)
        Me.CUOI.Margin = New System.Windows.Forms.Padding(4)
        Me.CUOI.Name = "CUOI"
        Me.CUOI.Size = New System.Drawing.Size(113, 47)
        Me.CUOI.TabIndex = 65
        Me.CUOI.Text = ">>"
        Me.CUOI.UseVisualStyleBackColor = False
        '
        'DAU
        '
        Me.DAU.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DAU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DAU.ForeColor = System.Drawing.SystemColors.Highlight
        Me.DAU.Location = New System.Drawing.Point(69, 552)
        Me.DAU.Margin = New System.Windows.Forms.Padding(4)
        Me.DAU.Name = "DAU"
        Me.DAU.Size = New System.Drawing.Size(113, 47)
        Me.DAU.TabIndex = 64
        Me.DAU.Text = "<<"
        Me.DAU.UseVisualStyleBackColor = False
        '
        'dtpNgayLap
        '
        Me.dtpNgayLap.Location = New System.Drawing.Point(180, 203)
        Me.dtpNgayLap.Name = "dtpNgayLap"
        Me.dtpNgayLap.Size = New System.Drawing.Size(240, 22)
        Me.dtpNgayLap.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(23, 203)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Ngày Lập"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(22, 253)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "MNVLHĐ"
        '
        'TxtMNV
        '
        Me.TxtMNV.Location = New System.Drawing.Point(179, 253)
        Me.TxtMNV.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMNV.Multiline = True
        Me.TxtMNV.Name = "TxtMNV"
        Me.TxtMNV.Size = New System.Drawing.Size(241, 32)
        Me.TxtMNV.TabIndex = 84
        '
        'F_HoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuanLyCuaHangMT.My.Resources.Resources.background_nhe_nhang_dep_tuyet_085535337
        Me.ClientSize = New System.Drawing.Size(1052, 616)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtMNV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpNgayLap)
        Me.Controls.Add(Me.Data_DS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTongTien)
        Me.Controls.Add(Me.SAU)
        Me.Controls.Add(Me.TRUOC)
        Me.Controls.Add(Me.TxtMAKH)
        Me.Controls.Add(Me.TxtMAHD)
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
        Me.Name = "F_HoaDon"
        Me.Text = "F_HoaDon"
        CType(Me.Data_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Data_DS As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTongTien As TextBox
    Friend WithEvents SAU As Button
    Friend WithEvents TRUOC As Button
    Friend WithEvents TxtMAKH As TextBox
    Friend WithEvents TxtMAHD As TextBox
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
    Friend WithEvents dtpNgayLap As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtMNV As TextBox
End Class
