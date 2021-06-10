Public Class StartForm
    Public number As Integer
    Public gameform As GameForm
    Public mycoin As Integer
    Public minimum As Integer
    Public farstgame As Boolean = True

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Image = Brighten(PictureBox1.Image, 50)
        PictureBox1.Refresh()
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Me.PictureBox1.Image = My.Resources.Strat_button

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        number = ComboBox1.SelectedIndex
        If number = 1 Then
            gameform = New GameForm
        ElseIf number = 2 Then
            gameform = New GameForm
        ElseIf number = 3 Then
            gameform = New GameForm
        Else
            MsgBox("対戦人数を選択してください")
            Return
        End If

        Try
            Me.mycoin = CInt(MyCoinTextBox.Text)
            If farstgame Then
                If mycoin < 100 Then
                    MsgBox("100以上の数値を入力してください")
                    Return
                End If
            End If
            minimum = CInt(MinimumTextBox.Text)
            MyCoinTextBox.ReadOnly = True
            farstgame = False
            MyCoinLabel.Text = "所持コイン"
            gameform.Show()
        Catch
            MsgBox("初期所持コインを設定してください")
            Return
        End Try

    End Sub
    Private Function Brighten(ByVal Source As Image, ByVal Alpha As Integer) As Bitmap
        '引数のチェック
        If IsNothing(Source) Then
            Throw New NullReferenceException("Sourceに値が設定されていません。")
        End If

        If Alpha < -255 OrElse Alpha > 255 Then
            Throw New ArgumentException("Alphaは-255 から255 の範囲で指定してください。")
        End If

        'Sourceのイメージをそのまま描画
        Dim g As Graphics
        Dim SourceImage As New Bitmap(Source.Width, Source.Height)

        g = Graphics.FromImage(SourceImage)
        g.DrawImage(Source, New Point(0, 0))

        'Sourceのイメージの上に白い(黒い)長方形を重ねる
        Dim MyBrush As SolidBrush

        If Alpha > 0 Then
            '白い長方形を作成
            MyBrush = New SolidBrush(Color.FromArgb(Alpha, 255, 255, 255))
            g.FillRectangle(MyBrush, Source.GetBounds(GraphicsUnit.Pixel))
        Else
            '黒い長方形を作成
            MyBrush = New SolidBrush(Color.FromArgb(-Alpha, 0, 0, 0))
            g.FillRectangle(MyBrush, Source.GetBounds(GraphicsUnit.Pixel))
        End If

        Return SourceImage

    End Function

    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("1com")
        ComboBox1.Items.Add("2com")
        ComboBox1.Items.Add("3com")

    End Sub

    Private Sub MyCoinTextBox_TextChanged(sender As Object, e As EventArgs) Handles MyCoinTextBox.TextChanged
        Dim num As Integer = CInt(MyCoinTextBox.Text)
        If farstgame Then
            If num >= 100 Then
                num = num / 10
                MinimumTextBox.Text = num.ToString
            Else
                MinimumTextBox.Text = "入力が適切ではありません"
            End If
        End If
    End Sub
End Class