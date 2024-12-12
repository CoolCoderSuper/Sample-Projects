Public Class HistoryManger
    Public Shared Function Load() As List(Of HistoryItem)
        Dim lItems As New List(Of HistoryItem)
        Dim doc As XDocument = XDocument.Load($"C:\Users\{Environment.UserName}\AppData\Roaming\MasterBrowser\History.xml")
        Dim objHistory As XElement = doc.Element("History")
        For Each el As XElement In objHistory.Elements("Item")
            Dim objItem As New HistoryItem
            objItem.Time = Date.Parse(el.Attribute("Time").Value)
            objItem.URL = el.Attribute("URL").Value
            lItems.Add(objItem)
        Next
        lItems.Reverse()
        Return lItems
    End Function

    Public Shared Sub Save(items As List(Of HistoryItem))
        items.Reverse()
        Dim doc As New XDocument
        Dim objHistory As New XElement("History")
        For Each item As HistoryItem In items
            Dim objEl As New XElement("Item")
            objEl.Add(New XAttribute("Time", item.Time.ToString))
            objEl.Add(New XAttribute("URL", item.URL))
            objHistory.Add(objEl)
        Next
        doc.Add(objHistory)
        doc.Save($"C:\Users\{Environment.UserName}\AppData\Roaming\MasterBrowser\History.xml")
    End Sub
End Class
