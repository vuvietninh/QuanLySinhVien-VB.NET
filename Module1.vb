Imports Microsoft.Data.SqlClient
Imports System.Data

Module DatabaseModule
    Public connStr As String = "Server=.;Database=QuanLySinhVien;Integrated Security=True"

    Public Function GetDataTable(sql As String, Optional params As List(Of SqlParameter) = Nothing) As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Using cmd As New SqlCommand(sql, conn)
                If params IsNot Nothing Then
                    cmd.Parameters.AddRange(params.ToArray())
                End If
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function ExecuteNonQuery(sql As String, Optional params As List(Of SqlParameter) = Nothing) As Integer
        Dim result As Integer
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Using cmd As New SqlCommand(sql, conn)
                If params IsNot Nothing Then
                    cmd.Parameters.AddRange(params.ToArray())
                End If
                result = cmd.ExecuteNonQuery()
            End Using
        End Using
        Return result
    End Function
End Module
