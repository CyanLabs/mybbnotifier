Imports Newtonsoft.Json
Imports System.Net

Public Class Form1
    Dim wc As New WebClient, obj As IList, json As String = ""
    Dim DoClose As Boolean = False, oldcount As Integer = 999999999
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = numInterval.Value * 1000
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
            json = wc.DownloadString(My.Settings.ScriptURL & "?apikey=" & My.Settings.APIKey)
        Catch ex As Exception
            ntfyIcon.ShowBalloonTip(5000, "MyBB Notifier - Error", ex.Message, ToolTipIcon.Error)
            Timer1.Stop()
        End Try
        If json = "Invalid API Key" Or json = "No API Key" Then
            ntfyIcon.ShowBalloonTip(5000, "MyBB Notifier - Error", "Missing or Invalid API Key", ToolTipIcon.Error)
            Timer1.Stop()
            Exit Sub
        ElseIf json = "Please change your API key at the top of this script before use" Then
            ntfyIcon.ShowBalloonTip(5000, "MyBB Notifier - Error", json, ToolTipIcon.Error)
            Timer1.Stop()
            Exit Sub
        End If
        Try
            obj = JsonConvert.DeserializeObject(Of List(Of JSON_result))(json)

            DataGridView1.Rows.Clear()
            For Each item In obj
                DataGridView1.Rows.Add(New String() {item.subject, item.message, item.username})
            Next

            If Not oldcount = obj.Count Then
                If obj.Count = 1 Then
                    ntfyIcon.ShowBalloonTip(5000, "MyBB Notifier - New Posts", "There is " & obj.Count & " new post since your last visit", ToolTipIcon.Info)
                Else
                    ntfyIcon.ShowBalloonTip(5000, "MyBB Notifier - New Posts", "There are " & obj.Count & " new posts since your last visit", ToolTipIcon.Info)
                End If
            End If
            oldcount = obj.Count
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ntfyIcon_DoubleClick(sender As Object, e As EventArgs) Handles ntfyIcon.DoubleClick, ShowToolStripMenuItem.Click
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

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        DoClose = True
        Application.Exit()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        PollPosts()
    End Sub

    Private Sub lblMyBB_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblMyBB.LinkClicked
        Process.Start("http://mybb.com")
    End Sub

    Private Sub lblCyan_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCyan.LinkClicked
        Process.Start("http://cyanlabs.net")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        My.Settings.Save()
        ntfyIcon.ShowBalloonTip(5000, "MyBB Notifier - Settings Saved", "Your settings have been updated" & vbNewLine & "now polling " & My.Settings.ScriptURL & vbNewLine & "with " & My.Settings.APIKey & " as API Key", ToolTipIcon.Info)
        PollPosts()
    End Sub
End Class

Public Class JSON_result
    Public subject As String
    Public message As String
    Public username As String
End Class