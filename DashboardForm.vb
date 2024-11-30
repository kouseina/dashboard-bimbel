Public Class frmdashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New frmguru()
        form.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New frmsiswa()
        form.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form As New frmkehadiran()
        form.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form As New frmnilai()
        form.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form As New frmubahpassword()
        form.Show()
        Me.Hide()
    End Sub
End Class