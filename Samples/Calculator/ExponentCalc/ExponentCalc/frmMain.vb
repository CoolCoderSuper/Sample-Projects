Public Class frmMain
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        txtResult.Text = txtNum1.Value ^ txtNum2.Value
    End Sub
End Class
