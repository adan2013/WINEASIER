Public Class wyciszaniepow

    Private Sub btntak_Click(sender As Object, e As EventArgs) Handles btntak.Click
        START.ciszapowiadomien = True
        Close()
    End Sub

    Private Sub btnnie_Click(sender As Object, e As EventArgs) Handles btnnie.Click
        START.ciszapowiadomien = False
        Close()
    End Sub
End Class