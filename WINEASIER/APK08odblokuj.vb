Public Class APK08odblokuj

    Public pass As String = ""

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        odblokuj()
    End Sub

    Private Sub odblokuj()
        If txt.Text = "" Then
            lblinfo.Visible = True
            ukr.Enabled = True
            txt.Text = ""
            txt.Focus()
        Else
            Dim dane As String = openFILE(START.folderapk, 8, "konfig")
            dane = POZget(dane, "root", "pass")
            If dane = "" Then
                lblinfo.Visible = True
                ukr.Enabled = True
                txt.Text = ""
                txt.Focus()
            Else
                dane = APK08sejfhasel.decode(dane, txt.Text)
                If dane = "" Then
                    lblinfo.Visible = True
                    ukr.Enabled = True
                    txt.Text = ""
                    txt.Focus()
                Else
                    If dane = APK08sejfhasel.hashcontrol Then
                        pass = txt.Text
                        DialogResult = DialogResult.OK
                    Else
                        lblinfo.Visible = True
                        ukr.Enabled = True
                        txt.Text = ""
                        txt.Focus()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txt_KeyUp(sender As Object, e As KeyEventArgs) Handles txt.KeyUp
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            odblokuj()
        End If
    End Sub

    Private Sub ukr_Tick(sender As Object, e As EventArgs) Handles ukr.Tick
        ukr.Enabled = False
        lblinfo.Visible = False
    End Sub

    Private Sub APK08odblokuj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico8.GetHicon())
    End Sub
End Class