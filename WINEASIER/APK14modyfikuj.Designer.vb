<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK14modyfikuj
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
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtadres = New System.Windows.Forms.TextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtnazwa = New System.Windows.Forms.TextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnzapisz = New MetroFramework.Controls.MetroLink()
        Me.btnanuluj = New MetroFramework.Controls.MetroLink()
        Me.SuspendLayout()
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 109)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(243, 15)
        Me.MetroLabel6.TabIndex = 14
        Me.MetroLabel6.Text = "Adres strony WWW w postaci http://google.pl:"
        '
        'txtadres
        '
        Me.txtadres.Location = New System.Drawing.Point(23, 127)
        Me.txtadres.MaxLength = 300
        Me.txtadres.Name = "txtadres"
        Me.txtadres.Size = New System.Drawing.Size(250, 20)
        Me.txtadres.TabIndex = 13
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 68)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(82, 15)
        Me.MetroLabel5.TabIndex = 12
        Me.MetroLabel5.Text = "Nazwa pozycji:"
        '
        'txtnazwa
        '
        Me.txtnazwa.Location = New System.Drawing.Point(23, 86)
        Me.txtnazwa.MaxLength = 30
        Me.txtnazwa.Name = "txtnazwa"
        Me.txtnazwa.Size = New System.Drawing.Size(250, 20)
        Me.txtnazwa.TabIndex = 11
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(159, 25)
        Me.MetroLabel1.TabIndex = 15
        Me.MetroLabel1.Text = "Modyfikacja pozycji"
        '
        'btnzapisz
        '
        Me.btnzapisz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzapisz.Location = New System.Drawing.Point(227, 154)
        Me.btnzapisz.Name = "btnzapisz"
        Me.btnzapisz.Size = New System.Drawing.Size(50, 23)
        Me.btnzapisz.TabIndex = 16
        Me.btnzapisz.Text = "Zapisz"
        Me.btnzapisz.UseSelectable = True
        '
        'btnanuluj
        '
        Me.btnanuluj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnanuluj.Location = New System.Drawing.Point(171, 154)
        Me.btnanuluj.Name = "btnanuluj"
        Me.btnanuluj.Size = New System.Drawing.Size(50, 23)
        Me.btnanuluj.TabIndex = 17
        Me.btnanuluj.Text = "Anuluj"
        Me.btnanuluj.UseSelectable = True
        '
        'APK14modyfikuj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnanuluj)
        Me.Controls.Add(Me.btnzapisz)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.txtadres)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.txtnazwa)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "APK14modyfikuj"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Modyfikacja - Magazyn stron WWW"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtadres As TextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtnazwa As TextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnzapisz As MetroFramework.Controls.MetroLink
    Friend WithEvents btnanuluj As MetroFramework.Controls.MetroLink
End Class
