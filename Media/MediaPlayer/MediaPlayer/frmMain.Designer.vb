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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnFastReverse = New System.Windows.Forms.Button()
        Me.btnFastForward = New System.Windows.Forms.Button()
        Me.tbVolume = New System.Windows.Forms.TrackBar()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.btnReverse = New System.Windows.Forms.Button()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'player
        '
        Me.player.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.player.Enabled = True
        Me.player.Location = New System.Drawing.Point(12, 2)
        Me.player.Name = "player"
        Me.player.OcxState = CType(resources.GetObject("player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.player.Size = New System.Drawing.Size(1021, 602)
        Me.player.TabIndex = 0
        '
        'btnPlay
        '
        Me.btnPlay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPlay.Location = New System.Drawing.Point(12, 618)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 45)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPause.Location = New System.Drawing.Point(93, 618)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 45)
        Me.btnPause.TabIndex = 2
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnStop.Location = New System.Drawing.Point(174, 618)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 45)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnFastReverse
        '
        Me.btnFastReverse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFastReverse.Location = New System.Drawing.Point(255, 618)
        Me.btnFastReverse.Name = "btnFastReverse"
        Me.btnFastReverse.Size = New System.Drawing.Size(75, 45)
        Me.btnFastReverse.TabIndex = 4
        Me.btnFastReverse.Text = "<<"
        Me.btnFastReverse.UseVisualStyleBackColor = True
        '
        'btnFastForward
        '
        Me.btnFastForward.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFastForward.Location = New System.Drawing.Point(336, 618)
        Me.btnFastForward.Name = "btnFastForward"
        Me.btnFastForward.Size = New System.Drawing.Size(75, 45)
        Me.btnFastForward.TabIndex = 5
        Me.btnFastForward.Text = ">>"
        Me.btnFastForward.UseVisualStyleBackColor = True
        '
        'tbVolume
        '
        Me.tbVolume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbVolume.Location = New System.Drawing.Point(579, 618)
        Me.tbVolume.Maximum = 100
        Me.tbVolume.Name = "tbVolume"
        Me.tbVolume.Size = New System.Drawing.Size(376, 45)
        Me.tbVolume.TabIndex = 6
        Me.tbVolume.Value = 50
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Location = New System.Drawing.Point(961, 618)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 45)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        Me.ofd.Filter = "All files (*.*)|*.*"
        Me.ofd.Title = "media file"
        '
        'btnForward
        '
        Me.btnForward.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnForward.Location = New System.Drawing.Point(498, 618)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(75, 45)
        Me.btnForward.TabIndex = 8
        Me.btnForward.Text = ">"
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'btnReverse
        '
        Me.btnReverse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReverse.Location = New System.Drawing.Point(417, 618)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(75, 45)
        Me.btnReverse.TabIndex = 9
        Me.btnReverse.Text = "<"
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 675)
        Me.Controls.Add(Me.btnReverse)
        Me.Controls.Add(Me.btnForward)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.tbVolume)
        Me.Controls.Add(Me.btnFastForward)
        Me.Controls.Add(Me.btnFastReverse)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.player)
        Me.Name = "frmMain"
        Me.Text = "MediaPlayer"
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnFastReverse As Button
    Friend WithEvents btnFastForward As Button
    Friend WithEvents tbVolume As TrackBar
    Friend WithEvents btnBrowse As Button
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents btnForward As Button
    Friend WithEvents btnReverse As Button
End Class
