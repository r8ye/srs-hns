Imports MySql.Data.MySqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.panelBody = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.gbEducation = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.department = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.course = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblDepartment = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblProgram = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.year = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblYearLevel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.studID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblStudentID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblRegisterStudent = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.gbPersonalDetails = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.DID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cgender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.cnumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblEmail = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.mname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblMiddleName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGender = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.fname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblFirstName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblLastName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.elipseBody = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.elipsePersonalDetails = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.elipseEducation = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.elipseForm3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.panelBody.SuspendLayout()
        Me.gbEducation.SuspendLayout()
        Me.gbPersonalDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.Color.Lavender
        Me.panelBody.Controls.Add(Me.Guna2Button1)
        Me.panelBody.Controls.Add(Me.btnSubmit)
        Me.panelBody.Controls.Add(Me.gbEducation)
        Me.panelBody.Controls.Add(Me.lblRegisterStudent)
        Me.panelBody.Controls.Add(Me.gbPersonalDetails)
        Me.panelBody.Location = New System.Drawing.Point(228, 59)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.ShadowDecoration.Parent = Me.panelBody
        Me.panelBody.Size = New System.Drawing.Size(755, 526)
        Me.panelBody.TabIndex = 1
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.BorderThickness = 2
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(598, 493)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(83, 29)
        Me.Guna2Button1.TabIndex = 70
        Me.Guna2Button1.Text = "Register"
        '
        'btnSubmit
        '
        Me.btnSubmit.Animated = True
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.btnSubmit.BorderRadius = 5
        Me.btnSubmit.BorderThickness = 2
        Me.btnSubmit.CheckedState.Parent = Me.btnSubmit
        Me.btnSubmit.CustomImages.Parent = Me.btnSubmit
        Me.btnSubmit.FillColor = System.Drawing.Color.CornflowerBlue
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.HoverState.Parent = Me.btnSubmit
        Me.btnSubmit.Location = New System.Drawing.Point(694, 606)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.ShadowDecoration.Parent = Me.btnSubmit
        Me.btnSubmit.Size = New System.Drawing.Size(83, 29)
        Me.btnSubmit.TabIndex = 56
        Me.btnSubmit.Text = "Add"
        '
        'gbEducation
        '
        Me.gbEducation.BackColor = System.Drawing.Color.Transparent
        Me.gbEducation.BorderColor = System.Drawing.Color.Transparent
        Me.gbEducation.BorderThickness = 0
        Me.gbEducation.Controls.Add(Me.department)
        Me.gbEducation.Controls.Add(Me.course)
        Me.gbEducation.Controls.Add(Me.lblDepartment)
        Me.gbEducation.Controls.Add(Me.lblProgram)
        Me.gbEducation.Controls.Add(Me.year)
        Me.gbEducation.Controls.Add(Me.lblYearLevel)
        Me.gbEducation.Controls.Add(Me.studID)
        Me.gbEducation.Controls.Add(Me.lblStudentID)
        Me.gbEducation.CustomBorderColor = System.Drawing.Color.CornflowerBlue
        Me.gbEducation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEducation.ForeColor = System.Drawing.Color.White
        Me.gbEducation.Location = New System.Drawing.Point(41, 283)
        Me.gbEducation.Name = "gbEducation"
        Me.gbEducation.ShadowDecoration.Parent = Me.gbEducation
        Me.gbEducation.Size = New System.Drawing.Size(666, 206)
        Me.gbEducation.TabIndex = 53
        Me.gbEducation.Text = "Education"
        '
        'department
        '
        Me.department.BackColor = System.Drawing.Color.Transparent
        Me.department.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.department.BorderRadius = 5
        Me.department.BorderThickness = 2
        Me.department.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.department.FocusedColor = System.Drawing.Color.Empty
        Me.department.FocusedState.Parent = Me.department
        Me.department.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.department.ForeColor = System.Drawing.Color.MidnightBlue
        Me.department.FormattingEnabled = True
        Me.department.HoverState.Parent = Me.department
        Me.department.ItemHeight = 30
        Me.department.ItemsAppearance.Parent = Me.department
        Me.department.Location = New System.Drawing.Point(343, 82)
        Me.department.Name = "department"
        Me.department.ShadowDecoration.Parent = Me.department
        Me.department.Size = New System.Drawing.Size(297, 36)
        Me.department.TabIndex = 38
        '
        'course
        '
        Me.course.BackColor = System.Drawing.Color.Transparent
        Me.course.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.course.BorderRadius = 5
        Me.course.BorderThickness = 2
        Me.course.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.course.FocusedColor = System.Drawing.Color.Empty
        Me.course.FocusedState.Parent = Me.course
        Me.course.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.course.ForeColor = System.Drawing.Color.MidnightBlue
        Me.course.FormattingEnabled = True
        Me.course.HoverState.Parent = Me.course
        Me.course.ItemHeight = 30
        Me.course.ItemsAppearance.Parent = Me.course
        Me.course.Location = New System.Drawing.Point(343, 145)
        Me.course.Name = "course"
        Me.course.ShadowDecoration.Parent = Me.course
        Me.course.Size = New System.Drawing.Size(297, 36)
        Me.course.TabIndex = 32
        '
        'lblDepartment
        '
        Me.lblDepartment.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblDepartment.Location = New System.Drawing.Point(343, 124)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(45, 19)
        Me.lblDepartment.TabIndex = 33
        Me.lblDepartment.Text = "Course"
        '
        'lblProgram
        '
        Me.lblProgram.BackColor = System.Drawing.Color.Transparent
        Me.lblProgram.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgram.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblProgram.Location = New System.Drawing.Point(344, 61)
        Me.lblProgram.Name = "lblProgram"
        Me.lblProgram.Size = New System.Drawing.Size(77, 19)
        Me.lblProgram.TabIndex = 35
        Me.lblProgram.Text = "Department"
        '
        'year
        '
        Me.year.AutoCompleteCustomSource.AddRange(New String() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.year.BackColor = System.Drawing.Color.Transparent
        Me.year.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.year.BorderRadius = 5
        Me.year.BorderThickness = 2
        Me.year.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.year.FocusedColor = System.Drawing.Color.Empty
        Me.year.FocusedState.Parent = Me.year
        Me.year.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.year.ForeColor = System.Drawing.Color.MidnightBlue
        Me.year.FormattingEnabled = True
        Me.year.HoverState.Parent = Me.year
        Me.year.ItemHeight = 30
        Me.year.Items.AddRange(New Object() {"Select Yea Level", "1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.year.ItemsAppearance.Parent = Me.year
        Me.year.Location = New System.Drawing.Point(28, 145)
        Me.year.Name = "year"
        Me.year.ShadowDecoration.Parent = Me.year
        Me.year.Size = New System.Drawing.Size(297, 36)
        Me.year.TabIndex = 36
        '
        'lblYearLevel
        '
        Me.lblYearLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblYearLevel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearLevel.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblYearLevel.Location = New System.Drawing.Point(28, 124)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(66, 19)
        Me.lblYearLevel.TabIndex = 37
        Me.lblYearLevel.Text = "Year Level"
        '
        'studID
        '
        Me.studID.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.studID.BorderRadius = 5
        Me.studID.BorderThickness = 2
        Me.studID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.studID.DefaultText = ""
        Me.studID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.studID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.studID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.studID.DisabledState.Parent = Me.studID
        Me.studID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.studID.Enabled = False
        Me.studID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studID.FocusedState.Parent = Me.studID
        Me.studID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.studID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studID.HoverState.Parent = Me.studID
        Me.studID.Location = New System.Drawing.Point(28, 80)
        Me.studID.Margin = New System.Windows.Forms.Padding(4)
        Me.studID.Name = "studID"
        Me.studID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.studID.PlaceholderForeColor = System.Drawing.Color.MidnightBlue
        Me.studID.PlaceholderText = ""
        Me.studID.SelectedText = ""
        Me.studID.ShadowDecoration.Parent = Me.studID
        Me.studID.Size = New System.Drawing.Size(297, 30)
        Me.studID.TabIndex = 16
        '
        'lblStudentID
        '
        Me.lblStudentID.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblStudentID.Location = New System.Drawing.Point(28, 60)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(69, 19)
        Me.lblStudentID.TabIndex = 17
        Me.lblStudentID.Text = "Student ID"
        '
        'lblRegisterStudent
        '
        Me.lblRegisterStudent.BackColor = System.Drawing.Color.Transparent
        Me.lblRegisterStudent.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterStudent.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblRegisterStudent.Location = New System.Drawing.Point(14, 5)
        Me.lblRegisterStudent.Name = "lblRegisterStudent"
        Me.lblRegisterStudent.Size = New System.Drawing.Size(218, 39)
        Me.lblRegisterStudent.TabIndex = 3
        Me.lblRegisterStudent.Text = "Register Student"
        '
        'gbPersonalDetails
        '
        Me.gbPersonalDetails.BackColor = System.Drawing.Color.Transparent
        Me.gbPersonalDetails.BorderColor = System.Drawing.Color.Transparent
        Me.gbPersonalDetails.BorderThickness = 0
        Me.gbPersonalDetails.Controls.Add(Me.DID)
        Me.gbPersonalDetails.Controls.Add(Me.CID)
        Me.gbPersonalDetails.Controls.Add(Me.cgender)
        Me.gbPersonalDetails.Controls.Add(Me.Guna2TextBox1)
        Me.gbPersonalDetails.Controls.Add(Me.Guna2HtmlLabel2)
        Me.gbPersonalDetails.Controls.Add(Me.Guna2TextBox2)
        Me.gbPersonalDetails.Controls.Add(Me.Guna2HtmlLabel3)
        Me.gbPersonalDetails.Controls.Add(Me.Guna2Button5)
        Me.gbPersonalDetails.Controls.Add(Me.cnumber)
        Me.gbPersonalDetails.Controls.Add(Me.lblEmail)
        Me.gbPersonalDetails.Controls.Add(Me.mname)
        Me.gbPersonalDetails.Controls.Add(Me.lblMiddleName)
        Me.gbPersonalDetails.Controls.Add(Me.lblGender)
        Me.gbPersonalDetails.Controls.Add(Me.fname)
        Me.gbPersonalDetails.Controls.Add(Me.lblFirstName)
        Me.gbPersonalDetails.Controls.Add(Me.lname)
        Me.gbPersonalDetails.Controls.Add(Me.lblLastName)
        Me.gbPersonalDetails.CustomBorderColor = System.Drawing.Color.CornflowerBlue
        Me.gbPersonalDetails.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPersonalDetails.ForeColor = System.Drawing.Color.White
        Me.gbPersonalDetails.Location = New System.Drawing.Point(41, 45)
        Me.gbPersonalDetails.Name = "gbPersonalDetails"
        Me.gbPersonalDetails.ShadowDecoration.Parent = Me.gbPersonalDetails
        Me.gbPersonalDetails.Size = New System.Drawing.Size(666, 232)
        Me.gbPersonalDetails.TabIndex = 0
        Me.gbPersonalDetails.Text = "Personal Details"
        '
        'DID
        '
        Me.DID.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.DID.BorderRadius = 5
        Me.DID.BorderThickness = 2
        Me.DID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DID.DefaultText = ""
        Me.DID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DID.DisabledState.Parent = Me.DID
        Me.DID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DID.FocusedState.Parent = Me.DID
        Me.DID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DID.HoverState.Parent = Me.DID
        Me.DID.Location = New System.Drawing.Point(266, 6)
        Me.DID.Margin = New System.Windows.Forms.Padding(4)
        Me.DID.Name = "DID"
        Me.DID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DID.PlaceholderForeColor = System.Drawing.Color.MidnightBlue
        Me.DID.PlaceholderText = ""
        Me.DID.SelectedText = ""
        Me.DID.ShadowDecoration.Parent = Me.DID
        Me.DID.Size = New System.Drawing.Size(59, 30)
        Me.DID.TabIndex = 65
        Me.DID.Visible = False
        '
        'CID
        '
        Me.CID.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.CID.BorderRadius = 5
        Me.CID.BorderThickness = 2
        Me.CID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CID.DefaultText = ""
        Me.CID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.CID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CID.DisabledState.Parent = Me.CID
        Me.CID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.CID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CID.FocusedState.Parent = Me.CID
        Me.CID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CID.HoverState.Parent = Me.CID
        Me.CID.Location = New System.Drawing.Point(183, 6)
        Me.CID.Margin = New System.Windows.Forms.Padding(4)
        Me.CID.Name = "CID"
        Me.CID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.CID.PlaceholderForeColor = System.Drawing.Color.MidnightBlue
        Me.CID.PlaceholderText = ""
        Me.CID.SelectedText = ""
        Me.CID.ShadowDecoration.Parent = Me.CID
        Me.CID.Size = New System.Drawing.Size(59, 30)
        Me.CID.TabIndex = 64
        Me.CID.Visible = False
        '
        'cgender
        '
        Me.cgender.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female"})
        Me.cgender.BackColor = System.Drawing.Color.Transparent
        Me.cgender.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.cgender.BorderRadius = 5
        Me.cgender.BorderThickness = 2
        Me.cgender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cgender.FocusedColor = System.Drawing.Color.Empty
        Me.cgender.FocusedState.Parent = Me.cgender
        Me.cgender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cgender.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cgender.FormattingEnabled = True
        Me.cgender.HoverState.Parent = Me.cgender
        Me.cgender.ItemHeight = 30
        Me.cgender.Items.AddRange(New Object() {"Select Gender", "Male", "Female"})
        Me.cgender.ItemsAppearance.Parent = Me.cgender
        Me.cgender.Location = New System.Drawing.Point(354, 138)
        Me.cgender.Name = "cgender"
        Me.cgender.ShadowDecoration.Parent = Me.cgender
        Me.cgender.Size = New System.Drawing.Size(139, 36)
        Me.cgender.TabIndex = 63
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2TextBox1.BorderRadius = 5
        Me.Guna2TextBox1.BorderThickness = 2
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(-6, -51)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(297, 30)
        Me.Guna2TextBox1.TabIndex = 59
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(-6, -71)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(70, 19)
        Me.Guna2HtmlLabel2.TabIndex = 60
        Me.Guna2HtmlLabel2.Text = "First Name"
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2TextBox2.BorderRadius = 5
        Me.Guna2TextBox2.BorderThickness = 2
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.HoverState.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Location = New System.Drawing.Point(-6, -108)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.ShadowDecoration.Parent = Me.Guna2TextBox2
        Me.Guna2TextBox2.Size = New System.Drawing.Size(297, 30)
        Me.Guna2TextBox2.TabIndex = 57
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(-6, -128)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(68, 19)
        Me.Guna2HtmlLabel3.TabIndex = 58
        Me.Guna2HtmlLabel3.Text = "Last Name"
        '
        'Guna2Button5
        '
        Me.Guna2Button5.Animated = True
        Me.Guna2Button5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button5.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Button5.BorderRadius = 5
        Me.Guna2Button5.BorderThickness = 2
        Me.Guna2Button5.CheckedState.Parent = Me.Guna2Button5
        Me.Guna2Button5.CustomImages.Parent = Me.Guna2Button5
        Me.Guna2Button5.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.HoverState.Parent = Me.Guna2Button5
        Me.Guna2Button5.Location = New System.Drawing.Point(662, 404)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.ShadowDecoration.Parent = Me.Guna2Button5
        Me.Guna2Button5.Size = New System.Drawing.Size(83, 29)
        Me.Guna2Button5.TabIndex = 61
        Me.Guna2Button5.Text = "Submit"
        '
        'cnumber
        '
        Me.cnumber.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.cnumber.BorderRadius = 5
        Me.cnumber.BorderThickness = 2
        Me.cnumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cnumber.DefaultText = ""
        Me.cnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cnumber.DisabledState.Parent = Me.cnumber
        Me.cnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cnumber.FocusedState.Parent = Me.cnumber
        Me.cnumber.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnumber.ForeColor = System.Drawing.Color.MidnightBlue
        Me.cnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cnumber.HoverState.Parent = Me.cnumber
        Me.cnumber.Location = New System.Drawing.Point(352, 77)
        Me.cnumber.Margin = New System.Windows.Forms.Padding(4)
        Me.cnumber.Name = "cnumber"
        Me.cnumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cnumber.PlaceholderForeColor = System.Drawing.Color.MidnightBlue
        Me.cnumber.PlaceholderText = ""
        Me.cnumber.SelectedText = ""
        Me.cnumber.ShadowDecoration.Parent = Me.cnumber
        Me.cnumber.Size = New System.Drawing.Size(297, 30)
        Me.cnumber.TabIndex = 45
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblEmail.Location = New System.Drawing.Point(352, 57)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(104, 19)
        Me.lblEmail.TabIndex = 46
        Me.lblEmail.Text = "Contact Number"
        '
        'mname
        '
        Me.mname.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.mname.BorderRadius = 5
        Me.mname.BorderThickness = 2
        Me.mname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.mname.DefaultText = ""
        Me.mname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.mname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.mname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mname.DisabledState.Parent = Me.mname
        Me.mname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.mname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mname.FocusedState.Parent = Me.mname
        Me.mname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.mname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mname.HoverState.Parent = Me.mname
        Me.mname.Location = New System.Drawing.Point(28, 188)
        Me.mname.Margin = New System.Windows.Forms.Padding(4)
        Me.mname.Name = "mname"
        Me.mname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mname.PlaceholderForeColor = System.Drawing.Color.MidnightBlue
        Me.mname.PlaceholderText = ""
        Me.mname.SelectedText = ""
        Me.mname.ShadowDecoration.Parent = Me.mname
        Me.mname.Size = New System.Drawing.Size(297, 30)
        Me.mname.TabIndex = 43
        '
        'lblMiddleName
        '
        Me.lblMiddleName.BackColor = System.Drawing.Color.Transparent
        Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblMiddleName.Location = New System.Drawing.Point(28, 168)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(86, 19)
        Me.lblMiddleName.TabIndex = 44
        Me.lblMiddleName.Text = "Middle Name"
        '
        'lblGender
        '
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblGender.Location = New System.Drawing.Point(354, 113)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(47, 19)
        Me.lblGender.TabIndex = 31
        Me.lblGender.Text = "Gender"
        '
        'fname
        '
        Me.fname.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.fname.BorderRadius = 5
        Me.fname.BorderThickness = 2
        Me.fname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fname.DefaultText = ""
        Me.fname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.fname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.fname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fname.DisabledState.Parent = Me.fname
        Me.fname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.fname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fname.FocusedState.Parent = Me.fname
        Me.fname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.fname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fname.HoverState.Parent = Me.fname
        Me.fname.Location = New System.Drawing.Point(28, 134)
        Me.fname.Margin = New System.Windows.Forms.Padding(4)
        Me.fname.Name = "fname"
        Me.fname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fname.PlaceholderForeColor = System.Drawing.Color.MidnightBlue
        Me.fname.PlaceholderText = ""
        Me.fname.SelectedText = ""
        Me.fname.ShadowDecoration.Parent = Me.fname
        Me.fname.Size = New System.Drawing.Size(297, 30)
        Me.fname.TabIndex = 41
        '
        'lblFirstName
        '
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblFirstName.Location = New System.Drawing.Point(28, 114)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(70, 19)
        Me.lblFirstName.TabIndex = 42
        Me.lblFirstName.Text = "First Name"
        '
        'lname
        '
        Me.lname.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.lname.BorderRadius = 5
        Me.lname.BorderThickness = 2
        Me.lname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lname.DefaultText = ""
        Me.lname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lname.DisabledState.Parent = Me.lname
        Me.lname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lname.FocusedState.Parent = Me.lname
        Me.lname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lname.HoverState.Parent = Me.lname
        Me.lname.Location = New System.Drawing.Point(28, 77)
        Me.lname.Margin = New System.Windows.Forms.Padding(4)
        Me.lname.Name = "lname"
        Me.lname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lname.PlaceholderForeColor = System.Drawing.Color.MidnightBlue
        Me.lname.PlaceholderText = ""
        Me.lname.SelectedText = ""
        Me.lname.ShadowDecoration.Parent = Me.lname
        Me.lname.Size = New System.Drawing.Size(297, 30)
        Me.lname.TabIndex = 39
        '
        'lblLastName
        '
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblLastName.Location = New System.Drawing.Point(28, 57)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(68, 19)
        Me.lblLastName.TabIndex = 40
        Me.lblLastName.Text = "Last Name"
        '
        'elipseBody
        '
        Me.elipseBody.BorderRadius = 25
        Me.elipseBody.TargetControl = Me.panelBody
        '
        'elipsePersonalDetails
        '
        Me.elipsePersonalDetails.BorderRadius = 25
        Me.elipsePersonalDetails.TargetControl = Me.gbPersonalDetails
        '
        'elipseEducation
        '
        Me.elipseEducation.BorderRadius = 25
        Me.elipseEducation.TargetControl = Me.gbEducation
        '
        'elipseForm3
        '
        Me.elipseForm3.BorderRadius = 25
        Me.elipseForm3.TargetControl = Me
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(995, 597)
        Me.Controls.Add(Me.panelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.panelBody.ResumeLayout(False)
        Me.panelBody.PerformLayout()
        Me.gbEducation.ResumeLayout(False)
        Me.gbEducation.PerformLayout()
        Me.gbPersonalDetails.ResumeLayout(False)
        Me.gbPersonalDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents elipseBody As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents gbPersonalDetails As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents elipsePersonalDetails As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents lblRegisterStudent As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents studID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblStudentID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGender As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblYearLevel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents year As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblProgram As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDepartment As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents course As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents gbEducation As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents cnumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblEmail As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents mname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblMiddleName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents fname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblFirstName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblLastName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents elipseEducation As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents elipseForm3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cgender As Guna.UI2.WinForms.Guna2ComboBox

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        filldepartment()
        year.SelectedIndex = 0
        cgender.SelectedIndex = 0
        studID.Text = GetNextStudentID()
    End Sub
    Sub filldepartment()
        department.Items.Clear()
        department.Items.Add("Select Department")
        department.SelectedIndex = 0
        Try

            OpenConnection()

            Dim query As String = "SELECT * FROM registration.department"
            Using cmd As New MySqlCommand(query, Connection)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    department.Items.Add(dr("Department").ToString())
                End While
                dr.Close()
            End Using

            CloseConnection()

        Catch ex As MySqlException
            MessageBox.Show("Error filling department combo box: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub fillcourse(selectedDepartment As String)
        course.Items.Clear()
        course.Items.Add("Select Course")
        course.SelectedIndex = 0

        If selectedDepartment = "Select Department" Then Exit Sub

        Try
            OpenConnection()


            Dim query As String = "SELECT tblcourse.Course FROM registration.tblcourse " &
                              "INNER JOIN registration.department ON tblcourse.DID = department.DID " &
                              "WHERE department.Department = @Department"
            Using cmd As New MySqlCommand(query, Connection)
                cmd.Parameters.AddWithValue("@Department", selectedDepartment)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                While dr.Read()
                    course.Items.Add(dr("Course").ToString())
                End While
                dr.Close()
            End Using

            CloseConnection()
        Catch ex As MySqlException
            MessageBox.Show("Error filling course combo box: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub RegisterStudent()
        If String.IsNullOrWhiteSpace(lname.Text) OrElse String.IsNullOrWhiteSpace(fname.Text) OrElse String.IsNullOrWhiteSpace(mname.Text) OrElse
       String.IsNullOrWhiteSpace(CID.Text) OrElse String.IsNullOrWhiteSpace(DID.Text) Then
            MessageBox.Show("Please fill in all fields.", "Fill in all fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf department.SelectedIndex = 0 Then
            MessageBox.Show("Select Department", "Select valid Department", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf course.SelectedIndex = 0 Then
            MessageBox.Show("Select Course", "Select valid Course", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf cgender.SelectedIndex = 0 Then
            MessageBox.Show("Select Gender", "Select valid Gender", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        ElseIf year.SelectedIndex = 0 Then
            MessageBox.Show("Select Year Level", "Select valid Year Level", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrEmpty(studID.Text) Then
            studID.Text = GetNextStudentID()
        End If

        If Not cnumber.Text.All(AddressOf Char.IsDigit) Then
            cnumber.Text = String.Concat(cnumber.Text.Where(AddressOf Char.IsDigit))
            cnumber.SelectionStart = cnumber.Text.Length
        End If

        If cnumber.Text.Length <> 11 Then
            MessageBox.Show("Contact number must be exactly 11 digits.", "Invalid Contact Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Try

            OpenConnection()
            Dim insertQuery As String = "INSERT INTO registration.tblstudents (studentID, Lname, Fname, Mname, Gender, Cnumber, CID, DID, Yearlvl) VALUES (@studID, @Lname, @Fname, @Mname, @Gender, @Cnumber, @CID, @DID, @Yearlvl)"
            Using insertCmd As New MySql.Data.MySqlClient.MySqlCommand(insertQuery, Connection)
                insertCmd.Parameters.AddWithValue("@studID", studID.Text)
                insertCmd.Parameters.AddWithValue("@Lname", lname.Text)
                insertCmd.Parameters.AddWithValue("@Fname", fname.Text)
                insertCmd.Parameters.AddWithValue("@Mname", mname.Text)
                insertCmd.Parameters.AddWithValue("@Cnumber", cnumber.Text)
                insertCmd.Parameters.AddWithValue("@Gender", cgender.Text)
                insertCmd.Parameters.AddWithValue("@CID", CID.Text)
                insertCmd.Parameters.AddWithValue("@DID", DID.Text)
                insertCmd.Parameters.AddWithValue("@Yearlvl", year.Text)
                insertCmd.ExecuteNonQuery()


                MessageBox.Show("Student added successfully!", "Adding Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cnumber.Clear()
                lname.Clear()
                fname.Clear()
                mname.Clear()
                course.SelectedIndex = 0
                department.SelectedIndex = 0
                cgender.SelectedIndex = 0
                year.SelectedIndex = 0
                studID.Clear()

                maindash.studentscount()
                studlist.StudentView()
                Totaldepartment.departmentoverview()
                totalstudents.studentoverview()
                Totalcourse.courseoverview()
            End Using
            CloseConnection()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Function GetNextStudentID() As String
        Dim random As New Random()
        Dim nextID As String = String.Empty
        Dim isUnique As Boolean = False

        While Not isUnique
            nextID = random.Next(1000000, 9999999).ToString()
            Dim query As String = "SELECT COUNT(*) FROM registration.tblstudents WHERE studentID = @studentID"
            OpenConnection()
            Try
                Using cmd As New MySql.Data.MySqlClient.MySqlCommand(query, Connection)
                    cmd.Parameters.AddWithValue("@studentID", nextID)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count = 0 Then
                        isUnique = True
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error checking the student ID: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                CloseConnection()
            End Try
        End While

        Return nextID
    End Function












    Friend WithEvents department As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents DID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CID As Guna.UI2.WinForms.Guna2TextBox

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        RegisterStudent()
        studID.Text = GetNextStudentID()
    End Sub

    Private Sub course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles course.SelectedIndexChanged
        course.Focus()
        DataModule.OpenConnection()

        Try
            Dim cmd As New MySqlCommand("SELECT * FROM registration.tblcourse WHERE Course LIKE @Course", DataModule.Connection)
            cmd.Parameters.AddWithValue("@Course", course.Text)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.HasRows Then
                dr.Read()
                CID.Text = dr("CID").ToString()
            Else
                CID.Text = String.Empty
            End If

            dr.Close()

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DataModule.CloseConnection()
        End Try
    End Sub

    Private Sub department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles department.SelectedIndexChanged
        Dim selectedDepartment As String = department.SelectedItem.ToString()
        fillcourse(selectedDepartment)
        department.Focus()
        DataModule.OpenConnection()


        Try
            Dim cmd As New MySqlCommand("SELECT * FROM registration.department WHERE Department LIKE @depart", DataModule.Connection)
            cmd.Parameters.AddWithValue("@depart", department.Text)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.HasRows Then
                dr.Read()
                DID.Text = dr("DID").ToString()
            Else
                DID.Text = String.Empty
            End If

            dr.Close()

        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DataModule.CloseConnection()
        End Try
    End Sub

    Private Sub year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles year.SelectedIndexChanged

    End Sub

    Private Sub cgender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cgender.SelectedIndexChanged


    End Sub

    Private Sub cnumber_TextChanged(sender As Object, e As EventArgs) Handles cnumber.TextChanged

    End Sub

    Private Sub cnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cnumber.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then

            e.Handled = True
        End If

        If cnumber.Text.Length >= 11 AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If

        If (Control.ModifierKeys And Keys.Control) = Keys.Control AndAlso e.KeyChar = ChrW(Keys.V) Then
            e.Handled = True
        End If

    End Sub
End Class
