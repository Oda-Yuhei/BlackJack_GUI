Public Class Computer : Inherits Player
    Public Overrides Sub ShowHand()
        ' 一枚目以外は隠す
        Dim result As String = hands.Item(0).ToString()
        For i As Integer = 1 To hands.Count - 1
            result &= "[---]"
        Next
        Console.WriteLine($"[手札={result}]")
    End Sub
End Class