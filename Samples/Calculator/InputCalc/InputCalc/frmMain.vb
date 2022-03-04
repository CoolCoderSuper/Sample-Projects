Public Class frmMain

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        Select Case cbxOp.Text
            Case "+"
                txtAnswer.Text = txtNum1.Value + txtNum2.Value
            Case "-"
                txtAnswer.Text = txtNum1.Value - txtNum2.Value
            Case "*"
                txtAnswer.Text = txtNum1.Value * txtNum2.Value
            Case "/"
                txtAnswer.Text = txtNum1.Value / txtNum2.Value
        End Select
    End Sub

End Class