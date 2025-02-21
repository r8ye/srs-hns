Imports MySql.Data.MySqlClient

Public Class maindash
    Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        totalstudents.ShowDialog()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Totaldepartment.ShowDialog()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Totalcourse.ShowDialog()
    End Sub

    Private Sub maindash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coursecount()
        studentscount()
        departmentcount()
    End Sub
    Public Sub coursecount()
        Try
            DataModule.OpenConnection()

            Dim query As String = "SELECT COUNT(*) FROM registration.tblcourse"

            Using cmd As New MySqlCommand(query, DataModule.Connection)
                Dim totalRecords As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                coursetotal.Text = totalRecords.ToString()
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Error fetching candidate count: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            DataModule.CloseConnection()
        End Try
    End Sub
    Public Sub departmentcount()
        Try
            DataModule.OpenConnection()

            Dim query As String = "SELECT COUNT(*) FROM registration.department"

            Using cmd As New MySqlCommand(query, DataModule.Connection)
                Dim totalRecords As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                totaldepaart.Text = totalRecords.ToString()
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Error fetching candidate count: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            DataModule.CloseConnection()
        End Try
    End Sub
    Public Sub studentscount()
        Try
            DataModule.OpenConnection()

            Dim query As String = "SELECT COUNT(*) FROM registration.tblstudents"

            Using cmd As New MySqlCommand(query, DataModule.Connection)
                Dim totalRecords As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                totalstudentss.Text = totalRecords.ToString()
            End Using

        Catch ex As MySqlException
            MessageBox.Show("Error fetching candidate count: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            DataModule.CloseConnection()
        End Try
    End Sub

    Private Sub crsbtn_Click(sender As Object, e As EventArgs)

    End Sub
End Class