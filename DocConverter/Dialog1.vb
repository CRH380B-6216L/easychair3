Imports System.IO
Imports System.Windows.Forms
Imports Mammoth

Public Class Dialog1
    Public Shared filepath, savepath As String
    Dim succeed As Boolean

    Public Sub start(sourse As String, target As String)
        Dim dialog1 As New Dialog1
        Dialog1.filepath = sourse
        Dialog1.savepath = target
        'dialog1.ShowDialog()
    End Sub

    Sub ConvertFileWordToHtml(WordFilePath As String, SaveHtmlPath As String)
        Dim source As Object = WordFilePath
        Dim target As Object = SaveHtmlPath

        Dim Converter As New DocumentConverter()
        Dim result = Converter.ConvertToHtml(WordFilePath)

        Dim saveDoc As New StreamWriter(SaveHtmlPath)
        saveDoc.WriteLine($"<html><head><meta charset={Chr(34)}utf-8{Chr(34)}/></head><body>")
        saveDoc.WriteLine(result.Value)
        saveDoc.WriteLine("</body></html>")
        saveDoc.Close()
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