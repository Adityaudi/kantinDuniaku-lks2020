Public Class GantiPassword

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub GantiPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Enabled = False
        TextBox3.Enabled = False

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            cmd = New SqlClient.SqlCommand("SELECT * FROM TBL_USER WHERE NAMA = '" & LoginUSER.TextBox1.Text & "' and PASSWORD = '" & TextBox1.Text & "'", conn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                TextBox1.Enabled = False
                TextBox3.Enabled = True
                TextBox2.Enabled = True
                Button4.Visible = True
            Else
                MsgBox("Password Lama salah, MAAF", MsgBoxStyle.Critical)
                TextBox1.Text = ""
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
       
    End Sub

    Private Sub Label4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.TextChanged
        Label4.Text = LoginUSER.TextBox1.Text

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox3.Text <> TextBox2.Text Then
            MsgBox("Password Baru tidak Sama, Silahkan Ulagi")
        Else
            Call koneksi()
            cmd = New SqlClient.SqlCommand("UPDATE TBL_USER SET PASSWORD = '" & TextBox2.Text & " ' WHERE NAMA = '" & LoginUSER.TextBox1.Text & "'", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Password Baru Berhasil diganti, TerimaKasih", MsgBoxStyle.Information)
            TextBox3.Text = ""
            TextBox2.Text = ""
            TextBox1.Text = ""
            TextBox3.Enabled = False
            TextBox2.Enabled = False
            TextBox1.Enabled = True
        End If
    End Sub
End Class