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
        Me.pbDraw = New System.Windows.Forms.PictureBox()
        Me.txtSize = New System.Windows.Forms.DomainUpDown()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnColour = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEraser = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnFill = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBrushStyles = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pbDraw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbDraw
        '
        Me.pbDraw.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbDraw.BackColor = System.Drawing.Color.White
        Me.pbDraw.Cursor = System.Windows.Forms.Cursors.Cross
        Me.pbDraw.Location = New System.Drawing.Point(13, 53)
        Me.pbDraw.Name = "pbDraw"
        Me.pbDraw.Size = New System.Drawing.Size(1101, 673)
        Me.pbDraw.TabIndex = 0
        Me.pbDraw.TabStop = False
        '
        'txtSize
        '
        Me.txtSize.Items.Add("2")
        Me.txtSize.Items.Add("4")
        Me.txtSize.Items.Add("6")
        Me.txtSize.Items.Add("8")
        Me.txtSize.Items.Add("10")
        Me.txtSize.Items.Add("12")
        Me.txtSize.Items.Add("14")
        Me.txtSize.Items.Add("16")
        Me.txtSize.Items.Add("18")
        Me.txtSize.Items.Add("20")
        Me.txtSize.Items.Add("22")
        Me.txtSize.Items.Add("23")
        Me.txtSize.Items.Add("24")
        Me.txtSize.Items.Add("26")
        Me.txtSize.Items.Add("28")
        Me.txtSize.Items.Add("30")
        Me.txtSize.Items.Add("32")
        Me.txtSize.Items.Add("34")
        Me.txtSize.Items.Add("36")
        Me.txtSize.Items.Add("38")
        Me.txtSize.Items.Add("40")
        Me.txtSize.Items.Add("42")
        Me.txtSize.Items.Add("44")
        Me.txtSize.Items.Add("46")
        Me.txtSize.Items.Add("48")
        Me.txtSize.Items.Add("50")
        Me.txtSize.Items.Add("52")
        Me.txtSize.Items.Add("54")
        Me.txtSize.Items.Add("56")
        Me.txtSize.Items.Add("58")
        Me.txtSize.Items.Add("60")
        Me.txtSize.Items.Add("62")
        Me.txtSize.Items.Add("64")
        Me.txtSize.Items.Add("66")
        Me.txtSize.Items.Add("68")
        Me.txtSize.Items.Add("70")
        Me.txtSize.Items.Add("72")
        Me.txtSize.Items.Add("74")
        Me.txtSize.Items.Add("76")
        Me.txtSize.Items.Add("78")
        Me.txtSize.Items.Add("80")
        Me.txtSize.Items.Add("1000")
        Me.txtSize.Location = New System.Drawing.Point(12, 27)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.ReadOnly = True
        Me.txtSize.Size = New System.Drawing.Size(120, 20)
        Me.txtSize.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnColour, Me.btnEraser, Me.btnFill, Me.btnClear, Me.btnBrushStyles, Me.btnSave})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1126, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnColour
        '
        Me.btnColour.Name = "btnColour"
        Me.btnColour.Size = New System.Drawing.Size(55, 20)
        Me.btnColour.Text = "Colour"
        '
        'btnEraser
        '
        Me.btnEraser.Name = "btnEraser"
        Me.btnEraser.Size = New System.Drawing.Size(50, 20)
        Me.btnEraser.Text = "Eraser"
        '
        'btnFill
        '
        Me.btnFill.Name = "btnFill"
        Me.btnFill.Size = New System.Drawing.Size(34, 20)
        Me.btnFill.Text = "Fill"
        '
        'btnClear
        '
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(46, 20)
        Me.btnClear.Text = "Clear"
        '
        'btnBrushStyles
        '
        Me.btnBrushStyles.Name = "btnBrushStyles"
        Me.btnBrushStyles.Size = New System.Drawing.Size(79, 20)
        Me.btnBrushStyles.Text = "BrushStyles"
        '
        'btnSave
        '
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(43, 20)
        Me.btnSave.Text = "Save"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 729)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 772)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.pbDraw)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "DrawingApp"
        CType(Me.pbDraw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbDraw As PictureBox
    Friend WithEvents txtSize As DomainUpDown
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnColour As ToolStripMenuItem
    Friend WithEvents btnEraser As ToolStripMenuItem
    Friend WithEvents btnFill As ToolStripMenuItem
    Friend WithEvents btnClear As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBrushStyles As ToolStripMenuItem
    Friend WithEvents btnSave As ToolStripMenuItem
End Class
