<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK08odblokuj
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txt = New MetroFramework.Controls.MetroTextBox()
        Me.btn = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblinfo = New MetroFramework.Controls.MetroLabel()
        Me.ukr = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(102, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Wpisz hasło"
        '
        'txt
        '
        Me.txt.Lines = New String(-1) {}
        Me.txt.Location = New System.Drawing.Point(43, 73)
        Me.txt.MaxLength = 30
        Me.txt.Name = "txt"
        Me.txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt.PromptText = "Hasło"
        Me.txt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt.SelectedText = ""
        Me.txt.Size = New System.Drawing.Size(240, 23)
        Me.txt.TabIndex = 1
        Me.txt.UseSelectable = True
        '
        'btn
        '
        Me.btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn.Location = New System.Drawing.Point(289, 73)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(75, 23)
        Me.btn.TabIndex = 2
        Me.btn.Text = "Odblokuj"
        Me.btn.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.MetroLabel2.Location = New System.Drawing.Point(43, 109)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(122, 15)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Domyślne hasło: 12345"
        Me.MetroLabel2.UseCustomForeColor = True
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblinfo.ForeColor = System.Drawing.Color.Red
        Me.lblinfo.Location = New System.Drawing.Point(254, 121)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(110, 19)
        Me.lblinfo.TabIndex = 4
        Me.lblinfo.Text = "BŁĘDNE HASŁO!"
        Me.lblinfo.UseCustomForeColor = True
        Me.lblinfo.Visible = False
        '
        'ukr
        '
        Me.ukr.Interval = 1200
        '
        'APK08odblokuj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 160)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "APK08odblokuj"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Sejf haseł"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblinfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents ukr As Timer
End Class
