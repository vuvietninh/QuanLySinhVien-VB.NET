Imports Microsoft.Data.SqlClient
Imports System.Data

Public Class DangNhap
    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap1.Click
        ' Kiểm tra dữ liệu nhập
        If String.IsNullOrWhiteSpace(txtTenDangNhap1.Text) OrElse String.IsNullOrWhiteSpace(txtMatKhau1.Text) Then
            MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!")
            Return
        End If

        ' Thử các connection string khác nhau
        Dim ketNoiThanhCong As Boolean = False

        ' Danh sách các connection string để thử
        Dim danhSachChuoiKetNoi As String() = {
            "Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True",
            "Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True",
            "Data Source=localhost;Initial Catalog=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True",
            "Data Source=.;Initial Catalog=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True",
            "Data Source=DESKTOP-28PTJI7;Initial Catalog=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True"
        }

        For Each connStr As String In danhSachChuoiKetNoi
            If KiemTraDangNhap(connStr) Then
                ketNoiThanhCong = True
                Exit For
            End If
        Next

        If Not ketNoiThanhCong Then
            MessageBox.Show("Không thể kết nối đến database! Vui lòng kiểm tra SQL Server.")
        End If
    End Sub

    Private Function KiemTraDangNhap(connStr As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap=@user AND MatKhau=@pass"

        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@user", txtTenDangNhap1.Text.Trim())
                    cmd.Parameters.AddWithValue("@pass", txtMatKhau1.Text.Trim())

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Đăng nhập thành công! (Kết nối: " & conn.DataSource & ")")

                        ' Ẩn form Đăng nhập và mở form chính
                        Me.Hide()
                        Dim f As New Main()
                        f.ShowDialog()
                        Me.Close()
                        Return True
                    Else
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!")
                        Return True ' Vẫn trả về True vì kết nối database thành công, chỉ sai thông tin đăng nhập
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Không hiển thị lỗi ở đây, để thử connection string tiếp theo
            Return False
        End Try
    End Function

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat1.Click
        Application.Exit()
    End Sub

    Private Sub DangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Có thể thêm code để test kết nối khi form load
        ' TestKetNoi()
    End Sub

    Private Sub TestKetNoi()
        ' Hàm test tất cả connection string
        Dim danhSachChuoi As String() = {
            "Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True",
            "Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True",
            "Data Source=localhost;Initial Catalog=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True",
            "Data Source=.;Initial Catalog=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True",
            "Data Source=DESKTOP-28PTJI7;Initial Catalog=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True"
        }

        For Each connStr As String In danhSachChuoi
            Try
                Using conn As New SqlConnection(connStr)
                    conn.Open()
                    MessageBox.Show("Kết nối thành công với: " & conn.DataSource, "Thành công")
                    Exit For
                End Using
            Catch ex As Exception
                ' Tiếp tục thử connection string tiếp theo
            End Try
        Next
    End Sub
End Class