Imports System.Net

Public Class frmMain
    Private Sub btnPing_Click(sender As Object, e As EventArgs) Handles btnPing.Click
        If txtIp.Text.Trim().Length = 0 Then
            txtOutput.Text &= "Enter IP" & vbNewLine : Exit Sub
        End If
        If My.Computer.Network.IsAvailable = False Then
            txtOutput.Text &= "Connect to a network." & vbNewLine : Exit Sub
        End If
        Try
            If My.Computer.Network.Ping(txtIp.Text, 1000) Then
                Dim hostname As IPHostEntry = Dns.GetHostEntry(txtIp.Text)
                Dim ip As IPAddress() = hostname.AddressList
                txtIp.Text = ip(0).ToString()
                txtOutput.Text &= $"Reply from {txtIp.Text}{vbNewLine}"
            Else
                txtOutput.Text &= "Request timed out." & vbNewLine
            End If
        Catch ex As Exception
            If ex.InnerException.Message = "No such host is known" Then
                txtOutput.Text &= $"Could not find host {txtIp.Text}{vbNewLine}"
            End If
        End Try
    End Sub

    Private Sub txtIp_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIp.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnPing.PerformClick()
        End If
    End Sub
End Class
