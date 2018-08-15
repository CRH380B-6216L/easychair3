Imports LanguageScript
Imports SoundControl
Imports StandardConfData

Public Class Dock_Timer
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent
    Public timingStatus As String
    Private isTiming, inumc As Boolean
    Dim iLimit, iTick As Integer
    Public k, i As Integer
    Dim kminute, ksecond As Integer
    Dim iminute, isecond As Integer
    Dim line1 As String
    'Dim cabinTime As Date, rate, rawrate As Integer
    Dim cabinRate() As Integer = {1, 2, 3, 5, 10, 20, 30, 60, 120, 180, 360, 720, 1440}
    Public ValuePlay1 As Integer = 20

    Sub line1add()
        Select Case timingStatus
            Case "FI"
                If Form1.LoadedConference.language = 1 Then
                    line1 = "请" + Form1.txthcmotion
                Else
                    line1 = "Please " + Form1.txthcmotion
                End If
            Case Else
                line1 = Form1.txthcmotion
        End Select
    End Sub

    Sub mc_end()
        txttime.Text = 60
        txttime.Enabled = 1
        k = 0
        i = 0
        timingStatus = "MC"
        Button3.Enabled = 1
        Button4.Enabled = 1
    End Sub

    Sub mc_start_click()
        i = txttime.Text
        iTick = 0
        lblmaohao.Visible = False
        isTiming = 1
        Button3.Text = "暂停"
        Button3.Image = My.Resources.Pause
        Button3.Enabled = 1
        Call timeDisp()
    End Sub

    Sub file_start(time As Integer)
        txttime.Text = time * 60
        txttime.Enabled = False
        k = txttime.Text
        i = txttime.Text
        If time = 0 Then
            Form2.UserControl11.SetBookmarkMode(Screen.bookmarkmode.Presents)
        Else
            Call timerControl(1, False)
        End If
    End Sub

    Sub umc_start()
        txttime.Text = Motion.num_m_umc.Value * 60
        txttime.Enabled = False
        k = txttime.Text
        i = txttime.Text
        Call timerControl(1, False)
    End Sub

    Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        cabinet.ShowDialog()
        If cabinet.DialogResult = DialogResult.OK Then
            Form1.nCabinetSetting = cabinet.cabintime
            xmlsaveload.SaveClock(False)
        End If
    End Sub

    Sub mcTimeDisp(m As Integer, s As Integer)
        Dim timeleft As String = ""
        If m < 10 Then timeleft = "0"
        timeleft = timeleft + m.ToString + ":"
        If s < 10 Then timeleft = timeleft + "0"
        timeleft = timeleft + s.ToString
        'lbl_mc_total_time.Text = timeleft
    End Sub

    Sub timeDisp()
        Dim timeleft As String = ""
        kminute = k \ 60
        ksecond = k Mod 60
        iminute = i \ 60
        isecond = i Mod 60
        '============================
        If iminute < 10 Then timeleft = "0"
        timeleft = timeleft + iminute.ToString + ":"
        If isecond < 10 Then timeleft = timeleft + "0"
        timeleft = timeleft + isecond.ToString
        '============================
        lblcount.Text = timeleft
        If timingStatus = "MC" Then
            Form2.UserControl11.SetMCTimeCount(k)
        End If
    End Sub

    Sub timeract()
        Dim line2, remain As String
        If Form1.LoadedConference.myrule = 2 Then
            remain = Language1.timerString(9)
        Else
            remain = Language1.timerString(6)
        End If
        Call line1add()
        line2 = ""
        kminute = k \ 60
        ksecond = k Mod 60
        iminute = i \ 60
        isecond = i Mod 60
        Call timeDisp()
        If k = 0 Then
            Select Case timingStatus
                Case "TP"
                    line2 = Language1.timerString(0)
                Case "MC"
                    line2 = Language1.timerString(1)
                Case "CR", "FI"
                    line2 = Language1.timerString(2)
                    Call Form1.mcopenclose(True)
                Case "FS"
                    line2 = Language1.timerString(3)
                    Call Form1.mcopenclose(True)
                Case "SL", "CSL"
                    line2 = Language1.timerString(4)
                    If Not Form1.LoadedConference.myrule = 2 Then Call Dock_SpeakersList.speakerend(True)
                Case "TB", "mTB", "UMC"
                    line2 = Language1.timerString(5)
                    Call Form1.mcopenclose(True)
            End Select
            'If Not isInDbq Then timingStatus = ""
        ElseIf k < 60 Then
            line2 = remain + Str(ksecond) + Language1.timerString(8)
        Else
            line2 = remain + Str(kminute) + Language1.timerString(7) + Str(ksecond) + Language1.timerString(8)
        End If
        If i = 0 And timingStatus = "MC" Then Call Dock_Moderated.mcnext()
        'If isInDbq Then
        '    lblmain.Text = dbqText + vbCrLf + line2
        'Else
        Dock_MainScreen.lblmain.Text = line1 + vbCrLf + line2
        'End If
    End Sub

    Sub timerControl(command As Integer, reset As Boolean)
        Select Case command
            Case 0
                isTiming = False
                iTick = 0
                lblmaohao.Visible = False
                If reset Then
                    k = 0
                    i = 0
                    lblcount.ForeColor = Color.Black
                    lblcount.Text = "00:00"
                    Button3.Enabled = True
                    Button4.Enabled = True
                    txttime.Enabled = True
                    Button3.Text = "开始"
                    Button3.Image = My.Resources.StartTiming
                    Form2.UserControl11.SetTimeCount(0, True)
                Else
                    lblcount.ForeColor = Color.Blue
                End If
            Case 1
                isTiming = True
                Button3.Enabled = True
                lblcount.ForeColor = Color.Black
        End Select
    End Sub

    Private Sub Dock_Timer_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Me.MdiParent = Form1
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'lbltime显示时间
        Dim curtime As String
        If Form1.nCabinetSetting.isCabinet = True And Form1.isStarted Then
            Form1.nCabinetSetting.AddMilliseconds()
            curtime = Form1.nCabinetSetting.cabintime
            Form2.UserControl11.SetTime(Form1.nCabinetSetting.cabintime, Form1.nCabinetSetting.cabintime)
        Else
            curtime = Date.Today + " " + TimeOfDay
            Form2.UserControl11.SetTime(Date.Today, TimeOfDay)
        End If
        lbltime.Text = curtime

        '定时开始等待
        If Form1.isWaiting Then
            If DateTime.Compare(Form1.timeStart, DateTime.Now) <= 0 Then
                Form1.isWaiting = 0
                Form1.nRWriter.Add(New Record.RecordContent(Record.RecordCategory.ST, DateTime.Now, Form1.session))
                Dim sound As New SoundControl.Class1
                sound.playSfx(3)
                'Dim autosave As New System.IO.StreamWriter("saved\" + lastPath + "\record.txt", True)
                'autosave.Write(Date.Today + " " + TimeOfDay + vbCrLf + conference + vbCrLf + committee + vbCrLf + topic(topicSelection) + vbCrLf + infoString(2) + session + infoString(3) + infoString(4) + vbCrLf + vbCrLf)
                'autosave.Close()
                'autosave.Dispose()
                Dock_WaitControl.Close()
            End If
        End If

        If isTiming Then
            iTick = iTick + 1
            Select Case iTick
                Case 8
                    If i >= 50 Then lblcount.ForeColor = Color.Black
                    Form2.UserControl11.SetTimeCount(i, False)
                    lblmaohao.Visible = True
                Case 16
                    lblmaohao.Visible = False
                    Select Case timingStatus
                        Case "CR", "FI", "FS"
                            iLimit = 30
                        Case "TB", "mTB", "UMC"
                            iLimit = 60
                            inumc = True
                        Case Else
                            iLimit = 20
                    End Select
                    '===========================
                    If k = 0 Or i = 0 Then
                        If Form1.LoadedConference.myrule = 2 Then
                            k = k + 1
                            i = i + 1
                        End If
                    Else
                        isTiming = True
                        Button3.Text = "暂停"
                        Button3.Image = My.Resources.Pause
                        If Form1.LoadedConference.myrule = 2 Then
                            k = k + 1
                            i = i + 1
                            If i Mod 60 = 0 Then lblcount.ForeColor = Color.Red
                        Else
                            k = k - 1
                            i = i - 1
                            If i <= iLimit Then
                                lblcount.ForeColor = Color.Red
                            Else
                                lblcount.ForeColor = Color.Black
                            End If
                        End If
                        'kminute = k \ 60
                        'ksecond = k Mod 60
                        'iminute = i \ 60
                        'isecond = i Mod 60
                    End If
                    Form2.UserControl11.SetTimeCount(i, True)
                    Call timeDisp()
                    '============================
                    Select Case i
                        Case 0
                            inumc = 0
                            Dim sound As New SoundControl.Class1
                            sound.playSfx(0)
                            isTiming = False
                            'If isYield = True Then yield.Close()
                            'isYield = False
                            If timingStatus <> "MC" Then
                                txttime.Enabled = True
                                'If Not isInDbq Then
                                '    If timingStatus = "SL" Then tlp_taskbar.Enabled = 1
                                'End If
                            Else
                                'If Not isInDbq Then Call mcnext()
                            End If
                            'btn_umc_close.Visible = 1
                            Button3.Text = "开始"
                            Button3.Image = My.Resources.StartTiming
                        'speaker.Button2.Enabled = False
                        'speaker.Button3.Enabled = True
                        Case iLimit
                            If inumc Then
                                Dim sound As New SoundControl.Class1
                                sound.playSfx(2)
                            Else
                                Dim sound As New SoundControl.Class1
                                sound.playSfx(1)
                            End If
                    End Select
                    iTick = 0
            End Select
            Call timeract()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "开始" Then
            'Call countStart()
        ElseIf Button3.Text = "暂停" Then
            Call timerControl(0, False)
            Button3.Text = "继续"
            Button3.Image = My.Resources.StartTiming
            If timingStatus <> "" Then
                'lblmain.Text = lblmain.Text + " - " + Timer(9)
            End If
            lblcount.ForeColor = Color.Blue
        Else
            isTiming = True
            lblcount.ForeColor = Color.Black
            Button3.Text = "暂停"
            Button3.Image = My.Resources.Pause
        End If
    End Sub
End Class