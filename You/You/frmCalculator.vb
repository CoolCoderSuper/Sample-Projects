Public Class frmCalculator


    Private Sub ButtonClickMethod(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnDot.Click, btnEquals.Click, btnAdd.Click, btnSubtract.Click, btnMultiply.Click, btnDivide.Click, btnC.Click

        Dim button As Button = CType(sender, Button)

        If button.Name = "btn1" Then
            txtOutput.Text = txtOutput.Text + "1"
        End If

        If button.Name = "btn2" Then
            txtOutput.Text = txtOutput.Text + "2"
        End If

        If button.Name = "btn3" Then
            txtOutput.Text = txtOutput.Text + "3"
        End If

        If button.Name = "btn4" Then
            txtOutput.Text = txtOutput.Text + "4"
        End If

        If button.Name = "btn5" Then
            txtOutput.Text = txtOutput.Text + "5"
        End If

        If button.Name = "btn6" Then
            txtOutput.Text = txtOutput.Text + "6"
        End If

        If button.Name = "btn7" Then
            txtOutput.Text = txtOutput.Text + "7"
        End If

        If button.Name = "btn8" Then
            txtOutput.Text = txtOutput.Text + "8"
        End If

        If button.Name = "btn9" Then
            txtOutput.Text = txtOutput.Text + "9"
        End If

        If button.Name = "btn0" Then
            txtOutput.Text = txtOutput.Text + "0"
        End If

        If button.Name = "btnDot" Then
            txtOutput.Text = txtOutput.Text + "."
        End If

        If button.Name = "btnEquals" Then
            Dim strEquation As String = txtOutput.Text
            strEquation = strEquation.Replace("X", "*")
            Dim dtResult = New DataTable().Compute(strEquation, Nothing)
            txtOutput.Text = dtResult
        End If

        If button.Name = "btnMultiply" Then
            txtOutput.Text = txtOutput.Text + "X"
        End If

        If button.Name = "btnDivide" Then
            txtOutput.Text = txtOutput.Text + "/"
        End If

        If button.Name = "btnSubtract" Then
            txtOutput.Text = txtOutput.Text + "-"
        End If

        If button.Name = "btnAdd" Then
            txtOutput.Text = txtOutput.Text + "+"
        End If

        If button.Name = "btnC" Then
            txtOutput.Text = ""
        End If
    End Sub
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        If MessageBox.Show("do you want close this app? May result in great depression. If so please call 911", "Emergency!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Dispose()
        End If
        Me.Close()
    End Sub


End Class





