<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dock_WaitControl
    Inherits WeifenLuo.WinFormsUI.Docking.DockContent

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dock_WaitControl))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.panel_roll_string = New System.Windows.Forms.Panel()
        Me.panel_delayctrl = New System.Windows.Forms.Panel()
        Me.btn_delay_ok = New System.Windows.Forms.Button()
        Me.num_delay = New System.Windows.Forms.NumericUpDown()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.btn_delay = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_stratnow = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panel_roll_string.SuspendLayout()
        Me.panel_delayctrl.SuspendLayout()
        CType(Me.num_delay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.panel_roll_string, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(214, 108)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'panel_roll_string
        '
        Me.panel_roll_string.Controls.Add(Me.panel_delayctrl)
        Me.panel_roll_string.Controls.Add(Me.btn_delay)
        Me.panel_roll_string.Controls.Add(Me.Label17)
        Me.panel_roll_string.Controls.Add(Me.btn_stratnow)
        Me.panel_roll_string.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_roll_string.Enabled = False
        Me.panel_roll_string.Location = New System.Drawing.Point(-1, 0)
        Me.panel_roll_string.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_roll_string.Name = "panel_roll_string"
        Me.panel_roll_string.Size = New System.Drawing.Size(216, 105)
        Me.panel_roll_string.TabIndex = 13
        '
        'panel_delayctrl
        '
        Me.panel_delayctrl.Controls.Add(Me.btn_delay_ok)
        Me.panel_delayctrl.Controls.Add(Me.num_delay)
        Me.panel_delayctrl.Controls.Add(Me.Label107)
        Me.panel_delayctrl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_delayctrl.Location = New System.Drawing.Point(0, 70)
        Me.panel_delayctrl.Name = "panel_delayctrl"
        Me.panel_delayctrl.Size = New System.Drawing.Size(216, 35)
        Me.panel_delayctrl.TabIndex = 15
        Me.panel_delayctrl.Visible = False
        '
        'btn_delay_ok
        '
        Me.btn_delay_ok.FlatAppearance.BorderSize = 0
        Me.btn_delay_ok.Location = New System.Drawing.Point(161, 5)
        Me.btn_delay_ok.Name = "btn_delay_ok"
        Me.btn_delay_ok.Size = New System.Drawing.Size(45, 23)
        Me.btn_delay_ok.TabIndex = 12
        Me.btn_delay_ok.Text = "确定"
        Me.btn_delay_ok.UseVisualStyleBackColor = True
        '
        'num_delay
        '
        Me.num_delay.Location = New System.Drawing.Point(47, 7)
        Me.num_delay.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.num_delay.Name = "num_delay"
        Me.num_delay.Size = New System.Drawing.Size(32, 20)
        Me.num_delay.TabIndex = 0
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Location = New System.Drawing.Point(15, 9)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(142, 13)
        Me.Label107.TabIndex = 1
        Me.Label107.Text = "延迟　　　 分钟开始会议"
        '
        'btn_delay
        '
        Me.btn_delay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_delay.FlatAppearance.BorderSize = 0
        Me.btn_delay.Location = New System.Drawing.Point(112, 42)
        Me.btn_delay.Name = "btn_delay"
        Me.btn_delay.Size = New System.Drawing.Size(89, 23)
        Me.btn_delay.TabIndex = 14
        Me.btn_delay.Text = "延迟"
        Me.btn_delay.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(15, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 26)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "预计开始的时间:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2014-9-29 20:32:43"
        '
        'btn_stratnow
        '
        Me.btn_stratnow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_stratnow.FlatAppearance.BorderSize = 0
        Me.btn_stratnow.Location = New System.Drawing.Point(17, 42)
        Me.btn_stratnow.Name = "btn_stratnow"
        Me.btn_stratnow.Size = New System.Drawing.Size(89, 23)
        Me.btn_stratnow.TabIndex = 13
        Me.btn_stratnow.Text = "立即开始"
        Me.btn_stratnow.UseVisualStyleBackColor = True
        '
        'Dock_WaitControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 108)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(230, 144)
        Me.Name = "Dock_WaitControl"
        Me.ShowInTaskbar = False
        Me.Text = "等待控制"
        Me.TopMost = True
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.panel_roll_string.ResumeLayout(False)
        Me.panel_roll_string.PerformLayout()
        Me.panel_delayctrl.ResumeLayout(False)
        Me.panel_delayctrl.PerformLayout()
        CType(Me.num_delay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panel_roll_string As System.Windows.Forms.Panel
    Friend WithEvents panel_delayctrl As System.Windows.Forms.Panel
    Friend WithEvents btn_delay_ok As System.Windows.Forms.Button
    Friend WithEvents num_delay As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents btn_delay As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btn_stratnow As System.Windows.Forms.Button
End Class
