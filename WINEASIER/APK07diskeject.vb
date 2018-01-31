Public Class APK07diskeject

    Dim konfiguracja As Boolean = False
    Public dyski As String = ""

    Private Sub APK07diskeject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico7.GetHicon())
        If START.pobierzparametr(7) = "RAPORT" Then
            START.diskejecttimer.Enabled = False
            APK07raport.Show()
            closetmr.Enabled = True
        Else
            If existFILE(START.folderapk, 7, "konfig", False) Then
                Dim dane As String = openFILE(START.folderapk, 7, "konfig")
                If POZget(dane, "root", "pwr") = 1 OrElse POZget(dane, "root", "pwr") = 0 Then
                    switchonoff.Checked = IIf(POZget(dane, "root", "pwr") = 0, False, True)
                Else
                    START.bladdanych()
                End If
                Select Case POZget(dane, "root", "time")
                    Case "1"
                        limit1.Checked = True
                    Case "2"
                        limit2.Checked = True
                    Case "3"
                        limit3.Checked = True
                    Case "4"
                        limit4.Checked = True
                    Case Else
                        START.bladdanych()
                End Select
                dyski = POZget(dane, "root", "disk").ToLower()
                If Not dyski = "" And dyski.Length < 20 Then
                    lbldyski.Text = ""
                    For i As Byte = 0 To dyski.Length - 1 Step 1
                        If "qwertyuiopasdfghjklzxcvbnm".IndexOf(dyski.Substring(i, 1)) < 0 Then
                            START.bladdanych()
                        Else
                            If lbldyski.Text = "" Then
                                lbldyski.Text &= dyski.Substring(i, 1).ToUpper() & ":\"
                            Else
                                lbldyski.Text &= " " & dyski.Substring(i, 1).ToUpper() & ":\"
                            End If
                        End If
                    Next
                End If
            Else
                existFILE(START.folderapk, 7, "konfig", True)
                Dim dane As String = ""
                POZmod(dane, "root", "pwr", "0")
                POZmod(dane, "root", "time", "1")
                POZmod(dane, "root", "disk", "")
                updateFILE(START.folderapk, 7, "konfig", dane)
            End If
            konfiguracja = True
        End If
    End Sub

    Private Sub limit1_CheckedChanged(sender As Object, e As EventArgs) Handles limit1.CheckedChanged
        If konfiguracja AndAlso sender.Checked Then
            Dim dane As String = openFILE(START.folderapk, 7, "konfig")
            POZmod(dane, "root", "time", "1")
            updateFILE(START.folderapk, 7, "konfig", dane)
        End If
    End Sub

    Private Sub limit2_CheckedChanged(sender As Object, e As EventArgs) Handles limit2.CheckedChanged
        If konfiguracja AndAlso sender.Checked Then
            Dim dane As String = openFILE(START.folderapk, 7, "konfig")
            POZmod(dane, "root", "time", "2")
            updateFILE(START.folderapk, 7, "konfig", dane)
        End If
    End Sub

    Private Sub limit3_CheckedChanged(sender As Object, e As EventArgs) Handles limit3.CheckedChanged
        If konfiguracja AndAlso sender.Checked Then
            Dim dane As String = openFILE(START.folderapk, 7, "konfig")
            POZmod(dane, "root", "time", "3")
            updateFILE(START.folderapk, 7, "konfig", dane)
        End If
    End Sub

    Private Sub limit4_CheckedChanged(sender As Object, e As EventArgs) Handles limit4.CheckedChanged
        If konfiguracja AndAlso sender.Checked Then
            Dim dane As String = openFILE(START.folderapk, 7, "konfig")
            POZmod(dane, "root", "time", "4")
            updateFILE(START.folderapk, 7, "konfig", dane)
        End If
    End Sub

    Private Sub switchonoff_CheckedChanged(sender As Object, e As EventArgs) Handles switchonoff.CheckedChanged
        If konfiguracja Then
            Dim dane As String = openFILE(START.folderapk, 7, "konfig")
            POZmod(dane, "root", "pwr", IIf(switchonoff.Checked, "1", "0"))
            updateFILE(START.folderapk, 7, "konfig", dane)
        End If
    End Sub

    Private Sub btnzmien_Click(sender As Object, e As EventArgs) Handles btnzmien.Click
        APK07edycja.ShowDialog()
        If APK07edycja.DialogResult = DialogResult.OK Then
            dyski = APK07edycja.dyski
            If Not dyski = "" And dyski.Length < 20 Then
                lbldyski.Text = ""
                For i As Byte = 0 To dyski.Length - 1 Step 1
                    If lbldyski.Text = "" Then
                        lbldyski.Text &= dyski.Substring(i, 1).ToUpper() & ":\"
                    Else
                        lbldyski.Text &= " " & dyski.Substring(i, 1).ToUpper() & ":\"
                    End If
                Next
            Else
                lbldyski.Text = "brak wyjątków"
            End If
        End If
        APK07edycja.Close()
        If konfiguracja Then
            Dim dane As String = openFILE(START.folderapk, 7, "konfig")
            POZmod(dane, "root", "disk", dyski)
            updateFILE(START.folderapk, 7, "konfig", dane)
        End If
    End Sub

    Private Sub closetmr_Tick(sender As Object, e As EventArgs) Handles closetmr.Tick
        Close()
    End Sub
End Class