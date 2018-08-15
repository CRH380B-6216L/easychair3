Imports LanguageScript
Imports WeifenLuo.WinFormsUI.Docking
Imports StandardConfData
Imports Console_link

Public Class Form1
    Inherits Form
    '%windir%\system32\displayswitch.exe
    Dim genetext As String
    Public lastPath As String, timeStart As DateTime
    Dim listCapacity As Integer
    Public LoadedConference As MyInfo.Conference
    Public nNationList As MyInfo.NationList
    Public nFileList As MyInfo.FileList
    Public nSpeakersList As MyInfo.SpeakersList2
    Public nCabinetSetting As MyInfo.CabinetSetting
    Public nRWriter As Record.RecordWriter
    Public WithEvents CLclient As LinkClient
    'Public language, topicSelection, myrule As Integer, conference, committee, topic(1)
    Public myScene As String
    Dim dckPanel As DockPanel
    Public UserControl As Screen.UserControl1
    'Public nation(193) As String, nationAtt(193) As Boolean
    'WIfi BJ31247mun

    Public isInMeeting, isStarted, isWaiting, isWidescr, isOnScreen As Boolean
    Public session, recIndex, presentWhenRoll As Integer
    Public txthcmotion As String

    Dim nations(100), opini(100), a1, a2 As String, yes, no, abst, pnat(99), vtTotal, vtCurrent, p, q, maj67vote, voteStep As Integer
    Dim r2, votePresentSaved As Boolean
    Dim current As Integer

    Dim dock1_Nationlist As DockContent = Dock_NationList
    Dim dock1_Mainscreen As DockContent = Dock_MainScreen
    Dim dock1_Speakerslist As DockContent = Dock_SpeakersList
    Dim dock1_Moderated As DockContent = Dock_Moderated
    Dim dock1_Filemanage As DockContent = Dock_FileManage
    Dim dock1_Timer As DockContent = Dock_Timer
    Dim dock1_WaitControl As DockContent = Dock_WaitControl
    Dim dock1_CrisisWriter As DockContent = Dock_CrisisWriter
    Dim dock1_ConsoleLink As DockContent = Dock_PressCentre

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        '
        ' Add the Dock Panel
        '
        Me.SuspendLayout()
        dckPanel = New DockPanel
        With dckPanel
            .Parent = Me
            .Dock = DockStyle.Fill
            .BringToFront()
        End With
        Me.ResumeLayout()

    End Sub

    Private Function mdck_BuildDockContent(ByVal persistString As String) As DockContent
        Console.WriteLine(persistString)
        '
        ' What we do first is scan all the existing
        ' forms to see if this form already exists
        '
        'Dim cf As frmChildForm
        'For Each cf In Forms
        'If cf.PersistString = persistString Then
        'Return cf
        'End If
        'Next
        'http://dockpanelsuitcsharpexamples.googlecode.com/svn/trunk/Lib/DockPanelSuite/DockPanel%20for%20VB.NET%20(Full).doc
        If persistString.Trim.Substring(0, 7) = "RecordInput" Then
            Dim nIndex As Integer = 0
            If persistString.Trim.Length > 7 Then
                nIndex = CInt(persistString.Trim.Substring(8))
            End If
            'Dim frmX As New Dock_RecordInput(nIndex)
            'Return frmX
        Else
            Select Case persistString
                Case "clientapp_main.Dock_MainScreen"
                    Return dock1_Mainscreen
                Case "clientapp_main.Dock_NationList"
                    Return dock1_Nationlist
                Case "clientapp_main.Dock_WaitControl"
                    Return dock1_WaitControl
                Case "clientapp_main.Dock_SpeakersList"
                    Return dock1_Speakerslist
                Case "clientapp_main.Dock_Timer"
                    Return dock1_Timer
                Case "clientapp_main.Dock_Moderated"
                    Return dock1_Moderated
                Case "clientapp_main.Dock_FileManage"
                    Return dock1_Filemanage
                Case "clientapp_main.Dock_ConsoleLink"
                    Return dock1_ConsoleLink
            End Select
        End If
    End Function

    Function GetAttendentNumber() As Integer
        Dim a As Integer = 0
        For Each i In nNationList
            If i.Attendence = True Then a = a + 1
        Next
        Return a
    End Function

    Sub OpenWorkstate()
        Dim configFile As String =
      System.IO.Path.Combine(System.IO.Path.GetDirectoryName(
                      Application.ExecutablePath), "DockPanel.config")

        If System.IO.File.Exists(configFile) Then
            ' Params to LoadFromXml are:
            ' - XML Config file
            ' - Pointer to the Fn that takes a Persist String & 
            ' returns a DockContent object
            dckPanel.LoadFromXml(configFile, AddressOf mdck_BuildDockContent)
        Else
            Dock_MainScreen.Show(dckPanel, DockState.Document)
            Dock_Moderated.Show(dckPanel, DockState.DockBottom)
            Dock_NationList.Show(dckPanel, DockState.DockLeft)
            Dock_SpeakersList.Show(dckPanel, DockState.DockLeft)
            Dock_Timer.Show(dckPanel, DockState.DockRight)
            Dock_WaitControl.Show(dckPanel, DockState.DockRight)
            Dock_FileManage.Show(dckPanel, DockState.DockRight)
        End If
        会议CToolStripMenuItem.Visible = 1
        动议MToolStripMenuItem.Visible = 1
        会场文件PToolStripMenuItem.Visible = 1
        Dock_Timer.Show()
        Dock_NationList.Show()
        Try
            Form2.UserControl11.subLoadMain()
            Form2.UserControl11.LoadTheme(myScene)
            Form2.ChangeStatus(Dock_NationList.rolled, MyInfo.AppStatus.Idle)
        Catch ex As Exception

        End Try
        If Not isStarted Then Call mcopenclose(False)
        isInMeeting = True
    End Sub

    Sub maketitil()
        Dim fenge As String = Language1.infoString(5)
        Dim huiqi() As String = New String() {Language1.infoString(2), Language1.infoString(3)}
        Dim left As String = LoadedConference.ConferenceTitle + fenge + LoadedConference.Committee
        Dim right As String = LoadedConference.Topic(LoadedConference.topicSel)
        If isStarted Then
            right = right + fenge + huiqi(0) + session.ToString + huiqi(1)
        End If
        Form2.UserControl11.subchangetitle(left, right)
    End Sub

    Sub loadevent(path As String)
        lastPath = path
        Dim newsave As New System.IO.StreamWriter("lastsave.txt")
        newsave.WriteLine(lastPath)
        newsave.Close()
        最近使用的项目ToolStripMenuItem1.Text = lastPath
        Call xmlsaveload.loadbasic()
        'MsgBox(LoadedConference.ConferenceTitle + vbCrLf + LoadedConference.Committee + vbCrLf + LoadedConference.Topic(LoadedConference.topicSel) + vbCrLf + LoadedConference.language.ToString)
        Call Language1.loadLanguageScript(LoadedConference.language, LoadedConference.myrule)
        Call maketitil()
        Call dianmingopenclose(Not isStarted)
        Call mcopenclose(isStarted)
        Call xmlsaveload.loadAttendance()
        Call xmlsaveload.loadSL()
        Call xmlsaveload.loadFile()
        nRWriter = New Record.RecordWriter(lastPath + "record.xml", "ConferenceRecord")
        Form2.UserControl11.SetPresents(Dock_NationList.pCount)
        Call OpenWorkstate()
        Dim autotxt() As TextBox = New TextBox() {Dock_SpeakersList.txt_spl_add, Dock_Moderated.txt_mc_add, Motion.TextBox1, Dock_SpeakersList.txt_spl_yieldto}
        For Each tb As TextBox In autotxt
            tb.AutoCompleteCustomSource.Clear()
            For Each nation As MyInfo.Nation In nNationList
                tb.AutoCompleteCustomSource.Add(nation.ToString)
            Next
        Next
        Form2.UserControl11.subchangemaintext(My.Application.Info.Title + vbCrLf + My.Application.Info.Copyright + vbCrLf + "All rights reserved")
    End Sub

    Sub dianmingopenclose(open As Boolean)
        开始新会期SToolStripMenuItem.Enabled = open
        点名RToolStripMenuItem.Enabled = open
        'Dock_NationList.Button1.Enabled = open
        Dock_NationList.ToolStripButton1.Enabled = open
    End Sub

    Sub mcopenclose(close As Boolean)
        Dock_SpeakersList.TableLayoutPanel1.Enabled = close
        主发言名单LToolStripMenuItem.Enabled = close
        动议MToolStripMenuItem.Enabled = close
        Select Case Dock_Timer.timingStatus
            Case "FI", "FS", "CR"
            Case Else
                If close = True Then Call Form2.ChangeStatus(Dock_NationList.rolled, MyInfo.AppStatus.Idle)
        End Select
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If isInMeeting And isStarted And nCabinetSetting IsNot Nothing AndAlso nCabinetSetting.isCabinet Then Call xmlsaveload.ClosingClock()
        'Shell("C:\Windows\system32\displayswitch.exe /internal")
        Try
            Shell("C:\Windows\system32\PresentationSettings.exe /stop")
        Catch ex As Exception

        End Try
    End Sub

    Sub ShowNationDetails()
        Try
            Dock_NationDetail.Show(dckPanel, DockState.Document)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dock_TaskWindow.Show(dckPanel, DockState.Document)
        Dim configFile As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Application.ExecutablePath), "DockPanel.config")
        If System.IO.File.Exists(configFile) Then
            ' Params to LoadFromXml are:
            ' - XML Config file
            ' - Pointer to the Fn that takes a Persist String &
            ' returns a DockContent object
            'dckPanel.LoadFromXml(configFile, AddressOf mdck_BuildDockContent)
        Else
            'Load a basic layout
            'm_ViewVideoList()
            'm_ViewPicture()
        End If

        Try
            Dim loadLast As New System.IO.StreamReader("lastsave.txt")
            lastPath = loadLast.ReadLine
            loadLast.Close()
            最近使用的项目ToolStripMenuItem1.Text = lastPath
            最近使用的项目ToolStripMenuItem1.Enabled = True
        Catch ex As Exception

        End Try
        Try
            myScene = "(Default)"
            Form2.Show()
            Form2.UserControl11.subchangemaintext(My.Application.Info.Title + vbCrLf + My.Application.Info.Copyright + vbCrLf + "All rights reserved")
        Catch ex As Exception

        End Try
    End Sub

    Sub NewMeetingCreate()
        NewMeeting.ShowDialog()
        If NewMeeting.DialogResult = System.Windows.Forms.DialogResult.OK Then
            LoadedConference = New MyInfo.Conference
            With LoadedConference
                .ConferenceTitle = NewMeeting.TextBox1.Text
                .Committee = NewMeeting.TextBox2.Text
                .Topic(0) = NewMeeting.TextBox3.Text
                .topicSel = 0
                If NewMeeting.CheckBox1.Checked Then .topicSel = 2
                .Topic(1) = NewMeeting.TextBox4.Text
                .myrule = NewMeeting.cbx_rulesel.SelectedIndex
                If NewMeeting.RadioButton4.Checked Then .language = 1 Else .language = 2
            End With
            nNationList = New MyInfo.NationList
            For Each i In NewMeeting.ListBox1.Items
                Dim n As New MyInfo.Nation
                n.Name = i.ToString
                nNationList.Add(n)
            Next
            nFileList = New MyInfo.FileList
            lastPath = NewMeeting.TextBox5.Text + "\"
            nCabinetSetting = New MyInfo.CabinetSetting
            Call xmlsaveload.CreateMeting(lastPath, LoadedConference)
            Dim newsave As New System.IO.StreamWriter("lastsave.txt")
            newsave.WriteLine(lastPath)
            newsave.Close()
            最近使用的项目ToolStripMenuItem1.Text = lastPath
            新建会议NToolStripMenuItem.Enabled = False
            Call loadevent(lastPath)
        End If
    End Sub

    Private Sub frmMaster_Closing(ByVal sender As Object,
                            ByVal e As System.ComponentModel.CancelEventArgs) _
                            Handles MyBase.Closing
        '         =================
        If isInMeeting Then
            Dim configFile As String =
        IO.Path.Combine(IO.Path.GetDirectoryName(
        Application.ExecutablePath), "DockPanel.config")
            dckPanel.SaveAsXml(configFile)
        End If
    End Sub

    Private Sub 新建会议NToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新建会议NToolStripMenuItem.Click
        Call NewMeetingCreate()
    End Sub

    Private Sub 退出XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出XToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub 最近使用的项目ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 最近使用的项目ToolStripMenuItem1.Click
        Call loadevent(lastPath)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dock_Timer.ToolStripButton3_Click(sender, EventArgs.Empty)
    End Sub

    Private Sub 国家信息IToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 国家信息IToolStripMenuItem.Click
        Call ShowNationDetails()
    End Sub

    Private Sub ConsoleLinkKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsoleLinkKToolStripMenuItem.Click
        Dim dock1_ConsoleLink As DockContent = Dock_PressCentre
        Dock_PressCentre.Show(dckPanel, DockState.DockRight)
    End Sub

    Private Sub 发送会场消息DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 发送会场消息DToolStripMenuItem.Click
        Dialog_CustomMsg.ShowDialog()
        If Dialog_CustomMsg.DialogResult = DialogResult.OK Then
            Dock_MainScreen.lblmain.Text = Dialog_CustomMsg.TextBox1.Text
            Dialog_CustomMsg.TextBox1.Text = ""
        End If
    End Sub

    Private Sub ToolStripSplitButton1_Click(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.Click

    End Sub

    Sub newsession1()
        Form2.MyStatus = MyInfo.AppStatus.Idle
        Call Form2.ChangeStatus(Dock_NationList.rolled, MyInfo.AppStatus.Idle)
        NewSession.ShowDialog()
        Dim mystartstring As String
        If NewSession.DialogResult = Windows.Forms.DialogResult.OK Then
            mystartstring = Language1.infoString(6) + LoadedConference.ConferenceTitle + vbCrLf + LoadedConference.Committee + vbCrLf + LoadedConference.Topic(LoadedConference.topicSel) + vbCrLf + Language1.infoString(2) + NewSession.txtsession.Text + Language1.infoString(3)
            'lblopic.Text = lblopic.Text + infoString(5) + infoString(2) + txtsession.Text + infoString(3)

            If NewSession.rad_immediatestart.Checked Then
                'Dim autosave As New System.IO.StreamWriter("saved\" + lastPath + "\record.txt", True)
                'autosave.Write(Date.Today + " " + TimeOfDay + vbCrLf + conference + vbCrLf + committee + vbCrLf + topic(topicSelection) + vbCrLf + infoString(2) + txtsession.Text + infoString(3) + infoString(4) + vbCrLf + vbCrLf)
                'autosave.Close()
                'autosave.Dispose()
                'panel_roll.Visible = 1
                'panel_roll_list.Visible = True
                'btn_roll_finish.Visible = True
                nRWriter.Add(New Record.RecordContent(Record.RecordCategory.ST, DateTime.Now, session))
                isStarted = True
            Else
                isWaiting = 1
                timeStart = New DateTime(Today.Year, Today.Month, Today.Day, NewSession.numstarth.Value, NewSession.numstartm.Value, 0)
                If DateTime.Compare(timeStart, DateTime.Now) < 0 Then timeStart.AddDays(1)
                Dim mm As String = NewSession.numstartm.Value
                If NewSession.numstartm.Value < 10 Then mm = "0" + mm
                Dock_WaitControl.panel_roll_string.Enabled = True
                Dock_WaitControl.Label17.Text = timeStart
                Dock_WaitControl.Label17.Text = "预计开始的时间: " + vbCrLf + Dock_WaitControl.Label17.Text
                mystartstring = mystartstring + vbCrLf + Language1.infoString(7) + NewSession.numstarth.Value.ToString + ":" + mm + Language1.infoString(8)
            End If
            session = NewSession.txtsession.Text
            Call maketitil()
            Dock_MainScreen.lblmain.Text = mystartstring
            xmlsaveload.ModifyStarted()
            开始新会期SToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub 开始新会期SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 开始新会期SToolStripMenuItem.Click
        Call newsession1()
    End Sub

    Private Sub 点名RToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 点名RToolStripMenuItem.Click
        If isStarted Then
            Call Dock_NationList.Button1_Click(点名RToolStripMenuItem, EventArgs.Empty)
            Call Form2.ChangeStatus(True, MyInfo.AppStatus.Idle)
        Else
            Call newsession1()
        End If
    End Sub

    Private Sub 主发言名单LToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 主发言名单LToolStripMenuItem.Click, 主发言名单SToolStripMenuItem.Click
        dock1_Speakerslist.Show()
        dock1_Speakerslist.BringToFront()
    End Sub

    Private Sub 有主持核心磋商CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 有主持核心磋商CToolStripMenuItem.Click, 自由磋商UToolStripMenuItem.Click, 调整发言时间AToolStripMenuItem.Click, 调整投票顺序OToolStripMenuItem.Click, 对文件投票VToolStripMenuItem.Click, 茶歇TToolStripMenuItem.Click, 结束辩论EToolStripMenuItem.Click, 休会SToolStripMenuItem.Click
        Dim motionItmes() As ToolStripMenuItem = New ToolStripMenuItem() {有主持核心磋商CToolStripMenuItem, 自由磋商UToolStripMenuItem, 调整发言时间AToolStripMenuItem, 调整投票顺序OToolStripMenuItem, 对文件投票VToolStripMenuItem, 茶歇TToolStripMenuItem, 结束辩论EToolStripMenuItem, 休会SToolStripMenuItem}
        Dim i As Integer = 0
        For Each itme In motionItmes
            If sender.Equals(motionItmes(i)) Then
                Motion.ComboBox1.SelectedIndex = i
                Exit For
            End If
            i = i + 1
        Next
        Form2.MyStatus = MyInfo.AppStatus.Idle
        Call Form2.ChangeStatus(Dock_NationList.rolled, MyInfo.AppStatus.Idle)
        Call Motion.chushihua()
        Motion.ShowDialog()
        If Motion.DialogResult = Windows.Forms.DialogResult.OK Then
            Call mcopenclose(False)
            Select Case Motion.ComboBox1.SelectedIndex
                Case 0
                    Dock_Timer.txttime.Text = Motion.num_m_mc_2.Value
                    Dock_Timer.txttime.Enabled = False
                    Dock_MainScreen.lblmain.Text = txthcmotion
                    Dock_Moderated.TableLayoutPanel1.Enabled = True
                    Dock_Timer.k = Motion.num_m_umc.Value * 60
                    Dock_Timer.i = Motion.num_m_mc_2.Value
                    Dock_Timer.timingStatus = "MC"
                    'Call mcTimeDisp(num_m_mc_1.Value, 0)
                    Form2.UserControl11.SetPage(1, 1)
                    Dock_Timer.Button3.Enabled = False
                    Dock_Timer.Button4.Enabled = False
                    Call mcReady()
                    Dock_Moderated.txt_mc_add.Text = Motion.TextBox1.Text
                Case 1, 5
                    If Motion.ComboBox1.SelectedIndex = 1 Then
                        'Label100.Text = "自由磋商进行中"
                        Dock_Timer.timingStatus = "UMC"
                    Else
                        'Label100.Text = "茶歇进行中"
                        Dock_Timer.timingStatus = "mTB"
                    End If
                    Call Dock_Timer.umc_start()
                    Call Form2.ChangeStatus(Dock_NationList.rolled, MyInfo.AppStatus.TimerOnly)
                Case 2
                    Dim mm As Integer = Motion.num_m_spl_1.Value
                    Dim ss As Integer = Motion.num_m_spl_2.Value
                    MyInfo.SpeakersList.slTime(1) = mm
                    MyInfo.SpeakersList.slTime(0) = ss
                    Call mcopenclose(True)
                Case 3
                    Call mcopenclose(True)
                Case 4
                    Dim filename = Motion.cbx_mfileselect.SelectedItem
                    Dim index = Dock_FileManage.ListBox1.Items.IndexOf(filename)
                    Dock_FileManage.ListBox1.SetSelected(index, True)
                    Call mcopenclose(True)
                    Dock_FileManage.Clickvote()
                Case 6, 7
                    If Motion.ComboBox1.SelectedIndex = 6 Then
                        txthcmotion = txthcmotion + vbCrLf + LanguageScript.Language1.motionString(21)
                    Else
                        txthcmotion = txthcmotion + vbCrLf + LanguageScript.Language1.motionString(22) + session.ToString + LanguageScript.Language1.motionString(23)
                        isStarted = 0
                        Form2.UserControl11.subchangetitle(LoadedConference.ConferenceTitle + Language1.infoString(5) + LoadedConference.Committee, LoadedConference.Topic(LoadedConference.topicSel))
                        Dock_MainScreen.lblmain.Text = txthcmotion
                        NewSession.txtsession.Text = ""
                        For ja = 1 To Dock_NationList.clb_nation_main.Items.Count
                            Dock_NationList.clb_nation_main.SetItemChecked(ja - 1, False)
                            nNationList(ja - 1).Attendence = False
                        Next
                        xmlsaveload.saveAttendance()
                        Dock_NationList.rollClose()
                        Call maketitil()
                        Call dianmingopenclose(True)
                        Call xmlsaveload.SaveClock(True)
                        Call Form2.ChangeStatus(False, MyInfo.AppStatus.Idle)
                        Exit Select
                    End If
                    Dock_MainScreen.lblmain.Text = txthcmotion
            End Select
        End If
    End Sub

    Sub mcReady()
        'mcmode = mode
        'mca = True
        timeStart = DateTime.Now
        'tlp_screenlist.Visible = 1
        'tlp_screenlist.Top = panel_main_screen.Height - tlp_screenlist.Height
        Form2.MyStatus = MyInfo.AppStatus.Motion
        Call Form2.ChangeStatus(Dock_NationList.rolled(), MyInfo.AppStatus.Motion)
        'Call line1add()
        '=============
        Call Dock_Moderated.mcReady()
    End Sub

    Sub 添加新文件NToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 添加新文件NToolStripMenuItem.Click
        NewFile.ShowDialog()
        If NewFile.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim taima As Integer = NewFile.num_file.Value
            Dim filename As String = NewFile.filename
            Dim sponsors As String = NewFile.txt_file_sponsors.Text
            Dim signatories As String = NewFile.txt_file_signatories.Text
            If LoadedConference.language = 1 Then
                txthcmotion = "阅读" + filename
                If sponsors <> "" Then txthcmotion = txthcmotion + vbCrLf + "起草国: " + sponsors
                If signatories <> "" Then txthcmotion = txthcmotion + vbCrLf + "附议国: " + signatories
                txthcmotion = txthcmotion + vbCrLf + "阅读时间:" + Str(NewFile.num_file.Value) + "分钟"
            Else
                txthcmotion = "read " + filename
                If sponsors <> "" Then txthcmotion = txthcmotion + vbCrLf + "Sponsors: " + sponsors
                If signatories <> "" Then txthcmotion = txthcmotion + vbCrLf + "Signatories: " + signatories
                txthcmotion = txthcmotion + vbCrLf + "Reading time:" + Str(NewFile.num_file.Value) + " minutes"
            End If
            Form2.UserControl11.SetPrompt(txthcmotion)
            Call Form2.ChangeStatus(Dock_NationList.rolled, MyInfo.AppStatus.FileView)
            Dock_Timer.timingStatus = "FI"
            Call Dock_Timer.file_start(taima)
            Dock_FileManage.ListBox1.Items.Add(filename)
            Form2.UserControl11.SetFile(lastPath + "media\" + filename + ".html")
        End If
    End Sub

    Private Sub 危机编写器CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 危机编写器CToolStripMenuItem.Click
        Dock_CrisisWriter.Show(dckPanel, DockState.Document)
        Dock_CrisisWriter.BringToFront()
    End Sub

    Sub Crisisstart()
        Dim atime As Integer = NewCrisis.time
        Dim afile As String = NewCrisis.filename123
        If LoadedConference.language = 1 Then
            txthcmotion = "阅读危机 (" + atime.ToString + "分钟)"
        Else
            txthcmotion = "Crisis (Reading time: " + atime.ToString + " minutes)"
        End If
        Form2.UserControl11.SetPrompt(txthcmotion)
        Call Form2.ChangeStatus(Dock_NationList.rolled, MyInfo.AppStatus.FileView)
        Dock_FileManage.ListBox1.Items.Add(afile)
        Dock_Timer.timingStatus = "CR"
        Dock_Timer.file_start(atime)
        Form2.UserControl11.SetFile(lastPath + "media\" + afile)
    End Sub

    Private Sub 发送危机CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 发送危机CToolStripMenuItem.Click
        NewCrisis.ShowDialog()
        If NewCrisis.DialogResult = Windows.Forms.DialogResult.OK Then Call Crisisstart()
    End Sub

    Private Sub 屏幕窗口SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 屏幕窗口SToolStripMenuItem.Click
        Form2.Show()
        'Form2.UserControl11 = UserControl
    End Sub

    Private Sub 投影模式PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 投影模式PToolStripMenuItem.Click
        If Not isOnScreen Then
            Shell("C:\Windows\system32\displayswitch.exe /extend")
            Try
                Shell("C:\Windows\system32\PresentationSettings.exe /start")
            Catch ex As Exception

            End Try
            MsgBox("请等待显示模式切换完成后点击" + Chr(34) + "确定" + Chr(34) + "。" + vbCrLf + "如未自动切换，请按【WinKey+P】快捷键（或笔记本电脑提供的显示模式切换键），在弹出菜单中选择" + Chr(34) + "扩展" + Chr(34) + "，等待切换完成后点击" + Chr(34) + "确定" + Chr(34) + "。", 64, "开启投影模式")
            Dim mywidth As Integer = My.Computer.Screen.Bounds.Width
            Form2.Left = mywidth + 100
            Form2.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Form2.WindowState = FormWindowState.Maximized
            投影模式PToolStripMenuItem.Checked = True
            isOnScreen = True
        Else
            Try
                Shell("C:\Windows\system32\PresentationSettings.exe /stop")
            Catch ex As Exception

            End Try
            Form2.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Form2.WindowState = FormWindowState.Normal
            投影模式PToolStripMenuItem.Checked = False
            isOnScreen = False
        End If
    End Sub

    Private Sub 有主持核心磋商MToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 有主持核心磋商MToolStripMenuItem.Click
        Dock_Moderated.Show(dckPanel, DockState.DockBottom)
    End Sub

    Private Sub 文件管理器FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 文件管理器FToolStripMenuItem.Click
        Dim dock1_Filemanage As DockContent = Dock_FileManage
        Dock_FileManage.Show(dckPanel, DockState.DockRight)
    End Sub

    Private Sub 国家列表NToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 国家列表NToolStripMenuItem.Click
        Dim dock1_Nationlist As DockContent = Dock_NationList
        Dock_NationList.Show(dckPanel, DockState.DockLeft)
    End Sub

    Private Sub 主屏幕MToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 主屏幕MToolStripMenuItem.Click
        Dim dock1_Mainscreen As DockContent = Dock_MainScreen
        Dock_MainScreen.Show(dckPanel, DockState.Document)
    End Sub

    Private Sub 等待控制WToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 等待控制WToolStripMenuItem.Click
        Dim dock1_WaitControl As DockContent = Dock_WaitControl
        Dock_WaitControl.Show(dckPanel, DockState.DockRight)
    End Sub

    Private Sub 计时器TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 计时器TToolStripMenuItem.Click
        Dock_Timer.Show(dckPanel, DockState.DockRight)
    End Sub

    Sub OpenFileView(form As Dock_FileView)
        form.Show(dckPanel, DockState.Document)
    End Sub

    Sub OpenMeeting()
        If Not OpenFileDialog1.ShowDialog() = DialogResult.Cancel Then
            Dim foldername As String = OpenFileDialog1.FileName.Remove(OpenFileDialog1.FileName.Length - 10, 10)
            Try
                Call loadevent(foldername)
            Catch ex As Exception
                MsgBox("无法打开指定的会议。", 0, "打开会议")
            End Try
        End If
    End Sub

    Private Sub 打开会议OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开会议OToolStripMenuItem.Click
        Call OpenMeeting()
    End Sub
End Class
