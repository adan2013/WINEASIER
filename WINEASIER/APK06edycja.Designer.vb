<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK06edycja
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
        Me.lblheader = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnzapisz = New MetroFramework.Controls.MetroLink()
        Me.txtnazwa = New System.Windows.Forms.TextBox()
        Me.txttresc = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblheader
        '
        Me.lblheader.AutoSize = True
        Me.lblheader.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblheader.Location = New System.Drawing.Point(23, 30)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(76, 25)
        Me.lblheader.TabIndex = 0
        Me.lblheader.Text = "Notatnik"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 71)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Nazwa:"
        '
        'btnzapisz
        '
        Me.btnzapisz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzapisz.Enabled = False
        Me.btnzapisz.Location = New System.Drawing.Point(387, 68)
        Me.btnzapisz.Name = "btnzapisz"
        Me.btnzapisz.Size = New System.Drawing.Size(90, 23)
        Me.btnzapisz.TabIndex = 4
        Me.btnzapisz.Text = "Zapisz zmiany"
        Me.btnzapisz.UseSelectable = True
        '
        'txtnazwa
        '
        Me.txtnazwa.Location = New System.Drawing.Point(80, 71)
        Me.txtnazwa.MaxLength = 100
        Me.txtnazwa.Name = "txtnazwa"
        Me.txtnazwa.Size = New System.Drawing.Size(301, 20)
        Me.txtnazwa.TabIndex = 1
        '
        'txttresc
        '
        Me.txttresc.Location = New System.Drawing.Point(23, 97)
        Me.txttresc.MaxLength = 1500
        Me.txttresc.Multiline = True
        Me.txttresc.Name = "txttresc"
        Me.txttresc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txttresc.Size = New System.Drawing.Size(454, 180)
        Me.txttresc.TabIndex = 0
        '
        'APK06edycja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.Controls.Add(Me.txttresc)
        Me.Controls.Add(Me.txtnazwa)
        Me.Controls.Add(Me.btnzapisz)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.lblheader)
        Me.DisplayHeader = False
        Me.MinimumSize = New System.Drawing.Size(500, 300)
        Me.Name = "APK06edycja"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Nowy wpis - Notatnik"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblheader As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnzapisz As MetroFramework.Controls.MetroLink
    Friend WithEvents txtnazwa As TextBox
    Friend WithEvents txttresc As TextBox
End Class
