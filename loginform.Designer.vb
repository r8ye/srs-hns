<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginform))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.logo = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaImageCheckBox1 = New Guna.UI.WinForms.GunaImageCheckBox()
        Me.password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.usertypename = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 25
        Me.Guna2Elipse1.TargetControl = Me
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.BaseColor = System.Drawing.Color.Transparent
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(104, 18)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(143, 122)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 6
        Me.logo.TabStop = False
        Me.logo.UseTransfarantBackground = False
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.Controls.Add(Me.Guna2Button1)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaImageCheckBox1)
        Me.GunaShadowPanel1.Controls.Add(Me.password)
        Me.GunaShadowPanel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.GunaShadowPanel1.Controls.Add(Me.usertypename)
        Me.GunaShadowPanel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.GunaShadowPanel1.Controls.Add(Me.logo)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(149, 83)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Cyan
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(347, 414)
        Me.GunaShadowPanel1.TabIndex = 7
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.PowderBlue
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.BorderThickness = 2
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.CornflowerBlue
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(116, 336)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(121, 34)
        Me.Guna2Button1.TabIndex = 64
        Me.Guna2Button1.Text = "Log In"
        '
        'GunaImageCheckBox1
        '
        Me.GunaImageCheckBox1.BackColor = System.Drawing.Color.White
        Me.GunaImageCheckBox1.ImageCheckedOff = CType(resources.GetObject("GunaImageCheckBox1.ImageCheckedOff"), System.Drawing.Image)
        Me.GunaImageCheckBox1.ImageCheckedOn = CType(resources.GetObject("GunaImageCheckBox1.ImageCheckedOn"), System.Drawing.Image)
        Me.GunaImageCheckBox1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaImageCheckBox1.Location = New System.Drawing.Point(308, 271)
        Me.GunaImageCheckBox1.Name = "GunaImageCheckBox1"
        Me.GunaImageCheckBox1.Size = New System.Drawing.Size(21, 17)
        Me.GunaImageCheckBox1.TabIndex = 88
        '
        'password
        '
        Me.password.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.password.BorderRadius = 5
        Me.password.BorderThickness = 2
        Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password.DefaultText = ""
        Me.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password.DisabledState.Parent = Me.password
        Me.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.FocusedState.Parent = Me.password
        Me.password.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.ForeColor = System.Drawing.Color.MidnightBlue
        Me.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.password.HoverState.Parent = Me.password
        Me.password.Location = New System.Drawing.Point(117, 264)
        Me.password.Margin = New System.Windows.Forms.Padding(4)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.password.PlaceholderForeColor = System.Drawing.Color.Red
        Me.password.PlaceholderText = "Input Password"
        Me.password.SelectedText = ""
        Me.password.ShadowDecoration.Parent = Me.password
        Me.password.Size = New System.Drawing.Size(218, 30)
        Me.password.TabIndex = 87
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(15, 266)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(93, 27)
        Me.Guna2HtmlLabel1.TabIndex = 86
        Me.Guna2HtmlLabel1.Text = "Password:"
        '
        'usertypename
        '
        Me.usertypename.BorderColor = System.Drawing.Color.CornflowerBlue
        Me.usertypename.BorderRadius = 5
        Me.usertypename.BorderThickness = 2
        Me.usertypename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usertypename.DefaultText = ""
        Me.usertypename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.usertypename.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.usertypename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usertypename.DisabledState.Parent = Me.usertypename
        Me.usertypename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usertypename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usertypename.FocusedState.Parent = Me.usertypename
        Me.usertypename.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usertypename.ForeColor = System.Drawing.Color.MidnightBlue
        Me.usertypename.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usertypename.HoverState.Parent = Me.usertypename
        Me.usertypename.Location = New System.Drawing.Point(115, 195)
        Me.usertypename.Margin = New System.Windows.Forms.Padding(4)
        Me.usertypename.Name = "usertypename"
        Me.usertypename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usertypename.PlaceholderForeColor = System.Drawing.Color.Red
        Me.usertypename.PlaceholderText = "Input Usernmae"
        Me.usertypename.SelectedText = ""
        Me.usertypename.ShadowDecoration.Parent = Me.usertypename
        Me.usertypename.Size = New System.Drawing.Size(218, 30)
        Me.usertypename.TabIndex = 85
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(15, 195)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(97, 27)
        Me.Guna2HtmlLabel2.TabIndex = 84
        Me.Guna2HtmlLabel2.Text = "Username:"
        '
        'loginform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(635, 519)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loginform"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents logo As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaImageCheckBox1 As Guna.UI.WinForms.GunaImageCheckBox
    Friend WithEvents password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents usertypename As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
