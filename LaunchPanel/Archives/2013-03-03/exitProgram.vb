Imports System.ComponentModel
Public Class exitProgram
    Dim n As Integer = 0
    'titleLbl.Text = "Please wait."
    'titleLbl.Text = "Please wait.."
    'titleLbl.Text = "Please wait..."

    Private Sub pwTimer_Tick(sender As Object, e As EventArgs) Handles pwTimer.Tick
        If titleLbl.Text = "Please wait.." Then
            titleLbl.Text = "Please wait..."
        ElseIf titleLbl.Text = "Please wait..." Then
            titleLbl.Text = "Please wait."
        ElseIf titleLbl.Text = "Please wait." Then
            titleLbl.Text = "Please wait.."
        End If

    End Sub

    Private Sub exitProgram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        notes.notesTextBox.SaveFile(My.Settings.homeDirectory & "notes.rtf")
        shutdownTimer.Enabled = True
    End Sub
    'disables close
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Private Sub shutdownTimer_Tick(sender As Object, e As EventArgs) Handles shutdownTimer.Tick
        n = n + 1
        If n = 9 Then
            Application.Exit()
        End If
    End Sub
End Class