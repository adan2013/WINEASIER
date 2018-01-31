Public Class aplikacje

    Dim panelwew As Panel = New Panel()

    Private Sub aplikacje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ladujliste("")
    End Sub

    Private Sub ladujliste(ByVal filtr As String)
        panelzewn.Controls.Clear()
        panelwew = New Panel()
        With panelwew
            .Location = New Point(0, 0)
            .Size = New Size(604, 150)
        End With

        Dim x As Byte = 0
        Dim y As Byte = 0
        Dim aplikacje As List(Of String) = New List(Of String)

        Dim tempidapk As Byte = 2
        Do
            If START.nazwaaplikacji(tempidapk) = "" Then Exit Do
            aplikacje.Add(START.nazwaaplikacji(tempidapk) & "#" & tempidapk)
            tempidapk += 1
        Loop

        aplikacje.Sort()

        For Each idapk As String In aplikacje
            idapk = idapk.Substring(idapk.IndexOf("#") + 1)
            If filtr = "" OrElse START.nazwaaplikacji(idapk).ToLower() Like "*" & filtr.ToLower() & "*" Then
                Dim pic As PictureBox = New PictureBox()
                Dim lbl As Label = New Label()
                With pic
                    .Name = "id" & idapk
                    .Location = New Point(x * 150, y * 120)
                    .Size = New Size(150, 80)
                    .SizeMode = PictureBoxSizeMode.CenterImage
                    .Image = START.grafikaaplikacji(idapk)
                    .Cursor = Cursors.Hand
                End With
                With lbl
                    .Name = "id" & idapk
                    .Location = New Point(x * 150, y * 120 + 80)
                    .Size = New Size(150, 20)
                    .Font = New Font("Segoe UI", 10)
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Text = START.nazwaaplikacji(idapk)
                    .Cursor = Cursors.Hand
                End With
                AddHandler pic.Click, AddressOf kliknij
                AddHandler lbl.Click, AddressOf kliknij
                panelwew.Controls.Add(pic)
                panelwew.Controls.Add(lbl)
                x += 1
            End If
            If x = 4 Then
                x = 0
                y += 1
                panelwew.Size = New Size(panelwew.Size.Width, panelwew.Size.Height + 120)
            End If
            idapk += 1
        Next
        If x + y * 4 Mod 4 = 0 Then panelwew.Size = New Size(panelwew.Size.Width, panelwew.Size.Height - 120)
        panelzewn.Controls.Add(panelwew)
        lbl2.Text = y * 4 + x
        lblup.Visible = False
        lbldn.Visible = False
        If panelwew.Location.Y < 0 Then lblup.Visible = True
        If panelwew.Location.Y + panelwew.Size.Height > panelzewn.Size.Height Then lbldn.Visible = True
    End Sub

    Private Sub kliknij(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            If START.obiektaplikacji(sender.Name.Substring(2)).Visible Then
                komunikat.Visible = True
                If ukr.Enabled Then ukr.Start() Else ukr.Enabled = True
                If START.obiektaplikacji(sender.Name.Substring(2)).WindowState = FormWindowState.Minimized Then START.obiektaplikacji(sender.Name.Substring(2)).WindowState = FormWindowState.Normal
            Else
                START.dodajparametr(sender.Name.Substring(2), "")
                START.obiektaplikacji(sender.Name.Substring(2)).Show()
                If Not START.closeapk Then Close()
            End If
        Else
            MsgBox(START.nazwaaplikacji(sender.Name.Substring(2)) & ":" & vbNewLine & START.opisaplikacji(sender.Name.Substring(2)), MsgBoxStyle.Information, "WINEASIER")
        End If
    End Sub

    Private Sub ukr_Tick(sender As Object, e As EventArgs) Handles ukr.Tick
        ukr.Enabled = False
        komunikat.Visible = False
    End Sub

    Private Sub txtszukaj_TextChanged(sender As Object, e As EventArgs) Handles txtszukaj.TextChanged
        ladujliste(txtszukaj.Text)
    End Sub

    Private Sub aplikacje_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            If panelwew.Location.Y < 0 Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y + 30)
            End If
        Else
            If panelzewn.Size.Height < panelwew.Location.Y + panelwew.Size.Height Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y - 30)
            End If
        End If
        lblup.Visible = False
        lbldn.Visible = False
        If panelwew.Location.Y < 0 Then lblup.Visible = True
        If panelwew.Location.Y + panelwew.Size.Height > panelzewn.Size.Height Then lbldn.Visible = True
    End Sub

    Private Sub lbldn_Click(sender As Object, e As EventArgs) Handles lbldn.Click
        If panelzewn.Size.Height < panelwew.Location.Y + panelwew.Size.Height Then
            panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y - 30)
            lblup.Visible = False
            lbldn.Visible = False
            If panelwew.Location.Y < 0 Then lblup.Visible = True
            If panelwew.Location.Y + panelwew.Size.Height > panelzewn.Size.Height Then lbldn.Visible = True
        End If
    End Sub

    Private Sub lblup_Click(sender As Object, e As EventArgs) Handles lblup.Click
        If panelwew.Location.Y < 0 Then
            panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y + 30)
            lblup.Visible = False
            lbldn.Visible = False
            If panelwew.Location.Y < 0 Then lblup.Visible = True
            If panelwew.Location.Y + panelwew.Size.Height > panelzewn.Size.Height Then lbldn.Visible = True
        End If
    End Sub
End Class