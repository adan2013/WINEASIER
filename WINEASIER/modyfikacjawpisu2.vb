Public Class modyfikacjawpisu2

    Dim nr As Byte = 0
    Dim sciezkagrafika As String = ""
    Dim sciezkaprogram As String = ""
    Dim akcjamod As String = ""

    Private Sub modyfikacjawpisu2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lp As Byte = 1
        Do
            lp += 1
            If START.nazwaaplikacji(lp) = "" Then
                Exit Do
            Else
                listaaplikacji.Items.Add(START.nazwaaplikacji(lp))
            End If
        Loop
        nr = ustawienia.listadol.SelectedIndex
        Dim danezpliku As String = ustawienia.konfigquickmenu2
        If GRexist(danezpliku, "poz" & nr) Then
            lbltytul.Text = "Modyfikacja wpisu"
            Dim daneikona As String = POZget(danezpliku, "poz" & nr, "ikona")
            Dim danecel As String = POZget(danezpliku, "poz" & nr, "cel")
            Dim danepar As String = POZget(danezpliku, "poz" & nr, "par")
            If daneikona = "" Then
                radiografikadomyslna.Checked = True
            Else
                radiografikaplik.Checked = True
                sciezkagrafika = daneikona
                lblplik.Text = My.Computer.FileSystem.GetName(daneikona)
            End If
            If danecel = 1 Then
                radioakcjawineasier.Checked = True
                If danepar.IndexOf("%") < 0 Then
                    listaaplikacji.SelectedIndex = danepar - 2
                Else
                    akcjamod = danepar.Substring(danepar.IndexOf("%") + 1)
                    listaaplikacji.SelectedIndex = danepar.Substring(0, danepar.IndexOf("%")) - 2
                End If
            Else
                radioakcjaprogram.Checked = True
                If danepar.IndexOf("%") < 0 Then
                    sciezkaprogram = danepar
                    If danepar.IndexOf("://") < 0 Then
                        lblprogram.Text = My.Computer.FileSystem.GetName(sciezkaprogram)
                    Else
                        lblprogram.Text = sciezkaprogram
                    End If
                Else
                    sciezkaprogram = danepar.Substring(0, danepar.IndexOf("%"))
                    If sciezkaprogram.IndexOf("://") < 0 Then
                        lblprogram.Text = My.Computer.FileSystem.GetName(sciezkaprogram)
                    Else
                        lblprogram.Text = sciezkaprogram
                    End If
                    txtparametr.Text = danepar.Substring(danepar.IndexOf("%") + 1)
                End If
            End If
        Else
            lbltytul.Text = "Nowy wpis"
        End If
    End Sub

    Private Sub btnwww_Click(sender As Object, e As EventArgs) Handles btnwww.Click
        Dim wynik As String = InputBox("Podaj docelowy adres URL strony WWW" & vbNewLine & "w następującej składni:" & vbNewLine & "http://google.pl lub http://microsoft.com:", "WINEASIER")
        If Not wynik = "" Then
            If wynik.IndexOf("://") < 0 Then
                MsgBox("Błędna składnia!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            sciezkaprogram = wynik
            lblprogram.Text = sciezkaprogram
        End If
    End Sub

    Private Sub btnprzegladaj_Click(sender As Object, e As EventArgs) Handles btnprzegladaj.Click
        oknowyborpliku.FileName = ""
        oknowyborpliku.ShowDialog()
        If Not oknowyborpliku.FileName = "" Then
            Dim rozszerzenie As String = oknowyborpliku.FileName.Substring(oknowyborpliku.FileName.Length - 4)
            Dim poprawneroz As Boolean = False
            If rozszerzenie = ".bmp" Then poprawneroz = True
            If rozszerzenie = ".png" Then poprawneroz = True
            If Not poprawneroz Then
                MsgBox("Plik grafiki musi mieć rozszerzenie .bmp lub .png!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            sciezkagrafika = oknowyborpliku.FileName
            lblplik.Text = My.Computer.FileSystem.GetName(sciezkagrafika)
        End If
    End Sub

    Private Sub btnprogram_Click(sender As Object, e As EventArgs) Handles btnprogram.Click
        oknowyborpliku.FileName = ""
        oknowyborpliku.ShowDialog()
        If Not oknowyborpliku.FileName = "" Then
            Dim rozszerzenie As String = oknowyborpliku.FileName.Substring(oknowyborpliku.FileName.Length - 4).ToLower()
            Dim poprawneroz As Boolean = False
            If rozszerzenie = ".exe" Then poprawneroz = True
            If rozszerzenie = ".bat" Then poprawneroz = True
            If Not poprawneroz Then
                MsgBox("Plik docelowy musi mieć rozszerzenie .exe lub .bat!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            sciezkaprogram = oknowyborpliku.FileName
            lblprogram.Text = My.Computer.FileSystem.GetName(sciezkaprogram)
        End If
    End Sub

    Private Sub MetroLink2_Click(sender As Object, e As EventArgs) Handles MetroLink2.Click
        Dim komunikat As String = ""
        If radiografikaplik.Checked AndAlso sciezkagrafika = "" Then komunikat = "Nie wybrano pliku z grafiką!"
        If radioakcjawineasier.Checked Then
            If listaaplikacji.SelectedIndex < 0 Or listaaplikacji.Text = "" Then komunikat = "Nie wybrano aplikacji docelowej!"
        End If
        If radioakcjaprogram.Checked AndAlso sciezkaprogram = "" Then komunikat = "Nie wybrano pliku programu lub strony WWW!"
        If Not komunikat = "" Then
            MsgBox(komunikat, MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End If
        If radiografikadomyslna.Checked Then
            POZmod(ustawienia.konfigquickmenu2, "poz" & ustawienia.listadol.SelectedIndex, "ikona", "")
        Else
            POZmod(ustawienia.konfigquickmenu2, "poz" & ustawienia.listadol.SelectedIndex, "ikona", sciezkagrafika)
        End If
        If radioakcjawineasier.Checked Then
            POZmod(ustawienia.konfigquickmenu2, "poz" & ustawienia.listadol.SelectedIndex, "cel", "1")

            Dim parametr As String = ""
            parametr = listaaplikacji.SelectedIndex + 2
            Dim lista As List(Of String) = New List(Of String)
            lista = START.akcjeaplikacji(parametr)
            parametr = parametr & lista(listaakcji.SelectedIndex).Substring(lista(listaakcji.SelectedIndex).IndexOf("%"))

            POZmod(ustawienia.konfigquickmenu2, "poz" & ustawienia.listadol.SelectedIndex, "par", parametr)
        Else
            POZmod(ustawienia.konfigquickmenu2, "poz" & ustawienia.listadol.SelectedIndex, "cel", "2")
            If sciezkaprogram.IndexOf("://") < 0 Then
                If txtparametr.Text = "" Then
                    POZmod(ustawienia.konfigquickmenu2, "poz" & ustawienia.listadol.SelectedIndex, "par", sciezkaprogram)
                Else
                    POZmod(ustawienia.konfigquickmenu2, "poz" & ustawienia.listadol.SelectedIndex, "par", sciezkaprogram & "%" & txtparametr.Text)
                End If
            Else
                POZmod(ustawienia.konfigquickmenu2, "poz" & ustawienia.listadol.SelectedIndex, "par", sciezkaprogram)
            End If
        End If
        ustawienia.sukceswpisu = True
        DialogResult = DialogResult.OK
    End Sub

    Private Sub listaaplikacji_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaaplikacji.SelectedIndexChanged
        listaakcji.Enabled = True
        listaakcji.Items.Clear()
        Dim lista As List(Of String) = New List(Of String)
        Dim dozazn As Byte = 0
        lista = START.akcjeaplikacji(listaaplikacji.SelectedIndex + 2)
        For i As Byte = 0 To lista.Count - 1 Step 1
            listaakcji.Items.Add(lista(i).Substring(0, lista(i).IndexOf("%")))
            If lista(i).Substring(lista(i).IndexOf("%") + 1) = akcjamod Then dozazn = i
        Next
        listaakcji.SelectedIndex = dozazn
    End Sub
End Class