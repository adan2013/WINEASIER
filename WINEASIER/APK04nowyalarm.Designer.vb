<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK04nowyalarm
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbltytul = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtopis = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.dzien1 = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.dzien2 = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.dzien3 = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.dzien4 = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.dzien5 = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.dzien6 = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.dzien7 = New MetroFramework.Controls.MetroToggle()
        Me.lblgodzina = New System.Windows.Forms.Label()
        Me.btnplusgodz = New MetroFramework.Controls.MetroLink()
        Me.btnplusmin = New MetroFramework.Controls.MetroLink()
        Me.btnminusgodz = New MetroFramework.Controls.MetroLink()
        Me.btnminusmin = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.radio1 = New MetroFramework.Controls.MetroRadioButton()
        Me.radio2 = New MetroFramework.Controls.MetroRadioButton()
        Me.radio4 = New MetroFramework.Controls.MetroRadioButton()
        Me.btnwww = New MetroFramework.Controls.MetroLink()
        Me.btnprzegladaj = New MetroFramework.Controls.MetroLink()
        Me.lblplik = New MetroFramework.Controls.MetroLabel()
        Me.btnzapisz = New MetroFramework.Controls.MetroLink()
        Me.radio3 = New MetroFramework.Controls.MetroRadioButton()
        Me.listaakcji = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtpar = New MetroFramework.Controls.MetroTextBox()
        Me.oknowyborpliku = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltytul
        '
        Me.lbltytul.AutoSize = True
        Me.lbltytul.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbltytul.Location = New System.Drawing.Point(23, 30)
        Me.lbltytul.Name = "lbltytul"
        Me.lbltytul.Size = New System.Drawing.Size(103, 25)
        Me.lbltytul.TabIndex = 0
        Me.lbltytul.Text = "Nowy alarm"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 67)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Opis:"
        '
        'txtopis
        '
        Me.txtopis.Lines = New String(-1) {}
        Me.txtopis.Location = New System.Drawing.Point(23, 89)
        Me.txtopis.MaxLength = 20
        Me.txtopis.Name = "txtopis"
        Me.txtopis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtopis.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtopis.SelectedText = ""
        Me.txtopis.Size = New System.Drawing.Size(294, 23)
        Me.txtopis.TabIndex = 2
        Me.txtopis.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 127)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(147, 19)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Dzień i godzina alarmu:"
        '
        'dzien1
        '
        Me.dzien1.AutoSize = True
        Me.dzien1.DisplayStatus = False
        Me.dzien1.Location = New System.Drawing.Point(23, 149)
        Me.dzien1.Name = "dzien1"
        Me.dzien1.Size = New System.Drawing.Size(50, 17)
        Me.dzien1.TabIndex = 4
        Me.dzien1.Text = "Off"
        Me.dzien1.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(79, 149)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "Poniedziałek"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(79, 172)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel5.TabIndex = 7
        Me.MetroLabel5.Text = "Wtorek"
        '
        'dzien2
        '
        Me.dzien2.AutoSize = True
        Me.dzien2.DisplayStatus = False
        Me.dzien2.Location = New System.Drawing.Point(23, 172)
        Me.dzien2.Name = "dzien2"
        Me.dzien2.Size = New System.Drawing.Size(50, 17)
        Me.dzien2.TabIndex = 6
        Me.dzien2.Text = "Off"
        Me.dzien2.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(79, 195)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(44, 19)
        Me.MetroLabel6.TabIndex = 9
        Me.MetroLabel6.Text = "Środa"
        '
        'dzien3
        '
        Me.dzien3.AutoSize = True
        Me.dzien3.DisplayStatus = False
        Me.dzien3.Location = New System.Drawing.Point(23, 195)
        Me.dzien3.Name = "dzien3"
        Me.dzien3.Size = New System.Drawing.Size(50, 17)
        Me.dzien3.TabIndex = 8
        Me.dzien3.Text = "Off"
        Me.dzien3.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(79, 218)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel7.TabIndex = 11
        Me.MetroLabel7.Text = "Czwartek"
        '
        'dzien4
        '
        Me.dzien4.AutoSize = True
        Me.dzien4.DisplayStatus = False
        Me.dzien4.Location = New System.Drawing.Point(23, 218)
        Me.dzien4.Name = "dzien4"
        Me.dzien4.Size = New System.Drawing.Size(50, 17)
        Me.dzien4.TabIndex = 10
        Me.dzien4.Text = "Off"
        Me.dzien4.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(79, 241)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(44, 19)
        Me.MetroLabel8.TabIndex = 13
        Me.MetroLabel8.Text = "Piątek"
        '
        'dzien5
        '
        Me.dzien5.AutoSize = True
        Me.dzien5.DisplayStatus = False
        Me.dzien5.Location = New System.Drawing.Point(23, 241)
        Me.dzien5.Name = "dzien5"
        Me.dzien5.Size = New System.Drawing.Size(50, 17)
        Me.dzien5.TabIndex = 12
        Me.dzien5.Text = "Off"
        Me.dzien5.UseSelectable = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(79, 264)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel9.TabIndex = 15
        Me.MetroLabel9.Text = "Sobota"
        '
        'dzien6
        '
        Me.dzien6.AutoSize = True
        Me.dzien6.DisplayStatus = False
        Me.dzien6.Location = New System.Drawing.Point(23, 264)
        Me.dzien6.Name = "dzien6"
        Me.dzien6.Size = New System.Drawing.Size(50, 17)
        Me.dzien6.TabIndex = 14
        Me.dzien6.Text = "Off"
        Me.dzien6.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(79, 287)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel10.TabIndex = 17
        Me.MetroLabel10.Text = "Niedziela"
        '
        'dzien7
        '
        Me.dzien7.AutoSize = True
        Me.dzien7.DisplayStatus = False
        Me.dzien7.Location = New System.Drawing.Point(23, 287)
        Me.dzien7.Name = "dzien7"
        Me.dzien7.Size = New System.Drawing.Size(50, 17)
        Me.dzien7.TabIndex = 16
        Me.dzien7.Text = "Off"
        Me.dzien7.UseSelectable = True
        '
        'lblgodzina
        '
        Me.lblgodzina.AutoSize = True
        Me.lblgodzina.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblgodzina.Location = New System.Drawing.Point(197, 195)
        Me.lblgodzina.Name = "lblgodzina"
        Me.lblgodzina.Size = New System.Drawing.Size(130, 51)
        Me.lblgodzina.TabIndex = 18
        Me.lblgodzina.Text = "00:00"
        '
        'btnplusgodz
        '
        Me.btnplusgodz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnplusgodz.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.btnplusgodz.Location = New System.Drawing.Point(216, 172)
        Me.btnplusgodz.Name = "btnplusgodz"
        Me.btnplusgodz.Size = New System.Drawing.Size(25, 25)
        Me.btnplusgodz.TabIndex = 19
        Me.btnplusgodz.Text = "+"
        Me.btnplusgodz.UseSelectable = True
        '
        'btnplusmin
        '
        Me.btnplusmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnplusmin.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.btnplusmin.Location = New System.Drawing.Point(276, 172)
        Me.btnplusmin.Name = "btnplusmin"
        Me.btnplusmin.Size = New System.Drawing.Size(25, 25)
        Me.btnplusmin.TabIndex = 20
        Me.btnplusmin.Text = "+"
        Me.btnplusmin.UseSelectable = True
        '
        'btnminusgodz
        '
        Me.btnminusgodz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnminusgodz.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.btnminusgodz.Location = New System.Drawing.Point(216, 249)
        Me.btnminusgodz.Name = "btnminusgodz"
        Me.btnminusgodz.Size = New System.Drawing.Size(25, 25)
        Me.btnminusgodz.TabIndex = 21
        Me.btnminusgodz.Text = "-"
        Me.btnminusgodz.UseSelectable = True
        '
        'btnminusmin
        '
        Me.btnminusmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnminusmin.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.btnminusmin.Location = New System.Drawing.Point(276, 249)
        Me.btnminusmin.Name = "btnminusmin"
        Me.btnminusmin.Size = New System.Drawing.Size(25, 25)
        Me.btnminusmin.TabIndex = 22
        Me.btnminusmin.Text = "-"
        Me.btnminusmin.UseSelectable = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(23, 321)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(127, 19)
        Me.MetroLabel11.TabIndex = 23
        Me.MetroLabel11.Text = "Akcja do wykonania:"
        '
        'radio1
        '
        Me.radio1.AutoSize = True
        Me.radio1.Checked = True
        Me.radio1.Location = New System.Drawing.Point(23, 343)
        Me.radio1.Name = "radio1"
        Me.radio1.Size = New System.Drawing.Size(143, 15)
        Me.radio1.TabIndex = 24
        Me.radio1.TabStop = True
        Me.radio1.Text = "Ważne powiadomienie"
        Me.radio1.UseSelectable = True
        '
        'radio2
        '
        Me.radio2.AutoSize = True
        Me.radio2.Location = New System.Drawing.Point(172, 343)
        Me.radio2.Name = "radio2"
        Me.radio2.Size = New System.Drawing.Size(145, 15)
        Me.radio2.TabIndex = 25
        Me.radio2.Text = "Zwykłe powiadomienie"
        Me.radio2.UseSelectable = True
        '
        'radio4
        '
        Me.radio4.AutoSize = True
        Me.radio4.Location = New System.Drawing.Point(23, 416)
        Me.radio4.Name = "radio4"
        Me.radio4.Size = New System.Drawing.Size(289, 15)
        Me.radio4.TabIndex = 26
        Me.radio4.Text = "Uruchomienie programu/otworzenie strony WWW"
        Me.radio4.UseSelectable = True
        '
        'btnwww
        '
        Me.btnwww.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnwww.Location = New System.Drawing.Point(23, 437)
        Me.btnwww.Name = "btnwww"
        Me.btnwww.Size = New System.Drawing.Size(85, 23)
        Me.btnwww.TabIndex = 27
        Me.btnwww.Text = "Strona WWW"
        Me.btnwww.UseSelectable = True
        '
        'btnprzegladaj
        '
        Me.btnprzegladaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprzegladaj.Location = New System.Drawing.Point(114, 437)
        Me.btnprzegladaj.Name = "btnprzegladaj"
        Me.btnprzegladaj.Size = New System.Drawing.Size(85, 23)
        Me.btnprzegladaj.TabIndex = 28
        Me.btnprzegladaj.Text = "Przeglądaj..."
        Me.btnprzegladaj.UseSelectable = True
        '
        'lblplik
        '
        Me.lblplik.AutoSize = True
        Me.lblplik.Location = New System.Drawing.Point(3, 0)
        Me.lblplik.Name = "lblplik"
        Me.lblplik.Size = New System.Drawing.Size(66, 19)
        Me.lblplik.TabIndex = 29
        Me.lblplik.Text = "Brak pliku"
        '
        'btnzapisz
        '
        Me.btnzapisz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzapisz.Location = New System.Drawing.Point(252, 504)
        Me.btnzapisz.Name = "btnzapisz"
        Me.btnzapisz.Size = New System.Drawing.Size(75, 23)
        Me.btnzapisz.TabIndex = 30
        Me.btnzapisz.Text = "Zapisz"
        Me.btnzapisz.UseSelectable = True
        '
        'radio3
        '
        Me.radio3.AutoSize = True
        Me.radio3.Location = New System.Drawing.Point(23, 364)
        Me.radio3.Name = "radio3"
        Me.radio3.Size = New System.Drawing.Size(114, 15)
        Me.radio3.TabIndex = 31
        Me.radio3.Text = "Akcja systemowa"
        Me.radio3.UseSelectable = True
        '
        'listaakcji
        '
        Me.listaakcji.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.listaakcji.FormattingEnabled = True
        Me.listaakcji.ItemHeight = 19
        Me.listaakcji.Items.AddRange(New Object() {"Wyłącz komputer (zwykłe wyłączenie)", "Wyłącz komputer (wyłączenie hybrydowe)", "Wyloguj komputer", "Reset komputera", "Hibernacja", "Uśpij komputer", "Wycisz głośniki", "Włącz głośniki", "Ustaw głośność na 25%", "Ustaw głośność na 50%", "Ustaw głośność na 75%", "Ustaw głośność na 100%"})
        Me.listaakcji.Location = New System.Drawing.Point(23, 385)
        Me.listaakcji.Name = "listaakcji"
        Me.listaakcji.Size = New System.Drawing.Size(294, 25)
        Me.listaakcji.TabIndex = 32
        Me.listaakcji.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 466)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel1.TabIndex = 33
        Me.MetroLabel1.Text = "Parametry:"
        '
        'txtpar
        '
        Me.txtpar.Lines = New String(-1) {}
        Me.txtpar.Location = New System.Drawing.Point(102, 466)
        Me.txtpar.MaxLength = 50
        Me.txtpar.Name = "txtpar"
        Me.txtpar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpar.SelectedText = ""
        Me.txtpar.Size = New System.Drawing.Size(215, 23)
        Me.txtpar.TabIndex = 34
        Me.txtpar.UseSelectable = True
        '
        'oknowyborpliku
        '
        Me.oknowyborpliku.Title = "Wybierz plik docelowy"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblplik)
        Me.Panel1.Location = New System.Drawing.Point(205, 437)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 23)
        Me.Panel1.TabIndex = 35
        '
        'APK04nowyalarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 550)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtpar)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.listaakcji)
        Me.Controls.Add(Me.radio3)
        Me.Controls.Add(Me.btnzapisz)
        Me.Controls.Add(Me.btnprzegladaj)
        Me.Controls.Add(Me.btnwww)
        Me.Controls.Add(Me.radio4)
        Me.Controls.Add(Me.radio2)
        Me.Controls.Add(Me.radio1)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.btnminusmin)
        Me.Controls.Add(Me.btnminusgodz)
        Me.Controls.Add(Me.btnplusmin)
        Me.Controls.Add(Me.btnplusgodz)
        Me.Controls.Add(Me.lblgodzina)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.dzien7)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.dzien6)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.dzien5)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.dzien4)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.dzien3)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.dzien2)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.dzien1)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtopis)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.lbltytul)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "APK04nowyalarm"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Text = "Nowy alarm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltytul As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtopis As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dzien1 As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dzien2 As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dzien3 As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dzien4 As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dzien5 As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dzien6 As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dzien7 As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblgodzina As Label
    Friend WithEvents btnplusgodz As MetroFramework.Controls.MetroLink
    Friend WithEvents btnplusmin As MetroFramework.Controls.MetroLink
    Friend WithEvents btnminusgodz As MetroFramework.Controls.MetroLink
    Friend WithEvents btnminusmin As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents radio1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radio2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radio4 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents btnwww As MetroFramework.Controls.MetroLink
    Friend WithEvents btnprzegladaj As MetroFramework.Controls.MetroLink
    Friend WithEvents lblplik As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnzapisz As MetroFramework.Controls.MetroLink
    Friend WithEvents radio3 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents listaakcji As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtpar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents oknowyborpliku As OpenFileDialog
    Friend WithEvents Panel1 As Panel
End Class
