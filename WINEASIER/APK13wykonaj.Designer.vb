<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK13wykonaj
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
        Me.btnanuluj = New MetroFramework.Controls.MetroLink()
        Me.btnwykonaj = New MetroFramework.Controls.MetroLink()
        Me.lista = New System.Windows.Forms.ListBox()
        Me.lblnazwa = New MetroFramework.Controls.MetroLabel()
        Me.lblstatus = New MetroFramework.Controls.MetroLabel()
        Me.lblostatnia = New MetroFramework.Controls.MetroLabel()
        Me.lblrozoryg = New MetroFramework.Controls.MetroLabel()
        Me.lblaktroz = New MetroFramework.Controls.MetroLabel()
        Me.lblrozlimit = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(211, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Wykonaj kopie na żądanie"
        '
        'btnanuluj
        '
        Me.btnanuluj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnanuluj.Location = New System.Drawing.Point(396, 204)
        Me.btnanuluj.Name = "btnanuluj"
        Me.btnanuluj.Size = New System.Drawing.Size(50, 23)
        Me.btnanuluj.TabIndex = 1
        Me.btnanuluj.Text = "Anuluj"
        Me.btnanuluj.UseSelectable = True
        '
        'btnwykonaj
        '
        Me.btnwykonaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnwykonaj.Enabled = False
        Me.btnwykonaj.Location = New System.Drawing.Point(452, 204)
        Me.btnwykonaj.Name = "btnwykonaj"
        Me.btnwykonaj.Size = New System.Drawing.Size(75, 23)
        Me.btnwykonaj.TabIndex = 2
        Me.btnwykonaj.Text = "Wykonaj"
        Me.btnwykonaj.UseSelectable = True
        '
        'lista
        '
        Me.lista.FormattingEnabled = True
        Me.lista.Location = New System.Drawing.Point(23, 72)
        Me.lista.Name = "lista"
        Me.lista.ScrollAlwaysVisible = True
        Me.lista.Size = New System.Drawing.Size(200, 121)
        Me.lista.TabIndex = 3
        '
        'lblnazwa
        '
        Me.lblnazwa.AutoSize = True
        Me.lblnazwa.Location = New System.Drawing.Point(229, 72)
        Me.lblnazwa.Name = "lblnazwa"
        Me.lblnazwa.Size = New System.Drawing.Size(81, 19)
        Me.lblnazwa.TabIndex = 4
        Me.lblnazwa.Text = "Nazwa: brak"
        Me.lblnazwa.UseCustomForeColor = True
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Location = New System.Drawing.Point(229, 91)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(108, 19)
        Me.lblstatus.TabIndex = 5
        Me.lblstatus.Text = "Status kopii: brak"
        Me.lblstatus.UseCustomForeColor = True
        '
        'lblostatnia
        '
        Me.lblostatnia.AutoSize = True
        Me.lblostatnia.Location = New System.Drawing.Point(229, 110)
        Me.lblostatnia.Name = "lblostatnia"
        Me.lblostatnia.Size = New System.Drawing.Size(126, 19)
        Me.lblostatnia.TabIndex = 6
        Me.lblostatnia.Text = "Ostatnia kopia: brak"
        Me.lblostatnia.UseCustomForeColor = True
        '
        'lblrozoryg
        '
        Me.lblrozoryg.AutoSize = True
        Me.lblrozoryg.Location = New System.Drawing.Point(229, 129)
        Me.lblrozoryg.Name = "lblrozoryg"
        Me.lblrozoryg.Size = New System.Drawing.Size(171, 19)
        Me.lblrozoryg.TabIndex = 7
        Me.lblrozoryg.Text = "Rozmiar oryg. plików: 0 MB"
        Me.lblrozoryg.UseCustomForeColor = True
        '
        'lblaktroz
        '
        Me.lblaktroz.AutoSize = True
        Me.lblaktroz.Location = New System.Drawing.Point(229, 148)
        Me.lblaktroz.Name = "lblaktroz"
        Me.lblaktroz.Size = New System.Drawing.Size(210, 19)
        Me.lblaktroz.TabIndex = 8
        Me.lblaktroz.Text = "Aktualny rozmiar magazynu: 0 MB"
        Me.lblaktroz.UseCustomForeColor = True
        '
        'lblrozlimit
        '
        Me.lblrozlimit.AutoSize = True
        Me.lblrozlimit.Location = New System.Drawing.Point(229, 167)
        Me.lblrozlimit.Name = "lblrozlimit"
        Me.lblrozlimit.Size = New System.Drawing.Size(196, 19)
        Me.lblrozlimit.TabIndex = 9
        Me.lblrozlimit.Text = "Limit rozmiaru magazynu: 0 MB"
        Me.lblrozlimit.UseCustomForeColor = True
        '
        'APK13wykonaj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblrozlimit)
        Me.Controls.Add(Me.lblaktroz)
        Me.Controls.Add(Me.lblrozoryg)
        Me.Controls.Add(Me.lblostatnia)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.lblnazwa)
        Me.Controls.Add(Me.lista)
        Me.Controls.Add(Me.btnwykonaj)
        Me.Controls.Add(Me.btnanuluj)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "APK13wykonaj"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Text = "Backup File Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnanuluj As MetroFramework.Controls.MetroLink
    Friend WithEvents btnwykonaj As MetroFramework.Controls.MetroLink
    Friend WithEvents lista As ListBox
    Friend WithEvents lblnazwa As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblstatus As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblostatnia As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblrozoryg As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblaktroz As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblrozlimit As MetroFramework.Controls.MetroLabel
End Class
