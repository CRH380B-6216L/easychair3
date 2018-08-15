Public Class Dock_MainScreen
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

    Private Sub Dock_MainScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Me.MdiParent = Form1
    End Sub

    Private Sub lblmain_TextChanged(sender As Object, e As EventArgs) Handles lblmain.TextChanged
        Form2.UserControl11.subchangemaintext(lblmain.Text)
    End Sub

    Private Sub 清除内容CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        lblmain.Text = ""
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

    End Sub
End Class