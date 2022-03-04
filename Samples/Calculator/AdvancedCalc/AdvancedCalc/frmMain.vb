Public Class frmMain

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click, btnPoint.Click, btnMultiply.Click, btnDivide.Click, btnAdd.Click, btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click, btnpi.Click, btne.Click
        txtValue.Text &= sender.Tag
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtValue.Clear()
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        Dim equation As String = txtValue.Text.Replace("X", "*").Replace("÷", "/").Replace("e", "2.7182818284590452353602874713527").Replace("π", "3.14159265358979323846")
        Try
            Dim result = New DataTable("Calculator").Compute(equation, Nothing)
            txtValue.Text = result
        Catch ex As Exception
            If IsNumeric(txtValue.Text) = False Then
                txtValue.Text = "Please enter numeric characters!!"
            Else
                txtValue.Text = "∞"
            End If
        End Try
    End Sub

    Private Sub btnSquared_Click(sender As Object, e As EventArgs) Handles btnSquared.Click

    End Sub

    Private Sub btnCubed_Click(sender As Object, e As EventArgs) Handles btnCubed.Click

    End Sub

    Private Sub btntentoxpower_Click(sender As Object, e As EventArgs) Handles btntentoxpower.Click
        Dim qa As Double = txtValue.Text
        Dim answer As Double = 10 ^ qa
        txtValue.Text = answer
    End Sub

    Private Sub btn1dx_Click(sender As Object, e As EventArgs) Handles btn1dx.Click
        Dim qa As Double = txtValue.Text
        Dim answer As Double = 1 / qa
        txtValue.Text = answer
    End Sub

    Private Sub btnnegative_Click(sender As Object, e As EventArgs) Handles btnnegative.Click
        txtValue.Text += "-"
    End Sub

    Private Sub btnfactorial_Click(sender As Object, e As EventArgs) Handles btnfactorial.Click
        Dim fac As Integer = 1
        Dim k As Integer
        For k = Val(txtValue.Text) To 1 Step -1
            fac *= k
        Next
        txtValue.Text = fac
    End Sub

    Private Sub btnsquareroot_Click(sender As Object, e As EventArgs) Handles btnsquareroot.Click
        Dim de As Double = txtValue.Text
        Dim answer As Double = Math.Sqrt(de)
        txtValue.Text = answer
    End Sub

    Private Sub btnsimple_Click(sender As Object, e As EventArgs) Handles btnSimple.Click
        Text = "Simple Calculator"
        btnpi.Hide()
        btne.Hide()
        btnSquared.Hide()
        btnCubed.Hide()
        btnfactorial.Hide()
        btnsquareroot.Hide()
        btntentoxpower.Hide()
        btn1dx.Hide()
        btnnegative.Hide()
        btnEquals.Location = New Point(13, 388)
        btnSimple.Location = New Point(13, 457)
        btnAdvanced.Location = New Point(13, 486)
        Height = 551
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnpi.Hide()
        btne.Hide()
        btnSquared.Hide()
        btnCubed.Hide()
        btnfactorial.Hide()
        btnsquareroot.Hide()
        btntentoxpower.Hide()
        btn1dx.Hide()
        btnnegative.Hide()
        btnEquals.Location = New Point(13, 388)
        btnSimple.Location = New Point(13, 457)
        btnAdvanced.Location = New Point(13, 486)
        Height = 551
    End Sub

    Private Sub btnadvanced_Click(sender As Object, e As EventArgs) Handles btnAdvanced.Click
        Text = "Advanced Calculator"
        btnpi.Show()
        btne.Show()
        btnSquared.Show()
        btnCubed.Show()
        btnfactorial.Show()
        btnsquareroot.Show()
        btntentoxpower.Show()
        btn1dx.Show()
        btnnegative.Show()
        btnEquals.Location = New Point(13, 595)
        btnSimple.Location = New Point(13, 664)
        btnAdvanced.Location = New Point(13, 693)
        Height = 762
    End Sub


End Class
