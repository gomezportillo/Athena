Public Class About_form
    Dim repostory_address As String = "http://github.com/gomezportillo/athena"
    Dim current_build As String = "October 2024"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbl_link.Click, PictureBox1.Click
        Process.Start(repostory_address)
    End Sub

    Private Sub About_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lbl_about.Text += " Current build " + current_build
    End Sub
End Class