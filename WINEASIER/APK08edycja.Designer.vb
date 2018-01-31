<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK08edycja
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnodkryj = New MetroFramework.Controls.MetroLink()
        Me.lista = New System.Windows.Forms.ListBox()
        Me.btnporzuc = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(120, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Edycja wpisów"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnodkryj)
        Me.Panel1.Controls.Add(Me.lista)
        Me.Panel1.Controls.Add(Me.btnporzuc)
        Me.Panel1.Controls.Add(Me.MetroLabel7)
        Me.Panel1.Controls.Add(Me.txt5)
        Me.Panel1.Controls.Add(Me.MetroLabel6)
        Me.Panel1.Controls.Add(Me.txt4)
        Me.Panel1.Controls.Add(Me.MetroLabel5)
        Me.Panel1.Controls.Add(Me.txt3)
        Me.Panel1.Controls.Add(Me.MetroLabel4)
        Me.Panel1.Controls.Add(Me.txt2)
        Me.Panel1.Controls.Add(Me.MetroLabel3)
        Me.Panel1.Controls.Add(Me.txt1)
        Me.Panel1.Controls.Add(Me.MetroLabel2)
        Me.Panel1.Location = New System.Drawing.Point(23, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(854, 250)
        Me.Panel1.TabIndex = 1
        '
        'btnodkryj
        '
        Me.btnodkryj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnodkryj.Location = New System.Drawing.Point(771, 82)
        Me.btnodkryj.Name = "btnodkryj"
        Me.btnodkryj.Size = New System.Drawing.Size(80, 23)
        Me.btnodkryj.TabIndex = 24
        Me.btnodkryj.Text = "Odkryj hasło"
        Me.btnodkryj.UseSelectable = True
        '
        'lista
        '
        Me.lista.FormattingEnabled = True
        Me.lista.Location = New System.Drawing.Point(16, 12)
        Me.lista.Name = "lista"
        Me.lista.ScrollAlwaysVisible = True
        Me.lista.Size = New System.Drawing.Size(250, 212)
        Me.lista.TabIndex = 2
        '
        'btnporzuc
        '
        Me.btnporzuc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnporzuc.Enabled = False
        Me.btnporzuc.Location = New System.Drawing.Point(665, 223)
        Me.btnporzuc.Name = "btnporzuc"
        Me.btnporzuc.Size = New System.Drawing.Size(175, 23)
        Me.btnporzuc.TabIndex = 2
        Me.btnporzuc.Text = "Porzuć zmiany w tym wpisie"
        Me.btnporzuc.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.MetroLabel7.Location = New System.Drawing.Point(398, 179)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(429, 30)
        Me.MetroLabel7.TabIndex = 23
        Me.MetroLabel7.Text = "Adres strony i uwagi są opcjonalne i nie muszą być podawane. Zmiany są zapisywane" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "automatycznie po zmianie edytowanej pozycji lub zamknięciu tego okna."
        Me.MetroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel7.UseCustomForeColor = True
        '
        'txt5
        '
        Me.txt5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt5.Location = New System.Drawing.Point(388, 111)
        Me.txt5.MaxLength = 200
        Me.txt5.Multiline = True
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(463, 65)
        Me.txt5.TabIndex = 22
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(334, 111)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel6.TabIndex = 21
        Me.MetroLabel6.Text = "Uwagi:"
        '
        'txt4
        '
        Me.txt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt4.Location = New System.Drawing.Point(388, 84)
        Me.txt4.MaxLength = 100
        Me.txt4.Name = "txt4"
        Me.txt4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt4.Size = New System.Drawing.Size(377, 21)
        Me.txt4.TabIndex = 20
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(338, 84)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(44, 19)
        Me.MetroLabel5.TabIndex = 19
        Me.MetroLabel5.Text = "Hasło:"
        '
        'txt3
        '
        Me.txt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt3.Location = New System.Drawing.Point(388, 57)
        Me.txt3.MaxLength = 50
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(463, 21)
        Me.txt3.TabIndex = 18
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(287, 57)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel4.TabIndex = 17
        Me.MetroLabel4.Text = "Login / E-mail:"
        '
        'txt2
        '
        Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt2.Location = New System.Drawing.Point(388, 30)
        Me.txt2.MaxLength = 150
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(463, 21)
        Me.txt2.TabIndex = 16
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(297, 30)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel3.TabIndex = 15
        Me.MetroLabel3.Text = "Adres strony:"
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt1.Location = New System.Drawing.Point(388, 3)
        Me.txt1.MaxLength = 40
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(463, 21)
        Me.txt1.TabIndex = 14
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(287, 3)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel2.TabIndex = 13
        Me.MetroLabel2.Text = "Nazwa pozycji:"
        '
        'APK08edycja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 350)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "APK08edycja"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Edycja - Sejf haseł"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnporzuc As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt5 As TextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt4 As TextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt3 As TextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt2 As TextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt1 As TextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lista As ListBox
    Friend WithEvents btnodkryj As MetroFramework.Controls.MetroLink
End Class
