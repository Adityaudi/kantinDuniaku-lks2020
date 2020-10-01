Imports System.Data.Sql
Imports System.Data.SqlClient

Module Module1
    Public conn As SqlConnection
    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public cmd As SqlCommand
    Public sql As String
    Public dt As DataTable

    Public Sub koneksi()
        sql = "Data Source=DESKTOP-L63F7SH;Initial Catalog=DB_KANTINSKENSA;Integrated Security=True"
        conn = New SqlConnection(sql)

        If conn.State = ConnectionState.Closed Then
            conn.Open()

        End If
    End Sub
End Module
