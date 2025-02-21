<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Course
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Course))
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.totaldepart = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblCreateAccount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.elipseDgv = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.elipseBody2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.departcombo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.panelBody = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.lblRegisterStudent = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.viewcourse = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.panelBody.SuspendLayout()
        CType(Me.viewcourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Guna2Button1.Location = New System.Drawing.Point(878, 506)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(83, 29)
        Me.Guna2Button1.TabIndex = 69
        Me.Guna2Button1.Text = "Add"
        '
        'totaldepart
        '
        Me.totaldepart.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.totaldepart.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaldepart.ForeColor = System.Drawing.Color.MidnightBlue
        Me.totaldepart.Location = New System.Drawing.Point(207, 436)
        Me.totaldepart.Name = "totaldepart"
        Me.totaldepart.Size = New System.Drawing.Size(58, 27)
        Me.totaldepart.TabIndex = 68
        Me.totaldepart.Text = "Count"
        '
        'lblCreateAccount
        '
        Me.lblCreateAccount.BackColor = System.Drawing.Color.Transparent
        Me.lblCreateAccount.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateAccount.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblCreateAccount.Location = New System.Drawing.Point(28, 436)
        Me.lblCreateAccount.Name = "lblCreateAccount"
        Me.lblCreateAccount.Size = New System.Drawing.Size(165, 27)
        Me.lblCreateAccount.TabIndex = 67
        Me.lblCreateAccount.Text = "Total Department:"
        '
        'elipseDgv
        '
        Me.elipseDgv.BorderRadius = 25
        '
        'elipseBody2
        '
        Me.elipseBody2.BorderRadius = 25
        Me.elipseBody2.TargetControl = Me
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 25
        Me.Guna2Elipse1.TargetControl = Me.totaldepart
        '
        'departcombo
        '
        Me.departcombo.AutoCompleteCustomSource.AddRange(New String() {"Select Department"})
        Me.departcombo.BackColor = System.Drawing.Color.Transparent
        Me.departcombo.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.departcombo.BorderRadius = 5
        Me.departcombo.BorderThickness = 2
        Me.departcombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.departcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.departcombo.FocusedColor = System.Drawing.Color.Empty
        Me.departcombo.FocusedState.Parent = Me.departcombo
        Me.departcombo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.departcombo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.departcombo.FormattingEnabled = True
        Me.departcombo.HoverState.Parent = Me.departcombo
        Me.departcombo.ItemHeight = 30
        Me.departcombo.ItemsAppearance.Parent = Me.departcombo
        Me.departcombo.Location = New System.Drawing.Point(696, 97)
        Me.departcombo.Name = "departcombo"
        Me.departcombo.ShadowDecoration.Parent = Me.departcombo
        Me.departcombo.Size = New System.Drawing.Size(242, 36)
        Me.departcombo.TabIndex = 70
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(385, 45)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(77, 19)
        Me.Guna2HtmlLabel2.TabIndex = 82
        Me.Guna2HtmlLabel2.Text = "Department"
        '
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.Color.Lavender
        Me.panelBody.Controls.Add(Me.Guna2HtmlLabel2)
        Me.panelBody.Controls.Add(Me.btnSubmit)
        Me.panelBody.Controls.Add(Me.lblRegisterStudent)
        Me.panelBody.Controls.Add(Me.totaldepart)
        Me.panelBody.Controls.Add(Me.lblCreateAccount)
        Me.panelBody.Location = New System.Drawing.Point(228, 59)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.ShadowDecoration.Parent = Me.panelBody
        Me.panelBody.Size = New System.Drawing.Size(755, 526)
        Me.panelBody.TabIndex = 83
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
        Me.lblRegisterStudent.Size = New System.Drawing.Size(143, 39)
        Me.lblRegisterStudent.TabIndex = 3
        Me.lblRegisterStudent.Text = "Course List"
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 25
        Me.Guna2Elipse2.TargetControl = Me.panelBody
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
        Me.viewcourse.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.edit, Me.delete})
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
        Me.viewcourse.Location = New System.Drawing.Point(258, 139)
        Me.viewcourse.Name = "viewcourse"
        Me.viewcourse.ReadOnly = True
        Me.viewcourse.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.viewcourse.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.viewcourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewcourse.Size = New System.Drawing.Size(703, 350)
        Me.viewcourse.TabIndex = 84
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
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.DividerWidth = 2
        Me.Column2.HeaderText = "Course"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.DividerWidth = 2
        Me.Column3.HeaderText = "Description"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.DividerWidth = 2
        Me.Column4.HeaderText = "Department"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
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
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 25
        Me.Guna2Elipse3.TargetControl = Me.viewcourse
        '
        'Course
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(991, 596)
        Me.Controls.Add(Me.viewcourse)
        Me.Controls.Add(Me.departcombo)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.panelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Course"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Course"
        Me.panelBody.ResumeLayout(False)
        Me.panelBody.PerformLayout()
        CType(Me.viewcourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents totaldepart As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblCreateAccount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents elipseDgv As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents elipseBody2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents departcombo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents panelBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblRegisterStudent As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents viewcourse As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewImageColumn
    Friend WithEvents delete As DataGridViewImageColumn
End Class
