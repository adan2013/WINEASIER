Public Class APK14modyfikuj

    Dim grupa As String = ""

    Private Sub APK14modyfikuj_Load(sender As Object, e As EventArgs) Handles Me.Load
        Icon = Icon.FromHandle(My.Resources.ico14.GetHicon())
        grupa = APK14magazynstronwww.domod
        Dim dane As String = openFILE(START.folderapk, 14, "lista")
        txtnazwa.Text = POZget(dane, grupa, "nazwa")
        txtadres.Text = POZget(dane, grupa, "adres")
    End Sub

    Private Sub btnanuluj_Click(sender As Object, e As EventArgs) Handles btnanuluj.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnzapisz_Click(sender As Object, e As EventArgs) Handles btnzapisz.Click
        If txtnazwa.Text = "" Or txtadres.Text = "" Then
            MsgBox("Pozostawiono puste pola!", MsgBoxStyle.Exclamation, "WINEASIER")
        Else
            For i As Byte = 0 To txtnazwa.Text.Length - 1 Step 1
                If " 0123456789qwertyuiopasdfghjklzxcvbnm-?!@#$%^&*()ąćęłńóśźż".IndexOf(txtnazwa.Text.Substring(i, 1).ToLower()) < 0 Then
                    MsgBox("Nazwa pozycji zawiera niedozwolone znaki!", MsgBoxStyle.Exclamation, "WINEASIER")
                    Exit Sub
                End If
            Next
            Dim dane As String = openFILE(START.folderapk, 14, "lista")
            POZmod(dane, grupa, "nazwa", txtnazwa.Text)
            POZmod(dane, grupa, "adres", txtadres.Text)
            updateFILE(START.folderapk, 14, "lista", dane)
            DialogResult = DialogResult.OK
        End If
    End Sub
End Class