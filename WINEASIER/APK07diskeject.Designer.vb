<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK07diskeject
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
        Me.switchonoff = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.limit1 = New MetroFramework.Controls.MetroRadioButton()
        Me.limit2 = New MetroFramework.Controls.MetroRadioButton()
        Me.limit3 = New MetroFramework.Controls.MetroRadioButton()
        Me.limit4 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.lbldyski = New MetroFramework.Controls.MetroLabel()
        Me.btnzmien = New MetroFramework.Controls.MetroLink()
        Me.closetmr = New System.Windows.Forms.Timer(Me.components)
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
        'switchonoff
        '
        Me.switchonoff.AutoSize = True
        Me.switchonoff.DisplayStatus = False
        Me.switchonoff.Location = New System.Drawing.Point(33, 82)
        Me.switchonoff.Name = "switchonoff"
        Me.switchonoff.Size = New System.Drawing.Size(50, 17)
        Me.switchonoff.TabIndex = 1
        Me.switchonoff.Text = "Off"
        Me.switchonoff.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.Location = New System.Drawing.Point(89, 84)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(139, 15)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Status uruchomienia usługi"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.Location = New System.Drawing.Point(33, 117)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(120, 15)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Limit czasowy blokady:"
        '
        'limit1
        '
        Me.limit1.AutoSize = True
        Me.limit1.Checked = True
        Me.limit1.Location = New System.Drawing.Point(33, 135)
        Me.limit1.Name = "limit1"
        Me.limit1.Size = New System.Drawing.Size(136, 15)
        Me.limit1.TabIndex = 4
        Me.limit1.TabStop = True
        Me.limit1.Text = "Bez limitu czasowego"
        Me.limit1.UseSelectable = True
        '
        'limit2
        '
        Me.limit2.AutoSize = True
        Me.limit2.Location = New System.Drawing.Point(33, 156)
        Me.limit2.Name = "limit2"
        Me.limit2.Size = New System.Drawing.Size(165, 15)
        Me.limit2.TabIndex = 5
        Me.limit2.Text = "Blokuj tylko przez 5 sekund"
        Me.limit2.UseSelectable = True
        '
        'limit3
        '
        Me.limit3.AutoSize = True
        Me.limit3.Location = New System.Drawing.Point(33, 177)
        Me.limit3.Name = "limit3"
        Me.limit3.Size = New System.Drawing.Size(171, 15)
        Me.limit3.TabIndex = 6
        Me.limit3.Text = "Blokuj tylko przez 15 sekund"
        Me.limit3.UseSelectable = True
        '
        'limit4
        '
        Me.limit4.AutoSize = True
        Me.limit4.Location = New System.Drawing.Point(33, 198)
        Me.limit4.Name = "limit4"
        Me.limit4.Size = New System.Drawing.Size(171, 15)
        Me.limit4.TabIndex = 7
        Me.limit4.Text = "Blokuj tylko przez 25 sekund"
        Me.limit4.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.Location = New System.Drawing.Point(33, 227)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(269, 15)
        Me.MetroLabel4.TabIndex = 8
        Me.MetroLabel4.Text = "Dyski ignorowane podczas uruchamiania komputera:"
        '
        'lbldyski
        '
        Me.lbldyski.AutoSize = True
        Me.lbldyski.Location = New System.Drawing.Point(89, 245)
        Me.lbldyski.Name = "lbldyski"
        Me.lbldyski.Size = New System.Drawing.Size(91, 19)
        Me.lbldyski.TabIndex = 9
        Me.lbldyski.Text = "brak wyjątków"
        '
        'btnzmien
        '
        Me.btnzmien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzmien.Location = New System.Drawing.Point(33, 245)
        Me.btnzmien.Name = "btnzmien"
        Me.btnzmien.Size = New System.Drawing.Size(50, 19)
        Me.btnzmien.TabIndex = 10
        Me.btnzmien.Text = "Zmień"
        Me.btnzmien.UseSelectable = True
        '
        'closetmr
        '
        Me.closetmr.Interval = 1
        '
        'APK07diskeject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.Controls.Add(Me.btnzmien)
        Me.Controls.Add(Me.lbldyski)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.limit4)
        Me.Controls.Add(Me.limit3)
        Me.Controls.Add(Me.limit2)
        Me.Controls.Add(Me.limit1)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.switchonoff)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Name = "APK07diskeject"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Disk Eject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents switchonoff As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents limit1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents limit2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents limit3 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents limit4 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbldyski As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnzmien As MetroFramework.Controls.MetroLink
    Friend WithEvents closetmr As Timer
End Class
