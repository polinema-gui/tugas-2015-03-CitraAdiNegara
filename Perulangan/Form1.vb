Public Class Form1
    Dim pesan As String
    Private Sub ProblemBintangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProblemBintangToolStripMenuItem.Click
        Form2.MdiParent = Me
        Form2.Show()
    End Sub

    Private Sub MatriksKalkulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatriksKalkulatorToolStripMenuItem.Click
        Form3.MdiParent = Me
        Form3.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click

        pesan = MsgBox("Apakah Anda yakin ingin Keluar", vbYesNo, "Exit")
        If pesan = vbYes Then
            Me.BackColor = Color.Blue
        End If
        Environment.Exit(0)
    End Sub
End Class
