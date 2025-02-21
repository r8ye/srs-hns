<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Totalcourse
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
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblRegisterStudent = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel14 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.courseflowpanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cbX = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(538, 98)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(95, 23)
        Me.Guna2HtmlLabel6.TabIndex = 19
        Me.Guna2HtmlLabel6.Text = "Department"
        '
        'lblRegisterStudent
        '
        Me.lblRegisterStudent.BackColor = System.Drawing.Color.Transparent
        Me.lblRegisterStudent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisterStudent.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblRegisterStudent.Location = New System.Drawing.Point(257, 98)
        Me.lblRegisterStudent.Name = "lblRegisterStudent"
        Me.lblRegisterStudent.Size = New System.Drawing.Size(91, 23)
        Me.lblRegisterStudent.TabIndex = 18
        Me.lblRegisterStudent.Text = "Description"
        '
        'Guna2HtmlLabel14
        '
        Me.Guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel14.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel14.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel14.Location = New System.Drawing.Point(199, 31)
        Me.Guna2HtmlLabel14.Name = "Guna2HtmlLabel14"
        Me.Guna2HtmlLabel14.Size = New System.Drawing.Size(280, 49)
        Me.Guna2HtmlLabel14.TabIndex = 17
        Me.Guna2HtmlLabel14.Text = "Course Overview"
        '
        'courseflowpanel
        '
        Me.courseflowpanel.AutoScroll = True
        Me.courseflowpanel.BackColor = System.Drawing.Color.Transparent
        Me.courseflowpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.courseflowpanel.Location = New System.Drawing.Point(17, 127)
        Me.courseflowpanel.Name = "courseflowpanel"
        Me.courseflowpanel.Size = New System.Drawing.Size(657, 295)
        Me.courseflowpanel.TabIndex = 16
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 25
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(41, 101)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(55, 23)
        Me.Guna2HtmlLabel3.TabIndex = 20
        Me.Guna2HtmlLabel3.Text = "Course"
        '
        'cbX
        '
        Me.cbX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbX.BackColor = System.Drawing.Color.Transparent
        Me.cbX.FillColor = System.Drawing.Color.Transparent
        Me.cbX.HoverState.Parent = Me.cbX
        Me.cbX.IconColor = System.Drawing.Color.MidnightBlue
        Me.cbX.Location = New System.Drawing.Point(634, 12)
        Me.cbX.Name = "cbX"
        Me.cbX.ShadowDecoration.Parent = Me.cbX
        Me.cbX.Size = New System.Drawing.Size(33, 29)
        Me.cbX.TabIndex = 67
        '
        'Totalcourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(686, 450)
        Me.Controls.Add(Me.cbX)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.lblRegisterStudent)
        Me.Controls.Add(Me.Guna2HtmlLabel14)
        Me.Controls.Add(Me.courseflowpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Totalcourse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Totalcourse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblRegisterStudent As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel14 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents courseflowpanel As FlowLayoutPanel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cbX As Guna.UI2.WinForms.Guna2ControlBox
End Class
