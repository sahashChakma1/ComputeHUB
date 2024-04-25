<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BACK = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Namebox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UserNameBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PasswordBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ConfirmPassBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CreateBox = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton2 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(315, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CREATE ACCOUNT"
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.PictureBox1)
        Me.Guna2ShadowPanel1.Controls.Add(Me.BACK)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Label2)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Guna2ShadowPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(220, 455)
        Me.Guna2ShadowPanel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 189)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'BACK
        '
        Me.BACK.AllowAnimations = True
        Me.BACK.AllowMouseEffects = True
        Me.BACK.AllowToggling = True
        Me.BACK.AnimationSpeed = 200
        Me.BACK.AutoGenerateColors = False
        Me.BACK.AutoRoundBorders = False
        Me.BACK.AutoSizeLeftIcon = True
        Me.BACK.AutoSizeRightIcon = True
        Me.BACK.BackColor = System.Drawing.Color.Transparent
        Me.BACK.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BACK.BackgroundImage = CType(resources.GetObject("BACK.BackgroundImage"), System.Drawing.Image)
        Me.BACK.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BACK.ButtonText = "Go Back"
        Me.BACK.ButtonTextMarginLeft = 0
        Me.BACK.ColorContrastOnClick = 45
        Me.BACK.ColorContrastOnHover = 45
        Me.BACK.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.BACK.CustomizableEdges = BorderEdges4
        Me.BACK.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BACK.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BACK.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BACK.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BACK.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BACK.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BACK.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BACK.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BACK.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BACK.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BACK.IconMarginLeft = 11
        Me.BACK.IconPadding = 10
        Me.BACK.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BACK.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BACK.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BACK.IconSize = 25
        Me.BACK.IdleBorderColor = System.Drawing.Color.WhiteSmoke
        Me.BACK.IdleBorderRadius = 30
        Me.BACK.IdleBorderThickness = 2
        Me.BACK.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BACK.IdleIconLeftImage = Nothing
        Me.BACK.IdleIconRightImage = Nothing
        Me.BACK.IndicateFocus = True
        Me.BACK.Location = New System.Drawing.Point(42, 265)
        Me.BACK.Name = "BACK"
        Me.BACK.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BACK.OnDisabledState.BorderRadius = 30
        Me.BACK.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BACK.OnDisabledState.BorderThickness = 2
        Me.BACK.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BACK.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BACK.OnDisabledState.IconLeftImage = Nothing
        Me.BACK.OnDisabledState.IconRightImage = Nothing
        Me.BACK.onHoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.BACK.onHoverState.BorderRadius = 30
        Me.BACK.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BACK.onHoverState.BorderThickness = 2
        Me.BACK.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BACK.onHoverState.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BACK.onHoverState.IconLeftImage = Nothing
        Me.BACK.onHoverState.IconRightImage = Nothing
        Me.BACK.OnIdleState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.BACK.OnIdleState.BorderRadius = 30
        Me.BACK.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BACK.OnIdleState.BorderThickness = 2
        Me.BACK.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BACK.OnIdleState.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BACK.OnIdleState.IconLeftImage = Nothing
        Me.BACK.OnIdleState.IconRightImage = Nothing
        Me.BACK.OnPressedState.BorderColor = System.Drawing.Color.White
        Me.BACK.OnPressedState.BorderRadius = 30
        Me.BACK.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BACK.OnPressedState.BorderThickness = 2
        Me.BACK.OnPressedState.FillColor = System.Drawing.Color.Teal
        Me.BACK.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BACK.OnPressedState.IconLeftImage = Nothing
        Me.BACK.OnPressedState.IconRightImage = Nothing
        Me.BACK.Size = New System.Drawing.Size(125, 39)
        Me.BACK.TabIndex = 2
        Me.BACK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BACK.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BACK.TextMarginLeft = 0
        Me.BACK.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BACK.UseDefaultRadiusAndThickness = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(22, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Already Registered !!"
        '
        'Namebox
        '
        Me.Namebox.Animated = True
        Me.Namebox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Namebox.DefaultText = ""
        Me.Namebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Namebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Namebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Namebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Namebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Namebox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.Namebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Namebox.Location = New System.Drawing.Point(237, 92)
        Me.Namebox.Name = "Namebox"
        Me.Namebox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Namebox.PlaceholderText = "Name"
        Me.Namebox.SelectedText = ""
        Me.Namebox.Size = New System.Drawing.Size(315, 36)
        Me.Namebox.TabIndex = 2
        '
        'UserNameBox
        '
        Me.UserNameBox.Animated = True
        Me.UserNameBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserNameBox.DefaultText = ""
        Me.UserNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserNameBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserNameBox.Location = New System.Drawing.Point(237, 156)
        Me.UserNameBox.Name = "UserNameBox"
        Me.UserNameBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserNameBox.PlaceholderText = "Username"
        Me.UserNameBox.SelectedText = ""
        Me.UserNameBox.Size = New System.Drawing.Size(315, 36)
        Me.UserNameBox.TabIndex = 3
        '
        'PasswordBox
        '
        Me.PasswordBox.Animated = True
        Me.PasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordBox.DefaultText = ""
        Me.PasswordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordBox.Location = New System.Drawing.Point(237, 223)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBox.PlaceholderText = "Password"
        Me.PasswordBox.SelectedText = ""
        Me.PasswordBox.Size = New System.Drawing.Size(315, 36)
        Me.PasswordBox.TabIndex = 4
        '
        'ConfirmPassBox
        '
        Me.ConfirmPassBox.Animated = True
        Me.ConfirmPassBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ConfirmPassBox.DefaultText = ""
        Me.ConfirmPassBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ConfirmPassBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ConfirmPassBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ConfirmPassBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ConfirmPassBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfirmPassBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPassBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfirmPassBox.Location = New System.Drawing.Point(237, 284)
        Me.ConfirmPassBox.Name = "ConfirmPassBox"
        Me.ConfirmPassBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPassBox.PlaceholderText = "Confirm Password"
        Me.ConfirmPassBox.SelectedText = ""
        Me.ConfirmPassBox.Size = New System.Drawing.Size(315, 36)
        Me.ConfirmPassBox.TabIndex = 5
        '
        'CreateBox
        '
        Me.CreateBox.AllowAnimations = True
        Me.CreateBox.AllowMouseEffects = True
        Me.CreateBox.AllowToggling = False
        Me.CreateBox.AnimationSpeed = 200
        Me.CreateBox.AutoGenerateColors = False
        Me.CreateBox.AutoRoundBorders = False
        Me.CreateBox.AutoSizeLeftIcon = True
        Me.CreateBox.AutoSizeRightIcon = True
        Me.CreateBox.BackColor = System.Drawing.Color.Transparent
        Me.CreateBox.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.CreateBox.BackgroundImage = CType(resources.GetObject("CreateBox.BackgroundImage"), System.Drawing.Image)
        Me.CreateBox.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.CreateBox.ButtonText = "Create"
        Me.CreateBox.ButtonTextMarginLeft = 0
        Me.CreateBox.ColorContrastOnClick = 45
        Me.CreateBox.ColorContrastOnHover = 45
        Me.CreateBox.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges5.BottomLeft = True
        BorderEdges5.BottomRight = True
        BorderEdges5.TopLeft = True
        BorderEdges5.TopRight = True
        Me.CreateBox.CustomizableEdges = BorderEdges5
        Me.CreateBox.DialogResult = System.Windows.Forms.DialogResult.None
        Me.CreateBox.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.CreateBox.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.CreateBox.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.CreateBox.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.CreateBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateBox.ForeColor = System.Drawing.Color.White
        Me.CreateBox.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreateBox.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.CreateBox.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.CreateBox.IconMarginLeft = 11
        Me.CreateBox.IconPadding = 10
        Me.CreateBox.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CreateBox.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.CreateBox.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.CreateBox.IconSize = 25
        Me.CreateBox.IdleBorderColor = System.Drawing.SystemColors.ButtonFace
        Me.CreateBox.IdleBorderRadius = 1
        Me.CreateBox.IdleBorderThickness = 1
        Me.CreateBox.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.CreateBox.IdleIconLeftImage = Nothing
        Me.CreateBox.IdleIconRightImage = Nothing
        Me.CreateBox.IndicateFocus = False
        Me.CreateBox.Location = New System.Drawing.Point(319, 363)
        Me.CreateBox.Name = "CreateBox"
        Me.CreateBox.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.CreateBox.OnDisabledState.BorderRadius = 1
        Me.CreateBox.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.CreateBox.OnDisabledState.BorderThickness = 1
        Me.CreateBox.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.CreateBox.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.CreateBox.OnDisabledState.IconLeftImage = Nothing
        Me.CreateBox.OnDisabledState.IconRightImage = Nothing
        Me.CreateBox.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.CreateBox.onHoverState.BorderRadius = 1
        Me.CreateBox.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.CreateBox.onHoverState.BorderThickness = 1
        Me.CreateBox.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.CreateBox.onHoverState.ForeColor = System.Drawing.Color.White
        Me.CreateBox.onHoverState.IconLeftImage = Nothing
        Me.CreateBox.onHoverState.IconRightImage = Nothing
        Me.CreateBox.OnIdleState.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.CreateBox.OnIdleState.BorderRadius = 1
        Me.CreateBox.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.CreateBox.OnIdleState.BorderThickness = 1
        Me.CreateBox.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.CreateBox.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.CreateBox.OnIdleState.IconLeftImage = Nothing
        Me.CreateBox.OnIdleState.IconRightImage = Nothing
        Me.CreateBox.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.CreateBox.OnPressedState.BorderRadius = 1
        Me.CreateBox.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.CreateBox.OnPressedState.BorderThickness = 1
        Me.CreateBox.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.CreateBox.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.CreateBox.OnPressedState.IconLeftImage = Nothing
        Me.CreateBox.OnPressedState.IconRightImage = Nothing
        Me.CreateBox.Size = New System.Drawing.Size(152, 38)
        Me.CreateBox.TabIndex = 6
        Me.CreateBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CreateBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.CreateBox.TextMarginLeft = 0
        Me.CreateBox.TextPadding = New System.Windows.Forms.Padding(0)
        Me.CreateBox.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton2
        '
        Me.BunifuButton2.AllowAnimations = True
        Me.BunifuButton2.AllowMouseEffects = True
        Me.BunifuButton2.AllowToggling = False
        Me.BunifuButton2.AnimationSpeed = 200
        Me.BunifuButton2.AutoGenerateColors = False
        Me.BunifuButton2.AutoRoundBorders = False
        Me.BunifuButton2.AutoSizeLeftIcon = True
        Me.BunifuButton2.AutoSizeRightIcon = True
        Me.BunifuButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuButton2.BackgroundImage = CType(resources.GetObject("BunifuButton2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.ButtonText = "X"
        Me.BunifuButton2.ButtonTextMarginLeft = 0
        Me.BunifuButton2.ColorContrastOnClick = 45
        Me.BunifuButton2.ColorContrastOnHover = 45
        Me.BunifuButton2.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges6.BottomLeft = True
        BorderEdges6.BottomRight = True
        BorderEdges6.TopLeft = True
        BorderEdges6.TopRight = True
        Me.BunifuButton2.CustomizableEdges = BorderEdges6
        Me.BunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton2.ForeColor = System.Drawing.Color.White
        Me.BunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton2.IconMarginLeft = 11
        Me.BunifuButton2.IconPadding = 10
        Me.BunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton2.IconSize = 25
        Me.BunifuButton2.IdleBorderColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuButton2.IdleBorderRadius = 1
        Me.BunifuButton2.IdleBorderThickness = 1
        Me.BunifuButton2.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuButton2.IdleIconLeftImage = Nothing
        Me.BunifuButton2.IdleIconRightImage = Nothing
        Me.BunifuButton2.IndicateFocus = False
        Me.BunifuButton2.Location = New System.Drawing.Point(551, -1)
        Me.BunifuButton2.Name = "BunifuButton2"
        Me.BunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.BorderRadius = 1
        Me.BunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnDisabledState.BorderThickness = 1
        Me.BunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton2.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuButton2.onHoverState.BorderRadius = 1
        Me.BunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.onHoverState.BorderThickness = 1
        Me.BunifuButton2.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuButton2.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton2.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton2.onHoverState.IconRightImage = Nothing
        Me.BunifuButton2.OnIdleState.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuButton2.OnIdleState.BorderRadius = 1
        Me.BunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnIdleState.BorderThickness = 1
        Me.BunifuButton2.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton2.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton2.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuButton2.OnPressedState.BorderRadius = 1
        Me.BunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnPressedState.BorderThickness = 1
        Me.BunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton2.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton2.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton2.Size = New System.Drawing.Size(42, 38)
        Me.BunifuButton2.TabIndex = 7
        Me.BunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton2.TextMarginLeft = 0
        Me.BunifuButton2.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton2.UseDefaultRadiusAndThickness = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(235, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(235, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(235, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(235, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 12)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Confirm Password"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CreateBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuButton2)
        Me.Controls.Add(Me.ConfirmPassBox)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.UserNameBox)
        Me.Controls.Add(Me.Namebox)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "f"
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.Guna2ShadowPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents BACK As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Namebox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UserNameBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PasswordBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ConfirmPassBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CreateBox As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuButton2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
