Public Class Form5
    Dim x As IO.StreamWriter
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If btnCancel.Text = "close" Then
            'close whole application
            Me.Dispose()
            Form1.Dispose()
            Form11.Dispose()
        Else
            'otherwise just close form and go back to form1
            Me.DialogResult = DialogResult.OK
            Me.Dispose()
            Form1.Show()
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        TextBox1.Text = ""
        MessageBox.Show("thanks for sending us your feedback for the future")
        btnCancel.Text = "close"
        If btnSend.Enabled = False Then
            btnSend.Enabled = True
        Else
            btnSend.Enabled = False
        End If
        'loadTextBox1()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCrash_Click(sender As Object, e As EventArgs) Handles btnCrash.Click
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