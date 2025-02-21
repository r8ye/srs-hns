<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class useraccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(useraccount))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.elipseBody2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.elipseDgv = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.usercount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.panelBody = New Guna.UI2.WinForms.Guna2Panel()
        Me.usertypeview = New Guna.UI.WinForms.GunaDataGridView()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.lblRegisterStudent = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.elipseForm3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.panelBody.SuspendLayout()
        CType(Me.usertypeview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 25
        '
        'elipseBody2
        '
        Me.elipseBody2.BorderRadius = 25
        Me.elipseBody2.TargetControl = Me
        '
        'elipseDgv
        '
        Me.elipseDgv.BorderRadius = 25
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
        Me.Guna2Button1.Location = New System.Drawing.Point(664, 493)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(83, 29)
        Me.Guna2Button1.TabIndex = 73
        Me.Guna2Button1.Text = "Add"
        '
        'usercount
        '
        Me.usercount.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.usercount.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usercount.ForeColor = System.Drawing.Color.MidnightBlue
        Me.usercount.Location = New System.Drawing.Point(166, 481)
        Me.usercount.Name = "usercount"
        Me.usercount.Size = New System.Drawing.Size(58, 27)
        Me.usercount.TabIndex = 76
        Me.usercount.Text = "Count"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(14, 481)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(146, 27)
        Me.Guna2HtmlLabel2.TabIndex = 75
        Me.Guna2HtmlLabel2.Text = "Total User Type:"
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 25
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 25
        Me.Guna2Elipse3.TargetControl = Me.usercount
        '
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.Color.Lavender
        Me.panelBody.Controls.Add(Me.usertypeview)
        Me.panelBody.Controls.Add(Me.btnSubmit)
        Me.panelBody.Controls.Add(Me.lblRegisterStudent)
        Me.panelBody.Controls.Add(Me.usercount)
        Me.panelBody.Controls.Add(Me.Guna2HtmlLabel2)
        Me.panelBody.Controls.Add(Me.Guna2Button1)
        Me.panelBody.Location = New System.Drawing.Point(228, 59)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.ShadowDecoration.Parent = Me.panelBody
        Me.panelBody.Size = New System.Drawing.Size(755, 526)
        Me.panelBody.TabIndex = 85
        '
        'usertypeview
        '
        Me.usertypeview.AllowUserToAddRows = False
        Me.usertypeview.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.usertypeview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.usertypeview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.usertypeview.BackgroundColor = System.Drawing.Color.White
        Me.usertypeview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usertypeview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.usertypeview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.usertypeview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.usertypeview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.usertypeview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.Column2, Me.DataGridViewTextBoxColumn6, Me.Column1, Me.edit, Me.delete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.usertypeview.DefaultCellStyle = DataGridViewCellStyle3
        Me.usertypeview.EnableHeadersVisualStyles = False
        Me.usertypeview.GridColor = System.Drawing.Color.Blue
        Me.usertypeview.Location = New System.Drawing.Point(44, 79)
        Me.usertypeview.Name = "usertypeview"
        Me.usertypeview.ReadOnly = True
        Me.usertypeview.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.usertypeview.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.usertypeview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.usertypeview.Size = New System.Drawing.Size(703, 350)
        Me.usertypeview.TabIndex = 86
        Me.usertypeview.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.usertypeview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.usertypeview.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.usertypeview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.usertypeview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.usertypeview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.usertypeview.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.usertypeview.ThemeStyle.GridColor = System.Drawing.Color.Blue
        Me.usertypeview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usertypeview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.usertypeview.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usertypeview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.usertypeview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.usertypeview.ThemeStyle.HeaderStyle.Height = 23
        Me.usertypeview.ThemeStyle.ReadOnly = True
        Me.usertypeview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.usertypeview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.usertypeview.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usertypeview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.usertypeview.ThemeStyle.RowsStyle.Height = 22
        Me.usertypeview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usertypeview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.lblRegisterStudent.Location = New System.Drawing.Point(14, 1)
        Me.lblRegisterStudent.Name = "lblRegisterStudent"
        Me.lblRegisterStudent.Size = New System.Drawing.Size(195, 39)
        Me.lblRegisterStudent.TabIndex = 3
        Me.lblRegisterStudent.Text = "Configure User"
        '
        'elipseForm3
        '
        Me.elipseForm3.BorderRadius = 25
        Me.elipseForm3.TargetControl = Me.panelBody
        '
        'Guna2Elipse4
        '
        Me.Guna2Elipse4.BorderRadius = 25
        Me.Guna2Elipse4.TargetControl = Me.usertypeview
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 51
        '
        'Column2
        '
        Me.Column2.HeaderText = "User Type"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DividerWidth = 2
        Me.DataGridViewTextBoxColumn6.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column1
        '
        Me.Column1.HeaderText = "Password"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
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
        'useraccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(991, 596)
        Me.Controls.Add(Me.panelBody)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "useraccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "useraccount"
        Me.panelBody.ResumeLayout(False)
        Me.panelBody.PerformLayout()
        CType(Me.usertypeview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents elipseBody2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents elipseDgv As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents usercount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents panelBody As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblRegisterStudent As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents elipseForm3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents usertypeview As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewImageColumn
    Friend WithEvents delete As DataGridViewImageColumn
End Class
