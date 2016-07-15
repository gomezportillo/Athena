Public Class Main_form

    Private _b As Book
    Friend WithEvents listView_contextMenu As New ContextMenu()
    Dim mnuItemRemove As New MenuItem("Delete")
    Dim mnuItemEdit As New MenuItem("Edit")
    Dim sortColumn As Integer = -1


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About_form.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Public Sub LoadDDBB()
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

            lbl_info.Text = "List of books updated"
        Next

    End Sub
    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles Btn_add.Click
        If tb_title.Text <> String.Empty And tb_author.Text <> String.Empty Then
            If tb_section.Text <> String.Empty Then
                _b = New Book(tb_title.Text, tb_author.Text, tb_section.Text)
            Else
                _b = New Book(tb_title.Text, tb_author.Text)
            End If

            _b.create()

            LoadDDBB()

            lbl_info.Text = "Book " & tb_title.Text & " stored correctly"
        Else
            lbl_info.Text = "Please insert at least a title and an author"
        End If

    End Sub

    Private Sub Main_frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDDBB()
        Create_listview_contextMenu()
    End Sub

    Private Sub Create_listview_contextMenu()
        mnuItemEdit.Visible = True
        mnuItemRemove.Visible = True

        listView_contextMenu.MenuItems.Add(mnuItemEdit)
        listView_contextMenu.MenuItems.Add(mnuItemRemove)
        AddHandler mnuItemRemove.Click, AddressOf Me.menuItemRemove_Listener
        AddHandler mnuItemEdit.Click, AddressOf Me.menuItemEdit_Listener

        AddHandler listView_books.ColumnClick, AddressOf Me.listViewBooks_ColumnClick
    End Sub

    Private Sub listView_books_SelectedIndexChanged(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles listView_books.MouseDown
        If e.Button = MouseButtons.Right Then
            If listView_books.GetItemAt(e.X, e.Y) IsNot Nothing Then
                listView_books.GetItemAt(e.X, e.Y).Selected = True
                listView_contextMenu.Show(listView_books, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    Private Sub menuItemRemove_Listener(sender As Object, e As EventArgs)
        Dim title, author, msg As String

        If listView_books.SelectedItems.Count <> 0 Then
            title = listView_books.SelectedItems(0).SubItems(0).Text
            author = listView_books.SelectedItems(0).SubItems(1).Text

            msg = "Are you sure you want to permanently delete " & title & " from " & author & "?"
            Dim response = MessageBox.Show(msg, "Delete book", MessageBoxButtons.YesNo)

            If response = MsgBoxResult.Yes Then
                _b = New Book(title, author)
                _b.delete()
                lbl_info.Text = title & " successfully deleted"
                LoadDDBB()
            End If
        End If
    End Sub

    Private Sub menuItemEdit_Listener(sender As Object, e As EventArgs)
        Dim title, author, section, units As String
        title = listView_books.SelectedItems(0).SubItems(0).Text
        author = listView_books.SelectedItems(0).SubItems(1).Text
        section = listView_books.SelectedItems(0).SubItems(2).Text
        units = listView_books.SelectedItems(0).SubItems(3).Text
        _b = New Book(title, author, section, units)
        Edit_form.setValues(_b)
        Edit_form.Show()
    End Sub

    'Extracted from https://msdn.microsoft.com/en-us/library/ms996467.aspx
    Private Sub listViewBooks_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs)
        ' Determine whether the column is the same as the last column clicked.
        If e.Column <> sortColumn Then
            ' Set the sort column to the new column.
            sortColumn = e.Column
            ' Set the sort order to ascending by default.
            listView_books.Sorting = SortOrder.Ascending
        Else
            ' Determine what the last sort order was and change it.
            If listView_books.Sorting = SortOrder.Ascending Then
                listView_books.Sorting = SortOrder.Descending
            Else
                listView_books.Sorting = SortOrder.Ascending
            End If
        End If
        ' Call the sort method to manually sort.
        listView_books.BeginUpdate()
        listView_books.Sort()
        listView_books.EndUpdate()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        listView_books.ListViewItemSorter = New ListViewItemComparer(e.Column, listView_books.Sorting)
    End Sub

End Class


Class ListViewItemComparer
    Implements IComparer
    Private col As Integer
    Private order As SortOrder

    Public Sub New()
        col = 0
        order = SortOrder.Ascending
    End Sub

    Public Sub New(column As Integer, order As SortOrder)
        col = column
        Me.order = order
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer _
                        Implements System.Collections.IComparer.Compare
        Dim returnVal As Integer = -1
        returnVal = [String].Compare(CType(x,
                        ListViewItem).SubItems(col).Text,
                        CType(y, ListViewItem).SubItems(col).Text)
        ' Determine whether the sort order is descending.
        If order = SortOrder.Descending Then
            ' Invert the value returned by String.Compare.
            returnVal *= -1
        End If

        Return returnVal
    End Function
End Class