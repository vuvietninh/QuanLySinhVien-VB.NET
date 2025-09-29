<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DangNhap
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
        Label1 = New Label()
        Label2 = New Label()
        txtTenDangNhap1 = New TextBox()
        txtMatKhau1 = New TextBox()
        btnThoat1 = New Button()
        btnDangNhap1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(106, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 15)
        Label1.TabIndex = 0
        Label1.Text = "Tên Đăng Nhập"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(106, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 15)
        Label2.TabIndex = 0
        Label2.Text = "Mật Khẩu"
        ' 
        ' txtTenDangNhap1
        ' 
        txtTenDangNhap1.Location = New Point(261, 36)
        txtTenDangNhap1.Name = "txtTenDangNhap1"
        txtTenDangNhap1.Size = New Size(213, 23)
        txtTenDangNhap1.TabIndex = 1
        ' 
        ' txtMatKhau1
        ' 
        txtMatKhau1.Location = New Point(261, 68)
        txtMatKhau1.Name = "txtMatKhau1"
        txtMatKhau1.Size = New Size(213, 23)
        txtMatKhau1.TabIndex = 1
        ' 
        ' btnThoat1
        ' 
        btnThoat1.Location = New Point(274, 120)
        btnThoat1.Name = "btnThoat1"
        btnThoat1.Size = New Size(92, 33)
        btnThoat1.TabIndex = 2
        btnThoat1.Text = "Thoát"
        btnThoat1.UseVisualStyleBackColor = True
        ' 
        ' btnDangNhap1
        ' 
        btnDangNhap1.Location = New Point(126, 120)
        btnDangNhap1.Name = "btnDangNhap1"
        btnDangNhap1.Size = New Size(92, 33)
        btnDangNhap1.TabIndex = 2
        btnDangNhap1.Text = "Đăng nhập"
        btnDangNhap1.UseVisualStyleBackColor = True
        ' 
        ' DangNhap
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(544, 228)
        Controls.Add(btnDangNhap1)
        Controls.Add(btnThoat1)
        Controls.Add(txtMatKhau1)
        Controls.Add(txtTenDangNhap1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "DangNhap"
        Text = "DangNhap"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTenDangNhap1 As TextBox
    Friend WithEvents txtMatKhau1 As TextBox
    Friend WithEvents btnThoat1 As Button
    Friend WithEvents btnDangNhap1 As Button
End Class
