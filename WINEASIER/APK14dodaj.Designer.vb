<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK14dodaj
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
        Me.btnnowy = New MetroFramework.Controls.MetroLink()
        Me.btnanuluj = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtkatalog = New System.Windows.Forms.TextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtnazwa = New System.Windows.Forms.TextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtadres = New System.Windows.Forms.TextBox()
        Me.btndodaj = New MetroFramework.Controls.MetroLink()
        Me.SuspendLayout()
        '
        'btnnowy
        '
        Me.btnnowy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnowy.Location = New System.Drawing.Point(151, 254)
        Me.btnnowy.Name = "btnnowy"
        Me.btnnowy.Size = New System.Drawing.Size(90, 23)
        Me.btnnowy.TabIndex = 0
        Me.btnnowy.Text = "Dodaj katalog"
        Me.btnnowy.UseSelectable = True
        '
        'btnanuluj
        '
        Me.btnanuluj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnanuluj.Location = New System.Drawing.Point(95, 254)
        Me.btnanuluj.Name = "btnanuluj"
        Me.btnanuluj.Size = New System.Drawing.Size(50, 23)
        Me.btnanuluj.TabIndex = 1
        Me.btnanuluj.Text = "Anuluj"
        Me.btnanuluj.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(119, 25)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Dodaj pozycję"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 72)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(126, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Nowa strona WWW"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 181)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Nowy katalog"
        '
        'txtkatalog
        '
        Me.txtkatalog.Location = New System.Drawing.Point(23, 203)
        Me.txtkatalog.MaxLength = 20
        Me.txtkatalog.Name = "txtkatalog"
        Me.txtkatalog.Size = New System.Drawing.Size(250, 20)
        Me.txtkatalog.TabIndex = 5
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 226)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(146, 15)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Dozwolone tylko litery i cyfry"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 95)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(82, 15)
        Me.MetroLabel5.TabIndex = 8
        Me.MetroLabel5.Text = "Nazwa pozycji:"
        '
        'txtnazwa
        '
        Me.txtnazwa.Location = New System.Drawing.Point(23, 113)
        Me.txtnazwa.MaxLength = 30
        Me.txtnazwa.Name = "txtnazwa"
        Me.txtnazwa.Size = New System.Drawing.Size(250, 20)
        Me.txtnazwa.TabIndex = 7
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 136)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(243, 15)
        Me.MetroLabel6.TabIndex = 10
        Me.MetroLabel6.Text = "Adres strony WWW w postaci http://google.pl:"
        '
        'txtadres
        '
        Me.txtadres.Location = New System.Drawing.Point(23, 154)
        Me.txtadres.MaxLength = 300
        Me.txtadres.Name = "txtadres"
        Me.txtadres.Size = New System.Drawing.Size(250, 20)
        Me.txtadres.TabIndex = 9
        '
        'btndodaj
        '
        Me.btndodaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndodaj.Location = New System.Drawing.Point(247, 254)
        Me.btndodaj.Name = "btndodaj"
        Me.btndodaj.Size = New System.Drawing.Size(80, 23)
        Me.btndodaj.TabIndex = 11
        Me.btndodaj.Text = "Dodaj stronę"
        Me.btndodaj.UseSelectable = True
        '
        'APK14dodaj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.btndodaj)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.txtadres)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.txtnazwa)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txtkatalog)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnanuluj)
        Me.Controls.Add(Me.btnnowy)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "APK14dodaj"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Text = "Dodaj - Magazyn stron WWW"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnnowy As MetroFramework.Controls.MetroLink
    Friend WithEvents btnanuluj As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtkatalog As TextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtnazwa As TextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtadres As TextBox
    Friend WithEvents btndodaj As MetroFramework.Controls.MetroLink
End Class
