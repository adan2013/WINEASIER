<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK14przeniesdo
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
        Me.btnzatwierdz = New MetroFramework.Controls.MetroLink()
        Me.btnanuluj = New MetroFramework.Controls.MetroLink()
        Me.lista = New MetroFramework.Controls.MetroComboBox()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(209, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Wybierz katalog docelowy"
        '
        'btnzatwierdz
        '
        Me.btnzatwierdz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzatwierdz.Location = New System.Drawing.Point(302, 104)
        Me.btnzatwierdz.Name = "btnzatwierdz"
        Me.btnzatwierdz.Size = New System.Drawing.Size(75, 23)
        Me.btnzatwierdz.TabIndex = 1
        Me.btnzatwierdz.Text = "Zatwierdź"
        Me.btnzatwierdz.UseSelectable = True
        '
        'btnanuluj
        '
        Me.btnanuluj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnanuluj.Location = New System.Drawing.Point(246, 104)
        Me.btnanuluj.Name = "btnanuluj"
        Me.btnanuluj.Size = New System.Drawing.Size(50, 23)
        Me.btnanuluj.TabIndex = 2
        Me.btnanuluj.Text = "Anuluj"
        Me.btnanuluj.UseSelectable = True
        '
        'lista
        '
        Me.lista.FormattingEnabled = True
        Me.lista.ItemHeight = 23
        Me.lista.Location = New System.Drawing.Point(23, 69)
        Me.lista.Name = "lista"
        Me.lista.Size = New System.Drawing.Size(354, 29)
        Me.lista.TabIndex = 3
        Me.lista.UseSelectable = True
        '
        'APK14przeniesdo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 150)
        Me.ControlBox = False
        Me.Controls.Add(Me.lista)
        Me.Controls.Add(Me.btnanuluj)
        Me.Controls.Add(Me.btnzatwierdz)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "APK14przeniesdo"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Text = "Przenieś do - Magazyn stron WWW"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnzatwierdz As MetroFramework.Controls.MetroLink
    Friend WithEvents btnanuluj As MetroFramework.Controls.MetroLink
    Friend WithEvents lista As MetroFramework.Controls.MetroComboBox
End Class
