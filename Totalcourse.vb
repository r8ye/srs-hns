Imports MySql.Data.MySqlClient

Public Class Totalcourse
    Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Totalcourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        courseoverview()
    End Sub
    Sub courseoverview()
        DataModule.OpenConnection()
        courseflowpanel.Controls.Clear()

        Try
            Dim query As String = "SELECT tblcourse.CID, tblcourse.Course, tblcourse.Description, department.Department " &
                      "FROM registration.tblcourse " &
                      "INNER JOIN registration.department ON tblcourse.DID = department.DID"

            Using cmd As New MySqlCommand(query, DataModule.Connection)
                Dim drparty As MySqlDataReader = cmd.ExecuteReader()

                While drparty.Read()
                    Dim panelparty As New Guna.UI.WinForms.GunaPanel()

                    Dim course As New Label
                    Dim department As New Label
                    Dim description As New Label


                    With panelparty
                        .Size = New Size(635, 60)
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




                    With course
                        .Text = drparty("Course").ToString()
                        .ForeColor = Color.MidnightBlue
                        .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .Location = New Point(26, 19)
                        .AutoSize = True
                    End With
                    panelparty.Controls.Add(course)
                    With description
                        .Text = drparty("Description").ToString()
                        .ForeColor = Color.MidnightBlue
                        .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .Location = New Point(116, 19)
                        .AutoSize = True
                    End With
                    panelparty.Controls.Add(description)

                    With department
                        .Text = drparty("Department").ToString()
                        .ForeColor = Color.MidnightBlue
                        .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .Location = New Point(543, 19)
                        .AutoSize = True
                    End With
                    panelparty.Controls.Add(department)







                    courseflowpanel.Controls.Add(panelparty)
                End While
                drparty.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving vote report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DataModule.CloseConnection()
        End Try
    End Sub
    Private Sub cbX_Click(sender As Object, e As EventArgs) Handles cbX.Click
        Me.Close()
    End Sub


End Class