Public Class APK08nowy

    Private Sub btndodaj_Click(sender As Object, e As EventArgs) Handles btndodaj.Click
        If txt1.Text = "" OrElse txt3.Text = "" OrElse txt4.Text = "" Then
            MsgBox("Uzupełnij wymagane pola w formularzu!", MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End If
        Dim haslo As String = ""
        If Not APK08sejfhasel.autoryzacja() Then
            APK08odblokuj.ShowDialog()
            If Not APK08odblokuj.DialogResult = DialogResult.OK Then
                MsgBox("Operacja nie przeszła poprawnie autoryzacji!", MsgBoxStyle.Exclamation, "WINEASIER")
                APK08odblokuj.Close()
                Exit Sub
            End If
            haslo = APK08odblokuj.pass
            APK08odblokuj.Close()
        Else
            haslo = APK08sejfhasel.wpr
        End If
        Dim dane As String = openFILE(START.folderapk, 8, "list")
        Dim pozycja As String = ""
        For i As Byte = 0 To 119 Step 1
            If Not GRexist(dane, "poz" & i) Then
                pozycja = "poz" & i
                Exit For
            End If
        Next
        If pozycja = "" Then
            MsgBox("Przekroczono maksymalną liczbę pozycji!", MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End If
        POZmod(dane, pozycja, "nazwa", txt1.Text)
        POZmod(dane, pozycja, "adres", txt2.Text)
        POZmod(dane, pozycja, "login", txt3.Text)
        POZmod(dane, pozycja, "haslo", APK08sejfhasel.encode(txt4.Text, haslo))
        POZmod(dane, pozycja, "uwagi", txt5.Text)
        updateFILE(START.folderapk, 8, "list", dane)
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnodkryj_MouseDown(sender As Object, e As MouseEventArgs) Handles btnodkryj.MouseDown
        txt4.PasswordChar = ""
    End Sub

    Private Sub btnodkryj_MouseUp(sender As Object, e As MouseEventArgs) Handles btnodkryj.MouseUp
        txt4.PasswordChar = "*"
    End Sub

    Private Sub APK08nowy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico8.GetHicon())
    End Sub
End Class