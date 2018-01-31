Public Class APK15kategorie

    Private Sub APK15kategorie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico15.GetHicon())
        Dim dane As String = openFILE(START.folderapk, 15, "kat")
        txt0.Text = POZget(dane, "kat0", "nazwa")
        txt1.Text = POZget(dane, "kat1", "nazwa")
        txt2.Text = POZget(dane, "kat2", "nazwa")
        txt3.Text = POZget(dane, "kat3", "nazwa")
        txt4.Text = POZget(dane, "kat4", "nazwa")
        txt5.Text = POZget(dane, "kat5", "nazwa")
        txt6.Text = POZget(dane, "kat6", "nazwa")
        Dim temp As String = ""
        temp = POZget(dane, "kat0", "alarm")
        If temp = "" Then
            pow0.SelectedIndex = 0
        Else
            If IsNumeric(temp) AndAlso temp >= 0 AndAlso temp < 9 Then
                pow0.SelectedIndex = temp + 1
            Else
                START.bladdanych()
            End If
        End If
        temp = POZget(dane, "kat1", "alarm")
        If temp = "" Then
            pow1.SelectedIndex = 0
        Else
            If IsNumeric(temp) AndAlso temp >= 0 AndAlso temp < 9 Then
                pow1.SelectedIndex = temp + 1
            Else
                START.bladdanych()
            End If
        End If
        temp = POZget(dane, "kat2", "alarm")
        If temp = "" Then
            pow2.SelectedIndex = 0
        Else
            If IsNumeric(temp) AndAlso temp >= 0 AndAlso temp < 9 Then
                pow2.SelectedIndex = temp + 1
            Else
                START.bladdanych()
            End If
        End If
        temp = POZget(dane, "kat3", "alarm")
        If temp = "" Then
            pow3.SelectedIndex = 0
        Else
            If IsNumeric(temp) AndAlso temp >= 0 AndAlso temp < 9 Then
                pow3.SelectedIndex = temp + 1
            Else
                START.bladdanych()
            End If
        End If
        temp = POZget(dane, "kat4", "alarm")
        If temp = "" Then
            pow4.SelectedIndex = 0
        Else
            If IsNumeric(temp) AndAlso temp >= 0 AndAlso temp < 9 Then
                pow4.SelectedIndex = temp + 1
            Else
                START.bladdanych()
            End If
        End If
        temp = POZget(dane, "kat5", "alarm")
        If temp = "" Then
            pow5.SelectedIndex = 0
        Else
            If IsNumeric(temp) AndAlso temp >= 0 AndAlso temp < 9 Then
                pow5.SelectedIndex = temp + 1
            Else
                START.bladdanych()
            End If
        End If
        temp = POZget(dane, "kat6", "alarm")
        If temp = "" Then
            pow6.SelectedIndex = 0
        Else
            If IsNumeric(temp) AndAlso temp >= 0 AndAlso temp < 9 Then
                pow6.SelectedIndex = temp + 1
            Else
                START.bladdanych()
            End If
        End If
    End Sub

    Private Sub btnzamknij_Click(sender As Object, e As EventArgs) Handles btnzamknij.Click
        Dim dane As String = openFILE(START.folderapk, 15, "kat")
        POZmod(dane, "kat0", "nazwa", txt0.Text)
        POZmod(dane, "kat1", "nazwa", txt1.Text)
        POZmod(dane, "kat2", "nazwa", txt2.Text)
        POZmod(dane, "kat3", "nazwa", txt3.Text)
        POZmod(dane, "kat4", "nazwa", txt4.Text)
        POZmod(dane, "kat5", "nazwa", txt5.Text)
        POZmod(dane, "kat6", "nazwa", txt6.Text)
        POZmod(dane, "kat0", "alarm", IIf(pow0.SelectedIndex = 0, "", pow0.SelectedIndex - 1))
        POZmod(dane, "kat1", "alarm", IIf(pow1.SelectedIndex = 0, "", pow1.SelectedIndex - 1))
        POZmod(dane, "kat2", "alarm", IIf(pow2.SelectedIndex = 0, "", pow2.SelectedIndex - 1))
        POZmod(dane, "kat3", "alarm", IIf(pow3.SelectedIndex = 0, "", pow3.SelectedIndex - 1))
        POZmod(dane, "kat4", "alarm", IIf(pow4.SelectedIndex = 0, "", pow4.SelectedIndex - 1))
        POZmod(dane, "kat5", "alarm", IIf(pow5.SelectedIndex = 0, "", pow5.SelectedIndex - 1))
        POZmod(dane, "kat6", "alarm", IIf(pow6.SelectedIndex = 0, "", pow6.SelectedIndex - 1))
        updateFILE(START.folderapk, 15, "kat", dane)
        DialogResult = DialogResult.OK
    End Sub
End Class