Public Class BetForm
    Private Sub BetenterButton_Click(sender As Object, e As EventArgs) Handles BetenterButton.Click
        Try
            Dim num As Integer = CInt(betcoinTextBox.Text)
            If num <= StartForm.mycoin - StartForm.gameform.betcoin Then
                StartForm.gameform.betcoin += num
                StartForm.gameform.BWriteline($"{StartForm.gameform.betcoin}Coin BETしました")
                Me.Close()
            Else
                MsgBox("所持コインが足りません")
            End If
        Catch
            MsgBox("入力が間違っています")
        End Try

    End Sub

    Private Sub BetForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mycoinLabel.Text = $"所持コイン：{StartForm.mycoin}"
        NowBetcoinLabel.Text = $"現在のBET：{StartForm.gameform.betcoin}"
    End Sub
End Class