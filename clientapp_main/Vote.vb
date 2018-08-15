Imports LanguageScript.Language1
Imports StandardConfData


Public Class Vote
    Public LoadRollcall As Boolean
    Public nations(100), a1, a2, FileName As String, yes, no, abst, pnat(99), vtTotal, vtCurrent, p, q, maj67vote, voteStep As Integer, opini(100) As MyInfo.VoteOpinion
    Public r2 As Boolean
    Public current As Integer
    Public VoteResult As Boolean

    Function vetoPower() As String
        Dim fj As Integer, vetoString As String
        vetoString = ""
        Dim fxk() As CheckBox = New CheckBox() {CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6}
        For v = 0 To 4
            If fxk(v).Checked = True Then
                fj = fj + 1
                If fj > 1 Then vetoString = vetoString + ", "
                vetoString = vetoString + fxk(v).Text
            End If
        Next
        If fj > 0 Then
            vetoString = vetoString + voteString(7)
        Else
            vetoString = voteString(6)
        End If
        Return vetoString
    End Function

    Function votePass() As Integer
        Dim passnumber As Integer
        If chk_noabst.Checked Then
            passnumber = maj67vote - abst
        Else
            passnumber = maj67vote
        End If
        If rad_50maj.Checked Then
            passnumber = passnumber \ 2 + 1
        ElseIf rad_67maj.Checked Then
            passnumber = passnumber * 2 \ 3 + 1
        ElseIf rad_80maj.Checked Then
            passnumber = passnumber * 4 \ 5
        End If
        Return passnumber
    End Function

    Sub voteClear()
        For i3 = 1 To 100
            nations(i3) = ""
            opini(i3) = 0
            pnat(i3 - 1) = 0
            yes = 0
            no = 0
            abst = 0
            vtTotal = 0
            vtCurrent = 0
            p = 0
            q = 0
            voteStep = 0
            r2 = 0
            current = 0
            Call voteDisp()
        Next
    End Sub

    Sub GetFilename(FromFileName As String)
        FileName = FromFileName
    End Sub

    Sub vote(ByVal op As Integer, ByVal r2 As Boolean)
        Select Case op
            Case 1
                If r2 = True Then
                    opini(pnat(q)) = MyInfo.VoteOpinion.Yes
                    ListView1.Items(pnat(q) - 1).SubItems(2).Text = voteString(3)
                Else
                    opini(vtCurrent) = MyInfo.VoteOpinion.Yes
                    ListView1.Items(vtCurrent - 1).SubItems(2).Text = voteString(3)
                End If
                yes = yes + 1
            Case 2
                If r2 = True Then
                    opini(pnat(q)) = MyInfo.VoteOpinion.No
                    ListView1.Items(pnat(q) - 1).SubItems(2).Text = voteString(4)
                Else
                    opini(vtCurrent) = MyInfo.VoteOpinion.No
                    ListView1.Items(vtCurrent - 1).SubItems(2).Text = voteString(4)
                End If
                no = no + 1
                If chk_vote_foujue.Checked Then
                    Dim vtCurNation As String
                    If r2 Then
                        vtCurNation = nations(pnat(q))
                    Else
                        vtCurNation = nations(vtCurrent)
                    End If
                    Select Case vtCurNation
                        Case "中国", "中华人民共和国", "天朝", "China", "PRC", "PR of China", "People Republic of China"
                            CheckBox2.Checked = 1
                        Case "美国", "美利坚合众国", "美帝", "US", "USA", "U.S.", "U.S.A.", "U.S", "U.S.A", "United States", "United States of America"
                            CheckBox3.Checked = 1
                        Case "英国", "大不列颠及北爱尔兰联合王国", "UK", "U.K.", "U.K", "Britain", "Great Britain", "United Kingdom", "United Kingdom of Great Britain and North Ireland"
                            CheckBox4.Checked = 1
                        Case "法国", "法兰西共和国", "法兰西第五共和国", "France", "Republic of France"
                            CheckBox5.Checked = 1
                        Case "俄罗斯", "俄罗斯联邦", "Russia", "Russian Federation", "Russian Fed"
                            CheckBox6.Checked = 1
                    End Select
                End If
            Case 3
                opini(vtCurrent) = MyInfo.VoteOpinion.Abst
                ListView1.Items(vtCurrent - 1).SubItems(2).Text = voteString(5)
                abst = abst + 1
            Case 4
                p = p + 1
                pnat(p) = vtCurrent
        End Select
        Call voteDisp()
        If r2 = False Then
            If nations(vtCurrent + 1) = "" Then
                Form2.UserControl11.SetListItmeMarkupExt(vtCurrent - ((vtCurrent - 1) \ 60) * 60, opini(vtCurrent))
                If p = 0 Then
                    Label108.Text = "请在上方选择行使否决权的国家{vbCrLf}或直接结束投票"
                    lbl_vote_nation.Text = ""
                    chk_vote_foujue.Enabled = True
                    btn_votectrl.Enabled = 0
                    Button1.Enabled = True
                    Button1.Focus()
                Else
                    Label108.Text = "请开启下一轮投票"
                    lbl_vote_nation.Text = "---"
                    btn_votectrl.Enabled = 0
                    Button1.Enabled = True
                    Button1.Focus()
                End If
                'Call display(b \ 30, True)
                'Call display(b \ 30, False)

                btnyes.Enabled = False
                btnno.Enabled = False
                btnabst.Enabled = False
                btnpass.Enabled = False
            Else
                'Call display(b \ 30, True)
                'Call display(b \ 30, False)
                Form2.UserControl11.SetListItmeMarkupExt(vtCurrent - ((vtCurrent - 1) \ 60) * 60, opini(vtCurrent))
                current = vtCurrent \ 60
                vtCurrent = vtCurrent + 1
                lbl_vote_nation.Text = nations(vtCurrent)
                If Not vtTotal Mod 60 = 0 Then
                    If vtCurrent = 61 Then
                        Form2.UserControl11.ClearList()
                        For i = 61 To vtTotal
                            Form2.UserControl11.SetListItmeExt(i - 60, nations(i), False)
                        Next
                        Form2.UserControl11.SetPage(2, 2)
                        ToolStripLabel1.Text = "页数 " + current.ToString + "/" + ((vtTotal - 1) \ 60 + 1).ToString
                    End If
                End If
            End If
        Else
            If nations(pnat(q + 1)) = "" Then
                Label108.Text = "请在上方选择行使否决权的国家{vbCrLf}或直接结束投票"
                lbl_vote_nation.Text = ""
                'Call display(pnat(q) \ 30, True)
                'Call display(pnat(q) \ 30, False)
                Form2.UserControl11.SetListItmeMarkupExt(pnat(q) - (((pnat(q)) - 1) \ 60) * 60, opini(pnat(q)))
                chk_vote_foujue.Enabled = True
                btn_votectrl.Enabled = 0
                btnyes.Enabled = False
                btnno.Enabled = False
                Button1.Enabled = True
                Button1.Focus()
            Else
                'Call display(pnat(q) \ 30, True)
                'Call display(pnat(q) \ 30, False)
                Form2.UserControl11.SetListItmeMarkupExt(pnat(q) - (((pnat(q)) - 1) \ 60) * 60, opini(pnat(q)))
                current = pnat(q) \ 60
                q = q + 1
                lbl_vote_nation.Text = nations(pnat(q))
                If Not vtTotal Mod 60 = 0 Then
                    If pnat(q) > 60 Then
                        Form2.UserControl11.ClearList()
                        For i = 61 To vtTotal
                            Form2.UserControl11.SetListItmeExt(i - 60, nations(i), False)
                            Form2.UserControl11.SetListItmeMarkupExt(i - 60, opini(i))
                        Next
                        Form2.UserControl11.SetPage(2, 2)
                        ToolStripLabel1.Text = "页数 " + current.ToString + "/" + ((vtTotal - 1) \ 60 + 1).ToString
                    End If
                End If
            End If
        End If
    End Sub

    Sub voteDisp()
        lblyes.Text = yes.ToString + "/" + votePass().ToString
        lblno.Text = no
        lblabst.Text = abst
        Form2.UserControl11.SetPresents(vtTotal, yes, no, abst)
    End Sub

    Sub Votestart(isLoaded As Boolean)
        'If isMotion Then
        '    If Form1.language = 1 Then
        '        Dock_MainScreen.lblmain.Text = Dock_MainScreen.lblmain.Text + vbCrLf + "获得通过，投票开始"
        '    Else
        '        Dock_MainScreen.lblmain.Text = Dock_MainScreen.lblmain.Text + vbCrLf + "Motion passes, vote starts"
        '    End If
        'Else
        'End If
        Dim i As Integer = 0
        vtTotal = 0
        If isLoaded Then
            Do While i < ListView1.Items.Count
                Dim name As String = ListView1.Items(i).SubItems(0).Text
                ListView1.Items(i).SubItems(2).Text = ""
                If i < 60 Then Form2.UserControl11.SetListItmeExt(i + 1, name, False)
                vtTotal = vtTotal + 1
                nations(vtTotal) = name
                i = i + 1
            Loop
        Else
            Do While i < ListView1.Items.Count
                Dim name As String = ListView1.Items(i).SubItems(0).Text
                If i < 60 Then Form2.UserControl11.SetListItmeExt(i + 1, name, False)
                vtTotal = vtTotal + 1
                nations(vtTotal) = name
                i = i + 1
            Loop
        End If
        Form2.UserControl11.SetPage(1, vtTotal \ 60 + 1)
        ToolStripLabel1.Text = "页数 " + current.ToString + "/" + ((vtTotal - 1) \ 60 + 1).ToString
        maj67vote = vtTotal
        Dim prompt1 As String = $"正在进行第1轮投票{vbCrLf}请被点到的国家高举国家牌并答{Chr(34)}赞成{Chr(34)}、{Chr(34)}反对{Chr(34)}、{Chr(34)}弃权{Chr(34)}或{Chr(34)}过{Chr(34)}。"
        Form2.UserControl11.SetPrompt(prompt1)
        MsgBox(prompt1, 64, "投票")
        lbl_vote_nation.Text = nations(1)
        vtCurrent = 1
        Call voteDisp()
        btnyes.Enabled = True
        btnno.Enabled = True
        btnabst.Enabled = True
        btnpass.Enabled = True
        btn_votectrl.Enabled = 1
        btn_votectrl.Focus()
        voteStep = 2
    End Sub

    Private Sub Vote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Try
            FileName = Dock_FileManage.ListBox1.SelectedItem.ToString
        Catch ex As Exception
            FileName = "决议草案0.1"
        End Try
        xmlsaveload.CreateRecord(Form1.recIndex, "VT")
        voteStep = 1
        Dim voteString1 As String
        If Form1.LoadedConference.language = 1 Then
            voteString1 = $"对{FileName}进行投票"
            Dock_MainScreen.lblmain.Text = $"正在{voteString1}"
        Else
            voteString1 = $"Vote for {FileName}"
            Dock_MainScreen.lblmain.Text = $"Voting for {FileName}"
        End If
        If Form1.LoadedConference.language = 1 Then
            CheckBox2.Text = "中国"
            CheckBox3.Text = "美国"
            CheckBox4.Text = "英国"
            CheckBox5.Text = "法国"
            CheckBox6.Text = "俄罗斯"
        End If
        Select Case Form1.LoadedConference.Committee
            Case "UNSC", "Security Council", "United Nations Security Council", "安理会", "联合国安理会", "联合国安全理事会"
                chk_vote_foujue.Checked = 1
            Case Else
                chk_vote_foujue.Checked = 0
        End Select
        Form2.UserControl11.SetVoteMode(True)
        Form2.UserControl11.SetPresents(Dock_NationList.pCount)
        Form1.txthcmotion = voteString1
        If LoadRollcall = True Then
            If MsgBox("是否加载上次点名数据？", 36, "投票") Then
                ListView1.Items.Clear()
                Form2.ChangeStatus(True, MyInfo.AppStatus.Vote)
                Dim i As Integer = 1
                For Each itme1 In Dock_NationList.clb_nation_main.CheckedItems
                    Dim itme(2) As String
                    itme(0) = itme1.ToString
                    itme(1) = Form1.nNationList.GetNationFromName(itme(0)).GetCompetence
                    ListView1.Items.Add(New ListViewItem(itme))
                    If i < 61 Then Form2.UserControl11.SetListItmeExt(i, itme1.ToString, False)
                Next
                Form2.UserControl11.SetPage(1, (ListView1.Items.Count - 1) \ 60 + 1)
                ToolStripLabel1.Text = "页数 " + current.ToString + "/" + ((vtTotal - 1) \ 60 + 1).ToString
                Call Votestart(True)
            Else
                LoadRollcall = False
                Call Dock_NationList.rolling(True)
                Call Votestart(False)
            End If
        Else
            Call Dock_NationList.rolling(True)
            Call Votestart(False)
        End If
        If Form1.LoadedConference.language = 1 Then
            voteString1 = "对" + FileName + "进行投票"
            Dock_MainScreen.lblmain.Text = "正在" + voteString1
        Else
            voteString1 = "Vote for " + FileName + ""
            Dock_MainScreen.lblmain.Text = "Voting for " + FileName + ""
        End If
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btn_votectrl.KeyPress
        If voteStep = 2 Or voteStep = 3 Then
            Select Case e.KeyChar
                Case Chr(49)
                    Call vote(1, r2)
                Case Chr(50)
                    Call vote(2, r2)
                Case Chr(51)
                    If voteStep = 2 Then Call vote(3, r2) Else Exit Sub
                Case Chr(52)
                    If voteStep = 2 Then Call vote(4, r2) Else Exit Sub
            End Select
            btn_votectrl.Focus()
        End If
    End Sub

    Private Sub btn_vote_next_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case voteStep
            Case 2
                If p > 0 Then
                    'lbl_vote_step.Text = "第3步: 进行第2轮投票"
                    Dim prompt2 As String = $"正在进行第2轮投票{vbCrLf}请被点到的国家高举国家牌并答{Chr(34)}赞成{Chr(34)}或{Chr(34)}反对{Chr(34)}。"
                    Form2.UserControl11.SetPrompt(prompt2)
                    lbl_vote_nation.Text = nations(pnat(1))
                    Form2.UserControl11.ClearList()
                    For i = pnat(1) \ 60 + 1 To vtTotal
                        Form2.UserControl11.SetListItmeExt(i - (pnat(1) \ 60) * 60, nations(i), False)
                        Form2.UserControl11.SetListItmeMarkupExt(i - (pnat(1) \ 60) * 60, opini(i))
                        If i = pnat(1) \ 60 + 60 Then Exit For
                    Next
                    Form2.UserControl11.SetPage(pnat(1) \ 60 + 1, 2)
                    ToolStripLabel1.Text = "页数 " + current.ToString + "/" + ((vtTotal - 1) \ 60 + 1).ToString
                    btnyes.Enabled = True
                    btnno.Enabled = True
                    Button1.Enabled = 0
                    r2 = True
                    q = 1
                    btn_votectrl.Enabled = 1
                    btn_votectrl.Focus()
                    voteStep = 3
                Else
                    'lbl_vote_step.Text = "第4步: 确认否决权和通过条件设定"
                    Button1.Text = "完成"
                    voteStep = 4
                End If
            Case 3
                'lbl_vote_step.Text = "第4步: 确认否决权和通过条件设定"
                Button1.Text = "完成"
                voteStep = 4
            Case 4
                Label108.Text = "投票已结束！"
                For i = 1 To vtTotal
                    Form2.UserControl11.SetListItmeExt(i, nations(i), False)
                    Form2.UserControl11.SetListItmeMarkupExt(i, opini(i))
                    If i = 60 Then Exit For
                Next
                Dim ispass As Boolean
                If yes >= votePass() Then
                    If vetoPower() = voteString(6) Then
                        a2 = voteString(0) + FileName + voteString(1)
                        ispass = True
                    Else
                        a2 = voteString(0) + FileName + voteString(2)
                        ispass = False
                    End If
                Else
                    a2 = voteString(0) + FileName + voteString(2)
                    ispass = False
                End If
                Dock_MainScreen.lblmain.Text = a2
                If chk_vote_foujue.Checked Then
                    Dock_MainScreen.lblmain.Text = Dock_MainScreen.lblmain.Text + vbCrLf + vetoPower()
                End If
                Dim numbers() As Integer = New Integer() {vtTotal, votePass(), yes, no, abst}
                Dim fxk() As Boolean = New Boolean() {chk_vote_foujue.Checked, CheckBox2.Checked, CheckBox3.Checked, CheckBox4.Checked, CheckBox5.Checked, CheckBox6.Checked}
                recordaccess.voteAdd(Form1.recIndex, nations, opini, vtTotal, numbers, ispass, fxk)
                Button1.Text = "关闭"
                voteStep = 5
            Case 5
                Button1.Text = "继续"
                Label108.Text = "下一国家:"
                Call Form2.ChangeStatus(Dock_NationList.rolled, MyInfo.AppStatus.Idle)
                Form2.UserControl11.ClearList()
                Form2.UserControl11.SetVoteMode(False)
                Form2.UserControl11.SetPresents(Dock_NationList.pCount())
                Call voteClear()
                Me.Close()
        End Select
    End Sub

    Private Sub btnyes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnyes.Click
        Call vote(1, r2)
        btn_votectrl.Focus()
    End Sub

    Private Sub btnno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnno.Click
        Call vote(2, r2)
        btn_votectrl.Focus()
    End Sub

    Private Sub btnabst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabst.Click
        Call vote(3, r2)
        btn_votectrl.Focus()
    End Sub

    Private Sub btnpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpass.Click
        Call vote(4, r2)
        btn_votectrl.Focus()
    End Sub

    Private Sub chk_vote_foujue_CheckedChanged(sender As Object, e As EventArgs) Handles chk_vote_foujue.CheckedChanged
        Dim fxk() As CheckBox = New CheckBox() {CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6}
        If chk_vote_foujue.Checked = True Then
            For c = 0 To 4
                fxk(c).Enabled = True
            Next
        Else
            For c = 0 To 4
                fxk(c).Enabled = False
            Next
        End If
    End Sub

    Private Sub rad_50maj_CheckedChanged(sender As Object, e As EventArgs) Handles rad_50maj.CheckedChanged, rad_67maj.CheckedChanged, rad_80maj.CheckedChanged, rad_all.CheckedChanged, chk_noabst.CheckedChanged
        Call voteDisp()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click, ToolStripButton2.Click
        If sender.Equals(ToolStripButton1) Then
            If current > 1 Then current = current - 1
        Else
            If current < ((vtTotal - 1) \ 60 + 1) Then current = ((vtTotal - 1) \ 60 + 1)
        End If
        Form2.UserControl11.ClearList()
        For i = 1 To 60
            Form2.UserControl11.SetListItmeExt(i, nations(i + (current - 1) * 60), False)
            Form2.UserControl11.SetListItmeMarkupExt(i, opini(i + (current - 1) * 60))
            If i + (current - 1) * 60 = vtTotal Then Exit For
        Next
        Form2.UserControl11.SetPage(current, (vtTotal - 1) \ 60 + 1)
        ToolStripLabel1.Text = "页数 " + current.ToString + "/" + ((vtTotal - 1) \ 60 + 1).ToString
    End Sub
End Class