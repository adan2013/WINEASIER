Public Class APK03minutnik

    Dim zegar As Stopwatch = New Stopwatch()
    Dim trybedycji As Boolean = False
    Dim godz As Byte = 0
    Dim min As Byte = 0
    Dim sek As Byte = 0
    Dim ostsek As Byte = 0

    Private Sub APK02minutnik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico3.GetHicon())
        START.pobierzparametr(3)
        Size = New Size(Size.Width, 150)
    End Sub

    Private Sub btnleft_Click(sender As Object, e As EventArgs) Handles btnleft.Click
        If trybedycji Then
            godz = 0
            min = 0
            sek = 0
            aktlbl()
        Else
            If zegar.IsRunning Then
                zegar.Stop()
                btnleft.Text = "Uruchom licznik"
                btnright.Enabled = True
            Else
                If godz = 0 Then
                    If min = 0 Then
                        If sek < 5 Then
                            MsgBox("Minimalny czas minutnika wynosi 5 sekund!", MsgBoxStyle.Exclamation, "WINEASIER")
                            Exit Sub
                        End If
                    End If
                End If
                zegar.Start()
                ostsek = zegar.Elapsed.Seconds
                btnleft.Text = "Zatrzymaj licznik"
                btnright.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnright_Click(sender As Object, e As EventArgs) Handles btnright.Click
        If trybedycji Then
            trybedycji = False
            btnright.Text = "Tryb edycji"
            btnleft.Text = "Uruchom licznik"
            Size = New Size(Size.Width, 150)
        Else
            trybedycji = True
            btnright.Text = "Zamknij tryb"
            btnleft.Text = "Resetuj"
            Size = New Size(Size.Width, 220)
        End If
    End Sub

    Private Sub aktlbl()
        lbl.Text = godz & ":" & IIf(min < 10, "0" & min, min) & ":" & IIf(sek < 10, "0" & sek, sek)
    End Sub

    Private Sub godzplus_Click(sender As Object, e As EventArgs) Handles godzplus.Click
        If Not trybedycji Then Exit Sub
        If godz = 8 Then godz = 0 Else godz += 1
        aktlbl()
    End Sub

    Private Sub godzminus_Click(sender As Object, e As EventArgs) Handles godzminus.Click
        If Not trybedycji Then Exit Sub
        If godz = 0 Then godz = 8 Else godz -= 1
        aktlbl()
    End Sub

    Private Sub minplus_Click(sender As Object, e As EventArgs) Handles minplus.Click
        If Not trybedycji Then Exit Sub
        If min = 59 Then min = 0 Else min += 1
        aktlbl()
    End Sub

    Private Sub minminus_Click(sender As Object, e As EventArgs) Handles minminus.Click
        If Not trybedycji Then Exit Sub
        If min = 0 Then min = 59 Else min -= 1
        aktlbl()
    End Sub

    Private Sub sekplus_Click(sender As Object, e As EventArgs) Handles sekplus.Click
        If Not trybedycji Then Exit Sub
        If sek = 59 Then sek = 0 Else sek += 1
        aktlbl()
    End Sub

    Private Sub sekminus_Click(sender As Object, e As EventArgs) Handles sekminus.Click
        If Not trybedycji Then Exit Sub
        If sek = 0 Then sek = 59 Else sek -= 1
        aktlbl()
    End Sub

    Private Sub odl_Tick(sender As Object, e As EventArgs) Handles odl.Tick
        If Not zegar.Elapsed.Seconds = ostsek Then
            ostsek = zegar.Elapsed.Seconds
            If sek = 0 Then
                If min = 0 Then
                    If godz = 0 Then
                        zegar.Stop()
                        btnleft.Text = "Uruchom licznik"
                        btnright.Enabled = True
                        If radio1.Checked Then
                            START.dodajostrzezenie("Minutnik zakończył odliczanie czasu", 3, "")
                        Else
                            START.dodajpowiadomienie("Minutnik zakończył odliczanie czasu", 3, "")
                        End If
                    Else
                        godz -= 1
                        min = 59
                        sek = 59
                    End If
                Else
                    min -= 1
                    sek = 59
                End If
            Else
                sek -= 1
            End If
        End If
        aktlbl()
    End Sub
End Class