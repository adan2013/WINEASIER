Public Class APK18colorpicker

    Dim bmp As Bitmap
    Public pobrany As Color

    Private Sub APK18colorpicker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If APK18wynik.Visible Then APK18wynik.Close()
        Icon = Icon.FromHandle(My.Resources.ico18.GetHicon())
        START.pobierzparametr(18)
        If Not menuform.Visible Then
            bmp = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
            Dim gfx As Graphics = Graphics.FromImage(bmp)
            gfx.Clear(Color.White)
            gfx.CopyFromScreen(New Point(0, 0), New Point(0, 0), New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
            dalej()
        Else
            tmr.Enabled = True
        End If
    End Sub

    Private Sub tmr_Tick(sender As Object, e As EventArgs) Handles tmr.Tick
        If Not menuform.Visible Then
            tmr.Enabled = False
            bmp = New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
            Dim gfx As Graphics = Graphics.FromImage(bmp)
            gfx.Clear(Color.White)
            gfx.CopyFromScreen(New Point(0, 0), New Point(0, 0), New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height))
            dalej()
        End If
    End Sub

    Private Sub zamknij()
        bmp.Dispose()
        Close()
    End Sub

    Private Sub APK18colorpicker_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then zamknij()
    End Sub

    Private Sub dalej()
        ekran.Image = bmp
        lblinfo.Parent = ekran
        lblinfo.BackColor = Color.FromArgb(180, 255, 255, 255)
        lblinfo.Location = New Point(Screen.PrimaryScreen.Bounds.Width / 2 - lblinfo.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height - 80)
        Opacity = 100
        odswiezanie.Enabled = True
    End Sub

    Private Sub odswiezanie_Tick(sender As Object, e As EventArgs) Handles odswiezanie.Tick
        If Cursor.Position.Y > Screen.PrimaryScreen.Bounds.Height - 150 AndAlso Cursor.Position.X > Screen.PrimaryScreen.Bounds.Width / 2 - lblinfo.Size.Width / 2 - 80 AndAlso Cursor.Position.X < Screen.PrimaryScreen.Bounds.Width / 2 + lblinfo.Size.Width / 2 + 30 Then
            lblinfo.Location = New Point(Screen.PrimaryScreen.Bounds.Width / 2 - lblinfo.Size.Width / 2, 50)
        Else
            lblinfo.Location = New Point(Screen.PrimaryScreen.Bounds.Width / 2 - lblinfo.Size.Width / 2, Screen.PrimaryScreen.Bounds.Height - 80)
        End If
        podglad.Location = New Point(IIf(Cursor.Position.X > Screen.PrimaryScreen.Bounds.Width - 80, Cursor.Position.X - 60, Cursor.Position.X + 10), IIf(Cursor.Position.Y > Screen.PrimaryScreen.Bounds.Height - 80, Cursor.Position.Y - 60, Cursor.Position.Y + 10))
        podglad.BackColor = bmp.GetPixel(Cursor.Position.X, Cursor.Position.Y)
    End Sub

    Private Sub ekran_Click(sender As Object, e As EventArgs) Handles ekran.Click
        pobrany = podglad.BackColor
        APK18wynik.Show()
        Close()
    End Sub
End Class