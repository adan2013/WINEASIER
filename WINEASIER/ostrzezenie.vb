Imports System.Threading
Public Class ostrzezenie

    Dim dane() As String
    Dim kolor As Byte = 0
    Dim pauza As Boolean = False

    Private Sub ostrzezenie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aktualizuj()
    End Sub

    Private Sub aktualizuj()
        If START.ostrzezenia.Count = 0 Then
            Close()
        Else
            dane = START.ostrzezenia.Item(0).Split("^")
            lblopis.Text = dane(0)
            lblnazwa.Text = START.nazwaaplikacji(dane(1))
        End If
    End Sub

    Private Sub btnzamknij_Click(sender As Object, e As EventArgs) Handles btnzamknij.Click
        If START.usunostrzezenie(0) Then
            Close()
        Else
            aktualizuj()
        End If
    End Sub

    Private Sub btnotworz_Click(sender As Object, e As EventArgs) Handles btnotworz.Click
        If START.usunostrzezenie(0) Then
            uruchom()
            Close()
        Else
            uruchom()
            aktualizuj()
        End If
    End Sub

    Private Sub uruchom()
        START.dodajparametr(dane(1), dane(2))
        START.obiektaplikacji(dane(1)).Show()
    End Sub

    Private Sub mrg_Tick(sender As Object, e As EventArgs) Handles mrg.Tick
        If Not pauza Then
            If kolor Mod 2 = 0 Then
                Style = MetroFramework.MetroColorStyle.Yellow
                UpdateStyles()
                kolor += 1
            Else
                Style = MetroFramework.MetroColorStyle.Red
                UpdateStyles()
                kolor += 1
            End If
            If kolor = 10 Then
                kolor = 0
                pauza = True
            End If
        Else
            kolor += 1
            If kolor = 8 Then
                kolor = 0
                pauza = False
            End If
        End If
    End Sub
End Class