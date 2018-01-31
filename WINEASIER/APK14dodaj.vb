Public Class APK14dodaj

    Private Sub btnanuluj_Click(sender As Object, e As EventArgs) Handles btnanuluj.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnnowy_Click(sender As Object, e As EventArgs) Handles btnnowy.Click
        If txtkatalog.Text = "" Then
            MsgBox("Nazwa katalogu jest pusta!", MsgBoxStyle.Exclamation, "WINEASIER")
        Else
            For i As Byte = 0 To txtkatalog.Text.Length - 1 Step 1
                If " 0123456789qwertyuiopasdfghjklzxcvbnmąćęłńóśźż".IndexOf(txtkatalog.Text.Substring(i, 1).ToLower()) < 0 Then
                    MsgBox("Nazwa katalogu zawiera niedozwolone znaki!", MsgBoxStyle.Exclamation, "WINEASIER")
                    Exit Sub
                End If
            Next
            Dim dane As String = openFILE(START.folderapk, 14, "lista")
            Dim gr As String = ""
            For i As Short = 0 To 2000 Step 1
                If Not GRexist(dane, "poz" & i) Then
                    gr = "poz" & i
                    Exit For
                End If
            Next
            If gr = "" Then
                MsgBox("Przekroczono maksymalną liczbę pozycji w magazynie!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            POZmod(dane, gr, "kat", "1")
            POZmod(dane, gr, "nazwa", txtkatalog.Text)
            POZmod(dane, gr, "path", APK14magazynstronwww.aktkat)
            updateFILE(START.folderapk, 14, "lista", dane)
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub btndodaj_Click(sender As Object, e As EventArgs) Handles btndodaj.Click
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
            Dim gr As String = ""
            For i As Short = 0 To 2000 Step 1
                If Not GRexist(dane, "poz" & i) Then
                    gr = "poz" & i
                    Exit For
                End If
            Next
            If gr = "" Then
                MsgBox("Przekroczono maksymalną liczbę pozycji w magazynie!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            POZmod(dane, gr, "kat", "0")
            POZmod(dane, gr, "nazwa", txtnazwa.Text)
            POZmod(dane, gr, "path", APK14magazynstronwww.aktkat)
            POZmod(dane, gr, "adres", txtadres.Text)
            updateFILE(START.folderapk, 14, "lista", dane)
            DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub APK14dodaj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico14.GetHicon())
    End Sub
End Class