Imports MySql.Data.MySqlClient

Public Class totalstudents
    Private Sub lblRegisterStudent_Click(sender As Object, e As EventArgs) Handles lblRegisterStudent.Click

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel5.Click

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles studentsflowpnel.Paint

    End Sub

    Private Sub cbX_Click(sender As Object, e As EventArgs) Handles cbX.Click
        Me.Close()
    End Sub

    Private Sub Guna2HtmlLabel14_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel14.Click

    End Sub

    Private Sub Guna2HtmlLabel6_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel6.Click

    End Sub

    Private Sub totalstudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        studentoverview()

    End Sub
    Sub StudentsFilter()
        Try

            Dim searchText As String = txtSearch.Text.Trim()

            studentsflowpnel.Controls.Clear()

            DataModule.OpenConnection()

            Dim sqlQuery As String = "SELECT tblstudents.studentID, tblstudents.Lname, tblstudents.Fname, tblstudents.Mname, tblstudents.Gender, tblstudents.Cnumber, " &
                                 "tblcourse.Course, department.Department, tblstudents.Yearlvl " &
                                 "FROM registration.tblstudents " &
                                 "INNER JOIN registration.department ON tblstudents.DID = department.DID " &
                                 "INNER JOIN registration.tblcourse ON tblstudents.CID = tblcourse.CID " &
                                 "WHERE 1=1"



            If Not String.IsNullOrEmpty(searchText) Then
                sqlQuery &= " AND (tblstudents.studentID LIKE @Search OR tblstudents.Lname LIKE @Search OR tblstudents.Fname LIKE @Search)"
            End If

            Using cmd As New MySqlCommand(sqlQuery, DataModule.Connection)


                If Not String.IsNullOrEmpty(searchText) Then
                    cmd.Parameters.AddWithValue("@Search", "%" & searchText & "%")
                End If

                Using drparty As MySqlDataReader = cmd.ExecuteReader()
                    While drparty.Read()
                        Dim panelparty As New Guna.UI.WinForms.GunaPanel()
                        Dim fname As New Label
                        Dim course As New Label
                        Dim department As New Label
                        Dim ID As New Label
                        Dim year As New Label
                        Dim Cnumber As New Label
                        Dim gender As New Label

                        With panelparty
                            .Size = New Size(898, 60)
                            .BackColor = Color.Transparent
                            .Margin = New Padding(3)
                            .BorderStyle = BorderStyle.None
                        End With

                        AddHandler panelparty.Paint, Sub(sender, e)
                                                         Dim borderColor As Color = Color.MidnightBlue
                                                         Dim borderThickness As Integer = 2
                                                         Dim borderRadius As Integer = 10
                                                         Dim panelRect As New Rectangle(0, 0, panelparty.Width - 1, panelparty.Height - 1)

                                                         Using path As New Drawing2D.GraphicsPath()
                                                             path.AddArc(panelRect.Left, panelRect.Top, borderRadius, borderRadius, 180, 90)
                                                             path.AddArc(panelRect.Right - borderRadius, panelRect.Top, borderRadius, borderRadius, 270, 90)
                                                             path.AddArc(panelRect.Right - borderRadius, panelRect.Bottom - borderRadius, borderRadius, borderRadius, 0, 90)
                                                             path.AddArc(panelRect.Left, panelRect.Bottom - borderRadius, borderRadius, borderRadius, 90, 90)
                                                             path.CloseFigure()

                                                             e.Graphics.DrawPath(New Pen(borderColor, borderThickness), path)
                                                         End Using
                                                     End Sub

                        With ID
                            .Text = drparty("studentID").ToString()
                            .ForeColor = Color.MidnightBlue
                            .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                            .Location = New Point(26, 19)
                            .AutoSize = True
                        End With
                        panelparty.Controls.Add(ID)

                        With fname
                            .Text = $"{drparty("Lname")}, {drparty("Fname")} {drparty("Mname")}."
                            .ForeColor = Color.MidnightBlue
                            .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                            .Location = New Point(121, 19)
                            .AutoSize = True
                        End With
                        panelparty.Controls.Add(fname)

                        With course
                            .Text = drparty("Course").ToString()
                            .ForeColor = Color.MidnightBlue
                            .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                            .Location = New Point(352, 19)
                            .AutoSize = True
                        End With
                        panelparty.Controls.Add(course)

                        With department
                            .Text = drparty("Department").ToString()
                            .ForeColor = Color.MidnightBlue
                            .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                            .Location = New Point(455, 19)
                            .AutoSize = True
                        End With
                        panelparty.Controls.Add(department)

                        With year
                            .Text = drparty("Yearlvl").ToString()
                            .ForeColor = Color.MidnightBlue
                            .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                            .Location = New Point(565, 19)
                            .AutoSize = True
                        End With
                        panelparty.Controls.Add(year)

                        With Cnumber
                            .Text = drparty("Cnumber").ToString()
                            .ForeColor = Color.MidnightBlue
                            .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                            .Location = New Point(674, 19)
                            .AutoSize = True
                        End With
                        panelparty.Controls.Add(Cnumber)

                        With gender
                            .Text = drparty("Gender").ToString()
                            .ForeColor = Color.MidnightBlue
                            .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                            .Location = New Point(815, 19)
                            .AutoSize = True
                        End With
                        panelparty.Controls.Add(gender)

                        studentsflowpnel.Controls.Add(panelparty)
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving student data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DataModule.CloseConnection()
        End Try
    End Sub

    Sub studentoverview()
        DataModule.OpenConnection()
        studentsflowpnel.Controls.Clear()

        Try
            Dim query As String = "SELECT tblstudents.studentID, tblstudents.Lname, tblstudents.Fname, tblstudents.Mname, tblstudents.Gender, tblstudents.Cnumber, " &
                                  "tblcourse.Course, department.Department, tblstudents.Yearlvl " &
                                  "FROM registration.tblstudents " &
                                  "INNER JOIN registration.department ON tblstudents.DID = department.DID " &
                                  "INNER JOIN registration.tblcourse ON tblstudents.CID = tblcourse.CID"

            Using cmd As New MySqlCommand(query, DataModule.Connection)
                Dim drparty As MySqlDataReader = cmd.ExecuteReader()

                While drparty.Read()
                    Dim panelparty As New Guna.UI.WinForms.GunaPanel()
                    Dim fname As New Label
                    Dim course As New Label
                    Dim department As New Label
                    Dim ID As New Label
                    Dim year As New Label
                    Dim Cnumber As New Label
                    Dim gender As New Label

                    With panelparty
                        .Size = New Size(898, 60)
                        .BackColor = Color.Transparent
                        .Margin = New Padding(3)
                        .BorderStyle = BorderStyle.None
                    End With

                    AddHandler panelparty.Paint, Sub(sender, e)
                                                     Dim borderColor As Color = Color.MidnightBlue
                                                     Dim borderThickness As Integer = 2
                                                     Dim borderRadius As Integer = 10
                                                     Dim panelRect As New Rectangle(0, 0, panelparty.Width - 1, panelparty.Height - 1)

                                                     Using path As New Drawing2D.GraphicsPath()
                                                         path.AddArc(panelRect.Left, panelRect.Top, borderRadius, borderRadius, 180, 90)
                                                         path.AddArc(panelRect.Right - borderRadius, panelRect.Top, borderRadius, borderRadius, 270, 90)
                                                         path.AddArc(panelRect.Right - borderRadius, panelRect.Bottom - borderRadius, borderRadius, borderRadius, 0, 90)
                                                         path.AddArc(panelRect.Left, panelRect.Bottom - borderRadius, borderRadius, borderRadius, 90, 90)
                                                         path.CloseFigure()

                                                         e.Graphics.DrawPath(New Pen(borderColor, borderThickness), path)
                                                     End Using
                                                 End Sub

                    With ID
                        .Text = drparty("studentID").ToString()
                        .ForeColor = Color.MidnightBlue
                        .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .Location = New Point(26, 19)
                        .AutoSize = True
                    End With
                    panelparty.Controls.Add(ID)

                    With fname
                        .Text = $"{drparty("Lname")}, {drparty("Fname")} {drparty("Mname")}."
                        .ForeColor = Color.MidnightBlue
                        .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .Location = New Point(121, 19)
                        .AutoSize = True
                    End With
                    panelparty.Controls.Add(fname)

                    With course
                        .Text = drparty("Course").ToString()
                        .ForeColor = Color.MidnightBlue
                        .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .Location = New Point(352, 19)
                        .AutoSize = True
                    End With
                    panelparty.Controls.Add(course)

                    With department
                        .Text = drparty("Department").ToString()
                        .ForeColor = Color.MidnightBlue
                        .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .Location = New Point(455, 19)
                        .AutoSize = True
                    End With
                    panelparty.Controls.Add(department)

                    With year
                        .Text = drparty("Yearlvl").ToString()
                        .ForeColor = Color.MidnightBlue
                        .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .Location = New Point(565, 19)
                        .AutoSize = True
                    End With
                    panelparty.Controls.Add(year)

                    With Cnumber
                        .Text = drparty("Cnumber").ToString()
                        .ForeColor = Color.MidnightBlue
                        .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .Location = New Point(674, 19)
                        .AutoSize = True
                    End With
                    panelparty.Controls.Add(Cnumber)

                    With gender
                        .Text = drparty("Gender").ToString()
                        .ForeColor = Color.MidnightBlue
                        .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .Location = New Point(815, 19)
                        .AutoSize = True
                    End With
                    panelparty.Controls.Add(gender)

                    studentsflowpnel.Controls.Add(panelparty)
                End While
                drparty.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving vote report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DataModule.CloseConnection()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        StudentsFilter()
    End Sub
End Class