<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK18wynik
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.podglad = New System.Windows.Forms.Panel()
        Me.TBred = New MetroFramework.Controls.MetroTrackBar()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.TBgreen = New MetroFramework.Controls.MetroTrackBar()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.TBblue = New MetroFramework.Controls.MetroTrackBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblinfo = New MetroFramework.Controls.MetroLabel()
        Me.schowekhtml = New MetroFramework.Controls.MetroLink()
        Me.txthtml = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.schowekrgb2 = New MetroFramework.Controls.MetroLink()
        Me.txtrgb2 = New MetroFramework.Controls.MetroTextBox()
        Me.schowekrgb = New MetroFramework.Controls.MetroLink()
        Me.txtrgb = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.btnzamknij = New MetroFramework.Controls.MetroLink()
        Me.btnprzywroc = New MetroFramework.Controls.MetroLink()
        Me.info = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(103, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Color Picker"
        '
        'podglad
        '
        Me.podglad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.podglad.Location = New System.Drawing.Point(14, 12)
        Me.podglad.Name = "podglad"
        Me.podglad.Size = New System.Drawing.Size(60, 60)
        Me.podglad.TabIndex = 1
        '
        'TBred
        '
        Me.TBred.BackColor = System.Drawing.Color.Transparent
        Me.TBred.Location = New System.Drawing.Point(31, 87)
        Me.TBred.Maximum = 255
        Me.TBred.Name = "TBred"
        Me.TBred.Size = New System.Drawing.Size(160, 23)
        Me.TBred.TabIndex = 0
        Me.TBred.Text = "MetroTrackBar1"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 85)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(22, 25)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "R"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 114)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(24, 25)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "G"
        '
        'TBgreen
        '
        Me.TBgreen.BackColor = System.Drawing.Color.Transparent
        Me.TBgreen.Location = New System.Drawing.Point(31, 116)
        Me.TBgreen.Maximum = 255
        Me.TBgreen.Name = "TBgreen"
        Me.TBgreen.Size = New System.Drawing.Size(160, 23)
        Me.TBgreen.TabIndex = 3
        Me.TBgreen.Text = "MetroTrackBar2"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 143)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(22, 25)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "B"
        '
        'TBblue
        '
        Me.TBblue.BackColor = System.Drawing.Color.Transparent
        Me.TBblue.Location = New System.Drawing.Point(31, 145)
        Me.TBblue.Maximum = 255
        Me.TBblue.Name = "TBblue"
        Me.TBblue.Size = New System.Drawing.Size(160, 23)
        Me.TBblue.TabIndex = 5
        Me.TBblue.Text = "MetroTrackBar3"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblinfo)
        Me.Panel1.Controls.Add(Me.schowekhtml)
        Me.Panel1.Controls.Add(Me.txthtml)
        Me.Panel1.Controls.Add(Me.MetroLabel6)
        Me.Panel1.Controls.Add(Me.schowekrgb2)
        Me.Panel1.Controls.Add(Me.txtrgb2)
        Me.Panel1.Controls.Add(Me.schowekrgb)
        Me.Panel1.Controls.Add(Me.txtrgb)
        Me.Panel1.Controls.Add(Me.MetroLabel5)
        Me.Panel1.Controls.Add(Me.btnzamknij)
        Me.Panel1.Controls.Add(Me.btnprzywroc)
        Me.Panel1.Controls.Add(Me.podglad)
        Me.Panel1.Controls.Add(Me.MetroLabel4)
        Me.Panel1.Controls.Add(Me.TBred)
        Me.Panel1.Controls.Add(Me.TBblue)
        Me.Panel1.Controls.Add(Me.MetroLabel2)
        Me.Panel1.Controls.Add(Me.MetroLabel3)
        Me.Panel1.Controls.Add(Me.TBgreen)
        Me.Panel1.Location = New System.Drawing.Point(23, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(554, 219)
        Me.Panel1.TabIndex = 7
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.Location = New System.Drawing.Point(14, 193)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(84, 19)
        Me.lblinfo.TabIndex = 8
        Me.lblinfo.Text = "Skopiowano!"
        Me.lblinfo.Visible = False
        '
        'schowekhtml
        '
        Me.schowekhtml.Cursor = System.Windows.Forms.Cursors.Hand
        Me.schowekhtml.Location = New System.Drawing.Point(399, 125)
        Me.schowekhtml.Name = "schowekhtml"
        Me.schowekhtml.Size = New System.Drawing.Size(90, 23)
        Me.schowekhtml.TabIndex = 17
        Me.schowekhtml.Text = "Do schowka"
        Me.schowekhtml.UseSelectable = True
        '
        'txthtml
        '
        Me.txthtml.Lines = New String(-1) {}
        Me.txthtml.Location = New System.Drawing.Point(233, 125)
        Me.txthtml.MaxLength = 32767
        Me.txthtml.Name = "txthtml"
        Me.txthtml.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txthtml.ReadOnly = True
        Me.txthtml.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txthtml.SelectedText = ""
        Me.txthtml.Size = New System.Drawing.Size(160, 23)
        Me.txthtml.TabIndex = 16
        Me.txthtml.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(233, 103)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel6.TabIndex = 15
        Me.MetroLabel6.Text = "Zapis HTML"
        '
        'schowekrgb2
        '
        Me.schowekrgb2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.schowekrgb2.Location = New System.Drawing.Point(399, 77)
        Me.schowekrgb2.Name = "schowekrgb2"
        Me.schowekrgb2.Size = New System.Drawing.Size(90, 23)
        Me.schowekrgb2.TabIndex = 14
        Me.schowekrgb2.Text = "Do schowka"
        Me.schowekrgb2.UseSelectable = True
        '
        'txtrgb2
        '
        Me.txtrgb2.Lines = New String(-1) {}
        Me.txtrgb2.Location = New System.Drawing.Point(233, 77)
        Me.txtrgb2.MaxLength = 32767
        Me.txtrgb2.Name = "txtrgb2"
        Me.txtrgb2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrgb2.ReadOnly = True
        Me.txtrgb2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtrgb2.SelectedText = ""
        Me.txtrgb2.Size = New System.Drawing.Size(160, 23)
        Me.txtrgb2.TabIndex = 13
        Me.txtrgb2.UseSelectable = True
        '
        'schowekrgb
        '
        Me.schowekrgb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.schowekrgb.Location = New System.Drawing.Point(399, 48)
        Me.schowekrgb.Name = "schowekrgb"
        Me.schowekrgb.Size = New System.Drawing.Size(90, 23)
        Me.schowekrgb.TabIndex = 12
        Me.schowekrgb.Text = "Do schowka"
        Me.schowekrgb.UseSelectable = True
        '
        'txtrgb
        '
        Me.txtrgb.Lines = New String(-1) {}
        Me.txtrgb.Location = New System.Drawing.Point(233, 48)
        Me.txtrgb.MaxLength = 32767
        Me.txtrgb.Name = "txtrgb"
        Me.txtrgb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrgb.ReadOnly = True
        Me.txtrgb.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtrgb.SelectedText = ""
        Me.txtrgb.Size = New System.Drawing.Size(160, 23)
        Me.txtrgb.TabIndex = 11
        Me.txtrgb.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(233, 24)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Zapis RGB"
        '
        'btnzamknij
        '
        Me.btnzamknij.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzamknij.Location = New System.Drawing.Point(491, 193)
        Me.btnzamknij.Name = "btnzamknij"
        Me.btnzamknij.Size = New System.Drawing.Size(60, 23)
        Me.btnzamknij.TabIndex = 9
        Me.btnzamknij.Text = "Zamknij"
        Me.btnzamknij.UseSelectable = True
        '
        'btnprzywroc
        '
        Me.btnprzywroc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprzywroc.Location = New System.Drawing.Point(335, 193)
        Me.btnprzywroc.Name = "btnprzywroc"
        Me.btnprzywroc.Size = New System.Drawing.Size(150, 23)
        Me.btnprzywroc.TabIndex = 8
        Me.btnprzywroc.Text = "Przywróć pobrany kolor"
        Me.btnprzywroc.UseSelectable = True
        '
        'info
        '
        Me.info.Interval = 600
        '
        'APK18wynik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 300)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "APK18wynik"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Color Picker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents podglad As Panel
    Friend WithEvents TBred As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TBgreen As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TBblue As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnzamknij As MetroFramework.Controls.MetroLink
    Friend WithEvents btnprzywroc As MetroFramework.Controls.MetroLink
    Friend WithEvents schowekhtml As MetroFramework.Controls.MetroLink
    Friend WithEvents txthtml As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents schowekrgb2 As MetroFramework.Controls.MetroLink
    Friend WithEvents txtrgb2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents schowekrgb As MetroFramework.Controls.MetroLink
    Friend WithEvents txtrgb As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents info As Timer
    Friend WithEvents lblinfo As MetroFramework.Controls.MetroLabel
End Class
