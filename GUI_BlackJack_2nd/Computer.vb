Public Class Computer : Inherits Player
    Public Sub ResultShowHand(number As String)
        CardsOpen()
        Dim i As Integer = 1
        For Each card In hands_string
            Dim c = My.Resources.Resources.ResourceManager.GetObject(card)
            Dim a = StartForm.gameform.Controls("comPictureBox" & number & i)
            i += 1
            Dim b = DirectCast(a, PictureBox)
            b.Image = c
            b.SizeMode = PictureBoxSizeMode.StretchImage
            b.Visible = True
        Next
        hands_string.Clear()

    End Sub
    Public Overrides Sub ShowHand(number As String)
        '---------------------------------------------------------
        '---------------------------------------------------------
        'プレイヤーのカード表示、ヒット・スタンドは完成
        '    プレイヤーはいじる必要なし
        '次回コンピュータのカード表示から作成
        'コンピューターShowhandから修正

        '---------------------------------------------------------
        '---------------------------------------------------------
        CardsOpen()
        Dim i As Integer = 1
        For Each card In hands_string
            If i = 1 Then
                Dim c = My.Resources.Resources.ResourceManager.GetObject(card)
                Dim a = StartForm.gameform.Controls("comPictureBox" + number & i)
                Dim b = DirectCast(a, PictureBox)
                b.Image = c
                b.SizeMode = PictureBoxSizeMode.StretchImage
                b.Visible = True
            Else
                Dim a = StartForm.gameform.Controls("comPictureBox" + number & i)
                Dim b = DirectCast(a, PictureBox)
                b.Image = My.Resources.z01
                b.SizeMode = PictureBoxSizeMode.StretchImage
                b.Visible = True
            End If
            i += 1

        Next
        hands_string.Clear()

    End Sub
    Public Overloads Function ToString(num As Integer) As Integer
        ' ここリンク
        ' 要復習
        ' それとラムダ式
        Dim result As String = String.Join("", hands.Select(Function(c) c.ToString()))
        'Return $"[手札={result},合計{GetTotal()}]"
        Dim a = StartForm.gameform.Controls("computer_total" & num)
        Dim b = DirectCast(a, Control)
        b.Text = $"Total : {GetTotal()}"
        Return GetTotal()
    End Function
End Class
