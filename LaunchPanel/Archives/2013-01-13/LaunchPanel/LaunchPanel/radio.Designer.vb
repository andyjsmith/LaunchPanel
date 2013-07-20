<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class radio
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
        Me.player = New System.Windows.Forms.WebBrowser()
        Me.slideoutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.slideinTimer = New System.Windows.Forms.Timer(Me.components)
        Me.back = New System.Windows.Forms.PictureBox()
        Me.sidePanel = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sidePanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'player
        '
        Me.player.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.player.Location = New System.Drawing.Point(0, -1)
        Me.player.MinimumSize = New System.Drawing.Size(20, 20)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(1022, 291)
        Me.player.TabIndex = 0
        Me.player.Url = New System.Uri("http://www.iheart.com/live/Q94-2469/", System.UriKind.Absolute)
        '
        'slideoutTimer
        '
        '
        'slideinTimer
        '
        '
        'back
        '
        Me.back.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.back.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.back.BackgroundImage = Global.LaunchPanel.My.Resources.Resources.ip_icon_02_Back
        Me.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back.Location = New System.Drawing.Point(996, -1)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(26, 27)
        Me.back.TabIndex = 7
        Me.back.TabStop = False
        '
        'sidePanel
        '
        Me.sidePanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.sidePanel.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.sidePanel.Location = New System.Drawing.Point(995, -1)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(27, 291)
        Me.sidePanel.TabIndex = 4
        Me.sidePanel.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1001, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 16)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(1001, 54)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 16)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'radio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1022, 290)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.sidePanel)
        Me.Controls.Add(Me.player)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(500, 0)
        Me.Name = "radio"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "lite98"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.DarkGoldenrod
        CType(Me.back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sidePanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents player As System.Windows.Forms.WebBrowser
    Friend WithEvents sidePanel As System.Windows.Forms.PictureBox
    Friend WithEvents slideoutTimer As System.Windows.Forms.Timer
    Friend WithEvents slideinTimer As System.Windows.Forms.Timer
    Friend WithEvents back As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
