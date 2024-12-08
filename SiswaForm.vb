Public Class frmsiswa
    ' List untuk menyimpan data siswa
    Dim daftarSiswa As New List(Of Siswa)

    ' Class untuk mendefinisikan struktur data siswa
    Public Class Siswa
        Public Property Nama As String
        Public Property Kelas As String
        Public Property NISN As String
    End Class

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        ' Mengecek apakah ada data yang dipilih di DataGridView
        If DataGridView.SelectedRows.Count > 0 Then
            ' Menghapus siswa yang dipilih
            Dim index As Integer = DataGridView.SelectedRows(0).Index
            daftarSiswa.RemoveAt(index)

            ' Mengupdate DataGridView setelah penghapusan
            UpdateDataGridView()
        Else
            MessageBox.Show("Pilih data yang akan dihapus terlebih dahulu.")
        End If
    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        Dim nama As String = txtnama.Text
        Dim kelas As String = cbkelas.Text
        Dim nisn As String = txtnisn.Text

        ' Mengecek apakah input tidak kosong
        If String.IsNullOrWhiteSpace(nama) Or String.IsNullOrWhiteSpace(kelas) Or String.IsNullOrWhiteSpace(nisn) Then
            MessageBox.Show("Semua data harus diisi!")
            Return
        End If

        ' Menambahkan siswa ke dalam list
        daftarSiswa.Add(New Siswa With {.Nama = nama, .Kelas = kelas, .NISN = nisn})

        ' Mengupdate DataGridView
        UpdateDataGridView()

        ' Clear input text setelah simpan
        txtnama.Clear()
        txtnisn.Clear()
        cbkelas.ResetText()


    End Sub

    ' Fungsi untuk mengupdate DataGridView
    Private Sub UpdateDataGridView()
        ' Menghapus semua baris yang ada
        DataGridView.Rows.Clear()

        ' Menambahkan data siswa ke dalam DataGridView
        For Each siswa As Siswa In daftarSiswa
            DataGridView.Rows.Add(siswa.Nama, siswa.Kelas, siswa.NISN)
        Next
    End Sub

    Private Sub frmsiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With DataGridView
            .ColumnCount = 3
            .Columns(0).Name = "Nama"
            .Columns(1).Name = "Kelas"
            .Columns(2).Name = "NISN"
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With

        ' Mengisi item ComboBox (Kelas)
        cbkelas.Items.AddRange(New String() {"KELAS 6 SD", "KELAS 3 SMP", "KELAS 3 SMA"})
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New frmdashboard()
        form.Show()
        Me.Hide()
    End Sub
End Class