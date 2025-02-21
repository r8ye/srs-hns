Imports MySql.Data.MySqlClient

Public Class adddepart
    Public Sub InsertDepartmentData()
        If String.IsNullOrWhiteSpace(departttx.Text) OrElse String.IsNullOrWhiteSpace(destxt.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        OpenConnection()

        Dim checkQuery As String = "SELECT COUNT(*) FROM registration.department WHERE Department = @Department"
        Using checkCmd As New MySql.Data.MySqlClient.MySqlCommand(checkQuery, Connection)
            checkCmd.Parameters.AddWithValue("@Department", departttx.Text)

            Try
                Dim departmentExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If departmentExists > 0 Then
                    MessageBox.Show("This department already exists.", "Duplicate Department", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim insertQuery As String = "INSERT INTO registration.department (Department, Description) VALUES (@Department, @Description)"
                    Using insertCmd As New MySql.Data.MySqlClient.MySqlCommand(insertQuery, Connection)
                        insertCmd.Parameters.AddWithValue("@Department", departttx.Text)
                        insertCmd.Parameters.AddWithValue("@Description", destxt.Text)

                        insertCmd.ExecuteNonQuery()
                        MessageBox.Show("Department added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        department.departmentview()
                        addcourse.viewdepartments()
                        editcourse.loaddept()
                        Totaldepartment.departmentoverview()
                        totalstudents.studentoverview()
                        Totalcourse.courseoverview()
                        maindash.departmentcount()

                    End Using
                End If
            Catch ex As MySqlException
                MessageBox.Show("Error checking for existing department: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        CloseConnection()
    End Sub



    Private Sub cbX_Click(sender As Object, e As EventArgs) Handles cbX.Click

        Me.Close()
        departttx.Clear()
        destxt.Clear()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        InsertDepartmentData()
        departttx.Clear()
        destxt.Clear()
        Course.filldepartment()
        studlist.viewdepartments()
        studlist.viewcoursedata()

    End Sub

    Private Sub departadd_Click(sender As Object, e As EventArgs) Handles departadd.Click

    End Sub

    Private Sub adddepart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TopMost = True
    End Sub
End Class