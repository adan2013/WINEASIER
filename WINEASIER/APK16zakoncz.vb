Imports System.Threading
Public Class APK16zakoncz

    Dim trd As Thread = New Thread(AddressOf TRDevent)
    Dim pracuje As Boolean = False

    Private Sub TRDevent()
        Dim err As Boolean = False
        pracuje = True
        Dim indir As String = ""
        Dim lista As List(Of String) = New List(Of String)
        Dim nr As Integer = 0
        Invoke(Sub() indir = APK16selektorzdjec.pathdir)
        Invoke(Sub() lista.AddRange(APK16selektorzdjec.imgsel))
        For Each i As String In lista
            If IO.File.Exists(indir & "\" & i) Then
                Try
                    IO.File.Copy(indir & "\" & i, seldir.SelectedPath & "\" & i, True)
                Catch ex As Exception
                    err = True
                End Try
            Else
                err = True
            End If
            nr += 1
            Invoke(Sub() lblpostep.Text = nr & " / " & lista.Count)
            Invoke(Sub() progbar.Value = nr * 100 / lista.Count)
        Next
        pracuje = False
        If err Then
            MsgBox("Proces kopiowania zakończony z błędem! Część plików mogła zostać nieskopiowana!", MsgBoxStyle.Exclamation, "WINEASIER")
        Else
            MsgBox("Proces kopiowania zakończony pomyślnie!", MsgBoxStyle.Information, "WINEASIER")
        End If
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnanuluj_Click(sender As Object, e As EventArgs) Handles btnanuluj.Click
        If pracuje Then
            MsgBox("Trwa proces kopiowania plików!", MsgBoxStyle.Exclamation, "WINEASIER")
        Else
            DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub btnzmien_Click(sender As Object, e As EventArgs) Handles btnzmien.Click
        seldir.ShowDialog()
        If Not seldir.SelectedPath = "" Then lbldir.Text = seldir.SelectedPath
    End Sub

    Private Sub APK16zakoncz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico16.GetHicon())
        seldir.SelectedPath = APK16selektorzdjec.pathdir
        lbldir.Text = seldir.SelectedPath
    End Sub

    Private Sub btnrozpocznij_Click(sender As Object, e As EventArgs) Handles btnrozpocznij.Click
        If seldir.SelectedPath = "" OrElse Not IO.Directory.Exists(seldir.SelectedPath) Then
            MsgBox("Katalog nie istnieje!", MsgBoxStyle.Exclamation, "WINEASIER")
        Else
            If seldir.SelectedPath = APK16selektorzdjec.pathdir Then
                MsgBox("Katalog docelowy jest taki sam jak wejściowy!", MsgBoxStyle.Exclamation, "WINEASIER")
            Else
                btnzmien.Enabled = False
                btnrozpocznij.Enabled = False
                progbar.Visible = True
                lblpostep.Text = "0 / " & APK16selektorzdjec.imgsel.Count
                lblpostep.Visible = True
                trd = New Thread(AddressOf TRDevent)
                trd.Start()
            End If
        End If
    End Sub
End Class