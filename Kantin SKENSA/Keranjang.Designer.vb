<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Keranjang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TANGGAL = New System.Windows.Forms.Label()
        Me.JAM = New System.Windows.Forms.Label()
        Me.pembeli = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.harga = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.Label()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.haha = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.kembali = New System.Windows.Forms.Label()
        Me.dibayar = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.status = New System.Windows.Forms.Label()
        Me.UNIK = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(18, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Barang"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.TANGGAL)
        Me.Panel1.Controls.Add(Me.JAM)
        Me.Panel1.Controls.Add(Me.pembeli)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.harga)
        Me.Panel1.Controls.Add(Me.nama)
        Me.Panel1.Controls.Add(Me.jumlah)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(12, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(807, 162)
        Me.Panel1.TabIndex = 2
        '
        'TANGGAL
        '
        Me.TANGGAL.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TANGGAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TANGGAL.Font = New System.Drawing.Font("Courier New", 17.0!, System.Drawing.FontStyle.Bold)
        Me.TANGGAL.ForeColor = System.Drawing.Color.Lime
        Me.TANGGAL.Location = New System.Drawing.Point(610, 98)
        Me.TANGGAL.Name = "TANGGAL"
        Me.TANGGAL.Size = New System.Drawing.Size(176, 39)
        Me.TANGGAL.TabIndex = 11
        Me.TANGGAL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'JAM
        '
        Me.JAM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.JAM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.JAM.Font = New System.Drawing.Font("Courier New", 17.0!, System.Drawing.FontStyle.Bold)
        Me.JAM.ForeColor = System.Drawing.Color.Lime
        Me.JAM.Location = New System.Drawing.Point(610, 54)
        Me.JAM.Name = "JAM"
        Me.JAM.Size = New System.Drawing.Size(176, 39)
        Me.JAM.TabIndex = 11
        Me.JAM.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pembeli
        '
        Me.pembeli.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pembeli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pembeli.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.pembeli.Location = New System.Drawing.Point(610, 11)
        Me.pembeli.Name = "pembeli"
        Me.pembeli.Size = New System.Drawing.Size(183, 26)
        Me.pembeli.TabIndex = 10
        Me.pembeli.Text = "BARU"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.Label9.Location = New System.Drawing.Point(457, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 26)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Nama Pembeli"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Snow
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.Button4.Location = New System.Drawing.Point(457, 83)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 48)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Tambah"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'harga
        '
        Me.harga.BackColor = System.Drawing.Color.WhiteSmoke
        Me.harga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.harga.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.harga.Location = New System.Drawing.Point(223, 77)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(199, 26)
        Me.harga.TabIndex = 8
        '
        'nama
        '
        Me.nama.BackColor = System.Drawing.Color.WhiteSmoke
        Me.nama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nama.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.nama.Location = New System.Drawing.Point(223, 45)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(199, 26)
        Me.nama.TabIndex = 7
        '
        'jumlah
        '
        Me.jumlah.Enabled = False
        Me.jumlah.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.jumlah.Location = New System.Drawing.Point(223, 111)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(116, 30)
        Me.jumlah.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(223, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 30)
        Me.TextBox1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.Label4.Location = New System.Drawing.Point(18, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Jumlah"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(18, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Harga"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(18, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Barang"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(807, 162)
        Me.ShapeContainer1.TabIndex = 9
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.Lime
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.RectangleShape1.BorderWidth = 3
        Me.RectangleShape1.CornerRadius = 7
        Me.RectangleShape1.Location = New System.Drawing.Point(443, 76)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(149, 61)
        Me.RectangleShape1.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 189)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(758, 160)
        Me.DataGridView1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Snow
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 360)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 82)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Lime
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.Button3.Location = New System.Drawing.Point(373, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 48)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Kembali"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.Button2.Location = New System.Drawing.Point(215, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 48)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 18.0!)
        Me.Button1.Location = New System.Drawing.Point(18, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Order"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'haha
        '
        Me.haha.BackColor = System.Drawing.Color.WhiteSmoke
        Me.haha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.haha.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.haha.Location = New System.Drawing.Point(534, 360)
        Me.haha.Name = "haha"
        Me.haha.Size = New System.Drawing.Size(100, 26)
        Me.haha.TabIndex = 9
        Me.haha.Text = "Total"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.Label7.Location = New System.Drawing.Point(534, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 26)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Dibayar"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.Label8.Location = New System.Drawing.Point(534, 433)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 26)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Kembali"
        '
        'total
        '
        Me.total.BackColor = System.Drawing.Color.WhiteSmoke
        Me.total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.total.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.total.Location = New System.Drawing.Point(640, 360)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(158, 26)
        Me.total.TabIndex = 9
        '
        'kembali
        '
        Me.kembali.BackColor = System.Drawing.Color.WhiteSmoke
        Me.kembali.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.kembali.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.kembali.Location = New System.Drawing.Point(640, 433)
        Me.kembali.Name = "kembali"
        Me.kembali.Size = New System.Drawing.Size(158, 26)
        Me.kembali.TabIndex = 12
        Me.kembali.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dibayar
        '
        Me.dibayar.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.dibayar.Location = New System.Drawing.Point(640, 397)
        Me.dibayar.Name = "dibayar"
        Me.dibayar.Size = New System.Drawing.Size(158, 30)
        Me.dibayar.TabIndex = 9
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.ForeColor = System.Drawing.Color.Lime
        Me.status.Location = New System.Drawing.Point(305, 1)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(46, 13)
        Me.status.TabIndex = 13
        Me.status.Text = "Dipesan"
        '
        'UNIK
        '
        Me.UNIK.BackColor = System.Drawing.Color.Lime
        Me.UNIK.ForeColor = System.Drawing.Color.Lime
        Me.UNIK.Location = New System.Drawing.Point(161, 1)
        Me.UNIK.Name = "UNIK"
        Me.UNIK.Size = New System.Drawing.Size(128, 17)
        Me.UNIK.TabIndex = 14
        '
        'Keranjang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(831, 480)
        Me.Controls.Add(Me.UNIK)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.dibayar)
        Me.Controls.Add(Me.kembali)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.haha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Keranjang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Keranjang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents harga As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.Label
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents pembeli As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents haha As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.Label
    Friend WithEvents kembali As System.Windows.Forms.Label
    Friend WithEvents dibayar As System.Windows.Forms.TextBox
    Friend WithEvents TANGGAL As System.Windows.Forms.Label
    Friend WithEvents JAM As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents status As System.Windows.Forms.Label
    Friend WithEvents UNIK As System.Windows.Forms.Label
End Class
