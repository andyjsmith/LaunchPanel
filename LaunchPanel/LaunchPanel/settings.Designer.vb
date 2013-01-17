<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Me.settingsTabControl = New System.Windows.Forms.TabControl()
        Me.generalTab = New System.Windows.Forms.TabPage()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.fastBtn = New System.Windows.Forms.Button()
        Me.slowBtn = New System.Windows.Forms.Button()
        Me.noneBtn = New System.Windows.Forms.Button()
        Me.pwBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.saveTB = New System.Windows.Forms.TextBox()
        Me.speedLabel = New System.Windows.Forms.Label()
        Me.unameLabel = New System.Windows.Forms.Label()
        Me.saveLabel = New System.Windows.Forms.Label()
        Me.displayTab = New System.Windows.Forms.TabPage()
        Me.notesGroup = New System.Windows.Forms.GroupBox()
        Me.bgcolorBtn = New System.Windows.Forms.Button()
        Me.textcolorBtn = New System.Windows.Forms.Button()
        Me.generalGroup = New System.Windows.Forms.GroupBox()
        Me.colorPreview = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.resetgeneralBtn = New System.Windows.Forms.Button()
        Me.generalcolorBtn = New System.Windows.Forms.Button()
        Me.helpTab = New System.Windows.Forms.TabPage()
        Me.helpBox = New System.Windows.Forms.RichTextBox()
        Me.colorPicker = New System.Windows.Forms.ColorDialog()
        Me.bgcolorDialog = New System.Windows.Forms.ColorDialog()
        Me.textcolorDialog = New System.Windows.Forms.ColorDialog()
        Me.settingsTabControl.SuspendLayout()
        Me.generalTab.SuspendLayout()
        Me.displayTab.SuspendLayout()
        Me.notesGroup.SuspendLayout()
        Me.generalGroup.SuspendLayout()
        CType(Me.colorPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.helpTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'settingsTabControl
        '
        Me.settingsTabControl.Controls.Add(Me.generalTab)
        Me.settingsTabControl.Controls.Add(Me.displayTab)
        Me.settingsTabControl.Controls.Add(Me.helpTab)
        Me.settingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.settingsTabControl.Location = New System.Drawing.Point(0, 0)
        Me.settingsTabControl.Name = "settingsTabControl"
        Me.settingsTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.settingsTabControl.SelectedIndex = 0
        Me.settingsTabControl.Size = New System.Drawing.Size(495, 437)
        Me.settingsTabControl.TabIndex = 0
        '
        'generalTab
        '
        Me.generalTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.generalTab.Controls.Add(Me.resetBtn)
        Me.generalTab.Controls.Add(Me.fastBtn)
        Me.generalTab.Controls.Add(Me.slowBtn)
        Me.generalTab.Controls.Add(Me.noneBtn)
        Me.generalTab.Controls.Add(Me.pwBtn)
        Me.generalTab.Controls.Add(Me.TextBox1)
        Me.generalTab.Controls.Add(Me.saveBtn)
        Me.generalTab.Controls.Add(Me.saveTB)
        Me.generalTab.Controls.Add(Me.speedLabel)
        Me.generalTab.Controls.Add(Me.unameLabel)
        Me.generalTab.Controls.Add(Me.saveLabel)
        Me.generalTab.Location = New System.Drawing.Point(4, 22)
        Me.generalTab.Name = "generalTab"
        Me.generalTab.Padding = New System.Windows.Forms.Padding(3)
        Me.generalTab.Size = New System.Drawing.Size(487, 411)
        Me.generalTab.TabIndex = 0
        Me.generalTab.Text = "General"
        '
        'resetBtn
        '
        Me.resetBtn.Location = New System.Drawing.Point(9, 380)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(121, 23)
        Me.resetBtn.TabIndex = 6
        Me.resetBtn.Text = "Reset All Settings"
        Me.resetBtn.UseVisualStyleBackColor = True
        '
        'fastBtn
        '
        Me.fastBtn.Location = New System.Drawing.Point(284, 147)
        Me.fastBtn.Name = "fastBtn"
        Me.fastBtn.Size = New System.Drawing.Size(75, 23)
        Me.fastBtn.TabIndex = 5
        Me.fastBtn.Text = "Fast"
        Me.fastBtn.UseVisualStyleBackColor = True
        '
        'slowBtn
        '
        Me.slowBtn.Location = New System.Drawing.Point(203, 147)
        Me.slowBtn.Name = "slowBtn"
        Me.slowBtn.Size = New System.Drawing.Size(75, 23)
        Me.slowBtn.TabIndex = 5
        Me.slowBtn.Text = "Slow"
        Me.slowBtn.UseVisualStyleBackColor = True
        '
        'noneBtn
        '
        Me.noneBtn.Location = New System.Drawing.Point(122, 147)
        Me.noneBtn.Name = "noneBtn"
        Me.noneBtn.Size = New System.Drawing.Size(75, 23)
        Me.noneBtn.TabIndex = 5
        Me.noneBtn.Text = "None"
        Me.noneBtn.UseVisualStyleBackColor = True
        '
        'pwBtn
        '
        Me.pwBtn.Location = New System.Drawing.Point(402, 53)
        Me.pwBtn.Name = "pwBtn"
        Me.pwBtn.Size = New System.Drawing.Size(75, 23)
        Me.pwBtn.TabIndex = 4
        Me.pwBtn.Text = "Password"
        Me.pwBtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(87, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(309, 20)
        Me.TextBox1.TabIndex = 3
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(402, 12)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(75, 23)
        Me.saveBtn.TabIndex = 2
        Me.saveBtn.Text = "Open"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'saveTB
        '
        Me.saveTB.Enabled = False
        Me.saveTB.Location = New System.Drawing.Point(136, 14)
        Me.saveTB.Name = "saveTB"
        Me.saveTB.Size = New System.Drawing.Size(260, 20)
        Me.saveTB.TabIndex = 1
        '
        'speedLabel
        '
        Me.speedLabel.AutoSize = True
        Me.speedLabel.ForeColor = System.Drawing.Color.White
        Me.speedLabel.Location = New System.Drawing.Point(200, 122)
        Me.speedLabel.Name = "speedLabel"
        Me.speedLabel.Size = New System.Drawing.Size(80, 13)
        Me.speedLabel.TabIndex = 0
        Me.speedLabel.Text = "Slideout speed:"
        '
        'unameLabel
        '
        Me.unameLabel.AutoSize = True
        Me.unameLabel.ForeColor = System.Drawing.Color.White
        Me.unameLabel.Location = New System.Drawing.Point(18, 58)
        Me.unameLabel.Name = "unameLabel"
        Me.unameLabel.Size = New System.Drawing.Size(63, 13)
        Me.unameLabel.TabIndex = 0
        Me.unameLabel.Text = "User Name:"
        '
        'saveLabel
        '
        Me.saveLabel.AutoSize = True
        Me.saveLabel.ForeColor = System.Drawing.Color.White
        Me.saveLabel.Location = New System.Drawing.Point(18, 17)
        Me.saveLabel.Name = "saveLabel"
        Me.saveLabel.Size = New System.Drawing.Size(112, 13)
        Me.saveLabel.TabIndex = 0
        Me.saveLabel.Text = "Save location on disk:"
        '
        'displayTab
        '
        Me.displayTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.displayTab.Controls.Add(Me.notesGroup)
        Me.displayTab.Controls.Add(Me.generalGroup)
        Me.displayTab.Location = New System.Drawing.Point(4, 22)
        Me.displayTab.Name = "displayTab"
        Me.displayTab.Padding = New System.Windows.Forms.Padding(3)
        Me.displayTab.Size = New System.Drawing.Size(487, 411)
        Me.displayTab.TabIndex = 1
        Me.displayTab.Text = "Display"
        '
        'notesGroup
        '
        Me.notesGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.notesGroup.Controls.Add(Me.bgcolorBtn)
        Me.notesGroup.Controls.Add(Me.textcolorBtn)
        Me.notesGroup.ForeColor = System.Drawing.Color.White
        Me.notesGroup.Location = New System.Drawing.Point(8, 113)
        Me.notesGroup.Name = "notesGroup"
        Me.notesGroup.Size = New System.Drawing.Size(473, 101)
        Me.notesGroup.TabIndex = 0
        Me.notesGroup.TabStop = False
        Me.notesGroup.Text = "Notes"
        '
        'bgcolorBtn
        '
        Me.bgcolorBtn.ForeColor = System.Drawing.Color.Black
        Me.bgcolorBtn.Location = New System.Drawing.Point(21, 27)
        Me.bgcolorBtn.Name = "bgcolorBtn"
        Me.bgcolorBtn.Size = New System.Drawing.Size(130, 23)
        Me.bgcolorBtn.TabIndex = 1
        Me.bgcolorBtn.Text = "Set Background Color"
        Me.bgcolorBtn.UseVisualStyleBackColor = True
        '
        'textcolorBtn
        '
        Me.textcolorBtn.ForeColor = System.Drawing.Color.Black
        Me.textcolorBtn.Location = New System.Drawing.Point(21, 56)
        Me.textcolorBtn.Name = "textcolorBtn"
        Me.textcolorBtn.Size = New System.Drawing.Size(130, 23)
        Me.textcolorBtn.TabIndex = 0
        Me.textcolorBtn.Text = "Set Text Color"
        Me.textcolorBtn.UseVisualStyleBackColor = True
        '
        'generalGroup
        '
        Me.generalGroup.Controls.Add(Me.colorPreview)
        Me.generalGroup.Controls.Add(Me.PictureBox1)
        Me.generalGroup.Controls.Add(Me.resetgeneralBtn)
        Me.generalGroup.Controls.Add(Me.generalcolorBtn)
        Me.generalGroup.ForeColor = System.Drawing.Color.White
        Me.generalGroup.Location = New System.Drawing.Point(6, 6)
        Me.generalGroup.Name = "generalGroup"
        Me.generalGroup.Size = New System.Drawing.Size(473, 101)
        Me.generalGroup.TabIndex = 0
        Me.generalGroup.TabStop = False
        Me.generalGroup.Text = "General"
        '
        'colorPreview
        '
        Me.colorPreview.Location = New System.Drawing.Point(134, 29)
        Me.colorPreview.Name = "colorPreview"
        Me.colorPreview.Size = New System.Drawing.Size(100, 50)
        Me.colorPreview.TabIndex = 1
        Me.colorPreview.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(129, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 60)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'resetgeneralBtn
        '
        Me.resetgeneralBtn.ForeColor = System.Drawing.Color.Black
        Me.resetgeneralBtn.Location = New System.Drawing.Point(23, 56)
        Me.resetgeneralBtn.Name = "resetgeneralBtn"
        Me.resetgeneralBtn.Size = New System.Drawing.Size(94, 23)
        Me.resetgeneralBtn.TabIndex = 0
        Me.resetgeneralBtn.Text = "Reset to Default"
        Me.resetgeneralBtn.UseVisualStyleBackColor = True
        '
        'generalcolorBtn
        '
        Me.generalcolorBtn.ForeColor = System.Drawing.Color.Black
        Me.generalcolorBtn.Location = New System.Drawing.Point(23, 27)
        Me.generalcolorBtn.Name = "generalcolorBtn"
        Me.generalcolorBtn.Size = New System.Drawing.Size(94, 23)
        Me.generalcolorBtn.TabIndex = 0
        Me.generalcolorBtn.Text = "Choose Color"
        Me.generalcolorBtn.UseVisualStyleBackColor = True
        '
        'helpTab
        '
        Me.helpTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.helpTab.Controls.Add(Me.helpBox)
        Me.helpTab.Location = New System.Drawing.Point(4, 22)
        Me.helpTab.Name = "helpTab"
        Me.helpTab.Size = New System.Drawing.Size(487, 411)
        Me.helpTab.TabIndex = 2
        Me.helpTab.Text = "Help"
        '
        'helpBox
        '
        Me.helpBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.helpBox.Location = New System.Drawing.Point(0, 0)
        Me.helpBox.Name = "helpBox"
        Me.helpBox.ReadOnly = True
        Me.helpBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.helpBox.Size = New System.Drawing.Size(487, 411)
        Me.helpBox.TabIndex = 0
        Me.helpBox.Text = "Loading help..."
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(495, 437)
        Me.Controls.Add(Me.settingsTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "settings"
        Me.Text = "Settings"
        Me.settingsTabControl.ResumeLayout(False)
        Me.generalTab.ResumeLayout(False)
        Me.generalTab.PerformLayout()
        Me.displayTab.ResumeLayout(False)
        Me.notesGroup.ResumeLayout(False)
        Me.generalGroup.ResumeLayout(False)
        CType(Me.colorPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.helpTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents settingsTabControl As System.Windows.Forms.TabControl
    Friend WithEvents generalTab As System.Windows.Forms.TabPage
    Friend WithEvents displayTab As System.Windows.Forms.TabPage
    Friend WithEvents helpTab As System.Windows.Forms.TabPage
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents saveTB As System.Windows.Forms.TextBox
    Friend WithEvents saveLabel As System.Windows.Forms.Label
    Friend WithEvents resetBtn As System.Windows.Forms.Button
    Friend WithEvents fastBtn As System.Windows.Forms.Button
    Friend WithEvents slowBtn As System.Windows.Forms.Button
    Friend WithEvents noneBtn As System.Windows.Forms.Button
    Friend WithEvents pwBtn As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents speedLabel As System.Windows.Forms.Label
    Friend WithEvents unameLabel As System.Windows.Forms.Label
    Friend WithEvents notesGroup As System.Windows.Forms.GroupBox
    Friend WithEvents generalGroup As System.Windows.Forms.GroupBox
    Friend WithEvents resetgeneralBtn As System.Windows.Forms.Button
    Friend WithEvents generalcolorBtn As System.Windows.Forms.Button
    Friend WithEvents helpBox As System.Windows.Forms.RichTextBox
    Friend WithEvents colorPreview As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents colorPicker As System.Windows.Forms.ColorDialog
    Friend WithEvents bgcolorBtn As System.Windows.Forms.Button
    Friend WithEvents textcolorBtn As System.Windows.Forms.Button
    Friend WithEvents bgcolorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents textcolorDialog As System.Windows.Forms.ColorDialog
End Class
