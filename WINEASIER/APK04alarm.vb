Public Class APK04alarm

    Public wybrany As SByte = -1
    Dim lp As Byte = 0
    Dim panelzlista As Panel = New Panel()

    Private Sub APK04alarm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico4.GetHicon())
        START.pobierzparametr(4)
        With panelzlista
            .Location = New Point(0, 0)
            .Size = New Size(528, 500)
        End With
        existFILE(START.folderapk, 4, "lista", True)
        aktualizujliste()
    End Sub

    Public Sub aktualizujliste(Optional ByVal analizazdarzen As Boolean = True)
        lp = 0
        listaalarmow.Controls.Clear()
        panelzlista.Controls.Clear()
        Dim dane As String = openFILE(START.folderapk, 4, "lista")
        If dane = "" Then
            Dim lblinfo As Label = New Label()
            With lblinfo
                .Location = New Point(0, 10)
                .Size = New Size(528, 20)
                .Font = New Font("Segoe UI", 10)
                .TextAlign = ContentAlignment.MiddleCenter
                .ForeColor = Color.LightGray
                .Text = "Brak alarmów"
            End With
            listaalarmow.Controls.Add(lblinfo)
        Else
            For Each i As String In GRarray(dane)
                If Not i = "" Then
                    Dim panel As Panel = New Panel()
                    Dim godzina As Label = New Label()
                    Dim opis As MetroFramework.Controls.MetroLabel = New MetroFramework.Controls.MetroLabel()
                    Dim dni As MetroFramework.Controls.MetroLabel = New MetroFramework.Controls.MetroLabel()
                    Dim btnpwr As MetroFramework.Controls.MetroLink = New MetroFramework.Controls.MetroLink
                    Dim btnedycja As MetroFramework.Controls.MetroLink = New MetroFramework.Controls.MetroLink
                    Dim btnusun As MetroFramework.Controls.MetroLink = New MetroFramework.Controls.MetroLink
                    With panel
                        .Location = New Point(0, 50 * lp)
                        .Size = New Size(528, 50)
                    End With
                    With godzina
                        .Location = New Point(0, 0)
                        .Size = New Size(120, 50)
                        .Font = New Font("Segoe UI", 26)
                        .TextAlign = ContentAlignment.MiddleCenter
                        .Text = IIf(POZget(dane, i, "godz") < 10, "0" & POZget(dane, i, "godz"), POZget(dane, i, "godz")) & ":" & IIf(POZget(dane, i, "min") < 10, "0" & POZget(dane, i, "min"), POZget(dane, i, "min"))
                    End With
                    With opis
                        .Location = New Point(120, 10)
                        .Size = New Size(180, 20)
                        .Font = New Font("Segoe UI", 12)
                        .TextAlign = ContentAlignment.MiddleLeft
                        .Text = IIf(POZget(dane, i, "opis") = "", "Brak opisu", POZget(dane, i, "opis"))
                        .FontWeight = MetroFramework.MetroLabelWeight.Bold
                    End With
                    With dni
                        .Location = New Point(120, 30)
                        .Size = New Size(180, 20)
                        .Font = New Font("Segoe UI", 12)
                        .TextAlign = ContentAlignment.MiddleLeft
                        Dim listadni As String = POZget(dane, i, "dzien")
                        Dim tempdni As String = ""
                        If listadni.Substring(0, 1) = 1 Then tempdni &= "Pn, "
                        If listadni.Substring(1, 1) = 1 Then tempdni &= "Wt, "
                        If listadni.Substring(2, 1) = 1 Then tempdni &= "Śr, "
                        If listadni.Substring(3, 1) = 1 Then tempdni &= "Czw, "
                        If listadni.Substring(4, 1) = 1 Then tempdni &= "Pt, "
                        If listadni.Substring(5, 1) = 1 Then tempdni &= "So, "
                        If listadni.Substring(6, 1) = 1 Then tempdni &= "Nd, "
                        If tempdni = "" Then
                            tempdni = "Alarm jednorazowy"
                        Else
                            tempdni = tempdni.Substring(0, tempdni.Length - 2)
                            If tempdni = "Pn, Wt, Śr, Czw, Pt" Then tempdni = "Dni robocze"
                            If tempdni = "Pn, Wt, Śr, Czw, Pt, So, Nd" Then tempdni = "Codziennie"
                        End If
                        .Text = tempdni
                    End With
                    With btnpwr
                        .Name = "pwr" & lp
                        .Location = New Point(300, 10)
                        .Size = New Size(90, 30)
                        .Text = IIf(POZget(dane, i, "pwr") = 1, "Wyłącz", "Włącz")
                        .Cursor = Cursors.Hand
                    End With
                    With btnedycja
                        .Name = "edycja" & lp
                        .Location = New Point(390, 10)
                        .Size = New Size(70, 30)
                        .Text = "Edycja"
                        .Cursor = Cursors.Hand
                    End With
                    With btnusun
                        .Name = "usun" & lp
                        .Location = New Point(460, 10)
                        .Size = New Size(70, 30)
                        .Text = "Usuń"
                        .Cursor = Cursors.Hand
                    End With
                    AddHandler btnpwr.Click, AddressOf pwrswitch
                    AddHandler btnedycja.Click, AddressOf edycja
                    AddHandler btnusun.Click, AddressOf usuwanie
                    panel.Controls.Add(godzina)
                    panel.Controls.Add(opis)
                    panel.Controls.Add(dni)
                    panel.Controls.Add(btnpwr)
                    panel.Controls.Add(btnedycja)
                    panel.Controls.Add(btnusun)

                    panelzlista.Controls.Add(panel)
                    lp += 1
                Else
                    Exit For
                End If
            Next
            listaalarmow.Controls.Add(panelzlista)
        End If
        lblilosc.Text = lp & "/10"
        lblup.Visible = False
        lbldn.Visible = False
        If panelzlista.Location.Y < 0 Then lblup.Visible = True
        If panelzlista.Location.Y > -(lp - 3) * 50 Then lbldn.Visible = True
        If analizazdarzen Then START.zarzadzajzdarzeniami()
    End Sub

    Private Sub usuwanie(sender As Object, e As EventArgs)
        Dim dane As String = openFILE(START.folderapk, 4, "lista")
        GRdel(dane, "poz" & sender.Name.Substring(sender.Name.Length - 1))
        updateFILE(START.folderapk, 4, "lista", dane)
        aktualizujliste()
    End Sub

    Private Sub edycja(sender As Object, e As EventArgs)
        wybrany = sender.Name.Substring(sender.Name.Length - 1)
        APK04nowyalarm.ShowDialog()
        If APK04nowyalarm.DialogResult = DialogResult.OK Then aktualizujliste()
        APK04nowyalarm.Close()
    End Sub

    Private Sub pwrswitch(sender As Object, e As EventArgs)
        Dim dane As String = openFILE(START.folderapk, 4, "lista")
        If sender.Text = "Włącz" Then
            POZmod(dane, "poz" & sender.Name.Substring(sender.Name.Length - 1), "pwr", "1")
        Else
            POZmod(dane, "poz" & sender.Name.Substring(sender.Name.Length - 1), "pwr", "0")
        End If
        updateFILE(START.folderapk, 4, "lista", dane)
        aktualizujliste()
    End Sub

    Private Sub btnwylaczwszystkie_Click(sender As Object, e As EventArgs) Handles btnwylaczwszystkie.Click
        If Not MsgBox("Wyłączyć wszystkie alarmy?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then Exit Sub
        Dim dane As String = openFILE(START.folderapk, 4, "lista")
        dane = dane.Replace(">pwr=1", ">pwr=0")
        updateFILE(START.folderapk, 4, "lista", dane)
        aktualizujliste()
    End Sub

    Private Sub btnusunwszystkie_Click(sender As Object, e As EventArgs) Handles btnusunwszystkie.Click
        If Not MsgBox("Usunąć wszystkie alarmy?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then Exit Sub
        updateFILE(START.folderapk, 4, "lista", "")
        aktualizujliste()
    End Sub

    Private Sub btnnowyalarm_Click(sender As Object, e As EventArgs) Handles btnnowyalarm.Click
        If lp >= 10 Then
            MsgBox("Osiągnięto maksymalną ilość alarmów!", MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End If
        wybrany = -1
        APK04nowyalarm.ShowDialog()
        If APK04nowyalarm.DialogResult = DialogResult.OK Then aktualizujliste()
        APK04nowyalarm.Close()
    End Sub

    Private Sub APK04alarm_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            If panelzlista.Location.Y < 0 Then
                panelzlista.Location = New Point(panelzlista.Location.X, panelzlista.Location.Y + 25)
            End If
        Else
            If panelzlista.Location.Y > -(lp - 3) * 50 Then
                panelzlista.Location = New Point(panelzlista.Location.X, panelzlista.Location.Y - 25)
            End If
        End If
        lblup.Visible = False
        lbldn.Visible = False
        If panelzlista.Location.Y < 0 Then lblup.Visible = True
        If panelzlista.Location.Y > -(lp - 3) * 50 Then lbldn.Visible = True
    End Sub

    Private Sub lblup_Click(sender As Object, e As EventArgs) Handles lblup.Click
        If panelzlista.Location.Y < 0 Then
            panelzlista.Location = New Point(panelzlista.Location.X, panelzlista.Location.Y + 25)
            lblup.Visible = False
            lbldn.Visible = False
            If panelzlista.Location.Y < 0 Then lblup.Visible = True
            If panelzlista.Location.Y > -(lp - 3) * 50 Then lbldn.Visible = True
        End If
    End Sub

    Private Sub lbldn_Click(sender As Object, e As EventArgs) Handles lbldn.Click
        If panelzlista.Location.Y > -(lp - 3) * 50 Then
            panelzlista.Location = New Point(panelzlista.Location.X, panelzlista.Location.Y - 25)
            lblup.Visible = False
            lbldn.Visible = False
            If panelzlista.Location.Y < 0 Then lblup.Visible = True
            If panelzlista.Location.Y > -(lp - 3) * 50 Then lbldn.Visible = True
        End If
    End Sub
End Class