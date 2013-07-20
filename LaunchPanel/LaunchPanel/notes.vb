Public Class notes
    Sub notesSlidein()
        If My.Computer.FileSystem.FileExists(My.Settings.homeDirectory & "notes.rtf") Then
            Me.notesTextBox.LoadFile(My.Settings.homeDirectory & "notes.rtf")
        Else
            Me.notesTextBox.SaveFile(My.Settings.homeDirectory & "notes.rtf")
        End If
        Me.Show()
        slideinTimer.Enabled = True
        slideoutTimer.Enabled = False
    End Sub
    Sub notesSlideout()
        Me.notesTextBox.SaveFile(My.Settings.homeDirectory & "notes.rtf")
        slideoutTimer.Enabled = True
        slideinTimer.Enabled = False
    End Sub

    Private Sub slideinTimer_Tick(sender As System.Object, e As System.EventArgs) Handles slideinTimer.Tick
        If Me.Location.Y >= 0 Then
            slideinTimer.Enabled = False
            Me.Location = New Point(Me.Location.X, 0)
        Else
            Me.Location = New Point(Me.Location.X, Me.Location.Y + My.Settings.Slide)
        End If
    End Sub

    Private Sub notes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        autoAdjust()
        Me.Location = New Point(Me.Location.X, -700)
        notesTextBox.BackColor = My.Settings.notesbg
        notesTextBox.ForeColor = My.Settings.notestext
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        notesSlideout()
    End Sub

    Private Sub slideoutTimer_Tick(sender As System.Object, e As System.EventArgs) Handles slideoutTimer.Tick
        If Me.Location.Y <= -700 Then
            slideoutTimer.Enabled = False
            Me.Location = New Point(Me.Location.X, -700)
            Me.Hide()
            LaunchPanel.Show()
            LaunchPanel.slidein()
        Else
            Me.Location = New Point(Me.Location.X, Me.Location.Y - My.Settings.Slide)
        End If
    End Sub
    Sub autoAdjust()
        'Adjusting to fit monitor
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim formloc As Point = New Point(screenWidth / 2 - Me.Width / 2, 0)
        Me.Location = formloc
    End Sub
End Class