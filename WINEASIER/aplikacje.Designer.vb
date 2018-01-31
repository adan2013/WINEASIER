<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aplikacje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aplikacje))
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.panelzewn = New System.Windows.Forms.Panel()
        Me.txtszukaj = New MetroFramework.Controls.MetroTextBox()
        Me.lbl1 = New MetroFramework.Controls.MetroLabel()
        Me.lbl2 = New MetroFramework.Controls.MetroLabel()
        Me.lbldn = New MetroFramework.Controls.MetroLabel()
        Me.lblup = New MetroFramework.Controls.MetroLabel()
        Me.komunikat = New MetroFramework.Controls.MetroLabel()
        Me.ukr = New System.Windows.Forms.Timer(Me.components)
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(154, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Wszystkie aplikacje"
        '
        'panelzewn
        '
        Me.panelzewn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelzewn.Location = New System.Drawing.Point(23, 111)
        Me.panelzewn.Name = "panelzewn"
        Me.panelzewn.Size = New System.Drawing.Size(604, 341)
        Me.panelzewn.TabIndex = 1
        '
        'txtszukaj
        '
        Me.txtszukaj.Lines = New String(-1) {}
        Me.txtszukaj.Location = New System.Drawing.Point(447, 82)
        Me.txtszukaj.MaxLength = 20
        Me.txtszukaj.Name = "txtszukaj"
        Me.txtszukaj.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtszukaj.PromptText = "Szukaj"
        Me.txtszukaj.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtszukaj.SelectedText = ""
        Me.txtszukaj.Size = New System.Drawing.Size(180, 23)
        Me.txtszukaj.TabIndex = 2
        Me.txtszukaj.UseSelectable = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(56, 82)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(131, 19)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "Znalezionych pozycji:"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lbl2.Location = New System.Drawing.Point(193, 82)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(17, 19)
        Me.lbl2.TabIndex = 5
        Me.lbl2.Text = "0"
        '
        'lbldn
        '
        Me.lbldn.AutoSize = True
        Me.lbldn.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbldn.Location = New System.Drawing.Point(607, 455)
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
        Me.lblup.Location = New System.Drawing.Point(581, 455)
        Me.lblup.Name = "lblup"
        Me.lblup.Size = New System.Drawing.Size(20, 25)
        Me.lblup.TabIndex = 6
        Me.lblup.Text = "↑"
        Me.lblup.Visible = False
        '
        'komunikat
        '
        Me.komunikat.AutoSize = True
        Me.komunikat.Location = New System.Drawing.Point(25, 461)
        Me.komunikat.Name = "komunikat"
        Me.komunikat.Size = New System.Drawing.Size(152, 19)
        Me.komunikat.TabIndex = 8
        Me.komunikat.Text = "Aplikacja jest już otwarta"
        Me.komunikat.Visible = False
        '
        'ukr
        '
        Me.ukr.Interval = 800
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.MetroLabel2.Location = New System.Drawing.Point(244, 460)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(266, 30)
        Me.MetroLabel2.TabIndex = 9
        Me.MetroLabel2.Text = "Aby uzyskać informacje na temat konkretnej" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "aplikacji kliknij na nią prawym przyc" &
    "iskiem myszy"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroLabel2.UseCustomForeColor = True
        '
        'aplikacje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 500)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.komunikat)
        Me.Controls.Add(Me.lbldn)
        Me.Controls.Add(Me.lblup)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtszukaj)
        Me.Controls.Add(Me.panelzewn)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "aplikacje"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Aplikacje"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents panelzewn As Panel
    Friend WithEvents txtszukaj As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbl1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbldn As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblup As MetroFramework.Controls.MetroLabel
    Friend WithEvents komunikat As MetroFramework.Controls.MetroLabel
    Friend WithEvents ukr As Timer
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
End Class
