Imports MySql.Data.MySqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studlist
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studlist))
        Me.elipseBody2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.elipseDgv = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.elipseForm4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.viewcourse = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.totaldepart = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblStudentID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.coursecombo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.departmentcombobox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblCreateAccount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.panelBody = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.yearcombo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.lblRegisterStudent = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.viewcourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'elipseBody2
        '
        Me.elipseBody2.BorderRadius = 25
        '
        'elipseDgv
        '
        Me.elipseDgv.BorderRadius = 25
        '
        'elipseForm4
        '
        Me.elipseForm4.BorderRadius = 25
        Me.elipseForm4.TargetControl = Me
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 25
        Me.Guna2Elipse1.TargetControl = Me.viewcourse
        '
        'viewcourse
        '
        Me.viewcourse.AllowUserToAddRows = False
        Me.viewcourse.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.viewcourse.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.viewcourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.viewcourse.BackgroundColor = System.Drawing.Color.White
        Me.viewcourse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.viewcourse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.viewcourse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.viewcourse.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.viewcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.viewcourse.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column6, Me.Column7, Me.Column3, Me.Column4, Me.Column5, Me.edit, Me.delete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.viewcourse.DefaultCellStyle = DataGridViewCellStyle3
        Me.viewcourse.EnableHeadersVisualStyles = False
        Me.viewcourse.GridColor = System.Drawing.Color.Blue
        Me.viewcourse.Location = New System.Drawing.Point(37, 112)
        Me.viewcourse.Name = "viewcourse"
        Me.viewcourse.ReadOnly = True
        Me.viewcourse.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.viewcourse.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.viewcourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewcourse.Size = New System.Drawing.Size(703, 350)
        Me.viewcourse.TabIndex = 85
        Me.viewcourse.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.viewcourse.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.viewcourse.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.viewcourse.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.viewcourse.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.viewcourse.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.viewcourse.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.viewcourse.ThemeStyle.GridColor = System.Drawing.Color.Blue
        Me.viewcourse.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.viewcourse.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.viewcourse.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewcourse.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.viewcourse.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.viewcourse.ThemeStyle.HeaderStyle.Height = 23
        Me.viewcourse.ThemeStyle.ReadOnly = True
        Me.viewcourse.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.viewcourse.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.viewcourse.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewcourse.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.viewcourse.ThemeStyle.RowsStyle.Height = 22
        Me.viewcourse.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.viewcourse.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "StudentID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 111
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.DividerWidth = 2
        Me.Column2.HeaderText = "Full Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 114
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Gender"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 89
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Contact #"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 106
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.DividerWidth = 2
        Me.Column3.HeaderText = "Course"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 88
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.DividerWidth = 2
        Me.Column4.HeaderText = "Department"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 128
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Year Level"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 111
        '
        'edit
        '
        Me.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.edit.DividerWidth = 2
        Me.edit.HeaderText = "Edit"
        Me.edit.Image = CType(resources.GetObject("edit.Image"), System.Drawing.Image)
        Me.edit.Name = "edit"
        Me.edit.ReadOnly = True
        Me.edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.edit.Width = 66
        '
        'delete
        '
        Me.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.delete.DividerWidth = 2
        Me.delete.HeaderText = "Delete"
        Me.delete.Image = CType(resources.GetObject("delete.Image"), System.Drawing.Image)
        Me.delete.Name = "delete"
        Me.delete.ReadOnly = True
        Me.delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.delete.Width = 86
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 25
        Me.Guna2Elipse2.TargetControl = Me.totaldepart
        '
        'totaldepart
        '
        Me.totaldepart.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.totaldepart.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaldepart.ForeColor = System.Drawing.Color.MidnightBlue
        Me.totaldepart.Location = New System.Drawing.Point(176, 462)
        Me.totaldepart.Name = "totaldepart"
        Me.totaldepart.Size = New System.Drawing.Size(58, 27)
        Me.totaldepart.TabIndex = 77
        Me.totaldepart.Text = "Count"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(550, 76)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(77, 19)
        Me.Guna2HtmlLabel2.TabIndex = 81
        Me.Guna2HtmlLabel2.Text = "Department"
        '
        'lblStudentID
        '
        Me.lblStudentID.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblStudentID.Location = New System.Drawing.Point(385, 76)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(45, 19)
        Me.lblStudentID.TabIndex = 80
        Me.lblStudentID.Text = "Course"
        '
        'coursecombo
        '
        Me.coursecombo.AutoCompleteCustomSource.AddRange(New String() {"Select Department"})
        Me.coursecombo.BackColor = System.Drawing.Color.Transparent
        Me.coursecombo.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.coursecombo.BorderRadius = 5
        Me.coursecombo.BorderThickness = 2
        Me.coursecombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.coursecombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.coursecombo.FocusedColor = System.Drawing.Color.Empty
        Me.coursecombo.FocusedState.Parent = Me.coursecombo
        Me.coursecombo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.coursecombo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.coursecombo.FormattingEnabled = True
        Me.coursecombo.HoverState.Parent = Me.coursecombo
        Me.coursecombo.ItemHeight = 30
        Me.coursecombo.Items.AddRange(New Object() {"All"})
        Me.coursecombo.ItemsAppearance.Parent = Me.coursecombo
        Me.coursecombo.Location = New System.Drawing.Point(440, 70)
        Me.coursecombo.Name = "coursecombo"
        Me.coursecombo.ShadowDecoration.Parent = Me.coursecombo
        Me.coursecombo.Size = New System.Drawing.Size(104, 36)
        Me.coursecombo.TabIndex = 79
        '
        'departmentcombobox
        '
        Me.departmentcombobox.AutoCompleteCustomSource.AddRange(New String() {"Select Department"})
        Me.departmentcombobox.BackColor = System.Drawing.Color.Transparent
        Me.departmentcombobox.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.departmentcombobox.BorderRadius = 5
        Me.departmentcombobox.BorderThickness = 2
        Me.departmentcombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.departmentcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.departmentcombobox.FocusedColor = System.Drawing.Color.Empty
        Me.departmentcombobox.FocusedState.Parent = Me.departmentcombobox
        Me.departmentcombobox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.departmentcombobox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.departmentcombobox.FormattingEnabled = True
        Me.departmentcombobox.HoverState.Parent = Me.departmentcombobox
        Me.departmentcombobox.ItemHeight = 30
        Me.departmentcombobox.Items.AddRange(New Object() {"All"})
        Me.departmentcombobox.ItemsAppearance.Parent = Me.departmentcombobox
        Me.departmentcombobox.Location = New System.Drawing.Point(633, 69)
        Me.departmentcombobox.Name = "departmentcombobox"
        Me.departmentcombobox.ShadowDecoration.Parent = Me.departmentcombobox
        Me.departmentcombobox.Size = New System.Drawing.Size(99, 36)
        Me.departmentcombobox.TabIndex = 78
        '
        'lblCreateAccount
        '
        Me.lblCreateAccount.BackColor = System.Drawing.Color.Transparent
        Me.lblCreateAccount.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateAccount.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblCreateAccount.Location = New System.Drawing.Point(33, 462)
        Me.lblCreateAccount.Name = "lblCreateAccount"
        Me.lblCreateAccount.Size = New System.Drawing.Size(137, 27)
        Me.lblCreateAccount.TabIndex = 76
        Me.lblCreateAccount.Text = "Total Students:"
        '
        'txtSearch
        '
        Me.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtSearch.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.txtSearch.BorderRadius = 5
        Me.txtSearch.BorderThickness = 2
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.Parent = Me.txtSearch
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.FocusedState.Parent = Me.txtSearch
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.HoverState.Parent = Me.txtSearch
        Me.txtSearch.IconLeft = CType(resources.GetObject("txtSearch.IconLeft"), System.Drawing.Image)
        Me.txtSearch.Location = New System.Drawing.Point(44, 69)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch.PlaceholderForeColor = System.Drawing.Color.MidnightBlue
        Me.txtSearch.PlaceholderText = "Search for ID or Name"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.ShadowDecoration.Parent = Me.txtSearch
        Me.txtSearch.Size = New System.Drawing.Size(158, 36)
        Me.txtSearch.TabIndex = 74
        '
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.Color.Lavender
        Me.panelBody.Controls.Add(Me.Guna2HtmlLabel1)
        Me.panelBody.Controls.Add(Me.yearcombo)
        Me.panelBody.Controls.Add(Me.viewcourse)
        Me.panelBody.Controls.Add(Me.lblCreateAccount)
        Me.panelBody.Controls.Add(Me.Guna2HtmlLabel2)
        Me.panelBody.Controls.Add(Me.totaldepart)
        Me.panelBody.Controls.Add(Me.lblStudentID)
        Me.panelBody.Controls.Add(Me.btnSubmit)
        Me.panelBody.Controls.Add(Me.coursecombo)
        Me.panelBody.Controls.Add(Me.txtSearch)
        Me.panelBody.Controls.Add(Me.departmentcombobox)
        Me.panelBody.Controls.Add(Me.lblRegisterStudent)
        Me.panelBody.Location = New System.Drawing.Point(228, 59)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.ShadowDecoration.Parent = Me.panelBody
        Me.panelBody.Size = New System.Drawing.Size(755, 526)
        Me.panelBody.TabIndex = 85
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(207, 76)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(66, 19)
        Me.Guna2HtmlLabel1.TabIndex = 87
        Me.Guna2HtmlLabel1.Text = "Year Level"
        '
        'yearcombo
        '
        Me.yearcombo.AutoCompleteCustomSource.AddRange(New String() {"Select Department"})
        Me.yearcombo.BackColor = System.Drawing.Color.Transparent
        Me.yearcombo.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.yearcombo.BorderRadius = 5
        Me.yearcombo.BorderThickness = 2
        Me.yearcombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.yearcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yearcombo.FocusedColor = System.Drawing.Color.Empty
        Me.yearcombo.FocusedState.Parent = Me.yearcombo
        Me.yearcombo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.yearcombo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.yearcombo.FormattingEnabled = True
        Me.yearcombo.HoverState.Parent = Me.yearcombo
        Me.yearcombo.ItemHeight = 30
        Me.yearcombo.Items.AddRange(New Object() {"All", "1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.yearcombo.ItemsAppearance.Parent = Me.yearcombo
        Me.yearcombo.Location = New System.Drawing.Point(277, 70)
        Me.yearcombo.Name = "yearcombo"
        Me.yearcombo.ShadowDecoration.Parent = Me.yearcombo
        Me.yearcombo.Size = New System.Drawing.Size(104, 36)
        Me.yearcombo.TabIndex = 86
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
        'lblRegisterStudent
        '
        Me.lblRegisterStudent.BackColor = System.Drawing.Color.Transparent
        Me.lblRegisterStudent.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterStudent.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblRegisterStudent.Location = New System.Drawing.Point(14, 5)
        Me.lblRegisterStudent.Name = "lblRegisterStudent"
        Me.lblRegisterStudent.Size = New System.Drawing.Size(156, 39)
        Me.lblRegisterStudent.TabIndex = 3
        Me.lblRegisterStudent.Text = "Student List"
        '
        'Guna2Elipse4
        '
        Me.Guna2Elipse4.BorderRadius = 25
        Me.Guna2Elipse4.TargetControl = Me.panelBody
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.DividerWidth = 2
        Me.DataGridViewImageColumn1.HeaderText = "Edit"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn2.DividerWidth = 2
        Me.DataGridViewImageColumn2.HeaderText = "Delete"
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'studlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(991, 596)
        Me.Controls.Add(Me.panelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "studlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.viewcourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBody.ResumeLayout(False)
        Me.panelBody.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents elipseBody2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents elipseDgv As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents elipseForm4 As Guna.UI2.WinForms.Guna2Elipse

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StudentView()
        FilterStudents()
        viewdepartments()
        viewcoursedata()
    End Sub
    Public Sub viewcoursedata()
        coursecombo.Items.Clear()
        coursecombo.Items.Add("All")
        coursecombo.SelectedIndex = 0

        OpenConnection()

        Dim query As String = "SELECT Course FROM registration.tblcourse"

        Try
            Using cmd As New MySqlCommand(query, Connection)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        coursecombo.Items.Add(dr("Course").ToString())
                    End While
                End Using
            End Using
        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            CloseConnection()
        End Try
    End Sub
    Public Sub viewdepartments()
        departmentcombobox.Items.Clear()
        departmentcombobox.Items.Add("All")
        departmentcombobox.SelectedIndex = 0

        OpenConnection()

        Dim query As String = "SELECT Department FROM registration.department"

        Try
            Using cmd As New MySqlCommand(query, Connection)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        departmentcombobox.Items.Add(dr("Department").ToString())
                    End While
                End Using
            End Using
        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            CloseConnection()
        End Try
    End Sub
    Private Sub FilterStudents()
        Try
            viewcourse.Rows.Clear()

            Dim selectedDepartment As String = If(departmentcombobox.SelectedItem IsNot Nothing, departmentcombobox.SelectedItem.ToString(), "All")
            Dim selectedYear As String = If(yearcombo.SelectedItem IsNot Nothing, yearcombo.SelectedItem.ToString(), "All")
            Dim searchText As String = txtSearch.Text.Trim()
            Dim selectedCourse As String = If(coursecombo.SelectedItem IsNot Nothing, coursecombo.SelectedItem.ToString(), "All")

            DataModule.OpenConnection()

            Dim query As String = "SELECT tblstudents.studentID, tblstudents.Lname, tblstudents.Fname, tblstudents.Mname, tblstudents.Gender, tblstudents.Cnumber, " &
                              "tblcourse.Course, department.Department, tblstudents.Yearlvl " &
                              "FROM registration.tblstudents " &
                              "INNER JOIN registration.department ON tblstudents.DID = department.DID " &
                              "INNER JOIN registration.tblcourse ON tblstudents.CID = tblcourse.CID WHERE 1=1"

            If selectedDepartment <> "All" Then
                query &= " AND department.Department = @Department"
            End If

            If selectedYear <> "All" Then
                query &= " AND tblstudents.Yearlvl = @YearLevel"
            End If

            If selectedCourse <> "All" Then
                query &= " AND tblcourse.Course = @Course"
            End If

            If Not String.IsNullOrEmpty(searchText) Then
                query &= " AND (tblstudents.studentID LIKE @Search OR tblstudents.Lname LIKE @Search OR tblstudents.Fname LIKE @Search)"
            End If

            Using cmd As New MySqlCommand(query, DataModule.Connection)
                If selectedDepartment <> "All" Then
                    cmd.Parameters.AddWithValue("@Department", selectedDepartment)
                End If

                If selectedYear <> "All" Then
                    cmd.Parameters.AddWithValue("@YearLevel", selectedYear)
                End If

                If selectedCourse <> "All" Then
                    cmd.Parameters.AddWithValue("@Course", selectedCourse)
                End If

                If Not String.IsNullOrEmpty(searchText) Then
                    cmd.Parameters.AddWithValue("@Search", "%" & searchText & "%")
                End If

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim fullName As String = reader("Lname").ToString() & ", " & reader("Fname").ToString()
                        If Not String.IsNullOrEmpty(reader("Mname").ToString()) Then
                            fullName &= " " & reader("Mname").ToString()
                        End If

                        viewcourse.Rows.Add(
                        reader("studentID").ToString(),
                        fullName,
                        reader("Gender").ToString(),
                        reader("Cnumber").ToString(),
                        reader("Course").ToString(),
                        reader("Department").ToString(),
                        reader("Yearlvl").ToString()
                    )
                    End While
                End Using
            End Using

            totaldepart.Text = "(" & viewcourse.RowCount & ")"
        Catch ex As Exception
            MsgBox("Error retrieving students: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            DataModule.CloseConnection()
        End Try
    End Sub


    Public Sub StudentView()
        Dim i As Integer = 0
        viewcourse.Rows.Clear()
        OpenConnection()

        Dim query As String = "SELECT tblstudents.studentID, tblstudents.Lname, tblstudents.Fname, tblstudents.Mname, tblstudents.Gender, tblstudents.Cnumber, " &
                          "tblcourse.Course, department.Department, tblstudents.Yearlvl " &
                          "FROM registration.tblstudents " &
                          "INNER JOIN registration.department ON tblstudents.DID = department.DID " &
                          "INNER JOIN registration.tblcourse ON tblstudents.CID = tblcourse.CID"

        Try
            Using cmd As New MySqlCommand(query, Connection)
                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        i += 1
                        Dim fullName As String = dr.Item("Lname").ToString() & ", " & dr.Item("Fname").ToString()

                        If Not String.IsNullOrEmpty(dr.Item("Mname").ToString()) Then
                            fullName &= " " & dr.Item("Mname").ToString()
                        End If

                        viewcourse.Rows.Add(
                        dr.Item("studentID").ToString(),
                        fullName,
                        dr.Item("Gender").ToString(),
                        dr.Item("Cnumber").ToString(),
                        dr.Item("Course").ToString(),
                        dr.Item("Department").ToString(),
                        dr.Item("Yearlvl").ToString()
                    )
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading student data: " & ex.Message)
        Finally
            CloseConnection()
        End Try

        totaldepart.Text = "(" & viewcourse.Rows.Count & ")"
    End Sub


    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub lblRegisterStudent_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblStudentID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents coursecombo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents departmentcombobox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblCreateAccount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents totaldepart As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents panelBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblRegisterStudent As Guna.UI2.WinForms.Guna2HtmlLabel

    Private Sub panelBody_Paint(sender As Object, e As PaintEventArgs) Handles panelBody.Paint

    End Sub

    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents viewcourse As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewImageColumn
    Friend WithEvents delete As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn

    Private Sub viewcourse_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewcourse.CellContentClick
        Dim colname As String = viewcourse.Columns(e.ColumnIndex).Name



        Try
            If colname = "edit" Then
                editstudents.loaddept()
                editstudents.loadcourse()
                With editstudents
                    .studID.Text = viewcourse.Rows(e.RowIndex).Cells(0).Value.ToString()

                    Dim fullName As String = viewcourse.Rows(e.RowIndex).Cells(1).Value.ToString()
                    Dim lname As String = ""
                    Dim fname As String = ""
                    Dim mname As String = ""

                    Dim commaIndex As Integer = fullName.IndexOf(","c)
                    If commaIndex > -1 Then
                        lname = fullName.Substring(0, commaIndex).Trim()
                        Dim firstAndMiddle As String = fullName.Substring(commaIndex + 1).Trim()
                        Dim spaceIndex As Integer = firstAndMiddle.IndexOf(" "c)

                        If spaceIndex > -1 Then
                            fname = firstAndMiddle.Substring(0, spaceIndex).Trim()
                            mname = firstAndMiddle.Substring(spaceIndex + 1).Trim()
                        Else
                            fname = firstAndMiddle
                        End If
                    Else
                        lname = fullName
                    End If

                    .lname.Text = lname
                    .fname.Text = fname
                    .mname.Text = mname

                    .cgender.SelectedItem = viewcourse.Rows(e.RowIndex).Cells(2).Value.ToString()
                    .cnumber.Text = viewcourse.Rows(e.RowIndex).Cells(3).Value.ToString()
                    .course.SelectedItem = viewcourse.Rows(e.RowIndex).Cells(4).Value.ToString()
                    .department.SelectedItem = viewcourse.Rows(e.RowIndex).Cells(5).Value.ToString()
                    .year.SelectedItem = viewcourse.Rows(e.RowIndex).Cells(6).Value.ToString()

                    .ShowDialog()
                End With



            ElseIf colname = "delete" Then
                If MessageBox.Show("Are you sure you want to delete this Student?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                    OpenConnection()

                    Dim deleteCoursesQuery As String = "DELETE FROM registration.tblstudents WHERE studentID = @SID"
                    Using deleteCmd As New MySqlCommand(deleteCoursesQuery, Connection)
                        deleteCmd.Parameters.AddWithValue("@SID", viewcourse.Rows(e.RowIndex).Cells(0).Value)
                        deleteCmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Course deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    StudentView()
                    totalstudents.studentoverview()
                    maindash.studentscount()


                    CloseConnection()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents yearcombo As Guna.UI2.WinForms.Guna2ComboBox

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If viewcourse.Columns.Count > 0 Then
            FilterStudents()
        End If
    End Sub

    Private Sub yearcombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles yearcombo.SelectedIndexChanged
        If viewcourse.Columns.Count > 0 Then
            FilterStudents()
        End If
    End Sub

    Private Sub coursecombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles coursecombo.SelectedIndexChanged
        If viewcourse.Columns.Count > 0 Then
            FilterStudents()
        End If
    End Sub

    Private Sub departmentcombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles departmentcombobox.SelectedIndexChanged
        If viewcourse.Columns.Count > 0 Then
            FilterStudents()
        End If
    End Sub
End Class
