Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("this is a first test " & vbNewLine & txtField1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button1.Enabled = False Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dbvalue1 As Double = txtField1.Text
        Dim dbvalue2 As Double = txtField2.Text
        Dim strOperator As String = txtOperator.Text

        If strOperator = "-" Then
            txtAnswer.Text = dbvalue1 - dbvalue2
        ElseIf strOperator = "+" Then
            txtAnswer.Text = dbvalue1 + dbvalue2
        ElseIf strOperator = "*" Then
            txtAnswer.Text = dbvalue1 * dbvalue2
        ElseIf strOperator = "/" Then
            txtAnswer.Text = dbvalue1 / dbvalue2
        Else
            txtAnswer.Text = "you have entered wrong data please check your brain"
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmWord.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        frmCalculator.Show()
    End Sub
End Class
