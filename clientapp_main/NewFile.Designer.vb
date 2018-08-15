<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewFile
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
        Me.panel_selfile = New System.Windows.Forms.Panel()
        Me.lbl_filepath = New System.Windows.Forms.TextBox()
        Me.btn_file_browse = New System.Windows.Forms.Button()
        Me.Label191 = New System.Windows.Forms.Label()
        Me.panel_f_1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_filenumber_2 = New System.Windows.Forms.TextBox()
        Me.txt_filenumber_1 = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.cbx_ftpye = New System.Windows.Forms.ComboBox()
        Me.txt_filenumber_3 = New System.Windows.Forms.TextBox()
        Me.num_file = New System.Windows.Forms.NumericUpDown()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.ofd_doc = New System.Windows.Forms.OpenFileDialog()
        Me.panel_signatories = New System.Windows.Forms.Panel()
        Me.txt_file_signatories = New System.Windows.Forms.TextBox()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.panel_sponsors = New System.Windows.Forms.Panel()
        Me.txt_file_sponsors = New System.Windows.Forms.TextBox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.panel_selfile.SuspendLayout()
        Me.panel_f_1.SuspendLayout()
        CType(Me.num_file, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_signatories.SuspendLayout()
        Me.panel_sponsors.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(55, 209)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 27)
        Me.TableLayoutPanel1.TabIndex = 4
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
        'panel_selfile
        '
        Me.panel_selfile.Controls.Add(Me.lbl_filepath)
        Me.panel_selfile.Controls.Add(Me.btn_file_browse)
        Me.panel_selfile.Controls.Add(Me.Label191)
        Me.panel_selfile.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_selfile.Location = New System.Drawing.Point(0, 155)
        Me.panel_selfile.Name = "panel_selfile"
        Me.panel_selfile.Size = New System.Drawing.Size(213, 54)
        Me.panel_selfile.TabIndex = 3
        '
        'lbl_filepath
        '
        Me.lbl_filepath.Location = New System.Drawing.Point(15, 26)
        Me.lbl_filepath.Name = "lbl_filepath"
        Me.lbl_filepath.ReadOnly = True
        Me.lbl_filepath.Size = New System.Drawing.Size(185, 21)
        Me.lbl_filepath.TabIndex = 1
        '
        'btn_file_browse
        '
        Me.btn_file_browse.FlatAppearance.BorderSize = 0
        Me.btn_file_browse.Location = New System.Drawing.Point(126, 1)
        Me.btn_file_browse.Name = "btn_file_browse"
        Me.btn_file_browse.Size = New System.Drawing.Size(75, 21)
        Me.btn_file_browse.TabIndex = 0
        Me.btn_file_browse.Text = "浏览(&B)..."
        Me.btn_file_browse.UseVisualStyleBackColor = True
        '
        'Label191
        '
        Me.Label191.AutoSize = True
        Me.Label191.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label191.Location = New System.Drawing.Point(12, 6)
        Me.Label191.Name = "Label191"
        Me.Label191.Size = New System.Drawing.Size(53, 12)
        Me.Label191.TabIndex = 0
        Me.Label191.Text = "选择文件"
        '
        'panel_f_1
        '
        Me.panel_f_1.Controls.Add(Me.txt_filenumber_3)
        Me.panel_f_1.Controls.Add(Me.TextBox1)
        Me.panel_f_1.Controls.Add(Me.txt_filenumber_2)
        Me.panel_f_1.Controls.Add(Me.txt_filenumber_1)
        Me.panel_f_1.Controls.Add(Me.Label35)
        Me.panel_f_1.Controls.Add(Me.Label103)
        Me.panel_f_1.Controls.Add(Me.cbx_ftpye)
        Me.panel_f_1.Controls.Add(Me.num_file)
        Me.panel_f_1.Controls.Add(Me.Label104)
        Me.panel_f_1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_f_1.Location = New System.Drawing.Point(0, 0)
        Me.panel_f_1.Name = "panel_f_1"
        Me.panel_f_1.Size = New System.Drawing.Size(213, 83)
        Me.panel_f_1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(105, 21)
        Me.TextBox1.TabIndex = 1
        '
        'txt_filenumber_2
        '
        Me.txt_filenumber_2.Location = New System.Drawing.Point(154, 34)
        Me.txt_filenumber_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_filenumber_2.Name = "txt_filenumber_2"
        Me.txt_filenumber_2.Size = New System.Drawing.Size(18, 21)
        Me.txt_filenumber_2.TabIndex = 3
        '
        'txt_filenumber_1
        '
        Me.txt_filenumber_1.Location = New System.Drawing.Point(126, 34)
        Me.txt_filenumber_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_filenumber_1.Name = "txt_filenumber_1"
        Me.txt_filenumber_1.Size = New System.Drawing.Size(18, 21)
        Me.txt_filenumber_1.TabIndex = 2
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(12, 11)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(53, 12)
        Me.Label35.TabIndex = 4
        Me.Label35.Text = "文件类型"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label103.Location = New System.Drawing.Point(145, 38)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(41, 12)
        Me.Label103.TabIndex = 5
        Me.Label103.Text = ".　　."
        '
        'cbx_ftpye
        '
        Me.cbx_ftpye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_ftpye.FormattingEnabled = True
        Me.cbx_ftpye.Items.AddRange(New Object() {"工作文件", "决议草案", "修正案", "指令草案"})
        Me.cbx_ftpye.Location = New System.Drawing.Point(73, 7)
        Me.cbx_ftpye.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbx_ftpye.Name = "cbx_ftpye"
        Me.cbx_ftpye.Size = New System.Drawing.Size(127, 20)
        Me.cbx_ftpye.TabIndex = 0
        '
        'txt_filenumber_3
        '
        Me.txt_filenumber_3.Location = New System.Drawing.Point(182, 34)
        Me.txt_filenumber_3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_filenumber_3.Name = "txt_filenumber_3"
        Me.txt_filenumber_3.Size = New System.Drawing.Size(18, 21)
        Me.txt_filenumber_3.TabIndex = 4
        '
        'num_file
        '
        Me.num_file.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.num_file.Location = New System.Drawing.Point(73, 56)
        Me.num_file.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.num_file.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.num_file.Name = "num_file"
        Me.num_file.Size = New System.Drawing.Size(35, 21)
        Me.num_file.TabIndex = 5
        Me.num_file.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label104.Location = New System.Drawing.Point(12, 59)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(125, 12)
        Me.Label104.TabIndex = 1
        Me.Label104.Text = "阅读时间　　　　分钟"
        '
        'ofd_doc
        '
        Me.ofd_doc.Filter = "Microsoft Word Document (*.doc;*.docx)|*.doc;*.docx"
        '
        'panel_signatories
        '
        Me.panel_signatories.Controls.Add(Me.txt_file_signatories)
        Me.panel_signatories.Controls.Add(Me.Label106)
        Me.panel_signatories.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_signatories.Location = New System.Drawing.Point(0, 131)
        Me.panel_signatories.Name = "panel_signatories"
        Me.panel_signatories.Size = New System.Drawing.Size(213, 24)
        Me.panel_signatories.TabIndex = 2
        '
        'txt_file_signatories
        '
        Me.txt_file_signatories.Location = New System.Drawing.Point(61, 1)
        Me.txt_file_signatories.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_file_signatories.Name = "txt_file_signatories"
        Me.txt_file_signatories.ReadOnly = True
        Me.txt_file_signatories.Size = New System.Drawing.Size(139, 21)
        Me.txt_file_signatories.TabIndex = 0
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label106.Location = New System.Drawing.Point(12, 4)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(41, 12)
        Me.Label106.TabIndex = 3
        Me.Label106.Text = "附议国"
        '
        'panel_sponsors
        '
        Me.panel_sponsors.Controls.Add(Me.txt_file_sponsors)
        Me.panel_sponsors.Controls.Add(Me.Label105)
        Me.panel_sponsors.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_sponsors.Location = New System.Drawing.Point(0, 107)
        Me.panel_sponsors.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.panel_sponsors.Name = "panel_sponsors"
        Me.panel_sponsors.Size = New System.Drawing.Size(213, 24)
        Me.panel_sponsors.TabIndex = 1
        '
        'txt_file_sponsors
        '
        Me.txt_file_sponsors.Location = New System.Drawing.Point(61, 0)
        Me.txt_file_sponsors.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_file_sponsors.Name = "txt_file_sponsors"
        Me.txt_file_sponsors.ReadOnly = True
        Me.txt_file_sponsors.Size = New System.Drawing.Size(139, 21)
        Me.txt_file_sponsors.TabIndex = 0
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label105.Location = New System.Drawing.Point(12, 4)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(41, 12)
        Me.Label105.TabIndex = 2
        Me.Label105.Text = "起草国"
        '
        'BackgroundWorker1
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(213, 24)
        Me.Panel1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 21)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "设置起草国/附议国(&E)..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NewFile
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(213, 246)
        Me.Controls.Add(Me.panel_selfile)
        Me.Controls.Add(Me.panel_signatories)
        Me.Controls.Add(Me.panel_sponsors)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panel_f_1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewFile"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "发布新文件"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.panel_selfile.ResumeLayout(False)
        Me.panel_selfile.PerformLayout()
        Me.panel_f_1.ResumeLayout(False)
        Me.panel_f_1.PerformLayout()
        CType(Me.num_file, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_signatories.ResumeLayout(False)
        Me.panel_signatories.PerformLayout()
        Me.panel_sponsors.ResumeLayout(False)
        Me.panel_sponsors.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents panel_selfile As System.Windows.Forms.Panel
    Friend WithEvents lbl_filepath As System.Windows.Forms.TextBox
    Friend WithEvents btn_file_browse As System.Windows.Forms.Button
    Friend WithEvents Label191 As System.Windows.Forms.Label
    Friend WithEvents panel_f_1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_filenumber_2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_filenumber_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents cbx_ftpye As System.Windows.Forms.ComboBox
    Friend WithEvents txt_filenumber_3 As System.Windows.Forms.TextBox
    Friend WithEvents num_file As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents ofd_doc As System.Windows.Forms.OpenFileDialog
    Friend WithEvents panel_signatories As System.Windows.Forms.Panel
    Friend WithEvents txt_file_signatories As System.Windows.Forms.TextBox
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents panel_sponsors As System.Windows.Forms.Panel
    Friend WithEvents txt_file_sponsors As System.Windows.Forms.TextBox
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
End Class
