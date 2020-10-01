Imports System.Data.SqlClient

Public Class loginKASIR

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Login Gagal, Anda belum Mengisi Nama & Password")
        Else
            Call koneksi()
            cmd = New SqlCommand("SELECT * FROM TBL_KASIR WHERE NAMA = '" & TextBox2.Text & "' AND PASSWORD = '" & TextBox1.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()

            If Not dr.HasRows Then
                Label4.Text = "Invalid Username atau Password"
            Else
                If dr("AKSES").ToString = "kasir" Then
                    Me.Close()
                    MenuUtama.PesananPembeliToolStripMenuItem.Visible = True
                    MenuUtama.TransaksiToolStripMenuItem.Visible = True

                    MenuUtama.LoginToolStripMenuItem.Enabled = False
                    MenuUtama.LogoutToolStripMenuItem.Enabled = True
                ElseIf dr("AKSES").ToString = "admin" Then
                    Me.Close()
                    MenuUtama.kasir.Visible = True
                    MenuUtama.user.Visible = True
                    MenuUtama.ProdukToolStripMenuItem.Visible = True
                    MenuUtama.LaporanToolStripMenuItem.Visible = True

                    MenuUtama.LoginToolStripMenuItem.Enabled = False
                    MenuUtama.LogoutToolStripMenuItem.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            TextBox1.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub loginKASIR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.UseSystemPasswordChar = True
    End Sub
End Class