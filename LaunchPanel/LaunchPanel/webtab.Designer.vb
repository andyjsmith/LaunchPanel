<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class webtab
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
        Me.navstatusPanel = New System.Windows.Forms.Panel()
        Me.slideoutBox = New System.Windows.Forms.PictureBox()
        Me.homeBox = New System.Windows.Forms.PictureBox()
        Me.reloadBox = New System.Windows.Forms.PictureBox()
        Me.stopBox = New System.Windows.Forms.PictureBox()
        Me.forwardBox = New System.Windows.Forms.PictureBox()
        Me.backBox = New System.Windows.Forms.PictureBox()
        Me.addressPanel = New System.Windows.Forms.Panel()
        Me.webSearch = New System.Windows.Forms.TextBox()
        Me.webAddress = New System.Windows.Forms.TextBox()
        Me.browser = New System.Windows.Forms.WebBrowser()
        Me.navstatusPanel.SuspendLayout()
        CType(Me.slideoutBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.homeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reloadBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stopBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.forwardBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addressPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'slideinTimer
        '
        Me.slideinTimer.Interval = 10
        '
        'slideoutTimer
        '
        Me.slideoutTimer.Interval = 10
        '
        'navstatusPanel
        '
        Me.navstatusPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.navstatusPanel.Controls.Add(Me.slideoutBox)
        Me.navstatusPanel.Controls.Add(Me.homeBox)
        Me.navstatusPanel.Controls.Add(Me.reloadBox)
        Me.navstatusPanel.Controls.Add(Me.stopBox)
        Me.navstatusPanel.Controls.Add(Me.forwardBox)
        Me.navstatusPanel.Controls.Add(Me.backBox)
        Me.navstatusPanel.Location = New System.Drawing.Point(0, 506)
        Me.navstatusPanel.Name = "navstatusPanel"
        Me.navstatusPanel.Size = New System.Drawing.Size(1079, 40)
        Me.navstatusPanel.TabIndex = 1
        '
        'slideoutBox
        '
        Me.slideoutBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.slideoutBox.BackgroundImage = Global.LaunchPanel.My.Resources.Resources._return
        Me.slideoutBox.Location = New System.Drawing.Point(1042, -2)
        Me.slideoutBox.Name = "slideoutBox"
        Me.slideoutBox.Size = New System.Drawing.Size(40, 40)
        Me.slideoutBox.TabIndex = 12
        Me.slideoutBox.TabStop = False
        '
        'homeBox
        '
        Me.homeBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.homeBox.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.home
        Me.homeBox.Location = New System.Drawing.Point(191, -2)
        Me.homeBox.Name = "homeBox"
        Me.homeBox.Size = New System.Drawing.Size(40, 40)
        Me.homeBox.TabIndex = 11
        Me.homeBox.TabStop = False
        '
        'reloadBox
        '
        Me.reloadBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.reloadBox.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.reload
        Me.reloadBox.Location = New System.Drawing.Point(144, -2)
        Me.reloadBox.Name = "reloadBox"
        Me.reloadBox.Size = New System.Drawing.Size(40, 40)
        Me.reloadBox.TabIndex = 10
        Me.reloadBox.TabStop = False
        '
        'stopBox
        '
        Me.stopBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.stopBox.BackgroundImage = Global.LaunchPanel.My.Resources.Resources._stop
        Me.stopBox.Location = New System.Drawing.Point(97, -2)
        Me.stopBox.Name = "stopBox"
        Me.stopBox.Size = New System.Drawing.Size(40, 40)
        Me.stopBox.TabIndex = 9
        Me.stopBox.TabStop = False
        '
        'forwardBox
        '
        Me.forwardBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.forwardBox.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.forward
        Me.forwardBox.Location = New System.Drawing.Point(50, -2)
        Me.forwardBox.Name = "forwardBox"
        Me.forwardBox.Size = New System.Drawing.Size(40, 40)
        Me.forwardBox.TabIndex = 8
        Me.forwardBox.TabStop = False
        '
        'backBox
        '
        Me.backBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.backBox.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.back
        Me.backBox.Location = New System.Drawing.Point(3, -2)
        Me.backBox.Name = "backBox"
        Me.backBox.Size = New System.Drawing.Size(40, 40)
        Me.backBox.TabIndex = 7
        Me.backBox.TabStop = False
        '
        'addressPanel
        '
        Me.addressPanel.Controls.Add(Me.webSearch)
        Me.addressPanel.Controls.Add(Me.webAddress)
        Me.addressPanel.Location = New System.Drawing.Point(0, 0)
        Me.addressPanel.Name = "addressPanel"
        Me.addressPanel.Size = New System.Drawing.Size(1082, 40)
        Me.addressPanel.TabIndex = 0
        '
        'webSearch
        '
        Me.webSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.webSearch.Location = New System.Drawing.Point(825, 8)
        Me.webSearch.Name = "webSearch"
        Me.webSearch.Size = New System.Drawing.Size(254, 26)
        Me.webSearch.TabIndex = 1
        Me.webSearch.Text = "Search"
        '
        'webAddress
        '
        Me.webAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.webAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.webAddress.Location = New System.Drawing.Point(4, 8)
        Me.webAddress.Name = "webAddress"
        Me.webAddress.Size = New System.Drawing.Size(815, 26)
        Me.webAddress.TabIndex = 0
        '
        'browser
        '
        Me.browser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.browser.Location = New System.Drawing.Point(4, 46)
        Me.browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.browser.Name = "browser"
        Me.browser.ScriptErrorsSuppressed = True
        Me.browser.Size = New System.Drawing.Size(1075, 454)
        Me.browser.TabIndex = 2
        Me.browser.Url = New System.Uri("http://www.google.com/", System.UriKind.Absolute)
        '
        'webtab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1081, 546)
        Me.Controls.Add(Me.addressPanel)
        Me.Controls.Add(Me.browser)
        Me.Controls.Add(Me.navstatusPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "webtab"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Web Browser"
        Me.TopMost = True
        Me.navstatusPanel.ResumeLayout(False)
        CType(Me.slideoutBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.homeBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reloadBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stopBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.forwardBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addressPanel.ResumeLayout(False)
        Me.addressPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents slideinTimer As System.Windows.Forms.Timer
    Friend WithEvents slideoutTimer As System.Windows.Forms.Timer
    Friend WithEvents navstatusPanel As System.Windows.Forms.Panel
    Friend WithEvents addressPanel As System.Windows.Forms.Panel
    Friend WithEvents webAddress As System.Windows.Forms.TextBox
    Friend WithEvents webSearch As System.Windows.Forms.TextBox
    Friend WithEvents browser As System.Windows.Forms.WebBrowser
    Friend WithEvents backBox As System.Windows.Forms.PictureBox
    Friend WithEvents slideoutBox As System.Windows.Forms.PictureBox
    Friend WithEvents homeBox As System.Windows.Forms.PictureBox
    Friend WithEvents reloadBox As System.Windows.Forms.PictureBox
    Friend WithEvents stopBox As System.Windows.Forms.PictureBox
    Friend WithEvents forwardBox As System.Windows.Forms.PictureBox
End Class
