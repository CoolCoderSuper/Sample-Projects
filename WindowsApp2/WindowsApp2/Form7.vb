Imports AxWMPLib
Public Class Form7


    Private Sub AxWindowsMediaPlayer1_PlayStateChange(sender As Object, e As _WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer1.PlayStateChange
        If e.newState = 1 Then
            Me.Dispose()
        End If
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class