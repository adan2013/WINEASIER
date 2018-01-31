Public Class wywolywaczform

    Dim tekst As Label = New Label()
    Dim fl As Boolean = False

    Private Sub wywolywaczform_Click(sender As Object, e As EventArgs) Handles Me.Click, logo.Click, pnlimg.Click
        Hide()
        menuform.Show()
    End Sub

    Private Sub wywolywaczform_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave, pnlimg.MouseLeave, logo.MouseLeave
        If fl AndAlso Not MouseIsOverControl(Me) Then Close()
    End Sub

    Private Sub wywolywaczform_Move(sender As Object, e As EventArgs) Handles Me.Move, pnlimg.Move, logo.Move
        fl = True
    End Sub

    Public Function MouseIsOverControl(ByVal c As Control) As Boolean
        Try
            Return New Rectangle(c.Location, c.Size).Contains(Cursor.Position)
        Catch ex As Exception
            Return True
        End Try
    End Function

    Private Sub wywolywaczform_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        With tekst
            .Location = New Point(45, 0)
            .Size = New Size(135, 50)
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New Font("Segoe UI", 8)
            .Text = Format(Now, "HH:mm dd-MM-yyyy") & vbNewLine & tekstpow(START.powiadomienia.Count)
        End With
        AddHandler tekst.MouseLeave, AddressOf wywolywaczform_MouseLeave
        AddHandler tekst.MouseMove, AddressOf wywolywaczform_Move
        AddHandler tekst.Click, AddressOf wywolywaczform_Click
        Controls.Add(tekst)
        Select Case START.wywolywaczPOZ
            Case 1
                Location = New Point(0, 0)
            Case 2
                Location = New Point(Screen.PrimaryScreen.Bounds.Width - 180, 0)
            Case 3
                Location = New Point(Screen.PrimaryScreen.Bounds.Width - 180, Screen.PrimaryScreen.Bounds.Height - 50)
            Case 4
                Location = New Point(0, Screen.PrimaryScreen.Bounds.Height - 50)
        End Select
    End Sub

    Private Function tekstpow(ByVal ilpow As Byte) As String
        Select Case ilpow
            Case 0
                Return "brak powiadomień"
            Case 1
                Return ilpow & " powiadomienie"
            Case 2, 3, 4
                Return ilpow & " powiadomienia"
            Case Else
                Return ilpow & " powiadomień"
        End Select
    End Function
End Class