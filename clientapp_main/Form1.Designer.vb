<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.文件FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新建会议NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开会议OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.最近使用的项目ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查看VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.投影模式PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConsoleLinkKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.会议CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.开始新会期SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.主发言名单LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.自定发言名单CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.无自定发言名单ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.新建发言名单NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.发送会场消息DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.会议属性PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.国家信息IToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.动议MToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.自由磋商UToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.调整发言时间AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.调整投票顺序OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.对文件投票VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.茶歇TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.结束辩论EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.休会SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.自定义CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.会场文件PToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.添加新文件NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.发送危机CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.屏幕窗口SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.主屏幕MToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.危机编写器CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.国家列表NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.主发言名单SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.有主持核心磋商MToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.文件管理器FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.计时器TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.等待控制WToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.点名RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.有主持核心磋商CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件FToolStripMenuItem, Me.查看VToolStripMenuItem, Me.会议CToolStripMenuItem, Me.动议MToolStripMenuItem, Me.会场文件PToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '文件FToolStripMenuItem
        '
        Me.文件FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新建会议NToolStripMenuItem, Me.打开会议OToolStripMenuItem, Me.ToolStripSeparator1, Me.最近使用的项目ToolStripMenuItem1, Me.ToolStripSeparator2, Me.退出XToolStripMenuItem})
        Me.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem"
        Me.文件FToolStripMenuItem.Size = New System.Drawing.Size(58, 21)
        Me.文件FToolStripMenuItem.Text = "文件(&F)"
        '
        '新建会议NToolStripMenuItem
        '
        Me.新建会议NToolStripMenuItem.Name = "新建会议NToolStripMenuItem"
        Me.新建会议NToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.新建会议NToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.新建会议NToolStripMenuItem.Text = "新建会议(&N)..."
        '
        '打开会议OToolStripMenuItem
        '
        Me.打开会议OToolStripMenuItem.Name = "打开会议OToolStripMenuItem"
        Me.打开会议OToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.打开会议OToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.打开会议OToolStripMenuItem.Text = "打开会议(&O)..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(195, 6)
        '
        '最近使用的项目ToolStripMenuItem1
        '
        Me.最近使用的项目ToolStripMenuItem1.Enabled = False
        Me.最近使用的项目ToolStripMenuItem1.Name = "最近使用的项目ToolStripMenuItem1"
        Me.最近使用的项目ToolStripMenuItem1.Size = New System.Drawing.Size(198, 22)
        Me.最近使用的项目ToolStripMenuItem1.Text = "最近使用的项目..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(195, 6)
        '
        '退出XToolStripMenuItem
        '
        Me.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem"
        Me.退出XToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.退出XToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.退出XToolStripMenuItem.Text = "退出(&X)"
        '
        '查看VToolStripMenuItem
        '
        Me.查看VToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.屏幕窗口SToolStripMenuItem, Me.投影模式PToolStripMenuItem, Me.ToolStripSeparator8, Me.主屏幕MToolStripMenuItem, Me.危机编写器CToolStripMenuItem, Me.ToolStripSeparator9, Me.国家列表NToolStripMenuItem, Me.主发言名单SToolStripMenuItem, Me.有主持核心磋商MToolStripMenuItem, Me.文件管理器FToolStripMenuItem, Me.计时器TToolStripMenuItem, Me.等待控制WToolStripMenuItem, Me.ConsoleLinkKToolStripMenuItem})
        Me.查看VToolStripMenuItem.Name = "查看VToolStripMenuItem"
        Me.查看VToolStripMenuItem.Size = New System.Drawing.Size(64, 21)
        Me.查看VToolStripMenuItem.Text = " 查看(&V)"
        '
        '投影模式PToolStripMenuItem
        '
        Me.投影模式PToolStripMenuItem.CheckOnClick = True
        Me.投影模式PToolStripMenuItem.Name = "投影模式PToolStripMenuItem"
        Me.投影模式PToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.投影模式PToolStripMenuItem.Text = "投影模式(&P)"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(177, 6)
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(177, 6)
        '
        'ConsoleLinkKToolStripMenuItem
        '
        Me.ConsoleLinkKToolStripMenuItem.Name = "ConsoleLinkKToolStripMenuItem"
        Me.ConsoleLinkKToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsoleLinkKToolStripMenuItem.Text = "危机接收器(&R)"
        '
        '会议CToolStripMenuItem
        '
        Me.会议CToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.开始新会期SToolStripMenuItem, Me.点名RToolStripMenuItem, Me.ToolStripSeparator3, Me.主发言名单LToolStripMenuItem, Me.自定发言名单CToolStripMenuItem, Me.ToolStripSeparator6, Me.发送会场消息DToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripSeparator10, Me.会议属性PToolStripMenuItem, Me.国家信息IToolStripMenuItem})
        Me.会议CToolStripMenuItem.Name = "会议CToolStripMenuItem"
        Me.会议CToolStripMenuItem.Size = New System.Drawing.Size(60, 21)
        Me.会议CToolStripMenuItem.Text = "会议(&C)"
        Me.会议CToolStripMenuItem.Visible = False
        '
        '开始新会期SToolStripMenuItem
        '
        Me.开始新会期SToolStripMenuItem.Name = "开始新会期SToolStripMenuItem"
        Me.开始新会期SToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.开始新会期SToolStripMenuItem.Text = "开始新会期(&S)..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(171, 6)
        '
        '主发言名单LToolStripMenuItem
        '
        Me.主发言名单LToolStripMenuItem.Name = "主发言名单LToolStripMenuItem"
        Me.主发言名单LToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.主发言名单LToolStripMenuItem.Text = "主发言名单(&L)..."
        '
        '自定发言名单CToolStripMenuItem
        '
        Me.自定发言名单CToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.无自定发言名单ToolStripMenuItem, Me.ToolStripSeparator4, Me.新建发言名单NToolStripMenuItem})
        Me.自定发言名单CToolStripMenuItem.Enabled = False
        Me.自定发言名单CToolStripMenuItem.Name = "自定发言名单CToolStripMenuItem"
        Me.自定发言名单CToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.自定发言名单CToolStripMenuItem.Text = "自定发言名单(&C)"
        '
        '无自定发言名单ToolStripMenuItem
        '
        Me.无自定发言名单ToolStripMenuItem.Enabled = False
        Me.无自定发言名单ToolStripMenuItem.Name = "无自定发言名单ToolStripMenuItem"
        Me.无自定发言名单ToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.无自定发言名单ToolStripMenuItem.Text = "无自定发言名单"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(172, 6)
        '
        '新建发言名单NToolStripMenuItem
        '
        Me.新建发言名单NToolStripMenuItem.Name = "新建发言名单NToolStripMenuItem"
        Me.新建发言名单NToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.新建发言名单NToolStripMenuItem.Text = "新建发言名单(&N)..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(171, 6)
        '
        '发送会场消息DToolStripMenuItem
        '
        Me.发送会场消息DToolStripMenuItem.Name = "发送会场消息DToolStripMenuItem"
        Me.发送会场消息DToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.发送会场消息DToolStripMenuItem.Text = "发送会场消息(&D)..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripMenuItem1.Text = "时间轴设定(&T)..."
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(171, 6)
        '
        '会议属性PToolStripMenuItem
        '
        Me.会议属性PToolStripMenuItem.Name = "会议属性PToolStripMenuItem"
        Me.会议属性PToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.会议属性PToolStripMenuItem.Text = "会议属性(&P)..."
        '
        '国家信息IToolStripMenuItem
        '
        Me.国家信息IToolStripMenuItem.Name = "国家信息IToolStripMenuItem"
        Me.国家信息IToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.国家信息IToolStripMenuItem.Text = "国家信息(&I)"
        '
        '动议MToolStripMenuItem
        '
        Me.动议MToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.有主持核心磋商CToolStripMenuItem, Me.自由磋商UToolStripMenuItem, Me.调整发言时间AToolStripMenuItem, Me.调整投票顺序OToolStripMenuItem, Me.对文件投票VToolStripMenuItem, Me.茶歇TToolStripMenuItem, Me.结束辩论EToolStripMenuItem, Me.休会SToolStripMenuItem, Me.ToolStripSeparator5, Me.自定义CToolStripMenuItem})
        Me.动议MToolStripMenuItem.Name = "动议MToolStripMenuItem"
        Me.动议MToolStripMenuItem.Size = New System.Drawing.Size(64, 21)
        Me.动议MToolStripMenuItem.Text = "动议(&M)"
        Me.动议MToolStripMenuItem.Visible = False
        '
        '自由磋商UToolStripMenuItem
        '
        Me.自由磋商UToolStripMenuItem.Name = "自由磋商UToolStripMenuItem"
        Me.自由磋商UToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.自由磋商UToolStripMenuItem.Text = "自由磋商(&U)..."
        '
        '调整发言时间AToolStripMenuItem
        '
        Me.调整发言时间AToolStripMenuItem.Name = "调整发言时间AToolStripMenuItem"
        Me.调整发言时间AToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.调整发言时间AToolStripMenuItem.Text = "调整发言时间(&A)..."
        '
        '调整投票顺序OToolStripMenuItem
        '
        Me.调整投票顺序OToolStripMenuItem.Name = "调整投票顺序OToolStripMenuItem"
        Me.调整投票顺序OToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.调整投票顺序OToolStripMenuItem.Text = "调整投票顺序(&O)..."
        '
        '对文件投票VToolStripMenuItem
        '
        Me.对文件投票VToolStripMenuItem.Name = "对文件投票VToolStripMenuItem"
        Me.对文件投票VToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.对文件投票VToolStripMenuItem.Text = "对文件投票(&V)..."
        '
        '茶歇TToolStripMenuItem
        '
        Me.茶歇TToolStripMenuItem.Name = "茶歇TToolStripMenuItem"
        Me.茶歇TToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.茶歇TToolStripMenuItem.Text = "茶歇(&T)..."
        '
        '结束辩论EToolStripMenuItem
        '
        Me.结束辩论EToolStripMenuItem.Name = "结束辩论EToolStripMenuItem"
        Me.结束辩论EToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.结束辩论EToolStripMenuItem.Text = "结束辩论(&E)..."
        '
        '休会SToolStripMenuItem
        '
        Me.休会SToolStripMenuItem.Name = "休会SToolStripMenuItem"
        Me.休会SToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.休会SToolStripMenuItem.Text = "休会(&S)..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(182, 6)
        '
        '自定义CToolStripMenuItem
        '
        Me.自定义CToolStripMenuItem.Name = "自定义CToolStripMenuItem"
        Me.自定义CToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.自定义CToolStripMenuItem.Text = "自定义(&C)..."
        '
        '会场文件PToolStripMenuItem
        '
        Me.会场文件PToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.添加新文件NToolStripMenuItem, Me.ToolStripSeparator7, Me.发送危机CToolStripMenuItem})
        Me.会场文件PToolStripMenuItem.Name = "会场文件PToolStripMenuItem"
        Me.会场文件PToolStripMenuItem.Size = New System.Drawing.Size(83, 21)
        Me.会场文件PToolStripMenuItem.Text = "会场文件(&P)"
        Me.会场文件PToolStripMenuItem.Visible = False
        '
        '添加新文件NToolStripMenuItem
        '
        Me.添加新文件NToolStripMenuItem.Name = "添加新文件NToolStripMenuItem"
        Me.添加新文件NToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.添加新文件NToolStripMenuItem.Text = "添加新文件(&N)..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(160, 6)
        '
        '发送危机CToolStripMenuItem
        '
        Me.发送危机CToolStripMenuItem.Name = "发送危机CToolStripMenuItem"
        Me.发送危机CToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.发送危机CToolStripMenuItem.Text = "发送危机(&C)..."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 611)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripSplitButton1.Text = "20:54"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(43, 17)
        Me.ToolStripStatusLabel1.Text = "       0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel2.Text = "Ready"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "config.xml|config.xml"
        '
        '屏幕窗口SToolStripMenuItem
        '
        Me.屏幕窗口SToolStripMenuItem.Image = Global.clientapp_main.My.Resources.Resources.SendToScreen
        Me.屏幕窗口SToolStripMenuItem.Name = "屏幕窗口SToolStripMenuItem"
        Me.屏幕窗口SToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.屏幕窗口SToolStripMenuItem.Text = "屏幕窗口(&S)"
        '
        '主屏幕MToolStripMenuItem
        '
        Me.主屏幕MToolStripMenuItem.Image = Global.clientapp_main.My.Resources.Resources.MainScreen
        Me.主屏幕MToolStripMenuItem.Name = "主屏幕MToolStripMenuItem"
        Me.主屏幕MToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.主屏幕MToolStripMenuItem.Text = "主屏幕(&M)"
        '
        '危机编写器CToolStripMenuItem
        '
        Me.危机编写器CToolStripMenuItem.Image = Global.clientapp_main.My.Resources.Resources.CrisisWriter
        Me.危机编写器CToolStripMenuItem.Name = "危机编写器CToolStripMenuItem"
        Me.危机编写器CToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.危机编写器CToolStripMenuItem.Text = "危机编写器(&C)"
        '
        '国家列表NToolStripMenuItem
        '
        Me.国家列表NToolStripMenuItem.Image = Global.clientapp_main.My.Resources.Resources.NationList
        Me.国家列表NToolStripMenuItem.Name = "国家列表NToolStripMenuItem"
        Me.国家列表NToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.国家列表NToolStripMenuItem.Text = "国家列表(&N)"
        '
        '主发言名单SToolStripMenuItem
        '
        Me.主发言名单SToolStripMenuItem.Image = Global.clientapp_main.My.Resources.Resources.SpeakersList
        Me.主发言名单SToolStripMenuItem.Name = "主发言名单SToolStripMenuItem"
        Me.主发言名单SToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.主发言名单SToolStripMenuItem.Text = "主发言名单(&L)"
        '
        '有主持核心磋商MToolStripMenuItem
        '
        Me.有主持核心磋商MToolStripMenuItem.Image = Global.clientapp_main.My.Resources.Resources.Moderated
        Me.有主持核心磋商MToolStripMenuItem.Name = "有主持核心磋商MToolStripMenuItem"
        Me.有主持核心磋商MToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.有主持核心磋商MToolStripMenuItem.Text = "有主持核心磋商(&M)"
        '
        '文件管理器FToolStripMenuItem
        '
        Me.文件管理器FToolStripMenuItem.Image = Global.clientapp_main.My.Resources.Resources.FileManage
        Me.文件管理器FToolStripMenuItem.Name = "文件管理器FToolStripMenuItem"
        Me.文件管理器FToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.文件管理器FToolStripMenuItem.Text = "文件管理器(&F)"
        '
        '计时器TToolStripMenuItem
        '
        Me.计时器TToolStripMenuItem.Image = Global.clientapp_main.My.Resources.Resources.Timer
        Me.计时器TToolStripMenuItem.Name = "计时器TToolStripMenuItem"
        Me.计时器TToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.计时器TToolStripMenuItem.Text = "计时器(&T)"
        '
        '等待控制WToolStripMenuItem
        '
        Me.等待控制WToolStripMenuItem.Image = Global.clientapp_main.My.Resources.Resources.WaitControl
        Me.等待控制WToolStripMenuItem.Name = "等待控制WToolStripMenuItem"
        Me.等待控制WToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.等待控制WToolStripMenuItem.Text = "等待控制(&W)"
        '
        '点名RToolStripMenuItem
        '
        Me.点名RToolStripMenuItem.Image = Global.clientapp_main.My.Resources.Resources.RollCall
        Me.点名RToolStripMenuItem.Name = "点名RToolStripMenuItem"
        Me.点名RToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.点名RToolStripMenuItem.Text = "点名(&R)..."
        '
        '有主持核心磋商CToolStripMenuItem
        '
        Me.有主持核心磋商CToolStripMenuItem.Image = Global.clientapp_main.My.Resources.Resources.Moderated
        Me.有主持核心磋商CToolStripMenuItem.Name = "有主持核心磋商CToolStripMenuItem"
        Me.有主持核心磋商CToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.有主持核心磋商CToolStripMenuItem.Text = "有主持核心磋商(&C)..."
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 633)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Easychair 3"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 文件FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents 新建会议NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 退出XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 最近使用的项目ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 会议CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 开始新会期SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 点名RToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 主发言名单LToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 自定发言名单CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 无自定发言名单ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 新建发言名单NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 查看VToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 动议MToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 有主持核心磋商CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 自由磋商UToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 调整发言时间AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 调整投票顺序OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 对文件投票VToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 茶歇TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 结束辩论EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 休会SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 自定义CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 会场文件PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 添加新文件NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 危机编写器CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 发送危机CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 屏幕窗口SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 投影模式PToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 主屏幕MToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 国家列表NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 主发言名单SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 有主持核心磋商MToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 文件管理器FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 计时器TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 等待控制WToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 发送会场消息DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 打开会议OToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents 会议属性PToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 国家信息IToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsoleLinkKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
End Class
