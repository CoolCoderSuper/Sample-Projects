<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHomer
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
        Me.lblHomer = New System.Windows.Forms.Label()
        Me.btnClickMe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHomer
        '
        Me.lblHomer.AutoSize = True
        Me.lblHomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomer.Location = New System.Drawing.Point(12, 9)
        Me.lblHomer.Name = "lblHomer"
        Me.lblHomer.Size = New System.Drawing.Size(1152, 108)
        Me.lblHomer.TabIndex = 43
        Me.lblHomer.Text = "HOMER IS DUMB RIGHT"
        '
        'btnClickMe
        '
        Me.btnClickMe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClickMe.Location = New System.Drawing.Point(12, 160)
        Me.btnClickMe.Name = "btnClickMe"
        Me.btnClickMe.Size = New System.Drawing.Size(395, 278)
        Me.btnClickMe.TabIndex = 44
        Me.btnClickMe.Text = "Click Me"
        Me.btnClickMe.UseVisualStyleBackColor = True
        '
        'frmHomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 450)
        Me.Controls.Add(Me.btnClickMe)
        Me.Controls.Add(Me.lblHomer)
        Me.Name = "frmHomer"
        Me.Text = "HOMER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHomer As Label
    Friend WithEvents btnClickMe As Button
End Class
