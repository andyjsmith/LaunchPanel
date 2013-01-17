<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaunchPanel
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
        Me.slideinTimer = New System.Windows.Forms.Timer(Me.components)
        Me.slideoutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.keypressTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.quicklaunchBtn = New System.Windows.Forms.TextBox()
        Me.notesButton = New System.Windows.Forms.PictureBox()
        Me.lite98Button = New System.Windows.Forms.PictureBox()
        Me.homeButton = New System.Windows.Forms.PictureBox()
        Me.closeButton = New System.Windows.Forms.PictureBox()
        Me.settingsIcon = New System.Windows.Forms.PictureBox()
        Me.exitLabel = New System.Windows.Forms.Label()
        CType(Me.notesButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lite98Button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.homeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.settingsIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'slideinTimer
        '
        Me.slideinTimer.Interval = 1
        '
        'slideoutTimer
        '
        Me.slideoutTimer.Interval = 1
        '
        'keypressTimer
        '
        '
        'quicklaunchBtn
        '
        Me.quicklaunchBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.quicklaunchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quicklaunchBtn.Location = New System.Drawing.Point(1626, 362)
        Me.quicklaunchBtn.Name = "quicklaunchBtn"
        Me.quicklaunchBtn.Size = New System.Drawing.Size(282, 26)
        Me.quicklaunchBtn.TabIndex = 7
        Me.quicklaunchBtn.Text = "Quick Launch"
        '
        'notesButton
        '
        Me.notesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.notesButton.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.Notes2
        Me.notesButton.Location = New System.Drawing.Point(264, 12)
        Me.notesButton.Name = "notesButton"
        Me.notesButton.Size = New System.Drawing.Size(120, 40)
        Me.notesButton.TabIndex = 6
        Me.notesButton.TabStop = False
        '
        'lite98Button
        '
        Me.lite98Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lite98Button.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.Radio2
        Me.lite98Button.Location = New System.Drawing.Point(138, 12)
        Me.lite98Button.Name = "lite98Button"
        Me.lite98Button.Size = New System.Drawing.Size(120, 40)
        Me.lite98Button.TabIndex = 5
        Me.lite98Button.TabStop = False
        '
        'homeButton
        '
        Me.homeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.homeButton.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.HomeSelected
        Me.homeButton.Location = New System.Drawing.Point(12, 12)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(120, 40)
        Me.homeButton.TabIndex = 4
        Me.homeButton.TabStop = False
        '
        'closeButton
        '
        Me.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.closeButton.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.Untitled_2
        Me.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.closeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeButton.Location = New System.Drawing.Point(876, 370)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(188, 50)
        Me.closeButton.TabIndex = 2
        Me.closeButton.TabStop = False
        '
        'settingsIcon
        '
        Me.settingsIcon.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.settingsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.settingsIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settingsIcon.Location = New System.Drawing.Point(1880, 0)
        Me.settingsIcon.Name = "settingsIcon"
        Me.settingsIcon.Size = New System.Drawing.Size(40, 40)
        Me.settingsIcon.TabIndex = 0
        Me.settingsIcon.TabStop = False
        '
        'exitLabel
        '
        Me.exitLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.exitLabel.AutoSize = True
        Me.exitLabel.BackColor = System.Drawing.Color.White
        Me.exitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.exitLabel.Location = New System.Drawing.Point(8, 371)
        Me.exitLabel.Name = "exitLabel"
        Me.exitLabel.Size = New System.Drawing.Size(35, 20)
        Me.exitLabel.TabIndex = 8
        Me.exitLabel.Text = "Exit"
        '
        'LaunchPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 400)
        Me.Controls.Add(Me.exitLabel)
        Me.Controls.Add(Me.quicklaunchBtn)
        Me.Controls.Add(Me.notesButton)
        Me.Controls.Add(Me.lite98Button)
        Me.Controls.Add(Me.homeButton)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.settingsIcon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LaunchPanel"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "LaunchPanel"
        Me.TopMost = True
        CType(Me.notesButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lite98Button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.homeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.settingsIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents settingsIcon As System.Windows.Forms.PictureBox
    Friend WithEvents slideinTimer As System.Windows.Forms.Timer
    Friend WithEvents slideoutTimer As System.Windows.Forms.Timer
    Friend WithEvents closeButton As System.Windows.Forms.PictureBox
    Friend WithEvents homeButton As System.Windows.Forms.PictureBox
    Friend WithEvents keypressTimer As System.Windows.Forms.Timer
    Friend WithEvents lite98Button As System.Windows.Forms.PictureBox
    Friend WithEvents notesButton As System.Windows.Forms.PictureBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents quicklaunchBtn As System.Windows.Forms.TextBox
    Friend WithEvents exitLabel As System.Windows.Forms.Label

End Class
