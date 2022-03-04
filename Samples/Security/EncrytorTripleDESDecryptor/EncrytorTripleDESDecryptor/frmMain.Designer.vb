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
        Me.txtInPlain = New System.Windows.Forms.TextBox()
        Me.txtKey1 = New System.Windows.Forms.TextBox()
        Me.txtOutEnc = New System.Windows.Forms.TextBox()
        Me.txtKey2 = New System.Windows.Forms.TextBox()
        Me.txtOutPlain = New System.Windows.Forms.TextBox()
        Me.txtInEnc = New System.Windows.Forms.TextBox()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SuspendLayout()
        '
        'txtInPlain
        '
        Me.txtInPlain.Location = New System.Drawing.Point(144, 12)
        Me.txtInPlain.Multiline = True
        Me.txtInPlain.Name = "txtInPlain"
        Me.txtInPlain.Size = New System.Drawing.Size(273, 128)
        Me.txtInPlain.TabIndex = 0
        '
        'txtKey1
        '
        Me.txtKey1.Location = New System.Drawing.Point(144, 146)
        Me.txtKey1.Name = "txtKey1"
        Me.txtKey1.Size = New System.Drawing.Size(273, 20)
        Me.txtKey1.TabIndex = 1
        '
        'txtOutEnc
        '
        Me.txtOutEnc.Location = New System.Drawing.Point(144, 201)
        Me.txtOutEnc.Multiline = True
        Me.txtOutEnc.Name = "txtOutEnc"
        Me.txtOutEnc.ReadOnly = True
        Me.txtOutEnc.Size = New System.Drawing.Size(273, 128)
        Me.txtOutEnc.TabIndex = 2
        '
        'txtKey2
        '
        Me.txtKey2.Location = New System.Drawing.Point(571, 146)
        Me.txtKey2.Name = "txtKey2"
        Me.txtKey2.Size = New System.Drawing.Size(273, 20)
        Me.txtKey2.TabIndex = 5
        '
        'txtOutPlain
        '
        Me.txtOutPlain.Location = New System.Drawing.Point(571, 201)
        Me.txtOutPlain.Multiline = True
        Me.txtOutPlain.Name = "txtOutPlain"
        Me.txtOutPlain.ReadOnly = True
        Me.txtOutPlain.Size = New System.Drawing.Size(273, 128)
        Me.txtOutPlain.TabIndex = 4
        '
        'txtInEnc
        '
        Me.txtInEnc.Location = New System.Drawing.Point(571, 12)
        Me.txtInEnc.Multiline = True
        Me.txtInEnc.Name = "txtInEnc"
        Me.txtInEnc.Size = New System.Drawing.Size(273, 128)
        Me.txtInEnc.TabIndex = 3
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(144, 172)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(273, 23)
        Me.btnEncrypt.TabIndex = 6
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btnDecrypt
        '
        Me.btnDecrypt.Location = New System.Drawing.Point(571, 172)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(273, 23)
        Me.btnDecrypt.TabIndex = 7
        Me.btnDecrypt.Text = "Decrypt"
        Me.btnDecrypt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "InputText:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(441, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "InputText:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Key:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(441, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Key:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "OutputText:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(441, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "OutputText:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(854, 342)
        Me.ShapeContainer1.TabIndex = 14
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 430
        Me.LineShape1.X2 = 429
        Me.LineShape1.Y1 = -3
        Me.LineShape1.Y2 = 342
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 342)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.txtKey2)
        Me.Controls.Add(Me.txtOutPlain)
        Me.Controls.Add(Me.txtInEnc)
        Me.Controls.Add(Me.txtOutEnc)
        Me.Controls.Add(Me.txtKey1)
        Me.Controls.Add(Me.txtInPlain)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.MaximumSize = New System.Drawing.Size(870, 381)
        Me.MinimumSize = New System.Drawing.Size(870, 381)
        Me.Name = "frmMain"
        Me.Text = "TripleDES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInPlain As TextBox
	Friend WithEvents txtKey1 As TextBox
	Friend WithEvents txtOutEnc As TextBox
	Friend WithEvents txtKey2 As TextBox
	Friend WithEvents txtOutPlain As TextBox
	Friend WithEvents txtInEnc As TextBox
	Friend WithEvents btnEncrypt As Button
	Friend WithEvents btnDecrypt As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
	Friend WithEvents LineShape1 As PowerPacks.LineShape
End Class
