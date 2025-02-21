Public Class tryDashboard
    Private Sub panelSide_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles stdbtn.Click
        With studlist
            .TopLevel = False
            .BringToFront()
            .TopMost = True
            dashboardpanel.Controls.Add(studlist)
            .Show()
            Course.Hide()
            department.Hide()
            useraccount.Hide()
            Form3.Hide()
            maindash.Hide()
            sName.Hide()
            logo.Hide()
            regtxt.Hide()
        End With
        accbtn.FillColor = Color.Transparent
        rgsbtn.FillColor = Color.Transparent
        stdbtn.FillColor = Color.DeepSkyBlue
        crsbtn.FillColor = Color.Transparent
        deptbtn.FillColor = Color.Transparent
        dashbtn.FillColor = Color.Transparent
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dashbtn_Click(sender As Object, e As EventArgs) Handles dashbtn.Click
        With maindash
            .TopLevel = False
            .BringToFront()
            .TopMost = True
            dashboardpanel.Controls.Add(maindash)
            .Show()
            Course.Hide()
            department.Hide()
            useraccount.Hide()
            studlist.Hide()
            Form3.Hide()
            sName.Hide()
            logo.Hide()
            regtxt.Hide()



        End With
        accbtn.FillColor = Color.Transparent
        rgsbtn.FillColor = Color.Transparent
        stdbtn.FillColor = Color.Transparent
        crsbtn.FillColor = Color.Transparent
        deptbtn.FillColor = Color.Transparent
        dashbtn.FillColor = Color.DeepSkyBlue
    End Sub

    Private Sub rgsbtn_Click(sender As Object, e As EventArgs) Handles rgsbtn.Click
        With Form3
            .TopLevel = False
            .BringToFront()
            .TopMost = True
            dashboardpanel.Controls.Add(Form3)
            .Show()
            Course.Hide()
            department.Hide()
            useraccount.Hide()
            studlist.Hide()
            maindash.Hide()
            sName.Hide()
            logo.Hide()
            regtxt.Hide()
        End With
        accbtn.FillColor = Color.Transparent
        rgsbtn.FillColor = Color.DeepSkyBlue
        stdbtn.FillColor = Color.Transparent
        crsbtn.FillColor = Color.Transparent
        deptbtn.FillColor = Color.Transparent
        dashbtn.FillColor = Color.Transparent


    End Sub

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub deptbtn_Click(sender As Object, e As EventArgs) Handles deptbtn.Click
        With department
            .TopLevel = False
            .BringToFront()
            .TopMost = True
            dashboardpanel.Controls.Add(department)
            .Show()
            Course.Hide()
            Form3.Hide()
            useraccount.Hide()
            studlist.Hide()
            maindash.Hide()
            sName.Hide()
            regtxt.Hide()
            logo.Hide()
        End With
        accbtn.FillColor = Color.Transparent
        rgsbtn.FillColor = Color.Transparent
        stdbtn.FillColor = Color.Transparent
        crsbtn.FillColor = Color.Transparent
        deptbtn.FillColor = Color.DeepSkyBlue
        dashbtn.FillColor = Color.Transparent


    End Sub

    Private Sub accbtn_Click(sender As Object, e As EventArgs) Handles accbtn.Click
        With useraccount
            .TopLevel = False
            .BringToFront()
            .TopMost = True
            dashboardpanel.Controls.Add(useraccount)
            .Show()
            Course.Hide()
            department.Hide()
            Form3.Hide()
            studlist.Hide()
            maindash.Hide()
            sName.Hide()
            regtxt.Hide()
            logo.Hide()
        End With
        accbtn.FillColor = Color.DeepSkyBlue
        rgsbtn.FillColor = Color.Transparent
        stdbtn.FillColor = Color.Transparent
        crsbtn.FillColor = Color.Transparent
        deptbtn.FillColor = Color.Transparent
        dashbtn.FillColor = Color.Transparent


    End Sub

    Private Sub crsbtn_Click(sender As Object, e As EventArgs) Handles crsbtn.Click
        With Course
            .TopLevel = False
            .BringToFront()
            .TopMost = True
            dashboardpanel.Controls.Add(Course)
            .Show()
            Form3.Hide()
            department.Hide()
            useraccount.Hide()
            studlist.Hide()
            maindash.Hide()
            sName.Hide()
            logo.Hide()
            regtxt.Hide()
        End With
        accbtn.FillColor = Color.Transparent
        rgsbtn.FillColor = Color.Transparent
        stdbtn.FillColor = Color.Transparent
        crsbtn.FillColor = Color.DeepSkyBlue
        deptbtn.FillColor = Color.Transparent
        dashbtn.FillColor = Color.Transparent

    End Sub

    Private Sub GunaCirclePictureBox1_Click(sender As Object, e As EventArgs) Handles logo.Click

    End Sub

    Private Sub sName_Click(sender As Object, e As EventArgs) Handles sName.Click

    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Logout()
        user.Location = New Point(15, 110)
        accbtn.Visible = True
        accbtn.Visible = False
        accbtn.Location = New Point(3, 466)
        deptbtn.Location = New Point(3, 364)
        rgsbtn.Location = New Point(3, 263)
        stdbtn.Location = New Point(3, 313)
        crsbtn.Location = New Point(3, 415)

    End Sub
    Sub Logout()
        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("You have been logged out successfully!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)

                loginform.Show()
                Me.Close()

                For Each form As Form In Application.OpenForms.OfType(Of Form).ToList()
                    If form.Name <> "loginform" Then
                        form.Close()
                    End If
                Next

                rgsbtn.FillColor = Color.Transparent
                stdbtn.FillColor = Color.Transparent
                deptbtn.FillColor = Color.Transparent
                crsbtn.FillColor = Color.Transparent
                accbtn.FillColor = Color.Transparent
                dashbtn.FillColor = Color.Transparent

                sName.Visible = True
                logo.Visible = True
                regtxt.Visible = True
            Else
                MessageBox.Show("Logout canceled.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred during logout: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class