Public Class frmMain
    Private Draw As Boolean = False
    Private DrawColour As Color = Color.Black
    Private DrawSize As Integer = 6
    Public _bmp As Bitmap

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSize.Text = 2
        _bmp = New Bitmap(pbDraw.Width, pbDraw.Height)
        pbDraw.Image = _bmp
    End Sub

    Private Sub PaintBrush(X As Integer, Y As Integer)
        Using g As Graphics = Graphics.FromImage(pbDraw.Image)
            g.FillRectangle(New SolidBrush(DrawColour), New Rectangle(X, Y, DrawSize, DrawSize))
        End Using
        pbDraw.Refresh()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As MouseEventArgs) Handles pbDraw.MouseDown, pbDraw.Click
        Draw = True
        PaintBrush(e.X, e.Y)
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles pbDraw.MouseMove
        If Draw = True Then
            PaintBrush(e.X, e.Y)
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles pbDraw.MouseUp
        Draw = False
    End Sub

    Private Sub txtSize_SelectedItemChanged(sender As Object, e As EventArgs) Handles txtSize.SelectedItemChanged
        DrawSize = txtSize.Text
    End Sub

    Private Sub btnColour_Click(sender As Object, e As EventArgs) Handles btnColour.Click
        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            DrawColour = ColorDialog1.Color
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        _bmp = New Bitmap(pbDraw.Width, pbDraw.Height)
        pbDraw.Image = _bmp
    End Sub

    Private Sub btnEraser_Click(sender As Object, e As EventArgs) Handles btnEraser.Click
        DrawColour = Color.White
    End Sub

    Private Sub btnFill_Click(sender As Object, e As MouseEventArgs) Handles btnFill.MouseDown
        Draw = True
        If Draw = True Then
            Using g As Graphics = Graphics.FromImage(pbDraw.Image)
                g.FillRectangle(New SolidBrush(DrawColour), New Rectangle(pbDraw.Location.X - 13, pbDraw.Location.Y - 71, pbDraw.Width, pbDraw.Height))
            End Using
            pbDraw.Refresh()
            Draw = False
        End If
    End Sub

    Private Sub pbDraw_Move(sender As Object, e As MouseEventArgs) Handles pbDraw.MouseMove
        Label1.Text = $"X.{e.X}{vbCrLf}Y.{e.Y}"
    End Sub

    Private Sub Form1_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Cursor = Cursors.Default
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        pbDraw.DrawToBitmap(_bmp, New Rectangle(0, 0, pbDraw.Width, pbDraw.Height))
        Dim objSaveFile As New SaveFileDialog
        If objSaveFile.ShowDialog() = DialogResult.OK Then
            _bmp.Save(objSaveFile.FileName)
            _bmp = New Bitmap(pbDraw.Width, pbDraw.Height)
        End If
    End Sub

End Class