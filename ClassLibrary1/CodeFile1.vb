'会议记录在StandardConfData根命名空间下

Namespace Record

    ''' <summary>
    ''' 指定会议记录的类别。
    ''' </summary>
    Public Enum RecordCategory
#Region "简化标记"
        ''' <summary>
        ''' 未定义类别(简化标记)。
        ''' </summary>
        UNDEF = 0
        ''' <summary>
        ''' 开始新会期(简化标记)。
        ''' </summary>
        ST = 1
        ''' <summary>
        ''' 点名(简化标记)。
        ''' </summary>
        RC = 2
        ''' <summary>
        ''' 主发言名单(简化标记)。
        ''' </summary>
        SL = 3
        ''' <summary>
        ''' 自定发言名单(简化标记)。
        ''' </summary>
        CSL = 4
        ''' <summary>
        ''' 有主持核心磋商(简化标记)。
        ''' </summary>
        MC = 5
        ''' <summary>
        ''' 自由磋商(简化标记)。
        ''' </summary>
        UMC = 6
        ''' <summary>
        ''' 茶歇(简化标记)。
        ''' </summary>
        TB = 7
        ''' <summary>
        ''' 动议的茶歇(简化标记)。
        ''' </summary>
        mTB = 8
        ''' <summary>
        ''' 调整主发言名单时间(简化标记)。
        ''' </summary>
        AT = 9
        ''' <summary>
        ''' 调整投票顺序(简化标记)。
        ''' </summary>
        AO = 10
        ''' <summary>
        ''' 对文件投票(简化标记)。
        ''' </summary>
        VT = 11
        ''' <summary>
        ''' 通过动议对文件投票(简化标记)。
        ''' </summary>
        mVT = 12
        ''' <summary>
        ''' 结束辩论(简化标记)。
        ''' </summary>
        ED = 13
        ''' <summary>
        ''' 休会(简化标记)。
        ''' </summary>
        XH = 14
        ''' <summary>
        ''' 新的会场文件(简化标记)。
        ''' </summary>
        NF = 15
        ''' <summary>
        ''' 介绍文件(简化标记)。
        ''' </summary>
        FI = 16
        ''' <summary>
        ''' 新的危机(简化标记)。
        ''' </summary>
        CR = 17
        ''' <summary>
        ''' 自定义文本消息(简化标记)。
        ''' </summary>
        CU = 18
