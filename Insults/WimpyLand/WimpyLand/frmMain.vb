Public Class frmMain
    Public intRandom As Integer
    Public max, min

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If txtName.Text.Trim().Length = 0 Then
            txtLevel.Text = "enter name"
            Exit Sub
        End If
        txtName.ReadOnly = True
        frmLoad.ShowDialog()
    End Sub

End Class