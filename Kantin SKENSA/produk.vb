Imports System.Data.SqlClient

Public Class produk

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label12_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label12.TextChanged
        Call koneksi()
        cmd = New SqlCommand("SELECT * FROM TBL_PRODUK WHERE KODE = '" & Label12.Text & "'", conn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            txt1.Text = dr.Item("NAMA")
            txt2.Text = dr.Item("HARGA")
            lokasi1.Text = dr.Item("PHOTO")
            PictureBox1.ImageLocation = lokasi1.Text
        End If
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label13_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label13.TextChanged
        Call koneksi()
        cmd = New SqlCommand("SELECT * FROM TBL_PRODUK WHERE KODE = '" & Label13.Text & "'", conn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            txt3.Text = dr.Item("NAMA")
            txt4.Text = dr.Item("HARGA")
            lokasi2.Text = dr.Item("PHOTO")
            PictureBox2.ImageLocation = lokasi2.Text
        End If
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label14_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label14.TextChanged
        Call koneksi()
        cmd = New SqlCommand("SELECT * FROM TBL_PRODUK WHERE KODE = '" & Label14.Text & "'", conn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            txt5.Text = dr.Item("NAMA")
            txt6.Text = dr.Item("HARGA")
            lokasi3.Text = dr.Item("PHOTO")
            PictureBox3.ImageLocation = lokasi3.Text
        End If
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label15_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label15.TextChanged
        Call koneksi()
        cmd = New SqlCommand("SELECT * FROM TBL_PRODUK WHERE KODE = '" & Label15.Text & "'", conn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            txt7.Text = dr.Item("NAMA")
            txt8.Text = dr.Item("HARGA")
            lokasi4.Text = dr.Item("PHOTO")
            PictureBox4.ImageLocation = lokasi4.Text
        End If
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label16_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label16.TextChanged
        Call koneksi()
        cmd = New SqlCommand("SELECT * FROM TBL_PRODUK WHERE KODE = '" & Label16.Text & "'", conn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            txt9.Text = dr.Item("NAMA")
            txt10.Text = dr.Item("HARGA")
            lokasi5.Text = dr.Item("PHOTO")
            PictureBox5.ImageLocation = lokasi5.Text
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.TextChanged
        Call koneksi()
        cmd = New SqlCommand("SELECT * FROM TBL_PRODUK WHERE KODE = '" & Label4.Text & "'", conn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            txt11.Text = dr.Item("NAMA")
            txt12.Text = dr.Item("HARGA")
            lokasi6.Text = dr.Item("PHOTO")
            PictureBox6.ImageLocation = lokasi6.Text
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Keranjang.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class