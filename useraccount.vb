Imports MySql.Data.MySqlClient

Public Class useraccount


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        adduser.Show()

    End Sub

    Private Sub useraccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        typeuserview()
    End Sub
    Public Sub typeuserview()
        Dim i As Integer = 0
        usertypeview.Rows.Clear()
        OpenConnection()

        Dim query As String = "SELECT * FROM registration.usertype"

        Using cmd As New MySqlCommand(query, Connection)
            Using dr As MySqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    i += 1
                    usertypeview.Rows.Add(dr.Item("ID").ToString(),
                                    dr.Item("Usertype").ToString(),
                                    dr.Item("Username").ToString(),
                                    dr.Item("Password").ToString())

                End While
            End Using
        End Using

        CloseConnection()

        usercount.Text = "(" & usertypeview.Rows.Count & ")"
    End Sub

    Private Sub usertypeview_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles usertypeview.CellContentClick
        Dim colname As String = usertypeview.Columns(e.ColumnIndex).Name
        Try
            If colname = "edit" Then
                With edituser
                    .ID.Text = usertypeview.Rows(e.RowIndex).Cells(0).Value
                    .user.Text = usertypeview.Rows(e.RowIndex).Cells(1).Value
                    .departttx.Text = usertypeview.Rows(e.RowIndex).Cells(2).Value
                    .destxt.Text = usertypeview.Rows(e.RowIndex).Cells(3).Value

                    Dim userType As String = usertypeview.Rows(e.RowIndex).Cells(1).Value.ToString().ToLower()
                    If userType = "superadmin" Then
                        .user.Enabled = False

                    Else
                        .user.Enabled = True
                    End If

                    .ShowDialog()
                End With

            ElseIf colname = "delete" Then
                If MessageBox.Show("Are you sure you want to delete this User?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    OpenConnection()

                    Dim userTypeQuery As String = "SELECT usertype FROM registration.usertype WHERE ID = @ID"
                    Dim userType As String = ""

                    Using userTypeCmd As New MySqlCommand(userTypeQuery, Connection)
                        userTypeCmd.Parameters.AddWithValue("@ID", usertypeview.Rows(e.RowIndex).Cells(0).Value)
                        Using reader As MySqlDataReader = userTypeCmd.ExecuteReader()
                            If reader.Read() Then
                                userType = reader("usertype").ToString()
                            End If
                        End Using
                    End Using

                    If userType.Trim().ToLower() = "superadmin" Then
                        MessageBox.Show("Superadmin user cannot be deleted.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Dim deleteCoursesQuery As String = "DELETE FROM registration.usertype WHERE ID = @ID"
                        Using deleteCmd As New MySqlCommand(deleteCoursesQuery, Connection)
                            deleteCmd.Parameters.AddWithValue("@ID", usertypeview.Rows(e.RowIndex).Cells(0).Value)
                            deleteCmd.ExecuteNonQuery()
                        End Using

                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        typeuserview()
                    End If

                    CloseConnection()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class