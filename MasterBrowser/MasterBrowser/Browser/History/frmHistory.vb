Public Class frmHistory
    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim historyp As New HistoryPanel
        historyp.Dock = DockStyle.Fill
        Controls.Add(historyp)
    End Sub
End Class