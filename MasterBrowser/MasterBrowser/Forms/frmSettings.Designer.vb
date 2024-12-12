<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxpage = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.txtpath = New System.Windows.Forms.TextBox()
        Me.rdpath = New System.Windows.Forms.RadioButton()
        Me.rdaskme = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lstpages = New System.Windows.Forms.ListBox()
        Me.rdset = New System.Windows.Forms.RadioButton()
        Me.rdleftof = New System.Windows.Forms.RadioButton()
        Me.rdnewtab = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rddark = New System.Windows.Forms.RadioButton()
        Me.rdnorm = New System.Windows.Forms.RadioButton()
        Me.rdlight = New System.Windows.Forms.RadioButton()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxpage)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HomePage"
        '
        'cbxpage
        '
        Me.cbxpage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxpage.FormattingEnabled = True
        Me.cbxpage.Items.AddRange(New Object() {"Google", "Bing", "MSN", "DuckDuckGo", "Ecosia", "Yahoo"})
        Me.cbxpage.Location = New System.Drawing.Point(7, 20)
        Me.cbxpage.Name = "cbxpage"
        Me.cbxpage.Size = New System.Drawing.Size(302, 21)
        Me.cbxpage.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnbrowse)
        Me.GroupBox2.Controls.Add(Me.txtpath)
        Me.GroupBox2.Controls.Add(Me.rdpath)
        Me.GroupBox2.Controls.Add(Me.rdaskme)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 71)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Downloads"
        '
        'btnbrowse
        '
        Me.btnbrowse.Location = New System.Drawing.Point(283, 41)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(26, 23)
        Me.btnbrowse.TabIndex = 3
        Me.btnbrowse.Text = "..."
        Me.btnbrowse.UseVisualStyleBackColor = True
        '
        'txtpath
        '
        Me.txtpath.Location = New System.Drawing.Point(103, 43)
        Me.txtpath.Name = "txtpath"
        Me.txtpath.ReadOnly = True
        Me.txtpath.Size = New System.Drawing.Size(174, 20)
        Me.txtpath.TabIndex = 2
        '
        'rdpath
        '
        Me.rdpath.AutoSize = True
        Me.rdpath.Location = New System.Drawing.Point(7, 42)
        Me.rdpath.Name = "rdpath"
        Me.rdpath.Size = New System.Drawing.Size(90, 17)
        Me.rdpath.TabIndex = 1
        Me.rdpath.Text = "Use this path:"
        Me.rdpath.UseVisualStyleBackColor = True
        '
        'rdaskme
        '
        Me.rdaskme.AutoSize = True
        Me.rdaskme.Checked = True
        Me.rdaskme.Location = New System.Drawing.Point(7, 19)
        Me.rdaskme.Name = "rdaskme"
        Me.rdaskme.Size = New System.Drawing.Size(114, 17)
        Me.rdaskme.TabIndex = 0
        Me.rdaskme.TabStop = True
        Me.rdaskme.Text = "Always ask me first"
        Me.rdaskme.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnremove)
        Me.GroupBox3.Controls.Add(Me.btnadd)
        Me.GroupBox3.Controls.Add(Me.lstpages)
        Me.GroupBox3.Controls.Add(Me.rdset)
        Me.GroupBox3.Controls.Add(Me.rdleftof)
        Me.GroupBox3.Controls.Add(Me.rdnewtab)
        Me.GroupBox3.Location = New System.Drawing.Point(354, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(174, 236)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "StartUp"
        '
        'btnremove
        '
        Me.btnremove.Location = New System.Drawing.Point(67, 89)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(55, 23)
        Me.btnremove.TabIndex = 5
        Me.btnremove.Text = "Remove"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(6, 89)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(55, 23)
        Me.btnadd.TabIndex = 4
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'lstpages
        '
        Me.lstpages.FormattingEnabled = True
        Me.lstpages.Location = New System.Drawing.Point(6, 122)
        Me.lstpages.Name = "lstpages"
        Me.lstpages.Size = New System.Drawing.Size(156, 108)
        Me.lstpages.TabIndex = 3
        '
        'rdset
        '
        Me.rdset.AutoSize = True
        Me.rdset.Enabled = False
        Me.rdset.Location = New System.Drawing.Point(6, 65)
        Me.rdset.Name = "rdset"
        Me.rdset.Size = New System.Drawing.Size(156, 17)
        Me.rdset.TabIndex = 2
        Me.rdset.TabStop = True
        Me.rdset.Text = "Open a certain set of pages"
        Me.rdset.UseVisualStyleBackColor = True
        '
        'rdleftof
        '
        Me.rdleftof.AutoSize = True
        Me.rdleftof.Enabled = False
        Me.rdleftof.Location = New System.Drawing.Point(6, 42)
        Me.rdleftof.Name = "rdleftof"
        Me.rdleftof.Size = New System.Drawing.Size(151, 17)
        Me.rdleftof.TabIndex = 1
        Me.rdleftof.TabStop = True
        Me.rdleftof.Text = "Continue where you left off"
        Me.rdleftof.UseVisualStyleBackColor = True
        '
        'rdnewtab
        '
        Me.rdnewtab.AutoSize = True
        Me.rdnewtab.Location = New System.Drawing.Point(6, 19)
        Me.rdnewtab.Name = "rdnewtab"
        Me.rdnewtab.Size = New System.Drawing.Size(104, 17)
        Me.rdnewtab.TabIndex = 0
        Me.rdnewtab.TabStop = True
        Me.rdnewtab.Text = "Open a NewTab"
        Me.rdnewtab.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rddark)
        Me.GroupBox4.Controls.Add(Me.rdnorm)
        Me.GroupBox4.Controls.Add(Me.rdlight)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 160)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(321, 89)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Theme"
        '
        'rddark
        '
        Me.rddark.AutoSize = True
        Me.rddark.Location = New System.Drawing.Point(7, 65)
        Me.rddark.Name = "rddark"
        Me.rddark.Size = New System.Drawing.Size(48, 17)
        Me.rddark.TabIndex = 2
        Me.rddark.Text = "Dark"
        Me.rddark.UseVisualStyleBackColor = True
        '
        'rdnorm
        '
        Me.rdnorm.AutoSize = True
        Me.rdnorm.Checked = True
        Me.rdnorm.Location = New System.Drawing.Point(7, 42)
        Me.rdnorm.Name = "rdnorm"
        Me.rdnorm.Size = New System.Drawing.Size(58, 17)
        Me.rdnorm.TabIndex = 1
        Me.rdnorm.TabStop = True
        Me.rdnorm.Text = "Normal"
        Me.rdnorm.UseVisualStyleBackColor = True
        '
        'rdlight
        '
        Me.rdlight.AutoSize = True
        Me.rdlight.Location = New System.Drawing.Point(7, 19)
        Me.rdlight.Name = "rdlight"
        Me.rdlight.Size = New System.Drawing.Size(48, 17)
        Me.rdlight.TabIndex = 0
        Me.rdlight.Text = "Light"
        Me.rdlight.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(13, 255)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(515, 23)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 286)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxpage As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnbrowse As Button
    Friend WithEvents txtpath As TextBox
    Friend WithEvents rdpath As RadioButton
    Friend WithEvents rdaskme As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnsave As Button
    Friend WithEvents rddark As RadioButton
    Friend WithEvents rdnorm As RadioButton
    Friend WithEvents rdlight As RadioButton
    Friend WithEvents btnremove As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents lstpages As ListBox
    Friend WithEvents rdset As RadioButton
    Friend WithEvents rdleftof As RadioButton
    Friend WithEvents rdnewtab As RadioButton
End Class
