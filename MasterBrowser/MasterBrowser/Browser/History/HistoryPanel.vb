Public Class HistoryPanel
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        History.Clear()
        Reload()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        For Each item As ListViewItem In lvHistory.SelectedItems
            History.RemoveAt(item.Index)
        Next
        Reload()
    End Sub

    Private Sub HistoryPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Public Sub Reload()
        lvHistory.Items.Clear()
        History.ForEach(Sub(x) lvHistory.Items.Add(New ListViewItem({x.Time, x.URL})))
    End Sub
End Class
