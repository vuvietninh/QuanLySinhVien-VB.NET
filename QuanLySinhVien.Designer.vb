<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuanLySinhVien
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
        txtMaSV = New TextBox()
        Label2 = New Label()
        txtTenSV = New TextBox()
        Label3 = New Label()
        txtSoDT = New TextBox()
        Label4 = New Label()
        txtEmail = New TextBox()
        Label5 = New Label()
        dtpNgaySinh = New DateTimePicker()
        Label6 = New Label()
        cboGioiTinh = New ComboBox()
        Label7 = New Label()
        cboKhoa = New ComboBox()
        btnThem = New Button()
        btnSua = New Button()
        btnXoa = New Button()
        btnLamMoi = New Button()
        dgvSinhVien = New DataGridView()
        CType(dgvSinhVien, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(61, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 0
        Label1.Text = "Mã sinh viên"
        ' 
        ' txtMaSV
        ' 
        txtMaSV.Location = New Point(178, 30)
        txtMaSV.Name = "txtMaSV"
        txtMaSV.Size = New Size(150, 23)
        txtMaSV.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(61, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 2
        Label2.Text = "Tên sinh viên"
        ' 
        ' txtTenSV
        ' 
        txtTenSV.Location = New Point(178, 65)
        txtTenSV.Name = "txtTenSV"
        txtTenSV.Size = New Size(150, 23)
        txtTenSV.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(61, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 15)
        Label3.TabIndex = 4
        Label3.Text = "Số điện thoại"
        ' 
        ' txtSoDT
        ' 
        txtSoDT.Location = New Point(178, 100)
        txtSoDT.Name = "txtSoDT"
        txtSoDT.Size = New Size(150, 23)
        txtSoDT.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(67, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 6
        Label4.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(178, 138)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(150, 23)
        txtEmail.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(61, 180)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 15)
        Label5.TabIndex = 8
        Label5.Text = "Ngày sinh"
        ' 
        ' dtpNgaySinh
        ' 
        dtpNgaySinh.Format = DateTimePickerFormat.Short
        dtpNgaySinh.Location = New Point(178, 174)
        dtpNgaySinh.Name = "dtpNgaySinh"
        dtpNgaySinh.Size = New Size(150, 23)
        dtpNgaySinh.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(61, 222)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 15)
        Label6.TabIndex = 10
        Label6.Text = "Giới tính"
        ' 
        ' cboGioiTinh
        ' 
        cboGioiTinh.FormattingEnabled = True
        cboGioiTinh.Location = New Point(178, 214)
        cboGioiTinh.Name = "cboGioiTinh"
        cboGioiTinh.Size = New Size(150, 23)
        cboGioiTinh.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(61, 263)
        Label7.Name = "Label7"
        Label7.Size = New Size(34, 15)
        Label7.TabIndex = 12
        Label7.Text = "Khoa"
        ' 
        ' cboKhoa
        ' 
        cboKhoa.FormattingEnabled = True
        cboKhoa.Items.AddRange(New Object() {"Toán", "Văn", "Anh"})
        cboKhoa.Location = New Point(178, 255)
        cboKhoa.Name = "cboKhoa"
        cboKhoa.Size = New Size(150, 23)
        cboKhoa.TabIndex = 13
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(438, 69)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(81, 54)
        btnThem.TabIndex = 14
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.Location = New Point(609, 69)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(85, 54)
        btnSua.TabIndex = 15
        btnSua.Text = "Sửa"
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(609, 161)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(85, 53)
        btnXoa.TabIndex = 16
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnLamMoi
        ' 
        btnLamMoi.Location = New Point(438, 161)
        btnLamMoi.Name = "btnLamMoi"
        btnLamMoi.Size = New Size(81, 53)
        btnLamMoi.TabIndex = 17
        btnLamMoi.Text = "Làm mới"
        btnLamMoi.UseVisualStyleBackColor = True
        ' 
        ' dgvSinhVien
        ' 
        dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSinhVien.Location = New Point(30, 313)
        dgvSinhVien.Name = "dgvSinhVien"
        dgvSinhVien.Size = New Size(746, 150)
        dgvSinhVien.TabIndex = 18
        ' 
        ' QuanLySinhVien
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 469)
        Controls.Add(dgvSinhVien)
        Controls.Add(btnLamMoi)
        Controls.Add(btnXoa)
        Controls.Add(btnSua)
        Controls.Add(btnThem)
        Controls.Add(cboKhoa)
        Controls.Add(Label7)
        Controls.Add(cboGioiTinh)
        Controls.Add(Label6)
        Controls.Add(dtpNgaySinh)
        Controls.Add(Label5)
        Controls.Add(txtEmail)
        Controls.Add(Label4)
        Controls.Add(txtSoDT)
        Controls.Add(Label3)
        Controls.Add(txtTenSV)
        Controls.Add(Label2)
        Controls.Add(txtMaSV)
        Controls.Add(Label1)
        Name = "QuanLySinhVien"
        Text = "QuanLySinhVien"
        CType(dgvSinhVien, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTenSV As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSoDT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpNgaySinh As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents cboGioiTinh As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboKhoa As ComboBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnLamMoi As Button
    Friend WithEvents dgvSinhVien As DataGridView
End Class
