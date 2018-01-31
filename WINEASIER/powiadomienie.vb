Public Class powiadomienie

    Dim idapk As Byte = 0
    Dim parametr As String = ""

    Public Sub aktualizuj()
        ukrywanie.Start()
        Select Case START.powiadomienia.Count
            Case 0
                Close()
            Case 1
                Dim temp() As String = START.powiadomienia.Item(START.powiadomienia.Count - 1).Split("^")
                lbltime.Text = temp(3) & ":" & temp(4)
                lbltime.Visible = True
                lblnazwa.Text = START.nazwaaplikacji(temp(6))
                idapk = temp(6)
                lblopis.Text = temp(5)
                parametr = temp(7)
            Case Else
                lbltime.Text = "00:00"
                lbltime.Visible = False
                lblnazwa.Text = "Nowe powiadomienia"
                lblopis.Text = "Ilość powiadomień: " & START.powiadomienia.Count
        End Select
    End Sub

    Private Sub powiadomienie_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Location = New Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - 200, Screen.PrimaryScreen.WorkingArea.Height - 110)
        aktualizuj()
    End Sub

    Private Sub btnotworz_Click(sender As Object, e As EventArgs) Handles btnotworz.Click
        Select Case START.powiadomienia.Count
            Case 1
                START.dodajparametr(idapk, parametr)
                START.obiektaplikacji(idapk).Show()
                START.wyczyscpowiadomienia()
            Case Else
                listapowiadomien.Show()
        End Select
        Close()
    End Sub

    Private Sub btnprzyczytane_Click(sender As Object, e As EventArgs) Handles btnprzyczytane.Click
        If START.powiadomienia.Count > 0 Then
            START.wyczyscpowiadomienia()
        End If
        Close()
    End Sub

    Private Sub ukrywanie_Tick(sender As Object, e As EventArgs) Handles ukrywanie.Tick
        Close()
    End Sub

    Private Sub lblzamknij_Click(sender As Object, e As EventArgs) Handles lblzamknij.Click
        Close()
    End Sub
End Class