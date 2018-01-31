Imports MetroFramework.Controls
Public Class menuform

    Public ruchformy As Boolean = False
    Dim docelowe(0) As String
    Dim docelowe2(5) As String

    Dim panelwew As Panel = New Panel()
    Dim panelzew As Panel = New Panel()

    Private Sub menuform_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim konfigmenu As String = START.konfiguracjamenu
        Dim konfigmenu2 As String = START.konfiguracjamenu2
        If konfigmenu = "" Then
            Dim lblbrakpoz As Label = New Label()
            With lblbrakpoz
                .Location = New Point(0, 100)
                .Size = New Size(300, 50)
                .Font = New Font("Microsoft Sans Serif", 10)
                .ForeColor = Color.DarkGray
                .TextAlign = ContentAlignment.MiddleCenter
                .Text = "Brak pozycji w menu"
            End With
            Controls.Add(lblbrakpoz)
        Else
            Dim pozwsp As Point = New Point(0, 0)
            Dim lp As Byte = 0
            Dim GRpoz() As String = GRarray(konfigmenu)
            With panelwew
                .Location = New Point(0, 0)
                .Size = New Size(300, 40 * GRpoz.Length)
            End With
            With panelzew
                .Location = New Point(0, 100)
                .Size = New Size(300, Screen.PrimaryScreen.Bounds.Height - 220)
            End With
            For Each foreach As String In GRpoz
                ReDim Preserve docelowe(lp)
                Dim partemp As String = POZget(konfigmenu, foreach, "par")
                Dim celtemp As String = POZget(konfigmenu, foreach, "cel")
                docelowe(lp) = celtemp & partemp
                Dim panel As Panel = New Panel()
                Dim lbl As Label = New Label()
                Dim pic As PictureBox = New PictureBox()
                With panel
                    .Name = "panel%" & lp
                    .Location = pozwsp
                    .Size = New Size(300, 40)
                    .BackColor = Color.Transparent
                    .Cursor = Cursors.Hand
                End With
                With pic
                    .Parent = panel
                    .Name = "pic%" & lp
                    .Location = New Point(24, 4)
                    .Size = New Size(32, 32)
                    Dim tempimg As String = POZget(konfigmenu, foreach, "ikona")
                    If tempimg = "" Then
                        If celtemp = 1 Then
                            If partemp.IndexOf("%") < 0 Then
                                .Image = START.grafikaaplikacji(partemp)
                            Else
                                .Image = START.grafikaaplikacji(partemp.Substring(0, partemp.IndexOf("%")))
                            End If
                        Else
                            If partemp.IndexOf("%") < 0 Then
                                If IO.File.Exists(partemp) Then
                                    .Image = Icon.ExtractAssociatedIcon(partemp).ToBitmap()
                                Else
                                    .Image = My.Resources.logocien
                                End If
                            Else
                                If IO.File.Exists(partemp.Substring(0, partemp.IndexOf("%"))) Then
                                    .Image = Icon.ExtractAssociatedIcon(partemp.Substring(0, partemp.IndexOf("%"))).ToBitmap()
                                Else
                                    .Image = My.Resources.logocien
                                End If
                            End If
                        End If
                    Else
                        If IO.File.Exists(tempimg) Then
                            .Image = New Bitmap(tempimg)
                        Else
                            .Image = My.Resources.logocien
                        End If
                    End If
                    .SizeMode = PictureBoxSizeMode.StretchImage
                End With
                With lbl
                    .Parent = panel
                    .Name = "lbl%" & lp
                    .Location = New Point(70, 0)
                    .Size = New Size(230, 40)
                    .Font = New Font("Segoe UI", 12)
                    .ForeColor = Color.Black
                    .TextAlign = ContentAlignment.MiddleLeft
                    .Text = POZget(konfigmenu, foreach, "nazwa")
                End With
                panel.Controls.Add(pic)
                panel.Controls.Add(lbl)
                panelwew.Controls.Add(panel)
                AddHandler panel.MouseMove, AddressOf podswietlpoz
                AddHandler panel.MouseLeave, AddressOf zgaspoz
                AddHandler lbl.MouseMove, AddressOf parentpodswietlpoz
                AddHandler lbl.MouseLeave, AddressOf parentzgaspoz
                AddHandler pic.MouseMove, AddressOf parentpodswietlpoz
                AddHandler pic.MouseLeave, AddressOf parentzgaspoz
                AddHandler panel.Click, AddressOf klikpoz
                AddHandler pic.Click, AddressOf klikpoz
                AddHandler lbl.Click, AddressOf klikpoz
                lp += 1
                pozwsp = New Point(pozwsp.X, pozwsp.Y + 40)
            Next
            panelzew.Controls.Add(panelwew)
            Controls.Add(panelzew)
        End If
        If konfigmenu2 <> "" Then
            For i As Byte = 0 To 5 Step 1
                If GRexist(konfigmenu2, "poz" & i) Then
                    Dim danepoz(2) As String
                    danepoz(0) = POZget(konfigmenu2, "poz" & i, "ikona")
                    danepoz(1) = POZget(konfigmenu2, "poz" & i, "cel")
                    danepoz(2) = POZget(konfigmenu2, "poz" & i, "par")
                    docelowe2(i) = danepoz(1) & danepoz(2)
                    Dim panel As Panel = New Panel()
                    Dim obraz As PictureBox = New PictureBox()
                    With panel
                        .Name = "pozycja" & i
                        .Location = New Point(50 * i, Screen.PrimaryScreen.Bounds.Height - 100)
                        .Size = New Size(50, 50)
                        .Cursor = Cursors.Hand
                    End With
                    With obraz
                        .Name = "pozycja" & i
                        .Location = New Point(9, 9)
                        .Size = New Size(32, 32)
                        If danepoz(0) = "" Then
                            If danepoz(1) = 1 Then
                                If danepoz(2).IndexOf("%") < 0 Then
                                    .Image = START.grafikaaplikacji(danepoz(2))
                                Else
                                    .Image = START.grafikaaplikacji(danepoz(2).Substring(0, danepoz(2).IndexOf("%")))
                                End If
                            Else
                                If danepoz(2).IndexOf("%") < 0 Then
                                    If IO.File.Exists(danepoz(2)) Then
                                        .Image = Icon.ExtractAssociatedIcon(danepoz(2)).ToBitmap()
                                    Else
                                        .Image = My.Resources.logocien
                                    End If
                                Else
                                    If IO.File.Exists(danepoz(2).Substring(0, danepoz(2).IndexOf("%"))) Then
                                        .Image = Icon.ExtractAssociatedIcon(danepoz(2).Substring(0, danepoz(2).IndexOf("%"))).ToBitmap()
                                    Else
                                        .Image = My.Resources.logocien
                                    End If
                                End If
                            End If
                        Else
                            If IO.File.Exists(danepoz(0)) Then
                                .Image = New Bitmap(danepoz(0))
                            Else
                                .Image = My.Resources.logocien
                            End If
                        End If
                        .SizeMode = PictureBoxSizeMode.StretchImage
                        .Cursor = Cursors.Hand
                    End With
                    panel.Controls.Add(obraz)
                    Controls.Add(panel)
                    AddHandler panel.MouseMove, AddressOf podswietlpoz
                    AddHandler panel.MouseLeave, AddressOf zgaspoz
                    AddHandler obraz.MouseMove, AddressOf parentpodswietlpoz
                    AddHandler obraz.MouseLeave, AddressOf parentzgaspoz
                    AddHandler panel.Click, AddressOf klikpoz2
                    AddHandler obraz.Click, AddressOf klikpoz2
                End If
            Next
        End If
        For i As Byte = 0 To 2 Step 1
            Dim panel As Panel = New Panel
            Dim pic As PictureBox = New PictureBox
            Dim tekst As Label = New Label
            With panel
                .Name = "menu" & i
                If i = 0 Then .Location = New Point(0, Screen.PrimaryScreen.Bounds.Height - 50)
                If i = 1 Then .Location = New Point(200, Screen.PrimaryScreen.Bounds.Height - 50)
                If i = 2 Then .Location = New Point(250, Screen.PrimaryScreen.Bounds.Height - 50)
                If i = 0 Then .Size = New Size(200, 50)
                If i = 1 Or i = 2 Then .Size = New Size(50, 50)
                .Cursor = Cursors.Hand
            End With
            With pic
                .Name = "menu" & i
                .Location = New Point(9, 9)
                .Size = New Size(32, 32)
                .Cursor = Cursors.Hand
                .SizeMode = PictureBoxSizeMode.CenterImage
            End With
            Select Case i
                Case 0
                    pic.Image = My.Resources.appall
                Case 1
                    pic.Image = My.Resources.notif
                Case 2
                    pic.Image = My.Resources.settings
            End Select
            If i = 0 Then
                With tekst
                    .Name = "menu" & i
                    .ForeColor = Color.Black
                    .Font = New Font("Segoe UI", 10)
                    .Text = "Wszystkie aplikacje"
                    .Location = New Point(50, 0)
                    .Size = New Size(150, 50)
                    .Cursor = Cursors.Hand
                    .TextAlign = ContentAlignment.MiddleLeft
                End With
            End If
            panel.Controls.Add(pic)
            If i = 0 Then panel.Controls.Add(tekst)
            Controls.Add(panel)
            AddHandler panel.MouseMove, AddressOf podswietlpoz
            AddHandler panel.MouseLeave, AddressOf zgaspoz
            AddHandler panel.Click, AddressOf klikpoz3
            AddHandler pic.MouseMove, AddressOf parentpodswietlpoz
            AddHandler pic.MouseLeave, AddressOf parentzgaspoz
            AddHandler pic.Click, AddressOf klikpoz3
            If i = 0 Then
                AddHandler tekst.MouseMove, AddressOf parentpodswietlpoz
                AddHandler tekst.MouseLeave, AddressOf parentzgaspoz
                AddHandler tekst.Click, AddressOf klikpoz3
            End If
        Next
        ruch.Enabled = True
    End Sub

    Private Sub klikpoz3(sender As Object, e As EventArgs)
        Select Case sender.Name.SubString(sender.Name.Length - 1)
            Case 0
                aplikacje.Show()
            Case 1
                listapowiadomien.Show()
            Case 2
                ustawienia.Show()
        End Select
    End Sub

    Private Sub klikpoz2(sender As Object, e As EventArgs)
        Try
            Dim dane As String = docelowe2(sender.Name.SubString(sender.Name.Length - 1))
            Select Case dane.Substring(0, 1)
                Case 1
                    Dim tempstr As String = dane.Substring(1)
                    If tempstr.IndexOf("%") < 0 Then
                        If START.obiektaplikacji(tempstr).Visible Then
                            START.obiektaplikacji(tempstr).Activate()
                        Else
                            START.obiektaplikacji(tempstr).Show()
                        End If
                    Else
                        START.dodajparametr(tempstr.Substring(0, tempstr.IndexOf("%")), tempstr.Substring(tempstr.IndexOf("%") + 1))
                        If START.obiektaplikacji(tempstr.Substring(0, tempstr.IndexOf("%"))).Visible Then
                            START.obiektaplikacji(tempstr.Substring(0, tempstr.IndexOf("%"))).Activate()
                        Else
                            START.obiektaplikacji(tempstr.Substring(0, tempstr.IndexOf("%"))).Show()
                        End If
                    End If
                Case 2
                    Dim tempstr As String = dane.Substring(1)
                    If tempstr.IndexOf("%") < 0 Then
                        Process.Start(tempstr)
                    Else
                        Process.Start(tempstr.Substring(0, tempstr.IndexOf("%")), tempstr.Substring(tempstr.IndexOf("%") + 1))
                    End If
            End Select
        Catch ex As Exception
            MsgBox("Wystąpił błąd podczas otwierania pozycji!" & vbNewLine & "Prawdopodobnie lokalizacja docelowa już nie istnieje", MsgBoxStyle.Exclamation, "WINEASIER")
        End Try
    End Sub

    Private Sub klikpoz(sender As Object, e As EventArgs)
        Try
            Select Case docelowe(sender.Name.Substring(sender.name.indexof("%") + 1)).Substring(0, 1)
                Case 1 'uruchom aplikacje WINEASIER
                    Dim tempstr As String = docelowe(sender.Name.Substring(sender.name.indexof("%") + 1)).Substring(1)
                    If tempstr.IndexOf("%") < 0 Then
                        If START.obiektaplikacji(tempstr).Visible Then
                            START.obiektaplikacji(tempstr).Activate()
                        Else
                            START.obiektaplikacji(tempstr).Show()
                        End If
                    Else
                        START.dodajparametr(tempstr.Substring(0, tempstr.IndexOf("%")), tempstr.Substring(tempstr.IndexOf("%") + 1))
                        If START.obiektaplikacji(tempstr.Substring(0, tempstr.IndexOf("%"))).Visible Then
                            START.obiektaplikacji(tempstr.Substring(0, tempstr.IndexOf("%"))).Activate()
                        Else
                            START.obiektaplikacji(tempstr.Substring(0, tempstr.IndexOf("%"))).Show()
                        End If
                    End If
                Case 2 'uruchom aplikacje z komputera
                    Dim tempstr As String = docelowe(sender.Name.Substring(sender.name.indexof("%") + 1)).Substring(1)
                    If tempstr.IndexOf("%") < 0 Then
                        Process.Start(tempstr)
                    Else
                        Process.Start(tempstr.Substring(0, tempstr.IndexOf("%")), tempstr.Substring(tempstr.IndexOf("%") + 1))
                    End If
            End Select
        Catch ex As Exception
            MsgBox("Wystąpił błąd podczas otwierania pozycji!" & vbNewLine & "Prawdopodobnie lokalizacja docelowa już nie istnieje", MsgBoxStyle.Exclamation, "WINEASIER")
        End Try
    End Sub

    Private Sub parentzgaspoz(sender As Object, e As EventArgs)
        sender.parent.BackColor = Color.Transparent
    End Sub

    Private Sub parentpodswietlpoz(sender As Object, e As MouseEventArgs)
        sender.parent.BackColor = Color.LightGray
    End Sub

    Private Sub zgaspoz(sender As Object, e As EventArgs)
        sender.BackColor = Color.Transparent
    End Sub

    Private Sub podswietlpoz(sender As Object, e As MouseEventArgs)
        sender.BackColor = Color.LightGray
    End Sub

    Private Sub menuform_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        If Not ruch.Enabled Then ruch.Enabled = True
    End Sub

    Private Sub ruch_Tick(sender As Object, e As EventArgs) Handles ruch.Tick
        Select Case START.wywolywaczPOZ
            Case 1, 4, 0
                If ruchformy Then
                    Location = New Point(Location.X - 50, 0)
                    If Location.X <= -300 Then
                        Location = New Point(-300, 0)
                        ruch.Enabled = False
                        ruchformy = False
                        Hide()
                        panelwew.Location = New Point(0, 0)
                    End If
                Else
                    Location = New Point(Location.X + 50, 0)
                    If Location.X = 0 Then
                        ruchformy = True
                        ruch.Enabled = False
                    End If
                End If
            Case 2, 3
                If ruchformy Then
                    Location = New Point(Location.X + 50, 0)
                    If Location.X >= Screen.PrimaryScreen.Bounds.Width Then
                        Location = New Point(Screen.PrimaryScreen.Bounds.Width, 0)
                        ruch.Enabled = False
                        ruchformy = False
                        Hide()
                        panelwew.Location = New Point(0, 0)
                    End If
                Else
                    Location = New Point(Location.X - 50, 0)
                    If Location.X = Screen.PrimaryScreen.Bounds.Width - 300 Then
                        ruchformy = True
                        ruch.Enabled = False
                    End If
                End If
        End Select
    End Sub

    Private Sub menuform_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ruchformy = False
        If Visible Then
            Select Case START.wywolywaczPOZ
                Case 1, 4, 0
                    Location = New Point(-300, 0)
                    Size = New Size(300, Screen.PrimaryScreen.Bounds.Height)
                Case 2, 3
                    Location = New Point(Screen.PrimaryScreen.Bounds.Width + 300, 0)
                    Size = New Size(300, Screen.PrimaryScreen.Bounds.Height)
            End Select
            ruch.Enabled = True
            Focus()
        End If
    End Sub

    Private Sub menuform_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            If panelwew.Location.Y < 0 Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y + 30)
            End If
        Else
            If panelzew.Size.Height < panelwew.Location.Y + panelwew.Size.Height Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y - 30)
            End If
        End If
    End Sub
End Class