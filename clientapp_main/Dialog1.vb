Imports System.Windows.Forms

Public Class Dialog1
    Public Shared filepath, savepath As String
    Dim succeed As Boolean

    Public Shared Sub start(sourse As String, target As String)
        Dim dialog1 As New Dialog1
        dialog1.filepath = sourse
        dialog1.savepath = target
        'dialog1.ShowDialog()
    End Sub

    Sub ConvertFileWordToHtml(WordFilePath As String, SaveHtmlPath As String)
        Dim source As Object = WordFilePath
        Dim target As Object = SaveHtmlPath

        Dim unknown As Object = Type.Missing
        Dim isReadonly As Object = True
        Dim isVisible As Object = False

        'Problem starts
        Dim newApp As Microsoft.Office.Interop.Word.Application = New Microsoft.Office.Interop.Word.Application()
        Dim doc As Microsoft.Office.Interop.Word.Document = newApp.Documents.Open(source, unknown, isReadonly, unknown, unknown, unknown, unknown, unknown, unknown, unknown, unknown, isVisible, unknown, unknown, unknown, unknown)

        Dim docType As Type = doc.GetType
        Dim format As Object = Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatHTML

        doc.SaveAs2(target, format)
        doc.Close(unknown, unknown, unknown)
        newApp.Quit(unknown, unknown, unknown)
        'My.Computer.FileSystem.MoveFile(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\" + SaveHtmlPath, My.Application.Info.DirectoryPath + "\html\" + SaveHtmlPath, True)

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Me.Cursor = Cursors.AppStarting
        Call ConvertFileWordToHtml(filepath, savepath)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If Not (e.Error Is Nothing) Then
            'MessageBox.Show(e.Error.Message)
            succeed = False
        ElseIf e.Cancelled Then
            ' Next, handle the case where the user canceled the 
            ' operation.
            ' Note that due to a race condition in 
            ' the DoWork event handler, the Cancelled
            ' flag may not have been set, even though
            ' CancelAsync was called.
            ' resultLabel.Text = "Canceled"
            succeed = False
        Else
            ' Finally, handle the case where the operation succeeded.
            ' resultLabel.Text = e.Result.ToString()
            succeed = True
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'i = i + 1
        'If i = 10 Then Invoke(New EventHandler(AddressOf BackgroundWorker1.RunWorkerAsync))
        'BackgroundWorker1.CancelAsync()
        If System.IO.File.Exists(savepath) Then
            Timer2.Enabled = False
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BackgroundWorker1.RunWorkerAsync()
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub
End Class