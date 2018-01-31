<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wywolywaczform
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
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.pnlimg = New System.Windows.Forms.Panel()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlimg.SuspendLayout()
        Me.SuspendLayout()
        '
        'logo
        '
        Me.logo.Image = Global.WINEASIER.My.Resources.Resources.logozwyk
        Me.logo.Location = New System.Drawing.Point(9, 9)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(32, 32)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'pnlimg
        '
        Me.pnlimg.BackColor = System.Drawing.Color.White
        Me.pnlimg.Controls.Add(Me.logo)
        Me.pnlimg.Location = New System.Drawing.Point(0, 0)
        Me.pnlimg.Name = "pnlimg"
        Me.pnlimg.Size = New System.Drawing.Size(50, 50)
        Me.pnlimg.TabIndex = 1
        '
        'wywolywaczform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(180, 50)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlimg)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "wywolywaczform"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.Text = "wywolywaczform"
        Me.TopMost = True
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlimg.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents logo As PictureBox
    Friend WithEvents pnlimg As Panel
End Class
