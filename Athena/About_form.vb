Public Class About_form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim webAddress As String = "http://github.com/gomezportillo/athena"
        Process.Start(webAddress)
    End Sub
End Class