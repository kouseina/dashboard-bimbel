Imports MySql.Data.MySqlClient

Module modulkoneksi
    Public conn As MySqlConnection

    Public Sub koneksikan()
        Dim SQLCon As String
        SQLCon = "server=localhost;Uid=root;Pwd=;Database=bimbel_un"
        conn = New MySqlConnection(SQLCon)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
