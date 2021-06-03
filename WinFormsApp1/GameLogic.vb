Public Class GameLogic
    Private Const COM_HIT_TOTAL As Integer = 17
    Private ReadOnly deck As Deck
    Private ReadOnly player As Player
    Private ReadOnly computer As Computer
    Public Sub New()
        deck = New Deck()
        player = New Player()
        computer = New Computer()
        ' 二枚引く
        For i As Integer = 1 To 2
            player.DrawCard(deck.DrawCard())
            computer.DrawCard(deck.DrawCard())
        Next
    End Sub
    Private Sub Hit()
        player.DrawCard(deck.DrawCard())
        If computer.GetTotal() < COM_HIT_TOTAL Then
            computer.DrawCard(deck.DrawCard())
        End If
    End Sub
    Private Sub Stand()
        While computer.GetTotal() < COM_HIT_TOTAL
            computer.DrawCard(deck.DrawCard())
        End While
    End Sub
    Private Sub ShowResult()
        Console.WriteLine("----------------------------------------------")
        Console.WriteLine("コンピューター")
        Console.WriteLine(computer.ToString)
        Console.WriteLine()
        Console.WriteLine("あなた")
        Console.WriteLine(player.ToString)

        Dim result As Integer = player.CompareTo(computer)
        If player.IsBurst() OrElse result < 0 Then
            Console.WriteLine("コンピューターの勝ち")
        ElseIf result > 0 Then
            Console.WriteLine("あなたの勝ち")
        Else
            Console.WriteLine("引き分け")
        End If
    End Sub
    Private Sub ShowTurn()
        Console.WriteLine("コンピューター")
        computer.ShowHand()
        Console.WriteLine("あなた")
        player.ShowHand()
    End Sub
    Public Sub Start()
        While True
            ShowTurn()
            Console.Write("もう一枚引きますか？[y or それ以外]")
            If Console.ReadLine() = "y" Then
                Hit()
                If player.IsBurst() Then
                    Console.WriteLine("あなたはバーストしました")
                    Exit While
                End If
            Else
                Exit While
            End If
        End While
        If Not player.IsBurst() Then
            Stand()
        End If
        ShowResult()
    End Sub
End Class
