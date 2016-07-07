Public Class Main_frame
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim message As String = "Athena is a open-source project for managing a home library." & vbCrLf & vbCrLf & "You can see the source code at http://github.com/gomezportillo/athena"
        MessageBox.Show(message, "About Athena", MessageBoxButtons.OK)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
