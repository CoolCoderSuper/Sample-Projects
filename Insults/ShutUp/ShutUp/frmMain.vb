Public Class frmMain

    Private Sub btnTryMe_Click(sender As Object, e As EventArgs) Handles btnTryMe.Click
        Dim g As String
        g = InputBox("enter name")
        Do Until g <> String.Empty
            g = InputBox("enter name")
        Loop
        If g.ToLower() = "joseph" Then
            MessageBox.Show("joseph is awesome!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!")
            MsgBox("ERROR", MessageBoxIcon.Error)
            Close()
        Else
            MessageBox.Show($"{g} sucks! Ha! Ha! Ha! Ha!")
        End If
    End Sub

    Private Sub btnOrMe_Click(sender As Object, e As EventArgs) Handles btnOrMe.Click
        If MessageBox.Show("Are you homer", String.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            frmHomer.Show()
        End If
    End Sub

End Class