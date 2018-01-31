<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class APK18colorpicker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.ekran = New System.Windows.Forms.PictureBox()
        Me.odswiezanie = New System.Windows.Forms.Timer(Me.components)
        Me.podglad = New System.Windows.Forms.Panel()
        Me.lblinfo = New System.Windows.Forms.Label()
        CType(Me.ekran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmr
        '
        '
        'ekran
        '
        Me.ekran.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ekran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ekran.Location = New System.Drawing.Point(0, 0)
        Me.ekran.Name = "ekran"
        Me.ekran.Size = New System.Drawing.Size(550, 550)
        Me.ekran.TabIndex = 0
        Me.ekran.TabStop = False
        '
        'odswiezanie
        '
        Me.odswiezanie.Interval = 1
        '
        'podglad
        '
        Me.podglad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.podglad.Location = New System.Drawing.Point(12, 12)
        Me.podglad.Name = "podglad"
        Me.podglad.Size = New System.Drawing.Size(50, 50)
        Me.podglad.TabIndex = 1
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblinfo.Location = New System.Drawing.Point(12, 384)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(770, 29)
        Me.lblinfo.TabIndex = 2
        Me.lblinfo.Text = "Wybierz kolor do pobrania lub naciśnij klawisz Esc aby wyjść z aplikacji"
        '
        'APK18colorpicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 550)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.podglad)
        Me.Controls.Add(Me.ekran)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "APK18colorpicker"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.Text = "Color Picker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ekran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmr As Timer
    Friend WithEvents ekran As PictureBox
    Friend WithEvents odswiezanie As Timer
    Friend WithEvents podglad As Panel
    Friend WithEvents lblinfo As Label
End Class
