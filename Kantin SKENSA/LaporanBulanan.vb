Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class LaporanBulanan
   
    Private Sub LaporanBulanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call koneksi()
       
        cmd = New SqlCommand("SELECT Bulan, Pendapatan FROM TBL_REPORT WHERE TGL BETWEEN @d4 and @d5 ", conn)
        da = New SqlDataAdapter(cmd)

        da.SelectCommand.Parameters.AddWithValue("@d4", DateTimePicker1.Value.ToString("yyyyMMdd"))
        da.SelectCommand.Parameters.AddWithValue("@d5", DateTimePicker2.Value.ToString("yyyyMMdd"))
        ds = New DataSet

        da.Fill(ds, "TBL_REPORT")

        Chart1.ChartAreas(0).AxisX.Interval = 1
        Chart1.Series("Pendapatan").XValueMember = "Bulan"
        Chart1.Series("Pendapatan").YValueMembers = "Pendapatan"

        DataGridView1.DataSource = ds.Tables("TBL_REPORT")
        Chart1.DataSource = ds.Tables("TBL_REPORT")
        DataGridView1.Columns(1).DefaultCellStyle.Format = "N2"
        With DataGridView1
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        End With
        DataGridView1.DefaultCellStyle.Font = New Font("Times new roman", 10)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
     
    End Sub
End Class