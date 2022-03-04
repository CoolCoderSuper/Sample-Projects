Public Class frmHomer

    Private Sub btnClickMe_Click(sender As Object, e As EventArgs) Handles btnClickMe.Click
        Size = New Size(1257, 489)
        btnClickMe.Size = New Size(1247, 278)
        Dim y As String
        y = InputBox("Answer")
        Do Until y <> String.Empty
            y = InputBox("enter name")
        Loop
        If y.ToLower() = "yes" Then
            Close()
            MsgBox("HOORAY, You are right!!", MsgBoxStyle.Exclamation, "Win")
        Else
            MsgBox("ERROR!! Answer invalid. Please enter a valid answer", MsgBoxStyle.Critical)
            Do Until y <> "yes"
                y = InputBox("enter name")
            Loop
        End If
    End Sub

End Class