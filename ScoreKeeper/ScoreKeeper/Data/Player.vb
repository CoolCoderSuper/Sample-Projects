Public Class Player
    Public Property Name As String

    Public ReadOnly Property Scores As List(Of Integer)

    Public ReadOnly Property TotalScore As Integer
        Get
            Dim intScore As Integer
            Scores.ForEach(Sub(x) intScore += x)
            Return intScore
        End Get
    End Property

    Public Sub New()
        Scores = New List(Of Integer)
    End Sub

End Class
