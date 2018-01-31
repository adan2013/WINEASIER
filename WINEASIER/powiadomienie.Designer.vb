<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class powiadomienie
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
        Me.lblnazwa = New MetroFramework.Controls.MetroLabel()
        Me.lblopis = New MetroFramework.Controls.MetroLabel()
        Me.btnotworz = New MetroFramework.Controls.MetroLink()
        Me.btnprzyczytane = New MetroFramework.Controls.MetroLink()
        Me.lbltime = New MetroFramework.Controls.MetroLabel()
        Me.ukrywanie = New System.Windows.Forms.Timer(Me.components)
        Me.lblzamknij = New MetroFramework.Controls.MetroLink()
        Me.nagore = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblnazwa
        '
        Me.lblnazwa.AutoSize = True
        Me.lblnazwa.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblnazwa.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblnazwa.Location = New System.Drawing.Point(20, 22)
        Me.lblnazwa.Name = "lblnazwa"
        Me.lblnazwa.Size = New System.Drawing.Size(144, 25)
        Me.lblnazwa.TabIndex = 0
        Me.lblnazwa.Text = "Nazwa aplikacji"
        '
        'lblopis
        '
        Me.lblopis.AutoSize = True
        Me.lblopis.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblopis.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblopis.Location = New System.Drawing.Point(23, 47)
        Me.lblopis.Name = "lblopis"
        Me.lblopis.Size = New System.Drawing.Size(109, 15)
        Me.lblopis.TabIndex = 1
        Me.lblopis.Text = "Opis powiadomienia"
        '
        'btnotworz
        '
        Me.btnotworz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnotworz.Location = New System.Drawing.Point(334, 70)
        Me.btnotworz.Name = "btnotworz"
        Me.btnotworz.Size = New System.Drawing.Size(56, 23)
        Me.btnotworz.TabIndex = 2
        Me.btnotworz.Text = "Otwórz"
        Me.btnotworz.UseSelectable = True
        '
        'btnprzyczytane
        '
        Me.btnprzyczytane.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprzyczytane.Location = New System.Drawing.Point(175, 70)
        Me.btnprzyczytane.Name = "btnprzyczytane"
        Me.btnprzyczytane.Size = New System.Drawing.Size(153, 23)
        Me.btnprzyczytane.TabIndex = 3
        Me.btnprzyczytane.Text = "Oznacz jako przeczytane"
        Me.btnprzyczytane.UseSelectable = True
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lbltime.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbltime.Location = New System.Drawing.Point(356, 47)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(34, 15)
        Me.lbltime.TabIndex = 4
        Me.lbltime.Text = "00:00"
        '
        'ukrywanie
        '
        Me.ukrywanie.Enabled = True
        Me.ukrywanie.Interval = 8000
        '
        'lblzamknij
        '
        Me.lblzamknij.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblzamknij.Location = New System.Drawing.Point(373, 9)
        Me.lblzamknij.Name = "lblzamknij"
        Me.lblzamknij.Size = New System.Drawing.Size(17, 23)
        Me.lblzamknij.TabIndex = 5
        Me.lblzamknij.Text = "x"
        Me.lblzamknij.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblzamknij.UseSelectable = True
        '
        'nagore
        '
        Me.nagore.Enabled = True
        Me.nagore.Interval = 10
        '
        'powiadomienie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 100)
        Me.Controls.Add(Me.lblzamknij)
        Me.Controls.Add(Me.lbltime)
        Me.Controls.Add(Me.btnprzyczytane)
        Me.Controls.Add(Me.btnotworz)
        Me.Controls.Add(Me.lblopis)
        Me.Controls.Add(Me.lblnazwa)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "powiadomienie"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Silver
        Me.Text = "Powiadomienie"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnazwa As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblopis As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnotworz As MetroFramework.Controls.MetroLink
    Friend WithEvents btnprzyczytane As MetroFramework.Controls.MetroLink
    Friend WithEvents lbltime As MetroFramework.Controls.MetroLabel
    Friend WithEvents ukrywanie As Timer
    Friend WithEvents lblzamknij As MetroFramework.Controls.MetroLink
    Friend WithEvents nagore As Timer
End Class
