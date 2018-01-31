<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK08sejfhasel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(APK08sejfhasel))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.panelzew = New System.Windows.Forms.Panel()
        Me.txtszukaj = New MetroFramework.Controls.MetroTextBox()
        Me.lbldn = New MetroFramework.Controls.MetroLabel()
        Me.lblup = New MetroFramework.Controls.MetroLabel()
        Me.btnlock = New MetroFramework.Controls.MetroLink()
        Me.btnpolityka = New MetroFramework.Controls.MetroLink()
        Me.btnedycja = New MetroFramework.Controls.MetroLink()
        Me.btnnowy = New MetroFramework.Controls.MetroLink()
        Me.btnzmiana = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(83, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Sejf haseł"
        '
        'panelzew
        '
        Me.panelzew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelzew.Location = New System.Drawing.Point(23, 112)
        Me.panelzew.Name = "panelzew"
        Me.panelzew.Size = New System.Drawing.Size(554, 206)
        Me.panelzew.TabIndex = 1
        '
        'txtszukaj
        '
        Me.txtszukaj.Lines = New String(-1) {}
        Me.txtszukaj.Location = New System.Drawing.Point(377, 83)
        Me.txtszukaj.MaxLength = 32767
        Me.txtszukaj.Name = "txtszukaj"
        Me.txtszukaj.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtszukaj.PromptText = "Szukaj"
        Me.txtszukaj.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtszukaj.SelectedText = ""
        Me.txtszukaj.Size = New System.Drawing.Size(200, 23)
        Me.txtszukaj.TabIndex = 2
        Me.txtszukaj.UseSelectable = True
        '
        'lbldn
        '
        Me.lbldn.AutoSize = True
        Me.lbldn.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbldn.Location = New System.Drawing.Point(557, 325)
        Me.lbldn.Name = "lbldn"
        Me.lbldn.Size = New System.Drawing.Size(20, 25)
        Me.lbldn.TabIndex = 7
        Me.lbldn.Text = "↓"
        Me.lbldn.Visible = False
        '
        'lblup
        '
        Me.lblup.AutoSize = True
        Me.lblup.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblup.Location = New System.Drawing.Point(531, 325)
        Me.lblup.Name = "lblup"
        Me.lblup.Size = New System.Drawing.Size(20, 25)
        Me.lblup.TabIndex = 6
        Me.lblup.Text = "↑"
        Me.lblup.Visible = False
        '
        'btnlock
        '
        Me.btnlock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlock.Location = New System.Drawing.Point(23, 83)
        Me.btnlock.Name = "btnlock"
        Me.btnlock.Size = New System.Drawing.Size(75, 23)
        Me.btnlock.TabIndex = 9
        Me.btnlock.Text = "Odblokuj"
        Me.btnlock.UseSelectable = True
        '
        'btnpolityka
        '
        Me.btnpolityka.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpolityka.Location = New System.Drawing.Point(23, 324)
        Me.btnpolityka.Name = "btnpolityka"
        Me.btnpolityka.Size = New System.Drawing.Size(130, 23)
        Me.btnpolityka.TabIndex = 10
        Me.btnpolityka.Text = "Polityka prywatności"
        Me.btnpolityka.UseSelectable = True
        '
        'btnedycja
        '
        Me.btnedycja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnedycja.Location = New System.Drawing.Point(245, 324)
        Me.btnedycja.Name = "btnedycja"
        Me.btnedycja.Size = New System.Drawing.Size(90, 23)
        Me.btnedycja.TabIndex = 11
        Me.btnedycja.Text = "Edycja wpisów"
        Me.btnedycja.UseSelectable = True
        '
        'btnnowy
        '
        Me.btnnowy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnowy.Location = New System.Drawing.Point(341, 325)
        Me.btnnowy.Name = "btnnowy"
        Me.btnnowy.Size = New System.Drawing.Size(80, 23)
        Me.btnnowy.TabIndex = 12
        Me.btnnowy.Text = "Nowy wpis"
        Me.btnnowy.UseSelectable = True
        '
        'btnzmiana
        '
        Me.btnzmiana.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzmiana.Location = New System.Drawing.Point(159, 324)
        Me.btnzmiana.Name = "btnzmiana"
        Me.btnzmiana.Size = New System.Drawing.Size(80, 23)
        Me.btnzmiana.TabIndex = 13
        Me.btnzmiana.Text = "Zmiana hasła"
        Me.btnzmiana.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 360)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(537, 90)
        Me.MetroLabel2.TabIndex = 14
        Me.MetroLabel2.Text = resources.GetString("MetroLabel2.Text")
        '
        'APK08sejfhasel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 470)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnzmiana)
        Me.Controls.Add(Me.btnnowy)
        Me.Controls.Add(Me.btnedycja)
        Me.Controls.Add(Me.btnpolityka)
        Me.Controls.Add(Me.btnlock)
        Me.Controls.Add(Me.lbldn)
        Me.Controls.Add(Me.lblup)
        Me.Controls.Add(Me.txtszukaj)
        Me.Controls.Add(Me.panelzew)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Name = "APK08sejfhasel"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Sejf haseł"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents panelzew As Panel
    Friend WithEvents txtszukaj As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbldn As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblup As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnlock As MetroFramework.Controls.MetroLink
    Friend WithEvents btnpolityka As MetroFramework.Controls.MetroLink
    Friend WithEvents btnedycja As MetroFramework.Controls.MetroLink
    Friend WithEvents btnnowy As MetroFramework.Controls.MetroLink
    Friend WithEvents btnzmiana As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
End Class
