Public Class Edit_form
    Shared _title, _author, _section, _units As String

    Friend Shared Sub setValues(title As String, author As String, section As String, units As String)
        _title = title
        _author = author
        _section = section
        _units = units
    End Sub

    Private Sub Edit_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class