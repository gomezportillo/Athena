Public Class Main_frame

    Private _b As Book

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About_form.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tb_title.Text <> String.Empty And tb_author.Text <> String.Empty Then
            If tb_section.Text <> String.Empty Then
                _b = New Book(tb_title.Text, tb_author.Text, tb_section.Text)
            Else
                _b = New Book(tb_title.Text, tb_author.Text)
            End If

            _b.create()

            LoadDDBB()

            lbl_info.Text = "Book " & tb_title.Text & "stored correctly"
        Else
            lbl_info.Text = "Please insert at least a title and an author"
        End If

    End Sub

    Private Sub LoadDDBB()
        listView_books.Items.Clear()

        _b = New Book()

        Try
            _b.readAll()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Dim item As ListViewItem
        For Each bAux As Book In _b.dao._books
            item = New ListViewItem(bAux.title)
            item.SubItems.Add(bAux.author)
            item.SubItems.Add(bAux.section)
            item.SubItems.Add(CStr(bAux.units))

            listView_books.Items.Add(item)

            lbl_info.Text = "Listview updated"
        Next

    End Sub

    Private Sub Main_frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDDBB()
    End Sub

End Class
