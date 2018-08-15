Public Class Dock_FileView
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent
    Public path As String

    Public Shared Sub SetPath(path As String)
        Dock_FileView.WebBrowser1.Url = New Uri(Form1.lastPath + "media\" + path)
    End Sub
End Class