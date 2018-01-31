Public Class modyfikacjawpisu3

    Dim danepozycji As String = ""
    Dim akcjamod As String = ""
    Dim sciezkaprogram As String = ""

    Private Sub modyfikacjawpisu3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lp As Byte = 1
        Do
            lp += 1
            If START.nazwaaplikacji(lp) = "" Then
                Exit Do
            Else
                listaaplikacji.Items.Add(START.nazwaaplikacji(lp))
            End If
        Loop
        If ustawienia.wybrany < 0 Then
            lbltytul.Text = "Nowy wpis"

        Else
            lbltytul.Text = "Modyfikacja wpisu"
            danepozycji = ustawienia.konfigklawisze(ustawienia.wybrany)
            If ustawienia.listaklawisze.Items(ustawienia.wybrany).IndexOf("Ctrl") >= 0 Then checkctrl.Checked = True
            If ustawienia.listaklawisze.Items(ustawienia.wybrany).IndexOf("Alt") >= 0 Then checkalt.Checked = True
            If ustawienia.listaklawisze.Items(ustawienia.wybrany).IndexOf("Shift") >= 0 Then checkshift.Checked = True
            Dim tempklawisz As String = danepozycji.Substring(danepozycji.IndexOf("@") + 1, danepozycji.LastIndexOf("@") - danepozycji.IndexOf("@") - 1)
            Dim nr As Byte = 0
            Do
                If listaklawisz.Items(nr) = tempklawisz Then
                    listaklawisz.SelectedIndex = nr
                    Exit Do
                End If
                nr += 1
            Loop
            If danepozycji.Substring(danepozycji.IndexOf("%") + 1, 1) = 1 Then radio1.Checked = True
            If danepozycji.Substring(danepozycji.IndexOf("%") + 1, 1) = 2 Then radio2.Checked = True
            If danepozycji.Substring(danepozycji.IndexOf("%") + 1, 1) = 3 Then radio3.Checked = True
            Dim temppar As String = danepozycji.Substring(danepozycji.IndexOf("%") + 2)
            If radio2.Checked Then
                akcjamod = temppar.Substring(temppar.IndexOf("%") + 1)
                listaaplikacji.SelectedIndex = temppar.Substring(0, temppar.IndexOf("%")) - 2
            Else
                If radio3.Checked Then
                    If temppar.IndexOf("://") < 0 Then
                        If temppar.IndexOf("%") < 0 Then
                            sciezkaprogram = temppar
                            lblprogram.Text = My.Computer.FileSystem.GetName(sciezkaprogram)
                        Else
                            sciezkaprogram = temppar.Substring(0, temppar.IndexOf("%"))
                            lblprogram.Text = My.Computer.FileSystem.GetName(temppar.Substring(0, temppar.IndexOf("%")))
                            txtpar.Text = temppar.Substring(temppar.IndexOf("%") + 1)
                        End If
                    Else
                        sciezkaprogram = temppar
                        lblprogram.Text = sciezkaprogram
                    End If
                End If
            End If
        End If
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

    Private Sub btnzapisz_Click(sender As Object, e As EventArgs) Handles btnzapisz.Click
        Dim komunikat As String = ""
        If listaklawisz.Text = "" Then komunikat = "Nie wybrano klawisza skrótu!"
        If radio2.Checked Then If listaaplikacji.Text = "" Then komunikat = "Nie wybrano aplikacji docelowej!"
        If radio3.Checked Then If sciezkaprogram = "" Then komunikat = "Nie wybrano ani strony ani programu docelowego!"
        If ustawienia.konfigklawisze.Count > 0 Then
            For i As Byte = 0 To ustawienia.konfigklawisze.Count - 1 Step 1
                If ustawienia.konfigklawisze(i).IndexOf(checkctrl.Checked & checkalt.Checked & checkshift.Checked & "@" & listaklawisz.Text & "@") = 0 Then
                    If Not i = ustawienia.wybrany Then
                        komunikat = "Wybrany skrót jest już zajęty!"
                        Exit For
                    End If
                End If
            Next
        End If
        If Not komunikat = "" Then
            MsgBox(komunikat, MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End If
        Dim parametr As String = ""
        If radio2.Checked Then
            parametr = listaaplikacji.SelectedIndex + 2
            Dim lista As List(Of String) = New List(Of String)
            lista = START.akcjeaplikacji(parametr)
            parametr = parametr & lista(listaakcji.SelectedIndex).Substring(lista(listaakcji.SelectedIndex).IndexOf("%"))
        End If
        If radio3.Checked Then
            If sciezkaprogram.IndexOf("://") < 0 Then
                If txtpar.Text = "" Then
                    parametr = sciezkaprogram
                Else
                    parametr = sciezkaprogram & "%" & txtpar.Text
                End If
            Else
                parametr = sciezkaprogram
            End If
        End If
        If ustawienia.wybrany < 0 Then
            ustawienia.konfigklawisze.Add(checkctrl.Checked & checkalt.Checked & checkshift.Checked & "@" & listaklawisz.Text & "@" & "%" & IIf(radio1.Checked, 1, IIf(radio2.Checked, 2, 3)) & parametr)
        Else
            ustawienia.konfigklawisze(ustawienia.wybrany) = checkctrl.Checked & checkalt.Checked & checkshift.Checked & "@" & listaklawisz.Text & "@" & "%" & IIf(radio1.Checked, 1, IIf(radio2.Checked, 2, 3)) & parametr
        End If
        ustawienia.sukceswpisu = True
        DialogResult = DialogResult.OK
    End Sub
End Class