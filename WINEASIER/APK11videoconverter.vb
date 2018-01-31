Imports System.IO
Imports System.Threading
Public Class APK11videoconverter

    Public pliki As List(Of String) = New List(Of String)
    Dim panelwew As Panel = New Panel()
    Dim teksty As List(Of MetroFramework.Controls.MetroLabel) = New List(Of MetroFramework.Controls.MetroLabel)
    Dim btnusun As List(Of MetroFramework.Controls.MetroLink) = New List(Of MetroFramework.Controls.MetroLink)
    Public out As String = ""

    Dim fileaudio As String = ""
    Dim filesrt As String = ""

    Public proc As Process = New Process()
    Public trd As Thread = New Thread(AddressOf TRDevent)
    Public wyjscieprocesu As String = ""

    Private Sub APK11videoconverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico11.GetHicon())
        START.pobierzparametr(11)
        If Not START.checkffmpeg Then Close()
        CheckForIllegalCrossThreadCalls = False
        listawa.SelectedIndex = 0
        listaoa.SelectedIndex = 0
        listatyp.SelectedIndex = 0
        nrfps.Value = 30
        ladujliste()
        MetroTabControl1.SelectedTab = MetroTabPage1
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
        dodajpliki.Multiselect = True
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

    Private Sub APK11videoconverter_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
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
        If chkboxprzytnij.Checked Then
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
        If switchpodmienaudio.Checked Then
            If fileaudio = "" Then
                MsgBox("Nie wybrano pliku audio!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            If Not IO.File.Exists(fileaudio) Then
                MsgBox("Wybrany plik audio nie istnieje!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
        End If
        If switchsrt.Checked Then
            If filesrt = "" Then
                MsgBox("Nie wybrano pliku z napisami!", MsgBoxStyle.Exclamation, "WINEASIER")
                Exit Sub
            End If
            If Not IO.File.Exists(filesrt) Then
                MsgBox("Wybrany plik z napisami nie istnieje!", MsgBoxStyle.Exclamation, "WINEASIER")
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
        trd.IsBackground = True
        APK11progress.ShowDialog()
        APK11progress.Close()
    End Sub

    Private Function tempowideo() As String
        Select Case CInt(bartempow.Value) + 2
            Case 2
                Return "2.0"
            Case 3
                Return "1.8"
            Case 4
                Return "1.6"
            Case 5
                Return "1.4"
            Case 6
                Return "1.2"
            Case 7
                Return "1.0"
            Case 8
                Return "0.8"
            Case 9
                Return "0.6"
            Case 10
                Return "0.4"
            Case 11
                Return "0.2"
            Case Else
                Return "1.0"
        End Select
    End Function

    Private Function tempoaudio() As String
        Select Case CInt(bartempoa.Value)
            Case 2
                Return "0.6"
            Case 3
                Return "0.8"
            Case 4
                Return "1.0"
            Case 5
                Return "1.2"
            Case 6
                Return "1.4"
            Case 7
                Return "1.6"
            Case 8
                Return "1.8"
            Case 9
                Return "2.0"
            Case Else
                Return "1.0"
        End Select
    End Function

    Private Function volaudio() As String
        Select Case CInt(barvol.Value)
            Case 0
                Return "0.2"
            Case 1
                Return "0.4"
            Case 2
                Return "0.6"
            Case 3
                Return "0.8"
            Case 4
                Return "1.0"
            Case 5
                Return "1.2"
            Case 6
                Return "1.4"
            Case 7
                Return "1.6"
            Case 8
                Return "1.8"
            Case 9
                Return "2.0"
            Case Else
                Return "1.0"
        End Select
    End Function

    Private Sub TRDevent()
        Try
            Dim wzorzec As String = "-i ""$INPUT$"""

            If Not listatyp.SelectedIndex = 1 AndAlso switchpodmienaudio.Checked Then
                wzorzec &= " -i """ & fileaudio & """"
            End If
            If Not listatyp.SelectedIndex = 2 AndAlso switchsrt.Checked Then
                wzorzec &= " -i """ & filesrt & """ -c:s mov_text"
            End If
            If chkboxprzytnij.Checked Then
                If chkboxdokonca.Checked Then
                    wzorzec &= " -ss " & txtpocz.Text
                Else
                    wzorzec &= " -ss " & txtpocz.Text & " -to " & txtkoniec.Text
                End If
            End If
            If listatyp.SelectedIndex = 1 Then wzorzec &= " -an"
            If listatyp.SelectedIndex = 2 Then wzorzec &= " -vn"
            If Not listatyp.SelectedIndex = 2 AndAlso switchklatki.Checked Then
                wzorzec &= " -r " & CInt(nrfps.Value)
            End If
            If Not listatyp.SelectedIndex = 2 AndAlso switchrozdz.Checked Then
                wzorzec &= " -s " & CInt(rozdzx.Value) & "x" & CInt(rozdzy.Value)
            End If
            If Not listatyp.SelectedIndex = 2 AndAlso switchtempo.Checked Then
                wzorzec &= " -filter:v ""setpts=" & tempowideo() & "*PTS"""
            End If
            If Not listatyp.SelectedIndex = 1 AndAlso switchvol.Checked Then
                wzorzec &= " -af ""volume=" & volaudio() & """"
            End If
            If Not listatyp.SelectedIndex = 1 AndAlso switchtempoa.Checked Then
                wzorzec &= " -filter:a ""atempo=" & tempoaudio() & """"
            End If
            If chkboxnadpisuj.Checked Then wzorzec &= " -y"

            wzorzec &= " ""$OUTPUT$"""
            For i As Byte = 0 To pliki.Count - 1 Step 1
                Dim plik As String = pliki(i)
                Dim plikout As String = ""
                If listatyp.SelectedIndex = 2 Then
                    plikout = out & "\" & My.Computer.FileSystem.GetName(plik).Substring(0, My.Computer.FileSystem.GetName(plik).LastIndexOf(".")) & listaoa.Text
                Else
                    plikout = out & "\" & My.Computer.FileSystem.GetName(plik).Substring(0, My.Computer.FileSystem.GetName(plik).LastIndexOf(".")) & listawa.Text
                End If
                Dim argumenty As String = wzorzec
                argumenty = argumenty.Replace("$INPUT$", plik)
                argumenty = argumenty.Replace("$OUTPUT$", plikout)
                Invoke(Sub() APK11progress.lbl1.Text = My.Computer.FileSystem.GetName(plik))
                Invoke(Sub() APK11progress.lbl2.Text = i + 1 & " / " & pliki.Count)
                Invoke(Sub() APK11progress.progbar.Value = (i + 1) * 100 / pliki.Count)
                Invoke(Sub() APK11progress.dodajhis("Rozpoczynanie konwersji pliku " & My.Computer.FileSystem.GetName(plik)))
                Dim roz As String = plik.Substring(plik.LastIndexOf(".") + 1).ToLower()
                If roz = "mp4" OrElse roz = "avi" OrElse roz = "flv" OrElse roz = "3gp" OrElse roz = "wmv" Then
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
                    Loop Until proc.HasExited ' And Invoke(Function() APK11progress.Visible) AndAlso Invoke(Function() APK11progress.historia.Item(0)) = ""
                    Invoke(Sub() APK11progress.dodajhis("Konwersja pliku " & My.Computer.FileSystem.GetName(plik) & " zakończona!"))

                End If
            Next
            Invoke(Sub() APK11progress.dodajhis("Konwersja zakończona"))
            Invoke(Sub() APK11progress.koniec = True)
            Invoke(Sub() APK11progress.btnzatrzymaj.Text = "Zamknij okno")
            Invoke(Sub() APK11progress.lbltytul.Text = "Konwersja zakończona!")
            Invoke(Sub() APK11progress.akt.Enabled = False)
        Catch
            APK11progress.msgboxerr()
            Try
                proc.Kill()
            Catch

            End Try
        Finally
            If APK11progress.Visible Then APK11progress.Close()
        End Try
    End Sub

    Private Sub btnaudio_Click(sender As Object, e As EventArgs) Handles btnaudio.Click
        dodajpliki.Multiselect = False
        dodajpliki.ShowDialog()
        If Not dodajpliki.FileName = "" Then
            Dim roz As String = dodajpliki.FileName.Substring(dodajpliki.FileName.LastIndexOf(".") + 1)
            If roz = "mp3" OrElse roz = "wav" OrElse roz = "wma" OrElse roz = "ogg" OrElse roz = "aac" Then
                fileaudio = dodajpliki.FileName
                lblfileaudio.Text = My.Computer.FileSystem.GetName(fileaudio)
            Else
                MsgBox("Format pliku nie jest obsługiwany!", MsgBoxStyle.Critical, "WINEASIER")
            End If
        End If
    End Sub

    Private Sub btnsrt_Click(sender As Object, e As EventArgs) Handles btnsrt.Click
        dodajpliki.Multiselect = False
        dodajpliki.ShowDialog()
        If Not dodajpliki.FileName = "" Then
            If dodajpliki.FileName.Substring(dodajpliki.FileName.LastIndexOf(".") + 1) = "srt" Then
                filesrt = dodajpliki.FileName
                lblsrt.Text = My.Computer.FileSystem.GetName(filesrt)
            Else
                MsgBox("Format pliku nie jest obsługiwany!", MsgBoxStyle.Critical, "WINEASIER")
            End If
        End If
    End Sub

    Private Sub bartempow_ValueChanged(sender As Object, e As EventArgs) Handles bartempow.ValueChanged
        Select Case CInt(bartempow.Value)
            Case 0
                lbltempow.Text = "0.2x"
            Case 1
                lbltempow.Text = "0.4x"
            Case 2
                lbltempow.Text = "0.6x"
            Case 3
                lbltempow.Text = "0.8x"
            Case 4
                lbltempow.Text = "1.0x"
            Case 5
                lbltempow.Text = "1.2x"
            Case 6
                lbltempow.Text = "1.4x"
            Case 7
                lbltempow.Text = "1.6x"
            Case 8
                lbltempow.Text = "1.8x"
            Case 9
                lbltempow.Text = "2.0x"
            Case Else
                lbltempow.Text = "1.0x"
        End Select
    End Sub

    Private Sub bartempoa_ValueChanged(sender As Object, e As EventArgs) Handles bartempoa.ValueChanged
        lbltempoa.Text = tempoaudio() & "x"
    End Sub

    Private Sub barvol_ValueChanged(sender As Object, e As EventArgs) Handles barvol.ValueChanged
        Select Case CInt(barvol.Value)
            Case 0
                lblvol.Text = "20%"
            Case 1
                lblvol.Text = "40%"
            Case 2
                lblvol.Text = "60%"
            Case 3
                lblvol.Text = "80%"
            Case 4
                lblvol.Text = "100%"
            Case 5
                lblvol.Text = "120%"
            Case 6
                lblvol.Text = "140%"
            Case 7
                lblvol.Text = "160%"
            Case 8
                lblvol.Text = "180%"
            Case 9
                lblvol.Text = "200%"
            Case Else
                lblvol.Text = "100%"
        End Select
    End Sub
End Class