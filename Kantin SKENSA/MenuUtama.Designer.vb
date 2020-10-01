<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.kasir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageKasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.user = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdukPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesananPembeliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MYpRFILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdukToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeranjangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtiltyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantiPasswordUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LaporanPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Lime
        Me.MenuStrip1.Font = New System.Drawing.Font("Comic Sans MS", 20.0!)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.kasir, Me.user, Me.ProdukToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.PesananPembeliToolStripMenuItem, Me.ProfileToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.UtiltyToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1380, 46)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(120, 42)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.KasirToolStripMenuItem, Me.UserToolStripMenuItem1})
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(178, 42)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 17.0!)
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(158, 36)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'KasirToolStripMenuItem
        '
        Me.KasirToolStripMenuItem.Font = New System.Drawing.Font("Comic Sans MS", 17.0!)
        Me.KasirToolStripMenuItem.Name = "KasirToolStripMenuItem"
        Me.KasirToolStripMenuItem.Size = New System.Drawing.Size(158, 36)
        Me.KasirToolStripMenuItem.Text = "Kasir"
        '
        'UserToolStripMenuItem1
        '
        Me.UserToolStripMenuItem1.Font = New System.Drawing.Font("Comic Sans MS", 17.0!)
        Me.UserToolStripMenuItem1.Name = "UserToolStripMenuItem1"
        Me.UserToolStripMenuItem1.Size = New System.Drawing.Size(158, 36)
        Me.UserToolStripMenuItem1.Text = "User"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(178, 42)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(178, 42)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'kasir
        '
        Me.kasir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageKasirToolStripMenuItem})
        Me.kasir.Name = "kasir"
        Me.kasir.Size = New System.Drawing.Size(93, 42)
        Me.kasir.Text = "Kasir"
        '
        'ManageKasirToolStripMenuItem
        '
        Me.ManageKasirToolStripMenuItem.Name = "ManageKasirToolStripMenuItem"
        Me.ManageKasirToolStripMenuItem.Size = New System.Drawing.Size(260, 42)
        Me.ManageKasirToolStripMenuItem.Text = "Manage Kasir"
        '
        'user
        '
        Me.user.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageUserToolStripMenuItem})
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(90, 42)
        Me.user.Text = "User"
        '
        'ManageUserToolStripMenuItem
        '
        Me.ManageUserToolStripMenuItem.Name = "ManageUserToolStripMenuItem"
        Me.ManageUserToolStripMenuItem.Size = New System.Drawing.Size(257, 42)
        Me.ManageUserToolStripMenuItem.Text = "Manage User"
        '
        'ProdukToolStripMenuItem
        '
        Me.ProdukToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdukPenjualanToolStripMenuItem})
        Me.ProdukToolStripMenuItem.Name = "ProdukToolStripMenuItem"
        Me.ProdukToolStripMenuItem.Size = New System.Drawing.Size(115, 42)
        Me.ProdukToolStripMenuItem.Text = "Produk"
        '
        'ProdukPenjualanToolStripMenuItem
        '
        Me.ProdukPenjualanToolStripMenuItem.Name = "ProdukPenjualanToolStripMenuItem"
        Me.ProdukPenjualanToolStripMenuItem.Size = New System.Drawing.Size(305, 42)
        Me.ProdukPenjualanToolStripMenuItem.Text = "Produk Penjualan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenjualanToolStripMenuItem, Me.LaporanPesananToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(127, 42)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanPenjualanToolStripMenuItem
        '
        Me.LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        Me.LaporanPenjualanToolStripMenuItem.Size = New System.Drawing.Size(317, 42)
        Me.LaporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan"
        '
        'PesananPembeliToolStripMenuItem
        '
        Me.PesananPembeliToolStripMenuItem.Name = "PesananPembeliToolStripMenuItem"
        Me.PesananPembeliToolStripMenuItem.Size = New System.Drawing.Size(230, 42)
        Me.PesananPembeliToolStripMenuItem.Text = "Pesanan Pembeli"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MYpRFILEToolStripMenuItem})
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(113, 42)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'MYpRFILEToolStripMenuItem
        '
        Me.MYpRFILEToolStripMenuItem.Name = "MYpRFILEToolStripMenuItem"
        Me.MYpRFILEToolStripMenuItem.Size = New System.Drawing.Size(215, 42)
        Me.MYpRFILEToolStripMenuItem.Text = "MyProfile"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdukToolStripMenuItem1, Me.KeranjangToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(150, 42)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'ProdukToolStripMenuItem1
        '
        Me.ProdukToolStripMenuItem1.Name = "ProdukToolStripMenuItem1"
        Me.ProdukToolStripMenuItem1.Size = New System.Drawing.Size(220, 42)
        Me.ProdukToolStripMenuItem1.Text = "Produk"
        '
        'KeranjangToolStripMenuItem
        '
        Me.KeranjangToolStripMenuItem.Name = "KeranjangToolStripMenuItem"
        Me.KeranjangToolStripMenuItem.Size = New System.Drawing.Size(220, 42)
        Me.KeranjangToolStripMenuItem.Text = "Keranjang"
        '
        'UtiltyToolStripMenuItem
        '
        Me.UtiltyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GantiPasswordUserToolStripMenuItem})
        Me.UtiltyToolStripMenuItem.Name = "UtiltyToolStripMenuItem"
        Me.UtiltyToolStripMenuItem.Size = New System.Drawing.Size(103, 42)
        Me.UtiltyToolStripMenuItem.Text = "Utilty"
        '
        'GantiPasswordUserToolStripMenuItem
        '
        Me.GantiPasswordUserToolStripMenuItem.Name = "GantiPasswordUserToolStripMenuItem"
        Me.GantiPasswordUserToolStripMenuItem.Size = New System.Drawing.Size(353, 42)
        Me.GantiPasswordUserToolStripMenuItem.Text = "Ganti Password User"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1380, 559)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Courier New", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(1116, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 53)
        Me.Label2.TabIndex = 1
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(1116, 91)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 27.0!)
        Me.Label1.Location = New System.Drawing.Point(46, 650)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(476, 64)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kantin SKENSA"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1380, 759)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.Snow
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.BorderWidth = 4
        Me.RectangleShape1.CornerRadius = 8
        Me.RectangleShape1.Location = New System.Drawing.Point(34, 639)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(764, 86)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'LaporanPesananToolStripMenuItem
        '
        Me.LaporanPesananToolStripMenuItem.Name = "LaporanPesananToolStripMenuItem"
        Me.LaporanPesananToolStripMenuItem.Size = New System.Drawing.Size(317, 42)
        Me.LaporanPesananToolStripMenuItem.Text = "Laporan Pesanan"
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(1380, 759)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuUtama"
        Me.Text = "MenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ProdukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PesananPembeliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdukToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeranjangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtiltyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents kasir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents user As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MYpRFILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KasirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdukPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GantiPasswordUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageKasirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanPesananToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
