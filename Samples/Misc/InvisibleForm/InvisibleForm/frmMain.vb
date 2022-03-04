Public Class frmMain

    Private moverect As New Rectangle(10, 10, 32, 32)
    Private moving As Drag = Drag.DISABLED

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TransparencyKey = BackColor
    End Sub

    Private Sub frmMain_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If moverect.Contains(e.Location) Then moving = Drag.ENABLED
    End Sub

    Private Sub frmMain_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If moving = Drag.ENABLED Then moving = Drag.DISABLED
    End Sub

    Private Sub frmMain_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If moving = Drag.ENABLED Then
            Location = New Point((Location.X + e.X) - moverect.X, (Location.Y + e.Y) - moverect.Y)
        End If
    End Sub

    Public Enum Drag
        ENABLED
        DISABLED
    End Enum

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

End Class