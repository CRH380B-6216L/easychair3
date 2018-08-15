Imports System.Xml
Imports StandardConfData

Public Class Class1

End Class

Public Class GetFromXml
    Public Shared Function GetConferenceInfo(node As XmlNode) As MyInfo.Conference
        Dim ReturnInfo As New MyInfo.Conference
        Dim xeBasic As XmlElement = CType(node, XmlElement)
        ReturnInfo.myrule = Val(xeBasic.GetAttribute("myrule"))
        ReturnInfo.language = Val(xeBasic.GetAttribute("languange"))
        Dim xninfo As XmlNode = xeBasic.FirstChild
        ReturnInfo.ConferenceTitle = xninfo.InnerText
        Dim xnCommittee As XmlNode = xninfo.NextSibling
        ReturnInfo.Committee = xnCommittee.InnerText
        Dim xnTopics As XmlNode = xnCommittee.NextSibling
        Dim xeTopics As XmlElement = CType(xnTopics, XmlElement)
        ReturnInfo.topicSel = xeTopics.GetAttribute("topicSelection")
        If Not ReturnInfo.topicSel = 2 Then
            Dim xnTopic As XmlNode = xnTopics.ChildNodes(ReturnInfo.topicSel)
            ReturnInfo.Topic(ReturnInfo.topicSel) = xnTopic.InnerText
        End If
        Return ReturnInfo
    End Function

    Public Shared Function GetCabinetSetting(node As XmlNode) As MyInfo.CabinetSetting
        Dim ReturnSetting As New MyInfo.CabinetSetting
        Dim xeClock As XmlElement = CType(node, XmlElement) '将子节点类型转换为XmlElement类型 
        ReturnSetting.isCabinet = xeClock.GetAttribute("isCabinet")
        Dim isRunningOnClose As Boolean
        isRunningOnClose = xeClock.GetAttribute("isRunningOnClose")
        If ReturnSetting.isCabinet Then
            Dim nl As XmlNode = xeClock.ChildNodes(0) '继续
            Dim xe1 As XmlElement = CType(nl, XmlElement) '
            ReturnSetting.cabintime = DateTime.Parse(xe1.InnerText, Globalization.CultureInfo.CreateSpecificCulture("en-us"))

            Dim nls As XmlNode = nl.NextSibling  '继续获取x
            Dim xe2 As XmlElement = CType(nls, XmlElement)
            Dim LastClose As DateTime = DateTime.Parse(xe2.InnerText, Globalization.CultureInfo.CreateSpecificCulture("en-us"))

            Dim nlss As XmlNode = nls.NextSibling  '继续获取
            Dim xe3 As XmlElement = CType(nlss, XmlElement)
            ReturnSetting.RawRate = xe3.InnerText

            If isRunningOnClose Then
                ReturnSetting.AddSpan(DateTime.Now.Subtract(LastClose))
            End If
        End If
        Return ReturnSetting
    End Function

    Public Shared Function GetConferenceString(path As String) As String
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load(path + "config.xml")
        Dim xnBasic As XmlNode = xmlDoc.SelectSingleNode("Conference").ChildNodes(0)
        Dim ReturnString As String = ""
        Dim xeBasic As XmlElement = CType(xnBasic, XmlElement)
        Dim xninfo As XmlNode = xeBasic.FirstChild
        ReturnString += xninfo.InnerText + vbCrLf
        Dim xnCommittee As XmlNode = xninfo.NextSibling
        ReturnString += xnCommittee.InnerText + vbCrLf
        Dim xnTopics As XmlNode = xnCommittee.NextSibling
        Dim xeTopics As XmlElement = CType(xnTopics, XmlElement)
        Dim topicSel = xeTopics.GetAttribute("topicSelection")
        If Not topicSel = 2 Then
            Dim xnTopic As XmlNode = xnTopics.ChildNodes(topicSel)
            ReturnString += xnTopic.InnerText
        End If
        Return ReturnString
    End Function

    ''' <summary>
    ''' 从会议数据文件读取国家列表。
    ''' </summary>
    ''' <param name="node">指定存储国家列表的XML节点。</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetNationList(node As XmlNode) As MyInfo.NationList
        Dim ReturnList As New MyInfo.NationList
        For Each xnSingle As XmlNode In node.ChildNodes
            Dim xeSingle As XmlElement = CType(xnSingle, XmlElement)
            Dim i As New MyInfo.Nation
            i.Name = xeSingle.GetAttribute("name")
            i.Attendence = xeSingle.GetAttribute("isPresent")
            i.Competence = xeSingle.GetAttribute("conpetence")
            Dim xnDels As XmlNode = xnSingle.ChildNodes(0)
            If xnDels.HasChildNodes Then
                For Each del As XmlNode In xnDels.ChildNodes
                    i.Delegates.Add(del.InnerText)
                Next
            End If
            Dim xnSchool As XmlNode = xnDels.NextSibling
            i.SchoolDelegates = xnSchool.InnerText
            Dim xnPresentatie As XmlNode = xnSchool.NextSibling
            i.PresentationPaper = xnPresentatie.InnerText
            ReturnList.Add(i)
        Next
        Return ReturnList
    End Function

    ''' <summary>
    ''' 从会议数据文件读取单个国家详细信息。
    ''' </summary>
    ''' <param name="index">国家列表从零开始的索引。</param>
    ''' <param name="node">指定存储国家列表的XML节点。</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetSingleNationDetail(index As Integer, node As XmlNode) As MyInfo.Nation
        Dim ReturnNation As New MyInfo.Nation
        Dim xnSingle As XmlNode = node.ChildNodes(index)
        Dim xeSingle As XmlElement = CType(xnSingle, XmlElement)
        Dim i As New MyInfo.Nation
        i.Name = xeSingle.GetAttribute("name")
        i.Attendence = xeSingle.GetAttribute("isPresent")
        i.Competence = xeSingle.GetAttribute("conpetence")
        i.VetoPower = xeSingle.GetAttribute("vetopower")
        Dim xnDels As XmlNode = xnSingle.ChildNodes(0)
        If xnDels.HasChildNodes Then
            For Each del As XmlNode In xnDels.ChildNodes
                i.Delegates.Add(del.InnerText)
            Next
        End If
        Dim xnSchool As XmlNode = xnDels.NextSibling
        i.SchoolDelegates = xnSchool.InnerText
        Dim xnPresentatie As XmlNode = xnSchool.NextSibling
        i.PresentationPaper = xnPresentatie.InnerText
        Return i
    End Function

    ''' <summary>
    ''' 从会议数据文件读取会场文件列表。
    ''' </summary>
    ''' <param name="node">指定存储会场文件列表的XML节点。</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetFileList(node As XmlNode, list As MyInfo.NationList) As MyInfo.FileList
        Dim ReturnList As New MyInfo.FileList
        For Each xnSingle As XmlNode In node.ChildNodes
            Dim xeSingle As XmlElement = CType(xnSingle, XmlElement)
            Dim i As New MyInfo.File
            i.FileTitle = xeSingle.GetAttribute("title")
            i.Category = xeSingle.GetAttribute("category")
            Dim xnPath As XmlNode = xnSingle.ChildNodes(0)
            i.FilePath = xnPath.InnerText
            Dim xnSponsors As XmlNode = xnPath.NextSibling
            If xnSponsors.HasChildNodes Then
                For Each sp As XmlNode In xnSponsors.ChildNodes
                    i.Sponsers.Add(list.GetNationFromName(sp.InnerText))
                Next
            End If
            Dim xnSignatories As XmlNode = xnSponsors.NextSibling
            If xnSignatories.HasChildNodes Then
                For Each sp As XmlNode In xnSignatories.ChildNodes
                    i.Signatories.Add(list.GetNationFromName(sp.InnerText))
                Next
            End If
            ReturnList.Add(i)
        Next
        Return ReturnList
    End Function
End Class

Public Class ModifyXML
    ''' <summary>
    ''' 更新全部国家的出席情况。
    ''' </summary>
    ''' <param name="nations">指定需要载入的国家列表。</param>
    ''' <param name="xnNationList">指定存储国家列表的XML节点。</param>
    ''' <remarks></remarks>
    Public Shared Sub ModifyAttendence(nations As MyInfo.NationList, xnNationList As XmlNode)
        For i = 1 To xnNationList.ChildNodes.Count
            Dim xeSingleNation = CType(xnNationList.ChildNodes(i - 1), XmlElement)
            xeSingleNation.SetAttribute("isPresent", nations(i - 1).Attendence)
        Next
    End Sub

    ''' <summary>
    ''' 更新单个国家的详细信息。
    ''' </summary>
    ''' <param name="index">国家列表从零开始的索引。</param>
    ''' <param name="nation">需要更新的单个国家。</param>
    ''' <param name="xnNationList">指定存储国家列表的XML节点。</param>
    ''' <remarks></remarks>
    Public Shared Sub ModifySingleNation(index As Integer, nation As MyInfo.Nation, xnNationList As XmlNode)
        Dim xnSingleNation As XmlNode = xnNationList.ChildNodes(index)
        Dim xeSingleNation = CType(xnSingleNation, XmlElement)
        xeSingleNation.SetAttribute("name", nation.Name)
        xeSingleNation.SetAttribute("isPresent", nation.Attendence)
        xeSingleNation.SetAttribute("conpetence", nation.Competence)
        xeSingleNation.SetAttribute("vetopower", nation.VetoPower)
    End Sub

    Public Shared Sub ModifyClockSetting(setting As MyInfo.CabinetSetting, xnClock As XmlNode, running As Boolean)
        Dim xeClock As XmlElement = CType(xnClock, XmlElement) '将子节点类型转换为XmlElement类型 
        xeClock.SetAttribute("isCabinet", setting.isCabinet)
        If setting.isCabinet Then
            xeClock.SetAttribute("isRunningOnClose", running)
            Dim nl As XmlNode = xeClock.ChildNodes(0) '继续获取xe子节点的所有子节点
            Dim xe1 As XmlElement = CType(nl, XmlElement) '转换类型 
            xe1.InnerText = setting.cabintime.ToString("G", Globalization.CultureInfo.CreateSpecificCulture("en-us"))

            Dim nls As XmlNode = nl.NextSibling  '继续获取xe子节点的所有子节点
            Dim xe2 As XmlElement = CType(nls, XmlElement) '转换类型 
            xe2.InnerText = DateTime.Now.ToString("G", Globalization.CultureInfo.CreateSpecificCulture("en-us"))

            Dim nlss As XmlNode = nls.NextSibling  '继续获取xe子节点的所有子节点
            Dim xe3 As XmlElement = CType(nlss, XmlElement) '转换类型 
            xe3.InnerText = setting.RawRate
        End If
    End Sub
