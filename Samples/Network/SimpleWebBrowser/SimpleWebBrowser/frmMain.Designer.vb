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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.wbMain = New System.Windows.Forms.WebBrowser()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSettings = New System.Windows.Forms.ToolStripButton()
        Me.btnHome = New System.Windows.Forms.ToolStripButton()
        Me.btnBack = New System.Windows.Forms.ToolStripButton()
        Me.btnForward = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnGo = New System.Windows.Forms.ToolStripButton()
        Me.txtURL = New System.Windows.Forms.ToolStripTextBox()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnClear = New System.Windows.Forms.ToolStripButton()
        Me.lstBookMarks = New System.Windows.Forms.ListBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'wbMain
        '
        Me.wbMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wbMain.Location = New System.Drawing.Point(174, 28)
        Me.wbMain.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbMain.Name = "wbMain"
        Me.wbMain.Size = New System.Drawing.Size(960, 547)
        Me.wbMain.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSettings, Me.btnHome, Me.btnBack, Me.btnForward, Me.btnRefresh, Me.btnGo, Me.txtURL, Me.btnAdd, Me.btnDelete, Me.btnClear})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1146, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSettings
        '
        Me.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(53, 22)
        Me.btnSettings.Text = "Settings"
        '
        'btnHome
        '
        Me.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(44, 22)
        Me.btnHome.Text = "Home"
        '
        'btnBack
        '
        Me.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(36, 22)
        Me.btnBack.Text = "Back"
        '
        'btnForward
        '
        Me.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnForward.Image = CType(resources.GetObject("btnForward.Image"), System.Drawing.Image)
        Me.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(54, 22)
        Me.btnForward.Text = "Forward"
        '
        'btnRefresh
        '
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(50, 22)
        Me.btnRefresh.Text = "Refresh"
        '
        'btnGo
        '
        Me.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnGo.Image = CType(resources.GetObject("btnGo.Image"), System.Drawing.Image)
        Me.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(26, 22)
        Me.btnGo.Text = "Go"
        '
        'txtURL
        '
        Me.txtURL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(655, 25)
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(33, 22)
        Me.btnAdd.Text = "Add"
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(44, 22)
        Me.btnDelete.Text = "Delete"
        '
        'btnClear
        '
        Me.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(38, 22)
        Me.btnClear.Text = "Clear"
        '
        'lstBookMarks
        '
        Me.lstBookMarks.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstBookMarks.FormattingEnabled = True
        Me.lstBookMarks.Location = New System.Drawing.Point(0, 25)
        Me.lstBookMarks.Name = "lstBookMarks"
        Me.lstBookMarks.Size = New System.Drawing.Size(168, 550)
        Me.lstBookMarks.TabIndex = 10
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 575)
        Me.Controls.Add(Me.lstBookMarks)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.wbMain)
        Me.Name = "frmMain"
        Me.Text = "Simple WebBrowser"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents wbMain As WebBrowser
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnHome As ToolStripButton
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents btnSettings As ToolStripButton
    Friend WithEvents btnBack As ToolStripButton
    Friend WithEvents btnForward As ToolStripButton
    Friend WithEvents btnRefresh As ToolStripButton
    Friend WithEvents btnGo As ToolStripButton
    Friend WithEvents txtURL As ToolStripTextBox
    Friend WithEvents lstBookMarks As ListBox
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents btnClear As ToolStripButton
End Class
