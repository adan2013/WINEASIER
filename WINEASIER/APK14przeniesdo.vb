Public Class APK14przeniesdo

    Public wynik As String = ""

    Private Sub APK14przeniesdo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico14.GetHicon())
        lista.Items.Clear()
        Dim dane As String = openFILE(START.folderapk, 14, "lista")
        For Each i As String In GRarray(dane)
            If POZget(dane, i, "kat") = "1" Then
                Dim sc As String = ""
                If POZget(dane, i, "path") = "" Then
                    sc = POZget(dane, i, "nazwa")
                Else
                    sc = POZget(dane, i, "path") & "/" & POZget(dane, i, "nazwa")
                End If
                Dim juzistnieje As Boolean = False
                For Each o As String In lista.Items
                    If sc = o Then
                        juzistnieje = True
                        Exit For
                    End If
                Next
                If Not juzistnieje Then lista.Items.Add(sc)
            End If
        Next
        If lista.Items.Count > 0 Then
            Dim tabl(0) As String
            For Each i As String In lista.Items
                tabl(tabl.Length - 1) = i
                ReDim Preserve tabl(tabl.Length)
            Next
            ReDim Preserve tabl(tabl.Length - 2)
            Array.Sort(tabl)
            lista.Items.Clear()
            lista.Items.AddRange(tabl)
        End If
        lista.Items.Insert(0, "Katalog główny")
        lista.SelectedIndex = 0
    End Sub

    Private Sub btnzatwierdz_Click(sender As Object, e As EventArgs) Handles btnzatwierdz.Click
        If lista.SelectedIndex = 0 Then wynik = "" Else wynik = lista.Text
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnanuluj_Click(sender As Object, e As EventArgs) Handles btnanuluj.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class