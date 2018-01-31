Public Class APK15edycja

    Dim wybrkat As Byte = 0
    Dim nazwykat(6) As String
    Dim imgwybr As PictureBox = New PictureBox()

    Private Sub APK15edycja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico15.GetHicon())
        With imgwybr
            .Location = New Point(5, 5)
            .Size = New Size(10, 10)
            .Image = My.Resources.wybr
            .Cursor = Cursors.Hand
        End With
        lstdatetime.SelectionStart = New Date(APK15kalendarz.lista2.Text, APK15kalendarz.lista1.SelectedIndex + 1, IIf(APK15kalendarz.sel = 0, Now.Day, APK15kalendarz.sel))
        lstcyklicznosc.SelectedIndex = 0
        nrg.Value = Now.Hour
        nrm.Value = Now.Minute
        Dim danekat As String = openFILE(START.folderapk, 15, "kat")
        For i As Byte = 0 To 6 Step 1
            nazwykat(i) = POZget(danekat, "kat" & i, "nazwa")
        Next
        If Not APK15kalendarz.wybr = "" Then
            lbltytul.Text = "Edycja wydarzenia"
            btndodaj.Text = "Zapisz"
            Try
                Dim dane As String = openFILE(START.folderapk, 15, "lista")
                If GRexist(dane, APK15kalendarz.wybr) Then
                    txtnazwa.Text = POZget(dane, APK15kalendarz.wybr, "nazwa")
                    txtopis.Text = POZget(dane, APK15kalendarz.wybr, "opis")
                    Dim temp As String = POZget(dane, APK15kalendarz.wybr, "kat")
                    If IsNumeric(temp) Then
                        If temp >= 0 AndAlso temp < 7 Then
                            wybrkat = temp
                            Select Case temp
                                Case 0
                                    kat0.Controls.Add(imgwybr)
                                Case 1
                                    kat1.Controls.Add(imgwybr)
                                Case 2
                                    kat2.Controls.Add(imgwybr)
                                Case 3
                                    kat3.Controls.Add(imgwybr)
                                Case 4
                                    kat4.Controls.Add(imgwybr)
                                Case 5
                                    kat5.Controls.Add(imgwybr)
                                Case 6
                                    kat6.Controls.Add(imgwybr)
                            End Select
                        Else
                            START.bladdanych()
                        End If
                    Else
                        START.bladdanych()
                    End If
                    lstdatetime.SelectionStart = New Date(POZget(dane, APK15kalendarz.wybr, "rok"), POZget(dane, APK15kalendarz.wybr, "miesiac"), POZget(dane, APK15kalendarz.wybr, "dzien"))
                    temp = POZget(dane, APK15kalendarz.wybr, "calydzien")
                    If temp = "1" Or temp = "0" Then
                        If temp = "1" Then
                            switchcalydzien.Checked = True
                            nrg.Enabled = False
                            nrm.Enabled = False
                        Else
                            switchcalydzien.Checked = False
                            nrg.Enabled = True
                            nrm.Enabled = True
                        End If
                    Else
                        START.bladdanych()
                    End If
                    temp = POZget(dane, APK15kalendarz.wybr, "godz")
                    If IsNumeric(temp) AndAlso temp >= 0 AndAlso temp < 24 Then
                        nrg.Value = temp
                    Else
                        START.bladdanych()
                    End If
                    temp = POZget(dane, APK15kalendarz.wybr, "min")
                    If IsNumeric(temp) AndAlso temp >= 0 AndAlso temp < 60 Then
                        nrm.Value = temp
                    Else
                        START.bladdanych()
                    End If
                    temp = POZget(dane, APK15kalendarz.wybr, "cykl")
                    If IsNumeric(temp) AndAlso temp >= 0 AndAlso temp < 10 Then
                        lstcyklicznosc.SelectedIndex = temp
                    Else
                        START.bladdanych()
                    End If
                End If
            Catch ex As Exception
                START.bladdanych()
            End Try
        Else
            kat0.Controls.Add(imgwybr)
        End If
    End Sub

    Private Sub switchcalydzien_CheckedChanged(sender As Object, e As EventArgs) Handles switchcalydzien.CheckedChanged
        If switchcalydzien.Checked Then
            nrg.Enabled = False
            nrm.Enabled = False
        Else
            nrg.Enabled = True
            nrm.Enabled = True
        End If
    End Sub

    Private Sub kat0_Click(sender As Object, e As EventArgs) Handles kat0.Click, kat1.Click, kat2.Click, kat3.Click, kat4.Click, kat5.Click, kat6.Click
        wybrkat = CInt(sender.Name.Substring(3))
        kat0.Controls.Clear()
        kat1.Controls.Clear()
        kat2.Controls.Clear()
        kat3.Controls.Clear()
        kat4.Controls.Clear()
        kat5.Controls.Clear()
        kat6.Controls.Clear()
        sender.Controls.Add(imgwybr)
    End Sub

    Private Sub kat0_MouseHover(sender As Object, e As EventArgs) Handles kat0.MouseHover, kat1.MouseHover, kat2.MouseHover, kat3.MouseHover, kat4.MouseHover, kat5.MouseHover, kat6.MouseHover
        lblkat.Text = nazwykat(CInt(sender.Name.Substring(3)))
        lblkat.Visible = True
    End Sub

    Private Sub kat0_MouseLeave(sender As Object, e As EventArgs) Handles kat0.MouseLeave, kat1.MouseLeave, kat2.MouseLeave, kat3.MouseLeave, kat4.MouseLeave, kat5.MouseLeave, kat6.MouseLeave
        lblkat.Visible = False
    End Sub

    Private Sub btnanuluj_Click(sender As Object, e As EventArgs) Handles btnanuluj.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btndodaj_Click(sender As Object, e As EventArgs) Handles btndodaj.Click
        If txtnazwa.Text = "" Then
            MsgBox("Nie podano nazwy wydarzenia!", MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End If
        If APK15kalendarz.wybr = "" Then
            Dim dane As String = openFILE(START.folderapk, 15, "lista")
            Dim grupa As String = ""
            For i As Short = 0 To 30000 Step 1
                If Not GRexist(dane, "poz" & i) Then
                    grupa = "poz" & i
                    Exit For
                End If
            Next
            If grupa = "" Then
                MsgBox("Przekroczono maksymalną liczbę pozycji!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            POZmod(dane, grupa, "dzien", lstdatetime.SelectionStart.Day)
            POZmod(dane, grupa, "miesiac", lstdatetime.SelectionStart.Month)
            POZmod(dane, grupa, "rok", lstdatetime.SelectionStart.Year)
            POZmod(dane, grupa, "nazwa", txtnazwa.Text)
            POZmod(dane, grupa, "opis", txtopis.Text)
            POZmod(dane, grupa, "kat", wybrkat)
            POZmod(dane, grupa, "calydzien", IIf(switchcalydzien.Checked, "1", "0"))
            POZmod(dane, grupa, "godz", nrg.Value)
            POZmod(dane, grupa, "min", nrm.Value)
            POZmod(dane, grupa, "cykl", lstcyklicznosc.SelectedIndex)
            updateFILE(START.folderapk, 15, "lista", dane)
        Else
            Dim dane As String = openFILE(START.folderapk, 15, "lista")
            If GRexist(dane, APK15kalendarz.wybr) Then
                Dim grupa As String = APK15kalendarz.wybr
                POZmod(dane, grupa, "dzien", lstdatetime.SelectionStart.Day)
                POZmod(dane, grupa, "miesiac", lstdatetime.SelectionStart.Month)
                POZmod(dane, grupa, "rok", lstdatetime.SelectionStart.Year)
                POZmod(dane, grupa, "nazwa", txtnazwa.Text)
                POZmod(dane, grupa, "opis", txtopis.Text)
                POZmod(dane, grupa, "kat", wybrkat)
                POZmod(dane, grupa, "calydzien", IIf(switchcalydzien.Checked, "1", "0"))
                POZmod(dane, grupa, "godz", nrg.Value)
                POZmod(dane, grupa, "min", nrm.Value)
                POZmod(dane, grupa, "cykl", lstcyklicznosc.SelectedIndex)
                updateFILE(START.folderapk, 15, "lista", dane)
            End If
        End If
        DialogResult = DialogResult.OK
    End Sub
End Class