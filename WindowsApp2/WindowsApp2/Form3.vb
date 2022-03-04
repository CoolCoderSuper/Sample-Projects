Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\HI.wav")
        Form11.Hide()
    End Sub
    Private Sub Form3_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Form11.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y As String
        y = InputBox("enter password")
        If y = "joseph" Then
            Form1.Show()
            Me.Dispose()
        ElseIf y = "" Then
            Form8.Dispose()
        Else
            Form8.Show()
            Me.Dispose()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
        Form11.Dispose()
    End Sub
    Sub PlayBackgroundSoundFile(strFilePath As String)
        My.Computer.Audio.Play(strFilePath,
            AudioPlayMode.WaitToComplete)
    End Sub
End Class