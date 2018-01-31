<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK11progress
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
        Me.btnzatrzymaj = New MetroFramework.Controls.MetroLink()
        Me.lbl1 = New MetroFramework.Controls.MetroLabel()
        Me.lbl2 = New MetroFramework.Controls.MetroLabel()
        Me.progbar = New MetroFramework.Controls.MetroProgressBar()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txthis = New System.Windows.Forms.TextBox()
        Me.lbltytul = New MetroFramework.Controls.MetroLabel()
        Me.akt = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnzatrzymaj
        '
        Me.btnzatrzymaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzatrzymaj.Location = New System.Drawing.Point(434, 234)
        Me.btnzatrzymaj.Name = "btnzatrzymaj"
        Me.btnzatrzymaj.Size = New System.Drawing.Size(123, 23)
        Me.btnzatrzymaj.TabIndex = 13
        Me.btnzatrzymaj.Text = "Zatrzymaj konwersje"
        Me.btnzatrzymaj.UseSelectable = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(23, 74)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(76, 19)
        Me.lbl1.TabIndex = 12
        Me.lbl1.Text = "nazwa pliku"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(495, 74)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(36, 19)
        Me.lbl2.TabIndex = 11
        Me.lbl2.Text = "0 / 0"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'progbar
        '
        Me.progbar.Location = New System.Drawing.Point(23, 96)
        Me.progbar.Name = "progbar"
        Me.progbar.Size = New System.Drawing.Size(534, 15)
        Me.progbar.TabIndex = 10
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 124)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(92, 15)
        Me.MetroLabel2.TabIndex = 9
        Me.MetroLabel2.Text = "Proces konwersji:"
        '
        'txthis
        '
        Me.txthis.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txthis.Location = New System.Drawing.Point(23, 142)
        Me.txthis.Multiline = True
        Me.txthis.Name = "txthis"
        Me.txthis.ReadOnly = True
        Me.txthis.Size = New System.Drawing.Size(534, 86)
        Me.txthis.TabIndex = 8
        '
        'lbltytul
        '
        Me.lbltytul.AutoSize = True
        Me.lbltytul.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbltytul.Location = New System.Drawing.Point(23, 30)
        Me.lbltytul.Name = "lbltytul"
        Me.lbltytul.Size = New System.Drawing.Size(205, 25)
        Me.lbltytul.TabIndex = 7
        Me.lbltytul.Text = "Konwersja wideo w toku..."
        '
        'akt
        '
        Me.akt.Enabled = True
        Me.akt.Interval = 10
        '
        'APK11progress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 280)
        Me.Controls.Add(Me.btnzatrzymaj)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.progbar)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txthis)
        Me.Controls.Add(Me.lbltytul)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "APK11progress"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Text = "Konwerter wideo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnzatrzymaj As MetroFramework.Controls.MetroLink
    Friend WithEvents lbl1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents progbar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txthis As TextBox
    Friend WithEvents lbltytul As MetroFramework.Controls.MetroLabel
    Friend WithEvents akt As Timer
End Class
