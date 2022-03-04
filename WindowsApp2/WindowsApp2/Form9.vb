Imports System.IO
Imports Tulpep.NotificationWindow
Public Class Form9
    Private dtmessage As DataTable
    Dim w As StreamWriter

    Private Sub messageloader()
        dtmessage = New DataTable()
        dtmessage.Columns.Add("message", GetType(String))
        Using r As StreamReader = New StreamReader("C:\Users\Joseph\Desktop\Messages.txt")
            Dim line As String
            line = r.ReadLine
            If Not IsNothing(line) Then
                If line.Length > 0 Then
                    Dim dr As DataRow = dtmessage.NewRow
                    dr.Item("message") = line
                    dtmessage.Rows.Add(dr)
                End If
            End If
            Do While (Not line Is Nothing)
                Console.WriteLine(line)
                line = r.ReadLine
                If Not IsNothing(line) Then
                    If line.Length > 0 Then
                        Dim dr As DataRow = dtmessage.NewRow
                        dr.Item("message") = line
                        dtmessage.Rows.Add(dr)
                    End If
                End If
            Loop
        End Using
        '***************************************************************************************
        dtmessage.Columns.Add("date", GetType(String))
        Using r As StreamReader = New StreamReader("C:\Users\Joseph\Desktop\Mdate.txt")
            Dim line As String
            line = r.ReadLine
            If Not IsNothing(line) Then
                If line.Length > 0 Then
                    Dim dr As DataRow = dtmessage.NewRow
                    dr.Item("date") = line
                    dtmessage.Rows.Add(dr)
                End If
            End If
            Do While (Not line Is Nothing)
                Console.WriteLine(line)
                line = r.ReadLine
                If Not IsNothing(line) Then
                    If line.Length > 0 Then
                        Dim dr As DataRow = dtmessage.NewRow
                        dr.Item("date") = line
                        dtmessage.Rows.Add(dr)
                    End If
                End If
            Loop
        End Using
        lstmessages.DataSource = dtmessage
        lstmessages.DisplayMember = "message"
    End Sub

    Private Sub messagesender()
        dtmessage.Rows.Add("Bob:" & txtmessage.Text)
        Dim file As StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Joseph\Desktop\Messages.txt", False)
        For Each dr As DataRow In dtmessage.Rows
            file.WriteLine(dr(0))
        Next
        file.Close()
        showmessagepopup()
        messageloader()
        txtmessage.Text = ""
    End Sub

    Private Sub showmessagepopup()
        Dim messagepopup As New PopupNotifier
        messagepopup.TitleText = "Message"
        messagepopup.ContentText = txtmessage.Text
        messagepopup.Popup()
    End Sub

    Private Sub btnrecieve_Click(sender As Object, e As EventArgs) Handles btnrecieve.Click
        messageloader()
    End Sub

    Private Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnsend.Click
        tmrstatus.Start()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtmessage.Text = ""
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Close()
    End Sub

    Private Sub tmrgetmessage_Tick(sender As Object, e As EventArgs) Handles tmrgetmessage.Tick
        messageloader()
    End Sub

    Private Sub tmrstatus_Tick(sender As Object, e As EventArgs) Handles tmrstatus.Tick
        If txtmessage.Text.Trim.Length = 0 Then lblmessagestatus.Text = "Could Not send value: NULL" : tmrstatus.Stop() : Exit Sub
        prbstatus.Increment(10)
        lblmessagestatus.Text = "Sending…"
        If prbstatus.Value = prbstatus.Maximum Then
            tmrstatus.Stop()
            messagesender()
            lblmessagestatus.Text = "Sent Successfully"
            prbstatus.Value = 0
        End If
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrgetmessage.Start()
    End Sub

    End Class