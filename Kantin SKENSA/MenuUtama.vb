Public Class MenuUtama

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = TimeOfDay

    End Sub

    Private Sub ManageUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageUserToolStripMenuItem.Click
        ManageUSER.ShowDialog()
    End Sub


    Private Sub MenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        user.Visible = False
        kasir.Visible = False
        ProdukToolStripMenuItem.Visible = False
        LaporanToolStripMenuItem.Visible = False
        PesananPembeliToolStripMenuItem.Visible = False
        ProfileToolStripMenuItem.Visible = False
        TransaksiToolStripMenuItem.Visible = False
        UtiltyToolStripMenuItem.Visible = False


        LogoutToolStripMenuItem.Enabled = False
    End Sub

    Private Sub ProdukToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdukToolStripMenuItem.Click

    End Sub

    Private Sub ProdukPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdukPenjualanToolStripMenuItem.Click
        ProdukAdmin.ShowDialog()

    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        user.Visible = False
        kasir.Visible = False
        ProdukToolStripMenuItem.Visible = False
        LaporanToolStripMenuItem.Visible = False
        PesananPembeliToolStripMenuItem.Visible = False
        ProfileToolStripMenuItem.Visible = False
        TransaksiToolStripMenuItem.Visible = False
        UtiltyToolStripMenuItem.Visible = False

        LogoutToolStripMenuItem.Enabled = False
        LoginToolStripMenuItem.Enabled = True
        loginKASIR.TextBox1.Text = ""
        loginKASIR.TextBox2.Text = ""
        LoginUSER.TextBox1.Text = ""
        LoginUSER.TextBox1.Text = ""
    End Sub

    Private Sub KasirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KasirToolStripMenuItem.Click
        loginKASIR.ShowDialog()
    End Sub

    Private Sub AdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminToolStripMenuItem.Click
        loginKASIR.ShowDialog()
    End Sub

    Private Sub GantiPasswordUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GantiPasswordUserToolStripMenuItem.Click
        GantiPassword.ShowDialog()

    End Sub

    Private Sub KeranjangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeranjangToolStripMenuItem.Click
        produk.ShowDialog()

    End Sub

    Private Sub ProdukToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProdukToolStripMenuItem1.Click
        produk.ShowDialog()

    End Sub

    Private Sub UserToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem1.Click
        LoginUSER.ShowDialog()

    End Sub

    Private Sub MYpRFILEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MYpRFILEToolStripMenuItem.Click
        MyProfile.ShowDialog()

    End Sub

    Private Sub kasir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kasir.Click

    End Sub

    Private Sub ManageKasirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageKasirToolStripMenuItem.Click
        ManageKasir.ShowDialog()

    End Sub

    Private Sub LaporanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanToolStripMenuItem.Click
      
    End Sub

    Private Sub PesananPembeliToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PesananPembeliToolStripMenuItem.Click
        PesananPembeli.ShowDialog()

    End Sub

    Private Sub GoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LaporanPesananToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPesananToolStripMenuItem.Click
        Status_Pesanan_Pembeli.ShowDialog()
        Status_Pesanan_Pembeli.DataGridView1.Visible = True
        Status_Pesanan_Pembeli.ComboBox1.Visible = False
        Status_Pesanan_Pembeli.Button1.Visible = False
        Status_Pesanan_Pembeli.Label4.Visible = False
        Status_Pesanan_Pembeli.ComboBox1.Visible = False
        Status_Pesanan_Pembeli.ComboBox1.Items.Clear()
    End Sub

    Private Sub LaporanPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        Status_Pesanan_Pembeli.ShowDialog()
        Status_Pesanan_Pembeli.DataGridView1.Visible = False
        Status_Pesanan_Pembeli.Button1.Visible = True
        Status_Pesanan_Pembeli.Label4.Visible = True
        Status_Pesanan_Pembeli.ComboBox1.Visible = True
        Status_Pesanan_Pembeli.ComboBox1.Items.Clear()
    End Sub
End Class