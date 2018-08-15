Imports System.Windows.Media
Imports System.Windows

Public Class ScreenControl
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
            UserControl.SetBookmarkMode(value)
        End Set
    End Property

    Public Property UserControl As UserControl1

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

    Public Property UseMarkup As Boolean
        Get
            Return UseMarkup
        End Get
        Set(value As Boolean)
            UserControl.SetMarkup(value)
            isUsingMarkup = value
        End Set
    End Property

    Public Property ListExtraColumn As Boolean
        Get
            Return isListExtraColumn
        End Get
        Set(value As Boolean)
            UserControl.SetListExtraColomn(value)
            isListExtraColumn = value
        End Set
    End Property

    Public Property ListExtention As Boolean
        Get
            Return isListExtention
        End Get
        Set(value As Boolean)
            If value Then
                UserControl.grid_list_extention.Visibility = Visibility.Visible
                If ListExtraColumn Then UserControl.grid_list_wide_ext.Visibility = Visibility.Visible
            Else
                UserControl.grid_list_extention.Visibility = Visibility.Collapsed
                UserControl.grid_list_wide_ext.Visibility = Visibility.Collapsed
            End If
            isListExtention = value
        End Set
    End Property

    Public Delegate Sub BookmarkHandler(sender As ScreenControl, bkmk As bookmarkmode)
    Public Event SetBookmark As BookmarkHandler
End Class
