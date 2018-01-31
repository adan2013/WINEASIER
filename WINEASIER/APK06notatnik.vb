Public Class APK06notatnik

    Dim panelwew As Panel = New Panel()
    Dim adresy As List(Of String) = New List(Of String)
    Public wybr As String = ""

    Private Sub APK06notatnik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico6.GetHicon())
        START.pobierzparametr(6)
        existFILE(START.folderapk, 6, "list", True)
        ladujliste()
    End Sub

    Private Sub APK06notatnik_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        panellista.Size = New Size(250, Size.Height - 120)
        btnnowa.Location = New Point(btnnowa.Location.X, Size.Height - 45)
        btnusun.Location = New Point(btnusun.Location.X, Size.Height - 45)
        lblup.Location = New Point(lblup.Location.X, Size.Height - 45)
        lbldn.Location = New Point(lbldn.Location.X, Size.Height - 45)
        panelpodglad.Size = New Size(Size.Width - 300, Size.Height - 80)
        lblinfo.Location = New Point(panelpodglad.Size.Width / 2 - lblinfo.Size.Width / 2, panelpodglad.Size.Height / 2 - lblinfo.Height / 2)
    End Sub

    Private Sub ladujliste()
        panellista.Controls.Clear()
        adresy.Clear()
        panelwew = New Panel()
        With panelwew
            .Location = New Point(0, 0)
            .Size = New Size(250, 40)
        End With
        panellista.Controls.Add(panelwew)
        Dim dane As String = openFILE(START.folderapk, 6, "list")
        Dim wspy As Integer = 0
        Dim lp As Byte = 0
        For Each grupa As String In GRarray(dane)
            adresy.Add(grupa)
            panelwew.Size = New Size(250, wspy + 40)
            Dim panelpoz As Panel = New Panel()
            Dim lbl1 As Label = New Label()
            Dim lbl2 As Label = New Label()
            With panelpoz
                .Name = "GR" & lp
                .Location = New Point(0, wspy)
                .Size = New Size(250, 40)
                .Cursor = Cursors.Hand
                If grupa = wybr Then .BackColor = Color.LightGray
            End With
            With lbl1
                .Name = "GR" & lp
                .Location = New Point(5, 5)
                .Size = New Size(200, 25)
                .TextAlign = ContentAlignment.TopLeft
                .Font = New Font("Segoe UI", 12, FontStyle.Bold)
                .Cursor = Cursors.Hand
                .Text = POZget(dane, grupa, "nazwa")
                If grupa = wybr Then .BackColor = Color.LightGray
            End With
            With lbl2
                .Name = "GR" & lp
                .Location = New Point(0, 15)
                .Size = New Size(245, 20)
                .TextAlign = ContentAlignment.BottomRight
                .Font = New Font("Segoe UI", 7)
                .Cursor = Cursors.Hand
                .Text = POZget(dane, grupa, "dzien") & " " & mies(POZget(dane, grupa, "mies"))
                If grupa = wybr Then .BackColor = Color.LightGray
            End With
            panelpoz.Controls.Add(lbl1)
            panelpoz.Controls.Add(lbl2)
            panelwew.Controls.Add(panelpoz)
            AddHandler panelpoz.MouseMove, AddressOf podswietl
            AddHandler lbl1.MouseMove, AddressOf podswietl
            AddHandler lbl2.MouseMove, AddressOf podswietl
            AddHandler panelpoz.MouseLeave, AddressOf zgas
            AddHandler lbl1.MouseLeave, AddressOf zgas
            AddHandler lbl2.MouseLeave, AddressOf zgas
            AddHandler panelpoz.Click, AddressOf kliknijpodglad
            AddHandler lbl1.Click, AddressOf kliknijpodglad
            AddHandler lbl2.Click, AddressOf kliknijpodglad
            AddHandler panelpoz.DoubleClick, AddressOf kliknijedycja
            AddHandler lbl1.DoubleClick, AddressOf kliknijedycja
            AddHandler lbl2.DoubleClick, AddressOf kliknijedycja
            wspy += 40
            lp += 1
        Next
        lblup.Visible = False
        lbldn.Visible = False
        If panelwew.Location.Y < 0 Then lblup.Visible = True
        If panelwew.Location.Y + panelwew.Size.Height > panellista.Size.Height Then lbldn.Visible = True
    End Sub

    Private Sub kliknijpodglad(sender As Object, e As EventArgs)
        Dim dane As String = openFILE(START.folderapk, 6, "list")
        wybr = adresy.Item(sender.Name.substring(2))
        Dim plik As String = POZget(dane, adresy.Item(sender.Name.substring(2)), "zrodlo")
        If existFILE(START.folderapk, 6, plik, False) Then
            txtpodglad.Text = openFILE(START.folderapk, 6, plik)
            If txtpodglad.Text = "" Then txtpodglad.Text = "Notatka jest pusta"
        Else
            txtpodglad.Text = "Notatka jest pusta"
        End If
        For Each i As Control In panelwew.Controls
            i.BackColor = Color.White
        Next
        If TypeOf sender Is Panel Then
            sender.BackColor = Color.LightGray
        Else
            sender.Parent.BackColor = Color.LightGray
        End If
        txtpodglad.Visible = True
        lblinfo.Visible = False
        btnusun.Enabled = True
    End Sub

    Private Sub zamknijpodglad()
        txtpodglad.Visible = False
        lblinfo.Visible = True
        btnusun.Enabled = False
    End Sub

    Private Sub zgas(sender As Object, e As EventArgs)
        If Not wybr = adresy.Item(sender.Name.substring(2)) Then
            If TypeOf sender Is Panel Then
                sender.BackColor = Color.White
            Else
                sender.Parent.BackColor = Color.White
            End If
        End If
    End Sub

    Private Sub podswietl(sender As Object, e As EventArgs)
        If TypeOf sender Is Panel Then
            sender.BackColor = Color.LightGray
        Else
            sender.Parent.BackColor = Color.LightGray
        End If
    End Sub

    Private Function mies(ByVal id As Byte) As String
        Select Case id
            Case 1
                Return "Sty"
            Case 2
                Return "Lut"
            Case 3
                Return "Mar"
            Case 4
                Return "Kwi"
            Case 5
                Return "Maj"
            Case 6
                Return "Cze"
            Case 7
                Return "Lip"
            Case 8
                Return "Sie"
            Case 9
                Return "Wrz"
            Case 10
                Return "Paź"
            Case 11
                Return "Lis"
            Case 12
                Return "Gru"
            Case Else
                Return "Sty"
        End Select
    End Function

    Private Sub btnusun_Click(sender As Object, e As EventArgs) Handles btnusun.Click
        If wybr = "" Then
            btnusun.Enabled = False
        Else
            zamknijpodglad()
            Dim dane As String = openFILE(START.folderapk, 6, "list")
            updateFILE(START.folderapk, 6, POZget(dane, wybr, "zrodlo"), "")
            GRdel(dane, wybr)
            updateFILE(START.folderapk, 6, "list", dane)
            wybr = ""
            ladujliste()
        End If
    End Sub

    Private Sub btnnowa_Click(sender As Object, e As EventArgs) Handles btnnowa.Click
        zamknijpodglad()
        wybr = ""
        APK06edycja.ShowDialog()
        APK06edycja.Close()
        ladujliste()
    End Sub

    Private Sub kliknijedycja(sender As Object, e As EventArgs)
        If Not wybr = "" Then
            zamknijpodglad()
            APK06edycja.ShowDialog()
            APK06edycja.Close()
            wybr = ""
            ladujliste()
        End If
    End Sub

    Private Sub APK06notatnik_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            If panelwew.Location.Y < 0 Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y + 30)
            End If
        Else
            If panellista.Size.Height < panelwew.Location.Y + panelwew.Size.Height Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y - 30)
            End If
        End If
        lblup.Visible = False
        lbldn.Visible = False
        If panelwew.Location.Y < 0 Then lblup.Visible = True
        If panelwew.Location.Y + panelwew.Size.Height > panellista.Size.Height Then lbldn.Visible = True
    End Sub

    Private Sub lbldn_Click(sender As Object, e As EventArgs) Handles lbldn.Click
        If panellista.Size.Height < panelwew.Location.Y + panelwew.Size.Height Then
            panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y - 30)
            lblup.Visible = False
            lbldn.Visible = False
            If panelwew.Location.Y < 0 Then lblup.Visible = True
            If panelwew.Location.Y + panelwew.Size.Height > panellista.Size.Height Then lbldn.Visible = True
        End If
    End Sub

    Private Sub lblup_Click(sender As Object, e As EventArgs) Handles lblup.Click
        If panelwew.Location.Y < 0 Then
            panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y + 30)
            lblup.Visible = False
            lbldn.Visible = False
            If panelwew.Location.Y < 0 Then lblup.Visible = True
            If panelwew.Location.Y + panelwew.Size.Height > panellista.Size.Height Then lbldn.Visible = True
        End If
    End Sub
End Class