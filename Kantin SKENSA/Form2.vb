Imports System.Data.SqlClient
Public Class Form2
    Sub tampil()
        Call koneksi()
        da = New SqlDataAdapter("select * from coba", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "coba")
        DataGridView1.DataSource = ds.Tables("coba")
        DataGridView1.Columns(0).DefaultCellStyle.Format = "Rp ###,###"
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampil()

    End Sub
End Class