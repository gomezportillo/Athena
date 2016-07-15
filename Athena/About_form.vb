Public Class About_form
    Dim repostory_address As String = "http://github.com/gomezportillo/athena"


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, PictureBox1.Click
        Process.Start(repostory_address)
    End Sub
End Class