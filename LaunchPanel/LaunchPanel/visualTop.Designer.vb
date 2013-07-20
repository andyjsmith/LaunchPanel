<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class visualTop
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
        Me.LabelYes = New System.Windows.Forms.Label()
        Me.LabelNo = New System.Windows.Forms.Label()
        Me.LabelMaybe = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelYes
        '
        Me.LabelYes.AutoSize = True
        Me.LabelYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelYes.ForeColor = System.Drawing.Color.Silver
        Me.LabelYes.Location = New System.Drawing.Point(53, 65)
        Me.LabelYes.Name = "LabelYes"
        Me.LabelYes.Size = New System.Drawing.Size(213, 108)
        Me.LabelYes.TabIndex = 0
        Me.LabelYes.Text = "Yes"
        '
        'LabelNo
        '
        Me.LabelNo.AutoSize = True
        Me.LabelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNo.ForeColor = System.Drawing.Color.Silver
        Me.LabelNo.Location = New System.Drawing.Point(382, 65)
        Me.LabelNo.Name = "LabelNo"
        Me.LabelNo.Size = New System.Drawing.Size(169, 108)
        Me.LabelNo.TabIndex = 0
        Me.LabelNo.Text = "No"
        '
        'LabelMaybe
        '
        Me.LabelMaybe.AutoSize = True
        Me.LabelMaybe.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMaybe.ForeColor = System.Drawing.Color.Silver
        Me.LabelMaybe.Location = New System.Drawing.Point(330, 327)
        Me.LabelMaybe.Name = "LabelMaybe"
        Me.LabelMaybe.Size = New System.Drawing.Size(337, 108)
        Me.LabelMaybe.TabIndex = 0
        Me.LabelMaybe.Text = "Maybe"
        '
        'visualTop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 616)
        Me.Controls.Add(Me.LabelMaybe)
        Me.Controls.Add(Me.LabelNo)
        Me.Controls.Add(Me.LabelYes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "visualTop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "visualTop"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelYes As System.Windows.Forms.Label
    Friend WithEvents LabelNo As System.Windows.Forms.Label
    Friend WithEvents LabelMaybe As System.Windows.Forms.Label
End Class
