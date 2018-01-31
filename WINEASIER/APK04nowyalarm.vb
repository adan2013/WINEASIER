Public Class APK04nowyalarm

    Dim sciezkaprogram As String = ""
    Dim godz As Byte = 0
    Dim min As Byte = 0

    Private Sub APK04nowyalarm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico4.GetHicon())
        listaakcji.SelectedIndex = 0
        If APK04alarm.wybrany < 0 Then

        Else
            Dim dane As String = openFILE(START.folderapk, 4, "lista")
            lbltytul.Text = "Modyfikacja alarmu"
            txtopis.Text = POZget(dane, "poz" & APK04alarm.wybrany, "opis")
            godz = POZget(dane, "poz" & APK04alarm.wybrany, "godz")
            min = POZget(dane, "poz" & APK04alarm.wybrany, "min")
            aktzegar()
            Dim temp As Byte = POZget(dane, "poz" & APK04alarm.wybrany, "cel")
            If temp = 1 Then radio1.Checked = True
            If temp = 2 Then radio2.Checked = True
            If temp = 3 Then
                radio3.Checked = True
                listaakcji.SelectedIndex = POZget(dane, "poz" & APK04alarm.wybrany, "par")
            End If
            If temp = 4 Then
                radio4.Checked = True
                sciezkaprogram = POZget(dane, "poz" & APK04alarm.wybrany, "par")
                If sciezkaprogram.IndexOf("://") < 0 Then
                    If sciezkaprogram.IndexOf("%") < 0 Then
                        lblplik.Text = My.Computer.FileSystem.GetName(sciezkaprogram)
                    Else
                        txtpar.Text = sciezkaprogram.Substring(sciezkaprogram.IndexOf("%") + 1)
                        sciezkaprogram = sciezkaprogram.Substring(0, sciezkaprogram.IndexOf("%"))
                        lblplik.Text = My.Computer.FileSystem.GetName(sciezkaprogram)
                    End If
                Else
                    lblplik.Text = sciezkaprogram
                End If
            End If
            Dim temp2 As String = POZget(dane, "poz" & APK04alarm.wybrany, "dzien")
            If temp2.Substring(0, 1) = 1 Then dzien1.Checked = True
            If temp2.Substring(1, 1) = 1 Then dzien2.Checked = True
            If temp2.Substring(2, 1) = 1 Then dzien3.Checked = True
            If temp2.Substring(3, 1) = 1 Then dzien4.Checked = True
            If temp2.Substring(4, 1) = 1 Then dzien5.Checked = True
            If temp2.Substring(5, 1) = 1 Then dzien6.Checked = True
            If temp2.Substring(6, 1) = 1 Then dzien7.Checked = True
        End If
    End Sub

    Private Sub btnplusgodz_Click(sender As Object, e As EventArgs) Handles btnplusgodz.Click
        If godz = 23 Then godz = 0 Else godz += 1
        aktzegar()
    End Sub

    Private Sub btnminusgodz_Click(sender As Object, e As EventArgs) Handles btnminusgodz.Click
        If godz = 0 Then godz = 23 Else godz -= 1
        aktzegar()
    End Sub

    Private Sub btnplusmin_Click(sender As Object, e As EventArgs) Handles btnplusmin.Click
        If min = 59 Then min = 0 Else min += 1
        aktzegar()
    End Sub

    Private Sub btnminusmin_Click(sender As Object, e As EventArgs) Handles btnminusmin.Click
        If min = 0 Then min = 59 Else min -= 1
        aktzegar()
    End Sub

    Private Sub aktzegar()
        lblgodzina.Text = IIf(godz < 10, "0" & godz, godz) & ":" & IIf(min < 10, "0" & min, min)
    End Sub

    Private Sub btnwww_Click(sender As Object, e As EventArgs) Handles btnwww.Click
        Dim wynik As String = InputBox("Podaj docelowy adres URL strony WWW" & vbNewLine & "w następującej składni:" & vbNewLine & "http://google.pl lub http://microsoft.com:", "WINEASIER")
        If Not wynik = "" Then
            If wynik.IndexOf("://") < 0 Then
                MsgBox("Błędna składnia!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            sciezkaprogram = wynik
            lblplik.Text = sciezkaprogram
        End If
    End Sub

    Private Sub btnprzegladaj_Click(sender As Object, e As EventArgs) Handles btnprzegladaj.Click
        oknowyborpliku.FileName = ""
        oknowyborpliku.ShowDialog()
        If Not oknowyborpliku.FileName = "" Then
            Dim rozszerzenie As String = oknowyborpliku.FileName.Substring(oknowyborpliku.FileName.Length - 4)
            Dim poprawneroz As Boolean = False
            If rozszerzenie = ".exe" Then poprawneroz = True
            If rozszerzenie = ".bat" Then poprawneroz = True
            If Not poprawneroz Then
                MsgBox("Plik docelowy musi mieć rozszerzenie .exe lub .bat!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            sciezkaprogram = oknowyborpliku.FileName
            lblplik.Text = My.Computer.FileSystem.GetName(sciezkaprogram)
        End If
    End Sub

    Private Sub btnzapisz_Click(sender As Object, e As EventArgs) Handles btnzapisz.Click
        If radio4.Checked AndAlso sciezkaprogram = "" Then
            MsgBox("Nie podano docelowej ścieżki!", MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End If
        Dim id As Byte = 0
        Dim dane As String = openFILE(START.folderapk, 4, "lista")
        If APK04alarm.wybrany < 0 Then
            For i As Byte = 0 To 9 Step 1
                If Not GRexist(dane, "poz" & i) Then
                    id = i
                    Exit For
                End If
            Next
        Else
            id = APK04alarm.wybrany
        End If
        If APK04alarm.wybrany < 0 Then POZmod(dane, "poz" & id, "pwr", "1")
        POZmod(dane, "poz" & id, "opis", txtopis.Text)
        POZmod(dane, "poz" & id, "godz", godz)
        POZmod(dane, "poz" & id, "min", min)
        Dim temp As String = ""
        If dzien1.Checked Then temp &= "1" Else temp &= "0"
        If dzien2.Checked Then temp &= "1" Else temp &= "0"
        If dzien3.Checked Then temp &= "1" Else temp &= "0"
        If dzien4.Checked Then temp &= "1" Else temp &= "0"
        If dzien5.Checked Then temp &= "1" Else temp &= "0"
        If dzien6.Checked Then temp &= "1" Else temp &= "0"
        If dzien7.Checked Then temp &= "1" Else temp &= "0"
        POZmod(dane, "poz" & id, "dzien", temp)
        If radio1.Checked Then POZmod(dane, "poz" & id, "cel", "1")
        If radio2.Checked Then POZmod(dane, "poz" & id, "cel", "2")
        If radio3.Checked Then POZmod(dane, "poz" & id, "cel", "3")
        If radio4.Checked Then POZmod(dane, "poz" & id, "cel", "4")
        If radio3.Checked Then POZmod(dane, "poz" & id, "par", listaakcji.SelectedIndex)
        If radio4.Checked Then
            If sciezkaprogram.IndexOf("://") < 0 Then
                If txtpar.Text = "" Then
                    POZmod(dane, "poz" & id, "par", sciezkaprogram)
                Else
                    POZmod(dane, "poz" & id, "par", sciezkaprogram & "%" & txtpar.Text)
                End If
            Else
                POZmod(dane, "poz" & id, "par", sciezkaprogram)
            End If
        End If
        updateFILE(START.folderapk, 4, "lista", dane)
        DialogResult = DialogResult.OK
    End Sub
End Class