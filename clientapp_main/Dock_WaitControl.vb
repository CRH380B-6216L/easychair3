Imports LanguageScript

Public Class Dock_WaitControl
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

    Private Sub btn_delay_Click(sender As Object, e As EventArgs) Handles btn_delay.Click
        If panel_delayctrl.Visible = 0 Then
            panel_delayctrl.Visible = 1
        Else
            panel_delayctrl.Visible = 0
        End If
    End Sub

    Private Sub btn_stratnow_Click(sender As Object, e As EventArgs) Handles btn_stratnow.Click
        If MsgBox("现在开始会议吗？", 36, "会议开始") = 6 Then
            Form1.isWaiting = 0
            'Call record_v2.addNewrecord("ST", DateTime.Now, DateTime.Now, , , , session)
            'If Form1.isPlay(3) Then Call Form1.playSfx(3)
            Dock_MainScreen.lblmain.Text = Language1.infoString(6) + Form1.LoadedConference.ConferenceTitle + vbCrLf + Form1.LoadedConference.Committee + vbCrLf + Form1.LoadedConference.Topic(Form1.LoadedConference.topicSel) + vbCrLf + Language1.infoString(2) + Form1.session.ToString + Language1.infoString(3) + vbCrLf + Language1.infoString(14)
            panel_roll_string.Enabled = False
        End If
    End Sub

    Private Sub btn_delay_ok_Click(sender As Object, e As EventArgs) Handles btn_delay_ok.Click
        If Not num_delay.Value = 0 Then
            Form1.timeStart = Form1.timeStart.AddMinutes(num_delay.Value)
            Label17.Text = Form1.timeStart
            Label17.Text = "预计开始的时间:" + vbCrLf + Label17.Text
            Dim mm As String = Form1.timeStart.Minute.ToString
            If Form1.timeStart.Minute < 10 Then mm = 0 + mm
            Dock_MainScreen.lblmain.Text = Language1.infoString(6) + Form1.LoadedConference.ConferenceTitle + vbCrLf + Form1.LoadedConference.Committee + vbCrLf + Form1.LoadedConference.Topic(Form1.LoadedConference.topicSel) + vbCrLf + Language1.infoString(2) + Form1.session.ToString + Language1.infoString(3) + vbCrLf + Language1.infoString(13) + Form1.timeStart.Hour.ToString + ":" + Form1.timeStart.Minute.ToString
            panel_delayctrl.Visible = 0
        End If
    End Sub

    Private Sub Dock_WaitControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Me.MdiParent = Form1
    End Sub
End Class