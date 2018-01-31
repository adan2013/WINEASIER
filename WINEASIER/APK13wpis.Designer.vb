<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK13wpis
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
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.btndirpath = New MetroFramework.Controls.MetroLink()
        Me.txtpath = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtnazwa = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.chkboxinfo2 = New MetroFramework.Controls.MetroCheckBox()
        Me.chkboxinfo1 = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.listail = New MetroFramework.Controls.MetroComboBox()
        Me.listahz = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.chkboxautoprog2 = New MetroFramework.Controls.MetroCheckBox()
        Me.chkboxautoprog1 = New MetroFramework.Controls.MetroCheckBox()
        Me.btndirexe2 = New MetroFramework.Controls.MetroLink()
        Me.txtexe2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.btndirexe1 = New MetroFramework.Controls.MetroLink()
        Me.txtexe1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.btnzapisz = New MetroFramework.Controls.MetroLink()
        Me.btnanuluj = New MetroFramework.Controls.MetroLink()
        Me.dialogfolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.dialogplik = New System.Windows.Forms.OpenFileDialog()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
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
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 58)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 2
        Me.MetroTabControl1.Size = New System.Drawing.Size(454, 187)
        Me.MetroTabControl1.TabIndex = 1
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.btndirpath)
        Me.MetroTabPage1.Controls.Add(Me.txtpath)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.txtnazwa)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(446, 145)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Ogólne"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'btndirpath
        '
        Me.btndirpath.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndirpath.Location = New System.Drawing.Point(326, 120)
        Me.btndirpath.Name = "btndirpath"
        Me.btndirpath.Size = New System.Drawing.Size(100, 23)
        Me.btndirpath.TabIndex = 4
        Me.btndirpath.Text = "Wybierz folder"
        Me.btndirpath.UseSelectable = True
        '
        'txtpath
        '
        Me.txtpath.Lines = New String(-1) {}
        Me.txtpath.Location = New System.Drawing.Point(14, 91)
        Me.txtpath.MaxLength = 300
        Me.txtpath.Name = "txtpath"
        Me.txtpath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpath.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpath.SelectedText = ""
        Me.txtpath.Size = New System.Drawing.Size(412, 23)
        Me.txtpath.TabIndex = 5
        Me.txtpath.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(14, 69)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(115, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Lokalizacja plików:"
        '
        'txtnazwa
        '
        Me.txtnazwa.Lines = New String(-1) {}
        Me.txtnazwa.Location = New System.Drawing.Point(14, 33)
        Me.txtnazwa.MaxLength = 20
        Me.txtnazwa.Name = "txtnazwa"
        Me.txtnazwa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnazwa.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtnazwa.SelectedText = ""
        Me.txtnazwa.Size = New System.Drawing.Size(412, 23)
        Me.txtnazwa.TabIndex = 3
        Me.txtnazwa.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(14, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Nazwa pozycji:"
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.chkboxinfo2)
        Me.MetroTabPage2.Controls.Add(Me.chkboxinfo1)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel5)
        Me.MetroTabPage2.Controls.Add(Me.listail)
        Me.MetroTabPage2.Controls.Add(Me.listahz)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(446, 145)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Automatyczne kopie"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'chkboxinfo2
        '
        Me.chkboxinfo2.AutoSize = True
        Me.chkboxinfo2.Location = New System.Drawing.Point(249, 64)
        Me.chkboxinfo2.Name = "chkboxinfo2"
        Me.chkboxinfo2.Size = New System.Drawing.Size(147, 30)
        Me.chkboxinfo2.TabIndex = 15
        Me.chkboxinfo2.Text = "Informuj o zakończeniu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tworzenia kopii"
        Me.chkboxinfo2.UseSelectable = True
        '
        'chkboxinfo1
        '
        Me.chkboxinfo1.AutoSize = True
        Me.chkboxinfo1.Location = New System.Drawing.Point(249, 28)
        Me.chkboxinfo1.Name = "chkboxinfo1"
        Me.chkboxinfo1.Size = New System.Drawing.Size(145, 30)
        Me.chkboxinfo1.TabIndex = 14
        Me.chkboxinfo1.Text = "Informuj o rozpoczęciu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tworzenia kopii"
        Me.chkboxinfo1.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(241, 6)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(116, 19)
        Me.MetroLabel5.TabIndex = 13
        Me.MetroLabel5.Text = "Opcje dodatkowe:"
        '
        'listail
        '
        Me.listail.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.listail.FormattingEnabled = True
        Me.listail.ItemHeight = 19
        Me.listail.Items.AddRange(New Object() {"2 kopie", "3 kopie", "4 kopie", "5 kopii", "6 kopii", "10 kopii", "15 kopii", "20 kopii", "25 kopii", "30 kopii"})
        Me.listail.Location = New System.Drawing.Point(17, 86)
        Me.listail.Name = "listail"
        Me.listail.Size = New System.Drawing.Size(200, 25)
        Me.listail.TabIndex = 12
        Me.listail.UseSelectable = True
        '
        'listahz
        '
        Me.listahz.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.listahz.FormattingEnabled = True
        Me.listahz.ItemHeight = 19
        Me.listahz.Items.AddRange(New Object() {"Wyłączone", "Co godzinę", "Co 3 godziny", "Codziennie", "Co 3 dni", "Co 5 dni", "Co tydzień", "Co 10 dni", "Co 15 dni"})
        Me.listahz.Location = New System.Drawing.Point(17, 28)
        Me.listahz.Name = "listahz"
        Me.listahz.Size = New System.Drawing.Size(200, 25)
        Me.listahz.TabIndex = 11
        Me.listahz.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(17, 64)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(110, 19)
        Me.MetroLabel3.TabIndex = 9
        Me.MetroLabel3.Text = "Ilość kopii wstecz:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(17, 6)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Częstotliwość:"
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.chkboxautoprog2)
        Me.MetroTabPage3.Controls.Add(Me.chkboxautoprog1)
        Me.MetroTabPage3.Controls.Add(Me.btndirexe2)
        Me.MetroTabPage3.Controls.Add(Me.txtexe2)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage3.Controls.Add(Me.btndirexe1)
        Me.MetroTabPage3.Controls.Add(Me.txtexe1)
        Me.MetroTabPage3.Controls.Add(Me.MetroLabel7)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(446, 145)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Programy opcjonalne"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'chkboxautoprog2
        '
        Me.chkboxautoprog2.AutoSize = True
        Me.chkboxautoprog2.Location = New System.Drawing.Point(17, 126)
        Me.chkboxautoprog2.Name = "chkboxautoprog2"
        Me.chkboxautoprog2.Size = New System.Drawing.Size(249, 15)
        Me.chkboxautoprog2.TabIndex = 13
        Me.chkboxautoprog2.Text = "Uruchom program po kopii automatycznej"
        Me.chkboxautoprog2.UseSelectable = True
        '
        'chkboxautoprog1
        '
        Me.chkboxautoprog1.AutoSize = True
        Me.chkboxautoprog1.Location = New System.Drawing.Point(17, 105)
        Me.chkboxautoprog1.Name = "chkboxautoprog1"
        Me.chkboxautoprog1.Size = New System.Drawing.Size(264, 15)
        Me.chkboxautoprog1.TabIndex = 12
        Me.chkboxautoprog1.Text = "Uruchom program przed kopią automatyczną"
        Me.chkboxautoprog1.UseSelectable = True
        '
        'btndirexe2
        '
        Me.btndirexe2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndirexe2.Location = New System.Drawing.Point(323, 76)
        Me.btndirexe2.Name = "btndirexe2"
        Me.btndirexe2.Size = New System.Drawing.Size(100, 23)
        Me.btndirexe2.TabIndex = 11
        Me.btndirexe2.Text = "Wybierz folder"
        Me.btndirexe2.UseSelectable = True
        '
        'txtexe2
        '
        Me.txtexe2.Lines = New String(-1) {}
        Me.txtexe2.Location = New System.Drawing.Point(17, 76)
        Me.txtexe2.MaxLength = 300
        Me.txtexe2.Name = "txtexe2"
        Me.txtexe2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtexe2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtexe2.SelectedText = ""
        Me.txtexe2.Size = New System.Drawing.Size(300, 23)
        Me.txtexe2.TabIndex = 10
        Me.txtexe2.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(17, 54)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(268, 19)
        Me.MetroLabel6.TabIndex = 9
        Me.MetroLabel6.Text = "Program do wykonania po utworzeniu kopii:"
        '
        'btndirexe1
        '
        Me.btndirexe1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndirexe1.Location = New System.Drawing.Point(323, 28)
        Me.btndirexe1.Name = "btndirexe1"
        Me.btndirexe1.Size = New System.Drawing.Size(100, 23)
        Me.btndirexe1.TabIndex = 8
        Me.btndirexe1.Text = "Wybierz folder"
        Me.btndirexe1.UseSelectable = True
        '
        'txtexe1
        '
        Me.txtexe1.Lines = New String(-1) {}
        Me.txtexe1.Location = New System.Drawing.Point(17, 28)
        Me.txtexe1.MaxLength = 300
        Me.txtexe1.Name = "txtexe1"
        Me.txtexe1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtexe1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtexe1.SelectedText = ""
        Me.txtexe1.Size = New System.Drawing.Size(300, 23)
        Me.txtexe1.TabIndex = 7
        Me.txtexe1.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(17, 6)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(223, 19)
        Me.MetroLabel7.TabIndex = 6
        Me.MetroLabel7.Text = "Program do wykonania przed kopią:"
        '
        'btnzapisz
        '
        Me.btnzapisz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzapisz.Location = New System.Drawing.Point(427, 254)
        Me.btnzapisz.Name = "btnzapisz"
        Me.btnzapisz.Size = New System.Drawing.Size(50, 23)
        Me.btnzapisz.TabIndex = 2
        Me.btnzapisz.Text = "Zapisz"
        Me.btnzapisz.UseSelectable = True
        '
        'btnanuluj
        '
        Me.btnanuluj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnanuluj.Location = New System.Drawing.Point(371, 254)
        Me.btnanuluj.Name = "btnanuluj"
        Me.btnanuluj.Size = New System.Drawing.Size(50, 23)
        Me.btnanuluj.TabIndex = 3
        Me.btnanuluj.Text = "Anuluj"
        Me.btnanuluj.UseSelectable = True
        '
        'APK13wpis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnanuluj)
        Me.Controls.Add(Me.btnzapisz)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.lbltytul)
        Me.DisplayHeader = False
        Me.Movable = False
        Me.Name = "APK13wpis"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Text = "Backup File Creator"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltytul As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnzapisz As MetroFramework.Controls.MetroLink
    Friend WithEvents btnanuluj As MetroFramework.Controls.MetroLink
    Friend WithEvents btndirpath As MetroFramework.Controls.MetroLink
    Friend WithEvents txtpath As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtnazwa As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkboxinfo2 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkboxinfo1 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents listail As MetroFramework.Controls.MetroComboBox
    Friend WithEvents listahz As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkboxautoprog2 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkboxautoprog1 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents btndirexe2 As MetroFramework.Controls.MetroLink
    Friend WithEvents txtexe2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btndirexe1 As MetroFramework.Controls.MetroLink
    Friend WithEvents txtexe1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dialogfolder As FolderBrowserDialog
    Friend WithEvents dialogplik As OpenFileDialog
End Class
