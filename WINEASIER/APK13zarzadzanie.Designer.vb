<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK13zarzadzanie
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
        Me.btnzamknij = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblstatus = New MetroFramework.Controls.MetroLabel()
        Me.btnanuluj = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.listakopii = New System.Windows.Forms.ListBox()
        Me.btnusun = New MetroFramework.Controls.MetroLink()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(169, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Zarządzanie kopiami"
        '
        'btnzamknij
        '
        Me.btnzamknij.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzamknij.Location = New System.Drawing.Point(217, 354)
        Me.btnzamknij.Name = "btnzamknij"
        Me.btnzamknij.Size = New System.Drawing.Size(60, 23)
        Me.btnzamknij.TabIndex = 1
        Me.btnzamknij.Text = "Zamknij"
        Me.btnzamknij.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 80)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(100, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Tworzenie kopii"
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblstatus.Location = New System.Drawing.Point(23, 109)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(160, 15)
        Me.lblstatus.TabIndex = 3
        Me.lblstatus.Text = "Status: Kopia nie jest tworzona"
        '
        'btnanuluj
        '
        Me.btnanuluj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnanuluj.Location = New System.Drawing.Point(137, 133)
        Me.btnanuluj.Name = "btnanuluj"
        Me.btnanuluj.Size = New System.Drawing.Size(140, 23)
        Me.btnanuluj.TabIndex = 4
        Me.btnanuluj.Text = "Anuluj tworzenie kopii"
        Me.btnanuluj.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 185)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(143, 19)
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "Lista utworzonych kopii"
        '
        'listakopii
        '
        Me.listakopii.FormattingEnabled = True
        Me.listakopii.Location = New System.Drawing.Point(23, 207)
        Me.listakopii.Name = "listakopii"
        Me.listakopii.ScrollAlwaysVisible = True
        Me.listakopii.Size = New System.Drawing.Size(254, 82)
        Me.listakopii.TabIndex = 6
        '
        'btnusun
        '
        Me.btnusun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnusun.Enabled = False
        Me.btnusun.Location = New System.Drawing.Point(227, 295)
        Me.btnusun.Name = "btnusun"
        Me.btnusun.Size = New System.Drawing.Size(50, 23)
        Me.btnusun.TabIndex = 7
        Me.btnusun.Text = "Usuń"
        Me.btnusun.UseSelectable = True
        '
        'APK13zarzadzanie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnusun)
        Me.Controls.Add(Me.listakopii)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.btnanuluj)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnzamknij)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "APK13zarzadzanie"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Text = "Backup File Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnzamknij As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblstatus As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnanuluj As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents listakopii As ListBox
    Friend WithEvents btnusun As MetroFramework.Controls.MetroLink
End Class
