<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class START
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(START))
        Me.tmrukryj = New System.Windows.Forms.Timer(Me.components)
        Me.NOTIFY = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.mrugikona = New System.Windows.Forms.Timer(Me.components)
        Me.diskejecttimer = New System.Windows.Forms.Timer(Me.components)
        Me.zdarzenia = New System.Windows.Forms.Timer(Me.components)
        Me.backuptimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblwersja = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.bgwbackup = New System.ComponentModel.BackgroundWorker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrukryj
        '
        Me.tmrukryj.Enabled = True
        Me.tmrukryj.Interval = 2000
        '
        'NOTIFY
        '
        Me.NOTIFY.Icon = CType(resources.GetObject("NOTIFY.Icon"), System.Drawing.Icon)
        Me.NOTIFY.Text = "WINEASIER"
        Me.NOTIFY.Visible = True
        '
        'tmr
        '
        '
        'mrugikona
        '
        Me.mrugikona.Enabled = True
        Me.mrugikona.Interval = 800
        '
        'diskejecttimer
        '
        Me.diskejecttimer.Interval = 5000
        '
        'zdarzenia
        '
        Me.zdarzenia.Enabled = True
        Me.zdarzenia.Interval = 1000
        '
        'backuptimer
        '
        Me.backuptimer.Enabled = True
        Me.backuptimer.Interval = 5000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WINEASIER.My.Resources.Resources.logonapis
        Me.PictureBox1.Location = New System.Drawing.Point(22, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 280)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblwersja
        '
        Me.lblwersja.AutoSize = True
        Me.lblwersja.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblwersja.Location = New System.Drawing.Point(23, 326)
        Me.lblwersja.Name = "lblwersja"
        Me.lblwersja.Size = New System.Drawing.Size(35, 19)
        Me.lblwersja.TabIndex = 1
        Me.lblwersja.Text = "v1.0"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(212, 326)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "adan2013"
        '
        'bgwbackup
        '
        '
        'START
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 365)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.lblwersja)
        Me.Controls.Add(Me.PictureBox1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "START"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.Text = "START"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrukryj As Timer
    Friend WithEvents NOTIFY As NotifyIcon
    Friend WithEvents tmr As Timer
    Friend WithEvents mrugikona As Timer
    Friend WithEvents diskejecttimer As Timer
    Friend WithEvents zdarzenia As Timer
    Friend WithEvents backuptimer As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblwersja As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents bgwbackup As System.ComponentModel.BackgroundWorker
End Class
