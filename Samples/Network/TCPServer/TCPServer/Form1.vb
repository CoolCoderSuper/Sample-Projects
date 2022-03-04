Imports System.ComponentModel
Imports System.IO
Public Class Form1
    Private WithEvents server As TCPREAD
    Private client As TCPSEND

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        server = New TCPREAD
        txtchat.Text = ":: SERVER STARTED ::" & vbNewLine
    End Sub

    Private Delegate Sub UpDateTextDelegate(TB As TextBox, txt As String)

    Private Sub UpdateText(TB As TextBox, txt As String)
        If TB.InvokeRequired Then
            TB.Invoke(New UpDateTextDelegate(AddressOf UpdateText), New Object() {TB, txt})
        Else
            If txt IsNot Nothing Then TB.AppendText(txt & vbNewLine)
        End If
    End Sub

    Private Sub server_MessageRecieved(sender As TCPREAD, data As String) Handles server.MessageRecieved
        UpdateText(txtchat, data)
    End Sub

    Private Sub Form11_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        server.islistening = False
    End Sub


    Private Sub btnconnect_Click(sender As Object, e As EventArgs) Handles btnconnect.Click
        client = New TCPSEND("192.168.11.110", 64554)
        If client.client.Connected Then btnconnect.Text = "Connected"
    End Sub

    Private Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnsend.Click
        send()
        txtmessage.Clear()
        txtmessage.Focus()
    End Sub

    Private Sub send()
        If client.client.Connected Then client.send("Me: " & txtmessage.Text)
        txtchat.Text &= "Me: " & txtmessage.Text & vbNewLine
    End Sub

    Private Sub txtmessage_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmessage.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsend.PerformClick()
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If client.client.Connected Then client.datastream.Close() : client.client.Close()
        File.WriteAllText("C:\programdata\codingcool\chat\c1.txt", txtchat.Text.Replace("::SERVER STARTED::", String.Empty))
    End Sub

End Class