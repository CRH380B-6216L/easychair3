Public Class Class1

End Class

Namespace MyInfo
    Public Class ConferenceStatus
        Public IsInSpeakerList As Boolean
    End Class

    Public Enum AppStatus As Integer
        Idle = 0
        RollCall = 1
        SpeakersLoist = 2
        Motion = 3
        FileView = 4
        Vote = 5
        TimerOnly = 6
    End Enum

    Public Enum Files As Integer
        WorkingPaper = 0
        DraftResolution = 1
        Amendment = 2
        DraftDirective = 3
        PageCrisis = 4
    End Enum

    ''' <summary>
    ''' 定义文件类型。
    ''' </summary>
    Public Enum FileCategory As Integer
        ''' <summary>
        ''' 工作文件。
        ''' </summary>
        WorkingPaper = 0
        ''' <summary>
        ''' 决议草案。
        ''' </summary>
        DraftResolution = 1
        ''' <summary>
        ''' 修正案。
        ''' </summary>
        Amendment = 2
        ''' <summary>
        ''' 指令草案。
        ''' </summary>
        DraftDirective = 3
        ''' <summary>
        ''' 危机文件。
        ''' </summary>
        Crisis = 4
        ''' <summary>
        ''' 政策建议。
        ''' </summary>
        PolicySuggect = 5
        ''' <summary>
        ''' 其他杂项文件。
        ''' </summary>
        Miscellaneous = 6
    End Enum

    ''' <summary>
    ''' 定义主发言名单剩余时间的让渡方式。
    ''' </summary>
    Public Enum YieldTo As Integer
        ''' <summary>
        ''' 无让渡操作定义。
        ''' </summary>
        NoYield = 0
        ''' <summary>
        ''' 让渡给其他国家。
        ''' </summary>
        ToNation = 1
        ''' <summary>
        ''' 让渡给问题。
        ''' </summary>
        ToQuestion = 2
        ''' <summary>
        ''' 让渡给评论。
        ''' </summary>
        ToComment = 3
        ''' <summary>
        ''' 让渡给主席。
        ''' </summary>
        ToDais = 4
    End Enum

    ''' <summary>
    ''' 定义工作语言。
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum WerkLanguage As Integer
        ''' <summary>
        ''' 简体中文。
        ''' </summary>
        ''' <remarks></remarks>
        ChineseS = 1
        ''' <summary>
        ''' English.
        ''' </summary>
        ''' <remarks></remarks>
        English = 2
    End Enum

    Public Enum UsingRule As Integer
        Robert = 0
        European = 1
        Security = 2
    End Enum

    ''' <summary>
    ''' 定义议题选定情况。
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum TopicSelection As Integer
        ''' <summary>
        ''' 选定第一议题，或仅有单一议题。
        ''' </summary>
        ''' <remarks></remarks>
        Topic1 = 0
        ''' <summary>
        ''' 选定第二议题。
        ''' </summary>
        ''' <remarks></remarks>
        Topic2 = 1
        ''' <summary>
        ''' 议题等待选定。
        ''' </summary>
        ''' <remarks></remarks>
        Unchosen = 2
    End Enum

    ''' <summary>
    ''' 定义投票立场。
    ''' </summary>
    Public Enum VoteOpinion
        ''' <summary>
        ''' 赞成。
        ''' </summary>
        Yes = 1
        ''' <summary>
        ''' 反对。
        ''' </summary>
        No = 2
        ''' <summary>
        ''' 弃权。
        ''' </summary>
        Abst = 3
    End Enum

    ''' <summary>
    ''' 定义会议基本信息。
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Conference
        ''' <summary>
        ''' 会议工作语言。
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property language As WerkLanguage
        ''' <summary>
        ''' 议题选定情况。
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property topicSel As TopicSelection
        ''' <summary>
        ''' 会场使用的规则。
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property myrule As UsingRule
        ''' <summary>
        ''' 会议存档版本。
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property XmlVersion As Integer
        ''' <summary>
        ''' 大会名称（如：XX模拟联合国大会）。
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property ConferenceTitle As String
        ''' <summary>
        ''' 本会场委员会（如：联合国安全理事会）。
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property Committee As String
        ''' <summary>
        ''' 使用的议题。
        ''' </summary>
        ''' <remarks></remarks>
        Public Topic(1) As String
    End Class

    Public Class Moderated
        Public Shared isModerated As Boolean
        Public Shared mcTitle, motionNation As String, mcIndex As Integer
        Public Shared mcTotal, mcCurrent, mcAdd, mcTime(1), mcLength(1) As Integer, mcNations(45), mcTopcic(1) As String, mcIsSpoken(45), isZhuijia As Boolean
        Public Shared mcAll As Integer
    End Class

    Public Class SpeakersList
        Public Shared slTotal, slCurrent, slTime(1), yieldType, page, maxPage, slIsSpoken(193) As Integer, slNations(193), yieldSubject As String, isYield As Boolean, slEndTime As DateTime
    End Class

    Public Class SpeakersList2
