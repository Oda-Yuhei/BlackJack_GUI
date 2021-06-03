Module Util
    Public Sub Shuffle(Of T)(list As IList(Of T))
        Dim r As Random = New Random()
        For i = 0 To list.Count - 1
            Dim index As Integer = r.Next(i, list.Count)
            If i <> index Then
                Dim temp As T = list(i)
                list(i) = list(index)
                list(index) = temp
            End If
        Next
    End Sub
End Module