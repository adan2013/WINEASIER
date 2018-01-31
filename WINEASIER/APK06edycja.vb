Public Class APK06edycja

    Dim zmiany As Boolean = False
    Dim gr As String = ""
    Dim uruchomiony As Boolean = False

    Private Sub APK06edycja_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        txtnazwa.Size = New Size(Size.Width - 200, txtnazwa.Size.Height)
        btnzapisz.Location = New Point(Size.Width - 110, btnzapisz.Location.Y)
        txttresc.Size = New Size(Size.Width - 40, Size.Height - 120)
    End Sub

    Private Sub APK06edycja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico6.GetHicon())
        gr = APK06notatnik.wybr
        If gr = "" Then
            lblheader.Text = "Notatnik - nowy wpis"
        Else
            lblheader.Text = "Notatnik - edycja wpisu"
            Dim dane As String = openFILE(START.folderapk, 6, "list")
            txtnazwa.Text = POZget(dane, gr, "nazwa")
            Text = POZget(dane, gr, "nazwa") & " - Notatnik"
            If existFILE(START.folderapk, 6, POZget(dane, gr, "zrodlo"), False) Then
                txttresc.Text = openFILE(START.folderapk, 6, POZget(dane, gr, "zrodlo"))
            End If
        End If
        txttresc.SelectionStart = txttresc.Text.Length
        uruchomiony = True
    End Sub

    Private Sub txttresc_TextChanged(sender As Object, e As EventArgs) Handles txttresc.TextChanged
        zmieniono()
    End Sub

    Private Sub txtnazwa_TextChanged(sender As Object, e As EventArgs) Handles txtnazwa.TextChanged
        zmieniono()
    End Sub

    Private Sub zmieniono()
        If Not uruchomiony Then Exit Sub
        If Not zmiany Then
            zmiany = True
            btnzapisz.Enabled = True
        End If
    End Sub

    Private Sub APK06edycja_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If zmiany Then
            If Not MsgBox("Wykryto wprowadzone zmiany w notatce" & vbNewLine & "Czy chcesz wyjść bez zapisu zmian?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnzapisz_Click(sender As Object, e As EventArgs) Handles btnzapisz.Click
        If zmiany Then
            If txtnazwa.Text = "" Then
                MsgBox("Nazwa nie może być pusta!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            If gr = "" Then
                Dim dane As String = openFILE(START.folderapk, 6, "list")
                Dim plik As String = Now.Year & Now.Month & Now.Day & Now.Hour & Now.Minute & Now.Second
                For i As Byte = 0 To 80 Step 1
                    If Not GRexist(dane, "poz" & i) Then
                        gr = "poz" & i
                        Exit For
                    End If
                Next
                POZmod(dane, gr, "nazwa", txtnazwa.Text)
                POZmod(dane, gr, "dzien", Now.Day)
                POZmod(dane, gr, "mies", Now.Month)
                POZmod(dane, gr, "zrodlo", plik)
                updateFILE(START.folderapk, 6, "list", dane)
                existFILE(START.folderapk, 6, plik, True)
                updateFILE(START.folderapk, 6, plik, txttresc.Text)
            Else
                Dim dane As String = openFILE(START.folderapk, 6, "list")
                POZmod(dane, gr, "nazwa", txtnazwa.Text)
                POZmod(dane, gr, "dzien", Now.Day)
                POZmod(dane, gr, "mies", Now.Month)
                updateFILE(START.folderapk, 6, "list", dane)
                Dim plik As String = POZget(dane, gr, "zrodlo")
                existFILE(START.folderapk, 6, plik, True)
                updateFILE(START.folderapk, 6, plik, txttresc.Text)
            End If
            Text = POZget(openFILE(START.folderapk, 6, "list"), gr, "nazwa") & " - Notatnik"
            btnzapisz.Enabled = False
        Else
            btnzapisz.Enabled = False
        End If
        zmiany = False
    End Sub
End Class