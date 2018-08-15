<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewSession
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsession = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.numstartm = New System.Windows.Forms.NumericUpDown()
        Me.rad_immediatestart = New System.Windows.Forms.RadioButton()
        Me.numstarth = New System.Windows.Forms.NumericUpDown()
        Me.rad_timedstart = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.numstartm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numstarth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(102, 128)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 27)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 21)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "确定"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 21)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "取消"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BJMUNC2013  联合国粮农组织" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "长期性的非洲粮食问题"
        '
        'txtsession
        '
        Me.txtsession.Location = New System.Drawing.Point(69, 54)
        Me.txtsession.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsession.Name = "txtsession"
        Me.txtsession.Size = New System.Drawing.Size(40, 21)
        Me.txtsession.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(14, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(125, 12)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "会议的第　　　　会期"
        '
        'numstartm
        '
        Me.numstartm.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numstartm.Location = New System.Drawing.Point(153, 99)
        Me.numstartm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numstartm.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.numstartm.Name = "numstartm"
        Me.numstartm.Size = New System.Drawing.Size(32, 21)
        Me.numstartm.TabIndex = 15
        '
        'rad_immediatestart
        '
        Me.rad_immediatestart.AutoSize = True
        Me.rad_immediatestart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rad_immediatestart.Location = New System.Drawing.Point(16, 77)
        Me.rad_immediatestart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rad_immediatestart.Name = "rad_immediatestart"
        Me.rad_immediatestart.Size = New System.Drawing.Size(71, 16)
        Me.rad_immediatestart.TabIndex = 16
        Me.rad_immediatestart.Text = "立即开始"
        Me.rad_immediatestart.UseVisualStyleBackColor = True
        '
        'numstarth
        '
        Me.numstarth.Location = New System.Drawing.Point(99, 99)
        Me.numstarth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.numstarth.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.numstarth.Name = "numstarth"
        Me.numstarth.Size = New System.Drawing.Size(32, 21)
        Me.numstarth.TabIndex = 14
        Me.numstarth.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'rad_timedstart
        '
        Me.rad_timedstart.AutoSize = True
        Me.rad_timedstart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rad_timedstart.Location = New System.Drawing.Point(16, 100)
        Me.rad_timedstart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rad_timedstart.Name = "rad_timedstart"
        Me.rad_timedstart.Size = New System.Drawing.Size(191, 16)
        Me.rad_timedstart.TabIndex = 17
        Me.rad_timedstart.Text = "指定时间: 　　　 时　　　 分"
        Me.rad_timedstart.UseVisualStyleBackColor = True
        '
        'NewSession
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(260, 166)
        Me.Controls.Add(Me.txtsession)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.numstartm)
        Me.Controls.Add(Me.rad_immediatestart)
        Me.Controls.Add(Me.numstarth)
        Me.Controls.Add(Me.rad_timedstart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewSession"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "NewSession"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.numstartm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numstarth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsession As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents numstartm As System.Windows.Forms.NumericUpDown
    Friend WithEvents rad_immediatestart As System.Windows.Forms.RadioButton
    Friend WithEvents numstarth As System.Windows.Forms.NumericUpDown
    Friend WithEvents rad_timedstart As System.Windows.Forms.RadioButton

End Class
