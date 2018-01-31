Public Class APK08podglad

    Dim poz1 As String = ""
    Dim poz2 As String = ""
    Dim poz3 As String = ""
    Dim poz4 As String = ""
    Dim poz5 As String = ""
    Dim haslo As String = ""

    Private Sub btnzamknij_Click(sender As Object, e As EventArgs) Handles btnzamknij.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub APK08podglad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico8.GetHicon())
        If APK08sejfhasel.autoryzacja() Then
            haslo = APK08sejfhasel.wpr
            Dim dane As String = openFILE(START.folderapk, 8, "list")
            poz1 = POZget(dane, APK08sejfhasel.wybr, "nazwa")
            poz2 = POZget(dane, APK08sejfhasel.wybr, "adres")
            poz3 = POZget(dane, APK08sejfhasel.wybr, "login")
            poz4 = POZget(dane, APK08sejfhasel.wybr, "haslo")
            poz5 = POZget(dane, APK08sejfhasel.wybr, "uwagi")
            If poz1 = "" Then START.bladdanych() Else lbl1.Text = poz1
            If poz2 = "" Then lbl2.Text = "brak informacji" Else lbl2.Text = poz2
            If poz3 = "" Then START.bladdanych() Else lbl3.Text = poz3
            If poz4 = "" Then START.bladdanych() Else lbl4.Text = "*****"
            If poz5 = "" Then lbl5.Text = "brak informacji" Else lbl5.Text = poz5
        Else
            APK08odblokuj.ShowDialog()
            If APK08odblokuj.DialogResult = DialogResult.OK Then
                haslo = APK08odblokuj.pass
                APK08odblokuj.Close()
                Dim dane As String = openFILE(START.folderapk, 8, "list")
                poz1 = POZget(dane, APK08sejfhasel.wybr, "nazwa")
                poz2 = POZget(dane, APK08sejfhasel.wybr, "adres")
                poz3 = POZget(dane, APK08sejfhasel.wybr, "login")
                poz4 = POZget(dane, APK08sejfhasel.wybr, "haslo")
                poz5 = POZget(dane, APK08sejfhasel.wybr, "uwagi")
                If poz1 = "" Then START.bladdanych() Else lbl1.Text = poz1
                If poz2 = "" Then lbl2.Text = "brak informacji" Else lbl2.Text = poz2
                If poz3 = "" Then START.bladdanych() Else lbl3.Text = poz3
                If poz4 = "" Then START.bladdanych() Else lbl4.Text = "*****"
                If poz5 = "" Then lbl5.Text = "brak informacji" Else lbl5.Text = poz5
            Else
                MsgBox("Operacja nie przeszła poprawnie autoryzacji!", MsgBoxStyle.Exclamation, "WINEASIER")
                APK08odblokuj.Close()
                DialogResult = DialogResult.OK
            End If
        End If
        If Not poz2 = "" Then otworz.Enabled = True
    End Sub

    Private Sub otworz_Click(sender As Object, e As EventArgs) Handles otworz.Click
        Try
            If Not poz2 = "" Then Process.Start(poz2)
        Catch ex As Exception
            MsgBox("Wystąpił błąd podczas otwierania strony" & vbNewLine & "Upewnij się że zaczyna się on od definicji protokołu np. http://", MsgBoxStyle.Exclamation, "WINEASIER")
        End Try
    End Sub

    Private Sub odslon_MouseDown(sender As Object, e As MouseEventArgs) Handles odslon.MouseDown
        lbl4.Text = APK08sejfhasel.decode(poz4, haslo)
    End Sub

    Private Sub odslon_MouseUp(sender As Object, e As MouseEventArgs) Handles odslon.MouseUp
        lbl4.Text = "*****"
    End Sub

    Private Sub btnedycja_Click(sender As Object, e As EventArgs) Handles btnedycja.Click
        DialogResult = DialogResult.Yes
    End Sub

    Private Sub btnusun_Click(sender As Object, e As EventArgs) Handles btnusun.Click
        If Not MsgBox("Czy na pewno chcesz usunąć ten wpis?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then Exit Sub
        Dim dane As String = openFILE(START.folderapk, 8, "list")
        GRdel(dane, APK08sejfhasel.wybr)
        updateFILE(START.folderapk, 8, "list", dane)
        DialogResult = DialogResult.No
    End Sub

    Private Sub schowek1_Click(sender As Object, e As EventArgs) Handles schowek1.Click
        If poz1 = "" Then Exit Sub
        Clipboard.SetText(poz1)
        ukr.Enabled = False
        ukr.Enabled = True
        lblinfo.Visible = True
    End Sub

    Private Sub schowek2_Click(sender As Object, e As EventArgs) Handles schowek2.Click
        If poz2 = "" Then Exit Sub
        Clipboard.SetText(poz2)
        ukr.Enabled = False
        ukr.Enabled = True
        lblinfo.Visible = True
    End Sub

    Private Sub schowek3_Click(sender As Object, e As EventArgs) Handles schowek3.Click
        If poz3 = "" Then Exit Sub
        Clipboard.SetText(poz3)
        ukr.Enabled = False
        ukr.Enabled = True
        lblinfo.Visible = True
    End Sub

    Private Sub schowek4_Click(sender As Object, e As EventArgs) Handles schowek4.Click
        If poz4 = "" Then Exit Sub
        Clipboard.SetText(APK08sejfhasel.decode(poz4, haslo))
        ukr.Enabled = False
        ukr.Enabled = True
        lblinfo.Visible = True
    End Sub

    Private Sub schowek5_Click(sender As Object, e As EventArgs) Handles schowek5.Click
        If poz5 = "" Then Exit Sub
        Clipboard.SetText(poz5)
        ukr.Enabled = False
        ukr.Enabled = True
        lblinfo.Visible = True
    End Sub

    Private Sub ukr_Tick(sender As Object, e As EventArgs) Handles ukr.Tick
        ukr.Enabled = False
        lblinfo.Visible = False
    End Sub
End Class