#Region "Properties"
        Private _sl_total As Integer

        Private _sl_current As Integer
        Public Property slTotal As Integer
            Get
                Return _sl_total
            End Get
            Private Set(value As Integer)
                _sl_total = value
            End Set
        End Property

        ''' <summary>
        ''' 指示主发言名单的发言位置。
        ''' </summary>
        ''' <returns></returns>
        Public Property slCurrent As Integer
            Get
                Return _sl_current
            End Get
            Private Set(value As Integer)
                _sl_current = value
            End Set
        End Property
        ''' <summary>
        ''' 主发言名单的发言时间（以秒为单位）。
        ''' </summary>
        ''' <returns></returns>
        Public Property slTime As Integer
        Public Property slNations As List(Of Nation) = New List(Of Nation)
        Public Property slIsSpolen As List(Of Integer) = New List(Of Integer)
        Public Property yieldMethod As List(Of YieldTo) = New List(Of YieldTo)

#End Region

        Public Sub New()
            slTime = 120
        End Sub

        Public Function AddNation(nat As Nation) As Integer
            slNations.Add(nat)
            slTotal += 1
            Return slTotal
        End Function
    End Class

    ''' <summary>
    ''' 表示单个国家。
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Nation
#Region "Properties"
        ''' <summary>
        ''' 国家名称。
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property Name As String
        ''' <summary>
        ''' 代表姓名。
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property Delegates As List(Of String) = New List(Of String)
        ''' <summary>
        ''' 代表所在学校。
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property SchoolDelegates As String
        ''' <summary>
        ''' 该国投票权限，默认值为1（一票）。
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property Competence As Integer = 1
        ''' <summary>
        ''' 该国立场文件提交情况。
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property PresentationPaper As String
        ''' <summary>
        ''' 该国出席情况。
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property Attendence As Boolean = False
        ''' <summary>
        ''' 该国是否拥有一票否决权。
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Property VetoPower As Boolean = False
#End Region

        Public Shared Empty As Nation = Nothing

        ''' <summary>
        ''' 返回所有代表的姓名。
        ''' </summary>
        ''' <param name="Delimiter">可选。任何字符串，用于在返回的字符串中分隔子字符串。如果省略该参数，则使用空白字符 (" ")。如果 Delimiter 是零长度字符串 ("") 或 Nothing，则列表中的所有项目都串联在一起，中间没有分隔符。</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetDelegateNames(Optional Delimiter As String = " ") As String
            If Delegates.Equals(Nothing) Then
                Return ""
            Else
                Dim delnames As String = ""
                For Each i In Delegates
                    If Not i = Delegates(0) Then delnames = delnames + Delimiter
                    delnames = delnames + i
                Next
                Return delnames
            End If
        End Function

        ''' <summary>
        ''' 将当前国家的投票权限转换为其等效的字符串表示形式。
        ''' </summary>
        ''' <returns></returns>
        Public Function GetCompetence() As String
            Dim getcompetence1 As String
            getcompetence1 = Competence.ToString
            If VetoPower = True And Competence > 0 Then getcompetence1 += "*"
            Return getcompetence1
        End Function

        ''' <summary>
        ''' 以多行文本设置代表姓名。
        ''' </summary>
        ''' <param name="MultiLineText">代表的姓名（每行一个）。</param>
        ''' <remarks></remarks>
        Public Sub SetDelegateFromMultiLineText(MultiLineText As String)
            Delegates.Clear()
            Dim split As String() = MultiLineText.Split(New [Char]() {vbCr, vbLf})
            For Each s In split
                If Not s = "" Then Delegates.Add(s)
            Next
        End Sub

        ''' <summary>
        ''' 将当前国家的名称转换为其等效的字符串表示形式。 
        ''' </summary>
        ''' <returns>当前国家名称的字符串表示形式。</returns>
        Public Overrides Function ToString() As String
            Return Name()
        End Function
    End Class

    ''' <summary>
    ''' 定义国家列表。
    ''' </summary>
    Public Class NationList
        Inherits System.Collections.Generic.List(Of Nation)

        ''' <summary>
        ''' 根据国家名获取国家。
        ''' </summary>
        ''' <param name="name">需要获取的国家名称。如果该国在列表中不存在，则返回 null 值。</param>
        ''' <returns></returns>
        Public Function GetNationFromName(name As String) As Nation
            For Each n As Nation In Me
                If n.Name = name Then
                    Return n
                    Exit Function
                End If
            Next
            Return Nothing
        End Function

        ''' <summary>
        ''' 根据国家名从国家列表获取国家。
        ''' </summary>
        ''' <param name="name">需要获取的国家名称。如果该国在列表中不存在，则返回 null 值。</param>
        ''' <param name="list">指定的国家列表。</param>
        ''' <returns></returns>
        Public Shared Function FindNation(name As String, list As NationList) As Nation
            For Each n As Nation In list
                If n.Name = name Then
                    Return n
                    Exit Function
                End If
            Next
            Return Nothing
        End Function

        ''' <summary>
        ''' 返回所有国家的名称。
        ''' </summary>
        ''' <param name="Delimiter">可选。任何字符串，用于在返回的字符串中分隔子字符串。如果省略该参数，则使用空白字符 (" ")。如果 Delimiter 是零长度字符串 ("") 或 Nothing，则列表中的所有项目都串联在一起，中间没有分隔符。</param>
        ''' <returns></returns>
        Public Overloads Function ToString(Optional Delimiter As String = " ") As String
            If Equals(Nothing) Then
                Return ""
            Else
                Dim names As String = ""
                For Each i As Nation In Me
                    If Not i.Equals(Me(0)) Then names = names + Delimiter
                    names = names + i.Name
                Next
                Return names
            End If
        End Function
    End Class

    ''' <summary>
    ''' 定义会场内文件。
    ''' </summary>
    Public Class File
#Region "Properties"
        ''' <summary>
        ''' 文件名称。
        ''' </summary>
        ''' <returns></returns>
        Public Property FileTitle As String
        ''' <summary>
        ''' 文件保存路径。
        ''' </summary>
        ''' <returns></returns>
        Public Property FilePath As String
        ''' <summary>
        ''' 文件类型。
        ''' </summary>
        ''' <returns></returns>
        Public Property Category As FileCategory
        ''' <summary>
        ''' 起草国。
        ''' </summary>
        ''' <returns></returns>
        Public Property Sponsers As New NationList
        ''' <summary>
        ''' 附议国。
        ''' </summary>
        ''' <returns></returns>
        Public Property Signatories As New NationList
#End Region

        Public Shared Empty As File = Nothing

        ''' <summary>
        ''' 定义空白的新文件。
        ''' </summary>
        Public Sub New()

        End Sub

        ''' <summary>
        ''' 定义新文件。
        ''' </summary>
        ''' <param name="title"></param>
        ''' <param name="path"></param>
        ''' <param name="cate"></param>
        ''' <param name="sponser">可选。定义文件起草国。</param>
        ''' <param name="signatorie">可选。定义文件附议国。</param>
        Public Sub New(title As String, path As String, cate As FileCategory, sponser As NationList, signatorie As NationList)
            FileTitle = title
            FilePath = path
            Category = cate
            Sponsers = sponser
            Signatories = signatorie
        End Sub

        Public Overrides Function ToString() As String
            Return FileTitle
        End Function
    End Class

    Public Class FileList
        Inherits List(Of File)

        ''' <summary>
        ''' 根据文件名获取文件。
        ''' </summary>
        ''' <param name="name">需要获取的文件名称。如果该文件在列表中不存在，则返回 null 值。</param>
        ''' <returns></returns>
        Public Function GetFileFromName(name As String) As File
            For Each n As File In Me
                If n.FileTitle = name Then
                    Return n
                    Exit Function
                End If
            Next
            Return Nothing
        End Function

        ''' <summary>
        ''' 根据文件名和文件列表获取文件。
        ''' </summary>
        ''' <param name="name">需要获取的文件名称。如果该文件在列表中不存在，则返回 null 值。</param>
        ''' <param name="list">指定的文件列表。</param>
        ''' <returns></returns>
        Public Shared Function FindFile(name As String, list As FileList) As File
            For Each n As File In list
                If n.FileTitle = name Then
                    Return n
                    Exit Function
                End If
            Next
            Return Nothing
        End Function

    End Class


    Public Class CabinetSetting
        Public Property isCabinet As Boolean
        Public Property cabintime As New DateTime
        Public Property RawRate As Integer = 1
        'Dim x() As Integer = {1, 2, 3, 5, 10, 20, 30, 60, 120, 180, 360, 720, 1440}

        Public Sub New()

        End Sub

        Public Sub New(iss As Boolean, time1 As Date, rate As Integer)
            isCabinet = iss
            cabintime = time1
            RawRate = rate
        End Sub

        Public Sub AddMilliseconds()
            cabintime = cabintime.AddMilliseconds(RawRate * 62)
        End Sub

        Public Sub AddSpan(Span As TimeSpan)
            cabintime = cabintime.Add(TimeSpan.FromSeconds(Span.TotalSeconds * RawRate))
        End Sub
    End Class

    Public Class VoteResult
        Public Property VoteNations As New NationList
        Public Property VoteOpinions As New List(Of VoteOpinion)
        Public Property VoteFile As File

    End Class
End Namespace
