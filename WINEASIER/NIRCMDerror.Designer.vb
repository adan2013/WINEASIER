﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NIRCMDerror
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NIRCMDerror))
        Me.btnclose = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.Location = New System.Drawing.Point(357, 134)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(100, 23)
        Me.btnclose.TabIndex = 5
        Me.btnclose.Text = "Zamknij okno"
        Me.btnclose.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 68)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(415, 57)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Znaleziono uszkodzenie lub brak części plików programu WINEASIER," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "jeżeli komunik" &
    "at ten będzie się powtarzał będzie wymagana ponowna" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "instalacja aplikacji."
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 30)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(328, 25)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "Znaleziono uszkodzenie plików programu"
        '
        'NIRCMDerror
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 180)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.DisplayHeader = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Movable = False
        Me.Name = "NIRCMDerror"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.ShowInTaskbar = False
        Me.Text = "Błąd - WINEASIER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnclose As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
