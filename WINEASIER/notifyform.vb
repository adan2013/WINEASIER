Public Class notifyform

    Private Sub notifyform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Cursor.Position.X < 250 Then
            'dolny lewy
            Location = New Point(Screen.PrimaryScreen.Bounds.Width - Screen.PrimaryScreen.WorkingArea.Width + 10, Screen.PrimaryScreen.WorkingArea.Height - 340)
        Else
            If Cursor.Position.Y < 250 Then
                'gorny prawy
                Location = New Point(IIf(Cursor.Position.X + 105 > Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Width - 210, Cursor.Position.X - 100), Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height + 10)
            Else
                'dolny prawy
                Location = New Point(IIf(Cursor.Position.X + 105 > Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Width - 210, Cursor.Position.X - 100), Screen.PrimaryScreen.WorkingArea.Height - 340)
            End If
        End If
        Dim pnlpanel(5) As Panel
        Dim lblbutton(5) As Label
        Dim imgbutton(5) As PictureBox
        For i As Byte = 0 To 5 Step 1
            pnlpanel(i) = New Panel()
            lblbutton(i) = New Label()
            imgbutton(i) = New PictureBox()
            With pnlpanel(i)
                .Location = New Point(0, 145 + 30 * i)
                .Size = New Size(200, 30)
                .Cursor = Cursors.Hand
                .Name = "panel" & i
            End With
            With imgbutton(i)
                .Location = New Point(0, 0)
                .Size = New Size(40, 30)
                .SizeMode = PictureBoxSizeMode.CenterImage
                .Cursor = Cursors.Hand
                .Name = "img" & i
                Select Case i
                    Case 0
                        .Image = My.Resources.mininotif
                    Case 1
                        .Image = My.Resources.minimenuopen
                    Case 2
                        .Image = My.Resources.miniallapp
                    Case 3
                        .Image = My.Resources.minisleep
                    Case 4
                        .Image = My.Resources.minisettings
                    Case 5
                        .Image = My.Resources.minishutdown
                End Select
            End With
            With lblbutton(i)
                .Location = New Point(35, 0)
                .Size = New Size(165, 30)
                .Font = New Font("Segoe UI", 10)
                .TextAlign = ContentAlignment.MiddleLeft
                .Cursor = Cursors.Hand
                .Name = "tekst" & i
                Select Case i
                    Case 0
                        lblbutton(i).Text = "Powiadomienia (" & START.powiadomienia.Count & ")"
                    Case 1
                        lblbutton(i).Text = "Otwórz menu"
                    Case 2
                        lblbutton(i).Text = "Wszystkie aplikacje"
                    Case 3
                        If START.ciszapowiadomien Then
                            lblbutton(i).Text = "Włącz powiadomienia"
                        Else
                            lblbutton(i).Text = "Wycisz powiadomienia"
                        End If
                    Case 4
                        lblbutton(i).Text = "Ustawienia"
                    Case 5
                        lblbutton(i).Text = "Zakończ"
                End Select
            End With
            Controls.Add(pnlpanel(i))
            pnlpanel(i).Controls.Add(lblbutton(i))
            pnlpanel(i).Controls.Add(imgbutton(i))
            AddHandler pnlpanel(i).MouseMove, AddressOf podswietl
            AddHandler pnlpanel(i).MouseLeave, AddressOf zgas
            AddHandler lblbutton(i).MouseMove, AddressOf podswietl
            AddHandler lblbutton(i).MouseLeave, AddressOf zgas
            AddHandler imgbutton(i).MouseMove, AddressOf podswietl
            AddHandler imgbutton(i).MouseLeave, AddressOf zgas
            AddHandler pnlpanel(i).Click, AddressOf klik
            AddHandler lblbutton(i).Click, AddressOf klik
            AddHandler imgbutton(i).Click, AddressOf klik
        Next
    End Sub

    Private Sub klik(sender As Object, e As EventArgs)
        Select Case sender.Name.SubString(sender.Name.Length - 1)
            Case 0
                If listapowiadomien.Visible Then Close() Else listapowiadomien.Show()
            Case 1
                If menuform.Visible Then Close() Else menuform.Show()
            Case 2
                aplikacje.Show()
            Case 3
                If START.ciszapowiadomien Then
                    START.ciszapowiadomien = False
                    Close()
                Else
                    wyciszaniepow.Show()
                End If
            Case 4
                ustawienia.Show()
            Case 5
                zamkniecieprog.Show()
        End Select
    End Sub

    Private Sub zgas(sender As Object, e As EventArgs)
        sender.BackColor = Color.Transparent
        If sender.Parent.Name.indexof("panel") = 0 Then
            sender.Parent.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub podswietl(sender As Object, e As MouseEventArgs)
        sender.BackColor = Color.LightGray
        If sender.Parent.Name.indexof("panel") = 0 Then
            sender.Parent.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub notifyform_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Close()
    End Sub
End Class
