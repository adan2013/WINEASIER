<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK13rozmiar
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
        Me.btnzamknij = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblakt = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txt1 = New System.Windows.Forms.NumericUpDown()
        Me.txt2 = New System.Windows.Forms.NumericUpDown()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        CType(Me.txt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(191, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Zarządzanie rozmiarem"
        '
        'btnzamknij
        '
        Me.btnzamknij.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzamknij.Location = New System.Drawing.Point(417, 254)
        Me.btnzamknij.Name = "btnzamknij"
        Me.btnzamknij.Size = New System.Drawing.Size(60, 23)
        Me.btnzamknij.TabIndex = 1
        Me.btnzamknij.Text = "Zamknij"
        Me.btnzamknij.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 73)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(217, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Aktualny rozmiar magazynu danych"
        '
        'lblakt
        '
        Me.lblakt.AutoSize = True
        Me.lblakt.Location = New System.Drawing.Point(35, 92)
        Me.lblakt.Name = "lblakt"
        Me.lblakt.Size = New System.Drawing.Size(40, 19)
        Me.lblakt.TabIndex = 3
        Me.lblakt.Text = "0 MB"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.Location = New System.Drawing.Point(174, 92)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(247, 15)
        Me.MetroLabel4.TabIndex = 4
        Me.MetroLabel4.Text = "Rozmiar aktualnie wybranego magazynu danych"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.Location = New System.Drawing.Point(174, 133)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(292, 30)
        Me.MetroLabel5.TabIndex = 7
        Me.MetroLabel5.Text = "Po przekroczeniu określonego progu wyświetlany" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "jest monit ostrzegający o rosnący" &
    "m rozmiarze magazynu"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(116, 137)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(29, 19)
        Me.MetroLabel6.TabIndex = 6
        Me.MetroLabel6.Text = "MB"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(23, 111)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(255, 19)
        Me.MetroLabel7.TabIndex = 5
        Me.MetroLabel7.Text = "Próg wyświetlania monitu ostrzegawczego"
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt1.Location = New System.Drawing.Point(35, 133)
        Me.txt1.Maximum = New Decimal(New Integer() {4096, 0, 0, 0})
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(75, 23)
        Me.txt1.TabIndex = 8
        '
        'txt2
        '
        Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt2.Location = New System.Drawing.Point(35, 200)
        Me.txt2.Maximum = New Decimal(New Integer() {4096, 0, 0, 0})
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(75, 23)
        Me.txt2.TabIndex = 12
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel8.Location = New System.Drawing.Point(174, 200)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(297, 45)
        Me.MetroLabel8.TabIndex = 11
        Me.MetroLabel8.Text = "Maksymalny rozmiar magazynu danych która" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nie może zostać przekroczony. Jeżeli ko" &
    "pia nie" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zmieści się w wyznaczonym limicie, nie zostanie utworzona"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(116, 204)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(29, 19)
        Me.MetroLabel9.TabIndex = 10
        Me.MetroLabel9.Text = "MB"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(23, 178)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(239, 19)
        Me.MetroLabel10.TabIndex = 9
        Me.MetroLabel10.Text = "Maksymalny rozmiar magazynu danych"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.BackColor = System.Drawing.Color.White
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel11.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.MetroLabel11.Location = New System.Drawing.Point(23, 254)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(228, 15)
        Me.MetroLabel11.TabIndex = 13
        Me.MetroLabel11.Text = "Wpisana wartość 0 oznacza wyłączenie opcji"
        Me.MetroLabel11.UseCustomForeColor = True
        '
        'APK13rozmiar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.lblakt)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnzamknij)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "APK13rozmiar"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Text = "Backup File Creator"
        CType(Me.txt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnzamknij As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblakt As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt1 As NumericUpDown
    Friend WithEvents txt2 As NumericUpDown
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
End Class
