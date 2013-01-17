Public Class notes
    Sub notesSlidein()
        Me.Show()
        slideinTimer.Enabled = True
        slideoutTimer.Enabled = False
    End Sub
    Sub notesSlideout()
        slideoutTimer.Enabled = True
        slideinTimer.Enabled = False
    End Sub

    Private Sub slideinTimer_Tick(sender As System.Object, e As System.EventArgs) Handles slideinTimer.Tick
        Do
            Me.Height += 1
            'Me.Refresh()
        Loop Until Me.Height = 700
        slideinTimer.Enabled = False
    End Sub

    Private Sub notes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Height = 0
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        notesSlideout()
    End Sub

    Private Sub slideoutTimer_Tick(sender As System.Object, e As System.EventArgs) Handles slideoutTimer.Tick
        Do
            Me.Height -= 1
            'Me.Refresh()
        Loop Until Me.Height = 5
        Me.Hide()
        slideoutTimer.Enabled = False
        LaunchPanel.Show()
        LaunchPanel.slidein()
    End Sub
End Class