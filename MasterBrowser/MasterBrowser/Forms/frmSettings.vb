Imports System.ComponentModel

Public Class frmSettings
    Private Sub btnsave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsave.Click
        'My.Settings.HomePage = cbxpage.Text + ".com"
        'If rdaskme.Checked = True Then
        '    My.Settings.DownloadsPath = ""
        'ElseIf rdpath.Checked = True Then
        '    If txtpath.Text = "" Then
        '        Dim ffd As New FolderBrowserDialog
        '        If ffd.ShowDialog = DialogResult.OK Then
        '            My.Settings.DownloadsPath = ffd.SelectedPath
        '        End If
        '    Else
        '        My.Settings.DownloadsPath = txtpath.Text
        '    End If
        'End If
        'If rdnorm.Checked = True Then
        '    My.Settings.Theme = "Normal"
        'ElseIf rdlight.Checked = True Then
        '    My.Settings.Theme = "Light"
        'ElseIf rddark.Checked = True Then
        '    My.Settings.Theme = "Dark"
        'End If
        Close()
    End Sub

    Private Sub frmsettings_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'cbxpage.Text = My.Settings.HomePage.Replace(".com", "")
        'If My.Settings.DownloadsPath = "" Then
        '    rdaskme.Checked = True
        '    rdpath.Checked = False
        'Else
        '    rdaskme.Checked = False
        '    rdpath.Checked = True
        '    txtpath.Text = My.Settings.DownloadsPath
        'End If
        'If My.Settings.Theme = "Normal" Then
        '    rdnorm.Checked = True
        '    rdlight.Checked = False
        '    rddark.Checked = False
        'ElseIf My.Settings.Theme = "Dark" Then
        '    rddark.Checked = True
        '    rdlight.Checked = False
        '    rdnorm.Checked = False
        'ElseIf My.Settings.Theme = "Light" Then
        '    rdlight.Checked = True
        '    rddark.Checked = False
        '    rdnorm.Checked = False
        'End If
    End Sub

    Private Sub btnbrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnbrowse.Click
        Dim ffd As New FolderBrowserDialog
        If ffd.ShowDialog = DialogResult.OK Then
            txtpath.Text = ffd.SelectedPath
        End If
    End Sub

End Class