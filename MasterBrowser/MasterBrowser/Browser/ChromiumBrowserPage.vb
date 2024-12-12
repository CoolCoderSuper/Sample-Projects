Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports CefSharp

Public Class ChromiumBrowserPage
    Inherits TabPage

#Region "Components"

    Private WithEvents btnBack As ToolStripButton
    Private WithEvents btnForward As ToolStripButton
    Private WithEvents btnRefresh As ToolStripButton
    Private WithEvents cbxSearch As ToolStripComboBox
    Private WithEvents btnSearch As ToolStripButton
    Private WithEvents btnHome As ToolStripButton
    Private WithEvents btnDownloads As ToolStripButton
    Private WithEvents cbxMode As ToolStripComboBox
    Private WithEvents wbMain As WinForms.ChromiumWebBrowser
    Private WithEvents mainStrip As ToolStrip
    Private WithEvents tmrCheck As Timer

    Public Sub New()
        'Back button
        btnBack = New ToolStripButton
        btnBack.Text = "Back"
        btnBack.Image = My.Resources.Back
        btnBack.DisplayStyle = ToolStripItemDisplayStyle.Image
        'Forward button
        btnForward = New ToolStripButton
        btnForward.Text = "Forward"
        btnForward.Image = My.Resources.Forward
        btnForward.DisplayStyle = ToolStripItemDisplayStyle.Image
        'Refresh button
        btnRefresh = New ToolStripButton
        btnRefresh.Text = "Reload"
        btnRefresh.Image = My.Resources.Refresh
        btnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image
        'Home button
        btnHome = New ToolStripButton
        btnHome.Text = "Home"
        btnHome.Image = My.Resources.Home
        btnHome.DisplayStyle = ToolStripItemDisplayStyle.Image
        'Search button
        btnSearch = New ToolStripButton
        btnSearch.Text = "Search"
        btnSearch.Image = My.Resources.Search
        btnSearch.DisplayStyle = ToolStripItemDisplayStyle.Image
        'Search box
        cbxSearch = New ToolStripComboBox
        cbxSearch.Size = New Size(500, 25)
        'Search mode box
        cbxMode = New ToolStripComboBox
        cbxMode.Size = New Size(75, 25)
        cbxMode.Items.AddRange({"URL", "SEARCH", "AUTO"})
        cbxMode.Text = "AUTO"
        cbxMode.DropDownStyle = ComboBoxStyle.DropDownList
        'Timer
        tmrCheck = New Timer
        tmrCheck.Interval = 100
        tmrCheck.Start()
        'Menu strip
        mainStrip = New ToolStrip
        mainStrip.Items.AddRange(New ToolStripItem() {btnBack, btnForward, btnRefresh, cbxSearch, cbxMode, btnSearch, btnHome})
        'Browser object
        If LicenseManager.UsageMode = LicenseUsageMode.Runtime Then
            wbMain = New WinForms.ChromiumWebBrowser("google.com")
            wbMain.Tag = Me
            wbMain.Size = New Size(Width, Height - mainStrip.Height)
            wbMain.Location = New Point(0, mainStrip.Height)
            wbMain.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            wbMain.MenuHandler = New MenuHandler
            wbMain.DownloadHandler = New DownloadHandler
            Tag = wbMain
        End If
        'Tab
        Controls.Add(mainStrip)
        Controls.Add(wbMain)
        Text = String.Empty
    End Sub

#End Region

