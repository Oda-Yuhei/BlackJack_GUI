Public Class Player
    Implements IComparable(Of Player)
    Public hands_string As New List(Of String)
    Protected hands As List(Of Card)
    Public Sub New()
        hands = New List(Of Card)
    End Sub

    Public Sub DrawCard(card As Card)
        hands.Add(card)
    End Sub

    Public Function CardsOpen() As List(Of String)
        For Each i In hands.Select(Function(c) c.GetResouceId())
            hands_string.Add(i)
        Next
    End Function



    Public Overridable Sub ShowHand()
        CardsOpen()
        For Each card In hands_string
            Dim i As Integer = 1
            Dim c = My.Resources.Resources.ResourceManager.GetObject(card)
            Dim a = GameForm.Controls("playerBox" & i)
            i += 1
            Dim b = DirectCast(a, PictureBox)
            b.Image = c
            b.SizeMode = PictureBoxSizeMode.StretchImage
        Next
    End Sub
    Public Function GetTotal() As Integer
        ' ここリンク
        Dim hasAce As Boolean = hands.Any(Function(c) c.Rank = 1)
        Dim total As Integer = hands.Sum(Function(C) If(C.Rank >= 10, 10, C.Rank))
        Return If(hasAce AndAlso total <= 11, total + 10, total)
    End Function
    Public Function IsBurst()
        Return GetTotal() > 21
    End Function
    Public Function CompareTo(other As Player) As Integer Implements IComparable(Of Player).CompareTo
        If Equals(other) Then
            Return 0
        ElseIf IsBurst() Then
            Return -1
        ElseIf other.IsBurst() Then
            Return 1
        End If
        Return GetTotal() - other.GetTotal()
    End Function
    Public Overloads Function Equals(obj As Object) As Boolean
        If obj Is Nothing OrElse TypeOf obj IsNot Player Then
            Return False
        End If
        Dim other As Player = DirectCast(obj, Player)
        Return IsBurst() AndAlso other.IsBurst() OrElse GetTotal() = other.GetTotal()
    End Function
End Class
