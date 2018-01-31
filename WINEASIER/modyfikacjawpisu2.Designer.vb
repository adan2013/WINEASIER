<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modyfikacjawpisu2
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
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.listaakcji = New MetroFramework.Controls.MetroComboBox()
        Me.btnwww = New MetroFramework.Controls.MetroLink()
        Me.lblprogram = New MetroFramework.Controls.MetroLabel()
        Me.btnprogram = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtparametr = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.listaaplikacji = New MetroFramework.Controls.MetroComboBox()
        Me.radioakcjawineasier = New MetroFramework.Controls.MetroRadioButton()
        Me.radioakcjaprogram = New MetroFramework.Controls.MetroRadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblplik = New MetroFramework.Controls.MetroLabel()
        Me.btnprzegladaj = New MetroFramework.Controls.MetroLink()
        Me.radiografikadomyslna = New MetroFramework.Controls.MetroRadioButton()
        Me.radiografikaplik = New MetroFramework.Controls.MetroRadioButton()
        Me.lbltytul = New MetroFramework.Controls.MetroLabel()
        Me.oknowyborpliku = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLink2
        '
        Me.MetroLink2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink2.Location = New System.Drawing.Point(327, 354)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.Size = New System.Drawing.Size(50, 23)
        Me.MetroLink2.TabIndex = 15
        Me.MetroLink2.Text = "Zapisz"
        Me.MetroLink2.UseSelectable = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.listaakcji)
        Me.GroupBox2.Controls.Add(Me.btnwww)
        Me.GroupBox2.Controls.Add(Me.lblprogram)
        Me.GroupBox2.Controls.Add(Me.btnprogram)
        Me.GroupBox2.Controls.Add(Me.MetroLabel5)
        Me.GroupBox2.Controls.Add(Me.txtparametr)
        Me.GroupBox2.Controls.Add(Me.MetroLabel4)
        Me.GroupBox2.Controls.Add(Me.listaaplikacji)
        Me.GroupBox2.Controls.Add(Me.radioakcjawineasier)
        Me.GroupBox2.Controls.Add(Me.radioakcjaprogram)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 204)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Akcja"
        '
        'listaakcji
        '
        Me.listaakcji.Enabled = False
        Me.listaakcji.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.listaakcji.FormattingEnabled = True
        Me.listaakcji.ItemHeight = 19
        Me.listaakcji.Location = New System.Drawing.Point(172, 40)
        Me.listaakcji.Name = "listaakcji"
        Me.listaakcji.Size = New System.Drawing.Size(160, 25)
        Me.listaakcji.TabIndex = 13
        Me.listaakcji.UseSelectable = True
        '
        'btnwww
        '
        Me.btnwww.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnwww.Location = New System.Drawing.Point(6, 115)
        Me.btnwww.Name = "btnwww"
        Me.btnwww.Size = New System.Drawing.Size(101, 23)
        Me.btnwww.TabIndex = 12
        Me.btnwww.Text = "Strona WWW"
        Me.btnwww.UseSelectable = True
        '
        'lblprogram
        '
        Me.lblprogram.AutoSize = True
        Me.lblprogram.Location = New System.Drawing.Point(194, 119)
        Me.lblprogram.Name = "lblprogram"
        Me.lblprogram.Size = New System.Drawing.Size(66, 19)
        Me.lblprogram.TabIndex = 8
        Me.lblprogram.Text = "Brak pliku"
        '
        'btnprogram
        '
        Me.btnprogram.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprogram.Location = New System.Drawing.Point(113, 115)
        Me.btnprogram.Name = "btnprogram"
        Me.btnprogram.Size = New System.Drawing.Size(75, 23)
        Me.btnprogram.TabIndex = 8
        Me.btnprogram.Text = "Przeglądaj..."
        Me.btnprogram.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(6, 141)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(199, 19)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Parametry procesu (opcjonalne):"
        '
        'txtparametr
        '
        Me.txtparametr.Lines = New String(-1) {}
        Me.txtparametr.Location = New System.Drawing.Point(6, 163)
        Me.txtparametr.MaxLength = 300
        Me.txtparametr.Name = "txtparametr"
        Me.txtparametr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtparametr.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtparametr.SelectedText = ""
        Me.txtparametr.Size = New System.Drawing.Size(342, 23)
        Me.txtparametr.TabIndex = 11
        Me.txtparametr.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(6, 93)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel4.TabIndex = 8
        Me.MetroLabel4.Text = "Ścieżka do pliku:"
        '
        'listaaplikacji
        '
        Me.listaaplikacji.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.listaaplikacji.FormattingEnabled = True
        Me.listaaplikacji.ItemHeight = 19
        Me.listaaplikacji.Location = New System.Drawing.Point(6, 40)
        Me.listaaplikacji.Name = "listaaplikacji"
        Me.listaaplikacji.Size = New System.Drawing.Size(160, 25)
        Me.listaaplikacji.TabIndex = 6
        Me.listaaplikacji.UseSelectable = True
        '
        'radioakcjawineasier
        '
        Me.radioakcjawineasier.AutoSize = True
        Me.radioakcjawineasier.Checked = True
        Me.radioakcjawineasier.Location = New System.Drawing.Point(6, 19)
        Me.radioakcjawineasier.Name = "radioakcjawineasier"
        Me.radioakcjawineasier.Size = New System.Drawing.Size(133, 15)
        Me.radioakcjawineasier.TabIndex = 4
        Me.radioakcjawineasier.TabStop = True
        Me.radioakcjawineasier.Text = "Aplikacja WINEASIER"
        Me.radioakcjawineasier.UseSelectable = True
        '
        'radioakcjaprogram
        '
        Me.radioakcjaprogram.AutoSize = True
        Me.radioakcjaprogram.Location = New System.Drawing.Point(6, 75)
        Me.radioakcjaprogram.Name = "radioakcjaprogram"
        Me.radioakcjaprogram.Size = New System.Drawing.Size(149, 15)
        Me.radioakcjaprogram.TabIndex = 5
        Me.radioakcjaprogram.Text = "Program / strona WWW"
        Me.radioakcjaprogram.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblplik)
        Me.GroupBox1.Controls.Add(Me.btnprzegladaj)
        Me.GroupBox1.Controls.Add(Me.radiografikadomyslna)
        Me.GroupBox1.Controls.Add(Me.radiografikaplik)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 70)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ikona"
        '
        'lblplik
        '
        Me.lblplik.AutoSize = True
        Me.lblplik.Location = New System.Drawing.Point(87, 45)
        Me.lblplik.Name = "lblplik"
        Me.lblplik.Size = New System.Drawing.Size(66, 19)
        Me.lblplik.TabIndex = 7
        Me.lblplik.Text = "Brak pliku"
        '
        'btnprzegladaj
        '
        Me.btnprzegladaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprzegladaj.Location = New System.Drawing.Point(6, 41)
        Me.btnprzegladaj.Name = "btnprzegladaj"
        Me.btnprzegladaj.Size = New System.Drawing.Size(75, 23)
        Me.btnprzegladaj.TabIndex = 6
        Me.btnprzegladaj.Text = "Przeglądaj..."
        Me.btnprzegladaj.UseSelectable = True
        '
        'radiografikadomyslna
        '
        Me.radiografikadomyslna.AutoSize = True
        Me.radiografikadomyslna.Checked = True
        Me.radiografikadomyslna.Location = New System.Drawing.Point(6, 19)
        Me.radiografikadomyslna.Name = "radiografikadomyslna"
        Me.radiografikadomyslna.Size = New System.Drawing.Size(115, 15)
        Me.radiografikadomyslna.TabIndex = 4
        Me.radiografikadomyslna.TabStop = True
        Me.radiografikadomyslna.Text = "Grafika domyślna"
        Me.radiografikadomyslna.UseSelectable = True
        '
        'radiografikaplik
        '
        Me.radiografikaplik.AutoSize = True
        Me.radiografikaplik.Location = New System.Drawing.Point(127, 19)
        Me.radiografikaplik.Name = "radiografikaplik"
        Me.radiografikaplik.Size = New System.Drawing.Size(97, 15)
        Me.radiografikaplik.TabIndex = 5
        Me.radiografikaplik.Text = "Grafika z pliku"
        Me.radiografikaplik.UseSelectable = True
        '
        'lbltytul
        '
        Me.lbltytul.AutoSize = True
        Me.lbltytul.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbltytul.Location = New System.Drawing.Point(23, 27)
        Me.lbltytul.Name = "lbltytul"
        Me.lbltytul.Size = New System.Drawing.Size(93, 25)
        Me.lbltytul.TabIndex = 10
        Me.lbltytul.Text = "Nowy wpis"
        '
        'oknowyborpliku
        '
        Me.oknowyborpliku.Title = "Wybierz plik docelowy"
        '
        'modyfikacjawpisu2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 400)
        Me.Controls.Add(Me.MetroLink2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbltytul)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "modyfikacjawpisu2"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Text = "Modyfikacja wpisu"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLink2 As MetroFramework.Controls.MetroLink
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblprogram As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnprogram As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtparametr As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents listaaplikacji As MetroFramework.Controls.MetroComboBox
    Friend WithEvents radioakcjawineasier As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radioakcjaprogram As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblplik As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnprzegladaj As MetroFramework.Controls.MetroLink
    Friend WithEvents radiografikadomyslna As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radiografikaplik As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents lbltytul As MetroFramework.Controls.MetroLabel
    Friend WithEvents oknowyborpliku As OpenFileDialog
    Friend WithEvents btnwww As MetroFramework.Controls.MetroLink
    Friend WithEvents listaakcji As MetroFramework.Controls.MetroComboBox
End Class
