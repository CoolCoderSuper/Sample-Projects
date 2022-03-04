Imports System.IO


Public Class Form1
    Private dtapps As DataTable
    Dim bisdoubleclick As Boolean
    Dim w As IO.StreamWriter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadListBox()
        LoadTreeView()
    End Sub
    Private Sub LoadListBox()


        dtapps = New DataTable()
        dtapps.Columns.Add("apps", GetType(String))
        'dtapps.Rows.Add("Roblox")
        'dtapps.Rows.Add("Minesweeper")
        'dtapps.Rows.Add("Ebay")
        'dtapps.Rows.Add("Kindle")
        'dtapps.Rows.Add("Township")
        'dtapps.Rows.Add("Visual Studios 2017")
        'dtapps.Rows.Add("Skype")
        'dtapps.Rows.Add("Thunderbird")
        'dtapps.Rows.Add("Hill Climb Racing2")



        Using r As StreamReader = New StreamReader("C:\Users\Joseph\Desktop\Apps.txt")
            ' Store contents in this String.
            Dim line As String

            ' Read first line.
            line = r.ReadLine
            If Not IsNothing(line) Then
                If line.Length > 0 Then
                    Dim dr As DataRow = dtapps.NewRow
                    dr.Item("apps") = line

                    dtapps.Rows.Add(dr)
                End If
            End If

            ' Loop over each line in file, While list is Not Nothing.
            Do While (Not line Is Nothing)
                ' Add this line to list.

                'List.Add(line)
                ' Display to console.
                Console.WriteLine(line)
                ' Read in the next line.
                line = r.ReadLine
                If Not IsNothing(line) Then
                    If line.Length > 0 Then
                        Dim dr As DataRow = dtapps.NewRow
                        dr.Item("apps") = line

                        dtapps.Rows.Add(dr)
                    End If
                End If
            Loop
        End Using


        ListBox1.DataSource = dtapps
        ListBox1.DisplayMember = "apps"

        'Using r As StreamReader = New StreamReader("C:\Users\Joseph\Desktop\Apps.txt")
        '    'Store contents in this String.
        '    Dim line As String

        '    'Read first line.
        '    line = r.ReadLine
        '    If Not IsNothing(line) Then
        '        If line.Length > 0 Then
        '            ListBox1.Items.Add(line)
        '        End If
        '    End If
        '    ' Loop over each line in file, While list is Not Nothing.
        '    Do While (Not line Is Nothing)
        '        ' Add this line to list.
        '        'List.Add(line)
        '        ' Display to console.
        '        Console.WriteLine(line)
        '        ' Read in the next line.
        '        line = r.ReadLine
        '        If Not IsNothing(line) Then
        '            If line.Length > 0 Then
        '                ListBox1.Items.Add(line)
        '            End If
        '        End If
        '    Loop
        'End Using

    End Sub
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete1.Click
        'ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        dtapps.Rows.RemoveAt(ListBox1.SelectedIndex)

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Joseph\Desktop\Apps.txt", False)
        For Each dr As DataRow In dtapps.Rows
            file.WriteLine(dr(0))
        Next
        'For i = 0 To ListBox1.Items.Count - 1
        '    file.WriteLine(ListBox1.Items(i))
        'Next
        file.Close()
    End Sub

    Private Sub btnAddNewItem_Click(sender As Object, e As EventArgs) Handles btnAddNewItem.Click
        'ListBox1.Items.Add(txtName.Text)
        dtapps.Rows.Add(txtName.Text)

        'ListBox1.DataSource = dtapps
        'w = New IO.StreamWriter("C:\Users\Joseph\Desktop\Apps.txt")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Joseph\Desktop\Apps.txt", False)
        For Each dr As DataRow In dtapps.Rows
            file.WriteLine(dr(0))
        Next
        'For i = 0 To ListBox1.Items.Count - 1
        '    file.WriteLine(ListBox1.Items(i))
        'Next
        file.Close()


    End Sub
    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'For x As Integer = 0 To ListBox1.Items.Count - 1
        '    If ListBox1.Items(x).ToString = txtSearch.Text$ Then
        '        ListBox1.SelectedIndex = x
        '        Return
        '    End If
        'Next
        Dim dvapps As New DataView
        dvapps = dtapps.DefaultView
        dvapps.RowFilter = "apps like'%" + txtSearch.Text + "%'"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim N As String
        N = InputBox("enter node name")

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Joseph\Desktop\Nodes.txt", False)
        For Each tmpNode As TreeNode In TreeView1.Nodes
            file.WriteLine(tmpNode.Text)
        Next
        file.Close()
        If TreeView1.SelectedNode Is Nothing Then
            TreeView1.Nodes.Add(N, N)
        Else
            TreeView1.SelectedNode.Nodes.Add(N, N)
        End If


        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Joseph\Desktop\Nodes.txt", False)
        For Each tmpNode As TreeNode In TreeView1.Nodes
            file.WriteLine(tmpNode.Name)
        Next
        file.Close()

    End Sub
    Private Sub LoadTreeView()

        'TreeView1.Nodes.Add("Roblox", "Roblox")
        'TreeView1.Nodes.Add("Minesweeper", "Minesweeper")
        'TreeView1.Nodes.Add("Kindle", "Kindle")
        'TreeView1.Nodes.Add("Township", "Township")
        'TreeView1.Nodes.Add("Visual Studios 2017", "Visual Studios 2017")
        'TreeView1.Nodes.Add("Skype", "Skype")
        'TreeView1.Nodes.Add("Thunderbird", "Thunderbird")
        'TreeView1.Nodes.Add("Hill Climb Racing2", "Hill Climb Racing2")


        Using r As StreamReader = New StreamReader("C:\Users\Joseph\Desktop\Nodes.txt")
            ' Store contents in this String.
            Dim line As String

            ' Read first line.
            line = r.ReadLine
            If Not IsNothing(line) Then
                If line.Length > 0 Then
                    TreeView1.Nodes.Add(line)
                End If
            End If
            ' Loop over each line in file, While list is Not Nothing.
            Do While (Not line Is Nothing)
                ' Add this line to list.

                'List.Add(line)
                ' Display to console.
                Console.WriteLine(line)
                ' Read in the next line.
                line = r.ReadLine
                If Not IsNothing(line) Then
                    If line.Length > 0 Then
                        TreeView1.Nodes.Add(line)
                    End If
                End If
            Loop
        End Using

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If bisdoubleclick Then
            MessageBox.Show(e.Node.Name)
            bisdoubleclick = False
        End If
    End Sub



    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged


    End Sub



    Private Sub ListBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedValueChanged

    End Sub

    'Private Sub ListBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDown
    '    If Not IsNothing(ListBox1.SelectedItem) Then
    '        If ListBox1.SelectedItem.ToString().Length > 0 Then
    '            MessageBox.Show(ListBox1.SelectedItem(0).ToString)
    '        End If
    '    End If
    'End Sub



    Private Sub TreeView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TreeView1.MouseDoubleClick
        'If bisdoubleclick = True Then
        MessageBox.Show(TreeView1.SelectedNode.Name.ToString)

        'End If
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        MessageBox.Show(ListBox1.SelectedItem(0).ToString)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Form2.Show()
    End Sub



    Private Sub btndelete2_Click(sender As Object, e As EventArgs) Handles btndelete2.Click
        If Not TreeView1.SelectedNode.Text = "Some App" Then
            TreeView1.Nodes.Remove(TreeView1.SelectedNode)

            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\Joseph\Desktop\Nodes.txt", False)
            For Each tmpNode As TreeNode In TreeView1.Nodes
                file.WriteLine(tmpNode.Text)
            Next
            file.Close()
        Else
            MessageBox.Show("You may not delete the selected entry, now get to work!")
        End If
    End Sub

    Private Sub lbl1_Click(sender As Object, e As EventArgs) Handles lbl1.Click
        lbl1.Text = TreeView1.Nodes.Count
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Form4.ShowDialog = DialogResult.Cancel Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As String
        x = InputBox("enter password")
        If x = "Newyears18" Then
            Form7.AxWindowsMediaPlayer1.URL = "C:\Users\Joseph\Music\Youtube\.mp3\Funny Male Crying Sound in High QUality.mp3"
            Form7.ShowDialog()
            MessageBox.Show("😯😪😓")
            Me.Dispose()
            Form11.Dispose()
        Else
            Form7.AxWindowsMediaPlayer1.URL = "C:\Users\Joseph\Music\Youtube\.mp3\Funny Laugh SOUND EFFECT.mp3"
            Form7.ShowDialog()
            MessageBox.Show("😜🤣")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form10.Show()
        ' Form6.Button4.Enabled
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Form6.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim r As String
        r = InputBox("enter password")
        If r = "Newyears18" Then
            Form9.Show()
        End If
    End Sub

    'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
    '    ListBox1.Text = TextBox1.Text
    'End Sub


End Class



