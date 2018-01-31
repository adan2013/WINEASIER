<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class APK09imageconverter
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.panelpliki = New System.Windows.Forms.Panel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnwyczysc = New MetroFramework.Controls.MetroLink()
        Me.btndodaj = New MetroFramework.Controls.MetroLink()
        Me.btnuruchom = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.typpng = New MetroFramework.Controls.MetroRadioButton()
        Me.typbmp = New MetroFramework.Controls.MetroRadioButton()
        Me.typjpg = New MetroFramework.Controls.MetroRadioButton()
        Me.typgif = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.ax = New System.Windows.Forms.NumericUpDown()
        Me.ay = New System.Windows.Forms.NumericUpDown()
        Me.by = New System.Windows.Forms.NumericUpDown()
        Me.bx = New System.Windows.Forms.NumericUpDown()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbldn = New MetroFramework.Controls.MetroLabel()
        Me.lblup = New MetroFramework.Controls.MetroLabel()
        Me.progress = New MetroFramework.Controls.MetroProgressBar()
        Me.lblprogress = New MetroFramework.Controls.MetroLabel()
        Me.dodajpliki = New System.Windows.Forms.OpenFileDialog()
        Me.chkboxoverwrite = New MetroFramework.Controls.MetroCheckBox()
        Me.folderoutput = New System.Windows.Forms.FolderBrowserDialog()
        Me.trybkonwersji = New MetroFramework.Controls.MetroComboBox()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.skalujdox = New MetroFramework.Controls.MetroRadioButton()
        Me.skalujdoy = New MetroFramework.Controls.MetroRadioButton()
        Me.skalujdowymiaru = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.skalarozx = New System.Windows.Forms.NumericUpDown()
        Me.skalarozy = New System.Windows.Forms.NumericUpDown()
        CType(Me.ax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.by, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.skalarozx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skalarozy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(158, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Konwerter obrazów"
        '
        'panelpliki
        '
        Me.panelpliki.AllowDrop = True
        Me.panelpliki.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelpliki.Location = New System.Drawing.Point(3, 34)
        Me.panelpliki.Name = "panelpliki"
        Me.panelpliki.Size = New System.Drawing.Size(554, 154)
        Me.panelpliki.TabIndex = 1
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
        'btnwyczysc
        '
        Me.btnwyczysc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnwyczysc.Location = New System.Drawing.Point(437, 5)
        Me.btnwyczysc.Name = "btnwyczysc"
        Me.btnwyczysc.Size = New System.Drawing.Size(120, 23)
        Me.btnwyczysc.TabIndex = 3
        Me.btnwyczysc.Text = "Wyczyść wszystkie"
        Me.btnwyczysc.UseSelectable = True
        '
        'btndodaj
        '
        Me.btndodaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndodaj.Location = New System.Drawing.Point(351, 5)
        Me.btndodaj.Name = "btndodaj"
        Me.btndodaj.Size = New System.Drawing.Size(80, 23)
        Me.btndodaj.TabIndex = 4
        Me.btndodaj.Text = "Dodaj pliki"
        Me.btndodaj.UseSelectable = True
        '
        'btnuruchom
        '
        Me.btnuruchom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnuruchom.Location = New System.Drawing.Point(463, 460)
        Me.btnuruchom.Name = "btnuruchom"
        Me.btnuruchom.Size = New System.Drawing.Size(120, 23)
        Me.btnuruchom.TabIndex = 5
        Me.btnuruchom.Text = "Uruchom konwersje"
        Me.btnuruchom.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 206)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(91, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Plik wyjściowy:"
        '
        'typpng
        '
        Me.typpng.AutoSize = True
        Me.typpng.Checked = True
        Me.typpng.Location = New System.Drawing.Point(7, 228)
        Me.typpng.Name = "typpng"
        Me.typpng.Size = New System.Drawing.Size(47, 15)
        Me.typpng.TabIndex = 7
        Me.typpng.TabStop = True
        Me.typpng.Text = ".png"
        Me.typpng.UseSelectable = True
        '
        'typbmp
        '
        Me.typbmp.AutoSize = True
        Me.typbmp.Location = New System.Drawing.Point(60, 228)
        Me.typbmp.Name = "typbmp"
        Me.typbmp.Size = New System.Drawing.Size(51, 15)
        Me.typbmp.TabIndex = 8
        Me.typbmp.Text = ".bmp"
        Me.typbmp.UseSelectable = True
        '
        'typjpg
        '
        Me.typjpg.AutoSize = True
        Me.typjpg.Location = New System.Drawing.Point(117, 228)
        Me.typjpg.Name = "typjpg"
        Me.typjpg.Size = New System.Drawing.Size(43, 15)
        Me.typjpg.TabIndex = 9
        Me.typjpg.Text = ".jpg"
        Me.typjpg.UseSelectable = True
        '
        'typgif
        '
        Me.typgif.AutoSize = True
        Me.typgif.Location = New System.Drawing.Point(166, 228)
        Me.typgif.Name = "typgif"
        Me.typgif.Size = New System.Drawing.Size(40, 15)
        Me.typgif.TabIndex = 10
        Me.typgif.Text = ".gif"
        Me.typgif.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.Location = New System.Drawing.Point(15, 11)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(161, 15)
        Me.MetroLabel6.TabIndex = 14
        Me.MetroLabel6.Text = "Pozycja górnego lewego rogu:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(71, 32)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(15, 19)
        Me.MetroLabel8.TabIndex = 17
        Me.MetroLabel8.Text = "x"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(159, 33)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(15, 19)
        Me.MetroLabel9.TabIndex = 19
        Me.MetroLabel9.Text = "y"
        '
        'ax
        '
        Me.ax.Location = New System.Drawing.Point(15, 32)
        Me.ax.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.ax.Name = "ax"
        Me.ax.Size = New System.Drawing.Size(50, 20)
        Me.ax.TabIndex = 25
        '
        'ay
        '
        Me.ay.Location = New System.Drawing.Point(103, 33)
        Me.ay.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.ay.Name = "ay"
        Me.ay.Size = New System.Drawing.Size(50, 20)
        Me.ay.TabIndex = 26
        '
        'by
        '
        Me.by.Location = New System.Drawing.Point(308, 32)
        Me.by.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.by.Name = "by"
        Me.by.Size = New System.Drawing.Size(50, 20)
        Me.by.TabIndex = 31
        '
        'bx
        '
        Me.bx.Location = New System.Drawing.Point(206, 32)
        Me.bx.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.bx.Name = "bx"
        Me.bx.Size = New System.Drawing.Size(50, 20)
        Me.bx.TabIndex = 30
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(364, 34)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(32, 19)
        Me.MetroLabel7.TabIndex = 29
        Me.MetroLabel7.Text = "wys."
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(262, 32)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(35, 19)
        Me.MetroLabel10.TabIndex = 28
        Me.MetroLabel10.Text = "szer."
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel11.Location = New System.Drawing.Point(206, 11)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(152, 15)
        Me.MetroLabel11.TabIndex = 27
        Me.MetroLabel11.Text = "Maksymalny rozmiar wycinka:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MetroTabControl1)
        Me.Panel1.Controls.Add(Me.trybkonwersji)
        Me.Panel1.Controls.Add(Me.lbldn)
        Me.Panel1.Controls.Add(Me.lblup)
        Me.Panel1.Controls.Add(Me.MetroLabel2)
        Me.Panel1.Controls.Add(Me.panelpliki)
        Me.Panel1.Controls.Add(Me.btnwyczysc)
        Me.Panel1.Controls.Add(Me.btndodaj)
        Me.Panel1.Controls.Add(Me.MetroLabel3)
        Me.Panel1.Controls.Add(Me.typpng)
        Me.Panel1.Controls.Add(Me.typbmp)
        Me.Panel1.Controls.Add(Me.typjpg)
        Me.Panel1.Controls.Add(Me.typgif)
        Me.Panel1.Location = New System.Drawing.Point(23, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 364)
        Me.Panel1.TabIndex = 32
        '
        'lbldn
        '
        Me.lbldn.AutoSize = True
        Me.lbldn.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbldn.Location = New System.Drawing.Point(527, 191)
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
        Me.lblup.Location = New System.Drawing.Point(501, 191)
        Me.lblup.Name = "lblup"
        Me.lblup.Size = New System.Drawing.Size(20, 25)
        Me.lblup.TabIndex = 36
        Me.lblup.Text = "↑"
        Me.lblup.Visible = False
        '
        'progress
        '
        Me.progress.Location = New System.Drawing.Point(26, 460)
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(297, 15)
        Me.progress.TabIndex = 33
        '
        'lblprogress
        '
        Me.lblprogress.AutoSize = True
        Me.lblprogress.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblprogress.Location = New System.Drawing.Point(329, 460)
        Me.lblprogress.Name = "lblprogress"
        Me.lblprogress.Size = New System.Drawing.Size(29, 15)
        Me.lblprogress.TabIndex = 34
        Me.lblprogress.Text = "0 / 0"
        '
        'dodajpliki
        '
        Me.dodajpliki.Multiselect = True
        '
        'chkboxoverwrite
        '
        Me.chkboxoverwrite.AutoSize = True
        Me.chkboxoverwrite.Location = New System.Drawing.Point(26, 441)
        Me.chkboxoverwrite.Name = "chkboxoverwrite"
        Me.chkboxoverwrite.Size = New System.Drawing.Size(147, 15)
        Me.chkboxoverwrite.TabIndex = 35
        Me.chkboxoverwrite.Text = "Nadpisuj istniejące pliki"
        Me.chkboxoverwrite.UseSelectable = True
        '
        'trybkonwersji
        '
        Me.trybkonwersji.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.trybkonwersji.FormattingEnabled = True
        Me.trybkonwersji.IntegralHeight = False
        Me.trybkonwersji.ItemHeight = 19
        Me.trybkonwersji.Items.AddRange(New Object() {"Nie modyfikuj obrazów", "Przytnij obrazy", "Przeskaluj obrazy", "Przytnij i przeskaluj obrazy"})
        Me.trybkonwersji.Location = New System.Drawing.Point(226, 218)
        Me.trybkonwersji.Name = "trybkonwersji"
        Me.trybkonwersji.Size = New System.Drawing.Size(220, 25)
        Me.trybkonwersji.TabIndex = 47
        Me.trybkonwersji.UseSelectable = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(7, 249)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(550, 112)
        Me.MetroTabControl1.TabIndex = 48
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel5)
        Me.MetroTabPage1.Controls.Add(Me.skalarozx)
        Me.MetroTabPage1.Controls.Add(Me.skalarozy)
        Me.MetroTabPage1.Controls.Add(Me.skalujdowymiaru)
        Me.MetroTabPage1.Controls.Add(Me.skalujdoy)
        Me.MetroTabPage1.Controls.Add(Me.skalujdox)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(542, 70)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Skalowanie"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.by)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage2.Controls.Add(Me.bx)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel8)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel9)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel7)
        Me.MetroTabPage2.Controls.Add(Me.ax)
        Me.MetroTabPage2.Controls.Add(Me.ay)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel10)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel11)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(542, 70)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Przycinanie"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'skalujdox
        '
        Me.skalujdox.AutoSize = True
        Me.skalujdox.Checked = True
        Me.skalujdox.Location = New System.Drawing.Point(18, 8)
        Me.skalujdox.Name = "skalujdox"
        Me.skalujdox.Size = New System.Drawing.Size(196, 15)
        Me.skalujdox.TabIndex = 8
        Me.skalujdox.Text = "Skaluj do podanej szerokości ( x )"
        Me.skalujdox.UseSelectable = True
        '
        'skalujdoy
        '
        Me.skalujdoy.AutoSize = True
        Me.skalujdoy.Location = New System.Drawing.Point(18, 29)
        Me.skalujdoy.Name = "skalujdoy"
        Me.skalujdoy.Size = New System.Drawing.Size(197, 15)
        Me.skalujdoy.TabIndex = 9
        Me.skalujdoy.Text = "Skaluj do podanej wysokości ( y )"
        Me.skalujdoy.UseSelectable = True
        '
        'skalujdowymiaru
        '
        Me.skalujdowymiaru.AutoSize = True
        Me.skalujdowymiaru.Location = New System.Drawing.Point(18, 50)
        Me.skalujdowymiaru.Name = "skalujdowymiaru"
        Me.skalujdowymiaru.Size = New System.Drawing.Size(191, 15)
        Me.skalujdowymiaru.TabIndex = 10
        Me.skalujdowymiaru.Text = "Skaluj bez zachowania proporcji"
        Me.skalujdowymiaru.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(330, 15)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel4.TabIndex = 27
        Me.MetroLabel4.Text = "szer. ( x )"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(330, 41)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel5.TabIndex = 28
        Me.MetroLabel5.Text = "wys. ( y )"
        '
        'skalarozx
        '
        Me.skalarozx.Location = New System.Drawing.Point(254, 14)
        Me.skalarozx.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.skalarozx.Name = "skalarozx"
        Me.skalarozx.Size = New System.Drawing.Size(70, 20)
        Me.skalarozx.TabIndex = 29
        '
        'skalarozy
        '
        Me.skalarozy.Location = New System.Drawing.Point(254, 40)
        Me.skalarozy.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.skalarozy.Name = "skalarozy"
        Me.skalarozy.Size = New System.Drawing.Size(70, 20)
        Me.skalarozy.TabIndex = 30
        '
        'APK09imageconverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 506)
        Me.Controls.Add(Me.chkboxoverwrite)
        Me.Controls.Add(Me.lblprogress)
        Me.Controls.Add(Me.progress)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnuruchom)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Name = "APK09imageconverter"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Konwerter obrazów"
        CType(Me.ax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.by, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        CType(Me.skalarozx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skalarozy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents panelpliki As Panel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnwyczysc As MetroFramework.Controls.MetroLink
    Friend WithEvents btndodaj As MetroFramework.Controls.MetroLink
    Friend WithEvents btnuruchom As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents typpng As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents typbmp As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents typjpg As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents typgif As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ax As NumericUpDown
    Friend WithEvents ay As NumericUpDown
    Friend WithEvents by As NumericUpDown
    Friend WithEvents bx As NumericUpDown
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents progress As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents lblprogress As MetroFramework.Controls.MetroLabel
    Friend WithEvents dodajpliki As OpenFileDialog
    Friend WithEvents chkboxoverwrite As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lbldn As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblup As MetroFramework.Controls.MetroLabel
    Friend WithEvents folderoutput As FolderBrowserDialog
    Friend WithEvents trybkonwersji As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents skalarozx As NumericUpDown
    Friend WithEvents skalarozy As NumericUpDown
    Friend WithEvents skalujdowymiaru As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents skalujdoy As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents skalujdox As MetroFramework.Controls.MetroRadioButton
End Class
