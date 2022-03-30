Public Class frmLibrary
    Private objManager As GameManager
    Private bCancel As Boolean = False

    Private Sub frmLibrary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objManager = New GameManager
        objManager.Path = My.Application.LibraryPath
        Reload()
    End Sub

    Private Sub Reload()
        lstLibrary.Items.Clear()
        lstLibrary.Tag = New List(Of String)
        For Each g As KeyValuePair(Of String, Game) In objManager.Library
            lstLibrary.Items.Add(g.Value.Name)
            lstLibrary.Tag.Add(g.Key)
        Next
    End Sub

    Public Function ShowLibrary() As KeyValuePair(Of String, Game)
        ShowDialog()
        Return If(bCancel, Nothing, New KeyValuePair(Of String, Game)(lstLibrary.Tag(lstLibrary.SelectedIndex), objManager.Library(lstLibrary.Tag(lstLibrary.SelectedIndex))))
    End Function

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        bCancel = True
        Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ofd As New OpenFileDialog With {.Multiselect = False, .RestoreDirectory = True, .FilterIndex = 0, .Filter = "Game files (*.game)|*.game"}
        If ofd.ShowDialog() = DialogResult.OK Then
            objManager.Library.Add(ofd.FileName, Game.Parse(ofd.FileName))
            objManager.Save()
            Reload()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        objManager.Library.Remove(lstLibrary.Tag(lstLibrary.SelectedIndex))
        objManager.Save()
        Reload()
    End Sub

End Class