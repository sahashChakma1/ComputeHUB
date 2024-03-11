<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.btnExit = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuGradientPanel1 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.UserName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2CustomCheckBox1 = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.BtnLogIn = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.Azure
        Me.BunifuLabel1.Location = New System.Drawing.Point(16, 14)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(165, 28)
        Me.BunifuLabel1.TabIndex = 0
        Me.BunifuLabel1.Text = "LOGIN HERE !"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'btnExit
        '
        Me.btnExit.AllowAnimations = True
        Me.btnExit.AllowMouseEffects = True
        Me.btnExit.AllowToggling = False
        Me.btnExit.AnimationSpeed = 200
        Me.btnExit.AutoGenerateColors = False
        Me.btnExit.AutoRoundBorders = False
        Me.btnExit.AutoSizeLeftIcon = True
        Me.btnExit.AutoSizeRightIcon = True
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackColor1 = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnExit.ButtonText = "x"
        Me.btnExit.ButtonTextMarginLeft = 0
        Me.btnExit.ColorContrastOnClick = 45
        Me.btnExit.ColorContrastOnHover = 45
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btnExit.CustomizableEdges = BorderEdges1
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExit.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnExit.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnExit.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnExit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Variable Display", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.btnExit.IconMarginLeft = 11
        Me.btnExit.IconPadding = 10
        Me.btnExit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.btnExit.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.btnExit.IconSize = 25
        Me.btnExit.IdleBorderColor = System.Drawing.Color.Transparent
        Me.btnExit.IdleBorderRadius = 1
        Me.btnExit.IdleBorderThickness = 1
        Me.btnExit.IdleFillColor = System.Drawing.Color.Transparent
        Me.btnExit.IdleIconLeftImage = Nothing
        Me.btnExit.IdleIconRightImage = Nothing
        Me.btnExit.IndicateFocus = False
        Me.btnExit.Location = New System.Drawing.Point(431, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnExit.OnDisabledState.BorderRadius = 1
        Me.btnExit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnExit.OnDisabledState.BorderThickness = 1
        Me.btnExit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnExit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnExit.OnDisabledState.IconLeftImage = Nothing
        Me.btnExit.OnDisabledState.IconRightImage = Nothing
        Me.btnExit.onHoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnExit.onHoverState.BorderRadius = 1
        Me.btnExit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnExit.onHoverState.BorderThickness = 1
        Me.btnExit.onHoverState.FillColor = System.Drawing.Color.Teal
        Me.btnExit.onHoverState.ForeColor = System.Drawing.Color.Transparent
        Me.btnExit.onHoverState.IconLeftImage = Nothing
        Me.btnExit.onHoverState.IconRightImage = Nothing
        Me.btnExit.OnIdleState.BorderColor = System.Drawing.Color.Transparent
        Me.btnExit.OnIdleState.BorderRadius = 1
        Me.btnExit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnExit.OnIdleState.BorderThickness = 1
        Me.btnExit.OnIdleState.FillColor = System.Drawing.Color.Transparent
        Me.btnExit.OnIdleState.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExit.OnIdleState.IconLeftImage = Nothing
        Me.btnExit.OnIdleState.IconRightImage = Nothing
        Me.btnExit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.btnExit.OnPressedState.BorderRadius = 1
        Me.btnExit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnExit.OnPressedState.BorderThickness = 1
        Me.btnExit.OnPressedState.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnExit.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.btnExit.OnPressedState.IconLeftImage = Nothing
        Me.btnExit.OnPressedState.IconRightImage = Nothing
        Me.btnExit.Size = New System.Drawing.Size(49, 42)
        Me.btnExit.TabIndex = 1
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnExit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnExit.TextMarginLeft = 0
        Me.btnExit.TextPadding = New System.Windows.Forms.Padding(0)
        Me.btnExit.UseDefaultRadiusAndThickness = True
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderRadius = 1
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuLabel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.btnExit)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-4, -1)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(480, 74)
        Me.BunifuGradientPanel1.TabIndex = 2
        '
        'UserName
        '
        Me.UserName.Animated = True
        Me.UserName.AutoRoundedCorners = True
        Me.UserName.BorderRadius = 17
        Me.UserName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserName.DefaultText = ""
        Me.UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UserName.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.UserName.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.UserName.IconLeft = CType(resources.GetObject("UserName.IconLeft"), System.Drawing.Image)
        Me.UserName.Location = New System.Drawing.Point(108, 154)
        Me.UserName.Name = "UserName"
        Me.UserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserName.PlaceholderText = "USERNAME"
        Me.UserName.SelectedText = ""
        Me.UserName.Size = New System.Drawing.Size(232, 36)
        Me.UserName.TabIndex = 3
        '
        'Password
        '
        Me.Password.Animated = True
        Me.Password.AutoRoundedCorners = True
        Me.Password.BorderRadius = 17
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.DefaultText = ""
        Me.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Password.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Password.HoverState.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Password.IconLeft = CType(resources.GetObject("Password.IconLeft"), System.Drawing.Image)
        Me.Password.Location = New System.Drawing.Point(108, 210)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.PlaceholderText = "PASSWORD"
        Me.Password.SelectedText = ""
        Me.Password.Size = New System.Drawing.Size(232, 36)
        Me.Password.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(188, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "LOGIN"
        '
        'Guna2CustomCheckBox1
        '
        Me.Guna2CustomCheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Guna2CustomCheckBox1.CheckedState.BorderRadius = 2
        Me.Guna2CustomCheckBox1.CheckedState.BorderThickness = 0
        Me.Guna2CustomCheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Guna2CustomCheckBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2CustomCheckBox1.Location = New System.Drawing.Point(119, 258)
        Me.Guna2CustomCheckBox1.Name = "Guna2CustomCheckBox1"
        Me.Guna2CustomCheckBox1.Size = New System.Drawing.Size(19, 18)
        Me.Guna2CustomCheckBox1.TabIndex = 6
        Me.Guna2CustomCheckBox1.Text = "Guna2CustomCheckBox1"
        Me.Guna2CustomCheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CustomCheckBox1.UncheckedState.BorderRadius = 2
        Me.Guna2CustomCheckBox1.UncheckedState.BorderThickness = 0
        Me.Guna2CustomCheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label2.Location = New System.Drawing.Point(144, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Show Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Small", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(123, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "New User??  "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI Variable Small", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(210, 390)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(87, 17)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Register now"
        '
        'BtnLogIn
        '
        Me.BtnLogIn.AllowAnimations = True
        Me.BtnLogIn.AllowMouseEffects = True
        Me.BtnLogIn.AllowToggling = False
        Me.BtnLogIn.AnimationSpeed = 200
        Me.BtnLogIn.AutoGenerateColors = False
        Me.BtnLogIn.AutoRoundBorders = False
        Me.BtnLogIn.AutoSizeLeftIcon = True
        Me.BtnLogIn.AutoSizeRightIcon = True
        Me.BtnLogIn.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogIn.BackColor1 = System.Drawing.SystemColors.Menu
        Me.BtnLogIn.BackgroundImage = CType(resources.GetObject("BtnLogIn.BackgroundImage"), System.Drawing.Image)
        Me.BtnLogIn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnLogIn.ButtonText = "LOGIN"
        Me.BtnLogIn.ButtonTextMarginLeft = 0
        Me.BtnLogIn.ColorContrastOnClick = 45
        Me.BtnLogIn.ColorContrastOnHover = 45
        Me.BtnLogIn.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.BtnLogIn.CustomizableEdges = BorderEdges2
        Me.BtnLogIn.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnLogIn.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnLogIn.DisabledFillColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnLogIn.DisabledForecolor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnLogIn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BtnLogIn.Font = New System.Drawing.Font("Segoe UI Variable Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnLogIn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogIn.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BtnLogIn.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BtnLogIn.IconMarginLeft = 11
        Me.BtnLogIn.IconPadding = 10
        Me.BtnLogIn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLogIn.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BtnLogIn.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BtnLogIn.IconSize = 25
        Me.BtnLogIn.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.BtnLogIn.IdleBorderRadius = 30
        Me.BtnLogIn.IdleBorderThickness = 1
        Me.BtnLogIn.IdleFillColor = System.Drawing.SystemColors.Menu
        Me.BtnLogIn.IdleIconLeftImage = Nothing
        Me.BtnLogIn.IdleIconRightImage = Nothing
        Me.BtnLogIn.IndicateFocus = False
        Me.BtnLogIn.Location = New System.Drawing.Point(147, 300)
        Me.BtnLogIn.Name = "BtnLogIn"
        Me.BtnLogIn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnLogIn.OnDisabledState.BorderRadius = 30
        Me.BtnLogIn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnLogIn.OnDisabledState.BorderThickness = 1
        Me.BtnLogIn.OnDisabledState.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnLogIn.OnDisabledState.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnLogIn.OnDisabledState.IconLeftImage = Nothing
        Me.BtnLogIn.OnDisabledState.IconRightImage = Nothing
        Me.BtnLogIn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnLogIn.onHoverState.BorderRadius = 30
        Me.BtnLogIn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnLogIn.onHoverState.BorderThickness = 1
        Me.BtnLogIn.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnLogIn.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BtnLogIn.onHoverState.IconLeftImage = Nothing
        Me.BtnLogIn.onHoverState.IconRightImage = Nothing
        Me.BtnLogIn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.BtnLogIn.OnIdleState.BorderRadius = 30
        Me.BtnLogIn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnLogIn.OnIdleState.BorderThickness = 1
        Me.BtnLogIn.OnIdleState.FillColor = System.Drawing.SystemColors.Menu
        Me.BtnLogIn.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnLogIn.OnIdleState.IconLeftImage = Nothing
        Me.BtnLogIn.OnIdleState.IconRightImage = Nothing
        Me.BtnLogIn.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.BtnLogIn.OnPressedState.BorderRadius = 30
        Me.BtnLogIn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnLogIn.OnPressedState.BorderThickness = 1
        Me.BtnLogIn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnLogIn.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BtnLogIn.OnPressedState.IconLeftImage = Nothing
        Me.BtnLogIn.OnPressedState.IconRightImage = Nothing
        Me.BtnLogIn.Size = New System.Drawing.Size(150, 39)
        Me.BtnLogIn.TabIndex = 10
        Me.BtnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnLogIn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnLogIn.TextMarginLeft = 0
        Me.BtnLogIn.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BtnLogIn.UseDefaultRadiusAndThickness = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 30
        Me.BunifuElipse1.TargetControl = Me
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 497)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnLogIn)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2CustomCheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents btnExit As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuGradientPanel1 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents UserName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2CustomCheckBox1 As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents BtnLogIn As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Protected Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
