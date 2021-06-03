Public Class GameForm
    Public logic As New GameLogic()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logic.Start()
    End Sub
End Class
