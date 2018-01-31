<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modyfikacjawpisu3
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
        Me.checkshift = New MetroFramework.Controls.MetroCheckBox()
        Me.checkctrl = New MetroFramework.Controls.MetroCheckBox()
        Me.checkalt = New MetroFramework.Controls.MetroCheckBox()
        Me.listaklawisz = New MetroFramework.Controls.MetroComboBox()
        Me.radio1 = New MetroFramework.Controls.MetroRadioButton()
        Me.radio2 = New MetroFramework.Controls.MetroRadioButton()
        Me.listaaplikacji = New MetroFramework.Controls.MetroComboBox()
        Me.listaakcji = New MetroFramework.Controls.MetroComboBox()
        Me.radio3 = New MetroFramework.Controls.MetroRadioButton()
        Me.btnwww = New MetroFramework.Controls.MetroLink()
        Me.btnprogram = New MetroFramework.Controls.MetroLink()
        Me.lblprogram = New MetroFramework.Controls.MetroLabel()
        Me.btnzapisz = New MetroFramework.Controls.MetroLink()
        Me.oknowyborpliku = New System.Windows.Forms.OpenFileDialog()
        Me.txtpar = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'lbltytul
        '
        Me.lbltytul.AutoSize = True
        Me.lbltytul.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbltytul.Location = New System.Drawing.Point(23, 30)
        Me.lbltytul.Name = "lbltytul"
        Me.lbltytul.Size = New System.Drawing.Size(93, 25)
        Me.lbltytul.TabIndex = 0
        Me.lbltytul.Text = "Nowy wpis"
        '
        'checkshift
        '
        Me.checkshift.AutoSize = True
        Me.checkshift.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.checkshift.Location = New System.Drawing.Point(23, 75)
        Me.checkshift.Name = "checkshift"
        Me.checkshift.Size = New System.Drawing.Size(52, 19)
        Me.checkshift.TabIndex = 1
        Me.checkshift.Text = "Shift"
        Me.checkshift.UseSelectable = True
        '
        'checkctrl
        '
        Me.checkctrl.AutoSize = True
        Me.checkctrl.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.checkctrl.Location = New System.Drawing.Point(111, 75)
        Me.checkctrl.Name = "checkctrl"
        Me.checkctrl.Size = New System.Drawing.Size(47, 19)
        Me.checkctrl.TabIndex = 2
        Me.checkctrl.Text = "Ctrl"
        Me.checkctrl.UseSelectable = True
        '
        'checkalt
        '
        Me.checkalt.AutoSize = True
        Me.checkalt.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.checkalt.Location = New System.Drawing.Point(199, 75)
        Me.checkalt.Name = "checkalt"
        Me.checkalt.Size = New System.Drawing.Size(42, 19)
        Me.checkalt.TabIndex = 3
        Me.checkalt.Text = "Alt"
        Me.checkalt.UseSelectable = True
        '
        'listaklawisz
        '
        Me.listaklawisz.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.listaklawisz.FormattingEnabled = True
        Me.listaklawisz.ItemHeight = 19
        Me.listaklawisz.Items.AddRange(New Object() {"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "Q", "S", "T", "U", "V", "W", "X", "Y", "Z"})
        Me.listaklawisz.Location = New System.Drawing.Point(290, 75)
        Me.listaklawisz.Name = "listaklawisz"
        Me.listaklawisz.Size = New System.Drawing.Size(115, 25)
        Me.listaklawisz.TabIndex = 4
        Me.listaklawisz.UseSelectable = True
        '
        'radio1
        '
        Me.radio1.AutoSize = True
        Me.radio1.Checked = True
        Me.radio1.Location = New System.Drawing.Point(23, 125)
        Me.radio1.Name = "radio1"
        Me.radio1.Size = New System.Drawing.Size(222, 15)
        Me.radio1.TabIndex = 5
        Me.radio1.TabStop = True
        Me.radio1.Text = "Pokaż/ukryj menu boczne WINEASIER"
        Me.radio1.UseSelectable = True
        '
        'radio2
        '
        Me.radio2.AutoSize = True
        Me.radio2.Location = New System.Drawing.Point(23, 146)
        Me.radio2.Name = "radio2"
        Me.radio2.Size = New System.Drawing.Size(133, 15)
        Me.radio2.TabIndex = 6
        Me.radio2.Text = "Aplikacja WINEASIER"
        Me.radio2.UseSelectable = True
        '
        'listaaplikacji
        '
        Me.listaaplikacji.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.listaaplikacji.FormattingEnabled = True
        Me.listaaplikacji.ItemHeight = 19
        Me.listaaplikacji.Location = New System.Drawing.Point(23, 167)
        Me.listaaplikacji.Name = "listaaplikacji"
        Me.listaaplikacji.Size = New System.Drawing.Size(200, 25)
        Me.listaaplikacji.TabIndex = 7
        Me.listaaplikacji.UseSelectable = True
        '
        'listaakcji
        '
        Me.listaakcji.Enabled = False
        Me.listaakcji.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.listaakcji.FormattingEnabled = True
        Me.listaakcji.ItemHeight = 19
        Me.listaakcji.Location = New System.Drawing.Point(229, 167)
        Me.listaakcji.Name = "listaakcji"
        Me.listaakcji.Size = New System.Drawing.Size(200, 25)
        Me.listaakcji.TabIndex = 8
        Me.listaakcji.UseSelectable = True
        '
        'radio3
        '
        Me.radio3.AutoSize = True
        Me.radio3.Location = New System.Drawing.Point(23, 198)
        Me.radio3.Name = "radio3"
        Me.radio3.Size = New System.Drawing.Size(161, 15)
        Me.radio3.TabIndex = 9
        Me.radio3.Text = "Program lub strona WWW"
        Me.radio3.UseSelectable = True
        '
        'btnwww
        '
        Me.btnwww.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnwww.Location = New System.Drawing.Point(23, 219)
        Me.btnwww.Name = "btnwww"
        Me.btnwww.Size = New System.Drawing.Size(93, 23)
        Me.btnwww.TabIndex = 10
        Me.btnwww.Text = "Strona WWW"
        Me.btnwww.UseSelectable = True
        '
        'btnprogram
        '
        Me.btnprogram.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprogram.Location = New System.Drawing.Point(122, 219)
        Me.btnprogram.Name = "btnprogram"
        Me.btnprogram.Size = New System.Drawing.Size(80, 23)
        Me.btnprogram.TabIndex = 11
        Me.btnprogram.Text = "Przeglądaj..."
        Me.btnprogram.UseSelectable = True
        '
        'lblprogram
        '
        Me.lblprogram.AutoSize = True
        Me.lblprogram.Location = New System.Drawing.Point(208, 223)
        Me.lblprogram.Name = "lblprogram"
        Me.lblprogram.Size = New System.Drawing.Size(66, 19)
        Me.lblprogram.TabIndex = 12
        Me.lblprogram.Text = "Brak pliku"
        '
        'btnzapisz
        '
        Me.btnzapisz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzapisz.Location = New System.Drawing.Point(369, 304)
        Me.btnzapisz.Name = "btnzapisz"
        Me.btnzapisz.Size = New System.Drawing.Size(60, 23)
        Me.btnzapisz.TabIndex = 13
        Me.btnzapisz.Text = "Zapisz"
        Me.btnzapisz.UseSelectable = True
        '
        'oknowyborpliku
        '
        Me.oknowyborpliku.Title = "Wybierz plik docelowy"
        '
        'txtpar
        '
        Me.txtpar.Lines = New String(-1) {}
        Me.txtpar.Location = New System.Drawing.Point(23, 248)
        Me.txtpar.MaxLength = 300
        Me.txtpar.Name = "txtpar"
        Me.txtpar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpar.SelectedText = ""
        Me.txtpar.Size = New System.Drawing.Size(404, 23)
        Me.txtpar.TabIndex = 14
        Me.txtpar.UseSelectable = True
        '
        'modyfikacjawpisu3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 350)
        Me.Controls.Add(Me.txtpar)
        Me.Controls.Add(Me.btnzapisz)
        Me.Controls.Add(Me.lblprogram)
        Me.Controls.Add(Me.btnprogram)
        Me.Controls.Add(Me.btnwww)
        Me.Controls.Add(Me.radio3)
        Me.Controls.Add(Me.listaakcji)
        Me.Controls.Add(Me.listaaplikacji)
        Me.Controls.Add(Me.radio2)
        Me.Controls.Add(Me.radio1)
        Me.Controls.Add(Me.listaklawisz)
        Me.Controls.Add(Me.checkalt)
        Me.Controls.Add(Me.checkctrl)
        Me.Controls.Add(Me.checkshift)
        Me.Controls.Add(Me.lbltytul)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "modyfikacjawpisu3"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Text = "Modyfikacja wpisu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltytul As MetroFramework.Controls.MetroLabel
    Friend WithEvents checkshift As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents checkctrl As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents checkalt As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents listaklawisz As MetroFramework.Controls.MetroComboBox
    Friend WithEvents radio1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radio2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents listaaplikacji As MetroFramework.Controls.MetroComboBox
    Friend WithEvents listaakcji As MetroFramework.Controls.MetroComboBox
    Friend WithEvents radio3 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents btnwww As MetroFramework.Controls.MetroLink
    Friend WithEvents btnprogram As MetroFramework.Controls.MetroLink
    Friend WithEvents lblprogram As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnzapisz As MetroFramework.Controls.MetroLink
    Friend WithEvents oknowyborpliku As OpenFileDialog
    Friend WithEvents txtpar As MetroFramework.Controls.MetroTextBox
End Class
