Imports System.Windows.Forms
Imports LanguageScript.Language1
Imports StandardConfData

Public Class NewFile
    Dim MyFileName As String
    Dim sponsors As New MyInfo.NationList
    Dim signatories As New MyInfo.NationList

    Function isvalidreq() As Boolean
        isvalidreq = False
        If cbx_ftpye.Text <> "" And txt_filenumber_2.Text <> "" And lbl_filepath.Text <> "" Then isvalidreq = True
    End Function

    Function filename() As String
        filename = TextBox1.Text + txt_filenumber_1.Text + "." + txt_filenumber_2.Text
        If cbx_ftpye.SelectedIndex = MyInfo.Files.Amendment Then
            filename = filename + "." + txt_filenumber_3.Text
        End If
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If isvalidreq() Then
            MyFileName = filename()
            Dim fileconvert As New DocConverter.Dialog1
            fileconvert.start(lbl_filepath.Text, Form1.lastPath + "media\" + MyFileName + ".html")
            fileconvert.ShowDialog()
            Dim newfile1 As New MyInfo.File(MyFileName, MyFileName + ".html", cbx_ftpye.SelectedIndex, sponsors, signatories)
            Form1.nFileList.Add(newfile1)
            xmlsaveload.AddFile2(newfile1)
            xmlsaveload.CreateRecord(Form1.recIndex, "FI")
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
            'Invoke(New EventHandler(AddressOf BackgroundWorker1.RunWorkerAsync))
            'If DocConverter.Dialog1.ConvertFileWordToHtml(lbl_filepath.Text, Form1.lastPath + "media\" + filename() + ".html") = True Then
            '    xmlsaveload.AddFile(filename, filename() + ".html", cbx_ftpye.SelectedIndex)
            '    xmlsaveload.CreateRecord(Form1.recIndex, "FI")
            '    Me.DialogResult = System.Windows.Forms.DialogResult.OK
            '    Me.Close()
            'End If
        End If
        'Dialog1.start(lbl_filepath.Text, Form1.lastPath + "media\" + filename() + ".html")
        'Dialog1.ShowDialog()

        'htmlpath = My.Application.Info.DirectoryPath + "\html\" + htmlpath
        'If Dialog1.DialogResult = Windows.Forms.DialogResult.OK Then
        'ElseIf Dialog1.DialogResult = Windows.Forms.DialogResult.Abort Then
        '    Exit Sub
        'End If
        'End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cbx_ftpye_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_ftpye.SelectedIndexChanged
        If cbx_ftpye.SelectedIndex = 2 Then
            txt_filenumber_3.Visible = 1
            Label103.Text = ".　　."
        Else
            txt_filenumber_3.Visible = 0
            Label103.Text = "."
        End If
        TextBox1.Text = fileString(cbx_ftpye.SelectedIndex)
        txt_filenumber_1.Text = Form1.session
        txt_filenumber_2.Focus()
    End Sub

    Private Sub btn_file_browse_Click(sender As Object, e As EventArgs) Handles btn_file_browse.Click
        ofd_doc.Title = "选择文档"
        ofd_doc.Filter = "Microsoft Word Document (*.doc;*.docx)|*.doc;*.docx"
        If ofd_doc.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            lbl_filepath.Text = ofd_doc.FileName
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'Me.Enabled = False
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Dialog1.Close()
        'Me.Enabled = True
        If Not (e.Error Is Nothing) Then
            MessageBox.Show(e.Error.Message)
        ElseIf e.Cancelled Then
            ' Next, handle the case where the user canceled the 
            ' operation.
            ' Note that due to a race condition in 
            ' the DoWork event handler, the Cancelled
            ' flag may not have been set, even though
            ' CancelAsync was called.
            ' resultLabel.Text = "Canceled"
        Else
            ' Finally, handle the case where the operation succeeded.
            ' resultLabel.Text = e.Result.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectie As New SelectSponsors
        sponsors.Clear()
        signatories.Clear()
        If cbx_ftpye.SelectedIndex = 1 Then selectie.IsSignatories = True Else selectie.IsSignatories = False
        For Each n As MyInfo.Nation In Form1.nNationList
            selectie.ListBox3.Items.Add(n.ToString)
        Next
        selectie.ShowDialog()
        If selectie.DialogResult = DialogResult.OK Then
            If selectie.ListBox1.Items.Count > 0 Then
                For Each i In selectie.ListBox1.Items
                    sponsors.Add(Form1.nNationList.GetNationFromName(i.ToString))
                Next
                txt_file_sponsors.Text = sponsors.ToString(infoString(15))
            End If
            If selectie.ListBox2.Items.Count > 0 Then
                For Each i In selectie.ListBox2.Items
                    signatories.Add(Form1.nNationList.GetNationFromName(i.ToString))
                Next
                txt_file_signatories.Text = signatories.ToString(infoString(15))
            End If
        End If
    End Sub
End Class
