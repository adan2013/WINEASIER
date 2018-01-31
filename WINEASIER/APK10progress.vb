Imports System.IO
Imports System.Threading
Public Class APK10progress

    Public Const hismax As Byte = 6

    Public historia As List(Of String) = New List(Of String)
    Public koniec As Boolean = False

    Private Sub APK10progress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico10.GetHicon())
        APK10audioconverter.trd.Start()
    End Sub

    Private Sub btnzatrzymaj_Click(sender As Object, e As EventArgs) Handles btnzatrzymaj.Click
        If koniec Then
            DialogResult = DialogResult.OK
        Else
            APK10audioconverter.trd.Abort()
            Try
                APK10audioconverter.proc.Kill()
            Catch

            End Try
            DialogResult = DialogResult.Cancel
        End If
    End Sub

    Public Sub dodajhis(ByVal tekst As String)
        If historia.Count > 0 AndAlso tekst = historia.Item(0) Then Exit Sub
        historia.Insert(0, tekst)
        If historia.Count > hismax Then historia.RemoveAt(hismax)
        txthis.Text = ""
        For i As Byte = 0 To historia.Count - 1 Step 1
            If txthis.Text = "" Then txthis.Text = historia(i) Else txthis.Text = historia(i) & vbNewLine & txthis.Text
            txthis.SelectionStart = txthis.Text.Length
        Next
    End Sub

    Public Sub msgboxerr()
        MsgBox("Wystąpił błąd krytyczny konwersji!" & vbNewLine & "Operacja została przerwana.", MsgBoxStyle.Critical, "WINEASIER")
    End Sub

    Private Sub akt_Tick(sender As Object, e As EventArgs) Handles akt.Tick
        dodajhis(APK10audioconverter.wyjscieprocesu)
    End Sub
End Class