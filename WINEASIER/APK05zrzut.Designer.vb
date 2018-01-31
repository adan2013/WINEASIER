<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class APK05zrzut
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
        Me.ekran = New System.Windows.Forms.PictureBox()
        Me.przybornik = New System.Windows.Forms.Panel()
        Me.ruch = New System.Windows.Forms.Timer(Me.components)
        Me.oknozapisu = New System.Windows.Forms.SaveFileDialog()
        Me.zamykanie = New System.Windows.Forms.Timer(Me.components)
        Me.odswiezanie = New System.Windows.Forms.Timer(Me.components)
        CType(Me.ekran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ekran
        '
        Me.ekran.BackColor = System.Drawing.SystemColors.Control
        Me.ekran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ekran.Location = New System.Drawing.Point(0, 0)
        Me.ekran.Name = "ekran"
        Me.ekran.Size = New System.Drawing.Size(700, 400)
        Me.ekran.TabIndex = 0
        Me.ekran.TabStop = False
        '
        'przybornik
        '
        Me.przybornik.BackColor = System.Drawing.Color.White
        Me.przybornik.Location = New System.Drawing.Point(0, 0)
        Me.przybornik.Name = "przybornik"
        Me.przybornik.Size = New System.Drawing.Size(585, 65)
        Me.przybornik.TabIndex = 1
        '
        'ruch
        '
        Me.ruch.Interval = 10
        '
        'oknozapisu
        '
        Me.oknozapisu.InitialDirectory = "C:\"
        '
        'zamykanie
        '
        Me.zamykanie.Interval = 10
        '
        'odswiezanie
        '
        Me.odswiezanie.Interval = 16
        '
        'APK05zrzut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.przybornik)
        Me.Controls.Add(Me.ekran)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "APK05zrzut"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.Text = "ScreenShot"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ekran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ekran As PictureBox
    Friend WithEvents przybornik As Panel
    Friend WithEvents ruch As Timer
    Friend WithEvents oknozapisu As SaveFileDialog
    Friend WithEvents zamykanie As Timer
    Friend WithEvents odswiezanie As Timer
End Class
