Public Class Computer : Inherits Player
    Public Sub ResultShowHand()
        CardsOpen()
        Dim i As Integer = 1
        For Each card In hands_string
            Dim c = My.Resources.Resources.ResourceManager.GetObject(card)
            Dim a = GameForm.Controls("comBox" & i)
            i += 1
            Dim b = DirectCast(a, PictureBox)
            b.Image = c
            b.SizeMode = PictureBoxSizeMode.StretchImage
        Next
        hands_string.Clear()

    End Sub
    Public Overrides Sub ShowHand()

        CardsOpen()
        Dim i As Integer = 1
        For Each card In hands_string
            If i = 1 Then
                Dim c = My.Resources.Resources.ResourceManager.GetObject(card)
                Dim a = GameForm.Controls("comBox" & i)
                Dim b = DirectCast(a, PictureBox)
                b.Image = c
                b.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                Dim a = GameForm.Controls("comBox" & i)
                Dim b = DirectCast(a, PictureBox)
                b.Image = My.Resources.z01
                b.SizeMode = PictureBoxSizeMode.StretchImage
            End If
            i += 1
        Next
        hands_string.Clear()

    End Sub
    Public Overrides Sub ToString()
        ' ここリンク
        ' 要復習
        ' それとラムダ式
        Dim result As String = String.Join("", hands.Select(Function(c) c.ToString()))
        'Return $"[手札={result},合計{GetTotal()}]"
        GameForm.computer_total.Text = $"Total : {GetTotal()}"
    End Sub
End Class