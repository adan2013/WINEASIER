Public Class APK08zmiana

    Dim spelnione As Boolean = False

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged
        If txt1.Text.Length < 5 Then
            lblsila.Text = "Brak"
            spelnione = False
            lblsila.ForeColor = Color.Black
        Else
            Dim SILAduze As Boolean = False
            Dim SILAmale As Boolean = False
            Dim SILAlitery As Boolean = False
            Dim SILAcyfry As Boolean = False
            Dim SILAznakispec As Boolean = False
            Dim SILAdlugosc As Boolean = False

            For i As Byte = 0 To txt1.Text.Length - 1 Step 1
                If "QWERTYUIOPASDFGHJKLZXCVBNM".IndexOf(txt1.Text.Substring(i, 1)) >= 0 Then SILAduze = True
                If "qwertyuiopasdfghjklzxcvbnm".IndexOf(txt1.Text.Substring(i, 1)) >= 0 Then SILAmale = True
                If "0123456789".IndexOf(txt1.Text.Substring(i, 1)) >= 0 Then SILAcyfry = True
                If "!@#$%^&*()-_=+[]{};:\|<,>./?".IndexOf(txt1.Text.Substring(i, 1)) >= 0 Then SILAznakispec = True
            Next
            If SILAduze Or SILAmale Then SILAlitery = True
            If txt1.Text.Length > 15 Then SILAdlugosc = True
            Dim nr As Byte = 0
            If SILAduze Then nr += 1
            If SILAmale Then nr += 1
            If SILAlitery Then nr += 1
            If SILAcyfry Then nr += 1
            If SILAznakispec Then nr += 1
            If SILAdlugosc Then nr += 1
            Select Case nr
                Case 0
                    lblsila.Text = "Brak"
                Case 1
                    lblsila.Text = "Bardzo niska"
                Case 2
                    lblsila.Text = "Niska"
                Case 3
                    lblsila.Text = "Średnia"
                Case 4
                    lblsila.Text = "Dobra"
                Case 5
                    lblsila.Text = "Wysoka"
                Case 6
                    lblsila.Text = "Bardzo wysoka"
                Case Else
                    lblsila.Text = "Brak"
            End Select
            If nr > 2 Then spelnione = True Else spelnione = False
            If nr > 2 Then lblsila.ForeColor = Color.Black Else lblsila.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnzmien_Click(sender As Object, e As EventArgs) Handles btnzmien.Click
        Dim kom As String = ""
        If Not txt1.Text = txt2.Text Then kom = "Pola z hasłami zawierają różne wartości"
        If Not spelnione Then kom = "Złożoność hasła jest za niska i nie spełnia wymogów bezpieczeństwa"
        If txt1.Text.Length < 5 Then kom = "Hasło jest za krótkie"
        If txt1.Text = "" OrElse txt2.Text = "" Then kom = "Pola nie mogą być puste"
        If kom = "" Then
            APK08odblokuj.ShowDialog()
            If APK08odblokuj.DialogResult = DialogResult.OK Then
                Dim dane As String = openFILE(START.folderapk, 8, "konfig")
                POZmod(dane, "root", "pass", APK08sejfhasel.encode(APK08sejfhasel.hashcontrol, txt1.Text))
                updateFILE(START.folderapk, 8, "konfig", dane)
                zamianahasel(txt1.Text, APK08odblokuj.pass)
                MsgBox("Hasło zostało zmienione!", MsgBoxStyle.Exclamation, "WINEASIER")
                APK08odblokuj.Close()
                DialogResult = DialogResult.OK
            Else
                MsgBox("Hasło nie może zostać zmienione bez podania poprzedniego!", MsgBoxStyle.Exclamation, "WINEASIER")
                APK08odblokuj.Close()
            End If
        Else
            MsgBox(kom, MsgBoxStyle.Exclamation, "WINEASIER")
        End If
    End Sub

    Private Sub zamianahasel(ByVal newpass As String, ByVal oldpass As String)
        Dim dane As String = openFILE(START.folderapk, 8, "list")
        For Each i As String In GRarray(dane)
            If Not POZget(dane, i, "haslo") = "" Then
                Dim temp As String = APK08sejfhasel.decode(POZget(dane, i, "haslo"), oldpass)
                If Not temp = "" Then
                    POZmod(dane, i, "haslo", APK08sejfhasel.encode(temp, newpass))
                End If
            End If
        Next
        updateFILE(START.folderapk, 8, "list", dane)
    End Sub

    Private Sub APK08zmiana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico8.GetHicon())
    End Sub
End Class