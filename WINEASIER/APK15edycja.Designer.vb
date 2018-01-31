<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class APK15edycja
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbltytul = New MetroFramework.Controls.MetroLabel()
        Me.btndodaj = New MetroFramework.Controls.MetroLink()
        Me.btnanuluj = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtnazwa = New System.Windows.Forms.TextBox()
        Me.txtopis = New System.Windows.Forms.TextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.switchcalydzien = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.nrg = New System.Windows.Forms.NumericUpDown()
        Me.nrm = New System.Windows.Forms.NumericUpDown()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.lstcyklicznosc = New MetroFramework.Controls.MetroComboBox()
        Me.kat0 = New System.Windows.Forms.Panel()
        Me.kat4 = New System.Windows.Forms.Panel()
        Me.kat5 = New System.Windows.Forms.Panel()
        Me.kat1 = New System.Windows.Forms.Panel()
        Me.kat2 = New System.Windows.Forms.Panel()
        Me.kat3 = New System.Windows.Forms.Panel()
        Me.kat6 = New System.Windows.Forms.Panel()
        Me.lblkat = New MetroFramework.Controls.MetroLabel()
        Me.lstdatetime = New System.Windows.Forms.MonthCalendar()
        CType(Me.nrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nrm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltytul
        '
        Me.lbltytul.AutoSize = True
        Me.lbltytul.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbltytul.Location = New System.Drawing.Point(23, 30)
        Me.lbltytul.Name = "lbltytul"
        Me.lbltytul.Size = New System.Drawing.Size(146, 25)
        Me.lbltytul.TabIndex = 0
        Me.lbltytul.Text = "Nowe wydarzenie"
        '
        'btndodaj
        '
        Me.btndodaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndodaj.Location = New System.Drawing.Point(507, 374)
        Me.btndodaj.Name = "btndodaj"
        Me.btndodaj.Size = New System.Drawing.Size(50, 23)
        Me.btndodaj.TabIndex = 2
        Me.btndodaj.Text = "Dodaj"
        Me.btndodaj.UseSelectable = True
        '
        'btnanuluj
        '
        Me.btnanuluj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnanuluj.Location = New System.Drawing.Point(451, 374)
        Me.btnanuluj.Name = "btnanuluj"
        Me.btnanuluj.Size = New System.Drawing.Size(50, 23)
        Me.btnanuluj.TabIndex = 3
        Me.btnanuluj.Text = "Anuluj"
        Me.btnanuluj.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 67)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Nazwa:"
        '
        'txtnazwa
        '
        Me.txtnazwa.Location = New System.Drawing.Point(23, 89)
        Me.txtnazwa.MaxLength = 40
        Me.txtnazwa.Name = "txtnazwa"
        Me.txtnazwa.Size = New System.Drawing.Size(250, 20)
        Me.txtnazwa.TabIndex = 5
        '
        'txtopis
        '
        Me.txtopis.Location = New System.Drawing.Point(23, 134)
        Me.txtopis.MaxLength = 200
        Me.txtopis.Multiline = True
        Me.txtopis.Name = "txtopis"
        Me.txtopis.Size = New System.Drawing.Size(257, 75)
        Me.txtopis.TabIndex = 7
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 112)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Opis:"
        '
        'switchcalydzien
        '
        Me.switchcalydzien.AutoSize = True
        Me.switchcalydzien.Checked = True
        Me.switchcalydzien.CheckState = System.Windows.Forms.CheckState.Checked
        Me.switchcalydzien.DisplayStatus = False
        Me.switchcalydzien.Location = New System.Drawing.Point(309, 92)
        Me.switchcalydzien.Name = "switchcalydzien"
        Me.switchcalydzien.Size = New System.Drawing.Size(50, 17)
        Me.switchcalydzien.TabIndex = 9
        Me.switchcalydzien.Text = "On"
        Me.switchcalydzien.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(365, 90)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel4.TabIndex = 10
        Me.MetroLabel4.Text = "Cały dzień"
        '
        'nrg
        '
        Me.nrg.Enabled = False
        Me.nrg.Location = New System.Drawing.Point(309, 115)
        Me.nrg.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.nrg.Name = "nrg"
        Me.nrg.Size = New System.Drawing.Size(70, 20)
        Me.nrg.TabIndex = 11
        '
        'nrm
        '
        Me.nrm.Enabled = False
        Me.nrm.Location = New System.Drawing.Point(403, 116)
        Me.nrm.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nrm.Name = "nrm"
        Me.nrm.Size = New System.Drawing.Size(70, 20)
        Me.nrm.TabIndex = 12
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(385, 116)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(12, 19)
        Me.MetroLabel5.TabIndex = 13
        Me.MetroLabel5.Text = ":"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 265)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel6.TabIndex = 14
        Me.MetroLabel6.Text = "Kategoria:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(309, 138)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(77, 19)
        Me.MetroLabel7.TabIndex = 15
        Me.MetroLabel7.Text = "Cykliczność:"
        '
        'lstcyklicznosc
        '
        Me.lstcyklicznosc.FormattingEnabled = True
        Me.lstcyklicznosc.ItemHeight = 23
        Me.lstcyklicznosc.Items.AddRange(New Object() {"Brak", "Co 5 dni", "Co tydzień", "Co 2 tygodnie", "Co 3 tygodnie", "Co miesiąc", "Co 2 miesiące", "Co 3 miesiące", "Co 6 miesięcy", "Co rok"})
        Me.lstcyklicznosc.Location = New System.Drawing.Point(309, 160)
        Me.lstcyklicznosc.Name = "lstcyklicznosc"
        Me.lstcyklicznosc.Size = New System.Drawing.Size(164, 29)
        Me.lstcyklicznosc.TabIndex = 16
        Me.lstcyklicznosc.UseSelectable = True
        '
        'kat0
        '
        Me.kat0.BackColor = System.Drawing.Color.Black
        Me.kat0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kat0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kat0.Location = New System.Drawing.Point(23, 287)
        Me.kat0.Name = "kat0"
        Me.kat0.Size = New System.Drawing.Size(64, 64)
        Me.kat0.TabIndex = 17
        '
        'kat4
        '
        Me.kat4.BackColor = System.Drawing.Color.YellowGreen
        Me.kat4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kat4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kat4.Location = New System.Drawing.Point(93, 322)
        Me.kat4.Name = "kat4"
        Me.kat4.Size = New System.Drawing.Size(29, 29)
        Me.kat4.TabIndex = 18
        '
        'kat5
        '
        Me.kat5.BackColor = System.Drawing.Color.DodgerBlue
        Me.kat5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kat5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kat5.Location = New System.Drawing.Point(128, 322)
        Me.kat5.Name = "kat5"
        Me.kat5.Size = New System.Drawing.Size(29, 29)
        Me.kat5.TabIndex = 18
        '
        'kat1
        '
        Me.kat1.BackColor = System.Drawing.Color.Red
        Me.kat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kat1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kat1.Location = New System.Drawing.Point(93, 287)
        Me.kat1.Name = "kat1"
        Me.kat1.Size = New System.Drawing.Size(29, 29)
        Me.kat1.TabIndex = 18
        '
        'kat2
        '
        Me.kat2.BackColor = System.Drawing.Color.DarkOrange
        Me.kat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kat2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kat2.Location = New System.Drawing.Point(128, 287)
        Me.kat2.Name = "kat2"
        Me.kat2.Size = New System.Drawing.Size(29, 29)
        Me.kat2.TabIndex = 18
        '
        'kat3
        '
        Me.kat3.BackColor = System.Drawing.Color.Gold
        Me.kat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kat3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kat3.Location = New System.Drawing.Point(163, 287)
        Me.kat3.Name = "kat3"
        Me.kat3.Size = New System.Drawing.Size(29, 29)
        Me.kat3.TabIndex = 19
        '
        'kat6
        '
        Me.kat6.BackColor = System.Drawing.Color.DarkViolet
        Me.kat6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kat6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kat6.Location = New System.Drawing.Point(163, 322)
        Me.kat6.Name = "kat6"
        Me.kat6.Size = New System.Drawing.Size(29, 29)
        Me.kat6.TabIndex = 20
        '
        'lblkat
        '
        Me.lblkat.AutoSize = True
        Me.lblkat.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblkat.Location = New System.Drawing.Point(23, 354)
        Me.lblkat.Name = "lblkat"
        Me.lblkat.Size = New System.Drawing.Size(55, 15)
        Me.lblkat.TabIndex = 21
        Me.lblkat.Text = "Kategoria"
        Me.lblkat.Visible = False
        '
        'lstdatetime
        '
        Me.lstdatetime.Location = New System.Drawing.Point(309, 200)
        Me.lstdatetime.MaxSelectionCount = 1
        Me.lstdatetime.Name = "lstdatetime"
        Me.lstdatetime.ShowToday = False
        Me.lstdatetime.ShowTodayCircle = False
        Me.lstdatetime.TabIndex = 22
        '
        'APK15edycja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 420)
        Me.ControlBox = False
        Me.Controls.Add(Me.lstdatetime)
        Me.Controls.Add(Me.lblkat)
        Me.Controls.Add(Me.kat3)
        Me.Controls.Add(Me.kat6)
        Me.Controls.Add(Me.kat2)
        Me.Controls.Add(Me.kat1)
        Me.Controls.Add(Me.kat5)
        Me.Controls.Add(Me.kat4)
        Me.Controls.Add(Me.kat0)
        Me.Controls.Add(Me.lstcyklicznosc)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.nrm)
        Me.Controls.Add(Me.nrg)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.switchcalydzien)
        Me.Controls.Add(Me.txtopis)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txtnazwa)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnanuluj)
        Me.Controls.Add(Me.btndodaj)
        Me.Controls.Add(Me.lbltytul)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "APK15edycja"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Text = "Kalendarz"
        CType(Me.nrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nrm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltytul As MetroFramework.Controls.MetroLabel
    Friend WithEvents btndodaj As MetroFramework.Controls.MetroLink
    Friend WithEvents btnanuluj As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtnazwa As TextBox
    Friend WithEvents txtopis As TextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents switchcalydzien As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents nrg As NumericUpDown
    Friend WithEvents nrm As NumericUpDown
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lstcyklicznosc As MetroFramework.Controls.MetroComboBox
    Friend WithEvents kat0 As Panel
    Friend WithEvents kat4 As Panel
    Friend WithEvents kat5 As Panel
    Friend WithEvents kat1 As Panel
    Friend WithEvents kat2 As Panel
    Friend WithEvents kat3 As Panel
    Friend WithEvents kat6 As Panel
    Friend WithEvents lblkat As MetroFramework.Controls.MetroLabel
    Friend WithEvents lstdatetime As MonthCalendar
End Class
