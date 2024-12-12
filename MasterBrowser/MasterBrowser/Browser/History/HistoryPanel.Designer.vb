<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistoryPanel))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.lvHistory = New System.Windows.Forms.ListView()
        Me.Time = New System.Windows.Forms.ColumnHeader()
        Me.URL = New System.Windows.Forms.ColumnHeader()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnClear = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.lvHistory)
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1129, 557)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1129, 582)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'lvHistory
        '
        Me.lvHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Time, Me.URL})
        Me.lvHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvHistory.FullRowSelect = True
        Me.lvHistory.GridLines = True
        Me.lvHistory.HideSelection = False
        Me.lvHistory.Location = New System.Drawing.Point(0, 0)
        Me.lvHistory.Name = "lvHistory"
        Me.lvHistory.Size = New System.Drawing.Size(1129, 557)
        Me.lvHistory.TabIndex = 0
        Me.lvHistory.UseCompatibleStateImageBehavior = False
        Me.lvHistory.View = System.Windows.Forms.View.Details
        '
        'Time
        '
        Me.Time.Text = "Time"
        Me.Time.Width = 150
        '
        'URL
        '
        Me.URL.Text = "URL"
        Me.URL.Width = 300
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnClear, Me.btnDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(94, 25)
        Me.ToolStrip1.TabIndex = 0
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
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(44, 22)
        Me.btnDelete.Text = "Delete"
        '
        'HistoryPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "HistoryPanel"
        Me.Size = New System.Drawing.Size(1129, 582)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnClear As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents lvHistory As ListView
    Friend WithEvents Time As ColumnHeader
    Friend WithEvents URL As ColumnHeader
End Class