#End Region
    End Enum

    ''' <summary>
    ''' 表示记录内的单条演讲内容。
    ''' </summary>
    Public Class Speech
        ''' <summary>
        ''' 发言的国家。
        ''' </summary>
        ''' <returns></returns>
        Public Property Nation As MyInfo.Nation
        ''' <summary>
        ''' 发言的顺序（有主持核心磋商）。
        ''' </summary>
        ''' <returns></returns>
        Public Property SpeechOrder As Integer
        ''' <summary>
        ''' 发言的模式（主发言名单）。
        ''' </summary>
        ''' <returns></returns>
        Public Property YieldMode As Integer
        ''' <summary>
        ''' 发言的内容。
        ''' </summary>
        ''' <returns></returns>
        Public Property Content As String

        ''' <summary>
        ''' 使用发言国家和内容初始化 Speech 类的一个新实例。
        ''' </summary>
        ''' <param name="nat">发言的国家。</param>
        ''' <param name="cont">发言的内容。</param>
        Public Sub New(nat As MyInfo.Nation, cont As String)
            Nation = nat
            Content = cont
        End Sub

        ''' <summary>
        ''' 使用发言国家、顺序和内容初始化 Speech 类的一个新实例。
        ''' </summary>
        ''' <param name="nat">发言的国家。</param>
        ''' <param name="cont">发言的内容。</param>
        ''' <param name="ord">发言顺序。</param>
        Public Sub New(nat As MyInfo.Nation, ord As Integer, cont As String)
            Nation = nat
            Content = cont
            SpeechOrder = ord
        End Sub
        ''' <summary>
        ''' 使用发言国家、内容和模式初始化 Speech 类的一个新实例。
        ''' </summary>
        ''' <param name="nat">发言的国家。</param>
        ''' <param name="cont">发言的内容。</param>
        ''' <param name="yield">发言模式。</param>
        Public Sub New(nat As MyInfo.Nation, cont As String, yield As Integer)
            Nation = nat
            Content = cont
            YieldMode = yield
        End Sub
    End Class

    ''' <summary>
    ''' 表示记录内的单条评价。
    ''' </summary>
    Public Class Comment
        ''' <summary>
        ''' 评价对应发言的国家。
        ''' </summary>
        ''' <returns></returns>
        Public Property Nation As MyInfo.Nation
        ''' <summary>
        ''' 评价的内容。
        ''' </summary>
        ''' <returns></returns>
        Public Property Content As String

        ''' <summary>
        ''' 使用发言国家和评价内容初始化 Comment 类的一个新实例。
        ''' </summary>
        ''' <param name="nat">评价对应发言的国家。</param>
        ''' <param name="cont">评价的内容。</param>
        Public Sub New(nat As MyInfo.Nation, cont As String)
            Nation = nat
            Content = cont
        End Sub
    End Class

    ''' <summary>
    ''' 表示记录内的单条投票内容。
    ''' </summary>
    Public Class VoteContent
        ''' <summary>
        ''' 投票的国家。
        ''' </summary>
        ''' <returns></returns>
        Public Property Nation As MyInfo.Nation
        ''' <summary>
        ''' 投票的内容。
        ''' </summary>
        ''' <returns></returns>
        Public Property Opinion As MyInfo.VoteOpinion
        ''' <summary>
        ''' 该国是否有否决权。
        ''' </summary>
        ''' <returns></returns>
        Public Property isVeto As Boolean = False

        ''' <summary>
        ''' 使用投票记录初始化 VoteContent 类的一个新实例。
        ''' </summary>
        ''' <param name="nat">投票的国家。</param>
        ''' <param name="opi">投票的选项。</param>
        ''' <param name="DisableVetoPower">可选。是否禁用否决权。如果值为 True，将禁用否决权设定。</param>
        Public Sub New(nat As MyInfo.Nation, opi As MyInfo.VoteOpinion, Optional DisableVetoPower As Boolean = False)
            Nation = nat
            Opinion = opi
            If Not DisableVetoPower Then isVeto = nat.VetoPower
        End Sub
    End Class

    ''' <summary>
    ''' 表示单条会议记录。
    ''' </summary>
    Public Class RecordContent
        Public Property Category As RecordCategory
        Public Property StartDate As Date
        Public session As Integer
        Public presents As String
        Public nation As MyInfo.Nation = MyInfo.Nation.Empty
        Public yield_type As Integer
        Public csl_file As String
        Public topic As String
        Public total_time As Integer
        Public single_time As Integer
        Public approved As Boolean
        Public file As MyInfo.File = MyInfo.File.Empty
        Public yes As Integer
        Public no As Integer
        Public abst As Integer
        Public EndDate As Integer

        Public Property Speeches As New List(Of Speech)
        Public Property Votes As New List(Of VoteContent)
        Public Property Comments As New List(Of Comment)
        Public Property note As String

