Public Class Edit_form
    Shared _title, _author, _section, _units As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim msg = "Save changes on " + tb_title.Text + "?"
        Dim response = MessageBox.Show(msg, "Save", MessageBoxButtons.YesNo)

        If response = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Friend Shared Sub setValues(title As String, author As String, section As String, units As String)
        _title = title
        _author = author
        _section = section
        _units = units
    End Sub

    Private Sub Edit_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_title.Text = _title
        tb_author.Text = _author
        tb_section.Text = _section
        tb_units.Text = _units
    End Sub
End Class