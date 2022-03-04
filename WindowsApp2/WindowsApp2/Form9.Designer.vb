<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.lstmessages = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btncopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.btndelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtmessage = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnrecieve = New System.Windows.Forms.ToolStripButton()
        Me.btnsend = New System.Windows.Forms.ToolStripButton()
        Me.btnclear = New System.Windows.Forms.ToolStripButton()
        Me.btnclose = New System.Windows.Forms.ToolStripButton()
        Me.tmrgetmessage = New System.Windows.Forms.Timer(Me.components)
        Me.tmrstatus = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.prbstatus = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblmessagestatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstmessages
        '
        Me.lstmessages.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lstmessages.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstmessages.FormattingEnabled = True
        Me.lstmessages.Location = New System.Drawing.Point(12, 25)
        Me.lstmessages.MultiColumn = False
        Me.lstmessages.Name = "lstmessages"
        Me.lstmessages.Size = New System.Drawing.Size(582, 394)
        Me.lstmessages.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btncopy, Me.btndelete})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 48)
        '
        'btncopy
        '
        Me.btncopy.Name = "btncopy"
        Me.btncopy.Size = New System.Drawing.Size(107, 22)
        Me.btncopy.Text = "Copy"
        '
        'btndelete
        '
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(107, 22)
        Me.btndelete.Text = "Delete"
        '
        'txtmessage
        '
        Me.txtmessage.Location = New System.Drawing.Point(600, 25)
        Me.txtmessage.Multiline = True
        Me.txtmessage.Name = "txtmessage"
        Me.txtmessage.Size = New System.Drawing.Size(196, 400)
        Me.txtmessage.TabIndex = 5
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnrecieve, Me.btnsend, Me.btnclear, Me.btnclose})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnrecieve
        '
        Me.btnrecieve.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnrecieve.Image = CType(resources.GetObject("btnrecieve.Image"), System.Drawing.Image)
        Me.btnrecieve.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnrecieve.Name = "btnrecieve"
        Me.btnrecieve.Size = New System.Drawing.Size(51, 22)
        Me.btnrecieve.Text = "Recieve"
        '
        'btnsend
        '
        Me.btnsend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnsend.Image = CType(resources.GetObject("btnsend.Image"), System.Drawing.Image)
        Me.btnsend.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(37, 22)
        Me.btnsend.Text = "Send"
        '
        'btnclear
        '
        Me.btnclear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnclear.Image = CType(resources.GetObject("btnclear.Image"), System.Drawing.Image)
        Me.btnclear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(38, 22)
        Me.btnclear.Text = "Clear"
        '
        'btnclose
        '
        Me.btnclose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(40, 22)
        Me.btnclose.Text = "Close"
        '
        'tmrgetmessage
        '
        Me.tmrgetmessage.Interval = 1000
        '
        'tmrstatus
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.prbstatus, Me.lblmessagestatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'prbstatus
        '
        Me.prbstatus.Maximum = 1000
        Me.prbstatus.Name = "prbstatus"
        Me.prbstatus.Size = New System.Drawing.Size(200, 16)
        '
        'lblmessagestatus
        '
        Me.lblmessagestatus.Name = "lblmessagestatus"
        Me.lblmessagestatus.Size = New System.Drawing.Size(0, 17)
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtmessage)
        Me.Controls.Add(Me.lstmessages)
        Me.Name = "Form9"
        Me.Text = "Form9"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstmessages As ListBox
    Friend WithEvents txtmessage As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnrecieve As ToolStripButton
    Friend WithEvents btnsend As ToolStripButton
    Friend WithEvents btnclear As ToolStripButton
    Friend WithEvents btnclose As ToolStripButton
    Friend WithEvents tmrgetmessage As Timer
    Friend WithEvents tmrstatus As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents prbstatus As ToolStripProgressBar
    Friend WithEvents lblmessagestatus As ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btncopy As ToolStripMenuItem
    Friend WithEvents btndelete As ToolStripMenuItem
End Class
