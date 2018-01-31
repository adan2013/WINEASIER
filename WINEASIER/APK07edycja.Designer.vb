<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK07edycja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(APK07edycja))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnzapisz = New MetroFramework.Controls.MetroLink()
        Me.btnanuluj = New MetroFramework.Controls.MetroLink()
        Me.btnhelp = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.lblstary = New MetroFramework.Controls.MetroLabel()
        Me.lblnowy = New MetroFramework.Controls.MetroLabel()
        Me.lista = New System.Windows.Forms.CheckedListBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.info1 = New MetroFramework.Controls.MetroLabel()
        Me.info2 = New MetroFramework.Controls.MetroLabel()
        Me.info3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.info4 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(166, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Edycja listy wyjątków"
        '
        'btnzapisz
        '
        Me.btnzapisz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzapisz.Location = New System.Drawing.Point(462, 219)
        Me.btnzapisz.Name = "btnzapisz"
        Me.btnzapisz.Size = New System.Drawing.Size(85, 23)
        Me.btnzapisz.TabIndex = 1
        Me.btnzapisz.Text = "Zapisz zmiany"
        Me.btnzapisz.UseSelectable = True
        '
        'btnanuluj
        '
        Me.btnanuluj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnanuluj.Location = New System.Drawing.Point(406, 219)
        Me.btnanuluj.Name = "btnanuluj"
        Me.btnanuluj.Size = New System.Drawing.Size(50, 23)
        Me.btnanuluj.TabIndex = 2
        Me.btnanuluj.Text = "Anuluj"
        Me.btnanuluj.UseSelectable = True
        '
        'btnhelp
        '
        Me.btnhelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhelp.Location = New System.Drawing.Point(280, 219)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(120, 23)
        Me.btnhelp.TabIndex = 3
        Me.btnhelp.Text = "Jakie dyski wybrać?"
        Me.btnhelp.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 255)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(517, 95)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = resources.GetString("MetroLabel2.Text")
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 227)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(90, 15)
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "Poprzedni filtr:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel4.Location = New System.Drawing.Point(47, 210)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(66, 15)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Nowy filtr:"
        '
        'lblstary
        '
        Me.lblstary.AutoSize = True
        Me.lblstary.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblstary.Location = New System.Drawing.Point(119, 227)
        Me.lblstary.Name = "lblstary"
        Me.lblstary.Size = New System.Drawing.Size(34, 15)
        Me.lblstary.TabIndex = 7
        Me.lblstary.Text = "pusty"
        '
        'lblnowy
        '
        Me.lblnowy.AutoSize = True
        Me.lblnowy.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblnowy.Location = New System.Drawing.Point(119, 210)
        Me.lblnowy.Name = "lblnowy"
        Me.lblnowy.Size = New System.Drawing.Size(34, 15)
        Me.lblnowy.TabIndex = 8
        Me.lblnowy.Text = "pusty"
        '
        'lista
        '
        Me.lista.FormattingEnabled = True
        Me.lista.Location = New System.Drawing.Point(35, 83)
        Me.lista.Name = "lista"
        Me.lista.ScrollAlwaysVisible = True
        Me.lista.Size = New System.Drawing.Size(203, 109)
        Me.lista.TabIndex = 9
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.MetroLabel5.Location = New System.Drawing.Point(269, 162)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(256, 30)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Podświetl element na liście po lewej, aby wyświetlić" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "więcej szczegółów o zaznacz" &
    "onej partycji"
        Me.MetroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel5.UseCustomForeColor = True
        Me.MetroLabel5.UseStyleColors = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(260, 83)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel6.TabIndex = 11
        Me.MetroLabel6.Text = "Główny katalog:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel7.Location = New System.Drawing.Point(269, 102)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(109, 19)
        Me.MetroLabel7.TabIndex = 12
        Me.MetroLabel7.Text = "Etykieta dysku:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel8.Location = New System.Drawing.Point(256, 121)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(122, 19)
        Me.MetroLabel8.TabIndex = 13
        Me.MetroLabel8.Text = "Gotowość dysku:"
        '
        'info1
        '
        Me.info1.AutoSize = True
        Me.info1.Location = New System.Drawing.Point(384, 83)
        Me.info1.Name = "info1"
        Me.info1.Size = New System.Drawing.Size(97, 19)
        Me.info1.TabIndex = 14
        Me.info1.Text = "brak informacji"
        '
        'info2
        '
        Me.info2.AutoSize = True
        Me.info2.Location = New System.Drawing.Point(384, 102)
        Me.info2.Name = "info2"
        Me.info2.Size = New System.Drawing.Size(97, 19)
        Me.info2.TabIndex = 15
        Me.info2.Text = "brak informacji"
        '
        'info3
        '
        Me.info3.AutoSize = True
        Me.info3.Location = New System.Drawing.Point(384, 121)
        Me.info3.Name = "info3"
        Me.info3.Size = New System.Drawing.Size(97, 19)
        Me.info3.TabIndex = 16
        Me.info3.Text = "brak informacji"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel9.Location = New System.Drawing.Point(249, 140)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(129, 19)
        Me.MetroLabel9.TabIndex = 17
        Me.MetroLabel9.Text = "Pojemność dysku:"
        '
        'info4
        '
        Me.info4.AutoSize = True
        Me.info4.Location = New System.Drawing.Point(384, 140)
        Me.info4.Name = "info4"
        Me.info4.Size = New System.Drawing.Size(97, 19)
        Me.info4.TabIndex = 18
        Me.info4.Text = "brak informacji"
        '
        'APK07edycja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 370)
        Me.ControlBox = False
        Me.Controls.Add(Me.info4)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.info3)
        Me.Controls.Add(Me.info2)
        Me.Controls.Add(Me.info1)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.lista)
        Me.Controls.Add(Me.lblnowy)
        Me.Controls.Add(Me.lblstary)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnhelp)
        Me.Controls.Add(Me.btnanuluj)
        Me.Controls.Add(Me.btnzapisz)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Name = "APK07edycja"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Disk Eject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnzapisz As MetroFramework.Controls.MetroLink
    Friend WithEvents btnanuluj As MetroFramework.Controls.MetroLink
    Friend WithEvents btnhelp As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblstary As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblnowy As MetroFramework.Controls.MetroLabel
    Friend WithEvents lista As CheckedListBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents info1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents info2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents info3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents info4 As MetroFramework.Controls.MetroLabel
End Class
