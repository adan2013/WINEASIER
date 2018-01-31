<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class APK15kalendarz
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbldn = New MetroFramework.Controls.MetroLabel()
        Me.lblup = New MetroFramework.Controls.MetroLabel()
        Me.btnzarzadzaj = New MetroFramework.Controls.MetroLink()
        Me.panellst = New System.Windows.Forms.Panel()
        Me.btnkat = New MetroFramework.Controls.MetroLink()
        Me.btnnowe = New MetroFramework.Controls.MetroLink()
        Me.panelkal = New System.Windows.Forms.Panel()
        Me.lista2 = New MetroFramework.Controls.MetroComboBox()
        Me.lista1 = New MetroFramework.Controls.MetroComboBox()
        Me.lista = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(86, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Kalendarz"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbldn)
        Me.Panel1.Controls.Add(Me.lblup)
        Me.Panel1.Controls.Add(Me.btnzarzadzaj)
        Me.Panel1.Controls.Add(Me.panellst)
        Me.Panel1.Controls.Add(Me.btnkat)
        Me.Panel1.Controls.Add(Me.btnnowe)
        Me.Panel1.Controls.Add(Me.panelkal)
        Me.Panel1.Controls.Add(Me.lista2)
        Me.Panel1.Controls.Add(Me.lista1)
        Me.Panel1.Location = New System.Drawing.Point(23, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(554, 269)
        Me.Panel1.TabIndex = 1
        '
        'lbldn
        '
        Me.lbldn.AutoSize = True
        Me.lbldn.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbldn.Location = New System.Drawing.Point(273, 7)
        Me.lbldn.Name = "lbldn"
        Me.lbldn.Size = New System.Drawing.Size(20, 25)
        Me.lbldn.TabIndex = 41
        Me.lbldn.Text = "↓"
        Me.lbldn.Visible = False
        '
        'lblup
        '
        Me.lblup.AutoSize = True
        Me.lblup.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblup.Location = New System.Drawing.Point(247, 7)
        Me.lblup.Name = "lblup"
        Me.lblup.Size = New System.Drawing.Size(20, 25)
        Me.lblup.TabIndex = 40
        Me.lblup.Text = "↑"
        Me.lblup.Visible = False
        '
        'btnzarzadzaj
        '
        Me.btnzarzadzaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzarzadzaj.Location = New System.Drawing.Point(299, 9)
        Me.btnzarzadzaj.Name = "btnzarzadzaj"
        Me.btnzarzadzaj.Size = New System.Drawing.Size(60, 23)
        Me.btnzarzadzaj.TabIndex = 4
        Me.btnzarzadzaj.Text = "Zarządzaj"
        Me.btnzarzadzaj.UseSelectable = True
        '
        'panellst
        '
        Me.panellst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panellst.Location = New System.Drawing.Point(237, 38)
        Me.panellst.Name = "panellst"
        Me.panellst.Size = New System.Drawing.Size(314, 228)
        Me.panellst.TabIndex = 3
        '
        'btnkat
        '
        Me.btnkat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnkat.Location = New System.Drawing.Point(365, 9)
        Me.btnkat.Name = "btnkat"
        Me.btnkat.Size = New System.Drawing.Size(70, 23)
        Me.btnkat.TabIndex = 3
        Me.btnkat.Text = "Kategorie"
        Me.btnkat.UseSelectable = True
        '
        'btnnowe
        '
        Me.btnnowe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnowe.Location = New System.Drawing.Point(441, 9)
        Me.btnnowe.Name = "btnnowe"
        Me.btnnowe.Size = New System.Drawing.Size(110, 23)
        Me.btnnowe.TabIndex = 2
        Me.btnnowe.Text = "Nowe wydarzenie"
        Me.btnnowe.UseSelectable = True
        '
        'panelkal
        '
        Me.panelkal.Location = New System.Drawing.Point(3, 38)
        Me.panelkal.Name = "panelkal"
        Me.panelkal.Size = New System.Drawing.Size(228, 228)
        Me.panelkal.TabIndex = 2
        '
        'lista2
        '
        Me.lista2.FormattingEnabled = True
        Me.lista2.ItemHeight = 23
        Me.lista2.Location = New System.Drawing.Point(149, 3)
        Me.lista2.Name = "lista2"
        Me.lista2.Size = New System.Drawing.Size(82, 29)
        Me.lista2.TabIndex = 1
        Me.lista2.UseSelectable = True
        '
        'lista1
        '
        Me.lista1.FormattingEnabled = True
        Me.lista1.ItemHeight = 23
        Me.lista1.Items.AddRange(New Object() {"Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec", "Lipiec", "Sierpień", "Wrzesień", "Październik", "Listopad", "Grudzień"})
        Me.lista1.Location = New System.Drawing.Point(3, 3)
        Me.lista1.Name = "lista1"
        Me.lista1.Size = New System.Drawing.Size(140, 29)
        Me.lista1.TabIndex = 0
        Me.lista1.UseSelectable = True
        '
        'lista
        '
        '
        'APK15kalendarz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 350)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Name = "APK15kalendarz"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Kalendarz"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lista2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lista1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents panelkal As Panel
    Friend WithEvents panellst As Panel
    Friend WithEvents btnkat As MetroFramework.Controls.MetroLink
    Friend WithEvents btnnowe As MetroFramework.Controls.MetroLink
    Friend WithEvents btnzarzadzaj As MetroFramework.Controls.MetroLink
    Friend WithEvents lbldn As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblup As MetroFramework.Controls.MetroLabel
    Friend WithEvents lista As Timer
End Class
