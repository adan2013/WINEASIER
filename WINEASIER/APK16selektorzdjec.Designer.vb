<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK16selektorzdjec
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.ekran = New System.Windows.Forms.PictureBox()
        Me.panel = New System.Windows.Forms.Panel()
        Me.lblilel = New MetroFramework.Controls.MetroLabel()
        Me.lblfolder = New MetroFramework.Controls.MetroLabel()
        Me.btnzakoncz = New MetroFramework.Controls.MetroLink()
        Me.btnfolder = New MetroFramework.Controls.MetroLink()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.kom = New System.Windows.Forms.Label()
        Me.seldir = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnczysc = New MetroFramework.Controls.MetroLink()
        Me.btnallzazn = New MetroFramework.Controls.MetroLink()
        Me.btnprzenies = New MetroFramework.Controls.MetroLink()
        Me.lblzazn = New MetroFramework.Controls.MetroLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblinfo = New MetroFramework.Controls.MetroLabel()
        Me.infozazn = New System.Windows.Forms.Label()
        CType(Me.ekran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(116, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Selektor zdjęć"
        '
        'ekran
        '
        Me.ekran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ekran.Location = New System.Drawing.Point(189, 77)
        Me.ekran.Name = "ekran"
        Me.ekran.Size = New System.Drawing.Size(488, 350)
        Me.ekran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ekran.TabIndex = 1
        Me.ekran.TabStop = False
        '
        'panel
        '
        Me.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel.Controls.Add(Me.lblilel)
        Me.panel.Controls.Add(Me.lblfolder)
        Me.panel.Controls.Add(Me.btnzakoncz)
        Me.panel.Controls.Add(Me.btnfolder)
        Me.panel.Location = New System.Drawing.Point(23, 145)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(160, 80)
        Me.panel.TabIndex = 2
        '
        'lblilel
        '
        Me.lblilel.AutoSize = True
        Me.lblilel.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblilel.Location = New System.Drawing.Point(3, 24)
        Me.lblilel.Name = "lblilel"
        Me.lblilel.Size = New System.Drawing.Size(29, 15)
        Me.lblilel.TabIndex = 4
        Me.lblilel.Text = "0 / 0"
        '
        'lblfolder
        '
        Me.lblfolder.AutoSize = True
        Me.lblfolder.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblfolder.Location = New System.Drawing.Point(3, 9)
        Me.lblfolder.Name = "lblfolder"
        Me.lblfolder.Size = New System.Drawing.Size(75, 15)
        Me.lblfolder.TabIndex = 3
        Me.lblfolder.Text = "Brak katalogu"
        '
        'btnzakoncz
        '
        Me.btnzakoncz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzakoncz.Location = New System.Drawing.Point(92, 52)
        Me.btnzakoncz.Name = "btnzakoncz"
        Me.btnzakoncz.Size = New System.Drawing.Size(63, 23)
        Me.btnzakoncz.TabIndex = 1
        Me.btnzakoncz.Text = "Zakończ"
        Me.btnzakoncz.UseSelectable = True
        '
        'btnfolder
        '
        Me.btnfolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfolder.Location = New System.Drawing.Point(3, 52)
        Me.btnfolder.Name = "btnfolder"
        Me.btnfolder.Size = New System.Drawing.Size(90, 23)
        Me.btnfolder.TabIndex = 0
        Me.btnfolder.Text = "Zmień folder"
        Me.btnfolder.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.MetroLabel4)
        Me.Panel1.Location = New System.Drawing.Point(23, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 62)
        Me.Panel1.TabIndex = 3
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(151, 60)
        Me.MetroLabel4.TabIndex = 0
        Me.MetroLabel4.Text = "Home - przejdź na początek" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "End - przejdź na koniec" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Strzałki - zmiana zdjęcia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "D" &
    "elete - zazn/odzn zdjęcie"
        '
        'kom
        '
        Me.kom.AutoSize = True
        Me.kom.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.kom.Location = New System.Drawing.Point(200, 87)
        Me.kom.Name = "kom"
        Me.kom.Size = New System.Drawing.Size(224, 30)
        Me.kom.TabIndex = 4
        Me.kom.Text = "Nie załadowano zdjęć"
        '
        'seldir
        '
        Me.seldir.ShowNewFolderButton = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnczysc)
        Me.Panel2.Controls.Add(Me.btnallzazn)
        Me.Panel2.Controls.Add(Me.btnprzenies)
        Me.Panel2.Controls.Add(Me.lblzazn)
        Me.Panel2.Location = New System.Drawing.Point(23, 231)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 85)
        Me.Panel2.TabIndex = 5
        '
        'btnczysc
        '
        Me.btnczysc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnczysc.Location = New System.Drawing.Point(8, 27)
        Me.btnczysc.Name = "btnczysc"
        Me.btnczysc.Size = New System.Drawing.Size(40, 23)
        Me.btnczysc.TabIndex = 7
        Me.btnczysc.Text = "Czyść"
        Me.btnczysc.UseSelectable = True
        '
        'btnallzazn
        '
        Me.btnallzazn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnallzazn.Location = New System.Drawing.Point(54, 27)
        Me.btnallzazn.Name = "btnallzazn"
        Me.btnallzazn.Size = New System.Drawing.Size(100, 23)
        Me.btnallzazn.TabIndex = 6
        Me.btnallzazn.Text = "Zazn. wszystkie"
        Me.btnallzazn.UseSelectable = True
        '
        'btnprzenies
        '
        Me.btnprzenies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprzenies.Location = New System.Drawing.Point(24, 56)
        Me.btnprzenies.Name = "btnprzenies"
        Me.btnprzenies.Size = New System.Drawing.Size(130, 23)
        Me.btnprzenies.TabIndex = 5
        Me.btnprzenies.Text = "Przenieś do selektora"
        Me.btnprzenies.UseSelectable = True
        '
        'lblzazn
        '
        Me.lblzazn.AutoSize = True
        Me.lblzazn.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblzazn.Location = New System.Drawing.Point(3, 9)
        Me.lblzazn.Name = "lblzazn"
        Me.lblzazn.Size = New System.Drawing.Size(90, 15)
        Me.lblzazn.TabIndex = 4
        Me.lblzazn.Text = "Zaznaczonych: 0"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblinfo)
        Me.Panel3.Location = New System.Drawing.Point(23, 322)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 52)
        Me.Panel3.TabIndex = 6
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblinfo.Location = New System.Drawing.Point(3, 3)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(81, 45)
        Me.lblinfo.TabIndex = 4
        Me.lblinfo.Text = "Nazwa:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rozmiar:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rozdzielczość:"
        '
        'infozazn
        '
        Me.infozazn.AutoSize = True
        Me.infozazn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.infozazn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.infozazn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.infozazn.Location = New System.Drawing.Point(544, 87)
        Me.infozazn.Name = "infozazn"
        Me.infozazn.Size = New System.Drawing.Size(122, 23)
        Me.infozazn.TabIndex = 7
        Me.infozazn.Text = "ZAZNACZONY"
        Me.infozazn.Visible = False
        '
        'APK16selektorzdjec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.infozazn)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.kom)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.ekran)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(700, 450)
        Me.Name = "APK16selektorzdjec"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Selektor zdjęć"
        CType(Me.ekran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ekran As PictureBox
    Friend WithEvents panel As Panel
    Friend WithEvents btnzakoncz As MetroFramework.Controls.MetroLink
    Friend WithEvents btnfolder As MetroFramework.Controls.MetroLink
    Friend WithEvents lblilel As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblfolder As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents kom As Label
    Friend WithEvents seldir As FolderBrowserDialog
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnprzenies As MetroFramework.Controls.MetroLink
    Friend WithEvents lblzazn As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblinfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents infozazn As Label
    Friend WithEvents btnallzazn As MetroFramework.Controls.MetroLink
    Friend WithEvents btnczysc As MetroFramework.Controls.MetroLink
End Class
