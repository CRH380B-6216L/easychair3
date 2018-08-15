Imports LanguageScript
Imports StandardConfData.MyInfo.ConferenceStatus
Imports StandardConfData.MyInfo.SpeakersList

Public Class Dock_SpeakersList
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

    Sub makeList()
        Dim capacity As Integer = Form2.UserControl11.ListCapacity
        Dim capaciti1 As Integer = capacity * (slCurrent \ Form2.UserControl11.ListCapacity + 1)
        Dim i As Integer = slCurrent \ 30 * 30 + 1
        Do While i <= capaciti1
            If i > capaciti1 Then Exit Do
            If i <= slCurrent Then
                Form2.UserControl11.SetListItme(slcurr(i), slNations(i), True)
            Else
                Form2.UserControl11.SetListItme(slcurr(i), slNations(i), False)
            End If
            i = i + 1
        Loop
        Form2.UserControl11.SetPage(slCurrent \ capacity + 1, slTotal \ capacity + 1)
    End Sub

    Sub slStringGenerake()
        Dim slstring As String
        If Form1.LoadedConference.language = 1 Then
            slstring = "主发言名单 (" + slTime(1).ToString
            If slTime(0) = 0 Then
                slstring = slstring + "分钟)"
            Else
                slstring = slstring + "分" + slTime(0).ToString + "秒)"
            End If
            slstring = slstring + vbCrLf + "当前发言: " + slNations(slCurrent + 1)
        Else
            slstring = "Speakers' List (" + slTime(1).ToString
            If slTime(0) = 0 Then
                slstring = slstring + " minutes)"
            Else
                slstring = slstring + "m " + slTime(0).ToString + "s)"
            End If
            slstring = slstring + vbCrLf + "Current: " + slNations(slCurrent + 1)
        End If
        Form1.txthcmotion = slstring
    End Sub

    Sub slNationAdd()
        If txt_spl_add.Text = "" Then
        Else
            slNations(slTotal + 1) = txt_spl_add.Text
            Dim singleItme(3) As String
            singleItme(1) = slNations(slTotal + 1)
            If slTotal = slCurrent Then
                txt_spl_currentnunber.Text = slCurrent + 1
                txt_spl_current.Text = slNations(slCurrent + 1)
                singleItme(0) = ">"
            End If
            ListView1.Items.Add(New ListViewItem(singleItme))
            slTotal = slTotal + 1
            Form2.UserControl11.SetListItme(slcurr(slTotal), slNations(slTotal), False)
            txt_spl_totalnumber.Text = slTotal + 1
            Call xmlsaveload.slAddNationToConfig(txt_spl_add.Text, slTotal)
            txt_spl_add.Text = ""
            txt_spl_add.Select()
            'If slTotal <= listCapacity * (page + 1) Then
            'Call listAction("add", (slTotal - 1) - listCapacity * page, slNations(slTotal))
            'Else
            'Call autoPage(page + 1)
            'End If
        End If
    End Sub

    Sub speakerend(ByVal timeout As Boolean)
        'Call sperkerClose()
        Call Dock_Timer.timerControl(0, False)
        '=======================
        btn_spl_add.Enabled = True
        btn_spl_start.Enabled = True
        txt_spl_add.Enabled = True
        btn_spl_start.Text = "开始"
        If timeout = False Then
            If Not Form1.LoadedConference.myrule = 2 Then
                If Form1.LoadedConference.language = 1 Then
                    Dock_MainScreen.lblmain.Text = Form1.txthcmotion + vbCrLf + "发言结束"
                Else
                    Dock_MainScreen.lblmain.Text = Form1.txthcmotion + vbCrLf + "Speech Finished"
                End If
                Call Dock_Timer.timerControl(0, True)
            End If
        Else
            'If Not isInDbq Then
            '   Call record_v2.addNewrecord(timingStatus, timeStart, DateTime.Now, name1, cslTitle, yieldSubject, yieldType)
            'End If
            Call slSpeakNext()
            yieldType = 0
        End If
    End Sub

    Function slcurr(i As Integer)
        slcurr = i Mod Form2.UserControl11.ListCapacity
        If slcurr = 0 Then slcurr = Form2.UserControl11.ListCapacity
    End Function

    Sub slSpeakNext()
        Call recordaccess.slmodify(Form1.recIndex, cbx_spl_yield.SelectedIndex, yieldSubject)
        cbx_spl_yield.SelectedIndex = 0
        'Call listAction("modify", slCurrent - listCapacity * page, "")
        ListView1.Items(slCurrent).SubItems(0).Text = ""
        slCurrent = slCurrent + 1
        Form2.UserControl11.SetListItme(slcurr(slCurrent), slNations(slCurrent), True)
        If slCurrent = slTotal Then
            txt_spl_current.Text = ""
            btn_spl_start.Enabled = False
        Else
            txt_spl_currentnunber.Text = slCurrent + 1
            txt_spl_current.Text = slNations(slCurrent + 1)
            ListView1.Items(slCurrent).SubItems(0).Text = ">"
        End If
        'Call display((slCurrent - 1) \ 50)
        'current = (slCurrent - 1) \ 50
        'If slCurrent >= (page + 1) * listCapacity Then Call autoPage(page + 1)
        'Call saveSlist()
        btn_spl_add.Enabled = True
        cbx_spl_yield.Enabled = False
        Dock_Timer.txttime.Enabled = False
    End Sub

    Sub yieldAction(type As Integer)
        Select Case type
            Case 1
                Label28.Text = "让渡给　　　　　　　　　　 代表"
                txt_spl_yieldto.Left = 57
                btn_spl_yieldgo.Text = "开始"
                yieldType = 1
            Case 2
                Label28.Text = "提问的国家"
                btn_spl_yieldgo.Text = "回答开始"
                txt_spl_yieldto.Left = 83
                yieldType = 2
            Case 3
                Label28.Text = "评论的国家"
                btn_spl_yieldgo.Text = "开始"
                txt_spl_yieldto.Left = 83
                yieldType = 3
        End Select
    End Sub

    Sub yieldAct(ByVal type As Integer, ByVal start As Boolean, ByVal isContinue As Boolean)
        Dim yieldText As String
        isYield = True
        If start = True Then
            If Not isContinue Then
                Select Case type
                    Case 1
                        yieldText = Language1.yieldString(0) + txt_spl_yieldto.Text
                        If Form1.LoadedConference.language = 1 Then
                            yieldText = yieldText + "代表"
                        End If
                        Form1.txthcmotion = yieldText
                    Case 2
                        yieldText = Language1.yieldString(1) + vbCrLf + Language1.yieldString(2) + txt_spl_yieldto.Text
                        Form1.txthcmotion = yieldText
                    Case 3
                        yieldText = Language1.yieldString(3) + vbCrLf + Language1.yieldString(4) + txt_spl_yieldto.Text
                        Form1.txthcmotion = yieldText
                End Select
                yieldSubject = txt_spl_yieldto.Text
                slEndTime = DateTime.Now
            Else
                yieldText = ", " + txt_spl_yieldto.Text
                yieldSubject = ", " + txt_spl_yieldto.Text
                Form1.txthcmotion = Form1.txthcmotion + yieldText
            End If
            'Call writeRecord(yieldText)
            Call Dock_Timer.timerControl(1, False)
            btn_spl_start.Text = "暂停"
            cbx_spl_yield.Enabled = False
        Else
            Call speakerend(False)
            Call slSpeakNext()
            If type = 4 Then
                slEndTime = DateTime.Now
                Dock_MainScreen.lblmain.Text = Form1.txthcmotion + vbCrLf + Language1.yieldString(5)
            Else
                If Form1.LoadedConference.language = 1 Then
                    Dock_MainScreen.lblmain.Text = Form1.txthcmotion + vbCrLf + "让渡发言结束"
                Else
                    Dock_MainScreen.lblmain.Text = Form1.txthcmotion + vbCrLf + "Yield-time Speech Finished"
                End If
            End If
            'Call record_v2.addNewrecord(timingStatus, timeStart, slEndTime, name1, cslTitle, yieldSubject, type)
            isYield = False
            yieldSubject = ""
        End If
    End Sub

    Private Sub Dock_SpeakersList_GotFocus(sender As Object, e As EventArgs) Handles txt_spl_totalnumber.GotFocus
        If Form1.isStarted Then
            Form2.MyStatus = StandardConfData.MyInfo.AppStatus.SpeakersLoist
            Call Form2.ChangeStatus(True, 2)
            Call makeList()
        End If
    End Sub

    Private Sub Dock_SpeakersList_Load(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If Me.Height < 270 And Not Me.Width < 450 Then
            Dim c As Control = Me.TableLayoutPanel1.GetControlFromPosition(0, 1)
            If Not c Is Nothing Then
                Me.TableLayoutPanel1.SetColumnSpan(c, 1)
                Me.TableLayoutPanel1.SetCellPosition(c, New TableLayoutPanelCellPosition(1, 0))
                Me.TableLayoutPanel1.SetRowSpan(c, 2)
            End If
        End If
        If Me.Width < 450 And Not Me.Height < 270 Then
            Dim c As Control = Me.TableLayoutPanel1.GetControlFromPosition(1, 0)
            If Not c Is Nothing Then
                Me.TableLayoutPanel1.SetRowSpan(c, 1)
                Me.TableLayoutPanel1.SetCellPosition(c, New TableLayoutPanelCellPosition(0, 1))
                Me.TableLayoutPanel1.SetColumnSpan(c, 2)
            End If
        End If
    End Sub

    Private Sub btn_spl_add_Click(sender As Object, e As EventArgs) Handles btn_spl_add.Click
        Call slNationAdd()
    End Sub

    Private Sub txt_spl_add_TextChanged(sender As Object, e As KeyEventArgs) Handles txt_spl_add.KeyUp
        If e.KeyCode = 13 Then
            Call slNationAdd()
        End If
    End Sub

    Private Sub btn_spl_start_Click(sender As Object, e As EventArgs) Handles btn_spl_start.Click
        If btn_spl_start.Text = "开始" Then
            'timeStart = DateTime.Now
            btn_spl_start.Text = "完成"
            cbx_spl_yield.Enabled = False
            Dock_Timer.timingStatus = "SL"
            Call xmlsaveload.CreateRecord(Form1.recIndex, Dock_Timer.timingStatus)
            Call xmlsaveload.slNext(slCurrent + 1)
            slIsSpoken(slCurrent + 1) = Form1.recIndex
            'If myrule = 2 Then
            '    btn_spl_yieldend.Visible = 1
            '    timingStatus = "scSL"
            'End If
            'If Not page = slCurrent \ listCapacity Then
            '    Call autoPage(slCurrent \ listCapacity)
            '    Call maxPages()
            'End If
            Call slStringGenerake()
            Dock_Timer.txttime.Text = slTime(1) * 60 + slTime(0)
            Dock_Timer.k = Dock_Timer.txttime.Text
            Dock_Timer.i = Dock_Timer.txttime.Text
            Call Dock_Timer.timerControl(1, False)
            Dock_Timer.Button4.Enabled = False
            '=======================
            btn_spl_add.Enabled = False
            txt_spl_add.Enabled = False
        Else
            btn_spl_start.Text = "开始"
            btn_spl_start.Enabled = False
            Dock_Timer.Button3.Enabled = False
            If Dock_Timer.k < 10 Then
                Call yieldAct(4, False, False)
            Else
                Call Dock_Timer.timerControl(0, False)
                Dock_MainScreen.lblmain.Text = Form1.txthcmotion + vbCrLf + Language1.yieldString(6) + Language1.timerString(6)
                If Dock_Timer.k >= 60 Then Dock_MainScreen.lblmain.Text = Dock_MainScreen.lblmain.Text + (Dock_Timer.k \ 60).ToString + Language1.timerString(7)
                Dock_MainScreen.lblmain.Text = Dock_MainScreen.lblmain.Text + (Dock_Timer.k Mod 60).ToString + Language1.timerString(8) + Language1.yieldString(7)
                cbx_spl_yield.Enabled = True
            End If
            cbx_spl_yield.Enabled = True
        End If
    End Sub

    Private Sub cbx_spl_yield_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_spl_yield.SelectedIndexChanged
        Select Case cbx_spl_yield.SelectedIndex
            Case 4
                Call yieldAct(4, False, False)
            Case 0
                Label28.Visible = False
                txt_spl_yieldto.Visible = False
                btn_spl_yieldgo.Visible = False
                btn_spl_yieldend.Visible = False
            Case Else
                Call yieldAction(cbx_spl_yield.SelectedIndex)
                Label28.Visible = True
                txt_spl_yieldto.Visible = True
                btn_spl_yieldgo.Visible = True
                btn_spl_yieldend.Visible = True
        End Select
    End Sub

    Private Sub btn_spl_yieldgo_Click(sender As Object, e As EventArgs) Handles btn_spl_yieldgo.Click
        If btn_spl_yieldgo.Text = "开始" Or btn_spl_yieldgo.Text = "回答开始" Then
            Call yieldAct(yieldType, True, False)
            If cbx_spl_yield.SelectedIndex = 1 Then
                btn_spl_yieldgo.Visible = False
            Else
                btn_spl_yieldgo.Text = "完成并准备下一个"
            End If
        ElseIf btn_spl_yieldgo.Text = "完成并准备下一个" Then
            Call Dock_Timer.timerControl(0, 0)
            txt_spl_yieldto.Text = ""
            txt_spl_yieldto.Select()
            btn_spl_yieldgo.Text = "开始下一个"
        Else
            Call yieldAct(yieldType, True, True)
            btn_spl_yieldgo.Text = "完成并准备下一个"
        End If
    End Sub

    Private Sub btn_spl_yieldend_Click(sender As Object, e As EventArgs) Handles btn_spl_yieldend.Click
        Call yieldAct(yieldType, False, False)
    End Sub

    Private Sub Dock_SpeakersList_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        cbx_spl_yield.SelectedIndex = 0
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.ItemActivate
        Dim index1 As Integer = ListView1.SelectedItems.Item(0).Index + 1
        MsgBox("slItemIndex: " + index1.ToString + vbCrLf + "ReferenceNr: " + slIsSpoken(index1).ToString)
    End Sub

    Private Sub abcd(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Hide()
        e.Cancel = True
    End Sub
End Class