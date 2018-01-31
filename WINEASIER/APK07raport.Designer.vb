<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK07raport
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
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lbllista = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.btnzamknij = New MetroFramework.Controls.MetroLink()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(83, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Disk Eject"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 79)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(334, 57)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Usługa Disk Eject zablokowała zamykanie systemu," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ponieważ wykryła conajmnie jede" &
    "n dysk, który" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "powinien być odłączony przed wyłączeniem komputera."
        '
        'lbllista
        '
        Me.lbllista.AutoSize = True
        Me.lbllista.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lbllista.Location = New System.Drawing.Point(23, 154)
        Me.lbllista.Name = "lbllista"
        Me.lbllista.Size = New System.Drawing.Size(46, 19)
        Me.lbllista.TabIndex = 2
        Me.lbllista.Text = "LISTA"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 348)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(353, 38)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Jeżeli któryś z wykrytych dysków nie powinien być zgłaszany" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dodaj jego literę do" &
    " wyjątków programu Disk Eject"
        '
        'btnzamknij
        '
        Me.btnzamknij.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzamknij.Location = New System.Drawing.Point(276, 404)
        Me.btnzamknij.Name = "btnzamknij"
        Me.btnzamknij.Size = New System.Drawing.Size(100, 23)
        Me.btnzamknij.TabIndex = 4
        Me.btnzamknij.Text = "Zamknij okno"
        Me.btnzamknij.UseSelectable = True
        '
        'APK07raport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnzamknij)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.lbllista)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Movable = False
        Me.Name = "APK07raport"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Text = "Disk Eject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbllista As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnzamknij As MetroFramework.Controls.MetroLink
End Class
