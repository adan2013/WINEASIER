Public Class APK15info

    Dim panelwew As Panel = New Panel()

    Private Sub btnzamknij_Click(sender As Object, e As EventArgs) Handles btnzamknij.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub APK15info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico15.GetHicon())
        Dim plik As String = openFILE(START.folderapk, 15, "lista")

        Dim wydarzenia As List(Of String) = New List(Of String)
        For Each gr As String In GRarray(plik)
            If Not START.getkatmessagetime(POZget(plik, gr, "kat")) = "" Then
                Dim d1 As DateTime = New DateTime(POZget(plik, gr, "rok"), POZget(plik, gr, "miesiac"), POZget(plik, gr, "dzien"))
                Dim d2 As DateTime = New DateTime(Now.Year, Now.Month, Now.Day)
                Do
                    If DateTime.Compare(d1, d2) >= 0 Then
                        If DateTime.Compare(d1.AddDays(START.getkatmessagetime(POZget(plik, gr, "kat")) * -1), d2) <= 0 Then
                            'dodaj powiadomienie
                            wydarzenia.Add(IIf(d1.Day < 10, "0" & d1.Day, d1.Day) & "#" & IIf(d1.Month < 10, "0" & d1.Month, d1.Month) & "#" & IIf(d1.Year < 10, "0" & d1.Year, d1.Year) & "#" & gr)
                            Exit Do
                        End If
                    End If
                    Select Case POZget(plik, gr, "cykl")
                        Case 0
                            Exit Do
                        Case 1
                            d1 = d1.AddDays(5)
                        Case 2
                            d1 = d1.AddDays(7)
                        Case 3
                            d1 = d1.AddDays(14)
                        Case 4
                            d1 = d1.AddDays(21)
                        Case 5
                            d1 = d1.AddMonths(1)
                        Case 6
                            d1 = d1.AddMonths(2)
                        Case 7
                            d1 = d1.AddMonths(3)
                        Case 8
                            d1 = d1.AddMonths(6)
                        Case 9
                            d1 = d1.AddYears(1)
                        Case Else
                            START.bladdanych()
                    End Select
                    If DateTime.Compare(d1.AddDays(-10), d2) > 0 Then Exit Do
                Loop
            End If
        Next

        panelwew = New Panel()
        With panelwew
            .Location = New Point(0, 0)
            .Size = New Size(panelzew.Size.Width, 0)
        End With
        For Each i As String In wydarzenia
            Dim gr As String = i.Split("#")(3)
            Dim tekst As Label = New Label()
            With tekst
                .Location = New Point(0, panelwew.Size.Height)
                .Size = New Size(panelwew.Size.Width, 20)
                .TextAlign = ContentAlignment.MiddleLeft
                .Font = New Font("Segoe UI", 10)
                If POZget(plik, gr, "calydzien") = "1" Then
                    .Text = "[ " & i.Split("#")(0) & "-" & i.Split("#")(1) & "-" & i.Split("#")(2) & " ] " & POZget(plik, gr, "nazwa")
                Else
                    .Text = "[ " & i.Split("#")(0) & "-" & i.Split("#")(1) & "-" & i.Split("#")(2) & " " & IIf(POZget(plik, gr, "godz") < 10, "0" & POZget(plik, gr, "godz"), POZget(plik, gr, "godz")) & ":" & IIf(POZget(plik, gr, "min") < 10, "0" & POZget(plik, gr, "min"), POZget(plik, gr, "min")) & " ] " & POZget(plik, gr, "nazwa")
                End If
            End With
            panelwew.Controls.Add(tekst)
            panelwew.Size = New Size(panelzew.Size.Width, panelwew.Size.Height + 20)
        Next
        panelzew.Controls.Add(panelwew)
        lblup.Visible = False
        lbldn.Visible = False
        If panelwew.Location.Y < 0 Then lblup.Visible = True
        If panelwew.Location.Y + panelwew.Size.Height > panelwew.Size.Height Then lbldn.Visible = True
    End Sub

    Private Sub APK15info_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            If panelwew.Location.Y < 0 Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y + 30)
            End If
        Else
            If panelwew.Size.Height < panelwew.Location.Y + panelwew.Size.Height Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y - 30)
            End If
        End If
        lblup.Visible = False
        lbldn.Visible = False
        If panelwew.Location.Y < 0 Then lblup.Visible = True
        If panelwew.Location.Y + panelwew.Size.Height > panelwew.Size.Height Then lbldn.Visible = True
    End Sub

    Private Sub lbldn_Click(sender As Object, e As EventArgs) Handles lbldn.Click
        If panelwew.Size.Height < panelwew.Location.Y + panelwew.Size.Height Then
            panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y - 30)
            lblup.Visible = False
            lbldn.Visible = False
            If panelwew.Location.Y < 0 Then lblup.Visible = True
            If panelwew.Location.Y + panelwew.Size.Height > panelwew.Size.Height Then lbldn.Visible = True
        End If
    End Sub

    Private Sub lblup_Click(sender As Object, e As EventArgs) Handles lblup.Click
        If panelwew.Location.Y < 0 Then
            panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y + 30)
            lblup.Visible = False
            lbldn.Visible = False
            If panelwew.Location.Y < 0 Then lblup.Visible = True
            If panelwew.Location.Y + panelwew.Size.Height > panelwew.Size.Height Then lbldn.Visible = True
        End If
    End Sub
End Class