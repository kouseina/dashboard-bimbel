Imports System.Data.Common
Imports System.Runtime.CompilerServices
Imports MySql.Data.MySqlClient

Public Class frmnilai
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader

    ' Menambahkan ComboBox untuk memilih kelas
    Dim kelasList As New List(Of String) From {"KELAS 6 SD", "KELAS 3 SMP", "KELAS 3 SMA"}

    Sub tampil()
        Call koneksikan()
        da = New MySqlDataAdapter("SELECT * FROM nilai", conn)
        ds = New DataSet()
        da.Fill(ds, "nilai")
        DataGridView.DataSource = ds.Tables("nilai")
    End Sub

    Sub kosong()
        txtnama.Text = ""
        txtnip.Text = ""
        txtmatematika.Text = ""
        txtipa.Text = ""
        txtbahasaindonesia.Text = ""
        cbkelas.SelectedIndex = -1 ' Mengosongkan ComboBox
    End Sub

    Private Sub frmnilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menambahkan pilihan kelas ke ComboBox
        cbkelas.DataSource = kelasList

        ' Menampilkan data
        Call tampil()

        ' Mengatur tombol yang aktif
        btsimpan.Enabled = True
        btcari.Enabled = True
        btedit.Enabled = False
        bthapus.Enabled = False
    End Sub

    ' Fungsi untuk menyimpan data
    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        Call koneksikan()
        Dim simpan As String = "insert into nilai (nama, nip, matematika, ipa, bahasa_indonesia, kelas) value 
        ('" & txtnama.Text & "','" & txtnip.Text & "','" & txtmatematika.Text & "','" & txtipa.Text & "','" & txtbahasaindonesia.Text & "', '" & cbkelas.SelectedItem.ToString() & "')"
        cmd = New MySqlCommand(simpan, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Di Simpan", vbInformation, "Simpan")
        Call tampil()
        Call kosong()

        btsimpan.Enabled = False
        btedit.Enabled = False
        bthapus.Enabled = True
        btcari.Enabled = True
    End Sub

    ' Fungsi untuk mencari data berdasarkan NIP
    Private Sub btcari_Click(sender As Object, e As EventArgs) Handles btcari.Click
        Call koneksikan()
        Try
            Dim query As String = "SELECT * FROM nilai WHERE nip LIKE @cari"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@cari", "%" & txtnip.Text & "%")
                da = New MySqlDataAdapter(cmd)
                ds = New DataSet()
                da.Fill(ds, "nilai")
                DataGridView.DataSource = ds.Tables("nilai")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        btsimpan.Enabled = False
        btcari.Enabled = True
        btedit.Enabled = True
        bthapus.Enabled = True
    End Sub

    ' Fungsi untuk mengedit data
    Private Sub btedit_Click(sender As Object, e As EventArgs) Handles btedit.Click
        Try
            Call koneksikan()

            ' Pastikan ada nilai di semua TextBox
            If String.IsNullOrWhiteSpace(txtnama.Text) OrElse
               String.IsNullOrWhiteSpace(txtnip.Text) OrElse
               String.IsNullOrWhiteSpace(txtmatematika.Text) OrElse
               String.IsNullOrWhiteSpace(txtipa.Text) OrElse
               String.IsNullOrWhiteSpace(txtbahasaindonesia.Text) OrElse
               cbkelas.SelectedIndex = -1 Then
                MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Query untuk update data
            Dim query As String = "UPDATE nilai SET matematika = @matematika, ipa = @ipa, bahasa_indonesia = @bahasa_indonesia, kelas = @kelas WHERE nip = @nip"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nip", txtnip.Text)
                cmd.Parameters.AddWithValue("@nama", txtnama.Text)
                cmd.Parameters.AddWithValue("@matematika", txtmatematika.Text)
                cmd.Parameters.AddWithValue("@ipa", txtipa.Text)
                cmd.Parameters.AddWithValue("@bahasa_indonesia", txtbahasaindonesia.Text)
                cmd.Parameters.AddWithValue("@kelas", cbkelas.SelectedItem.ToString())

                cmd.ExecuteNonQuery()

                MessageBox.Show("Data berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using

            ' Refresh DataGridView setelah data diperbarui
            Call tampil()

            ' Kosongkan TextBox setelah update
            Call kosong()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        ' Nonaktifkan tombol setelah edit
        btsimpan.Enabled = True
        btedit.Enabled = False
        bthapus.Enabled = True
        btcari.Enabled = True
    End Sub

    ' Fungsi untuk menghapus data
    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        If String.IsNullOrWhiteSpace(txtnip.Text) Then
            MessageBox.Show("NIP harus diisi untuk menghapus data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Menghapus data berdasarkan nip
        Try
            Call koneksikan()
            Dim query As String = "DELETE FROM nilai WHERE nip = @nip"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nip", txtnip.Text)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call tampil() ' Menampilkan data yang terbaru
            Call kosong()  ' Mengosongkan kolom input
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

        ' Nonaktifkan tombol setelah hapus
        btsimpan.Enabled = True
        btedit.Enabled = False
        bthapus.Enabled = False
        btcari.Enabled = True
    End Sub

    ' Fungsi untuk memilih baris dari DataGridView
    Private Sub DataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView.Rows(e.RowIndex)

            ' Isi nilai ke dalam TextBox berdasarkan kolom yang dipilih
            txtnama.Text = row.Cells("nama").Value.ToString()
            txtnip.Text = row.Cells("nip").Value.ToString()
            cbkelas.SelectedItem = row.Cells("kelas").Value.ToString()
            txtmatematika.Text = row.Cells("matematika").Value.ToString()
            txtipa.Text = row.Cells("ipa").Value.ToString()
            txtbahasaindonesia.Text = row.Cells("bahasa_indonesia").Value.ToString()


            ' Mengaktifkan tombol Edit dan Hapus setelah memilih baris
            btedit.Enabled = True
            bthapus.Enabled = True
        End If
    End Sub

    ' Fungsi untuk kembali ke dashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New frmdashboard()
        form.Show()
        Me.Hide()
    End Sub
End Class