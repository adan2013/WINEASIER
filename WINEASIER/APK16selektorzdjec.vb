Public Class APK16selektorzdjec

    Public pathdir As String = ""
    Dim imglist As List(Of String) = New List(Of String)
    Public imgsel As List(Of String) = New List(Of String)
    Dim wybrel As Integer = 0

    Private Sub APK16selektorzdjec_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ekran.Size = New Size(Size.Width - 212, Size.Height - 100)
        infozazn.Location = New Point(Size.Width - 155, infozazn.Location.Y)
    End Sub

    Private Sub btnfolder_Click(sender As Object, e As EventArgs) Handles btnfolder.Click
        seldir.ShowDialog()
        If seldir.SelectedPath = "" Then Exit Sub
        Dim ilel As Integer = 0
        Try
            For Each i As String In My.Computer.FileSystem.GetFiles(seldir.SelectedPath)
                If Not (i = "." Or i = "..") Then
                    Select Case i.Substring(i.LastIndexOf(".") + 1).ToLower()
                        Case "jpg", "png", "bmp", "gif"
                            ilel += 1
                    End Select
                End If
            Next
        Catch ex As Exception
            MsgBox("Brak dostępu do katalogu!", MsgBoxStyle.Exclamation, "WINEASIER")
        Exit Sub
        End Try
        If ilel = 0 Then
            MsgBox("Nie znaleziono zdjęć w wybranym katalogu!", MsgBoxStyle.Information, "WINEASIER")
        Else
            If MsgBox("Znaleziono " & ilel & " zdjęć! Załadować katalog do programu?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then
                pathdir = seldir.SelectedPath
                lblfolder.Text = New IO.DirectoryInfo(pathdir).Name
                wybrel = 0
                imglist.Clear()
                imgsel.Clear()
                For Each i As String In My.Computer.FileSystem.GetFiles(seldir.SelectedPath)
                    If Not (i = "." Or i = "..") Then
                        Select Case i.Substring(i.LastIndexOf(".") + 1).ToLower()
                            Case "jpg", "png", "bmp", "gif"
                                imglist.Add(New IO.FileInfo(i).Name)
                        End Select
                    End If
                Next
                lblilel.Text = wybrel + 1 & " / " & imglist.Count
                nastzdj(0)
            End If
        End If
    End Sub

    Private Sub nastzdj(ByVal kier As SByte)
        If pathdir = "" Or imglist.Count = 0 Then Exit Sub
        Select Case kier
            Case -2
                If wybrel = 0 Then Exit Sub
                wybrel = 0
            Case -1
                wybrel -= 1
                If wybrel < 0 Then
                    wybrel = 0
                    Exit Sub
                End If
            Case 0

            Case 1
                wybrel += 1
                If imglist.Count - 1 < wybrel Then
                    wybrel = imglist.Count - 1
                    Exit Sub
                End If
            Case 2
                If imglist.Count - 1 = wybrel Then Exit Sub
                wybrel = imglist.Count - 1
        End Select
        kom.Visible = False
        infozazn.Visible = False
        lblilel.Text = wybrel + 1 & " / " & imglist.Count
        lblzazn.Text = "Zaznaczonych: " & imgsel.Count
        Try
            If ekran.Image IsNot Nothing Then ekran.Image.Dispose()
            ekran.Image = Image.FromFile(pathdir & "\" & imglist.Item(wybrel))
            lblinfo.Text = "Nazwa: " & imglist.Item(wybrel) & vbNewLine & "Rozmiar: " & Math.Round(New IO.FileInfo(pathdir & "\" & imglist.Item(wybrel)).Length / 1024 / 1024, 1) & " MB" & vbNewLine & "Rozdzielczość: " & ekran.Image.Size.Width & "x" & ekran.Image.Size.Height
            If jestzazn(imglist(wybrel)) Then infozazn.Visible = True
        Catch ex As Exception
            kom.Text = "Błąd ładowania obrazka"
            kom.Visible = True
        End Try
    End Sub

    Private Function jestzazn(ByVal nazwa As String) As Boolean
        For Each i As String In imgsel
            If nazwa = i Then Return True
        Next
        Return False
    End Function

    Private Sub APK16selektorzdjec_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Left, Keys.Up
                nastzdj(-1)
            Case Keys.Right, Keys.Down
                nastzdj(1)
            Case Keys.Home
                nastzdj(-2)
            Case Keys.End
                nastzdj(2)
            Case Keys.Delete
                If jestzazn(imglist(wybrel)) Then
                    imgsel.Remove(imglist(wybrel))
                    infozazn.Visible = False
                Else
                    imgsel.Add(imglist(wybrel))
                    infozazn.Visible = True
                End If
                lblzazn.Text = "Zaznaczonych: " & imgsel.Count
        End Select
    End Sub

    Private Sub btnprzenies_Click(sender As Object, e As EventArgs) Handles btnprzenies.Click
        If imgsel.Count = 0 Then
            MsgBox("Brak zaznaczonych zdjęć!", MsgBoxStyle.Exclamation, "WINEASIER")
        Else
            wybrel = 0
            imglist.Clear()
            imglist.AddRange(imgsel)
            imgsel.Clear()
            nastzdj(0)
            MsgBox("Przeniesionych zdjęć: " & imglist.Count, MsgBoxStyle.Information, "WINEASIER")
        End If
    End Sub

    Private Sub btnallzazn_Click(sender As Object, e As EventArgs) Handles btnallzazn.Click
        imgsel.Clear()
        imgsel.AddRange(imglist)
        nastzdj(0)
    End Sub

    Private Sub btnczysc_Click(sender As Object, e As EventArgs) Handles btnczysc.Click
        imgsel.Clear()
        nastzdj(0)
    End Sub

    Private Sub btnzakoncz_Click(sender As Object, e As EventArgs) Handles btnzakoncz.Click
        If imgsel.Count = 0 Then
            MsgBox("Brak zaznaczonych zdjęć!", MsgBoxStyle.Exclamation, "WINEASIER")
        Else
            APK16zakoncz.ShowDialog()
            APK16zakoncz.Close()
        End If
    End Sub

    Private Sub APK16selektorzdjec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico16.GetHicon())
        START.pobierzparametr(16)
    End Sub
End Class