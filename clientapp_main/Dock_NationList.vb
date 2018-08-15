Imports StandardConfData

Public Class Dock_NationList
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent
    Public dianmingstatus As String = "当前未进行点名"

    Public Shared Function rolled() As Boolean
        rolled = False
        If Dock_NationList.dianmingstatus = "点名已完成" Then rolled = True
    End Function

    Sub rollClose()
        dianmingstatus = "当前未进行点名"
        Call pcalc(0)
    End Sub

    Public Shared Function pCount()
        pCount = 0
        Dim i As Integer = 0
        Do While i < Dock_NationList.clb_nation_main.Items.Count
            If Dock_NationList.clb_nation_main.GetItemCheckState(i) Then pCount = pCount + 1
            i = i + 1
        Loop
    End Function

    Public Shared Sub pcalc(ByVal p As Integer)
        If p = 0 Then
            Dock_NationList.Label1.Text = Dock_NationList.dianmingstatus + vbCrLf + "出席国家数:" + Str(0) + vbCrLf + "简单多数:" + Str(0) + vbCrLf + "三分之二多数:" + Str(0) + vbCrLf + "20%:" + Str(0)
            Dock_NationList.ToolStripLabel1.Text = 0.ToString + "/" + (0).ToString + "/" + (0).ToString + "/" + (0).ToString
        Else
            Dock_NationList.Label1.Text = Dock_NationList.dianmingstatus + vbCrLf + "出席国家数:" + Str(p) + vbCrLf + "简单多数:" + Str((p) \ 2 + 1) + vbCrLf + "三分之二多数:" + Str((p) * 2 \ 3 + 1) + vbCrLf + "20%:" + Str((p) \ 5 + 1)
            Dock_NationList.ToolStripLabel1.Text = p.ToString + "/" + ((p) \ 2 + 1).ToString + "/" + ((p) * 2 \ 3 + 1).ToString + "/" + ((p) \ 5 + 1).ToString
        End If
    End Sub

    Function rolling(isvote As Boolean) As Boolean
        dianmingstatus = "正在进行点名"
        Call pcalc(pCount)
        MsgBox("下面将进行点名。请点到的国家高举国家牌并答" + Chr(34) + "到" + Chr(34) + "或" + Chr(34) + "出席" + Chr(34) + "。", 64, "点名")
        Call Form2.ChangeStatus(True, MyInfo.AppStatus.RollCall)
        Dim capacity As Integer = Form2.UserControl11.ListCapacity
        If Form1.LoadedConference.language = 1 Then
            Dock_MainScreen.lblmain.Text = "下面将进行点名。请点到的国家高举国家牌并答" + Chr(34) + "到" + Chr(34) + "或" + Chr(34) + "出席" + Chr(34) + "。"
        Else
            Dock_MainScreen.lblmain.Text = "All the delegates please raise your placard and say " + Chr(34) + "Present" + Chr(34) + " when your country's name is called."
        End If
        If isvote Then
            Form2.UserControl11.SetPage(1, 1)
            Vote.ListView1.Items.Clear()
        Else
            Form2.UserControl11.SetPage(1, clb_nation_main.Items.Count \ capacity + 1)
            For n = 1 To clb_nation_main.Items.Count
                If n > capacity Then Exit For
                Form2.UserControl11.SetListItmeExt(n, clb_nation_main.Items(n - 1).ToString, False)
            Next
        End If
        Dim i As Integer = 0
        Dim s As Integer = 0
        Do While i < clb_nation_main.Items.Count
            If Not isvote AndAlso i = capacity Then
                Form2.UserControl11.ClearList()
                Form2.UserControl11.SetPage(2, 2)
                For n = capacity + 1 To clb_nation_main.Items.Count
                    If n > capacity * 2 Then Exit For
                    Form2.UserControl11.SetListItmeExt(n - capacity, clb_nation_main.Items(n - 1).ToString, False)
                Next
            End If
            If isvote AndAlso s = capacity Then
                Form2.UserControl11.ClearList()
                Form2.UserControl11.SetPage(2, 2)
            End If
            If i < clb_nation_main.Items.Count - 10 Then clb_nation_main.SetSelected(i + 10, True)
            clb_nation_main.SetSelected(i, True)
            Dim YesNoCancel = MessageBoxButtons.YesNoCancel
            If isvote Then YesNoCancel = MessageBoxButtons.YesNo

            Select Case MessageBox.Show($"{clb_nation_main.Items(i).ToString}{vbCrLf}该国是否出席？", "点名", YesNoCancel, MessageBoxIcon.Question)
                Case DialogResult.Yes
                    clb_nation_main.SetItemCheckState(i, CheckState.Checked)
                    If isvote Then
                        Form2.UserControl11.SetListItmeExt(s + 1 - ((s \ capacity) * capacity), clb_nation_main.Items(i).ToString, False)
                        s = s + 1
                        Dim itme(2) As String
                        itme(0) = clb_nation_main.Items(i).ToString
                        itme(1) = Form1.nNationList(i).GetCompetence
                        Vote.ListView1.Items.Add(New ListViewItem(itme))
                    Else
                        Form2.UserControl11.SetListItmeMarkupExt(i + 1 - ((i \ capacity) * capacity), Screen.listmarkup.Aan)
                        Try
                            Dock_NationDetail.ChangeItemChecked(i, True)
                        Catch
                        End Try
                        Form1.nNationList(i).Attendence = True
                    End If
                Case DialogResult.No
                    clb_nation_main.SetItemCheckState(i, CheckState.Unchecked)
                    Try
                        Dock_NationDetail.ChangeItemChecked(i, False)
                    Catch
                    End Try
                    Form1.nNationList(i).Attendence = False
                Case DialogResult.Cancel
                    dianmingstatus = "点名流程被取消"
                    Call Form2.ChangeStatus(rolled, MyInfo.AppStatus.Idle)
                    Call pcalc(pCount)
                    If isvote Then Vote.Close()
                    rolling = False
                    Exit Function
            End Select
            Call pcalc(pCount)
            Form2.UserControl11.SetPresents(pCount)
            clb_nation_main.SetSelected(i, False)
            i = i + 1
        Loop
        If isvote Then
            If MsgBox("是否记住本次点名结果？", 36, "点名") = 6 Then Vote.LoadRollcall = True
        End If
        dianmingstatus = "点名已完成"
        rolling = True
        Call pcalc(pCount)
    End Function

    Private Sub Dock_NationList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p1 As Integer = 0
        For Each i In Form1.nNationList
            clb_nation_main.Items.Add(i.Name)
            Dim n As Integer = clb_nation_main.Items.Count - 1
            If i.Attendence = True Then
                clb_nation_main.SetItemCheckState(n, CheckState.Checked)
                p1 = p1 + 1
            Else
                clb_nation_main.SetItemCheckState(n, CheckState.Unchecked)
            End If
        Next
        Call pcalc(p1)
        Call Button2_Click(sender, EventArgs.Empty)
    End Sub

    Sub Button1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Show()
        If rolling(False) = True Then
            Dim report As String
            Dim pc1 As Integer = pCount()
            Form1.presentWhenRoll = pc1
            Form1.nRWriter.Add(New Record.RecordContent(Record.RecordCategory.RC, Date.Now, pc1))
            Call Form2.ChangeStatus(rolled, MyInfo.AppStatus.Idle)
            If Form1.LoadedConference.language = 1 Then
                report = $"本次会议实际有{pc1.ToString}国家出席{vbCrLf}简单多数为{((pc1) \ 2 + 1).ToString + vbCrLf}三分之二多数为{((pc1) * 2 \ 3 + 1).ToString + vbCrLf}20%国家数为{((pc1) \ 5).ToString}"
            Else
                report = $"{pc1.ToString} nations present in the conference{vbCrLf}Simple majority: {((pc1) \ 2 + 1).ToString + vbCrLf}2/3 majority: {((pc1) * 2 \ 3 + 1).ToString + vbCrLf}20% count of nations: {((pc1) \ 5).ToString}"
            End If
            Dock_MainScreen.lblmain.Text = report
            ToolStripLabel1.Text = $"{pc1.ToString}/{((pc1) \ 2 + 1).ToString}/{((pc1) * 2 \ 3 + 1).ToString}/{((pc1) \ 5).ToString}"
            Call xmlsaveload.saveAttendance(True)
            Call Form1.mcopenclose(True)
            Call Form1.dianmingopenclose(False)
        Else
            For i = 0 To clb_nation_main.Items.Count - 1
                clb_nation_main.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Dim EnableEdit As Boolean

    Private Sub clb_nation_main_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clb_nation_main.ItemCheck
        If dianmingstatus = "点名已完成" Then
            ToolStripButton2.Enabled = True
            If EnableEdit Then Timer1.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Call pcalc(pCount)
        Form2.UserControl11.SetPresents(pCount)
        Call xmlsaveload.saveAttendance()
        'Button2.Enabled = False
        ToolStripButton2.Enabled = False
    End Sub

    Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click ', Form1.国家信息IToolStripMenuItem.Click
        Call Form1.ShowNationDetails()
    End Sub

    Private Sub adsdf(sender As Object, e As EventArgs) Handles clb_nation_main.Click
        EnableEdit = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not clb_nation_main.SelectedIndex = -1 Then Form1.nNationList(clb_nation_main.SelectedIndex).Attendence = clb_nation_main.GetItemChecked(clb_nation_main.SelectedIndex)
        Try
            Dock_NationDetail.ChangeItemChecked(clb_nation_main.SelectedIndex, clb_nation_main.GetItemChecked(clb_nation_main.SelectedIndex))
        Catch ex As Exception

        End Try
        EnableEdit = False
        Timer1.Enabled = False
    End Sub

    Private Sub clb_nation_main_SelectedIndexChanged(sender As Object, e As ItemCheckEventArgs) Handles clb_nation_main.ItemCheck

    End Sub
End Class