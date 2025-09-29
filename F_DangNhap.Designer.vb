<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_DangNhap
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTenDN = New System.Windows.Forms.TextBox()
        Me.TxtMatKhau = New System.Windows.Forms.TextBox()
        Me.DangNhap = New System.Windows.Forms.Button()
        Me.DangKy = New System.Windows.Forms.Button()
        Me.BtThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tên Đăng Nhập"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(141, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mật Khẩu"
        '
        'TxtTenDN
        '
        Me.TxtTenDN.Location = New System.Drawing.Point(324, 142)
        Me.TxtTenDN.Multiline = True
        Me.TxtTenDN.Name = "TxtTenDN"
        Me.TxtTenDN.Size = New System.Drawing.Size(206, 26)
        Me.TxtTenDN.TabIndex = 2
        '
        'TxtMatKhau
        '
        Me.TxtMatKhau.Location = New System.Drawing.Point(324, 192)
        Me.TxtMatKhau.Multiline = True
        Me.TxtMatKhau.Name = "TxtMatKhau"
        Me.TxtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtMatKhau.Size = New System.Drawing.Size(206, 27)
        Me.TxtMatKhau.TabIndex = 3
        '
        'DangNhap
        '
        Me.DangNhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DangNhap.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.DangNhap.Location = New System.Drawing.Point(134, 238)
        Me.DangNhap.Name = "DangNhap"
        Me.DangNhap.Size = New System.Drawing.Size(134, 31)
        Me.DangNhap.TabIndex = 4
        Me.DangNhap.Text = "Đăng Nhập"
        Me.DangNhap.UseVisualStyleBackColor = True
        '
        'DangKy
        '
        Me.DangKy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DangKy.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.DangKy.Location = New System.Drawing.Point(286, 238)
        Me.DangKy.Name = "DangKy"
        Me.DangKy.Size = New System.Drawing.Size(114, 31)
        Me.DangKy.TabIndex = 5
        Me.DangKy.Text = "Đăng Ký"
        Me.DangKy.UseVisualStyleBackColor = True
        '
        'BtThoat
        '
        Me.BtThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtThoat.ForeColor = System.Drawing.Color.Red
        Me.BtThoat.Location = New System.Drawing.Point(416, 238)
        Me.BtThoat.Name = "BtThoat"
        Me.BtThoat.Size = New System.Drawing.Size(114, 31)
        Me.BtThoat.TabIndex = 6
        Me.BtThoat.Text = "Thoát"
        Me.BtThoat.UseVisualStyleBackColor = True
        '
        'F_DangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuanLyCuaHangMT.My.Resources.Resources.abstract_square_interface_modern_background_concept_fingerprint_digital_scanning_visual_security_system_authentication_login_vector
        Me.ClientSize = New System.Drawing.Size(698, 399)
        Me.Controls.Add(Me.BtThoat)
        Me.Controls.Add(Me.DangKy)
        Me.Controls.Add(Me.DangNhap)
        Me.Controls.Add(Me.TxtMatKhau)
        Me.Controls.Add(Me.TxtTenDN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "F_DangNhap"
        Me.Text = "Đăng nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtTenDN As TextBox
    Friend WithEvents TxtMatKhau As TextBox
    Friend WithEvents DangNhap As Button
    Friend WithEvents DangKy As Button
    Friend WithEvents BtThoat As Button
End Class
