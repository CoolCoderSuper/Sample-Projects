Public Class frmMain

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim fac As Integer = 1
        Dim k As Integer
        For k = txtInput.Value To 1 Step -1
            fac *= k
        Next
        lblAnswer.Text = fac
    End Sub

End Class