Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            MsgBox("Aplikacja WINEASIER już działa w tle!", MsgBoxStyle.Critical, "WINEASIER")
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim st As New StackTrace(True)
            st = New StackTrace(e.Exception, True)

            START.infoerr = "Message: " & e.Exception.Message & vbNewLine
            START.infoerr &= "Line number: " & st.GetFrame(0).GetFileLineNumber().ToString() & vbNewLine
            START.infoerr &= "File: " & My.Computer.FileSystem.GetName(st.GetFrame(0).GetFileName().ToString())

            errinfo.ShowDialog()
            errinfo.Close()
            End
        End Sub
    End Class
End Namespace
