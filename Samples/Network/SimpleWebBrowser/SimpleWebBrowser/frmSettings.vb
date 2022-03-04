Public Class frmSettings
    Private dtweb As DataTable
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\User\Desktop\home page.txt", False)
        file.WriteLine(txtHomePage.Text)
        file.Close()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtHomePage.Text = My.Computer.FileSystem.ReadAllText("C:\Users\User\Desktop\home page.txt")
        dtweb = New DataTable
        dtweb.Columns.Add("web", GetType(String))
        dtweb.Rows.Add("bing.com")
        dtweb.Rows.Add("google.com")
        dtweb.Rows.Add("ecosia.com")
        dtweb.Rows.Add("duckduckgo.com")
        lstPages.DataSource = dtweb
        lstPages.DisplayMember = "web"
        lstPages.ValueMember = "web"
    End Sub

    Private Sub lstPages_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstPages.SelectedValueChanged
        Try
            txtHomePage.Text = lstPages.SelectedValue
        Catch ex As Exception

        End Try
    End Sub
End Class
