Imports StandardConfData

Public Class Dock_NationDetail

    Inherits WeifenLuo.WinFormsUI.Docking.DockContent
    Dim Editing As Boolean

    Sub LoadNationDetail()
        For Each i In Form1.nNationList
            Dim itme As New ListViewItem
            itme.Checked = i.Attendence
            itme.SubItems(0).Text = i.Name
            itme.SubItems.Add(i.GetCompetence)
            itme.SubItems.Add(i.GetDelegateNames(LanguageScript.Language1.infoString(15)))
            itme.SubItems.Add(i.SchoolDelegates)
            itme.SubItems.Add(i.PresentationPaper)
            ListView1.Items.Add(itme)
        Next
    End Sub

    Sub DisplaySingleNation(index As Integer)
        Dim i As MyInfo.Nation = Form1.nNationList(index)
        CheckBox1.Checked = i.Attendence
        TextBox0.Text = i.Name
        TextBox2.Text = i.GetDelegateNames(LanguageScript.Language1.infoString(15))
        TextBox3.Text = i.SchoolDelegates
        TextBox4.Text = i.PresentationPaper
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If Not ListView1.SelectedIndices.Count = 0 Then
            Dim index As Integer = ListView1.SelectedIndices(0)
            Editing = True
            ToolStripTextBox1.Text = (index + 1).ToString
            'TextBox0.Text = ListView1.Items(index).SubItems(0).Text
        End If
    End Sub

    Private Sub Dock_NationDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadNationDetail()
        ToolStripLabel2.Text = "/" + ListView1.Items.Count.ToString
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Editing = True
        ToolStripTextBox1.Text = (Val(ToolStripTextBox1.Text) - 1).ToString
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Editing = True
        ToolStripTextBox1.Text = 1.ToString
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Editing = True
        ToolStripTextBox1.Text = (Val(ToolStripTextBox1.Text) + 1).ToString
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Editing = True
        ToolStripTextBox1.Text = ListView1.Items.Count.ToString
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        'Call TextBox0_TextChanged(sender, EventArgs.Empty)
        'Editing = False
        If ToolStripTextBox1.Text = 1 Then
            ToolStripButton1.Enabled = False
            ToolStripButton2.Enabled = False
            ToolStripButton3.Enabled = True
            ToolStripButton4.Enabled = True
        ElseIf ToolStripTextBox1.Text = ListView1.Items.Count.ToString Then
            ToolStripButton3.Enabled = False
            ToolStripButton4.Enabled = False
            ToolStripButton1.Enabled = True
            ToolStripButton2.Enabled = True
        Else
            ToolStripButton1.Enabled = True
            ToolStripButton2.Enabled = True
            ToolStripButton3.Enabled = True
            ToolStripButton4.Enabled = True
        End If
        Dim index As Integer = Val(ToolStripTextBox1.Text) - 1
        Call DisplaySingleNation(index)
        If Editing Then
            If ListView1.Items(index).SubItems(0).Text.StartsWith("*") Then
                tsbsave.Enabled = True
                tsbrevert.Enabled = True
            Else
                tsbsave.Enabled = False
                tsbrevert.Enabled = False
            End If
            If TextBox0.Focused Or TextBox3.Focused Then
            Else
                Editing = False
            End If
        End If
    End Sub

    Private Sub jaekglf(sender As Object, e As EventArgs) Handles TextBox0.GotFocus, TextBox3.GotFocus, NumericUpDown1.GotFocus, CheckBox1.Click, ListView1.MouseEnter
        Editing = True
    End Sub

    Private Sub jaekgl1f(sender As Object, e As EventArgs) Handles TextBox0.Leave, TextBox3.Leave, NumericUpDown1.Leave, ListView1.MouseLeave
        Editing = False
    End Sub

    Private Sub TextBox0_TextChanged(sender As Object, e As EventArgs) Handles TextBox0.TextChanged, TextBox3.TextChanged
        If Editing Then
            Dim index As Integer = Val(ToolStripTextBox1.Text) - 1
            Dim changed As Boolean
            If sender.Equals(TextBox3) Then
                If Not TextBox3.Text = Form1.nNationList(index).SchoolDelegates Then
                    ListView1.Items(index).SubItems(3).Text = TextBox3.Text
                    Form1.nNationList(index).SchoolDelegates = TextBox3.Text
                    changed = True
                End If
            End If
            If sender.Equals(TextBox0) Then
                If Not TextBox0.Text = Form1.nNationList(index).Name Then
                    Form1.nNationList(index).Name = TextBox0.Text
                    changed = True
                End If
            End If
            If changed Then
                ListView1.Items(index).SubItems(0).Text = "*" + TextBox0.Text
                tsbsave.Enabled = True
                tsbsaveall.Enabled = True
                tsbrevert.Enabled = True
            End If
        End If
    End Sub

    Private Sub Tdthbgyjged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If Editing Then
            Dim index As Integer = Val(ToolStripTextBox1.Text) - 1
            ListView1.Items(index).SubItems(1).Text = NumericUpDown1.Value.ToString
            Form1.nNationList(index).Competence = NumericUpDown1.Value
            ListView1.Items(index).SubItems(0).Text = "*" + TextBox0.Text
            tsbsave.Enabled = True
            tsbsaveall.Enabled = True
            tsbrevert.Enabled = True
        End If
    End Sub

    Private Sub tsbsave_Click(sender As Object, e As EventArgs) Handles tsbsave.Click
        Dim index As Integer = Val(ToolStripTextBox1.Text) - 1
        'Form1.NationList(index).Name = TextBox0.Text
        'Form1.NationList(index).Competence = NumericUpDown1.Value
        'Form1.NationList(index).SchoolDelegates = TextBox3.Text
        xmlsaveload.ModifyNation(index, Form1.nNationList(index))
        ListView1.Items(index).SubItems(0).Text = TextBox0.Text
        tsbsave.Enabled = False
        tsbrevert.Enabled = False
        If CheckUnsaved() = 0 Then
            tsbsaveall.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckStateChanged
        If Editing Then
            Dim index As Integer = Val(ToolStripTextBox1.Text) - 1
            Form1.nNationList(index).Attendence = CheckBox1.Checked
            ListView1.Items(index).Checked = CheckBox1.Checked
            Dock_NationList.clb_nation_main.SetItemChecked(index, CheckBox1.Checked)
        End If
    End Sub

    Private Sub ggg(sender As Object, e As ItemCheckedEventArgs) Handles ListView1.ItemChecked
        If Editing Then
            Form1.nNationList(e.Item.Index).Attendence = e.Item.Checked
            Call ChangeItemChecked(e.Item.Index, e.Item.Checked)
        End If
    End Sub

    Sub ChangeItemChecked(e As Integer, checked As Boolean)
        Dock_NationList.clb_nation_main.SetItemChecked(e, checked)
        ListView1.Items(e).Checked = checked
        If e = Val(ToolStripTextBox1.Text) - 1 Then CheckBox1.Checked = checked
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SetDelegate.TextBox1.Text = TextBox2.Text.Replace(LanguageScript.Language1.infoString(15), vbCrLf)
        SetDelegate.ShowDialog()
        If SetDelegate.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim index As Integer = Val(ToolStripTextBox1.Text) - 1
            Dim i = Form1.nNationList(index)
            i.SetDelegateFromMultiLineText(SetDelegate.TextBox1.Text)
            ListView1.Items(index).SubItems(2).Text = i.GetDelegateNames(LanguageScript.Language1.infoString(15))
            TextBox2.Text = i.GetDelegateNames(LanguageScript.Language1.infoString(15))
            ListView1.Items(index).SubItems(0).Text = "*" + TextBox0.Text
            tsbsave.Enabled = True
            tsbsaveall.Enabled = True
            tsbrevert.Enabled = True
            SetDelegate.TextBox1.Text = ""
        End If
    End Sub

    Function CheckUnsaved() As Integer
        CheckUnsaved = 0
        For Each i As ListViewItem In ListView1.Items
            If i.SubItems(0).Text.StartsWith("*") Then CheckUnsaved += 1
        Next
    End Function

    Private Sub tsbsaveall_Click(sender As Object, e As EventArgs) Handles tsbsaveall.Click
        For i = 1 To ListView1.Items.Count
            Dim index = i - 1
            If ListView1.Items(index).SubItems(0).Text.StartsWith("*") Then
                xmlsaveload.ModifyNation(index, Form1.nNationList(index))
                ListView1.Items(index).SubItems(0).Text = Form1.nNationList(index).Name
            End If
        Next
        tsbsave.Enabled = False
        tsbrevert.Enabled = False
        tsbsaveall.Enabled = False
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub
End Class