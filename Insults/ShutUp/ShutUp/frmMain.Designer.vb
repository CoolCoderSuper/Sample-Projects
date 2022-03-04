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
        Me.btnTryMe = New System.Windows.Forms.Button()
        Me.btnOrMe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTryMe
        '
        Me.btnTryMe.Location = New System.Drawing.Point(12, 12)
        Me.btnTryMe.Name = "btnTryMe"
        Me.btnTryMe.Size = New System.Drawing.Size(75, 87)
        Me.btnTryMe.TabIndex = 0
        Me.btnTryMe.Text = "Try Me"
        Me.btnTryMe.UseVisualStyleBackColor = True
        '
        'btnOrMe
        '
        Me.btnOrMe.Location = New System.Drawing.Point(93, 12)
        Me.btnOrMe.Name = "btnOrMe"
        Me.btnOrMe.Size = New System.Drawing.Size(75, 87)
        Me.btnOrMe.TabIndex = 1
        Me.btnOrMe.Text = "Or Me"
        Me.btnOrMe.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(176, 111)
        Me.Controls.Add(Me.btnOrMe)
        Me.Controls.Add(Me.btnTryMe)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTryMe As Button
    Friend WithEvents btnOrMe As Button
End Class
