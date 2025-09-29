<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_DangKy
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
        Me.BtThoat = New System.Windows.Forms.Button()
        Me.BtDangKy = New System.Windows.Forms.Button()
        Me.TxtMatKhau = New System.Windows.Forms.TextBox()
        Me.TxtTenDN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtXacNhanMatKhau = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtThoat
        '
        Me.BtThoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtThoat.ForeColor = System.Drawing.Color.Red
        Me.BtThoat.Location = New System.Drawing.Point(339, 245)
        Me.BtThoat.Name = "BtThoat"
        Me.BtThoat.Size = New System.Drawing.Size(114, 31)
        Me.BtThoat.TabIndex = 12
        Me.BtThoat.Text = "Thoát"
        Me.BtThoat.UseVisualStyleBackColor = True
        '
        'BtDangKy
        '
        Me.BtDangKy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtDangKy.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BtDangKy.Location = New System.Drawing.Point(113, 245)
        Me.BtDangKy.Name = "BtDangKy"
        Me.BtDangKy.Size = New System.Drawing.Size(114, 31)
        Me.BtDangKy.TabIndex = 11
        Me.BtDangKy.Text = "Đăng Ký"
        Me.BtDangKy.UseVisualStyleBackColor = True
        '
        'TxtMatKhau
        '
        Me.TxtMatKhau.Location = New System.Drawing.Point(316, 163)
        Me.TxtMatKhau.Multiline = True
        Me.TxtMatKhau.Name = "TxtMatKhau"
        Me.TxtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtMatKhau.Size = New System.Drawing.Size(206, 27)
        Me.TxtMatKhau.TabIndex = 10
        '
        'TxtTenDN
        '
        Me.TxtTenDN.Location = New System.Drawing.Point(316, 113)
        Me.TxtTenDN.Multiline = True
        Me.TxtTenDN.Name = "TxtTenDN"
        Me.TxtTenDN.Size = New System.Drawing.Size(206, 26)
        Me.TxtTenDN.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Mật Khẩu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tên Đăng Nhập"
        '
        'TxtXacNhanMatKhau
        '
        Me.TxtXacNhanMatKhau.Location = New System.Drawing.Point(316, 210)
        Me.TxtXacNhanMatKhau.Multiline = True
        Me.TxtXacNhanMatKhau.Name = "TxtXacNhanMatKhau"
        Me.TxtXacNhanMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtXacNhanMatKhau.Size = New System.Drawing.Size(206, 27)
        Me.TxtXacNhanMatKhau.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 22)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nhập  Mật Khẩu"
        '
        'F_DangKy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuanLyCuaHangMT.My.Resources.Resources.pngtree_cartoon_computer_illustration_png_image_6567230
        Me.ClientSize = New System.Drawing.Size(619, 379)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtXacNhanMatKhau)
        Me.Controls.Add(Me.BtThoat)
        Me.Controls.Add(Me.BtDangKy)
        Me.Controls.Add(Me.TxtMatKhau)
        Me.Controls.Add(Me.TxtTenDN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "F_DangKy"
        Me.Text = "Đăng Ký"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtThoat As Button
    Friend WithEvents BtDangKy As Button
    Friend WithEvents TxtMatKhau As TextBox
    Friend WithEvents TxtTenDN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtXacNhanMatKhau As TextBox
    Friend WithEvents Label3 As Label
End Class
