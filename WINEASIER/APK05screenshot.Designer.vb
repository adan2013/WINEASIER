<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK05screenshot
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
        Me.components = New System.ComponentModel.Container()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnzapisz = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.radio1 = New MetroFramework.Controls.MetroRadioButton()
        Me.radio2 = New MetroFramework.Controls.MetroRadioButton()
        Me.btnfolder = New MetroFramework.Controls.MetroLink()
        Me.lblplik = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.listaplik = New MetroFramework.Controls.MetroComboBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.n4 = New MetroFramework.Controls.MetroRadioButton()
        Me.n3 = New MetroFramework.Controls.MetroRadioButton()
        Me.n2 = New MetroFramework.Controls.MetroRadioButton()
        Me.n1 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.oknofolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.MetroPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(97, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "ScreenShot"
        '
        'btnzapisz
        '
        Me.btnzapisz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzapisz.Location = New System.Drawing.Point(367, 304)
        Me.btnzapisz.Name = "btnzapisz"
        Me.btnzapisz.Size = New System.Drawing.Size(110, 23)
        Me.btnzapisz.TabIndex = 2
        Me.btnzapisz.Text = "Zapisz ustawienia"
        Me.btnzapisz.UseSelectable = True
        Me.btnzapisz.Visible = False
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(419, 57)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Aby wykonać zrzut ekranu komputera ustaw preferowaną przez Ciebie" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "kombinację kla" &
    "wiszy klawiatury w ustawieniach programu WINEASIER," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a następnie jej użyj by wyw" &
    "ołać menu edycji obrazu."
        '
        'radio1
        '
        Me.radio1.AutoSize = True
        Me.radio1.Checked = True
        Me.radio1.Location = New System.Drawing.Point(3, 75)
        Me.radio1.Name = "radio1"
        Me.radio1.Size = New System.Drawing.Size(127, 15)
        Me.radio1.TabIndex = 2
        Me.radio1.TabStop = True
        Me.radio1.Text = "Pytaj przed zapisem"
        Me.radio1.UseSelectable = True
        '
        'radio2
        '
        Me.radio2.AutoSize = True
        Me.radio2.Location = New System.Drawing.Point(136, 75)
        Me.radio2.Name = "radio2"
        Me.radio2.Size = New System.Drawing.Size(194, 15)
        Me.radio2.TabIndex = 3
        Me.radio2.Text = "Zdefiniowana przez użytkownika"
        Me.radio2.UseSelectable = True
        '
        'btnfolder
        '
        Me.btnfolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfolder.Location = New System.Drawing.Point(3, 96)
        Me.btnfolder.Name = "btnfolder"
        Me.btnfolder.Size = New System.Drawing.Size(80, 23)
        Me.btnfolder.TabIndex = 4
        Me.btnfolder.Text = "Zmień folder"
        Me.btnfolder.UseSelectable = True
        '
        'lblplik
        '
        Me.lblplik.AutoSize = True
        Me.lblplik.Location = New System.Drawing.Point(89, 100)
        Me.lblplik.Name = "lblplik"
        Me.lblplik.Size = New System.Drawing.Size(83, 19)
        Me.lblplik.TabIndex = 5
        Me.lblplik.Text = "Nie wybrano"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 130)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Rozszerzenie pliku:"
        '
        'listaplik
        '
        Me.listaplik.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.listaplik.FormattingEnabled = True
        Me.listaplik.ItemHeight = 19
        Me.listaplik.Items.AddRange(New Object() {".png", ".bmp", ".jpg"})
        Me.listaplik.Location = New System.Drawing.Point(127, 130)
        Me.listaplik.Name = "listaplik"
        Me.listaplik.Size = New System.Drawing.Size(80, 25)
        Me.listaplik.TabIndex = 7
        Me.listaplik.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.Panel1)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel1.Controls.Add(Me.listaplik)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.lblplik)
        Me.MetroPanel1.Controls.Add(Me.radio1)
        Me.MetroPanel1.Controls.Add(Me.btnfolder)
        Me.MetroPanel1.Controls.Add(Me.radio2)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(23, 58)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(454, 240)
        Me.MetroPanel1.TabIndex = 8
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.n4)
        Me.Panel1.Controls.Add(Me.n3)
        Me.Panel1.Controls.Add(Me.n2)
        Me.Panel1.Controls.Add(Me.n1)
        Me.Panel1.Location = New System.Drawing.Point(3, 193)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 44)
        Me.Panel1.TabIndex = 9
        '
        'n4
        '
        Me.n4.AutoSize = True
        Me.n4.Location = New System.Drawing.Point(226, 3)
        Me.n4.Name = "n4"
        Me.n4.Size = New System.Drawing.Size(78, 15)
        Me.n4.TabIndex = 13
        Me.n4.Text = "Wycinanie"
        Me.n4.UseSelectable = True
        '
        'n3
        '
        Me.n3.AutoSize = True
        Me.n3.Location = New System.Drawing.Point(167, 3)
        Me.n3.Name = "n3"
        Me.n3.Size = New System.Drawing.Size(53, 15)
        Me.n3.TabIndex = 12
        Me.n3.Text = "Elipsa"
        Me.n3.UseSelectable = True
        '
        'n2
        '
        Me.n2.AutoSize = True
        Me.n2.Location = New System.Drawing.Point(88, 3)
        Me.n2.Name = "n2"
        Me.n2.Size = New System.Drawing.Size(73, 15)
        Me.n2.TabIndex = 11
        Me.n2.Text = "Prostokąt"
        Me.n2.UseSelectable = True
        '
        'n1
        '
        Me.n1.AutoSize = True
        Me.n1.Checked = True
        Me.n1.Location = New System.Drawing.Point(3, 3)
        Me.n1.Name = "n1"
        Me.n1.Size = New System.Drawing.Size(79, 15)
        Me.n1.TabIndex = 10
        Me.n1.TabStop = True
        Me.n1.Text = "Rysowanie"
        Me.n1.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 171)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(129, 19)
        Me.MetroLabel3.TabIndex = 8
        Me.MetroLabel3.Text = "Domyślne narzędzie:"
        '
        'tmr
        '
        '
        'APK05screenshot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 350)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.btnzapisz)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Name = "APK05screenshot"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Text = "ScreenShot"
        Me.TopMost = True
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnzapisz As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents radio1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radio2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents btnfolder As MetroFramework.Controls.MetroLink
    Friend WithEvents lblplik As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents listaplik As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents oknofolder As FolderBrowserDialog
    Friend WithEvents tmr As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents n2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents n1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents n4 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents n3 As MetroFramework.Controls.MetroRadioButton
End Class
