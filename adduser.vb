Imports MySql.Data.MySqlClient

Public Class adduser
    Private Sub departadd_Click(sender As Object, e As EventArgs) Handles departadd.Click

    End Sub

    Private Sub departttx_TextChanged(sender As Object, e As EventArgs) Handles uname.TextChanged

    End Sub

    Private Sub cbX_Click(sender As Object, e As EventArgs) Handles cbX.Click
        Me.Close()
        destxt.Clear()
        destxt.Clear()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        adduser()

    End Sub
    Public Sub adduser()
        If String.IsNullOrWhiteSpace(uname.Text) OrElse String.IsNullOrWhiteSpace(destxt.Text) OrElse String.IsNullOrWhiteSpace(user.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        OpenConnection()

        Dim checkQuery As String = "SELECT COUNT(*) FROM registration.usertype WHERE Usertype = @user AND Username = @uname"
        Using checkCmd As New MySql.Data.MySqlClient.MySqlCommand(checkQuery, Connection)
            checkCmd.Parameters.AddWithValue("@user", user.Text)
            checkCmd.Parameters.AddWithValue("@uname", uname.Text)

            Try
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If count > 0 Then
                    MessageBox.Show("This User Type and Username already exist.", "User Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim checkUserQuery As String = "SELECT COUNT(*) FROM registration.usertype WHERE Usertype = @user"
                    Using checkUserCmd As New MySql.Data.MySqlClient.MySqlCommand(checkUserQuery, Connection)
                        checkUserCmd.Parameters.AddWithValue("@user", user.Text)

                        Dim userExists As Integer = Convert.ToInt32(checkUserCmd.ExecuteScalar())

                        If userExists > 0 Then
                            MessageBox.Show("This User Type already exists.", "User Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Dim checkUsernameQuery As String = "SELECT COUNT(*) FROM registration.usertype WHERE Username = @uname"
                            Using checkUsernameCmd As New MySql.Data.MySqlClient.MySqlCommand(checkUsernameQuery, Connection)
                                checkUsernameCmd.Parameters.AddWithValue("@uname", uname.Text)

                                Dim usernameExists As Integer = Convert.ToInt32(checkUsernameCmd.ExecuteScalar())

                                If usernameExists > 0 Then
                                    MessageBox.Show("This Username already exists.", "User Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Else
                                    Dim insertQuery As String = "INSERT INTO registration.usertype (Usertype, Username, Password) VALUES (@user, @username, @pass)"
                                    Using insertCmd As New MySql.Data.MySqlClient.MySqlCommand(insertQuery, Connection)
                                        insertCmd.Parameters.AddWithValue("@user", user.Text)
                                        insertCmd.Parameters.AddWithValue("@username", uname.Text)
                                        insertCmd.Parameters.AddWithValue("@pass", destxt.Text)

                                        insertCmd.ExecuteNonQuery()
                                        MessageBox.Show("New User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        useraccount.typeuserview()
                                        destxt.Clear()
                                        uname.Clear()
                                        user.Clear()
                                    End Using
                                End If
                            End Using
                        End If
                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show("Error checking user type or username: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        CloseConnection()
    End Sub
End Class