<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vote
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vote))
        Me.chk_noabst = New System.Windows.Forms.CheckBox()
        Me.rad_all = New System.Windows.Forms.RadioButton()
        Me.rad_80maj = New System.Windows.Forms.RadioButton()
        Me.rad_67maj = New System.Windows.Forms.RadioButton()
        Me.rad_50maj = New System.Windows.Forms.RadioButton()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.chk_vote_foujue = New System.Windows.Forms.CheckBox()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.btnpass = New System.Windows.Forms.Button()
        Me.btnabst = New System.Windows.Forms.Button()
        Me.btnno = New System.Windows.Forms.Button()
        Me.btnyes = New System.Windows.Forms.Button()
        Me.lbl_vote_nation = New System.Windows.Forms.Label()
        Me.lblno = New System.Windows.Forms.Label()
        Me.lblyes = New System.Windows.Forms.Label()
        Me.lblabst = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.nation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.bote = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_votectrl = New System.Windows.Forms.Button()
        Me.comp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chk_noabst
        '
        Me.chk_noabst.AutoSize = True
        Me.chk_noabst.Checked = True
        Me.chk_noabst.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_noabst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chk_noabst.Location = New System.Drawing.Point(99, 121)
        Me.chk_noabst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_noabst.Name = "chk_noabst"
        Me.chk_noabst.Size = New System.Drawing.Size(86, 17)
        Me.chk_noabst.TabIndex = 10
        Me.chk_noabst.Text = "不计弃权票"
        Me.chk_noabst.UseVisualStyleBackColor = True
        '
        'rad_all
        '
        Me.rad_all.AutoSize = True
        Me.rad_all.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rad_all.Location = New System.Drawing.Point(99, 101)
        Me.rad_all.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rad_all.Name = "rad_all"
        Me.rad_all.Size = New System.Drawing.Size(49, 17)
        Me.rad_all.TabIndex = 9
        Me.rad_all.Text = "全部"
        Me.rad_all.UseVisualStyleBackColor = True
        '
        'rad_80maj
        '
        Me.rad_80maj.AutoSize = True
        Me.rad_80maj.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rad_80maj.Location = New System.Drawing.Point(99, 81)
        Me.rad_80maj.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rad_80maj.Name = "rad_80maj"
        Me.rad_80maj.Size = New System.Drawing.Size(45, 17)
        Me.rad_80maj.TabIndex = 8
        Me.rad_80maj.Text = "80%"
        Me.rad_80maj.UseVisualStyleBackColor = True
        '
        'rad_67maj
        '
        Me.rad_67maj.AutoSize = True
        Me.rad_67maj.Checked = True
        Me.rad_67maj.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rad_67maj.Location = New System.Drawing.Point(99, 61)
        Me.rad_67maj.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rad_67maj.Name = "rad_67maj"
        Me.rad_67maj.Size = New System.Drawing.Size(97, 17)
        Me.rad_67maj.TabIndex = 7
        Me.rad_67maj.TabStop = True
        Me.rad_67maj.Text = "三分之二多数"
        Me.rad_67maj.UseVisualStyleBackColor = True
        '
        'rad_50maj
        '
        Me.rad_50maj.AutoSize = True
        Me.rad_50maj.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rad_50maj.Location = New System.Drawing.Point(99, 41)
        Me.rad_50maj.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rad_50maj.Name = "rad_50maj"
        Me.rad_50maj.Size = New System.Drawing.Size(73, 17)
        Me.rad_50maj.TabIndex = 6
        Me.rad_50maj.Text = "简单多数"
        Me.rad_50maj.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Enabled = False
        Me.CheckBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CheckBox6.Location = New System.Drawing.Point(16, 121)
        Me.CheckBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(58, 17)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "Russia"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Enabled = False
        Me.CheckBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CheckBox5.Location = New System.Drawing.Point(16, 101)
        Me.CheckBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(59, 17)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "France"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Enabled = False
        Me.CheckBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CheckBox4.Location = New System.Drawing.Point(16, 82)
        Me.CheckBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "UK"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CheckBox3.Location = New System.Drawing.Point(16, 62)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "USA"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CheckBox2.Location = New System.Drawing.Point(16, 42)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "China"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'chk_vote_foujue
        '
        Me.chk_vote_foujue.AutoSize = True
        Me.chk_vote_foujue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chk_vote_foujue.Location = New System.Drawing.Point(9, 20)
        Me.chk_vote_foujue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chk_vote_foujue.Name = "chk_vote_foujue"
        Me.chk_vote_foujue.Size = New System.Drawing.Size(149, 17)
        Me.chk_vote_foujue.TabIndex = 0
        Me.chk_vote_foujue.Text = "启用否决权    通过条件:"
        Me.chk_vote_foujue.UseVisualStyleBackColor = True
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label108.Location = New System.Drawing.Point(10, 16)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(58, 13)
        Me.Label108.TabIndex = 5
        Me.Label108.Text = "下一国家:"
        '
        'btnpass
        '
        Me.btnpass.FlatAppearance.BorderSize = 0
        Me.btnpass.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnpass.Location = New System.Drawing.Point(161, 70)
        Me.btnpass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnpass.Name = "btnpass"
        Me.btnpass.Size = New System.Drawing.Size(46, 23)
        Me.btnpass.TabIndex = 4
        Me.btnpass.Text = "Pass"
        Me.btnpass.UseVisualStyleBackColor = False
        '
        'btnabst
        '
        Me.btnabst.FlatAppearance.BorderSize = 0
        Me.btnabst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod
        Me.btnabst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnabst.Location = New System.Drawing.Point(110, 70)
        Me.btnabst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnabst.Name = "btnabst"
        Me.btnabst.Size = New System.Drawing.Size(46, 23)
        Me.btnabst.TabIndex = 3
        Me.btnabst.Text = "弃权"
        Me.btnabst.UseVisualStyleBackColor = False
        '
        'btnno
        '
        Me.btnno.FlatAppearance.BorderSize = 0
        Me.btnno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnno.Location = New System.Drawing.Point(58, 70)
        Me.btnno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnno.Name = "btnno"
        Me.btnno.Size = New System.Drawing.Size(46, 23)
        Me.btnno.TabIndex = 2
        Me.btnno.Text = "反对"
        Me.btnno.UseVisualStyleBackColor = False
        '
        'btnyes
        '
        Me.btnyes.FlatAppearance.BorderSize = 0
        Me.btnyes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.btnyes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnyes.Location = New System.Drawing.Point(7, 70)
        Me.btnyes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnyes.Name = "btnyes"
        Me.btnyes.Size = New System.Drawing.Size(46, 23)
        Me.btnyes.TabIndex = 1
        Me.btnyes.Text = "赞成"
        Me.btnyes.UseVisualStyleBackColor = False
        '
        'lbl_vote_nation
        '
        Me.lbl_vote_nation.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_vote_nation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_vote_nation.Location = New System.Drawing.Point(8, 35)
        Me.lbl_vote_nation.Name = "lbl_vote_nation"
        Me.lbl_vote_nation.Size = New System.Drawing.Size(193, 28)
        Me.lbl_vote_nation.TabIndex = 0
        Me.lbl_vote_nation.Text = "Label108"
        Me.lbl_vote_nation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblno
        '
        Me.lblno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblno.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblno.Location = New System.Drawing.Point(59, 99)
        Me.lblno.Name = "lblno"
        Me.lblno.Size = New System.Drawing.Size(45, 21)
        Me.lblno.TabIndex = 8
        Me.lblno.Text = "0"
        Me.lblno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblyes
        '
        Me.lblyes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblyes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblyes.Location = New System.Drawing.Point(8, 99)
        Me.lblyes.Name = "lblyes"
        Me.lblyes.Size = New System.Drawing.Size(45, 21)
        Me.lblyes.TabIndex = 7
        Me.lblyes.Text = "0/0"
        Me.lblyes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblabst
        '
        Me.lblabst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblabst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblabst.Location = New System.Drawing.Point(111, 99)
        Me.lblabst.Name = "lblabst"
        Me.lblabst.Size = New System.Drawing.Size(45, 21)
        Me.lblabst.TabIndex = 9
        Me.lblabst.Text = "0"
        Me.lblabst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_noabst)
        Me.GroupBox1.Controls.Add(Me.chk_vote_foujue)
        Me.GroupBox1.Controls.Add(Me.rad_all)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.rad_80maj)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.rad_67maj)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.rad_50maj)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 148)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "配置"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label108)
        Me.GroupBox2.Controls.Add(Me.btnpass)
        Me.GroupBox2.Controls.Add(Me.lbl_vote_nation)
        Me.GroupBox2.Controls.Add(Me.lblabst)
        Me.GroupBox2.Controls.Add(Me.btnyes)
        Me.GroupBox2.Controls.Add(Me.lblno)
        Me.GroupBox2.Controls.Add(Me.btnno)
        Me.GroupBox2.Controls.Add(Me.btnabst)
        Me.GroupBox2.Controls.Add(Me.lblyes)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 129)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "控制板"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(161, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "继续"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListView1)
        Me.GroupBox3.Controls.Add(Me.ToolStrip1)
        Me.GroupBox3.Location = New System.Drawing.Point(232, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(203, 283)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "国家列表"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nation, Me.comp, Me.bote})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(3, 41)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(197, 239)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'nation
        '
        Me.nation.Text = "国家"
        Me.nation.Width = 84
        '
        'bote
        '
        Me.bote.Text = "投票"
        Me.bote.Width = 45
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripLabel1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(197, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "<"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripLabel1.Text = "页数 1/1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = ">"
        '
        'Timer1
        '
        '
        'btn_votectrl
        '
        Me.btn_votectrl.Location = New System.Drawing.Point(-6, -28)
        Me.btn_votectrl.Name = "btn_votectrl"
        Me.btn_votectrl.Size = New System.Drawing.Size(75, 23)
        Me.btn_votectrl.TabIndex = 22
        Me.btn_votectrl.Text = "Button2"
        Me.btn_votectrl.UseVisualStyleBackColor = True
        '
        'comp
        '
        Me.comp.Text = "权限"
        Me.comp.Width = 45
        '
        'Vote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 309)
        Me.Controls.Add(Me.btn_votectrl)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Vote"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Vote"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chk_noabst As System.Windows.Forms.CheckBox
    Friend WithEvents rad_all As System.Windows.Forms.RadioButton
    Friend WithEvents rad_80maj As System.Windows.Forms.RadioButton
    Friend WithEvents rad_67maj As System.Windows.Forms.RadioButton
    Friend WithEvents rad_50maj As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents chk_vote_foujue As System.Windows.Forms.CheckBox
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents btnpass As System.Windows.Forms.Button
    Friend WithEvents btnabst As System.Windows.Forms.Button
    Friend WithEvents btnno As System.Windows.Forms.Button
    Friend WithEvents btnyes As System.Windows.Forms.Button
    Friend WithEvents lbl_vote_nation As System.Windows.Forms.Label
    Friend WithEvents lblno As System.Windows.Forms.Label
    Friend WithEvents lblyes As System.Windows.Forms.Label
    Friend WithEvents lblabst As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents nation As System.Windows.Forms.ColumnHeader
    Friend WithEvents bote As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_votectrl As System.Windows.Forms.Button
    Friend WithEvents comp As ColumnHeader
End Class
