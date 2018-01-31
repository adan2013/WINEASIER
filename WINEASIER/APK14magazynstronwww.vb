Imports System.IO
Public Class APK14magazynstronwww

    Public aktkat As String = ""
    Public domod As String = ""
    Dim panelwew As Panel = New Panel()

    Private Sub APK14magazynstronwww_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        panelgl.Size = New Size(Size.Width - 46, Size.Height - 81)
        panelzlista.Size = New Size(panelgl.Width - 6, panelgl.Height - 49)
        txtszukaj.Location = New Point(panelzlista.Size.Width - 148, txtszukaj.Location.Y)
        btndodaj.Location = New Point(panelzlista.Size.Width - 209, btndodaj.Location.Y)
        lbldn.Location = New Point(panelzlista.Size.Width - 235, lbldn.Location.Y)
        lblup.Location = New Point(panelzlista.Size.Width - 261, lblup.Location.Y)
    End Sub

    Private Sub APK14magazynstronwww_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico14.GetHicon())
        START.pobierzparametr(14)
        existFILE(START.folderapk, 14, "lista", True)
        panelwew.Location = New Point(0, 0)
        ladujliste("")
    End Sub

    Private Sub ladujliste(ByVal filtr As String) 'rozmiar 150x 110y
        panelzlista.Controls.Clear()
        panelwew.Controls.Clear()
        panelwew.Size = New Size(panelzlista.Size.Width, 110)
        Dim dane As String = openFILE(START.folderapk, 14, "lista")
        Dim aktX, aktY As Integer
        Dim arraykat(0) As String
        Dim arraywww(0) As String
        Dim wyswkat As Boolean = True

        For Each i As String In GRarray(dane)
            If txtszukaj.Text = "" Then
                If Not POZget(dane, i, "path") = aktkat Then Continue For
            End If
            If POZget(dane, i, "kat") = "1" Then
                If filtr = "" Then
                    arraykat(arraykat.Length - 1) = POZget(dane, i, "nazwa") & "+" & i
                    ReDim Preserve arraykat(arraykat.Length)
                End If
            Else
                If POZget(dane, i, "nazwa").IndexOf(filtr) >= 0 Then
                    arraywww(arraywww.Length - 1) = POZget(dane, i, "nazwa") & "+" & i
                    ReDim Preserve arraywww(arraywww.Length)
                End If
            End If
        Next
        Array.Sort(arraykat)
        Array.Sort(arraywww)
        Do
            For Each i As String In IIf(wyswkat, arraykat, arraywww)

                If i = "" Then Continue For
                i = i.Substring(i.LastIndexOf("+") + 1)
                Dim obr As PictureBox = New PictureBox()
                Dim txt As Label = New Label()
                With obr
                    .Name = If(wyswkat, "1", "0") & i
                    If wyswkat Then
                        .Image = My.Resources.webdir
                    Else
                        If IO.File.Exists(START.folderapk & "\apk14\favicon-" & i & ".png") Then
                            '.Image = Image.FromFile(START.folderapk & "\apk14\favicon-" & i & ".png")
                            .Image = SafeImageFromFile(START.folderapk & "\apk14\favicon-" & i & ".png")
                        Else
                            .Image = My.Resources.emptyiconweb
                        End If
                    End If
                    .Location = New Point(aktX, aktY)
                    .Size = New Size(110, 80)
                    .Cursor = Cursors.Hand
                    .SizeMode = PictureBoxSizeMode.CenterImage
                    If wyswkat Then .ContextMenuStrip = menukat Else .ContextMenuStrip = menupoz
                End With
                With txt
                    .Name = If(wyswkat, "1", "0") & i
                    .Text = POZget(dane, i, "nazwa")
                    .Location = New Point(aktX, aktY + 80)
                    .Size = New Size(110, 30)
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Cursor = Cursors.Hand
                    .Font = New Font("Segoe UI", 10)
                    If wyswkat Then .ContextMenuStrip = menukat Else .ContextMenuStrip = menupoz
                End With
                AddHandler obr.Click, AddressOf klik
                AddHandler txt.Click, AddressOf klik
                panelwew.Controls.Add(obr)
                panelwew.Controls.Add(txt)
                aktX += 110
                If aktX + 110 > panelwew.Size.Width Then
                    aktX = 0
                    aktY += 110
                    panelwew.Size = New Size(panelwew.Size.Width, aktY + 110)
                End If

            Next
            If wyswkat Then wyswkat = False Else Exit Do
        Loop
        If aktX = 0 Then panelwew.Size = New Size(panelwew.Size.Width, panelwew.Size.Height - 110)
        panelzlista.Controls.Add(panelwew)
        lblup.Visible = False
        lbldn.Visible = False
        If panelwew.Location.Y < 0 Then lblup.Visible = True
        If panelwew.Location.Y + panelwew.Size.Height > panelzlista.Size.Height Then lbldn.Visible = True
    End Sub

    Private Sub klik(sender As Object, e As EventArgs)
        If sender.Name.Substring(0, 1) = "1" Then
            If txtszukaj.Text = "" Then
                Dim dane As String = openFILE(START.folderapk, 14, "lista")
                If aktkat = "" Then
                    aktkat = POZget(dane, sender.Name.Substring(1), "nazwa")
                Else
                    aktkat &= "/" & POZget(dane, sender.Name.Substring(1), "nazwa")
                End If
                lblpath.Text = aktkat & "/"
                Dim skrocono As Boolean = False
                Do While lblpath.Size.Width > panelwew.Size.Width - 350
                    lblpath.Text = lblpath.Text.Substring(2)
                    skrocono = True
                Loop
                If skrocono Then lblpath.Text = "..." & lblpath.Text
                btnback.Enabled = True
                ladujliste("")
            Else
                MsgBox("Nie dozwolone w trybie wyszukiwania!", MsgBoxStyle.Exclamation, "WINEASIER")
            End If
        Else
            Dim dane As String = openFILE(START.folderapk, 14, "lista")
            Try
                Process.Start(POZget(dane, sender.Name.Substring(1), "adres"))
            Catch ex As Exception
                MsgBox("Wystąpił błąd podczas otwierania strony!" & vbNewLine & "Sprawdź adres WWW wpisany w pozycję", MsgBoxStyle.Exclamation, "WINEASIER")
            End Try
        End If
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        If aktkat.IndexOf("/") < 0 Then
            aktkat = ""
            lblpath.Text = "Katalog główny"
            btnback.Enabled = False
        Else
            aktkat = aktkat.Substring(0, aktkat.LastIndexOf("/"))
            lblpath.Text = aktkat & "/"
            Dim skrocono As Boolean = False
            Do While lblpath.Size.Width > panelwew.Size.Width - 350
                lblpath.Text = lblpath.Text.Substring(2)
                skrocono = True
            Loop
            If skrocono Then lblpath.Text = "..." & lblpath.Text
            btnback.Enabled = True
        End If
        ladujliste("")
    End Sub

    Private Sub APK14magazynstronwww_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        ladujliste(txtszukaj.Text)
    End Sub

    Private Sub APK14magazynstronwww_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            If panelwew.Location.Y < 0 Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y + 30)
            End If
        Else
            If panelzlista.Size.Height < panelwew.Location.Y + panelwew.Size.Height Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y - 30)
            End If
        End If
        lblup.Visible = False
        lbldn.Visible = False
        If panelwew.Location.Y < 0 Then lblup.Visible = True
        If panelwew.Location.Y + panelwew.Size.Height > panelzlista.Size.Height Then lbldn.Visible = True
    End Sub

    Private Sub lbldn_Click(sender As Object, e As EventArgs) Handles lbldn.Click
        If panelzlista.Size.Height < panelwew.Location.Y + panelwew.Size.Height Then
            panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y - 30)
            lblup.Visible = False
            lbldn.Visible = False
            If panelwew.Location.Y < 0 Then lblup.Visible = True
            If panelwew.Location.Y + panelwew.Size.Height > panelzlista.Size.Height Then lbldn.Visible = True
        End If
    End Sub

    Private Sub lblup_Click(sender As Object, e As EventArgs) Handles lblup.Click
        If panelwew.Location.Y < 0 Then
            panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y + 30)
            lblup.Visible = False
            lbldn.Visible = False
            If panelwew.Location.Y < 0 Then lblup.Visible = True
            If panelwew.Location.Y + panelwew.Size.Height > panelzlista.Size.Height Then lbldn.Visible = True
        End If
    End Sub

    Private Sub btndodaj_Click(sender As Object, e As EventArgs) Handles btndodaj.Click
        If Not txtszukaj.Text = "" Then Exit Sub
        APK14dodaj.ShowDialog()
        If APK14dodaj.DialogResult = DialogResult.OK Then ladujliste("")
        APK14dodaj.Close()
    End Sub

    Private Sub txtszukaj_TextChanged(sender As Object, e As EventArgs) Handles txtszukaj.TextChanged
        If txtszukaj.Text = "" Then
            btndodaj.Enabled = True
            ladujliste("")
            If aktkat = "" Then lblpath.Text = "Katalog główny" Else lblpath.Text = aktkat & "/"
            Dim skrocono As Boolean = False
            Do While lblpath.Size.Width > panelwew.Size.Width - 350
                lblpath.Text = lblpath.Text.Substring(2)
                skrocono = True
            Loop
            If skrocono Then lblpath.Text = "..." & lblpath.Text
            If aktkat = "" Then btnback.Enabled = False Else btnback.Enabled = True
        Else
            btndodaj.Enabled = False
            btnback.Enabled = False
            lblpath.Text = "Wyniki wyszukiwania"
            ladujliste(txtszukaj.Text)
        End If
    End Sub

    Private Sub menupozusunkatalog_Click(sender As Object, e As EventArgs) Handles menupozusunkatalog.Click
        If Not MsgBox("Usunąć katalog? Oznacza to usunięcie wszystkich stron i katalogów znajdujących się w nim!", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then Exit Sub
        Dim cel As String = sender.GetCurrentParent().SourceControl.Name.Substring(1)
        Dim dane As String = openFILE(START.folderapk, 14, "lista")

        Dim folder As String = POZget(dane, cel, "path")
        If folder = "" Then folder = POZget(dane, cel, "nazwa") Else folder &= "/" & POZget(dane, cel, "nazwa")
        GRdel(dane, cel)
        For Each i As String In GRarray(dane)
            If POZget(dane, i, "path") = folder OrElse POZget(dane, i, "path") Like "*" & folder & "[/]*" Then GRdel(dane, i)
        Next
        updateFILE(START.folderapk, 14, "lista", dane)
        ladujliste("")
    End Sub

    Private Sub menupozzmiennazwe_Click(sender As Object, e As EventArgs) Handles menupozzmiennazwe.Click
        Do
            Dim nowanazwa As String = InputBox("Podaj nową nazwę katalogu:", "WINEASIER")
            If nowanazwa = "" Then Exit Do
            Dim cel As String = sender.GetCurrentParent().SourceControl.Name.Substring(1)
            Dim dane As String = openFILE(START.folderapk, 14, "lista")

            If nowanazwa.Length > 20 Then
                MsgBox("Nazwa jest za długa! (maksymalnie 20 znaków)", MsgBoxStyle.Exclamation, "WINEASIER")
                Continue Do
            End If
            For i As Byte = 0 To nowanazwa.Length - 1 Step 1
                If " 0123456789qwertyuiopasdfghjklzxcvbnmąćęłńóśźż".IndexOf(nowanazwa.Substring(i, 1).ToLower()) < 0 Then
                    MsgBox("Nazwa może zawierać tylko litery i cyfry!", MsgBoxStyle.Exclamation, "WINEASIER")
                    Continue Do
                End If
            Next
            POZmod(dane, cel, "nazwa", nowanazwa)
            updateFILE(START.folderapk, 14, "lista", dane)
            ladujliste("")
            Exit Do
        Loop
    End Sub

    Private Sub menupozotworzwszystkie_Click(sender As Object, e As EventArgs) Handles menupozotworzwszystkie.Click
        Dim cel As String = sender.GetCurrentParent().SourceControl.Name.Substring(1)
        Dim dane As String = openFILE(START.folderapk, 14, "lista")
        Dim folder As String = POZget(dane, cel, "path")
        If folder = "" Then folder = POZget(dane, cel, "nazwa") Else folder &= "/" & POZget(dane, cel, "nazwa")
        For Each i As String In GRarray(dane)
            If POZget(dane, i, "path") = folder Then
                Try
                    Process.Start(POZget(dane, i, "adres"))
                Catch ex As Exception

                End Try
            End If
        Next
        updateFILE(START.folderapk, 14, "lista", dane)
        ladujliste("")
    End Sub

    Private Sub menupozprzenieswszystkie_Click(sender As Object, e As EventArgs) Handles menupozprzenieswszystkie.Click
        APK14przeniesdo.ShowDialog()
        If APK14przeniesdo.DialogResult = DialogResult.OK Then

            Dim katdocelowy As String = APK14przeniesdo.wynik
            Dim cel As String = sender.GetCurrentParent().SourceControl.Name.Substring(1)
            Dim dane As String = openFILE(START.folderapk, 14, "lista")
            Dim katwejsciowy As String = POZget(dane, cel, "path")
            If katwejsciowy = "" Then katwejsciowy = POZget(dane, cel, "nazwa") Else katwejsciowy &= "/" & POZget(dane, cel, "nazwa")

            For Each i As String In GRarray(dane)
                If POZget(dane, i, "path") = katwejsciowy Then
                    POZmod(dane, i, "path", katdocelowy)
                Else
                    If POZget(dane, i, "path") Like "*" & katwejsciowy & "[/]*" Then
                        If katdocelowy = "" Then
                            POZmod(dane, i, "path", POZget(dane, i, "path").Replace(katwejsciowy & "/", ""))
                        Else
                            POZmod(dane, i, "path", POZget(dane, i, "path").Replace(katwejsciowy, katdocelowy))
                        End If
                    End If
                End If
            Next

            updateFILE(START.folderapk, 14, "lista", dane)
            ladujliste("")

        End If
        APK14przeniesdo.Close()
    End Sub

    Private Sub menupozusunstrone_Click(sender As Object, e As EventArgs) Handles menupozusunstrone.Click
        If Not MsgBox("Czy na pewno chcesz usunąć tę stronę?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then Exit Sub
        Dim cel As String = sender.GetCurrentParent().SourceControl.Name.Substring(1)
        Dim dane As String = openFILE(START.folderapk, 14, "lista")
        GRdel(dane, cel)
        updateFILE(START.folderapk, 14, "lista", dane)
        ladujliste(txtszukaj.Text)
    End Sub

    Private Sub menupozdoschowka_Click(sender As Object, e As EventArgs) Handles menupozdoschowka.Click
        Dim cel As String = sender.GetCurrentParent().SourceControl.Name.Substring(1)
        Dim dane As String = openFILE(START.folderapk, 14, "lista")
        Try
            Clipboard.SetText(POZget(dane, cel, "adres"))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub menupozprzeniesdokatalogu_Click(sender As Object, e As EventArgs) Handles menupozprzeniesdokatalogu.Click
        APK14przeniesdo.ShowDialog()
        If APK14przeniesdo.DialogResult = DialogResult.OK Then

            Dim katdocelowy As String = APK14przeniesdo.wynik
            Dim cel As String = sender.GetCurrentParent().SourceControl.Name.Substring(1)
            Dim dane As String = openFILE(START.folderapk, 14, "lista")
            If katdocelowy = "" Then
                POZmod(dane, cel, "path", "")
            Else
                POZmod(dane, cel, "path", katdocelowy)
            End If
            updateFILE(START.folderapk, 14, "lista", dane)
            ladujliste(txtszukaj.Text)

        End If
        APK14przeniesdo.Close()
    End Sub

    Private Sub menupozmodyfikujwpis_Click(sender As Object, e As EventArgs) Handles menupozmodyfikujwpis.Click
        domod = sender.GetCurrentParent().SourceControl.Name.Substring(1)
        APK14modyfikuj.ShowDialog()
        If APK14modyfikuj.DialogResult = DialogResult.OK Then ladujliste(txtszukaj.Text)
        APK14modyfikuj.Close()
    End Sub

    Private Sub menupozpobierzikone_Click(sender As Object, e As EventArgs) Handles menupozpobierzikone.Click
        Dim cel As String = sender.GetCurrentParent().SourceControl.Name.Substring(1)
        Dim dane As String = openFILE(START.folderapk, 14, "lista")
        downloadfavicon(POZget(dane, cel, "adres"), cel)
        ladujliste(txtszukaj.Text)
    End Sub

    Private Sub menupozusunikone_Click(sender As Object, e As EventArgs) Handles menupozusunikone.Click
        Dim cel As String = sender.GetCurrentParent().SourceControl.Name.Substring(1)
        Dim dane As String = openFILE(START.folderapk, 14, "lista")
        Try
            If IO.File.Exists(START.folderapk & "\apk14\favicon-" & cel & ".png") Then
                panelwew.Controls.Clear()
                IO.File.Delete(START.folderapk & "\apk14\favicon-" & cel & ".png")
                ladujliste(txtszukaj.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub downloadfavicon(ByVal adr As String, ByVal poz As String)
        Try
            Dim url As Uri = New Uri(adr)
            If url.HostNameType = UriHostNameType.Dns Then
                If IO.File.Exists(START.folderapk & "\apk14\favicon-" & poz & ".png") Then
                    panelwew.Controls.Clear()
                    IO.File.Delete(START.folderapk & "\apk14\favicon-" & poz & ".png")
                End If
                Dim iconURL As String = "http://" & url.Host & "/favicon.ico"
                Dim request As Net.WebRequest = Net.WebRequest.Create(iconURL)
                Dim response As Net.HttpWebResponse = request.GetResponse()
                Dim stream As IO.Stream = response.GetResponseStream()
                Dim favicon As Image = Image.FromStream(stream)
                favicon.Save(START.folderapk & "\apk14\favicon-" & poz & ".png")
                MsgBox("Ikona została pobrana pomyślnie!", MsgBoxStyle.Information, "WINEASIER")
            Else
                MsgBox("Wystąpił błąd podczas pobierania ikony strony z serwera!", MsgBoxStyle.Exclamation, "WINEASIER")
            End If
        Catch ex As Exception
            MsgBox("Wystąpił błąd podczas pobierania ikony strony z serwera!", MsgBoxStyle.Exclamation, "WINEASIER")
        End Try
    End Sub

    Public Shared Function SafeImageFromFile(ByVal path As String) As Image
        Using fs As New FileStream(path, FileMode.Open, FileAccess.Read)
            Dim img As Image = Image.FromStream(fs)
            Return img
        End Using
    End Function
End Class