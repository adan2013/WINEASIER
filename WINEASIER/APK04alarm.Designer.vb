<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK04alarm
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
        Me.listaalarmow = New MetroFramework.Controls.MetroPanel()
        Me.lblup = New MetroFramework.Controls.MetroLabel()
        Me.lbldn = New MetroFramework.Controls.MetroLabel()
        Me.btnnowyalarm = New MetroFramework.Controls.MetroLink()
        Me.btnwylaczwszystkie = New MetroFramework.Controls.MetroLink()
        Me.btnusunwszystkie = New MetroFramework.Controls.MetroLink()
        Me.lblilosc = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(57, 25)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Alarm"
        '
        'listaalarmow
        '
        Me.listaalarmow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listaalarmow.HorizontalScrollbarBarColor = True
        Me.listaalarmow.HorizontalScrollbarHighlightOnWheel = False
        Me.listaalarmow.HorizontalScrollbarSize = 10
        Me.listaalarmow.Location = New System.Drawing.Point(23, 72)
        Me.listaalarmow.Name = "listaalarmow"
        Me.listaalarmow.Size = New System.Drawing.Size(554, 180)
        Me.listaalarmow.TabIndex = 1
        Me.listaalarmow.VerticalScrollbarBarColor = True
        Me.listaalarmow.VerticalScrollbarHighlightOnWheel = False
        Me.listaalarmow.VerticalScrollbarSize = 10
        '
        'lblup
        '
        Me.lblup.AutoSize = True
        Me.lblup.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblup.Location = New System.Drawing.Point(531, 258)
        Me.lblup.Name = "lblup"
        Me.lblup.Size = New System.Drawing.Size(20, 25)
        Me.lblup.TabIndex = 2
        Me.lblup.Text = "↑"
        Me.lblup.Visible = False
        '
        'lbldn
        '
        Me.lbldn.AutoSize = True
        Me.lbldn.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lbldn.Location = New System.Drawing.Point(557, 258)
        Me.lbldn.Name = "lbldn"
        Me.lbldn.Size = New System.Drawing.Size(20, 25)
        Me.lbldn.TabIndex = 3
        Me.lbldn.Text = "↓"
        Me.lbldn.Visible = False
        '
        'btnnowyalarm
        '
        Me.btnnowyalarm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnowyalarm.Location = New System.Drawing.Point(23, 258)
        Me.btnnowyalarm.Name = "btnnowyalarm"
        Me.btnnowyalarm.Size = New System.Drawing.Size(75, 23)
        Me.btnnowyalarm.TabIndex = 2
        Me.btnnowyalarm.Text = "Nowy alarm"
        Me.btnnowyalarm.UseSelectable = True
        '
        'btnwylaczwszystkie
        '
        Me.btnwylaczwszystkie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnwylaczwszystkie.Location = New System.Drawing.Point(104, 258)
        Me.btnwylaczwszystkie.Name = "btnwylaczwszystkie"
        Me.btnwylaczwszystkie.Size = New System.Drawing.Size(125, 23)
        Me.btnwylaczwszystkie.TabIndex = 4
        Me.btnwylaczwszystkie.Text = "Wyłącz wszystkie"
        Me.btnwylaczwszystkie.UseSelectable = True
        '
        'btnusunwszystkie
        '
        Me.btnusunwszystkie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnusunwszystkie.Location = New System.Drawing.Point(235, 258)
        Me.btnusunwszystkie.Name = "btnusunwszystkie"
        Me.btnusunwszystkie.Size = New System.Drawing.Size(100, 23)
        Me.btnusunwszystkie.TabIndex = 5
        Me.btnusunwszystkie.Text = "Usuń wszystkie"
        Me.btnusunwszystkie.UseSelectable = True
        '
        'lblilosc
        '
        Me.lblilosc.AutoSize = True
        Me.lblilosc.Location = New System.Drawing.Point(445, 264)
        Me.lblilosc.Name = "lblilosc"
        Me.lblilosc.Size = New System.Drawing.Size(35, 19)
        Me.lblilosc.TabIndex = 6
        Me.lblilosc.Text = "0/10"
        '
        'APK04alarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 300)
        Me.Controls.Add(Me.lblilosc)
        Me.Controls.Add(Me.btnusunwszystkie)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnwylaczwszystkie)
        Me.Controls.Add(Me.btnnowyalarm)
        Me.Controls.Add(Me.lbldn)
        Me.Controls.Add(Me.lblup)
        Me.Controls.Add(Me.listaalarmow)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Name = "APK04alarm"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Alarm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents listaalarmow As MetroFramework.Controls.MetroPanel
    Friend WithEvents lblup As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbldn As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnnowyalarm As MetroFramework.Controls.MetroLink
    Friend WithEvents btnwylaczwszystkie As MetroFramework.Controls.MetroLink
    Friend WithEvents btnusunwszystkie As MetroFramework.Controls.MetroLink
    Friend WithEvents lblilosc As MetroFramework.Controls.MetroLabel
End Class
