Imports MySql.Data.MySqlClient

Public Class editcourse
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            If String.IsNullOrWhiteSpace(departttx.Text) OrElse String.IsNullOrWhiteSpace(destxt.Text) Then
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If MsgBox("Are you sure you want to update this Course?", vbYesNo + vbQuestion) = vbYes Then
                OpenConnection()

                Dim checkQuery As String = "SELECT COUNT(*) FROM registration.tblcourse WHERE Course = @course AND CID != @CID"
                Using checkCmd As New MySql.Data.MySqlClient.MySqlCommand(checkQuery, Connection)
                    checkCmd.Parameters.AddWithValue("@course", departttx.Text)
                    checkCmd.Parameters.AddWithValue("@CID", idtext.Text)

                    Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If exists > 0 Then
                        MessageBox.Show("The Course already exists.", "Duplicate Course", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Using cmd As New MySqlCommand("UPDATE registration.tblcourse SET Course = @Course, Description = @description, DID = @DID WHERE CID = @CID", Connection)
                            cmd.Parameters.AddWithValue("@Course", departttx.Text)
                            cmd.Parameters.AddWithValue("@description", destxt.Text)
                            cmd.Parameters.AddWithValue("@CID", idtext.Text)
                            cmd.Parameters.AddWithValue("@DID", departmentid.Text)

                            Dim result As Integer = cmd.ExecuteNonQuery()

                            If result > 0 Then
                                MessageBox.Show("Course updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                department.departmentview()
                                studlist.viewdepartments()
                                studlist.viewcoursedata()
                                addcourse.viewdepartments()
                                Course.CourseView()
                                studlist.StudentView()
                                Totaldepartment.departmentoverview()
                                totalstudents.studentoverview()
                                Totalcourse.courseoverview()


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

    Private Sub departcombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles departcombobox.SelectedIndexChanged
        Try
            OpenConnection()


            Dim sqlQuery As String = "SELECT DID, Department FROM registration.department WHERE Department LIKE @department"
            Using cmd As New MySqlCommand(sqlQuery, Connection)
                cmd.Parameters.AddWithValue("@department", "%" & departcombobox.Text & "%")

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        departcombobox.Text = dr("Department").ToString()
                        departmentid.Text = dr("DID").ToString()
                    Else
                        departcombobox.Text = String.Empty
                        departmentid.Text = String.Empty
                    End If
                End Using
            End Using

            CloseConnection()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub departadd_Click(sender As Object, e As EventArgs) Handles departadd.Click

    End Sub
    Sub loaddept()
        Try

            OpenConnection()

            Dim query As String = "SELECT * FROM registration.department"
            Using cmd As New MySqlCommand(query, Connection)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    departcombobox.Items.Add(dr("Department").ToString())
                End While
                dr.Close()
            End Using

            CloseConnection()

        Catch ex As MySqlException
            MessageBox.Show("Error filling department combo box: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class