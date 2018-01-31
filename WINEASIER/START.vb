Imports System.ComponentModel
Imports System.IO
Imports System.IO.Compression
Public Class START

    Public Const wersja As String = "2.2"

    Public folderapk As String = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\adan2013\WINEASIER"
    Public folderffmpeg As String = Application.StartupPath & "\ffmpeg\bin\ffmpeg.exe"
    Public foldernircmd As String = Application.StartupPath & "\nircmd.exe"
    Public skonfigurowany As Boolean = False
    Dim WithEvents keyb As KeyboardHook = New KeyboardHook
    Public wywolywaczPOZ As Byte = 1
    Public wywolywaczROZ As Byte = 10
    Public wyciszfullscreen As Boolean = False
    Public closeapk As Boolean = False

    Public konfiguracjamenu As String = ""
    Public konfiguracjamenu2 As String = ""

    Public skrotyklaw As List(Of String) = New List(Of String)
    Dim listaparametrow As List(Of String) = New List(Of String)
    Public powiadomienia As List(Of String) = New List(Of String)
    Public ostrzezenia As List(Of String) = New List(Of String)
    Public ciszapowiadomien As Boolean = False
    Dim nrdnia As Byte = 0

    Dim ikonamrug As Boolean = False

    Dim EVENTa As Boolean = False
    Dim EVENTh As Byte = 0
    Dim EVENTm As Byte = 0
    Dim EVENTid As List(Of String) = New List(Of String)

    Public infoerr As String = ""

    'wylacznik
    Public aktmouse As Byte = 0
    Public aktczas As Byte = 0
    Public wyswpow As Byte = 0
    Dim czasakt As DateTime
    Public czaswyl As DateTime

    Private Declare Function ShowWindow Lib "user32" (ByVal handle As IntPtr, ByVal nCmdShow As Integer) As Integer

#Region "fullscreendetector"

    Public Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    Public Declare Auto Function GetWindowRect Lib "User32.dll" (ByVal hWnd As IntPtr, ByRef rect As RECT) As Integer

    Private Function DetectFullScreen() As Boolean
        Dim clsScreen As System.Drawing.Rectangle = Screen.GetBounds(New System.Drawing.Point(0, 0))
        For Each clsProcess As System.Diagnostics.Process In System.Diagnostics.Process.GetProcesses
            Dim clsRect As New RECT
            Try
                If GetWindowRect(clsProcess.MainWindowHandle, clsRect) <> 0 Then
                    If clsRect.Top <= 0 And clsRect.Left <= 0 And clsRect.Right >= clsScreen.Width And clsRect.Bottom >= clsScreen.Height Then
                        Return True
                    End If
                End If
            Catch

            End Try
        Next
        Return False
    End Function
#End Region

#Region "KONFIGURACJA APLIKACJI"

    Public Function nazwaaplikacji(ByVal id As String) As String
        Select Case id
            Case 1
                Return "WINEASIER"
            Case 2
                Return "Stoper"
            Case 3
                Return "Minutnik"
            Case 4
                Return "Alarm"
            Case 5
                Return "ScreenShot"
            Case 6
                Return "Notatnik"
            Case 7
                Return "Disk Eject"
            Case 8
                Return "Sejf haseł"
            Case 9
                Return "Konwerter obrazów"
            Case 10
                Return "Konwerter audio"
            Case 11
                Return "Konwerter wideo"
            Case 12
                Return "Przelicznik walut"
            Case 13
                Return "Kopie zapasowe"
            Case 14
                Return "Magazyn stron WWW"
            Case 15
                Return "Kalendarz"
            Case 16
                Return "Selektor zdjęć"
            Case 17
                Return "Wyłącznik"
            Case 18
                Return "Color Picker"
            Case 19
                Return "Analizator dysku"
            Case Else
                Return ""
        End Select
    End Function

    Public Function opisaplikacji(ByVal id As String) As String
        Select Case id
            Case 1
                Return "WINEASIER"
            Case 2
                Return "Aplikacja służy do odmierzania czasu i zapisywaniu czasów pośrednich"
            Case 3
                Return "Aplikacja służy do odmierzenia ustawionego czasu i wyświetleniu powiadomienia"
            Case 4
                Return "Aplikacja służy do ustawiania alarmów na konkretną godzinę i dzień tygodnia"
            Case 5
                Return "Aplikacja służy do łatwego tworzenia zrzutów ekranu komputera oraz ich szybkiej edycji"
            Case 6
                Return "Aplikacja służy do zapisywania prostych notatek tekstowych"
            Case 7
                Return "Aplikacja zapobiega zostawieniu w komputerze przenośnych pamięci masowych oraz płyt w napędzie poprzez zablokowanie procesu zamykania systemu"
            Case 8
                Return "Aplikacja umożliwia zapis haseł do różnych portali internetowych lub aplikacji i zabezpieczenie ich jednym wspólnym hasłem"
            Case 9
                Return "Aplikacja służy do pojedynczej lub masowej konwersji, procesu przycinania i skalowania plików graficznych"
            Case 10
                Return "Aplikacja służy do konwersji plików audio, przycinania ich, a także zmiany parametrów dźwięku"
            Case 11
                Return "Aplikacja służy do konwersji plików wideo, przycinania ich, zmiany parametrów obrazu i dźwięku, separacji ścieżki dźwiękowej, a także do dodawania napisów do filmu"
            Case 12
                Return "Aplikacja pozwala na szybkie przeliczenie kwot pieniędzy zgodnie z najnowszymi kursami walut"
            Case 13
                Return "Aplikacja służy do szybkiego i zautomatyzowanego tworzenia kopii bezpieczeństwa plików użytkownika"
            Case 14
                Return "Aplikacja pozwala na zapisywanie adresów stron internetowych i grupowaniu ich w katalogach"
            Case 15
                Return "Aplikacja umożliwia wszelkiego rodzaju organizację dnia oraz przypominanie z wyprzedzeniem o ważnych wydarzeniach lub datach"
            Case 16
                Return "Aplikacja służy do łatwego i szybkiego przeprowadzenia selekcji zdjęć np. z wakacji"
            Case 17
                Return "Aplikacja umożliwia utworzenie skrótów zamykających system lub wylogowywujących użytkownika, a także automatycznego wyłączenia komputera po bezczynności klawiatury i myszy"
            Case 18
                Return "Aplikacja umożliwia łatwe pobierania koloru z ekranu komputera"
            Case 19
                Return "Aplikacja analizuje strukturę katalogową dysku i wyznacza katalogi, które zajmują najwięcej przestrzeni dyskowej"
            Case Else
                Return ""
        End Select
    End Function

    Public Function obiektaplikacji(ByVal id As String) As Form
        Select Case id
            Case 1
                Return menuform
            Case 2
                Return APK02stoper
            Case 3
                Return APK03minutnik
            Case 4
                Return APK04alarm
            Case 5
                Return APK05screenshot
            Case 6
                Return APK06notatnik
            Case 7
                Return APK07diskeject
            Case 8
                Return APK08sejfhasel
            Case 9
                Return APK09imageconverter
            Case 10
                Return APK10audioconverter
            Case 11
                Return APK11videoconverter
            Case 12
                Return APK12waluty
            Case 13
                Return APK13backup
            Case 14
                Return APK14magazynstronwww
            Case 15
                Return APK15kalendarz
            Case 16
                Return APK16selektorzdjec
            Case 17
                Return APK17wylacznik
            Case 18
                Return APK18colorpicker
            Case 19
                Return APK19analizatordysku
            Case Else
                Return menuform
        End Select
    End Function

    Public Function grafikaaplikacji(ByVal id As String) As Bitmap
        Select Case id
            Case 1
                Return My.Resources.logocien
            Case 2
                Return My.Resources.ico2
            Case 3
                Return My.Resources.ico3
            Case 4
                Return My.Resources.ico4
            Case 5
                Return My.Resources.ico5
            Case 6
                Return My.Resources.ico6
            Case 7
                Return My.Resources.ico7
            Case 8
                Return My.Resources.ico8
            Case 9
                Return My.Resources.ico9
            Case 10
                Return My.Resources.ico10
            Case 11
                Return My.Resources.ico11
            Case 12
                Return My.Resources.ico12
            Case 13
                Return My.Resources.ico13
            Case 14
                Return My.Resources.ico14
            Case 15
                Return My.Resources.ico15
            Case 16
                Return My.Resources.ico16
            Case 17
                Return My.Resources.ico17
            Case 18
                Return My.Resources.ico18
            Case 19
                Return My.Resources.ico19
            Case Else
                Return My.Resources.logocien
        End Select
    End Function

    Public Function akcjeaplikacji(ByVal id As String) As List(Of String)
        Dim wynik As List(Of String) = New List(Of String)
        wynik.Add("Otwórz okno aplikacji%")
        Select Case id
            Case 5
                wynik.Add("Wykonaj zrzut ekranu%WYKONAJ")
            Case 15
                wynik.Add("Dodaj wydarzenie%add")
                wynik.Add("Wyświetl najbliższe%info")
            Case 16

            Case 17
                wynik.Add("Wyłączenie zwykłe%poweroff")
                wynik.Add("Wyłączenie hybrydowe%hybridpoweroff")
                wynik.Add("Reset komputera%reset")
                wynik.Add("Wyloguj użytkownika%logout")
                wynik.Add("Hibernacja%hib")
                wynik.Add("Stan wstrzymania%wst")
                wynik.Add("Wyłącz funkcję%set1")
                wynik.Add("Włącz f. bez powiadomienia%set2")
                wynik.Add("Włącz f. z powiadomieniem%set3")
                wynik.Add("Wyłącz za 5 minut%off5")
                wynik.Add("Wyłącz za 10 minut%off10")
                wynik.Add("Wyłącz za 20 minut%off20")
                wynik.Add("Wyłącz za 30 minut%off30")
                wynik.Add("Anuluj wyłączenie%off0")
        End Select
        Return wynik
    End Function

