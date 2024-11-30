Imports System.Runtime.Intrinsics

Public Class frmlogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form2 As New frmdashboard()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
