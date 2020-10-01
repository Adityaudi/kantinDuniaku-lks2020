Imports System.Data.SqlClient

Public Class LoginUSER

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            If TextBox2.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Login Gagal, Anda belum Mengisi Nama & Password")
            Else
                Call koneksi()
                cmd = New SqlCommand("SELECT * FROM TBL_USER WHERE NAMA = '" & TextBox1.Text & "' AND PASSWORD = '" & TextBox2.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()

                If Not dr.HasRows Then
                    Label4.Text = "Invalid Username atau Password"
                    TextBox2.Text = ""
                Else
                If dr("AKSES").ToString = "user" Then
                    Me.Close()

                    GantiPassword.Label4.Text = TextBox1.Text
                    MyProfile.Label1.Text = TextBox1.Text
                    Keranjang.pembeli.Text = TextBox1.Text

                    MenuUtama.ProfileToolStripMenuItem.Visible = True
                    MenuUtama.TransaksiToolStripMenuItem.Visible = True
                    MenuUtama.UtiltyToolStripMenuItem.Visible = True

                    MenuUtama.LoginToolStripMenuItem.Enabled = False
                    MenuUtama.LogoutToolStripMenuItem.Enabled = True

                End If
                End If
                    End If
    End Sub

    Private Sub LoginUSER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
End Class