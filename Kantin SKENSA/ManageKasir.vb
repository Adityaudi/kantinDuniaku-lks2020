Imports System.Data.SqlClient
Public Class ManageKasir
    Sub tampil()
        Call koneksi()
        da = New SqlDataAdapter("SELECT KASIRID, NAMA, JENIS_KELAMIN, TTL, ALAMAT, NO_HP FROM TBL_KASIR  where NAMA Like '%" & TextBox1.Text & "%'", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "TBL_KASIR")
        DataGridView1.DataSource = ds.Tables("TBL_KASIR")
        DataGridView1.ReadOnly = True

        With DataGridView1
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Lime
        End With
    End Sub
    Private Sub ManageKasir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampil()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Lengkapi Semua data untuk Menambahkan User", MsgBoxStyle.Critical)
        Else

            Dim jeniskelamin As String
            If RadioButton1.Checked = True Then
                jeniskelamin = RadioButton1.Text
            Else
                RadioButton2.Checked = True
                jeniskelamin = RadioButton2.Text
            End If

            Dim tglllahir As String
            tglllahir = Format(DateTimePicker1.Value, "yyyyMMdd")

            Call koneksi()
            Dim input As String = "INSERT INTO TBL_KASIR VALUES ('" & TextBox2.Text & "', '" & TextBox3.Text & "' ,'" & TextBox4.Text & "' ,'" & jeniskelamin & "' ,'" & tglllahir & "' ,'" & TextBox6.Text & "','" & TextBox8.Text & "', '" & AKSES.Text & "' , '" & PHOTO.Text & "')"
            cmd = New SqlCommand(input, conn)
            cmd.ExecuteNonQuery()
            MsgBox("User Berhasil ditambahkan, Terimakasih", MsgBoxStyle.OkOnly)
            Call tampil()
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.RowCount >= 0 Then
            Dim baris As Integer = 0
            With DataGridView1
                baris = DataGridView1.CurrentRow.Index
                TextBox3.Text = .Item(1, baris).Value
                TextBox3.BackColor = Color.Lime

            End With
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call tampil()
    End Sub
End Class