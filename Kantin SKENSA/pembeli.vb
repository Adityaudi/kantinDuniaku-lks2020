Imports System.Data.SqlClient

Public Class Status_Pesanan_Pembeli
    Sub tampil()
        Call koneksi()
        da = New SqlDataAdapter("SELECT PEMBELI, JAM, TANGGAL, NAMA, HARGA, JUMLAH, TOTAL, STATUS FROM TBL_LAPORANADMIN ", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "TBL_LAPORANADMIN")
        DataGridView1.DataSource = ds.Tables("TBL_LAPORANADMIN")
        DataGridView1.Columns(4).DefaultCellStyle.Format = "Rp ###,###"
        DataGridView1.Columns(6).DefaultCellStyle.Format = "Rp  ###,###"
        Try
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 80
            DataGridView1.Columns(2).Width = 80
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(4).Width = 100
            DataGridView1.Columns(5).Width = 50
            DataGridView1.Columns(6).Width = 100

            DataGridView1.Columns(0).HeaderText = "Konsumen"
            DataGridView1.Columns(1).HeaderText = "Jam "
            DataGridView1.Columns(2).HeaderText = "Tanggal"
            DataGridView1.Columns(3).HeaderText = "Nama Menu"
            DataGridView1.Columns(4).HeaderText = "Harga"
            DataGridView1.Columns(5).HeaderText = "Jumlah"
            DataGridView1.Columns(6).HeaderText = "Total"

            DataGridView1.DefaultCellStyle.Font = New Font("Times New Roman", 10)

            DataGridView1.Columns(0).HeaderCell.Style.Font = New Font("Microsoft Sans Serif", 7, FontStyle.Bold)
            DataGridView1.Columns(1).HeaderCell.Style.Font = New Font("Microsoft Sans Serif", 7, FontStyle.Bold)
            DataGridView1.Columns(2).HeaderCell.Style.Font = New Font("Microsoft Sans Serif", 7, FontStyle.Bold)
            DataGridView1.Columns(3).HeaderCell.Style.Font = New Font("Microsoft Sans Serif", 7, FontStyle.Bold)
            DataGridView1.Columns(4).HeaderCell.Style.Font = New Font("Microsoft Sans Serif", 7, FontStyle.Bold)
            DataGridView1.Columns(5).HeaderCell.Style.Font = New Font("Microsoft Sans Serif", 7, FontStyle.Bold)
            DataGridView1.Columns(6).HeaderCell.Style.Font = New Font("Microsoft Sans Serif", 7, FontStyle.Bold)

            DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            With DataGridView1
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Silver
            End With
            Call hasil()
        Catch
            MsgBox("Laporan ada masalah, Silahkan Hubungi Admin")
        End Try '
    End Sub
    Sub hasil()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(6).Value
            Label3.Text = hitung
            Label3.Text = FormatCurrency(Label3.Text, 0)
        Next
    End Sub
    Private Sub Status_Pesanan_Pembeli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampil()
        Call hasil()

        ComboBox1.Items.Add("Januari")
        ComboBox1.Items.Add("Febuari")
        ComboBox1.Items.Add("Maret")
        ComboBox1.Items.Add("April")
        ComboBox1.Items.Add("Mei")
        ComboBox1.Items.Add("Juni")
        ComboBox1.Items.Add("Juli")
        ComboBox1.Items.Add("Agustus")
        ComboBox1.Items.Add("September")
        ComboBox1.Items.Add("Oktober")
        ComboBox1.Items.Add("November")
        ComboBox1.Items.Add("Desember")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Call koneksi()
        Dim input As String = "UPDATE TBL_REPORT SET Pendapatan = '" & Microsoft.VisualBasic.Str(Label3.Text) & "' WHERE Bulan = '" & ComboBox1.Text & "'"
        cmd = New SqlClient.SqlCommand(input, conn)
        cmd.ExecuteNonQuery()
        LaporanBulanan.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
     
    End Sub

 
    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Januari" Then
            Button4.Visible = True
        ElseIf ComboBox1.Text = "Febuari" Then
            Button4.Visible = True
        ElseIf ComboBox1.Text = "Maret" Then
            Button4.Visible = True
        ElseIf ComboBox1.Text = "April" Then
            Button4.Visible = True
        ElseIf ComboBox1.Text = "Mei" Then
            Button4.Visible = True
        ElseIf ComboBox1.Text = "Juni" Then
            Button4.Visible = True
        ElseIf ComboBox1.Text = "Juli" Then
            Button4.Visible = True
        ElseIf ComboBox1.Text = "Agustus" Then
            Button4.Visible = True
        ElseIf ComboBox1.Text = "September" Then
            Button4.Visible = True
        ElseIf ComboBox1.Text = "Oktober" Then
            Button4.Visible = True
        ElseIf ComboBox1.Text = "November" Then
            Button4.Visible = True
        ElseIf ComboBox1.Text = "Desember" Then
            Button4.Visible = True
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class