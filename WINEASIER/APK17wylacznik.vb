Public Class APK17wylacznik

    Dim zmiany As Boolean = True

    Private Sub APK17wylacznik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico17.GetHicon())
        Dim par As String = START.pobierzparametr(17)
        Dim zamknij As Boolean = True
        If existFILE(START.folderapk, 17, "konfig", False) Then
            aktualizuj()
        Else
            existFILE(START.folderapk, 17, "konfig", True)
            Dim dopliku As String = ""
            POZmod(dopliku, "root", "ust", "0")
            POZmod(dopliku, "root", "time", "5")
            POZmod(dopliku, "root", "typ", "0")
            updateFILE(START.folderapk, 17, "konfig", dopliku)
        End If
        Select Case par
            Case "poweroff"
                START.runhideprogram("shutdown.exe", "/s /t 0")
                End
            Case "hybridpoweroff"
                START.runhideprogram("shutdown.exe", "/s /hybrid /t 0")
                End
            Case "reset"
                START.runhideprogram("shutdown.exe", "/r")
                End
            Case "logout"
                START.runhideprogram("shutdown.exe", "/l")
                End
            Case "hib"
                START.runhideprogram("shutdown.exe", "/h")
            Case "wst"
                If START.checknircmd() Then START.runhideprogram(START.foldernircmd, "standby")
            Case "set1"
                START.dodajpowiadomienie("Usługa została wyłączona", 17, "")
                zmien("ust", "0")
                START.aktmouse = 0
            Case "set2"
                START.dodajpowiadomienie("Usługa została aktywowana", 17, "")
                zmien("ust", "1")
                START.aktmouse = ilmin.Value
                START.wyswpow = 0
            Case "set3"
                START.dodajpowiadomienie("Usługa i powiadomienie zostały aktywowane", 17, "")
                zmien("ust", "2")
                START.aktmouse = ilmin.Value
                START.wyswpow = 1
            Case "off5"
                START.dodajpowiadomienie("Komputer zostanie wyłączony za 5 minut", 17, "")
                START.czaswyl = Now
                START.aktczas = 5
            Case "off10"
                START.dodajpowiadomienie("Komputer zostanie wyłączony za 10 minut", 17, "")
                START.czaswyl = Now
                START.aktczas = 10
            Case "off20"
                START.dodajpowiadomienie("Komputer zostanie wyłączony za 20 minut", 17, "")
                START.czaswyl = Now
                START.aktczas = 20
            Case "off30"
                START.dodajpowiadomienie("Komputer zostanie wyłączony za 30 minut", 17, "")
                START.czaswyl = Now
                START.aktczas = 30
            Case "off0"
                START.dodajpowiadomienie("Dezaktywowano czasowe wyłączenie komputera", 17, "")
                START.aktczas = 0
            Case Else
                zamknij = False
        End Select
        If zamknij Then
            zam.Enabled = True
        Else
            Opacity = 100
        End If
    End Sub

    Public Sub aktualizuj()
        zmiany = True
        Dim dane As String = openFILE(START.folderapk, 17, "konfig")
        Select Case POZget(dane, "root", "ust")
            Case "0"
                ust1.Checked = True
            Case "1"
                ust2.Checked = True
            Case "2"
                ust3.Checked = True
            Case Else
                START.bladdanych()
        End Select
        If IsNumeric(POZget(dane, "root", "time")) AndAlso POZget(dane, "root", "time") >= 5 AndAlso POZget(dane, "root", "time") <= 60 Then
            ilmin.Value = POZget(dane, "root", "time")
        Else
            START.bladdanych()
        End If
        Select Case POZget(dane, "root", "typ")
            Case "0"
                typ1.Checked = True
            Case "1"
                typ2.Checked = True
            Case Else
                START.bladdanych()
        End Select
        zmiany = False
    End Sub

    Private Sub zapiszzmiany() Handles ust1.CheckedChanged, ust2.CheckedChanged, ust3.CheckedChanged, ilmin.ValueChanged, typ1.CheckedChanged, typ2.CheckedChanged
        If zmiany Then Exit Sub
        Dim dopliku As String = ""
        If ust1.Checked Then POZmod(dopliku, "root", "ust", "0")
        If ust2.Checked Then POZmod(dopliku, "root", "ust", "1")
        If ust3.Checked Then POZmod(dopliku, "root", "ust", "2")
        POZmod(dopliku, "root", "time", ilmin.Value.ToString())
        If typ1.Checked Then POZmod(dopliku, "root", "typ", "0")
        If typ2.Checked Then POZmod(dopliku, "root", "typ", "1")
        updateFILE(START.folderapk, 17, "konfig", dopliku)
        If ust1.Checked Then
            START.aktmouse = 0
        End If
        If ust2.Checked Then
            START.aktmouse = ilmin.Value
            START.wyswpow = 0
        End If
        If ust3.Checked Then
            START.aktmouse = ilmin.Value
            START.wyswpow = 1
        End If
    End Sub

    Private Sub zmien(ByVal par As String, ByVal nw As String)
        Dim dopliku As String = openFILE(START.folderapk, 17, "konfig")
        POZmod(dopliku, "root", par, nw)
        updateFILE(START.folderapk, 17, "konfig", dopliku)
    End Sub

    Private Sub zam_Tick(sender As Object, e As EventArgs) Handles zam.Tick
        Close()
    End Sub
End Class