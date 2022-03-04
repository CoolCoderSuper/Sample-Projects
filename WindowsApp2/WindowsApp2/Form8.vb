Imports System.ComponentModel

Public Class Form8
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        End If
    End Sub



    Private Sub Form8_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form3.Show()
    End Sub
End Class