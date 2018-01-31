Imports System.Threading
Public Class APK12pobieranie

    Const adresxml As String = "http://www.nbp.pl/kursy/xml/LastA.xml"

    Private Sub APK12pobieranie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico12.GetHicon())
        lbl.Location = New Point(Size.Width / 2 - lbl.Size.Width / 2, lbl.Location.Y)
        Location = New Point(APK12waluty.Location.X + APK12waluty.Size.Width / 2 - Size.Width / 2, APK12waluty.Location.Y + APK12waluty.Size.Height / 2 - Size.Height / 2)
    End Sub

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        tmr.Enabled = False
        Try
            If IO.File.Exists(START.folderapk & "\apk12\LastA-DOWNLOAD.xml") Then IO.File.Delete(START.folderapk & "\apk12\LastA-DOWNLOAD.xml")
            Thread.Sleep(1300)
            My.Computer.Network.DownloadFile(adresxml, START.folderapk & "\apk12\LastA-DOWNLOAD.xml", False, 2000)
            If IO.File.Exists(START.folderapk & "\apk12\LastA-DOWNLOAD.xml") Then
                If IO.File.Exists(START.folderapk & "\apk12\LastA.xml") Then IO.File.Delete(START.folderapk & "\apk12\LastA.xml")
                My.Computer.FileSystem.RenameFile(START.folderapk & "\apk12\LastA-DOWNLOAD.xml", "LastA.xml")
                Dim plik As String = openFILE(START.folderapk, 12, "konfig")
                POZmod(plik, "konfig", "updateR", Now.Year)
                POZmod(plik, "konfig", "updateM", IIf(Now.Month < 10, "0" & Now.Month, Now.Month))
                POZmod(plik, "konfig", "updateD", IIf(Now.Day < 10, "0" & Now.Day, Now.Day))
                updateFILE(START.folderapk, 12, "konfig", plik)
                DialogResult = DialogResult.OK
            Else
                MsgBox("Plik nie mógł zostać pobrany z serwera!", MsgBoxStyle.Exclamation, "WINEASIER")
                DialogResult = DialogResult.Cancel
            End If
        Catch ex As Exception
            MsgBox("Plik nie mógł zostać pobrany z serwera!", MsgBoxStyle.Exclamation, "WINEASIER")
            DialogResult = DialogResult.Cancel
        End Try
    End Sub
End Class