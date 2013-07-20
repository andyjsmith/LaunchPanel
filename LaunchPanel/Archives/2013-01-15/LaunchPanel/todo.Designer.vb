<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class todo
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
        Me.returnBtn = New System.Windows.Forms.PictureBox()
        Me.slideoutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.slideinTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.returnBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'returnBtn
        '
        Me.returnBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.returnBtn.BackgroundImage = Global.LaunchPanel.My.Resources.Resources._return
        Me.returnBtn.Location = New System.Drawing.Point(551, 534)
        Me.returnBtn.Name = "returnBtn"
        Me.returnBtn.Size = New System.Drawing.Size(40, 40)
        Me.returnBtn.TabIndex = 2
        Me.returnBtn.TabStop = False
        '
        'slideoutTimer
        '
        '
        'slideinTimer
        '
        '
        'todo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(592, 574)
        Me.Controls.Add(Me.returnBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "todo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "todo"
        Me.TopMost = True
        CType(Me.returnBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents returnBtn As System.Windows.Forms.PictureBox
    Friend WithEvents slideoutTimer As System.Windows.Forms.Timer
    Friend WithEvents slideinTimer As System.Windows.Forms.Timer
End Class
