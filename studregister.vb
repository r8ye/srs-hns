'Imports MySql.Data.MySqlClient

'Public Class Form3

'    ' Declare the event
'    Public Event DataChanged()
'    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ' Populate combo boxes with data when the form loads
'        cmbGender.Items.Add("Male")
'        cmbGender.Items.Add("Female")

'        cmbYearLevel.Items.Add("1st Year")
'        cmbYearLevel.Items.Add("2nd Year")
'        cmbYearLevel.Items.Add("3rd Year")
'        cmbYearLevel.Items.Add("4th Year")
'    End Sub

'    ' Submit new student record
'    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
'        ' Validate input fields
'        If String.IsNullOrWhiteSpace(txtStudentID.Text) Then
'            MessageBox.Show("Please enter a Student ID.")
'            Return
'        End If

'        ' Connect to the database
'        DataModule.OpenConnection()

'        ' Check if the student ID already exists in the 'personal' table
'        Dim checkQuery As String = "SELECT COUNT(*) FROM personal WHERE student_id = @student_id"
'        Dim checkCmd As New MySqlCommand(checkQuery, DataModule.Connection)
'        checkCmd.Parameters.AddWithValue("@student_id", txtStudentID.Text)
'        Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

'        If count > 0 Then
'            ' If student ID already exists, notify the user
'            MessageBox.Show("Student ID already exists. Please update the existing record.")
'            DataModule.CloseConnection()
'            Return
'        End If

'        ' Insert personal data into 'personal' table
'        Dim query As String = "INSERT INTO personal (student_id, last_name, first_name, middle_name, email, home_address, father_name, mother_name, gender, birthday) VALUES (@student_id, @last_name, @first_name, @middle_name, @email, @home_address, @father_name, @mother_name, @gender, @birthday)"
'        Dim cmd As New MySqlCommand(query, DataModule.Connection)
'        cmd.Parameters.AddWithValue("@student_id", txtStudentID.Text)
'        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text)
'        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text)
'        cmd.Parameters.AddWithValue("@middle_name", txtMiddleName.Text)
'        cmd.Parameters.AddWithValue("@email", txtEmail.Text)
'        cmd.Parameters.AddWithValue("@home_address", txtHomeAddress.Text)
'        cmd.Parameters.AddWithValue("@father_name", txtFatherName.Text)
'        cmd.Parameters.AddWithValue("@mother_name", txtMotherName.Text)
'        cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem)
'        cmd.Parameters.AddWithValue("@birthday", dtpBirthday.Value)

'        cmd.ExecuteNonQuery()

'        ' Insert education data into 'education' table
'        Dim educationQuery As String = "INSERT INTO education (student_id, year_level, department, program) VALUES (@student_id, @year_level, @department, @program)"
'        Dim educationCmd As New MySqlCommand(educationQuery, DataModule.Connection)
'        educationCmd.Parameters.AddWithValue("@student_id", txtStudentID.Text)
'        educationCmd.Parameters.AddWithValue("@year_level", cmbYearLevel.SelectedItem)
'        educationCmd.Parameters.AddWithValue("@department", cmbDepartment.SelectedItem)
'        educationCmd.Parameters.AddWithValue("@program", cmbProgram.SelectedItem)

'        educationCmd.ExecuteNonQuery()

'        MessageBox.Show("Student registered successfully!")

'        RaiseEvent DataChanged()

'        ClearFields()

'        DataModule.CloseConnection()
'    End Sub


'    ' Handle student search by ID
'    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
'        ' Validate the Student ID input
'        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
'            MessageBox.Show("Please enter a Student ID to search.")
'            Return
'        End If

'        ' Connect to the database
'        DataModule.OpenConnection()

'        ' Query the 'personal' table for the student details
'        Dim query As String = "SELECT * FROM personal WHERE student_id = @student_id"
'        Dim cmd As New MySqlCommand(query, DataModule.Connection)
'        cmd.Parameters.AddWithValue("@student_id", txtSearch.Text)

'        Dim reader As MySqlDataReader = cmd.ExecuteReader()

'        If reader.HasRows Then
'            ' Populate textboxes with the student data
'            reader.Read()
'            txtStudentID.Text = reader("student_id").ToString()
'            txtLastName.Text = reader("last_name").ToString()
'            txtFirstName.Text = reader("first_name").ToString()
'            txtMiddleName.Text = reader("middle_name").ToString()
'            txtEmail.Text = reader("email").ToString()
'            txtHomeAddress.Text = reader("home_address").ToString()
'            txtFatherName.Text = reader("father_name").ToString()
'            txtMotherName.Text = reader("mother_name").ToString()
'            cmbGender.SelectedItem = reader("gender").ToString()
'            dtpBirthday.Value = Convert.ToDateTime(reader("birthday"))

'            ' Close the first reader before executing the next query
'            reader.Close()

'            ' Fetch education data
'            Dim educationQuery As String = "SELECT * FROM education WHERE student_id = @student_id"
'            Dim educationCmd As New MySqlCommand(educationQuery, DataModule.Connection)
'            educationCmd.Parameters.AddWithValue("@student_id", txtSearch.Text)

