Public Class APK13wykonaj

    Dim zezw As Boolean = False
    Dim aktgr As String = ""

    Private Sub btnanuluj_Click(sender As Object, e As EventArgs) Handles btnanuluj.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnwykonaj_Click(sender As Object, e As EventArgs) Handles btnwykonaj.Click
        If Not zezw Then Exit Sub
        If aktgr = "" Then Exit Sub
        Dim plik As String = openFILE(START.folderapk, 13, "lista")
        POZmod(plik, aktgr, "status", "2")
        updateFILE(START.folderapk, 13, "lista", plik)
        DialogResult = DialogResult.OK
    End Sub

    Private Sub lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista.SelectedIndexChanged
        zezw = True
        lblnazwa.ForeColor = Color.Black
        lblstatus.ForeColor = Color.Black
        lblostatnia.ForeColor = Color.Black
        lblrozoryg.ForeColor = Color.Black
        lblaktroz.ForeColor = Color.Black
        lblrozlimit.ForeColor = Color.Black
        Dim plik As String = openFILE(START.folderapk, 13, "lista")
        For Each i As String In GRarray(plik)
            If POZget(plik, i, "nazwa") = lista.Text Then
                aktgr = i
                lblnazwa.Text = "Nazwa: " & POZget(plik, i, "nazwa")
                lblstatus.Text = "Status: " & APK13backup.getpozstatus(IIf(POZget(plik, i, "status") = "", 0, POZget(plik, i, "status")))
                If IIf(POZget(plik, i, "status") = "", 0, POZget(plik, i, "status")) = 1 OrElse IIf(POZget(plik, i, "status") = "", 0, POZget(plik, i, "status")) = 2 OrElse IIf(POZget(plik, i, "status") = "", 0, POZget(plik, i, "status")) = 4 Then
                    lblstatus.ForeColor = Color.Red
                    zezw = False
                End If
                Dim tempdata As String = ""
                tempdata &= IIf(POZget(plik, i, "lastHR") = "", 0, POZget(plik, i, "lastHR")) & ":"
                tempdata &= IIf(POZget(plik, i, "lastMIN") = "", 0, POZget(plik, i, "lastMIN")) & " "
                tempdata &= IIf(POZget(plik, i, "lastD") = "", 0, POZget(plik, i, "lastD")) & "-"
                tempdata &= IIf(POZget(plik, i, "lastM") = "", 0, POZget(plik, i, "lastM")) & "-"
                tempdata &= IIf(POZget(plik, i, "lastY") = "", 0, POZget(plik, i, "lastY"))
                lblostatnia.Text = "Ostatnia kopia: " & tempdata
                Dim roz As Integer = 0
                Try
                    lblrozoryg.Text = "Rozmiar oryg. plików: " & APK13backup.directorysize(POZget(plik, i, "path"), True) & " MB"
                    roz = APK13backup.directorysize(POZget(plik, i, "path"), True)
                Catch ex As Exception
                    lblrozoryg.Text = "Rozmiar oryg. plików: błąd ścieżki"
                    lblrozoryg.ForeColor = Color.Red
                    zezw = False
                End Try
                Dim plik2 As String = openFILE(START.folderapk, 13, "folder")
                Dim magazyn As String = POZget(plik2, "konfig", "path")
                If IO.Directory.Exists(magazyn) Then
                    Try
                        lblaktroz.Text = "Aktualny rozmiar magazynu: " & APK13backup.directorysize(magazyn, True) & " MB"
                    Catch ex As Exception
                        lblaktroz.Text = "Aktualny rozmiar magazynu: błąd ścieżki"
                        lblaktroz.ForeColor = Color.Red
                        zezw = False
                    End Try
                Else
                    lblaktroz.Text = "Aktualny rozmiar magazynu: błąd ścieżki"
                    lblaktroz.ForeColor = Color.Red
                    zezw = False
                End If
                tempdata = POZget(plik2, "konfig", "limit")
                If IsNumeric(tempdata) AndAlso tempdata >= 0 AndAlso tempdata < 4097 Then
                    If tempdata = 0 Then
                        lblrozlimit.Text = "Limit rozmiaru magazynu: " & Math.Round(My.Computer.FileSystem.GetDriveInfo(magazyn.Substring(0, magazyn.IndexOf("\") + 1)).TotalFreeSpace / 1024 / 1024, 2) & " MB"
                        If Math.Round(My.Computer.FileSystem.GetDriveInfo(magazyn.Substring(0, magazyn.IndexOf("\") + 1)).TotalFreeSpace / 1024 / 1024, 2) < roz Then
                            lblrozlimit.ForeColor = Color.Red
                            zezw = False
                        End If
                    Else
                        If Math.Round(My.Computer.FileSystem.GetDriveInfo(magazyn.Substring(0, magazyn.IndexOf("\") + 1)).TotalFreeSpace / 1024 / 1024, 2) > roz Then
                            lblrozlimit.Text = "Limit rozmiaru magazynu: " & Math.Round(My.Computer.FileSystem.GetDriveInfo(magazyn.Substring(0, magazyn.IndexOf("\") + 1)).TotalFreeSpace / 1024 / 1024, 2) & " MB"
                            If APK13backup.directorysize(magazyn, True) + roz < tempdata Then
                                lblrozlimit.Text = "Limit rozmiaru magazynu: " & tempdata & " MB"
                            Else
                                lblrozlimit.Text = "Limit rozmiaru magazynu: " & tempdata & " MB"
                                lblrozlimit.ForeColor = Color.Red
                                zezw = False
                            End If
                        Else
                            lblrozlimit.Text = "Limit rozmiaru magazynu: " & Math.Round(My.Computer.FileSystem.GetDriveInfo(magazyn.Substring(0, magazyn.IndexOf("\") + 1)).TotalFreeSpace / 1024 / 1024, 2) & " MB"
                            lblrozlimit.ForeColor = Color.Red
                            zezw = False
                        End If
                    End If
                Else
                    START.bladdanych()
                End If
                Exit For
            End If
        Next
        If zezw Then btnwykonaj.Enabled = True Else btnwykonaj.Enabled = False
    End Sub

    Private Sub APK13wykonaj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico13.GetHicon())
        Dim plik As String = openFILE(START.folderapk, 13, "lista")
        For Each i As String In GRarray(plik)
            lista.Items.Add(POZget(plik, i, "nazwa"))
        Next
    End Sub
End Class