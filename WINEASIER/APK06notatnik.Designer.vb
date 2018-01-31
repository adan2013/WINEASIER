<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class APK06notatnik
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lbldn = New MetroFramework.Controls.MetroLabel()
        Me.lblup = New MetroFramework.Controls.MetroLabel()
        Me.btnnowa = New MetroFramework.Controls.MetroLink()
        Me.btnusun = New MetroFramework.Controls.MetroLink()
        Me.panellista = New System.Windows.Forms.Panel()
        Me.panelpodglad = New System.Windows.Forms.Panel()
        Me.txtpodglad = New MetroFramework.Controls.MetroLabel()
        Me.lblinfo = New MetroFramework.Controls.MetroLabel()
        Me.panelpodglad.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(76, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Notatnik"
        '
        'lbldn
        '
        Me.lbldn.AutoSize = True
        Me.lbldn.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbldn.Location = New System.Drawing.Point(243, 352)
        Me.lbldn.Name = "lbldn"
        Me.lbldn.Size = New System.Drawing.Size(20, 25)
        Me.lbldn.TabIndex = 5
        Me.lbldn.Text = "↓"
        Me.lbldn.Visible = False
        '
        'lblup
        '
        Me.lblup.AutoSize = True
        Me.lblup.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblup.Location = New System.Drawing.Point(217, 352)
        Me.lblup.Name = "lblup"
        Me.lblup.Size = New System.Drawing.Size(20, 25)
        Me.lblup.TabIndex = 4
        Me.lblup.Text = "↑"
        Me.lblup.Visible = False
        '
        'btnnowa
        '
        Me.btnnowa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnowa.Location = New System.Drawing.Point(23, 354)
        Me.btnnowa.Name = "btnnowa"
        Me.btnnowa.Size = New System.Drawing.Size(100, 23)
        Me.btnnowa.TabIndex = 2
        Me.btnnowa.Text = "Nowa notatka"
        Me.btnnowa.UseSelectable = True
        '
        'btnusun
        '
        Me.btnusun.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnusun.Enabled = False
        Me.btnusun.Location = New System.Drawing.Point(129, 354)
        Me.btnusun.Name = "btnusun"
        Me.btnusun.Size = New System.Drawing.Size(50, 23)
        Me.btnusun.TabIndex = 7
        Me.btnusun.Text = "Usuń"
        Me.btnusun.UseSelectable = True
        '
        'panellista
        '
        Me.panellista.BackColor = System.Drawing.Color.White
        Me.panellista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panellista.Location = New System.Drawing.Point(23, 68)
        Me.panellista.Name = "panellista"
        Me.panellista.Size = New System.Drawing.Size(250, 280)
        Me.panellista.TabIndex = 8
        '
        'panelpodglad
        '
        Me.panelpodglad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelpodglad.Controls.Add(Me.txtpodglad)
        Me.panelpodglad.Controls.Add(Me.lblinfo)
        Me.panelpodglad.Location = New System.Drawing.Point(279, 68)
        Me.panelpodglad.Name = "panelpodglad"
        Me.panelpodglad.Size = New System.Drawing.Size(398, 309)
        Me.panelpodglad.TabIndex = 9
        '
        'txtpodglad
        '
        Me.txtpodglad.AutoSize = True
        Me.txtpodglad.Location = New System.Drawing.Point(13, 12)
        Me.txtpodglad.Name = "txtpodglad"
        Me.txtpodglad.Size = New System.Drawing.Size(36, 19)
        Me.txtpodglad.TabIndex = 10
        Me.txtpodglad.Text = "tresc"
        Me.txtpodglad.Visible = False
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblinfo.Location = New System.Drawing.Point(95, 156)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(238, 30)
        Me.lblinfo.TabIndex = 10
        Me.lblinfo.Text = "Wybierz notatkę z listy alby wyświetlić podgląd" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kliknij dwukrotnie, aby edytować" &
    " notatkę"
        Me.lblinfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'APK06notatnik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 400)
        Me.Controls.Add(Me.panelpodglad)
        Me.Controls.Add(Me.panellista)
        Me.Controls.Add(Me.btnusun)
        Me.Controls.Add(Me.btnnowa)
        Me.Controls.Add(Me.lbldn)
        Me.Controls.Add(Me.lblup)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MinimumSize = New System.Drawing.Size(700, 400)
        Me.Name = "APK06notatnik"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Notatnik"
        Me.panelpodglad.ResumeLayout(False)
        Me.panelpodglad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbldn As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblup As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnnowa As MetroFramework.Controls.MetroLink
    Friend WithEvents btnusun As MetroFramework.Controls.MetroLink
    Friend WithEvents panellista As Panel
    Friend WithEvents panelpodglad As Panel
    Friend WithEvents lblinfo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtpodglad As MetroFramework.Controls.MetroLabel
End Class
