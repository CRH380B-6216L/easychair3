<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dock_RecordInput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dock_RecordInput))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.新建NToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.打开OToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.保存SToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.打印PToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.剪切UToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.复制CToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.粘贴PToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.帮助LToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.显示发言记录RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.显示评价CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新建NToolStripButton, Me.打开OToolStripButton, Me.保存SToolStripButton, Me.打印PToolStripButton, Me.toolStripSeparator, Me.剪切UToolStripButton, Me.复制CToolStripButton, Me.粘贴PToolStripButton, Me.toolStripSeparator1, Me.帮助LToolStripButton, Me.ToolStripSeparator2, Me.ToolStripSplitButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(374, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        '新建NToolStripButton
        '
        Me.新建NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.新建NToolStripButton.Image = CType(resources.GetObject("新建NToolStripButton.Image"), System.Drawing.Image)
        Me.新建NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.新建NToolStripButton.Name = "新建NToolStripButton"
        Me.新建NToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.新建NToolStripButton.Text = "新建(&N)"
        '
        '打开OToolStripButton
        '
        Me.打开OToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.打开OToolStripButton.Image = CType(resources.GetObject("打开OToolStripButton.Image"), System.Drawing.Image)
        Me.打开OToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.打开OToolStripButton.Name = "打开OToolStripButton"
        Me.打开OToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.打开OToolStripButton.Text = "打开(&O)"
        '
        '保存SToolStripButton
        '
        Me.保存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.保存SToolStripButton.Image = CType(resources.GetObject("保存SToolStripButton.Image"), System.Drawing.Image)
        Me.保存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.保存SToolStripButton.Name = "保存SToolStripButton"
        Me.保存SToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.保存SToolStripButton.Text = "保存(&S)"
        '
        '打印PToolStripButton
        '
        Me.打印PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.打印PToolStripButton.Image = CType(resources.GetObject("打印PToolStripButton.Image"), System.Drawing.Image)
        Me.打印PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.打印PToolStripButton.Name = "打印PToolStripButton"
        Me.打印PToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.打印PToolStripButton.Text = "打印(&P)"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        '剪切UToolStripButton
        '
        Me.剪切UToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.剪切UToolStripButton.Image = CType(resources.GetObject("剪切UToolStripButton.Image"), System.Drawing.Image)
        Me.剪切UToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.剪切UToolStripButton.Name = "剪切UToolStripButton"
        Me.剪切UToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.剪切UToolStripButton.Text = "剪切(&U)"
        '
        '复制CToolStripButton
        '
        Me.复制CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.复制CToolStripButton.Image = CType(resources.GetObject("复制CToolStripButton.Image"), System.Drawing.Image)
        Me.复制CToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.复制CToolStripButton.Name = "复制CToolStripButton"
        Me.复制CToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.复制CToolStripButton.Text = "复制(&C)"
        '
        '粘贴PToolStripButton
        '
        Me.粘贴PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.粘贴PToolStripButton.Image = CType(resources.GetObject("粘贴PToolStripButton.Image"), System.Drawing.Image)
        Me.粘贴PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.粘贴PToolStripButton.Name = "粘贴PToolStripButton"
        Me.粘贴PToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.粘贴PToolStripButton.Text = "粘贴(&P)"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        '帮助LToolStripButton
        '
        Me.帮助LToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.帮助LToolStripButton.Image = CType(resources.GetObject("帮助LToolStripButton.Image"), System.Drawing.Image)
        Me.帮助LToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.帮助LToolStripButton.Name = "帮助LToolStripButton"
        Me.帮助LToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.帮助LToolStripButton.Text = "帮助(&L)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.显示发言记录RToolStripMenuItem, Me.显示评价CToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripSplitButton1.Text = "显示发言记录"
        '
        '显示发言记录RToolStripMenuItem
        '
        Me.显示发言记录RToolStripMenuItem.Checked = True
        Me.显示发言记录RToolStripMenuItem.CheckOnClick = True
        Me.显示发言记录RToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.显示发言记录RToolStripMenuItem.Name = "显示发言记录RToolStripMenuItem"
        Me.显示发言记录RToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.显示发言记录RToolStripMenuItem.Text = "显示发言记录(&R)"
        '
        '显示评价CToolStripMenuItem
        '
        Me.显示评价CToolStripMenuItem.CheckOnClick = True
        Me.显示评价CToolStripMenuItem.Name = "显示评价CToolStripMenuItem"
        Me.显示评价CToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.显示评价CToolStripMenuItem.Text = "显示评价(&C)"
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 25)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(374, 310)
        Me.TextBox1.TabIndex = 1
        '
        'Dock_RecordInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 335)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dock_RecordInput"
        Me.Text = "RecordInput"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents 新建NToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents 打开OToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents 保存SToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents 打印PToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 剪切UToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents 复制CToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents 粘贴PToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 帮助LToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents 显示发言记录RToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 显示评价CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
