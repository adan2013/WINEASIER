<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK03minutnik
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
        Me.lbl = New System.Windows.Forms.Label()
        Me.godzplus = New MetroFramework.Controls.MetroLink()
        Me.minplus = New MetroFramework.Controls.MetroLink()
        Me.sekplus = New MetroFramework.Controls.MetroLink()
        Me.godzminus = New MetroFramework.Controls.MetroLink()
        Me.minminus = New MetroFramework.Controls.MetroLink()
        Me.sekminus = New MetroFramework.Controls.MetroLink()
        Me.btnleft = New MetroFramework.Controls.MetroLink()
        Me.btnright = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.radio1 = New MetroFramework.Controls.MetroRadioButton()
        Me.radio2 = New MetroFramework.Controls.MetroRadioButton()
        Me.odl = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(78, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Minutnik"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl.Location = New System.Drawing.Point(23, 72)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(179, 54)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "0:00:00"
        '
        'godzplus
        '
        Me.godzplus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.godzplus.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.godzplus.Location = New System.Drawing.Point(32, 142)
        Me.godzplus.Name = "godzplus"
        Me.godzplus.Size = New System.Drawing.Size(30, 30)
        Me.godzplus.TabIndex = 2
        Me.godzplus.Text = "+"
        Me.godzplus.UseSelectable = True
        '
        'minplus
        '
        Me.minplus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minplus.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.minplus.Location = New System.Drawing.Point(85, 142)
        Me.minplus.Name = "minplus"
        Me.minplus.Size = New System.Drawing.Size(30, 30)
        Me.minplus.TabIndex = 3
        Me.minplus.Text = "+"
        Me.minplus.UseSelectable = True
        '
        'sekplus
        '
        Me.sekplus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sekplus.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.sekplus.Location = New System.Drawing.Point(148, 142)
        Me.sekplus.Name = "sekplus"
        Me.sekplus.Size = New System.Drawing.Size(30, 30)
        Me.sekplus.TabIndex = 4
        Me.sekplus.Text = "+"
        Me.sekplus.UseSelectable = True
        '
        'godzminus
        '
        Me.godzminus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.godzminus.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.godzminus.Location = New System.Drawing.Point(32, 178)
        Me.godzminus.Name = "godzminus"
        Me.godzminus.Size = New System.Drawing.Size(30, 30)
        Me.godzminus.TabIndex = 5
        Me.godzminus.Text = "-"
        Me.godzminus.UseSelectable = True
        '
        'minminus
        '
        Me.minminus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minminus.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.minminus.Location = New System.Drawing.Point(85, 178)
        Me.minminus.Name = "minminus"
        Me.minminus.Size = New System.Drawing.Size(30, 30)
        Me.minminus.TabIndex = 6
        Me.minminus.Text = "-"
        Me.minminus.UseSelectable = True
        '
        'sekminus
        '
        Me.sekminus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sekminus.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.sekminus.Location = New System.Drawing.Point(148, 178)
        Me.sekminus.Name = "sekminus"
        Me.sekminus.Size = New System.Drawing.Size(30, 30)
        Me.sekminus.TabIndex = 7
        Me.sekminus.Text = "-"
        Me.sekminus.UseSelectable = True
        '
        'btnleft
        '
        Me.btnleft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnleft.Location = New System.Drawing.Point(208, 103)
        Me.btnleft.Name = "btnleft"
        Me.btnleft.Size = New System.Drawing.Size(104, 23)
        Me.btnleft.TabIndex = 8
        Me.btnleft.Text = "Uruchom licznik"
        Me.btnleft.UseSelectable = True
        '
        'btnright
        '
        Me.btnright.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnright.Location = New System.Drawing.Point(318, 103)
        Me.btnright.Name = "btnright"
        Me.btnright.Size = New System.Drawing.Size(89, 23)
        Me.btnright.TabIndex = 9
        Me.btnright.Text = "Tryb edycji"
        Me.btnright.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(208, 150)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(127, 19)
        Me.MetroLabel2.TabIndex = 10
        Me.MetroLabel2.Text = "Typ powiadomienia:"
        '
        'radio1
        '
        Me.radio1.AutoSize = True
        Me.radio1.Checked = True
        Me.radio1.Location = New System.Drawing.Point(208, 172)
        Me.radio1.Name = "radio1"
        Me.radio1.Size = New System.Drawing.Size(143, 15)
        Me.radio1.TabIndex = 11
        Me.radio1.TabStop = True
        Me.radio1.Text = "Ważne powiadomienie"
        Me.radio1.UseSelectable = True
        '
        'radio2
        '
        Me.radio2.AutoSize = True
        Me.radio2.Location = New System.Drawing.Point(208, 193)
        Me.radio2.Name = "radio2"
        Me.radio2.Size = New System.Drawing.Size(145, 15)
        Me.radio2.TabIndex = 12
        Me.radio2.Text = "Zwykłe powiadomienie"
        Me.radio2.UseSelectable = True
        '
        'odl
        '
        Me.odl.Enabled = True
        Me.odl.Interval = 1
        '
        'APK03minutnik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 220)
        Me.Controls.Add(Me.radio2)
        Me.Controls.Add(Me.radio1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnright)
        Me.Controls.Add(Me.btnleft)
        Me.Controls.Add(Me.sekminus)
        Me.Controls.Add(Me.minminus)
        Me.Controls.Add(Me.godzminus)
        Me.Controls.Add(Me.sekplus)
        Me.Controls.Add(Me.minplus)
        Me.Controls.Add(Me.godzplus)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Name = "APK03minutnik"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Minutnik"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl As Label
    Friend WithEvents godzplus As MetroFramework.Controls.MetroLink
    Friend WithEvents minplus As MetroFramework.Controls.MetroLink
    Friend WithEvents sekplus As MetroFramework.Controls.MetroLink
    Friend WithEvents godzminus As MetroFramework.Controls.MetroLink
    Friend WithEvents minminus As MetroFramework.Controls.MetroLink
    Friend WithEvents sekminus As MetroFramework.Controls.MetroLink
    Friend WithEvents btnleft As MetroFramework.Controls.MetroLink
    Friend WithEvents btnright As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents radio1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents radio2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents odl As Timer
End Class
