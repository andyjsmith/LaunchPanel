Imports System.Runtime.InteropServices

Public Class LaunchPanel
    Dim appdata As String = Environ("APPDATA")
    <DllImport("user32.dll")> _
    Private Shared Function GetAsyncKeyState(ByVal vKey As Integer) As UShort
    End Function
    Public isSlidOut As Boolean = False
    'Variables
    ':For Home:
    Dim homeSelected As Boolean = True
    Dim radioSelected As Boolean = False
    Dim notesSelected As Boolean = False
    Dim webSelected As Boolean = False
    Dim tasksSelected As Boolean = False
    Dim todoSelected As Boolean = False
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
    Sub autoAdjust()
        'Adjusting to fit monitor
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim formloc As Point = New Point(screenWidth / 2 - Me.Width / 2, 0)
        Me.Location = formloc
        Me.Width = screenWidth

        'Adjust minimize button
        Dim closeBtnLoc As Point = New Point(screenWidth / 2 - closeButton.Width / 2, 370)
        closeButton.Location = closeBtnLoc
        

    End Sub

    Private Sub LaunchPanel_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            'Setting up the environment - getting directories

            My.Settings.homeDirectory = appdata & "\GitBit\LaunchPanel\"
            'Insert timestamp file
            My.Computer.FileSystem.CreateDirectory(My.Settings.homeDirectory & "\ini")
            Dim file As System.IO.FileStream
            file = System.IO.File.Create(My.Settings.homeDirectory & "\ini\" & Date.Now.ToString("MM dd yy hh mm") & ".log")
        Catch ex As Exception
            If My.Settings.alreadyValidated = False Then
                MessageBox.Show(ex.Message)
                My.Settings.alreadyValidated = True
            End If
        End Try

        'The rest of it
        autoAdjust()
        keypressTimer.Enabled = True
        Me.Height = 0
        slidein()
        isSlidOut = False

    End Sub

    Private Sub slideinTimer_Tick(sender As System.Object, e As System.EventArgs) Handles slideinTimer.Tick
        'Making buttons not lag :P
        YouWidgetBtn.Visible = False
        blcBtn.Visible = False
        namesuggesterBtn.Visible = False
        toolproBtn.Visible = False
        'End button lag
        Me.Refresh()
        Do
            Me.Height += 2
            ' Me.Refresh()
        Loop Until Me.Height = 400

        slideinTimer.Enabled = False

        'Make buttons visible again
        YouWidgetBtn.Visible = True
        blcBtn.Visible = True
        namesuggesterBtn.Visible = True
        toolproBtn.Visible = True
    End Sub

    Private Sub slideoutTimer_Tick(sender As System.Object, e As System.EventArgs) Handles slideoutTimer.Tick

        'Making buttons not lag :P
        YouWidgetBtn.Visible = False
        blcBtn.Visible = False
        namesuggesterBtn.Visible = False
        toolproBtn.Visible = False
        'End button lag

        Me.Refresh()
        Do
            Me.Height -= 2
            ' Me.Refresh()
        Loop Until Me.Height = 4
        Me.Hide()
        slideoutTimer.Enabled = False
        Me.Refresh()

        'Make buttons visible again
        YouWidgetBtn.Visible = True
        blcBtn.Visible = True
        namesuggesterBtn.Visible = True
        toolproBtn.Visible = True
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
                ElseIf webtab.Visible = True Then
                    webtab.webtabSlideout()
                ElseIf taskmanager.Visible = True Then
                    taskmanager.taskmanagerSlideout()
                ElseIf todo.Visible = True Then
                    todo.todoSlideout()
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

    Private Sub webButton_Click(sender As Object, e As EventArgs) Handles webButton.Click
        slideout()
        webtab.webtabSlidein()
    End Sub

    Private Sub webButton_MouseDown(sender As Object, e As MouseEventArgs) Handles webButton.MouseDown
        webButton.BackgroundImage = My.Resources.Web3
    End Sub

    Private Sub webButton_MouseEnter(sender As Object, e As EventArgs) Handles webButton.MouseEnter
        webButton.BackgroundImage = My.Resources.Web1
    End Sub

    Private Sub webButton_MouseLeave(sender As Object, e As EventArgs) Handles webButton.MouseLeave
        If webSelected = True Then
            webButton.BackgroundImage = My.Resources.Web3
        Else
            webButton.BackgroundImage = My.Resources.Web2
        End If
    End Sub

    Private Sub tasksButton_MouseClick(sender As Object, e As MouseEventArgs) Handles tasksButton.MouseClick
        slideout()
        taskmanager.taskmanagerSlidein()
    End Sub

    Private Sub tasksButton_MouseDown(sender As Object, e As MouseEventArgs) Handles tasksButton.MouseDown
        tasksButton.BackgroundImage = My.Resources.tasks3
    End Sub

    Private Sub tasksButton_MouseEnter(sender As Object, e As EventArgs) Handles tasksButton.MouseEnter
        tasksButton.BackgroundImage = My.Resources.tasks1
    End Sub

    Private Sub tasksButton_MouseLeave(sender As Object, e As EventArgs) Handles tasksButton.MouseLeave
        If tasksSelected = True Then
            tasksButton.BackgroundImage = My.Resources.tasks3
        Else
            tasksButton.BackgroundImage = My.Resources.tasks2
        End If
    End Sub

    Private Sub todoButton_MouseClick(sender As Object, e As EventArgs) Handles todoButton.MouseClick
        slideout()
        todo.todoSlidein()
    End Sub

    Private Sub todoButton_MouseDown(sender As Object, e As MouseEventArgs) Handles todoButton.MouseDown
        todoButton.BackgroundImage = My.Resources.todo3
    End Sub

    Private Sub todoButton_MouseEnter(sender As Object, e As EventArgs) Handles todoButton.MouseEnter
        todoButton.BackgroundImage = My.Resources.todo1
    End Sub

    Private Sub todoButton_MouseLeave(sender As Object, e As EventArgs) Handles todoButton.MouseLeave
        If todoSelected = True Then
            todoButton.BackgroundImage = My.Resources.todo3
        Else
            todoButton.BackgroundImage = My.Resources.todo2
        End If
    End Sub

    Private Sub settingsIcon_Click(sender As Object, e As EventArgs) Handles settingsIcon.Click
        Me.slideout()
        settings.Show()
    End Sub

    'Public Function GetSettingItem(ByVal File As String, ByVal Identifier As String) As String
    '    Dim S As New IO.StreamReader(File) : Dim result As String = ""
    '    Do While (S.Peek <> -1)
    '        Dim Line As String = S.ReadLine
    '        If Line.ToLower.StartsWith(Identifier.ToLower & ":") Then
    '            result = Line.Substring(Identifier.Length + 2)
    '        End If
    '    Loop
    '    Return result
    'End Function

    Private Sub todoButton_MouseClick(sender As Object, e As MouseEventArgs) Handles todoButton.MouseClick

    End Sub

    Private Sub YouWidgetBtn_Click(sender As Object, e As EventArgs) Handles YouWidgetBtn.Click
        Try
            Process.Start(My.Settings.homeDirectory & "YouWidget.exe")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Execution Failed")
        End Try
        slideout()
    End Sub

    Private Sub namesuggesterBtn_Click(sender As Object, e As EventArgs) Handles namesuggesterBtn.Click
        Try
            Process.Start(My.Settings.homeDirectory & "Suggester.exe")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Execution Failed")
        End Try
        slideout()
    End Sub

    Private Sub blcBtn_Click(sender As Object, e As EventArgs) Handles blcBtn.Click
        Try
            Process.Start(My.Settings.homeDirectory & "Bitly.exe")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Execution Failed")
        End Try
        slideout()
    End Sub

    Private Sub toolproBtn_Click(sender As Object, e As EventArgs) Handles toolproBtn.Click
        Try
            Process.Start(My.Settings.homeDirectory & "ToolPro.exe")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Execution Failed")
        End Try
        slideout()
    End Sub
End Class