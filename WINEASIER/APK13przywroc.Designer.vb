<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK13przywroc
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
        Me.btnwykonaj = New MetroFramework.Controls.MetroLink()
        Me.btnanuluj = New MetroFramework.Controls.MetroLink()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lista1 = New MetroFramework.Controls.MetroComboBox()
        Me.lista2 = New MetroFramework.Controls.MetroComboBox()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(123, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Przywróć dane"
        '
        'btnwykonaj
        '
        Me.btnwykonaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnwykonaj.Enabled = False
        Me.btnwykonaj.Location = New System.Drawing.Point(302, 154)
        Me.btnwykonaj.Name = "btnwykonaj"
        Me.btnwykonaj.Size = New System.Drawing.Size(75, 23)
        Me.btnwykonaj.TabIndex = 1
        Me.btnwykonaj.Text = "Wykonaj"
        Me.btnwykonaj.UseSelectable = True
        '
        'btnanuluj
        '
        Me.btnanuluj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnanuluj.Location = New System.Drawing.Point(246, 154)
        Me.btnanuluj.Name = "btnanuluj"
        Me.btnanuluj.Size = New System.Drawing.Size(50, 23)
        Me.btnanuluj.TabIndex = 2
        Me.btnanuluj.Text = "Anuluj"
        Me.btnanuluj.UseSelectable = True
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 19
        Me.MetroComboBox1.Location = New System.Drawing.Point(23, 86)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(354, 25)
        Me.MetroComboBox1.TabIndex = 3
        Me.MetroComboBox1.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 64)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(249, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Wybierz pozycje i dane do przywrócenia:"
        '
        'lista1
        '
        Me.lista1.Enabled = False
        Me.lista1.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.lista1.FormattingEnabled = True
        Me.lista1.ItemHeight = 19
        Me.lista1.Location = New System.Drawing.Point(23, 86)
        Me.lista1.Name = "lista1"
        Me.lista1.Size = New System.Drawing.Size(354, 25)
        Me.lista1.TabIndex = 5
        Me.lista1.UseSelectable = True
        '
        'lista2
        '
        Me.lista2.Enabled = False
        Me.lista2.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.lista2.FormattingEnabled = True
        Me.lista2.ItemHeight = 19
        Me.lista2.Location = New System.Drawing.Point(23, 117)
        Me.lista2.Name = "lista2"
        Me.lista2.Size = New System.Drawing.Size(354, 25)
        Me.lista2.TabIndex = 6
        Me.lista2.UseSelectable = True
        '
        'APK13przywroc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.lista2)
        Me.Controls.Add(Me.lista1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.btnanuluj)
        Me.Controls.Add(Me.btnwykonaj)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "APK13przywroc"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Text = "Backup File Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnwykonaj As MetroFramework.Controls.MetroLink
    Friend WithEvents btnanuluj As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lista1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lista2 As MetroFramework.Controls.MetroComboBox
End Class
