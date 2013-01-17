Imports System.Runtime.InteropServices

Public Class LaunchPanel

    <DllImport("user32.dll")> _
    Private Shared Function GetAsyncKeyState(ByVal vKey As Integer) As UShort
    End Function
    Public isSlidOut As Boolean = False
    'Variables
    ':For Home:
    Dim homeSelected As Boolean = True
    Dim radioSelected As Boolean = False
    Dim notesSelected As Boolean = False
    ':End Home:

    Private Declare Function RegisterHotKey Lib "user32" (ByVal hWnd As IntPtr, ByVal id As Integer, ByVal fsModifier As Integer, ByVal vk As Integer) As Integer
    Private Const Key_NONE As Integer = &H0
    Private Const WM_HOTKEY As Integer = &H31

    Sub slidein()
        Me.Show()
        slideinTimer.Enabled = True
        slideoutTimer.Enabled = False
    End Sub
    Sub slideout()
        slideoutTimer.Enabled = True
        slideinTimer.Enabled = False
    End Sub

    Private Sub LaunchPanel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        keypressTimer.Enabled = True
        Me.Height = 0
        slidein()
        isSlidOut = False
    End Sub

    Private Sub slideinTimer_Tick(sender As System.Object, e As System.EventArgs) Handles slideinTimer.Tick
        Me.Refresh()
        Do
            Me.Height += 1
            ' Me.Refresh()
        Loop Until Me.Height = 400

        slideinTimer.Enabled = False
    End Sub

    Private Sub slideoutTimer_Tick(sender As System.Object, e As System.EventArgs) Handles slideoutTimer.Tick
        Me.Refresh()
        Do
            Me.Height -= 1
            ' Me.Refresh()
        Loop Until Me.Height = 5
        Me.Hide()
        slideoutTimer.Enabled = False
    End Sub

    Private Sub settingsIcon_MouseHover(sender As Object, e As System.EventArgs) Handles settingsIcon.MouseHover

    End Sub

    Private Sub closeButton_Click(sender As System.Object, e As System.EventArgs) Handles closeButton.Click
        slideout()
    End Sub

    Private Sub homeButton_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles homeButton.MouseDown
        homeButton.BackgroundImage = My.Resources.HomeSelected
    End Sub

    Private Sub homeButton_MouseEnter(sender As Object, e As System.EventArgs) Handles homeButton.MouseEnter
        homeButton.BackgroundImage = My.Resources.HomeHover
    End Sub

    Private Sub homeButton_MouseLeave(sender As Object, e As System.EventArgs) Handles homeButton.MouseLeave
        If homeSelected = True Then
            homeButton.BackgroundImage = My.Resources.HomeSelected
        Else
            homeButton.BackgroundImage = My.Resources.HomeDefault
        End If
    End Sub

    Private Sub keypressTimer_Tick(sender As System.Object, e As System.EventArgs) Handles keypressTimer.Tick
        Dim Hotkey As Boolean
        Hotkey = GetAsyncKeyState(Keys.Pause)

        If Hotkey = True Then

            If Me.Visible = True Then
                Me.slideout()
            End If

            If Me.Visible = False Then
                If notes.Visible = True Then
                    notes.notesSlideout()
                ElseIf radio.Visible = True Then
                    radio.lite98Slideout()
                ElseIf radio.Visible = False And notes.Visible = False And Me.Visible = False Then
                    Me.slidein()
                End If
            End If
        End If
    End Sub

    Private Sub lite98Button_Click(sender As System.Object, e As System.EventArgs) Handles lite98Button.Click
        slideout()
        radio.lite98Slidein()
    End Sub

    Private Sub notesButton_Click(sender As System.Object, e As System.EventArgs) Handles notesButton.Click
        slideout()
        notes.notesSlidein()
    End Sub

    Private Sub lite98Button_MouseDown(sender As Object, e As MouseEventArgs) Handles lite98Button.MouseDown
        lite98Button.BackgroundImage = My.Resources.Radio3
    End Sub

    Private Sub lite98Button_MouseEnter(sender As Object, e As EventArgs) Handles lite98Button.MouseEnter
        lite98Button.BackgroundImage = My.Resources.Radio1
    End Sub

    Private Sub lite98Button_MouseLeave(sender As Object, e As EventArgs) Handles lite98Button.MouseLeave
        If radioSelected = True Then
            lite98Button.BackgroundImage = My.Resources.Radio3
        Else
            lite98Button.BackgroundImage = My.Resources.Radio2
        End If
    End Sub

    Private Sub notesButton_MouseDown(sender As Object, e As MouseEventArgs) Handles notesButton.MouseDown
        notesButton.BackgroundImage = My.Resources.Notes3
    End Sub

    Private Sub notesButton_MouseEnter(sender As Object, e As EventArgs) Handles notesButton.MouseEnter
        notesButton.BackgroundImage = My.Resources.Notes1
    End Sub

    Private Sub notesButton_MouseLeave(sender As Object, e As EventArgs) Handles notesButton.MouseLeave
        If notesSelected = True Then
            notesButton.BackgroundImage = My.Resources.Notes3
        Else
            notesButton.BackgroundImage = My.Resources.Notes2
        End If
    End Sub

    Private Sub quicklaunchBtn_MouseClick(sender As Object, e As MouseEventArgs) Handles quicklaunchBtn.MouseClick
        quicklaunchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12)
        quicklaunchBtn.Text = ""
    End Sub

    Private Sub quicklaunchBtn_TextChanged(sender As Object, e As EventArgs) Handles quicklaunchBtn.TextChanged
        If quicklaunchBtn.Text <> "Quick Launch" Then
            quicklaunchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12)
        End If
    End Sub

    Private Sub exitLabel_Click(sender As Object, e As EventArgs) Handles exitLabel.Click
        Me.slideout()
        exitProgram.Show()
    End Sub
End Class