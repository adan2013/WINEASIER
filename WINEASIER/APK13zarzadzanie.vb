Imports System.IO
Public Class APK13zarzadzanie

    Dim lk As List(Of String) = New List(Of String)

    Private Sub btnzamknij_Click(sender As Object, e As EventArgs) Handles btnzamknij.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnanuluj_Click(sender As Object, e As EventArgs) Handles btnanuluj.Click
        Dim plik As String = openFILE(START.folderapk, 13, "lista")
        Dim gr As String = ""
        For Each i As String In GRarray(plik)
            If POZget(plik, i, "nazwa") = APK13backup.wybr Then
                gr = i
                Exit For
            End If
        Next
        If gr = "" Then START.bladdanych()
        Select Case POZget(plik, gr, "status")
            Case "0", "3", "4", "5"
                MsgBox("Nie można anulować tworzenia kopii, ponieważ nie jest ona tworzona!", MsgBoxStyle.Exclamation, "WINEASIER")
            Case "1"
                MsgBox("Nie można anulować tworzenia kopii, ponieważ jest ona w trakcie tworzenia!", MsgBoxStyle.Exclamation, "WINEASIER")
            Case "2"
                If MsgBox("Na pewno anulować tworzenie kopii?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then
                    POZmod(plik, gr, "status", "0")
                    updateFILE(START.folderapk, 13, "lista", plik)
                End If
            Case Else
                START.bladdanych()
        End Select
        updatestatus()
    End Sub

    Private Sub APK13zarzadzanie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico13.GetHicon())
        updatestatus()
        ladujliste()
    End Sub

    Private Sub updatestatus()
        lblstatus.Text = "Status: Kopia nie jest tworzona"
        Dim plik As String = openFILE(START.folderapk, 13, "lista")
        For Each i As String In GRarray(plik)
            If POZget(plik, i, "nazwa") = APK13backup.wybr Then
                Select Case POZget(plik, i, "status")
                    Case "0"
                        lblstatus.Text = "Status: Kopia nie jest tworzona"
                    Case "1"
                        lblstatus.Text = "Status: Kopia jest aktualnie tworzona"
                    Case "2"
                        lblstatus.Text = "Status: Kopia oczekuje w kolejce"
                    Case "3"
                        lblstatus.Text = "Status: Kopia nie jest tworzona"
                    Case "4"
                        lblstatus.Text = "Status: Kopia nie jest tworzona"
                    Case "5"
                        lblstatus.Text = "Status: Kopia nie jest tworzona"
                    Case Else
                        START.bladdanych()
                End Select
                Exit Sub
            End If
        Next
        START.bladdanych()
    End Sub

    Private Sub ladujliste()
        btnusun.Enabled = False
        listakopii.Items.Clear()
        lk.Clear()
        Dim plik As String = openFILE(START.folderapk, 13, "POZ-" & APK13backup.wybr)
        If Not plik = "" Then
            For Each i As String In GRarray(plik)
                lk.Add(i)
                Dim tekst As String = POZget(plik, i, "h") & ":" & POZget(plik, i, "m") & " " & POZget(plik, i, "Dd") & "-" & POZget(plik, i, "Dm") & "-" & POZget(plik, i, "Dy")
                Dim folder As String = APK13backup.wybr & "-" & POZget(plik, i, "h") & "-" & POZget(plik, i, "m") & "-" & POZget(plik, i, "Dd") & "-" & POZget(plik, i, "Dm") & "-" & POZget(plik, i, "Dy")
                If IO.File.Exists(APK13backup.magazyn & "\" & folder & ".zip") Then
                    listakopii.Items.Add(tekst & " - " & Math.Round(New FileInfo(APK13backup.magazyn & "\" & folder & ".zip").Length / 1024 / 1024, 1) & " MB")
                Else
                    listakopii.Items.Add(tekst & " - nieznaleziono pliku kopii")
                End If
            Next
        End If
    End Sub

    Private Sub listakopii_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listakopii.SelectedIndexChanged
        btnusun.Enabled = True
    End Sub

    Private Sub btnusun_Click(sender As Object, e As EventArgs) Handles btnusun.Click
        Dim plik As String = openFILE(START.folderapk, 13, "POZ-" & APK13backup.wybr)
        If Not plik = "" Then
            Dim tekst As String = POZget(plik, lk(listakopii.SelectedIndex), "h") & ":" & POZget(plik, lk(listakopii.SelectedIndex), "m") & " " & POZget(plik, lk(listakopii.SelectedIndex), "Dd") & "-" & POZget(plik, lk(listakopii.SelectedIndex), "Dm") & "-" & POZget(plik, lk(listakopii.SelectedIndex), "Dy")
            Dim folder As String = APK13backup.wybr & "-" & POZget(plik, lk(listakopii.SelectedIndex), "h") & "-" & POZget(plik, lk(listakopii.SelectedIndex), "m") & "-" & POZget(plik, lk(listakopii.SelectedIndex), "Dd") & "-" & POZget(plik, lk(listakopii.SelectedIndex), "Dm") & "-" & POZget(plik, lk(listakopii.SelectedIndex), "Dy")
            If IO.File.Exists(APK13backup.magazyn & "\" & folder & ".zip") Then
                IO.File.Delete(APK13backup.magazyn & "\" & folder & ".zip")
            End If
            GRdel(plik, lk(listakopii.SelectedIndex))
            updateFILE(START.folderapk, 13, "POZ-" & APK13backup.wybr, plik)
        End If
        btnusun.Enabled = False
        ladujliste()
    End Sub
End Class