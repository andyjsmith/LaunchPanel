<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class taskmanager
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
        Me.killTask = New System.Windows.Forms.Button()
        Me.backBtn = New System.Windows.Forms.PictureBox()
        Me.slideoutTimer = New System.Windows.Forms.Timer(Me.components)
        Me.slideinTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tasksList = New System.Windows.Forms.ListView()
        Me.nameHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.memoryHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.workingHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.initializedHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.idHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.refreshTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'killTask
        '
        Me.killTask.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.killTask.Location = New System.Drawing.Point(563, 442)
        Me.killTask.Name = "killTask"
        Me.killTask.Size = New System.Drawing.Size(75, 23)
        Me.killTask.TabIndex = 0
        Me.killTask.Text = "Kill Task"
        Me.killTask.UseVisualStyleBackColor = True
        '
        'backBtn
        '
        Me.backBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.backBtn.BackgroundImage = Global.LaunchPanel.My.Resources.Resources._return
        Me.backBtn.Location = New System.Drawing.Point(3, 436)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(40, 40)
        Me.backBtn.TabIndex = 2
        Me.backBtn.TabStop = False
        '
        'slideoutTimer
        '
        '
        'slideinTimer
        '
        '
        'tasksList
        '
        Me.tasksList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tasksList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nameHeader, Me.memoryHeader, Me.workingHeader, Me.initializedHeader, Me.idHeader})
        Me.tasksList.GridLines = True
        Me.tasksList.Location = New System.Drawing.Point(12, 12)
        Me.tasksList.MultiSelect = False
        Me.tasksList.Name = "tasksList"
        Me.tasksList.Size = New System.Drawing.Size(626, 418)
        Me.tasksList.TabIndex = 3
        Me.tasksList.UseCompatibleStateImageBehavior = False
        Me.tasksList.View = System.Windows.Forms.View.Details
        '
        'nameHeader
        '
        Me.nameHeader.Text = "Name"
        Me.nameHeader.Width = 265
        '
        'memoryHeader
        '
        Me.memoryHeader.Text = "Memory"
        Me.memoryHeader.Width = 94
        '
        'workingHeader
        '
        Me.workingHeader.Text = "Working"
        Me.workingHeader.Width = 101
        '
        'initializedHeader
        '
        Me.initializedHeader.Text = "Initialized"
        Me.initializedHeader.Width = 61
        '
        'idHeader
        '
        Me.idHeader.Text = "ID"
        Me.idHeader.Width = 100
        '
        'refreshTimer
        '
        Me.refreshTimer.Enabled = True
        Me.refreshTimer.Interval = 15000
        '
        'taskmanager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(650, 475)
        Me.Controls.Add(Me.tasksList)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.killTask)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "taskmanager"
        Me.ShowInTaskbar = False
        Me.Text = "Task Manager"
        Me.TopMost = True
        CType(Me.backBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents killTask As System.Windows.Forms.Button
    Friend WithEvents backBtn As System.Windows.Forms.PictureBox
    Friend WithEvents slideoutTimer As System.Windows.Forms.Timer
    Friend WithEvents slideinTimer As System.Windows.Forms.Timer
    Friend WithEvents tasksList As System.Windows.Forms.ListView
    Friend WithEvents nameHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents memoryHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents workingHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents initializedHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents idHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents refreshTimer As System.Windows.Forms.Timer
End Class
