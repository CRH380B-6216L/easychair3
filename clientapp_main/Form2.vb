Imports StandardConfData

Public Class Form2
    Public MyStatus As MyInfo.AppStatus = MyInfo.AppStatus.Idle

    Public Shared Sub ChangeStatus(rolled As Boolean, status As MyInfo.AppStatus, Optional resumes As Boolean = True)
        If rolled Then
            Form2.UserControl11.SetBookmarkMode(Screen.bookmarkmode.Presents)
        Else : Form2.UserControl11.SetBookmarkMode(Screen.bookmarkmode.Versie)
        End If
        Form2.UserControl11.SetTextVisibility(True)
        Form2.UserControl11.SetFileVisibility(False)
        Form2.UserControl11.SetMCTimerVisibility(False)
        Form2.UserControl11.HideList()
        If resumes = True Then
            Form2.UserControl11.ClearList()
        End If
        Select Case status
            Case MyInfo.AppStatus.RollCall, MyInfo.AppStatus.Vote
                Form2.UserControl11.SetBookmarkMode(Screen.bookmarkmode.Presents)
                Form2.UserControl11.ListExtention = True
                Form2.UserControl11.UseMarkup = True
                Form2.UserControl11.ShowList()
            Case MyInfo.AppStatus.SpeakersLoist
                Form2.UserControl11.SetBookmarkMode(Screen.bookmarkmode.Timer)
                Form2.UserControl11.ListExtention = False
                Form2.UserControl11.UseMarkup = False
                Form2.UserControl11.ShowList()
            Case MyInfo.AppStatus.Motion
                Form2.UserControl11.SetBookmarkMode(Screen.bookmarkmode.Timer)
                Form2.UserControl11.ListExtention = False
                Form2.UserControl11.UseMarkup = False
                Form2.UserControl11.ShowList()
                Form2.UserControl11.SetMCTimerVisibility(True)
            Case MyInfo.AppStatus.TimerOnly
                Form2.UserControl11.SetBookmarkMode(Screen.bookmarkmode.Timer)
            Case MyInfo.AppStatus.FileView
                Form2.UserControl11.SetBookmarkMode(Screen.bookmarkmode.Timer)
                Form2.UserControl11.SetTextVisibility(False)
                Form2.UserControl11.SetFileVisibility(True)
        End Select
        Form2.MyStatus = status
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim daterel As Date = My.Computer.FileSystem.GetFileInfo("clientapp_main.exe").LastWriteTime
            UserControl11.loadlang(1)
            UserControl11.SetAppBasicInfo(My.Application.Info.Title, My.Application.Info.Version, daterel)
            UserControl11.LoadTheme(Form1.myScene)
            UserControl11.SetVoteMode(False)
            If Form1.isInMeeting Then
                ChangeStatus(Dock_NationList.rolled, MyInfo.AppStatus.Idle)
                UserControl11.subLoadMain()
                Form1.maketitil()
                UserControl11.SetPresents(Dock_NationList.pCount)
                UserControl11.subchangemaintext(Form1.txthcmotion)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub aweg(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.Width >= 1250 Then
            UserControl11.ListExtraColumn = True
        Else
            UserControl11.ListExtraColumn = False
        End If
    End Sub

    Private Sub jakljaw(sender As Object, e As EventArgs) Handles Me.Closing
        Form1.UserControl = UserControl11
    End Sub

    Private Sub abcd(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Hide()
        e.Cancel = True
    End Sub
End Class