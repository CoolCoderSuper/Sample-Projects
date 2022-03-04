Public Class Form2


    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If MessageBox.Show("do you want close this form? May result to mental issues!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim dbvalue1 As Double = txt1.Text
        Dim dbvalue2 As Double = txt2.Text
        Dim strOperator As String = txt4.Text
        'Dim numeric As Decimal = Decimal.Parse(txt3.Text)
        'Dim strNumeric As String = Format(numeric, "0,000")
        'If IsNumeric(str1) Then
        '    Dim intFromString As Integer = Integer.Parse(str1)
        'End If

        If strOperator = "-" Then
            txt3.Text = dbvalue1 - dbvalue2
        ElseIf strOperator = "+" Then
            txt3.Text = dbvalue1 + dbvalue2
        ElseIf strOperator = "*" Then
            txt3.Text = dbvalue1 * dbvalue2
        ElseIf strOperator = "/" Then
            txt3.Text = dbvalue1 / dbvalue2
        ElseIf strOperator = "^" Then
            txt3.Text = dbvalue1 ^ dbvalue2
        Else
            txt3.Text = "you have entered wrong data please check your brain"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt4.Text = ""
    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        btn2.Enabled = RadioButton2.Checked
        btn3.Enabled = RadioButton2.Checked
        txt1.Enabled = RadioButton2.Checked
        txt2.Enabled = RadioButton2.Checked
        txt3.Enabled = RadioButton2.Checked
        txt4.Enabled = RadioButton2.Checked
        Button41.Enabled = RadioButton2.Checked
        Button43.Enabled = RadioButton2.Checked
        Button42.Enabled = RadioButton2.Checked
        Button44.Enabled = RadioButton2.Checked
        Button45.Enabled = RadioButton2.Checked
        Button46.Enabled = RadioButton2.Checked

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\A.wav")
    End Sub
    Sub PlayBackgroundSoundFile(strFilePath As String)
        My.Computer.Audio.Play(strFilePath,
            AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\B.wav")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\C.wav")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\D.wav")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\E.wav")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\F.wav")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\G.wav")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\H.wav")
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\I.wav")
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\J.wav")
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\K.wav")
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\L.wav")
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\M.wav")
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\N.wav")
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\O.wav")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\P.wav")
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\Q.wav")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\R.wav")
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\S.wav")
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\T.wav")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\U.wav")
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\V.wav")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\W.wav")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\X.wav")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\Y.wav")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\Z.wav")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\ALPHABET.wav")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        Dim x As String
        x = InputBox("enter password")
        If x = "Newyears18" Then
            Form7.AxWindowsMediaPlayer1.URL = "C:\Users\Joseph\Music\Youtube\.mp3\Funny Male Crying Sound in High QUality.mp3"
            Form7.ShowDialog()
            MessageBox.Show("😯😪😓")
            Me.Dispose()
            Form11.Dispose()
        Else
            Form7.AxWindowsMediaPlayer1.URL = "C:\Users\Joseph\Music\Youtube\.mp3\Funny Laugh SOUND EFFECT.mp3"
            Form7.ShowDialog()
            MessageBox.Show("😜🤣")

        End If

        'Turn of computer
        'Shell("Shutdown) -r -t 50")
        'Application.Exit()

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\NUMBERS.wav")
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\1.wav")
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\2.wav")
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\3.wav")
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\4.wav")
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\5.wav")
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\6.wav")
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\7.wav")
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\8.wav")
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\9.wav")
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        PlayBackgroundSoundFile("C:\Users\Joseph\Documents\Audacity\10.wav")
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Form6.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Dim pi As Double = 3.14159265359
        txt1.Text = pi
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        Dim er As Double = 2.7182818284590451
        txt1.Text = er
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Dim Number As Integer = txt1.Text

        Dim fac As Integer = 1
        Dim k As Integer
        For k = Val(txt1.Text) To 1 Step -1
            fac *= k
        Next
        txt3.Text = fac
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Dim qa As Integer = txt1.Text
        txt3.Text = qa ^ 2
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Dim qa As Integer = txt1.Text
        txt3.Text = qa ^ 3
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Dim qa As Integer = txt1.Text
        txt3.Text = 10 ^ qa
    End Sub
End Class