Imports Newtonsoft.Json.Linq

Public Class Game

    Public Property Name As String

    Public ReadOnly Property Players As List(Of Player)

    Public Sub New()
        Players = New List(Of Player)
    End Sub

    Public Shared Function Parse(strPath As String) As Game
        Dim jg As JObject = JObject.Parse(IO.File.ReadAllText(strPath))
        Dim g As New Game With {.Name = jg("Name")}
        Dim players As JArray = jg("Players")
        For Each p As JObject In players
            Dim pl As New Player With {.Name = p("Name")}
            Dim s As New List(Of Integer)
            For Each i As Integer In p("Scores")
                s.Add(i)
            Next
            pl.Scores.AddRange(s)
            g.Players.Add(pl)
        Next
        Return g
    End Function

    Public Function ToJSON() As JObject
        Dim jg As New JObject
        jg("Name") = Name
        Dim players As New JArray
        For Each p As Player In Me.Players
            Dim jp As New JObject
            jp("Name") = p.Name
            Dim js As New JArray
            For Each i As Integer In p.Scores
                js.Add(i)
            Next
            jp("Scores") = js
            players.Add(jp)
        Next
        jg("Players") = players
        Return jg
    End Function

End Class
