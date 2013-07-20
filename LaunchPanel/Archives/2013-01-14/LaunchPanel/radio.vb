Public Class radio
    Sub lite98Slidein()
        Me.Show()
        slideinTimer.Enabled = True
        slideoutTimer.Enabled = False
    End Sub
    Sub lite98Slideout()
        slideoutTimer.enabled = True
        slideinTimer.Enabled = False
    End Sub

    Private Sub slideinTimer_Tick(sender As System.Object, e As System.EventArgs) Handles slideinTimer.Tick
        Do
            Me.Height += 2
            Me.Refresh()
        Loop Until Me.Height = 292
        slideinTimer.Enabled = False
    End Sub

    Private Sub slideoutTimer_Tick(sender As System.Object, e As System.EventArgs) Handles slideoutTimer.Tick
        Do
            Me.Height -= 2
            'Me.Refresh()
        Loop Until Me.Height = 4
        Me.Hide()
        slideoutTimer.Enabled = False
        LaunchPanel.Show()
        LaunchPanel.slidein()
        Me.Hide()
    End Sub

    Private Sub back_Click(sender As System.Object, e As System.EventArgs) Handles back.Click
        lite98Slideout()
    End Sub

    Private Sub lite98_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Height = 0
        autoAdjust()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        player.Navigate("http://www.iheart.com/live/Q94-2469/")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        player.Navigate("http://www.iheart.com/live/HOT-1009-6094/")
    End Sub
    Sub autoAdjust()
        'Adjusting to fit monitor
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim formloc As Point = New Point(screenWidth / 2 - Me.Width / 2, 0)
        Me.Location = formloc
    End Sub
End Class