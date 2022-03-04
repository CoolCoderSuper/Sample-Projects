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
		Me.txtchat = New System.Windows.Forms.TextBox()
		Me.txtmessage = New System.Windows.Forms.TextBox()
		Me.btnsend = New System.Windows.Forms.Button()
		Me.btnconnect = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'txtchat
		'
		Me.txtchat.Location = New System.Drawing.Point(13, 13)
		Me.txtchat.Multiline = True
		Me.txtchat.Name = "txtchat"
		Me.txtchat.ReadOnly = True
		Me.txtchat.Size = New System.Drawing.Size(422, 425)
		Me.txtchat.TabIndex = 0
		'
		'txtmessage
		'
		Me.txtmessage.Location = New System.Drawing.Point(441, 71)
		Me.txtmessage.Name = "txtmessage"
		Me.txtmessage.Size = New System.Drawing.Size(176, 20)
		Me.txtmessage.TabIndex = 5
		'
		'btnsend
		'
		Me.btnsend.Location = New System.Drawing.Point(441, 42)
		Me.btnsend.Name = "btnsend"
		Me.btnsend.Size = New System.Drawing.Size(75, 23)
		Me.btnsend.TabIndex = 4
		Me.btnsend.Text = "Send"
		Me.btnsend.UseVisualStyleBackColor = True
		'
		'btnconnect
		'
		Me.btnconnect.Location = New System.Drawing.Point(441, 13)
		Me.btnconnect.Name = "btnconnect"
		Me.btnconnect.Size = New System.Drawing.Size(176, 23)
		Me.btnconnect.TabIndex = 3
		Me.btnconnect.Text = "Connect"
		Me.btnconnect.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(624, 450)
		Me.Controls.Add(Me.txtmessage)
		Me.Controls.Add(Me.btnsend)
		Me.Controls.Add(Me.btnconnect)
		Me.Controls.Add(Me.txtchat)
		Me.Name = "Form1"
		Me.Text = "Chat1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtchat As TextBox
	Friend WithEvents txtmessage As TextBox
	Friend WithEvents btnsend As Button
	Friend WithEvents btnconnect As Button
End Class
