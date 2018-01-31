<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APK19analizatordysku
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.drzewo = New System.Windows.Forms.TreeView()
        Me.btnstart = New MetroFramework.Controls.MetroLink()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.graf = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblstat = New MetroFramework.Controls.MetroLabel()
        Me.lblanaliza = New MetroFramework.Controls.MetroLabel()
        Me.spinprogress = New MetroFramework.Controls.MetroProgressSpinner()
        Me.lblpath = New MetroFramework.Controls.MetroLabel()
        Me.btnzmien = New MetroFramework.Controls.MetroLink()
        Me.dirdialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.graf, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MetroLabel1.Text = "Analizator dysku"
        '
        'drzewo
        '
        Me.drzewo.Font = New System.Drawing.Font("Lucida Console", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.drzewo.Location = New System.Drawing.Point(12, 92)
        Me.drzewo.Name = "drzewo"
        Me.drzewo.Size = New System.Drawing.Size(613, 474)
        Me.drzewo.TabIndex = 1
        '
        'btnstart
        '
        Me.btnstart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstart.Location = New System.Drawing.Point(3, 17)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(110, 23)
        Me.btnstart.TabIndex = 2
        Me.btnstart.Text = "Rozpocznij analizę"
        Me.btnstart.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblstat)
        Me.Panel1.Controls.Add(Me.lblanaliza)
        Me.Panel1.Controls.Add(Me.spinprogress)
        Me.Panel1.Controls.Add(Me.lblpath)
        Me.Panel1.Controls.Add(Me.btnzmien)
        Me.Panel1.Controls.Add(Me.btnstart)
        Me.Panel1.Controls.Add(Me.drzewo)
        Me.Panel1.Location = New System.Drawing.Point(23, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1254, 569)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.MetroLabel3)
        Me.Panel2.Controls.Add(Me.graf)
        Me.Panel2.Controls.Add(Me.MetroLabel2)
        Me.Panel2.Location = New System.Drawing.Point(631, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(620, 474)
        Me.Panel2.TabIndex = 10
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 428)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(294, 30)
        Me.MetroLabel3.TabIndex = 10
        Me.MetroLabel3.Text = "Użyj prawego przycisku myszy na gałęzi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "struktury katalogów, by otworzyć ścieżkę " &
    "docelową"
        Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroLabel3.UseCustomForeColor = True
        '
        'graf
        '
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Name = "ChartArea1"
        Me.graf.ChartAreas.Add(ChartArea1)
        Me.graf.Location = New System.Drawing.Point(3, 3)
        Me.graf.Name = "graf"
        Me.graf.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.CustomProperties = "PieLabelStyle=Outside"
        Series1.Name = "Series1"
        Me.graf.Series.Add(Series1)
        Me.graf.Size = New System.Drawing.Size(612, 422)
        Me.graf.TabIndex = 8
        Me.graf.Text = "Chart1"
        Me.graf.Visible = False
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.MetroLabel2.Location = New System.Drawing.Point(325, 428)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(290, 30)
        Me.MetroLabel2.TabIndex = 9
        Me.MetroLabel2.Text = "Aby wyświetlić diagram kliknij dwukrotnie na jedną" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "z gałęzi struktury katalogów " &
    "po lewej stronie"
        Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroLabel2.UseCustomForeColor = True
        '
        'lblstat
        '
        Me.lblstat.AutoSize = True
        Me.lblstat.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblstat.Location = New System.Drawing.Point(58, 65)
        Me.lblstat.Name = "lblstat"
        Me.lblstat.Size = New System.Drawing.Size(201, 15)
        Me.lblstat.TabIndex = 7
        Me.lblstat.Text = "0 katalogów / 0 błędów braku dostępu"
        '
        'lblanaliza
        '
        Me.lblanaliza.AutoSize = True
        Me.lblanaliza.Location = New System.Drawing.Point(58, 46)
        Me.lblanaliza.Name = "lblanaliza"
        Me.lblanaliza.Size = New System.Drawing.Size(197, 19)
        Me.lblanaliza.TabIndex = 6
        Me.lblanaliza.Text = "Analiza nie została uruchomiona"
        '
        'spinprogress
        '
        Me.spinprogress.Location = New System.Drawing.Point(12, 46)
        Me.spinprogress.Maximum = 1
        Me.spinprogress.Name = "spinprogress"
        Me.spinprogress.Size = New System.Drawing.Size(40, 40)
        Me.spinprogress.Speed = 2.0!
        Me.spinprogress.Spinning = False
        Me.spinprogress.TabIndex = 5
        Me.spinprogress.UseSelectable = True
        Me.spinprogress.Value = 1
        '
        'lblpath
        '
        Me.lblpath.AutoSize = True
        Me.lblpath.Location = New System.Drawing.Point(215, 21)
        Me.lblpath.Name = "lblpath"
        Me.lblpath.Size = New System.Drawing.Size(26, 19)
        Me.lblpath.TabIndex = 4
        Me.lblpath.Text = "C:\"
        '
        'btnzmien
        '
        Me.btnzmien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnzmien.Location = New System.Drawing.Point(119, 17)
        Me.btnzmien.Name = "btnzmien"
        Me.btnzmien.Size = New System.Drawing.Size(90, 23)
        Me.btnzmien.TabIndex = 3
        Me.btnzmien.Text = "Zmień katalog"
        Me.btnzmien.UseSelectable = True
        '
        'dirdialog
        '
        Me.dirdialog.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.dirdialog.SelectedPath = "C:\"
        Me.dirdialog.ShowNewFolderButton = False
        '
        'APK19analizatordysku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.Name = "APK19analizatordysku"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "Analizator dysku"
        Me.TransparencyKey = System.Drawing.Color.Magenta
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.graf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents drzewo As TreeView
    Friend WithEvents btnstart As MetroFramework.Controls.MetroLink
    Friend WithEvents Panel1 As Panel
    Friend WithEvents graf As DataVisualization.Charting.Chart
    Friend WithEvents lblstat As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblanaliza As MetroFramework.Controls.MetroLabel
    Friend WithEvents spinprogress As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents lblpath As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnzmien As MetroFramework.Controls.MetroLink
    Friend WithEvents dirdialog As FolderBrowserDialog
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
End Class