End Class

Public Class SetToXml
    ''' <summary>
    ''' 将单个国家信息写入会议数据文件。
    ''' </summary>
    ''' <param name="nation">需要写入的单个国家。</param>
    ''' <param name="xmlDoc">指定写入的文档。</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function SetNation(nation As MyInfo.Nation, xmlDoc As XmlDocument) As XmlElement
        Dim ReturnNode As XmlElement = xmlDoc.CreateElement("nation")
        ReturnNode.SetAttribute("name", nation.Name)
        ReturnNode.SetAttribute("isPresent", nation.Attendence)
        ReturnNode.SetAttribute("conpetence", nation.Competence)
        ReturnNode.SetAttribute("vetopower", nation.VetoPower)
        Dim xndels As XmlNode = xmlDoc.CreateElement("delegates")
        If Not nation.Delegates.Equals(Nothing) Then
            For Each i In nation.Delegates
                Dim xnsingledel As XmlNode = xmlDoc.CreateElement("person")
                xnsingledel.InnerText = i
                xndels.AppendChild(xnsingledel)
            Next
        End If
        ReturnNode.AppendChild(xndels)
        Dim xnschool As XmlNode = xmlDoc.CreateElement("school")
        xnschool.InnerText = nation.SchoolDelegates
        ReturnNode.AppendChild(xnschool)
        Dim xnPresentatie As XmlNode = xmlDoc.CreateElement("presentationpaper")
        xnPresentatie.InnerText = nation.PresentationPaper
        ReturnNode.AppendChild(xnPresentatie)
        Return ReturnNode
    End Function

    ''' <summary>
    ''' 将整个国家列表写入会议数据文件。
    ''' </summary>
    ''' <param name="nations">需要导入的列表。</param>
    ''' <param name="xmlDoc">指定写入的文档。</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function SetNations(nations As MyInfo.NationList, xmlDoc As XmlDocument) As XmlElement
        Dim ReturnNode As XmlElement = xmlDoc.CreateElement("Nations")
        For Each i In nations
            ReturnNode.AppendChild(SetNation(i, xmlDoc))
        Next
        Return ReturnNode
    End Function

    ''' <summary>
    ''' 将单个会场文件信息写入会议数据文件。
    ''' </summary>
    ''' <param name="file">需要写入的会场文件。</param>
    ''' <param name="xmlDoc">指定写入的文档。</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function SetFile(file As MyInfo.File, xmlDoc As XmlDocument) As XmlElement
        Dim ReturnNode As XmlElement = xmlDoc.CreateElement("file")
        ReturnNode.SetAttribute("title", file.FileTitle)
        ReturnNode.SetAttribute("category", Convert.ChangeType(file.Category, [Enum].GetUnderlyingType(GetType(MyInfo.FileCategory))).ToString)
        Dim xnschool As XmlNode = xmlDoc.CreateElement("path")
        xnschool.InnerText = file.FilePath
        ReturnNode.AppendChild(xnschool)
        Dim xnsp As XmlNode = xmlDoc.CreateElement("sponsors")
        If Not file.Sponsers.Count = 0 Then
            For Each i In file.Sponsers
                Dim xnsingledel As XmlNode = xmlDoc.CreateElement("nation")
                xnsingledel.InnerText = i.ToString
                xnsp.AppendChild(xnsingledel)
            Next
        End If
        ReturnNode.AppendChild(xnsp)
        Dim xnsg As XmlNode = xmlDoc.CreateElement("signatories")
        If Not file.Signatories.Count = 0 Then
            For Each i In file.Signatories
                Dim xnsingledel As XmlNode = xmlDoc.CreateElement("nation")
                xnsingledel.InnerText = i.ToString
                xnsg.AppendChild(xnsingledel)
            Next
        End If
        ReturnNode.AppendChild(xnsg)
        Return ReturnNode
    End Function
End Class
