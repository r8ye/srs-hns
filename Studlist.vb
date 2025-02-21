'Imports MySql.Data.MySqlClient

'Public Class Form4
'    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        LoadData()  ' Load all student data initially
'        AddHandler Form3.DataChanged, AddressOf ReloadData
'    End Sub

'    Public Sub ReloadData()
'        LoadData() ' Refresh the data in the DataGridView
'    End Sub


'    ' Load all data into DataGridView
'    Private Sub LoadData()
'        ' SQL query to get personal and education data
'        Dim query As String = "SELECT personal.student_id, personal.last_name, personal.first_name, personal.middle_name, " &
'                      "personal.email, personal.home_address, personal.father_name, personal.mother_name, personal.gender, " &
'                      "personal.birthday, education.year_level, education.department, education.program " &
'                      "FROM personal " &
'                      "JOIN education ON personal.student_id = education.student_id " &
'                      "ORDER BY personal.student_id ASC"



'        ' Set up the MySQL command with the query
'        Dim cmd As New MySqlCommand(query, DataModule.Connection)

'        ' Create a DataAdapter to execute the query
'        Dim adapter As New MySqlDataAdapter(cmd)

'        ' Create a DataTable to hold the data
'        Dim table As New DataTable()

'        ' Open connection, execute query, and close connection
'        DataModule.OpenConnection()
'        adapter.Fill(table)
'        DataModule.CloseConnection()

'        ' Bind the result to the DataGridView
'        dgvStudents.DataSource = table

'        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
'        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

'        ' Set column headers if necessary
'        If dgvStudents.Columns.Count > 0 Then
'            If dgvStudents.Columns.Contains("student_id") Then
'                dgvStudents.Columns("student_id").HeaderText = "Student ID"
'            End If
'            If dgvStudents.Columns.Contains("last_name") Then
'                dgvStudents.Columns("last_name").HeaderText = "Last Name"
'            End If
'            If dgvStudents.Columns.Contains("first_name") Then
'                dgvStudents.Columns("first_name").HeaderText = "First Name"
'            End If
'            If dgvStudents.Columns.Contains("middle_name") Then
'                dgvStudents.Columns("middle_name").HeaderText = "Middle Name"
'            End If
'            If dgvStudents.Columns.Contains("email") Then
'                dgvStudents.Columns("email").HeaderText = "Email"
'            End If
'            If dgvStudents.Columns.Contains("home_address") Then
'                dgvStudents.Columns("home_address").HeaderText = "Home Address"
'            End If
'            If dgvStudents.Columns.Contains("father_name") Then
'                dgvStudents.Columns("father_name").HeaderText = "Father's Name"
'            End If
'            If dgvStudents.Columns.Contains("mother_name") Then
'                dgvStudents.Columns("mother_name").HeaderText = "Mother's Name"
'            End If
'            If dgvStudents.Columns.Contains("gender") Then
'                dgvStudents.Columns("gender").HeaderText = "Gender"
'            End If
'            If dgvStudents.Columns.Contains("birthday") Then
'                dgvStudents.Columns("birthday").HeaderText = "Birthday"
'            End If
'            If dgvStudents.Columns.Contains("year_level") Then
'                dgvStudents.Columns("year_level").HeaderText = "Year Level"
'            End If
'            If dgvStudents.Columns.Contains("department") Then
'                dgvStudents.Columns("department").HeaderText = "Department"
'            End If
'            If dgvStudents.Columns.Contains("program") Then
'                dgvStudents.Columns("program").HeaderText = "Program"
'            End If
'        End If
'    End Sub

'    ' Search student by ID or name
'    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
'        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
'            LoadData() ' Load all data if search box is empty
'            Return
'        End If

'        ' Existing search logic
'        Dim searchValue As String = txtSearch.Text.Trim()
'        Dim query As String = "SELECT personal.student_id, personal.last_name, personal.first_name, personal.middle_name, " &
'                          "personal.email, personal.home_address, personal.father_name, personal.mother_name, personal.gender, " &
'                          "personal.birthday, education.year_level, education.department, education.program " &
'                          "FROM personal " &
'                          "JOIN education ON personal.student_id = education.student_id " &
'                          "WHERE personal.student_id LIKE @search OR personal.last_name LIKE @search OR personal.first_name LIKE @search"

'        Dim cmd As New MySqlCommand(query, DataModule.Connection)
'        cmd.Parameters.AddWithValue("@search", "%" & searchValue & "%")

'        Dim adapter As New MySqlDataAdapter(cmd)
'        Dim table As New DataTable()

'        DataModule.OpenConnection()
'        adapter.Fill(table)
'        DataModule.CloseConnection()

'        dgvStudents.DataSource = table

'        If table.Rows.Count = 0 Then
'            MessageBox.Show("No records found.")
'        End If
'    End Sub

'    ' Register a new student (opens Form3)
'    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
'        Form3.Show()
'        Me.Hide()
'    End Sub

'    ' Log out and return to Form1
'    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
'        MessageBox.Show("You have successfully logged out.")

'        ' Show Form1 (login screen) and hide this form
'        Registration.Show()
'        Me.Hide()
'    End Sub

'    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
'        LoadData()
'        txtSearch.Clear()
'    End Sub

'    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnBack.Click
'        LoadData()
'        txtSearch.Clear()
'    End Sub

'    Private Sub panelBody_Paint(sender As Object, e As PaintEventArgs) Handles panelBody.Paint

'    End Sub
'End Class