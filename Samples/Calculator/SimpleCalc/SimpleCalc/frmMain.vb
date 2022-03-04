Public Class frmMain

    Private Sub ButtonClickMethod(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btnAdd.Click, btnDivide.Click, btnMinus.Click, btnMultiply.Click, btnPoint.Click, btnEquals.Click, btnClear.Click

        Dim button As Button = CType(sender, Button)

        If Name = "btn1" Then
            txtResult.Text = $"{txtResult.Text}1"
        End If

        If button.Name = "btn2" Then
            txtResult.Text = $"{txtResult.Text}2"
        End If

        If button.Name = "btn3" Then
            txtResult.Text = $"{txtResult.Text}3"
        End If

        If button.Name = "btn4" Then
            txtResult.Text = $"{txtResult.Text}4"
        End If

        If button.Name = "btn5" Then
            txtResult.Text = $"{txtResult.Text}5"
        End If

        If button.Name = "btn6" Then
            txtResult.Text = $"{txtResult.Text}6"
        End If

        If button.Name = "btn7" Then
            txtResult.Text = $"{txtResult.Text}7"
        End If

        If button.Name = "btn8" Then
            txtResult.Text = $"{txtResult.Text}8"
        End If

        If button.Name = "btn9" Then
            txtResult.Text = $"{txtResult.Text}9"
        End If

        If button.Name = "btn0" Then
            txtResult.Text = $"{txtResult.Text}0"
        End If

        If button.Name = "btnPoint" Then
            txtResult.Text = $"{txtResult.Text}."
        End If

        If button.Name = "btnEquals" Then
            Dim equation As String = txtResult.Text
            Dim result = New DataTable("Calculator").Compute(equation, Nothing)
            txtResult.Text = result
        End If

        If button.Name = "btnMultiply" Then
            txtResult.Text = $"{txtResult.Text}*"
        End If

        If button.Name = "btnDivide" Then
            txtResult.Text = $"{txtResult.Text}/"
        End If

        If button.Name = "btnAdd" Then
            txtResult.Text = $"{txtResult.Text}+"
        End If

        If button.Name = "btnMinus" Then
            txtResult.Text = $"{txtResult.Text}-"
        End If

        If button.Name = "btnClear" Then
            txtResult.Text = String.Empty
        End If

    End Sub

    Private Sub btnBackspace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackspace.Click
        If txtResult.Text < " " Then
            txtResult.Text = Mid(txtResult.Text, 1, Len(txtResult.Text) - 1 + 1)
        Else
            txtResult.Text = Mid(txtResult.Text, 1, Len(txtResult.Text) - 1)
        End If
    End Sub

End Class