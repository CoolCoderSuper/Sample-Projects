Imports CefSharp

Public Class DownloadHandler
    Implements IDownloadHandler

    Public Event OnBeforeDownloadFired As EventHandler(Of DownloadItem)

    Public Event OnDownloadUpdatedFired As EventHandler(Of DownloadItem)

    Public Sub OnBeforeDownload(ByVal chromiumWebBrowser As IWebBrowser, ByVal browser As IBrowser, ByVal downloadItem As DownloadItem, ByVal callback As IBeforeDownloadCallback) Implements IDownloadHandler.OnBeforeDownload
        RaiseEvent OnBeforeDownloadFired(Me, downloadItem)

        If Not callback.IsDisposed Then
            Using callback
                callback.Continue(downloadItem.SuggestedFileName, showDialog:=True)
            End Using
        End If
    End Sub

    Public Sub OnDownloadUpdated(ByVal chromiumWebBrowser As IWebBrowser, ByVal browser As IBrowser, ByVal downloadItem As DownloadItem, ByVal callback As IDownloadItemCallback) Implements IDownloadHandler.OnDownloadUpdated
        RaiseEvent OnDownloadUpdatedFired(Me, downloadItem)
    End Sub

    Public Function CanDownload(chromiumWebBrowser As IWebBrowser, browser As IBrowser, url As String, requestMethod As String) As Boolean Implements IDownloadHandler.CanDownload
        Return True
    End Function
End Class