Public Class frmWord
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(txtLocation.Text, True)
        file.WriteLine(txtInput.Text)
        file.Close()
    End Sub




    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            txtLocation.Text = fd.FileName
            txtInput.Text = My.Computer.FileSystem.ReadAllText(txtLocation.Text)
        End If
    End Sub

    Private Sub frmWord_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class