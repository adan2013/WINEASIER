Public Class APK08edycja

    Dim pierwszezazn As Boolean = True
    Dim zamykanie As Boolean = False
    Dim poprzindex As Byte = 0
    Dim adresy As List(Of String) = New List(Of String)
    Dim haslo As String = ""

    Private Sub APK08edycja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not pierwszezazn Then
            zamykanie = True
            zapiszzmiany()
        End If
    End Sub

    Private Sub btnodkryj_MouseDown(sender As Object, e As MouseEventArgs) Handles btnodkryj.MouseDown
        txt4.PasswordChar = ""
    End Sub

    Private Sub btnodkryj_MouseUp(sender As Object, e As MouseEventArgs) Handles btnodkryj.MouseUp
        txt4.PasswordChar = "*"
    End Sub

    Private Sub btnporzuc_Click(sender As Object, e As EventArgs) Handles btnporzuc.Click
        btnporzuc.Enabled = False
        zaladujdane()
    End Sub

    Private Sub lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lista.SelectedIndexChanged
        If pierwszezazn Then
            pierwszezazn = False
        Else
            zapiszzmiany()
        End If
        If Not zamykanie Then poprzindex = lista.SelectedIndex
        zaladujdane()
    End Sub

    Private Sub zapiszzmiany()
        If Not btnporzuc.Enabled Then Exit Sub
        If txt1.Text = "" OrElse txt3.Text = "" OrElse txt4.Text = "" Then
            MsgBox("Zmiany nie zostały zapisane, ponieważ nie uzupełniono wszystkich wymaganych pól!", MsgBoxStyle.Exclamation, "WINEASIER")
            btnporzuc.Enabled = True
            Exit Sub
        End If
        Dim dane As String = openFILE(START.folderapk, 8, "list")
        POZmod(dane, adresy(poprzindex), "nazwa", txt1.Text)
        POZmod(dane, adresy(poprzindex), "adres", txt2.Text)
        POZmod(dane, adresy(poprzindex), "login", txt3.Text)
        POZmod(dane, adresy(poprzindex), "haslo", APK08sejfhasel.encode(txt4.Text, haslo))
        POZmod(dane, adresy(poprzindex), "uwagi", txt5.Text)
        updateFILE(START.folderapk, 8, "list", dane)
        If Not zamykanie Then
            lista.Items.Item(poprzindex) = txt1.Text & " (" & txt3.Text & ")"
            btnporzuc.Enabled = False
        End If
    End Sub

    Private Sub zaladujdane()
        If lista.SelectedIndex >= 0 Then
            Dim dane As String = openFILE(START.folderapk, 8, "list")
            txt1.Text = POZget(dane, adresy(lista.SelectedIndex), "nazwa")
            txt2.Text = POZget(dane, adresy(lista.SelectedIndex), "adres")
            txt3.Text = POZget(dane, adresy(lista.SelectedIndex), "login")
            txt4.Text = APK08sejfhasel.decode(POZget(dane, adresy(lista.SelectedIndex), "haslo"), haslo)
            txt5.Text = POZget(dane, adresy(lista.SelectedIndex), "uwagi")
            btnporzuc.Enabled = False
        End If
    End Sub

    Private Sub zaladujliste()
        lista.Items.Clear()
        adresy.Clear()
        Dim dane As String = openFILE(START.folderapk, 8, "list")
        For Each i As String In GRarray(dane)
            lista.Items.Add(POZget(dane, i, "nazwa") & " (" & POZget(dane, i, "login") & ")")
            adresy.Add(i)
            If Not APK08sejfhasel.wybr = "" Then
                If APK08sejfhasel.wybr = i Then lista.SelectedIndex = lista.Items.Count - 1
            End If
        Next
    End Sub

    Private Sub APK08edycja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico8.GetHicon())
        If APK08sejfhasel.autoryzacja() Then
            haslo = APK08sejfhasel.wpr
        Else
            APK08odblokuj.ShowDialog()
            If APK08odblokuj.DialogResult = DialogResult.OK Then
                haslo = APK08odblokuj.pass
                APK08odblokuj.Close()
            Else
                MsgBox("Operacja nie przeszła poprawnie autoryzacji!", MsgBoxStyle.Exclamation, "WINEASIER")
                APK08odblokuj.Close()
                DialogResult = DialogResult.OK
            End If
        End If
        zaladujliste()
    End Sub

    Private Sub zmiana(sender As Object, e As EventArgs) Handles txt1.TextChanged, txt2.TextChanged, txt3.TextChanged, txt4.TextChanged, txt5.TextChanged
        btnporzuc.Enabled = True
    End Sub
End Class