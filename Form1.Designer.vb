<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuGradientPanel1 = New Bunifu.UI.WinForms.BunifuGradientPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelReportProgress = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBarLoading1 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderRadius = 0
        Me.BunifuGradientPanel1.Controls.Add(Me.Label2)
        Me.BunifuGradientPanel1.Controls.Add(Me.Panel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(918, 450)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.Label2.Location = New System.Drawing.Point(24, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 88)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BY " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SAHASH CHAKMA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VI BCA 'B'" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "22BCAB56" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LabelReportProgress)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ProgressBarLoading1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(450, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 450)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(429, 263)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'LabelReportProgress
        '
        Me.LabelReportProgress.AutoSize = True
        Me.LabelReportProgress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReportProgress.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.LabelReportProgress.Location = New System.Drawing.Point(396, 367)
        Me.LabelReportProgress.Name = "LabelReportProgress"
        Me.LabelReportProgress.Size = New System.Drawing.Size(52, 18)
        Me.LabelReportProgress.TabIndex = 4
        Me.LabelReportProgress.Text = "000%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label4.Location = New System.Drawing.Point(22, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Launching...."
        '
        'ProgressBarLoading1
        '
        Me.ProgressBarLoading1.BackColor = System.Drawing.Color.White
        Me.ProgressBarLoading1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProgressBarLoading1.Location = New System.Drawing.Point(26, 346)
        Me.ProgressBarLoading1.Name = "ProgressBarLoading1"
        Me.ProgressBarLoading1.Size = New System.Drawing.Size(419, 18)
        Me.ProgressBarLoading1.Step = 20
        Me.ProgressBarLoading1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBarLoading1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 381)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 80)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COMPUTER SHOP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MANAGEMENT SYSTEM"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 30
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 16
        Me.Guna2Elipse1.TargetControl = Me.ProgressBarLoading1
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.BorderRadius = 25
        Me.Guna2Elipse2.TargetControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(918, 450)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuGradientPanel1 As Bunifu.UI.WinForms.BunifuGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelReportProgress As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProgressBarLoading1 As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
End Class
