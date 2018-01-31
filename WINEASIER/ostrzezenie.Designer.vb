<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ostrzezenie
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
        Me.btnotworz = New MetroFramework.Controls.MetroLink()
        Me.btnzamknij = New MetroFramework.Controls.MetroLink()
        Me.lblopis = New MetroFramework.Controls.MetroLabel()
        Me.mrg = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblnazwa
        '
        Me.lblnazwa.AutoSize = True
        Me.lblnazwa.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblnazwa.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblnazwa.Location = New System.Drawing.Point(23, 30)
        Me.lblnazwa.Name = "lblnazwa"
        Me.lblnazwa.Size = New System.Drawing.Size(119, 25)
        Me.lblnazwa.TabIndex = 0
        Me.lblnazwa.Text = "MetroLabel1"
        '
        'btnotworz
        '
        Me.btnotworz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnotworz.Location = New System.Drawing.Point(410, 146)
        Me.btnotworz.Name = "btnotworz"
        Me.btnotworz.Size = New System.Drawing.Size(56, 23)
        Me.btnotworz.TabIndex = 3
        Me.btnotworz.Text = "Otwórz"
        Me.btnotworz.UseSelectable = True
        '
        'btnzamknij
        '
        Me.btnzamknij.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzamknij.Location = New System.Drawing.Point(348, 146)
        Me.btnzamknij.Name = "btnzamknij"
        Me.btnzamknij.Size = New System.Drawing.Size(56, 23)
        Me.btnzamknij.TabIndex = 4
        Me.btnzamknij.Text = "Zamknij"
        Me.btnzamknij.UseSelectable = True
        '
        'lblopis
        '
        Me.lblopis.AutoSize = True
        Me.lblopis.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblopis.Location = New System.Drawing.Point(23, 55)
        Me.lblopis.Name = "lblopis"
        Me.lblopis.Size = New System.Drawing.Size(130, 19)
        Me.lblopis.TabIndex = 5
        Me.lblopis.Text = "Opis powiadomienia"
        '
        'mrg
        '
        Me.mrg.Enabled = True
        Me.mrg.Interval = 300
        '
        'ostrzezenie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 180)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblopis)
        Me.Controls.Add(Me.btnzamknij)
        Me.Controls.Add(Me.btnotworz)
        Me.Controls.Add(Me.lblnazwa)
        Me.DisplayHeader = False
        Me.Movable = False
        Me.Name = "ostrzezenie"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Ostrzezenie"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnazwa As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnotworz As MetroFramework.Controls.MetroLink
    Friend WithEvents btnzamknij As MetroFramework.Controls.MetroLink
    Friend WithEvents lblopis As MetroFramework.Controls.MetroLabel
    Friend WithEvents mrg As Timer
End Class
