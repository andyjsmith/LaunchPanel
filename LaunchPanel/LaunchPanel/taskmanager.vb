Public Class taskmanager

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        taskmanagerSlideout()
    End Sub

    Private Sub taskmanager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoAdjust()
        Me.Location = New Point(Me.Location.X, -475)

        Dim Process As New Process()
        Dim Count As Integer = 0
        tasksList.Items.Clear()
        For Each Process In Process.GetProcesses(My.Computer.Name)
            On Error Resume Next
            tasksList.Items.Add(Process.ProcessName)
            tasksList.Items(Count).SubItems.Add(FormatNumber(Math.Round(Process.PrivateMemorySize64 / 1024), 0))
            tasksList.Items(Count).SubItems.Add(Process.Responding)
            tasksList.Items(Count).SubItems.Add(Process.StartTime.ToString.Trim)
            tasksList.Items(Count).SubItems.Add(Process.Id)
            Count += 1
        Next

    End Sub
    Sub autoAdjust()
        'Adjusting to fit monitor
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim formloc As Point = New Point(screenWidth / 2 - Me.Width / 2, 0)
        Me.Location = formloc
    End Sub
    Sub taskmanagerSlidein()
        Me.Show()
        slideinTimer.Enabled = True
        slideoutTimer.Enabled = False
    End Sub
    Sub taskmanagerSlideout()
        slideoutTimer.Enabled = True
        slideinTimer.Enabled = False
    End Sub

    Private Sub slideinTimer_Tick(sender As Object, e As EventArgs) Handles slideinTimer.Tick
        If Me.Location.Y >= 0 Then
            slideinTimer.Enabled = False
            Me.Location = New Point(Me.Location.X, 0)
        Else
            Me.Location = New Point(Me.Location.X, Me.Location.Y + My.Settings.Slide)
        End If
    End Sub

    Private Sub slideoutTimer_Tick(sender As Object, e As EventArgs) Handles slideoutTimer.Tick
        If Me.Location.Y <= -475 Then
            slideoutTimer.Enabled = False
            Me.Location = New Point(Me.Location.X, -475)
            Me.Hide()
            LaunchPanel.Show()
            LaunchPanel.slidein()
        Else
            Me.Location = New Point(Me.Location.X, Me.Location.Y - My.Settings.Slide)
        End If
    End Sub

    Private Sub killTask_Click(sender As Object, e As EventArgs) Handles killTask.Click
        For Each Process As ListViewItem In tasksList.SelectedItems
            System.Diagnostics.Process.GetProcessById(Process.SubItems(1).Text).Kill()
        Next
        taskmanager_Load(Nothing, Nothing)
    End Sub

    Private Sub refreshTimer_Tick(sender As Object, e As EventArgs) Handles refreshTimer.Tick
        taskmanager_Load(Nothing, Nothing)
    End Sub
End Class