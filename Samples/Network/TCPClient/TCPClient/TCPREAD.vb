Imports System.IO
Imports System.Net
Imports System.Threading

Public Class TCPREAD

    Public Event MessageRecieved(sender As TCPREAD, data As String)

    Public serverip As IPAddress = IPAddress.Parse("192.168.11.105")
    Public port As Integer = 64554
    Public server As Net.Sockets.TcpListener
    Private commthread As Thread
    Public islistening As Boolean = True
    Private client As Net.Sockets.TcpClient
    Private clientdata As StreamReader

    Public Sub New()
        server = New Net.Sockets.TcpListener(serverip, port)
        server.Start()
        commthread = New Thread(New ThreadStart(AddressOf listening))
        commthread.Start()
    End Sub

    Private Sub listening()
        Do Until islistening = False
            If server.Pending() Then
                client = server.AcceptTcpClient()
                clientdata = New StreamReader(client.GetStream())
            End If
            Try
                RaiseEvent MessageRecieved(Me, clientdata.ReadLine())
            Catch ex As Exception

            End Try
            Thread.Sleep(100)
        Loop
    End Sub

End Class