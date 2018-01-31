Imports System.IO
Public Class APK13backup

    Dim panelwew As Panel = New Panel()
    Public wybr As String = ""
    Public magazyn As String = ""

    Private Sub APK13backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico13.GetHicon())
        With panelwew
            .Location = New Point(0, 0)
            .Size = New Size(panellista.Size.Width, 0)
        End With
        START.pobierzparametr(13)
        existFILE(START.folderapk, 13, "lista", True)
        ladujliste()
        existFILE(START.folderapk, 13, "folder", True)
        Dim plik As String = openFILE(START.folderapk, 13, "folder")
        If POZget(plik, "konfig", "info") = "" Then POZmod(plik, "konfig", "info", "0")
        If POZget(plik, "konfig", "limit") = "" Then POZmod(plik, "konfig", "limit", "0")
        If Not POZget(plik, "konfig", "path") = "" Then
            If IO.Directory.Exists(POZget(plik, "konfig", "path")) Then
                lblpath.Text = POZget(plik, "konfig", "path")
                magazyn = POZget(plik, "konfig", "path")
                Try
                    lblpath.Text &= " | " & directorysize(lblpath.Text, True) & " MB"
                Catch ex As Exception
                    POZmod(plik, "konfig", "path", "")
                    lblpath.Text = "Nie wybrano"
                    MsgBox("Program nie może wykorzystać aktualnego folderu magazynu do przechowywania danych z powodu odmowy dostępu do niego!" & vbNewLine & "Wybierz nowy folder magazynu", MsgBoxStyle.Exclamation, "WINEASIER")
                End Try
            Else
                POZmod(plik, "konfig", "path", "")
                MsgBox("Folder magazynu danych został usunięty z tego komputera!" & vbNewLine & "Wybierz nowy folder magazynu", MsgBoxStyle.Exclamation, "WINEASIER")
            End If
        End If
        updateFILE(START.folderapk, 13, "folder", plik)
    End Sub

    Private Sub ladujliste()
        panellista.Controls.Clear()
        panelwew.Controls.Clear()
        panelwew.Size = New Size(panellista.Size.Width, 0)
        Dim plik As String = openFILE(START.folderapk, 13, "lista")
        For Each i As String In GRarray(plik)
            If POZget(plik, i, "nazwa") = "" Then
                START.bladdanych()
            Else
                Dim tempnazwa As String = POZget(plik, i, "nazwa")
                panelwew.Size = New Size(panelwew.Size.Width, panelwew.Size.Height + 50)
                Dim panelpoz As Panel = New Panel()
                Dim lblnazwa As Label = New Label()
                Dim lblhz As Label = New Label()
                Dim lblstatus As Label = New Label()
                With panelpoz
                    .Name = "POZ" & tempnazwa
                    .Location = New Point(0, panelwew.Size.Height - 50)
                    .Size = New Size(panelwew.Size.Width, 50)
                End With
                With lblnazwa
                    .Name = "POZ" & tempnazwa
                    .Text = tempnazwa
                    .Font = New Font("Segoe UI", 14)
                    .Location = New Point(2, 0)
                    .Size = New Size(panelwew.Size.Width, 30)
                    .TextAlign = ContentAlignment.MiddleLeft
                    .Cursor = Cursors.Hand
                End With
                With lblhz
                    .Name = "POZ" & tempnazwa
                    .Text = getpozhz(IIf(POZget(plik, i, "hz") = "", 0, POZget(plik, i, "hz")))
                    .Font = New Font("Segoe UI", 8)
                    .Location = New Point(0, 30)
                    .Size = New Size(panelwew.Size.Width / 2, 20)
                    .TextAlign = ContentAlignment.MiddleLeft
                    .Cursor = Cursors.Hand
                End With
                With lblstatus
                    .Name = "POZ" & tempnazwa
                    .Text = getpozstatus(IIf(POZget(plik, i, "status") = "", 0, POZget(plik, i, "status")))
                    .Font = New Font("Segoe UI", 8)
                    .Location = New Point(panelwew.Width / 2, 30)
                    .Size = New Size(panelwew.Size.Width / 2 - 2, 20)
                    .TextAlign = ContentAlignment.MiddleRight
                    .Cursor = Cursors.Hand
                End With
                AddHandler panelpoz.MouseMove, AddressOf podswietl
                AddHandler lblnazwa.MouseMove, AddressOf podswietl
                AddHandler lblhz.MouseMove, AddressOf podswietl
                AddHandler lblstatus.MouseMove, AddressOf podswietl
                AddHandler panelpoz.MouseLeave, AddressOf zgas
                AddHandler lblnazwa.MouseLeave, AddressOf zgas
                AddHandler lblhz.MouseLeave, AddressOf zgas
                AddHandler lblstatus.MouseLeave, AddressOf zgas
                AddHandler panelpoz.Click, AddressOf podglad
                AddHandler lblnazwa.Click, AddressOf podglad
                AddHandler lblhz.Click, AddressOf podglad
                AddHandler lblstatus.Click, AddressOf podglad
                AddHandler panelpoz.DoubleClick, AddressOf edycja
                AddHandler lblnazwa.DoubleClick, AddressOf edycja
                AddHandler lblhz.DoubleClick, AddressOf edycja
                AddHandler lblstatus.DoubleClick, AddressOf edycja
                panelpoz.Controls.Add(lblnazwa)
                panelpoz.Controls.Add(lblhz)
                panelpoz.Controls.Add(lblstatus)
                panelwew.Controls.Add(panelpoz)
            End If
        Next
        panellista.Controls.Add(panelwew)
        For Each i As Control In panelwew.Controls
            If i.Name = "POZ" & wybr Then i.BackColor = Color.LightGray
        Next
        If Not magazyn = "" Then
            lblpath.Text = magazyn & " | " & directorysize(magazyn, True) & " MB"
        End If
    End Sub

    Private Sub edycja(sender As Object, e As EventArgs)
        APK13wpis.ShowDialog()
        If APK13wpis.DialogResult = DialogResult.OK Then ladujliste()
        APK13wpis.Close()
    End Sub

    Private Sub podglad(sender As Object, e As EventArgs)
        odswiez.Stop()
        odswiez.Start()
        wybr = sender.Name.Substring(3)
        btnusun.Enabled = True
        btnzk.Enabled = True
        Dim plik As String = openFILE(START.folderapk, 13, "lista")
        Dim gr As String = ""
        For Each i As String In GRarray(plik)
            If POZget(plik, i, "nazwa") = wybr Then
                gr = i
                Exit For
            End If
        Next
        If gr = "" Then Exit Sub
        lblinfo.Text = "Nazwa: " & POZget(plik, gr, "nazwa")
        lblinfo.Text &= vbNewLine & "Częstotliwość tworzenia kopii: " & getpozhz(IIf(POZget(plik, gr, "hz") = "", 0, POZget(plik, gr, "hz")))
        lblinfo.Text &= vbNewLine & "Status pozycji: " & getpozstatus(IIf(POZget(plik, gr, "status") = "", 0, POZget(plik, gr, "status")))
        lblinfo.Text &= vbNewLine & "Ilość kopii wstecz: " & getpozil(IIf(POZget(plik, gr, "il") = "", 0, POZget(plik, gr, "il")))
        lblinfo.Text &= vbNewLine & "Ostatnia kopia: " & getlast(POZget(plik, gr, "lastHR"), POZget(plik, gr, "lastMIN"), POZget(plik, gr, "lastD"), POZget(plik, gr, "lastM"), POZget(plik, gr, "lastY"))
        'lblinfo.Text &= vbNewLine & ""

        For Each i As Control In panelwew.Controls
            i.BackColor = Color.White
        Next
        If TypeOf sender Is Panel Then
            sender.BackColor = Color.LightGray
        Else
            sender.Parent.BackColor = Color.LightGray
        End If
    End Sub

    Private Function getlast(ByVal hr As String, ByVal min As String, ByVal d As String, ByVal m As String, ByVal r As String) As String
        If hr = "" Then Return ""
        If min = "" Then Return ""
        If d = "" Then Return ""
        If m = "" Then Return ""
        If r = "" Then Return ""
        If hr < 10 Then hr = "0" & hr
        If min < 10 Then min = "0" & min
        If d < 10 Then d = "0" & d
        If m < 10 Then m = "0" & m
        Return hr & ":" & min & " " & d & "-" & m & "-" & r
    End Function

    Private Sub zgas(sender As Object, e As EventArgs)
        If Not "POZ" & wybr = sender.Name Then
            If TypeOf sender Is Panel Then
                sender.BackColor = Color.White
            Else
                sender.Parent.BackColor = Color.White
            End If
        End If
    End Sub

    Private Sub podswietl(sender As Object, e As EventArgs)
        If TypeOf sender Is Panel Then
            sender.BackColor = Color.LightGray
        Else
            sender.Parent.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btnnowy_Click(sender As Object, e As EventArgs) Handles btnnowy.Click
        Dim plik As String = openFILE(START.folderapk, 13, "lista")
        Dim ilpoz As Byte = 0
        For Each i As String In GRarray(plik)
            ilpoz += 1
        Next
        If ilpoz >= 30 Then
            MsgBox("Osiągnięto maksymalną ilość pozycji!", MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End If

        Dim tempwybr As String = wybr
        wybr = ""
        APK13wpis.ShowDialog()
        If APK13wpis.DialogResult = DialogResult.OK Then ladujliste() Else wybr = tempwybr
        If wybr = "" Then
            btnusun.Enabled = False
            btnzk.Enabled = False
            lblinfo.Text = "Nie wybrano pozycji do podglądu"
        End If
        APK13wpis.Close()
    End Sub

    Private Sub btnusun_Click(sender As Object, e As EventArgs) Handles btnusun.Click
        If wybr = "" Then
            btnusun.Enabled = False
        Else
            If MsgBox("Czy na pewno chcesz usunąć tą pozycje?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then

                Dim plik As String = openFILE(START.folderapk, 13, "lista")
                For Each i As String In GRarray(plik)
                    If POZget(plik, i, "nazwa") = wybr Then
                        GRdel(plik, i)
                        Exit For
                    End If
                Next
                updateFILE(START.folderapk, 13, "lista", plik)

                If IO.File.Exists(START.folderapk & "\apk13\POZ-" & wybr & ".txt") Then IO.File.Delete(START.folderapk & "\apk13\POZ-" & wybr & ".txt")

                If Not magazyn = "" AndAlso IO.Directory.Exists(magazyn) Then
                    If MsgBox("Usunąć także wszystkie utworzone kopie tej pozycji?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then
                        For Each o As String In My.Computer.FileSystem.GetFiles(magazyn)
                            Try
                                If New IO.FileInfo(o).Name Like wybr & "-*" Then IO.File.Delete(o)
                            Catch ex As Exception

                            End Try
                        Next
                    End If
                End If

                wybr = ""
                btnusun.Enabled = False
                btnzk.Enabled = False
                lblinfo.Text = "Nie wybrano pozycji do podglądu"
                ladujliste()
            End If
        End If
    End Sub

    Private Sub APK13backup_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            If panelwew.Location.Y < 0 Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y + 30)
            End If
        Else
            If panellista.Size.Height < panelwew.Location.Y + panelwew.Size.Height Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y - 30)
            End If
        End If
        lblup.Visible = False
        lbldn.Visible = False
        If panelwew.Location.Y < 0 Then lblup.Visible = True
        If panelwew.Location.Y + panelwew.Size.Height > panellista.Size.Height Then lbldn.Visible = True
    End Sub

    Private Sub lbldn_Click(sender As Object, e As EventArgs) Handles lbldn.Click
        If panellista.Size.Height < panelwew.Location.Y + panelwew.Size.Height Then
            panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y - 30)
            lblup.Visible = False
            lbldn.Visible = False
            If panelwew.Location.Y < 0 Then lblup.Visible = True
            If panelwew.Location.Y + panelwew.Size.Height > panellista.Size.Height Then lbldn.Visible = True
        End If
    End Sub

    Private Sub lblup_Click(sender As Object, e As EventArgs) Handles lblup.Click
        If panelwew.Location.Y < 0 Then
            panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y + 30)
            lblup.Visible = False
            lbldn.Visible = False
            If panelwew.Location.Y < 0 Then lblup.Visible = True
            If panelwew.Location.Y + panelwew.Size.Height > panellista.Size.Height Then lbldn.Visible = True
        End If
    End Sub

    Private Function getpozhz(ByVal id As Byte) As String
        Select Case id
            Case 0
                Return "Tylko kopie ręczne"
            Case 1
                Return "Kopia co godzinę"
            Case 2
                Return "Kopia co 3 godziny"
            Case 3
                Return "Kopia codzienna"
            Case 4
                Return "Kopia co 3 dni"
            Case 5
                Return "Kopia co 5 dni"
            Case 6
                Return "Kopia co tydzień"
            Case 7
                Return "Kopia co 10 dni"
            Case 8
                Return "Kopia co 15 dni"
            Case Else
                START.bladdanych()
                Return ""
        End Select
    End Function

    Public Function getpozstatus(ByVal id As Byte) As String
        Select Case id
            Case 0
                Return "Gotowość"
            Case 1
                Return "Tworzenie kopii..."
            Case 2
                Return "Oczekiwanie..."
            Case 3
                Return "Błąd tworzenia kopii!"
            Case 4
                Return "Przywracanie danych..."
            Case 5
                Return "Błąd przywracania!"
            Case Else
                START.bladdanych()
                Return ""
        End Select
    End Function

    Private Function getpozil(ByVal id As Byte) As String
        Select Case id
            Case 0
                Return "2"
            Case 1
                Return "3"
            Case 2
                Return "4"
            Case 3
                Return "5"
            Case 4
                Return "6"
            Case 5
                Return "10"
            Case 6
                Return "15"
            Case 7
                Return "20"
            Case 8
                Return "25"
            Case 9
                Return "30"
            Case Else
                START.bladdanych()
                Return ""
        End Select
    End Function

    Private Sub odswiez_Tick(sender As Object, e As EventArgs) Handles odswiez.Tick
        If APK13wpis.Visible Then Exit Sub
        If APK13rozmiar.Visible Then Exit Sub
        If APK13zarzadzanie.Visible Then Exit Sub
        If APK13przywroc.Visible Then Exit Sub

        ladujliste()
    End Sub

    Public Function directorysize(ByVal path As String, ByVal toMB As Boolean) As Long
        Try
            If Not IO.Directory.Exists(path) Then Return 0
            Dim dir As DirectoryInfo = New DirectoryInfo(path)
            Dim rozmiar As Long = 0
            For Each i As FileInfo In dir.GetFiles()
                rozmiar += i.Length
            Next
            For Each i As DirectoryInfo In dir.GetDirectories()
                rozmiar += directorysize(i.FullName, False)
            Next
            If rozmiar = 0 Then
                Return 0
            Else
                If toMB Then
                    Return Math.Round(rozmiar / 1024 / 1024, 2)
                Else
                    Return rozmiar
                End If
            End If
        Catch ex As Exception
            Throw New System.Exception("noaccess")
        End Try
    End Function

    Private Sub btnzmien_Click(sender As Object, e As EventArgs) Handles btnzmien.Click
        If trwatworzeniekopii() Then
            MsgBox("Najpierw zakończ tworzenie wszystkich kopii!", MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End If
        dialogfolder.ShowDialog()
        If IO.Directory.Exists(dialogfolder.SelectedPath) Then
            Dim plik As String = openFILE(START.folderapk, 13, "folder")
            lblpath.Text = dialogfolder.SelectedPath
            Try
                lblpath.Text &= " | " & directorysize(lblpath.Text, True) & " MB"
                POZmod(plik, "konfig", "path", dialogfolder.SelectedPath)
                updateFILE(START.folderapk, 13, "folder", plik)
                magazyn = dialogfolder.SelectedPath
            Catch ex As Exception
                POZmod(plik, "konfig", "path", "")
                updateFILE(START.folderapk, 13, "folder", plik)
                lblpath.Text = "Nie wybrano"
                MsgBox("Program nie może wykorzystać aktualnego folderu magazynu do przechowywania danych z powodu odmowy dostępu do niego!" & vbNewLine & "Wybierz nowy folder magazynu", MsgBoxStyle.Exclamation, "WINEASIER")
            End Try
        End If
    End Sub

    Private Sub btnotworz_Click(sender As Object, e As EventArgs) Handles btnotworz.Click
        If lblpath.Text = "Nie wybrano" Then
            MsgBox("Nie wybrano magazynu kopii zapasowych!", MsgBoxStyle.Exclamation, "WINEASIER")
        Else
            Try
                Process.Start(lblpath.Text.Substring(0, lblpath.Text.LastIndexOf(" |")))
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnzarzadzaj_Click(sender As Object, e As EventArgs) Handles btnzarzadzaj.Click
        If trwatworzeniekopii() Then
            MsgBox("Najpierw zakończ tworzenie wszystkich kopii!", MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End If
        APK13rozmiar.ShowDialog()
        APK13rozmiar.Close()
    End Sub

    Private Sub btnkopia_Click(sender As Object, e As EventArgs) Handles btnkopia.Click
        If magazyn = "" Then
            MsgBox("Nie wybrano magazynu danych!", MsgBoxStyle.Information, "WINEASIER")
        Else
            APK13wykonaj.ShowDialog()
            APK13wykonaj.Close()
            ladujliste()
        End If
    End Sub

    Private Function trwatworzeniekopii() As Boolean
        Dim plik As String = openFILE(START.folderapk, 13, "lista")
        For Each i As String In GRarray(plik)
            If POZget(plik, i, "status") = "1" OrElse POZget(plik, i, "status") = "2" Then Return True
        Next
        Return False
    End Function

    Private Sub btnzk_Click(sender As Object, e As EventArgs) Handles btnzk.Click
        If wybr = "" Then
            btnzk.Enabled = False
        Else
            If magazyn = "" Then
                MsgBox("Nie wybrano magazynu danych!", MsgBoxStyle.Information, "WINEASIER")
            Else
                APK13zarzadzanie.ShowDialog()
                APK13zarzadzanie.Close()
                ladujliste()
            End If
        End If
    End Sub

    Private Sub btnprzywroc_Click(sender As Object, e As EventArgs) Handles btnprzywroc.Click
        If trwatworzeniekopii() Then
            MsgBox("Najpierw zakończ tworzenie wszystkich kopii!", MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End If
        If magazyn = "" Then
            MsgBox("Nie wybrano magazynu danych!", MsgBoxStyle.Information, "WINEASIER")
        Else
            APK13przywroc.ShowDialog()
            APK13przywroc.Close()
        End If
    End Sub
End Class