'Imports System.Speech.Recognition
'Imports System.Threading
'Imports System.Globalization
'Public Class visualTop
'    ' recogniser & grammar
'    Dim recog As New SpeechRecognizer
'    Dim gram As Grammar
'    ' events
'    Public Event SpeechRecognized As  _
'        EventHandler(Of SpeechRecognizedEventArgs)
'    Public Event SpeechRecognitionRejected As  _
'        EventHandler(Of SpeechRecognitionRejectedEventArgs)
'    ' word list
'    Dim wordlist As String() = New String() {"Yes", "No", "Maybe", "Exit"}
'    ' word recognised event
'    Public Sub recevent(ByVal sender As System.Object, _
'            ByVal e As RecognitionEventArgs)
'        LabelYes.ForeColor = Color.LightGray
'        LabelNo.ForeColor = Color.LightGray
'        LabelMaybe.ForeColor = Color.LightGray
'        If (e.Result.Text = "Yes") Then
'            LabelYes.ForeColor = Color.Blue
'        ElseIf (e.Result.Text = "No") Then
'            LabelNo.ForeColor = Color.Blue
'        ElseIf (e.Result.Text = "Maybe") Then
'            LabelMaybe.ForeColor = Color.Blue
'        ElseIf (e.Result.Text = "Exit") Then
'            Application.Exit()
'        End If
'    End Sub
'    ' recognition failed event
'    Public Sub recfailevent(ByVal sender As System.Object, _
'            ByVal e As RecognitionEventArgs)
'        LabelYes.ForeColor = Color.LightGray
'        LabelNo.ForeColor = Color.LightGray
'        LabelMaybe.ForeColor = Color.LightGray
'    End Sub
'    ' form initialisation
'    Private Sub Form1_Load(ByVal sender As System.Object, _
'            ByVal e As System.EventArgs) Handles MyBase.Load
'        ' need these to get British English rather than default US
'        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")
'        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-GB")
'        ' convert the word list into a grammar
'        Dim words As New Choices(wordlist)
'        gram = New Grammar(New GrammarBuilder(words))
'        recog.LoadGrammar(gram)
'        ' add handlers for the recognition events
'        AddHandler recog.SpeechRecognized, AddressOf Me.recevent
'        AddHandler recog.SpeechRecognitionRejected, AddressOf Me.recfailevent
'        ' enable the recogniser
'        recog.Enabled = True
'    End Sub
'End Class


'Private Sub visualTop_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    synth.SpeakAsync("setting the back color to ")
'    Dim gram As New SrgsDocument

'    Dim colorRule As New SrgsRule("color")

'    Dim colorsList As New SrgsOneOf("red", "green")

'    colorRule.Add(colorsList)

'    gram.Rules.Add(colorRule)

'    gram.Root = colorRule

'    reco.LoadGrammar(New Recognition.Grammar(gram))
'End Sub
'Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized

'    Select Case e.Result.Text

'        Case "red"

'            synth.SpeakAsync("red")

'        Case "green"

'            synth.SpeakAsync("green")

'    End Select
'End Sub

Imports System.Speech

Public Class visualTop

    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine

    Private Sub SetColor(ByVal color As System.Drawing.Color)

        Dim synth As New Synthesis.SpeechSynthesizer

        synth.SpeakAsync("setting the back color to " + color.ToString)

        Me.BackColor = color

    End Sub


    Private Sub visualTop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        reco.SetInputToDefaultAudioDevice()

        Dim gram As New Recognition.SrgsGrammar.SrgsDocument

        Dim colorRule As New Recognition.SrgsGrammar.SrgsRule("color")

        Dim colorsList As New Recognition.SrgsGrammar.SrgsOneOf("set the color to red", "set the color to green", "set the color to blue", "set the color to yellow", "exit")

        colorRule.Add(colorsList)

        gram.Rules.Add(colorRule)

        gram.Root = colorRule

        reco.LoadGrammar(New Recognition.Grammar(gram))

        reco.RecognizeAsync()

    End Sub

    Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles reco.RecognizeCompleted

        reco.RecognizeAsync()

    End Sub

    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized

        Select Case e.Result.Text

            Case "set the color to red"

                SetColor(Color.Red)

            Case "set the color to green"

                SetColor(Color.Green)

            Case "set the color to blue"

                SetColor(Color.Blue)

            Case "set the color to yellow"

                SetColor(Color.Yellow)

            Case "exit"
                Process.GetCurrentProcess.Kill()
        End Select

    End Sub

End Class