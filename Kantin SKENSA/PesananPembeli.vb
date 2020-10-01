Imports System.Data.SqlClient


Public Class PesananPembeli
    Sub tampil()
        Try
            Call koneksi()

            da = New SqlDataAdapter("SELECT PEMBELI, NAMA, HARGA, JUMLAH, TOTAL, DIBAYAR, KEMBALI, STATUS FROM TBL_PESANAN", conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "TBL_PESANAN")
            DataGridView1.DataSource = ds.Tables("TBL_PESANAN")

            DataGridView1.ReadOnly = True
            DataGridView1.Columns(4).DefaultCellStyle.Format = "Rp ###,###, ###"
            DataGridView1.Columns(5).DefaultCellStyle.Format = "Rp ###,###, ###"
            DataGridView1.Columns(6).DefaultCellStyle.Format = "Rp ###,###, ###"



            DataGridView1.Columns(0).Width = 120
            DataGridView1.Columns(1).Width = 100
            DataGridView1.Columns(2).Width = 80
            DataGridView1.Columns(3).Width = 50
            DataGridView1.Columns(4).Width = 80
            DataGridView1.Columns(5).Width = 80
            DataGridView1.Columns(6).Width = 80
            DataGridView1.Columns(7).Width = 120

            DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter

            DataGridView1.DefaultCellStyle.Font = New Font("Times New Roman", 10)
            DataGridView1.Columns(7).DefaultCellStyle.Font = New Font("Times New Roman", 10, FontStyle.Bold)
            With DataGridView1
                .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            End With
        Catch
            MsgBox("Pesanan Pembeli Erorr, Silahkan Hubungi Admin Aplikasi", MsgBoxStyle.Critical, "Erorr")
        End Try
    End Sub
    Private Sub PesananPembeli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampil()

        ComboBox1.Items.Add("Pesanan Sedang Diproses")
        ComboBox1.Items.Add("Menunggu Diambil Oleh Kasir")
        ComboBox1.Items.Add("Pesanan Selesai")
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
  
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call koneksi()

        Dim update As String = "UPDATE TBL_PESANAN SET STATUS = '" & ComboBox1.Text & "' WHERE PEMBELI = '" & TextBox1.Text & " '"
        Dim updateadmin As String = "UPDATE TBL_LAPORANADMIN SET STATUS = '" & ComboBox1.Text & "' WHERE PEMBELI = '" & TextBox1.Text & " '"
        cmd = New SqlCommand(update, conn)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand(updateadmin, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Status Berhasil diupdate, Oleh . . ", MsgBoxStyle.OkOnly)
        Label3.Visible = False
        Button1.Visible = False
        ComboBox1.Visible = False
        TextBox1.Text = ""
        Button2.Visible = False
        Call tampil()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
            If ComboBox1.Text = "Pesanan Sedang Diproses" Then
            Button1.Visible = True
            Button2.Visible = False
            ElseIf ComboBox1.Text = "Menunggu Diambil Oleh Kasir" Then
            Button1.Visible = True
            Button2.Visible = False
        ElseIf ComboBox1.Text = "Pesanan Selesai" Then
            Button2.Visible = True
            Button1.Visible = False
            End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call koneksi()

        Dim hapus As String = "DELETE TBL_PESANAN WHERE PEMBELI = '" & TextBox1.Text & "'"
        cmd = New SqlCommand(hapus, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Pesanan Selesai, TerimaKasih")
        Label3.Visible = False
        Button2.Visible = False
        ComboBox1.Visible = False
        TextBox1.Text = ""
        Button1.Visible = False
        Call tampil()

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        If DataGridView1.RowCount >= 0 Then
            Dim baris As Integer = 0
            With DataGridView1
                baris = DataGridView1.CurrentRow.Index
                TextBox1.Text = .Item(0, baris).Value
                Label3.Visible = True
                ComboBox1.Visible = True
            End With
        End If
    End Sub
End Class