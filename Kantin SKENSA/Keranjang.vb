Imports System.Data.SqlClient

Public Class Keranjang
    Sub buatkolom()
        DataGridView1.Columns.Add("KODE", "Kode Produk")
        DataGridView1.Columns.Add("NAMA", "Nama Produk")
        DataGridView1.Columns.Add("HARGA", "Harga")
        DataGridView1.Columns.Add("JUMLAH", "Jumlah Pesanan")
        DataGridView1.Columns.Add("TOTAL", "Total Belanja")
        DataGridView1.ReadOnly = True
        With DataGridView1
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Lime
        End With
    End Sub
    Sub uniknich()
        Call koneksi()

        cmd = New SqlCommand("SELECT ORDER_ID FROM TBL_PESANAN where ORDER_ID IN(SELECT MAX(ORDER_ID) FROM TBL_PESANAN)", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            UNIK.Text = "12320" + "1"
            conn.Close()
        Else
            Dim cekUNIK = Microsoft.VisualBasic.Right(dr.GetInt32(0), 3) + 1
            UNIK.Text = "12320" + Microsoft.VisualBasic.Right("12320" & cekUNIK, 3)
        End If
    End Sub
    Private Sub JAM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JAM.Click

    End Sub

    Private Sub Keranjang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TANGGAL.Text = Today
        Call buatkolom()
        Call uniknich()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        JAM.Text = TimeOfDay

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New SqlCommand("SELECT * FROM TBL_PRODUK WHERE KODE = '" & TextBox1.Text & "'", conn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                TextBox1.Text = dr.Item("KODE")
                nama.Text = dr.Item("NAMA")
                harga.Text = dr.Item("HARGA")
                harga.Text = FormatCurrency(harga.Text, 0)
                TextBox1.Enabled = False
                jumlah.Enabled = True
                Button4.Visible = True
                RectangleShape1.Visible = True
            Else
                MsgBox("Kode Barang tidak ditemukan, Silahkan Cek Kembali", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Or nama.Text = "" Or jumlah.Text = "" Then
            MsgBox("Belum bisa dipesan, Silahkan Masukan Kode Pesanan Anda atau Nama Barang nya", MsgBoxStyle.Critical)
        Else
            DataGridView1.Rows.Add(New String() {TextBox1.Text, nama.Text, harga.Text, jumlah.Text, Val(Microsoft.VisualBasic.Str(harga.Text)) * Val(jumlah.Text)})
            Call hasil()
            total.Text = FormatCurrency(total.Text, 0)
            TextBox1.Enabled = True
            jumlah.Enabled = False
            Button4.Visible = False
            RectangleShape1.Visible = False
            Button1.Enabled = True
            Button2.Enabled = True
            Button1.Focus()
            jumlah.Text = ""
            nama.Text = ""
            harga.Text = ""
            'TextBox1.Text = ""
            'nama.Text = ""
            'harga.Text = ""
            'jumlah.Text = "'"
            'Call coba()
        End If

    End Sub
    Sub hasil()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(4).Value
            total.Text = hitung
        Next
    End Sub
    Private Sub dibayar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dibayar.KeyPress

        If e.KeyChar = Chr(13) Then
            dibayar.Text = FormatCurrency(dibayar.Text, 0)
            If Val(Microsoft.VisualBasic.Str(dibayar.Text)) < Val(Microsoft.VisualBasic.Str(total.Text)) Then
                MsgBox("Pembayaraan Anda Kurang, TerimaKasih", MsgBoxStyle.Critical)
            ElseIf Val(Microsoft.VisualBasic.Str(dibayar.Text)) = Val(Microsoft.VisualBasic.Str(total.Text)) Then
                kembali.Text = 0
                kembali.Text = FormatCurrency(kembali.Text, 0)
            ElseIf Val(Microsoft.VisualBasic.Str(dibayar.Text)) > Val(Microsoft.VisualBasic.Str(total.Text)) Then
                kembali.Text = Val(Microsoft.VisualBasic.Str(dibayar.Text)) - Val(Microsoft.VisualBasic.Str(total.Text))
                kembali.Text = FormatCurrency(kembali.Text, 0)
            End If
        End If

    End Sub
    Private Sub dibayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dibayar.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        jumlah.Enabled = False
        DataGridView1.Columns.Clear()
        Call buatkolom()
        kembali.Text = ""
        total.Text = ""
        nama.Text = ""
        harga.Text = ""
        TextBox1.Enabled = True
        dibayar.Text = ""
        jumlah.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

            Call koneksi()

            For baris1 As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim input As String = "INSERT INTO TBL_PESANAN VALUES ('" & UNIK.Text & "' ,  '" & DataGridView1.Rows(baris1).Cells(0).Value & "', '" & DataGridView1.Rows(baris1).Cells(1).Value & "', '" & Microsoft.VisualBasic.Str(DataGridView1.Rows(baris1).Cells(2).Value) & "', '" & DataGridView1.Rows(baris1).Cells(3).Value & "', '" & Microsoft.VisualBasic.Str(total.Text) & "',  '" & Microsoft.VisualBasic.Str(dibayar.Text) & "', '" & Microsoft.VisualBasic.Str(kembali.Text) & "', '" & pembeli.Text & "', '" & status.Text & "')"
                Dim inputadmin As String = "INSERT INTO TBL_LAPORANADMIN VALUES ('" & DataGridView1.Rows(baris1).Cells(0).Value & "', '" & DataGridView1.Rows(baris1).Cells(1).Value & "', '" & Microsoft.VisualBasic.Str(DataGridView1.Rows(baris1).Cells(2).Value) & "', '" & DataGridView1.Rows(baris1).Cells(3).Value & "',  '" & DataGridView1.Rows(baris1).Cells(4).Value & "',  '" & Microsoft.VisualBasic.Str(dibayar.Text) & "', '" & Microsoft.VisualBasic.Str(kembali.Text) & "', '" & pembeli.Text & "', '" & JAM.Text & "' , '" & TANGGAL.Text & "', '" & status.Text & "')"
                cmd = New SqlCommand(input, conn)
                cmd.ExecuteNonQuery()
                cmd = New SqlCommand(inputadmin, conn)
                cmd.ExecuteNonQuery()
            Next
            MsgBox("TerimaKasih Telah Memesan, Pesanan Anda Akan Diantarakan Oleh Kasir", MsgBoxStyle.Information, "Sukses...")

            jumlah.Enabled = False
            DataGridView1.Columns.Clear()
            Call buatkolom()
            kembali.Text = ""
            total.Text = ""
            nama.Text = ""
            harga.Text = ""
            TextBox1.Enabled = True
            dibayar.Text = ""
            jumlah.Text = ""
            TextBox1.Text = ""
            UNIK.Text = ""
            Button4.Visible = False
            RectangleShape1.Visible = False
            Call uniknich()
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Focus()

    End Sub

    Private Sub pembeli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pembeli.Click

    End Sub

    Private Sub pembeli_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles pembeli.TextChanged
        pembeli.Text = LoginUSER.TextBox1.Text
    End Sub

    Private Sub total_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total.Click

    End Sub

    Private Sub harga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles harga.Click

    End Sub

    Private Sub harga_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles harga.Leave

    End Sub

    Private Sub harga_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles harga.TextChanged

    End Sub

    Private Sub total_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles total.TextChanged

    End Sub

    Private Sub kembali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kembali.Click

    End Sub

    Private Sub kembali_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles kembali.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub UNIK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UNIK.Click

    End Sub

    Private Sub UNIK_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UNIK.TextChanged

    End Sub
End Class