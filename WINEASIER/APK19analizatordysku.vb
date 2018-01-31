Public Class APK19analizatordysku

    Dim sciezka As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Dim analizawtoku As Boolean = False
    Dim statkat As Integer = 0
    Dim stataccess As Integer = 0
    Dim sep As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
    Dim TRDproces As Threading.Thread = New Threading.Thread(AddressOf TRDevent)

    Dim treesize As TreeView = New TreeView()

    Private Sub APK19analizatordysku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico19.GetHicon())
        START.pobierzparametr(19)
        CheckForIllegalCrossThreadCalls = False
        lblpath.Text = sciezka
    End Sub

    Private Sub btnzmien_Click(sender As Object, e As EventArgs) Handles btnzmien.Click
        dirdialog.ShowDialog()
        If IO.Directory.Exists(dirdialog.SelectedPath) Then
            sciezka = dirdialog.SelectedPath
            lblpath.Text = sciezka
        End If
    End Sub

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        If analizawtoku Then
            If MsgBox("Anulować proces analizowania dysku?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then
                analizawtoku = False
                btnstart.Text = "Rozpocznij analizę"
                lblanaliza.Text = "Analiza zatrzymana"
                spinprogress.Spinning = False
                btnzmien.Enabled = True
                Try
                    TRDproces.Abort()
                Catch ex As Exception

                Finally
                    drzewo.Nodes.Clear()
                End Try
            End If
        Else
            If MsgBox("Rozpocząć proces analizy dysku?" & vbNewLine & "Może to zająć trochę czasu", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then
                analizawtoku = True
                btnstart.Text = "Zatrzymaj analizę"
                btnzmien.Enabled = False
                spinprogress.Spinning = True
                TRDproces = New Threading.Thread(AddressOf TRDevent)
                TRDproces.IsBackground = True
                TRDproces.Start()
            End If
        End If
    End Sub

    Private Sub TRDevent()
        Try
            statkat = 0
            stataccess = 0
            lblanaliza.Text = "Analiza w toku..."
            drzewo.Nodes.Clear()
            treesize.Nodes.Clear()
            graf.Visible = False
            Invoke(Sub() drzewo.Nodes.Add(sciezka))
            Invoke(Sub() treesize.Nodes.Add(0))
            PopulateTreeView(sciezka, drzewo.Nodes.Item(0), treesize.Nodes.Item(0))
            analizawtoku = False
            btnstart.Text = "Rozpocznij analizę"
            spinprogress.Spinning = False
            btnzmien.Enabled = True
            lblanaliza.Text = "Analiza zakończona pomyślnie"
            lblstat.Text = statkat & " katalogów / " & stataccess & " błędów braku dostępu"
        Catch ex As Exception
            If analizawtoku Then
                analizawtoku = False
                btnstart.Text = "Rozpocznij analizę"
                spinprogress.Spinning = False
                btnzmien.Enabled = True
                lblanaliza.Text = "Analiza zakończona błędem"
                lblstat.Text = statkat & " katalogów / " & stataccess & " błędów braku dostępu"
                drzewo.Nodes.Clear()
            End If
        End Try
    End Sub

    Private Sub PopulateTreeView(ByVal dir As String, ByVal parentNode As TreeNode, ByVal treesizeNode As TreeNode)
        For Each i As String In IO.Directory.GetDirectories(dir)
            Try
                Dim childNode As TreeNode = New TreeNode(New IO.DirectoryInfo(i).Name)
                Dim sizeNode As TreeNode = New TreeNode(GetFilesSize(i))
                Invoke(Sub() parentNode.Nodes.Add(childNode))
                Invoke(Sub() treesizeNode.Nodes.Add(sizeNode))
                GenerateSizeString(childNode, sizeNode)
                statkat += 1
                Dim robTEXT As TreeNode = parentNode
                Dim robSIZE As TreeNode = treesizeNode
                Do
                    robSIZE.Text = CDbl(robSIZE.Text) + CDbl(sizeNode.Text)
                    GenerateSizeString(robTEXT, robSIZE)
                    If robSIZE.Parent Is Nothing Then
                        Exit Do
                    Else
                        robSIZE = robSIZE.Parent
                        robTEXT = robTEXT.Parent
                    End If
                Loop
                PopulateTreeView(i, childNode, sizeNode)
            Catch ex As Exception
                Invoke(Sub() parentNode.Nodes.Add("[    0" & sep & "0 MB ] " & New IO.DirectoryInfo(i).Name & ": Odmowa dostępu"))
                Invoke(Sub() treesizeNode.Nodes.Add(0))
                stataccess += 1
            Finally
                lblstat.Text = statkat & " katalogów / " & stataccess & " błędów braku dostępu"
            End Try
        Next
    End Sub

    Private Function GetFilesSize(ByVal dir As String) As Double
        Dim w As Double = 0
        For Each i As String In IO.Directory.GetFiles(dir)
            w += New IO.FileInfo(i).Length
        Next
        Return w / 1024 / 1024
    End Function

    Private Sub GenerateSizeString(ByVal textData As TreeNode, ByVal sizeData As TreeNode)
        If textData.Text.Substring(0, 1) = "[" Then textData.Text = textData.Text.Substring(13 + sep.Length)
        Dim rozmiar As Double = sizeData.Text
        If rozmiar > 1024 Then
            rozmiar /= 1024
            rozmiar = Math.Round(rozmiar, 1)
            textData.Text = "[ " & GetSpace(rozmiar) & rozmiar & IIf(rozmiar.ToString().IndexOf(sep) < 0, sep & "0", "") & " GB ] " & textData.Text
        Else
            rozmiar = Math.Round(rozmiar, 1)
            textData.Text = "[ " & GetSpace(rozmiar) & rozmiar & IIf(rozmiar.ToString().IndexOf(sep) < 0, sep & "0", "") & " MB ] " & textData.Text
        End If
    End Sub

    Private Function GetSpace(ByVal nr As Double) As String
        If nr >= 1000 Then Return ""
        If nr >= 100 Then Return " "
        If nr >= 10 Then Return "  "
        Return "   "
    End Function

    Private Function GetXpie(ByVal txt As String) As String
        If txt.Substring(0, 1) = "[" Then
            If txt.Length - (13 + sep.Length) > 20 Then
                Return txt.Substring(13 + sep.Length, 20) & "..."
            Else
                Return txt.Substring(13 + sep.Length)
            End If
        Else
            If txt.Length > 20 Then
                Return txt.Substring(0, 20) & "..."
            Else
                Return txt
            End If
        End If
    End Function

    Private Function GetYpie(ByVal txt As String) As Double
        If txt.Substring(0, 1) = "[" Then
            txt = txt.Substring(2, 7 + sep.Length)
            If txt.IndexOf("G") > 0 Then
                Return CDbl(txt.Substring(0, txt.Length - 2)) * 1024
            Else
                Return CDbl(txt.Substring(0, txt.Length - 2))
            End If
        Else
            Return 0
        End If
    End Function

    Private Sub drzewo_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles drzewo.NodeMouseDoubleClick
        If drzewo.SelectedNode Is Nothing Or analizawtoku Then Exit Sub
        graf.Series.Clear()
        graf.Series.Add("wizualizacja")
        graf.Series.Item(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
        graf.Series.Item(0)("PieLabelStyle") = "Outside"
        If e.Node.Nodes.Count = 0 Then
            graf.Series.Item(0).Points.AddXY("Pliki w katalogu", 1)
        Else
            Dim sumakatalogow As Double = 0
            For Each i As TreeNode In e.Node.Nodes
                graf.Series.Item(0).Points.AddXY(GetXpie(i.Text), GetYpie(i.Text))
                sumakatalogow += GetYpie(i.Text)
            Next
            graf.Series.Item(0).Points.AddXY("Pliki w katalogu", GetYpie(e.Node.Text) - sumakatalogow)
        End If
        graf.Visible = True
    End Sub

    Private Sub drzewo_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles drzewo.NodeMouseClick
        Try
            If e.Button = MouseButtons.Right And e.Node IsNot Nothing And Not analizawtoku Then
                Dim cel As String = ""
                Dim robNODE As TreeNode = e.Node
                Do
                    If robNODE.Text.Substring(0, 1) = "[" Then
                        cel = robNODE.Text.Substring(13 + sep.Length) & "\" & cel
                    Else
                        cel = robNODE.Text & "\" & cel
                    End If
                    If robNODE.Parent Is Nothing Then Exit Do Else robNODE = robNODE.Parent
                Loop
                cel = cel.Substring(0, cel.Length - 1)
                cel = cel.Replace(":\\", ":\")
                cel = cel.Replace(": Odmowa dostępu", "")
                Process.Start(cel)
            End If
        Catch ex As Exception
            MsgBox("Wystąpił błąd podczas próby otwarcia ścieżki docelowej", MsgBoxStyle.Exclamation, "WINEASIER")
        End Try
    End Sub
End Class