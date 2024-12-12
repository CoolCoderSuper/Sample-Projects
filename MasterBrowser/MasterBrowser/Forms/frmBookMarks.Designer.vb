<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookMarks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btngo = New System.Windows.Forms.Button()
        Me.lstbookmarks = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(378, 12)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 13
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(297, 69)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 12
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnremove
        '
        Me.btnremove.Location = New System.Drawing.Point(297, 40)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(75, 23)
        Me.btnremove.TabIndex = 11
        Me.btnremove.Text = "Remove"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'btngo
        '
        Me.btngo.Location = New System.Drawing.Point(297, 11)
        Me.btngo.Name = "btngo"
        Me.btngo.Size = New System.Drawing.Size(75, 23)
        Me.btngo.TabIndex = 10
        Me.btngo.Text = "Go"
        Me.btngo.UseVisualStyleBackColor = True
        '
        'lstbookmarks
        '
        Me.lstbookmarks.FormattingEnabled = True
        Me.lstbookmarks.Location = New System.Drawing.Point(12, 12)
        Me.lstbookmarks.Name = "lstbookmarks"
        Me.lstbookmarks.Size = New System.Drawing.Size(279, 420)
        Me.lstbookmarks.TabIndex = 9
        '
        'frmBookMarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 438)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnremove)
        Me.Controls.Add(Me.btngo)
        Me.Controls.Add(Me.lstbookmarks)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBookMarks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bookmarks"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnclose As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnremove As Button
    Friend WithEvents btngo As Button
    Friend WithEvents lstbookmarks As ListBox
End Class
