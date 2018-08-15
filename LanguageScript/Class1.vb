Public Class Language1
    Public Shared timerString(10), yieldString(7), motionString(29), fileString(6), voteString(8), infoString(15), presentString(11) As String

    Public Shared Sub loadLanguageScript(language As Integer, myrule As Integer)
        Dim langfile(7) As String
        langfile(0) = "lang\timer" + language.ToString + ".edl"
        langfile(1) = "lang\yield" + language.ToString + ".edl"
        langfile(2) = "lang\motion" + language.ToString + ".edl"
        langfile(3) = "lang\file" + language.ToString + ".edl"
        langfile(4) = "lang\vote" + language.ToString + ".edl"
        langfile(5) = "lang\info" + language.ToString + ".edl"
        langfile(6) = "lang\present" + language.ToString + ".edl"
        langfile(7) = "lang\scscript" + language.ToString + ".edl"
        Dim tload As New System.IO.StreamReader(langfile(0))
        For x = 0 To 10
            timerString(x) = tload.ReadLine
        Next
        tload.Close()
        Dim yload As New System.IO.StreamReader(langfile(1))
        For x = 0 To 7
            yieldString(x) = yload.ReadLine
        Next
        yload.Close()
        If Not myrule = 2 Then
            Dim mload As New System.IO.StreamReader(langfile(2))
            For x = 0 To 29
                motionString(x) = mload.ReadLine
            Next
            mload.Close()
        Else
            'Dim scload As New System.IO.StreamReader(langfile(7))
            'For x = 0 To 47
            'scString(x) = scload.ReadLine
            'Next
            'scload.Close()
        End If
        Dim fload As New System.IO.StreamReader(langfile(3))
        For x = 0 To 6
            fileString(x) = fload.ReadLine
        Next
        fload.Close()
        Dim vload As New System.IO.StreamReader(langfile(4))
        For x = 0 To 8
            voteString(x) = vload.ReadLine
        Next
        vload.Close()
        Dim iload As New System.IO.StreamReader(langfile(5))
        For x = 0 To 15
            infoString(x) = iload.ReadLine
        Next
        iload.Close()
        Dim pload As New System.IO.StreamReader(langfile(6))
        For x = 0 To 11
            presentString(x) = pload.ReadLine
        Next
        pload.Close()
    End Sub

End Class
