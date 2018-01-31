Public Class APK15zarzadzaj

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnusunstare_Click(sender As Object, e As EventArgs) Handles btnusunstare.Click
        If Not MsgBox("Usunąć przestarzałe zdarzenia z kalendarza?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then Exit Sub
        Dim dane As String = openFILE(START.folderapk, 15, "lista")
        For Each i As String In GRarray(dane)
            If DateTime.Compare(New DateTime(POZget(dane, i, "rok"), POZget(dane, i, "miesiac"), POZget(dane, i, "dzien")).AddDays(5), Now) < 0 Then
                If POZget(dane, i, "cykl") = "0" Then GRdel(dane, i)
            End If
        Next
        updateFILE(START.folderapk, 15, "lista", dane)
        laduj()
    End Sub

    Private Sub APK15zarzadzaj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico15.GetHicon())
        laduj()
    End Sub

    Private Sub laduj()
        Dim dane As String = openFILE(START.folderapk, 15, "lista")
        Dim l1 As Short = 0
        Dim l2 As Short = 0
        For Each i As String In GRarray(dane)
            l1 += 1
            If DateTime.Compare(New DateTime(POZget(dane, i, "rok"), POZget(dane, i, "miesiac"), POZget(dane, i, "dzien")).AddDays(5), Now) < 0 Then
                If POZget(dane, i, "cykl") = "0" Then l2 += 1
            End If
        Next
        lbl1.Text = "Wszystkich zdarzeń: " & l1
        lbl2.Text = "Przestarzałych zdarzeń: " & l2
    End Sub
End Class