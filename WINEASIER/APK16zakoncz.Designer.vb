<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK16zakoncz
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
        Me.lbldir = New MetroFramework.Controls.MetroLabel()
        Me.btnanuluj = New MetroFramework.Controls.MetroLink()
        Me.btnrozpocznij = New MetroFramework.Controls.MetroLink()
        Me.btnzmien = New MetroFramework.Controls.MetroLink()
        Me.seldir = New System.Windows.Forms.FolderBrowserDialog()
        Me.progbar = New MetroFramework.Controls.MetroProgressBar()
        Me.lblpostep = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(232, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Wybierz lokalizację docelową"
        '
        'lbldir
        '
        Me.lbldir.AutoSize = True
        Me.lbldir.Location = New System.Drawing.Point(23, 64)
        Me.lbldir.Name = "lbldir"
        Me.lbldir.Size = New System.Drawing.Size(83, 19)
        Me.lbldir.TabIndex = 1
        Me.lbldir.Text = "MetroLabel2"
        '
        'btnanuluj
        '
        Me.btnanuluj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnanuluj.Location = New System.Drawing.Point(397, 134)
        Me.btnanuluj.Name = "btnanuluj"
        Me.btnanuluj.Size = New System.Drawing.Size(60, 23)
        Me.btnanuluj.TabIndex = 2
        Me.btnanuluj.Text = "Anuluj"
        Me.btnanuluj.UseSelectable = True
        '
        'btnrozpocznij
        '
        Me.btnrozpocznij.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrozpocznij.Location = New System.Drawing.Point(241, 134)
        Me.btnrozpocznij.Name = "btnrozpocznij"
        Me.btnrozpocznij.Size = New System.Drawing.Size(150, 23)
        Me.btnrozpocznij.TabIndex = 3
        Me.btnrozpocznij.Text = "Rozpocznij kopiowanie"
        Me.btnrozpocznij.UseSelectable = True
        '
        'btnzmien
        '
        Me.btnzmien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzmien.Location = New System.Drawing.Point(155, 134)
        Me.btnzmien.Name = "btnzmien"
        Me.btnzmien.Size = New System.Drawing.Size(80, 23)
        Me.btnzmien.TabIndex = 4
        Me.btnzmien.Text = "Zmień folder"
        Me.btnzmien.UseSelectable = True
        '
        'progbar
        '
        Me.progbar.Location = New System.Drawing.Point(23, 97)
        Me.progbar.Name = "progbar"
        Me.progbar.Size = New System.Drawing.Size(300, 19)
        Me.progbar.TabIndex = 5
        Me.progbar.Visible = False
        '
        'lblpostep
        '
        Me.lblpostep.AutoSize = True
        Me.lblpostep.Location = New System.Drawing.Point(329, 97)
        Me.lblpostep.Name = "lblpostep"
        Me.lblpostep.Size = New System.Drawing.Size(36, 19)
        Me.lblpostep.TabIndex = 6
        Me.lblpostep.Text = "0 / 0"
        Me.lblpostep.Visible = False
        '
        'APK16zakoncz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 180)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblpostep)
        Me.Controls.Add(Me.progbar)
        Me.Controls.Add(Me.btnzmien)
        Me.Controls.Add(Me.btnrozpocznij)
        Me.Controls.Add(Me.btnanuluj)
        Me.Controls.Add(Me.lbldir)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "APK16zakoncz"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Text = "Selektor zdjęć"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbldir As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnanuluj As MetroFramework.Controls.MetroLink
    Friend WithEvents btnrozpocznij As MetroFramework.Controls.MetroLink
    Friend WithEvents btnzmien As MetroFramework.Controls.MetroLink
    Friend WithEvents seldir As FolderBrowserDialog
    Friend WithEvents progbar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents lblpostep As MetroFramework.Controls.MetroLabel
End Class
