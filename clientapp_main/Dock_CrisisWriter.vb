Imports System.Xml

Public Class Dock_CrisisWriter
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

    Function WriteHTML(filepath As String, title As String, text As String) As Boolean
        WriteHTML = False
        Try
            Dim paragraph() As String = text.Split(New [Char]() {vbCr, vbLf})
            Dim myTW As New XmlTextWriter(filepath, Nothing)
            myTW.WriteStartDocument()
            myTW.Formatting = Formatting.Indented
            myTW.WriteStartElement("html")  '<html>
            myTW.WriteStartElement("head")  '<head>
            myTW.WriteStartElement("meta")  '<meta 
            myTW.WriteAttributeString("http-equiv", "Content-Type")
            myTW.WriteAttributeString("content", "text/html; charset=utf-8")
            myTW.WriteEndElement()  '/>
            myTW.WriteElementString("title", title)  '<title>title</title>
            myTW.WriteEndElement()  '</head>
            myTW.WriteStartElement("body") '<body>
            myTW.WriteStartElement("font") '<font 
            myTW.WriteAttributeString("face", "Arial, Segoe UI, Microsoft Yahei UI, 微软雅黑") 'face="Arial, 微软雅黑" 
            myTW.WriteAttributeString("size", 5) 'size="5">
            myTW.WriteElementString("h1", title) '<h1>title1标题</h1>
            myTW.WriteStartElement("hr")  '<hr
            myTW.WriteAttributeString("size", 1) 'size="1"
            myTW.WriteEndElement()  '/>
            For Each para As String In paragraph
                myTW.WriteElementString("p", para)  '<p>text</p>
            Next
            myTW.WriteEndElement()  '</font>
            myTW.WriteStartElement("font") '<font 
            myTW.WriteAttributeString("face", "Arial") 'face="Arial, 微软雅黑" 
            myTW.WriteAttributeString("size", 2)
            myTW.WriteAttributeString("color", "lightgray")
            myTW.WriteElementString("p", "Powered by Easychair Crisis Writer")  '<p>text</p>
            myTW.WriteEndElement()  '</font>
            myTW.WriteEndElement()
            myTW.WriteEndElement()
            myTW.WriteEndDocument()
            myTW.Close()
            WriteHTML = True
        Catch ex As Exception
            WriteHTML = False
        End Try
    End Function

    Private Sub Dock_CrisisWriter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function cut(length) As Integer
        cut = length
        If length > 15 Then
            cut = 15
        End If
    End Function

    Public Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        If TextBox1.Text = "" Then TextBox1.Text = "(无标题)"
        If TextBox2.Text = "" Then
            MessageBox.Show("请填写正文！", "危机编写器", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If ToolStripTextBox1.Text = "" Then ToolStripTextBox1.Text = $"Crisis_{Date.Today.ToString("MMdd")}_{TimeOfDay.ToString("hhmmss")}_{TextBox1.Text.Substring(0, cut(TextBox1.Text.Length))}"
        Dim filename As String = ToolStripTextBox1.Text + ".html"
        If sender.Equals("other") Then
            NewCrisis.GetFilePath(filename)
        End If
        If WriteHTML(Form1.lastPath + "media\" + filename, TextBox1.Text, TextBox2.Text) = True Then
            If sender.Equals(SaveToolStripButton) Then MessageBox.Show("成功保存至" + vbCrLf + Form1.lastPath + "media\" + filename, "危机编写器", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ToolStripTextBox1.Text = ""
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If TextBox1.Text = "" Then TextBox1.Text = "(无标题)"
        If TextBox2.Text = "" Then
            MessageBox.Show("请填写正文！", "危机编写器", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            NewCrisis.RadioButton3.Checked = True
            NewCrisis.ShowDialog()
            If NewCrisis.DialogResult = Windows.Forms.DialogResult.OK Then Call Form1.Crisisstart()
        End If
    End Sub
End Class