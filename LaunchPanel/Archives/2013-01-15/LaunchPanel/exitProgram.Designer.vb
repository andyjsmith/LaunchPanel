<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class exitProgram
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
        Me.info = New System.Windows.Forms.Label()
        Me.titleLbl = New System.Windows.Forms.Label()
        Me.pwTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("Myriad Web Pro", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.ForeColor = System.Drawing.Color.White
        Me.info.Location = New System.Drawing.Point(12, 40)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(306, 24)
        Me.info.TabIndex = 0
        Me.info.Text = "Exiting program and saving data."
        '
        'titleLbl
        '
        Me.titleLbl.AutoSize = True
        Me.titleLbl.Font = New System.Drawing.Font("Myriad Web Pro", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLbl.ForeColor = System.Drawing.Color.White
        Me.titleLbl.Location = New System.Drawing.Point(12, 9)
        Me.titleLbl.Name = "titleLbl"
        Me.titleLbl.Size = New System.Drawing.Size(161, 31)
        Me.titleLbl.TabIndex = 0
        Me.titleLbl.Text = "Please wait..."
        '
        'pwTimer
        '
        Me.pwTimer.Enabled = True
        Me.pwTimer.Interval = 500
        '
        'exitProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(338, 76)
        Me.Controls.Add(Me.titleLbl)
        Me.Controls.Add(Me.info)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "exitProgram"
        Me.Text = "Please Wait"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents titleLbl As System.Windows.Forms.Label
    Friend WithEvents pwTimer As System.Windows.Forms.Timer
End Class
