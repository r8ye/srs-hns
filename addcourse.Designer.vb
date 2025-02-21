<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addcourse
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
        Me.destxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.lblYearLevel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.departttx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblStudentID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.departadd = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.departcombobox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbX = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.didtext = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.elipseForm1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.departadd.SuspendLayout()
        Me.SuspendLayout()
        '
        'destxt
        '
        Me.destxt.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.destxt.BorderRadius = 5
        Me.destxt.BorderThickness = 2
        Me.destxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.destxt.DefaultText = ""
        Me.destxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.destxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.destxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.destxt.DisabledState.Parent = Me.destxt
        Me.destxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.destxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.destxt.FocusedState.Parent = Me.destxt
        Me.destxt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.destxt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.destxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.destxt.HoverState.Parent = Me.destxt
        Me.destxt.Location = New System.Drawing.Point(28, 150)
        Me.destxt.Margin = New System.Windows.Forms.Padding(4)
        Me.destxt.Name = "destxt"
        Me.destxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.destxt.PlaceholderForeColor = System.Drawing.Color.MidnightBlue
        Me.destxt.PlaceholderText = ""
        Me.destxt.SelectedText = ""
        Me.destxt.ShadowDecoration.Parent = Me.destxt
        Me.destxt.Size = New System.Drawing.Size(297, 30)
        Me.destxt.TabIndex = 64
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.AliceBlue
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.BorderThickness = 2
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(138, 259)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(83, 29)
        Me.Guna2Button1.TabIndex = 63
        Me.Guna2Button1.Text = "Save"
        '
        'lblYearLevel
        '
        Me.lblYearLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblYearLevel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearLevel.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblYearLevel.Location = New System.Drawing.Point(28, 129)
        Me.lblYearLevel.Name = "lblYearLevel"
        Me.lblYearLevel.Size = New System.Drawing.Size(74, 19)
        Me.lblYearLevel.TabIndex = 37
        Me.lblYearLevel.Text = "Description"
        '
        'departttx
        '
        Me.departttx.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.departttx.BorderRadius = 5
        Me.departttx.BorderThickness = 2
        Me.departttx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.departttx.DefaultText = ""
        Me.departttx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.departttx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.departttx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.departttx.DisabledState.Parent = Me.departttx
        Me.departttx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.departttx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.departttx.FocusedState.Parent = Me.departttx
        Me.departttx.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departttx.ForeColor = System.Drawing.Color.MidnightBlue
        Me.departttx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.departttx.HoverState.Parent = Me.departttx
        Me.departttx.Location = New System.Drawing.Point(28, 80)
        Me.departttx.Margin = New System.Windows.Forms.Padding(4)
        Me.departttx.Name = "departttx"
        Me.departttx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.departttx.PlaceholderForeColor = System.Drawing.Color.MidnightBlue
        Me.departttx.PlaceholderText = ""
        Me.departttx.SelectedText = ""
        Me.departttx.ShadowDecoration.Parent = Me.departttx
        Me.departttx.Size = New System.Drawing.Size(297, 30)
        Me.departttx.TabIndex = 16
        '
        'lblStudentID
        '
        Me.lblStudentID.BackColor = System.Drawing.Color.Transparent
        Me.lblStudentID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblStudentID.Location = New System.Drawing.Point(28, 60)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(45, 19)
        Me.lblStudentID.TabIndex = 17
        Me.lblStudentID.Text = "Course"
        '
        'departadd
        '
        Me.departadd.BackColor = System.Drawing.Color.Transparent
        Me.departadd.BorderColor = System.Drawing.Color.Transparent
        Me.departadd.BorderThickness = 0
        Me.departadd.Controls.Add(Me.Guna2HtmlLabel1)
        Me.departadd.Controls.Add(Me.departcombobox)
        Me.departadd.Controls.Add(Me.cbX)
        Me.departadd.Controls.Add(Me.destxt)
        Me.departadd.Controls.Add(Me.Guna2Button1)
        Me.departadd.Controls.Add(Me.lblYearLevel)
        Me.departadd.Controls.Add(Me.departttx)
        Me.departadd.Controls.Add(Me.lblStudentID)
        Me.departadd.Controls.Add(Me.didtext)
        Me.departadd.CustomBorderColor = System.Drawing.Color.CornflowerBlue
        Me.departadd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departadd.ForeColor = System.Drawing.Color.White
        Me.departadd.Location = New System.Drawing.Point(0, 0)
        Me.departadd.Name = "departadd"
        Me.departadd.ShadowDecoration.Parent = Me.departadd
        Me.departadd.Size = New System.Drawing.Size(363, 301)
        Me.departadd.TabIndex = 63
        Me.departadd.Text = "Add Course"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(28, 193)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(77, 19)
        Me.Guna2HtmlLabel1.TabIndex = 67
        Me.Guna2HtmlLabel1.Text = "Department"
        '
        'departcombobox
        '
        Me.departcombobox.AutoCompleteCustomSource.AddRange(New String() {"Select Department"})
        Me.departcombobox.BackColor = System.Drawing.Color.Transparent
        Me.departcombobox.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.departcombobox.BorderRadius = 5
        Me.departcombobox.BorderThickness = 2
        Me.departcombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.departcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.departcombobox.FocusedColor = System.Drawing.Color.Empty
        Me.departcombobox.FocusedState.Parent = Me.departcombobox
        Me.departcombobox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.departcombobox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.departcombobox.FormattingEnabled = True
        Me.departcombobox.HoverState.Parent = Me.departcombobox
        Me.departcombobox.ItemHeight = 30
        Me.departcombobox.ItemsAppearance.Parent = Me.departcombobox
        Me.departcombobox.Location = New System.Drawing.Point(28, 214)
        Me.departcombobox.Name = "departcombobox"
        Me.departcombobox.ShadowDecoration.Parent = Me.departcombobox
        Me.departcombobox.Size = New System.Drawing.Size(297, 36)
        Me.departcombobox.TabIndex = 66
        '
        'cbX
        '
        Me.cbX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbX.BackColor = System.Drawing.Color.Transparent
        Me.cbX.FillColor = System.Drawing.Color.Transparent
        Me.cbX.HoverState.Parent = Me.cbX
        Me.cbX.IconColor = System.Drawing.Color.MidnightBlue
        Me.cbX.Location = New System.Drawing.Point(325, 5)
        Me.cbX.Name = "cbX"
        Me.cbX.ShadowDecoration.Parent = Me.cbX
        Me.cbX.Size = New System.Drawing.Size(33, 29)
        Me.cbX.TabIndex = 65
        '
        'didtext
        '
        Me.didtext.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.didtext.BorderRadius = 5
        Me.didtext.BorderThickness = 2
        Me.didtext.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.didtext.DefaultText = ""
        Me.didtext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.didtext.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.didtext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.didtext.DisabledState.Parent = Me.didtext
        Me.didtext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.didtext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.didtext.FocusedState.Parent = Me.didtext
        Me.didtext.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.didtext.ForeColor = System.Drawing.Color.MidnightBlue
        Me.didtext.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.didtext.HoverState.Parent = Me.didtext
        Me.didtext.Location = New System.Drawing.Point(152, 8)
        Me.didtext.Margin = New System.Windows.Forms.Padding(4)
        Me.didtext.Name = "didtext"
        Me.didtext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.didtext.PlaceholderForeColor = System.Drawing.Color.MidnightBlue
        Me.didtext.PlaceholderText = ""
        Me.didtext.SelectedText = ""
        Me.didtext.ShadowDecoration.Parent = Me.didtext
        Me.didtext.Size = New System.Drawing.Size(69, 30)
        Me.didtext.TabIndex = 68
        Me.didtext.Visible = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 25
        Me.Guna2Elipse1.TargetControl = Me
        '
        'elipseForm1
        '
        Me.elipseForm1.BorderRadius = 25
        Me.elipseForm1.TargetControl = Me.departadd
        '
        'addcourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 300)
        Me.Controls.Add(Me.departadd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addcourse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addcourse"
        Me.departadd.ResumeLayout(False)
        Me.departadd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents destxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblYearLevel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents departttx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblStudentID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents departadd As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents cbX As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents departcombobox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents elipseForm1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents didtext As Guna.UI2.WinForms.Guna2TextBox
End Class
