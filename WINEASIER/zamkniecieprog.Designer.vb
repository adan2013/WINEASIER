<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zamkniecieprog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(zamkniecieprog))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnnie = New MetroFramework.Controls.MetroLink()
        Me.btntak = New MetroFramework.Controls.MetroLink()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(256, 50)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Czy na pewno chcesz zakończyć" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "działanie programu?"
        '
        'btnnie
        '
        Me.btnnie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnie.Location = New System.Drawing.Point(297, 106)
        Me.btnnie.Name = "btnnie"
        Me.btnnie.Size = New System.Drawing.Size(50, 23)
        Me.btnnie.TabIndex = 1
        Me.btnnie.Text = "Nie"
        Me.btnnie.UseSelectable = True
        '
        'btntak
        '
        Me.btntak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntak.Location = New System.Drawing.Point(241, 106)
        Me.btntak.Name = "btntak"
        Me.btntak.Size = New System.Drawing.Size(50, 23)
        Me.btntak.TabIndex = 2
        Me.btntak.Text = "Tak"
        Me.btntak.UseSelectable = True
        '
        'zamkniecieprog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 140)
        Me.ControlBox = False
        Me.Controls.Add(Me.btntak)
        Me.Controls.Add(Me.btnnie)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Movable = False
        Me.Name = "zamkniecieprog"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Text = "Zamknięcie programu WINEASIER"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnnie As MetroFramework.Controls.MetroLink
    Friend WithEvents btntak As MetroFramework.Controls.MetroLink
End Class
