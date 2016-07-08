Public Class Main_frame

    Private _b As Book

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim message As String = "Athena is a open-source project for managing a home library." & vbCrLf & vbCrLf & "You can see the source code at http://github.com/gomezportillo/athena"
        MessageBox.Show(message, "About Athena", MessageBoxButtons.OK)
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

            lbl_info.Text = "Book " & tb_title.Text & "stored correctly"
        Else
            lbl_info.Text = "Please insert at least a title and an author"
        End If

    End Sub

    Private Sub ListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listView_books.SelectedIndexChanged

    End Sub

    Private Sub LoadDDBBUpdateList()
        listView_books.Clear()

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
            item.SubItems.Add(bAux.units)

            listView_books.Items.Add(item)

            lbl_info.Text = bAux.ToString()
        Next

    End Sub

    Private Sub Main_frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDDBBUpdateList()
    End Sub
End Class
