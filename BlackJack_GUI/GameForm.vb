Public Class GameForm
    Public logic As New GameLogic()
    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        logic.Start()
    End Sub
End Class
