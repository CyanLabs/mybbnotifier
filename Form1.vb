﻿'MyBB Notifier - V1.1 (Client Side).
'Created By CyanLabs. (http://cyanlabs.net)
'Credit to ShrinkOnce @ http://community.mybb.com/thread-123744.html for the idea.

'I based it on the post above but have included security such as API key as in the old version.
'ANY ONE COULD GET THE SALT AND MD5 OF THE OWNERS (UID 1) ACCOUNT. DO NOT USE THE OLD VERSION BY ShrinkOnce.
'The old version was also based on a chrome extension where as mine will be a windows application and possible other OS's
'My version also uses JSON to parse not only the count but also the subject, poster and message.

'Feel free to improve or break this code and re-distribute it. Leave the credit for both Fma965/Cyanlabs and ShrinkOnce.
Imports Newtonsoft.Json
Imports System.Net
Imports System.Threading
Imports System.Text.RegularExpressions

Public Class Form1
    Dim wc As New WebClient, obj As IList, json As String = ""
    Dim DoClose As Boolean = False, oldcount As Integer = 999999999
    Dim Updater As New Cyanlabs_Updater.Updater
    Private UpdateChecker As System.Threading.Thread = New Thread(AddressOf Updater.IsLatest)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Update = True Then
            UpdateChecker.IsBackground = True
            UpdateChecker.Start()
        End If
        Timer1.Interval = My.Settings.Interval * 1000
        Timer1.Start()
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        Me.Visible = False
        PollPosts()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PollPosts()
    End Sub
    Sub PollPosts()
        Try
            json = wc.DownloadString(My.Settings.ForumURL & My.Settings.Script & "?apikey=" & My.Settings.APIKey & "&UID=" & My.Settings.UID)
        Catch ex As Exception
            ntfyIcon.ShowBalloonTip(5000, "MyBB Notifier - Error", ex.Message, ToolTipIcon.Error)
        End Try
        If json = "Invalid API Key" Or json = "No API Key" Then
            ntfyIcon.ShowBalloonTip(5000, "MyBB Notifier - Error", "Missing or Invalid API Key", ToolTipIcon.Error)
            Timer1.Stop()
            Exit Sub
        ElseIf json = "Please change your API key at the top of the server script before use" Then
            ntfyIcon.ShowBalloonTip(5000, "MyBB Notifier - Error", json, ToolTipIcon.Error)
            Timer1.Stop()
            Exit Sub
        End If
        Try
            obj = JsonConvert.DeserializeObject(Of List(Of JSON_result))(json)

            DataGridView1.Rows.Clear()
            Dim x As Integer = 0
            For Each item In obj
                item.message = Regex.Replace(item.message, "\[[^\.*]*\]", "").Replace(vbNewLine & vbNewLine, " ")
                DataGridView1.Rows.Add(New String() {item.subject, item.message, item.username})
                If My.Settings.GoogleSEO Then
                    DataGridView1.Rows(x).Tag = My.Settings.ForumURL & "/showthread.php?tid=" & item.tid & "&action=lastpost"
                Else
                    DataGridView1.Rows(x).Tag = My.Settings.ForumURL & "/showthread.php?tid=" & item.tid & "?action=lastpost"
                End If
                x = x + 1
            Next

            If Not oldcount = obj.Count Then
                If obj.Count = 1 Then
                    ntfyIcon.ShowBalloonTip(5000, "MyBB Notifier - New Posts", "There is " & obj.Count & " new post since your last visit", ToolTipIcon.Info)
                    If My.Settings.Sound Then My.Computer.Audio.Play(My.Resources.notify, AudioPlayMode.Background)
                    ElseIf obj.Count = 0 Then
                        ntfyIcon.ShowBalloonTip(5000, "MyBB Notifier - New Posts", "There are " & obj.Count & " new posts since your last visit", ToolTipIcon.Info)
                    End If
                End If
                oldcount = obj.Count
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ntfyIcon_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Visible = True
        Me.Opacity = 1
        Me.ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not DoClose Then
            e.Cancel = True
            Me.WindowState = FormWindowState.Minimized
            Me.Visible = False
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click, ExitToolStripMenuItem1.Click
        DoClose = True
        Application.Exit()
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Process.Start(DataGridView1.Rows(e.RowIndex).Tag)
    End Sub

    Private Sub ntfyIcon_DoubleClick(sender As Object, e As EventArgs) Handles ntfyIcon.DoubleClick
        If Not DataGridView1.Rows.Count = 0 Then
            Process.Start(DataGridView1.Rows(0).Tag)
        Else
            Me.Visible = True
            Me.Opacity = 1
            Me.ShowInTaskbar = True
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        PollPosts()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class

Public Class JSON_result
    Public subject As String
    Public message As String
    Public username As String
    Public tid As String
End Class