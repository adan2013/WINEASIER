Imports System.Xml
Public Class APK12waluty

    Const lblconst As String = "Kursy walut z dnia: "

    Dim wal1 As String = ""
    Dim wal2 As String = ""
    Dim p1 As Double = 0
    Dim p2 As Double = 0
    Dim trwakonfiguracja As Boolean = True

    Private Sub APK12waluty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico12.GetHicon())
        START.pobierzparametr(12)
        waluta1.Focus()
        If existFILE(START.folderapk, 12, "konfig", False) Then
            Dim plik As String = openFILE(START.folderapk, 12, "konfig")
            If POZget(plik, "konfig", "updateR") = "" OrElse POZget(plik, "konfig", "updateM") = "" OrElse POZget(plik, "konfig", "updateD") = "" Then

            Else
                lblkurs.Text = lblconst & POZget(plik, "konfig", "updateR") & "-" & POZget(plik, "konfig", "updateM") & "-" & POZget(plik, "konfig", "updateD")
                If Not IO.File.Exists(START.folderapk & "\apk12\LastA.xml") Then
                    lblkurs.Text = lblconst & "Nie pobrano!"
                    POZmod(plik, "konfig", "updateR", "")
                    POZmod(plik, "konfig", "updateM", "")
                    POZmod(plik, "konfig", "updateD", "")
                    updateFILE(START.folderapk, 12, "konfig", plik)
                End If
            End If
            wal1 = POZget(plik, "konfig", "waluta1")
            wal2 = POZget(plik, "konfig", "waluta2")
        Else
            existFILE(START.folderapk, 12, "konfig", True)
            Dim plik As String = ""
            POZmod(plik, "konfig", "waluta1", "")
            POZmod(plik, "konfig", "waluta2", "")
            POZmod(plik, "konfig", "updateR", "")
            POZmod(plik, "konfig", "updateM", "")
            POZmod(plik, "konfig", "updateD", "")
            updateFILE(START.folderapk, 12, "konfig", plik)
        End If
        loadlist()
        obliczP(True)
        obliczP(False)
    End Sub

    Private Sub loadlist()
        trwakonfiguracja = True
        p1 = 0
        p2 = 0
        listawaluta1.Items.Clear()
        listawaluta2.Items.Clear()
        listawaluta1.Items.Add("PLN - złoty (Polska)")
        listawaluta2.Items.Add("PLN - złoty (Polska)")
        listawaluta1.SelectedIndex = 0
        listawaluta2.SelectedIndex = 0
        If IO.File.Exists(START.folderapk & "\apk12\LastA.xml") Then
            Dim xml As XmlTextReader = New XmlTextReader(START.folderapk & "\apk12\LastA.xml")
            Dim nazwa As String = ""
            Dim kod As String = ""
            Dim POZnazwa As Boolean = False
            Dim POZkod As Boolean = False
            Do While xml.Read()
                If xml.NodeType = XmlNodeType.Element AndAlso xml.Name = "pozycja" Then
                    nazwa = ""
                    kod = ""
                End If
                If POZnazwa Then
                    POZnazwa = False
                    If xml.NodeType = XmlNodeType.Text Then nazwa = xml.Value
                End If
                If POZkod Then
                    POZkod = False
                    If xml.NodeType = XmlNodeType.Text Then kod = xml.Value
                End If
                If xml.NodeType = XmlNodeType.Element AndAlso xml.Name = "nazwa_waluty" Then POZnazwa = True
                If xml.NodeType = XmlNodeType.Element AndAlso xml.Name = "kod_waluty" Then POZkod = True
                If xml.NodeType = XmlNodeType.EndElement AndAlso xml.Name = "pozycja" Then
                    listawaluta1.Items.Add(kod & " - " & nazwa)
                    listawaluta2.Items.Add(kod & " - " & nazwa)
                End If
            Loop
            xml.Dispose()
            For i As Byte = 0 To listawaluta1.Items.Count - 1 Step 1
                If listawaluta1.Items(i).substring(0, listawaluta1.Items(i).indexof(" ")) = wal1 Then
                    listawaluta1.SelectedIndex = i
                    Exit For
                End If
            Next
            For i As Byte = 0 To listawaluta2.Items.Count - 1 Step 1
                If listawaluta2.Items(i).substring(0, listawaluta2.Items(i).indexof(" ")) = wal2 Then
                    listawaluta2.SelectedIndex = i
                    Exit For
                End If
            Next
        End If
        trwakonfiguracja = False
    End Sub

    Private Sub btnzaktualizuj_Click(sender As Object, e As EventArgs) Handles btnzaktualizuj.Click
        APK12pobieranie.ShowDialog()
        If APK12pobieranie.DialogResult = DialogResult.OK Then
            Dim plik As String = openFILE(START.folderapk, 12, "konfig")
            lblkurs.Text = lblconst & POZget(plik, "konfig", "updateR") & "-" & POZget(plik, "konfig", "updateM") & "-" & POZget(plik, "konfig", "updateD")
            loadlist()
            obliczP(True)
            obliczP(False)
            przelicz()
        End If
        APK12pobieranie.Close()
    End Sub

    Private Sub waluta1_TextChanged(sender As Object, e As EventArgs) Handles waluta1.TextChanged
        przelicz()
    End Sub

    Private Sub listawaluta1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listawaluta1.SelectedIndexChanged
        If trwakonfiguracja Then Exit Sub
        wal1 = listawaluta1.Text.Substring(0, listawaluta1.Text.IndexOf(" "))
        obliczP(True)
        przelicz()
        zapiszwaluty()
    End Sub

    Private Sub listawaluta2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listawaluta2.SelectedIndexChanged
        If trwakonfiguracja Then Exit Sub
        wal2 = listawaluta2.Text.Substring(0, listawaluta2.Text.IndexOf(" "))
        obliczP(False)
        przelicz()
        zapiszwaluty()
    End Sub

    Private Sub obliczP(ByVal pierwszy As Boolean)
        Dim wal As String = ""
        If pierwszy Then
            p1 = 0
            wal = listawaluta1.Text.Substring(0, listawaluta1.Text.IndexOf(" "))
            If wal = "PLN" Then Exit Sub
        Else
            p2 = 0
            wal = listawaluta2.Text.Substring(0, listawaluta2.Text.IndexOf(" "))
            If wal = "PLN" Then Exit Sub
        End If

        If IO.File.Exists(START.folderapk & "\apk12\LastA.xml") Then
            Dim xml As XmlTextReader = New XmlTextReader(START.folderapk & "\apk12\LastA.xml")
            Dim xmlP As String = ""
            Dim xmlKS As String = ""
            Dim xmlkod As String = ""
            Dim POZp As Boolean = False
            Dim POZks As Boolean = False
            Dim POZkod As Boolean = False
            Do While xml.Read()
                If xml.NodeType = XmlNodeType.Element AndAlso xml.Name = "pozycja" Then
                    xmlP = ""
                    xmlKS = ""
                    xmlkod = ""
                End If
                If POZp Then
                    POZp = False
                    If xml.NodeType = XmlNodeType.Text Then xmlP = xml.Value
                End If
                If POZks Then
                    POZks = False
                    If xml.NodeType = XmlNodeType.Text Then xmlKS = xml.Value
                End If
                If POZkod Then
                    POZkod = False
                    If xml.NodeType = XmlNodeType.Text Then xmlkod = xml.Value
                End If
                If xml.NodeType = XmlNodeType.Element AndAlso xml.Name = "przelicznik" Then POZp = True
                If xml.NodeType = XmlNodeType.Element AndAlso xml.Name = "kurs_sredni" Then POZks = True
                If xml.NodeType = XmlNodeType.Element AndAlso xml.Name = "kod_waluty" Then POZkod = True
                If xml.NodeType = XmlNodeType.EndElement AndAlso xml.Name = "pozycja" Then
                    If xmlkod = wal Then
                        If pierwszy Then p1 = Convert.ToDouble(xmlKS) / CInt(xmlP) Else p2 = Convert.ToDouble(xmlKS) / CInt(xmlP)
                        Exit Do
                    End If
                End If
            Loop
            xml.Dispose()
        End If
    End Sub

    Private Sub btnzamien_Click(sender As Object, e As EventArgs) Handles btnzamien.Click
        trwakonfiguracja = True
        Dim prep As Double = p1
        Dim indexrep As Byte = listawaluta1.SelectedIndex
        p1 = p2
        listawaluta1.SelectedIndex = listawaluta2.SelectedIndex
        p2 = prep
        listawaluta2.SelectedIndex = indexrep
        zapiszwaluty()
        trwakonfiguracja = False
        przelicz()
    End Sub

    Private Sub zapiszwaluty()
        Dim plik As String = openFILE(START.folderapk, 12, "konfig")
        POZmod(plik, "konfig", "waluta1", listawaluta1.Text.Substring(0, listawaluta1.Text.IndexOf(" ")))
        POZmod(plik, "konfig", "waluta2", listawaluta2.Text.Substring(0, listawaluta2.Text.IndexOf(" ")))
        updateFILE(START.folderapk, 12, "konfig", plik)
    End Sub

    Private Sub przelicz()
        If IsNumeric(waluta1.Text) Then
            Dim posr As Double = 0
            If p1 = 0 Then
                posr = waluta1.Text
                waluta3.Text = waluta1.Text & " PLN"
            Else
                posr = waluta1.Text * p1
                waluta3.Text = Math.Round(posr, 2) & " PLN"
            End If
            If p2 = 0 Then
                waluta2.Text = Math.Round(posr, 2)
            Else
                waluta2.Text = Math.Round(posr / p2, 2)
            End If
        Else
            waluta2.Text = "0"
            waluta3.Text = "0 PLN"
        End If
    End Sub
End Class