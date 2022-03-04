Public Class frmMain
    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        If txtInPlain.Text <> String.Empty And txtKey1.Text <> String.Empty Then
            Try
                txtOutEnc.Text = EncryptTripleDES(txtInPlain.Text, txtKey1.Text)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try
        Else
            MsgBox("Enter info!!!", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        If txtInEnc.Text <> String.Empty And txtKey2.Text <> String.Empty Then
            Try
                txtOutPlain.Text = DecryptTripleDES(txtInPlain.Text, txtKey1.Text)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            End Try
        Else
            MsgBox("Enter info!!!", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub
End Class
