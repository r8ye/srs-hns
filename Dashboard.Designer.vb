<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tryDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tryDashboard))
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.rgsbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.dashpanel = New Guna.UI.WinForms.GunaPanel()
        Me.gbAdmin = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.user = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pbAdmin = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.accbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.stdbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.dashbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSignOut = New Guna.UI2.WinForms.Guna2Button()
        Me.crsbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.deptbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.lblLastName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblFirstName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGender = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblMiddleName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblEmail = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblHomeAddress = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblBirthday = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.elipseForm3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.elipseBody = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.elipsePersonalDetails = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.dashboardpanel = New Guna.UI.WinForms.GunaPanel()
        Me.regtxt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.logo = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.sName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.GunaShadowPanel1.SuspendLayout()
        Me.gbAdmin.SuspendLayout()
        CType(Me.pbAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dashboardpanel.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.Controls.Add(Me.rgsbtn)
        Me.GunaShadowPanel1.Controls.Add(Me.dashpanel)
        Me.GunaShadowPanel1.Controls.Add(Me.gbAdmin)
        Me.GunaShadowPanel1.Controls.Add(Me.accbtn)
        Me.GunaShadowPanel1.Controls.Add(Me.stdbtn)
        Me.GunaShadowPanel1.Controls.Add(Me.dashbtn)
        Me.GunaShadowPanel1.Controls.Add(Me.btnSignOut)
        Me.GunaShadowPanel1.Controls.Add(Me.crsbtn)
        Me.GunaShadowPanel1.Controls.Add(Me.deptbtn)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(1, 0)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.SystemColors.HotTrack
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(201, 596)
        Me.GunaShadowPanel1.TabIndex = 0
        '
        'rgsbtn
        '
        Me.rgsbtn.Animated = True
        Me.rgsbtn.BackColor = System.Drawing.Color.Transparent
        Me.rgsbtn.BorderColor = System.Drawing.Color.PowderBlue
        Me.rgsbtn.BorderRadius = 5
        Me.rgsbtn.BorderThickness = 2
        Me.rgsbtn.CheckedState.Parent = Me.rgsbtn
        Me.rgsbtn.CustomImages.Parent = Me.rgsbtn
        Me.rgsbtn.FillColor = System.Drawing.Color.White
        Me.rgsbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgsbtn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.rgsbtn.HoverState.Parent = Me.rgsbtn
        Me.rgsbtn.Location = New System.Drawing.Point(3, 263)
        Me.rgsbtn.Name = "rgsbtn"
        Me.rgsbtn.PressedColor = System.Drawing.Color.Blue
        Me.rgsbtn.ShadowDecoration.Parent = Me.rgsbtn
        Me.rgsbtn.Size = New System.Drawing.Size(191, 38)
        Me.rgsbtn.TabIndex = 17
        Me.rgsbtn.Text = "Register"
        '
        'dashpanel
        '
        Me.dashpanel.Location = New System.Drawing.Point(200, 0)
        Me.dashpanel.Name = "dashpanel"
        Me.dashpanel.Size = New System.Drawing.Size(794, 686)
        Me.dashpanel.TabIndex = 1
        '
        'gbAdmin
        '
        Me.gbAdmin.BorderColor = System.Drawing.Color.Lavender
        Me.gbAdmin.BorderRadius = 10
        Me.gbAdmin.BorderThickness = 0
        Me.gbAdmin.Controls.Add(Me.user)
        Me.gbAdmin.Controls.Add(Me.pbAdmin)
        Me.gbAdmin.CustomBorderColor = System.Drawing.Color.Lavender
        Me.gbAdmin.FillColor = System.Drawing.Color.Lavender
        Me.gbAdmin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.gbAdmin.ForeColor = System.Drawing.Color.White
        Me.gbAdmin.Location = New System.Drawing.Point(35, 29)
        Me.gbAdmin.Name = "gbAdmin"
        Me.gbAdmin.ShadowDecoration.Parent = Me.gbAdmin
        Me.gbAdmin.Size = New System.Drawing.Size(127, 148)
        Me.gbAdmin.TabIndex = 20
        '
        'user
        '
        Me.user.BackColor = System.Drawing.Color.Transparent
        Me.user.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.MidnightBlue
        Me.user.Location = New System.Drawing.Point(15, 110)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(96, 23)
        Me.user.TabIndex = 2
        Me.user.Text = "Superadmin"
        '
        'pbAdmin
        '
        Me.pbAdmin.BackColor = System.Drawing.Color.Lavender
        Me.pbAdmin.Image = CType(resources.GetObject("pbAdmin.Image"), System.Drawing.Image)
        Me.pbAdmin.Location = New System.Drawing.Point(6, 6)
        Me.pbAdmin.Name = "pbAdmin"
        Me.pbAdmin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pbAdmin.ShadowDecoration.Parent = Me.pbAdmin
        Me.pbAdmin.Size = New System.Drawing.Size(114, 116)
        Me.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAdmin.TabIndex = 1
        Me.pbAdmin.TabStop = False
        '
        'accbtn
        '
        Me.accbtn.Animated = True
        Me.accbtn.BackColor = System.Drawing.Color.Transparent
        Me.accbtn.BorderColor = System.Drawing.Color.PowderBlue
        Me.accbtn.BorderRadius = 5
        Me.accbtn.BorderThickness = 2
        Me.accbtn.CheckedState.Parent = Me.accbtn
        Me.accbtn.CustomImages.Parent = Me.accbtn
        Me.accbtn.FillColor = System.Drawing.Color.White
        Me.accbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accbtn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.accbtn.HoverState.Parent = Me.accbtn
        Me.accbtn.Location = New System.Drawing.Point(3, 466)
        Me.accbtn.Name = "accbtn"
        Me.accbtn.PressedColor = System.Drawing.Color.Blue
        Me.accbtn.ShadowDecoration.Parent = Me.accbtn
        Me.accbtn.Size = New System.Drawing.Size(191, 38)
        Me.accbtn.TabIndex = 24
        Me.accbtn.Text = "Configure Account"
        '
        'stdbtn
        '
        Me.stdbtn.Animated = True
        Me.stdbtn.BackColor = System.Drawing.Color.Transparent
        Me.stdbtn.BorderColor = System.Drawing.Color.PowderBlue
        Me.stdbtn.BorderRadius = 5
        Me.stdbtn.BorderThickness = 2
        Me.stdbtn.CheckedState.Parent = Me.stdbtn
        Me.stdbtn.CustomImages.Parent = Me.stdbtn
        Me.stdbtn.FillColor = System.Drawing.Color.White
        Me.stdbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdbtn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.stdbtn.HoverState.Parent = Me.stdbtn
        Me.stdbtn.Location = New System.Drawing.Point(3, 313)
        Me.stdbtn.Name = "stdbtn"
        Me.stdbtn.PressedColor = System.Drawing.Color.Blue
        Me.stdbtn.ShadowDecoration.Parent = Me.stdbtn
        Me.stdbtn.Size = New System.Drawing.Size(191, 38)
        Me.stdbtn.TabIndex = 18
        Me.stdbtn.Text = "Students"
        '
        'dashbtn
        '
        Me.dashbtn.Animated = True
        Me.dashbtn.BackColor = System.Drawing.Color.Transparent
        Me.dashbtn.BorderColor = System.Drawing.Color.PowderBlue
        Me.dashbtn.BorderRadius = 5
        Me.dashbtn.BorderThickness = 2
        Me.dashbtn.CheckedState.Parent = Me.dashbtn
        Me.dashbtn.CustomImages.Parent = Me.dashbtn
        Me.dashbtn.FillColor = System.Drawing.Color.White
        Me.dashbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashbtn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dashbtn.HoverState.Parent = Me.dashbtn
        Me.dashbtn.Location = New System.Drawing.Point(3, 213)
        Me.dashbtn.Name = "dashbtn"
        Me.dashbtn.PressedColor = System.Drawing.Color.Blue
        Me.dashbtn.ShadowDecoration.Parent = Me.dashbtn
        Me.dashbtn.Size = New System.Drawing.Size(191, 38)
        Me.dashbtn.TabIndex = 23
        Me.dashbtn.Text = "Dashboard"
        '
        'btnSignOut
        '
        Me.btnSignOut.Animated = True
        Me.btnSignOut.BackColor = System.Drawing.Color.Transparent
        Me.btnSignOut.BorderColor = System.Drawing.Color.PowderBlue
        Me.btnSignOut.BorderRadius = 5
        Me.btnSignOut.BorderThickness = 2
        Me.btnSignOut.CheckedState.Parent = Me.btnSignOut
        Me.btnSignOut.CustomImages.Parent = Me.btnSignOut
        Me.btnSignOut.FillColor = System.Drawing.Color.CornflowerBlue
        Me.btnSignOut.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignOut.ForeColor = System.Drawing.Color.White
        Me.btnSignOut.HoverState.Parent = Me.btnSignOut
        Me.btnSignOut.Location = New System.Drawing.Point(35, 538)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.PressedColor = System.Drawing.Color.Blue
        Me.btnSignOut.ShadowDecoration.Parent = Me.btnSignOut
        Me.btnSignOut.Size = New System.Drawing.Size(127, 38)
        Me.btnSignOut.TabIndex = 19
        Me.btnSignOut.Text = "Log Out"
        '
        'crsbtn
        '
        Me.crsbtn.Animated = True
        Me.crsbtn.BackColor = System.Drawing.Color.Transparent
        Me.crsbtn.BorderColor = System.Drawing.Color.PowderBlue
        Me.crsbtn.BorderRadius = 5
        Me.crsbtn.BorderThickness = 2
        Me.crsbtn.CheckedState.Parent = Me.crsbtn
        Me.crsbtn.CustomImages.Parent = Me.crsbtn
        Me.crsbtn.FillColor = System.Drawing.Color.White
        Me.crsbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crsbtn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.crsbtn.HoverState.Parent = Me.crsbtn
        Me.crsbtn.Location = New System.Drawing.Point(3, 415)
        Me.crsbtn.Name = "crsbtn"
        Me.crsbtn.PressedColor = System.Drawing.Color.Blue
        Me.crsbtn.ShadowDecoration.Parent = Me.crsbtn
        Me.crsbtn.Size = New System.Drawing.Size(191, 38)
        Me.crsbtn.TabIndex = 22
        Me.crsbtn.Text = "Course"
        '
        'deptbtn
        '
        Me.deptbtn.Animated = True
        Me.deptbtn.BackColor = System.Drawing.Color.Transparent
        Me.deptbtn.BorderColor = System.Drawing.Color.PowderBlue
        Me.deptbtn.BorderRadius = 5
        Me.deptbtn.BorderThickness = 2
        Me.deptbtn.CheckedState.Parent = Me.deptbtn
        Me.deptbtn.CustomImages.Parent = Me.deptbtn
        Me.deptbtn.FillColor = System.Drawing.Color.White
        Me.deptbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deptbtn.ForeColor = System.Drawing.Color.MidnightBlue
        Me.deptbtn.HoverState.Parent = Me.deptbtn
        Me.deptbtn.Location = New System.Drawing.Point(3, 364)
        Me.deptbtn.Name = "deptbtn"
        Me.deptbtn.PressedColor = System.Drawing.Color.Blue
        Me.deptbtn.ShadowDecoration.Parent = Me.deptbtn
        Me.deptbtn.Size = New System.Drawing.Size(191, 38)
        Me.deptbtn.TabIndex = 21
        Me.deptbtn.Text = "Department"
        '
        'lblLastName
        '
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblLastName.Location = New System.Drawing.Point(28, 85)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(68, 19)
        Me.lblLastName.TabIndex = 40
        Me.lblLastName.Text = "Last Name"
        '
        'lblFirstName
        '
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblFirstName.Location = New System.Drawing.Point(28, 142)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(70, 19)
        Me.lblFirstName.TabIndex = 42
        Me.lblFirstName.Text = "First Name"
        '
        'lblGender
        '
        Me.lblGender.BackColor = System.Drawing.Color.Transparent
        Me.lblGender.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblGender.Location = New System.Drawing.Point(414, 189)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(47, 19)
        Me.lblGender.TabIndex = 31
        Me.lblGender.Text = "Gender"
        '
        'lblMiddleName
        '
        Me.lblMiddleName.BackColor = System.Drawing.Color.Transparent
        Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblMiddleName.Location = New System.Drawing.Point(28, 196)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(86, 19)
        Me.lblMiddleName.TabIndex = 44
        Me.lblMiddleName.Text = "Middle Name"
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblEmail.Location = New System.Drawing.Point(414, 85)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(37, 19)
        Me.lblEmail.TabIndex = 46
        Me.lblEmail.Text = "Email"
        '
        'lblHomeAddress
        '
        Me.lblHomeAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblHomeAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeAddress.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblHomeAddress.Location = New System.Drawing.Point(414, 142)
        Me.lblHomeAddress.Name = "lblHomeAddress"
        Me.lblHomeAddress.Size = New System.Drawing.Size(93, 19)
        Me.lblHomeAddress.TabIndex = 48
        Me.lblHomeAddress.Text = "Home Address"
        '
        'lblBirthday
        '
        Me.lblBirthday.BackColor = System.Drawing.Color.Transparent
        Me.lblBirthday.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthday.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblBirthday.Location = New System.Drawing.Point(571, 192)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(55, 19)
        Me.lblBirthday.TabIndex = 53
        Me.lblBirthday.Text = "Birthday"
        '
        'elipseForm3
        '
        Me.elipseForm3.BorderRadius = 25
        Me.elipseForm3.TargetControl = Me
        '
        'elipseBody
        '
        Me.elipseBody.BorderRadius = 25
        '
        'elipsePersonalDetails
        '
        Me.elipsePersonalDetails.BorderRadius = 25
        '
        'dashboardpanel
        '
        Me.dashboardpanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dashboardpanel.Controls.Add(Me.regtxt)
        Me.dashboardpanel.Controls.Add(Me.logo)
        Me.dashboardpanel.Controls.Add(Me.sName)
        Me.dashboardpanel.Location = New System.Drawing.Point(4, 0)
        Me.dashboardpanel.Name = "dashboardpanel"
        Me.dashboardpanel.Size = New System.Drawing.Size(995, 597)
        Me.dashboardpanel.TabIndex = 1
        '
        'regtxt
        '
        Me.regtxt.BackColor = System.Drawing.Color.Transparent
        Me.regtxt.Font = New System.Drawing.Font("Shrikhand", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regtxt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.regtxt.Location = New System.Drawing.Point(373, 465)
        Me.regtxt.Name = "regtxt"
        Me.regtxt.Size = New System.Drawing.Size(470, 45)
        Me.regtxt.TabIndex = 6
        Me.regtxt.Text = "Student Registration System"
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.BaseColor = System.Drawing.Color.Transparent
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(402, 53)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(367, 298)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 5
        Me.logo.TabStop = False
        Me.logo.UseTransfarantBackground = False
        '
        'sName
        '
        Me.sName.BackColor = System.Drawing.Color.Transparent
        Me.sName.Font = New System.Drawing.Font("Shrikhand", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.sName.Location = New System.Drawing.Point(320, 389)
        Me.sName.Name = "sName"
        Me.sName.Size = New System.Drawing.Size(484, 72)
        Me.sName.TabIndex = 4
        Me.sName.Text = "Noah's Arc College"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 25
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 25
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.BorderRadius = 25
        '
        'Guna2Elipse4
        '
        Me.Guna2Elipse4.BorderRadius = 25
        '
        'tryDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(995, 597)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Controls.Add(Me.dashboardpanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tryDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.gbAdmin.ResumeLayout(False)
        Me.gbAdmin.PerformLayout()
        CType(Me.pbAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dashboardpanel.ResumeLayout(False)
        Me.dashboardpanel.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents rgsbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents gbAdmin As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents pbAdmin As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents accbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents stdbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dashbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSignOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents crsbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents deptbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dashpanel As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lblLastName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblFirstName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGender As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblMiddleName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblEmail As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblHomeAddress As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblBirthday As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents elipseForm3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents elipseBody As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents elipsePersonalDetails As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents dashboardpanel As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents logo As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents sName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents regtxt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents user As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
