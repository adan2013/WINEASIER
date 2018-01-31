<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK10audioconverter
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.listawyjsciowy = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.switchprzytnij = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.switchjakosc = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.switchhz = New MetroFramework.Controls.MetroToggle()
        Me.chkboxnadpisuj = New MetroFramework.Controls.MetroCheckBox()
        Me.chkboxdokonca = New MetroFramework.Controls.MetroCheckBox()
        Me.txtkoniec = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.txtpocz = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.listahz = New System.Windows.Forms.NumericUpDown()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.jakosc = New MetroFramework.Controls.MetroTrackBar()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.lbldn = New MetroFramework.Controls.MetroLabel()
        Me.lblup = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.panelpliki = New System.Windows.Forms.Panel()
        Me.btnwyczysc = New MetroFramework.Controls.MetroLink()
        Me.btndodaj = New MetroFramework.Controls.MetroLink()
        Me.btnuruchom = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.dodajpliki = New System.Windows.Forms.OpenFileDialog()
        Me.folderoutput = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.listahz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MetroLabel3)
        Me.Panel1.Controls.Add(Me.listawyjsciowy)
        Me.Panel1.Controls.Add(Me.MetroLabel14)
        Me.Panel1.Controls.Add(Me.switchprzytnij)
        Me.Panel1.Controls.Add(Me.MetroLabel15)
        Me.Panel1.Controls.Add(Me.switchjakosc)
        Me.Panel1.Controls.Add(Me.MetroLabel13)
        Me.Panel1.Controls.Add(Me.switchhz)
        Me.Panel1.Controls.Add(Me.chkboxnadpisuj)
        Me.Panel1.Controls.Add(Me.chkboxdokonca)
        Me.Panel1.Controls.Add(Me.txtkoniec)
        Me.Panel1.Controls.Add(Me.MetroLabel11)
        Me.Panel1.Controls.Add(Me.txtpocz)
        Me.Panel1.Controls.Add(Me.MetroLabel10)
        Me.Panel1.Controls.Add(Me.MetroLabel8)
        Me.Panel1.Controls.Add(Me.listahz)
        Me.Panel1.Controls.Add(Me.MetroLabel7)
        Me.Panel1.Controls.Add(Me.MetroLabel6)
        Me.Panel1.Controls.Add(Me.MetroLabel5)
        Me.Panel1.Controls.Add(Me.jakosc)
        Me.Panel1.Controls.Add(Me.MetroLabel4)
        Me.Panel1.Controls.Add(Me.lbldn)
        Me.Panel1.Controls.Add(Me.lblup)
        Me.Panel1.Controls.Add(Me.MetroLabel2)
        Me.Panel1.Controls.Add(Me.panelpliki)
        Me.Panel1.Controls.Add(Me.btnwyczysc)
        Me.Panel1.Controls.Add(Me.btndodaj)
        Me.Panel1.Location = New System.Drawing.Point(23, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(654, 355)
        Me.Panel1.TabIndex = 38
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(12, 197)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(91, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Plik wyjściowy:"
        '
        'listawyjsciowy
        '
        Me.listawyjsciowy.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.listawyjsciowy.FormattingEnabled = True
        Me.listawyjsciowy.IntegralHeight = False
        Me.listawyjsciowy.ItemHeight = 19
        Me.listawyjsciowy.Items.AddRange(New Object() {".mp3", ".wav", ".wma", ".ogg", ".aac"})
        Me.listawyjsciowy.Location = New System.Drawing.Point(109, 196)
        Me.listawyjsciowy.Name = "listawyjsciowy"
        Me.listawyjsciowy.Size = New System.Drawing.Size(90, 25)
        Me.listawyjsciowy.TabIndex = 46
        Me.listawyjsciowy.UseSelectable = True
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(402, 321)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(132, 19)
        Me.MetroLabel14.TabIndex = 61
        Me.MetroLabel14.Text = "Przytnij ścieżke audio"
        '
        'switchprzytnij
        '
        Me.switchprzytnij.AutoSize = True
        Me.switchprzytnij.DisplayStatus = False
        Me.switchprzytnij.Location = New System.Drawing.Point(346, 321)
        Me.switchprzytnij.Name = "switchprzytnij"
        Me.switchprzytnij.Size = New System.Drawing.Size(50, 17)
        Me.switchprzytnij.TabIndex = 60
        Me.switchprzytnij.Text = "Off"
        Me.switchprzytnij.UseSelectable = True
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(402, 298)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(140, 19)
        Me.MetroLabel15.TabIndex = 59
        Me.MetroLabel15.Text = "Zmień jakość nagrania"
        '
        'switchjakosc
        '
        Me.switchjakosc.AutoSize = True
        Me.switchjakosc.DisplayStatus = False
        Me.switchjakosc.Location = New System.Drawing.Point(346, 298)
        Me.switchjakosc.Name = "switchjakosc"
        Me.switchjakosc.Size = New System.Drawing.Size(50, 17)
        Me.switchjakosc.TabIndex = 58
        Me.switchjakosc.Text = "Off"
        Me.switchjakosc.UseSelectable = True
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(402, 275)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(204, 19)
        Me.MetroLabel13.TabIndex = 57
        Me.MetroLabel13.Text = "Zmień częstotliwość próbkowania"
        '
        'switchhz
        '
        Me.switchhz.AutoSize = True
        Me.switchhz.DisplayStatus = False
        Me.switchhz.Location = New System.Drawing.Point(346, 275)
        Me.switchhz.Name = "switchhz"
        Me.switchhz.Size = New System.Drawing.Size(50, 17)
        Me.switchhz.TabIndex = 56
        Me.switchhz.Text = "Off"
        Me.switchhz.UseSelectable = True
        '
        'chkboxnadpisuj
        '
        Me.chkboxnadpisuj.AutoSize = True
        Me.chkboxnadpisuj.Location = New System.Drawing.Point(37, 325)
        Me.chkboxnadpisuj.Name = "chkboxnadpisuj"
        Me.chkboxnadpisuj.Size = New System.Drawing.Size(147, 15)
        Me.chkboxnadpisuj.TabIndex = 53
        Me.chkboxnadpisuj.Text = "Nadpisuj istniejące pliki"
        Me.chkboxnadpisuj.UseSelectable = True
        '
        'chkboxdokonca
        '
        Me.chkboxdokonca.AutoSize = True
        Me.chkboxdokonca.Location = New System.Drawing.Point(199, 325)
        Me.chkboxdokonca.Name = "chkboxdokonca"
        Me.chkboxdokonca.Size = New System.Drawing.Size(114, 15)
        Me.chkboxdokonca.TabIndex = 52
        Me.chkboxdokonca.Text = "Przytnij do końca"
        Me.chkboxdokonca.UseSelectable = True
        '
        'txtkoniec
        '
        Me.txtkoniec.Lines = New String() {"00:00:00"}
        Me.txtkoniec.Location = New System.Drawing.Point(193, 296)
        Me.txtkoniec.MaxLength = 32767
        Me.txtkoniec.Name = "txtkoniec"
        Me.txtkoniec.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtkoniec.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtkoniec.SelectedText = ""
        Me.txtkoniec.Size = New System.Drawing.Size(120, 23)
        Me.txtkoniec.TabIndex = 51
        Me.txtkoniec.Text = "00:00:00"
        Me.txtkoniec.UseSelectable = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(23, 296)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(164, 19)
        Me.MetroLabel11.TabIndex = 50
        Me.MetroLabel11.Text = "Koniec wycinka (hh:mm:ss):"
        '
        'txtpocz
        '
        Me.txtpocz.Lines = New String() {"00:00:00"}
        Me.txtpocz.Location = New System.Drawing.Point(193, 267)
        Me.txtpocz.MaxLength = 32767
        Me.txtpocz.Name = "txtpocz"
        Me.txtpocz.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpocz.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpocz.SelectedText = ""
        Me.txtpocz.Size = New System.Drawing.Size(120, 23)
        Me.txtpocz.TabIndex = 49
        Me.txtpocz.Text = "00:00:00"
        Me.txtpocz.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(12, 267)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(175, 19)
        Me.MetroLabel10.TabIndex = 48
        Me.MetroLabel10.Text = "Początek wicinka (hh:mm:ss):"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel8.Location = New System.Drawing.Point(427, 254)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(168, 15)
        Me.MetroLabel8.TabIndex = 44
        Me.MetroLabel8.Text = "Hz (zakres od 40000 do 192000)"
        '
        'listahz
        '
        Me.listahz.Location = New System.Drawing.Point(346, 249)
        Me.listahz.Maximum = New Decimal(New Integer() {192000, 0, 0, 0})
        Me.listahz.Minimum = New Decimal(New Integer() {40000, 0, 0, 0})
        Me.listahz.Name = "listahz"
        Me.listahz.Size = New System.Drawing.Size(75, 20)
        Me.listahz.TabIndex = 43
        Me.listahz.Value = New Decimal(New Integer() {44100, 0, 0, 0})
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(337, 227)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(250, 19)
        Me.MetroLabel7.TabIndex = 42
        Me.MetroLabel7.Text = "Częstotliwość próbkowania (sample rate):"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.Location = New System.Drawing.Point(67, 249)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(117, 15)
        Me.MetroLabel6.TabIndex = 41
        Me.MetroLabel6.Text = "Największa kompresja"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.Location = New System.Drawing.Point(220, 249)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(93, 15)
        Me.MetroLabel5.TabIndex = 40
        Me.MetroLabel5.Text = "Najwyższa jakość"
        '
        'jakosc
        '
        Me.jakosc.BackColor = System.Drawing.Color.Transparent
        Me.jakosc.Location = New System.Drawing.Point(67, 227)
        Me.jakosc.Maximum = 9
        Me.jakosc.Name = "jakosc"
        Me.jakosc.Size = New System.Drawing.Size(246, 19)
        Me.jakosc.TabIndex = 39
        Me.jakosc.Text = "MetroTrackBar1"
        Me.jakosc.Value = 9
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(12, 227)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel4.TabIndex = 38
        Me.MetroLabel4.Text = "Jakość:"
        '
        'lbldn
        '
        Me.lbldn.AutoSize = True
        Me.lbldn.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbldn.Location = New System.Drawing.Point(621, 191)
        Me.lbldn.Name = "lbldn"
        Me.lbldn.Size = New System.Drawing.Size(20, 25)
        Me.lbldn.TabIndex = 37
        Me.lbldn.Text = "↓"
        Me.lbldn.Visible = False
        '
        'lblup
        '
        Me.lblup.AutoSize = True
        Me.lblup.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblup.Location = New System.Drawing.Point(595, 191)
        Me.lblup.Name = "lblup"
        Me.lblup.Size = New System.Drawing.Size(20, 25)
        Me.lblup.TabIndex = 36
        Me.lblup.Text = "↑"
        Me.lblup.Visible = False
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 12)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Lista plików:"
        '
        'panelpliki
        '
        Me.panelpliki.AllowDrop = True
        Me.panelpliki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelpliki.Location = New System.Drawing.Point(3, 34)
        Me.panelpliki.Name = "panelpliki"
        Me.panelpliki.Size = New System.Drawing.Size(648, 154)
        Me.panelpliki.TabIndex = 1
        '
        'btnwyczysc
        '
        Me.btnwyczysc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnwyczysc.Location = New System.Drawing.Point(531, 5)
        Me.btnwyczysc.Name = "btnwyczysc"
        Me.btnwyczysc.Size = New System.Drawing.Size(120, 23)
        Me.btnwyczysc.TabIndex = 3
        Me.btnwyczysc.Text = "Wyczyść wszystkie"
        Me.btnwyczysc.UseSelectable = True
        '
        'btndodaj
        '
        Me.btndodaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndodaj.Location = New System.Drawing.Point(445, 5)
        Me.btndodaj.Name = "btndodaj"
        Me.btndodaj.Size = New System.Drawing.Size(80, 23)
        Me.btndodaj.TabIndex = 4
        Me.btndodaj.Text = "Dodaj pliki"
        Me.btndodaj.UseSelectable = True
        '
        'btnuruchom
        '
        Me.btnuruchom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnuruchom.Location = New System.Drawing.Point(557, 414)
        Me.btnuruchom.Name = "btnuruchom"
        Me.btnuruchom.Size = New System.Drawing.Size(120, 23)
        Me.btnuruchom.TabIndex = 37
        Me.btnuruchom.Text = "Uruchom konwersje"
        Me.btnuruchom.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 27)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(136, 25)
        Me.MetroLabel1.TabIndex = 36
        Me.MetroLabel1.Text = "Konwerter audio"
        '
        'dodajpliki
        '
        Me.dodajpliki.Multiselect = True
        '
        'APK10audioconverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 460)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnuruchom)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Name = "APK10audioconverter"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Konwerter audio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.listahz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbldn As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblup As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents panelpliki As Panel
    Friend WithEvents btnwyczysc As MetroFramework.Controls.MetroLink
    Friend WithEvents btndodaj As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnuruchom As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents listahz As NumericUpDown
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents jakosc As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkboxnadpisuj As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkboxdokonca As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtkoniec As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtpocz As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents listawyjsciowy As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents switchprzytnij As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents switchjakosc As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents switchhz As MetroFramework.Controls.MetroToggle
    Friend WithEvents dodajpliki As OpenFileDialog
    Friend WithEvents folderoutput As FolderBrowserDialog
End Class
