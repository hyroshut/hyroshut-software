<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.shutdownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LogInButton1 = New Hyroshut.LogInButton()
        Me.LogInGroupBox1 = New Hyroshut.LogInGroupBox()
        Me.LogInRadioButton2 = New Hyroshut.LogInRadioButton()
        Me.LogInRadioButton1 = New Hyroshut.LogInRadioButton()
        Me.LogInButtonWithProgress1 = New Hyroshut.LogInButtonWithProgress()
        Me.LogInGroupBox2 = New Hyroshut.LogInGroupBox()
        Me.LogInSeperator2 = New Hyroshut.LogInSeperator()
        Me.LogInSeperator1 = New Hyroshut.LogInSeperator()
        Me.LogInLabel3 = New Hyroshut.LogInLabel()
        Me.LogInLabel2 = New Hyroshut.LogInLabel()
        Me.LogInLabel1 = New Hyroshut.LogInLabel()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogInGroupBox1.SuspendLayout()
        Me.LogInGroupBox2.SuspendLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'shutdownTimer
        '
        Me.shutdownTimer.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hyroshut.My.Resources.Resources.hyroshut_coplete_banner
        Me.PictureBox1.Location = New System.Drawing.Point(94, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(477, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'LogInButton1
        '
        Me.LogInButton1.BackColor = System.Drawing.Color.Transparent
        Me.LogInButton1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButton1.Location = New System.Drawing.Point(620, 9)
        Me.LogInButton1.Name = "LogInButton1"
        Me.LogInButton1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButton1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButton1.Size = New System.Drawing.Size(32, 27)
        Me.LogInButton1.TabIndex = 6
        Me.LogInButton1.Text = "۞"
        '
        'LogInGroupBox1
        '
        Me.LogInGroupBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInGroupBox1.Controls.Add(Me.LogInRadioButton2)
        Me.LogInGroupBox1.Controls.Add(Me.LogInRadioButton1)
        Me.LogInGroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInGroupBox1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInGroupBox1.Location = New System.Drawing.Point(94, 104)
        Me.LogInGroupBox1.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInGroupBox1.Name = "LogInGroupBox1"
        Me.LogInGroupBox1.Size = New System.Drawing.Size(477, 110)
        Me.LogInGroupBox1.TabIndex = 3
        Me.LogInGroupBox1.Text = "Que faire ?"
        Me.LogInGroupBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LogInRadioButton2
        '
        Me.LogInRadioButton2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInRadioButton2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadioButton2.Checked = False
        Me.LogInRadioButton2.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LogInRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInRadioButton2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInRadioButton2.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LogInRadioButton2.Location = New System.Drawing.Point(255, 58)
        Me.LogInRadioButton2.Name = "LogInRadioButton2"
        Me.LogInRadioButton2.Size = New System.Drawing.Size(106, 22)
        Me.LogInRadioButton2.TabIndex = 0
        Me.LogInRadioButton2.Text = "Redémarrer"
        '
        'LogInRadioButton1
        '
        Me.LogInRadioButton1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInRadioButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInRadioButton1.Checked = False
        Me.LogInRadioButton1.CheckedColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LogInRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogInRadioButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInRadioButton1.HighlightColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.LogInRadioButton1.Location = New System.Drawing.Point(115, 58)
        Me.LogInRadioButton1.Name = "LogInRadioButton1"
        Me.LogInRadioButton1.Size = New System.Drawing.Size(84, 22)
        Me.LogInRadioButton1.TabIndex = 0
        Me.LogInRadioButton1.Text = "Eteindre"
        '
        'LogInButtonWithProgress1
        '
        Me.LogInButtonWithProgress1.BackColor = System.Drawing.Color.Transparent
        Me.LogInButtonWithProgress1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInButtonWithProgress1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.LogInButtonWithProgress1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInButtonWithProgress1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.LogInButtonWithProgress1.Location = New System.Drawing.Point(94, 379)
        Me.LogInButtonWithProgress1.Maximum = 0
        Me.LogInButtonWithProgress1.Name = "LogInButtonWithProgress1"
        Me.LogInButtonWithProgress1.PressedColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInButtonWithProgress1.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.LogInButtonWithProgress1.Size = New System.Drawing.Size(477, 68)
        Me.LogInButtonWithProgress1.TabIndex = 2
        Me.LogInButtonWithProgress1.Text = "Demarrer"
        Me.LogInButtonWithProgress1.Value = 0
        '
        'LogInGroupBox2
        '
        Me.LogInGroupBox2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInGroupBox2.Controls.Add(Me.LogInSeperator2)
        Me.LogInGroupBox2.Controls.Add(Me.LogInSeperator1)
        Me.LogInGroupBox2.Controls.Add(Me.LogInLabel3)
        Me.LogInGroupBox2.Controls.Add(Me.LogInLabel2)
        Me.LogInGroupBox2.Controls.Add(Me.LogInLabel1)
        Me.LogInGroupBox2.Controls.Add(Me.NumericUpDown3)
        Me.LogInGroupBox2.Controls.Add(Me.NumericUpDown2)
        Me.LogInGroupBox2.Controls.Add(Me.NumericUpDown1)
        Me.LogInGroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LogInGroupBox2.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LogInGroupBox2.Location = New System.Drawing.Point(94, 242)
        Me.LogInGroupBox2.MainColour = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.LogInGroupBox2.Name = "LogInGroupBox2"
        Me.LogInGroupBox2.Size = New System.Drawing.Size(477, 108)
        Me.LogInGroupBox2.TabIndex = 4
        Me.LogInGroupBox2.Text = "Dans combiens de temps ?"
        Me.LogInGroupBox2.TextColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'LogInSeperator2
        '
        Me.LogInSeperator2.Alignment = Hyroshut.LogInSeperator.Style.Verticle
        Me.LogInSeperator2.BackColor = System.Drawing.Color.Transparent
        Me.LogInSeperator2.Location = New System.Drawing.Point(294, 27)
        Me.LogInSeperator2.Name = "LogInSeperator2"
        Me.LogInSeperator2.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInSeperator2.Size = New System.Drawing.Size(58, 81)
        Me.LogInSeperator2.TabIndex = 2
        Me.LogInSeperator2.Text = "LogInSeperator1"
        Me.LogInSeperator2.Thickness = 1.0!
        '
        'LogInSeperator1
        '
        Me.LogInSeperator1.Alignment = Hyroshut.LogInSeperator.Style.Verticle
        Me.LogInSeperator1.BackColor = System.Drawing.Color.Transparent
        Me.LogInSeperator1.Location = New System.Drawing.Point(128, 27)
        Me.LogInSeperator1.Name = "LogInSeperator1"
        Me.LogInSeperator1.SeperatorColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LogInSeperator1.Size = New System.Drawing.Size(63, 81)
        Me.LogInSeperator1.TabIndex = 2
        Me.LogInSeperator1.Text = "LogInSeperator1"
        Me.LogInSeperator1.Thickness = 1.0!
        '
        'LogInLabel3
        '
        Me.LogInLabel3.AutoSize = True
        Me.LogInLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel3.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel3.Location = New System.Drawing.Point(355, 49)
        Me.LogInLabel3.Name = "LogInLabel3"
        Me.LogInLabel3.Size = New System.Drawing.Size(50, 15)
        Me.LogInLabel3.TabIndex = 1
        Me.LogInLabel3.Text = "Minutes"
        '
        'LogInLabel2
        '
        Me.LogInLabel2.AutoSize = True
        Me.LogInLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel2.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel2.Location = New System.Drawing.Point(194, 49)
        Me.LogInLabel2.Name = "LogInLabel2"
        Me.LogInLabel2.Size = New System.Drawing.Size(44, 15)
        Me.LogInLabel2.TabIndex = 1
        Me.LogInLabel2.Text = "Heures"
        '
        'LogInLabel1
        '
        Me.LogInLabel1.AutoSize = True
        Me.LogInLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LogInLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LogInLabel1.FontColour = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LogInLabel1.Location = New System.Drawing.Point(28, 49)
        Me.LogInLabel1.Name = "LogInLabel1"
        Me.LogInLabel1.Size = New System.Drawing.Size(34, 15)
        Me.LogInLabel1.TabIndex = 1
        Me.LogInLabel1.Text = "Jours"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.NumericUpDown3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown3.ForeColor = System.Drawing.SystemColors.Info
        Me.NumericUpDown3.Location = New System.Drawing.Point(358, 66)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(91, 25)
        Me.NumericUpDown3.TabIndex = 7
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.NumericUpDown2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.ForeColor = System.Drawing.SystemColors.Info
        Me.NumericUpDown2.Location = New System.Drawing.Point(197, 67)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(91, 25)
        Me.NumericUpDown2.TabIndex = 7
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.NumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.ForeColor = System.Drawing.SystemColors.Info
        Me.NumericUpDown1.Location = New System.Drawing.Point(31, 66)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(91, 25)
        Me.NumericUpDown1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(664, 464)
        Me.Controls.Add(Me.LogInButton1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LogInGroupBox1)
        Me.Controls.Add(Me.LogInButtonWithProgress1)
        Me.Controls.Add(Me.LogInGroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(126, 39)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HyroShut"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogInGroupBox1.ResumeLayout(False)
        Me.LogInGroupBox2.ResumeLayout(False)
        Me.LogInGroupBox2.PerformLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LogInLabel1 As Hyroshut.LogInLabel
    Friend WithEvents LogInLabel2 As Hyroshut.LogInLabel
    Friend WithEvents LogInLabel3 As Hyroshut.LogInLabel
    Friend WithEvents LogInButtonWithProgress1 As Hyroshut.LogInButtonWithProgress
    Friend WithEvents LogInGroupBox1 As Hyroshut.LogInGroupBox
    Friend WithEvents LogInRadioButton1 As Hyroshut.LogInRadioButton
    Friend WithEvents LogInRadioButton2 As Hyroshut.LogInRadioButton
    Friend WithEvents LogInGroupBox2 As Hyroshut.LogInGroupBox
    Friend WithEvents shutdownTimer As System.Windows.Forms.Timer
    Friend WithEvents LogInSeperator2 As Hyroshut.LogInSeperator
    Friend WithEvents LogInSeperator1 As Hyroshut.LogInSeperator
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LogInButton1 As Hyroshut.LogInButton
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown

End Class
