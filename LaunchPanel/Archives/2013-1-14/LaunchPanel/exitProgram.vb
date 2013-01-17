Imports System.ComponentModel

Public Class exitProgram
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
End Class