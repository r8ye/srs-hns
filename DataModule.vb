Imports MySql.Data.MySqlClient

Public Module DataModule

    Private Const ConnectionString As String = "server=localhost;user=root;password=;database=registration"
    Public Connection As New MySqlConnection(ConnectionString)

    Public Sub OpenConnection()
        Try
            If Connection.State = ConnectionState.Closed Then
                Connection.Open()
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error opening connection: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub CloseConnection()
        Try
            If Connection.State = ConnectionState.Open Then
                Connection.Close()
            End If
        Catch ex As MySqlException
            MessageBox.Show("Error closing connection: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
