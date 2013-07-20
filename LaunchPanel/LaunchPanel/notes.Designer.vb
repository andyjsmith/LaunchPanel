<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class notes
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.slideoutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.notesTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'slideinTimer
        '
        Me.slideinTimer.Interval = 10
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "<--"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'slideoutTimer
        '
        Me.slideoutTimer.Interval = 10
        '
        'notesTextBox
        '
        Me.notesTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.notesTextBox.Location = New System.Drawing.Point(12, 41)
        Me.notesTextBox.Name = "notesTextBox"
        Me.notesTextBox.Size = New System.Drawing.Size(556, 647)
        Me.notesTextBox.TabIndex = 1
        Me.notesTextBox.Text = ""
        '
        'notes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(580, 700)
        Me.Controls.Add(Me.notesTextBox)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(670, 0)
        Me.Name = "notes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "notes"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents slideinTimer As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents slideoutTimer As System.Windows.Forms.Timer
    Friend WithEvents notesTextBox As System.Windows.Forms.RichTextBox
End Class
