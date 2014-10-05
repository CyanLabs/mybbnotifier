<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUID = New System.Windows.Forms.Label()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.lblAPI = New System.Windows.Forms.Label()
        Me.lblScriptAddress = New System.Windows.Forms.Label()
        Me.grpServer = New System.Windows.Forms.GroupBox()
        Me.chkGoogleSEO = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.numUID = New System.Windows.Forms.NumericUpDown()
        Me.numInterval = New System.Windows.Forms.NumericUpDown()
        Me.txtScript = New System.Windows.Forms.TextBox()
        Me.txtAPI = New System.Windows.Forms.TextBox()
        Me.lblCyan = New System.Windows.Forms.LinkLabel()
        Me.lblMyBB = New System.Windows.Forms.LinkLabel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.grpApplication = New System.Windows.Forms.GroupBox()
        Me.chkChangelog = New System.Windows.Forms.CheckBox()
        Me.chkStartup = New System.Windows.Forms.CheckBox()
        Me.chkSound = New System.Windows.Forms.CheckBox()
        Me.chkUpdate = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpServer.SuspendLayout()
        CType(Me.numUID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpApplication.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Address:"
        '
        'lblUID
        '
        Me.lblUID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblUID.AutoSize = True
        Me.lblUID.Location = New System.Drawing.Point(166, 121)
        Me.lblUID.Name = "lblUID"
        Me.lblUID.Size = New System.Drawing.Size(32, 13)
        Me.lblUID.TabIndex = 15
        Me.lblUID.Text = "User:"
        '
        'lblInterval
        '
        Me.lblInterval.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(43, 121)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(45, 13)
        Me.lblInterval.TabIndex = 16
        Me.lblInterval.Text = "Interval:"
        '
        'lblAPI
        '
        Me.lblAPI.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAPI.AutoSize = True
        Me.lblAPI.Location = New System.Drawing.Point(60, 90)
        Me.lblAPI.Name = "lblAPI"
        Me.lblAPI.Size = New System.Drawing.Size(28, 13)
        Me.lblAPI.TabIndex = 17
        Me.lblAPI.Text = "Key:"
        '
        'lblScriptAddress
        '
        Me.lblScriptAddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblScriptAddress.AutoSize = True
        Me.lblScriptAddress.Location = New System.Drawing.Point(7, 60)
        Me.lblScriptAddress.Name = "lblScriptAddress"
        Me.lblScriptAddress.Size = New System.Drawing.Size(81, 13)
        Me.lblScriptAddress.TabIndex = 18
        Me.lblScriptAddress.Text = "Script Location:"
        '
        'grpServer
        '
        Me.grpServer.Controls.Add(Me.chkGoogleSEO)
        Me.grpServer.Controls.Add(Me.Label1)
        Me.grpServer.Controls.Add(Me.TextBox1)
        Me.grpServer.Controls.Add(Me.numUID)
        Me.grpServer.Controls.Add(Me.lblScriptAddress)
        Me.grpServer.Controls.Add(Me.lblUID)
        Me.grpServer.Controls.Add(Me.numInterval)
        Me.grpServer.Controls.Add(Me.txtScript)
        Me.grpServer.Controls.Add(Me.txtAPI)
        Me.grpServer.Controls.Add(Me.lblInterval)
        Me.grpServer.Controls.Add(Me.lblAPI)
        Me.grpServer.Location = New System.Drawing.Point(12, 12)
        Me.grpServer.Name = "grpServer"
        Me.grpServer.Size = New System.Drawing.Size(389, 150)
        Me.grpServer.TabIndex = 24
        Me.grpServer.TabStop = False
        Me.grpServer.Text = "Server Settings"
        '
        'chkGoogleSEO
        '
        Me.chkGoogleSEO.AutoSize = True
        Me.chkGoogleSEO.Checked = Global.MyBB_Notifier.My.MySettings.Default.GoogleSEO
        Me.chkGoogleSEO.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MyBB_Notifier.My.MySettings.Default, "GoogleSEO", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkGoogleSEO.Location = New System.Drawing.Point(288, 120)
        Me.chkGoogleSEO.Name = "chkGoogleSEO"
        Me.chkGoogleSEO.Size = New System.Drawing.Size(85, 17)
        Me.chkGoogleSEO.TabIndex = 0
        Me.chkGoogleSEO.Text = "Google SEO"
        Me.chkGoogleSEO.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MyBB_Notifier.My.MySettings.Default, "ForumURL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(94, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(279, 20)
        Me.TextBox1.TabIndex = 22
        Me.TextBox1.Text = Global.MyBB_Notifier.My.MySettings.Default.ForumURL
        '
        'numUID
        '
        Me.numUID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.numUID.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.MyBB_Notifier.My.MySettings.Default, "UID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numUID.Location = New System.Drawing.Point(204, 118)
        Me.numUID.Name = "numUID"
        Me.numUID.Size = New System.Drawing.Size(60, 20)
        Me.numUID.TabIndex = 20
        Me.numUID.Value = Global.MyBB_Notifier.My.MySettings.Default.UID
        '
        'numInterval
        '
        Me.numInterval.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.numInterval.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.MyBB_Notifier.My.MySettings.Default, "Interval", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numInterval.Location = New System.Drawing.Point(94, 118)
        Me.numInterval.Name = "numInterval"
        Me.numInterval.Size = New System.Drawing.Size(60, 20)
        Me.numInterval.TabIndex = 19
        Me.numInterval.Value = Global.MyBB_Notifier.My.MySettings.Default.Interval
        '
        'txtScript
        '
        Me.txtScript.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtScript.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MyBB_Notifier.My.MySettings.Default, "Script", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtScript.Location = New System.Drawing.Point(94, 57)
        Me.txtScript.Name = "txtScript"
        Me.txtScript.Size = New System.Drawing.Size(279, 20)
        Me.txtScript.TabIndex = 14
        Me.txtScript.Text = Global.MyBB_Notifier.My.MySettings.Default.Script
        '
        'txtAPI
        '
        Me.txtAPI.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAPI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MyBB_Notifier.My.MySettings.Default, "APIKey", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtAPI.Location = New System.Drawing.Point(94, 87)
        Me.txtAPI.Name = "txtAPI"
        Me.txtAPI.Size = New System.Drawing.Size(279, 20)
        Me.txtAPI.TabIndex = 13
        Me.txtAPI.Text = Global.MyBB_Notifier.My.MySettings.Default.APIKey
        Me.txtAPI.UseSystemPasswordChar = True
        '
        'lblCyan
        '
        Me.lblCyan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCyan.AutoSize = True
        Me.lblCyan.LinkArea = New System.Windows.Forms.LinkArea(34, 9)
        Me.lblCyan.Location = New System.Drawing.Point(181, 335)
        Me.lblCyan.Name = "lblCyan"
        Me.lblCyan.Size = New System.Drawing.Size(228, 17)
        Me.lblCyan.TabIndex = 27
        Me.lblCyan.TabStop = True
        Me.lblCyan.Text = "MyBB Notifier  - Copyright © 2014 CyanLabs"
        Me.lblCyan.UseCompatibleTextRendering = True
        '
        'lblMyBB
        '
        Me.lblMyBB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMyBB.AutoSize = True
        Me.lblMyBB.LinkArea = New System.Windows.Forms.LinkArea(44, 11)
        Me.lblMyBB.Location = New System.Drawing.Point(102, 315)
        Me.lblMyBB.Name = "lblMyBB"
        Me.lblMyBB.Size = New System.Drawing.Size(312, 17)
        Me.lblMyBB.TabIndex = 26
        Me.lblMyBB.TabStop = True
        Me.lblMyBB.Text = "MyBB Forum Software - Copyright © 2002-2014 MyBB Group"
        Me.lblMyBB.UseCompatibleTextRendering = True
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Location = New System.Drawing.Point(4, 335)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(60, 13)
        Me.lblVersion.TabIndex = 25
        Me.lblVersion.Text = "Version 1.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpApplication
        '
        Me.grpApplication.Controls.Add(Me.chkChangelog)
        Me.grpApplication.Controls.Add(Me.chkStartup)
        Me.grpApplication.Controls.Add(Me.chkSound)
        Me.grpApplication.Controls.Add(Me.chkUpdate)
        Me.grpApplication.Location = New System.Drawing.Point(12, 171)
        Me.grpApplication.Name = "grpApplication"
        Me.grpApplication.Size = New System.Drawing.Size(389, 77)
        Me.grpApplication.TabIndex = 28
        Me.grpApplication.TabStop = False
        Me.grpApplication.Text = "Application Settings"
        '
        'chkChangelog
        '
        Me.chkChangelog.AutoSize = True
        Me.chkChangelog.Checked = Global.MyBB_Notifier.My.MySettings.Default.Changelog
        Me.chkChangelog.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChangelog.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MyBB_Notifier.My.MySettings.Default, "Changelog", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkChangelog.Location = New System.Drawing.Point(220, 23)
        Me.chkChangelog.Name = "chkChangelog"
        Me.chkChangelog.Size = New System.Drawing.Size(106, 17)
        Me.chkChangelog.TabIndex = 24
        Me.chkChangelog.Text = "Show changelog"
        Me.chkChangelog.UseVisualStyleBackColor = True
        Me.chkChangelog.Visible = False
        '
        'chkStartup
        '
        Me.chkStartup.AutoSize = True
        Me.chkStartup.Checked = Global.MyBB_Notifier.My.MySettings.Default.Startup
        Me.chkStartup.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MyBB_Notifier.My.MySettings.Default, "Startup", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkStartup.Location = New System.Drawing.Point(220, 46)
        Me.chkStartup.Name = "chkStartup"
        Me.chkStartup.Size = New System.Drawing.Size(114, 17)
        Me.chkStartup.TabIndex = 23
        Me.chkStartup.Text = "Start with windows"
        Me.chkStartup.UseVisualStyleBackColor = True
        '
        'chkSound
        '
        Me.chkSound.AutoSize = True
        Me.chkSound.Checked = Global.MyBB_Notifier.My.MySettings.Default.Sound
        Me.chkSound.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSound.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MyBB_Notifier.My.MySettings.Default, "Sound", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkSound.Location = New System.Drawing.Point(28, 46)
        Me.chkSound.Name = "chkSound"
        Me.chkSound.Size = New System.Drawing.Size(132, 17)
        Me.chkSound.TabIndex = 22
        Me.chkSound.Text = "Play notification sound"
        Me.chkSound.UseVisualStyleBackColor = True
        '
        'chkUpdate
        '
        Me.chkUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkUpdate.AutoSize = True
        Me.chkUpdate.Checked = Global.MyBB_Notifier.My.MySettings.Default.Update
        Me.chkUpdate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUpdate.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MyBB_Notifier.My.MySettings.Default, "Update", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkUpdate.Location = New System.Drawing.Point(28, 23)
        Me.chkUpdate.Name = "chkUpdate"
        Me.chkUpdate.Size = New System.Drawing.Size(163, 17)
        Me.chkUpdate.TabIndex = 21
        Me.chkUpdate.Text = "Check for updates on launch"
        Me.chkUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.Location = New System.Drawing.Point(12, 254)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(388, 45)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save Settings"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 351)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpApplication)
        Me.Controls.Add(Me.lblCyan)
        Me.Controls.Add(Me.lblMyBB)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.grpServer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.Text = "Settings"
        Me.TopMost = True
        Me.grpServer.ResumeLayout(False)
        Me.grpServer.PerformLayout()
        CType(Me.numUID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpApplication.ResumeLayout(False)
        Me.grpApplication.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents chkUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents numUID As System.Windows.Forms.NumericUpDown
    Friend WithEvents numInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblUID As System.Windows.Forms.Label
    Friend WithEvents lblInterval As System.Windows.Forms.Label
    Friend WithEvents lblAPI As System.Windows.Forms.Label
    Friend WithEvents txtAPI As System.Windows.Forms.TextBox
    Friend WithEvents lblScriptAddress As System.Windows.Forms.Label
    Friend WithEvents txtScript As System.Windows.Forms.TextBox
    Friend WithEvents grpServer As System.Windows.Forms.GroupBox
    Friend WithEvents chkGoogleSEO As System.Windows.Forms.CheckBox
    Friend WithEvents lblCyan As System.Windows.Forms.LinkLabel
    Friend WithEvents lblMyBB As System.Windows.Forms.LinkLabel
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents grpApplication As System.Windows.Forms.GroupBox
    Friend WithEvents chkStartup As System.Windows.Forms.CheckBox
    Friend WithEvents chkSound As System.Windows.Forms.CheckBox
    Friend WithEvents chkChangelog As System.Windows.Forms.CheckBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
