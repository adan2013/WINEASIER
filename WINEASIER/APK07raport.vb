Public Class APK07raport

    Private Sub APK07raport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico7.GetHicon())
        lbllista.Text = "Lista wykrytych dysków:" & vbNewLine
        If existFILE(START.folderapk, 7, "konfig", False) Then
            Dim dane As String = openFILE(START.folderapk, 7, "konfig")
            If POZget(dane, "root", "pwr") = 1 Then
                Dim wyj As String = POZget(dane, "root", "disk")
                If wyj.Length < 20 Then
                    Try
                        For Each i As IO.DriveInfo In IO.DriveInfo.GetDrives
                            If i.IsReady Then
                                If wyj.IndexOf(i.Name.Substring(0, i.Name.IndexOf(":")).ToLower()) < 0 Then
                                    lbllista.Text &= i.Name & " - " & IIf(i.VolumeLabel = "", "brak etykiety", i.VolumeLabel) & vbNewLine
                                End If
                            End If
                        Next
                    Catch ex As Exception

                    End Try
                Else
                    START.bladdanych()
                End If
            End If
        End If
    End Sub

    Private Sub btnzamknij_Click(sender As Object, e As EventArgs) Handles btnzamknij.Click
        Close()
    End Sub
End Class