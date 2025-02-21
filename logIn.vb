'Imports MySql.Data.MySqlClient

'Public Class logIn

'    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
'        Dim username As String = txtUsername.Text
'        Dim password As String = txtPassword.Text
'        DataModule.OpenConnection()
'        Dim query As String = "SELECT * FROM admin_users WHERE username = @username AND password_hash = SHA2(@password, 256)"
'        Dim cmd As New MySqlCommand(query, DataModule.Connection)
'        cmd.Parameters.AddWithValue("@username", username)
'        cmd.Parameters.AddWithValue("@password", password)

'        Dim reader As MySqlDataReader = cmd.ExecuteReader()

'        If reader.HasRows Then

'            MessageBox.Show("Sign In Successful!")
'            Dim form3 As New Form3()
'            form3.Show()
'            Me.Hide()
'        Else
'            MessageBox.Show("Invalid username or password.")
'        End If

'        ClearFields()

'        DataModule.CloseConnection()
'    End Sub

'    Private Sub ClearFields()
'        txtUsername.Clear()
'        txtPassword.Clear()
'    End Sub

'    Private Sub linkSignUp_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSignUp.LinkClicked



'        ClearFields()
'    End Sub

'    Private Sub txtShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbSignInSP.CheckedChanged
'        If cbSignInSP.Checked = True Then
'            txtPassword.UseSystemPasswordChar = False
'        Else
'            txtPassword.UseSystemPasswordChar = True
'        End If
'    End Sub


'End Class
