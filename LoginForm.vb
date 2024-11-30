Imports System.Runtime.Intrinsics
Imports MySql.Data.MySqlClient

Public Class frmlogin
    Private connectionString As String = "server=localhost;Uid=root;Pwd=;Database=bimbel_un"

    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text

        ' Validate user input
        If String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Connect to the database
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Prepare SQL query
                Dim query As String = "SELECT * FROM login WHERE email = @email AND password = @password"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@email", email)
                    command.Parameters.AddWithValue("@password", password)

                    ' Execute query
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' Navigate to the next form (e.g., Dashboard)
                            Dim form2 As New frmdashboard()
                            form2.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksikan()
        da = New MySqlDataAdapter("select * from login", conn)
        ds = New DataSet
        da.Fill(ds, "login")

        My.Application.Log.WriteEntry(
        "Exiting TracingTest with argument " & ds.GetXml)
    End Sub
End Class
