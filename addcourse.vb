Imports MySql.Data.MySqlClient

Public Class addcourse
    Private Sub cbX_Click(sender As Object, e As EventArgs) Handles cbX.Click
        Me.Close()
        departttx.Clear()
        destxt.Clear()

    End Sub

    Private Sub departmentc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles departcombobox.SelectedIndexChanged
        departcombobox.Focus()
        DataModule.OpenConnection()

        Try
            Dim cmd As New MySqlCommand("SELECT * FROM registration.department WHERE Department LIKE @depart", DataModule.Connection)
            cmd.Parameters.AddWithValue("@depart", departcombobox.Text)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.HasRows Then
                dr.Read()
                didtext.Text = dr("DID").ToString()
            Else
                didtext.Text = String.Empty
            End If

            dr.Close()

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DataModule.CloseConnection()
        End Try



    End Sub
    Public Sub viewdepartments()
        departcombobox.Items.Clear()
        departcombobox.Items.Add("Select Department")
        departcombobox.SelectedIndex = 0

        OpenConnection()

        Dim query As String = "SELECT Department FROM registration.department"

        Try
            Using cmd As New MySqlCommand(query, Connection)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        departcombobox.Items.Add(dr("Department").ToString())
                    End While
                End Using
            End Using
        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            CloseConnection()
        End Try
    End Sub


    Public Sub InsertCourse()
        If String.IsNullOrWhiteSpace(departttx.Text) OrElse String.IsNullOrWhiteSpace(destxt.Text) Then
            MessageBox.Show("Please fill in all fields.", "Fill in all fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf departcombobox.SelectedIndex = 0 Then
            MessageBox.Show("Select Department", "Select valid Department", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        OpenConnection()

        Dim checkQuery As String = "SELECT COUNT(*) FROM registration.tblcourse WHERE Course = @Course"
        Using checkCmd As New MySql.Data.MySqlClient.MySqlCommand(checkQuery, Connection)
            checkCmd.Parameters.AddWithValue("@Course", departttx.Text)

            Try
                Dim departmentExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If departmentExists > 0 Then
                    MessageBox.Show("This course already exists.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim insertQuery As String = "INSERT INTO registration.tblcourse (Course, Description, DID) VALUES (@Course, @Description, @DID)"
                    Using insertCmd As New MySql.Data.MySqlClient.MySqlCommand(insertQuery, Connection)
                        insertCmd.Parameters.AddWithValue("@Course", departttx.Text)
                        insertCmd.Parameters.AddWithValue("@Description", destxt.Text)
                        insertCmd.Parameters.AddWithValue("@DID", didtext.Text)

                        insertCmd.ExecuteNonQuery()
                        MessageBox.Show("Course added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        departcombobox.SelectedIndex = 0
                        didtext.Clear()
                        destxt.Clear()
                        departttx.Clear()
                        Course.CourseView()
                        maindash.coursecount()

                        Totaldepartment.departmentoverview()
                        totalstudents.studentoverview()
                        Totalcourse.courseoverview()
                        Form3.filldepartment()

                        studlist.viewdepartments()
                        studlist.viewcoursedata()




                    End Using
                End If
            Catch ex As MySqlException
                MessageBox.Show("Error checking for existing department: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

        If departcombobox.Items.Count > 1 Then
            departcombobox.SelectedIndex = 0
        Else
            MsgBox("No departments found.", MsgBoxStyle.Information, "No Data")
        End If

        CloseConnection()

    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        InsertCourse()
    End Sub

    Private Sub addcourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        viewdepartments()
        TopMost = True

    End Sub

    Private Sub departadd_Click(sender As Object, e As EventArgs) Handles departadd.Click

    End Sub

    Private Sub didtext_TextChanged(sender As Object, e As EventArgs) Handles didtext.TextChanged

    End Sub
End Class