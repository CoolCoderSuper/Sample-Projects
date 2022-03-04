<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.btnconnect = New System.Windows.Forms.Button()
		Me.btnsend = New System.Windows.Forms.Button()
		Me.txtmessage = New System.Windows.Forms.TextBox()
		Me.txtchat = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'btnconnect
		'
		Me.btnconnect.Location = New System.Drawing.Point(440, 12)
		Me.btnconnect.Name = "btnconnect"
		Me.btnconnect.Size = New System.Drawing.Size(176, 23)
		Me.btnconnect.TabIndex = 0
		Me.btnconnect.Text = "Connect"
		Me.btnconnect.UseVisualStyleBackColor = True
		'
		'btnsend
		'
		Me.btnsend.Location = New System.Drawing.Point(440, 41)
		Me.btnsend.Name = "btnsend"
		Me.btnsend.Size = New System.Drawing.Size(75, 23)
		Me.btnsend.TabIndex = 1
		Me.btnsend.Text = "Send"
		Me.btnsend.UseVisualStyleBackColor = True
		'
		'txtmessage
		'
		Me.txtmessage.Location = New System.Drawing.Point(440, 70)
		Me.txtmessage.Name = "txtmessage"
		Me.txtmessage.Size = New System.Drawing.Size(176, 20)
		Me.txtmessage.TabIndex = 2
		'
		'txtchat
		'
		Me.txtchat.Location = New System.Drawing.Point(12, 12)
		Me.txtchat.Multiline = True
		Me.txtchat.Name = "txtchat"
		Me.txtchat.ReadOnly = True
		Me.txtchat.Size = New System.Drawing.Size(422, 425)
		Me.txtchat.TabIndex = 3
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(622, 448)
		Me.Controls.Add(Me.txtchat)
		Me.Controls.Add(Me.txtmessage)
		Me.Controls.Add(Me.btnsend)
		Me.Controls.Add(Me.btnconnect)
		Me.Name = "Form1"
		Me.Text = "Chat2"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnconnect As Button
	Friend WithEvents btnsend As Button
	Friend WithEvents txtmessage As TextBox
	Friend WithEvents txtchat As TextBox
End Class
