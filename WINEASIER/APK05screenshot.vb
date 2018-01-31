Public Class APK05screenshot

    Dim sciezka As String = ""
    Dim konfiguracja As Boolean = False
    Public bmp As Bitmap

    Private Sub APK05screenshot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico5.GetHicon())
        Dim parametr As String = START.pobierzparametr(5)
        If parametr = "WYKONAJ" Then
            existFILE(START.folderapk, 5, "ust", True)
            Dim dane As String = openFILE(START.folderapk, 5, "ust")
            If Not POZexist(dane, "ust", "folder") Then POZmod(dane, "ust", "folder", "")
            If Not POZexist(dane, "ust", "roz") Then POZmod(dane, "ust", "roz", "1")
            If Not POZexist(dane, "ust", "start") Then POZmod(dane, "ust", "start", "4")
            updateFILE(START.folderapk, 5, "ust", dane)

            'wykonanie zrzutu
            Opacity = 0
            Hide()
            If Not menuform.Visible Then
                bmp = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
                Dim gfx As Graphics = Graphics.FromImage(bmp)
                gfx.Clear(Color.White)
                gfx.CopyFromScreen(New Point(0, 0), New Point(0, 0), New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
                APK05zrzut.Show()
            End If
            tmr.Enabled = True
        Else
            'zwykle uruchomienie
            listaplik.SelectedIndex = 0
            existFILE(START.folderapk, 5, "ust", True)
            Dim dane As String = openFILE(START.folderapk, 5, "ust")
            If POZexist(dane, "ust", "folder") Then
                If Not POZget(dane, "ust", "folder") = "" Then
                    radio2.Checked = True
                    sciezka = POZget(dane, "ust", "folder")
                    lblplik.Text = My.Computer.FileSystem.GetName(sciezka)
                End If
            Else
                POZmod(dane, "ust", "folder", "")
            End If
            If POZexist(dane, "ust", "roz") Then
                Dim lista As Byte = POZget(dane, "ust", "roz")
                If lista < 1 Or lista > 3 Then START.bladdanych()
                listaplik.SelectedIndex = lista - 1
            Else
                POZmod(dane, "ust", "roz", "1")
            End If
            If POZexist(dane, "ust", "start") Then
                Dim lista As Byte = POZget(dane, "ust", "start")
                If lista < 1 Or lista > 4 Then START.bladdanych()
                If lista = 1 Then n1.Checked = True
                If lista = 2 Then n2.Checked = True
                If lista = 3 Then n3.Checked = True
                If lista = 4 Then n4.Checked = True
            Else
                POZmod(dane, "ust", "start", "4")
            End If
            updateFILE(START.folderapk, 5, "ust", dane)
        End If
        konfiguracja = True
    End Sub

    Private Sub btnzapisz_Click(sender As Object, e As EventArgs) Handles btnzapisz.Click
        If radio2.Checked AndAlso sciezka = "" Then
            MsgBox("Nie wybrano folderu docelowego!", MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End If
        Dim dane As String = openFILE(START.folderapk, 5, "ust")
        If radio1.Checked Then
            POZmod(dane, "ust", "folder", "")
        Else
            POZmod(dane, "ust", "folder", sciezka)
        End If
        POZmod(dane, "ust", "roz", listaplik.SelectedIndex + 1)
        If n1.Checked Then POZmod(dane, "ust", "start", "1")
        If n2.Checked Then POZmod(dane, "ust", "start", "2")
        If n3.Checked Then POZmod(dane, "ust", "start", "3")
        If n4.Checked Then POZmod(dane, "ust", "start", "4")
        updateFILE(START.folderapk, 5, "ust", dane)
        btnzapisz.Visible = False
    End Sub

    Private Sub listaplik_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaplik.SelectedIndexChanged
        If konfiguracja Then btnzapisz.Visible = True
    End Sub

    Private Sub radio1_CheckedChanged(sender As Object, e As EventArgs) Handles radio1.CheckedChanged, radio2.CheckedChanged, n1.CheckedChanged, n2.CheckedChanged, n3.CheckedChanged, n4.CheckedChanged
        If konfiguracja Then btnzapisz.Visible = True
    End Sub

    Private Sub btnfolder_Click(sender As Object, e As EventArgs) Handles btnfolder.Click
        oknofolder.ShowDialog()
        If Not oknofolder.SelectedPath = "" Then
            sciezka = oknofolder.SelectedPath
            lblplik.Text = My.Computer.FileSystem.GetName(sciezka)
            btnzapisz.Visible = True
        End If
    End Sub

    Private Sub APK05screenshot_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If btnzapisz.Visible Then
            If Not MsgBox("Nie zapisano zmian w ustawieniach" & vbNewLine & "Na pewno chcesz wyjść?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        If APK05zrzut.Visible Then
            bmp.Dispose()
            Close()
        Else
            If Not menuform.Visible Then
                bmp = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
                Dim gfx As Graphics = Graphics.FromImage(bmp)
                gfx.Clear(Color.White)
                gfx.CopyFromScreen(New Point(0, 0), New Point(0, 0), New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
                APK05zrzut.Show()
            End If
        End If
    End Sub
End Class