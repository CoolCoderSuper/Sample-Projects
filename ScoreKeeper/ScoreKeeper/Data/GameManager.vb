Public Class GameManager
    Public ReadOnly Property Library As Dictionary(Of String, Game)
    Private strPath As String

    Public Property Path As String
        Get
            Return strPath
        End Get
        Set(value As String)
            strPath = value
            Load()
        End Set
    End Property

    Public Sub New()
        Library = New Dictionary(Of String, Game)
    End Sub

    Public Sub Save()
        IO.File.WriteAllLines(strPath, Library.Keys.AsEnumerable())
    End Sub

    Private Sub Load()
        IO.File.ReadAllLines(strPath).ToList().ForEach(Sub(x) Library.Add(x, Game.Parse(x)))
    End Sub

    Public Shared Sub Save(strPath As String, g As Game)
        IO.File.WriteAllText(strPath, g.ToJSON().ToString())
    End Sub

End Class