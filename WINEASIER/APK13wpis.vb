Public Class APK13wpis

    Private Sub APK13wpis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico13.GetHicon())
        MetroTabControl1.SelectedIndex = 0
        listahz.SelectedIndex = 0
        listail.SelectedIndex = 0
        If APK13backup.wybr = "" Then

        Else
            txtnazwa.Enabled = False
            lbltytul.Text = "Edycja wpisu"
            Dim plik As String = openFILE(START.folderapk, 13, "lista")
            Dim gr As String = ""
            For Each i As String In GRarray(plik)
                If POZget(plik, i, "nazwa") = APK13backup.wybr Then
                    gr = i
                    Exit For
                End If
            Next
            If gr = "" Then START.bladdanych()
            txtnazwa.Text = POZget(plik, gr, "nazwa")
            If txtnazwa.Text = "" Then START.bladdanych()
            For i As Byte = 0 To txtnazwa.Text.Length - 1 Step 1
                If "0123456789 qwertyuiopasdfghjklzxcvbnmąćęłńóśźż".IndexOf(txtnazwa.Text.Substring(i, 1).ToLower()) < 0 Then START.bladdanych()
            Next
            txtpath.Text = POZget(plik, gr, "path")
            Dim temp As String = POZget(plik, gr, "hz")
            If IsNumeric(temp) AndAlso temp < 9 Then
                listahz.SelectedIndex = temp
            Else
                START.bladdanych()
            End If
            temp = POZget(plik, gr, "il")
            If IsNumeric(temp) AndAlso temp < 10 Then
                listail.SelectedIndex = temp
            Else
                START.bladdanych()
            End If
            txtexe1.Text = POZget(plik, gr, "start")
            txtexe2.Text = POZget(plik, gr, "koniec")
            temp = POZget(plik, gr, "opcje")
            If IsNumeric(temp) AndAlso temp.Length = 4 Then
                If temp.Substring(0, 1) = "1" Then chkboxinfo1.Checked = True
                If temp.Substring(1, 1) = "1" Then chkboxinfo2.Checked = True
                If temp.Substring(2, 1) = "1" Then chkboxautoprog1.Checked = True
                If temp.Substring(3, 1) = "1" Then chkboxautoprog2.Checked = True
            Else
                START.bladdanych()
            End If
        End If
    End Sub

    Private Sub btndirpath_Click(sender As Object, e As EventArgs) Handles btndirpath.Click
        dialogfolder.ShowDialog()
        If IO.Directory.Exists(dialogfolder.SelectedPath) Then txtpath.Text = dialogfolder.SelectedPath
    End Sub

    Private Sub btndirexe1_Click(sender As Object, e As EventArgs) Handles btndirexe1.Click
        dialogplik.ShowDialog()
        If IO.File.Exists(dialogplik.FileName) Then txtexe1.Text = dialogplik.FileName
    End Sub

    Private Sub btndirexe2_Click(sender As Object, e As EventArgs) Handles btndirexe2.Click
        dialogplik.ShowDialog()
        If IO.File.Exists(dialogplik.FileName) Then txtexe2.Text = dialogplik.FileName
    End Sub

    Private Sub btnzapisz_Click(sender As Object, e As EventArgs) Handles btnzapisz.Click
        Dim plik As String = openFILE(START.folderapk, 13, "lista")
        Dim gr As String = ""

        If txtnazwa.Text = "" Then
            MsgBox("Nazwa nie może być pusta!", MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End If
        For i As Byte = 0 To txtnazwa.Text.Length - 1 Step 1
            If "0123456789 qwertyuiopasdfghjklzxcvbnmąćęłńóśźż".IndexOf(txtnazwa.Text.Substring(i, 1).ToLower()) < 0 Then
                MsgBox("Nazwa może składać się jedynie z cyfr i liter!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
        Next
        If APK13backup.wybr = "" Then
            For Each i As String In GRarray(plik)
                If POZget(plik, i, "nazwa") = txtnazwa.Text Then
                    MsgBox("Podana nazwa jest już zajęta!", MsgBoxStyle.Exclamation, "WINEASIER")
                    Exit Sub
                End If
            Next
        End If
        If txtpath.Text = "" OrElse Not IO.Directory.Exists(txtpath.Text) Then
            MsgBox("Ścieżka do folderu z danymi jest błędna!", MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End If
        Try
            APK13backup.directorysize(txtpath.Text, False)
        Catch ex As Exception
            MsgBox("Brak dostępu do folderu z danymi!", MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End Try

        If APK13backup.wybr = "" Then
            For i As Byte = 0 To 29 Step 1
                If Not GRexist(plik, "poz" & i) Then
                    gr = "poz" & i
                    Exit For
                End If
            Next
            If gr = "" Then START.bladdanych()
        Else
            For Each i As String In GRarray(plik)
                If POZget(plik, i, "nazwa") = APK13backup.wybr Then
                    gr = i
                    Exit For
                End If
            Next
            If gr = "" Then START.bladdanych()
        End If

        If APK13backup.wybr = "" Then POZmod(plik, gr, "nazwa", txtnazwa.Text)
        POZmod(plik, gr, "path", txtpath.Text)
        POZmod(plik, gr, "hz", listahz.SelectedIndex)
        POZmod(plik, gr, "il", listail.SelectedIndex)
        POZmod(plik, gr, "start", txtexe1.Text)
        POZmod(plik, gr, "koniec", txtexe2.Text)
        Dim temp As String = ""
        If chkboxinfo1.Checked Then temp &= "1" Else temp &= "0"
        If chkboxinfo2.Checked Then temp &= "1" Else temp &= "0"
        If chkboxautoprog1.Checked Then temp &= "1" Else temp &= "0"
        If chkboxautoprog2.Checked Then temp &= "1" Else temp &= "0"
        POZmod(plik, gr, "opcje", temp)
        POZmod(plik, gr, "status", "0")
        updateFILE(START.folderapk, 13, "lista", plik)
        If APK13backup.wybr = "" Then
            existFILE(START.folderapk, 13, "POZ-" & txtnazwa.Text, True)
            If Not openFILE(START.folderapk, 13, "POZ-" & txtnazwa.Text) = "" Then updateFILE(START.folderapk, 13, "POZ-" & txtnazwa.Text, "")
        End If
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnanuluj_Click(sender As Object, e As EventArgs) Handles btnanuluj.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class