<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class errinfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(errinfo))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnend = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.kombledu = New System.Windows.Forms.TextBox()
        Me.btnskopiuj = New MetroFramework.Controls.MetroLink()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(378, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Program WINEASIER uległ nieoczekiwanej awarii"
        '
        'btnend
        '
        Me.btnend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnend.Location = New System.Drawing.Point(327, 254)
        Me.btnend.Name = "btnend"
        Me.btnend.Size = New System.Drawing.Size(110, 23)
        Me.btnend.TabIndex = 1
        Me.btnend.Text = "Zamknij program"
        Me.btnend.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(32, 73)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(395, 76)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = resources.GetString("MetroLabel2.Text")
        '
        'kombledu
        '
        Me.kombledu.Location = New System.Drawing.Point(23, 166)
        Me.kombledu.Multiline = True
        Me.kombledu.Name = "kombledu"
        Me.kombledu.ReadOnly = True
        Me.kombledu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.kombledu.Size = New System.Drawing.Size(414, 70)
        Me.kombledu.TabIndex = 3
        '
        'btnskopiuj
        '
        Me.btnskopiuj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnskopiuj.Location = New System.Drawing.Point(201, 254)
        Me.btnskopiuj.Name = "btnskopiuj"
        Me.btnskopiuj.Size = New System.Drawing.Size(120, 23)
        Me.btnskopiuj.TabIndex = 4
        Me.btnskopiuj.Text = "Skopiuj do schowka"
        Me.btnskopiuj.UseSelectable = True
        '
        'errinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnskopiuj)
        Me.Controls.Add(Me.kombledu)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnend)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "errinfo"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Błąd - WINEASIER"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnend As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents kombledu As TextBox
    Friend WithEvents btnskopiuj As MetroFramework.Controls.MetroLink
End Class
