<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK17wylacznik
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
        Me.ust1 = New MetroFramework.Controls.MetroRadioButton()
        Me.ust2 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.ust3 = New MetroFramework.Controls.MetroRadioButton()
        Me.ilmin = New System.Windows.Forms.NumericUpDown()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.typ2 = New MetroFramework.Controls.MetroRadioButton()
        Me.typ1 = New MetroFramework.Controls.MetroRadioButton()
        Me.zam = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ilmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(87, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Wyłącznik"
        '
        'ust1
        '
        Me.ust1.AutoSize = True
        Me.ust1.Checked = True
        Me.ust1.Location = New System.Drawing.Point(14, 22)
        Me.ust1.Name = "ust1"
        Me.ust1.Size = New System.Drawing.Size(46, 15)
        Me.ust1.TabIndex = 1
        Me.ust1.TabStop = True
        Me.ust1.Text = "Brak"
        Me.ust1.UseSelectable = True
        '
        'ust2
        '
        Me.ust2.AutoSize = True
        Me.ust2.Location = New System.Drawing.Point(14, 43)
        Me.ust2.Name = "ust2"
        Me.ust2.Size = New System.Drawing.Size(209, 15)
        Me.ust2.TabIndex = 2
        Me.ust2.Text = "Wyłącz od razu po upłynięciu czasu"
        Me.ust2.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(223, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Wyłączenie po bezczynności kursora:"
        '
        'ust3
        '
        Me.ust3.AutoSize = True
        Me.ust3.Location = New System.Drawing.Point(14, 64)
        Me.ust3.Name = "ust3"
        Me.ust3.Size = New System.Drawing.Size(265, 15)
        Me.ust3.TabIndex = 4
        Me.ust3.Text = "Wyświetl powiadomienie przed końcem czasu"
        Me.ust3.UseSelectable = True
        '
        'ilmin
        '
        Me.ilmin.Location = New System.Drawing.Point(203, 82)
        Me.ilmin.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.ilmin.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.ilmin.Name = "ilmin"
        Me.ilmin.Size = New System.Drawing.Size(65, 20)
        Me.ilmin.TabIndex = 5
        Me.ilmin.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 82)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(194, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Czas do wyłączenia w minutach:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(97, 19)
        Me.MetroLabel4.TabIndex = 7
        Me.MetroLabel4.Text = "Typ wyłączenia:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MetroLabel2)
        Me.Panel1.Controls.Add(Me.ust1)
        Me.Panel1.Controls.Add(Me.MetroLabel3)
        Me.Panel1.Controls.Add(Me.ust2)
        Me.Panel1.Controls.Add(Me.ilmin)
        Me.Panel1.Controls.Add(Me.ust3)
        Me.Panel1.Location = New System.Drawing.Point(23, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(324, 110)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.typ2)
        Me.Panel2.Controls.Add(Me.typ1)
        Me.Panel2.Controls.Add(Me.MetroLabel4)
        Me.Panel2.Location = New System.Drawing.Point(23, 174)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(324, 73)
        Me.Panel2.TabIndex = 9
        '
        'typ2
        '
        Me.typ2.AutoSize = True
        Me.typ2.Location = New System.Drawing.Point(14, 43)
        Me.typ2.Name = "typ2"
        Me.typ2.Size = New System.Drawing.Size(301, 15)
        Me.typ2.TabIndex = 8
        Me.typ2.Text = "Hybrydowe (dla systemów nowszych niż Windows 7)"
        Me.typ2.UseSelectable = True
        '
        'typ1
        '
        Me.typ1.AutoSize = True
        Me.typ1.Checked = True
        Me.typ1.Location = New System.Drawing.Point(14, 22)
        Me.typ1.Name = "typ1"
        Me.typ1.Size = New System.Drawing.Size(273, 15)
        Me.typ1.TabIndex = 7
        Me.typ1.TabStop = True
        Me.typ1.Text = "Zwykłe (dla systemów starszych niż Windows 8)"
        Me.typ1.UseSelectable = True
        '
        'zam
        '
        Me.zam.Interval = 10
        '
        'APK17wylacznik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 270)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Name = "APK17wylacznik"
        Me.Opacity = 0R
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Wyłącznik"
        CType(Me.ilmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ust1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents ust2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ust3 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents ilmin As NumericUpDown
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents typ2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents typ1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents zam As Timer
End Class
