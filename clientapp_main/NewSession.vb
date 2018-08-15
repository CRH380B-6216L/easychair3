Imports System.Windows.Forms

Public Class NewSession

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If txtsession.Text = "" Then
            txtsession.Select()
        Else
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub NewSession_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Form1.LoadedConference.ConferenceTitle + "  " + Form1.LoadedConference.Committee + vbCrLf + Form1.LoadedConference.Topic(Form1.LoadedConference.topicSel)
        Me.Width = Label1.Width + Label1.Left * 2
        rad_immediatestart.Checked = True
    End Sub

    Private Sub rad_immediatestart_CheckedChanged(sender As Object, e As EventArgs) Handles rad_immediatestart.CheckedChanged
        If rad_timedstart.Checked Then
            numstarth.Enabled = True
            numstartm.Enabled = True
            numstartm.Value = TimeOfDay.Minute + (5 - TimeOfDay.Minute Mod 5)
            numstarth.Value = TimeOfDay.Hour
            If numstartm.Value = 60 Then
                numstartm.Value = 0
                numstarth.Value = numstarth.Value + 1
            End If
        Else
            numstarth.Enabled = False
            numstartm.Enabled = False
        End If
    End Sub
End Class
