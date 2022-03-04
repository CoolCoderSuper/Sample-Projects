Imports System.IO

Public Class TCPSEND
    Public client As Net.Sockets.TcpClient
    Public datastream As StreamWriter

    'port = 64555
    Public Sub New(host As String, port As Integer)
        client = New Net.Sockets.TcpClient(host, port)
        datastream = New StreamWriter(client.GetStream())
    End Sub

    Public Sub send(data As String)
        datastream.Write(data & vbNewLine)
        datastream.Flush()
    End Sub

End Class