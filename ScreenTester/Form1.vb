Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Form2.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Form2.WindowState = FormWindowState.Maximized
        Form2.Show()
        For Each loaded In System.IO.Directory.GetDirectories("themes")
            ComboBox3.Items.Add(System.IO.Path.GetFileName(loaded))
        Next
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        Dim lang2 As Integer = InputBox("language (1 or 2)")
        Form2.UserControl11.loadlang(lang2)
        Dim daterel As Date = My.Computer.FileSystem.GetFileInfo("ScreenTester.exe").LastWriteTime
        Form2.UserControl11.SetAppBasicInfo(My.Application.Info.Title, My.Application.Info.Version, daterel)
        Form2.UserControl11.LoadTheme("(Default)")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.UserControl11.subLoadMain()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.UserControl11.subunloadmain()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.UserControl11.subchangemaintext(TextBox1.Text)
        TextBox1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim conference As String = InputBox("left")
        Dim committee As String = InputBox("right")
        Form2.UserControl11.subchangetitle(conference, committee)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Form2.UserControl11.SetBookmarkMode(ComboBox1.SelectedIndex + 1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form2.UserControl11.SetTime(Date.Today, TimeOfDay)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim p As Integer = InputBox("presents")
        Form2.UserControl11.SetPresents(p)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim k As Integer = InputBox("time(s)")
        Form2.UserControl11.SetTimeCount(k, True)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form2.UserControl11.ClearNews()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form2.UserControl11.SetNews(1, TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Form2.UserControl11.ListExtention = CheckBox2.Checked
        'Form2.UserControl11.ListExtSetting()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Form2.UserControl11.ListExtention = CheckBox2.Checked
            CheckBox2.Enabled = False
            Form2.UserControl11.ShowList()
        Else
            Form2.UserControl11.HideList()
            CheckBox2.Enabled = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        Form2.UserControl11.SetTextVisibility(CheckBox3.Checked)
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        Form2.UserControl11.SetFileVisibility(CheckBox4.Checked)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If CheckBox2.Checked Then
            Form2.UserControl11.SetListItmeExt(NumericUpDown1.Value, TextBox3.Text, CheckBox5.Checked)
            Form2.UserControl11.SetListItmeMarkupExt(NumericUpDown1.Value, ComboBox2.SelectedIndex)
        Else
            Form2.UserControl11.SetListItme(NumericUpDown1.Value, TextBox3.Text, CheckBox5.Checked)
            Form2.UserControl11.SetListItmeMarkup(NumericUpDown1.Value, ComboBox2.SelectedIndex)
        End If
        ComboBox2.SelectedIndex = 0
        TextBox3.Text = ""
        CheckBox5.Checked = False
        NumericUpDown1.Value = NumericUpDown1.Value + 1
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.UserControl11.SetPrompt(TextBox1.Text)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim k As Integer = InputBox("time(s)")
        Form2.UserControl11.SetMCTimeCount(k)
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        Form2.UserControl11.SetMCTimerVisibility(CheckBox6.Checked)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Form2.UserControl11.LoadTheme(ComboBox3.SelectedItem.ToString)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim cur As Integer = InputBox("current")
        Dim tot As Integer = InputBox("total")
        Form2.UserControl11.SetPage(cur, tot)
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        Form2.UserControl11.UseMarkup = CheckBox7.Checked
    End Sub
End Class
