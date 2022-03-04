Public Class frmMain

    Private Sub ControlFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlFormToolStripMenuItem.Click
        frmChild.MdiParent = Me
        frmChild.Show()
    End Sub

End Class