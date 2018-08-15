Imports System.Xml
Imports StandardConfData.MyInfo

Public Class xmlsaveload
    Public Shared Sub CreateMeting(path As String, NewConference As Conference)
        My.Computer.FileSystem.CreateDirectory(path + "custom_lists")
        My.Computer.FileSystem.CreateDirectory(path + "media")
        My.Computer.FileSystem.CreateDirectory(path + "presentation_papers")
        Dim myTW As New XmlTextWriter(path + "config.xml", Nothing)
        myTW.WriteStartDocument()
        myTW.Formatting = Formatting.Indented
        myTW.WriteStartElement("Conference")
        myTW.WriteAttributeString("myversion", 0)
        myTW.WriteAttributeString("myscene", NewMeeting.ComboBox1.SelectedItem.ToString)
        myTW.WriteStartElement("Basic")
        myTW.WriteAttributeString("myrule", Convert.ChangeType(NewConference.myrule, [Enum].GetUnderlyingType(GetType(UsingRule))).ToString)
        myTW.WriteAttributeString("languange", Convert.ChangeType(NewConference.language, [Enum].GetUnderlyingType(GetType(WerkLanguage))).ToString)
        myTW.WriteElementString("conference", NewConference.ConferenceTitle)
        myTW.WriteElementString("committee", NewConference.Committee)
        myTW.WriteStartElement("topic")
        myTW.WriteAttributeString("topicSelection", Convert.ChangeType(NewConference.topicSel, [Enum].GetUnderlyingType(GetType(TopicSelection))).ToString)
        myTW.WriteElementString("topic-0", NewConference.Topic(0))
        myTW.WriteElementString("topic-1", NewConference.Topic(1))
        myTW.WriteEndElement()
        myTW.WriteEndElement()
        myTW.WriteStartElement("Config")
        myTW.WriteAttributeString("session", 0)
        myTW.WriteElementString("isStarted", False)
        myTW.WriteElementString("presentWhenRoll", 0)
        myTW.WriteEndElement()
        myTW.WriteStartElement("ClockSettings")
        myTW.WriteAttributeString("isCabinet", False)
        myTW.WriteAttributeString("isRunningOnClose", False)
        myTW.WriteElementString("cabinTime", DateTime.Now.ToString("G", Globalization.CultureInfo.CreateSpecificCulture("en-us")) + "#")
        myTW.WriteElementString("CloseTime", DateTime.Now.ToString("G", Globalization.CultureInfo.CreateSpecificCulture("en-us")) + "#")
        myTW.WriteElementString("rawrate", 0)
        myTW.WriteElementString("Jetlag", 8)
        myTW.WriteEndElement()
        'myTW.WriteStartElement("Nations")
        'Dim n As Integer
        'Do While n < NewMeeting.ListBox1.Items.Count
        '    myTW.WriteStartElement("nation")
        '    myTW.WriteAttributeString("name", NewMeeting.ListBox1.Items(n).ToString)
        '    myTW.WriteAttributeString("isPresent", False)
        '    myTW.WriteEndElement()
        '    n = n + 1
        'Loop
        'myTW.WriteEndElement()
        myTW.WriteStartElement("speakerslist")
        myTW.WriteAttributeString("slTotal", 0)
        myTW.WriteAttributeString("slCurrent", 0)
        myTW.WriteAttributeString("slTime", 120)
        myTW.WriteEndElement()
        myTW.WriteStartElement("files")
        myTW.WriteEndElement()
        myTW.WriteEndElement()
        myTW.WriteEndDocument()
        myTW.Close()

        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.lastPath + "config.xml")
        Dim xnNationlist As XmlNode = xmlDoc.SelectSingleNode("Conference")
        xnNationlist.InsertAfter(XmlAccess.SetToXml.SetNations(Form1.nNationList, xmlDoc), xnNationlist.ChildNodes(2))
        xmlDoc.Save(Form1.lastPath + "config.xml")

        StandardConfData.Record.RecordWriter.Create(Form1.lastPath, "ConferenceRecord")
    End Sub

    Public Shared Sub loadbasic()
        Dim myVersie As Integer
        Dim xmlDoc As New XmlDocument()
        Try
            xmlDoc.Load(Form1.lastPath + "config.xml")
        Catch ex As Exception
            MessageBox.Show("无法打开该会议数据文件！", "Easychair", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        Dim xnIntro As XmlNode = xmlDoc.SelectSingleNode("Conference")
        Dim xeIntro As XmlElement = CType(xnIntro, XmlElement)
        myVersie = Val(xeIntro.GetAttribute("myversion"))
        Form1.myScene = xeIntro.GetAttribute("myscene")
        Dim xnBasic As XmlNode = xmlDoc.SelectSingleNode("Conference/Basic")
        Form1.LoadedConference = XmlAccess.GetFromXml.GetConferenceInfo(xnBasic)

        Dim xnCongif As XmlNode = xmlDoc.SelectSingleNode("Conference/Config")
        Dim xeCongif As XmlElement = CType(xnCongif, XmlElement) '将子节点类型转换为XmlElement类型 
        Form1.session = xeCongif.GetAttribute("session")
        Dim xeIsStarted As XmlElement = CType(xnCongif.FirstChild, XmlElement)
        Form1.isStarted = xeIsStarted.InnerText
        Dim xnPWR As XmlNode = xmlDoc.SelectSingleNode("Conference/Config/presentWhenRoll")
        Form1.presentWhenRoll = xnPWR.InnerText
        If Form1.isStarted And Form1.presentWhenRoll > 0 Then
            Dock_NationList.dianmingstatus = "点名已完成"
            'Dock_NationList.Button1.Enabled = False
            'Dock_NationList.Button2.Enabled = False
        End If

        Dim xnClock As XmlNode = xmlDoc.SelectSingleNode("Conference/ClockSettings")
        Form1.nCabinetSetting = XmlAccess.GetFromXml.GetCabinetSetting(xnClock)

        Dim xmlDoc1 As New XmlDocument()
        xmlDoc1.Load(Form1.lastPath + "record.xml")
        Dim xnRecord As XmlNode = xmlDoc1.SelectSingleNode("ConferenceRecord")
        Dim xeRecord As XmlElement = CType(xnRecord, XmlElement)
        Form1.recIndex = xeRecord.GetAttribute("recordIndex")
    End Sub

    Public Shared Sub loadAttendance()
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.lastPath + "config.xml")
        Dim xnBase As XmlNode = xmlDoc.SelectSingleNode("Conference")
        Dim xeBase As XmlElement = CType(xnBase, XmlElement)
        Dim xnNation As XmlNode = xmlDoc.SelectSingleNode("Conference/Nations")
        Form1.nNationList = XmlAccess.GetFromXml.GetNationList(xnNation)
        'Dim xnfile As XmlNode = xmlDoc.SelectSingleNode("Conference/files")
        'Dim xefile As XmlElement = CType(xnfile, XmlElement) '将子节点类型转换为XmlElement类型 
        'Form1.nFileList = XmlAccess.GetFromXml.GetFileList(xnfile, Form1.nNationList)
        'Dim xnNations As XmlNodeList = xnNation.ChildNodes
        'Dim p1, i As Integer
        'For Each XmlNode In xnNations
        '    Dim xnSingleNations As XmlElement = XmlNode
        '    Dock_NationList.clb_nation_main.Items.Add(xnSingleNations.GetAttribute("name"))
        '    If xnSingleNations.GetAttribute("isPresent") = "True" Then
        '        Dock_NationList.clb_nation_main.SetItemCheckState(i, CheckState.Checked)
        '        p1 = p1 + 1
        '    Else
        '        Dock_NationList.clb_nation_main.SetItemCheckState(i, CheckState.Unchecked)
        '    End If
        '    i = i + 1
        'Next
        'Call Dock_NationList.pcalc(Form1.GetAttendentNumber)
    End Sub

    Public Shared Sub loadSL()
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.lastPath + "config.xml")
        Dim xnBase As XmlNode = xmlDoc.SelectSingleNode("Conference")
        Dim xeBase As XmlElement = CType(xnBase, XmlElement)
        Dim xnNation As XmlNode = xmlDoc.SelectSingleNode("Conference/speakerslist")
        Dim xeSL As XmlElement = CType(xnNation, XmlElement)
        SpeakersList.slTotal = xeSL.GetAttribute("slTotal")
        SpeakersList.slCurrent = xeSL.GetAttribute("slCurrent")
        SpeakersList.slTime = New Integer() {(xeSL.GetAttribute("slTime")) Mod 60, (xeSL.GetAttribute("slTime")) \ 60}
        Dim xnSLnations As XmlNodeList = xnNation.ChildNodes
        Dim i As Integer = 1
        For Each XmlNode In xnSLnations
            Dim xeEachNation As XmlElement = CType(XmlNode, XmlElement)
            Dim singleItme(3) As String
            SpeakersList.slNations(i) = xeEachNation.GetAttribute("name")
            SpeakersList.slIsSpoken(i) = xeEachNation.GetAttribute("Referencenr")
            singleItme(1) = SpeakersList.slNations(i)
            If Dock_SpeakersList.ListView1.Items.Count = SpeakersList.slCurrent Then singleItme(0) = ">"
            Dock_SpeakersList.ListView1.Items.Add(New ListViewItem(singleItme))
            i = i + 1
        Next
        Dock_SpeakersList.txt_spl_totalnumber.Text = SpeakersList.slTotal + 1
        If SpeakersList.slTotal > 0 Then
            Dock_SpeakersList.txt_spl_currentnunber.Text = SpeakersList.slCurrent + 1
            Dock_SpeakersList.txt_spl_current.Text = SpeakersList.slNations(SpeakersList.slCurrent + 1)
        End If
    End Sub

    Public Shared Sub loadFile()
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.lastPath + "config.xml")
        Dim xnfile As XmlNode = xmlDoc.SelectSingleNode("Conference/files")
        Dim xefile As XmlElement = CType(xnfile, XmlElement) '将子节点类型转换为XmlElement类型 
        Form1.nFileList = XmlAccess.GetFromXml.GetFileList(xnfile, Form1.nNationList)
    End Sub

    Public Shared Sub saveAttendance(Optional rollcall As Boolean = False)
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.lastPath + "config.xml")
        Dim xnNation As XmlNode = xmlDoc.SelectSingleNode("Conference/Nations")
        XmlAccess.ModifyXML.ModifyAttendence(Form1.nNationList, xnNation)
        'xnNation.RemoveAll()
        'Dim xeNation As XmlElement = xmlDoc.CreateElement("Nations")
        'Dim n As Integer
        'Do While n < Dock_NationList.clb_nation_main.Items.Count
        '    Dim xeSingleNation As XmlElement = xmlDoc.CreateElement("nation")
        '    xeSingleNation.SetAttribute("name", Dock_NationList.clb_nation_main.Items(n).ToString)
        '    xeSingleNation.SetAttribute("isPresent", Dock_NationList.clb_nation_main.GetItemChecked(n))
        '    xnNation.AppendChild(xeSingleNation)
        '    n = n + 1
        'Loop
        'xeBase.InsertAfter(xeNation, xmlDoc.SelectSingleNode("Conference/ClockSettings"))
        If rollcall Then
            Dim xnPWR As XmlNode = xmlDoc.SelectSingleNode("Conference/Config/presentWhenRoll")
            xnPWR.InnerText = Form1.presentWhenRoll
        End If
        xmlDoc.Save(Form1.lastPath + "config.xml")
    End Sub

    Public Shared Sub ModifyStarted()
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.lastPath + "config.xml")
        Dim xnCongif As XmlNode = xmlDoc.SelectSingleNode("Conference/Config")
        Dim xeCongif As XmlElement = CType(xnCongif, XmlElement) '将子节点类型转换为XmlElement类型 
        xeCongif.SetAttribute("session", Form1.session)
        Dim xnIsStarted As XmlNode = xmlDoc.SelectSingleNode("Conference/Config/isStarted")
        xnIsStarted.InnerText = Form1.isStarted
        xmlDoc.Save(Form1.lastPath + "config.xml")
    End Sub


    Public Shared Sub ModifyNation(index As Integer, nation As Nation)
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.lastPath + "config.xml")
        Dim xnBase As XmlNode = xmlDoc.SelectSingleNode("Conference")
        Dim xeBase As XmlElement = CType(xnBase, XmlElement)
        Dim xnNation As XmlNode = xmlDoc.SelectSingleNode("Conference/Nations")
        xnNation.ReplaceChild(XmlAccess.SetToXml.SetNation(nation, xmlDoc), xnNation.ChildNodes(index))

        'xnNation.RemoveAll()
        'Dim xeNation As XmlElement = xmlDoc.CreateElement("Nations")
        'Dim n As Integer
        'Do While n < Dock_NationList.clb_nation_main.Items.Count
        '    Dim xeSingleNation As XmlElement = xmlDoc.CreateElement("nation")
        '    xeSingleNation.SetAttribute("name", Dock_NationList.clb_nation_main.Items(n).ToString)
        '    xeSingleNation.SetAttribute("isPresent", Dock_NationList.clb_nation_main.GetItemChecked(n))
        '    xnNation.AppendChild(xeSingleNation)
        '    n = n + 1
        'Loop
        'xeBase.InsertAfter(xeNation, xmlDoc.SelectSingleNode("Conference/ClockSettings"))
        xmlDoc.Save(Form1.lastPath + "config.xml")
    End Sub

    Public Shared Sub slAddNationToConfig(nation As String, total As Integer)
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.lastPath + "config.xml")
        Dim xnBase As XmlNode = xmlDoc.SelectSingleNode("Conference")
        Dim xeBase As XmlElement = CType(xnBase, XmlElement)
        Dim xnNation As XmlNode = xmlDoc.SelectSingleNode("Conference/speakerslist")
        Dim xeSL As XmlElement = CType(xnNation, XmlElement)
        xeSL.SetAttribute("slTotal", total)
        Dim xeSingleNation As XmlElement = xmlDoc.CreateElement("nation")
        xeSingleNation.SetAttribute("name", nation)
        xeSingleNation.SetAttribute("Referencenr", 0)
        xnNation.AppendChild(xeSingleNation)
        xmlDoc.Save(Form1.lastPath + "config.xml")
    End Sub

    Public Shared Sub slNext(current As Integer)
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.lastPath + "config.xml")
        Dim xnBase As XmlNode = xmlDoc.SelectSingleNode("Conference")
        Dim xeBase As XmlElement = CType(xnBase, XmlElement)
        Dim xnNation As XmlNode = xmlDoc.SelectSingleNode("Conference/speakerslist")
        Dim xeSL As XmlElement = CType(xnNation, XmlElement)
        xeSL.SetAttribute("slCurrent", current)
        Dim xnSingleNation As XmlNode = xnNation.ChildNodes(current - 1)
        Dim xeSN As XmlElement = CType(xnSingleNation, XmlElement)
        xeSN.SetAttribute("Referencenr", Form1.recIndex)
        xmlDoc.Save(Form1.lastPath + "config.xml")
    End Sub

    Public Shared Sub ClosingClock()
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.lastPath + "config.xml")
        Dim xnCongif As XmlNode = xmlDoc.SelectSingleNode("Conference/Config")
        Dim xeCongif As XmlElement = CType(xnCongif, XmlElement) '将子节点类型转换为XmlElement类型 
        xeCongif.SetAttribute("session", Form1.session)
        Dim xeIsStarted As XmlElement = CType(xnCongif.FirstChild, XmlElement)
        xeIsStarted.InnerText = Form1.isStarted
        Dim xePresentWhenRoll As XmlElement = CType(xnCongif.FirstChild.NextSibling, XmlElement)
        xePresentWhenRoll.InnerText = Form1.presentWhenRoll
        xmlDoc.Save(Form1.lastPath + "config.xml") '保存。
        If Form1.isStarted Then
            Dim running As Boolean = True
            Dim xnClock As XmlNode = xmlDoc.SelectSingleNode("Conference/ClockSettings")
            Dim isRunningOnClose As DialogResult = MessageBox.Show("是否冻结时间轴？", "时间轴设定", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If isRunningOnClose = DialogResult.Yes Then running = False
            XmlAccess.ModifyXML.ModifyClockSetting(Form1.nCabinetSetting, xnClock, running)
        End If
    End Sub

    Public Shared Sub SaveClock(dialog As Boolean)
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.lastPath + "config.xml")
        Dim running As Boolean = True
        Dim xnClock As XmlNode = xmlDoc.SelectSingleNode("Conference/ClockSettings")
        Dim isRunningOnClose As DialogResult = DialogResult.No
        If dialog Then
            isRunningOnClose = MessageBox.Show("是否冻结时间轴？", "时间轴设定", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If
        If isRunningOnClose = DialogResult.Yes Then running = False
        XmlAccess.ModifyXML.ModifyClockSetting(Form1.nCabinetSetting, xnClock, running)
        xmlDoc.Save(Form1.lastPath + "config.xml") '保存。
    End Sub

    Public Shared Sub AddFile(filename As String, pathname As String, type As Files)
        Dim type1 = Convert.ChangeType(type, [Enum].GetUnderlyingType(GetType(Files)))
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.lastPath + "config.xml")
        Dim xnBase As XmlNode = xmlDoc.SelectSingleNode("Conference")
        Dim xeBase As XmlElement = CType(xnBase, XmlElement)
        Dim xnFile As XmlNode = xmlDoc.SelectSingleNode("Conference/files")
        Dim xeSL As XmlElement = CType(xnFile, XmlElement)
        Dim xnSingleFile As XmlElement = xmlDoc.CreateElement("file")
        xnSingleFile.SetAttribute("name", filename)
        xnSingleFile.SetAttribute("type", type1)
        xnSingleFile.InnerText = pathname
        xnFile.AppendChild(xnSingleFile)
        xmlDoc.Save(Form1.lastPath + "config.xml")
    End Sub

    Public Shared Sub AddFile2(file As File)
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.lastPath + "config.xml")
        Dim xnFile As XmlNode = xmlDoc.SelectSingleNode("Conference/files")
        Dim xeFile As XmlElement = CType(xnFile, XmlElement)
        xnFile.AppendChild(XmlAccess.SetToXml.SetFile(file, xmlDoc))
        xmlDoc.Save(Form1.lastPath + "config.xml")
    End Sub

    Public Shared Sub CreateRecord(index As Integer, catogory As String, Optional approved As Boolean = False)
        index = index + 1
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(Form1.lastPath + "record.xml")
        Dim xnRecord As XmlNode = xmlDoc.SelectSingleNode("ConferenceRecord")
        Dim xeRecord As XmlElement = CType(xnRecord, XmlElement)
        xeRecord.SetAttribute("recordIndex", index)
        Dim xeSingleRecord As XmlElement = xmlDoc.CreateElement("record")
        xeSingleRecord.SetAttribute("index", index)
        xeSingleRecord.SetAttribute("category", catogory)
        Dim xnStartTime As XmlNode = xmlDoc.CreateElement("StartDate")
        xnStartTime.InnerText = "#" + DateTime.Now.ToString("G", Globalization.CultureInfo.CreateSpecificCulture("en-us")) + "#"
        xeSingleRecord.AppendChild(xnStartTime)
        Select Case catogory
            Case "ST"
                Dim xnSession As XmlNode = xmlDoc.CreateElement("session")
                xnSession.InnerText = Form1.session
                xeSingleRecord.AppendChild(xnSession)
            Case "RC"
                Dim xnPresents As XmlNode = xmlDoc.CreateElement("presents")
                xnPresents.InnerText = Dock_NationList.pCount()
                xeSingleRecord.AppendChild(xnPresents)
            Case "SL"
                Dim xnSL As XmlNode = xmlDoc.CreateElement("nation")
                xnSL.InnerText = SpeakersList.slNations(SpeakersList.slCurrent + 1)
                xeSingleRecord.AppendChild(xnSL)
            Case "MC"
                Dim xeMCtitle As XmlElement = xmlDoc.CreateElement("mclist")
                xeMCtitle.SetAttribute("nation", Motion.TextBox1.Text)
                xeMCtitle.SetAttribute("topic", Motion.TextBox2.Text)
                xeMCtitle.SetAttribute("k", Motion.num_m_umc.Value)
                xeMCtitle.SetAttribute("i", Motion.num_m_mc_2.Value)
                xeMCtitle.SetAttribute("approved", approved)
                xeSingleRecord.AppendChild(xeMCtitle)
            Case "UMC", "mTB"
                Dim xeUMC As XmlElement = xmlDoc.CreateElement("timer")
                xeUMC.SetAttribute("nation", Motion.TextBox1.Text)
                xeUMC.SetAttribute("k", Motion.num_m_umc.Value)
                xeUMC.SetAttribute("approved", approved)
                xeSingleRecord.AppendChild(xeUMC)
            Case "AT"
                Dim xeChangetime As XmlElement = xmlDoc.CreateElement("mclist")
                xeChangetime.SetAttribute("nation", Motion.TextBox1.Text)
                xeChangetime.SetAttribute("mm", Motion.num_m_spl_1.Value)
                xeChangetime.SetAttribute("ss", Motion.num_m_spl_2.Value)
                xeChangetime.SetAttribute("approved", approved)
                xeSingleRecord.AppendChild(xeChangetime)
            Case "AO", "VT", "mVT"
                Dim xeFileAcc As XmlElement = xmlDoc.CreateElement("voting")
                If catogory = "VT" Then
                    xeFileAcc.SetAttribute("file", Vote.FileName)
                Else
                    xeFileAcc.SetAttribute("nation", Motion.TextBox1.Text)
                    If Not Motion.cbx_mfileselect.SelectedItem Is Nothing Then
                        xeFileAcc.SetAttribute("file", Motion.cbx_mfileselect.SelectedItem.ToString)
                    End If
                    xeFileAcc.SetAttribute("approved", approved)
                End If
                xeSingleRecord.AppendChild(xeFileAcc)
            Case "ED", "XH"
                Dim xeEndebate As XmlElement = xmlDoc.CreateElement("ending")
                xeEndebate.SetAttribute("nation", Motion.TextBox1.Text)
                If catogory = "XH" Then xeEndebate.SetAttribute("session", Form1.session)
                xeEndebate.SetAttribute("approved", approved)
                xeSingleRecord.AppendChild(xeEndebate)
            Case "FI"
                Dim xeFileIntro As XmlElement = xmlDoc.CreateElement("fileintro")
                xeFileIntro.SetAttribute("file", NewFile.filename)
                xeFileIntro.SetAttribute("timer", NewFile.num_file.Value)
                xeFileIntro.SetAttribute("path", NewFile.filename + ".html")
                xeSingleRecord.AppendChild(xeFileIntro)
                Dim xnSponsors As XmlNode = xmlDoc.CreateElement("sponsors")
                xnSponsors.InnerText = NewFile.txt_file_sponsors.Text
                xeFileIntro.AppendChild(xnSponsors)
                Dim xnSignatories As XmlNode = xmlDoc.CreateElement("signatories")
                xnSignatories.InnerText = NewFile.txt_file_signatories.Text
                xeFileIntro.AppendChild(xnSignatories)
            Case "CR"
                Dim xeFileIntro As XmlElement = xmlDoc.CreateElement("crisis")
                xeFileIntro.SetAttribute("file", NewCrisis.filename123)
                xeFileIntro.SetAttribute("timer", NewCrisis.time)
                xeFileIntro.SetAttribute("path", NewCrisis.filename123 + ".html")
                xeSingleRecord.AppendChild(xeFileIntro)
        End Select
        xnRecord.AppendChild(xeSingleRecord)
        xmlDoc.Save(Form1.lastPath + "record.xml")
        Form1.recIndex = index
    End Sub
End Class
