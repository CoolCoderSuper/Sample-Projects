Imports AxWMPLib

Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        AxWindowsMediaPlayer1.URL = "C:\Users\Joseph\Pictures\Saved Pictures\awesome.mp4"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim x As String
        x = InputBox("enter password")
        If x = "Newyears18" Then
            Form7.AxWindowsMediaPlayer1.URL = "C:\Users\Joseph\Music\Youtube\.mp3\Funny Male Crying Sound in High QUality.mp3"
            Form7.ShowDialog()
            MessageBox.Show("😯😪😓")
            Me.Dispose()
            Form2.Dispose()
            Form11.Dispose()
        Else
            Form7.AxWindowsMediaPlayer1.URL = "C:\Users\Joseph\Music\Youtube\.mp3\Funny Laugh SOUND EFFECT.mp3"
            Form7.ShowDialog()
            MessageBox.Show("😜🤣")

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub
End Class