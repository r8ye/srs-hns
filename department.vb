Imports MySql.Data.MySqlClient

Public Class department
    Dim ID, Department, Description As String

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles totaldepart.Click

    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        adddepart.Show()

    End Sub
    Public Sub departmentview()
        Dim i As Integer = 0
        viewdepart.Rows.Clear()
        OpenConnection()

        Dim query As String = "SELECT * FROM registration.department"

        Using cmd As New MySqlCommand(query, Connection)
            Using dr As MySqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    i += 1
                    viewdepart.Rows.Add(dr.Item("DID").ToString(),
                                    dr.Item("Department").ToString(),
                                    dr.Item("Description").ToString())
                End While
            End Using
        End Using

        CloseConnection()

        totaldepart.Text = "(" & viewdepart.Rows.Count & ")"
    End Sub


    Private Sub department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        departmentview()

    End Sub

    Private Sub viewdepart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewdepart.CellContentClick
        Dim colname As String = viewdepart.Columns(e.ColumnIndex).Name

        Try
            If colname = "edit" Then
                With editdepart
                    .departttx.Text = Department
                    .destxt.Text = Description
                    .id.Text = ID
                    .ShowDialog()
                End With
            ElseIf colname = "delete" Then
                If MessageBox.Show("Are you sure you want to delete this Department?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    OpenConnection()


                    Dim deleteCoursesQuery As String = "DELETE FROM registration.tblcourse WHERE DID = @DID"
                    Using deleteCmd As New MySqlCommand(deleteCoursesQuery, Connection)
                        deleteCmd.Parameters.AddWithValue("@DID", viewdepart.Rows(e.RowIndex).Cells(0).Value)
                        deleteCmd.ExecuteNonQuery()
                    End Using


                    Dim deleteDepartmentQuery As String = "DELETE FROM registration.department WHERE DID = @DID"
                    Using cmd As New MySqlCommand(deleteDepartmentQuery, Connection)
                        cmd.Parameters.AddWithValue("@DID", viewdepart.Rows(e.RowIndex).Cells(0).Value)

                        Dim result As Integer = cmd.ExecuteNonQuery()
                        MessageBox.Show("Department deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If result > 0 Then
                            departmentview()
                            addcourse.viewdepartments()
                            Course.CourseView()
                            editcourse.loaddept()
                            Form3.filldepartment()
                            maindash.coursecount()
                            maindash.departmentcount()
                            Totaldepartment.departmentoverview()
                            totalstudents.studentoverview()
                            studlist.viewdepartments()
                            studlist.viewcoursedata()

                        Else
                            MessageBox.Show("Department not found or could not be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using

                    CloseConnection()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub viewdepart_SelectionChanged(sender As Object, e As EventArgs) Handles viewdepart.SelectionChanged
        Dim i As Integer = viewdepart.CurrentRow.Index
        ID = viewdepart.Item(0, i).Value
        Department = viewdepart.Item(1, i).Value
        Description = viewdepart.Item(2, i).Value
    End Sub
End Class