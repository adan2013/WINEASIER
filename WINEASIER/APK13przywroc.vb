Imports System.IO
Public Class APK13przywroc

    Dim lk As List(Of String) = New List(Of String)

    Private Sub APK13przywroc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico13.GetHicon())
        lista1.Items.Clear()
        lista2.Items.Clear()
        Dim lista As String = openFILE(START.folderapk, 13, "lista")
        For Each i As String In GRarray(lista)
            lista1.Enabled = True
            lista1.Items.Add(POZget(lista, i, "nazwa"))
        Next
    End Sub

    Private Sub lista1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista1.SelectedIndexChanged
        If lista1.Text = "" Then Exit Sub
        lista2.Enabled = False
        lista2.Items.Clear()
        lk.Clear()
        Dim pozycje As String = openFILE(START.folderapk, 13, "POZ-" & lista1.Text)
        If pozycje = "" Then Exit Sub
        For Each i As String In GRarray(pozycje)
            lista2.Enabled = True
            Dim tekst As String = POZget(pozycje, i, "h") & ":" & POZget(pozycje, i, "m") & " " & POZget(pozycje, i, "Dd") & "-" & POZget(pozycje, i, "Dm") & "-" & POZget(pozycje, i, "Dy")
            Dim folder As String = APK13backup.wybr & "-" & POZget(pozycje, i, "h") & "-" & POZget(pozycje, i, "m") & "-" & POZget(pozycje, i, "Dd") & "-" & POZget(pozycje, i, "Dm") & "-" & POZget(pozycje, i, "Dy")
            If IO.File.Exists(APK13backup.magazyn & "\" & folder & ".zip") Then
                lk.Add(i)
                lista2.Items.Add(tekst & " - " & Math.Round(New FileInfo(APK13backup.magazyn & "\" & folder & ".zip").Length / 1024 / 1024, 1) & " MB")
            Else
                lk.Add("!")
                lista2.Items.Add(tekst & " - nieznaleziono pliku kopii")
            End If
        Next
    End Sub

    Private Sub btnanuluj_Click(sender As Object, e As EventArgs) Handles btnanuluj.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub lista2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista2.SelectedIndexChanged
        btnwykonaj.Enabled = False
        If Not lk(lista2.SelectedIndex) = "!" Then btnwykonaj.Enabled = True
    End Sub

    Private Sub btnwykonaj_Click(sender As Object, e As EventArgs) Handles btnwykonaj.Click
        Dim plik As String = openFILE(START.folderapk, 13, "lista")
        For Each i As String In GRarray(plik)
            If POZget(plik, i, "nazwa") = lista1.Text Then
                If POZget(plik, i, "status") = "0" OrElse POZget(plik, i, "status") = "3" Then
                    If MsgBox("Czy na pewno chcesz przywrócić dane z kopii bezpieczeństwa? Oznacza to usunięcie aktualnych dancyh znajdujących się na komputerze", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then
                        existFILE(START.folderapk, 13, "przywracanie", True)
                        Dim plikprzywr As String = openFILE(START.folderapk, 13, "przywracanie")
                        Dim nazwagrupy As String = ""
                        For o As Byte = 0 To 60 Step 1
                            If Not GRexist(plikprzywr, "poz" & o) Then
                                nazwagrupy = "poz" & o
                                Exit For
                            End If
                        Next
                        If nazwagrupy = "" Then START.bladdanych()
                        POZmod(plikprzywr, nazwagrupy, "nazwa", lista1.Text)
                        POZmod(plikprzywr, nazwagrupy, "pozycja", lk(lista2.SelectedIndex))
                        updateFILE(START.folderapk, 13, "przywracanie", plikprzywr)
                        POZmod(plik, i, "status", "4")
                        updateFILE(START.folderapk, 13, "lista", plik)
                        MsgBox("Rozpoczęto tworzenie kopii! Nie wyłączaj komputera podczas trwania procesu przywracania, ponieważ może to spowodować trwałą utratę danych!", MsgBoxStyle.Exclamation, "WINEASIER")
                        DialogResult = DialogResult.OK
                    End If
                Else
                    MsgBox("Status pozycji nie pozwala na wykonanie przywrócenia danych!", MsgBoxStyle.Exclamation, "WINEASIER")
                End If
            End If
        Next
    End Sub
End Class