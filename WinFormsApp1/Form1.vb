Public Class GameForm
    Private Sub GameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim logic As New GameLogic
        logic.Start()
        
    End Sub
End Class
