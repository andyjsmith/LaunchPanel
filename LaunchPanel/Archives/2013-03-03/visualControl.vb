Public Class visualControl
    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
    Private Sub visualControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        visualTop.Show()
    End Sub

    Private Sub visualControl_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Me.Focus()
    End Sub

    Private Sub visualControl_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        visualTop.Activate()
    End Sub
End Class