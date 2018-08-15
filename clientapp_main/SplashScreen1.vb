Public NotInheritable Class SplashScreen1

    'TODO:  可轻松将此窗体设置为应用程序的初始屏幕，方法是转到
    '  “项目设计器”的“应用程序”选项卡(“项目”菜单下的“属性”)。


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '根据应用程序的程序集信息在运行时设置对话框文本。  

        'TODO:  在项目属性对话框(“项目”菜单下)中的“应用程序”面板
        '  中自定义应用程序的程序集信息。

        '应用程序标题
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            '若应用程序标题丢失，则使用不带扩展名的应用程序名
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        '使用在设计时作为格式字符串设置到 Version 控件中的文本格式化版本信息。
        '  以便根据需要进行有效的本地化。
        '  使用以下代码，将 Version 控件的设计时文本 
        '  更改为“Version {0}.{1:00}.{2}.{3}”或类似格式，将内部版本和修订信息包括在内。
        '  有关更多信息，请参阅帮助中的 String.Format()。
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        '版权信息
        Copyright.Text = My.Application.Info.Copyright
    End Sub

End Class
