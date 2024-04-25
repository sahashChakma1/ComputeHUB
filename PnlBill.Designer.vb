<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PnlBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PnlBill))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioUpiButton = New System.Windows.Forms.RadioButton()
        Me.RadioCardButton = New System.Windows.Forms.RadioButton()
        Me.RadioCashButton = New System.Windows.Forms.RadioButton()
        Me.DeleteButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.EditButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.DataGridView2 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.PrintButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.TextItem = New System.Windows.Forms.TextBox()
        Me.TextQuantity = New System.Windows.Forms.TextBox()
        Me.TextBrand = New System.Windows.Forms.TextBox()
        Me.TextPrice = New System.Windows.Forms.TextBox()
        Me.TextCustomer = New System.Windows.Forms.TextBox()
        Me.AddButton = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.TextCategory = New System.Windows.Forms.ComboBox()
        Me.ID = New System.Windows.Forms.Label()
        Me.IDText = New System.Windows.Forms.TextBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Back = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 145)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quanity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(311, 86)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(305, 148)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Brand"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowCustomTheming = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.BackColor = System.Drawing.Color.Teal
        Me.DataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal
        Me.DataGridView1.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.Name = Nothing
        Me.DataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridView1.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.DataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DataGridView1.HeaderBackColor = System.Drawing.Color.Teal
        Me.DataGridView1.HeaderBgColor = System.Drawing.Color.Empty
        Me.DataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(16, 253)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(543, 500)
        Me.DataGridView1.TabIndex = 5
        Me.DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 195)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Customer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioUpiButton)
        Me.GroupBox1.Controls.Add(Me.RadioCardButton)
        Me.GroupBox1.Controls.Add(Me.RadioCashButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(662, 31)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(423, 88)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payments"
        '
        'RadioUpiButton
        '
        Me.RadioUpiButton.AutoSize = True
        Me.RadioUpiButton.Location = New System.Drawing.Point(259, 21)
        Me.RadioUpiButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.RadioUpiButton.Name = "RadioUpiButton"
        Me.RadioUpiButton.Size = New System.Drawing.Size(41, 16)
        Me.RadioUpiButton.TabIndex = 2
        Me.RadioUpiButton.TabStop = True
        Me.RadioUpiButton.Text = "UPI"
        Me.RadioUpiButton.UseVisualStyleBackColor = True
        '
        'RadioCardButton
        '
        Me.RadioCardButton.AutoSize = True
        Me.RadioCardButton.Location = New System.Drawing.Point(137, 22)
        Me.RadioCardButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.RadioCardButton.Name = "RadioCardButton"
        Me.RadioCardButton.Size = New System.Drawing.Size(50, 16)
        Me.RadioCardButton.TabIndex = 1
        Me.RadioCardButton.TabStop = True
        Me.RadioCardButton.Text = "Card"
        Me.RadioCardButton.UseVisualStyleBackColor = True
        '
        'RadioCashButton
        '
        Me.RadioCashButton.AutoSize = True
        Me.RadioCashButton.Location = New System.Drawing.Point(9, 21)
        Me.RadioCashButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.RadioCashButton.Name = "RadioCashButton"
        Me.RadioCashButton.Size = New System.Drawing.Size(51, 16)
        Me.RadioCashButton.TabIndex = 0
        Me.RadioCashButton.TabStop = True
        Me.RadioCashButton.Text = "Cash"
        Me.RadioCashButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.AllowAnimations = True
        Me.DeleteButton.AllowMouseEffects = True
        Me.DeleteButton.AllowToggling = False
        Me.DeleteButton.AnimationSpeed = 200
        Me.DeleteButton.AutoGenerateColors = False
        Me.DeleteButton.AutoRoundBorders = False
        Me.DeleteButton.AutoSizeLeftIcon = True
        Me.DeleteButton.AutoSizeRightIcon = True
        Me.DeleteButton.BackColor = System.Drawing.Color.Transparent
        Me.DeleteButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DeleteButton.BackgroundImage = CType(resources.GetObject("DeleteButton.BackgroundImage"), System.Drawing.Image)
        Me.DeleteButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DeleteButton.ButtonText = "Delete"
        Me.DeleteButton.ButtonTextMarginLeft = 0
        Me.DeleteButton.ColorContrastOnClick = 45
        Me.DeleteButton.ColorContrastOnHover = 45
        Me.DeleteButton.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.DeleteButton.CustomizableEdges = BorderEdges1
        Me.DeleteButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.DeleteButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DeleteButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.DeleteButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.DeleteButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.DeleteButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.DeleteButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.DeleteButton.IconMarginLeft = 11
        Me.DeleteButton.IconPadding = 10
        Me.DeleteButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeleteButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.DeleteButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.DeleteButton.IconSize = 25
        Me.DeleteButton.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DeleteButton.IdleBorderRadius = 1
        Me.DeleteButton.IdleBorderThickness = 1
        Me.DeleteButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DeleteButton.IdleIconLeftImage = Nothing
        Me.DeleteButton.IdleIconRightImage = Nothing
        Me.DeleteButton.IndicateFocus = False
        Me.DeleteButton.Location = New System.Drawing.Point(512, 195)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DeleteButton.OnDisabledState.BorderRadius = 1
        Me.DeleteButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DeleteButton.OnDisabledState.BorderThickness = 1
        Me.DeleteButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.DeleteButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.DeleteButton.OnDisabledState.IconLeftImage = Nothing
        Me.DeleteButton.OnDisabledState.IconRightImage = Nothing
        Me.DeleteButton.onHoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.DeleteButton.onHoverState.BorderRadius = 1
        Me.DeleteButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DeleteButton.onHoverState.BorderThickness = 1
        Me.DeleteButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DeleteButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.onHoverState.IconLeftImage = Nothing
        Me.DeleteButton.onHoverState.IconRightImage = Nothing
        Me.DeleteButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DeleteButton.OnIdleState.BorderRadius = 1
        Me.DeleteButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DeleteButton.OnIdleState.BorderThickness = 1
        Me.DeleteButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DeleteButton.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.OnIdleState.IconLeftImage = Nothing
        Me.DeleteButton.OnIdleState.IconRightImage = Nothing
        Me.DeleteButton.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.DeleteButton.OnPressedState.BorderRadius = 1
        Me.DeleteButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.DeleteButton.OnPressedState.BorderThickness = 1
        Me.DeleteButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DeleteButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.OnPressedState.IconLeftImage = Nothing
        Me.DeleteButton.OnPressedState.IconRightImage = Nothing
        Me.DeleteButton.Size = New System.Drawing.Size(95, 31)
        Me.DeleteButton.TabIndex = 16
        Me.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DeleteButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DeleteButton.TextMarginLeft = 0
        Me.DeleteButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.DeleteButton.UseDefaultRadiusAndThickness = True
        '
        'EditButton
        '
        Me.EditButton.AllowAnimations = True
        Me.EditButton.AllowMouseEffects = True
        Me.EditButton.AllowToggling = False
        Me.EditButton.AnimationSpeed = 200
        Me.EditButton.AutoGenerateColors = False
        Me.EditButton.AutoRoundBorders = False
        Me.EditButton.AutoSizeLeftIcon = True
        Me.EditButton.AutoSizeRightIcon = True
        Me.EditButton.BackColor = System.Drawing.Color.Transparent
        Me.EditButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.EditButton.BackgroundImage = CType(resources.GetObject("EditButton.BackgroundImage"), System.Drawing.Image)
        Me.EditButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.EditButton.ButtonText = "Edit"
        Me.EditButton.ButtonTextMarginLeft = 0
        Me.EditButton.ColorContrastOnClick = 45
        Me.EditButton.ColorContrastOnHover = 45
        Me.EditButton.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.EditButton.CustomizableEdges = BorderEdges2
        Me.EditButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.EditButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.EditButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.EditButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.EditButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.EditButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.ForeColor = System.Drawing.Color.White
        Me.EditButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.EditButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.EditButton.IconMarginLeft = 11
        Me.EditButton.IconPadding = 10
        Me.EditButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EditButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.EditButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.EditButton.IconSize = 25
        Me.EditButton.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.EditButton.IdleBorderRadius = 1
        Me.EditButton.IdleBorderThickness = 1
        Me.EditButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.EditButton.IdleIconLeftImage = Nothing
        Me.EditButton.IdleIconRightImage = Nothing
        Me.EditButton.IndicateFocus = False
        Me.EditButton.Location = New System.Drawing.Point(314, 195)
        Me.EditButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.EditButton.OnDisabledState.BorderRadius = 1
        Me.EditButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.EditButton.OnDisabledState.BorderThickness = 1
        Me.EditButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.EditButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.EditButton.OnDisabledState.IconLeftImage = Nothing
        Me.EditButton.OnDisabledState.IconRightImage = Nothing
        Me.EditButton.onHoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.EditButton.onHoverState.BorderRadius = 1
        Me.EditButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.EditButton.onHoverState.BorderThickness = 1
        Me.EditButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EditButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.EditButton.onHoverState.IconLeftImage = Nothing
        Me.EditButton.onHoverState.IconRightImage = Nothing
        Me.EditButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.EditButton.OnIdleState.BorderRadius = 1
        Me.EditButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.EditButton.OnIdleState.BorderThickness = 1
        Me.EditButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.EditButton.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.EditButton.OnIdleState.IconLeftImage = Nothing
        Me.EditButton.OnIdleState.IconRightImage = Nothing
        Me.EditButton.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.EditButton.OnPressedState.BorderRadius = 1
        Me.EditButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.EditButton.OnPressedState.BorderThickness = 1
        Me.EditButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.EditButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.EditButton.OnPressedState.IconLeftImage = Nothing
        Me.EditButton.OnPressedState.IconRightImage = Nothing
        Me.EditButton.Size = New System.Drawing.Size(90, 31)
        Me.EditButton.TabIndex = 14
        Me.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.EditButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.EditButton.TextMarginLeft = 0
        Me.EditButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.EditButton.UseDefaultRadiusAndThickness = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowCustomTheming = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.ColumnHeadersHeight = 40
        Me.DataGridView2.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.DataGridView2.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView2.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.DataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView2.CurrentTheme.BackColor = System.Drawing.Color.Teal
        Me.DataGridView2.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DataGridView2.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal
        Me.DataGridView2.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView2.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView2.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DataGridView2.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView2.CurrentTheme.Name = Nothing
        Me.DataGridView2.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridView2.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView2.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView2.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.DataGridView2.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DataGridView2.HeaderBackColor = System.Drawing.Color.Teal
        Me.DataGridView2.HeaderBgColor = System.Drawing.Color.Empty
        Me.DataGridView2.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView2.Location = New System.Drawing.Point(626, 127)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowTemplate.Height = 40
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(510, 495)
        Me.DataGridView2.TabIndex = 17
        Me.DataGridView2.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal
        '
        'PrintButton
        '
        Me.PrintButton.AllowAnimations = True
        Me.PrintButton.AllowMouseEffects = True
        Me.PrintButton.AllowToggling = False
        Me.PrintButton.AnimationSpeed = 200
        Me.PrintButton.AutoGenerateColors = False
        Me.PrintButton.AutoRoundBorders = False
        Me.PrintButton.AutoSizeLeftIcon = True
        Me.PrintButton.AutoSizeRightIcon = True
        Me.PrintButton.BackColor = System.Drawing.Color.Transparent
        Me.PrintButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.PrintButton.BackgroundImage = CType(resources.GetObject("PrintButton.BackgroundImage"), System.Drawing.Image)
        Me.PrintButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.PrintButton.ButtonText = "Print"
        Me.PrintButton.ButtonTextMarginLeft = 0
        Me.PrintButton.ColorContrastOnClick = 45
        Me.PrintButton.ColorContrastOnHover = 45
        Me.PrintButton.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.PrintButton.CustomizableEdges = BorderEdges3
        Me.PrintButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.PrintButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.PrintButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PrintButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.PrintButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.PrintButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintButton.ForeColor = System.Drawing.Color.White
        Me.PrintButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PrintButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.PrintButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.PrintButton.IconMarginLeft = 11
        Me.PrintButton.IconPadding = 10
        Me.PrintButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PrintButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.PrintButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.PrintButton.IconSize = 25
        Me.PrintButton.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.PrintButton.IdleBorderRadius = 1
        Me.PrintButton.IdleBorderThickness = 1
        Me.PrintButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.PrintButton.IdleIconLeftImage = Nothing
        Me.PrintButton.IdleIconRightImage = Nothing
        Me.PrintButton.IndicateFocus = False
        Me.PrintButton.Location = New System.Drawing.Point(820, 653)
        Me.PrintButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.PrintButton.OnDisabledState.BorderRadius = 1
        Me.PrintButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.PrintButton.OnDisabledState.BorderThickness = 1
        Me.PrintButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PrintButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.PrintButton.OnDisabledState.IconLeftImage = Nothing
        Me.PrintButton.OnDisabledState.IconRightImage = Nothing
        Me.PrintButton.onHoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.PrintButton.onHoverState.BorderRadius = 1
        Me.PrintButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.PrintButton.onHoverState.BorderThickness = 1
        Me.PrintButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PrintButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.PrintButton.onHoverState.IconLeftImage = Nothing
        Me.PrintButton.onHoverState.IconRightImage = Nothing
        Me.PrintButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.PrintButton.OnIdleState.BorderRadius = 1
        Me.PrintButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.PrintButton.OnIdleState.BorderThickness = 1
        Me.PrintButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.PrintButton.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.PrintButton.OnIdleState.IconLeftImage = Nothing
        Me.PrintButton.OnIdleState.IconRightImage = Nothing
        Me.PrintButton.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.PrintButton.OnPressedState.BorderRadius = 1
        Me.PrintButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.PrintButton.OnPressedState.BorderThickness = 1
        Me.PrintButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.PrintButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.PrintButton.OnPressedState.IconLeftImage = Nothing
        Me.PrintButton.OnPressedState.IconRightImage = Nothing
        Me.PrintButton.Size = New System.Drawing.Size(115, 35)
        Me.PrintButton.TabIndex = 18
        Me.PrintButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.PrintButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.PrintButton.TextMarginLeft = 0
        Me.PrintButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.PrintButton.UseDefaultRadiusAndThickness = True
        '
        'TextItem
        '
        Me.TextItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextItem.Location = New System.Drawing.Point(381, 31)
        Me.TextItem.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextItem.Multiline = True
        Me.TextItem.Name = "TextItem"
        Me.TextItem.Size = New System.Drawing.Size(207, 26)
        Me.TextItem.TabIndex = 19
        '
        'TextQuantity
        '
        Me.TextQuantity.Location = New System.Drawing.Point(101, 138)
        Me.TextQuantity.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextQuantity.Multiline = True
        Me.TextQuantity.Name = "TextQuantity"
        Me.TextQuantity.Size = New System.Drawing.Size(185, 31)
        Me.TextQuantity.TabIndex = 20
        '
        'TextBrand
        '
        Me.TextBrand.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBrand.Location = New System.Drawing.Point(381, 138)
        Me.TextBrand.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBrand.Multiline = True
        Me.TextBrand.Name = "TextBrand"
        Me.TextBrand.Size = New System.Drawing.Size(207, 31)
        Me.TextBrand.TabIndex = 21
        '
        'TextPrice
        '
        Me.TextPrice.Location = New System.Drawing.Point(377, 79)
        Me.TextPrice.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextPrice.Multiline = True
        Me.TextPrice.Name = "TextPrice"
        Me.TextPrice.Size = New System.Drawing.Size(211, 27)
        Me.TextPrice.TabIndex = 23
        '
        'TextCustomer
        '
        Me.TextCustomer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCustomer.Location = New System.Drawing.Point(95, 195)
        Me.TextCustomer.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextCustomer.Multiline = True
        Me.TextCustomer.Name = "TextCustomer"
        Me.TextCustomer.Size = New System.Drawing.Size(187, 39)
        Me.TextCustomer.TabIndex = 24
        '
        'AddButton
        '
        Me.AddButton.AllowAnimations = True
        Me.AddButton.AllowMouseEffects = True
        Me.AddButton.AllowToggling = False
        Me.AddButton.AnimationSpeed = 200
        Me.AddButton.AutoGenerateColors = False
        Me.AddButton.AutoRoundBorders = False
        Me.AddButton.AutoSizeLeftIcon = True
        Me.AddButton.AutoSizeRightIcon = True
        Me.AddButton.BackColor = System.Drawing.Color.Transparent
        Me.AddButton.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.AddButton.BackgroundImage = CType(resources.GetObject("AddButton.BackgroundImage"), System.Drawing.Image)
        Me.AddButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddButton.ButtonText = "Add"
        Me.AddButton.ButtonTextMarginLeft = 0
        Me.AddButton.ColorContrastOnClick = 45
        Me.AddButton.ColorContrastOnHover = 45
        Me.AddButton.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.AddButton.CustomizableEdges = BorderEdges4
        Me.AddButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.AddButton.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.AddButton.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.AddButton.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.AddButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.AddButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.White
        Me.AddButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddButton.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.AddButton.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.AddButton.IconMarginLeft = 11
        Me.AddButton.IconPadding = 10
        Me.AddButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddButton.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.AddButton.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.AddButton.IconSize = 25
        Me.AddButton.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.AddButton.IdleBorderRadius = 1
        Me.AddButton.IdleBorderThickness = 1
        Me.AddButton.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.AddButton.IdleIconLeftImage = Nothing
        Me.AddButton.IdleIconRightImage = Nothing
        Me.AddButton.IndicateFocus = False
        Me.AddButton.Location = New System.Drawing.Point(411, 195)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.AddButton.OnDisabledState.BorderRadius = 1
        Me.AddButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddButton.OnDisabledState.BorderThickness = 1
        Me.AddButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.AddButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.AddButton.OnDisabledState.IconLeftImage = Nothing
        Me.AddButton.OnDisabledState.IconRightImage = Nothing
        Me.AddButton.onHoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.AddButton.onHoverState.BorderRadius = 1
        Me.AddButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddButton.onHoverState.BorderThickness = 1
        Me.AddButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddButton.onHoverState.ForeColor = System.Drawing.Color.White
        Me.AddButton.onHoverState.IconLeftImage = Nothing
        Me.AddButton.onHoverState.IconRightImage = Nothing
        Me.AddButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.AddButton.OnIdleState.BorderRadius = 1
        Me.AddButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddButton.OnIdleState.BorderThickness = 1
        Me.AddButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.AddButton.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.AddButton.OnIdleState.IconLeftImage = Nothing
        Me.AddButton.OnIdleState.IconRightImage = Nothing
        Me.AddButton.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.AddButton.OnPressedState.BorderRadius = 1
        Me.AddButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.AddButton.OnPressedState.BorderThickness = 1
        Me.AddButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.AddButton.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.AddButton.OnPressedState.IconLeftImage = Nothing
        Me.AddButton.OnPressedState.IconRightImage = Nothing
        Me.AddButton.Size = New System.Drawing.Size(91, 31)
        Me.AddButton.TabIndex = 25
        Me.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AddButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.AddButton.TextMarginLeft = 0
        Me.AddButton.TextPadding = New System.Windows.Forms.Padding(0)
        Me.AddButton.UseDefaultRadiusAndThickness = True
        '
        'TextCategory
        '
        Me.TextCategory.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCategory.FormattingEnabled = True
        Me.TextCategory.ItemHeight = 17
        Me.TextCategory.Items.AddRange(New Object() {"Processors (CPUs)", "Graphics Cards (GPUs)", "Motherboards", "Memory (RAM)", "Storage Drives", "Power Supplies (PSUs)", "Computer Cases", "Cooling Solutions", "Peripherals", "Networking Equipment", "Accessories", "Software"})
        Me.TextCategory.Location = New System.Drawing.Point(95, 79)
        Me.TextCategory.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextCategory.Name = "TextCategory"
        Me.TextCategory.Size = New System.Drawing.Size(190, 25)
        Me.TextCategory.TabIndex = 26
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(59, 31)
        Me.ID.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(25, 18)
        Me.ID.TabIndex = 27
        Me.ID.Text = "ID"
        '
        'IDText
        '
        Me.IDText.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDText.Location = New System.Drawing.Point(97, 31)
        Me.IDText.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.IDText.Multiline = True
        Me.IDText.Name = "IDText"
        Me.IDText.Size = New System.Drawing.Size(188, 27)
        Me.IDText.TabIndex = 28
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Back
        '
        Me.Back.AllowAnimations = True
        Me.Back.AllowMouseEffects = True
        Me.Back.AllowToggling = False
        Me.Back.AnimationSpeed = 200
        Me.Back.AutoGenerateColors = False
        Me.Back.AutoRoundBorders = False
        Me.Back.AutoSizeLeftIcon = True
        Me.Back.AutoSizeRightIcon = True
        Me.Back.BackColor = System.Drawing.Color.Transparent
        Me.Back.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Back.BackgroundImage = CType(resources.GetObject("Back.BackgroundImage"), System.Drawing.Image)
        Me.Back.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Back.ButtonText = "<-"
        Me.Back.ButtonTextMarginLeft = 0
        Me.Back.ColorContrastOnClick = 45
        Me.Back.ColorContrastOnHover = 45
        Me.Back.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges5.BottomLeft = True
        BorderEdges5.BottomRight = True
        BorderEdges5.TopLeft = True
        BorderEdges5.TopRight = True
        Me.Back.CustomizableEdges = BorderEdges5
        Me.Back.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Back.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Back.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Back.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Back.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.Back.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.ForeColor = System.Drawing.Color.White
        Me.Back.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Back.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.Back.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.Back.IconMarginLeft = 11
        Me.Back.IconPadding = 10
        Me.Back.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Back.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.Back.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.Back.IconSize = 25
        Me.Back.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Back.IdleBorderRadius = 1
        Me.Back.IdleBorderThickness = 1
        Me.Back.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Back.IdleIconLeftImage = Nothing
        Me.Back.IdleIconRightImage = Nothing
        Me.Back.IndicateFocus = False
        Me.Back.Location = New System.Drawing.Point(569, 234)
        Me.Back.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Back.Name = "Back"
        Me.Back.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Back.OnDisabledState.BorderRadius = 1
        Me.Back.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Back.OnDisabledState.BorderThickness = 1
        Me.Back.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Back.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Back.OnDisabledState.IconLeftImage = Nothing
        Me.Back.OnDisabledState.IconRightImage = Nothing
        Me.Back.onHoverState.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Back.onHoverState.BorderRadius = 1
        Me.Back.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Back.onHoverState.BorderThickness = 1
        Me.Back.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Back.onHoverState.ForeColor = System.Drawing.Color.White
        Me.Back.onHoverState.IconLeftImage = Nothing
        Me.Back.onHoverState.IconRightImage = Nothing
        Me.Back.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Back.OnIdleState.BorderRadius = 1
        Me.Back.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Back.OnIdleState.BorderThickness = 1
        Me.Back.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Back.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.Back.OnIdleState.IconLeftImage = Nothing
        Me.Back.OnIdleState.IconRightImage = Nothing
        Me.Back.OnPressedState.BorderColor = System.Drawing.Color.Transparent
        Me.Back.OnPressedState.BorderRadius = 1
        Me.Back.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.Back.OnPressedState.BorderThickness = 1
        Me.Back.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Back.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.Back.OnPressedState.IconLeftImage = Nothing
        Me.Back.OnPressedState.IconRightImage = Nothing
        Me.Back.Size = New System.Drawing.Size(45, 31)
        Me.Back.TabIndex = 29
        Me.Back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Back.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Back.TextMarginLeft = 0
        Me.Back.TextPadding = New System.Windows.Forms.Padding(0)
        Me.Back.UseDefaultRadiusAndThickness = True
        '
        'PnlBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 821)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.IDText)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.TextCategory)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.TextCustomer)
        Me.Controls.Add(Me.TextPrice)
        Me.Controls.Add(Me.TextBrand)
        Me.Controls.Add(Me.TextQuantity)
        Me.Controls.Add(Me.TextItem)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PrintButton)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "PnlBill"
        Me.Text = "PnlBill"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioUpiButton As RadioButton
    Friend WithEvents RadioCardButton As RadioButton
    Friend WithEvents RadioCashButton As RadioButton
    Friend WithEvents DeleteButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents EditButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents DataGridView2 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents PrintButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents TextItem As TextBox
    Friend WithEvents TextQuantity As TextBox
    Friend WithEvents TextBrand As TextBox
    Friend WithEvents TextPrice As TextBox
    Friend WithEvents TextCustomer As TextBox
    Friend WithEvents AddButton As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents TextCategory As ComboBox
    Friend WithEvents ID As Label
    Friend WithEvents IDText As TextBox
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Back As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class
