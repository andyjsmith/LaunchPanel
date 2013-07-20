Public Class settings

    Private Sub generalcolorBtn_Click(sender As Object, e As EventArgs) Handles generalcolorBtn.Click, generalcolorBtn.Click
        colorPicker.ShowDialog()
        My.Settings.generalColor = colorPicker.Color
        colorGeneral()
    End Sub

    Private Sub resetgeneralBtn_Click(sender As Object, e As EventArgs) Handles resetgeneralBtn.Click
        My.Settings.generalColor = My.Settings.defaultColor
        colorGeneral()
    End Sub
    Public Sub colorGeneral()
        LaunchPanel.BackColor = My.Settings.generalColor
        colorPreview.BackColor = My.Settings.generalColor
        generalGroup.BackColor = My.Settings.generalColor
        generalTab.BackColor = My.Settings.generalColor
        notesGroup.BackColor = My.Settings.generalColor
        displayTab.BackColor = My.Settings.generalColor
        settingsTabControl.BackColor = My.Settings.generalColor
        todo.BackColor = My.Settings.generalColor
        notes.BackColor = My.Settings.generalColor
        webtab.BackColor = My.Settings.generalColor
        exitProgram.BackColor = My.Settings.generalColor
        radio.BackColor = My.Settings.generalColor
        Me.BackColor = My.Settings.generalColor
    End Sub

    Private Sub bgcolorBtn_Click(sender As Object, e As EventArgs) Handles bgcolorBtn.Click
        bgcolorDialog.ShowDialog()
        My.Settings.notesbg = bgcolorDialog.Color
        notes.notesTextBox.BackColor = My.Settings.notesbg
    End Sub

    Private Sub textcolorBtn_Click(sender As Object, e As EventArgs) Handles textcolorBtn.Click
        textcolorDialog.ShowDialog()
        My.Settings.notestext = textcolorDialog.Color
        notes.notesTextBox.ForeColor = My.Settings.notestext
    End Sub

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(My.Settings.homeDirectory & "help.rtf") Then
            Me.helpBox.LoadFile(My.Settings.homeDirectory & "help.rtf")
        Else
            helpBox.Text = "Error: No help file found!"
        End If
        saveTB.Text = My.Settings.homeDirectory
    End Sub

    Private Sub slowBtn_Click(sender As Object, e As EventArgs) Handles slowBtn.Click
        My.Settings.Slide = 20
        My.Settings.slideIn = 400
        My.Settings.slideOut = 4
        Application.Exit()
    End Sub

    Private Sub fastBtn_Click(sender As Object, e As EventArgs) Handles fastBtn.Click
        My.Settings.Slide = 40
        My.Settings.slideIn = 402
        My.Settings.slideOut = 2
        Application.Exit()
    End Sub

    Private Sub noneBtn_Click(sender As Object, e As EventArgs) Handles noneBtn.Click
        My.Settings.Slide = 400
        My.Settings.slideIn = 402
        My.Settings.slideOut = 2
        Application.Exit()
    End Sub

    Private Sub opendirBtn_Click(sender As Object, e As EventArgs) Handles opendirBtn.Click
        Process.Start(My.Settings.homeDirectory)
    End Sub
End Class