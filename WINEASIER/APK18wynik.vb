Public Class APK18wynik

    Dim kolor As Color

    Private Sub APK18wynik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico18.GetHicon())
        kolor = APK18colorpicker.pobrany
        TBred.Value = kolor.R
        TBgreen.Value = kolor.G
        TBblue.Value = kolor.B
    End Sub

    Private Sub akt() Handles TBred.ValueChanged, TBgreen.ValueChanged, TBblue.ValueChanged
        podglad.BackColor = Color.FromArgb(TBred.Value, TBgreen.Value, TBblue.Value)
        txtrgb.Text = "rgb(" & TBred.Value & ", " & TBgreen.Value & ", " & TBblue.Value & ")"
        txtrgb2.Text = TBred.Value & ", " & TBgreen.Value & ", " & TBblue.Value
        txthtml.Text = ColorTranslator.ToHtml(podglad.BackColor)
    End Sub

    Private Sub btnzamknij_Click(sender As Object, e As EventArgs) Handles btnzamknij.Click
        Close()
    End Sub

    Private Sub btnprzywroc_Click(sender As Object, e As EventArgs) Handles btnprzywroc.Click
        TBred.Value = kolor.R
        TBgreen.Value = kolor.G
        TBblue.Value = kolor.B
    End Sub

    Private Sub schowekrgb_Click(sender As Object, e As EventArgs) Handles schowekrgb.Click
        Clipboard.SetText(txtrgb.Text)
        lblinfo.Visible = True
        If info.Enabled Then info.Enabled = False
        info.Enabled = True
    End Sub

    Private Sub schowekrgb2_Click(sender As Object, e As EventArgs) Handles schowekrgb2.Click
        Clipboard.SetText(txtrgb2.Text)
        lblinfo.Visible = True
        If info.Enabled Then info.Enabled = False
        info.Enabled = True
    End Sub

    Private Sub schowekhtml_Click(sender As Object, e As EventArgs) Handles schowekhtml.Click
        Clipboard.SetText(txthtml.Text)
        lblinfo.Visible = True
        If info.Enabled Then info.Enabled = False
        info.Enabled = True
    End Sub

    Private Sub info_Tick(sender As Object, e As EventArgs) Handles info.Tick
        lblinfo.Visible = False
        info.Enabled = False
    End Sub
End Class