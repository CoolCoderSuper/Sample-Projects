Imports System.IO
Imports System.Net.Sockets

Public Class TCPSEND
    Public client As TcpClient
    Public datastream As StreamWriter

    'port = 64554
    Public Sub New(host As String, port As Integer)
        client = New TcpClient(host, port)
        datastream = New StreamWriter(client.GetStream())
    End Sub

    Public Sub send(data As String)
        datastream.Write(data & vbNewLine)
        datastream.Flush()
    End Sub

End Class