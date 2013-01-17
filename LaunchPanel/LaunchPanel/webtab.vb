Public Class webtab
    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

    Private Sub webtab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim formloc As Point = New Point(screenWidth / 2 - Me.Width / 2, 0)
        Me.Location = formloc
        Me.Height = 0

        '''''''''''''

    End Sub
    Sub webtabSlidein()
        Me.Show()
        slideinTimer.Enabled = True
        slideoutTimer.Enabled = False
    End Sub
    Sub webtabSlideout()
        slideoutTimer.Enabled = True
        slideinTimer.Enabled = False
    End Sub

    Private Sub slideinTimer_Tick(sender As Object, e As EventArgs) Handles slideinTimer.Tick
        Do
            Me.Height += 2
            'Me.Refresh()
        Loop Until Me.Height = 546
        slideinTimer.Enabled = False
    End Sub

    Private Sub slideoutTimer_Tick(sender As Object, e As EventArgs) Handles slideoutTimer.Tick
        Do
            Me.Height -= 2
            'Me.Refresh()
        Loop Until Me.Height = 4
        Me.Hide()
        slideoutTimer.Enabled = False
        LaunchPanel.Show()
        LaunchPanel.slidein()
    End Sub

    Private Sub webAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles webAddress.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            browser.Navigate(webAddress.Text)
        End If
    End Sub

    Private Sub browser_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles browser.Navigated
        webAddress.Text = browser.Url.ToString
    End Sub

    Private Sub webSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles webSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            browser.Navigate("https://www.google.com/search?hl=en&q=" & webSearch.Text)
        End If
    End Sub

    Private Sub backBox_Click(sender As Object, e As EventArgs) Handles backBox.Click
        browser.GoBack()
    End Sub

    Private Sub forwardBox_Click(sender As Object, e As EventArgs) Handles forwardBox.Click
        browser.GoForward()
    End Sub

    Private Sub stopBox_Click(sender As Object, e As EventArgs) Handles stopBox.Click
        browser.Stop()
    End Sub

    Private Sub reloadBox_Click(sender As Object, e As EventArgs) Handles reloadBox.Click
        browser.Refresh()
    End Sub

    Private Sub homeBox_Click(sender As Object, e As EventArgs) Handles homeBox.Click
        browser.GoHome()
    End Sub

    Private Sub slideoutBox_Click(sender As Object, e As EventArgs) Handles slideoutBox.Click
        webtabSlideout()
    End Sub
End Class