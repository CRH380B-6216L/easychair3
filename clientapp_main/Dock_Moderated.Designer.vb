<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dock_Moderated
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dock_Moderated))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch_nations = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch_script = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch_mark = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panel_mc = New System.Windows.Forms.Panel()
        Me.btn_mcnext = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.btn_mc_end = New System.Windows.Forms.Button()
        Me.btn_mc_start = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_mc_totalnumber = New System.Windows.Forms.TextBox()
        Me.txt_mc_add = New System.Windows.Forms.TextBox()
        Me.txt_mc_currentnumber = New System.Windows.Forms.TextBox()
        Me.txt_mc_current = New System.Windows.Forms.TextBox()
        Me.btn_mc_add = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panel_mc.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.panel_mc, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Enabled = False
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(813, 151)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(216, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel2, 2)
        Me.Panel2.Size = New System.Drawing.Size(597, 151)
        Me.Panel2.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ch_nations, Me.ch_script, Me.ch_mark})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(12, 13)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(573, 126)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "*"
        Me.ColumnHeader1.Width = 21
        '
        'ch_nations
        '
        Me.ch_nations.Text = "国家"
        Me.ch_nations.Width = 115
        '
        'ch_script
        '
        Me.ch_script.Text = "记录"
        Me.ch_script.Width = 251
        '
        'ch_mark
        '
        Me.ch_mark.Text = "评价"
        Me.ch_mark.Width = 181
        '
        'panel_mc
        '
        Me.panel_mc.Controls.Add(Me.btn_mcnext)
        Me.panel_mc.Controls.Add(Me.Label33)
        Me.panel_mc.Controls.Add(Me.btn_mc_end)
        Me.panel_mc.Controls.Add(Me.btn_mc_start)
        Me.panel_mc.Controls.Add(Me.Label31)
        Me.panel_mc.Controls.Add(Me.Label32)
        Me.panel_mc.Controls.Add(Me.txt_mc_totalnumber)
        Me.panel_mc.Controls.Add(Me.txt_mc_add)
        Me.panel_mc.Controls.Add(Me.txt_mc_currentnumber)
        Me.panel_mc.Controls.Add(Me.txt_mc_current)
        Me.panel_mc.Controls.Add(Me.btn_mc_add)
        Me.panel_mc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_mc.Location = New System.Drawing.Point(0, 0)
        Me.panel_mc.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_mc.Name = "panel_mc"
        Me.panel_mc.Size = New System.Drawing.Size(216, 123)
        Me.panel_mc.TabIndex = 8
        '
        'btn_mcnext
        '
        Me.btn_mcnext.FlatAppearance.BorderSize = 0
        Me.btn_mcnext.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_mcnext.Location = New System.Drawing.Point(139, 82)
        Me.btn_mcnext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_mcnext.Name = "btn_mcnext"
        Me.btn_mcnext.Size = New System.Drawing.Size(63, 23)
        Me.btn_mcnext.TabIndex = 29
        Me.btn_mcnext.Text = "下一个"
        Me.btn_mcnext.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label33.Location = New System.Drawing.Point(12, 10)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(127, 13)
        Me.Label33.TabIndex = 13
        Me.Label33.Text = "未进入有主持核心磋商"
        '
        'btn_mc_end
        '
        Me.btn_mc_end.FlatAppearance.BorderSize = 0
        Me.btn_mc_end.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_mc_end.Location = New System.Drawing.Point(14, 82)
        Me.btn_mc_end.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_mc_end.Name = "btn_mc_end"
        Me.btn_mc_end.Size = New System.Drawing.Size(119, 23)
        Me.btn_mc_end.TabIndex = 12
        Me.btn_mc_end.Text = "结束/提前结束"
        Me.btn_mc_end.UseVisualStyleBackColor = True
        '
        'btn_mc_start
        '
        Me.btn_mc_start.FlatAppearance.BorderSize = 0
        Me.btn_mc_start.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_mc_start.Location = New System.Drawing.Point(160, 55)
        Me.btn_mc_start.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_mc_start.Name = "btn_mc_start"
        Me.btn_mc_start.Size = New System.Drawing.Size(42, 23)
        Me.btn_mc_start.TabIndex = 11
        Me.btn_mc_start.Text = "开始"
        Me.btn_mc_start.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label31.Location = New System.Drawing.Point(12, 35)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(34, 13)
        Me.Label31.TabIndex = 3
        Me.Label31.Text = "新增:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(12, 60)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(34, 13)
        Me.Label32.TabIndex = 4
        Me.Label32.Text = "当前:"
        '
        'txt_mc_totalnumber
        '
        Me.txt_mc_totalnumber.Location = New System.Drawing.Point(51, 31)
        Me.txt_mc_totalnumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_mc_totalnumber.Name = "txt_mc_totalnumber"
        Me.txt_mc_totalnumber.ReadOnly = True
        Me.txt_mc_totalnumber.Size = New System.Drawing.Size(22, 20)
        Me.txt_mc_totalnumber.TabIndex = 6
        Me.txt_mc_totalnumber.Text = "1"
        '
        'txt_mc_add
        '
        Me.txt_mc_add.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_mc_add.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_mc_add.Location = New System.Drawing.Point(79, 31)
        Me.txt_mc_add.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_mc_add.Name = "txt_mc_add"
        Me.txt_mc_add.Size = New System.Drawing.Size(74, 20)
        Me.txt_mc_add.TabIndex = 7
        '
        'txt_mc_currentnumber
        '
        Me.txt_mc_currentnumber.Location = New System.Drawing.Point(51, 57)
        Me.txt_mc_currentnumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_mc_currentnumber.Name = "txt_mc_currentnumber"
        Me.txt_mc_currentnumber.ReadOnly = True
        Me.txt_mc_currentnumber.Size = New System.Drawing.Size(22, 20)
        Me.txt_mc_currentnumber.TabIndex = 8
        Me.txt_mc_currentnumber.Text = "0"
        '
        'txt_mc_current
        '
        Me.txt_mc_current.Location = New System.Drawing.Point(79, 57)
        Me.txt_mc_current.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_mc_current.Name = "txt_mc_current"
        Me.txt_mc_current.ReadOnly = True
        Me.txt_mc_current.Size = New System.Drawing.Size(74, 20)
        Me.txt_mc_current.TabIndex = 9
        '
        'btn_mc_add
        '
        Me.btn_mc_add.FlatAppearance.BorderSize = 0
        Me.btn_mc_add.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_mc_add.Location = New System.Drawing.Point(160, 29)
        Me.btn_mc_add.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_mc_add.Name = "btn_mc_add"
        Me.btn_mc_add.Size = New System.Drawing.Size(42, 23)
        Me.btn_mc_add.TabIndex = 10
        Me.btn_mc_add.Text = "确认"
        Me.btn_mc_add.UseVisualStyleBackColor = True
        '
        'Dock_Moderated
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 151)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dock_Moderated"
        Me.Text = "Moderated"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.panel_mc.ResumeLayout(False)
        Me.panel_mc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_mcnext As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ch_nations As System.Windows.Forms.ColumnHeader
    Friend WithEvents ch_script As System.Windows.Forms.ColumnHeader
    Friend WithEvents ch_mark As System.Windows.Forms.ColumnHeader
    Friend WithEvents panel_mc As System.Windows.Forms.Panel
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents btn_mc_end As System.Windows.Forms.Button
    Friend WithEvents btn_mc_start As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txt_mc_totalnumber As System.Windows.Forms.TextBox
    Friend WithEvents txt_mc_add As System.Windows.Forms.TextBox
    Friend WithEvents txt_mc_currentnumber As System.Windows.Forms.TextBox
    Friend WithEvents txt_mc_current As System.Windows.Forms.TextBox
    Friend WithEvents btn_mc_add As System.Windows.Forms.Button
End Class
