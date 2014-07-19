<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Subject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Message = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Poster = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblScriptAddress = New System.Windows.Forms.Label()
        Me.lblAPI = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.ntfyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblMyBB = New System.Windows.Forms.LinkLabel()
        Me.lblCyan = New System.Windows.Forms.LinkLabel()
        Me.lblUID = New System.Windows.Forms.Label()
        Me.chkUpdate = New System.Windows.Forms.CheckBox()
        Me.numUID = New System.Windows.Forms.NumericUpDown()
        Me.numInterval = New System.Windows.Forms.NumericUpDown()
        Me.txtAPI = New System.Windows.Forms.TextBox()
        Me.txtScript = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.numUID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Subject, Me.Message, Me.Poster})
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(15, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(978, 201)
        Me.DataGridView1.TabIndex = 1
        '
        'Subject
        '
        Me.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Subject.HeaderText = "Subject"
        Me.Subject.Name = "Subject"
        Me.Subject.ReadOnly = True
        Me.Subject.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Subject.Width = 68
        '
        'Message
        '
        Me.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Message.HeaderText = "Message"
        Me.Message.Name = "Message"
        Me.Message.ReadOnly = True
        '
        'Poster
        '
        Me.Poster.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Poster.HeaderText = "Poster"
        Me.Poster.Name = "Poster"
        Me.Poster.ReadOnly = True
        Me.Poster.Width = 62
        '
        'lblScriptAddress
        '
        Me.lblScriptAddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblScriptAddress.AutoSize = True
        Me.lblScriptAddress.Location = New System.Drawing.Point(12, 16)
        Me.lblScriptAddress.Name = "lblScriptAddress"
        Me.lblScriptAddress.Size = New System.Drawing.Size(81, 13)
        Me.lblScriptAddress.TabIndex = 3
        Me.lblScriptAddress.Text = "Script Location:"
        '
        'lblAPI
        '
        Me.lblAPI.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAPI.AutoSize = True
        Me.lblAPI.Location = New System.Drawing.Point(289, 17)
        Me.lblAPI.Name = "lblAPI"
        Me.lblAPI.Size = New System.Drawing.Size(28, 13)
        Me.lblAPI.TabIndex = 3
        Me.lblAPI.Text = "Key:"
        '
        'Timer1
        '
        '
        'lblInterval
        '
        Me.lblInterval.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(441, 16)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(45, 13)
        Me.lblInterval.TabIndex = 3
        Me.lblInterval.Text = "Interval:"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRefresh.Location = New System.Drawing.Point(938, 13)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(55, 21)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'ntfyIcon
        '
        Me.ntfyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ntfyIcon.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ntfyIcon.Icon = CType(resources.GetObject("ntfyIcon.Icon"), System.Drawing.Icon)
        Me.ntfyIcon.Text = "MyBB Notifier"
        Me.ntfyIcon.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(104, 48)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpdate.Location = New System.Drawing.Point(841, 13)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(91, 21)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update Settings"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Location = New System.Drawing.Point(27, 243)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(954, 13)
        Me.lblVersion.TabIndex = 6
        Me.lblVersion.Text = "Version 1.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMyBB
        '
        Me.lblMyBB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMyBB.AutoSize = True
        Me.lblMyBB.LinkArea = New System.Windows.Forms.LinkArea(44, 11)
        Me.lblMyBB.Location = New System.Drawing.Point(15, 243)
        Me.lblMyBB.Name = "lblMyBB"
        Me.lblMyBB.Size = New System.Drawing.Size(315, 17)
        Me.lblMyBB.TabIndex = 7
        Me.lblMyBB.TabStop = True
        Me.lblMyBB.Text = "MyBB Forum Software - Copyright © 2002-2014 MyBB Group "
        Me.lblMyBB.UseCompatibleTextRendering = True
        '
        'lblCyan
        '
        Me.lblCyan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCyan.AutoSize = True
        Me.lblCyan.LinkArea = New System.Windows.Forms.LinkArea(34, 9)
        Me.lblCyan.Location = New System.Drawing.Point(762, 243)
        Me.lblCyan.Name = "lblCyan"
        Me.lblCyan.Size = New System.Drawing.Size(231, 17)
        Me.lblCyan.TabIndex = 8
        Me.lblCyan.TabStop = True
        Me.lblCyan.Text = "MyBB Notifier  - Copyright © 2014 CyanLabs "
        Me.lblCyan.UseCompatibleTextRendering = True
        '
        'lblUID
        '
        Me.lblUID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblUID.AutoSize = True
        Me.lblUID.Location = New System.Drawing.Point(556, 16)
        Me.lblUID.Name = "lblUID"
        Me.lblUID.Size = New System.Drawing.Size(32, 13)
        Me.lblUID.TabIndex = 3
        Me.lblUID.Text = "User:"
        '
        'chkUpdate
        '
        Me.chkUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkUpdate.AutoSize = True
        Me.chkUpdate.Checked = Global.MyBB_Notifier.My.MySettings.Default.Update
        Me.chkUpdate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUpdate.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.MyBB_Notifier.My.MySettings.Default, "Update", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkUpdate.Location = New System.Drawing.Point(675, 15)
        Me.chkUpdate.Name = "chkUpdate"
        Me.chkUpdate.Size = New System.Drawing.Size(141, 17)
        Me.chkUpdate.TabIndex = 10
        Me.chkUpdate.Text = "Auto Update Application"
        Me.chkUpdate.UseVisualStyleBackColor = True
        '
        'numUID
        '
        Me.numUID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.numUID.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.MyBB_Notifier.My.MySettings.Default, "UID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numUID.Location = New System.Drawing.Point(594, 13)
        Me.numUID.Name = "numUID"
        Me.numUID.Size = New System.Drawing.Size(46, 20)
        Me.numUID.TabIndex = 9
        Me.numUID.Value = Global.MyBB_Notifier.My.MySettings.Default.UID
        '
        'numInterval
        '
        Me.numInterval.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.numInterval.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.MyBB_Notifier.My.MySettings.Default, "Interval", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numInterval.Location = New System.Drawing.Point(492, 13)
        Me.numInterval.Name = "numInterval"
        Me.numInterval.Size = New System.Drawing.Size(46, 20)
        Me.numInterval.TabIndex = 4
        Me.numInterval.Value = Global.MyBB_Notifier.My.MySettings.Default.Interval
        '
        'txtAPI
        '
        Me.txtAPI.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtAPI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MyBB_Notifier.My.MySettings.Default, "APIKey", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtAPI.Location = New System.Drawing.Point(323, 13)
        Me.txtAPI.Name = "txtAPI"
        Me.txtAPI.Size = New System.Drawing.Size(100, 20)
        Me.txtAPI.TabIndex = 2
        Me.txtAPI.Text = Global.MyBB_Notifier.My.MySettings.Default.APIKey
        '
        'txtScript
        '
        Me.txtScript.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtScript.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MyBB_Notifier.My.MySettings.Default, "ScriptURL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtScript.Location = New System.Drawing.Point(99, 13)
        Me.txtScript.Name = "txtScript"
        Me.txtScript.Size = New System.Drawing.Size(170, 20)
        Me.txtScript.TabIndex = 2
        Me.txtScript.Text = Global.MyBB_Notifier.My.MySettings.Default.ScriptURL
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 261)
        Me.Controls.Add(Me.chkUpdate)
        Me.Controls.Add(Me.numUID)
        Me.Controls.Add(Me.lblCyan)
        Me.Controls.Add(Me.lblMyBB)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.numInterval)
        Me.Controls.Add(Me.lblUID)
        Me.Controls.Add(Me.lblInterval)
        Me.Controls.Add(Me.lblAPI)
        Me.Controls.Add(Me.txtAPI)
        Me.Controls.Add(Me.lblScriptAddress)
        Me.Controls.Add(Me.txtScript)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblVersion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1024, 300)
        Me.Name = "Form1"
        Me.Text = "MyBB Notifier"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.numUID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Subject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Message As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Poster As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtScript As System.Windows.Forms.TextBox
    Friend WithEvents lblScriptAddress As System.Windows.Forms.Label
    Friend WithEvents txtAPI As System.Windows.Forms.TextBox
    Friend WithEvents lblAPI As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblInterval As System.Windows.Forms.Label
    Friend WithEvents numInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents ntfyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblMyBB As System.Windows.Forms.LinkLabel
    Friend WithEvents lblCyan As System.Windows.Forms.LinkLabel
    Friend WithEvents lblUID As System.Windows.Forms.Label
    Friend WithEvents numUID As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkUpdate As System.Windows.Forms.CheckBox

End Class
