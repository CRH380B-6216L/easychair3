Public Class Class1
    Public Shared screen(18) As String

    Public Shared Sub loadlang(lang As Integer)
        Dim screen1 As String = My.Resources.screen1
        Dim screen2 As String = My.Resources.screen2
        Dim screens() As String = New String() {Nothing, screen1, screen2}
        Dim split As String() = screens(lang).Split(New [Char]() {vbCr, vbLf})
        Dim i As Integer = 0
        For Each s As String In split
            If s <> "" Then
                screen(i) = s
                i = i + 1
            End If
        Next
    End Sub
End Class

Public Enum bookmarkmode As Integer
    Versie = 1
    Presents = 2
    Timer = 3
End Enum

Public Enum listmarkup As Integer
    Empty = 0
    Yes = 1
    No = 2
    Abst = 3
    Aan = 4
End Enum