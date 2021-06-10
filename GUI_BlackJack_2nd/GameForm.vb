Public Class GameForm
    Private Const COM_HIT_TOTAL As Integer = 17
    Private deck As Deck
    Private player As Player
    Private computer1 As Computer
    Private computer2 As Computer
    Private computer3 As Computer
    Public cardpicutrebox_stringlist As List(Of String)
    Public number As Integer
    Public betcoin As Integer

    Private computers As New List(Of Computer)

    Public Bwrite As New List(Of String)

    Public Sub score_boad(num)
        Dim a = StartForm.gameform.Controls("computer_total" & num)
        Dim b = DirectCast(a, Control)
        b.Visible = True
    End Sub
    Public Sub BWriteline(i As String)
        Dim Btext As String = ":)"
        Bwrite.Add(i)
        If Bwrite.Count = 5 Then
            Bwrite.RemoveAt(0)
        End If

        For Each i In Bwrite
            Btext = Btext & vbCrLf & i
        Next
        BlackConsole.Text = Btext
    End Sub
    Private Sub Hit()
        player.DrawCard(deck.DrawCard())
        player.ToString()
        For Each computer In computers
            If computer.GetTotal() < COM_HIT_TOTAL Then
                computer.DrawCard(deck.DrawCard())
            End If
        Next
    End Sub
    Private Sub Stand()
        For Each computer In computers
            While computer.GetTotal() < COM_HIT_TOTAL
                computer.DrawCard(deck.DrawCard())
            End While
        Next
    End Sub
    Private Sub ShowResult()
        Dim ii As Integer = 1
        Dim comTotalMax As New List(Of Integer)
        For Each computer In computers
            comTotalMax.Add(computer.ToString(ii))
            computer.ResultShowHand(ii)
            ii += 1
        Next

        player.ToString()

        Dim win As Integer
        Dim lose As Integer
        Dim draw As Integer
        Dim burst As Integer
        Dim winner As Integer
        If player.IsBurst() Then
            burst += 1
        End If
        For Each com In computers
            Dim result As Integer = player.CompareTo(com)
            If result < 0 Then
                lose += 1
            ElseIf result > 0 Then
                win += 1
            Else
                Draw += 1
            End If
        Next
        If burst = 1 Then
            BWriteline("あなたはバーストしました")
        ElseIf lose > 0 Then
            BWriteline($"あなたはの{lose}体のコンピュータに負けました")
        Else
            If draw <> 0 Then
                BWriteline("引き分けです")
                MsgBox("引き分けです" & vbCrLf & vbCrLf & "コインの変動はありません")
                Me.Close()
                Return
            End If
            BWriteline("あなたの勝ちです")
            winner += 1
        End If
        Dim ResultText As String
        If winner = 1 Then
            betcoin = betcoin * computers.Count
            If draw > 0 Then
                betcoin = betcoin / draw
            End If
            StartForm.mycoin += betcoin
            ResultText = "勝負に勝ち" & vbCrLf & vbCrLf & $"{betcoin}Coin獲得しました"
        Else
            StartForm.mycoin -= betcoin
            ResultText = "勝負に負け" & vbCrLf & vbCrLf & $"{betcoin}Coin失いました"
        End If


        MsgBox($"BETコイン：{betcoin}" & vbCrLf & ResultText)
        StartForm.MyCoinTextBox.Text = StartForm.mycoin
        Me.Close()

        If StartForm.mycoin < StartForm.minimum Then
            MsgBox("最低賭金を下回りました" & vbCrLf & "ゲームを終了します")
            StartForm.Close()
        End If
    End Sub
    Private Sub ShowTurn()
        Me.number = StartForm.number
        player.ShowHand(99)
        If number = 3 Then
            computer1.ShowHand(1.ToString)
            computer2.ShowHand(2.ToString)
            computer3.ShowHand(3.ToString)
        ElseIf number = 2 Then
            computer1.ShowHand(1.ToString)
            computer2.ShowHand(2.ToString)
        ElseIf number = 1 Then
            computer1.ShowHand(1.ToString)
        End If
    End Sub

    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deck = New Deck()
        player = New Player()

        If StartForm.number = 1 Then
            computer1 = New Computer()
            computers.Add(computer1)
        ElseIf StartForm.number = 2 Then
            computer2 = New Computer()
            computer1 = New Computer()
            computers.Add(computer2)
            computers.Add(computer1)
        ElseIf StartForm.number = 3 Then
            computer3 = New Computer()
            computer2 = New Computer()
            computer1 = New Computer()
            computers.Add(computer3)
            computers.Add(computer2)
            computers.Add(computer1)
        End If
        ' 二枚引く
        For i As Integer = 1 To 2
            player.DrawCard(deck.DrawCard())
            For Each computer In computers
                computer.DrawCard(deck.DrawCard())
            Next
        Next
        ShowTurn()
        For i As Integer = 1 To StartForm.number
            score_boad(i)
        Next

        betcoin = StartForm.minimum
        BWriteline($"{StartForm.minimum}CoinをBET")

    End Sub
    Private Sub HitButton_Click(sender As Object, e As EventArgs) Handles HitButton.Click

        BWriteline($"HITを選択した")
        Hit()
        player.ShowHand(99)
        If player.IsBurst() Then
            player.ToString()
            MsgBox("バーストしてしまった")
            ShowResult()
        End If
    End Sub

    Private Sub StandButton_Click(sender As Object, e As EventArgs) Handles StandButton.Click
        BWriteline("STANDを選択した")
        Stand()
        ShowResult()
    End Sub

    Private Sub BetButton_Click(sender As Object, e As EventArgs) Handles BetButton.Click
        BWriteline("BETを選択した")
        Dim betform As New BetForm
        betform.Show()
    End Sub
End Class
