Public Class errinfo

    Private Sub btnend_Click(sender As Object, e As EventArgs) Handles btnend.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnskopiuj_Click(sender As Object, e As EventArgs) Handles btnskopiuj.Click
        Clipboard.SetText(kombledu.Text)
        MsgBox("Szczegóły błędu zostały skopiowane do schowka. Dziękuje za pomoc!", MsgBoxStyle.Information, "WINEASIER")
    End Sub

    Private Sub errinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kombledu.Text = START.infoerr
    End Sub
End Class