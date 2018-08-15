Public Class Form2

    Private Sub Form2_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.Width >= 1250 Then
            UserControl11.ListExtraColumn = True
        Else
            UserControl11.ListExtraColumn = False
        End If
    End Sub
End Class