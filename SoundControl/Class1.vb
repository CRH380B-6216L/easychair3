Public Class Class1
    Public isPlay() As Boolean = New Boolean() {True, True, True, True, True}
    Public myplay() As String = New String() {"sounds\time_over.wav", "sounds\buzzer.wav", "sounds\twilight.wav", "sounds\conference_start.wav", "sounds\message.wav"}

    Sub playSfx(soundmode As Integer)
        Dim myisplay As Boolean = isPlay(soundmode)
        If Not myisplay Then Exit Sub
        Try
            Dim play As New System.Media.SoundPlayer(myplay(soundmode))
            play.Play()
            play.Dispose()
        Catch ex As Exception
            isPlay(soundmode) = 0
        End Try
    End Sub
End Class
