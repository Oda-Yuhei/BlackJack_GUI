Public Class Deck
    Public Const RANK_MAX As Integer = 13
    Private ReadOnly cards As New List(Of Card)
    Public Sub New()
        For Each suit As Suit In [Enum].GetValues(GetType(Suit))
            For rank As Integer = 1 To 13
                cards.Add(New Card(suit, rank))
            Next rank
        Next
        Util.Shuffle(cards)
    End Sub
    Public Function DrawCard() As Card
        Dim card As Card = cards.Item(0)
        cards.Remove(card)
        Return card
    End Function
End Class
