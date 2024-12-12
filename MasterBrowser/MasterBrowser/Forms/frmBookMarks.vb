Public Class frmBookMarks
    'Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
    '    lstbookmarks.Items.RemoveAt(lstbookmarks.SelectedIndex)
    '    For Each b As String In lstbookmarks.Items
    '        My.Settings.Bookmarks = b + ";"
    '    Next
    '    If My.Settings.Bookmarks.LastIndexOf(";") = My.Settings.Bookmarks.Length - 1 Then
    '        Dim newstring As String = ""
    '        Dim count As Integer = 0
    '        For Each b As Char In My.Settings.Bookmarks
    '            If Not count = My.Settings.Bookmarks.Length Then
    '                newstring &= b
    '                count += 1
    '            End If
    '        Next
    '    End If
    'End Sub
    'Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
    '    lstbookmarks.Items.Clear()
    '    My.Settings.Bookmarks = ""
    'End Sub
    'Private Sub btngo_Click(sender As Object, e As EventArgs) Handles btngo.Click
    '    frmMain.tbmain.SelectedTab = frmMain.pagemain
    '    Dispose()
    'End Sub

    'Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
    '    Dispose()
    'End Sub

    'Private Sub frmbookmarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    lstbookmarks.Items.Clear()
    '    For Each b As String In My.Settings.Bookmarks.Split(";")
    '        lstbookmarks.Items.Add(b)
    '    Next
    'End Sub

End Class