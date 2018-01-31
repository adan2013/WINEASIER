Imports System.Threading
Imports IWshRuntimeLibrary
Public Class ustawienia

    Dim zmiana As Boolean = False
    Public konfigquickmenu As String = ""
    Public konfigquickmenu2 As String = ""
    Public konfigklawisze As List(Of String) = New List(Of String)
    Public listapozquick As List(Of String) = New List(Of String)
    Public wybrany As SByte = 0
    Public sukceswpisu As Boolean = False

    Private Sub rozpasek_Scroll(sender As Object, e As ScrollEventArgs) Handles rozpasek.Scroll
        rozlbl.Text = "Rozmiar: " & rozpasek.Value & "px"
    End Sub

    Private Sub zmieniono()
        zmiana = True
        btnzapisz.Visible = True
    End Sub

    Private Sub ustawienia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblversion.Text = "Wersja: " & START.wersja
        'ladowanie ustawien
        If START.wywolywaczPOZ = 1 Then nar1.Checked = True
        If START.wywolywaczPOZ = 2 Then nar2.Checked = True
        If START.wywolywaczPOZ = 3 Then nar3.Checked = True
        If START.wywolywaczPOZ = 4 Then nar4.Checked = True
        If START.wywolywaczPOZ = 0 Then nar0.Checked = True
        rozpasek.Value = START.wywolywaczROZ
        chkboxfullscreen.Checked = START.wyciszfullscreen
        chkboxcloseapk.Checked = START.closeapk
        rozlbl.Text = "Rozmiar: " & rozpasek.Value & "px"
        konfigquickmenu = openFILE(START.folderapk, 1, "quickmenu")
        konfigquickmenu2 = openFILE(START.folderapk, 1, "konfig")
        listaquick.Items.Clear()
        listapozquick.Clear()
        For Each i As String In GRarray(konfigquickmenu)
            listapozquick.Add(i)
            listaquick.Items.Add(POZget(konfigquickmenu, i, "nazwa"))
        Next
        lblilosc.Text = "Ilość elementów w szybkim menu: " & listaquick.Items.Count & "/50"
        For i As Byte = 0 To 5 Step 1
            If GRexist(konfigquickmenu2, "poz" & i) Then
                Dim temppar As String = POZget(konfigquickmenu2, "poz" & i, "par")
                If POZget(konfigquickmenu2, "poz" & i, "cel") = 1 Then
                    If temppar.IndexOf("%") < 0 Then
                        listadol.Items.Add(i + 1 & ". " & START.nazwaaplikacji(temppar))
                    Else
                        listadol.Items.Add(i + 1 & ". " & START.nazwaaplikacji(temppar.Substring(0, temppar.IndexOf("%"))))
                    End If
                Else
                    If temppar.IndexOf("%") < 0 Then
                        If temppar.IndexOf("://") < 0 Then
                            listadol.Items.Add(i + 1 & ". " & My.Computer.FileSystem.GetName(temppar))
                        Else
                            listadol.Items.Add(i + 1 & ". " & temppar)
                        End If
                    Else
                        If temppar.IndexOf("://") < 0 Then
                            listadol.Items.Add(i + 1 & ". " & My.Computer.FileSystem.GetName(temppar.Substring(0, temppar.IndexOf("%"))))
                        Else
                            listadol.Items.Add(i + 1 & ". " & temppar.Substring(0, temppar.IndexOf("%")))
                        End If
                    End If
                End If
            Else
                listadol.Items.Add(i + 1 & ". PUSTY")
            End If
        Next
        listaklawisze.Items.Clear()
        konfigklawisze = START.skrotyklaw
        If konfigklawisze.Count > 0 Then
            For i As Byte = 0 To konfigklawisze.Count - 1 Step 1
                ' ODCZYT ZMIENNYCH LOGICZNYCH
                Dim pozycja As String = konfigklawisze(i)
                If Not pozycja = "" Then
                    Dim kur As Byte = 1
                    Dim klawctrl As Boolean = False
                    Dim klawalt As Boolean = False
                    Dim klawshift As Boolean = False
                    Dim klawisz As String = ""
                    For o As Byte = 0 To pozycja.Length - 1 Step 1
                        Dim znak As String = pozycja.Substring(o, 1)
                        If znak = "T" Or znak = "F" Then
                            Select Case kur
                                Case 1
                                    If znak = "T" Then klawctrl = True
                                Case 2
                                    If znak = "T" Then klawalt = True
                                Case 3
                                    If znak = "T" Then klawshift = True
                            End Select
                            kur += 1
                        End If
                        If kur = 4 Then Exit For
                    Next
                    klawisz = pozycja.Substring(pozycja.IndexOf("@") + 1, pozycja.LastIndexOf("@") - pozycja.IndexOf("@") - 1)
                    ' ODCZYT ZMIENNYCH LOGICZNYCH
                    Dim txtpozycji As String = ""
                    txtpozycji = IIf(klawctrl, "Ctrl + ", "")
                    txtpozycji &= IIf(klawalt, "Alt + ", "")
                    txtpozycji &= IIf(klawshift, "Shift + ", "")
                    txtpozycji &= klawisz
                    listaklawisze.Items.Add(txtpozycji)
                End If
            Next
        End If
        lblilkl.Text = "Ilość skrótów: " & listaklawisze.Items.Count & "/30"

        'uchwyty
        AddHandler nar1.CheckedChanged, AddressOf zmieniono
        AddHandler nar2.CheckedChanged, AddressOf zmieniono
        AddHandler nar3.CheckedChanged, AddressOf zmieniono
        AddHandler nar4.CheckedChanged, AddressOf zmieniono
        AddHandler nar0.CheckedChanged, AddressOf zmieniono
        AddHandler chkboxfullscreen.CheckedChanged, AddressOf zmieniono
        AddHandler chkboxcloseapk.CheckedChanged, AddressOf zmieniono
        AddHandler rozpasek.Scroll, AddressOf zmieniono
        AddHandler btndodaj.Click, AddressOf zmieniono
        AddHandler btnusun.Click, AddressOf zmieniono
        AddHandler btnup.Click, AddressOf zmieniono
        AddHandler btndn.Click, AddressOf zmieniono
        AddHandler btnusun2.Click, AddressOf zmieniono
        AddHandler btnklawiszedodaj.Click, AddressOf zmieniono
        AddHandler btnklawiszeusun.Click, AddressOf zmieniono
        aktautostart()
        MetroTabControl1.SelectTab(0)
    End Sub

    Private Sub btndodaj_Click(sender As Object, e As EventArgs) Handles btndodaj.Click
        If listaquick.Items.Count >= 50 Then
            MsgBox("Osiągnięto maksymalną ilość pozycji w menu!", MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End If
        wybrany = -1
        sukceswpisu = False
        modyfikacjawpisu.ShowDialog()
        If sukceswpisu Then
            Dim nazwawpisu As String = ""
            For Each i As String In GRarray(konfigquickmenu)
                nazwawpisu = i
            Next
            listaquick.Items.Add(POZget(konfigquickmenu, nazwawpisu, "nazwa"))
            listaquick.SelectedIndex = listaquick.Items.Count - 1
            listapozquick.Add(nazwawpisu)
        End If
        modyfikacjawpisu.Close()
        lblilosc.Text = "Ilość elementów w szybkim menu: " & listaquick.Items.Count & "/50"
    End Sub

    Private Sub btnusun_Click(sender As Object, e As EventArgs) Handles btnusun.Click
        If listaquick.SelectedIndex >= 0 Then
            If listaquick.Items.Count = 1 Then
                GRdel(konfigquickmenu, listapozquick.Item(listaquick.SelectedIndex))
                listapozquick.RemoveAt(listaquick.SelectedIndex)
                listaquick.Items.RemoveAt(listaquick.SelectedIndex)
            Else
                If listaquick.SelectedIndex = 0 Then
                    GRdel(konfigquickmenu, listapozquick.Item(listaquick.SelectedIndex))
                    listapozquick.RemoveAt(listaquick.SelectedIndex)
                    listaquick.Items.RemoveAt(listaquick.SelectedIndex)
                    listaquick.SelectedIndex = 0
                Else
                    Dim lp As Byte = listaquick.SelectedIndex - 1
                    GRdel(konfigquickmenu, listapozquick.Item(lp + 1))
                    listapozquick.RemoveAt(lp + 1)
                    listaquick.Items.RemoveAt(lp + 1)
                    listaquick.SelectedIndex = lp
                End If
            End If
        End If
        lblilosc.Text = "Ilość elementów w szybkim menu: " & listaquick.Items.Count & "/50"
    End Sub

    Private Sub btnup_Click(sender As Object, e As EventArgs) Handles btnup.Click
        If listaquick.SelectedIndex >= 0 Then
            If listaquick.SelectedIndex > 0 Then
                Dim lp As Byte = listaquick.SelectedIndex
                listaquick.SelectedIndex -= 1
                listaquick.Items.Insert(listaquick.SelectedIndex, listaquick.Items(listaquick.SelectedIndex + 1))
                listaquick.Items.RemoveAt(listaquick.SelectedIndex + 1)
                listaquick.SelectedIndex -= 1

                lp -= 1
                listapozquick.Insert(lp, listapozquick.Item(lp + 1))
                listapozquick.RemoveAt(lp + 2)
            End If
        End If
    End Sub

    Private Sub btndn_Click(sender As Object, e As EventArgs) Handles btndn.Click
        If listaquick.SelectedIndex >= 0 Then
            If listaquick.SelectedIndex + 1 < listaquick.Items.Count Then
                Dim lp As Byte = listaquick.SelectedIndex
                listaquick.SelectedIndex += 1
                listaquick.Items.Insert(listaquick.SelectedIndex + 1, listaquick.Items(listaquick.SelectedIndex - 1))
                listaquick.Items.RemoveAt(listaquick.SelectedIndex - 1)
                listaquick.SelectedIndex += 1

                lp += 1
                listapozquick.Insert(lp + 1, listapozquick.Item(lp - 1))
                listapozquick.RemoveAt(lp - 1)
            End If
        End If
    End Sub

    Private Sub listaquick_DoubleClick(sender As Object, e As EventArgs) Handles listaquick.DoubleClick
        wybrany = listaquick.SelectedIndex
        sukceswpisu = False
        modyfikacjawpisu.ShowDialog()
        If sukceswpisu Then
            listaquick.Items.RemoveAt(wybrany)
            listaquick.Items.Insert(wybrany, POZget(konfigquickmenu, listapozquick(wybrany), "nazwa"))
            listaquick.SelectedIndex = wybrany
            zmiana = True
            btnzapisz.Visible = True
        End If
        modyfikacjawpisu.Close()
    End Sub

    Private Sub btnusun2_Click(sender As Object, e As EventArgs) Handles btnusun2.Click
        If listadol.SelectedIndex >= 0 Then
            If listadol.Items(listadol.SelectedIndex).indexOf(listadol.SelectedIndex - 1 & ". PUSTY") > 0 Then Exit Sub
            Dim nr As Byte = listadol.SelectedIndex
            GRdel(konfigquickmenu2, "poz" & nr)
            listadol.Items.RemoveAt(nr)
            listadol.Items.Insert(nr, nr + 1 & ". PUSTY")
        End If
    End Sub

    Private Sub listadol_DoubleClick(sender As Object, e As EventArgs) Handles listadol.DoubleClick
        sukceswpisu = False
        modyfikacjawpisu2.ShowDialog()
        If sukceswpisu Then
            Dim nr As Byte = listadol.SelectedIndex
            listadol.Items.RemoveAt(nr)
            Dim temppar As String = POZget(konfigquickmenu2, "poz" & nr, "par")
            If POZget(konfigquickmenu2, "poz" & nr, "cel") = 1 Then
                If temppar.IndexOf("%") < 0 Then
                    listadol.Items.Insert(nr, nr + 1 & ". " & START.nazwaaplikacji(temppar))
                Else
                    listadol.Items.Insert(nr, nr + 1 & ". " & START.nazwaaplikacji(temppar.Substring(0, temppar.IndexOf("%"))))
                End If
            Else
                If temppar.IndexOf("%") < 0 Then
                    If temppar.IndexOf("://") < 0 Then
                        listadol.Items.Insert(nr, nr + 1 & ". " & My.Computer.FileSystem.GetName(temppar))
                    Else
                        listadol.Items.Insert(nr, nr + 1 & ". " & temppar)
                    End If
                Else
                    If temppar.IndexOf("://") < 0 Then
                        listadol.Items.Insert(nr, nr + 1 & ". " & My.Computer.FileSystem.GetName(temppar.Substring(0, temppar.IndexOf("%"))))
                    Else
                        listadol.Items.Insert(nr, nr + 1 & ". " & temppar.Substring(0, temppar.IndexOf("%")))
                    End If
                End If
            End If
            zmiana = True
            btnzapisz.Visible = True
        End If
        modyfikacjawpisu2.Close()
    End Sub

    Private Sub btnklawiszedodaj_Click(sender As Object, e As EventArgs) Handles btnklawiszedodaj.Click
        If listaklawisze.Items.Count >= 30 Then
            MsgBox("Osiągnięto maksymalną ilość skrótów!", MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End If
        wybrany = -1
        sukceswpisu = False
        modyfikacjawpisu3.ShowDialog()
        If sukceswpisu Then

            ' ODCZYT ZMIENNYCH LOGICZNYCH
            Dim pozycja As String = konfigklawisze(konfigklawisze.Count - 1)
            Dim kur As Byte = 1
            Dim klawctrl As Boolean = False
            Dim klawalt As Boolean = False
            Dim klawshift As Boolean = False
            Dim klawisz As String = ""
            For o As Byte = 0 To pozycja.Length - 1 Step 1
                Dim znak As String = pozycja.Substring(o, 1)
                If znak = "T" Or znak = "F" Then
                    Select Case kur
                        Case 1
                            If znak = "T" Then klawctrl = True
                        Case 2
                            If znak = "T" Then klawalt = True
                        Case 3
                            If znak = "T" Then klawshift = True
                    End Select
                    kur += 1
                End If
                If kur = 4 Then Exit For
            Next
            klawisz = pozycja.Substring(pozycja.IndexOf("@") + 1, pozycja.LastIndexOf("@") - pozycja.IndexOf("@") - 1)
            ' ODCZYT ZMIENNYCH LOGICZNYCH
            Dim txtpozycji As String = ""
            txtpozycji = IIf(klawctrl, "Ctrl + ", "")
            txtpozycji &= IIf(klawalt, "Alt + ", "")
            txtpozycji &= IIf(klawshift, "Shift + ", "")
            txtpozycji &= klawisz
            listaklawisze.Items.Add(txtpozycji)
            lblilkl.Text = "Ilość skrótów: " & listaklawisze.Items.Count & "/30"

        End If
        modyfikacjawpisu3.Close()
    End Sub

    Private Sub btnklawiszeusun_Click(sender As Object, e As EventArgs) Handles btnklawiszeusun.Click
        If listaklawisze.SelectedIndex >= 0 Then
            Dim lp As Byte = listaklawisze.SelectedIndex
            konfigklawisze.RemoveAt(lp)
            listaklawisze.Items.RemoveAt(lp)
            If lp = 0 Then
                If listaklawisze.Items.Count > 0 Then listaklawisze.SelectedIndex = 0
            Else
                listaklawisze.SelectedIndex = lp - 1
            End If
            lblilkl.Text = "Ilość skrótów: " & listaklawisze.Items.Count & "/30"
        End If
    End Sub

    Private Sub listaklawisze_DoubleClick(sender As Object, e As EventArgs) Handles listaklawisze.DoubleClick
        wybrany = listaklawisze.SelectedIndex
        sukceswpisu = False
        modyfikacjawpisu3.ShowDialog()
        If sukceswpisu Then

            ' ODCZYT ZMIENNYCH LOGICZNYCH
            Dim pozycja As String = konfigklawisze(wybrany)
            Dim kur As Byte = 1
            Dim klawctrl As Boolean = False
            Dim klawalt As Boolean = False
            Dim klawshift As Boolean = False
            Dim klawisz As String = ""
            For o As Byte = 0 To pozycja.Length - 1 Step 1
                Dim znak As String = pozycja.Substring(o, 1)
                If znak = "T" Or znak = "F" Then
                    Select Case kur
                        Case 1
                            If znak = "T" Then klawctrl = True
                        Case 2
                            If znak = "T" Then klawalt = True
                        Case 3
                            If znak = "T" Then klawshift = True
                    End Select
                    kur += 1
                End If
                If kur = 4 Then Exit For
            Next
            klawisz = pozycja.Substring(pozycja.IndexOf("@") + 1, pozycja.LastIndexOf("@") - pozycja.IndexOf("@") - 1)
            ' ODCZYT ZMIENNYCH LOGICZNYCH
            Dim txtpozycji As String = ""
            txtpozycji = IIf(klawctrl, "Ctrl + ", "")
            txtpozycji &= IIf(klawalt, "Alt + ", "")
            txtpozycji &= IIf(klawshift, "Shift + ", "")
            txtpozycji &= klawisz
            listaklawisze.Items.RemoveAt(wybrany)
            listaklawisze.Items.Insert(wybrany, txtpozycji)


            zmiana = True
            btnzapisz.Visible = True
        End If
        modyfikacjawpisu3.Close()
    End Sub


    Private Sub btnzapisz_Click(sender As Object, e As EventArgs) Handles btnzapisz.Click
        Dim doplikukonfig As String = ""
        Dim doplikukeyb As String = ""
        Dim doplikuquickmenu As String = ""
        If nar1.Checked Then POZmod(doplikukonfig, "wyw", "poz", "1")
        If nar2.Checked Then POZmod(doplikukonfig, "wyw", "poz", "2")
        If nar3.Checked Then POZmod(doplikukonfig, "wyw", "poz", "3")
        If nar4.Checked Then POZmod(doplikukonfig, "wyw", "poz", "4")
        If nar0.Checked Then POZmod(doplikukonfig, "wyw", "poz", "0")
        POZmod(doplikukonfig, "wyw", "roz", rozpasek.Value.ToString())
        If chkboxfullscreen.Checked Then
            POZmod(doplikukonfig, "wyw", "fullscreen", "1")
        Else
            POZmod(doplikukonfig, "wyw", "fullscreen", "0")
        End If
        START.wyciszfullscreen = chkboxfullscreen.Checked
        If chkboxcloseapk.Checked Then
            POZmod(doplikukonfig, "wyw", "closeapk", "1")
        Else
            POZmod(doplikukonfig, "wyw", "closeapk", "0")
        End If
        START.closeapk = chkboxcloseapk.Checked
        For i As Byte = 0 To 5 Step 1
            If GRexist(konfigquickmenu2, "poz" & i) Then
                POZmod(doplikukonfig, "poz" & i, "ikona", POZget(konfigquickmenu2, "poz" & i, "ikona"))
                POZmod(doplikukonfig, "poz" & i, "cel", POZget(konfigquickmenu2, "poz" & i, "cel"))
                POZmod(doplikukonfig, "poz" & i, "par", POZget(konfigquickmenu2, "poz" & i, "par"))
            End If
        Next
        If konfigklawisze.Count > 0 Then
            For i As Byte = 0 To konfigklawisze.Count - 1 Step 1
                Dim pozycja As String = konfigklawisze(i)
                POZmod(doplikukeyb, "poz" & i, "skrot", pozycja.Substring(0, pozycja.IndexOf("%")))
                POZmod(doplikukeyb, "poz" & i, "cel", pozycja.Substring(pozycja.IndexOf("%") + 1, 1))
                If Not pozycja.Substring(pozycja.IndexOf("%") + 2) = "" Then POZmod(doplikukeyb, "poz" & i, "par", pozycja.Substring(pozycja.IndexOf("%") + 2))
            Next
        End If
        Dim nrpoz As Byte = 0
        If listapozquick.Count > 0 Then
            For i As Byte = 0 To listapozquick.Count - 1 Step 1
                Dim grupa As String = listapozquick(i)
                POZmod(doplikuquickmenu, "poz" & nrpoz, "nazwa", POZget(konfigquickmenu, grupa, "nazwa"))
                POZmod(doplikuquickmenu, "poz" & nrpoz, "ikona", POZget(konfigquickmenu, grupa, "ikona"))
                POZmod(doplikuquickmenu, "poz" & nrpoz, "cel", POZget(konfigquickmenu, grupa, "cel"))
                POZmod(doplikuquickmenu, "poz" & nrpoz, "par", POZget(konfigquickmenu, grupa, "par"))
                nrpoz += 1
            Next
        End If
        Dim bladzapisu As Boolean = False
        If Not updateFILE(START.folderapk, 1, "konfig", doplikukonfig) Then bladzapisu = True
        If Not updateFILE(START.folderapk, 1, "keyb", doplikukeyb) Then bladzapisu = True
        If Not updateFILE(START.folderapk, 1, "quickmenu", doplikuquickmenu) Then bladzapisu = True
        If bladzapisu Then
            MsgBox("Podczas aktualizacji ustawień aplikacji wystąpił błąd zapisu danych!", MsgBoxStyle.Exclamation, "WINEASIER")
        Else
            menuform.Close()
            START.aktustawienia()
            zmiana = False
            Close()
        End If
    End Sub

    Private Sub ustawienia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If zmiana Then
            If Not MsgBox("Wykryto zmiany w ustawieniach, które nie zostały zapisane" & vbNewLine & "Wyjść z ustawień bez zapisu?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then e.Cancel = True
        End If
    End Sub

    Private Sub aktautostart()
        If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\WINEASIER.lnk") Then
            autostartinfo.Text = "Autostart aktywny"
            btnautostart.Text = "Usuń z autostartu"
        Else
            autostartinfo.Text = "Autostart jest wyłączony"
            btnautostart.Text = "Dodaj do autostartu"
        End If
    End Sub

    Private Sub btnautostart_Click(sender As Object, e As EventArgs) Handles btnautostart.Click
        If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\WINEASIER.lnk") Then
            'usuń autostart
            Try
                IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\WINEASIER.lnk")
            Catch ex As Exception
                MsgBox("Błąd usuwania pliku autostartu! Spróbuj usunąć go ręcznie:" & vbNewLine & vbNewLine & Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\WINEASIER.lnk", MsgBoxStyle.Critical, "WINEASIER")
            End Try
        Else
            'dodaj autostart
            Try
                Dim WshShell As New WshShell
                Dim shortCut As IWshShortcut = CType(WshShell.CreateShortcut(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\WINEASIER.lnk"), IWshShortcut)
                With shortCut
                    .TargetPath = Application.ExecutablePath
                    .WorkingDirectory = Application.StartupPath
                    .IconLocation = Application.ExecutablePath & ", 0"
                    .Save()
                End With
            Catch ex As System.Exception
                MsgBox("Błąd dodawania pliku autostartu!", MsgBoxStyle.Critical, "WINEASIER")
            End Try
        End If
        Thread.Sleep(800)
        aktautostart()
    End Sub

    Private Sub listaklawisze_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaklawisze.SelectedIndexChanged
        If listaklawisze.SelectedIndex < 0 Then
            keybinfolbl.Visible = False
        Else
            keybinfolbl.Text = "Skrót: " & listaklawisze.Text & vbNewLine
            Dim danepozycji As String = konfigklawisze(listaklawisze.SelectedIndex)
            If danepozycji.Substring(danepozycji.IndexOf("%") + 1, 1) = 1 Then keybinfolbl.Text &= "Akcja: Pokaż/ukryj menu boczne"
            If danepozycji.Substring(danepozycji.IndexOf("%") + 1, 1) = 2 Then keybinfolbl.Text &= "Akcja: Aplikacja WINEASIER"
            If danepozycji.Substring(danepozycji.IndexOf("%") + 1, 1) = 3 Then keybinfolbl.Text &= "Akcja: Program lub strona WWW"
            Dim temppar As String = danepozycji.Substring(danepozycji.IndexOf("%") + 2)
            If danepozycji.Substring(danepozycji.IndexOf("%") + 1, 1) = 2 Then
                keybinfolbl.Text &= vbNewLine & "Aplikacja: " & START.nazwaaplikacji(temppar.Substring(0, temppar.IndexOf("%")))
            Else
                If danepozycji.Substring(danepozycji.IndexOf("%") + 1, 1) = 3 Then
                    If temppar.IndexOf("://") < 0 Then
                        If temppar.IndexOf("%") < 0 Then
                            Try
                                keybinfolbl.Text &= vbNewLine & "Program: " & My.Computer.FileSystem.GetName(temppar)
                            Catch ex As Exception
                                keybinfolbl.Text &= vbNewLine & "Program: (nieznaleziono pliku)"
                            End Try
                        Else
                            Try
                                keybinfolbl.Text &= vbNewLine & "Program: " & My.Computer.FileSystem.GetName(temppar.Substring(0, temppar.IndexOf("%")))
                            Catch ex As Exception
                                keybinfolbl.Text &= vbNewLine & "Program: (nieznaleziono pliku)"
                            End Try
                            keybinfolbl.Text &= vbNewLine & "Parametr: " & temppar.Substring(temppar.IndexOf("%") + 1)
                        End If
                    Else
                        keybinfolbl.Text &= vbNewLine & "Adres: " & temppar
                    End If
                End If
            End If



            keybinfolbl.Visible = True
        End If
    End Sub
End Class