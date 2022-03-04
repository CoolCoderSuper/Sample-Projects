<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btnAddNewItem = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btndelete1 = New System.Windows.Forms.Button()
        Me.btndelete2 = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button40 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(93, 51)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(306, 40)
        Me.txtSearch.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(93, 96)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(306, 342)
        Me.ListBox1.TabIndex = 2
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(2, 51)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(87, 387)
        Me.TreeView1.TabIndex = 3
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(3, 5)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(87, 40)
        Me.btn1.TabIndex = 8
        Me.btn1.Text = "Add Node"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btnAddNewItem
        '
        Me.btnAddNewItem.Location = New System.Drawing.Point(405, 51)
        Me.btnAddNewItem.Name = "btnAddNewItem"
        Me.btnAddNewItem.Size = New System.Drawing.Size(150, 40)
        Me.btnAddNewItem.TabIndex = 9
        Me.btnAddNewItem.Text = "Add New"
        Me.btnAddNewItem.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(405, 97)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(150, 39)
        Me.txtName.TabIndex = 10
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(692, 356)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(96, 82)
        Me.btn3.TabIndex = 11
        Me.btn3.Text = "form2"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btndelete1
        '
        Me.btndelete1.Location = New System.Drawing.Point(405, 142)
        Me.btndelete1.Name = "btndelete1"
        Me.btndelete1.Size = New System.Drawing.Size(75, 69)
        Me.btndelete1.TabIndex = 12
        Me.btndelete1.Text = "Delete"
        Me.btndelete1.UseVisualStyleBackColor = True
        '
        'btndelete2
        '
        Me.btndelete2.Location = New System.Drawing.Point(95, 5)
        Me.btndelete2.Name = "btndelete2"
        Me.btndelete2.Size = New System.Drawing.Size(75, 40)
        Me.btndelete2.TabIndex = 13
        Me.btndelete2.Text = "delete t"
        Me.btndelete2.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(176, 12)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(268, 33)
        Me.lbl1.TabIndex = 14
        Me.lbl1.Text = "click to find number"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(713, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 63)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Crash"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(713, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 51)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "?"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button40
        '
        Me.Button40.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button40.Location = New System.Drawing.Point(405, 314)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(168, 124)
        Me.Button40.TabIndex = 63
        Me.Button40.Text = "Be Awesome"
        Me.Button40.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(713, 258)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 64
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button40)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btndelete2)
        Me.Controls.Add(Me.btndelete1)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnAddNewItem)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtSearch)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents btn1 As Button
    Friend WithEvents btnAddNewItem As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn3 As Button
    Friend WithEvents btndelete1 As Button
    Friend WithEvents btndelete2 As Button
    Friend WithEvents lbl1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button40 As Button
    Friend WithEvents Button3 As Button
End Class
