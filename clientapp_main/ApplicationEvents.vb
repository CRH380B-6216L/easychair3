Namespace My

    ' 以下事件可用于 MyApplication: 
    ' 
    ' Startup:  应用程序启动时在创建启动窗体之前引发。
    ' Shutdown:  在关闭所有应用程序窗体后引发。  如果应用程序异常终止，则不会引发此事件。
    ' UnhandledException:  在应用程序遇到未经处理的异常时引发。
    ' StartupNextInstance:  在启动单实例应用程序且应用程序已处于活动状态时引发。
    ' NetworkAvailabilityChanged:  在连接或断开网络连接时引发。
    Partial Friend Class MyApplication
        Dim path As String
        Dim myver, newver As Integer, url As String
        Dim TempPath = Environment.GetEnvironmentVariable("Temp").ToString & "\"

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) 'Handles Me.Startup
            Try
                Dim original As New Xml.XmlDocument
                original.Load("UpFileList.xml")
                url = original.SelectNodes("/Xml/Url").Item(0).InnerText
                Dim loadMyver As New System.IO.StreamReader("version.txt")
                myver = loadMyver.ReadLine()
                loadMyver.Close()
                path = url + "version.txt"
                Dim Obj_Lob As New System.Net.WebClient()
                Obj_Lob.DownloadFile(path, TempPath + "version.txt")
                Dim loadNewver As New System.IO.StreamReader(TempPath.ToString + "version.txt")
                newver = loadNewver.ReadLine()
                loadNewver.Close()
                If Not myver = newver Then
                    If MsgBox("有新的更新可用，是否安装？", 36, "Console") = 6 Then
                        Dim saveMyver As New System.IO.StreamWriter("version.txt")
                        saveMyver.WriteLine(newver)
                        saveMyver.Close()
                        Shell("update.exe")
                        End
                    Else
                    End If
                Else
                End If
            Catch ex As Exception
                MsgBox("检查更新时遇到错误。点击" + Chr(34) + "确定" + Chr(34) + "跳过更新。" + vbCrLf + "错误信息:" + vbCrLf + ex.Message)
            End Try
        End Sub
    End Class


End Namespace

