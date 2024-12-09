Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmubahpassword
    Private connectionString As String = "server=localhost;Uid=root;Pwd=;Database=bimbel_un"

    ' Fungsi untuk melakukan hashing password menggunakan SHA256
    'Private Function HashPassword(password As String) As String
    'Using sha256 As SHA256 = SHA256.Create()
    'Dim hashBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
    'Return BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
    'End Using
    'End Function

    ' Fungsi untuk menangani klik tombol Ubah Password
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim email As String = txtEmail.Text.Trim()
        Dim oldpassword As String = txtOld.Text.Trim()
        Dim newpassword As String = txtNewPassword.Text.Trim()
        Dim konfirmasi As String = txtNewConfirmPassword.Text.Trim()

        ' Validasi input
        If String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(oldpassword) OrElse String.IsNullOrWhiteSpace(newpassword) OrElse String.IsNullOrWhiteSpace(konfirmasi) Then
            MessageBox.Show("Please fill in all fields (email, old password, new password, and confirm password).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf newpassword.Length < 8 Then
            MessageBox.Show("New password must be at least 8 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf newpassword <> konfirmasi Then
            MessageBox.Show("New password and confirmation password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Hashing password baru dan password lama yang dimasukkan
        Dim newpasswordHash As String = newpassword
        Dim oldpasswordHash As String = oldpassword

        Try
            ' Koneksi ke database
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Query untuk mengecek apakah email dan password lama cocok
                Dim queryCheck As String = "SELECT * FROM login WHERE LOWER(email) = LOWER(@Email) AND password = @OldPassword"
                Using commandCheck As New MySqlCommand(queryCheck, connection)
                    commandCheck.Parameters.AddWithValue("@Email", email)
                    commandCheck.Parameters.AddWithValue("@OldPassword", oldpasswordHash)

                    Using reader As MySqlDataReader = commandCheck.ExecuteReader()
                        If reader.HasRows Then
                            reader.Close()

                            ' Query untuk update password baru
                            Dim queryUpdate As String = "UPDATE login SET password = @NewPassword WHERE LOWER(email) = LOWER(@Email)"
                            Using commandUpdate As New MySqlCommand(queryUpdate, connection)
                                commandUpdate.Parameters.AddWithValue("@NewPassword", newpasswordHash)
                                commandUpdate.Parameters.AddWithValue("@Email", email)

                                Dim rowsAffected As Integer = commandUpdate.ExecuteNonQuery()
                                If rowsAffected > 0 Then
                                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    ' Reset semua input
                                    txtEmail.Clear()
                                    txtNewPassword.Clear()
                                    txtOld.Clear()
                                    txtNewConfirmPassword.Clear()
                                Else
                                    MessageBox.Show("An error occurred while updating the password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            End Using
                        Else
                            MessageBox.Show("Incorrect email or old password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New frmdashboard()
        form.Show()
        Me.Hide()
    End Sub
End Class