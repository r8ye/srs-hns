Imports MySql.Data.MySqlClient

Public Class editstudents
    Private Sub cbX_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub editstudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            If String.IsNullOrWhiteSpace(lname.Text) OrElse String.IsNullOrWhiteSpace(fname.Text) OrElse String.IsNullOrWhiteSpace(mname.Text) OrElse String.IsNullOrWhiteSpace(cnumber.Text) OrElse
               String.IsNullOrWhiteSpace(CID.Text) OrElse String.IsNullOrWhiteSpace(DID.Text) Then
                MessageBox.Show("Please fill in all fields.", "Fill in all fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf cgender.SelectedIndex = 0 Then
                MessageBox.Show("Select Gender", "Select valid Gender", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf year.SelectedIndex = 0 Then
                MessageBox.Show("Select Year Level", "Select valid Year Level", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If



            If MsgBox("Are you sure you want to update this student information?", vbYesNo + vbQuestion) = vbYes Then
                OpenConnection()

                Dim updateQuery As String = "UPDATE registration.tblstudents SET Lname = @Lname, Fname = @Fname, Mname = @Mname, Gender = @Gender, Cnumber = @Cnumber, CID = @CID, DID = @DID, Yearlvl = @Yearlvl WHERE studentID = @studID"

                Using updateCmd As New MySql.Data.MySqlClient.MySqlCommand(updateQuery, Connection)
                    updateCmd.Parameters.AddWithValue("@studID", studID.Text)
                    updateCmd.Parameters.AddWithValue("@Lname", lname.Text)
                    updateCmd.Parameters.AddWithValue("@Fname", fname.Text)
                    updateCmd.Parameters.AddWithValue("@Mname", mname.Text)
                    updateCmd.Parameters.AddWithValue("@Gender", cgender.SelectedItem.ToString())
                    updateCmd.Parameters.AddWithValue("@Cnumber", cnumber.Text)
                    updateCmd.Parameters.AddWithValue("@CID", CID.Text)
                    updateCmd.Parameters.AddWithValue("@DID", DID.Text)
                    updateCmd.Parameters.AddWithValue("@Yearlvl", year.SelectedItem.ToString())

                    Dim result As Integer = updateCmd.ExecuteNonQuery()

                    If result > 0 Then
                        MessageBox.Show("Student information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        studlist.StudentView()

                        maindash.studentscount()
                        Totaldepartment.departmentoverview()
                        totalstudents.studentoverview()
                        Totalcourse.courseoverview()
                    Else
                        MessageBox.Show("Failed to update student information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using

                CloseConnection()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Sub loaddept()
        Try

            OpenConnection()

            Dim query As String = "SELECT * FROM registration.department"
            Using cmd As New MySqlCommand(query, Connection)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    department.Items.Add(dr("Department").ToString())
                End While
                dr.Close()
            End Using

            CloseConnection()

        Catch ex As MySqlException
            MessageBox.Show("Error filling department combo box: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub loadcourse()
        Try

            OpenConnection()

            Dim query As String = "SELECT * FROM registration.tblcourse"
            Using cmd As New MySqlCommand(query, Connection)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    course.Items.Add(dr("Course").ToString())
                End While
                dr.Close()
            End Using

            CloseConnection()

        Catch ex As MySqlException
            MessageBox.Show("Error filling department combo box: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles department.SelectedIndexChanged
        Try
            OpenConnection()


            Dim sqlQuery As String = "SELECT DID, Department FROM registration.department WHERE Department LIKE @department"
            Using cmd As New MySqlCommand(sqlQuery, Connection)
                cmd.Parameters.AddWithValue("@department", "%" & department.Text & "%")

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        DID.Text = dr("Department").ToString()
                        DID.Text = dr("DID").ToString()
                    Else
                        DID.Text = String.Empty
                        DID.Text = String.Empty
                    End If
                End Using
            End Using

            CloseConnection()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles course.SelectedIndexChanged
        Try
            OpenConnection()


            Dim sqlQuery As String = "SELECT CID, Course FROM registration.tblcourse WHERE Course LIKE @Course"
            Using cmd As New MySqlCommand(sqlQuery, Connection)
                cmd.Parameters.AddWithValue("@Course", "%" & department.Text & "%")

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        CID.Text = dr("Course").ToString()
                        CID.Text = dr("CID").ToString()
                    Else
                        CID.Text = String.Empty
                        CID.Text = String.Empty
                    End If
                End Using
            End Using

            CloseConnection()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbX_Click_1(sender As Object, e As EventArgs) Handles cbX.Click
        Me.Close()
    End Sub

    Private Sub panelBody_Paint(sender As Object, e As PaintEventArgs) Handles panelBody.Paint

    End Sub

    Private Sub cnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cnumber.KeyPress

        'If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then

        '    e.Handled = True
        'End If

        'If cnumber.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then

        '    e.Handled = True
        'End If

        'If (Control.ModifierKeys And Keys.Control) = Keys.Control AndAlso e.KeyChar = ChrW(Keys.V) Then
        '    e.Handled = True


        'End If
    End Sub
End Class