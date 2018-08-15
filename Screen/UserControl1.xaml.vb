Imports System.Windows.Media
Imports System.Windows.Controls
Imports System.Windows
Imports System.Xml

Public Class UserControl1

    Private isListExtention, isListExtraColumn, isUsingMarkup As Boolean
    Private capacity As Integer
    Private VoteMode, isNews As Boolean
    Private listitme(60) As String, markups(60) As listmarkup
    Private _bookmarkmode As bookmarkmode

    Public Property BookmarkMode As bookmarkmode
        Get
            Return _bookmarkmode
        End Get
        Set(value As bookmarkmode)
            _bookmarkmode = value
            Call SetBookmarkMode(value)
        End Set
    End Property

    Public Property ListMarkup As listmarkup
    Public Property bgimage As ImageBrush
    Public Property ColortitleB As SolidColorBrush
    Public Property ColortitleF As SolidColorBrush
    Public Property ColortimebarB As SolidColorBrush
    Public Property ColortimebarF As SolidColorBrush
    Public Property ColorsideareaB As SolidColorBrush
    Public Property ColorsideareaF As SolidColorBrush
    Public Property ScreenWorkingLanguange As Integer

    Public ReadOnly Property ListCapacity As Integer
        Get
            capacity = 30
            If isListExtention Then capacity = 45
            If isListExtraColumn Then capacity = 40
            If isListExtention And isListExtraColumn Then capacity = 60
            Return capacity
        End Get
    End Property

    Public Sub SetMarkup(value As Boolean)
        Dim markupwidth As Integer = Convert.ToInt32(value) * 64
        grid_list_main.ColumnDefinitions(1).Width = New GridLength(markupwidth)
        grid_list_main.ColumnDefinitions(3).Width = New GridLength(markupwidth)
        grid_list_main.ColumnDefinitions(5).Width = New GridLength(markupwidth)
        grid_list_wide.ColumnDefinitions(1).Width = New GridLength(markupwidth)
        grid_list_extention.ColumnDefinitions(1).Width = New GridLength(markupwidth)
        grid_list_extention.ColumnDefinitions(3).Width = New GridLength(markupwidth)
        grid_list_extention.ColumnDefinitions(5).Width = New GridLength(markupwidth)
        grid_list_wide_ext.ColumnDefinitions(1).Width = New GridLength(markupwidth)
    End Sub

    Public Property UseMarkup As Boolean
        Get
            Return UseMarkup
        End Get
        Set(value As Boolean)
            Call SetMarkup(value)
            isUsingMarkup = value
        End Set
    End Property

    Public Sub SetListExtraColomn(value As Boolean)
        If value = False Then
            grid_list_wide.Visibility = Windows.Visibility.Collapsed
            grid_list_wide_ext.Visibility = Windows.Visibility.Collapsed
            grid_list.ColumnDefinitions(3).Width = New GridLength(0)
        Else
            grid_list.ColumnDefinitions(3).Width = New GridLength(1, GridUnitType.Star)
            grid_list_wide.Visibility = Windows.Visibility.Visible
            If ListExtention Then grid_list_wide_ext.Visibility = Windows.Visibility.Visible
        End If
    End Sub

    Public Property ListExtraColumn As Boolean
        Get
            Return isListExtraColumn
        End Get
        Set(value As Boolean)
            Call SetListExtraColomn(value)
            isListExtraColumn = value
        End Set
    End Property

    Public Property ListExtention As Boolean
        Get
            Return isListExtention
        End Get
        Set(value As Boolean)
            If value Then
                grid_list_extention.Visibility = Windows.Visibility.Visible
                If ListExtraColumn Then grid_list_wide_ext.Visibility = Windows.Visibility.Visible
            Else
                grid_list_extention.Visibility = Windows.Visibility.Collapsed
                grid_list_wide_ext.Visibility = Windows.Visibility.Collapsed
            End If
            isListExtention = value
        End Set
    End Property

    Public Event LoadMain()
    Sub subLoadMain()
        panel_prompt.Visibility = Windows.Visibility.Visible
        grid_main.Visibility = Windows.Visibility.Visible
        grid_title.Visibility = Windows.Visibility.Visible
    End Sub

    Public Event UnloadMain()
    Sub subunloadmain()
        panel_prompt.Visibility = Windows.Visibility.Hidden
        grid_main.Visibility = Windows.Visibility.Hidden
        grid_title.Visibility = Windows.Visibility.Hidden
    End Sub

    Public Event MainTextChanged()
    Sub subchangemaintext(text As String)
        lblmain.Text = text
    End Sub

    Sub subchangetitle(left As String, right As String)
        lblconf.Content = left
        lblopic.Content = right
    End Sub

    Sub SetBookmarkMode(mode As bookmarkmode)
        Select Case mode
            Case Screen.bookmarkmode.Versie
                grid_versie.Visibility = Windows.Visibility.Visible
                grid_present.Visibility = Windows.Visibility.Collapsed
                grid_timer1.Visibility = Windows.Visibility.Collapsed
            Case Screen.bookmarkmode.Presents
                grid_versie.Visibility = Windows.Visibility.Collapsed
                grid_present.Visibility = Windows.Visibility.Visible
                grid_timer1.Visibility = Windows.Visibility.Collapsed
            Case Screen.bookmarkmode.Timer
                grid_versie.Visibility = Windows.Visibility.Collapsed
                grid_present.Visibility = Windows.Visibility.Collapsed
                grid_timer1.Visibility = Windows.Visibility.Visible
        End Select
    End Sub

    Sub SetTime(date1 As Date, time As DateTime)
        lbltime.Content = date1.ToString("d") + "　" + time.ToString("T")
    End Sub

    Sub SetVoteMode(turnon As Boolean)
        If turnon Then
            lblpresent1.Content = Class1.screen(14)
            lbl50maj1.Content = Class1.screen(6)
            lbl67maj1.Content = Class1.screen(7)
            lbl20maj1.Content = Class1.screen(8)
        Else
            lblpresent1.Content = Class1.screen(14)
            lbl50maj1.Content = Class1.screen(15)
            lbl67maj1.Content = Class1.screen(16)
            lbl20maj1.Content = "20%"
        End If
        VoteMode = turnon
    End Sub

    Sub SetPresents(present As Integer, Optional yes As Integer = 0, Optional no As Integer = 0, Optional abst As Integer = 0)
        lblpresent.Content = present.ToString
        If Not VoteMode Then
            lbl50maj.Content = (present \ 2 + 1).ToString
            lbl67maj.Content = (present * 2 \ 3 + 1).ToString
            lbl20maj.Content = (present \ 5 + 1).ToString
        Else
            lbl50maj.Content = yes.ToString
            lbl67maj.Content = no.ToString
            lbl20maj.Content = abst.ToString
        End If
    End Sub

    Sub SetTimeCount(time As Integer, maohao As Boolean)
        If time >= 5999 Then
            lbltime_mm.Content = "99"
            lbltime_ss.Content = "59"
            If maohao = True Then
                lblmaohao.Visibility = Windows.Visibility.Visible
            Else
                lblmaohao.Visibility = Windows.Visibility.Hidden
            End If
            Exit Sub
        End If
        Dim imin As Integer = time \ 60
        Dim isec As Integer = time Mod 60
        If imin < 10 Then lbltime_mm.Content = "0" Else lbltime_mm.Content = ""
        lbltime_mm.Content = lbltime_mm.Content + imin.ToString
        If isec < 10 Then lbltime_ss.Content = "0" Else lbltime_ss.Content = ""
        lbltime_ss.Content = lbltime_ss.Content + isec.ToString
        If maohao = True Then
            lblmaohao.Visibility = Windows.Visibility.Visible
        Else
            lblmaohao.Visibility = Windows.Visibility.Hidden
            If time >= 50 Then
                lblmaohao.Foreground = ColorsideareaF
                lbltime_mm.Foreground = ColorsideareaF
                lbltime_ss.Foreground = ColorsideareaF
            End If
        End If
    End Sub

    Sub SetMCTimeCount(time As Integer)
        If time >= 5999 Then
            lbl_totaltime.Content = "99:59"
            Exit Sub
        End If
        Dim imin As Integer = time \ 60
        Dim isec As Integer = time Mod 60
        If imin < 10 Then lbl_totaltime.Content = "0" Else lbl_totaltime.Content = ""
        lbl_totaltime.Content = lbl_totaltime.Content + imin.ToString
        If isec < 10 Then lbl_totaltime.Content = lbl_totaltime.Content + ":0" Else lbl_totaltime.Content = lbl_totaltime.Content + ":"
        lbl_totaltime.Content = lbl_totaltime.Content + isec.ToString
    End Sub

    Sub SetNews(unread As Integer, content As String, Optional title As String = "")
        lbl_cxxctr.Content = Class1.screen(0) + unread.ToString + ")"
        txt_nieuwscontent.Text = content
        txt_nieuwstitel.Text = title
        If title = "" Then txt_nieuwstitel.Text = Class1.screen(1)
        isNews = True
        grid_nieuws.Background = ColortimebarB
        lbl_cxxctr.Foreground = ColortimebarF
        lbl_nieuwstitel.Foreground = ColortimebarF
        lbl_nieuwscontent.Foreground = ColortimebarF
    End Sub

    Sub ClearNews()
        lbl_cxxctr.Content = Class1.screen(2)
        txt_nieuwscontent.Text = Class1.screen(4)
        txt_nieuwstitel.Text = Class1.screen(3)
        isNews = False
        grid_nieuws.Background = Nothing
        lbl_cxxctr.Foreground = ColorsideareaF
        lbl_nieuwstitel.Foreground = ColorsideareaF
        lbl_nieuwscontent.Foreground = ColorsideareaF
    End Sub

    'Sub ListExtSetting()

    'End Sub

    Sub ShowList()
        grid_list.Visibility = Windows.Visibility.Visible
        'Call ListExtSetting()
    End Sub

    Sub HideList()
        grid_list.Visibility = Windows.Visibility.Collapsed
    End Sub

    Sub SetTextVisibility(visible As Boolean)
        If visible Then
            lblmain.Visibility = Windows.Visibility.Visible
        Else
            lblmain.Visibility = Windows.Visibility.Collapsed
        End If
    End Sub

    Sub SetFileVisibility(visible As Boolean)
        If visible Then
            fileview.Visibility = Windows.Visibility.Visible
        Else
            fileview.Visibility = Windows.Visibility.Collapsed
        End If
    End Sub

    Sub SetListItme(number As Integer, text As String, stroke As Boolean)
        'lbl_nationt_41, lbl_nationt_42, lbl_nationt_43, lbl_nationt_44, lbl_nationt_45, 
        'lbl_nationt_51, lbl_nationt_52, lbl_nationt_53, lbl_nationt_54, lbl_nationt_55,
        'lbl_nationt_61, lbl_nationt_62, lbl_nationt_63, lbl_nationt_64, lbl_nationt_65, 
        'lbl_nationt_71, lbl_nationt_72, lbl_nationt_73, lbl_nationt_74, lbl_nationt_75,

        Dim list() As TextBlock = New TextBlock() {Nothing, lbl_nationt_1, lbl_nationt_2, lbl_nationt_3, lbl_nationt_4, lbl_nationt_5, lbl_nationt_6, lbl_nationt_7, lbl_nationt_8, lbl_nationt_9, lbl_nationt_10, lbl_nationt_11, lbl_nationt_12, lbl_nationt_13, lbl_nationt_14, lbl_nationt_15, lbl_nationt_16, lbl_nationt_17, lbl_nationt_18, lbl_nationt_19, lbl_nationt_20, lbl_nationt_21, lbl_nationt_22, lbl_nationt_23, lbl_nationt_24, lbl_nationt_25, lbl_nationt_26, lbl_nationt_27, lbl_nationt_28, lbl_nationt_29, lbl_nationt_30, lbl_nationt_31, lbl_nationt_32, lbl_nationt_33, lbl_nationt_34, lbl_nationt_35, lbl_nationt_36, lbl_nationt_37, lbl_nationt_38, lbl_nationt_39, lbl_nationt_40}
        list(number).Text = text
        If stroke Then
            list(number).TextDecorations = TextDecorations.Strikethrough
        Else
            list(number).TextDecorations = Nothing
        End If
        listitme(number) = text
    End Sub

    Sub SetListItmeExt(number As Integer, text As String, stroke As Boolean)
        Dim list() As TextBlock = New TextBlock() {Nothing, lbl_nationt_41, lbl_nationt_42, lbl_nationt_43, lbl_nationt_44, lbl_nationt_45, lbl_nationt_1, lbl_nationt_2, lbl_nationt_3, lbl_nationt_4, lbl_nationt_5, lbl_nationt_6, lbl_nationt_7, lbl_nationt_8, lbl_nationt_9, lbl_nationt_10, lbl_nationt_51, lbl_nationt_52, lbl_nationt_53, lbl_nationt_54, lbl_nationt_55, lbl_nationt_11, lbl_nationt_12, lbl_nationt_13, lbl_nationt_14, lbl_nationt_15, lbl_nationt_16, lbl_nationt_17, lbl_nationt_18, lbl_nationt_19, lbl_nationt_20, lbl_nationt_61, lbl_nationt_62, lbl_nationt_63, lbl_nationt_64, lbl_nationt_65, lbl_nationt_21, lbl_nationt_22, lbl_nationt_23, lbl_nationt_24, lbl_nationt_25, lbl_nationt_26, lbl_nationt_27, lbl_nationt_28, lbl_nationt_29, lbl_nationt_30, lbl_nationt_71, lbl_nationt_72, lbl_nationt_73, lbl_nationt_74, lbl_nationt_75, lbl_nationt_31, lbl_nationt_32, lbl_nationt_33, lbl_nationt_34, lbl_nationt_35, lbl_nationt_36, lbl_nationt_37, lbl_nationt_38, lbl_nationt_39, lbl_nationt_40}
        list(number).Text = text
        If stroke Then
            list(number).TextDecorations = TextDecorations.Strikethrough
        Else
            list(number).TextDecorations = Nothing
        End If
        listitme(number) = text
    End Sub

    Sub SetListItmeMarkup(number As Integer, type As listmarkup)
        Dim list() As Label = New Label() {Nothing, lbl_nation_markup_1, lbl_nation_markup_2, lbl_nation_markup_3, lbl_nation_markup_4, lbl_nation_markup_5, lbl_nation_markup_6, lbl_nation_markup_7, lbl_nation_markup_8, lbl_nation_markup_9, lbl_nation_markup_10, lbl_nation_markup_11, lbl_nation_markup_12, lbl_nation_markup_13, lbl_nation_markup_14, lbl_nation_markup_15, lbl_nation_markup_16, lbl_nation_markup_17, lbl_nation_markup_18, lbl_nation_markup_19, lbl_nation_markup_20, lbl_nation_markup_21, lbl_nation_markup_22, lbl_nation_markup_23, lbl_nation_markup_24, lbl_nation_markup_25, lbl_nation_markup_26, lbl_nation_markup_27, lbl_nation_markup_28, lbl_nation_markup_29, lbl_nation_markup_30, lbl_nation_markup_31, lbl_nation_markup_32, lbl_nation_markup_33, lbl_nation_markup_34, lbl_nation_markup_35, lbl_nation_markup_36, lbl_nation_markup_37, lbl_nation_markup_38, lbl_nation_markup_39, lbl_nation_markup_40}
        Select Case type
            Case Screen.listmarkup.Aan
                list(number).Content = Class1.screen(5)
                list(number).Background = Brushes.LightGreen
                list(number).Foreground = Brushes.Green
            Case Screen.listmarkup.Yes
                list(number).Content = Class1.screen(6)
                list(number).Background = Brushes.MistyRose
                list(number).Foreground = Brushes.Firebrick
            Case Screen.listmarkup.No
                list(number).Content = Class1.screen(7)
                list(number).Background = Brushes.PowderBlue
                list(number).Foreground = Brushes.RoyalBlue
            Case Screen.listmarkup.Abst
                list(number).Content = Class1.screen(8)
                list(number).Background = Brushes.Yellow
                list(number).Foreground = Brushes.DarkGoldenrod
            Case Screen.listmarkup.Empty
                list(number).Content = ""
                list(number).Background = Nothing
                list(number).Foreground = Brushes.Black
        End Select
        markups(number) = type
    End Sub

    Sub SetListItmeMarkupExt(number As Integer, type As listmarkup)
        Dim list() As Label = New Label() {Nothing, lbl_nation_markup_41, lbl_nation_markup_42, lbl_nation_markup_43, lbl_nation_markup_44, lbl_nation_markup_45, lbl_nation_markup_1, lbl_nation_markup_2, lbl_nation_markup_3, lbl_nation_markup_4, lbl_nation_markup_5, lbl_nation_markup_6, lbl_nation_markup_7, lbl_nation_markup_8, lbl_nation_markup_9, lbl_nation_markup_10, lbl_nation_markup_51, lbl_nation_markup_52, lbl_nation_markup_53, lbl_nation_markup_54, lbl_nation_markup_55, lbl_nation_markup_11, lbl_nation_markup_12, lbl_nation_markup_13, lbl_nation_markup_14, lbl_nation_markup_15, lbl_nation_markup_16, lbl_nation_markup_17, lbl_nation_markup_18, lbl_nation_markup_19, lbl_nation_markup_20, lbl_nation_markup_61, lbl_nation_markup_62, lbl_nation_markup_63, lbl_nation_markup_64, lbl_nation_markup_65, lbl_nation_markup_21, lbl_nation_markup_22, lbl_nation_markup_23, lbl_nation_markup_24, lbl_nation_markup_25, lbl_nation_markup_26, lbl_nation_markup_27, lbl_nation_markup_28, lbl_nation_markup_29, lbl_nation_markup_30, lbl_nation_markup_71, lbl_nation_markup_72, lbl_nation_markup_73, lbl_nation_markup_74, lbl_nation_markup_75, lbl_nation_markup_31, lbl_nation_markup_32, lbl_nation_markup_33, lbl_nation_markup_34, lbl_nation_markup_35, lbl_nation_markup_36, lbl_nation_markup_37, lbl_nation_markup_38, lbl_nation_markup_39, lbl_nation_markup_40}
        Select Case type
            Case Screen.listmarkup.Aan
                list(number).Content = Class1.screen(5)
                list(number).Background = Brushes.LightGreen
                list(number).Foreground = Brushes.Green
            Case Screen.listmarkup.Yes
                list(number).Content = Class1.screen(6)
                list(number).Background = Brushes.MistyRose
                list(number).Foreground = Brushes.Firebrick
            Case Screen.listmarkup.No
                list(number).Content = Class1.screen(7)
                list(number).Background = Brushes.PowderBlue
                list(number).Foreground = Brushes.RoyalBlue
            Case Screen.listmarkup.Abst
                list(number).Content = Class1.screen(8)
                list(number).Background = Brushes.Yellow
                list(number).Foreground = Brushes.DarkGoldenrod
            Case Screen.listmarkup.Empty
                list(number).Content = ""
                list(number).Background = Nothing
                list(number).Foreground = Brushes.Black
        End Select
        markups(number) = type
    End Sub

    Sub DeleteSingleListItme(i As Integer)
        Call SetListItme(i, "", False)
        Call SetListItmeMarkup(i, Screen.listmarkup.Empty)
    End Sub

    Sub DeleteSingleListItmeExt(i As Integer)
        Call SetListItmeExt(i, "", False)
        Call SetListItmeMarkupExt(i, Screen.listmarkup.Empty)
    End Sub

    Sub ClearList()
        For i = 1 To 60
            Call DeleteSingleListItmeExt(i)
        Next
    End Sub

    Sub SetPrompt(prompt As String)
        If prompt = "" Then
            txt_promptcontent.Text = Class1.screen(12)
        Else : txt_promptcontent.Text = prompt
        End If
    End Sub

    Sub SetMCTimerVisibility(visible As Boolean)
        If visible Then
            grid_totaltime.Visibility = Windows.Visibility.Visible
        Else
            grid_totaltime.Visibility = Windows.Visibility.Collapsed
        End If
    End Sub

    Sub SetNieuwsVisibility(visible As Boolean)
        If visible Then
            grid_nieuws.Visibility = Windows.Visibility.Visible
        Else
            grid_nieuws.Visibility = Windows.Visibility.Collapsed
        End If
    End Sub

    Sub SetAppBasicInfo(titel As String, versie As System.Version, releasedate As Date)
        lbl_apptitel.Content = titel
        lbl_mainversie.Content = Class1.screen(9) + versie.ToString
        lbl_releasedatum.Content = Class1.screen(10) + releasedate.ToString("d")
    End Sub

    Sub LoadTheme(titel As String)
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load("themes\" + titel + "\color.xml")
        Dim xnBase As XmlNode = xmlDoc.SelectSingleNode("color")
        Dim xeBase As XmlElement = CType(xnBase, XmlElement)
        Dim bg As String = "\" + xeBase.GetAttribute("bgimage")
        Dim xnColor1 As XmlNode = xnBase.FirstChild
        Dim xeColor1 As XmlElement = CType(xnColor1, XmlElement)
        ColortitleB = New SolidColorBrush(Color.FromArgb(xeColor1.GetAttribute("a"), xeColor1.GetAttribute("r"), xeColor1.GetAttribute("g"), xeColor1.GetAttribute("b")))
        Dim xnColor2 As XmlNode = xnBase.ChildNodes(1)
        Dim xeColor2 As XmlElement = CType(xnColor2, XmlElement)
        ColortitleF = New SolidColorBrush(Color.FromArgb(xeColor2.GetAttribute("a"), xeColor2.GetAttribute("r"), xeColor2.GetAttribute("g"), xeColor2.GetAttribute("b")))
        Dim xnColor3 As XmlNode = xnBase.ChildNodes(2)
        Dim xeColor3 As XmlElement = CType(xnColor3, XmlElement)
        ColortimebarB = New SolidColorBrush(Color.FromArgb(xeColor3.GetAttribute("a"), xeColor3.GetAttribute("r"), xeColor3.GetAttribute("g"), xeColor3.GetAttribute("b")))
        Dim xnColor4 As XmlNode = xnBase.ChildNodes(3)
        Dim xeColor4 As XmlElement = CType(xnColor4, XmlElement)
        ColortimebarF = New SolidColorBrush(Color.FromArgb(xeColor4.GetAttribute("a"), xeColor4.GetAttribute("r"), xeColor4.GetAttribute("g"), xeColor4.GetAttribute("b")))
        Dim xnColor5 As XmlNode = xnBase.ChildNodes(4)
        Dim xeColor5 As XmlElement = CType(xnColor5, XmlElement)
        ColorsideareaB = New SolidColorBrush(Color.FromArgb(xeColor5.GetAttribute("a"), xeColor5.GetAttribute("r"), xeColor5.GetAttribute("g"), xeColor5.GetAttribute("b")))
        Dim xnColor6 As XmlNode = xnBase.LastChild
        Dim xeColor6 As XmlElement = CType(xnColor6, XmlElement)
        ColorsideareaF = New SolidColorBrush(Color.FromArgb(xeColor6.GetAttribute("a"), xeColor6.GetAttribute("r"), xeColor6.GetAttribute("g"), xeColor6.GetAttribute("b")))
        bgimage = New ImageBrush()
        bgimage.ImageSource = New Imaging.BitmapImage(New Uri(My.Application.Info.DirectoryPath.ToString & "\themes\" & titel & bg))
        bgimage.Stretch = Stretch.UniformToFill
        grid_title.Background = ColortitleB
        lblconf.Foreground = ColortitleF
        lblopic.Foreground = ColortitleF
        lbltime.Background = ColortimebarB
        lbltime.Foreground = ColortimebarF
        panel_timerbase.Background = ColorsideareaB
        lbl_apptitel.Foreground = ColorsideareaF
        lbl_mainversie.Foreground = ColorsideareaF
        lbl_releasedatum.Foreground = ColorsideareaF
        lblpresent.Foreground = ColorsideareaF
        lblpresent1.Foreground = ColorsideareaF
        lbl50maj.Foreground = ColorsideareaF
        lbl50maj1.Foreground = ColorsideareaF
        lbl67maj.Foreground = ColorsideareaF
        lbl67maj1.Foreground = ColorsideareaF
        lbl20maj.Foreground = ColorsideareaF
        lbl20maj1.Foreground = ColorsideareaF
        lblmaohao.Foreground = ColorsideareaF
        lbltime_mm.Foreground = ColorsideareaF
        lbltime_ss.Foreground = ColorsideareaF
        Dim gradient1 As Color = ColorsideareaB.Color
        gradient1.A = 221
        Dim gradient2 As Color = ColorsideareaB.Color
        gradient2.A = 170
        Dim gradient As New LinearGradientBrush(gradient1, gradient2, 90)
        panel_prompt.Background = gradient
        If isNews Then
            grid_nieuws.Background = ColortimebarB
            lbl_cxxctr.Foreground = ColortimebarF
            lbl_nieuwstitel.Foreground = ColortimebarF
            lbl_nieuwscontent.Foreground = ColortimebarF
        Else
            lbl_cxxctr.Foreground = ColorsideareaF
            lbl_nieuwstitel.Foreground = ColorsideareaF
            lbl_nieuwscontent.Foreground = ColorsideareaF
        End If
        lbl_totaltime.Foreground = ColorsideareaF
        lbl_totaltime1.Foreground = ColorsideareaF
        lbl_prompt1.Foreground = ColorsideareaF
        txt_promptcontent.Foreground = ColorsideareaF
        screen_base.Background = bgimage
    End Sub

    Sub loadlang(lang1 As Integer)
        ScreenWorkingLanguange = lang1
        Call Class1.loadlang(lang1)
        lbl_cxxctr.Content = Class1.screen(2)
        txt_nieuwscontent.Text = Class1.screen(4)
        txt_nieuwstitel.Text = Class1.screen(3)
        lbl_prompt1.Content = Class1.screen(11)
        txt_promptcontent.Text = Class1.screen(12)
        lblt_totaltime.Text = Class1.screen(13)
        txtpresents1.Text = Class1.screen(14)
        txt50maj1.Text = Class1.screen(15)
        txt67maj1.Text = Class1.screen(16)
    End Sub

    Sub SetPage(cur As Integer, tot As Integer)
        lbl_nations_pagenummer.Content = Class1.screen(17) + cur.ToString + Class1.screen(18) + tot.ToString
    End Sub

    Sub SetFile(path As String)
        fileview.Source = New Uri(path)
    End Sub
End Class
