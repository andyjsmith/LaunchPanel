Public Class todo

    Private Sub todo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoAdjust()
        Me.Location = New Point(Me.Location.X, -574)
    End Sub
    Sub autoAdjust()
        'Adjusting to fit monitor
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim formloc As Point = New Point(screenWidth / 2 - Me.Width / 2, 0)
        Me.Location = formloc
    End Sub
    Sub todoSlidein()
        Me.Show()
        slideinTimer.Enabled = True
        slideoutTimer.Enabled = False
    End Sub
    Sub todoSlideout()
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
        If Me.Location.Y <= -574 Then
            slideoutTimer.Enabled = False
            Me.Location = New Point(Me.Location.X, -574)
            Me.Hide()
            LaunchPanel.Show()
            LaunchPanel.slidein()
        Else
            Me.Location = New Point(Me.Location.X, Me.Location.Y - My.Settings.Slide)
        End If
    End Sub

    Private Sub returnBtn_Click(sender As Object, e As EventArgs) Handles returnBtn.Click
        todoSlideout()
        LaunchPanel.slidein()
    End Sub

    Private Sub task5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub task4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub task2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub task1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub task18_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class