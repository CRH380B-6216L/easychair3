Imports System.Windows.Forms
Imports StandardConfData

Public Class NewCrisis
    Public FilePath1 As String
    Public filename123 As String
    Public time As Integer

    Function GetFilePath(filepath) As String
        FilePath1 = filepath
        GetFilePath = filepath
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If RadioButton1.Checked Then
            filename123 = ComboBox1.SelectedItem.ToString
            Dim newfile2 As New MyInfo.File(filename123, filename123, 4, New MyInfo.NationList, New MyInfo.NationList)
            Form1.nFileList.Add(newfile2)
            xmlsaveload.AddFile2(newfile2)
        ElseIf RadioButton2.Checked Then
            Dim filename As String = My.Computer.FileSystem.GetFileInfo(lbl_filepath.Text).Name
            Dim newcriis As New DocConverter.Dialog1
            newcriis.start(lbl_filepath.Text, Form1.lastPath + "media\" + filename + ".html")
            newcriis.ShowDialog()
            'If DocConverter.Dialog1.ConvertFileWordToHtml(lbl_filepath.Text, Form1.lastPath + "media\" + filename + ".html") = True Then
            filename123 = filename
            Dim newfile1 As New MyInfo.File(filename123, filename + ".html", 4, New MyInfo.NationList, New MyInfo.NationList)
            Form1.nFileList.Add(newfile1)
            xmlsaveload.AddFile2(newfile1)
            filename123 = filename + ".html"
            'xmlsaveload.CreateRecord(Form1.recIndex, "CR")
            'Dim sound1 As New SoundControl.Class1
            'sound1.playSfx(4)
            'Me.DialogResult = System.Windows.Forms.DialogResult.OK
            'Me.Close()
            '    Exit Sub
            'Else : Exit Sub
            'End If
        Else
            Dock_CrisisWriter.SaveToolStripButton_Click("other", EventArgs.Empty)
            filename123 = FilePath1
            Dim newfile2 As New MyInfo.File(filename123, filename123, 4, New MyInfo.NationList, New MyInfo.NationList)
            Form1.nFileList.Add(newfile2)
            xmlsaveload.AddFile2(newfile2)
        End If
        xmlsaveload.CreateRecord(Form1.recIndex, "CR")
        Dim sound As New SoundControl.Class1
        sound.playSfx(4)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, CheckBox1.CheckedChanged, num_crisis.ValueChanged
        ComboBox1.Enabled = RadioButton1.Checked
        btn_file_browse.Enabled = RadioButton2.Checked
        num_crisis.Enabled = CheckBox1.Checked
        If CheckBox1.Checked Then
            time = num_crisis.Value
        Else : time = 0
        End If
    End Sub

    Private Sub NewCrisis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        If Dock_CrisisWriter.TextBox2.Text = "" Then RadioButton3.Enabled = False
        If sender.Equals(Dock_CrisisWriter.ToolStripButton1) Then
            RadioButton3.Checked = True
            RadioButton3.Enabled = True
        End If
        Try
            ComboBox1.Items.Clear()
            For Each loaded In System.IO.Directory.GetFiles(Form1.lastPath + "media")
                ComboBox1.Items.Add(System.IO.Path.GetFileName(loaded))
            Next
            ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1
        Catch ex As Exception
            RadioButton1.Enabled = False
        End Try
    End Sub

    Private Sub btn_file_browse_Click(sender As Object, e As EventArgs) Handles btn_file_browse.Click
        ofd_doc.Title = "选择文档"
        ofd_doc.Filter = "Microsoft Word Document (*.doc;*.docx)|*.doc;*.docx"
        If ofd_doc.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            lbl_filepath.Text = ofd_doc.FileName
        End If
    End Sub
End Class
