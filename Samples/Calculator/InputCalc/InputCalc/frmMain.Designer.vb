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
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.txtNum2 = New System.Windows.Forms.NumericUpDown()
        Me.txtNum1 = New System.Windows.Forms.NumericUpDown()
        Me.cbxOp = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.txtNum2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNum1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(93, 92)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ReadOnly = True
        Me.txtAnswer.Size = New System.Drawing.Size(264, 20)
        Me.txtAnswer.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Answer: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Operation: "
        '
        'btnEquals
        '
        Me.btnEquals.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.25!)
        Me.btnEquals.Location = New System.Drawing.Point(15, 118)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(345, 81)
        Me.btnEquals.TabIndex = 6
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(93, 66)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(245, 20)
        Me.txtNum2.TabIndex = 7
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(93, 13)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(267, 20)
        Me.txtNum1.TabIndex = 8
        '
        'cbxOp
        '
        Me.cbxOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOp.FormattingEnabled = True
        Me.cbxOp.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.cbxOp.Location = New System.Drawing.Point(93, 39)
        Me.cbxOp.Name = "cbxOp"
        Me.cbxOp.Size = New System.Drawing.Size(31, 21)
        Me.cbxOp.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Number: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Number: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(344, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "="
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 211)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxOp)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAnswer)
        Me.Name = "frmMain"
        Me.Text = "InputCalc"
        CType(Me.txtNum2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNum1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEquals As Button
    Friend WithEvents txtNum2 As NumericUpDown
    Friend WithEvents txtNum1 As NumericUpDown
    Friend WithEvents cbxOp As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
