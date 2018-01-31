Imports System.IO
Imports System.Threading
Public Class APK10audioconverter

    Public pliki As List(Of String) = New List(Of String)
    Dim panelwew As Panel = New Panel()
    Dim teksty As List(Of MetroFramework.Controls.MetroLabel) = New List(Of MetroFramework.Controls.MetroLabel)
    Dim btnusun As List(Of MetroFramework.Controls.MetroLink) = New List(Of MetroFramework.Controls.MetroLink)
    Public out As String = ""

    Public proc As Process = New Process()
    Public trd As Thread = New Thread(AddressOf TRDevent)
    Public wyjscieprocesu As String = ""

    Private Sub APK10audioconverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico10.GetHicon())
        START.pobierzparametr(10)
        If Not START.checkffmpeg() Then Close()
        CheckForIllegalCrossThreadCalls = False
        listawyjsciowy.SelectedIndex = 0
        listahz.Value = 44100
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

    Private Sub APK10audioconverter_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
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

    Private Sub btnuruchom_Click(sender As Object, e As EventArgs) Handles btnuruchom.Click
        If pliki.Count = 0 Then
            MsgBox("Nie wybrano plików do konwersji!", MsgBoxStyle.Exclamation, "WINEASIER")
            Exit Sub
        End If
        If switchprzytnij.Checked Then
            If Not txtpocz.Text Like "##[:]##[:]##" Then
                MsgBox("Początek nie jest zgodny ze wzorcem hh:mm:ss!" & vbNewLine & "np. 01:14:07", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            If Not chkboxdokonca.Checked Then
                If Not txtkoniec.Text Like "##[:]##[:]##" Then
                    MsgBox("Koniec nie jest zgodny ze wzorcem hh:mm:ss!" & vbNewLine & "np. 01:14:07", MsgBoxStyle.Exclamation, "WINEASIER")
                    Exit Sub
                End If
            End If
            If txtpocz.Text.Substring(0, 2) > 2 Then
                MsgBox("Czas początku wykracza poza dopuszczalny zakres!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            If txtpocz.Text.Substring(3, 2) > 59 Then
                MsgBox("Czas początku wykracza poza dopuszczalny zakres!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            If txtpocz.Text.Substring(6, 2) > 59 Then
                MsgBox("Czas początku wykracza poza dopuszczalny zakres!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            If txtkoniec.Text.Substring(0, 2) > 2 Then
                MsgBox("Czas końca wykracza poza dopuszczalny zakres!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            If txtkoniec.Text.Substring(3, 2) > 59 Then
                MsgBox("Czas końca wykracza poza dopuszczalny zakres!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            If txtkoniec.Text.Substring(6, 2) > 59 Then
                MsgBox("Czas końca wykracza poza dopuszczalny zakres!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            If Not chkboxdokonca.Checked AndAlso txtpocz.Text.Replace(":", "") > txtkoniec.Text.Replace(":", "") Then
                MsgBox("Czas początku wycinka nie może być większy niż czas końca wycinka!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
        End If
        folderoutput.ShowDialog()
        If folderoutput.SelectedPath = "" Then
            Exit Sub
        Else
            out = folderoutput.SelectedPath
        End If
        trd = New Thread(AddressOf TRDevent)
        APK10progress.ShowDialog()
        APK10progress.Close()
    End Sub

    Private Sub TRDevent()
        Try
            Dim wzorzec As String = "-i ""$INPUT$"""
            If switchprzytnij.Checked Then
                If chkboxdokonca.Checked Then
                    wzorzec &= " -ss " & txtpocz.Text
                Else
                    wzorzec &= " -ss " & txtpocz.Text & " -to " & txtkoniec.Text
                End If
            End If
            If switchjakosc.Checked Then
                wzorzec &= " -qscale:a " & Math.Abs(jakosc.Value - 9)
            End If
            If switchhz.Checked Then
                wzorzec &= " -ar " & CInt(listahz.Value)
            End If
            If chkboxnadpisuj.Checked Then
                wzorzec &= " -y"
            End If
            wzorzec &= " ""$OUTPUT$"""
            For i As Byte = 0 To pliki.Count - 1 Step 1
                Dim plik As String = pliki(i)
                Dim plikout As String = out & "\" & My.Computer.FileSystem.GetName(plik).Substring(0, My.Computer.FileSystem.GetName(plik).LastIndexOf(".")) & listawyjsciowy.Text
                Dim argumenty As String = wzorzec
                argumenty = argumenty.Replace("$INPUT$", plik)
                argumenty = argumenty.Replace("$OUTPUT$", plikout)
                Invoke(Sub() APK10progress.lbl1.Text = My.Computer.FileSystem.GetName(plik))
                Invoke(Sub() APK10progress.lbl2.Text = i + 1 & " / " & pliki.Count)
                Invoke(Sub() APK10progress.progbar.Value = (i + 1) * 100 / pliki.Count)
                Invoke(Sub() APK10progress.dodajhis("Rozpoczynanie konwersji pliku " & My.Computer.FileSystem.GetName(plik)))
                Dim roz As String = plik.Substring(plik.LastIndexOf(".") + 1).ToLower()
                If roz = "mp3" OrElse roz = "wav" OrElse roz = "wma" OrElse roz = "ogg" OrElse roz = "aac" Then
                    If Not chkboxnadpisuj.Checked Then
                        If IO.File.Exists(plikout) Then Continue For
                    End If
                    Dim procinfo As ProcessStartInfo = New ProcessStartInfo()
                    With procinfo
                        .FileName = Invoke(Function() START.folderffmpeg)
                        .Arguments = argumenty
                        .UseShellExecute = False
                        .WindowStyle = ProcessWindowStyle.Hidden
                        .RedirectStandardError = True
                        .RedirectStandardOutput = True
                        .CreateNoWindow = True
                    End With
                    proc = New Process()
                    With proc
                        .StartInfo = procinfo
                        .Start()
                    End With
                    Dim sr As StreamReader
                    sr = proc.StandardError
                    Do
                        wyjscieprocesu = sr.ReadLine
                    Loop Until proc.HasExited ' And Invoke(Function() APK10progress.historia.Item(0)) = ""
                    Invoke(Sub() APK10progress.dodajhis("Konwersja pliku " & My.Computer.FileSystem.GetName(plik) & " zakończona!"))

                End If
            Next
            Invoke(Sub() APK10progress.dodajhis("Konwersja zakończona"))
            Invoke(Sub() APK10progress.koniec = True)
            Invoke(Sub() APK10progress.btnzatrzymaj.Text = "Zamknij okno")
            Invoke(Sub() APK10progress.lbltytul.Text = "Konwersja zakończona!")
        Catch
            APK10progress.msgboxerr()
            Try
                proc.Kill()
            Catch

            End Try
        Finally
            If APK10progress.Visible Then APK10progress.Close()
        End Try
    End Sub
End Class