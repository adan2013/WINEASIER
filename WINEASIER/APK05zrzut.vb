Public Class APK05zrzut

    Dim uruchomienie As Boolean = True
    Dim wysuniety As Boolean = True
    Dim zrzut As Bitmap = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
    Dim temp As Bitmap = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
    Dim origimg As Bitmap = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
    Dim gfx As Graphics = Graphics.FromImage(zrzut)
    Dim tempgfx As Graphics = Graphics.FromImage(temp)
    Dim origgfx As Graphics = Graphics.FromImage(origimg)
    Dim przyslona As SolidBrush = New SolidBrush(Color.FromArgb(128, 0, 0, 0))
    Dim OLDdowyc As Rectangle = New Rectangle(0, 0, 0, 0)
    Dim dowyc As Rectangle = New Rectangle(0, 0, 0, 0)
    Dim aktkolor As Panel = New Panel()
    Dim gr As Byte = 4
    Dim narzedzie As Byte = 0
    Dim his As Bitmap
    Dim rysowaniebtndn As Boolean = False
    Dim colorpodsw As Color = Color.FromArgb(204, 204, 204)
    Dim colorhover As Color = Color.FromArgb(204, 204, 204)
    Dim ostwyc As Boolean = False

    Dim ex As MouseEventArgs = New MouseEventArgs(MouseButtons.None, 0, 0, 0, 0)

    Private Sub APK05zrzut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico5.GetHicon())
        gfx.DrawImage(APK05screenshot.bmp, New Point(0, 0))
        przybornik.Location = New Point(Screen.PrimaryScreen.Bounds.Width / 2 - przybornik.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height - 65)
        ekran.Image = zrzut
        origgfx.DrawImage(zrzut, New Point(0, 0))
        gfx.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim kolory(7) As Panel
        With aktkolor
            .Location = New Point(5, 5)
            .Size = New Size(32, 32)
            .BackColor = Color.Black
        End With
        For i As Byte = 0 To 7 Step 1
            kolory(i) = New Panel()
            With kolory(i)
                Select Case i
                    Case 0
                        .Location = New Point(42, 5)
                    Case 1
                        .Location = New Point(59, 5)
                    Case 2
                        .Location = New Point(76, 5)
                    Case 3
                        .Location = New Point(93, 5)
                    Case 4
                        .Location = New Point(42, 22)
                    Case 5
                        .Location = New Point(59, 22)
                    Case 6
                        .Location = New Point(76, 22)
                    Case 7
                        .Location = New Point(93, 22)
                End Select
                .Size = New Size(15, 15)
                .Cursor = Cursors.Hand
                .BackColor = getcolor(i)
            End With
            przybornik.Controls.Add(kolory(i))
            AddHandler kolory(i).Click, AddressOf zmienkolor
        Next
        przybornik.Controls.Add(aktkolor)
        Dim grpisaka As MetroFramework.Controls.MetroTrackBar = New MetroFramework.Controls.MetroTrackBar()
        With grpisaka
            .Location = New Point(5, 40)
            .Size = New Size(103, 23)
            .Value = 4
            .Minimum = 1
            .Maximum = 14
        End With
        AddHandler grpisaka.ValueChanged, AddressOf zmiengr
        przybornik.Controls.Add(grpisaka)
        narzedzie = odczytajnarzedzie() - 1
        Dim przyciski(8) As PictureBox
        For i As Byte = 0 To 8 Step 1
            przyciski(i) = New PictureBox()
            With przyciski(i)
                .Name = "btn" & i
                .Location = New Point(115 + 52 * i, 0)
                .Size = New Size(50, 65)
                .Cursor = Cursors.Hand
                .SizeMode = PictureBoxSizeMode.CenterImage
                If i = narzedzie Then .BackColor = colorpodsw Else .BackColor = Color.White
                Select Case i
                    Case 0
                        .Image = My.Resources.screenbtn1
                    Case 1
                        .Image = My.Resources.screenbtn2
                    Case 2
                        .Image = My.Resources.screenbtn3
                    Case 3
                        .Image = My.Resources.screenbtn4
                    Case 4
                        .Image = My.Resources.screenbtn5
                    Case 5
                        .Image = My.Resources.screenbtn6
                    Case 6
                        .Image = My.Resources.screenbtn7
                    Case 7
                        .Image = My.Resources.screenbtn8
                    Case 8
                        .Image = My.Resources.screenbtn9
                End Select
            End With
            ' rysik prostokat elipsa wycinanie cofnij schowek zapisz schowekizapisz anuluj
            przybornik.Controls.Add(przyciski(i))
            AddHandler przyciski(i).MouseMove, AddressOf podswietl
            AddHandler przyciski(i).MouseLeave, AddressOf zgas
            AddHandler przyciski(i).Click, AddressOf klik
        Next
        odswiezanie.Enabled = True
        Opacity = 100
    End Sub

    Private Sub zmiennarzedzie(ByVal id As Byte)
        narzedzie = id
        For i As Byte = 0 To przybornik.Controls.Count - 1 Step 1
            If przybornik.Controls(i).Name.IndexOf("btn") = 0 Then
                If przybornik.Controls(i).Name.Substring(3) = narzedzie Then przybornik.Controls(i).BackColor = colorpodsw Else przybornik.Controls(i).BackColor = Color.White
            End If
        Next
    End Sub

    Private Sub klik(sender As Object, e As EventArgs)
        Select Case sender.Name.Substring(3)
            Case 0
                zmiennarzedzie(0)
            Case 1
                zmiennarzedzie(1)
            Case 2
                zmiennarzedzie(2)
            Case 3
                zmiennarzedzie(3)
            Case 4
                przywrocobraz()
            Case 5
                Clipboard.SetImage(getimageforsave())
                zamknij()
            Case 6
                zapiszobraz()
                zamknij()
            Case 7
                Clipboard.SetImage(getimageforsave())
                zapiszobraz()
                zamknij()
            Case 8
                zamknij()
        End Select
    End Sub

    Private Function getimageforsave() As Bitmap
        If dowyc.Width > 10 And dowyc.Height > 10 Then
            Dim tempimg As Bitmap = New Bitmap(dowyc.Width, dowyc.Height)
            Using gfxtempimg As Graphics = Graphics.FromImage(tempimg)
                gfxtempimg.DrawImage(zrzut, New Rectangle(0, 0, dowyc.Width, dowyc.Height), dowyc, GraphicsUnit.Pixel)
            End Using
            Return tempimg
        Else
            Return zrzut
        End If
    End Function

    Private Sub zapiszobraz()
        Dim fol As String = odczytajustawienie(False)
        Dim roz As String = odczytajustawienie(True)
        If fol = "" Then
            oknozapisu.Filter = "Obraz PNG (.png)|*.png|Obraz BMP (.bmp)|*.bmp|Obraz JPG (.jpg)|*.jpg"
            oknozapisu.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            oknozapisu.FileName = Now.Day & "-" & Now.Month & "-" & Now.Year & " " & Now.Hour & "-" & Now.Minute & "-" & Now.Second
            Select Case roz
                Case "1"
                    oknozapisu.DefaultExt = "png"
                Case "2"
                    oknozapisu.DefaultExt = "bmp"
                Case "3"
                    oknozapisu.DefaultExt = "jpg"
                Case Else
                    oknozapisu.DefaultExt = "png"
            End Select
            oknozapisu.ShowDialog()
            If Not oknozapisu.FileName = "" Then
                Try
                    If IO.File.Exists(oknozapisu.FileName) Then IO.File.Delete(oknozapisu.FileName)
                Catch ex As Exception
                    MsgBox("Brak dostępu!", MsgBoxStyle.Exclamation, "WINEASIER")
                    Exit Sub
                End Try
                getimageforsave().Save(oknozapisu.FileName)
            End If
        Else
            Try
                If Not IO.Directory.Exists(fol) Then IO.Directory.CreateDirectory(fol)
                Select Case roz
                    Case "1"
                        getimageforsave().Save(fol & "\" & Now.Day & "-" & Now.Month & "-" & Now.Year & " " & Now.Hour & "-" & Now.Minute & "-" & Now.Second & ".png", Imaging.ImageFormat.Png)
                    Case "2"
                        getimageforsave().Save(fol & "\" & Now.Day & "-" & Now.Month & "-" & Now.Year & " " & Now.Hour & "-" & Now.Minute & "-" & Now.Second & ".bmp", Imaging.ImageFormat.Bmp)
                    Case "3"
                        getimageforsave().Save(fol & "\" & Now.Day & "-" & Now.Month & "-" & Now.Year & " " & Now.Hour & "-" & Now.Minute & "-" & Now.Second & ".jpg", Imaging.ImageFormat.Jpeg)
                End Select
            Catch ex As Exception
                MsgBox("Błąd zapisu grafiki!", MsgBoxStyle.Critical, "WINEASIER")
            End Try
        End If
    End Sub

    Private Function odczytajustawienie(ByVal ust As Boolean) As String
        If existFILE(START.folderapk, 5, "ust", False) Then
            Dim dane As String = openFILE(START.folderapk, 5, "ust")
            If ust Then
                Return POZget(dane, "ust", "roz")
            Else
                Return POZget(dane, "ust", "folder")
            End If
        Else
            If ust Then
                Return "1"
            Else
                Return ""
            End If
        End If
    End Function

    Private Function odczytajnarzedzie() As Byte
        If existFILE(START.folderapk, 5, "ust", False) Then
            Dim dane As String = openFILE(START.folderapk, 5, "ust")
            If IsNumeric(POZget(dane, "ust", "start")) AndAlso POZget(dane, "ust", "start") < 5 AndAlso POZget(dane, "ust", "start") >= 0 Then
                Return POZget(dane, "ust", "start")
            Else
                Return 4
            End If
        Else
            Return 4
        End If
    End Function

    Private Sub zgas(sender As Object, e As EventArgs)
        If Not sender.Name.Substring(3) = narzedzie Then sender.BackColor = Color.White
    End Sub

    Private Sub podswietl(sender As Object, e As EventArgs)
        If sender.Name.Substring(sender.Name.Length - 1) = narzedzie Then sender.BackColor = colorpodsw Else sender.BackColor = colorhover
    End Sub

    Private Sub zmiengr(sender As Object, e As EventArgs)
        gr = sender.Value
    End Sub

    Private Sub zmienkolor(sender As Object, e As EventArgs)
        aktkolor.BackColor = sender.BackColor
    End Sub

    Private Function getcolor(ByVal id As Byte) As Color
        Select Case id
            Case 0
                Return Color.Black
            Case 1
                Return Color.Red
            Case 2
                Return Color.Green
            Case 3
                Return Color.MediumPurple
            Case 4
                Return Color.Blue
            Case 5
                Return Color.Gold
            Case 6
                Return Color.Orange
            Case 7
                Return Color.Pink
            Case Else
                Return Color.Black
        End Select
    End Function

    Private Sub ruch_Tick(sender As Object, e As EventArgs) Handles ruch.Tick
        If wysuniety Then
            If przybornik.Location.Y > Screen.PrimaryScreen.Bounds.Height - 60 Then
                przybornik.Location = New Point(przybornik.Location.X, przybornik.Location.Y - 10)
            Else
                ruch.Enabled = False
            End If
        Else
            If przybornik.Location.Y >= Screen.PrimaryScreen.Bounds.Height - 5 Then
                ruch.Enabled = False
            Else
                przybornik.Location = New Point(przybornik.Location.X, przybornik.Location.Y + 10)
            End If
        End If
    End Sub

    Private Sub zapiszzmiany()
        his = New Bitmap(zrzut)
    End Sub

    Private Sub przywrocobraz()
        If his IsNot Nothing Then
            If ostwyc Then
                If OLDdowyc.Width > 10 And OLDdowyc.Height > 10 Then
                    dowyc = OLDdowyc
                Else
                    dowyc = New Rectangle(0, 0, 0, 0)
                End If
                ostwyc = False
            End If
            gfx.DrawImage(his, New Point(0, 0))
            origgfx.DrawImage(his, New Point(0, 0))
            ekran.Image = zrzut
            his.Dispose()
            his = Nothing
        End If
    End Sub

    Private Sub ekran_MouseHover(sender As Object, e As EventArgs) Handles ekran.MouseHover
        If uruchomienie Then
            uruchomienie = False
            Exit Sub
        End If
        If wysuniety Then
            wysuniety = False
            If Not ruch.Enabled Then ruch.Enabled = True
        End If
    End Sub

    Private Sub ekran_MouseLeave(sender As Object, e As EventArgs) Handles ekran.MouseLeave
        If Not wysuniety AndAlso Not ruch.Enabled Then
            wysuniety = True
            ruch.Enabled = True
        End If
    End Sub

    Private Sub zamknij()
        zrzut.Dispose()
        temp.Dispose()
        gfx.Dispose()
        tempgfx.Dispose()
        origimg.Dispose()
        aktkolor.Dispose()
        If his IsNot Nothing Then his.Dispose()
        Close()
    End Sub

    Private Sub APK05zrzut_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then zamykanie.Enabled = True
    End Sub

    Private Sub zamykanie_Tick(sender As Object, e As EventArgs) Handles zamykanie.Tick
        zamknij()
    End Sub

    Private Sub odswiezanie_Tick(sender As Object, e As EventArgs) Handles odswiezanie.Tick
        Static ost As Point = New Point(0, 0)
        Static pocz As Point = New Point(0, 0)
        ex = New MouseEventArgs(ex.Button, ex.Clicks, Cursor.Position.X, Cursor.Position.Y, ex.Delta)
        If rysowaniebtndn AndAlso ex.Button = MouseButtons.None Then
            rysowaniebtndn = False
            ostwyc = False
            Select Case narzedzie
                Case 0

                Case 1
                    gfx.DrawImage(temp, 0, 0)
                    origgfx.DrawImage(temp, 0, 0)
                Case 2
                    gfx.DrawImage(temp, 0, 0)
                    origgfx.DrawImage(temp, 0, 0)
                Case 3
                    If dowyc.Width > 10 And dowyc.Height > 10 Then

                        Dim rysik As Pen = New Pen(Color.Black, 2)
                        rysik.DashStyle = Drawing2D.DashStyle.Dash
                        gfx.DrawRectangle(rysik, New Rectangle(dowyc.X - 2, dowyc.Y - 2, dowyc.Width + 4, dowyc.Height + 4))
                        rysik.Dispose()
                        ostwyc = True
                        ekran.Image = zrzut
                    Else
                        dowyc = OLDdowyc

                        If dowyc.Width > 10 And dowyc.Height > 10 Then
                            Dim rysik As Pen = New Pen(Color.Black, 2)
                            rysik.DashStyle = Drawing2D.DashStyle.Dash
                            gfx.DrawRectangle(rysik, New Rectangle(dowyc.X - 2, dowyc.Y - 2, dowyc.Width + 4, dowyc.Height + 4))
                            rysik.Dispose()
                        End If

                        ekran.Image = zrzut
                    End If
            End Select
        End If
        If ex.Button = MouseButtons.Left Then
            Select Case narzedzie
                Case 0
                    If Not rysowaniebtndn Then
                        rysowaniebtndn = True
                        zapiszzmiany()
                    End If
                    gfx.DrawLine(New Pen(aktkolor.BackColor, gr * 2), ost.X, ost.Y, ex.X, ex.Y)
                    gfx.DrawEllipse(New Pen(aktkolor.BackColor, gr), New Rectangle(ost.X - gr / 2, ost.Y - gr / 2, gr, gr))
                    origgfx.DrawLine(New Pen(aktkolor.BackColor, gr * 2), ost.X, ost.Y, ex.X, ex.Y)
                    origgfx.DrawEllipse(New Pen(aktkolor.BackColor, gr), New Rectangle(ost.X - gr / 2, ost.Y - gr / 2, gr, gr))
                    ekran.Image = zrzut
                Case 1
                    If Not rysowaniebtndn Then
                        rysowaniebtndn = True
                        zapiszzmiany()
                        pocz = New Point(ex.X, ex.Y)
                    End If
                    tempgfx.DrawImage(zrzut, 0, 0)
                    tempgfx.DrawRectangle(New Pen(aktkolor.BackColor, gr * 2), New Rectangle(IIf(ex.X < pocz.X, ex.X, pocz.X), IIf(ex.Y < pocz.Y, ex.Y, pocz.Y), IIf(ex.X < pocz.X, pocz.X - ex.X, ex.X - pocz.X), IIf(ex.Y < pocz.Y, pocz.Y - ex.Y, ex.Y - pocz.Y)))
                    ekran.Image = temp
                Case 2
                    If Not rysowaniebtndn Then
                        rysowaniebtndn = True
                        zapiszzmiany()
                        pocz = New Point(ex.X, ex.Y)
                    End If
                    tempgfx.DrawImage(zrzut, 0, 0)
                    tempgfx.DrawEllipse(New Pen(aktkolor.BackColor, gr * 2), New Rectangle(pocz.X, pocz.Y, ex.X - pocz.X, ex.Y - pocz.Y))
                    ekran.Image = temp
                Case 3
                    If Not rysowaniebtndn Then
                        OLDdowyc = dowyc
                        rysowaniebtndn = True
                        zapiszzmiany()
                        pocz = New Point(ex.X, ex.Y)
                        gfx.DrawImage(origimg, New Point(0, 0))
                    End If
                    tempgfx.DrawImage(zrzut, 0, 0)
                    tempgfx.FillRectangle(przyslona, 0, 0, IIf(pocz.X < ex.X, pocz.X, ex.X), Screen.PrimaryScreen.Bounds.Height)
                    tempgfx.FillRectangle(przyslona, IIf(pocz.X < ex.X, pocz.X, ex.X), IIf(pocz.Y < ex.Y, ex.Y, pocz.Y), Screen.PrimaryScreen.Bounds.Width - IIf(pocz.X < ex.X, pocz.X, ex.X), Screen.PrimaryScreen.Bounds.Height - IIf(pocz.Y < ex.Y, ex.Y, pocz.Y))
                    tempgfx.FillRectangle(przyslona, IIf(pocz.X < ex.X, ex.X, pocz.X), IIf(pocz.Y < ex.Y, pocz.Y, ex.Y), IIf(pocz.X < ex.X, Screen.PrimaryScreen.Bounds.Width - ex.X, Screen.PrimaryScreen.Bounds.Width - pocz.X), IIf(pocz.Y < ex.Y, ex.Y - pocz.Y, pocz.Y - ex.Y))
                    tempgfx.FillRectangle(przyslona, IIf(pocz.X < ex.X, pocz.X, ex.X), 0, Screen.PrimaryScreen.Bounds.Width - IIf(pocz.X < ex.X, pocz.X, ex.X), IIf(pocz.Y < ex.Y, pocz.Y, ex.Y))
                    dowyc = New Rectangle(IIf(pocz.X < ex.X, pocz.X, ex.X), IIf(pocz.Y < ex.Y, pocz.Y, ex.Y), IIf(pocz.X < ex.X, ex.X - pocz.X, pocz.X - ex.X), IIf(pocz.Y < ex.Y, ex.Y - pocz.Y, pocz.Y - ex.Y))
                    ekran.Image = temp
            End Select
        End If
        ost = New Point(ex.X, ex.Y)
    End Sub

    Private Sub ekran_MouseDown(sender As Object, e As MouseEventArgs) Handles ekran.MouseDown
        ex = New MouseEventArgs(e.Button, e.Clicks, Cursor.Position.X, Cursor.Position.Y, e.Delta)
    End Sub

    Private Sub ekran_MouseUp(sender As Object, e As MouseEventArgs) Handles ekran.MouseUp
        If e.Button = MouseButtons.Left Then ex = New MouseEventArgs(MouseButtons.None, e.Clicks, Cursor.Position.X, Cursor.Position.Y, e.Delta)
    End Sub
End Class