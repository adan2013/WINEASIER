<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK02stoper
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
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.btnleft = New MetroFramework.Controls.MetroLink()
        Me.btnright = New MetroFramework.Controls.MetroLink()
        Me.odl = New System.Windows.Forms.Timer(Me.components)
        Me.lista = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(61, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Stoper"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl1.Location = New System.Drawing.Point(23, 75)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl1.Size = New System.Drawing.Size(130, 39)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "0:00:00"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbl2.Location = New System.Drawing.Point(142, 85)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(58, 29)
        Me.lbl2.TabIndex = 2
        Me.lbl2.Text = ":000"
        '
        'btnleft
        '
        Me.btnleft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnleft.Location = New System.Drawing.Point(23, 135)
        Me.btnleft.Name = "btnleft"
        Me.btnleft.Size = New System.Drawing.Size(70, 23)
        Me.btnleft.TabIndex = 3
        Me.btnleft.Text = "Start"
        Me.btnleft.UseSelectable = True
        '
        'btnright
        '
        Me.btnright.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnright.Location = New System.Drawing.Point(127, 135)
        Me.btnright.Name = "btnright"
        Me.btnright.Size = New System.Drawing.Size(70, 23)
        Me.btnright.TabIndex = 4
        Me.btnright.Text = "Wyzeruj"
        Me.btnright.UseSelectable = True
        '
        'odl
        '
        Me.odl.Enabled = True
        Me.odl.Interval = 1
        '
        'lista
        '
        Me.lista.FormattingEnabled = True
        Me.lista.Location = New System.Drawing.Point(23, 179)
        Me.lista.Name = "lista"
        Me.lista.ScrollAlwaysVisible = True
        Me.lista.Size = New System.Drawing.Size(174, 108)
        Me.lista.TabIndex = 5
        '
        'APK02stoper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 300)
        Me.Controls.Add(Me.lista)
        Me.Controls.Add(Me.btnright)
        Me.Controls.Add(Me.btnleft)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Name = "APK02stoper"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Stoper"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents btnleft As MetroFramework.Controls.MetroLink
    Friend WithEvents btnright As MetroFramework.Controls.MetroLink
    Friend WithEvents odl As Timer
    Friend WithEvents lista As ListBox
End Class
