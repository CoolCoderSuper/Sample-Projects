Imports System.IO

Public Class frmMain
    Private dtweb As DataTable

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        txtURL.Text = My.Computer.FileSystem.ReadAllText("C:\Users\User\Desktop\home page.txt")
        wbMain.Navigate(txtURL.Text)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtweb = New DataTable
        dtweb.Columns.Add("web", GetType(String))
        Using r As StreamReader = New StreamReader("C:\Users\User\Desktop\bookmarks.txt")
            Dim line As String
            line = r.ReadLine()
            If Not IsNothing(line) Then
                If line.Length > 0 Then
                    Dim dr As DataRow = dtweb.NewRow()
                    dr.Item("web") = line
                    dtweb.Rows.Add(dr)
                End If
            End If
            Do While (Not line Is Nothing)
                Console.WriteLine(line)
                line = r.ReadLine()
                If Not IsNothing(line) Then
                    If line.Length > 0 Then
                        Dim dr As DataRow = dtweb.NewRow()
                        dr.Item("web") = line
                        dtweb.Rows.Add(dr)
                    End If
                End If
            Loop
        End Using
        lstBookMarks.DataSource = dtweb
        lstBookMarks.DisplayMember = "web"
        lstBookMarks.ValueMember = "web"
        txtURL.Text = My.Computer.FileSystem.ReadAllText("C:\Users\User\Desktop\home page.txt")
        wbMain.Navigate(txtURL.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strNewBookMark As String = txtURL.Text
        For Each dr As DataRow In dtweb.Rows
            If dr(0) = strNewBookMark Then
                MessageBox.Show("This bookmark already exists and will Not be added")
                Exit Sub
            End If
        Next
        dtweb.Rows.Add(txtURL.Text)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\User\Desktop\bookmarks.txt", False)
        For Each dr As DataRow In dtweb.Rows
            file.WriteLine(dr(0))
        Next
        file.Close()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        wbMain.GoBack()
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        wbMain.GoForward()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        wbMain.Refresh()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        wbMain.Navigate(txtURL.Text)
    End Sub

    Private Sub lstBookMarks_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstBookMarks.SelectedValueChanged
        If Not IsNothing(lstBookMarks.SelectedValue) Then
            wbMain.Navigate(lstBookMarks.SelectedValue.ToString())
            txtURL.Text = lstBookMarks.SelectedValue.ToString()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dtweb.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        dtweb.Rows.RemoveAt(lstBookMarks.SelectedIndex)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\User\Desktop\bookmarks.txt", False)
        For Each dr As DataRow In dtweb.Rows
            file.WriteLine(dr(0))
        Next
        file.Close()
    End Sub

End Class