'            ' Execute and handle the education query
'            Dim educationReader As MySqlDataReader = educationCmd.ExecuteReader()
'            If educationReader.HasRows Then
'                educationReader.Read()
'                cmbYearLevel.SelectedItem = educationReader("year_level").ToString()
'                cmbDepartment.SelectedItem = educationReader("department").ToString()
'                cmbProgram.SelectedItem = educationReader("program").ToString()
'            End If

'            ' Close the education reader after use
'            educationReader.Close()
'        Else
'            MessageBox.Show("Student not found.")
'        End If

'        ' Close the initial reader
'        reader.Close()



'        DataModule.CloseConnection()
'    End Sub

'    ' Edit the student record
'    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
'        ' Validate the input fields
'        If String.IsNullOrWhiteSpace(txtStudentID.Text) Then
'            MessageBox.Show("Please select a student first.")
'            Return
'        End If

'        ' Connect to the database
'        DataModule.OpenConnection()

'        ' Update personal data in 'personal' table
'        Dim query As String = "UPDATE personal SET last_name = @last_name, first_name = @first_name, middle_name = @middle_name, email = @email, home_address = @home_address, father_name = @father_name, mother_name = @mother_name, gender = @gender, birthday = @birthday WHERE student_id = @student_id"
'        Dim cmd As New MySqlCommand(query, DataModule.Connection)
'        cmd.Parameters.AddWithValue("@student_id", txtStudentID.Text)
'        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text)
'        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text)
'        cmd.Parameters.AddWithValue("@middle_name", txtMiddleName.Text)
'        cmd.Parameters.AddWithValue("@email", txtEmail.Text)
'        cmd.Parameters.AddWithValue("@home_address", txtHomeAddress.Text)
'        cmd.Parameters.AddWithValue("@father_name", txtFatherName.Text)
'        cmd.Parameters.AddWithValue("@mother_name", txtMotherName.Text)
'        cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem)
'        cmd.Parameters.AddWithValue("@birthday", dtpBirthday.Value)

'        cmd.ExecuteNonQuery()

'        ' Update education data in 'education' table
'        Dim educationQuery As String = "UPDATE education SET year_level = @year_level, department = @department, program = @program WHERE student_id = @student_id"
'        Dim educationCmd As New MySqlCommand(educationQuery, DataModule.Connection)
'        educationCmd.Parameters.AddWithValue("@student_id", txtStudentID.Text)
'        educationCmd.Parameters.AddWithValue("@year_level", cmbYearLevel.SelectedItem)
'        educationCmd.Parameters.AddWithValue("@department", cmbDepartment.SelectedItem)
'        educationCmd.Parameters.AddWithValue("@program", cmbProgram.SelectedItem)

'        educationCmd.ExecuteNonQuery()

'        MessageBox.Show("Student record updated successfully!")

'        RaiseEvent DataChanged()

'        ClearFields()

'        DataModule.CloseConnection()
'    End Sub


'    ' Delete the student record
'    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
'        ' Validate the input fields
'        If String.IsNullOrWhiteSpace(txtStudentID.Text) Then
'            MessageBox.Show("Please select a student first.")
'            Return
'        End If

'        ' Confirm deletion
'        Dim result = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo)
'        If result = DialogResult.Yes Then
'            ' Connect to the database
'            DataModule.OpenConnection()

'            ' First, delete the student from 'education' table
'            Dim educationQuery As String = "DELETE FROM education WHERE student_id = @student_id"
'            Dim educationCmd As New MySqlCommand(educationQuery, DataModule.Connection)
'            educationCmd.Parameters.AddWithValue("@student_id", txtStudentID.Text)
'            educationCmd.ExecuteNonQuery()

'            ' Then, delete the student from 'personal' table
'            Dim query As String = "DELETE FROM personal WHERE student_id = @student_id"
'            Dim cmd As New MySqlCommand(query, DataModule.Connection)
'            cmd.Parameters.AddWithValue("@student_id", txtStudentID.Text)
'            cmd.ExecuteNonQuery()

'            RaiseEvent DataChanged()

'            ClearFields()

'            DataModule.CloseConnection()
'        End If
'    End Sub

'    Private Sub ClearFields()
'        ' Clear all textboxes
'        txtStudentID.Clear()
'        txtLastName.Clear()
'        txtFirstName.Clear()
'        txtMiddleName.Clear()
'        txtEmail.Clear()
'        txtHomeAddress.Clear()
'        txtFatherName.Clear()
'        txtMotherName.Clear()
'        txtSearch.Clear()

'        ' Reset combo boxes
'        cmbGender.SelectedIndex = -1
'        cmbYearLevel.SelectedIndex = -1
'        cmbDepartment.SelectedIndex = -1
'        cmbProgram.SelectedIndex = -1

'        ' Reset date picker
'        dtpBirthday.Value = DateTime.Now
'    End Sub


'    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
'        Form4.Show()
'        Me.Hide()
'    End Sub

'    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
'        MessageBox.Show("You have successfully logged out.")

'        Registration.Show()
'        Me.Hide()
'    End Sub

'    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
'        ClearFields()
'    End Sub

'    Private Sub panelBody_Paint(sender As Object, e As PaintEventArgs) Handles panelBody.Paint

'    End Sub

'    Private Sub gbEducation_Click(sender As Object, e As EventArgs) Handles gbEducation.Click

'    End Sub

'    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged

'    End Sub

'    Private Sub lblLastName_Click(sender As Object, e As EventArgs) Handles lblLastName.Click

'    End Sub
'End Class