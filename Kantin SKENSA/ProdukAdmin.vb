Imports System.Data.SqlClient

Public Class ProdukAdmin
    Sub awal()
        no1.Visible = False
        no2.Visible = False
        no3.Visible = False
        no4.Visible = False
        no5.Visible = False
        no6.Visible = False

        PictureBox1.Enabled = False
        PictureBox2.Enabled = False
        PictureBox3.Enabled = False
        PictureBox4.Enabled = False
        PictureBox5.Enabled = False
        PictureBox6.Enabled = False

        txt1.Enabled = False
        txt2.Enabled = False
        txt3.Enabled = False
        txt4.Enabled = False
        txt5.Enabled = False
        txt6.Enabled = False
        txt7.Enabled = False
        txt8.Enabled = False
        txt9.Enabled = False
        txt10.Enabled = False
        txt11.Enabled = False
        txt12.Enabled = False

        
    End Sub

    Sub link()
        LinkLabel1.Visible = False
        LinkLabel2.Visible = False
        LinkLabel3.Visible = False
        LinkLabel4.Visible = False
        LinkLabel5.Visible = False
        LinkLabel6.Visible = False
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub ProdukAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call awal()

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()

        lokasi1.Text = OpenFileDialog1.FileName
        PictureBox1.ImageLocation = lokasi1.Text
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        OpenFileDialog2.ShowDialog()

        lokasi2.Text = OpenFileDialog2.FileName
        PictureBox2.ImageLocation = lokasi2.Text
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        OpenFileDialog3.ShowDialog()

        lokasi3.Text = OpenFileDialog3.FileName
        PictureBox3.ImageLocation = lokasi3.Text
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        OpenFileDialog4.ShowDialog()

        lokasi4.Text = OpenFileDialog4.FileName
        PictureBox4.ImageLocation = lokasi4.Text
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        OpenFileDialog5.ShowDialog()

        lokasi5.Text = OpenFileDialog5.FileName
        PictureBox5.ImageLocation = lokasi5.Text
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

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

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

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

    Private Sub kode6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kode6.Click

    End Sub

    Private Sub kode6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles kode6.TextChanged
        Call koneksi()
        cmd = New SqlCommand("SELECT * FROM TBL_PRODUK WHERE KODE = '" & kode6.Text & "'", conn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            txt11.Text = dr.Item("NAMA")
            txt12.Text = dr.Item("HARGA")
            lokasi8.Text = dr.Item("PHOTO")

            PictureBox6.ImageLocation = lokasi8.Text
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        no1.Visible = True
        Call link()

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        no2.Visible = True
        Call link()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        no3.Visible = True
        Call link()

    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        no4.Visible = True
        Call link()
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        no5.Visible = True
        Call link()

    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        no6.Visible = True
        Call link()

    End Sub

    Private Sub no6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no6.Click
        If no6.Text = "Edit" Then
            no6.Text = "Simpan"
            txt11.Enabled = True
            txt12.Enabled = True
            PictureBox6.Enabled = True

        Else
            Call koneksi()
            Dim update As String = "UPDATE TBL_PRODUK SET NAMA = '" & txt11.Text & "', HARGA = '" & txt12.Text & "' ,PHOTO = '" & lokasi8.Text & "' where KODE = '" & kode6.Text & "'"
            cmd = New SqlCommand(update, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Produk Berhasil diganti TerimaKasih", MsgBoxStyle.OkOnly)
            txt11.Enabled = False
            txt12.Enabled = False
            LinkLabel1.Visible = True
            LinkLabel2.Visible = True
            LinkLabel3.Visible = True
            LinkLabel4.Visible = True
            LinkLabel5.Visible = True
            LinkLabel6.Visible = True
            no6.Text = "Edit"
            no6.Visible = False
            PictureBox6.Enabled = False

        End If
    End Sub

    Private Sub no2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no2.Click
        If no2.Text = "Edit" Then
            no2.Text = "Simpan"
            txt3.Enabled = True
            txt4.Enabled = True
            PictureBox2.Enabled = True

        Else
            Call koneksi()
            Dim update As String = "UPDATE TBL_PRODUK SET NAMA = '" & txt3.Text & "', HARGA = '" & txt4.Text & "' ,PHOTO = '" & lokasi2.Text & "'  where KODE = '" & Label13.Text & "'"
            cmd = New SqlCommand(update, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Produk Berhasil diganti TerimaKasih", MsgBoxStyle.OkOnly)
            txt3.Enabled = False
            txt4.Enabled = False
            LinkLabel1.Visible = True
            LinkLabel2.Visible = True
            LinkLabel3.Visible = True
            LinkLabel4.Visible = True
            LinkLabel5.Visible = True
            LinkLabel6.Visible = True
            no2.Text = "Edit"
            no2.Visible = False
            PictureBox2.Enabled = False

        End If
    End Sub

    Private Sub no4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no4.Click
        If no4.Text = "Edit" Then
            no4.Text = "Simpan"
            txt7.Enabled = True
            txt8.Enabled = True
            PictureBox4.Enabled = True

        Else
            Call koneksi()
            Dim update As String = "UPDATE TBL_PRODUK SET NAMA = '" & txt7.Text & "', HARGA = '" & txt8.Text & "' ,PHOTO = '" & lokasi4.Text & "'  where KODE = '" & Label15.Text & "'"
            cmd = New SqlCommand(update, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Produk Berhasil diganti TerimaKasih", MsgBoxStyle.OkOnly)
            txt7.Enabled = False
            txt8.Enabled = False
            LinkLabel1.Visible = True
            LinkLabel2.Visible = True
            LinkLabel3.Visible = True
            LinkLabel4.Visible = True
            LinkLabel5.Visible = True
            LinkLabel6.Visible = True
            no4.Text = "Edit"
            no4.Visible = False
            PictureBox4.Enabled = False

        End If
    End Sub

    Private Sub no3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no3.Click
        If no3.Text = "Edit" Then
            no3.Text = "Simpan"
            txt5.Enabled = True
            txt6.Enabled = True
            PictureBox3.Enabled = True

        Else
            Call koneksi()
            Dim update As String = "UPDATE TBL_PRODUK SET NAMA = '" & txt5.Text & "', HARGA = '" & txt6.Text & "' ,PHOTO = '" & lokasi3.Text & " where KODE = '" & Label14.Text & "'"
            cmd = New SqlCommand(update, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Produk Berhasil diganti TerimaKasih", MsgBoxStyle.OkOnly)
            txt5.Enabled = False
            txt6.Enabled = False
            LinkLabel1.Visible = True
            LinkLabel2.Visible = True
            LinkLabel3.Visible = True
            LinkLabel4.Visible = True
            LinkLabel5.Visible = True
            LinkLabel6.Visible = True
            no3.Text = "Edit"
            no3.Visible = False
            PictureBox3.Enabled = False

        End If
    End Sub

    Private Sub no5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no5.Click
        If no5.Text = "Edit" Then
            no5.Text = "Simpan"
            txt9.Enabled = True
            txt10.Enabled = True
            PictureBox5.Enabled = True

        Else
            Call koneksi()
            Dim update As String = "UPDATE TBL_PRODUK SET NAMA = '" & txt9.Text & "', HARGA = '" & txt10.Text & "' ,PHOTO = '" & lokasi5.Text & "  where KODE = '" & Label16.Text & "'"
            cmd = New SqlCommand(update, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Produk Berhasil diganti TerimaKasih", MsgBoxStyle.OkOnly)
            txt9.Enabled = False
            txt10.Enabled = False
            LinkLabel1.Visible = True
            LinkLabel2.Visible = True
            LinkLabel3.Visible = True
            LinkLabel4.Visible = True
            LinkLabel5.Visible = True
            LinkLabel6.Visible = True
            no5.Text = "Edit"
            no5.Visible = False
            PictureBox5.Enabled = False

        End If
    End Sub

    Private Sub no1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no1.Click
        If no1.Text = "Edit" Then
            no1.Text = "Simpan"
            txt1.Enabled = True
            txt2.Enabled = True
            PictureBox1.Enabled = True

        Else
            Call koneksi()
            Dim update As String = "UPDATE TBL_PRODUK SET NAMA = '" & txt1.Text & "', HARGA = '" & txt2.Text & "' ,PHOTO = '" & lokasi1.Text & "'  where KODE = '" & Label12.Text & "'"
            cmd = New SqlCommand(update, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Produk Berhasil diganti TerimaKasih", MsgBoxStyle.OkOnly)
            txt1.Enabled = False
            txt2.Enabled = False
            LinkLabel1.Visible = True
            LinkLabel2.Visible = True
            LinkLabel3.Visible = True
            LinkLabel4.Visible = True
            LinkLabel5.Visible = True
            LinkLabel6.Visible = True
            no1.Text = "Edit"
            no1.Visible = False
            PictureBox1.Enabled = False

        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        OpenFileDialog6.ShowDialog()

        lokasi8.Text = OpenFileDialog6.FileName
        PictureBox6.ImageLocation = lokasi8.Text
    End Sub

    Private Sub txt2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt2.Leave

    End Sub


    Private Sub txt2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt2.TextChanged

    End Sub
End Class