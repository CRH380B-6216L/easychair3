<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Motion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Motion))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panel_m_4 = New System.Windows.Forms.Panel()
        Me.cbx_mfileselect = New System.Windows.Forms.ComboBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.panel_m_3 = New System.Windows.Forms.Panel()
        Me.num_m_spl_1 = New System.Windows.Forms.NumericUpDown()
        Me.num_m_spl_2 = New System.Windows.Forms.NumericUpDown()
        Me.Label185 = New System.Windows.Forms.Label()
        Me.panel_m_1 = New System.Windows.Forms.Panel()
        Me.num_m_mc_2 = New System.Windows.Forms.NumericUpDown()
        Me.Label184 = New System.Windows.Forms.Label()
        Me.panel_m_2 = New System.Windows.Forms.Panel()
        Me.num_m_umc = New System.Windows.Forms.NumericUpDown()
        Me.Label186 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panel_m_4.SuspendLayout()
        Me.panel_m_3.SuspendLayout()
        CType(Me.num_m_spl_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_m_spl_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_m_1.SuspendLayout()
        CType(Me.num_m_mc_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_m_2.SuspendLayout()
        CType(Me.num_m_umc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(95, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "确定"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "取消"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 152)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(253, 43)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.panel_m_4)
        Me.Panel2.Controls.Add(Me.panel_m_3)
        Me.Panel2.Controls.Add(Me.panel_m_1)
        Me.Panel2.Controls.Add(Me.panel_m_2)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(253, 152)
        Me.Panel2.TabIndex = 2
        '
        'panel_m_4
        '
        Me.panel_m_4.Controls.Add(Me.cbx_mfileselect)
        Me.panel_m_4.Controls.Add(Me.Label99)
        Me.panel_m_4.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_m_4.Location = New System.Drawing.Point(0, 183)
        Me.panel_m_4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panel_m_4.Name = "panel_m_4"
        Me.panel_m_4.Size = New System.Drawing.Size(253, 29)
        Me.panel_m_4.TabIndex = 16
        Me.panel_m_4.Visible = False
        '
        'cbx_mfileselect
        '
        Me.cbx_mfileselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_mfileselect.FormattingEnabled = True
        Me.cbx_mfileselect.Items.AddRange(New Object() {"决议草案1.2", "指令草案1.1", "决议草案1.4"})
        Me.cbx_mfileselect.Location = New System.Drawing.Point(57, 0)
        Me.cbx_mfileselect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbx_mfileselect.Name = "cbx_mfileselect"
        Me.cbx_mfileselect.Size = New System.Drawing.Size(115, 21)
        Me.cbx_mfileselect.TabIndex = 0
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label99.Location = New System.Drawing.Point(14, 4)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(190, 13)
        Me.Label99.TabIndex = 14
        Me.Label99.Text = "优先对 　　　　　　　　　　投票"
        '
        'panel_m_3
        '
        Me.panel_m_3.Controls.Add(Me.num_m_spl_1)
        Me.panel_m_3.Controls.Add(Me.num_m_spl_2)
        Me.panel_m_3.Controls.Add(Me.Label185)
        Me.panel_m_3.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_m_3.Location = New System.Drawing.Point(0, 154)
        Me.panel_m_3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panel_m_3.Name = "panel_m_3"
        Me.panel_m_3.Size = New System.Drawing.Size(253, 29)
        Me.panel_m_3.TabIndex = 17
        Me.panel_m_3.Visible = False
        '
        'num_m_spl_1
        '
        Me.num_m_spl_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.num_m_spl_1.Location = New System.Drawing.Point(74, 0)
        Me.num_m_spl_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.num_m_spl_1.Name = "num_m_spl_1"
        Me.num_m_spl_1.Size = New System.Drawing.Size(36, 20)
        Me.num_m_spl_1.TabIndex = 0
        Me.num_m_spl_1.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'num_m_spl_2
        '
        Me.num_m_spl_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.num_m_spl_2.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.num_m_spl_2.Location = New System.Drawing.Point(134, 0)
        Me.num_m_spl_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.num_m_spl_2.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.num_m_spl_2.Minimum = New Decimal(New Integer() {5, 0, 0, -2147483648})
        Me.num_m_spl_2.Name = "num_m_spl_2"
        Me.num_m_spl_2.Size = New System.Drawing.Size(36, 20)
        Me.num_m_spl_2.TabIndex = 1
        '
        'Label185
        '
        Me.Label185.AutoSize = True
        Me.Label185.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label185.Location = New System.Drawing.Point(13, 3)
        Me.Label185.Name = "Label185"
        Me.Label185.Size = New System.Drawing.Size(178, 13)
        Me.Label185.TabIndex = 7
        Me.Label185.Text = "调整为 　　　　　分　　　　秒"
        '
        'panel_m_1
        '
        Me.panel_m_1.Controls.Add(Me.num_m_mc_2)
        Me.panel_m_1.Controls.Add(Me.Label184)
        Me.panel_m_1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_m_1.Location = New System.Drawing.Point(0, 125)
        Me.panel_m_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panel_m_1.Name = "panel_m_1"
        Me.panel_m_1.Size = New System.Drawing.Size(253, 29)
        Me.panel_m_1.TabIndex = 14
        Me.panel_m_1.Visible = False
        '
        'num_m_mc_2
        '
        Me.num_m_mc_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.num_m_mc_2.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.num_m_mc_2.Location = New System.Drawing.Point(134, 0)
        Me.num_m_mc_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.num_m_mc_2.Name = "num_m_mc_2"
        Me.num_m_mc_2.Size = New System.Drawing.Size(36, 20)
        Me.num_m_mc_2.TabIndex = 0
        Me.num_m_mc_2.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'Label184
        '
        Me.Label184.AutoSize = True
        Me.Label184.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label184.Location = New System.Drawing.Point(13, 3)
        Me.Label184.Name = "Label184"
        Me.Label184.Size = New System.Drawing.Size(178, 13)
        Me.Label184.TabIndex = 12
        Me.Label184.Text = "每位代表发言时间 　　　　　秒"
        '
        'panel_m_2
        '
        Me.panel_m_2.Controls.Add(Me.num_m_umc)
        Me.panel_m_2.Controls.Add(Me.Label186)
        Me.panel_m_2.Controls.Add(Me.Button3)
        Me.panel_m_2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_m_2.Location = New System.Drawing.Point(0, 96)
        Me.panel_m_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panel_m_2.Name = "panel_m_2"
        Me.panel_m_2.Size = New System.Drawing.Size(253, 29)
        Me.panel_m_2.TabIndex = 15
        Me.panel_m_2.Visible = False
        '
        'num_m_umc
        '
        Me.num_m_umc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.num_m_umc.Location = New System.Drawing.Point(83, 0)
        Me.num_m_umc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.num_m_umc.Name = "num_m_umc"
        Me.num_m_umc.Size = New System.Drawing.Size(36, 20)
        Me.num_m_umc.TabIndex = 0
        Me.num_m_umc.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label186
        '
        Me.Label186.AutoSize = True
        Me.Label186.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label186.Location = New System.Drawing.Point(13, 3)
        Me.Label186.Name = "Label186"
        Me.Label186.Size = New System.Drawing.Size(139, 13)
        Me.Label186.TabIndex = 7
        Me.Label186.Text = "总时长为　　　　　分钟"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(213, -1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 22)
        Me.Button3.TabIndex = 1
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 67)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(253, 29)
        Me.Panel4.TabIndex = 5
        Me.Panel4.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(59, 0)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(148, 20)
        Me.TextBox2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "议题为"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(213, -1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 22)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(253, 67)
        Me.Panel3.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox1.Location = New System.Drawing.Point(12, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 20)
        Me.TextBox1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"有主持核心磋商", "自由磋商", "调整发言时间", "调整投票顺序", "对文件投票", "茶歇", "结束辩论", "休会"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 39)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(195, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "动议(一个)"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(213, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 22)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Motion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(253, 195)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Motion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Motion"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.panel_m_4.ResumeLayout(False)
        Me.panel_m_4.PerformLayout()
        Me.panel_m_3.ResumeLayout(False)
        Me.panel_m_3.PerformLayout()
        CType(Me.num_m_spl_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_m_spl_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_m_1.ResumeLayout(False)
        Me.panel_m_1.PerformLayout()
        CType(Me.num_m_mc_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_m_2.ResumeLayout(False)
        Me.panel_m_2.PerformLayout()
        CType(Me.num_m_umc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents panel_m_1 As System.Windows.Forms.Panel
    Friend WithEvents num_m_mc_2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label184 As System.Windows.Forms.Label
    Friend WithEvents panel_m_2 As System.Windows.Forms.Panel
    Friend WithEvents num_m_umc As System.Windows.Forms.NumericUpDown
    Private WithEvents Label186 As System.Windows.Forms.Label
    Friend WithEvents panel_m_4 As System.Windows.Forms.Panel
    Friend WithEvents cbx_mfileselect As System.Windows.Forms.ComboBox
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents panel_m_3 As System.Windows.Forms.Panel
    Friend WithEvents num_m_spl_1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_m_spl_2 As System.Windows.Forms.NumericUpDown
    Private WithEvents Label185 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
