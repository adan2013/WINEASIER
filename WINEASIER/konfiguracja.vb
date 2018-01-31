Public Class konfiguracja

    Const maxkrok As Byte = 4
    Dim krok As Byte = 0
    Dim zamykanie As Boolean = False

    Private Sub konfiguracja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not zamykanie Then
            If Not MsgBox("Na pewno chcesz zakończyć działanie kreatora?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub akt()
        If krok > 0 Then btnwstecz.Visible = True Else btnwstecz.Visible = False
        If krok = maxkrok Then btndalej.Text = "Zakończ" Else btndalej.Text = "Dalej"
        Select Case krok
            Case 0
                txt.Text = "Dziękuję za wybór" & vbNewLine & "programu WINEASIER"
                img.Image = My.Resources.logonapis
            Case 1
                txt.Text = "Użyj górnego lewego rogu" & vbNewLine & "ekranu, aby wywołać okienko" & vbNewLine & " programu. Jego kliknięcie spowoduje" & vbNewLine & "otworzenie menu bocznego"
                img.Image = My.Resources.wstep1
            Case 2
                txt.Text = "W ustawieniach możesz dodać" & vbNewLine & "aplikację do autostartu systemu," & vbNewLine & "zmienić róg ekranu, dodać pozycje" & vbNewLine & "do menu bocznego oraz dodawać" & vbNewLine & "skróty klawiszowe"
                img.Image = My.Resources.wstep2
            Case 3
                txt.Text = "Szybki dostęp do funkcji programu" & vbNewLine & "umożliwia także ikona na pasku" & vbNewLine & "systemu obok zegara"
                img.Image = My.Resources.wstep3
            Case 4
                txt.Text = "Program skonfigurowany!" & vbNewLine & "Kliknij Zakończ, aby uruchomić program"
                img.Image = My.Resources.logonapis
        End Select
    End Sub

    Private Sub btndalej_Click(sender As Object, e As EventArgs) Handles btndalej.Click
        If krok = maxkrok Then
            updateFILE(START.folderapk, 1, "konfig", "<wyw=>poz=1>roz=1")
            updateFILE(START.folderapk, 1, "quickmenu", "<poz0=>nazwa=Wykonaj zrzut ekranu>ikona=>cel=1>par=5%WYKONAJ<poz1=>nazwa=ScreenShot - konfiguracja>ikona=>cel=1>par=5%<poz2=>nazwa=Kopie zapasowe>ikona=>cel=1>par=13%<poz3=>nazwa=Kalendarz/Organizer>ikona=>cel=1>par=15%<poz4=>nazwa=Sejf haseł>ikona=>cel=1>par=8%<poz5=>nazwa=Strona programu>ikona=>cel=2>par=http://wineasier.esy.es")
            START.skonfigurowany = True
            zamykanie = True
            Close()
        Else
            krok += 1
            akt()
        End If
    End Sub

    Private Sub btnwstecz_Click(sender As Object, e As EventArgs) Handles btnwstecz.Click
        krok -= 1
        akt()
    End Sub

    Private Sub konfiguracja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        akt()
    End Sub
End Class