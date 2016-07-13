Public Class Edit_form
    Private old_book, new_book As Book
    Shared _title, _author, _section, _units As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim msg = "Save changes on " + tb_title.Text + "?"
        Dim response = MessageBox.Show(msg, "Save", MessageBoxButtons.YesNo)

        If response = MsgBoxResult.Yes Then
            new_book = New Book(tb_title.Text, tb_author.Text, tb_section.Text, tb_units.Text)

            'UPDATE sql sentence not working if changing primary keys (title and author)
            old_book.delete()
            new_book.create()
            Main_form.LoadDDBB()
            Me.Close()
        End If
    End Sub

    Friend Shared Sub setValues(ByVal b As Book)
        _title = b.title
        _author = b.author
        _section = b.section
        _units = b.units
    End Sub

    Private Sub Edit_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        old_book = New Book(_title, _author, _section, _units)

        tb_title.Text = _title
        tb_author.Text = _author
        tb_section.Text = _section
        tb_units.Text = _units
    End Sub
End Class