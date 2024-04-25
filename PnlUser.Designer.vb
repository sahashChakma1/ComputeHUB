<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PnlUser
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PnlUser))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameText = New System.Windows.Forms.TextBox()
        Me.Gender = New System.Windows.Forms.TextBox()
        Me.EmailText = New System.Windows.Forms.TextBox()
        Me.PhoneText = New System.Windows.Forms.TextBox()
        Me.DataGridView = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.BtnDelete = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BtnEdit = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.CustIdText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(421, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(635, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(860, 38)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Phoneno"
        '
        'NameText
        '
        Me.NameText.Location = New System.Drawing.Point(222, 63)
        Me.NameText.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.NameText.Multiline = True
        Me.NameText.Name = "NameText"
        Me.NameText.Size = New System.Drawing.Size(190, 33)
        Me.NameText.TabIndex = 4
        '
        'Gender
        '
        Me.Gender.Location = New System.Drawing.Point(425, 64)
        Me.Gender.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Gender.Multiline = True
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(195, 31)
        Me.Gender.TabIndex = 5
        '
        'EmailText
        '
        Me.EmailText.Location = New System.Drawing.Point(630, 63)
        Me.EmailText.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.EmailText.Multiline = True
        Me.EmailText.Name = "EmailText"
        Me.EmailText.Size = New System.Drawing.Size(218, 31)
        Me.EmailText.TabIndex = 6
        '
        'PhoneText
        '
        Me.PhoneText.Location = New System.Drawing.Point(864, 63)
        Me.PhoneText.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PhoneText.Multiline = True
        Me.PhoneText.Name = "PhoneText"
        Me.PhoneText.Size = New System.Drawing.Size(228, 31)
        Me.PhoneText.TabIndex = 7
        '
        'DataGridView
        '
        Me.DataGridView.AllowCustomTheming = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView.ColumnHeadersHeight = 40
        Me.DataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DataGridView.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.DataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView.CurrentTheme.BackColor = System.Drawing.Color.Teal
        Me.DataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal
        Me.DataGridView.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DataGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView.CurrentTheme.Name = Nothing
        Me.DataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridView.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.DataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView.EnableHeadersVisualStyles = False
        Me.DataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DataGridView.HeaderBackColor = System.Drawing.Color.Teal
        Me.DataGridView.HeaderBackColor = System.Drawing.Color.Empty
        Me.DataGridView.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView.Location = New System.Drawing.Point(34, 222)
        Me.DataGridView.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.RowTemplate.Height = 40
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(1026, 453)
        Me.DataGridView.TabIndex = 8
        Me.DataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal
        '
        'BtnDelete
        '
        Me.BtnDelete.AllowAnimations = True
        Me.BtnDelete.AllowMouseEffects = True
        Me.BtnDelete.AllowToggling = False
        Me.BtnDelete.AnimationSpeed = 200
        Me.BtnDelete.AutoGenerateColors = False
        Me.BtnDelete.AutoRoundBorders = False
        Me.BtnDelete.AutoSizeLeftIcon = True
        Me.BtnDelete.AutoSizeRightIcon = True
        Me.BtnDelete.BackColor = System.Drawing.Color.Transparent
        Me.BtnDelete.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnDelete.BackgroundImage = CType(resources.GetObject("BtnDelete.BackgroundImage"), System.Drawing.Image)
        Me.BtnDelete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnDelete.ButtonText = "Delete"
        Me.BtnDelete.ButtonTextMarginLeft = 0
        Me.BtnDelete.ColorContrastOnClick = 45
        Me.BtnDelete.ColorContrastOnHover = 45
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BtnDelete.CustomizableEdges = BorderEdges1
        Me.BtnDelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnDelete.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnDelete.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BtnDelete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BtnDelete.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BtnDelete.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BtnDelete.IconMarginLeft = 11
        Me.BtnDelete.IconPadding = 10
        Me.BtnDelete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BtnDelete.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BtnDelete.IconSize = 25
        Me.BtnDelete.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnDelete.IdleBorderRadius = 1
        Me.BtnDelete.IdleBorderThickness = 1
        Me.BtnDelete.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnDelete.IdleIconLeftImage = Nothing
        Me.BtnDelete.IdleIconRightImage = Nothing
        Me.BtnDelete.IndicateFocus = False
        Me.BtnDelete.Location = New System.Drawing.Point(571, 168)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnDelete.OnDisabledState.BorderRadius = 1
        Me.BtnDelete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnDelete.OnDisabledState.BorderThickness = 1
        Me.BtnDelete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnDelete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BtnDelete.OnDisabledState.IconLeftImage = Nothing
        Me.BtnDelete.OnDisabledState.IconRightImage = Nothing
        Me.BtnDelete.onHoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.BtnDelete.onHoverState.BorderRadius = 1
        Me.BtnDelete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnDelete.onHoverState.BorderThickness = 1
        Me.BtnDelete.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnDelete.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.onHoverState.IconLeftImage = Nothing
        Me.BtnDelete.onHoverState.IconRightImage = Nothing
        Me.BtnDelete.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnDelete.OnIdleState.BorderRadius = 1
        Me.BtnDelete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnDelete.OnIdleState.BorderThickness = 1
        Me.BtnDelete.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnDelete.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.OnIdleState.IconLeftImage = Nothing
        Me.BtnDelete.OnIdleState.IconRightImage = Nothing
        Me.BtnDelete.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.BtnDelete.OnPressedState.BorderRadius = 1
        Me.BtnDelete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnDelete.OnPressedState.BorderThickness = 1
        Me.BtnDelete.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnDelete.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.OnPressedState.IconLeftImage = Nothing
        Me.BtnDelete.OnPressedState.IconRightImage = Nothing
        Me.BtnDelete.Size = New System.Drawing.Size(93, 32)
        Me.BtnDelete.TabIndex = 16
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnDelete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnDelete.TextMarginLeft = 0
        Me.BtnDelete.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BtnDelete.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton1
        '
        Me.BunifuButton1.AllowAnimations = True
        Me.BunifuButton1.AllowMouseEffects = True
        Me.BunifuButton1.AllowToggling = False
        Me.BunifuButton1.AnimationSpeed = 200
        Me.BunifuButton1.AutoGenerateColors = False
        Me.BunifuButton1.AutoRoundBorders = False
        Me.BunifuButton1.AutoSizeLeftIcon = True
        Me.BunifuButton1.AutoSizeRightIcon = True
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.ButtonText = "Add"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.ColorContrastOnClick = 45
        Me.BunifuButton1.ColorContrastOnHover = 45
        Me.BunifuButton1.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.BunifuButton1.CustomizableEdges = BorderEdges2
        Me.BunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton1.IconMarginLeft = 11
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton1.IconSize = 25
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuButton1.IdleBorderRadius = 1
        Me.BunifuButton1.IdleBorderThickness = 1
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuButton1.IdleIconLeftImage = Nothing
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.IndicateFocus = False
        Me.BunifuButton1.Location = New System.Drawing.Point(438, 168)
        Me.BunifuButton1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuButton1.Name = "BunifuButton1"
        Me.BunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.BorderRadius = 1
        Me.BunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnDisabledState.BorderThickness = 1
        Me.BunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton1.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuButton1.onHoverState.BorderRadius = 1
        Me.BunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.onHoverState.BorderThickness = 1
        Me.BunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton1.onHoverState.IconRightImage = Nothing
        Me.BunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuButton1.OnIdleState.BorderRadius = 1
        Me.BunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnIdleState.BorderThickness = 1
        Me.BunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton1.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.OnPressedState.BorderRadius = 1
        Me.BunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnPressedState.BorderThickness = 1
        Me.BunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton1.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton1.Size = New System.Drawing.Size(96, 32)
        Me.BunifuButton1.TabIndex = 15
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton1.TextMarginLeft = 0
        Me.BunifuButton1.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton1.UseDefaultRadiusAndThickness = True
        '
        'BtnEdit
        '
        Me.BtnEdit.AllowAnimations = True
        Me.BtnEdit.AllowMouseEffects = True
        Me.BtnEdit.AllowToggling = False
        Me.BtnEdit.AnimationSpeed = 200
        Me.BtnEdit.AutoGenerateColors = False
        Me.BtnEdit.AutoRoundBorders = False
        Me.BtnEdit.AutoSizeLeftIcon = True
        Me.BtnEdit.AutoSizeRightIcon = True
        Me.BtnEdit.BackColor = System.Drawing.Color.Transparent
        Me.BtnEdit.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnEdit.BackgroundImage = CType(resources.GetObject("BtnEdit.BackgroundImage"), System.Drawing.Image)
        Me.BtnEdit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnEdit.ButtonText = "Edit"
        Me.BtnEdit.ButtonTextMarginLeft = 0
        Me.BtnEdit.ColorContrastOnClick = 45
        Me.BtnEdit.ColorContrastOnHover = 45
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.BtnEdit.CustomizableEdges = BorderEdges3
        Me.BtnEdit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnEdit.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnEdit.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnEdit.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BtnEdit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BtnEdit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BtnEdit.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BtnEdit.IconMarginLeft = 11
        Me.BtnEdit.IconPadding = 10
        Me.BtnEdit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BtnEdit.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BtnEdit.IconSize = 25
        Me.BtnEdit.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnEdit.IdleBorderRadius = 1
        Me.BtnEdit.IdleBorderThickness = 1
        Me.BtnEdit.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnEdit.IdleIconLeftImage = Nothing
        Me.BtnEdit.IdleIconRightImage = Nothing
        Me.BtnEdit.IndicateFocus = False
        Me.BtnEdit.Location = New System.Drawing.Point(300, 168)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnEdit.OnDisabledState.BorderRadius = 1
        Me.BtnEdit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnEdit.OnDisabledState.BorderThickness = 1
        Me.BtnEdit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BtnEdit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BtnEdit.OnDisabledState.IconLeftImage = Nothing
        Me.BtnEdit.OnDisabledState.IconRightImage = Nothing
        Me.BtnEdit.onHoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.BtnEdit.onHoverState.BorderRadius = 1
        Me.BtnEdit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnEdit.onHoverState.BorderThickness = 1
        Me.BtnEdit.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnEdit.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.onHoverState.IconLeftImage = Nothing
        Me.BtnEdit.onHoverState.IconRightImage = Nothing
        Me.BtnEdit.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnEdit.OnIdleState.BorderRadius = 1
        Me.BtnEdit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnEdit.OnIdleState.BorderThickness = 1
        Me.BtnEdit.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnEdit.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.OnIdleState.IconLeftImage = Nothing
        Me.BtnEdit.OnIdleState.IconRightImage = Nothing
        Me.BtnEdit.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.BtnEdit.OnPressedState.BorderRadius = 1
        Me.BtnEdit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BtnEdit.OnPressedState.BorderThickness = 1
        Me.BtnEdit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BtnEdit.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.OnPressedState.IconLeftImage = Nothing
        Me.BtnEdit.OnPressedState.IconRightImage = Nothing
        Me.BtnEdit.Size = New System.Drawing.Size(105, 32)
        Me.BtnEdit.TabIndex = 14
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnEdit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BtnEdit.TextMarginLeft = 0
        Me.BtnEdit.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BtnEdit.UseDefaultRadiusAndThickness = True
        '
        'CustIdText
        '
        Me.CustIdText.Location = New System.Drawing.Point(19, 61)
        Me.CustIdText.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CustIdText.Multiline = True
        Me.CustIdText.Name = "CustIdText"
        Me.CustIdText.Size = New System.Drawing.Size(190, 33)
        Me.CustIdText.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 34)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 24)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "CUSTID"
        '
        'PnlUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 706)
        Me.Controls.Add(Me.CustIdText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BunifuButton1)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.PhoneText)
        Me.Controls.Add(Me.EmailText)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.NameText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "PnlUser"
        Me.Text = "PnlUser"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NameText As TextBox
    Friend WithEvents Gender As TextBox
    Friend WithEvents EmailText As TextBox
    Friend WithEvents PhoneText As TextBox
    Friend WithEvents DataGridView As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents BtnDelete As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BtnEdit As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents CustIdText As TextBox
    Friend WithEvents Label5 As Label
End Class
