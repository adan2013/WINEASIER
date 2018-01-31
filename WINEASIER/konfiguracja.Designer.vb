<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class konfiguracja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(konfiguracja))
        Me.btndalej = New MetroFramework.Controls.MetroLink()
        Me.btnwstecz = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txt = New MetroFramework.Controls.MetroLabel()
        Me.img = New System.Windows.Forms.PictureBox()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btndalej
        '
        Me.btndalej.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndalej.Location = New System.Drawing.Point(557, 314)
        Me.btndalej.Name = "btndalej"
        Me.btndalej.Size = New System.Drawing.Size(60, 23)
        Me.btndalej.TabIndex = 0
        Me.btndalej.Text = "Dalej"
        Me.btndalej.UseSelectable = True
        '
        'btnwstecz
        '
        Me.btnwstecz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnwstecz.Location = New System.Drawing.Point(491, 314)
        Me.btnwstecz.Name = "btnwstecz"
        Me.btnwstecz.Size = New System.Drawing.Size(60, 23)
        Me.btnwstecz.TabIndex = 1
        Me.btnwstecz.Text = "Wstecz"
        Me.btnwstecz.UseSelectable = True
        Me.btnwstecz.Visible = False
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(314, 25)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Konfiguracja programu WINEASIER"
        '
        'txt
        '
        Me.txt.AutoSize = True
        Me.txt.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.txt.Location = New System.Drawing.Point(32, 118)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(50, 25)
        Me.txt.TabIndex = 3
        Me.txt.Text = "Tekst"
        '
        'img
        '
        Me.img.Location = New System.Drawing.Point(353, 87)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(250, 200)
        Me.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img.TabIndex = 4
        Me.img.TabStop = False
        '
        'konfiguracja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 360)
        Me.Controls.Add(Me.img)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnwstecz)
        Me.Controls.Add(Me.btndalej)
        Me.DisplayHeader = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Movable = False
        Me.Name = "konfiguracja"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Konfiguracja programu WINEASIER"
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btndalej As MetroFramework.Controls.MetroLink
    Friend WithEvents btnwstecz As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt As MetroFramework.Controls.MetroLabel
    Friend WithEvents img As PictureBox
End Class
