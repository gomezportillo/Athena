Public Class Edit_form
    Shared _old_book As Book

    Private Sub Cancel_Edition(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub Update_Book(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim msg = "Save changes on " + tb_title.Text + "?"
        Dim response = MessageBox.Show(msg, "Save", MessageBoxButtons.YesNo)

        If response = MsgBoxResult.Yes Then
            Dim new_book = New Book(tb_title.Text, tb_author.Text, tb_section.Text, tb_collection.Text, tb_units.Text)

            'Update query will not work if changing primary keys (title and author)
            new_book.create()
            _old_book.delete()

            Main_form.LoadDDBB()
            Me.Close()
        End If
    End Sub

    Friend Shared Sub setValues(ByVal b As Book)
        _old_book = b
    End Sub

    Private Sub Edit_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_title.Text = _old_book.title
        tb_author.Text = _old_book.author
        tb_section.Text = If(_old_book.section <> "None", _old_book.section, String.Empty)
        tb_collection.Text = If(_old_book.collection <> "None", _old_book.collection, String.Empty)
        tb_units.Text = _old_book.units
    End Sub
End Class