<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class logIn
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
        Me.lblWelcome = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSignIn = New Guna.UI2.WinForms.Guna2Button()
        Me.lblNew = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.linkSignUp = New System.Windows.Forms.LinkLabel()
        Me.gbRegSys = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.cbSignInSP = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.cbX = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.pbSignIn = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.elipseForm1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.gbRegSys.SuspendLayout()
        CType(Me.pbSignIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblWelcome.Location = New System.Drawing.Point(76, 61)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(156, 49)
        Me.lblWelcome.TabIndex = 2
        Me.lblWelcome.Text = "Welcome"
        '
        'txtUsername
        '
        Me.txtUsername.BorderColor = System.Drawing.Color.Lavender
        Me.txtUsername.BorderRadius = 5
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.Parent = Me.txtUsername
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FillColor = System.Drawing.Color.Lavender
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.FocusedState.Parent = Me.txtUsername
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.HoverState.Parent = Me.txtUsername
        Me.txtUsername.Location = New System.Drawing.Point(15, 137)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderForeColor = System.Drawing.Color.MidnightBlue
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.ShadowDecoration.Parent = Me.txtUsername
        Me.txtUsername.Size = New System.Drawing.Size(281, 38)
        Me.txtUsername.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.BorderColor = System.Drawing.Color.Lavender
        Me.txtPassword.BorderRadius = 5
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.Parent = Me.txtPassword
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FillColor = System.Drawing.Color.Lavender
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedState.Parent = Me.txtPassword
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.HoverState.Parent = Me.txtPassword
        Me.txtPassword.Location = New System.Drawing.Point(15, 190)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderForeColor = System.Drawing.Color.MidnightBlue
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.Size = New System.Drawing.Size(281, 38)
        Me.txtPassword.TabIndex = 5
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnSignIn
        '
        Me.btnSignIn.Animated = True
        Me.btnSignIn.BackColor = System.Drawing.Color.Transparent
        Me.btnSignIn.BorderRadius = 10
        Me.btnSignIn.CheckedState.Parent = Me.btnSignIn
        Me.btnSignIn.CustomImages.Parent = Me.btnSignIn
        Me.btnSignIn.FillColor = System.Drawing.Color.CornflowerBlue
        Me.btnSignIn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.ForeColor = System.Drawing.Color.White
        Me.btnSignIn.HoverState.Parent = Me.btnSignIn
        Me.btnSignIn.Location = New System.Drawing.Point(90, 248)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.ShadowDecoration.Parent = Me.btnSignIn
        Me.btnSignIn.Size = New System.Drawing.Size(145, 38)
        Me.btnSignIn.TabIndex = 6
        Me.btnSignIn.Text = "Sign In"
        '
        'lblNew
        '
        Me.lblNew.BackColor = System.Drawing.Color.Transparent
        Me.lblNew.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblNew.Location = New System.Drawing.Point(58, 309)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(156, 19)
        Me.lblNew.TabIndex = 8
        Me.lblNew.Text = "Dont have an account yet? "
        '
        'linkSignUp
        '
        Me.linkSignUp.ActiveLinkColor = System.Drawing.Color.MidnightBlue
        Me.linkSignUp.AutoSize = True
        Me.linkSignUp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkSignUp.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.linkSignUp.Location = New System.Drawing.Point(214, 309)
        Me.linkSignUp.Name = "linkSignUp"
        Me.linkSignUp.Size = New System.Drawing.Size(54, 17)
        Me.linkSignUp.TabIndex = 9
        Me.linkSignUp.TabStop = True
        Me.linkSignUp.Text = "Sign Up"
        '
        'gbRegSys
        '
        Me.gbRegSys.BorderColor = System.Drawing.Color.White
        Me.gbRegSys.Controls.Add(Me.cbSignInSP)
        Me.gbRegSys.Controls.Add(Me.txtPassword)
        Me.gbRegSys.Controls.Add(Me.linkSignUp)
        Me.gbRegSys.Controls.Add(Me.txtUsername)
        Me.gbRegSys.Controls.Add(Me.lblNew)
        Me.gbRegSys.Controls.Add(Me.btnSignIn)
        Me.gbRegSys.Controls.Add(Me.lblWelcome)
        Me.gbRegSys.CustomBorderColor = System.Drawing.Color.White
        Me.gbRegSys.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRegSys.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.gbRegSys.Location = New System.Drawing.Point(14, 12)
        Me.gbRegSys.Name = "gbRegSys"
        Me.gbRegSys.ShadowDecoration.Parent = Me.gbRegSys
        Me.gbRegSys.Size = New System.Drawing.Size(378, 426)
        Me.gbRegSys.TabIndex = 10
        '
        'cbSignInSP
        '
        Me.cbSignInSP.Animated = True
        Me.cbSignInSP.AutoSize = True
        Me.cbSignInSP.BackColor = System.Drawing.Color.Transparent
        Me.cbSignInSP.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSignInSP.CheckedState.BorderRadius = 2
        Me.cbSignInSP.CheckedState.BorderThickness = 0
        Me.cbSignInSP.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSignInSP.CheckMarkColor = System.Drawing.Color.Lavender
        Me.cbSignInSP.Location = New System.Drawing.Point(271, 203)
        Me.cbSignInSP.Name = "cbSignInSP"
        Me.cbSignInSP.Size = New System.Drawing.Size(15, 14)
        Me.cbSignInSP.TabIndex = 10
        Me.cbSignInSP.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbSignInSP.UncheckedState.BorderRadius = 2
        Me.cbSignInSP.UncheckedState.BorderThickness = 0
        Me.cbSignInSP.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbSignInSP.UseVisualStyleBackColor = False
        '
        'cbX
        '
        Me.cbX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbX.BackColor = System.Drawing.Color.Transparent
        Me.cbX.FillColor = System.Drawing.Color.White
        Me.cbX.HoverState.Parent = Me.cbX
        Me.cbX.IconColor = System.Drawing.Color.MidnightBlue
        Me.cbX.Location = New System.Drawing.Point(723, -1)
        Me.cbX.Name = "cbX"
        Me.cbX.ShadowDecoration.Parent = Me.cbX
        Me.cbX.Size = New System.Drawing.Size(33, 29)
        Me.cbX.TabIndex = 11
        '
        'pbSignIn
        '
        Me.pbSignIn.Image = Global.AAAAA.My.Resources.Resources.rb_3137
        Me.pbSignIn.Location = New System.Drawing.Point(317, 28)
        Me.pbSignIn.Name = "pbSignIn"
        Me.pbSignIn.ShadowDecoration.Parent = Me.pbSignIn
        Me.pbSignIn.Size = New System.Drawing.Size(433, 367)
        Me.pbSignIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSignIn.TabIndex = 0
        Me.pbSignIn.TabStop = False
        '
        'elipseForm1
        '
        Me.elipseForm1.BorderRadius = 25
        Me.elipseForm1.TargetControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(755, 414)
        Me.Controls.Add(Me.pbSignIn)
        Me.Controls.Add(Me.cbX)
        Me.Controls.Add(Me.gbRegSys)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.gbRegSys.ResumeLayout(False)
        Me.gbRegSys.PerformLayout()
        CType(Me.pbSignIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbSignIn As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblWelcome As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSignIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblNew As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents linkSignUp As LinkLabel
    Friend WithEvents gbRegSys As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents cbX As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents elipseForm1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents cbSignInSP As Guna.UI2.WinForms.Guna2CheckBox
End Class
