Public Class listapowiadomien

    Dim docelowe() As String

    Private Sub listapowiadomien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aktualizuj()
    End Sub

    Private Function zostalocos() As Boolean
        For Each i As Control In pnl.Controls
            If i.Name = "panele" Then Return True
        Next
        Return False
    End Function

    Public Sub aktualizuj()
        Do
            For Each i As Control In pnl.Controls
                If i.Name = "panele" Then pnl.Controls.Remove(i)
            Next
        Loop While zostalocos
        If START.powiadomienia.Count = 0 Then
            Dim lblinfo As Label = New Label()
            With lblinfo
                .Name = "panele"
                .Location = New Point(25, 75)
                .Size = New Size(650, 20)
                .Font = New Font("Segoe UI", 10)
                .TextAlign = ContentAlignment.MiddleCenter
                .ForeColor = Color.DarkGray
                .Text = "Brak powiadomień"
            End With
            pnl.Controls.Add(lblinfo)
        Else
            For i As Byte = 0 To START.powiadomienia.Count - 1 Step 1
                Dim dane() As String = START.powiadomienia.Item(i).Split("^")
                ReDim Preserve docelowe(i)
                docelowe(i) = dane(6) & "%" & dane(7)
                Dim kontener As Panel = New Panel()
                Dim lblnazwa As Label = New Label()
                Dim lblopis As Label = New Label()
                Dim lblczas As Label = New Label()
                Dim btnotworz As MetroFramework.Controls.MetroLink = New MetroFramework.Controls.MetroLink()
                Dim btnprzeczytane As MetroFramework.Controls.MetroLink = New MetroFramework.Controls.MetroLink()
                With kontener
                    .Name = "panele"
                    .Location = New Point(25, 5 + 65 * i)
                    .Size = New Size(650, 60)
                End With
                With lblnazwa
                    .Location = New Point(5, 5)
                    .Size = New Size(400, 30)
                    .Font = New Font("Segoe UI", 14)
                    .Text = START.nazwaaplikacji(dane(6))
                End With
                With lblopis
                    .Location = New Point(8, 40)
                    .Size = New Size(590, 15)
                    .Font = New Font("Segoe UI", 8)
                    .Text = dane(5)
                End With
                With lblczas
                    .Location = New Point(595, 40)
                    .Size = New Size(40, 15)
                    .TextAlign = ContentAlignment.TopRight
                    .Font = New Font("Segoe UI", 8)
                    .Text = dane(3) & ":" & dane(4)
                End With
                With btnprzeczytane
                    .Name = "p" & i
                    .Location = New Point(480, 5)
                    .Size = New Size(100, 30)
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Cursor = Cursors.Hand
                    .Text = "Przeczytane"
                End With
                With btnotworz
                    .Name = "o" & i
                    .Location = New Point(590, 5)
                    .Size = New Size(50, 30)
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Cursor = Cursors.Hand
                    .Text = "Otwórz"
                End With
                pnl.Controls.Add(kontener)
                kontener.Controls.Add(lblnazwa)
                kontener.Controls.Add(lblopis)
                kontener.Controls.Add(lblczas)
                kontener.Controls.Add(btnprzeczytane)
                kontener.Controls.Add(btnotworz)
                AddHandler btnprzeczytane.Click, AddressOf wykasuj
                AddHandler btnotworz.Click, AddressOf otworz
                If i = 4 Then Exit For
            Next
            Dim dolpanel As Panel = New Panel()
            Dim dollblilosc As Label = New Label()
            Dim dolbtnwyczysc As MetroFramework.Controls.MetroLink = New MetroFramework.Controls.MetroLink()
            With dolpanel
                .Name = "panele"
                .Location = New Point(25, 330)
                .Size = New Size(650, 20)
            End With
            With dollblilosc
                .Location = New Point(0, 0)
                .Size = New Size(300, 20)
                .Font = New Font("Segoe UI", 10)
                .Text = "Ilość powiadomień: " & START.powiadomienia.Count
            End With
            With dolbtnwyczysc
                .Location = New Point(530, 0)
                .Size = New Size(120, 20)
                .Text = "Wyczyść wszystkie"
                .Cursor = Cursors.Hand
                .TextAlign = ContentAlignment.TopRight
            End With
            pnl.Controls.Add(dolpanel)
            dolpanel.Controls.Add(dollblilosc)
            dolpanel.Controls.Add(dolbtnwyczysc)
            AddHandler dolbtnwyczysc.Click, AddressOf wszystko
        End If
    End Sub

    Private Sub wszystko(sender As Object, e As EventArgs)
        START.wyczyscpowiadomienia()
        aktualizuj()
    End Sub

    Private Sub otworz(sender As Object, e As EventArgs)
        Dim danedocelowe As String = docelowe(sender.Name.SubString(1))
        START.dodajparametr(danedocelowe.Substring(0, danedocelowe.IndexOf("%")), danedocelowe.Substring(danedocelowe.IndexOf("%") + 1))
        START.obiektaplikacji(danedocelowe.Substring(0, danedocelowe.IndexOf("%"))).Show()
        START.usunpowiadomienie(sender.Name.SubString(1))
        aktualizuj()
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub wykasuj(sender As Object, e As EventArgs)
        START.usunpowiadomienie(sender.Name.SubString(1))
        aktualizuj()
    End Sub
End Class