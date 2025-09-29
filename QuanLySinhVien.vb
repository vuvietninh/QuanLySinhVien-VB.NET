Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class QuanLySinhVien

    ' Chuỗi kết nối SQL Server - ĐÃ SỬA LỖI SSL
    Dim connStr As String = "Data Source=.;Initial Catalog=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True"

    ' Khi form load
    Private Sub QuanLySinhVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadKhoa()
        LoadSinhVien()
        LamMoiDuLieu()

        ' Thêm dữ liệu ComboBox giới tính
        cboGioiTinh.Items.Clear()
        cboGioiTinh.Items.Add("Nam")
        cboGioiTinh.Items.Add("Nữ")
    End Sub

    ' ============================
    ' Load danh sách Khoa
    ' ============================
    Private Sub LoadKhoa()
        Try
            Using conn As New SqlConnection(connStr)
                Dim da As New SqlDataAdapter("SELECT * FROM Khoa", conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                cboKhoa.DataSource = dt
                cboKhoa.DisplayMember = "TenKhoa"
                cboKhoa.ValueMember = "MaKhoa" ' SỬA: thành "Makhoa" (chữ k thường)
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi tải danh sách khoa: " & ex.Message)
        End Try
    End Sub

    ' ============================
    ' Load danh sách Sinh viên
    ' ============================
    Private Sub LoadSinhVien()
        Try
            Using conn As New SqlConnection(connStr)
                Dim query As String = "SELECT S.*, K.TenKhoa FROM SinhVien S LEFT JOIN Khoa K ON S.MaKhoa = K.MaKhoa"
                Dim da As New SqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvSinhVien.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi tải danh sách sinh viên: " & ex.Message)
        End Try
    End Sub

    ' ============================
    ' Sự kiện click trên DataGridView - ĐÃ SỬA LỖI
    ' ============================
    Private Sub dgvSinhVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSinhVien.CellClick
        If e.RowIndex >= 0 Then
            Try
                Dim row As DataGridViewRow = dgvSinhVien.Rows(e.RowIndex)

                ' SỬA: Kiểm tra null trước khi gán giá trị
                If Not IsDBNull(row.Cells("MaSV").Value) Then
                    txtMaSV.Text = row.Cells("MaSV").Value.ToString()
                Else
                    txtMaSV.Text = ""
                End If

                If Not IsDBNull(row.Cells("TenSV").Value) Then
                    txtTenSV.Text = row.Cells("TenSV").Value.ToString()
                Else
                    txtTenSV.Text = ""
                End If

                txtSoDT.Text = If(IsDBNull(row.Cells("SoDT").Value), "", row.Cells("SoDT").Value.ToString())
                txtEmail.Text = If(IsDBNull(row.Cells("Email").Value), "", row.Cells("Email").Value.ToString())

                ' Xử lý ngày sinh
                If Not IsDBNull(row.Cells("NgaySinh").Value) Then
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells("NgaySinh").Value)
                Else
                    dtpNgaySinh.Value = DateTime.Now
                End If

                ' Xử lý giới tính
                If Not IsDBNull(row.Cells("GioiTinh").Value) Then
                    cboGioiTinh.Text = row.Cells("GioiTinh").Value.ToString()
                Else
                    cboGioiTinh.SelectedIndex = -1
                End If

                ' Xử lý khoa - SỬA: Thêm xử lý lỗi khi không tìm thấy SelectedValue
                

                ' Khóa mã SV khi sửa
                txtMaSV.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Lỗi tải dữ liệu sinh viên: " & ex.Message)
            End Try
        End If
    End Sub

    ' ============================
    ' Kiểm tra dữ liệu nhập
    ' ============================
    Private Function KiemTraDuLieu() As Boolean
        If String.IsNullOrEmpty(txtMaSV.Text.Trim()) Then
            MessageBox.Show("Vui lòng nhập Mã sinh viên!")
            txtMaSV.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtTenSV.Text.Trim()) Then
            MessageBox.Show("Vui lòng nhập Tên sinh viên!")
            txtTenSV.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(txtEmail.Text.Trim()) OrElse Not txtEmail.Text.Contains("@") Then
            MessageBox.Show("Vui lòng nhập Email hợp lệ!")
            txtEmail.Focus()
            Return False
        End If

        If cboGioiTinh.SelectedIndex = -1 Then
            MessageBox.Show("Vui lòng chọn Giới tính!")
            cboGioiTinh.Focus()
            Return False
        End If

        If cboKhoa.SelectedIndex = -1 Then
            MessageBox.Show("Vui lòng chọn Khoa!")
            cboKhoa.Focus()
            Return False
        End If

        Return True
    End Function

    ' ============================
    ' Thêm sinh viên
    ' ============================
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If Not KiemTraDuLieu() Then
            Return
        End If

        ' Kiểm tra mã sinh viên đã tồn tại chưa
        If KiemTraMaSVTonTai(txtMaSV.Text.Trim()) Then
            MessageBox.Show("Mã sinh viên đã tồn tại! Vui lòng nhập mã khác.")
            txtMaSV.Focus()
            Return
        End If

        Try
            Dim sql As String = "INSERT INTO SinhVien (MaSV, TenSV, SoDT, Email, NgaySinh, GioiTinh, MaKhoa) 
                             VALUES (@ma, @ten, @sdt, @mail, @ngaysinh, @gt, @khoa)"

            Using conn As New SqlConnection(connStr)
                conn.Open()
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ma", txtMaSV.Text.Trim())
                    cmd.Parameters.AddWithValue("@ten", txtTenSV.Text.Trim())
                    cmd.Parameters.AddWithValue("@sdt", If(String.IsNullOrEmpty(txtSoDT.Text), DBNull.Value, txtSoDT.Text.Trim()))
                    cmd.Parameters.AddWithValue("@mail", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@ngaysinh", dtpNgaySinh.Value)
                    cmd.Parameters.AddWithValue("@gt", cboGioiTinh.Text)
                    cmd.Parameters.AddWithValue("@khoa", cboKhoa.SelectedValue)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Thêm sinh viên thành công!")
            LoadSinhVien()
            LamMoiDuLieu()
        Catch ex As Exception
            MessageBox.Show("Lỗi thêm sinh viên: " & ex.Message)
        End Try
    End Sub

    ' ============================
    ' Sửa sinh viên
    ' ============================
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If String.IsNullOrEmpty(txtMaSV.Text.Trim()) Then
            MessageBox.Show("Vui lòng chọn sinh viên cần sửa!")
            Return
        End If

        If Not KiemTraDuLieu() Then
            Return
        End If

        Try
            Dim sql As String = "UPDATE SinhVien 
                             SET TenSV = @ten, SoDT = @sdt, Email = @mail, NgaySinh = @ngaysinh, GioiTinh = @gt, MaKhoa = @khoa 
                             WHERE MaSV = @ma"

            Using conn As New SqlConnection(connStr)
                conn.Open()
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ten", txtTenSV.Text.Trim())
                    cmd.Parameters.AddWithValue("@sdt", If(String.IsNullOrEmpty(txtSoDT.Text), DBNull.Value, txtSoDT.Text.Trim()))
                    cmd.Parameters.AddWithValue("@mail", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@ngaysinh", dtpNgaySinh.Value)
                    cmd.Parameters.AddWithValue("@gt", cboGioiTinh.Text)
                    cmd.Parameters.AddWithValue("@khoa", cboKhoa.SelectedValue)
                    cmd.Parameters.AddWithValue("@ma", txtMaSV.Text.Trim())

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Cập nhật sinh viên thành công!")
            LoadSinhVien()
            LamMoiDuLieu()
        Catch ex As Exception
            MessageBox.Show("Lỗi cập nhật sinh viên: " & ex.Message)
        End Try
    End Sub

    ' ============================
    ' Xóa sinh viên
    ' ============================
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If String.IsNullOrEmpty(txtMaSV.Text.Trim()) Then
            MessageBox.Show("Vui lòng chọn sinh viên cần xóa!")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên " & txtTenSV.Text & "?",
                                                   "Xác nhận xóa",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Dim sql As String = "DELETE FROM SinhVien WHERE MaSV = @ma"

                Using conn As New SqlConnection(connStr)
                    conn.Open()
                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@ma", txtMaSV.Text.Trim())
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Xóa sinh viên thành công!")
                LoadSinhVien()
                LamMoiDuLieu()
            Catch ex As Exception
                MessageBox.Show("Lỗi xóa sinh viên: " & ex.Message)
            End Try
        End If
    End Sub

    ' ============================
    ' Kiểm tra mã SV tồn tại
    ' ============================
    Private Function KiemTraMaSVTonTai(maSV As String) As Boolean
        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()
                Dim sql As String = "SELECT COUNT(*) FROM SinhVien WHERE MaSV = @ma"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@ma", maSV)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi kiểm tra mã SV: " & ex.Message)
            Return False
        End Try
    End Function

    ' ============================
    ' Làm mới form nhập
    ' ============================
    Private Sub btnLamMoi_Click(sender As Object, e As EventArgs) Handles btnLamMoi.Click
        LamMoiDuLieu()
    End Sub

    Private Sub LamMoiDuLieu()
        txtMaSV.Clear()
        txtTenSV.Clear()
        txtSoDT.Clear()
        txtEmail.Clear()
        dtpNgaySinh.Value = DateTime.Now
        cboGioiTinh.SelectedIndex = -1
        cboKhoa.SelectedIndex = -1
        txtMaSV.Enabled = True
    End Sub

    ' ============================
    ' Nút quay lại
    ' ============================

End Class