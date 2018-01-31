<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK15zarzadzaj
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
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.lbl1 = New MetroFramework.Controls.MetroLabel()
        Me.lbl2 = New MetroFramework.Controls.MetroLabel()
        Me.btnusunstare = New MetroFramework.Controls.MetroLink()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(104, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Zarządzanie"
        '
        'MetroLink1
        '
        Me.MetroLink1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink1.Location = New System.Drawing.Point(217, 134)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(60, 23)
        Me.MetroLink1.TabIndex = 1
        Me.MetroLink1.Text = "Zamknij"
        Me.MetroLink1.UseSelectable = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(23, 65)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(134, 19)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "Wszystkich zdarzeń: 0"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(23, 84)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(155, 19)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "Przestarzałych zdarzeń: 0"
        '
        'btnusunstare
        '
        Me.btnusunstare.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnusunstare.Location = New System.Drawing.Point(81, 134)
        Me.btnusunstare.Name = "btnusunstare"
        Me.btnusunstare.Size = New System.Drawing.Size(130, 23)
        Me.btnusunstare.TabIndex = 4
        Me.btnusunstare.Text = "Usuń stare zdarzenia"
        Me.btnusunstare.UseSelectable = True
        '
        'APK15zarzadzaj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 180)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnusunstare)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.MetroLink1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "APK15zarzadzaj"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowIcon = False
        Me.Text = "Zarządzanie - Kalendarz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents lbl1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnusunstare As MetroFramework.Controls.MetroLink
End Class
