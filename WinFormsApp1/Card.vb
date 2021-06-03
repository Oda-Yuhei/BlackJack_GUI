Public Enum Suit
    Spade
    Heart
    Diamond
    Club
End Enum
Public Class Card
    Public ReadOnly Property Suit() As Suit
    Public ReadOnly Property Rank() As Integer
    Sub New(suit As Suit, rank As Integer)
        _Suit = suit
        _Rank = rank
    End Sub
    Public Overloads Function ToString() As String
        Dim rankStr As String
        Select Case Rank
            Case 1
                rankStr = "A"
            Case 11
                rankStr = "j"
            Case 12
                rankStr = "Q"
            Case 13
                rankStr = "K"
            Case Else
                rankStr = Rank
        End Select
        Return $"[{Suit} {rankStr}]"
    End Function
End Class