#End Region

#Region "PARAMETRY URUCHAMIANIA"

    Public Sub dodajparametr(ByVal id As Byte, ByVal par As String)
        listaparametrow.Add(id & "%" & par)
    End Sub

    Public Function pobierzparametr(ByVal id As Byte) As String
        If listaparametrow.Count > 0 Then
            For i As Byte = 0 To listaparametrow.Count - 1 Step 1
                If listaparametrow.Item(i).IndexOf(id & "%") = 0 Then
                    Dim wynik As String = listaparametrow.Item(i)
                    listaparametrow.RemoveAt(i)
                    Return wynik.Substring(wynik.IndexOf("%") + 1)
                End If
            Next
        End If
        Return ""
    End Function
#End Region

#Region "POWIADOMIENIA"

    Public Sub dodajpowiadomienie(ByVal tresc As String, ByVal apk As Byte, ByVal parametry As String)
        powiadomienia.Add(Format(Now, "dd^MM^yyyy^HH^mm") & "^" & tresc & "^" & apk & "^" & parametry)
        If listapowiadomien.Visible Then listapowiadomien.aktualizuj()
        If Not ciszapowiadomien Then
            If wyciszfullscreen AndAlso DetectFullScreen() Then Exit Sub
            If powiadomienie.Visible Then
                powiadomienie.aktualizuj()
            Else
                ShowWindow(powiadomienie.Handle, 8)
            End If
        End If
    End Sub

    Public Sub usunpowiadomienie(ByVal id As Byte)
        If powiadomienia.Count > 0 Then
            powiadomienia.RemoveAt(id)
            If powiadomienia.Count = 0 Then
                NOTIFY.Icon = My.Resources.ikonawineasier
                ikonamrug = False
            End If
        End If
    End Sub

    Public Sub wyczyscpowiadomienia()
        powiadomienia.Clear()
        NOTIFY.Icon = My.Resources.ikonawineasier
        ikonamrug = False
    End Sub
#End Region

#Region "OSTRZEZENIA"

    Public Sub dodajostrzezenie(ByVal tresc As String, ByVal apk As Byte, ByVal parametry As String)
        ostrzezenia.Add(tresc & "^" & apk & "^" & parametry)
        If Not ostrzezenie.Visible Then ostrzezenie.Show()
    End Sub

    Public Function usunostrzezenie(ByVal id As Byte) As Boolean
        ostrzezenia.RemoveAt(id)
        If ostrzezenia.Count = 0 Then Return True Else Return False
    End Function

    Public Sub usunwszystkieostrzezenie()
        ostrzezenia.Clear()
    End Sub
