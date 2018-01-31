<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK12waluty
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
        Me.listawaluta1 = New MetroFramework.Controls.MetroComboBox()
        Me.listawaluta2 = New MetroFramework.Controls.MetroComboBox()
        Me.waluta1 = New System.Windows.Forms.TextBox()
        Me.waluta2 = New System.Windows.Forms.Label()
        Me.btnzamien = New MetroFramework.Controls.MetroLink()
        Me.btnzaktualizuj = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblkurs = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.waluta3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(136, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Przelicznik walut"
        '
        'listawaluta1
        '
        Me.listawaluta1.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.listawaluta1.FormattingEnabled = True
        Me.listawaluta1.ItemHeight = 19
        Me.listawaluta1.Location = New System.Drawing.Point(23, 74)
        Me.listawaluta1.Name = "listawaluta1"
        Me.listawaluta1.Size = New System.Drawing.Size(250, 25)
        Me.listawaluta1.Sorted = True
        Me.listawaluta1.TabIndex = 3
        Me.listawaluta1.UseSelectable = True
        '
        'listawaluta2
        '
        Me.listawaluta2.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.listawaluta2.FormattingEnabled = True
        Me.listawaluta2.ItemHeight = 19
        Me.listawaluta2.Location = New System.Drawing.Point(307, 74)
        Me.listawaluta2.Name = "listawaluta2"
        Me.listawaluta2.Size = New System.Drawing.Size(250, 25)
        Me.listawaluta2.Sorted = True
        Me.listawaluta2.TabIndex = 2
        Me.listawaluta2.UseSelectable = True
        '
        'waluta1
        '
        Me.waluta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.waluta1.Location = New System.Drawing.Point(43, 134)
        Me.waluta1.MaxLength = 6
        Me.waluta1.Name = "waluta1"
        Me.waluta1.Size = New System.Drawing.Size(210, 53)
        Me.waluta1.TabIndex = 0
        '
        'waluta2
        '
        Me.waluta2.AutoSize = True
        Me.waluta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.waluta2.Location = New System.Drawing.Point(328, 140)
        Me.waluta2.Name = "waluta2"
        Me.waluta2.Size = New System.Drawing.Size(36, 39)
        Me.waluta2.TabIndex = 4
        Me.waluta2.Text = "0"
        '
        'btnzamien
        '
        Me.btnzamien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzamien.Location = New System.Drawing.Point(467, 219)
        Me.btnzamien.Name = "btnzamien"
        Me.btnzamien.Size = New System.Drawing.Size(90, 23)
        Me.btnzamien.TabIndex = 5
        Me.btnzamien.Text = "Zamień waluty"
        Me.btnzamien.UseSelectable = True
        '
        'btnzaktualizuj
        '
        Me.btnzaktualizuj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzaktualizuj.Location = New System.Drawing.Point(23, 219)
        Me.btnzaktualizuj.Name = "btnzaktualizuj"
        Me.btnzaktualizuj.Size = New System.Drawing.Size(136, 23)
        Me.btnzaktualizuj.TabIndex = 6
        Me.btnzaktualizuj.Text = "Zaktualizuj kursy walut"
        Me.btnzaktualizuj.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.Location = New System.Drawing.Point(329, 245)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(228, 15)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "Dostawcą danych jest Narodowy Bank Polski"
        '
        'lblkurs
        '
        Me.lblkurs.AutoSize = True
        Me.lblkurs.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblkurs.Location = New System.Drawing.Point(23, 245)
        Me.lblkurs.Name = "lblkurs"
        Me.lblkurs.Size = New System.Drawing.Size(168, 15)
        Me.lblkurs.TabIndex = 8
        Me.lblkurs.Text = "Kursy walut z dnia: Nie pobrano!"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WINEASIER.My.Resources.Resources.strz
        Me.PictureBox1.Location = New System.Drawing.Point(277, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WINEASIER.My.Resources.Resources.strz
        Me.PictureBox2.Location = New System.Drawing.Point(277, 146)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'waluta3
        '
        Me.waluta3.AutoSize = True
        Me.waluta3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.waluta3.Location = New System.Drawing.Point(333, 180)
        Me.waluta3.Name = "waluta3"
        Me.waluta3.Size = New System.Drawing.Size(66, 25)
        Me.waluta3.TabIndex = 11
        Me.waluta3.Text = "0 PLN"
        '
        'APK12waluty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 280)
        Me.Controls.Add(Me.waluta3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblkurs)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnzaktualizuj)
        Me.Controls.Add(Me.btnzamien)
        Me.Controls.Add(Me.waluta2)
        Me.Controls.Add(Me.waluta1)
        Me.Controls.Add(Me.listawaluta2)
        Me.Controls.Add(Me.listawaluta1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Name = "APK12waluty"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Przelicznik walut"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents listawaluta1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents listawaluta2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents waluta1 As TextBox
    Friend WithEvents waluta2 As Label
    Friend WithEvents btnzamien As MetroFramework.Controls.MetroLink
    Friend WithEvents btnzaktualizuj As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblkurs As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents waluta3 As Label
End Class
