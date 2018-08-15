Imports System.Xml
Namespace Record

    ''' <summary>
    ''' 表示可以从一个 XML 文档读取会议记录的读取器。 
    ''' </summary>
    Public Class RecordReader
        Dim xmlDoc As New XmlDocument
        Dim xnRecord As XmlNode
        Dim xeRecord As XmlElement
        Dim nlist As MyInfo.NationList
        Dim flist As MyInfo.FileList
        Public xmlpath As String
        Public NodeName As String
        Private YieldString() As String = New String() {"normal", "yieldn", "yieldq", "yielda", "yieldc"}

        ''' <summary>
        ''' 为指定的 XML 文档和节点名初始化 RecordReader 类的一个新实例。
        ''' </summary>
        ''' <param name="LoadXmlPath">文件的 URL，该文件包含要加载的 XML 文档。URL 既可以是本地文件，也可以是 HTTP URL（Web 地址）。</param>
        ''' <param name="_NodeName">存储会议记录的 XML 节点名或 XPath 表达式。</param>
        Public Sub New(LoadXmlPath As String, _NodeName As String)
            xmlpath = LoadXmlPath
            NodeName = _NodeName
            xmlDoc.Load(LoadXmlPath)
            xnRecord = xmlDoc.SelectSingleNode(_NodeName)
            xeRecord = CType(xnRecord, XmlElement)
        End Sub

        ''' <summary>
        ''' 获取当前文档的记录索引数。
        ''' </summary>
        ''' <returns></returns>
        Public Function GetRecordIndex() As Integer
            GetRecordIndex = xeRecord.GetAttribute("recordIndex")
        End Function

        Public Function GetRecordCollection() As RecordCollection
            GetRecordCollection = New RecordCollection
            For Each xnSingle As XmlNode In xnRecord.ChildNodes
                Dim i As New RecordContent
                Dim xnStartDate As XmlNode = xnSingle.SelectSingleNode("StartDate")
                i.StartDate = xnSingle.InnerText
                Dim xnProperties As XmlNode = xnSingle.SelectSingleNode("properties")
                Dim xeProperties As XmlElement = xnProperties
                i.session = xeProperties.GetAttribute("session")
                i.presents = xeProperties.GetAttribute("presents")
                i.nation = MyInfo.NationList.FindNation(xeProperties.GetAttribute("nation"), nlist)
                i.yield_type = xeProperties.GetAttribute("yield-method")
                i.csl_file = xeProperties.GetAttribute("csl-file")
                i.topic = xeProperties.GetAttribute("topic")
                i.total_time = xeProperties.GetAttribute("total-time")
                i.single_time = xeProperties.GetAttribute("single-time")
                i.file = MyInfo.FileList.FindFile(xeProperties.GetAttribute("file"), flist)
                i.approved = xeProperties.GetAttribute("approved")
                i.yes = xeProperties.GetAttribute("yes")
                i.no = xeProperties.GetAttribute("no")
                i.abst = xeProperties.GetAttribute("abst")
            Next
        End Function
    End Class


    ''' <summary>
    ''' 表示可以写入会议记录到一个 XML 文档的编写器。
    ''' </summary>
    Public Class RecordWriter
        Dim xmlDoc As New XmlDocument
        Private _RecordIndex As Integer
        Dim xnRecord As XmlNode
        Dim xeRecord As XmlElement
        Dim xmlpath As String
        Private YieldString() As String = New String() {"normal", "yieldn", "yieldq", "yielda", "yieldc"}

        ''' <summary>
        ''' 返回当前文档的记录索引数。
        ''' </summary>
        ''' <returns></returns>
        Public Property RecordIndex As Integer
            Get
                Return _RecordIndex
            End Get
            Private Set(ByVal value As Integer)
                _RecordIndex = value
            End Set
        End Property

        ''' <summary>
        ''' 为指定的 XML 文档和节点名初始化 RecordWriter 类的一个新实例。
        ''' </summary>
        ''' <param name="LoadXmlPath">文件的 URL，该文件包含要加载的 XML 文档。URL 既可以是本地文件，也可以是 HTTP URL（Web 地址）。</param>
        ''' <param name="NodeName">存储会议记录的 XML 节点名或 XPath 表达式。</param>
        Public Sub New(LoadXmlPath As String, NodeName As String)
            xmlpath = LoadXmlPath
            xmlDoc.Load(LoadXmlPath)
            xnRecord = xmlDoc.SelectSingleNode(NodeName)
            xeRecord = CType(xnRecord, XmlElement)
            RecordIndex = xeRecord.GetAttribute("recordIndex")
        End Sub

        ''' <summary>
        ''' 向 XML 文档添加一条新的会议记录。
        ''' </summary>
        ''' <param name="_single">要添加的会议记录。</param>
        Public Sub Add(_single As RecordContent)
            RecordIndex += 1
            Dim xeSingleRecord As XmlElement = xmlDoc.CreateElement("record")
            xeSingleRecord.SetAttribute("index", RecordIndex)
            xeSingleRecord.SetAttribute("category", _single.Category.ToString)
            Dim xnStartTime As XmlNode = xmlDoc.CreateElement("StartDate")
            xnStartTime.InnerText = "#" + _single.StartDate.ToString("G", Globalization.CultureInfo.CreateSpecificCulture("en-us")) + "#"
            xeSingleRecord.AppendChild(xnStartTime)
            Dim xnProperties As XmlNode = xmlDoc.CreateElement("properties")
            Dim xeProperties As XmlElement = xnProperties
            If Not _single.session = 0 Then xeProperties.SetAttribute("session", _single.session)
            If Not _single.presents = 0 Then xeProperties.SetAttribute("presents", _single.presents)
            If Not _single.nation Is MyInfo.Nation.Empty Then xeProperties.SetAttribute("nation", _single.nation.ToString)
            If _single.Category = RecordCategory.SL Or _single.Category = RecordCategory.CSL Then xeProperties.SetAttribute("yield-method", _single.yield_type)
            If Not _single.csl_file = "" Then xeProperties.SetAttribute("csl-file", _single.csl_file)
            If Not _single.topic = "" Then xeProperties.SetAttribute("topic", _single.topic)
            If Not _single.total_time = 0 Then xeProperties.SetAttribute("total-time", _single.total_time)
            If Not _single.single_time = 0 Then xeProperties.SetAttribute("single-time", _single.single_time)
            If Not _single.file Is MyInfo.File.Empty Then xeProperties.SetAttribute("nation", _single.file.ToString)
            Select Case _single.Category
                Case RecordCategory.MC, RecordCategory.UMC, RecordCategory.AT, RecordCategory.AO, RecordCategory.mTB, RecordCategory.mVT, RecordCategory.ED, RecordCategory.XH
                    xeProperties.SetAttribute("approved", _single.approved)
            End Select
            If _single.Category = RecordCategory.VT Or _single.Category = RecordCategory.mVT Then
                xeProperties.SetAttribute("yes", _single.yes)
                xeProperties.SetAttribute("no", _single.no)
                xeProperties.SetAttribute("abst", _single.abst)
            End If
            xeSingleRecord.AppendChild(xeProperties)
            If Not _single.Speeches.Count = 0 Then
                For Each i As Speech In _single.Speeches
                    Dim xnSingle As XmlNode = xmlDoc.CreateElement("speech")
                    xnSingle.InnerText = i.Content
                    Dim xeSingle As XmlElement = xnSingle
                    xeSingle.SetAttribute("nation", i.Nation.ToString)
                    If _single.Category = RecordCategory.MC Then xeSingle.SetAttribute("order", i.SpeechOrder)
                    If _single.Category = RecordCategory.SL Or _single.Category = RecordCategory.CSL Then xeSingle.SetAttribute("mode", YieldString(i.YieldMode))
                    xeSingleRecord.AppendChild(xnSingle)
                Next
            End If
            If Not _single.Votes.Count = 0 Then
                For Each i As VoteContent In _single.Votes
                    Dim xnSingle As XmlNode = xmlDoc.CreateElement("vote")
                    Dim xeSingle As XmlElement = xnSingle
                    xeSingle.SetAttribute("nation", i.Nation.ToString)
                    xeSingle.SetAttribute("opinion", Convert.ChangeType(i.Opinion, [Enum].GetUnderlyingType(GetType(MyInfo.VoteOpinion))).ToString)
                    xeSingle.SetAttribute("isveto", YieldString(i.isVeto))
                    xeSingleRecord.AppendChild(xnSingle)
                Next
            End If
            If Not _single.Comments.Count = 0 Then
                For Each i As Comment In _single.Comments
                    Dim xnSingle As XmlNode = xmlDoc.CreateElement("comment")
                    xnSingle.InnerText = i.Content
                    Dim xeSingle As XmlElement = xnSingle
                    xeSingle.SetAttribute("nation", i.Nation.ToString)
                    xeSingleRecord.AppendChild(xnSingle)
                Next
            End If
            If Not _single.note = "" Then
                Dim xnNote As XmlNode = xmlDoc.CreateElement("note")
                xnNote.InnerText = "#" + DateTime.Now.ToString("G", Globalization.CultureInfo.CreateSpecificCulture("en-us")) + "#"
                xeSingleRecord.AppendChild(xnNote)
            End If
            xnRecord.AppendChild(xeSingleRecord)
            xeRecord.SetAttribute("recordIndex", RecordIndex)
            xmlDoc.Save(xmlpath)
        End Sub

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="Path"></param>
        ''' <param name="NodeName"></param>
        Public Shared Sub Create(Path As String, NodeName As String)
            Dim myTW1 As New XmlTextWriter(Path + "record.xml", Nothing)
            myTW1.WriteStartDocument()
            myTW1.Formatting = Formatting.Indented
            myTW1.WriteStartElement(NodeName)
            myTW1.WriteAttributeString("recordIndex", 0)
            myTW1.WriteEndElement()
            myTW1.WriteEndDocument()
            myTW1.Close()
        End Sub
    End Class
End Namespace