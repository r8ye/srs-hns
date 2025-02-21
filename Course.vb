Imports MySql.Data.MySqlClient

Public Class Course
Dim ID, Course, Department, Description As String
Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
    addcourse.Show()
End Sub

    Private Sub departmentc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles departcombo.SelectedIndexChanged
        FilterCourses()

    End Sub
    Public Sub CourseView()
        Dim i As Integer = 0
        viewcourse.Rows.Clear()
        OpenConnection()

        Dim query As String = "SELECT tblcourse.CID, tblcourse.Course, tblcourse.Description, department.Department " &
                      "FROM registration.tblcourse " &
                      "INNER JOIN registration.department ON tblcourse.DID = department.DID"

        Using cmd As New MySqlCommand(query, Connection)
            Using dr As MySqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    i += 1
                    viewcourse.Rows.Add(dr.Item("CID").ToString(),
                                dr.Item("Course").ToString(),
                                dr.Item("Description").ToString(),
                                dr.Item("Department").ToString())
                End While
            End Using
        End Using

        CloseConnection()

        totaldepart.Text = "(" & viewcourse.Rows.Count & ")"
    End Sub

    Private Sub Course_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CourseView()

        filldepartment()
    End Sub
    Sub filldepartment()

        departcombo.Items.Clear()
        departcombo.Items.Add("All")
        departcombo.SelectedIndex = 0

        OpenConnection()

        Dim query As String = "SELECT * FROM registration.department"
        Using cmd As New MySqlCommand(query, Connection)
            Using dr As MySqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    departcombo.Items.Add(dr("Department").ToString())
                End While
            End Using
        End Using

        CloseConnection()
    End Sub
    Sub FilterCourses()
        Try
            viewcourse.Rows.Clear()

            Dim selectedDepartment As String = If(departcombo.SelectedItem IsNot Nothing, departcombo.SelectedItem.ToString(), "All")

            Dim query As String = "SELECT tblcourse.CID, tblcourse.Course, tblcourse.Description, department.Department " &
                              "FROM registration.tblcourse " &
                              "INNER JOIN registration.department ON tblcourse.DID = department.DID "

            If selectedDepartment <> "All" Then
                query &= "WHERE department.Department = @Department "
            End If

            DataModule.OpenConnection()

            Using cmd As New MySqlCommand(query, DataModule.Connection)
                If selectedDepartment <> "All" Then
                    cmd.Parameters.AddWithValue("@Department", selectedDepartment)
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim id As String = reader("CID").ToString()
                        Dim courseName As String = reader("Course").ToString()
                        Dim description As String = reader("Description").ToString()
                        Dim department As String = reader("Department").ToString()
                        viewcourse.Rows.Add(id, courseName, department, description)
                    End While
                End Using
            End Using

            totaldepart.Text = "(" & viewcourse.RowCount & ")"

        Catch ex As Exception
            MsgBox("Error retrieving courses: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            DataModule.CloseConnection()
        End Try
    End Sub




    Private Sub viewcourse_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewcourse.CellContentClick
        Dim colname As String = viewcourse.Columns(e.ColumnIndex).Name
        Try
            If colname = "edit" Then
                editcourse.loaddept()
                With editcourse
                    .idtext.Text = viewcourse.Rows(e.RowIndex).Cells(0).Value
                    .departttx.Text = viewcourse.Rows(e.RowIndex).Cells(1).Value
                    .destxt.Text = viewcourse.Rows(e.RowIndex).Cells(2).Value
                    .departcombobox.SelectedItem = viewcourse.Rows(e.RowIndex).Cells(3).Value.ToString()
                    .ShowDialog()
                End With
            ElseIf colname = "delete" Then
                If MessageBox.Show("Are you sure you want to delete this Course?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    OpenConnection()

                    Dim deleteCoursesQuery As String = "DELETE FROM registration.tblcourse WHERE CID = @CID"
                    Using deleteCmd As New MySqlCommand(deleteCoursesQuery, Connection)
                        deleteCmd.Parameters.AddWithValue("@CID", viewcourse.Rows(e.RowIndex).Cells(0).Value)
                        deleteCmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Course deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CourseView()
                    maindash.coursecount()
                    Totaldepartment.departmentoverview()
                    totalstudents.studentoverview()
                    Totalcourse.courseoverview()
                    studlist.viewdepartments()
                    studlist.viewcoursedata()


                    CloseConnection()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub viewcourse_SelectionChanged(sender As Object, e As EventArgs) Handles viewcourse.SelectionChanged
        Dim i As Integer = viewcourse.CurrentRow.Index
        ID = viewcourse.Item(0, i).Value
        Course = viewcourse.Item(1, i).Value
        Description = viewcourse.Item(2, i).Value
        Department = viewcourse.Item(3, i).Value
    End Sub



End Class