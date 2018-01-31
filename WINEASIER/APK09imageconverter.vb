Imports System.Threading
Public Class APK09imageconverter

    Dim pliki As List(Of String) = New List(Of String)
    Dim panelwew As Panel = New Panel()
    Dim teksty As List(Of MetroFramework.Controls.MetroLabel) = New List(Of MetroFramework.Controls.MetroLabel)
    Dim btnusun As List(Of MetroFramework.Controls.MetroLink) = New List(Of MetroFramework.Controls.MetroLink)
    Dim PROCES As Thread = New Thread(AddressOf TRDproces)
    Dim pracuje As Boolean = False
    Dim out As String = ""

    Private Sub APK09imageconverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico9.GetHicon())
        START.pobierzparametr(9)
        trybkonwersji.SelectedIndex = 0
        CheckForIllegalCrossThreadCalls = False
        ladujliste()
    End Sub

    Private Sub ladujliste()
        If pliki.Count > 120 Then
            MsgBox("Przekroczono maksymalną liczbę plików!", MsgBoxStyle.Exclamation, "WINEASIER")
            pliki.RemoveRange(120, pliki.Count - 121)
        End If
        panelpliki.Controls.Clear()
        panelwew = New Panel()
        teksty.Clear()
        btnusun.Clear()
        With panelwew
            .Location = New Point(0, 0)
            .Size = New Size(panelpliki.Width, panelpliki.Height)
        End With
        If pliki.Count = 0 Then
            Dim info As MetroFramework.Controls.MetroLabel = New MetroFramework.Controls.MetroLabel()
            With info
                .Text = "Brak wybranych plików" & vbNewLine & "Przeciągnij pliki nad to pole lub użyj przycisku u góry okna"
                .TextAlign = ContentAlignment.MiddleCenter
                .Location = New Point(0, 0)
                .Size = New Size(panelpliki.Size.Width, panelpliki.Size.Height)
                .UseCustomForeColor = True
                .ForeColor = Color.Gray
            End With
            panelwew.Controls.Add(info)
        Else
            Dim lp As Byte = 0
            For Each i As String In pliki
                teksty.Add(New MetroFramework.Controls.MetroLabel())
                btnusun.Add(New MetroFramework.Controls.MetroLink())
                With btnusun(lp)
                    .Name = "file" & lp
                    .Cursor = Cursors.Hand
                    .Text = "Usuń"
                    .Location = New Point(panelpliki.Size.Width - 50, 20 * lp)
                    .Size = New Size(50, 20)
                End With
                With teksty(lp)
                    .Text = My.Computer.FileSystem.GetName(i)
                    .TextAlign = ContentAlignment.MiddleLeft
                    .Location = New Point(0, 20 * lp)
                    .Size = New Size(panelpliki.Size.Width - 50, 20)
                End With
                panelwew.Size = New Size(panelpliki.Size.Width, 20 * lp + 20)
                panelwew.Controls.Add(teksty(lp))
                panelwew.Controls.Add(btnusun(lp))
                AddHandler btnusun(lp).Click, AddressOf usunpoz
                lp += 1
            Next
        End If
        panelpliki.Controls.Add(panelwew)
        If panelwew.Location.Y < 0 Then lblup.Visible = True
        If panelwew.Location.Y + panelwew.Size.Height > panelpliki.Size.Height Then lbldn.Visible = True
        lblprogress.Text = "0 / " & pliki.Count
        progress.Value = 0
    End Sub

    Private Sub usunpoz(sender As Object, e As EventArgs)
        pliki.RemoveAt(sender.Name.Substring(4))
        ladujliste()
    End Sub

    Private Sub btnwyczysc_Click(sender As Object, e As EventArgs) Handles btnwyczysc.Click
        pliki.Clear()
        ladujliste()
    End Sub

    Private Sub panelpliki_DragDrop(sender As Object, e As DragEventArgs) Handles panelpliki.DragDrop
        Dim modyf As Boolean = False
        Dim istnieje As Boolean = False
        For Each path As String In e.Data.GetData(DataFormats.FileDrop)
            If IO.File.Exists(path) Then
                istnieje = False
                For Each i As String In pliki
                    If i = path Then
                        istnieje = True
                        Exit For
                    End If
                Next
                If Not istnieje Then
                    pliki.Add(path)
                    modyf = True
                End If
            End If
        Next
        If modyf Then ladujliste()
    End Sub

    Private Sub panelpliki_DragEnter(sender As Object, e As DragEventArgs) Handles panelpliki.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub btndodaj_Click(sender As Object, e As EventArgs) Handles btndodaj.Click
        dodajpliki.ShowDialog()
        Dim modyf As Boolean = False
        Dim istnieje As Boolean = False
        For Each path As String In dodajpliki.FileNames
            istnieje = False
            For Each i As String In pliki
                If i = path Then
                    istnieje = True
                    Exit For
                End If
            Next
            If Not istnieje Then
                pliki.Add(path)
                modyf = True
            End If
        Next
        If modyf Then ladujliste()
    End Sub

    Private Sub APK09imageconverter_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then
            If panelwew.Location.Y < 0 Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y + 30)
            End If
        Else
            If panelpliki.Size.Height < panelwew.Location.Y + panelwew.Size.Height Then
                panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y - 30)
            End If
        End If
        lblup.Visible = False
        lbldn.Visible = False
        If panelwew.Location.Y < 0 Then lblup.Visible = True
        If panelwew.Location.Y + panelwew.Size.Height > panelpliki.Size.Height Then lbldn.Visible = True
    End Sub

    Private Sub lbldn_Click(sender As Object, e As EventArgs) Handles lbldn.Click
        If panelpliki.Size.Height < panelwew.Location.Y + panelwew.Size.Height Then
            panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y - 30)
            lblup.Visible = False
            lbldn.Visible = False
            If panelwew.Location.Y < 0 Then lblup.Visible = True
            If panelwew.Location.Y + panelwew.Size.Height > panelpliki.Size.Height Then lbldn.Visible = True
        End If
    End Sub

    Private Sub lblup_Click(sender As Object, e As EventArgs) Handles lblup.Click
        If panelwew.Location.Y < 0 Then
            panelwew.Location = New Point(panelwew.Location.X, panelwew.Location.Y + 30)
            lblup.Visible = False
            lbldn.Visible = False
            If panelwew.Location.Y < 0 Then lblup.Visible = True
            If panelwew.Location.Y + panelwew.Size.Height > panelpliki.Size.Height Then lbldn.Visible = True
        End If
    End Sub

    Private Sub TRDproces()
        Try
            For i As Byte = 0 To pliki.Count - 1 Step 1
                Dim plik As String = pliki(i)
                Dim roz As String = plik.Substring(plik.LastIndexOf(".") + 1).ToLower()
                If roz = "png" OrElse roz = "bmp" OrElse roz = "jpg" OrElse roz = "gif" Then
                    Try
                        Dim obraz As Image = New Bitmap(plik)
                        If trybkonwersji.SelectedIndex = 1 Or trybkonwersji.SelectedIndex = 3 Then
                            Dim przyc As Bitmap = New Bitmap(CInt(bx.Value), CInt(by.Value))
                            Using gfx As Graphics = Graphics.FromImage(przyc)
                                gfx.DrawImage(obraz, New Rectangle(0, 0, CInt(bx.Value), CInt(by.Value)), New Rectangle(CInt(ax.Value), CInt(ay.Value), CInt(bx.Value), CInt(by.Value)), GraphicsUnit.Pixel)
                            End Using
                            obraz.Dispose()
                            obraz = New Bitmap(przyc)
                            przyc.Dispose()
                        End If
                        If trybkonwersji.SelectedIndex = 2 Or trybkonwersji.SelectedIndex = 3 Then
                            Dim wspsk As Double = 0
                            Dim rozmiargr As Size
                            If skalujdox.Checked Then
                                rozmiargr = New Size(CInt(skalarozx.Value), CInt(skalarozx.Value) * obraz.Size.Height / obraz.Size.Width)
                            Else
                                If skalujdoy.Checked Then
                                    rozmiargr = New Size(CInt(skalarozy.Value) * obraz.Size.Width / obraz.Size.Height, CInt(skalarozy.Value))
                                Else
                                    rozmiargr = New Size(CInt(skalarozx.Value), CInt(skalarozy.Value))
                                End If
                            End If
                            obraz = New Bitmap(obraz, rozmiargr)
                        End If
                        If IO.File.Exists(out & "\" & My.Computer.FileSystem.GetName(plik).Substring(0, My.Computer.FileSystem.GetName(plik).LastIndexOf(".")) & getendnamefile()) Then
                            If chkboxoverwrite.Checked Then obraz.Save(out & "\" & My.Computer.FileSystem.GetName(plik).Substring(0, My.Computer.FileSystem.GetName(plik).LastIndexOf(".")) & getendnamefile(), getimagingformat())
                        Else
                            obraz.Save(out & "\" & My.Computer.FileSystem.GetName(plik).Substring(0, My.Computer.FileSystem.GetName(plik).LastIndexOf(".")) & getendnamefile(), getimagingformat())
                        End If
                    Catch ex As Exception

                    End Try
                End If
                lblprogress.Text = i + 1 & " / " & pliki.Count
                progress.Value = (i + 1) * 100 / pliki.Count
            Next
        Catch
            MsgBox("Wystąpił błąd krytyczny konwersji!" & vbNewLine & "Operacja została przerwana.", MsgBoxStyle.Critical, "WINEASIER")
        Finally
            pracuje = False
            chkboxoverwrite.Enabled = True
            typpng.Enabled = True
            typbmp.Enabled = True
            typjpg.Enabled = True
            typgif.Enabled = True
            trybkonwersji.Enabled = True
            ax.Enabled = True
            ay.Enabled = True
            bx.Enabled = True
            by.Enabled = True
            btndodaj.Enabled = True
            btnwyczysc.Enabled = True
            btnuruchom.Text = "Uruchom konwersje"
        End Try
    End Sub

    Private Function getendnamefile() As String
        If typpng.Checked Then Return ".png"
        If typbmp.Checked Then Return ".bmp"
        If typjpg.Checked Then Return ".jpg"
        If typgif.Checked Then Return ".gif"
        Return ".png"
    End Function

    Private Function getimagingformat() As Imaging.ImageFormat
        If typpng.Checked Then Return Imaging.ImageFormat.Png
        If typbmp.Checked Then Return Imaging.ImageFormat.Bmp
        If typjpg.Checked Then Return Imaging.ImageFormat.Jpeg
        If typgif.Checked Then Return Imaging.ImageFormat.Gif
        Return Imaging.ImageFormat.Png
    End Function

    Private Sub btnuruchom_Click(sender As Object, e As EventArgs) Handles btnuruchom.Click
        If pracuje Then
            pracuje = False
            chkboxoverwrite.Enabled = True
            typpng.Enabled = True
            typbmp.Enabled = True
            typjpg.Enabled = True
            typgif.Enabled = True
            trybkonwersji.Enabled = True
            ax.Enabled = True
            ay.Enabled = True
            bx.Enabled = True
            by.Enabled = True
            btndodaj.Enabled = True
            btnwyczysc.Enabled = True
            btnuruchom.Text = "Uruchom konwersje"
            PROCES.Abort()
        Else
            If pliki.Count = 0 Then
                MsgBox("Nie wybrano plików do konwersji!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            If trybkonwersji.SelectedIndex = 1 Or trybkonwersji.SelectedIndex = 3 Then
                If bx.Value < 10 OrElse by.Value < 10 Then
                    MsgBox("Minimalny obszar wycinanego obrazu to 10x10px!", MsgBoxStyle.Exclamation, "WINEASIER")
                    Exit Sub
                End If
            End If
            If trybkonwersji.SelectedIndex = 2 Or trybkonwersji.SelectedIndex = 3 Then
                If skalujdox.Checked AndAlso skalarozx.Value < 10 Then
                    MsgBox("Minimalna szerokość skalowania to 10px!", MsgBoxStyle.Exclamation, "WINEASIER")
                    Exit Sub
                End If
                If skalujdoy.Checked AndAlso skalarozy.Value < 10 Then
                    MsgBox("Minimalna wysokość skalowania to 10px!", MsgBoxStyle.Exclamation, "WINEASIER")
                    Exit Sub
                End If
                If skalujdowymiaru.Checked AndAlso (skalarozx.Value < 10 Or skalarozy.Value < 10) Then
                    MsgBox("Minimalny rozmiar skalowania to 10x10px!", MsgBoxStyle.Exclamation, "WINEASIER")
                    Exit Sub
                End If
            End If
            folderoutput.ShowDialog()
            If folderoutput.SelectedPath = "" Then
                Exit Sub
            Else
                out = folderoutput.SelectedPath
            End If
            pracuje = True
            chkboxoverwrite.Enabled = False
            typpng.Enabled = False
            typbmp.Enabled = False
            typjpg.Enabled = False
            typgif.Enabled = False
            trybkonwersji.Enabled = False
            ax.Enabled = False
            ay.Enabled = False
            bx.Enabled = False
            by.Enabled = False
            btndodaj.Enabled = False
            btnwyczysc.Enabled = False
            btnuruchom.Text = "Zatrzymaj"
            PROCES = New Thread(AddressOf TRDproces)
            PROCES.Start()
        End If
    End Sub

    Private Sub APK09imageconverter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If pracuje Then
            e.Cancel = True
            MsgBox("Najpierw zatrzymaj proces konwerterowania obrazów!", MsgBoxStyle.Exclamation, "WINEASIER")
        End If
    End Sub
End Class