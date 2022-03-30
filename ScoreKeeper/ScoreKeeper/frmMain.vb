Public Class frmMain
    Private objGame As Game
    Private strPath As String
    Private bIsNew As Boolean = True

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text.Trim() <> String.Empty Then
            lstPlayers.Items.Add(txtName.Text)
            objGame.Players.Add(New Player With {.Name = txtName.Text})
            txtName.Clear()
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objGame = New Game
        Reload()
    End Sub

    Private Sub lstPlayers_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstPlayers.SelectedValueChanged
        lstScores.Items.Clear()
        For Each s As Integer In objGame.Players.Where(Function(x) x.Name = lstPlayers.SelectedItem).FirstOrDefault().Scores
            lstScores.Items.Add(s)
        Next
    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        lstScores.Items.Add(txtScore.Value)
        objGame.Players.Where(Function(x) x.Name = lstPlayers.SelectedItem).FirstOrDefault().Scores.Add(txtScore.Value)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not txtGameName.Text.Trim() = String.Empty Then
            If bIsNew Then
                Dim objGameManager As New GameManager With {.Path = My.Application.LibraryPath}
                strPath = $"{IO.Directory.GetParent(My.Application.LibraryPath).FullName}\{txtGameName.Text}.game"
                objGameManager.Library.Add(strPath, objGame)
                objGameManager.Save()
            End If
            GameManager.Save(strPath, objGame)
        Else
            MsgBox("Enter a game name!", MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dim objGameKey As KeyValuePair(Of String, Game) = frmLibrary.ShowLibrary()
        If objGameKey.Key IsNot Nothing AndAlso objGameKey.Value IsNot Nothing Then
            strPath = objGameKey.Key
            objGame = objGameKey.Value
            bIsNew = False
        End If
        Reload()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        objGame = New Game
        bIsNew = True
        Reload()
    End Sub

    Private Sub Reload()
        Try
            txtGameName.DataBindings.RemoveAt(0)
        Catch ex As Exception

        End Try
        txtGameName.DataBindings.Add("Text", objGame, "Name")
        lstPlayers.Items.Clear()
        lstScores.Items.Clear()
        For Each p As Player In objGame.Players
            lstPlayers.Items.Add(p.Name)
        Next
    End Sub

End Class