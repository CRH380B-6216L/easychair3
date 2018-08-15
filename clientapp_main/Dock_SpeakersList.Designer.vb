<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dock_SpeakersList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dock_SpeakersList))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_spl_yieldto = New System.Windows.Forms.TextBox()
        Me.btn_spl_yieldend = New System.Windows.Forms.Button()
        Me.btn_spl_yieldgo = New System.Windows.Forms.Button()
        Me.cbx_spl_yield = New System.Windows.Forms.ComboBox()
        Me.btn_spl_start = New System.Windows.Forms.Button()
        Me.btn_spl_add = New System.Windows.Forms.Button()
        Me.txt_spl_current = New System.Windows.Forms.TextBox()
        Me.txt_spl_currentnunber = New System.Windows.Forms.TextBox()
        Me.txt_spl_add = New System.Windows.Forms.TextBox()
        Me.txt_spl_totalnumber = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch_nations = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch_script = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ch_mark = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(214, 536)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_spl_yieldto)
        Me.Panel1.Controls.Add(Me.btn_spl_yieldend)
        Me.Panel1.Controls.Add(Me.btn_spl_yieldgo)
        Me.Panel1.Controls.Add(Me.cbx_spl_yield)
        Me.Panel1.Controls.Add(Me.btn_spl_start)
        Me.Panel1.Controls.Add(Me.btn_spl_add)
        Me.Panel1.Controls.Add(Me.txt_spl_current)
        Me.Panel1.Controls.Add(Me.txt_spl_currentnunber)
        Me.Panel1.Controls.Add(Me.txt_spl_add)
        Me.Panel1.Controls.Add(Me.txt_spl_totalnumber)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label28)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(216, 150)
        Me.Panel1.TabIndex = 0
        '
        'txt_spl_yieldto
        '
        Me.txt_spl_yieldto.Location = New System.Drawing.Point(83, 89)
        Me.txt_spl_yieldto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_spl_yieldto.Name = "txt_spl_yieldto"
        Me.txt_spl_yieldto.Size = New System.Drawing.Size(114, 20)
        Me.txt_spl_yieldto.TabIndex = 27
        Me.txt_spl_yieldto.Visible = False
        '
        'btn_spl_yieldend
        '
        Me.btn_spl_yieldend.FlatAppearance.BorderSize = 0
        Me.btn_spl_yieldend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_spl_yieldend.Location = New System.Drawing.Point(139, 116)
        Me.btn_spl_yieldend.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_spl_yieldend.Name = "btn_spl_yieldend"
        Me.btn_spl_yieldend.Size = New System.Drawing.Size(63, 23)
        Me.btn_spl_yieldend.TabIndex = 29
        Me.btn_spl_yieldend.Text = "结束发言"
        Me.btn_spl_yieldend.UseVisualStyleBackColor = True
        Me.btn_spl_yieldend.Visible = False
        '
        'btn_spl_yieldgo
        '
        Me.btn_spl_yieldgo.FlatAppearance.BorderSize = 0
        Me.btn_spl_yieldgo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_spl_yieldgo.Location = New System.Drawing.Point(11, 116)
        Me.btn_spl_yieldgo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_spl_yieldgo.Name = "btn_spl_yieldgo"
        Me.btn_spl_yieldgo.Size = New System.Drawing.Size(122, 23)
        Me.btn_spl_yieldgo.TabIndex = 28
        Me.btn_spl_yieldgo.Text = "开始"
        Me.btn_spl_yieldgo.UseVisualStyleBackColor = True
        Me.btn_spl_yieldgo.Visible = False
        '
        'cbx_spl_yield
        '
        Me.cbx_spl_yield.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_spl_yield.Enabled = False
        Me.cbx_spl_yield.FormattingEnabled = True
        Me.cbx_spl_yield.Items.AddRange(New Object() {"请选择让渡方式", "让渡给他国代表", "让渡给问题", "让渡给评论", "让渡给主席"})
        Me.cbx_spl_yield.Location = New System.Drawing.Point(14, 62)
        Me.cbx_spl_yield.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbx_spl_yield.Name = "cbx_spl_yield"
        Me.cbx_spl_yield.Size = New System.Drawing.Size(188, 21)
        Me.cbx_spl_yield.TabIndex = 25
        '
        'btn_spl_start
        '
        Me.btn_spl_start.FlatAppearance.BorderSize = 0
        Me.btn_spl_start.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_spl_start.Location = New System.Drawing.Point(160, 34)
        Me.btn_spl_start.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_spl_start.Name = "btn_spl_start"
        Me.btn_spl_start.Size = New System.Drawing.Size(42, 23)
        Me.btn_spl_start.TabIndex = 24
        Me.btn_spl_start.Text = "开始"
        Me.btn_spl_start.UseVisualStyleBackColor = True
        '
        'btn_spl_add
        '
        Me.btn_spl_add.FlatAppearance.BorderSize = 0
        Me.btn_spl_add.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_spl_add.Location = New System.Drawing.Point(160, 8)
        Me.btn_spl_add.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_spl_add.Name = "btn_spl_add"
        Me.btn_spl_add.Size = New System.Drawing.Size(42, 23)
        Me.btn_spl_add.TabIndex = 23
        Me.btn_spl_add.Text = "确认"
        Me.btn_spl_add.UseVisualStyleBackColor = True
        '
        'txt_spl_current
        '
        Me.txt_spl_current.Location = New System.Drawing.Point(79, 36)
        Me.txt_spl_current.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_spl_current.Name = "txt_spl_current"
        Me.txt_spl_current.ReadOnly = True
        Me.txt_spl_current.Size = New System.Drawing.Size(74, 20)
        Me.txt_spl_current.TabIndex = 22
        '
        'txt_spl_currentnunber
        '
        Me.txt_spl_currentnunber.Location = New System.Drawing.Point(51, 36)
        Me.txt_spl_currentnunber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_spl_currentnunber.Name = "txt_spl_currentnunber"
        Me.txt_spl_currentnunber.ReadOnly = True
        Me.txt_spl_currentnunber.Size = New System.Drawing.Size(22, 20)
        Me.txt_spl_currentnunber.TabIndex = 21
        Me.txt_spl_currentnunber.Text = "0"
        '
        'txt_spl_add
        '
        Me.txt_spl_add.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_spl_add.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_spl_add.Location = New System.Drawing.Point(79, 10)
        Me.txt_spl_add.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_spl_add.Name = "txt_spl_add"
        Me.txt_spl_add.Size = New System.Drawing.Size(74, 20)
        Me.txt_spl_add.TabIndex = 20
        '
        'txt_spl_totalnumber
        '
        Me.txt_spl_totalnumber.Location = New System.Drawing.Point(51, 10)
        Me.txt_spl_totalnumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_spl_totalnumber.Name = "txt_spl_totalnumber"
        Me.txt_spl_totalnumber.ReadOnly = True
        Me.txt_spl_totalnumber.Size = New System.Drawing.Size(22, 20)
        Me.txt_spl_totalnumber.TabIndex = 19
        Me.txt_spl_totalnumber.Text = "1"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(12, 39)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 13)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "当前:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(12, 13)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(34, 13)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "新增:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(12, 94)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(154, 13)
        Me.Label28.TabIndex = 26
        Me.Label28.Text = "让渡给问题                     代表"
        Me.Label28.Visible = False
        '
        'Panel2
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel2, 2)
        Me.Panel2.Controls.Add(Me.ListView1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 150)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(214, 386)
        Me.Panel2.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ch_nations, Me.ch_script, Me.ch_mark})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(214, 386)
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
        'Dock_SpeakersList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 536)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(230, 186)
        Me.Name = "Dock_SpeakersList"
        Me.Text = "主发言名单"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_spl_yieldto As System.Windows.Forms.TextBox
    Friend WithEvents btn_spl_yieldend As System.Windows.Forms.Button
    Friend WithEvents btn_spl_yieldgo As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cbx_spl_yield As System.Windows.Forms.ComboBox
    Friend WithEvents btn_spl_start As System.Windows.Forms.Button
    Friend WithEvents btn_spl_add As System.Windows.Forms.Button
    Friend WithEvents txt_spl_current As System.Windows.Forms.TextBox
    Friend WithEvents txt_spl_currentnunber As System.Windows.Forms.TextBox
    Friend WithEvents txt_spl_add As System.Windows.Forms.TextBox
    Friend WithEvents txt_spl_totalnumber As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ch_nations As System.Windows.Forms.ColumnHeader
    Friend WithEvents ch_script As System.Windows.Forms.ColumnHeader
    Friend WithEvents ch_mark As System.Windows.Forms.ColumnHeader
End Class
