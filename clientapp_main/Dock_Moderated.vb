Imports StandardConfData.MyInfo.Moderated
Imports StandardConfData

Public Class Dock_Moderated
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

    Sub mcReady()
        isModerated = True
        TableLayoutPanel1.Enabled = True
        txt_mc_add.Enabled = True
        btn_mc_end.Enabled = False
        btn_mc_start.Enabled = False
        mcAll = Dock_Timer.k / Dock_Timer.i
        Label33.Text = "最多有" + mcAll.ToString + "个国家可加入发言列表"
        txt_mc_add.Focus()
        mcCurrent = 0
        mcTotal = 0
    End Sub

    Sub mcNationAdd()
        Dim a1, a2 As Integer
        a1 = mcTotal + 1
        If txt_mc_add.Text = "" Then
        Else
            Dim itme(3) As String
            itme(1) = txt_mc_add.Text
            mcTotal = a1
            txt_mc_totalnumber.Text = a1 + 1
            mcNations(mcTotal) = txt_mc_add.Text
            Form2.UserControl11.SetListItme(mcTotal, mcNations(mcTotal), False)
            ListView1.Items.Add(New ListViewItem(itme))
            Call recordaccess.mcAdd(Form1.recIndex, txt_mc_add.Text)
            txt_mc_add.Text = ""
            txt_mc_add.Focus()
            btn_mc_end.Enabled = 0
            If isZhuijia = True Then
                btn_mc_start.Enabled = True
                mcCurrent = mcCurrent + 1
                txt_mc_currentnumber.Text = mcCurrent
                txt_mc_current.Text = mcNations(mcCurrent)
                isZhuijia = False
                ListView1.Items(mcCurrent - 1).SubItems(0).Text = ">"
            End If
            If mcTotal >= mcAll Then
                txt_mc_add.Text = ""
                Label33.Text = "请开始发言"
                txt_mc_add.Enabled = 0
                btn_mc_add.Enabled = False
                btn_mc_start.Enabled = True
                btn_mc_start.Focus()
                txt_mc_currentnumber.Text = mcCurrent
                txt_mc_current.Text = mcNations(mcCurrent)
            Else
                If mcTotal = 1 Then
                    btn_mc_start.Enabled = True
                    txt_mc_currentnumber.Text = mcTotal
                    txt_mc_current.Text = mcNations(1)
                    mcCurrent = 1
                    ListView1.Items(0).SubItems(0).Text = ">"
                End If
                a2 = mcAll - mcTotal
                Label33.Text = "还可继续添加" + a2.ToString + "个国家"
                txt_mc_add.Select()
            End If
        End If
    End Sub

    Sub mcnext()
        mcIsSpoken(mcCurrent) = True
        ListView1.Items(mcCurrent - 1).SubItems(0).Text = ""
        Form2.UserControl11.SetListItme(mcCurrent, mcNations(mcCurrent), True)
        btn_mcnext.Enabled = False
        Call Dock_Timer.timerControl(0, False)
        Dock_Timer.Button3.Text = "开始"
        Dim k As Integer = Dock_Timer.k
        If mcCurrent >= mcTotal Then
            If k >= Dock_Timer.txttime.Text Then
                txt_mc_add.Text = "点这里追加"
                txt_mc_add.Enabled = 1
                txt_mc_add.ReadOnly = 1
                btn_mc_end.Enabled = 1
                btn_mc_end.Text = "提前结束"
                isZhuijia = True
                mcAdd = k \ Dock_Timer.txttime.Text
                Label33.Text = mcAdd
                Label33.Text = "可向列表追加" + Label33.Text + "个国家"
            Else
                btn_mc_end.Enabled = True
                btn_mc_end.Text = "结束"
                btn_mc_end.Focus()
                Label33.Text = "点击" + Chr(34) + "结束" + Chr(34) + "以完成本轮发言"
            End If
        Else
            ListView1.Items(mcCurrent).SubItems(0).Text = ">"
            mcCurrent = mcCurrent + 1
            txt_mc_currentnumber.Text = mcCurrent
            txt_mc_current.Text = mcNations(mcCurrent)
            btn_mc_start.Enabled = True
            btn_mc_start.Focus()
        End If
    End Sub

    Sub mcEnd()
        Dim k As Integer = Dock_Timer.k
        Dim numtime As Integer = Dock_Timer.txttime.Text
        If k < numtime Then
            If Form1.LoadedConference.language = 1 Then
                Dock_MainScreen.lblmain.Text = Form1.txthcmotion + vbCrLf + "本轮动议结束"
                'nationstr = "本轮动议提前结束, 参加发言的国家有: " + vbCrLf
            Else
                Dock_MainScreen.lblmain.Text = Form1.txthcmotion + vbCrLf + "Motion Ended"
                'nationstr = "Motion expired, nations came up speech: " + vbCrLf
            End If
        Else
            If Form1.LoadedConference.language = 1 Then
                Dock_MainScreen.lblmain.Text = Form1.txthcmotion + vbCrLf + "本轮动议提前结束"
                'nationstr = "本轮动议提前结束, 参加发言的国家有: " + vbCrLf
            Else
                Dock_MainScreen.lblmain.Text = Form1.txthcmotion + vbCrLf + "Motion Expired"
                'nationstr = "Motion expired, nations came up speech: " + vbCrLf
            End If
        End If
        'txthcmotion = nationstr
        Call Dock_Timer.mc_end()
        txt_mc_totalnumber.Text = 1
        txt_mc_currentnumber.Text = 0
        txt_mc_current.Text = ""
        txt_mc_add.ReadOnly = 0
        btn_mc_add.Enabled = 1
        isZhuijia = False
        txt_mc_add.ReadOnly = False
        txt_mc_add.Text = ""
        Call Form1.mcopenclose(True)
        mcCurrent = 0
        mcTotal = 0
        For ee = 1 To 45
            mcNations(ee) = ""
            mcIsSpoken(ee) = 0
        Next
        Call Form2.ChangeStatus(Dock_NationList.rolled, MyInfo.AppStatus.Idle)
        Form2.UserControl11.ClearList()
        ListView1.Items.Clear()
        isModerated = False
        TableLayoutPanel1.Enabled = False
    End Sub

    Private Sub Dock_Moderated_Load(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If Me.Width < 450 And Not Me.Height < 270 Then
            Dim c As Control = Me.TableLayoutPanel1.GetControlFromPosition(1, 0)
            If Not c Is Nothing Then
                Me.TableLayoutPanel1.SetRowSpan(c, 1)
                Me.TableLayoutPanel1.SetCellPosition(c, New TableLayoutPanelCellPosition(0, 1))
                Me.TableLayoutPanel1.SetColumnSpan(c, 2)
            End If
        End If
        If Me.Height < 270 And Not Me.Width < 450 Then
            Dim c As Control = Me.TableLayoutPanel1.GetControlFromPosition(0, 1)
            If Not c Is Nothing Then
                Me.TableLayoutPanel1.SetColumnSpan(c, 1)
                Me.TableLayoutPanel1.SetCellPosition(c, New TableLayoutPanelCellPosition(1, 0))
                Me.TableLayoutPanel1.SetRowSpan(c, 2)
            End If
        End If
    End Sub

    Private Sub btn_mc_add_Click(sender As Object, e As EventArgs) Handles btn_mc_add.Click
        Call mcNationAdd()
    End Sub

    Private Sub txt_mc_add_KeyPress(sender As Object, e As KeyEventArgs) Handles txt_mc_add.KeyUp
        If e.KeyCode = 13 Then
            Call mcNationAdd()
        End If
    End Sub

    Private Sub txt_mc_add_click(sender As Object, e As EventArgs) Handles txt_mc_add.Click
        If txt_mc_add.Text = "点这里追加" Then
            txt_mc_add.ReadOnly = 0
            txt_mc_add.Text = ""
            txt_mc_add.Focus()
            mcAll = mcCurrent + mcAdd
            btn_mc_add.Enabled = True
            txt_mc_totalnumber.Text = mcTotal + 1
        End If
    End Sub

    Private Sub btn_mc_start_Click(sender As Object, e As EventArgs) Handles btn_mc_start.Click
        Label33.Text = "停止发言请点击" + Chr(34) + "下一个" + Chr(34)
        Call Dock_Timer.mc_start_click()
        btn_mc_start.Enabled = False
        btn_mcnext.Enabled = True
        txt_mc_add.Enabled = False
        btn_mc_add.Enabled = False
        btn_mcnext.Focus()
    End Sub

    Private Sub btn_mc_next_Click(sender As Object, e As EventArgs) Handles btn_mcnext.Click
        Dock_Timer.Button3.Enabled = 0
        Call mcnext()
    End Sub

    Private Sub btn_mc_end_Click(sender As Object, e As EventArgs) Handles btn_mc_end.Click
        Call mcEnd()
    End Sub

    Private Sub Dock_Moderated_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        If isModerated Then
            TableLayoutPanel1.Enabled = True
            For i = 1 To mcTotal
                If mcTotal = 0 Then
                Else
                    Dim itme(3) As String
                    itme(1) = mcNations(i)
                    If i = mcCurrent + 1 Then itme(0) = ">"
                    txt_mc_totalnumber.Text = mcTotal + 1
                    txt_mc_currentnumber.Text = mcCurrent
                    txt_mc_current.Text = mcNations(mcCurrent)
                    Form2.UserControl11.SetListItme(mcTotal, mcNations(mcTotal), False)
                    ListView1.Items.Add(New ListViewItem(itme))
                End If
            Next
        End If
    End Sub
End Class