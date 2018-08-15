Imports System.Windows.Forms
Imports LanguageScript.Language1
Imports StandardConfData

Public Class Motion

    Function mystring(steps As Integer) As String
        mystring = motionString(29)
        If Not TextBox1.Text = "" Then
            Dim motiontype() As String = New String() {motionString(4), motionString(9), motionString(27), motionString(24), motionString(28), motionString(16), motionString(17), motionString(18)}
            mystring = TextBox1.Text + motiontype(ComboBox1.SelectedIndex)
        End If
        If steps > 0 Then
            Select Case ComboBox1.SelectedIndex
                Case 0
                    mystring = mystring + vbCrLf + motionString(5) + TextBox2.Text
                    If steps = 1 Then
                        mystring = mystring + " ..."
                    Else
                        mystring = mystring + vbCrLf + motionString(6) + num_m_umc.Value.ToString
                        If steps = 2 Then
                            mystring = mystring + motionString(10) + " ..."
                        Else
                            mystring = mystring + motionString(7) + num_m_mc_2.Value.ToString + motionString(8)
                        End If
                    End If
                Case 1, 5
                    mystring = mystring + vbCrLf + motionString(6) + num_m_umc.Value.ToString + motionString(10)
                    If steps = 2 Then mystring = mystring + " ..."
                Case 2
                    mystring = TextBox1.Text + motionString(11) + num_m_spl_1.Value.ToString
                    If num_m_spl_2.Value = 0 Then
                        mystring = mystring + motionString(10)
                    Else
                        mystring = mystring + motionString(12) + num_m_spl_2.Value.ToString + motionString(13)
                    End If
                    If steps < 2 Then mystring = mystring + " ..."
                Case 3
                    If Not cbx_mfileselect.SelectedItem Is Nothing Then
                        mystring = mystring + vbCrLf + motionString(25) + cbx_mfileselect.SelectedItem.ToString + motionString(26)
                    End If
                    If steps < 2 Then mystring = mystring + " ..."
                Case 4
                    mystring = TextBox1.Text + motionString(14) + cbx_mfileselect.SelectedItem.ToString + motionString(15)
                    If steps < 2 Then mystring = mystring + " ..."
            End Select
        Else : mystring = mystring + " ..."
        End If
    End Function

    Sub chushihua()
        TextBox1.Text = ""
        TextBox2.Text = ""
        Call ResetPanels()
    End Sub

    Sub ResetPanels()
        Panel4.Visible = False
        panel_m_1.Visible = False
        panel_m_2.Visible = False
        panel_m_3.Visible = False
        panel_m_4.Visible = False
        Button1.Visible = True
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        OK_Button.Focus()
        Dim mytext As String = mystring(4)
        Dock_MainScreen.lblmain.Text = mytext + vbCrLf + motionString(0)
        Dim myCategory() As String = New String() {"MC", "UMC", "AT", "AO", "mVT", "mTB", "ED", "XH"}
        Dim second = MsgBox(motionString(0), 32 + 4, ComboBox1.SelectedItem.ToString)
        If second = vbNo Then
            Dock_MainScreen.lblmain.Text = mytext + vbCrLf + motionString(3)
            Call xmlsaveload.CreateRecord(Form1.recIndex, myCategory(ComboBox1.SelectedIndex))
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        Else
            Dock_MainScreen.lblmain.Text = mytext + vbCrLf + motionString(1)
            Dim infavor = MsgBox(motionString(1) + vbCrLf + motionString(2), 32 + 4, ComboBox1.SelectedItem.ToString)
            If infavor = vbNo Then
                Dock_MainScreen.lblmain.Text = mytext + vbCrLf + motionString(3)
                Call xmlsaveload.CreateRecord(Form1.recIndex, myCategory(ComboBox1.SelectedIndex))
                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                Me.Close()
            Else
                'Dock_MainScreen.lblmain.Text = ""
                Dock_MainScreen.lblmain.Text = mytext
                Form1.txthcmotion = mytext
                If ComboBox1.SelectedIndex = 5 Then Form1.txthcmotion = TextBox1.Text + motionString(16) + vbCrLf + motionString(20) + num_m_umc.Value.ToString + motionString(10) + ")"
                Call xmlsaveload.CreateRecord(Form1.recIndex, myCategory(ComboBox1.SelectedIndex), True)
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp, TextBox2.KeyUp
        If e.KeyCode = Keys.Enter Then
            If sender.Equals(TextBox1) Then Call Button1_Click(TextBox1, EventArgs.Empty)
            If sender.Equals(TextBox2) And Not TextBox2.Text = "" Then Call Button2_Click(TextBox2, EventArgs.Empty)
        End If
    End Sub

    Private Sub Motion_Load(sender As Object, e As EventArgs) Handles MyBase.Load, ComboBox1.SelectedIndexChanged, TextBox1.TextChanged
        Dock_MainScreen.lblmain.Text = mystring(0)
        Call ResetPanels()
        If sender.Equals(Me) Then
            cbx_mfileselect.Items.Clear()
            For Each file As MyInfo.File In Form1.nFileList
                If file.Category = MyInfo.FileCategory.Amendment OrElse file.Category = MyInfo.FileCategory.DraftDirective OrElse file.Category = MyInfo.FileCategory.DraftResolution Then
                    cbx_mfileselect.Items.Add(file.ToString)
                End If
            Next
            TextBox1.Text = ""
            TextBox2.Text = ""
            num_m_spl_1.Value = MyInfo.SpeakersList.slTime(1)
            num_m_spl_2.Value = MyInfo.SpeakersList.slTime(0)
            Dock_MainScreen.lblmain.Text = mystring(0)
            TextBox1.Focus()
        ElseIf sender.Equals(ComboBox1) Then
            If ComboBox1.SelectedIndex = 4 Then
                Label99.Text = "对文件 　　　　　　　　　　投票"
            Else
                Label99.Text = "优先对 　　　　　　　　　　投票"
            End If
            OK_Button.Enabled = False
        End If
        If TextBox1.Text = "" Then
            Button1.Enabled = False
            OK_Button.Enabled = False
        Else
            Button1.Enabled = True
            If ComboBox1.SelectedIndex > 5 Then OK_Button.Enabled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged, TextBox2.GotFocus, num_m_spl_1.ValueChanged, num_m_spl_1.GotFocus, num_m_spl_2.ValueChanged, num_m_spl_2.GotFocus, cbx_mfileselect.SelectedIndexChanged
        Dock_MainScreen.lblmain.Text = mystring(1)
        Button2.Visible = True
        If sender.Equals(TextBox2) AndAlso TextBox2.Text = "" Then
            Button2.Enabled = False
            OK_Button.Enabled = False
        Else : Button2.Enabled = True
        End If
    End Sub

    Private Sub adfad(sender As Object, e As EventArgs) Handles num_m_spl_2.ValueChanged
        'Dock_MainScreen.lblmain.Text = mystring(1)
        'Button2.Visible = True
        Dim m As Integer = num_m_spl_1.Value
        Dim s As Integer = num_m_spl_2.Value
        If s > 55 Then
            m = m + 1
            s = 0
        ElseIf s < 0 Then
            m = m - 1
            If m < 0 Then m = 0
            s = 55
        End If
        num_m_spl_1.Value = m
        num_m_spl_2.Value = s
    End Sub

    Private Sub num_m_umc_KeyUp(sender As Object, e As KeyEventArgs) Handles num_m_umc.KeyUp
        If e.KeyCode = Keys.Enter Then
            If ComboBox1.SelectedIndex = 0 Then
                Call Button3_Click(num_m_umc, EventArgs.Empty)
                OK_Button.Enabled = True
            Else
                Call OK_Button_Click(num_m_umc, EventArgs.Empty)
            End If
        End If
    End Sub

    Private Sub num_m_umc_ValueChanged(sender As Object, e As EventArgs) Handles num_m_umc.ValueChanged, num_m_umc.GotFocus
        Dock_MainScreen.lblmain.Text = mystring(2)
        If ComboBox1.SelectedIndex = 0 Then
            num_m_mc_2.Maximum = num_m_umc.Value * 60
            Button3.Visible = True
        End If
    End Sub

    Private Sub num_m_mc_2_KeyUp(sender As Object, e As KeyEventArgs) Handles num_m_mc_2.KeyUp, num_m_spl_1.KeyUp, num_m_spl_2.KeyUp, cbx_mfileselect.KeyUp
        If e.KeyCode = Keys.Enter Then
            If sender.Equals(num_m_spl_1) Then
                num_m_spl_2.Focus()
            Else
                If sender.Equals(num_m_umc) AndAlso ComboBox1.SelectedIndex = 0 Then
                    OK_Button.Enabled = True
                Else
                    Call OK_Button_Click(sender, EventArgs.Empty)
                End If
            End If
        End If
    End Sub

    Private Sub num_m_mc_2_ValueChanged(sender As Object, e As EventArgs) Handles num_m_mc_2.ValueChanged, num_m_mc_2.GotFocus
        Dock_MainScreen.lblmain.Text = mystring(3)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case ComboBox1.SelectedIndex
            Case 0
                Panel4.Visible = True
                Button2.Visible = True
                TextBox2.Focus()
            Case 1, 5
                panel_m_2.Visible = True
                OK_Button.Enabled = True
                num_m_umc.Focus()
            Case 2
                panel_m_3.Visible = True
                OK_Button.Enabled = True
                num_m_spl_2.Focus()
            Case 3, 4
                panel_m_4.Visible = True
                OK_Button.Enabled = True
                cbx_mfileselect.Focus()
            Case 6, 7
                Call OK_Button_Click(Button1, EventArgs.Empty)
                Exit Sub
        End Select
        Button1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        panel_m_2.Visible = True
        Button3.Visible = True
        Button2.Visible = False
        panel_m_2.BringToFront()
        num_m_umc.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        panel_m_1.Visible = True
        Button3.Visible = False
        panel_m_1.BringToFront()
        num_m_mc_2.Focus()
    End Sub
End Class
