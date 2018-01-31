Module Module1

    Public Function updateFILE(ByVal sciezka As String, ByVal apk As Byte, ByVal plik As String, ByVal tresc As String) As Boolean
        Try
            If IO.File.Exists(sciezka & "\apk" & apk & "\" & plik & ".txt") Then
                IO.File.Delete(sciezka & "\apk" & apk & "\" & plik & ".txt")
                IO.File.WriteAllText(sciezka & "\apk" & apk & "\" & plik & ".txt", tresc)
                Return True
            Else
                IO.File.WriteAllText(sciezka & "\apk" & apk & "\" & plik & ".txt", tresc)
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function existFILE(ByVal sciezka As String, ByVal apk As Byte, ByVal plik As String, ByVal utworz As Boolean) As Boolean
        If IO.File.Exists(sciezka & "\apk" & apk & "\" & plik & ".txt") Then
            Return True
        Else
            If Not IO.Directory.Exists(sciezka & "\apk" & apk) Then IO.Directory.CreateDirectory(sciezka & "\apk" & apk)
            If utworz Then IO.File.WriteAllText(sciezka & "\apk" & apk & "\" & plik & ".txt", "", Text.Encoding.UTF8) Else Return False
            Return True
        End If
    End Function

    Public Function openFILE(ByVal sciezka As String, ByVal apk As Byte, ByVal plik As String) As String
        If IO.File.Exists(sciezka & "\apk" & apk & "\" & plik & ".txt") Then
            Return IO.File.ReadAllText(sciezka & "\apk" & apk & "\" & plik & ".txt")
        Else
            Return ""
        End If
    End Function

    Private Function weryfikujdane(ByVal wartosc As String) As String
        wartosc = wartosc.Replace("=", "/$/ROW")
        wartosc = wartosc.Replace("<", "/$/ZNGR")
        wartosc = wartosc.Replace(">", "/$/ZNPOZ")
        Return wartosc
    End Function

    Private Function tlumaczdane(ByVal wartosc As String) As String
        wartosc = wartosc.Replace("/$/ROW", "=")
        wartosc = wartosc.Replace("/$/ZNGR", "<")
        wartosc = wartosc.Replace("/$/ZNPOZ", ">")
        Return wartosc
    End Function

    Public Function dozwoloneznaki(ByVal wartosc As String) As Boolean
        If wartosc.IndexOf("/$/") < 0 Then Return True Else Return False
    End Function

    Public Function GRarray(ByVal zrodlo As String) As String()
        Dim wynik(0) As String
        If zrodlo <> "" Then
            For i As Short = 0 To zrodlo.Length - 1 Step 1
                If zrodlo.Substring(i, 1) = "<" Then
                    wynik(wynik.Length - 1) = zrodlo.Substring(i).Substring(1, zrodlo.Substring(i).IndexOf("=") - 1)
                    ReDim Preserve wynik(wynik.Length)
                End If
            Next
        End If
        ReDim Preserve wynik(wynik.Length - 2)
        Return wynik
    End Function

    Public Function GRexist(ByVal zrodlo As String, ByVal id As String) As Boolean
        If zrodlo.IndexOf("<" & id & "=") < 0 Then Return False Else Return True
    End Function

    Public Function POZexist(ByVal zrodlo As String, ByVal gr As String, ByVal id As String) As Boolean
        Dim wynik As String = GRget(zrodlo, gr)
        If wynik.IndexOf(">" & id & "=") < 0 Then Return False Else Return True
    End Function

    Public Function GRget(ByVal zrodlo As String, ByVal id As String) As String
        If Not GRexist(zrodlo, id) Then Return ""
        Dim wynik As String = zrodlo.Substring(zrodlo.IndexOf("<" & id & "="))
        If wynik.Substring(1).IndexOf("<") < 0 Then
            Return wynik
        Else
            Return wynik.Substring(0, wynik.Substring(1).IndexOf("<") + 1)
        End If
    End Function

    Public Function POZget(ByVal zrodlo As String, ByVal gr As String, ByVal id As String, Optional ByVal notranslate As Boolean = False) As String
        If Not POZexist(zrodlo, gr, id) Then Return ""
        Dim wynik As String = GRget(zrodlo, gr)
        wynik = wynik.Substring(wynik.IndexOf(">" & id & "=") + id.Length + 2)
        If notranslate Then
            If wynik.IndexOf(">") < 0 Then
                Return wynik
            Else
                Return wynik.Substring(0, wynik.IndexOf(">"))
            End If
        Else
            If wynik.IndexOf(">") < 0 Then
                Return tlumaczdane(wynik)
            Else
                Return tlumaczdane(wynik.Substring(0, wynik.IndexOf(">")))
            End If
        End If
    End Function

    Public Sub GRdel(ByRef zrodlo As String, ByVal id As String)
        If Not GRexist(zrodlo, id) Then Exit Sub
        zrodlo = zrodlo.Replace(GRget(zrodlo, id), "")
    End Sub

    Public Sub POZdel(ByRef zrodlo As String, ByVal gr As String, ByVal id As String)
        If Not POZexist(zrodlo, gr, id) Then Exit Sub
        Dim grupa As String = GRget(zrodlo, gr)
        grupa = grupa.Replace(">" & id & "=" & POZget(zrodlo, gr, id), "")
        If grupa.IndexOf(">") < 0 Then
            zrodlo = zrodlo.Replace(GRget(zrodlo, gr), "")
        Else
            zrodlo = zrodlo.Replace(GRget(zrodlo, gr), grupa)
        End If
    End Sub

    Public Function POZmod(ByRef zrodlo As String, ByVal gr As String, ByVal id As String, ByVal wartosc As String) As Boolean
        wartosc = weryfikujdane(wartosc)
        If GRexist(zrodlo, gr) Then
            If POZexist(zrodlo, gr, id) Then
                Dim grupa As String = GRget(zrodlo, gr)
                grupa = grupa.Replace(">" & id & "=" & POZget(zrodlo, gr, id, True), ">" & id & "=" & wartosc)
                zrodlo = zrodlo.Replace(GRget(zrodlo, gr), grupa)
                Return False
            Else
                Dim grupa As String = GRget(zrodlo, gr)
                zrodlo = zrodlo.Replace(grupa, grupa & ">" & id & "=" & wartosc)
                Return True
            End If
        Else
            zrodlo &= "<" & gr & "=" & ">" & id & "=" & wartosc
            Return True
        End If
    End Function
End Module
