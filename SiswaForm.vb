Public Class frmsiswa
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New frmdashboard()
        form.Show()
        Me.Hide()
    End Sub
End Class