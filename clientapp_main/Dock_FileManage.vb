Imports StandardConfData
Imports StandardConfData.MyInfo

Public Class Dock_FileManage
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

    Public Shared Sub Clickvote()
        Call Dock_FileManage.ToolStripButton2_Click(Dock_FileManage.对文件投票VToolStripMenuItem, EventArgs.Empty)
    End Sub

    Private Sub Dock_FileManage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        For Each i In Form1.nFileList
            ListBox1.Items.Add(i.ToString)
        Next
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click, ToolStripButton1.Click, 介绍文件IToolStripMenuItem.Click, 对文件投票VToolStripMenuItem.Click, 文件属性RToolStripMenuItem.Click
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("请选择文件！", 48, "文件管理器")
        Else
            If sender.Equals(对文件投票VToolStripMenuItem) Then
                'Vote.GetFilename()
                Dock_NationList.BringToFront()
                Vote.ShowDialog()
            ElseIf sender.Equals(ToolStripButton3) Then
                Dim FileViewForm As New Dock_FileView
                FileViewForm.WebBrowser1.Url = New Uri(Form1.lastPath + "media\" + Form1.nFileList(ListBox1.SelectedIndex).FilePath)
                FileViewForm.Text = ListBox1.SelectedItem.ToString
                Form1.OpenFileView(FileViewForm)
            ElseIf sender.Equals(ToolStripButton1) Then
                Form2.UserControl11.SetTextVisibility(False)
                Form2.UserControl11.SetFileVisibility(True)
                Form2.UserControl11.HideList()
                Form2.UserControl11.SetFile(Form1.lastPath + "media\" + Form1.nFileList(ListBox1.SelectedIndex).FilePath)
                Form2.UserControl11.SetPrompt(Form1.txthcmotion)
            ElseIf sender.Equals(介绍文件IToolStripMenuItem) Then
                Dialog_FileIntro.Text = $"介绍{ListBox1.SelectedItem}"
                Dialog_FileIntro.CheckedListBox1.Items.Clear()
                For Each n As Nation In Form1.nFileList(ListBox1.SelectedIndex).Sponsers
                    Dialog_FileIntro.CheckedListBox1.Items.Add(n.Name)
                Next
                Dialog_FileIntro.ShowDialog()
                If Dialog_FileIntro.DialogResult = DialogResult.OK Then
                    Dim taima As Integer = Dialog_FileIntro.num_file.Value
                    Dim filename As String = Form1.nFileList(ListBox1.SelectedIndex).FileTitle
                    Dim nations As String = ""
                    For Each n In Dialog_FileIntro.CheckedListBox1.CheckedItems
                        nations += n + LanguageScript.Language1.infoString(15)
                    Next
                    nations = nations.Substring(0, nations.Length - LanguageScript.Language1.infoString(15).Length)
                    Dim txthcmotion As String
                    If Form1.LoadedConference.language = 1 Then
                        txthcmotion = "介绍" + filename
                        If nations <> "" Then txthcmotion = txthcmotion + vbCrLf + "参与介绍的国家: " + nations
                        txthcmotion = txthcmotion + vbCrLf + "介绍时间:" + Str(Dialog_FileIntro.num_file.Value) + "分钟"
                    Else
                        txthcmotion = "Introduce " + filename
                        If nations <> "" Then txthcmotion = txthcmotion + vbCrLf + "Nations: " + nations
                        txthcmotion = txthcmotion + vbCrLf + "Time of introduction:" + Str(Dialog_FileIntro.num_file.Value) + " minutes"
                    End If
                    Form1.txthcmotion = txthcmotion
                    Form2.UserControl11.SetPrompt(txthcmotion)
                    Call Form2.ChangeStatus(Dock_NationList.rolled, AppStatus.FileView)
                    Dock_Timer.timingStatus = "FS"
                    Call Dock_Timer.file_start(taima)
                    Form2.UserControl11.SetFile(Form1.lastPath + "media\" + filename + ".html")
                End If
            End If
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Form2.ChangeStatus(Dock_NationList.rolled, Form2.MyStatus, False)
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        Form1.添加新文件NToolStripMenuItem_Click(sender, EventArgs.Empty)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex = -1 Then
            Label1.Text = "未选定任何文件"
            Label2.Text = "选定一项文件以查看信息。"
        Else
            Dim getdate As New System.IO.FileInfo(Form1.lastPath + "media\" + Form1.nFileList(ListBox1.SelectedIndex).FilePath)
            Label1.Text = Form1.nFileList(ListBox1.SelectedIndex).ToString
            Label2.Text = "文件类型: " + LanguageScript.Language1.fileString(Form1.nFileList(ListBox1.SelectedIndex).Category)
            If Not Form1.nFileList(ListBox1.SelectedIndex).Sponsers.Count = 0 Then Label2.Text += vbCrLf + "起草国: " + Form1.nFileList(ListBox1.SelectedIndex).Sponsers.ToString(LanguageScript.Language1.infoString(15))
            If Not Form1.nFileList(ListBox1.SelectedIndex).Signatories.Count = 0 Then Label2.Text += vbCrLf + "附议国: " + Form1.nFileList(ListBox1.SelectedIndex).Signatories.ToString(LanguageScript.Language1.infoString(15))
            Label2.Text += vbCrLf + "创建时间: " + getdate.CreationTime.ToString
        End If
    End Sub
End Class