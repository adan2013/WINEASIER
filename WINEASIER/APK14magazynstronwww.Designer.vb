<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class APK14magazynstronwww
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
        Me.components = New System.ComponentModel.Container()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.panelgl = New System.Windows.Forms.Panel()
        Me.lbldn = New MetroFramework.Controls.MetroLabel()
        Me.lblup = New MetroFramework.Controls.MetroLabel()
        Me.btndodaj = New MetroFramework.Controls.MetroLink()
        Me.lblpath = New MetroFramework.Controls.MetroLabel()
        Me.btnback = New MetroFramework.Controls.MetroLink()
        Me.txtszukaj = New MetroFramework.Controls.MetroTextBox()
        Me.panelzlista = New System.Windows.Forms.Panel()
        Me.menupoz = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menupozusunstrone = New System.Windows.Forms.ToolStripMenuItem()
        Me.menupozmodyfikujwpis = New System.Windows.Forms.ToolStripMenuItem()
        Me.menupozprzeniesdokatalogu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menupozdoschowka = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menupozpobierzikone = New System.Windows.Forms.ToolStripMenuItem()
        Me.menupozusunikone = New System.Windows.Forms.ToolStripMenuItem()
        Me.menukat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.menupozusunkatalog = New System.Windows.Forms.ToolStripMenuItem()
        Me.menupozzmiennazwe = New System.Windows.Forms.ToolStripMenuItem()
        Me.menupozprzenieswszystkie = New System.Windows.Forms.ToolStripMenuItem()
        Me.menupozotworzwszystkie = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelgl.SuspendLayout()
        Me.menupoz.SuspendLayout()
        Me.menukat.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(177, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Magazyn stron WWW"
        '
        'panelgl
        '
        Me.panelgl.Controls.Add(Me.lbldn)
        Me.panelgl.Controls.Add(Me.lblup)
        Me.panelgl.Controls.Add(Me.btndodaj)
        Me.panelgl.Controls.Add(Me.lblpath)
        Me.panelgl.Controls.Add(Me.btnback)
        Me.panelgl.Controls.Add(Me.txtszukaj)
        Me.panelgl.Controls.Add(Me.panelzlista)
        Me.panelgl.Location = New System.Drawing.Point(23, 58)
        Me.panelgl.Name = "panelgl"
        Me.panelgl.Size = New System.Drawing.Size(674, 269)
        Me.panelgl.TabIndex = 1
        '
        'lbldn
        '
        Me.lbldn.AutoSize = True
        Me.lbldn.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbldn.Location = New System.Drawing.Point(439, 14)
        Me.lbldn.Name = "lbldn"
        Me.lbldn.Size = New System.Drawing.Size(20, 25)
        Me.lbldn.TabIndex = 39
        Me.lbldn.Text = "↓"
        Me.lbldn.Visible = False
        '
        'lblup
        '
        Me.lblup.AutoSize = True
        Me.lblup.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblup.Location = New System.Drawing.Point(413, 14)
        Me.lblup.Name = "lblup"
        Me.lblup.Size = New System.Drawing.Size(20, 25)
        Me.lblup.TabIndex = 38
        Me.lblup.Text = "↑"
        Me.lblup.Visible = False
        '
        'btndodaj
        '
        Me.btndodaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndodaj.Location = New System.Drawing.Point(465, 16)
        Me.btndodaj.Name = "btndodaj"
        Me.btndodaj.Size = New System.Drawing.Size(50, 23)
        Me.btndodaj.TabIndex = 5
        Me.btndodaj.Text = "Dodaj"
        Me.btndodaj.UseSelectable = True
        '
        'lblpath
        '
        Me.lblpath.AutoSize = True
        Me.lblpath.Location = New System.Drawing.Point(59, 20)
        Me.lblpath.Name = "lblpath"
        Me.lblpath.Size = New System.Drawing.Size(98, 19)
        Me.lblpath.TabIndex = 4
        Me.lblpath.Text = "Katalog główny"
        '
        'btnback
        '
        Me.btnback.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnback.Enabled = False
        Me.btnback.Location = New System.Drawing.Point(3, 17)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(50, 23)
        Me.btnback.TabIndex = 3
        Me.btnback.Text = "Powrót"
        Me.btnback.UseSelectable = True
        '
        'txtszukaj
        '
        Me.txtszukaj.Lines = New String(-1) {}
        Me.txtszukaj.Location = New System.Drawing.Point(521, 17)
        Me.txtszukaj.MaxLength = 32767
        Me.txtszukaj.Name = "txtszukaj"
        Me.txtszukaj.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtszukaj.PromptText = "Szukaj"
        Me.txtszukaj.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtszukaj.SelectedText = ""
        Me.txtszukaj.Size = New System.Drawing.Size(150, 23)
        Me.txtszukaj.TabIndex = 2
        Me.txtszukaj.UseSelectable = True
        '
        'panelzlista
        '
        Me.panelzlista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelzlista.Location = New System.Drawing.Point(3, 46)
        Me.panelzlista.Name = "panelzlista"
        Me.panelzlista.Size = New System.Drawing.Size(668, 220)
        Me.panelzlista.TabIndex = 0
        '
        'menupoz
        '
        Me.menupoz.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menupozusunstrone, Me.menupozmodyfikujwpis, Me.menupozprzeniesdokatalogu, Me.menupozdoschowka, Me.ToolStripMenuItem1, Me.menupozpobierzikone, Me.menupozusunikone})
        Me.menupoz.Name = "menupoz"
        Me.menupoz.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menupoz.Size = New System.Drawing.Size(211, 142)
        '
        'menupozusunstrone
        '
        Me.menupozusunstrone.Name = "menupozusunstrone"
        Me.menupozusunstrone.Size = New System.Drawing.Size(210, 22)
        Me.menupozusunstrone.Text = "Usuń stronę"
        '
        'menupozmodyfikujwpis
        '
        Me.menupozmodyfikujwpis.Name = "menupozmodyfikujwpis"
        Me.menupozmodyfikujwpis.Size = New System.Drawing.Size(210, 22)
        Me.menupozmodyfikujwpis.Text = "Modyfikuj wpis"
        '
        'menupozprzeniesdokatalogu
        '
        Me.menupozprzeniesdokatalogu.Name = "menupozprzeniesdokatalogu"
        Me.menupozprzeniesdokatalogu.Size = New System.Drawing.Size(210, 22)
        Me.menupozprzeniesdokatalogu.Text = "Przenieś do katalogu..."
        '
        'menupozdoschowka
        '
        Me.menupozdoschowka.Name = "menupozdoschowka"
        Me.menupozdoschowka.Size = New System.Drawing.Size(210, 22)
        Me.menupozdoschowka.Text = "Skopiuj adres do schowka"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(207, 6)
        '
        'menupozpobierzikone
        '
        Me.menupozpobierzikone.Name = "menupozpobierzikone"
        Me.menupozpobierzikone.Size = New System.Drawing.Size(210, 22)
        Me.menupozpobierzikone.Text = "Pobierz ikonę strony"
        '
        'menupozusunikone
        '
        Me.menupozusunikone.Name = "menupozusunikone"
        Me.menupozusunikone.Size = New System.Drawing.Size(210, 22)
        Me.menupozusunikone.Text = "Usuń ikonę strony"
        '
        'menukat
        '
        Me.menukat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menupozusunkatalog, Me.menupozzmiennazwe, Me.menupozprzenieswszystkie, Me.menupozotworzwszystkie})
        Me.menukat.Name = "menukat"
        Me.menukat.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menukat.Size = New System.Drawing.Size(258, 92)
        '
        'menupozusunkatalog
        '
        Me.menupozusunkatalog.Name = "menupozusunkatalog"
        Me.menupozusunkatalog.Size = New System.Drawing.Size(257, 22)
        Me.menupozusunkatalog.Text = "Usuń cały katalog"
        '
        'menupozzmiennazwe
        '
        Me.menupozzmiennazwe.Name = "menupozzmiennazwe"
        Me.menupozzmiennazwe.Size = New System.Drawing.Size(257, 22)
        Me.menupozzmiennazwe.Text = "Zmień nazwę katalogu"
        '
        'menupozprzenieswszystkie
        '
        Me.menupozprzenieswszystkie.Name = "menupozprzenieswszystkie"
        Me.menupozprzenieswszystkie.Size = New System.Drawing.Size(257, 22)
        Me.menupozprzenieswszystkie.Text = "Przenieś zawartość do katalogu..."
        '
        'menupozotworzwszystkie
        '
        Me.menupozotworzwszystkie.Name = "menupozotworzwszystkie"
        Me.menupozotworzwszystkie.Size = New System.Drawing.Size(257, 22)
        Me.menupozotworzwszystkie.Text = "Otwórz wszystkie strony z katalogu"
        '
        'APK14magazynstronwww
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 350)
        Me.Controls.Add(Me.panelgl)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MinimumSize = New System.Drawing.Size(720, 350)
        Me.Name = "APK14magazynstronwww"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Magazyn stron WWW"
        Me.panelgl.ResumeLayout(False)
        Me.panelgl.PerformLayout()
        Me.menupoz.ResumeLayout(False)
        Me.menukat.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents panelgl As Panel
    Friend WithEvents panelzlista As Panel
    Friend WithEvents lblpath As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnback As MetroFramework.Controls.MetroLink
    Friend WithEvents txtszukaj As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btndodaj As MetroFramework.Controls.MetroLink
    Friend WithEvents menupoz As ContextMenuStrip
    Friend WithEvents menupozusunstrone As ToolStripMenuItem
    Friend WithEvents menupozmodyfikujwpis As ToolStripMenuItem
    Friend WithEvents menupozdoschowka As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents menupozpobierzikone As ToolStripMenuItem
    Friend WithEvents menupozusunikone As ToolStripMenuItem
    Friend WithEvents menukat As ContextMenuStrip
    Friend WithEvents menupozusunkatalog As ToolStripMenuItem
    Friend WithEvents menupozzmiennazwe As ToolStripMenuItem
    Friend WithEvents menupozotworzwszystkie As ToolStripMenuItem
    Friend WithEvents lbldn As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblup As MetroFramework.Controls.MetroLabel
    Friend WithEvents menupozprzeniesdokatalogu As ToolStripMenuItem
    Friend WithEvents menupozprzenieswszystkie As ToolStripMenuItem
End Class
