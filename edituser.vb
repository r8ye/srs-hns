Imports MySql.Data.MySqlClient

Public Class edituser
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If String.IsNullOrWhiteSpace(departttx.Text) OrElse String.IsNullOrWhiteSpace(destxt.Text) OrElse String.IsNullOrWhiteSpace(user.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            If String.IsNullOrWhiteSpace(departttx.Text) OrElse String.IsNullOrWhiteSpace(destxt.Text) OrElse String.IsNullOrWhiteSpace(user.Text) Then
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If MsgBox("Are you sure you want to update this User?", vbYesNo + vbQuestion) = vbYes Then
                OpenConnection()

                Dim checkQuery As String = "SELECT COUNT(*) FROM registration.usertype WHERE Usertype = @user AND ID != @ID"
                Using checkCmd As New MySql.Data.MySqlClient.MySqlCommand(checkQuery, Connection)
                    checkCmd.Parameters.AddWithValue("@user", user.Text)
                    checkCmd.Parameters.AddWithValue("@ID", ID.Text)

                    Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If exists > 0 Then
                        MessageBox.Show("The User Type already exists.", "Duplicate Course", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Using cmd As New MySqlCommand("UPDATE registration.usertype SET Usertype = @user, Username = @username, Password = @pass WHERE ID = @ID", Connection)
                            cmd.Parameters.AddWithValue("@user", user.Text)
                            cmd.Parameters.AddWithValue("@username", departttx.Text)
                            cmd.Parameters.AddWithValue("@ID", ID.Text)
                            cmd.Parameters.AddWithValue("@pass", destxt.Text)

                            Dim result As Integer = cmd.ExecuteNonQuery()

                            If result > 0 Then
                                MessageBox.Show("User updated successfully.", "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                department.departmentview()
                                useraccount.typeuserview()

                            Else
                                MessageBox.Show("Failed to update course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End If
                End Using

                CloseConnection()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class