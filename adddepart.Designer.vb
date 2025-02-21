<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adddepart
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
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.departadd = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.cbX = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.destxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblYearLevel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.departttx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblStudentID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.elipseForm1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.departadd.SuspendLayout()
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
        Me.Guna2Button1.Location = New System.Drawing.Point(136, 187)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(83, 29)
        Me.Guna2Button1.TabIndex = 63
        Me.Guna2Button1.Text = "Save"
        '
        'departadd
        '
        Me.departadd.BackColor = System.Drawing.Color.Transparent
        Me.departadd.BorderColor = System.Drawing.Color.Transparent
        Me.departadd.BorderThickness = 0
        Me.departadd.Controls.Add(Me.cbX)
        Me.departadd.Controls.Add(Me.destxt)
        Me.departadd.Controls.Add(Me.Guna2Button1)
        Me.departadd.Controls.Add(Me.lblYearLevel)
        Me.departadd.Controls.Add(Me.departttx)
        Me.departadd.Controls.Add(Me.lblStudentID)
        Me.departadd.CustomBorderColor = System.Drawing.Color.CornflowerBlue
        Me.departadd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departadd.ForeColor = System.Drawing.Color.White
        Me.departadd.Location = New System.Drawing.Point(-1, 0)
        Me.departadd.Name = "departadd"
        Me.departadd.ShadowDecoration.Parent = Me.departadd
        Me.departadd.Size = New System.Drawing.Size(363, 232)
        Me.departadd.TabIndex = 62
        Me.departadd.Text = "Add Department"
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
        Me.lblStudentID.Size = New System.Drawing.Size(77, 19)
        Me.lblStudentID.TabIndex = 17
        Me.lblStudentID.Text = "Department"
        '
        'elipseForm1
        '
        Me.elipseForm1.BorderRadius = 25
        Me.elipseForm1.TargetControl = Me
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 25
        Me.Guna2Elipse1.TargetControl = Me.departadd
        '
        'adddepart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 236)
        Me.Controls.Add(Me.departadd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adddepart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adddepart"
        Me.departadd.ResumeLayout(False)
        Me.departadd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents departadd As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblYearLevel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents departttx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblStudentID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents destxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents elipseForm1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents cbX As Guna.UI2.WinForms.Guna2ControlBox
End Class
