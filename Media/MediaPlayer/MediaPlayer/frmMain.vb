Public Class frmMain

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ofd.ShowDialog()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        player.Ctlcontrols.play()
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        player.Ctlcontrols.pause()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        player.Ctlcontrols.stop()
    End Sub

    Private Sub btnFastReverse_Click(sender As Object, e As EventArgs) Handles btnFastReverse.Click
        player.Ctlcontrols.fastReverse()
    End Sub

    Private Sub btnFastForward_Click(sender As Object, e As EventArgs) Handles btnFastForward.Click
        player.Ctlcontrols.fastForward()
    End Sub

    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        player.Ctlcontrols.previous()
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        player.Ctlcontrols.next()
    End Sub

    Private Sub ofd_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofd.FileOk
        player.URL = ofd.FileName
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles tbVolume.Scroll
        player.settings.volume = tbVolume.Value
    End Sub

End Class