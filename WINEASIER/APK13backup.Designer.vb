<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK13backup
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnzk = New MetroFramework.Controls.MetroLink()
        Me.lbldn = New MetroFramework.Controls.MetroLabel()
        Me.lblup = New MetroFramework.Controls.MetroLabel()
        Me.btnprzywroc = New MetroFramework.Controls.MetroLink()
        Me.btnzarzadzaj = New MetroFramework.Controls.MetroLink()
        Me.btnkopia = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.lblpath = New MetroFramework.Controls.MetroLabel()
        Me.btnotworz = New MetroFramework.Controls.MetroLink()
        Me.btnzmien = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.btnusun = New MetroFramework.Controls.MetroLink()
        Me.btnnowy = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.panelinfo = New System.Windows.Forms.Panel()
        Me.lblinfo = New MetroFramework.Controls.MetroLabel()
        Me.panellista = New System.Windows.Forms.Panel()
        Me.odswiez = New System.Windows.Forms.Timer(Me.components)
        Me.dialogfolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel1.SuspendLayout()
        Me.panelinfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(133, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Kopie zapasowe"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnzk)
        Me.Panel1.Controls.Add(Me.lbldn)
        Me.Panel1.Controls.Add(Me.lblup)
        Me.Panel1.Controls.Add(Me.btnprzywroc)
        Me.Panel1.Controls.Add(Me.btnzarzadzaj)
        Me.Panel1.Controls.Add(Me.btnkopia)
        Me.Panel1.Controls.Add(Me.MetroLabel6)
        Me.Panel1.Controls.Add(Me.lblpath)
        Me.Panel1.Controls.Add(Me.btnotworz)
        Me.Panel1.Controls.Add(Me.btnzmien)
        Me.Panel1.Controls.Add(Me.MetroLabel4)
        Me.Panel1.Controls.Add(Me.btnusun)
        Me.Panel1.Controls.Add(Me.btnnowy)
        Me.Panel1.Controls.Add(Me.MetroLabel3)
        Me.Panel1.Controls.Add(Me.MetroLabel2)
        Me.Panel1.Controls.Add(Me.panelinfo)
        Me.Panel1.Controls.Add(Me.panellista)
        Me.Panel1.Location = New System.Drawing.Point(23, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(754, 339)
        Me.Panel1.TabIndex = 1
        '
        'btnzk
        '
        Me.btnzk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzk.Enabled = False
        Me.btnzk.Location = New System.Drawing.Point(485, 209)
        Me.btnzk.Name = "btnzk"
        Me.btnzk.Size = New System.Drawing.Size(107, 23)
        Me.btnzk.TabIndex = 15
        Me.btnzk.Text = "Zarządzaj kopiami"
        Me.btnzk.UseSelectable = True
        '
        'lbldn
        '
        Me.lbldn.AutoSize = True
        Me.lbldn.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbldn.Location = New System.Drawing.Point(263, 4)
        Me.lbldn.Name = "lbldn"
        Me.lbldn.Size = New System.Drawing.Size(20, 25)
        Me.lbldn.TabIndex = 5
        Me.lbldn.Text = "↓"
        Me.lbldn.Visible = False
        '
        'lblup
        '
        Me.lblup.AutoSize = True
        Me.lblup.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblup.Location = New System.Drawing.Point(237, 4)
        Me.lblup.Name = "lblup"
        Me.lblup.Size = New System.Drawing.Size(20, 25)
        Me.lblup.TabIndex = 4
        Me.lblup.Text = "↑"
        Me.lblup.Visible = False
        '
        'btnprzywroc
        '
        Me.btnprzywroc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprzywroc.Location = New System.Drawing.Point(389, 209)
        Me.btnprzywroc.Name = "btnprzywroc"
        Me.btnprzywroc.Size = New System.Drawing.Size(90, 23)
        Me.btnprzywroc.TabIndex = 14
        Me.btnprzywroc.Text = "Przywróć dane"
        Me.btnprzywroc.UseSelectable = True
        '
        'btnzarzadzaj
        '
        Me.btnzarzadzaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzarzadzaj.Location = New System.Drawing.Point(230, 302)
        Me.btnzarzadzaj.Name = "btnzarzadzaj"
        Me.btnzarzadzaj.Size = New System.Drawing.Size(130, 23)
        Me.btnzarzadzaj.TabIndex = 12
        Me.btnzarzadzaj.Text = "Zarządzaj rozmiarem"
        Me.btnzarzadzaj.UseSelectable = True
        '
        'btnkopia
        '
        Me.btnkopia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnkopia.Location = New System.Drawing.Point(293, 209)
        Me.btnkopia.Name = "btnkopia"
        Me.btnkopia.Size = New System.Drawing.Size(90, 23)
        Me.btnkopia.TabIndex = 11
        Me.btnkopia.Text = "Wykonaj kopię"
        Me.btnkopia.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.Location = New System.Drawing.Point(526, 284)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(198, 30)
        Me.MetroLabel6.TabIndex = 10
        Me.MetroLabel6.Text = "Pojedyncze kliknięcie - podgląd" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dwukrotne kliknięcie - zmiana ustawień"
        Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblpath
        '
        Me.lblpath.AutoSize = True
        Me.lblpath.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblpath.Location = New System.Drawing.Point(8, 284)
        Me.lblpath.Name = "lblpath"
        Me.lblpath.Size = New System.Drawing.Size(70, 15)
        Me.lblpath.TabIndex = 9
        Me.lblpath.Text = "Nie wybrano"
        '
        'btnotworz
        '
        Me.btnotworz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnotworz.Location = New System.Drawing.Point(104, 302)
        Me.btnotworz.Name = "btnotworz"
        Me.btnotworz.Size = New System.Drawing.Size(120, 23)
        Me.btnotworz.TabIndex = 8
        Me.btnotworz.Text = "Otwórz lokalizację"
        Me.btnotworz.UseSelectable = True
        '
        'btnzmien
        '
        Me.btnzmien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzmien.Location = New System.Drawing.Point(3, 302)
        Me.btnzmien.Name = "btnzmien"
        Me.btnzmien.Size = New System.Drawing.Size(95, 23)
        Me.btnzmien.TabIndex = 7
        Me.btnzmien.Text = "Zmień ścieżkę"
        Me.btnzmien.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 261)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(170, 19)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Magazyn kopii zapasowych:"
        '
        'btnusun
        '
        Me.btnusun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnusun.Enabled = False
        Me.btnusun.Location = New System.Drawing.Point(54, 209)
        Me.btnusun.Name = "btnusun"
        Me.btnusun.Size = New System.Drawing.Size(40, 23)
        Me.btnusun.TabIndex = 5
        Me.btnusun.Text = "Usuń"
        Me.btnusun.UseSelectable = True
        '
        'btnnowy
        '
        Me.btnnowy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnowy.Location = New System.Drawing.Point(8, 209)
        Me.btnnowy.Name = "btnnowy"
        Me.btnnowy.Size = New System.Drawing.Size(40, 23)
        Me.btnnowy.TabIndex = 2
        Me.btnnowy.Text = "Nowy"
        Me.btnnowy.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(293, 10)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Informacje o kopii:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 10)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(161, 19)
        Me.MetroLabel2.TabIndex = 0
        Me.MetroLabel2.Text = "Lista zaplanowanych kopii:"
        '
        'panelinfo
        '
        Me.panelinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelinfo.Controls.Add(Me.lblinfo)
        Me.panelinfo.Location = New System.Drawing.Point(289, 32)
        Me.panelinfo.Name = "panelinfo"
        Me.panelinfo.Size = New System.Drawing.Size(462, 171)
        Me.panelinfo.TabIndex = 3
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblinfo.Location = New System.Drawing.Point(3, 5)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(176, 15)
        Me.lblinfo.TabIndex = 0
        Me.lblinfo.Text = "Nie wybrano pozycji do podglądu"
        '
        'panellista
        '
        Me.panellista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panellista.Location = New System.Drawing.Point(3, 32)
        Me.panellista.Name = "panellista"
        Me.panellista.Size = New System.Drawing.Size(280, 171)
        Me.panellista.TabIndex = 2
        '
        'odswiez
        '
        Me.odswiez.Enabled = True
        Me.odswiez.Interval = 5000
        '
        'APK13backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 420)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Name = "APK13backup"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Backup File Creator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelinfo.ResumeLayout(False)
        Me.panelinfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panellista As Panel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents panelinfo As Panel
    Friend WithEvents lblpath As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnotworz As MetroFramework.Controls.MetroLink
    Friend WithEvents btnzmien As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnusun As MetroFramework.Controls.MetroLink
    Friend WithEvents btnnowy As MetroFramework.Controls.MetroLink
    Friend WithEvents btnzarzadzaj As MetroFramework.Controls.MetroLink
    Friend WithEvents btnkopia As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnprzywroc As MetroFramework.Controls.MetroLink
    Friend WithEvents lbldn As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblup As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblinfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents odswiez As Timer
    Friend WithEvents dialogfolder As FolderBrowserDialog
    Friend WithEvents btnzk As MetroFramework.Controls.MetroLink
End Class
