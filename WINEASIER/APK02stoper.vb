Public Class APK02stoper

    Dim zegar As Stopwatch = New Stopwatch()

    Private Sub odl_Tick(sender As Object, e As EventArgs) Handles odl.Tick
        Dim elapsed As TimeSpan = zegar.Elapsed
        lbl1.Text = String.Format("{0:0}:{1:00}:{2:00}", elapsed.Hours, elapsed.Minutes, elapsed.Seconds)
        lbl2.Text = String.Format(":{0:000}", elapsed.Milliseconds)
    End Sub

    Private Sub btnleft_Click(sender As Object, e As EventArgs) Handles btnleft.Click
        If zegar.IsRunning Then
            btnleft.Text = "Start"
            btnright.Text = "Wyzeruj"
            zegar.Stop()
        Else
            btnleft.Text = "Zatrzymaj"
            btnright.Text = "Zapisz"
            zegar.Start()
        End If
    End Sub

    Private Sub btnright_Click(sender As Object, e As EventArgs) Handles btnright.Click
        If zegar.IsRunning Then
            lista.Items.Add(lista.Items.Count + 1 & ": " & lbl1.Text & lbl2.Text)
            lista.SelectedIndex = lista.Items.Count - 1
            Size = New Size(Size.Width, 300)
        Else
            lbl1.Text = "0:00:00"
            lbl2.Text = ":000"
            zegar.Reset()
            lista.Items.Clear()
            Size = New Size(Size.Width, 170)
        End If
    End Sub

    Private Sub APK01stoper_Load(sender As Object, e As EventArgs) Handles Me.Load
        Icon = Icon.FromHandle(My.Resources.ico2.GetHicon())
        START.pobierzparametr(2)
        Size = New Size(Size.Width, 170)
    End Sub
End Class