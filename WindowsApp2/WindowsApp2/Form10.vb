
Public Class Form10

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As String
        x = InputBox("enter password")
        If x = "Newyears18" Then
            Form7.AxWindowsMediaPlayer1.URL = "C:\Users\Joseph\Music\Youtube\.mp3\Funny Male Crying Sound in High QUality.mp3"
            Form7.ShowDialog()
            MessageBox.Show("😯😪😓")
            Me.Dispose()

        Else
            Form7.AxWindowsMediaPlayer1.URL = "C:\Users\Joseph\Music\Youtube\.mp3\Funny Laugh SOUND EFFECT.mp3"
            Form7.ShowDialog()
            MessageBox.Show("😜🤣")

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Me.Dispose()
        Form7.Show()
        Form7.AxWindowsMediaPlayer1.URL = "C:\Users\Joseph\Pictures\Saved Pictures\awesome.mp4"
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Dim g As String
        g = InputBox("question")
        Me.Dispose()
        MessageBox.Show("it has been sent. keep working!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!")
    End Sub
End Class