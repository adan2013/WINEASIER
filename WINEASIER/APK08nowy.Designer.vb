<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK08nowy
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
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.btndodaj = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.btnodkryj = New MetroFramework.Controls.MetroLink()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(93, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Nowy wpis"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(33, 97)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Nazwa pozycji:"
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt1.Location = New System.Drawing.Point(134, 97)
        Me.txt1.MaxLength = 40
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(463, 21)
        Me.txt1.TabIndex = 2
        '
        'txt2
        '
        Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt2.Location = New System.Drawing.Point(134, 124)
        Me.txt2.MaxLength = 150
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(463, 21)
        Me.txt2.TabIndex = 4
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(43, 124)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Adres strony:"
        '
        'txt3
        '
        Me.txt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt3.Location = New System.Drawing.Point(134, 151)
        Me.txt3.MaxLength = 50
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(463, 21)
        Me.txt3.TabIndex = 6
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(33, 151)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "Login / E-mail:"
        '
        'txt4
        '
        Me.txt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt4.Location = New System.Drawing.Point(134, 178)
        Me.txt4.MaxLength = 100
        Me.txt4.Name = "txt4"
        Me.txt4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt4.Size = New System.Drawing.Size(377, 21)
        Me.txt4.TabIndex = 8
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(84, 178)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(44, 19)
        Me.MetroLabel5.TabIndex = 7
        Me.MetroLabel5.Text = "Hasło:"
        '
        'txt5
        '
        Me.txt5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt5.Location = New System.Drawing.Point(134, 205)
        Me.txt5.MaxLength = 200
        Me.txt5.Multiline = True
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(463, 65)
        Me.txt5.TabIndex = 10
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(80, 205)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel6.TabIndex = 9
        Me.MetroLabel6.Text = "Uwagi:"
        '
        'btndodaj
        '
        Me.btndodaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndodaj.Location = New System.Drawing.Point(522, 277)
        Me.btndodaj.Name = "btndodaj"
        Me.btndodaj.Size = New System.Drawing.Size(75, 23)
        Me.btndodaj.TabIndex = 11
        Me.btndodaj.Text = "Dodaj wpis"
        Me.btndodaj.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel7.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.MetroLabel7.Location = New System.Drawing.Point(43, 285)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(313, 15)
        Me.MetroLabel7.TabIndex = 12
        Me.MetroLabel7.Text = "Adres strony i uwagi są opcjonalne i nie muszą być podawane"
        Me.MetroLabel7.UseCustomForeColor = True
        '
        'btnodkryj
        '
        Me.btnodkryj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnodkryj.Location = New System.Drawing.Point(517, 176)
        Me.btnodkryj.Name = "btnodkryj"
        Me.btnodkryj.Size = New System.Drawing.Size(80, 23)
        Me.btnodkryj.TabIndex = 25
        Me.btnodkryj.Text = "Odkryj hasło"
        Me.btnodkryj.UseSelectable = True
        '
        'APK08nowy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 320)
        Me.Controls.Add(Me.btnodkryj)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.btndodaj)
        Me.Controls.Add(Me.txt5)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "APK08nowy"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Nowy - Sejf haseł"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt3 As TextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt4 As TextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt5 As TextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btndodaj As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnodkryj As MetroFramework.Controls.MetroLink
End Class
