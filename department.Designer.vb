<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class department
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(department))
        Me.elipseBody2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.elipseDgv = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.viewdepart = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblCreateAccount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.totaldepart = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.panelBody = New Guna.UI2.WinForms.Guna2Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblRegisterStudent = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.viewdepart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBody.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'elipseBody2
        '
        Me.elipseBody2.BorderRadius = 25
        Me.elipseBody2.TargetControl = Me
        '
        'elipseDgv
        '
        Me.elipseDgv.BorderRadius = 25
        Me.elipseDgv.TargetControl = Me.viewdepart
        '
        'viewdepart
        '
        Me.viewdepart.AllowUserToAddRows = False
        Me.viewdepart.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.viewdepart.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.viewdepart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.viewdepart.BackgroundColor = System.Drawing.Color.White
        Me.viewdepart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.viewdepart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.viewdepart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.viewdepart.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.viewdepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.viewdepart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.edit, Me.delete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.viewdepart.DefaultCellStyle = DataGridViewCellStyle3
        Me.viewdepart.EnableHeadersVisualStyles = False
        Me.viewdepart.GridColor = System.Drawing.Color.Blue
        Me.viewdepart.Location = New System.Drawing.Point(258, 139)
        Me.viewdepart.Name = "viewdepart"
        Me.viewdepart.ReadOnly = True
        Me.viewdepart.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.viewdepart.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.viewdepart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.viewdepart.Size = New System.Drawing.Size(703, 350)
        Me.viewdepart.TabIndex = 57
        Me.viewdepart.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.viewdepart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.viewdepart.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.viewdepart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.viewdepart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.viewdepart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.viewdepart.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.viewdepart.ThemeStyle.GridColor = System.Drawing.Color.Blue
        Me.viewdepart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.viewdepart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.viewdepart.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewdepart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.viewdepart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.viewdepart.ThemeStyle.HeaderStyle.Height = 23
        Me.viewdepart.ThemeStyle.ReadOnly = True
        Me.viewdepart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.viewdepart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.viewdepart.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewdepart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.viewdepart.ThemeStyle.RowsStyle.Height = 22
        Me.viewdepart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.viewdepart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.Column2.HeaderText = "Department"
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
        'lblCreateAccount
        '
        Me.lblCreateAccount.BackColor = System.Drawing.Color.Transparent
        Me.lblCreateAccount.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreateAccount.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblCreateAccount.Location = New System.Drawing.Point(37, 436)
        Me.lblCreateAccount.Name = "lblCreateAccount"
        Me.lblCreateAccount.Size = New System.Drawing.Size(165, 27)
        Me.lblCreateAccount.TabIndex = 61
        Me.lblCreateAccount.Text = "Total Department:"
        '
        'totaldepart
        '
        Me.totaldepart.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.totaldepart.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaldepart.ForeColor = System.Drawing.Color.MidnightBlue
        Me.totaldepart.Location = New System.Drawing.Point(216, 436)
        Me.totaldepart.Name = "totaldepart"
        Me.totaldepart.Size = New System.Drawing.Size(58, 27)
        Me.totaldepart.TabIndex = 62
        Me.totaldepart.Text = "Count"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 25
        Me.Guna2Elipse1.TargetControl = Me.totaldepart
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
        Me.Guna2Button1.Location = New System.Drawing.Point(650, 434)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(83, 29)
        Me.Guna2Button1.TabIndex = 64
        Me.Guna2Button1.Text = "Add"
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
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.Color.Lavender
        Me.panelBody.Controls.Add(Me.DataGridView1)
        Me.panelBody.Controls.Add(Me.Guna2Button1)
        Me.panelBody.Controls.Add(Me.btnSubmit)
        Me.panelBody.Controls.Add(Me.totaldepart)
        Me.panelBody.Controls.Add(Me.lblCreateAccount)
        Me.panelBody.Controls.Add(Me.lblRegisterStudent)
        Me.panelBody.Location = New System.Drawing.Point(228, 59)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.ShadowDecoration.Parent = Me.panelBody
        Me.panelBody.Size = New System.Drawing.Size(755, 526)
        Me.panelBody.TabIndex = 84
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DataGridView1.Location = New System.Drawing.Point(165, 199)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 65
        '
        'Column6
        '
        Me.Column6.HeaderText = "ID"
        Me.Column6.Name = "Column6"
        Me.Column6.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "Department"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Description"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Edit"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Delete"
        Me.Column10.Name = "Column10"
        '
        'lblRegisterStudent
        '
        Me.lblRegisterStudent.BackColor = System.Drawing.Color.Transparent
        Me.lblRegisterStudent.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterStudent.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblRegisterStudent.Location = New System.Drawing.Point(14, 5)
        Me.lblRegisterStudent.Name = "lblRegisterStudent"
        Me.lblRegisterStudent.Size = New System.Drawing.Size(211, 39)
        Me.lblRegisterStudent.TabIndex = 3
        Me.lblRegisterStudent.Text = "Department List"
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 25
        Me.Guna2Elipse2.TargetControl = Me.panelBody
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
        'department
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(995, 597)
        Me.Controls.Add(Me.viewdepart)
        Me.Controls.Add(Me.panelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "department"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "department"
        CType(Me.viewdepart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBody.ResumeLayout(False)
        Me.panelBody.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents elipseBody2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents elipseDgv As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents totaldepart As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblCreateAccount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblRegisterStudent As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents viewdepart As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewImageColumn
    Friend WithEvents delete As DataGridViewImageColumn
End Class
