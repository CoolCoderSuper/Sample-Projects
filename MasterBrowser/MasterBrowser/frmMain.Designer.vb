<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.mainStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnnewwindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnnewtab = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnopen = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnexit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnsettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnbookmarks = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnaddb = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnabout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.tbmain = New System.Windows.Forms.TabControl()
        Me.pageadd = New System.Windows.Forms.TabPage()
        Me.mainStrip.SuspendLayout()
        Me.tbmain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainStrip
        '
        Me.mainStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.btnsettings, Me.btn, Me.HelpToolStripMenuItem})
        Me.mainStrip.Location = New System.Drawing.Point(0, 0)
        Me.mainStrip.Name = "mainStrip"
        Me.mainStrip.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.mainStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mainStrip.Size = New System.Drawing.Size(1387, 24)
        Me.mainStrip.TabIndex = 0
        Me.mainStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnewwindow, Me.btnnewtab, Me.btnopen, Me.btnexit, Me.btnHistory})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'btnnewwindow
        '
        Me.btnnewwindow.Name = "btnnewwindow"
        Me.btnnewwindow.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.btnnewwindow.Size = New System.Drawing.Size(219, 22)
        Me.btnnewwindow.Text = "NewWindow"
        '
        'btnnewtab
        '
        Me.btnnewtab.Name = "btnnewtab"
        Me.btnnewtab.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.btnnewtab.Size = New System.Drawing.Size(219, 22)
        Me.btnnewtab.Text = "NewTab"
        '
        'btnopen
        '
        Me.btnopen.Name = "btnopen"
        Me.btnopen.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.btnopen.Size = New System.Drawing.Size(219, 22)
        Me.btnopen.Text = "Open"
        '
        'btnexit
        '
        Me.btnexit.Name = "btnexit"
        Me.btnexit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.btnexit.Size = New System.Drawing.Size(219, 22)
        Me.btnexit.Text = "Exit"
        '
        'btnHistory
        '
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(219, 22)
        Me.btnHistory.Text = "History"
        '
        'btnsettings
        '
        Me.btnsettings.Name = "btnsettings"
        Me.btnsettings.Size = New System.Drawing.Size(61, 20)
        Me.btnsettings.Text = "&Settings"
        '
        'btn
        '
        Me.btn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnbookmarks, Me.btnaddb})
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(78, 20)
        Me.btn.Text = "&Bookmarks"
        '
        'btnbookmarks
        '
        Me.btnbookmarks.Name = "btnbookmarks"
        Me.btnbookmarks.Size = New System.Drawing.Size(133, 22)
        Me.btnbookmarks.Text = "Bookmarks"
        '
        'btnaddb
        '
        Me.btnaddb.Name = "btnaddb"
        Me.btnaddb.Size = New System.Drawing.Size(133, 22)
        Me.btnaddb.Text = "Add"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnabout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'btnabout
        '
        Me.btnabout.Name = "btnabout"
        Me.btnabout.Size = New System.Drawing.Size(116, 22)
        Me.btnabout.Text = "&About..."
        '
        'lIcons
        '
        Me.lIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.lIcons.ImageSize = New System.Drawing.Size(16, 16)
        Me.lIcons.TransparentColor = System.Drawing.Color.Transparent
        '
        'tbmain
        '
        Me.tbmain.Controls.Add(Me.pageadd)
        Me.tbmain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbmain.HotTrack = True
        Me.tbmain.ImageList = Me.lIcons
        Me.tbmain.Location = New System.Drawing.Point(0, 24)
        Me.tbmain.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tbmain.Name = "tbmain"
        Me.tbmain.SelectedIndex = 0
        Me.tbmain.Size = New System.Drawing.Size(1387, 792)
        Me.tbmain.TabIndex = 1
        '
        'pageadd
        '
        Me.pageadd.Location = New System.Drawing.Point(4, 24)
        Me.pageadd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pageadd.Name = "pageadd"
        Me.pageadd.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pageadd.Size = New System.Drawing.Size(1379, 764)
        Me.pageadd.TabIndex = 1
        Me.pageadd.Text = "+"
        Me.pageadd.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1387, 816)
        Me.Controls.Add(Me.tbmain)
        Me.Controls.Add(Me.mainStrip)
        Me.MainMenuStrip = Me.mainStrip
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmMain"
        Me.Text = "MasterBrowser"
        Me.mainStrip.ResumeLayout(False)
        Me.mainStrip.PerformLayout()
        Me.tbmain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnnewwindow As ToolStripMenuItem
    Friend WithEvents btnnewtab As ToolStripMenuItem
    Friend WithEvents btnexit As ToolStripMenuItem
    Friend WithEvents btnsettings As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnabout As ToolStripMenuItem
    Friend WithEvents tbmain As TabControl
    Friend WithEvents btn As ToolStripMenuItem
    Friend WithEvents btnopen As ToolStripMenuItem
    Friend WithEvents btnbookmarks As ToolStripMenuItem
    Friend WithEvents btnaddb As ToolStripMenuItem
    Friend WithEvents pageadd As TabPage
    Friend WithEvents lIcons As System.Windows.Forms.ImageList
    Friend WithEvents btnHistory As ToolStripMenuItem

End Class
