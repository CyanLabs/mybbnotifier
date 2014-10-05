Public Class Settings

    Private Sub chkStartup_CheckedChanged(sender As Object, e As EventArgs) Handles chkStartup.CheckedChanged
        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
        If chkStartup.Checked = True Then
            regKey.SetValue("MyBB Notifier", Application.ExecutablePath)
        Else
            regKey.DeleteValue("MyBB Notifier", False)
        End If
        regKey.Close()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersion.Text = "Version " & System.Reflection.Assembly.GetEntryAssembly.GetName().Version.ToString
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.Save()
        Form1.Timer1.Start()
        Form1.Timer1.Interval = numInterval.Value * 1000
        Form1.ntfyIcon.ShowBalloonTip(5000, "MyBB Notifier", "Settings Saved!", ToolTipIcon.Info)
    End Sub

    Private Sub lblMyBB_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblMyBB.LinkClicked
        Process.Start("http://mybb.com")
    End Sub

    Private Sub lblCyan_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCyan.LinkClicked
        Process.Start("http://cyanlabs.net")
    End Sub
End Class