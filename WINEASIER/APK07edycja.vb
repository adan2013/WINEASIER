Public Class APK07edycja

    Public dyski As String = ""
    Dim konfiguracja As Boolean = False

    Private Sub APK07edycja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = Icon.FromHandle(My.Resources.ico7.GetHicon())
        Size = New Size(Size.Width, 260)
        If Not APK07diskeject.dyski = "" And APK07diskeject.dyski.Length < 20 Then
            lblstary.Text = ""
            For i As Byte = 0 To APK07diskeject.dyski.Length - 1 Step 1
                dyski &= APK07diskeject.dyski.Substring(i, 1).ToLower()
                If lblstary.Text = "" Then
                    lblstary.Text &= APK07diskeject.dyski.Substring(i, 1).ToUpper() & ":\"
                Else
                    lblstary.Text &= " " & APK07diskeject.dyski.Substring(i, 1).ToUpper() & ":\"
                End If
            Next
        End If
        lblnowy.Text = lblstary.Text
        lista.Items.Clear()
        For Each i As IO.DriveInfo In IO.DriveInfo.GetDrives()
            If i.IsReady Then
                lista.Items.Add(i.Name & " - " & IIf(i.VolumeLabel = "", "brak etykiety", i.VolumeLabel))
            Else
                lista.Items.Add(i.Name & " - Niepodłączony")
            End If
            If dyski.IndexOf(i.Name.Substring(0, i.Name.IndexOf(":")).ToLower()) >= 0 Then
                lista.SetItemChecked(lista.Items.Count - 1, True)
            End If
        Next
        konfiguracja = True
    End Sub

    Private Sub btnhelp_Click(sender As Object, e As EventArgs) Handles btnhelp.Click
        If Size.Height = 260 Then Size = New Size(Size.Width, 370) Else Size = New Size(Size.Width, 260)
    End Sub

    Private Sub btnanuluj_Click(sender As Object, e As EventArgs) Handles btnanuluj.Click
        If lblstary.Text = lblnowy.Text Then
            DialogResult = DialogResult.No
        Else
            If MsgBox("Porzucić zmiany?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then DialogResult = DialogResult.No
        End If
    End Sub

    Private Sub btnzapisz_Click(sender As Object, e As EventArgs) Handles btnzapisz.Click
        If lblstary.Text = lblnowy.Text Then
            DialogResult = DialogResult.No
        Else
            If MsgBox("Zapisać zmiany?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WINEASIER") = MsgBoxResult.Yes Then DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub lista_SelectedValueChanged(sender As Object, e As EventArgs) Handles lista.SelectedValueChanged
        Dim litera As String = lista.SelectedItem.Substring(0, lista.SelectedItem.IndexOf("\") + 1)
        info1.Text = litera
        For Each i As IO.DriveInfo In IO.DriveInfo.GetDrives
            If i.Name = litera Then
                If i.IsReady Then
                    info2.Text = IIf(i.VolumeLabel = "", "brak etykiety", i.VolumeLabel)
                    info3.Text = "Tak"
                    info4.Text = Math.Round(i.TotalSize / 1024 / 1024 / 1024, 2) & " GB" & " (zajęte: " & 100 - Math.Round(i.TotalFreeSpace * 100 / i.TotalSize, 0) & "%)"
                Else
                    info2.Text = "brak informacji"
                    info3.Text = "Nie"
                    info4.Text = "brak informacji"
                End If
            End If
        Next
    End Sub

    Private Sub lista_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lista.ItemCheck
        If konfiguracja Then
            lblnowy.Text = ""
            dyski = ""
            For i As Byte = 0 To lista.Items.Count - 1 Step 1
                If i = e.Index Then
                    If e.NewValue = CheckState.Checked Then
                        dyski &= lista.Items.Item(i).Substring(0, lista.Items.Item(i).IndexOf(":")).ToLower()
                        If lblnowy.Text = "" Then
                            lblnowy.Text &= lista.Items.Item(i).Substring(0, lista.Items.Item(i).IndexOf(":")).ToUpper() & ":\"
                        Else
                            lblnowy.Text &= " " & lista.Items.Item(i).Substring(0, lista.Items.Item(i).IndexOf(":")).ToUpper() & ":\"
                        End If
                    End If
                Else
                    If lista.GetItemCheckState(i) = CheckState.Checked Then
                        dyski &= lista.Items.Item(i).Substring(0, lista.Items.Item(i).IndexOf(":")).ToLower()
                        If lblnowy.Text = "" Then
                            lblnowy.Text &= lista.Items.Item(i).Substring(0, lista.Items.Item(i).IndexOf(":")).ToUpper() & ":\"
                        Else
                            lblnowy.Text &= " " & lista.Items.Item(i).Substring(0, lista.Items.Item(i).IndexOf(":")).ToUpper() & ":\"
                        End If
                    End If
                End If
            Next
            If lblnowy.Text = "" Then lblnowy.Text = "pusty"
        End If
    End Sub

    Private Sub APK07edycja_Click(sender As Object, e As EventArgs) Handles Me.Click
        MsgBox(dyski)
    End Sub
End Class