#Region "Events"

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
        DoCommand(CommandType.BACK)
    End Sub

    Private Sub btnForward_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnForward.Click
        DoCommand(CommandType.FORWARD)
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        DoCommand(CommandType.REFRESH)
    End Sub

    Private Sub btnHome_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHome.Click
        DoCommand(CommandType.HOME)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSearch.Click
        DoCommand(CommandType.GO)
    End Sub

    Private Sub cbxSearch_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles cbxSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            DoCommand(CommandType.GO)
            e.SuppressKeyPress = True
            e.Handled = True
        End If
    End Sub

    Private Sub wbMain_AddressChanged(sender As Object, e As AddressChangedEventArgs) Handles wbMain.AddressChanged
        Invoke(Sub() cbxSearch.Text = e.Address)
        Dim item As New HistoryItem
        item.URL = e.Address
        item.Time = Now
        History.Add(item)
    End Sub

    Private Sub wbMain_TitleChanged(sender As Object, e As TitleChangedEventArgs) Handles wbMain.TitleChanged
        Invoke(Sub() Text = e.Title)
    End Sub

    Private Sub tmrCheck_Tick(sender As Object, e As EventArgs) Handles tmrCheck.Tick
        btnBack.Enabled = wbMain.CanGoBack
        btnForward.Enabled = wbMain.CanGoForward
    End Sub

#End Region

#Region "Methods"

    Public Sub DoCommand(ByVal cmd As CommandType)
        Select Case cmd
            Case CommandType.BACK
                If wbMain.CanGoBack Then
                    wbMain.Back()
                End If
            Case CommandType.FORWARD
                If wbMain.CanGoForward Then
                    wbMain.Forward()
                End If
            Case CommandType.REFRESH
                wbMain.Reload()
            Case CommandType.HOME
                wbMain.Load("google.com")
            Case CommandType.GO
                Go()
            Case CommandType.INSPECT
                wbMain.ShowDevTools()
            Case CommandType.VIEWSOURCE
                wbMain.ViewSource()
            Case CommandType.CLOSE

        End Select
    End Sub

    Public Sub Go()
        If cbxMode.Text = "SEARCH" Then
            Search()
        ElseIf cbxMode.Text = "URL" Then
            wbMain.Load(cbxSearch.Text)
            wbMain.BringToFront()
        Else
            If Regex.IsMatch(cbxSearch.Text, "(([\w]+:)?\/\/)?(([\d\w]|%[a-fA-f\d]{2,2})+(:([\d\w]|%[a-fA-f\d]{2,2})+)?@)?([\d\w][-\d\w]{0,253}[\d\w]\.)+[\w]{2,63}(:[\d]+)?(\/([-+_~.\d\w]|%[a-fA-f\d]{2,2})*)*(\?(&?([-+_~.\d\w]|%[a-fA-f\d]{2,2})=?)*)?(#([-+_~.\d\w]|%[a-fA-f\d]{2,2})*)?") Then
                wbMain.Load(cbxSearch.Text)
            Else
                Search()
            End If
        End If
    End Sub

    Public Sub Search()
        'If My.Settings.HomePage = "Google.com" Then
        wbMain.Load($"https://www.google.com/search?q={cbxSearch.Text}")
        'ElseIf My.Settings.HomePage = "Bing.com" Then
        '    wbMain.Load("https://www.bing.com/search?q=" & cbxSearch.Text)
        'ElseIf My.Settings.HomePage = "DuckDuckGo.com" Then
        '    wbMain.Load("https://duckduckgo.com/?q=" & cbxSearch.Text)
        'ElseIf My.Settings.HomePage = "Ecosia.com" Then
        '    wbMain.Load("https://www.ecosia.co/search?q=" & cbxSearch.Text)
        'ElseIf My.Settings.HomePage = "Yahoo.com" Then
        '    wbMain.Load("https://search.yahoo.com/search?p=" & cbxSearch.Text)
        'End If
    End Sub

    Public Function GetIcon() As Bitmap
        Try
            Dim wc As New WebClient
            Dim memorystream As New MemoryStream(wc.DownloadData($"http://www.google.com/s2/favicons?domain={wbMain.Address}"))
            Dim objIcon As New Bitmap(memorystream)
            Return objIcon
        Catch ex As Exception
            Return New Bitmap(10, 10)
        End Try
    End Function

#End Region

End Class