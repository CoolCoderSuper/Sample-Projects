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
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnPing = New System.Windows.Forms.Button()
        Me.txtIp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(12, 39)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(331, 144)
        Me.txtOutput.TabIndex = 8
        '
        'btnPing
        '
        Me.btnPing.Location = New System.Drawing.Point(268, 9)
        Me.btnPing.Name = "btnPing"
        Me.btnPing.Size = New System.Drawing.Size(75, 23)
        Me.btnPing.TabIndex = 7
        Me.btnPing.Text = "Ping"
        Me.btnPing.UseVisualStyleBackColor = True
        '
        'txtIp
        '
        Me.txtIp.Location = New System.Drawing.Point(12, 12)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(250, 20)
        Me.txtIp.TabIndex = 6
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 188)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnPing)
        Me.Controls.Add(Me.txtIp)
        Me.MaximumSize = New System.Drawing.Size(367, 227)
        Me.MinimumSize = New System.Drawing.Size(367, 227)
        Me.Name = "frmMain"
        Me.Text = "Ping"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOutput As TextBox
	Friend WithEvents btnPing As Button
	Friend WithEvents txtIp As TextBox
End Class
