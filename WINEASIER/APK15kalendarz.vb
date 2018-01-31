Public Class APK15kalendarz

    Dim konfiguracja As Boolean = True
    Public sel As Byte = Now.Day
    Public wybr As String = ""
    Dim nazwykat(6) As String
    Dim panelwew As Panel = New Panel()

    Private Sub APK15kalendarz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico15.GetHicon())
        Dim parametr As String = START.pobierzparametr(15)

        existFILE(START.folderapk, 15, "lista", True)
        If Not existFILE(START.folderapk, 15, "kat", False) Then
            existFILE(START.folderapk, 15, "kat", True)
            Dim temptxt As String = ""
            POZmod(temptxt, "kat0", "nazwa", "")
            POZmod(temptxt, "kat0", "alarm", "")
            POZmod(temptxt, "kat1", "nazwa", "")
            POZmod(temptxt, "kat1", "alarm", "")
            POZmod(temptxt, "kat2", "nazwa", "")
            POZmod(temptxt, "kat2", "alarm", "")
            POZmod(temptxt, "kat3", "nazwa", "")
            POZmod(temptxt, "kat3", "alarm", "")
            POZmod(temptxt, "kat4", "nazwa", "")
            POZmod(temptxt, "kat4", "alarm", "")
            POZmod(temptxt, "kat5", "nazwa", "")
            POZmod(temptxt, "kat5", "alarm", "")
            POZmod(temptxt, "kat6", "nazwa", "")
            POZmod(temptxt, "kat6", "alarm", "")
            updateFILE(START.folderapk, 15, "kat", temptxt)
        End If
        For i As Short = Now.Year - 10 To Now.Year + 10 Step 1
            lista2.Items.Add(i)
        Next
        lista2.SelectedIndex = 10
        lista1.SelectedIndex = Now.Month - 1
        konfiguracja = False
        aktkategorie()
        wyswkal(False)

        Select Case parametr
            Case "info"
                lista.Enabled = True
            Case "add"
                wybr = ""
                APK15edycja.ShowDialog()
                wyswkal(False)
                APK15edycja.Close()
        End Select
    End Sub

    Private Sub lista1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista1.SelectedIndexChanged
        If sel > ildniwmies(lista1.SelectedIndex + 1, lista2.Text) Then sel = ildniwmies(lista1.SelectedIndex + 1, lista2.Text)
        wyswkal(False)
        lista1.Enabled = False
        lista2.Enabled = False
        lista1.Enabled = True
        lista2.Enabled = True
    End Sub

    Private Sub lista2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista2.SelectedIndexChanged
        If sel > ildniwmies(lista1.SelectedIndex + 1, lista2.Text) Then sel = ildniwmies(lista1.SelectedIndex + 1, lista2.Text)
        wyswkal(False)
        lista1.Enabled = False
        lista2.Enabled = False
        lista1.Enabled = True
        lista2.Enabled = True
    End Sub

    Private Sub wyswkal(Optional ByVal czysczazn As Boolean = True, Optional ByVal resetpozwyd As Boolean = True)
        If konfiguracja Then Exit Sub
        If czysczazn Then sel = 0
        panelkal.Controls.Clear()
        Dim info As Date = New DateTime(lista2.Text, lista1.SelectedIndex + 1, 1)
        Dim x, y As Short
        If info.DayOfWeek = 0 Then x = 6 Else x = info.DayOfWeek - 1
        Dim dni(6) As Label

        Dim dane As String = openFILE(START.folderapk, 15, "lista")
        Dim znalezione As String = ""
        For Each i As String In GRarray(dane)
            Select Case POZget(dane, i, "cykl")
                Case "0"
                    If lista2.Text = POZget(dane, i, "rok") AndAlso lista1.SelectedIndex + 1 = POZget(dane, i, "miesiac") Then znalezione &= "#" & POZget(dane, i, "dzien").TrimStart("0") & "@"
                Case "1", "2", "3", "4", "5", "6", "7", "8", "9"
                    znalezione &= obslugacyklumies(New DateTime(POZget(dane, i, "rok"), POZget(dane, i, "miesiac"), POZget(dane, i, "dzien")), New DateTime(lista2.Text, lista1.SelectedIndex + 1, IIf(sel = 0, 1, sel)), POZget(dane, i, "cykl"))
                Case Else
                    START.bladdanych()
            End Select
        Next

        For i As Byte = 0 To 6 Step 1
            dni(i) = New Label()
            With dni(i)
                .Location = New Point(2 + i * 32, 8)
                .Size = New Size(30, 15)
                Select Case i
                    Case 0
                        .Text = "Pn"
                    Case 1
                        .Text = "Wt"
                    Case 2
                        .Text = "Śr"
                    Case 3
                        .Text = "Cz"
                    Case 4
                        .Text = "Pt"
                    Case 5
                        .Text = "So"
                    Case 6
                        .Text = "Nd"
                        .ForeColor = Color.Red
                End Select
                .TextAlign = ContentAlignment.MiddleCenter
            End With
            panelkal.Controls.Add(dni(i))
        Next
        For i As Byte = 1 To ildniwmies(lista1.SelectedIndex + 1, lista2.Text) Step 1
            Dim lbl As Label = New Label()
            With lbl
                .Location = New Point(2 + x * 32, 25 + y * 32)
                .Size = New Size(30, 30)
                .Text = i
                If x = 6 Then .ForeColor = Color.Red
                .Cursor = Cursors.Hand
                .Name = "day" & i
                .BorderStyle = Windows.Forms.BorderStyle.FixedSingle
                If i = Now.Day AndAlso lista1.SelectedIndex + 1 = Now.Month AndAlso lista2.Text = Now.Year Then .BackColor = Color.LightBlue
                If i = sel Then .BackColor = Color.Yellow
                If znalezione.IndexOf("#" & i & "@") >= 0 Then
                    .Font = New Font("Sans Serif", 8.25, FontStyle.Underline)
                    Dim nrkw As Byte = 0
                    For Each gri As String In GRarray(dane)
                        Dim wdniu As Boolean = False
                        Select Case POZget(dane, gri, "cykl")
                            Case "0"
                                If lista2.Text = POZget(dane, gri, "rok") AndAlso lista1.SelectedIndex + 1 = POZget(dane, gri, "miesiac") AndAlso POZget(dane, gri, "dzien").TrimStart("0") = i Then
                                    wdniu = True
                                End If
                            Case "1", "2", "3", "4", "5", "6", "7", "8", "9"
                                If obslugacyklumies(New DateTime(POZget(dane, gri, "rok"), POZget(dane, gri, "miesiac"), POZget(dane, gri, "dzien")), New DateTime(lista2.Text, lista1.SelectedIndex + 1, IIf(sel = 0, 1, sel)), POZget(dane, gri, "cykl")).IndexOf("#" & i & "@") >= 0 Then
                                    wdniu = True
                                End If
                        End Select
                        If wdniu And nrkw < 3 Then
                            Dim powpnl As Panel = New Panel()
                            With powpnl
                                .BorderStyle = Windows.Forms.BorderStyle.FixedSingle
                                Select Case POZget(dane, gri, "kat")
                                    Case "0"
                                        .BackColor = Color.Black
                                    Case "1"
                                        .BackColor = Color.Red
                                    Case "2"
                                        .BackColor = Color.DarkOrange
                                    Case "3"
                                        .BackColor = Color.Gold
                                    Case "4"
                                        .BackColor = Color.YellowGreen
                                    Case "5"
                                        .BackColor = Color.DodgerBlue
                                    Case "6"
                                        .BackColor = Color.DarkViolet
                                End Select
                                .Cursor = Cursors.Hand
                                .Name = "kw" & i
                                .Location = New Point(4 + x * 32 + (nrkw * 8), 46 + y * 32)
                                .Size = New Size(7, 7)
                            End With
                            nrkw += 1
                            panelkal.Controls.Add(powpnl)
                            AddHandler powpnl.Click, AddressOf klik2
                        End If
                    Next
                End If
            End With
            panelkal.Controls.Add(lbl)
            AddHandler lbl.Click, AddressOf klik
            x += 1
            If x = 7 Then
                x = 0
                y += 1
            End If
        Next
        dane = ""
        wyswwyd(resetpozwyd)
        lista1.Enabled = False
        lista2.Enabled = False
        lista1.Enabled = True
        lista2.Enabled = True
        START.zarzadzajzdarzeniami()
    End Sub

    Private Sub wyswwyd(ByVal resetpoz As Boolean)
        panelwew.Size = New Size(panellst.Size.Width, 0)
        If resetpoz Then
            panelwew = New Panel()
            panelwew.Location = New Point(0, 0)
            panelwew.Size = New Size(panellst.Size.Width, 0)
        End If
        panellst.Controls.Clear()
        If sel = 0 Then
            Dim tekst As Label = New Label()
            With tekst
                .Location = New Point(0, 0)
                .Size = New Size(panellst.Size.Width, panellst.Size.Height)
                .TextAlign = ContentAlignment.MiddleCenter
                .ForeColor = Color.LightGray
                .Text = "Nie wybrano dnia miesiąca"
            End With
            panellst.Controls.Add(tekst)
        Else
            Dim dane As String = openFILE(START.folderapk, 15, "lista")
            Dim znalezione As List(Of String) = New List(Of String)
            For Each i As String In GRarray(dane)
                Select Case POZget(dane, i, "cykl")
                    Case "0"
                        If lista2.Text = POZget(dane, i, "rok") AndAlso lista1.SelectedIndex + 1 = POZget(dane, i, "miesiac") AndAlso sel = POZget(dane, i, "dzien") Then znalezione.Add(i)
                    Case "1", "2", "3", "4", "5", "6", "7", "8", "9"
                        If obslugacyklu(New DateTime(POZget(dane, i, "rok"), POZget(dane, i, "miesiac"), POZget(dane, i, "dzien")), New DateTime(lista2.Text, lista1.SelectedIndex + 1, sel), POZget(dane, i, "cykl")) Then
                            znalezione.Add(i)
                        End If
                    Case Else
                        START.bladdanych()
                End Select
            Next
            If znalezione.Count = 0 Then
                Dim tekst As Label = New Label()
                With tekst
                    .Location = New Point(0, 0)
                    .Size = New Size(panellst.Size.Width, panellst.Size.Height)
                    .TextAlign = ContentAlignment.MiddleCenter
                    .ForeColor = Color.LightGray
                    .Text = "Brak wydarzeń w tym dniu"
                End With
                panellst.Controls.Add(tekst)
            Else
                For i As Short = 0 To znalezione.Count - 1 Step 1
                    Dim grfor As String = znalezione(i)
                    If POZget(dane, grfor, "calydzien") = "1" Then
                        znalezione(i) = "0000%" & grfor
                    Else
                        znalezione(i) = IIf(POZget(dane, grfor, "godz") < 10, "0" & POZget(dane, grfor, "godz"), POZget(dane, grfor, "godz")) & IIf(POZget(dane, grfor, "min") < 10, "0" & POZget(dane, grfor, "min"), POZget(dane, grfor, "min")) & "%" & grfor
                    End If
                Next
                znalezione.Sort()
                For i As Short = 0 To znalezione.Count - 1 Step 1
                    Dim pozycja As Panel = New Panel()
                    Dim pnlkat As Panel = New Panel()
                    Dim napis As Label = New Label()
                    Dim napis2 As Label = New Label()
                    Dim btnusun As MetroFramework.Controls.MetroLink = New MetroFramework.Controls.MetroLink()
                    With pozycja
                        .Location = New Point(0, panelwew.Size.Height)
                        .Size = New Size(panelwew.Size.Width, 40)
                        .Cursor = Cursors.Hand
                        .Name = znalezione(i).Substring(znalezione(i).IndexOf("%") + 1)
                    End With
                    With pnlkat
                        .Location = New Point(0, 0)
                        .Size = New Size(5, 40)
                        .Cursor = Cursors.Default
                        Select Case POZget(dane, znalezione(i).Substring(znalezione(i).IndexOf("%") + 1), "kat")
                            Case "0"
                                .BackColor = Color.Black
                            Case "1"
                                .BackColor = Color.Red
                            Case "2"
                                .BackColor = Color.DarkOrange
                            Case "3"
                                .BackColor = Color.Gold
                            Case "4"
                                .BackColor = Color.YellowGreen
                            Case "5"
                                .BackColor = Color.DodgerBlue
                            Case "6"
                                .BackColor = Color.DarkViolet
                        End Select
                    End With
                    With napis
                        .Location = New Point(10, 0)
                        .Size = New Size(250, 25)
                        .TextAlign = ContentAlignment.MiddleLeft
                        .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                        .Cursor = Cursors.Hand
                        .Name = znalezione(i).Substring(znalezione(i).IndexOf("%") + 1)
                    End With
                    With napis2
                        .Location = New Point(10, 25)
                        .Size = New Size(250, 15)
                        .TextAlign = ContentAlignment.MiddleLeft
                        .Cursor = Cursors.Hand
                        .Name = znalezione(i).Substring(znalezione(i).IndexOf("%") + 1)
                    End With
                    With btnusun
                        .Location = New Point(260, 20)
                        .Size = New Size(54, 20)
                        .Cursor = Cursors.Hand
                        .Text = "Usuń"
                        .Name = znalezione(i).Substring(znalezione(i).IndexOf("%") + 1)
                    End With
                    If znalezione(i).IndexOf("0000%") = 0 Then
                        napis.Text = POZget(dane, znalezione(i).Substring(znalezione(i).IndexOf("%") + 1), "nazwa")
                    Else
                        Dim g As String = POZget(dane, znalezione(i).Substring(znalezione(i).IndexOf("%") + 1), "godz")
                        Dim m As String = POZget(dane, znalezione(i).Substring(znalezione(i).IndexOf("%") + 1), "min")
                        If g < 10 Then g = "0" & g
                        If m < 10 Then m = "0" & m
                        napis.Text = g & ":" & m & " " & POZget(dane, znalezione(i).Substring(znalezione(i).IndexOf("%") + 1), "nazwa")
                    End If
                    napis2.Text = txtcykl(POZget(dane, znalezione(i).Substring(znalezione(i).IndexOf("%") + 1), "cykl"), POZget(dane, znalezione(i).Substring(znalezione(i).IndexOf("%") + 1), "rok"))
                    If IsNumeric(POZget(dane, znalezione(i).Substring(znalezione(i).IndexOf("%") + 1), "kat")) Then
                        If POZget(dane, znalezione(i).Substring(znalezione(i).IndexOf("%") + 1), "kat") >= 0 AndAlso POZget(dane, znalezione(i).Substring(znalezione(i).IndexOf("%") + 1), "kat") < 7 Then

                        Else
                            START.bladdanych()
                        End If
                    Else
                        START.bladdanych()
                    End If
                    If napis2.Text = "" Then
                        napis2.Text = nazwykat(POZget(dane, znalezione(i).Substring(znalezione(i).IndexOf("%") + 1), "kat"))
                    Else
                        If Not nazwykat(POZget(dane, znalezione(i).Substring(znalezione(i).IndexOf("%") + 1), "kat")) = "" Then
                            napis2.Text &= ", " & nazwykat(POZget(dane, znalezione(i).Substring(znalezione(i).IndexOf("%") + 1), "kat"))
                        End If
                    End If
                    pozycja.Controls.Add(pnlkat)
                    pozycja.Controls.Add(napis)
                    pozycja.Controls.Add(napis2)
                    pozycja.Controls.Add(btnusun)
                    AddHandler btnusun.Click, AddressOf pozusun
                    AddHandler pozycja.DoubleClick, AddressOf pozedycja
                    AddHandler napis.DoubleClick, AddressOf pozedycja
                    AddHandler napis2.DoubleClick, AddressOf pozedycja
                    panelwew.Size = New Size(panelwew.Size.Width, panelwew.Size.Height + 40)
                    panelwew.Controls.Add(pozycja)
                Next
                panellst.Controls.Add(panelwew)
            End If
        End If
        lblup.Visible = False
        lbldn.Visible = False
        If panelwew.Location.Y < 0 Then lblup.Visible = True
        If panelwew.Location.Y + panelwew.Size.Height > panellst.Size.Height Then lbldn.Visible = True
    End Sub

    Private Sub pozedycja(sender As Object, e As EventArgs)
        wybr = sender.Name
        APK15edycja.ShowDialog()
        If APK15edycja.DialogResult = DialogResult.OK Then wyswkal(False)
        APK15edycja.Close()
    End Sub

    Private Sub pozusun(sender As Object, e As EventArgs)
        Dim dane As String = openFILE(START.folderapk, 15, "lista")
        GRdel(dane, sender.Name)
        updateFILE(START.folderapk, 15, "lista", dane)
        wyswkal(False, False)
    End Sub

    Private Function obslugacyklumies(ByVal d1 As DateTime, ByVal d2 As DateTime, ByVal skok As Byte) As String
        Dim wynik As String = ""
        Do
            If d1.Month = d2.Month And d1.Year = d2.Year Then wynik &= "#" & d1.Day & "@"
            If d1.Year > d2.Year Then Exit Do
            Select Case skok
                Case 1
                    d1 = d1.AddDays(5)
                Case 2
                    d1 = d1.AddDays(7)
                Case 3
                    d1 = d1.AddDays(14)
                Case 4
                    d1 = d1.AddDays(21)
                Case 5
                    d1 = d1.AddMonths(1)
                Case 6
                    d1 = d1.AddMonths(2)
                Case 7
                    d1 = d1.AddMonths(3)
                Case 8
                    d1 = d1.AddMonths(6)
                Case 9
                    d1 = d1.AddYears(1)
                Case Else
                    START.bladdanych()
            End Select
        Loop
        Return wynik
    End Function

    Private Function obslugacyklu(ByVal d1 As DateTime, ByVal d2 As DateTime, ByVal skok As Byte) As Boolean
        If DateTime.Compare(d1, d2) < 0 Then
            Do
                Select Case skok
                    Case 1
                        d1 = d1.AddDays(5)
                    Case 2
                        d1 = d1.AddDays(7)
                    Case 3
                        d1 = d1.AddDays(14)
                    Case 4
                        d1 = d1.AddDays(21)
                    Case 5
                        d1 = d1.AddMonths(1)
                    Case 6
                        d1 = d1.AddMonths(2)
                    Case 7
                        d1 = d1.AddMonths(3)
                    Case 8
                        d1 = d1.AddMonths(6)
                    Case 9
                        d1 = d1.AddYears(1)
                    Case Else
                        START.bladdanych()
                End Select
                If DateTime.Compare(d1, d2) = 0 Then Return True
                If DateTime.Compare(d1, d2) > 0 Then Return False
            Loop
        Else
            If DateTime.Compare(d1, d2) = 0 Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Private Sub klik(sender As Object, e As EventArgs)
        Dim zazn As Boolean = False
        If lista1.SelectedIndex + 1 = Now.Month AndAlso lista2.Text = Now.Year Then zazn = True
        For Each i As Control In panelkal.Controls
            If i.Name.IndexOf("day") = 0 Then i.BackColor = Color.White
            If zazn AndAlso i.Name = "day" & Now.Day Then i.BackColor = Color.LightBlue
        Next
        sender.BackColor = Color.Yellow
        sel = sender.Name.Substring(3)
        wyswwyd(True)
        lista1.Enabled = False
        lista2.Enabled = False
        lista1.Enabled = True
        lista2.Enabled = True
    End Sub

    Private Sub klik2(sender As Object, e As EventArgs)
        sel = sender.Name.Substring(2)
        Dim zazn As Boolean = False
        If lista1.SelectedIndex + 1 = Now.Month AndAlso lista2.Text = Now.Year Then zazn = True
        For Each i As Control In panelkal.Controls
            If i.Name.IndexOf("day") = 0 Then i.BackColor = Color.White
            If zazn AndAlso i.Name = "day" & Now.Day Then i.BackColor = Color.LightBlue
            If i.Name = "day" & sel Then i.BackColor = Color.Yellow
        Next
        wyswwyd(True)
        lista1.Enabled = False
        lista2.Enabled = False
        lista1.Enabled = True
        lista2.Enabled = True
    End Sub

    Public Function ildniwmies(ByVal nr As Byte, ByVal rok As Short) As Byte
        Select Case nr
            Case 1, 3, 5, 7, 8, 10, 12
                Return 31
            Case 4, 6, 9, 11
                Return 30
            Case 2
                If rok Mod 4 = 0 Then Return 29 Else Return 28
            Case Else
                Return 0
        End Select
    End Function

    Private Function txtcykl(ByVal war As String, ByVal rok As String) As String
        Select Case war
            Case "0"
                Return ""
            Case "1"
                Return "Co 5 dni"
            Case "2"
                Return "Co tydzień"
            Case "3"
                Return "Co 2 tygodnie"
            Case "4"
                Return "Co 3 tygodnie"
            Case "5"
                Return "Co miesiąc"
            Case "6"
                Return "Co 2 miesiące"
            Case "7"
                Return "Co 3 miesiące"
            Case "8"
                Return "Co 6 miesięcy"
            Case "9"
                Dim r As Short = lista2.Text - rok
                Return "Rocznica (" & rok & IIf(r > 0, " - lat: " & r & ")", ")")
            Case Else
                START.bladdanych()
                Return ""
        End Select
    End Function

    Private Sub aktkategorie()
        Dim danekat As String = openFILE(START.folderapk, 15, "kat")
        For i As Byte = 0 To 6 Step 1
            nazwykat(i) = POZget(danekat, "kat" & i, "nazwa")
        Next
    End Sub

    Private Sub btnnowe_Click(sender As Object, e As EventArgs) Handles btnnowe.Click
        wybr = ""
        APK15edycja.ShowDialog()
        wyswkal(False)
        APK15edycja.Close()
    End Sub

    Private Sub btnkat_Click(sender As Object, e As EventArgs) Handles btnkat.Click
        APK15kategorie.ShowDialog()
        APK15kategorie.Close()
        aktkategorie()
        wyswkal(False)
    End Sub

    Private Sub btnzarzadzaj_Click(sender As Object, e As EventArgs) Handles btnzarzadzaj.Click
        APK15zarzadzaj.ShowDialog()
        APK15zarzadzaj.Close()
        wyswkal(False)
    End Sub

    Private Sub lbldn_Click(sender As Object, e As EventArgs) Handles lbldn.Click
        If panellst.Size.Height < panelwew.Location.Y + panelwew.Size.Height Then
            panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y - 30)
            lblup.Visible = False
            lbldn.Visible = False
            If panelwew.Location.Y < 0 Then lblup.Visible = True
            If panelwew.Location.Y + panelwew.Size.Height > panellst.Size.Height Then lbldn.Visible = True
        End If
    End Sub

    Private Sub lblup_Click(sender As Object, e As EventArgs) Handles lblup.Click
        If panelwew.Location.Y < 0 Then
            panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y + 30)
            lblup.Visible = False
            lbldn.Visible = False
            If panelwew.Location.Y < 0 Then lblup.Visible = True
            If panelwew.Location.Y + panelwew.Size.Height > panellst.Size.Height Then lbldn.Visible = True
        End If
    End Sub

    Private Sub APK15kalendarz_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            If panelwew.Location.Y < 0 Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y + 30)
            End If
        Else
            If panellst.Size.Height < panelwew.Location.Y + panelwew.Size.Height Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y - 30)
            End If
        End If
        lblup.Visible = False
        lbldn.Visible = False
        If panelwew.Location.Y < 0 Then lblup.Visible = True
        If panelwew.Location.Y + panelwew.Size.Height > panellst.Size.Height Then lbldn.Visible = True
    End Sub

    Private Sub lista_Tick(sender As Object, e As EventArgs) Handles lista.Tick
        lista.Enabled = False
        APK15info.ShowDialog()
        APK15info.Close()
    End Sub
End Class