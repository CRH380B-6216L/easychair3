Imports System.Windows.Forms
Imports StandardConfData

Public Class cabinet
    'Dim x() As Integer = {1, 2, 3, 5, 10, 20, 30, 60, 120, 180, 360, 720, 1440}
    Public  cabintime As MyInfo.CabinetSetting

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        cabintime = New MyInfo.CabinetSetting(CheckBox1.Checked, New Date(Year(DateTimePicker1.Value), Month(DateTimePicker1.Value), Microsoft.VisualBasic.DateAndTime.Day(DateTimePicker1.Value), numhh.Value, nummm.Value, 0), NumericUpDown1.Value)

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cabinet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cabintime As Date
        CheckBox1.Checked = Form1.nCabinetSetting.isCabinet
        cabintime = Form1.nCabinetSetting.cabintime
        NumericUpDown1.Value = Form1.nCabinetSetting.RawRate
        If CheckBox1.Checked = False Then NumericUpDown1.Value = 1
        If CheckBox1.Checked = False Then
            DateTimePicker1.Value = Date.Today
            numhh.Value = Hour(TimeOfDay)
            nummm.Value = Minute(TimeOfDay)
        Else
            DateTimePicker1.Value = cabintime
            numhh.Value = Hour(cabintime)
            nummm.Value = Minute(cabintime)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            Label1.Enabled = False
            Label2.Enabled = False
            Label3.Enabled = False
            Label4.Enabled = False
            DateTimePicker1.Enabled = False
            numhh.Enabled = False
            nummm.Enabled = False
            NumericUpDown1.Enabled = False
        Else
            Label1.Enabled = True
            Label2.Enabled = True
            Label3.Enabled = True
            Label4.Enabled = True
            DateTimePicker1.Enabled = True
            numhh.Enabled = True
            nummm.Enabled = True
            NumericUpDown1.Enabled = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dock_MainScreen.lblmain.Text = "倍数—内阁时间/现实时间比例" + vbCrLf + "1x—1分钟/1分钟" + vbCrLf + "2x—2分钟/1分钟" + vbCrLf + "3x—3分钟/1分钟" + vbCrLf + "5x—5分钟/1分钟" + vbCrLf + "10x—10分钟/1分钟" + vbCrLf + "20x—20分钟/1分钟" + vbCrLf + "30x—30分钟/1分钟" + vbCrLf + "60x—1小时/1分钟" + vbCrLf + "120x—2小时/1分钟" + vbCrLf + "180x—3小时/1分钟" + vbCrLf + "360x—6小时/1分钟" + vbCrLf + "720x—12小时/1分钟" + vbCrLf + "1440x—1天/1分钟"
        'If loadnsave.langload = 1 Then
        'Form1.lblmain.Text = "倍数—内阁时间/现实时间比例" + vbCrLf + "1x—1分钟/1分钟" + vbCrLf + "2x—2分钟/1分钟" + vbCrLf + "3x—3分钟/1分钟" + vbCrLf + "5x—5分钟/1分钟" + vbCrLf + "10x—10分钟/1分钟" + vbCrLf + "20x—20分钟/1分钟" + vbCrLf + "30x—30分钟/1分钟" + vbCrLf + "60x—1小时/1分钟" + vbCrLf + "120x—2小时/1分钟" + vbCrLf + "180x—3小时/1分钟" + vbCrLf + "360x—6小时/1分钟" + vbCrLf + "720x—12小时/1分钟" + vbCrLf + "1440x—1天/1分钟"
        'Else
        'Form1.lblmain.Text = "Multiple - Ratio of Cabinet-time/Real-time" + vbCrLf + "1x - 1 min/1 min" + vbCrLf + "2x - 2 min/1 min" + vbCrLf + "3x - 3 min/1 min" + vbCrLf + "5x - 5 min/1 min" + vbCrLf + "10x - 10 min/1 min" + vbCrLf + "20x - 20 min/1 min" + vbCrLf + "30x - 30 min/1 min" + vbCrLf + "60x - 1 hr/1 min" + vbCrLf + "120x - 2 hr/1 min" + vbCrLf + "180x - 3 hr/1 min" + vbCrLf + "360x - 6 hr/1 min" + vbCrLf + "720x - 12 hr/1 min" + vbCrLf + "1440x - 1 day/1 min"
        'End If
    End Sub
End Class
