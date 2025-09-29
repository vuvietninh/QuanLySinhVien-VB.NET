Public Class Main
    Private Sub btnQLSV_Click(sender As Object, e As EventArgs) Handles btnQLSV.Click
        ' Mở form QuanLySinhVien
        Dim formQLSV As New QuanLySinhVien()
        formQLSV.Show()  ' Hoặc formQLSV.ShowDialog() nếu muốn form modal
    End Sub

    Private Sub btnQLKhoa_Click(sender As Object, e As EventArgs) Handles btnQLKhoa.Click
        MessageBox.Show("Chức năng quản lý khoa đang phát triển")
    End Sub

    Private Sub btnThongTin_Click(sender As Object, e As EventArgs) Handles btnThongTin.Click
        MessageBox.Show("PHẦN MỀM QUẢN LÝ SINH VIÊN v1.0")
    End Sub

    Private Sub btnDangXuat_Click(sender As Object, e As EventArgs) Handles btnDangXuat.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim loginForm As New DangNhap()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class