Public Class MyProfile

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Button1.Text = "Edit" Then
                Button1.Text = "Perbaharui"
                txt1.Enabled = True
                TextBox1.Enabled = True
                Button3.Visible = True
            Else
                Call koneksi()
                cmd = New SqlClient.SqlCommand("UPDATE TBL_USER SET NO_HP = '" & txt1.Text & "', ALAMAT = '" & TextBox1.Text & "' , PHOTO = '" & lokasi.Text & "' where NAMA = '" & Label1.Text & "' ", conn)
                cmd.ExecuteNonQuery()
                MsgBox("TerimaKasih, Profile Berhasil diperbaharui")
                txt1.Enabled = False
                TextBox1.Enabled = False
                Button1.Enabled = False
                Button3.Enabled = False
                Button2.Focus()

            End If
        Catch
            MsgBox("Aplikasi Erorr, Silahkan Hubungu Admin Aplikasi ", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MyProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt1.Enabled = False
        TextBox1.Enabled = False
        Button3.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        OpenFileDialog1.ShowDialog()

        lokasi.Text = OpenFileDialog1.FileName
        PictureBox1.ImageLocation = lokasi.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.TextChanged
        Call koneksi()
        cmd = New SqlClient.SqlCommand("SELECT USERID, NO_HP, ALAMAT, PHOTO FROM TBL_USER WHERE NAMA = '" & LoginUSER.TextBox1.Text & "'", conn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            Label1.Text = LoginUSER.TextBox1.Text

            Label4.Text = dr.Item("USERID")
            txt1.Text = dr.Item("NO_HP")
            TextBox1.Text = dr.Item("ALAMAT")
            lokasi.Text = dr.Item("PHOTO")
            PictureBox1.ImageLocation = lokasi.Text
        End If
    End Sub
End Class