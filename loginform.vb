Imports MySql.Data.MySqlClient

Public Class loginform
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        login()
    End Sub
    Sub login()
        Try
            Dim fullName As String = ""
            Dim found As Boolean = False

            If String.IsNullOrEmpty(usertypename.Text) OrElse String.IsNullOrEmpty(password.Text) Then
                password.PlaceholderText = "Invalid Password"
                password.PlaceholderForeColor = Color.Red
                usertypename.PlaceholderText = "Invalid Username"
                usertypename.PlaceholderForeColor = Color.Red
                Return
            End If

            DataModule.OpenConnection()

            Dim query As String = "SELECT * FROM usertype WHERE BINARY Username = @User AND BINARY Password = @Pass"
            Using cmd As New MySqlCommand(query, DataModule.Connection)
                cmd.Parameters.AddWithValue("@User", usertypename.Text)
                cmd.Parameters.AddWithValue("@Pass", password.Text)

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        Dim isSuperadmin As Boolean = (dr("Usertype").ToString() = "Superadmin")
                        fullName = dr("Usertype").ToString()
                        found = True
                        tryDashboard.accbtn.Visible = True
                        tryDashboard.Visible = False
                        tryDashboard.Location = New Point(3, 466)
                        tryDashboard.Location = New Point(3, 364)
                        tryDashboard.Location = New Point(3, 263)
                        tryDashboard.Location = New Point(3, 313)
                        tryDashboard.Location = New Point(3, 415)

                        If Not isSuperadmin Then
                            tryDashboard.accbtn.Visible = False
                            tryDashboard.deptbtn.Location = New Point(3, 398)
                            tryDashboard.rgsbtn.Location = New Point(3, 274)
                            tryDashboard.stdbtn.Location = New Point(3, 336)
                            tryDashboard.crsbtn.Location = New Point(3, 460)
                            tryDashboard.user.Location = New Point(36, 111)
                            maindash.usertype.Location = New Point(78, 55)
                        End If
                    Else
                        MessageBox.Show("Wrong Username or Password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        usertypename.Clear()
                        password.Clear()
                        usertypename.PlaceholderText = "Invalid Username"
                        usertypename.PlaceholderForeColor = Color.Red
                        password.PlaceholderText = "Invalid Password"
                        password.PlaceholderForeColor = Color.Red
                    End If
                End Using
            End Using

            If found Then
                MessageBox.Show("Access Granted! Welcome " & fullName, "Log In Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Me.Hide()
                password.UseSystemPasswordChar = False
                GunaImageCheckBox1.Checked = False
                tryDashboard.user.Text = fullName
                maindash.usertype.Text = fullName
                tryDashboard.ShowDialog()
                tryDashboard.logo.Visible = True
                tryDashboard.sName.Visible = True
                tryDashboard.regtxt.Visible = True
                usertypename.Clear()
                password.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            DataModule.CloseConnection()
        End Try
    End Sub



    Private Sub loginform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaImageCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaImageCheckBox1.CheckedChanged
        If GunaImageCheckBox1.Checked Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged
        If GunaImageCheckBox1.Checked Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True
        End If
    End Sub
End Class