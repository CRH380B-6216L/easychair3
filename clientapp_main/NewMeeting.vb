Imports System.Windows.Forms

Public Class NewMeeting
    Function validate1() As String
        validate1 = 0
        Dim txtvalidate() As TextBox = New TextBox() {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5}
        For d = 0 To 4
            If txtvalidate(d).Text = "" Then
                If d = 3 Then
                    CheckBox1.Checked = False
                Else
                    validate1 = validate1 + 1
                    txtvalidate(d).BackColor = Color.Yellow
                End If
            End If
        Next
        If ListBox1.Items.Count = 0 Then
            validate1 = validate1 + 1
            ListBox1.BackColor = Color.Yellow
        End If
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If validate1() = 0 Then

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else

        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If Not TextBox6.Text = "" Then
            For i = 0 To TextBox6.Lines().Length - 1
                ListBox1.Items.Add(TextBox6.Lines(i))
            Next
            TextBox6.Clear()
            ListBox1.BackColor = Color.White
        End If
        Dim n As Integer = 0
        Do While n < ListBox1.Items.Count
            Dim nation As String = ListBox1.Items(n).ToString
            Dim nationtrim As String = nation.Trim()
            ListBox1.Items.RemoveAt(n)
            If Not nationtrim = "" Then
                ListBox1.Items.Insert(n, nationtrim)
                If n = ListBox1.Items.Count - 1 Then Exit Do
                n = n + 1
            End If
        Loop
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.GotFocus, TextBox2.GotFocus, TextBox3.GotFocus, TextBox5.GotFocus
        Dim txtvalidate() As TextBox = New TextBox() {TextBox1, TextBox2, TextBox3, TextBox5}
        For d = 0 To 3
            If sender.Equals(txtvalidate(d)) Then
                txtvalidate(d).BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub NewMeeting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = Panel2.Width + Panel3.Width
        cbx_rulesel.SelectedIndex = 0
        ComboBox1.SelectedIndex = 0
        ComboBox1.Items.Clear()
        For Each loaded In System.IO.Directory.GetDirectories("themes")
            ComboBox1.Items.Add(System.IO.Path.GetFileName(loaded))
        Next
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub cbx_rulesel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_rulesel.SelectedIndexChanged
        If cbx_rulesel.SelectedIndex = 2 Then
            Panel3.Visible = False
        Else
            Panel3.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            TextBox5.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        If ListBox1.SelectedIndex >= 0 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
    End Sub
End Class
