Imports CefSharp

Public Class MenuHandler
    Implements IContextMenuHandler

    Public Sub OnBeforeContextMenu(ByVal browserControl As IWebBrowser, ByVal browser As IBrowser, ByVal frame As IFrame, ByVal parameters As IContextMenuParams, ByVal model As IMenuModel) Implements IContextMenuHandler.OnBeforeContextMenu
        ' Add a new item to the list using the AddItem method of the model
        model.AddItem(26501, "Inspect")
        model.AddItem(26502, "Save page as...")
    End Sub

    Public Function OnContextMenuCommand(ByVal browserControl As IWebBrowser, ByVal browser As IBrowser, ByVal frame As IFrame, ByVal parameters As IContextMenuParams, ByVal commandId As CefMenuCommand, ByVal eventFlags As CefEventFlags) As Boolean Implements IContextMenuHandler.OnContextMenuCommand
        ' React to the first ID (show dev tools method)
        If commandId = CType(26501, CefMenuCommand) Then
            browser.GetHost().ShowDevTools()
            Return True
        End If
        If commandId = CType(26502, CefMenuCommand) Then
            Return False
        End If
        Return False
    End Function

    Public Sub OnContextMenuDismissed(ByVal browserControl As IWebBrowser, ByVal browser As IBrowser, ByVal frame As IFrame) Implements IContextMenuHandler.OnContextMenuDismissed
    End Sub

    Public Function RunContextMenu(ByVal browserControl As IWebBrowser, ByVal browser As IBrowser, ByVal frame As IFrame, ByVal parameters As IContextMenuParams, ByVal model As IMenuModel, ByVal callback As IRunContextMenuCallback) As Boolean Implements IContextMenuHandler.RunContextMenu
        Return False
    End Function

End Class