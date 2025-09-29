<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        btnQLSV = New Button()
        btnQLKhoa = New Button()
        btnThongTin = New Button()
        btnDangXuat = New Button()
        btnThoat = New Button()
        SuspendLayout()
        ' 
        ' btnQLSV
        ' 
        btnQLSV.Location = New Point(69, 39)
        btnQLSV.Name = "btnQLSV"
        btnQLSV.Size = New Size(156, 23)
        btnQLSV.TabIndex = 0
        btnQLSV.Text = "Quản Lý Sinh Viên"
        btnQLSV.UseVisualStyleBackColor = True
        ' 
        ' btnQLKhoa
        ' 
        btnQLKhoa.Location = New Point(69, 105)
        btnQLKhoa.Name = "btnQLKhoa"
        btnQLKhoa.Size = New Size(156, 23)
        btnQLKhoa.TabIndex = 0
        btnQLKhoa.Text = "Quản Lý Khoa"
        btnQLKhoa.UseVisualStyleBackColor = True
        ' 
        ' btnThongTin
        ' 
        btnThongTin.Location = New Point(69, 168)
        btnThongTin.Name = "btnThongTin"
        btnThongTin.Size = New Size(156, 23)
        btnThongTin.TabIndex = 0
        btnThongTin.Text = "Thông Tin"
        btnThongTin.UseVisualStyleBackColor = True
        ' 
        ' btnDangXuat
        ' 
        btnDangXuat.Location = New Point(69, 235)
        btnDangXuat.Name = "btnDangXuat"
        btnDangXuat.Size = New Size(156, 23)
        btnDangXuat.TabIndex = 0
        btnDangXuat.Text = "Đăng Xuất"
        btnDangXuat.UseVisualStyleBackColor = True
        ' 
        ' btnThoat
        ' 
        btnThoat.Location = New Point(69, 303)
        btnThoat.Name = "btnThoat"
        btnThoat.Size = New Size(156, 23)
        btnThoat.TabIndex = 0
        btnThoat.Text = "Thoát"
        btnThoat.UseVisualStyleBackColor = True
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(289, 394)
        Controls.Add(btnThoat)
        Controls.Add(btnDangXuat)
        Controls.Add(btnThongTin)
        Controls.Add(btnQLKhoa)
        Controls.Add(btnQLSV)
        Name = "Main"
        Text = "Main"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnQLSV As Button
    Friend WithEvents btnQLKhoa As Button
    Friend WithEvents btnThongTin As Button
    Friend WithEvents btnDangXuat As Button
    Friend WithEvents btnThoat As Button
End Class
