<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtCode = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.btnCompile = New System.Windows.Forms.Button()
        Me.rdVB = New System.Windows.Forms.RadioButton()
        Me.rdCSharp = New System.Windows.Forms.RadioButton()
        Me.chexecutable = New System.Windows.Forms.CheckBox()
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCode
        '
        Me.txtCode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCode.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.txtCode.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.\(\)]+\s*(?<range>=)\s*(?<range>.+)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtCode.AutoScrollMinSize = New System.Drawing.Size(291, 154)
        Me.txtCode.BackBrush = Nothing
        Me.txtCode.CharHeight = 14
        Me.txtCode.CharWidth = 8
        Me.txtCode.CommentPrefix = "'"
        Me.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCode.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.txtCode.IsReplaceMode = False
        Me.txtCode.Language = FastColoredTextBoxNS.Language.VB
        Me.txtCode.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.txtCode.Location = New System.Drawing.Point(12, 38)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Paddings = New System.Windows.Forms.Padding(0)
        Me.txtCode.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.txtCode.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCode.Size = New System.Drawing.Size(1110, 453)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Text = "Imports System" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Module m" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sub Main()" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Console.WriteLine(""Hello World"")" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Conso" &
    "le.ReadKey()" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "End Sub" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "End Module"
        Me.txtCode.Zoom = 100
        '
        'txtOutput
        '
        Me.txtOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutput.Location = New System.Drawing.Point(12, 526)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutput.Size = New System.Drawing.Size(1110, 170)
        Me.txtOutput.TabIndex = 1
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(12, 12)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(251, 20)
        Me.txtFile.TabIndex = 2
        '
        'btnCompile
        '
        Me.btnCompile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCompile.Location = New System.Drawing.Point(12, 497)
        Me.btnCompile.Name = "btnCompile"
        Me.btnCompile.Size = New System.Drawing.Size(1110, 23)
        Me.btnCompile.TabIndex = 3
        Me.btnCompile.Text = "Compile"
        Me.btnCompile.UseVisualStyleBackColor = True
        '
        'rdVB
        '
        Me.rdVB.AutoSize = True
        Me.rdVB.Checked = True
        Me.rdVB.Location = New System.Drawing.Point(270, 12)
        Me.rdVB.Name = "rdVB"
        Me.rdVB.Size = New System.Drawing.Size(39, 17)
        Me.rdVB.TabIndex = 4
        Me.rdVB.TabStop = True
        Me.rdVB.Text = "VB"
        Me.rdVB.UseVisualStyleBackColor = True
        '
        'rdCSharp
        '
        Me.rdCSharp.AutoSize = True
        Me.rdCSharp.Location = New System.Drawing.Point(315, 12)
        Me.rdCSharp.Name = "rdCSharp"
        Me.rdCSharp.Size = New System.Drawing.Size(60, 17)
        Me.rdCSharp.TabIndex = 5
        Me.rdCSharp.Text = "CSharp"
        Me.rdCSharp.UseVisualStyleBackColor = True
        '
        'chexecutable
        '
        Me.chexecutable.AutoSize = True
        Me.chexecutable.Checked = True
        Me.chexecutable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chexecutable.Enabled = False
        Me.chexecutable.Location = New System.Drawing.Point(382, 12)
        Me.chexecutable.Name = "chexecutable"
        Me.chexecutable.Size = New System.Drawing.Size(113, 17)
        Me.chexecutable.TabIndex = 6
        Me.chexecutable.Text = "Create Executable"
        Me.chexecutable.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 708)
        Me.Controls.Add(Me.chexecutable)
        Me.Controls.Add(Me.rdCSharp)
        Me.Controls.Add(Me.rdVB)
        Me.Controls.Add(Me.btnCompile)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtCode)
        Me.Name = "frmMain"
        Me.Text = "CodeRunner"
        CType(Me.txtCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCode As New FastColoredTextBoxNS.FastColoredTextBox()
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents txtFile As TextBox
    Friend WithEvents btnCompile As Button
    Friend WithEvents rdVB As RadioButton
    Friend WithEvents rdCSharp As RadioButton
    Friend WithEvents chexecutable As CheckBox
End Class
