<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listapowiadomien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listapowiadomien))
        Me.pnl = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Location = New System.Drawing.Point(0, 63)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(700, 375)
        Me.pnl.TabIndex = 0
        '
        'listapowiadomien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 440)
        Me.Controls.Add(Me.pnl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "listapowiadomien"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Powiadomienia"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl As Panel
End Class
