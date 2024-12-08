Imports System.Data.Common
Imports System.Runtime.CompilerServices
Imports System.Runtime.Intrinsics.Arm
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class frmkehadiran
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader

    Sub tampil()
        da = New MySqlDataAdapter("select * from kehadiran", conn)
        ds = New DataSet
        da.Fill(ds, "kehadiran")
        DataGridView1.DataSource = ds.Tables("kehadiran")
        'DGV.DataSource = ds.table("guru")
    End Sub

    Sub kosong()
        Txtnama.Text = ""
        Txtnip.Text = ""
        Txttanggal.Text = ""
        Cbketerangan.Text = ""

    End Sub

    Private Sub frmkehadiran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil()
        Cbketerangan.Items.AddRange(New String() {"Hadir", "Izin", "Sakit"})

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New frmdashboard()
        form.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrWhiteSpace(Txtnama.Text) OrElse
           String.IsNullOrWhiteSpace(Txtnip.Text) OrElse
           String.IsNullOrWhiteSpace(Txttanggal.Text) Then
            MessageBox.Show("Nama, NIP, dan Tanggal harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim query As String = "INSERT INTO kehadiran (nama, nip, tanggal, keterangan) VALUES (@nama, @nip, @tanggal, @keterangan)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", Txtnama.Text)
            cmd.Parameters.AddWithValue("@nip", Txtnip.Text)
            cmd.Parameters.AddWithValue("@tanggal", DateTime.Parse(Txttanggal.Text)) ' Pastikan format tanggal benar
            cmd.Parameters.AddWithValue("@keterangan", Cbketerangan.SelectedItem.ToString())
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
        End Try
        Call tampil()
        Call kosong()

    End Sub
End Class