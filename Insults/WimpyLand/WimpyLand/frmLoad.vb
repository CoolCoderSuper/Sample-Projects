Imports System.ComponentModel

Public Class frmLoad
    Public bClicked As Boolean = False
    Private intLevel As Integer = 0

    Private Sub frmLoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intLevel = 0
        tmrLoad.Start()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        bClicked = True
        Close()
    End Sub

    Private Sub tmrLoad_Tick(sender As Object, e As EventArgs) Handles tmrLoad.Tick
        If intLevel = 0 Then
            lblStatus.Text = "Retreiving past..."
        ElseIf intLevel = 4 Then
            lblStatus.Text = "Finding wimpy times..."
        ElseIf intLevel = 8 Then
            lblStatus.Text = "Applying formula..."
        ElseIf intLevel = 10 Then
            lblStatus.Text = "Verifying results..."
        ElseIf intLevel = 12 Then
            lblStatus.Text = "Finishing up..."
        ElseIf intLevel = 13 Then
            Close()
        End If
        intLevel += 1
    End Sub

    Private Sub frmLoad_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If bClicked = True Then
            frmMain.txtName.ReadOnly = False
        ElseIf bClicked = False Then
            frmMain.max = 100
            frmMain.min = 1
            frmMain.txtLevel.Text = (Int((frmMain.max - frmMain.min + 1) * Rnd() + frmMain.min))
            frmMain.txtName.ReadOnly = False
        End If
    End Sub

End Class