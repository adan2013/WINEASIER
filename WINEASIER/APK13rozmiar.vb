Public Class APK13rozmiar

    Private Sub APK13rozmiar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico13.GetHicon())
        Dim plik As String = openFILE(START.folderapk, 13, "folder")
        If Not POZget(plik, "konfig", "path") = "" Then
            If IO.Directory.Exists(POZget(plik, "konfig", "path")) Then
                Try
                    lblakt.Text = APK13backup.directorysize(POZget(plik, "konfig", "path"), True) & " MB"
                Catch ex As Exception

                End Try
            End If
        End If
        Dim temp As String = ""
        temp = POZget(plik, "konfig", "info")
        If IsNumeric(temp) AndAlso temp < 4097 AndAlso temp >= 0 Then
            Dim flaga As Boolean = True
            For i As Byte = 0 To temp.Length - 1 Step 1
                If "0123456789".IndexOf(temp.Substring(i, 1)) < 0 Then
                    flaga = False
                    Exit For
                End If
            Next
            If flaga Then txt1.Value = CInt(temp) Else POZmod(plik, "konfig", "info", "0")
        Else
            POZmod(plik, "konfig", "info", "0")
        End If
        temp = POZget(plik, "konfig", "limit")
        If IsNumeric(temp) AndAlso temp < 4097 AndAlso temp >= 0 Then
            Dim flaga As Boolean = True
            For i As Byte = 0 To temp.Length - 1 Step 1
                If "0123456789".IndexOf(temp.Substring(i, 1)) < 0 Then
                    flaga = False
                    Exit For
                End If
            Next
            If flaga Then txt2.Value = CInt(temp) Else POZmod(plik, "konfig", "limit", "0")
        Else
            POZmod(plik, "konfig", "limit", "0")
        End If
        updateFILE(START.folderapk, 13, "folder", plik)
    End Sub

    Private Sub btnzamknij_Click(sender As Object, e As EventArgs) Handles btnzamknij.Click
        Dim plik As String = openFILE(START.folderapk, 13, "folder")
        POZmod(plik, "konfig", "info", txt1.Value.ToString())
        POZmod(plik, "konfig", "limit", txt2.Value.ToString())
        updateFILE(START.folderapk, 13, "folder", plik)
        DialogResult = DialogResult.OK
    End Sub
End Class