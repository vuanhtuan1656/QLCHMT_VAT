<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_KhachHang
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
        Me.Data_DS = New System.Windows.Forms.DataGridView()
        Me.TxtDT = New System.Windows.Forms.TextBox()
        Me.TxtDC = New System.Windows.Forms.TextBox()
        Me.TxtHT = New System.Windows.Forms.TextBox()
        Me.TxtMAKH = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.XOA = New System.Windows.Forms.Button()
        Me.THOAT = New System.Windows.Forms.Button()
        Me.LUU = New System.Windows.Forms.Button()
        Me.TKiem = New System.Windows.Forms.Button()
        Me.SUA = New System.Windows.Forms.Button()
        Me.THEM = New System.Windows.Forms.Button()
        Me.CUOI = New System.Windows.Forms.Button()
        Me.SAU = New System.Windows.Forms.Button()
        Me.TRUOC = New System.Windows.Forms.Button()
        Me.DAU = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        CType(Me.Data_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Data_DS
        '
        Me.Data_DS.AllowUserToOrderColumns = True
        Me.Data_DS.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.Data_DS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_DS.Location = New System.Drawing.Point(122, 357)
        Me.Data_DS.Margin = New System.Windows.Forms.Padding(4)
        Me.Data_DS.Name = "Data_DS"
        Me.Data_DS.RowHeadersWidth = 51
        Me.Data_DS.Size = New System.Drawing.Size(923, 181)
        Me.Data_DS.TabIndex = 1
        '
        'TxtDT
        '
        Me.TxtDT.Location = New System.Drawing.Point(158, 150)
        Me.TxtDT.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDT.Multiline = True
        Me.TxtDT.Name = "TxtDT"
        Me.TxtDT.Size = New System.Drawing.Size(256, 31)
        Me.TxtDT.TabIndex = 26
        '
        'TxtDC
        '
        Me.TxtDC.Location = New System.Drawing.Point(158, 264)
        Me.TxtDC.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDC.Multiline = True
        Me.TxtDC.Name = "TxtDC"
        Me.TxtDC.Size = New System.Drawing.Size(256, 30)
        Me.TxtDC.TabIndex = 25
        '
        'TxtHT
        '
        Me.TxtHT.Location = New System.Drawing.Point(158, 97)
        Me.TxtHT.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtHT.Multiline = True
        Me.TxtHT.Name = "TxtHT"
        Me.TxtHT.Size = New System.Drawing.Size(256, 28)
        Me.TxtHT.TabIndex = 24
        '
        'TxtMAKH
        '
        Me.TxtMAKH.Location = New System.Drawing.Point(158, 42)
        Me.TxtMAKH.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMAKH.Multiline = True
        Me.TxtMAKH.Name = "TxtMAKH"
        Me.TxtMAKH.Size = New System.Drawing.Size(256, 28)
        Me.TxtMAKH.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(26, 161)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Điện thoại:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(26, 264)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Địa chỉ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(26, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Họ Tên:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(26, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Mã khách:"
        '
        'XOA
        '
        Me.XOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XOA.ForeColor = System.Drawing.Color.Red
        Me.XOA.Location = New System.Drawing.Point(975, 111)
        Me.XOA.Margin = New System.Windows.Forms.Padding(4)
        Me.XOA.Name = "XOA"
        Me.XOA.Size = New System.Drawing.Size(108, 32)
        Me.XOA.TabIndex = 32
        Me.XOA.Text = "Xoá"
        Me.XOA.UseVisualStyleBackColor = True
        '
        'THOAT
        '
        Me.THOAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.THOAT.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.THOAT.Location = New System.Drawing.Point(560, 111)
        Me.THOAT.Margin = New System.Windows.Forms.Padding(4)
        Me.THOAT.Name = "THOAT"
        Me.THOAT.Size = New System.Drawing.Size(108, 32)
        Me.THOAT.TabIndex = 31
        Me.THOAT.Text = "Thoát"
        Me.THOAT.UseVisualStyleBackColor = True
        '
        'LUU
        '
        Me.LUU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUU.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LUU.Location = New System.Drawing.Point(783, 111)
        Me.LUU.Margin = New System.Windows.Forms.Padding(4)
        Me.LUU.Name = "LUU"
        Me.LUU.Size = New System.Drawing.Size(108, 32)
        Me.LUU.TabIndex = 30
        Me.LUU.Text = "Lưu "
        Me.LUU.UseVisualStyleBackColor = True
        '
        'TKiem
        '
        Me.TKiem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TKiem.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TKiem.Location = New System.Drawing.Point(560, 44)
        Me.TKiem.Margin = New System.Windows.Forms.Padding(4)
        Me.TKiem.Name = "TKiem"
        Me.TKiem.Size = New System.Drawing.Size(108, 32)
        Me.TKiem.TabIndex = 29
        Me.TKiem.Text = "Tìm kiếm"
        Me.TKiem.UseVisualStyleBackColor = True
        '
        'SUA
        '
        Me.SUA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUA.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.SUA.Location = New System.Drawing.Point(767, 42)
        Me.SUA.Margin = New System.Windows.Forms.Padding(4)
        Me.SUA.Name = "SUA"
        Me.SUA.Size = New System.Drawing.Size(108, 32)
        Me.SUA.TabIndex = 28
        Me.SUA.Text = "Sửa"
        Me.SUA.UseVisualStyleBackColor = True
        '
        'THEM
        '
        Me.THEM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.THEM.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.THEM.Location = New System.Drawing.Point(975, 44)
        Me.THEM.Margin = New System.Windows.Forms.Padding(4)
        Me.THEM.Name = "THEM"
        Me.THEM.Size = New System.Drawing.Size(108, 32)
        Me.THEM.TabIndex = 27
        Me.THEM.Text = "Thêm"
        Me.THEM.UseVisualStyleBackColor = True
        '
        'CUOI
        '
        Me.CUOI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CUOI.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.CUOI.Location = New System.Drawing.Point(975, 194)
        Me.CUOI.Margin = New System.Windows.Forms.Padding(4)
        Me.CUOI.Name = "CUOI"
        Me.CUOI.Size = New System.Drawing.Size(108, 32)
        Me.CUOI.TabIndex = 36
        Me.CUOI.Text = ">>"
        Me.CUOI.UseVisualStyleBackColor = True
        '
        'SAU
        '
        Me.SAU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAU.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.SAU.Location = New System.Drawing.Point(836, 194)
        Me.SAU.Margin = New System.Windows.Forms.Padding(4)
        Me.SAU.Name = "SAU"
        Me.SAU.Size = New System.Drawing.Size(108, 32)
        Me.SAU.TabIndex = 35
        Me.SAU.Text = ">"
        Me.SAU.UseVisualStyleBackColor = True
        '
        'TRUOC
        '
        Me.TRUOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRUOC.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TRUOC.Location = New System.Drawing.Point(701, 194)
        Me.TRUOC.Margin = New System.Windows.Forms.Padding(4)
        Me.TRUOC.Name = "TRUOC"
        Me.TRUOC.Size = New System.Drawing.Size(108, 32)
        Me.TRUOC.TabIndex = 34
        Me.TRUOC.Text = "<"
        Me.TRUOC.UseVisualStyleBackColor = True
        '
        'DAU
        '
        Me.DAU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DAU.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.DAU.Location = New System.Drawing.Point(560, 194)
        Me.DAU.Margin = New System.Windows.Forms.Padding(4)
        Me.DAU.Name = "DAU"
        Me.DAU.Size = New System.Drawing.Size(108, 32)
        Me.DAU.TabIndex = 33
        Me.DAU.Text = "<<"
        Me.DAU.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(26, 210)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 20)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Email:"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(158, 210)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEmail.Multiline = True
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(256, 31)
        Me.TxtEmail.TabIndex = 38
        '
        'F_KhachHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuanLyCuaHangMT.My.Resources.Resources.hinh_nen_dep_mau_trang_104324637
        Me.ClientSize = New System.Drawing.Size(1131, 606)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CUOI)
        Me.Controls.Add(Me.SAU)
        Me.Controls.Add(Me.TRUOC)
        Me.Controls.Add(Me.DAU)
        Me.Controls.Add(Me.XOA)
        Me.Controls.Add(Me.THOAT)
        Me.Controls.Add(Me.LUU)
        Me.Controls.Add(Me.TKiem)
        Me.Controls.Add(Me.SUA)
        Me.Controls.Add(Me.THEM)
        Me.Controls.Add(Me.TxtDT)
        Me.Controls.Add(Me.TxtDC)
        Me.Controls.Add(Me.TxtHT)
        Me.Controls.Add(Me.TxtMAKH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Data_DS)
        Me.Name = "F_KhachHang"
        Me.Text = "F_KhachHang"
        CType(Me.Data_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Data_DS As DataGridView
    Friend WithEvents TxtDT As TextBox
    Friend WithEvents TxtDC As TextBox
    Friend WithEvents TxtHT As TextBox
    Friend WithEvents TxtMAKH As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents XOA As Button
    Friend WithEvents THOAT As Button
    Friend WithEvents LUU As Button
    Friend WithEvents TKiem As Button
    Friend WithEvents SUA As Button
    Friend WithEvents THEM As Button
    Friend WithEvents CUOI As Button
    Friend WithEvents SAU As Button
    Friend WithEvents TRUOC As Button
    Friend WithEvents DAU As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtEmail As TextBox
End Class
