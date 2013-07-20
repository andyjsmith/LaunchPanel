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
        Me.quicklaunchBtn = New System.Windows.Forms.TextBox()
        Me.exitLabel = New System.Windows.Forms.Label()
        Me.numbergeneratorBtn = New System.Windows.Forms.PictureBox()
        Me.extlookupBtn = New System.Windows.Forms.PictureBox()
        Me.toolproBtn = New System.Windows.Forms.PictureBox()
        Me.blcBtn = New System.Windows.Forms.PictureBox()
        Me.namesuggesterBtn = New System.Windows.Forms.PictureBox()
        Me.YouWidgetBtn = New System.Windows.Forms.PictureBox()
        Me.todoButton = New System.Windows.Forms.PictureBox()
        Me.tasksButton = New System.Windows.Forms.PictureBox()
        Me.webButton = New System.Windows.Forms.PictureBox()
        Me.notesButton = New System.Windows.Forms.PictureBox()
        Me.lite98Button = New System.Windows.Forms.PictureBox()
        Me.homeButton = New System.Windows.Forms.PictureBox()
        Me.closeButton = New System.Windows.Forms.PictureBox()
        Me.settingsIcon = New System.Windows.Forms.PictureBox()
        Me.timeLbl = New System.Windows.Forms.Label()
        Me.dateLbl = New System.Windows.Forms.Label()
        Me.dowLbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.numbergeneratorBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.extlookupBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toolproBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blcBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.namesuggesterBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YouWidgetBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.todoButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tasksButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.webButton, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.quicklaunchBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quicklaunchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quicklaunchBtn.Location = New System.Drawing.Point(1626, 362)
        Me.quicklaunchBtn.Name = "quicklaunchBtn"
        Me.quicklaunchBtn.Size = New System.Drawing.Size(282, 26)
        Me.quicklaunchBtn.TabIndex = 7
        Me.quicklaunchBtn.Text = "Quick Launch"
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
        'numbergeneratorBtn
        '
        Me.numbergeneratorBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.numbergeneratorBtn.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.randomnumber
        Me.numbergeneratorBtn.Location = New System.Drawing.Point(801, 132)
        Me.numbergeneratorBtn.Name = "numbergeneratorBtn"
        Me.numbergeneratorBtn.Size = New System.Drawing.Size(140, 140)
        Me.numbergeneratorBtn.TabIndex = 17
        Me.numbergeneratorBtn.TabStop = False
        '
        'extlookupBtn
        '
        Me.extlookupBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.extlookupBtn.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.extlookup
        Me.extlookupBtn.Location = New System.Drawing.Point(654, 132)
        Me.extlookupBtn.Name = "extlookupBtn"
        Me.extlookupBtn.Size = New System.Drawing.Size(140, 140)
        Me.extlookupBtn.TabIndex = 16
        Me.extlookupBtn.TabStop = False
        '
        'toolproBtn
        '
        Me.toolproBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.toolproBtn.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.ToolPro
        Me.toolproBtn.Location = New System.Drawing.Point(507, 132)
        Me.toolproBtn.Name = "toolproBtn"
        Me.toolproBtn.Size = New System.Drawing.Size(140, 140)
        Me.toolproBtn.TabIndex = 15
        Me.toolproBtn.TabStop = False
        '
        'blcBtn
        '
        Me.blcBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.blcBtn.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.blc
        Me.blcBtn.Location = New System.Drawing.Point(360, 132)
        Me.blcBtn.Name = "blcBtn"
        Me.blcBtn.Size = New System.Drawing.Size(140, 140)
        Me.blcBtn.TabIndex = 14
        Me.blcBtn.TabStop = False
        '
        'namesuggesterBtn
        '
        Me.namesuggesterBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.namesuggesterBtn.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.namer1
        Me.namesuggesterBtn.Location = New System.Drawing.Point(213, 132)
        Me.namesuggesterBtn.Name = "namesuggesterBtn"
        Me.namesuggesterBtn.Size = New System.Drawing.Size(140, 140)
        Me.namesuggesterBtn.TabIndex = 13
        Me.namesuggesterBtn.TabStop = False
        '
        'YouWidgetBtn
        '
        Me.YouWidgetBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.YouWidgetBtn.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.YouWidgetSMALL1
        Me.YouWidgetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.YouWidgetBtn.Location = New System.Drawing.Point(67, 132)
        Me.YouWidgetBtn.Name = "YouWidgetBtn"
        Me.YouWidgetBtn.Size = New System.Drawing.Size(140, 140)
        Me.YouWidgetBtn.TabIndex = 12
        Me.YouWidgetBtn.TabStop = False
        '
        'todoButton
        '
        Me.todoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.todoButton.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.todo2
        Me.todoButton.Location = New System.Drawing.Point(643, 12)
        Me.todoButton.Name = "todoButton"
        Me.todoButton.Size = New System.Drawing.Size(120, 40)
        Me.todoButton.TabIndex = 11
        Me.todoButton.TabStop = False
        '
        'tasksButton
        '
        Me.tasksButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tasksButton.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.tasks2
        Me.tasksButton.Location = New System.Drawing.Point(516, 12)
        Me.tasksButton.Name = "tasksButton"
        Me.tasksButton.Size = New System.Drawing.Size(120, 40)
        Me.tasksButton.TabIndex = 10
        Me.tasksButton.TabStop = False
        '
        'webButton
        '
        Me.webButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.webButton.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.Web2
        Me.webButton.Location = New System.Drawing.Point(390, 12)
        Me.webButton.Name = "webButton"
        Me.webButton.Size = New System.Drawing.Size(120, 40)
        Me.webButton.TabIndex = 9
        Me.webButton.TabStop = False
        '
        'notesButton
        '
        Me.notesButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.notesButton.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.Notes2
        Me.notesButton.Location = New System.Drawing.Point(264, 12)
        Me.notesButton.Name = "notesButton"
        Me.notesButton.Size = New System.Drawing.Size(120, 40)
        Me.notesButton.TabIndex = 6
        Me.notesButton.TabStop = False
        '
        'lite98Button
        '
        Me.lite98Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lite98Button.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.Radio2
        Me.lite98Button.Location = New System.Drawing.Point(138, 12)
        Me.lite98Button.Name = "lite98Button"
        Me.lite98Button.Size = New System.Drawing.Size(120, 40)
        Me.lite98Button.TabIndex = 5
        Me.lite98Button.TabStop = False
        '
        'homeButton
        '
        Me.homeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.homeButton.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.HomeSelected
        Me.homeButton.Location = New System.Drawing.Point(12, 12)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(120, 40)
        Me.homeButton.TabIndex = 4
        Me.homeButton.TabStop = False
        '
        'closeButton
        '
        Me.closeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        Me.settingsIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.settingsIcon.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.gear
        Me.settingsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.settingsIcon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settingsIcon.Location = New System.Drawing.Point(1880, 0)
        Me.settingsIcon.Name = "settingsIcon"
        Me.settingsIcon.Size = New System.Drawing.Size(40, 40)
        Me.settingsIcon.TabIndex = 0
        Me.settingsIcon.TabStop = False
        '
        'timeLbl
        '
        Me.timeLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timeLbl.AutoSize = True
        Me.timeLbl.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLbl.ForeColor = System.Drawing.Color.White
        Me.timeLbl.Location = New System.Drawing.Point(1716, 314)
        Me.timeLbl.Name = "timeLbl"
        Me.timeLbl.Size = New System.Drawing.Size(192, 45)
        Me.timeLbl.TabIndex = 18
        Me.timeLbl.Text = "12:00:00 PM"
        '
        'dateLbl
        '
        Me.dateLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateLbl.AutoSize = True
        Me.dateLbl.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.dateLbl.ForeColor = System.Drawing.Color.White
        Me.dateLbl.Location = New System.Drawing.Point(1756, 282)
        Me.dateLbl.Name = "dateLbl"
        Me.dateLbl.Size = New System.Drawing.Size(111, 32)
        Me.dateLbl.TabIndex = 19
        Me.dateLbl.Text = "1/1/1111"
        '
        'dowLbl
        '
        Me.dowLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dowLbl.AutoSize = True
        Me.dowLbl.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.dowLbl.ForeColor = System.Drawing.Color.White
        Me.dowLbl.Location = New System.Drawing.Point(1763, 250)
        Me.dowLbl.Name = "dowLbl"
        Me.dowLbl.Size = New System.Drawing.Size(94, 32)
        Me.dowLbl.TabIndex = 20
        Me.dowLbl.Text = "Sunday"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(1525, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Visual Control"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LaunchPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1920, 400)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dowLbl)
        Me.Controls.Add(Me.dateLbl)
        Me.Controls.Add(Me.timeLbl)
        Me.Controls.Add(Me.numbergeneratorBtn)
        Me.Controls.Add(Me.extlookupBtn)
        Me.Controls.Add(Me.toolproBtn)
        Me.Controls.Add(Me.blcBtn)
        Me.Controls.Add(Me.namesuggesterBtn)
        Me.Controls.Add(Me.YouWidgetBtn)
        Me.Controls.Add(Me.todoButton)
        Me.Controls.Add(Me.tasksButton)
        Me.Controls.Add(Me.webButton)
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
        CType(Me.numbergeneratorBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.extlookupBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toolproBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blcBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.namesuggesterBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YouWidgetBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.todoButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tasksButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.webButton, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents quicklaunchBtn As System.Windows.Forms.TextBox
    Friend WithEvents exitLabel As System.Windows.Forms.Label
    Friend WithEvents webButton As System.Windows.Forms.PictureBox
    Friend WithEvents tasksButton As System.Windows.Forms.PictureBox
    Friend WithEvents todoButton As System.Windows.Forms.PictureBox
    Friend WithEvents YouWidgetBtn As System.Windows.Forms.PictureBox
    Friend WithEvents namesuggesterBtn As System.Windows.Forms.PictureBox
    Friend WithEvents blcBtn As System.Windows.Forms.PictureBox
    Friend WithEvents toolproBtn As System.Windows.Forms.PictureBox
    Friend WithEvents extlookupBtn As System.Windows.Forms.PictureBox
    Friend WithEvents numbergeneratorBtn As System.Windows.Forms.PictureBox
    Friend WithEvents timeLbl As System.Windows.Forms.Label
    Friend WithEvents dateLbl As System.Windows.Forms.Label
    Friend WithEvents dowLbl As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