#Region "RecordContent 构造函数"

        ''' <summary>
        ''' 使用空白记录项初始化 RecordContent 类的一个新实例。
        ''' </summary>
        Public Sub New()

        End Sub

        ''' <summary>
        ''' 使用开始新会期或点名的记录项初始化 RecordContent 类的一个新实例。
        ''' </summary>
        ''' <param name="cate">会议记录的类别（请选择开始新会期或点名）。</param>
        ''' <param name="stadt">事件的发生时间。</param>
        ''' <param name="sess">会期的序号或者出席人数。</param>
        Public Sub New(cate As RecordCategory, stadt As Date, sess As Integer)
            Category = cate
            StartDate = stadt
            If Category = 1 Then
                session = sess
            Else
                presents = sess
            End If
        End Sub

        ''' <summary>
        ''' 使用主发言名单的记录项初始化 RecordContent 类的一个新实例。
        ''' </summary>
        ''' <param name="cate">会议记录的类别（请选择主发言名单）。</param>
        ''' <param name="stadt">事件的发生时间。</param>
        ''' <param name="nation">在主发言名单中发言的国家。</param>
        ''' <param name="yield">选择的让渡方式。</param>
        Public Sub New(cate As RecordCategory, stadt As Date, nation As MyInfo.Nation, yield As Integer)
            Category = cate
            StartDate = stadt
            Me.nation = nation
            yield_type = yield
        End Sub

        ''' <summary>
        ''' 使用有主持核心磋商的记录项初始化 RecordContent 类的一个新实例。
        ''' </summary>
        ''' <param name="cate">会议记录的类别（请选择有主持核心磋商）。</param>
        ''' <param name="stadt">事件的发生时间。</param>
        ''' <param name="nat">动议发起的国家。</param>
        ''' <param name="topi">该轮有主持核心磋商的议题。</param>
        ''' <param name="total">该轮有主持核心磋商的总时长。</param>
        ''' <param name="singel">该轮有主持核心磋商每位代表的发言时间。</param>
        ''' <param name="approve">动议的通过情况。</param>
        Public Sub New(cate As RecordCategory, stadt As Date, nat As MyInfo.Nation, topi As String, total As Integer, singel As Integer, approve As Boolean)
            Category = cate
            StartDate = stadt
            nation = nat
            topic = topi
            total_time = total
            single_time = singel
            approved = approve
        End Sub

        ''' <summary>
        ''' 使用自由磋商、茶歇、动议茶歇或调整主发言名单时间的记录项初始化 RecordContent 类的一个新实例。
        ''' </summary>
        ''' <param name="cate">会议记录的类别（请选择自由磋商或动议茶歇）。</param>
        ''' <param name="stadt">事件的发生时间。</param>
        ''' <param name="nat">动议发起的国家。如果使用茶歇，则将其赋值为 null。</param>
        ''' <param name="total">自由磋商、茶歇的总时长，或新的主发言名单时间。</param>
        ''' <param name="approve">动议的通过情况。如果使用茶歇，可任意赋值。</param>
        Public Sub New(cate As RecordCategory, stadt As Date, nat As MyInfo.Nation, total As Integer, approve As Boolean)
            Category = cate
            StartDate = stadt
            If Not cate = 7 Then
                nation = nat
                approved = approve
            End If
            total_time = total
        End Sub

        ''' <summary>
        ''' 使用调整投票顺序、投票或动议发起投票的记录项初始化 RecordContent 类的一个新实例。
        ''' </summary>
        ''' <param name="cate">会议记录的类别（请选择调整投票顺序、投票或动议发起投票）。</param>
        ''' <param name="stadt">事件的发生时间。</param>
        ''' <param name="nat">动议发起的国家。如果使用投票，则将其赋值为 null。</param>
        ''' <param name="fil">希望优先投票的文件。</param>
        ''' <param name="approve">动议的通过情况。如果使用投票，可任意赋值。</param>
        Public Sub New(cate As RecordCategory, stadt As Date, nat As MyInfo.Nation, fil As MyInfo.File, approve As Boolean)
            Category = cate
            StartDate = stadt
            nation = nat
            file = fil
            approved = approve
        End Sub

        ''' <summary>
        ''' 使用发布文件、介绍文件或发布危机的记录项初始化 RecordContent 类的一个新实例。
        ''' </summary>
        ''' <param name="cate">会议记录的类别（请选择发布文件、介绍文件或发布危机）。</param>
        ''' <param name="stadt">事件的发生时间。</param>
        ''' <param name="fil">发表或介绍的文件。</param>
        ''' <param name="total">发表文件或介绍文件时长。</param>
        Public Sub New(cate As RecordCategory, stadt As Date, fil As MyInfo.File, total As Integer)
            Category = cate
            StartDate = stadt
            file = fil
            total_time = total
        End Sub

        ''' <summary>
        ''' 使用发布自定义文本信息的记录项初始化 RecordContent 类的一个新实例。
        ''' </summary>
        ''' <param name="cate">会议记录的类别（请选择自定义文本信息）。</param>
        ''' <param name="stadt">事件的发生时间。</param>
        ''' <param name="topi">文本信息的内容。</param>
        Public Sub New(cate As RecordCategory, stadt As Date, topi As String)
            Category = cate
            StartDate = stadt
            topic = topi
        End Sub
#End Region

        ''' <summary>
        ''' 返回表示当前会议记录的字符串。
        ''' </summary>
        ''' <returns></returns>
        Public Overrides Function ToString() As String
            Dim mystring As String = ""
            If Category = RecordCategory.ST Then
                mystring += StartDate.ToShortDateString() + " "
            End If
            mystring += StartDate.ToLongTimeString() + vbCrLf
            Select Case Category
                Case RecordCategory.ST
                    'mystring += XmlAccess.GetFromXml.GetConferenceString()
                Case RecordCategory.RC
                    mystring += ""
            End Select
            Return mystring
        End Function
    End Class

    Public Class RecordCollection
        Inherits List(Of RecordContent)

        Public Shared Function FromXmlReader(reader As RecordReader) As RecordCollection
            Return reader.GetRecordCollection()
        End Function

        Public Overloads Sub Add(rec As RecordContent, Optional writer As RecordWriter = Nothing)
            MyBase.Add(rec)
            If writer IsNot Nothing Then writer.Add(rec)
        End Sub

        Public Overrides Function ToString() As String
            Return MyBase.ToString()
        End Function
    End Class

End Namespace