#End Region

    Private Sub NOTIFY_Click(sender As Object, e As EventArgs) Handles NOTIFY.Click
        If Application.OpenForms().OfType(Of notifyform).Any Then
            notifyform.Close()
        Else
            If skonfigurowany Then notifyform.Show()
        End If
    End Sub

    Public Sub bladdanych()
        MsgBox("Wykryto błędne dane w plikach konfiguracyjnych programu" & vbNewLine & "Program zostanie zamknięty!", MsgBoxStyle.Critical, "ERROR")
        End
    End Sub

    Public Sub aktustawienia()
        Try
            If Not existFILE(folderapk, 1, "konfig", False) Then End
            Dim plik As String = openFILE(folderapk, 1, "konfig")
            wywolywaczPOZ = POZget(plik, "wyw", "poz")
            wywolywaczROZ = POZget(plik, "wyw", "roz")
            wyciszfullscreen = IIf(POZget(plik, "wyw", "fullscreen") = "1", True, False)
            closeapk = IIf(POZget(plik, "wyw", "closeapk") = "1", True, False)
            If wywolywaczPOZ < 0 Or wywolywaczPOZ > 4 Or wywolywaczROZ > 30 Then bladdanych()
            existFILE(folderapk, 1, "keyb", True)
            Dim key As String = openFILE(folderapk, 1, "keyb")
            If key <> "" Then
                skrotyklaw.Clear()
                For Each foreach As String In GRarray(key)
                    skrotyklaw.Add(POZget(key, foreach, "skrot") & "%" & POZget(key, foreach, "cel") & POZget(key, foreach, "par"))
                Next
            End If
            konfiguracjamenu = ""
            existFILE(folderapk, 1, "quickmenu", True)
            konfiguracjamenu = openFILE(folderapk, 1, "quickmenu")
            konfiguracjamenu2 = ""
            konfiguracjamenu2 = plik
            'apk13 - backup / zamiania statusu kopii z tworzenia na blad
            If existFILE(folderapk, 13, "lista", False) Then
                plik = openFILE(folderapk, 13, "lista")
                For Each i As String In GRarray(plik)
                    If POZget(plik, i, "status") = "3" Then POZmod(plik, i, "status", "0")
                    If POZget(plik, i, "status") = "5" Then POZmod(plik, i, "status", "0")
                    If POZget(plik, i, "status") = "1" Then POZmod(plik, i, "status", "3")
                    If POZget(plik, i, "status") = "4" Then POZmod(plik, i, "status", "5")
                Next
                updateFILE(folderapk, 13, "lista", plik)
            End If
            'apk17 - zaladowanie ustawien
            Dim dane As String = openFILE(folderapk, 17, "konfig")
            Select Case POZget(dane, "root", "ust")
                Case "0", ""

                Case "1"
                    If IsNumeric(POZget(dane, "root", "time")) AndAlso POZget(dane, "root", "time") >= 5 AndAlso POZget(dane, "root", "time") <= 60 Then
                        aktmouse = POZget(dane, "root", "time")
                    Else
                        bladdanych()
                    End If
                    wyswpow = 0
                    dodajpowiadomienie("Usługa wyłączenia komputera w przypadku bezczynności aktywna!", 17, "")
                Case "2"
                    If IsNumeric(POZget(dane, "root", "time")) AndAlso POZget(dane, "root", "time") >= 5 AndAlso POZget(dane, "root", "time") <= 60 Then
                        aktmouse = POZget(dane, "root", "time")
                    Else
                        bladdanych()
                    End If
                    wyswpow = 1
                    dodajpowiadomienie("Usługa wyłączenia komputera w przypadku bezczynności aktywna!", 17, "")
                Case Else
                    bladdanych()
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tmrukryj_Tick(sender As Object, e As EventArgs) Handles tmrukryj.Tick
        tmrukryj.Enabled = False
        Hide()
        If Not IO.Directory.Exists(folderapk) Then IO.Directory.CreateDirectory(folderapk)
        If existFILE(folderapk, 1, "konfig", False) Then
            'odczyt najwazniejszych parametrow
            aktustawienia()
            skonfigurowany = True
        Else
            'tryb konfiguracji
            konfiguracja.ShowDialog()
            If skonfigurowany Then
                aktustawienia()
            Else
                End
            End If
        End If
        tmr.Enabled = True
        zarzadzajzdarzeniami(True)
    End Sub

    Private Sub keyb_KeyDown(Key As Keys) Handles keyb.KeyDown
        czasakt = Now
        If skrotyklaw.Count = 0 Then Exit Sub
        Dim nac As String = My.Computer.Keyboard.CtrlKeyDown & My.Computer.Keyboard.AltKeyDown & My.Computer.Keyboard.ShiftKeyDown & "@" & Key.ToString() & "@"
        For i As Byte = 0 To skrotyklaw.Count - 1 Step 1
            If skrotyklaw(i).IndexOf(nac) = 0 Then
                Select Case skrotyklaw(i).Substring(skrotyklaw(i).IndexOf("%") + 1, 1)
                    Case 1 'pokazywanie i ukrywanie menu
                        If menuform.Visible Then
                            If Not menuform.ruch.Enabled Then menuform.ruch.Enabled = True
                        Else
                            menuform.Show()
                        End If
                    Case 2 'wywolywanie aplikacji WINEASIER
                        Dim tempstr As String = skrotyklaw(i).Substring(skrotyklaw(i).IndexOf("%") + 2)
                        dodajparametr(tempstr.Substring(0, tempstr.IndexOf("%")), tempstr.Substring(tempstr.IndexOf("%") + 1))
                        obiektaplikacji(tempstr.Substring(0, tempstr.IndexOf("%"))).Show()
                    Case 3 'wywolywanie aplikacji z komputera
                        Dim tempstr As String = skrotyklaw(i).Substring(skrotyklaw(i).IndexOf("%") + 2)
                        If tempstr.IndexOf("%") < 0 Then
                            Process.Start(tempstr)
                        Else
                            Process.Start(tempstr.Substring(0, tempstr.IndexOf("%")), tempstr.Substring(tempstr.IndexOf("%") + 1))
                        End If
                End Select
            End If
        Next
    End Sub

    Private Sub mrugikona_Tick(sender As Object, e As EventArgs) Handles mrugikona.Tick
        If powiadomienia.Count > 0 Then
            If ikonamrug Then
                NOTIFY.Icon = My.Resources.ikonawineasier
                ikonamrug = False
            Else
                NOTIFY.Icon = My.Resources.ikonawineasier2
                ikonamrug = True
            End If
        End If
    End Sub

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        'WYJATKI WYSWIETLEN FORMY
        If APK05zrzut.Visible OrElse APK18colorpicker.Visible Then Exit Sub
        Select Case wywolywaczPOZ
            Case 1
                If Cursor.Position.X <= wywolywaczROZ AndAlso Cursor.Position.Y <= wywolywaczROZ Then
                    If Application.OpenForms().OfType(Of wywolywaczform).Any Or menuform.Visible Then

                    Else
                        ShowWindow(wywolywaczform.Handle, 8)
                    End If
                End If
            Case 2
                If Cursor.Position.X >= Screen.PrimaryScreen.Bounds.Width - wywolywaczROZ AndAlso Cursor.Position.Y <= wywolywaczROZ Then
                    If Application.OpenForms().OfType(Of wywolywaczform).Any Or menuform.Visible Then

                    Else
                        ShowWindow(wywolywaczform.Handle, 8)
                    End If
                End If
            Case 3
                If Cursor.Position.X >= Screen.PrimaryScreen.Bounds.Width - wywolywaczROZ AndAlso Cursor.Position.Y >= Screen.PrimaryScreen.Bounds.Height - wywolywaczROZ Then
                    If Application.OpenForms().OfType(Of wywolywaczform).Any Or menuform.Visible Then

                    Else
                        ShowWindow(wywolywaczform.Handle, 8)
                    End If
                End If
            Case 4
                If Cursor.Position.X <= wywolywaczROZ AndAlso Cursor.Position.Y >= Screen.PrimaryScreen.Bounds.Height - wywolywaczROZ Then
                    If Application.OpenForms().OfType(Of wywolywaczform).Any Or menuform.Visible Then

                    Else
                        ShowWindow(wywolywaczform.Handle, 8)
                    End If
                End If
        End Select
        'obsluga aplikacji 17-Wylacznik
        Static ostpoz As Point = New Point(0, 0)
        If Cursor.Position.X = ostpoz.X AndAlso Cursor.Position.Y = ostpoz.Y Then
            If aktmouse > 0 Then
                If wyswpow = 1 AndAlso czasakt.AddMinutes(aktmouse - 1) < Now Then
                    dodajpowiadomienie("Za chwilę nastąpi wyłączenie komputera z powodu bezczynności." & vbNewLine & "Aby anulować rusz kursorem!", 17, "")
                    wyswpow = 2
                End If
                If czasakt.AddMinutes(aktmouse) < Now Then
                    If POZget(openFILE(folderapk, 17, "konfig"), "root", "typ") = "1" Then
                        runhideprogram("shutdown.exe", "/s /hybrid /t 0")
                    Else
                        runhideprogram("shutdown.exe", "/s /t 0")
                    End If
                    End
                End If
            End If
        Else
            czasakt = Now
            If wyswpow = 2 Then wyswpow = 1
        End If
        ostpoz = Cursor.Position
        If aktczas > 0 Then
            If czaswyl.AddMinutes(aktczas) < Now Then
                If POZget(openFILE(folderapk, 17, "konfig"), "root", "typ") = "1" Then
                    runhideprogram("shutdown.exe", "/s /hybrid /t 0")
                Else
                    runhideprogram("shutdown.exe", "/s /t 0")
                End If
                End
            End If
        End If
    End Sub

    Private Sub START_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'obsluga aplikacji 07-DiskEject
        If existFILE(folderapk, 7, "konfig", False) Then
            Dim dane As String = openFILE(folderapk, 7, "konfig")
            If POZget(dane, "root", "pwr") = 1 Then
                Dim wyj As String = POZget(dane, "root", "disk")
                If wyj.Length < 20 Then
                    Dim ilosc As Byte = 0
                    For Each i As IO.DriveInfo In IO.DriveInfo.GetDrives
                        If i.IsReady Then
                            If wyj.IndexOf(i.Name.Substring(0, i.Name.IndexOf(":")).ToLower()) < 0 Then
                                ilosc += 1
                            End If
                        End If
                    Next
                    If ilosc > 0 Then
                        e.Cancel = True
                        If diskejecttimer.Enabled Then diskejecttimer.Enabled = False
                        Select Case POZget(dane, "root", "time")
                            Case 1

                            Case 2
                                diskejecttimer.Interval = 5000
                                diskejecttimer.Enabled = True
                            Case 3
                                diskejecttimer.Interval = 15000
                                diskejecttimer.Enabled = True
                            Case 4
                                diskejecttimer.Interval = 25000
                                diskejecttimer.Enabled = True
                            Case Else
                                bladdanych()
                        End Select
                        dodajostrzezenie("Usługa Disk Eject wykryła niewyjęte pamięci wymienne podłączone" & vbNewLine & "do tego komputera. Ilość wykrytych pamięci: " & ilosc, 7, "RAPORT")
                    End If
                Else
                    bladdanych()
                End If
            End If
        End If
    End Sub

    Private Sub diskejecttimer_Tick(sender As Object, e As EventArgs) Handles diskejecttimer.Tick
        diskejecttimer.Enabled = False
        If ostrzezenie.Visible Then End
    End Sub

    Public Function checkffmpeg() As Boolean
        If Not IO.File.Exists(folderffmpeg) Then
            FFMPEGerror.ShowDialog()
            Return False
        End If
        Return True
    End Function

    Public Function checknircmd() As Boolean
        If Not IO.File.Exists(foldernircmd) Then
            NIRCMDerror.ShowDialog()
            Return False
        End If
        Return True
    End Function

    Public Sub zarzadzajzdarzeniami(Optional ByVal wyswkal As Boolean = False)
        Dim plik As String = ""
        EVENTid.Clear()
        'skan 04 alarm
        If existFILE(folderapk, 4, "lista", False) Then
            plik = openFILE(folderapk, 4, "lista")
            For Each gr As String In GRarray(plik)
                If POZget(plik, gr, "pwr") = 1 Then
                    If POZget(plik, gr, "dzien") = "0000000" Then
                        dodajevent(4, gr, POZget(plik, gr, "godz"), POZget(plik, gr, "min"))
                    Else
                        If Now.DayOfWeek = 0 Then
                            If POZget(plik, gr, "dzien").Substring(6, 1) = "1" Then
                                dodajevent(4, gr, POZget(plik, gr, "godz"), POZget(plik, gr, "min"))
                            End If
                        Else
                            If POZget(plik, gr, "dzien").Substring(Now.DayOfWeek - 1, 1) = "1" Then
                                dodajevent(4, gr, POZget(plik, gr, "godz"), POZget(plik, gr, "min"))
                            End If
                        End If
                    End If
                End If
            Next
        End If
        'skan 15 kalendarz
        If existFILE(folderapk, 15, "lista", False) Then
            plik = openFILE(folderapk, 15, "lista")
            Dim ilwyd As Byte = 0
            For Each gr As String In GRarray(plik)
                If Not getkatmessagetime(POZget(plik, gr, "kat")) = "" Then
                    Dim d1 As DateTime = New DateTime(POZget(plik, gr, "rok"), POZget(plik, gr, "miesiac"), POZget(plik, gr, "dzien"))
                    Dim d2 As DateTime = New DateTime(Now.Year, Now.Month, Now.Day)
                    Do
                        If DateTime.Compare(d1, d2) >= 0 Then
                            If DateTime.Compare(d1.AddDays(getkatmessagetime(POZget(plik, gr, "kat")) * -1), d2) <= 0 Then
                                'dodaj powiadomienie
                                ilwyd += 1
                                Exit Do
                            End If
                        End If
                        Select Case POZget(plik, gr, "cykl")
                            Case 0
                                Exit Do
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
                                bladdanych()
                        End Select
                        If DateTime.Compare(d1.AddDays(-10), d2) > 0 Then Exit Do
                    Loop
                End If
            Next
            If ilwyd > 0 And Not APK15kalendarz.Visible Then
                If wyswkal Then dodajpowiadomienie("Liczba zbliżających się wydarzeń: " & ilwyd, 15, "info")
            End If
        End If

        If EVENTid.Count = 0 Then EVENTa = False
    End Sub

    Private Sub dodajevent(ByVal id As Byte, ByVal adr As String, ByVal h As Byte, ByVal m As Byte)
        If EVENTa Then
            If EVENTh = h And EVENTm = m Then
                EVENTid.Add(id & "%" & adr)
            Else
                If EVENTh & EVENTm > h & m AndAlso h & m > Now.Hour & Now.Minute Then
                    EVENTid.Clear()
                    EVENTh = h
                    EVENTm = m
                    EVENTid.Add(id & "%" & adr)
                End If
            End If
        Else
            If h & m > Now.Hour & Now.Minute Then
                EVENTa = True
                EVENTh = h
                EVENTm = m
                EVENTid.Add(id & "%" & adr)
            End If
        End If
    End Sub

    Private Sub zdarzenia_Tick(sender As Object, e As EventArgs) Handles zdarzenia.Tick
        If EVENTa Then
            If EVENTh < Now.Hour Then
                zarzadzajzdarzeniami()
            Else
                If EVENTh = Now.Hour AndAlso EVENTm < Now.Minute Then zarzadzajzdarzeniami()
            End If
        End If
        If Now.Hour = 0 AndAlso Now.Minute = 0 AndAlso Now.Day <> nrdnia Then
            nrdnia = Now.Day
            zarzadzajzdarzeniami(True)
        Else
            If EVENTa AndAlso EVENTh = Now.Hour AndAlso EVENTm = Now.Minute Then
                zdarzenia.Enabled = False
                executeevent()
                zdarzenia.Enabled = True
                zarzadzajzdarzeniami()
            End If
        End If
    End Sub

    Private Sub executeevent()
        Dim plik As String = ""
        For Each poz As String In EVENTid
            Select Case poz.Substring(0, poz.IndexOf("%"))
                Case 4
                    If existFILE(folderapk, 4, "lista", False) Then
                        plik = openFILE(folderapk, 4, "lista")
                        If GRexist(plik, poz.Substring(poz.IndexOf("%") + 1)) AndAlso POZget(plik, poz.Substring(poz.IndexOf("%") + 1), "pwr") = "1" Then
                            If POZget(plik, poz.Substring(poz.IndexOf("%") + 1), "dzien") = "0000000" Then
                                POZmod(plik, poz.Substring(poz.IndexOf("%") + 1), "pwr", "0")
                                updateFILE(folderapk, 4, "lista", plik)
                                If APK04alarm.Visible Then APK04alarm.aktualizujliste(False)
                            End If
                            Select Case POZget(plik, poz.Substring(poz.IndexOf("%") + 1), "cel")
                                Case 1
                                    dodajostrzezenie("Na godzinę " & Now.Hour & ":" & Now.Minute & " został ustawiony budzik" & vbNewLine & IIf(POZget(plik, poz.Substring(poz.IndexOf("%") + 1), "opis") = "", "", "Opis: " & POZget(plik, poz.Substring(poz.IndexOf("%") + 1), "opis")), 4, "")
                                Case 2
                                    dodajpowiadomienie("Na godzinę " & Now.Hour & ":" & Now.Minute & " został ustawiony budzik" & vbNewLine & IIf(POZget(plik, poz.Substring(poz.IndexOf("%") + 1), "opis") = "", "", "Opis: " & POZget(plik, poz.Substring(poz.IndexOf("%") + 1), "opis")), 4, "")
                                Case 3
                                    Select Case POZget(plik, poz.Substring(poz.IndexOf("%") + 1), "par")
                                        Case 0
                                            runhideprogram("shutdown.exe", "/s /t 0")
                                            End
                                        Case 1
                                            runhideprogram("shutdown.exe", "/s /hybrid /t 0")
                                            End
                                        Case 2
                                            runhideprogram("shutdown.exe", "/l")
                                            End
                                        Case 3
                                            runhideprogram("shutdown.exe", "/r")
                                            End
                                        Case 4
                                            runhideprogram("shutdown.exe", "/h")
                                        Case 5
                                            If checknircmd() Then runhideprogram(foldernircmd, "standby")
                                        Case 6
                                            If checknircmd() Then runhideprogram(foldernircmd, "mutesysvolume 1")
                                        Case 7
                                            If checknircmd() Then runhideprogram(foldernircmd, "mutesysvolume 0")
                                        Case 8
                                            If checknircmd() Then runhideprogram(foldernircmd, "setsysvolume 16383")
                                        Case 9
                                            If checknircmd() Then runhideprogram(foldernircmd, "setsysvolume 32767")
                                        Case 10
                                            If checknircmd() Then runhideprogram(foldernircmd, "setsysvolume 49151")
                                        Case 11
                                            If checknircmd() Then runhideprogram(foldernircmd, "setsysvolume 65535")
                                    End Select
                                Case 4
                                    Try
                                        If Not POZget(plik, poz.Substring(poz.IndexOf("%") + 1), "par") = "" Then
                                            If POZget(plik, poz.Substring(poz.IndexOf("%") + 1), "par").IndexOf("://") < 0 Then
                                                If POZget(plik, poz.Substring(poz.IndexOf("%") + 1), "par").IndexOf("%") < 0 Then
                                                    Process.Start(POZget(plik, poz.Substring(poz.IndexOf("%") + 1), "par"))
                                                Else
                                                    Process.Start(POZget(plik, poz.Substring(poz.IndexOf("%") + 1), "par").Substring(0, POZget(plik, poz.Substring(poz.IndexOf("%") + 1), "par").IndexOf("%")), POZget(plik, poz.Substring(poz.IndexOf("%") + 1), "par").Substring(POZget(plik, poz.Substring(poz.IndexOf("%") + 1), "par").IndexOf("%") + 1))
                                                End If
                                            Else
                                                Process.Start(POZget(plik, poz.Substring(poz.IndexOf("%") + 1), "par"))
                                            End If
                                        End If
                                    Catch ex As Exception

                                    End Try
                            End Select
                        End If
                    End If
            End Select
        Next
        EVENTa = False
        EVENTid.Clear()
    End Sub

    Public Sub runhideprogram(ByVal sciezka As String, ByVal argumenty As String)
        Dim procinfo As ProcessStartInfo = New ProcessStartInfo()
        With procinfo
            .FileName = sciezka
            .Arguments = argumenty
            .UseShellExecute = False
            .WindowStyle = ProcessWindowStyle.Hidden
            .RedirectStandardError = True
            .RedirectStandardOutput = True
            .CreateNoWindow = True
        End With
        Dim proc = New Process()
        With proc
            .StartInfo = procinfo
            .Start()
        End With
    End Sub

    Private Sub backuptimer_Tick(sender As Object, e As EventArgs) Handles backuptimer.Tick
        backuptimer.Enabled = False
        bgwbackup.RunWorkerAsync()
    End Sub

    Private Sub bgwbackup_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwbackup.RunWorkerCompleted
        If e.Error IsNot Nothing Then Throw New Exception("", e.Error)
        backuptimer.Enabled = True
    End Sub

    Private Sub bgwbackup_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwbackup.DoWork
        Dim plik As String = openFILE(folderapk, 13, "lista")
        For Each i As String In GRarray(plik)
            Select Case POZget(plik, i, "status")
                Case "0", "3", "5"
                    'oblicz czas
                    If Not POZget(plik, i, "hz") = "0" Then
                        Dim tpoz As DateTime
                        If POZget(plik, i, "lastY") = "" Or POZget(plik, i, "lastM") = "" Or POZget(plik, i, "lastD") = "" Or POZget(plik, i, "lastHR") = "" Or POZget(plik, i, "lastMIN") = "" Then
                            tpoz = New DateTime(2000, 1, 1, 0, 0, 0)
                        Else
                            tpoz = New DateTime(POZget(plik, i, "lastY"), POZget(plik, i, "lastM"), POZget(plik, i, "lastD"), POZget(plik, i, "lastHR"), POZget(plik, i, "lastMIN"), 0)
                        End If
                        If (Now - tpoz).TotalMinutes > getpozhzAPK13(POZget(plik, i, "hz")) Then
                            POZmod(plik, i, "status", "2")
                            updateFILE(folderapk, 13, "lista", plik)
                        End If
                    End If
                Case "1"
                    POZmod(plik, i, "status", "3")
                Case "2"
                    POZmod(plik, i, "status", "1")
                    updateFILE(folderapk, 13, "lista", plik)

                    Try

                        Dim danekopii As String = POZget(plik, i, "nazwa") & "-" & Now.Hour & "-" & Now.Minute & "-" & Now.Day & "-" & Now.Month & "-" & Now.Year

                        'utworz kopie

                        'czy plik pozycji istnieje
                        If existFILE(folderapk, 13, "POZ-" & POZget(plik, i, "nazwa"), False) Then

                            'pobieranie danych
                            Dim tempfile As String = openFILE(folderapk, 13, "POZ-" & POZget(plik, i, "nazwa"))
                            Dim magazynfile As String = openFILE(folderapk, 13, "folder")
                            Dim magazyndanych As String = POZget(magazynfile, "konfig", "path")

                            'sprawdzanie folderu magazynu danych
                            If IO.Directory.Exists(magazyndanych) Then
                                Try
                                    directorysize(magazyndanych, False)
                                Catch ex As Exception
                                    Invoke(Sub() dodajpowiadomienie("Brak dostępu do folderu magazynu danych!", 13, ""))
                                    POZmod(plik, i, "status", "0")
                                    POZmod(plik, i, "lastHR", danekopii.Split("-")(1))
                                    POZmod(plik, i, "lastMIN", danekopii.Split("-")(2))
                                    POZmod(plik, i, "lastD", danekopii.Split("-")(3))
                                    POZmod(plik, i, "lastM", danekopii.Split("-")(4))
                                    POZmod(plik, i, "lastY", danekopii.Split("-")(5))
                                    updateFILE(folderapk, 13, "lista", plik)
                                    Continue For
                                End Try
                            Else
                                If magazyndanych = "" Then
                                    Invoke(Sub() dodajpowiadomienie("Brak folderu magazynu danych!", 13, ""))
                                Else
                                    Invoke(Sub() dodajpowiadomienie("Folder magazynu danych został usunięty!", 13, ""))
                                End If
                                POZmod(plik, i, "status", "0")
                                POZmod(plik, i, "lastHR", danekopii.Split("-")(1))
                                POZmod(plik, i, "lastMIN", danekopii.Split("-")(2))
                                POZmod(plik, i, "lastD", danekopii.Split("-")(3))
                                POZmod(plik, i, "lastM", danekopii.Split("-")(4))
                                POZmod(plik, i, "lastY", danekopii.Split("-")(5))
                                updateFILE(folderapk, 13, "lista", plik)
                                Continue For
                            End If

                            'obliczanie ilości utworzonych kopii oraz ich usuwanie
                            Dim ilpoz As Byte = 0
                            For Each q As String In GRarray(tempfile)
                                ilpoz += 1
                            Next
                            If ilpoz > 0 Then
                                Do While ilpoz >= getpozil(POZget(plik, i, "il"))
                                    Dim grupa As String = GRarray(tempfile)(0)
                                    Dim folder As String = POZget(plik, i, "nazwa") & "-" & POZget(tempfile, grupa, "h") & "-" & POZget(tempfile, grupa, "m") & "-" & POZget(tempfile, grupa, "Dd") & "-" & POZget(tempfile, grupa, "Dm") & "-" & POZget(tempfile, grupa, "Dy")
                                    Try
                                        If IO.File.Exists(magazyndanych & "\" & folder & ".zip") Then IO.File.Delete(magazyndanych & "\" & folder & ".zip")
                                    Catch ex As Exception

                                    End Try
                                    GRdel(tempfile, grupa)
                                    updateFILE(folderapk, 13, "POZ-" & POZget(plik, i, "nazwa"), tempfile)
                                    ilpoz = 0
                                    For Each q As String In GRarray(tempfile)
                                        ilpoz += 1
                                    Next
                                Loop
                            End If

                            'sprawdzanie folderu danych pozycji
                            Try
                                If IO.Directory.Exists(POZget(plik, i, "path")) Then

                                Else
                                    Invoke(Sub() dodajpowiadomienie("Nie znaleziono folderu z danymi pozycji o nazwie " & POZget(plik, i, "nazwa"), 13, ""))
                                    POZmod(plik, i, "status", "0")
                                    POZmod(plik, i, "lastHR", danekopii.Split("-")(1))
                                    POZmod(plik, i, "lastMIN", danekopii.Split("-")(2))
                                    POZmod(plik, i, "lastD", danekopii.Split("-")(3))
                                    POZmod(plik, i, "lastM", danekopii.Split("-")(4))
                                    POZmod(plik, i, "lastY", danekopii.Split("-")(5))
                                    updateFILE(folderapk, 13, "lista", plik)
                                    Continue For
                                End If
                            Catch ex As Exception
                                Invoke(Sub() dodajpowiadomienie("Nie znaleziono folderu z danymi pozycji o nazwie " & POZget(plik, i, "nazwa"), 13, ""))
                                POZmod(plik, i, "status", "0")
                                POZmod(plik, i, "lastHR", danekopii.Split("-")(1))
                                POZmod(plik, i, "lastMIN", danekopii.Split("-")(2))
                                POZmod(plik, i, "lastD", danekopii.Split("-")(3))
                                POZmod(plik, i, "lastM", danekopii.Split("-")(4))
                                POZmod(plik, i, "lastY", danekopii.Split("-")(5))
                                updateFILE(folderapk, 13, "lista", plik)
                                Continue For
                            End Try
                            Try
                                directorysize(POZget(plik, i, "path"), False)
                            Catch ex As Exception
                                Invoke(Sub() dodajpowiadomienie("Brak dostępu do folderu z danymi pozycji o nazwie " & POZget(plik, i, "nazwa") & "!", 13, ""))
                                POZmod(plik, i, "status", "0")
                                POZmod(plik, i, "lastHR", danekopii.Split("-")(1))
                                POZmod(plik, i, "lastMIN", danekopii.Split("-")(2))
                                POZmod(plik, i, "lastD", danekopii.Split("-")(3))
                                POZmod(plik, i, "lastM", danekopii.Split("-")(4))
                                POZmod(plik, i, "lastY", danekopii.Split("-")(5))
                                updateFILE(folderapk, 13, "lista", plik)
                                Continue For
                            End Try

                            Dim magazynrozmiar As Integer = directorysize(magazyndanych, True)
                            Dim nowyrozmiar As Short = directorysize(POZget(plik, i, "path"), True)

                            'sprawdzic info
                            If IsNumeric(POZget(magazynfile, "konfig", "info")) Then
                                If POZget(magazynfile, "konfig", "info") > 0 AndAlso POZget(magazynfile, "konfig", "info") < 4097 Then
                                    If magazynrozmiar + nowyrozmiar > POZget(magazynfile, "konfig", "info") Then
                                        Invoke(Sub() dodajpowiadomienie("Magazyn danych przekroczył próg " & POZget(magazynfile, "konfig", "info") & "MB!", 13, ""))
                                    End If
                                Else
                                    If Not POZget(magazynfile, "konfig", "info") = 0 Then Invoke(Sub() bladdanych())
                                End If
                            Else
                                Invoke(Sub() bladdanych())
                            End If

                            'sprawdzic limit
                            If IsNumeric(POZget(magazynfile, "konfig", "limit")) Then
                                If POZget(magazynfile, "konfig", "limit") > 0 AndAlso POZget(magazynfile, "konfig", "limit") < 4097 Then
                                    If magazynrozmiar + nowyrozmiar > POZget(magazynfile, "konfig", "limit") Then
                                        Invoke(Sub() dodajpowiadomienie("Kopia danych pozycji o nazwie " & POZget(plik, i, "nazwa") & " nie została utworzona! Przekroczono limitu rozmiaru magazynu danych!", 13, ""))
                                        POZmod(plik, i, "lastHR", danekopii.Split("-")(1))
                                        POZmod(plik, i, "lastMIN", danekopii.Split("-")(2))
                                        POZmod(plik, i, "lastD", danekopii.Split("-")(3))
                                        POZmod(plik, i, "lastM", danekopii.Split("-")(4))
                                        POZmod(plik, i, "lastY", danekopii.Split("-")(5))
                                        updateFILE(folderapk, 13, "lista", plik)
                                        Continue For
                                    End If
                                Else
                                    If Not POZget(magazynfile, "konfig", "limit") = 0 Then Invoke(Sub() bladdanych())
                                End If
                            Else
                                Invoke(Sub() bladdanych())
                            End If

                            Try
                                If New DriveInfo(magazyndanych.Substring(0, magazyndanych.IndexOf(":") + 2)).TotalFreeSpace - (directorysize(POZget(plik, i, "path"), False) + 52428800) <= 0 Then
                                    Invoke(Sub() dodajpowiadomienie("Nie można wykonać kopii, ponieważ partycja magazynu danych jest zapełniona!", 13, ""))
                                    POZmod(plik, i, "status", "0")

                                    POZmod(plik, i, "lastHR", danekopii.Split("-")(1))
                                    POZmod(plik, i, "lastMIN", danekopii.Split("-")(2))
                                    POZmod(plik, i, "lastD", danekopii.Split("-")(3))
                                    POZmod(plik, i, "lastM", danekopii.Split("-")(4))
                                    POZmod(plik, i, "lastY", danekopii.Split("-")(5))
                                    updateFILE(folderapk, 13, "lista", plik)
                                    Continue For
                                End If
                            Catch ex As Exception
                                Invoke(Sub() dodajpowiadomienie("Bład tworzenia kopii pozycji o nazwie " & POZget(plik, i, "nazwa"), 13, ""))
                                POZmod(plik, i, "status", "3")
                                updateFILE(folderapk, 13, "lista", plik)
                                Continue For
                            End Try

                            'rozpoczynanie tworzenia kopii
                            Dim opcje As String = POZget(plik, i, "opcje")
                            If opcje.Length = 4 Then
                                For w As Byte = 0 To 3 Step 1
                                    If opcje.Substring(w, 1) = "0" OrElse opcje.Substring(w, 1) = "1" Then

                                    Else
                                        Invoke(Sub() bladdanych())
                                    End If
                                Next
                            Else
                                Invoke(Sub() bladdanych())
                            End If

                            If opcje.Substring(0, 1) = "1" Then Invoke(Sub() dodajpowiadomienie("Rozpoczęto tworzenie kopii pozycji o nazwie " & POZget(plik, i, "nazwa"), 13, ""))

                            If opcje.Substring(2, 1) = "1" Then
                                Try
                                    Process.Start(POZget(plik, i, "start"))
                                Catch ex As Exception
                                    Invoke(Sub() dodajpowiadomienie("Błąd uruchomiania programu startowego pozycji o nazwie " & POZget(plik, i, "nazwa"), 13, ""))
                                End Try
                            End If

                            'tworzenie kopii
                            Try

                                ZipFile.CreateFromDirectory(POZget(plik, i, "path"), magazyndanych & "\" & danekopii & ".zip", CompressionLevel.NoCompression, False)

                                POZmod(plik, i, "lastHR", danekopii.Split("-")(1))
                                POZmod(plik, i, "lastMIN", danekopii.Split("-")(2))
                                POZmod(plik, i, "lastD", danekopii.Split("-")(3))
                                POZmod(plik, i, "lastM", danekopii.Split("-")(4))
                                POZmod(plik, i, "lastY", danekopii.Split("-")(5))
                                updateFILE(folderapk, 13, "lista", plik)
                                Dim grupapozycji As String = ""
                                For g As Byte = 0 To 50 Step 1
                                    If Not GRexist(tempfile, "poz" & g) Then
                                        grupapozycji = "poz" & g
                                        Exit For
                                    End If
                                Next
                                If grupapozycji = "" Then Invoke(Sub() bladdanych())
                                POZmod(tempfile, grupapozycji, "h", danekopii.Split("-")(1))
                                POZmod(tempfile, grupapozycji, "m", danekopii.Split("-")(2))
                                POZmod(tempfile, grupapozycji, "Dd", danekopii.Split("-")(3))
                                POZmod(tempfile, grupapozycji, "Dm", danekopii.Split("-")(4))
                                POZmod(tempfile, grupapozycji, "Dy", danekopii.Split("-")(5))
                                updateFILE(folderapk, 13, "POZ-" & POZget(plik, i, "nazwa"), tempfile)
                                POZmod(plik, i, "status", "0")
                            Catch ex As Exception
                                Invoke(Sub() dodajpowiadomienie("Bład tworzenia kopii pozycji o nazwie " & POZget(plik, i, "nazwa"), 13, ""))
                                POZmod(plik, i, "status", "3")
                                updateFILE(folderapk, 13, "lista", plik)
                                Continue For
                            End Try

                            'konczenie tworzenia kopii
                            If opcje.Substring(1, 1) = "1" Then Invoke(Sub() dodajpowiadomienie("Zakończono tworzenie kopii pozycji o nazwie " & POZget(plik, i, "nazwa"), 13, ""))

                            If opcje.Substring(3, 1) = "1" Then
                                Try
                                    Process.Start(POZget(plik, i, "koniec"))
                                Catch ex As Exception
                                    Invoke(Sub() dodajpowiadomienie("Błąd uruchomiania programu końcowego pozycji o nazwie " & POZget(plik, i, "nazwa"), 13, ""))
                                End Try
                            End If

                        End If

                    Catch ex As Exception
                        POZmod(plik, i, "status", "3")
                        updateFILE(folderapk, 13, "lista", plik)
                    End Try
                Case "4"

                    Dim sukcesprzywr As Boolean = False

                    Try

                        'przywroc dane
                        If existFILE(folderapk, 13, "przywracanie", False) Then
                            Dim plikprzywr As String = openFILE(folderapk, 13, "przywracanie")
                            For Each o As String In GRarray(plikprzywr)
                                If POZget(plik, i, "nazwa") = POZget(plikprzywr, o, "nazwa") Then
                                    If existFILE(folderapk, 13, "POZ-" & POZget(plik, i, "nazwa"), False) Then
                                        Dim plikpoz As String = openFILE(folderapk, 13, "POZ-" & POZget(plik, i, "nazwa"))
                                        If GRexist(plikpoz, POZget(plikprzywr, o, "pozycja")) Then
                                            Dim grupapoz As String = POZget(plikprzywr, o, "pozycja")
                                            Dim folder As String = POZget(plik, i, "nazwa") & "-" & POZget(plikpoz, grupapoz, "h") & "-" & POZget(plikpoz, grupapoz, "m") & "-" & POZget(plikpoz, grupapoz, "Dd") & "-" & POZget(plikpoz, grupapoz, "Dm") & "-" & POZget(plikpoz, grupapoz, "Dy")

                                            Try
                                                'przywracanie danych

                                                Try
                                                    directorysize(POZget(openFILE(folderapk, 13, "folder"), "konfig", "path"), False)
                                                Catch ex As Exception
                                                    POZmod(plik, i, "status", "5")
                                                    Invoke(Sub() dodajpowiadomienie("Wystąpił błąd podczas przywracania danych pozycji o nazwie " & POZget(plik, i, "nazwa"), 13, ""))
                                                End Try
                                                Try
                                                    directorysize(POZget(plik, i, "path"), False)
                                                Catch ex As Exception
                                                    POZmod(plik, i, "status", "5")
                                                    Invoke(Sub() dodajpowiadomienie("Wystąpił błąd podczas przywracania danych pozycji o nazwie " & POZget(plik, i, "nazwa"), 13, ""))
                                                End Try

                                                Try
                                                    If New DriveInfo(POZget(plik, i, "path").Substring(0, POZget(plik, i, "path").IndexOf(":") + 2)).TotalFreeSpace + directorysize(POZget(plik, i, "path"), False) - (New FileInfo(POZget(openFILE(folderapk, 13, "folder"), "konfig", "path") & "\" & folder & ".zip").Length + 52428800) <= 0 Then
                                                        Invoke(Sub() dodajpowiadomienie("Wystąpił błąd podczas przywracania danych pozycji o nazwie " & POZget(plik, i, "nazwa"), 13, ""))
                                                        POZmod(plik, i, "status", "5")
                                                        updateFILE(folderapk, 13, "lista", plik)
                                                        Continue For
                                                    End If
                                                Catch ex As Exception
                                                    Invoke(Sub() dodajpowiadomienie("Wystąpił błąd podczas przywracania danych pozycji o nazwie " & POZget(plik, i, "nazwa"), 13, ""))
                                                    POZmod(plik, i, "status", "5")
                                                    updateFILE(folderapk, 13, "lista", plik)
                                                    Continue For
                                                End Try

                                                Try
                                                    DeleteFilesFromFolder(POZget(plik, i, "path"))
                                                    ZipFile.ExtractToDirectory(POZget(openFILE(folderapk, 13, "folder"), "konfig", "path") & "\" & folder & ".zip", POZget(plik, i, "path"))
                                                Catch ex As Exception
                                                    Invoke(Sub() dodajpowiadomienie("Wystąpił krytyczny błąd podczas przywracania danych pozycji o nazwie " & POZget(plik, i, "nazwa"), 13, ""))
                                                    POZmod(plik, i, "status", "5")
                                                    updateFILE(folderapk, 13, "lista", plik)
                                                    Continue For
                                                End Try

                                                sukcesprzywr = True
                                                GRdel(plikprzywr, o)
                                                updateFILE(folderapk, 13, "przywracanie", plikprzywr)
                                            Catch ex As Exception

                                            End Try

                                        End If
                                    End If
                                End If
                            Next
                        End If

                    Catch ex As Exception

                    End Try

                    If sukcesprzywr Then
                        POZmod(plik, i, "status", "0")
                        Invoke(Sub() dodajpowiadomienie("Proces przywracania danych pozycji o nazwie " & POZget(plik, i, "nazwa") & " zakończony pomyślnie!", 13, ""))
                    Else
                        POZmod(plik, i, "status", "5")
                        Invoke(Sub() dodajpowiadomienie("Wystąpił błąd podczas przywracania danych pozycji o nazwie " & POZget(plik, i, "nazwa"), 13, ""))
                    End If
                Case Else
                    If Not POZget(plik, i, "status") = "" Then Invoke(Sub() bladdanych())
            End Select
            updateFILE(folderapk, 13, "lista", plik)
        Next
    End Sub

    Public Function getkatmessagetime(ByVal nr As Byte) As String
        Dim danezpliku As String = openFILE(folderapk, 15, "kat")
        If GRexist(danezpliku, "kat" & nr) Then
            Return POZget(danezpliku, "kat" & nr, "alarm")
        Else
            Return ""
        End If
    End Function

    Private Function getpozhzAPK13(ByVal war As String) As Integer
        Select Case war
            Case "1"
                Return 60
            Case "2"
                Return 180
            Case "3"
                Return 1440
            Case "4"
                Return 4320
            Case "5"
                Return 7200
            Case "6"
                Return 10080
            Case "7"
                Return 14400
            Case "8"
                Return 21600
            Case Else
                bladdanych()
                Return ""
        End Select
    End Function

    Private Function getpozil(ByVal id As String) As Byte
        Select Case id
            Case "0"
                Return 2
            Case "1"
                Return 3
            Case "2"
                Return 4
            Case "3"
                Return 5
            Case "4"
                Return 6
            Case "5"
                Return 10
            Case "6"
                Return 15
            Case "7"
                Return 20
            Case "8"
                Return 25
            Case "9"
                Return 30
            Case Else
                bladdanych()
                Return ""
        End Select
    End Function

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

    Private Sub DeleteFilesFromFolder(ByVal dir As String)
        If Directory.Exists(dir) Then
            For Each _file As String In Directory.GetFiles(dir)
                File.Delete(_file)
            Next
            For Each _folder As String In Directory.GetDirectories(dir)
                DeleteFilesFromFolder(_folder)
            Next
        End If
    End Sub

    Private Sub START_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nrdnia = Now.Day
        lblwersja.Text = "v" & wersja
    End Sub

    Private Sub NOTIFY_DoubleClick(sender As Object, e As EventArgs) Handles NOTIFY.DoubleClick
        If aplikacje.Visible Then
            aplikacje.WindowState = FormWindowState.Normal
        Else
            aplikacje.Show()
        End If
    End Sub
End Class