<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK08zmiana
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txt1 = New MetroFramework.Controls.MetroTextBox()
        Me.txt2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblsila = New MetroFramework.Controls.MetroLabel()
        Me.btnzmien = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(113, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Zmiana hasła"
        '
        'txt1
        '
        Me.txt1.Lines = New String(-1) {}
        Me.txt1.Location = New System.Drawing.Point(23, 72)
        Me.txt1.MaxLength = 30
        Me.txt1.Name = "txt1"
        Me.txt1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt1.PromptText = "Nowe hasło"
        Me.txt1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt1.SelectedText = ""
        Me.txt1.Size = New System.Drawing.Size(284, 23)
        Me.txt1.TabIndex = 1
        Me.txt1.UseSelectable = True
        '
        'txt2
        '
        Me.txt2.Lines = New String(-1) {}
        Me.txt2.Location = New System.Drawing.Point(23, 101)
        Me.txt2.MaxLength = 30
        Me.txt2.Name = "txt2"
        Me.txt2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt2.PromptText = "Powtórz nowe hasło"
        Me.txt2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt2.SelectedText = ""
        Me.txt2.Size = New System.Drawing.Size(284, 23)
        Me.txt2.TabIndex = 2
        Me.txt2.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 136)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Siła hasła:"
        '
        'lblsila
        '
        Me.lblsila.AutoSize = True
        Me.lblsila.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblsila.Location = New System.Drawing.Point(94, 136)
        Me.lblsila.Name = "lblsila"
        Me.lblsila.Size = New System.Drawing.Size(40, 19)
        Me.lblsila.TabIndex = 4
        Me.lblsila.Text = "Brak"
        Me.lblsila.UseCustomForeColor = True
        '
        'btnzmien
        '
        Me.btnzmien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzmien.Location = New System.Drawing.Point(232, 284)
        Me.btnzmien.Name = "btnzmien"
        Me.btnzmien.Size = New System.Drawing.Size(75, 23)
        Me.btnzmien.TabIndex = 5
        Me.btnzmien.Text = "Zmień hasło"
        Me.btnzmien.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(52, 167)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(220, 95)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Silne hasło powinno zawierać:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1.Duże i małe znaki" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2.Litery oraz cyfry" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3.Znaki " &
    "specialne typu $, @, %" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Długość hasła: od 5 do 30 znaków"
        '
        'APK08zmiana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 330)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.btnzmien)
        Me.Controls.Add(Me.lblsila)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "APK08zmiana"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Sejf haseł"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblsila As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnzmien As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
End Class
