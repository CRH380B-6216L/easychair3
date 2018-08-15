Imports System.Text.RegularExpressions

Public Class Dock_PressCentre
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent
    Dim r As New Regex("^https?://.*/.*$")

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If ToolStripTextBox1.Text = "" Then
            MessageBox.Show("请输入服务端地址！"， "局势中心", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf Not r.IsMatch(ToolStripTextBox1.Text) Then
            MessageBox.Show("无效的URL！"， "局势中心", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Form1.CLclient Is Nothing Then
            Try
                Form1.CLclient = New Console_link.LinkClient(ToolStripTextBox1.Text)
                AddHandler Form1.CLclient.DataRenewed, AddressOf NewMsgArrives
                ToolStripButton1.Text = "断开(&D)"
                ToolStripTextBox1.Visible = False
                ToolStripSeparator1.Visible = True
                ToolStripButton2.Visible = True
                ToolStripButton3.Visible = True
            Catch ex As Exception
                MessageBox.Show("无法连接到局势中心！"， "局势中心", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        Else
            RemoveHandler Form1.CLclient.DataRenewed, AddressOf NewMsgArrives
            Form1.CLclient = Nothing
            ToolStripButton1.Text = "连接(&C)..."
            ToolStripTextBox1.Visible = True
            ToolStripSeparator1.Visible = False
            ToolStripButton2.Visible = False
            ToolStripButton3.Visible = False
        End If
    End Sub

    Private Sub NewMsgArrives()
        'MessageBox.Show("233333！"， "局势中心", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim sound As New SoundControl.Class1
        sound.playSfx(4)
        Form2.UserControl11.SetNews(1, Form1.CLclient.GetContent, Form1.CLclient.GetTitle)
    End Sub

    Private Sub remove() Handles ToolStripButton3.Click
        Form2.UserControl11.ClearNews()
    End Sub
End Class