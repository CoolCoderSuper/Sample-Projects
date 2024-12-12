Imports CefSharp
Imports System.IO

Public Class frmMain
    Public WithEvents currentbrowser As WinForms.ChromiumWebBrowser
    Private WithEvents tab As ChromiumBrowserPage

    Public Sub New()
        History = HistoryManger.Load()
        Dim settings As New CefSharp.WinForms.CefSettings
        settings.CachePath = $"C:\Users\{Environment.UserName }\AppData\Roaming\MasterBrowser\Cache"
        CefSharp.Cef.Initialize(settings)
        InitializeComponent()
    End Sub

    Private Sub frmmain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        tbmain.TabPages.Insert(0, New ChromiumBrowserPage)
        tbmain.SelectedIndex = 0
        currentbrowser = tbmain.SelectedTab.Tag
        tab = CType(tbmain.SelectedTab, ChromiumBrowserPage)
        'If My.Settings.Theme = "Normal" Then
        '    BackColor = DefaultBackColor
        '    mainStrip.BackColor = DefaultBackColor
        'ElseIf My.Settings.Theme = "Light" Then
        '    BackColor = Color.White
        '    mainStrip.BackColor = DefaultBackColor
        'ElseIf My.Settings.Theme = "Dark" Then
        '    BackColor = Color.Black
        '    mainStrip.BackColor = Color.Gray
        'End If
    End Sub

    Private Sub btnsettings_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnsettings.Click
        frmSettings.ShowDialog()
        'If My.Settings.Theme = "Normal" Then
        '    BackColor = DefaultBackColor
        '    mainStrip.BackColor = DefaultBackColor
        'ElseIf My.Settings.Theme = "Light" Then
        '    BackColor = Color.White
        '    mainStrip.BackColor = DefaultBackColor
        'ElseIf My.Settings.Theme = "Dark" Then
        '    BackColor = Color.Black
        '    mainStrip.BackColor = Color.Gray
        'End If
    End Sub

    Private Sub btnnewwindow_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnnewwindow.Click
        Dim frm As New frmMain
        frm.Show()
    End Sub

    Private Sub btnexit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnexit.Click
        Dispose()
    End Sub

    Private Sub btnopen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnopen.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "HTML Files(*.html)|*.html|HTM files(*.htm)|*.htm"
        If ofd.ShowDialog() = DialogResult.OK Then
            tbmain.SelectedTab.Tag.DocumentText = File.ReadAllText(ofd.FileName)
        End If
    End Sub
    Private Sub btnabout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnabout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnbookmarks_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnbookmarks.Click
        frmBookMarks.ShowDialog()
    End Sub

    Private Sub btnnewtab_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnnewtab.Click
        Dim page As New ChromiumBrowserPage
        tbmain.Controls.Add(page)
        Dim paged As New TabPage
        paged.Text = "X"
        tbmain.Controls.Add(paged)
        tbmain.SelectedTab = page
    End Sub

    Private Sub tbmain_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbmain.SelectedIndexChanged
        If tbmain.SelectedTab.Text = "+" Then
            btnnewtab.PerformClick()
            tbmain.TabPages.Remove(pageadd)
            tbmain.TabPages.Add(pageadd)
        ElseIf tbmain.SelectedTab.Text = "X" Then
            tbmain.Controls.RemoveAt(tbmain.SelectedIndex - 1)
            tbmain.Controls.RemoveAt(tbmain.SelectedIndex)
        Else
            currentbrowser = tbmain.SelectedTab.Tag
            tab = CType(tbmain.SelectedTab, ChromiumBrowserPage)
        End If
    End Sub

    Private Sub currentbrowser_AddressChanged(sender As Object, e As AddressChangedEventArgs) Handles currentbrowser.AddressChanged
        lIcons.Images.Add(tab.GetIcon())
        Invoke(Sub() tab.ImageIndex = lIcons.Images.Count - 1)
    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        HistoryManger.Save(History)
        CefSharp.Cef.Shutdown()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        frmHistory.ShowDialog()
    End Sub
End Class
