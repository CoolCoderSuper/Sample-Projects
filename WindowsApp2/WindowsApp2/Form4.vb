Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = DialogResult.OK
        Me.Dispose()
        MessageBox.Show("thanks for sending us your feedback for the future")
        Form11.Dispose()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.DialogResult = DialogResult.Cancel
        Form5.Show()
        Me.Dispose()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Dispose()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As String
        x = InputBox("enter password")
        If x = "Newyears18" Then
            Form7.AxWindowsMediaPlayer1.URL = "C:\Users\Joseph\Music\Youtube\.mp3\Funny Male Crying Sound in High QUality.mp3"
            Form7.ShowDialog()
            MessageBox.Show("😯😪😓")
            Me.DialogResult = DialogResult.OK
            Me.Dispose()
            Form11.Dispose()
        Else
            Form7.AxWindowsMediaPlayer1.URL = "C:\Users\Joseph\Music\Youtube\.mp3\Funny Laugh SOUND EFFECT.mp3"
            Form7.ShowDialog()
            MessageBox.Show("😜🤣")

        End If
    End Sub
End Class
