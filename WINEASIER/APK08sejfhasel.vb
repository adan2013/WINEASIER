Public Class APK08sejfhasel

    Public Const hashcontrol As String = "hash2013encode"

    Public wpr As String = ""
    Dim panelwew As Panel = New Panel()
    Public wybr As String = ""

#Region "ZABEZPIECZENIA"

    Public Function encode(ByVal tekst As String, ByVal pass As String) As String
        Dim wrapper As New EncryptDecryptVB(pass)
        Return wrapper.EncryptData(tekst)
    End Function

    Public Function decode(ByVal tekst As String, ByVal pass As String) As String
        Dim wrapper As New EncryptDecryptVB(pass)
        Try
            Return wrapper.DecryptData(tekst)
        Catch ex As System.Security.Cryptography.CryptographicException
            Return ""
        End Try
    End Function
#End Region

    Private Sub btnpolityka_Click(sender As Object, e As EventArgs) Handles btnpolityka.Click
        If Size.Height = 360 Then Size = New Size(Size.Width, 470) Else Size = New Size(Size.Width, 360)
    End Sub

    Private Sub APK08sejfhasel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico8.GetHicon())
        START.pobierzparametr(8)
        Size = New Size(Size.Width, 360)
        If existFILE(START.folderapk, 8, "konfig", False) Then
            zaladujliste("")
        Else
            MsgBox("Ustawiono domyślne hasło dostępu: 12345" & vbNewLine & "Pamiętaj, aby zmienić to hasło jak najszybciej!", MsgBoxStyle.Information, "WINEASIER")
            existFILE(START.folderapk, 8, "konfig", True)
            Dim temp As String = ""
            POZmod(temp, "root", "pass", encode(hashcontrol, "12345"))
            updateFILE(START.folderapk, 8, "konfig", temp)
            existFILE(START.folderapk, 8, "list", True)
            updateFILE(START.folderapk, 8, "list", "")
        End If
    End Sub

    Private Sub zaladujliste(ByVal filtr As String)
        panelzew.Controls.Clear()
        panelwew = New Panel()
        With panelwew
            .Location = New Point(0, 0)
            .Size = New Size(panelzew.Width, panelzew.Height)
        End With
        Dim lp As Byte = 0
        Dim dane As String = openFILE(START.folderapk, 8, "list")
        For Each i As String In GRarray(dane)
            If POZget(dane, i, "nazwa").ToLower() Like "*" & filtr.ToLower() & "*" OrElse POZget(dane, i, "login").ToLower() Like "*" & filtr.ToLower() & "*" Then
                panelwew.Size = New Size(panelzew.Width, (lp + 1) * 40)
                Dim panel As Panel = New Panel()
                Dim nazwa As Label = New Label()
                Dim login As Label = New Label()
                With panel
                    .Name = "GR" & i
                    .Location = New Point(0, 40 * lp)
                    .Size = New Size(panelzew.Size.Width, 40)
                    .Cursor = Cursors.Hand
                End With
                With nazwa
                    .Name = "GR" & i
                    .Location = New Point(0, 0)
                    .Size = New Size(300, 40)
                    .Font = New Font("Segoe UI", 14)
                    .TextAlign = ContentAlignment.TopLeft
                    .Text = POZget(dane, i, "nazwa")
                    .Cursor = Cursors.Hand
                End With
                With login
                    .Name = "GR" & i
                    .Location = New Point(panelwew.Size.Width - 300, 20)
                    .Size = New Size(300, 20)
                    .Font = New Font("Segoe UI", 10)
                    .TextAlign = ContentAlignment.BottomRight
                    .Text = POZget(dane, i, "login")
                    .Cursor = Cursors.Hand
                End With
                AddHandler panel.MouseMove, AddressOf podswietl
                AddHandler panel.MouseLeave, AddressOf zgas
                AddHandler nazwa.MouseMove, AddressOf podswietl
                AddHandler nazwa.MouseLeave, AddressOf zgas
                AddHandler login.MouseMove, AddressOf podswietl
                AddHandler login.MouseLeave, AddressOf zgas
                AddHandler panel.Click, AddressOf klik
                AddHandler nazwa.Click, AddressOf klik
                AddHandler login.Click, AddressOf klik
                panel.Controls.Add(nazwa)
                panel.Controls.Add(login)
                panelwew.Controls.Add(panel)
                lp += 1
            End If
        Next
        panelzew.Controls.Add(panelwew)
        If panelwew.Location.Y < 0 Then lblup.Visible = True
        If panelwew.Location.Y + panelwew.Size.Height > panelzew.Size.Height Then lbldn.Visible = True
    End Sub

    Private Sub klik(sender As Object, e As EventArgs)
        wybr = sender.Name.SubString(2)
        APK08podglad.ShowDialog()
        If APK08podglad.DialogResult = DialogResult.Yes Then
            APK08podglad.Close()
            APK08edycja.ShowDialog()
            APK08edycja.Close()
            zaladujliste(txtszukaj.Text)
            wybr = ""
        Else
            If APK08podglad.DialogResult = DialogResult.No Then zaladujliste(txtszukaj.Text)
            APK08podglad.Close()
            wybr = ""
        End If
    End Sub

    Private Sub zgas(sender As Object, e As EventArgs)
        If TypeOf sender Is Panel Then
            sender.BackColor = Color.White
        Else
            sender.Parent.BackColor = Color.White
        End If
    End Sub

    Private Sub podswietl(sender As Object, e As MouseEventArgs)
        If TypeOf sender Is Panel Then
            sender.BackColor = Color.LightGray
        Else
            sender.Parent.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub btnlock_Click(sender As Object, e As EventArgs) Handles btnlock.Click
        If wpr = "" Then
            APK08odblokuj.ShowDialog()
            If APK08odblokuj.DialogResult = DialogResult.OK Then
                wpr = APK08odblokuj.pass
                btnlock.Text = "Zablokuj"
            End If
            APK08odblokuj.Close()
        Else
            wpr = ""
            btnlock.Text = "Odblokuj"
        End If
    End Sub

    Public Function autoryzacja() As Boolean
        If wpr = "" Then
            Return False
        Else
            Dim dane As String = openFILE(START.folderapk, 8, "konfig")
            dane = POZget(dane, "root", "pass")
            If dane = "" Then
                Return False
            Else
                dane = decode(dane, wpr)
                If dane = "" Then
                    Return False
                Else
                    If dane = hashcontrol Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            End If
        End If
    End Function

    Private Sub btnzmiana_Click(sender As Object, e As EventArgs) Handles btnzmiana.Click
        APK08zmiana.ShowDialog()
        APK08zmiana.Close()
        wpr = ""
        btnlock.Text = "Odblokuj"
    End Sub

    Private Sub btnnowy_Click(sender As Object, e As EventArgs) Handles btnnowy.Click
        APK08nowy.ShowDialog()
        APK08nowy.Close()
        zaladujliste(txtszukaj.Text)
    End Sub

    Private Sub txtszukaj_TextChanged(sender As Object, e As EventArgs) Handles txtszukaj.TextChanged
        zaladujliste(txtszukaj.Text)
    End Sub

    Private Sub btnedycja_Click(sender As Object, e As EventArgs) Handles btnedycja.Click
        wybr = ""
        APK08edycja.ShowDialog()
        APK08edycja.Close()
        zaladujliste(txtszukaj.Text)
    End Sub

    Private Sub lbldn_Click(sender As Object, e As EventArgs) Handles lbldn.Click
        If panelzew.Size.Height < panelwew.Location.Y + panelwew.Size.Height Then
            panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y - 30)
            lblup.Visible = False
            lbldn.Visible = False
            If panelwew.Location.Y < 0 Then lblup.Visible = True
            If panelwew.Location.Y + panelwew.Size.Height > panelzew.Size.Height Then lbldn.Visible = True
        End If
    End Sub

    Private Sub lblup_Click(sender As Object, e As EventArgs) Handles lblup.Click
        If panelwew.Location.Y < 0 Then
            panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y + 30)
            lblup.Visible = False
            lbldn.Visible = False
            If panelwew.Location.Y < 0 Then lblup.Visible = True
            If panelwew.Location.Y + panelwew.Size.Height > panelzew.Size.Height Then lbldn.Visible = True
        End If
    End Sub

    Private Sub APK08sejfhasel_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            If panelwew.Location.Y < 0 Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y + 30)
            End If
        Else
            If panelzew.Size.Height < panelwew.Location.Y + panelwew.Size.Height Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y - 30)
            End If
        End If
        lblup.Visible = False
        lbldn.Visible = False
        If panelwew.Location.Y < 0 Then lblup.Visible = True
        If panelwew.Location.Y + panelwew.Size.Height > panelzew.Size.Height Then lbldn.Visible = True
    End Sub
End Class