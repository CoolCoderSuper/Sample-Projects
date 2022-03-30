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
        Me.lstPlayers = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtScore = New System.Windows.Forms.NumericUpDown()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.gbGame = New System.Windows.Forms.GroupBox()
        Me.txtGameName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        CType(Me.txtScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGame.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstPlayers
        '
        Me.lstPlayers.FormattingEnabled = True
        Me.lstPlayers.ItemHeight = 15
        Me.lstPlayers.Location = New System.Drawing.Point(7, 83)
        Me.lstPlayers.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstPlayers.Name = "lstPlayers"
        Me.lstPlayers.Size = New System.Drawing.Size(403, 274)
        Me.lstPlayers.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(81, 51)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(235, 23)
        Me.txtName.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(323, 49)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 27)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name:"
        '
        'lstScores
        '
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 15
        Me.lstScores.Location = New System.Drawing.Point(7, 369)
        Me.lstScores.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(403, 229)
        Me.lstScores.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 611)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Score: "
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(62, 609)
        Me.txtScore.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(254, 23)
        Me.txtScore.TabIndex = 8
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(323, 605)
        Me.btnRecord.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(88, 27)
        Me.btnRecord.TabIndex = 9
        Me.btnRecord.Text = "Record"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'gbGame
        '
        Me.gbGame.Controls.Add(Me.txtGameName)
        Me.gbGame.Controls.Add(Me.Label3)
        Me.gbGame.Controls.Add(Me.lstPlayers)
        Me.gbGame.Controls.Add(Me.btnRecord)
        Me.gbGame.Controls.Add(Me.txtName)
        Me.gbGame.Controls.Add(Me.txtScore)
        Me.gbGame.Controls.Add(Me.btnAdd)
        Me.gbGame.Controls.Add(Me.Label2)
        Me.gbGame.Controls.Add(Me.Label1)
        Me.gbGame.Controls.Add(Me.lstScores)
        Me.gbGame.Location = New System.Drawing.Point(12, 41)
        Me.gbGame.Name = "gbGame"
        Me.gbGame.Size = New System.Drawing.Size(420, 640)
        Me.gbGame.TabIndex = 10
        Me.gbGame.TabStop = False
        Me.gbGame.Text = "Game"
        '
        'txtGameName
        '
        Me.txtGameName.Location = New System.Drawing.Point(81, 22)
        Me.txtGameName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtGameName.Name = "txtGameName"
        Me.txtGameName.Size = New System.Drawing.Size(329, 23)
        Me.txtGameName.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Game Name:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(93, 12)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 12
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(174, 12)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 13
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 693)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbGame)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "ScoreKeeper"
        CType(Me.txtScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGame.ResumeLayout(False)
        Me.gbGame.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstPlayers As ListBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstScores As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtScore As NumericUpDown
    Friend WithEvents btnRecord As Button
    Friend WithEvents gbGame As GroupBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents txtGameName As TextBox
    Friend WithEvents Label3 As Label
End Class
