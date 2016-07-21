Public Class Main_form

    Private _b As Book
    Friend WithEvents listView_contextMenu As New ContextMenu()
    Dim mnuItemRemove As New MenuItem("Delete")
    Dim mnuItemEdit As New MenuItem("Edit")
    Dim sortColumn As Integer = -1
    Dim autocomplete_title As AutoCompleteStringCollection
    Dim autocomplete_author As AutoCompleteStringCollection
    Dim autocomplete_section As AutoCompleteStringCollection
    Dim autocomplete_collection As AutoCompleteStringCollection
    Dim search_by As Integer


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About_form.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Main_frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDDBB()

        tb_search.AutoCompleteCustomSource = tb_title.AutoCompleteCustomSource

        Create_listview_contextMenu()
        search_by = 0
    End Sub

    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles Btn_add.Click
        If tb_title.Text <> String.Empty And tb_author.Text <> String.Empty Then

            _b = New Book(tb_title.Text, tb_author.Text, tb_section.Text, tb_collection.Text)

            _b.create()

            LoadDDBB()

            lbl_info.Text = "Book " & tb_title.Text & " stored correctly"

            tb_title.Text = String.Empty
            tb_author.Text = String.Empty
            tb_section.Text = String.Empty
            tb_collection.Text = String.Empty
        Else
            lbl_info.Text = "Please insert at least a title and an author"
        End If
    End Sub

    'Launch the context menu where the user has clicked
    Private Sub listView_books_SelectedIndexChanged(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles listView_books.MouseDown
        If e.Button = MouseButtons.Right Then
            If listView_books.GetItemAt(e.X, e.Y) IsNot Nothing Then
                listView_books.GetItemAt(e.X, e.Y).Selected = True
                listView_contextMenu.Show(listView_books, New Point(e.X, e.Y))
            End If
        End If
    End Sub

    'Subprocedure for loading the whole database onto the listview and in the textbox suggestions
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
        Dim title_list, author_list, section_list, collection_list As New List(Of String)

        For Each bAux As Book In _b.dao._books
            item = New ListViewItem(bAux.title)
            item.SubItems.Add(bAux.author)

            bAux.section = If(bAux.section = "None", String.Empty, bAux.section)
            item.SubItems.Add(bAux.section)

            bAux.collection = If(bAux.collection = "None", String.Empty, bAux.collection)
            item.SubItems.Add(bAux.collection)
            item.SubItems.Add(CStr(bAux.units))
            listView_books.Items.Add(item)

            title_list.Add(bAux.title)
            author_list.Add(bAux.author)
            section_list.Add(bAux.section)
            collection_list.Add(bAux.collection)
        Next

        Fill_TexBox_Autocomplete(title_list, author_list, section_list, collection_list)
        lbl_info.Text = "List of books updated"
    End Sub

    'Subprocedure executed for assigning the data readed from the ddbb to the textbox suggestions 
    Private Sub Fill_TexBox_Autocomplete(ByVal title_list As List(Of String), ByVal author_list As List(Of String), ByVal section_list As List(Of String), ByVal collection_list As List(Of String))
        autocomplete_title = New AutoCompleteStringCollection()
        autocomplete_title.AddRange(title_list.ToArray())
        tb_title.AutoCompleteCustomSource = autocomplete_title

        autocomplete_author = New AutoCompleteStringCollection()
        autocomplete_author.AddRange(author_list.ToArray())
        tb_author.AutoCompleteCustomSource = autocomplete_author

        autocomplete_section = New AutoCompleteStringCollection()
        autocomplete_section.AddRange(section_list.ToArray())
        tb_section.AutoCompleteCustomSource = autocomplete_section

        autocomplete_collection = New AutoCompleteStringCollection()
        autocomplete_collection.AddRange(collection_list.ToArray())
        tb_collection.AutoCompleteCustomSource = autocomplete_collection
    End Sub

    'Subprocess for creating the context menu (edit & delete) for the list view
    Private Sub Create_listview_contextMenu()
        mnuItemEdit.Visible = True
        mnuItemRemove.Visible = True

        listView_contextMenu.MenuItems.Add(mnuItemEdit)
        listView_contextMenu.MenuItems.Add(mnuItemRemove)

        AddHandler mnuItemRemove.Click, AddressOf Me.menuItemRemove_Listener
        AddHandler mnuItemEdit.Click, AddressOf Me.menuItemEdit_Listener
        AddHandler listView_books.ColumnClick, AddressOf Me.listViewBooks_ColumnClick
    End Sub

    'Method called when the option 'Remove' is selected from the list view context menu
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

    'Creates a .txt file with the current content of the list view
    Private Sub GeneratetxtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneratetxtToolStripMenuItem.Click
        Dim file As System.IO.StreamWriter
        Dim filename As String = "Athena.txt"
        Dim content As String = ""

        For Each item As ListViewItem In listView_books.Items
            content += item.Text & " - " & item.SubItems(1).Text + " - " & item.SubItems(2).Text + " - " & item.SubItems(3).Text & vbCrLf
        Next

        My.Computer.FileSystem.DeleteFile(filename)
        file = My.Computer.FileSystem.OpenTextFileWriter(filename, True)
        file.WriteLine(content)
        file.Close()
        lbl_info.Text = filename & " generated correctly"
    End Sub

    'Method for launching the 'Edit' form
    Private Sub menuItemEdit_Listener(sender As Object, e As EventArgs)
        Dim title, author, section, collection, units As String

        title = listView_books.SelectedItems(0).SubItems(0).Text
        author = listView_books.SelectedItems(0).SubItems(1).Text
        section = listView_books.SelectedItems(0).SubItems(2).Text
        collection = listView_books.SelectedItems(0).SubItems(3).Text
        units = listView_books.SelectedItems(0).SubItems(4).Text

        _b = New Book(title, author, section, collection, units)

        Edit_form.setValues(_b)
        Edit_form.Show()
    End Sub

    'Method for searching on the list view at the same time the textbox is written
    Private Sub tb_search_TextChanged(sender As Object, e As EventArgs) Handles tb_search.TextChanged
        Dim item_text As String
        Dim search_term As String = UnAccent(tb_search.Text.ToLower())

        listView_books.BeginUpdate()

        LoadDDBB()

        For Each new_item As ListViewItem In listView_books.Items
            item_text = UnAccent(new_item.SubItems(search_by).Text.ToLower())
            If Not item_text.Contains(search_term) Then
                listView_books.Items.Remove(new_item)
            End If
        Next

        listView_books.EndUpdate()
    End Sub

    'Radio button listeners that change the type of search and the search textbox's suggestions
    Private Sub rb_title_CheckedChanged(sender As Object, e As EventArgs) Handles rb_title.CheckedChanged
        tb_search.AutoCompleteCustomSource = tb_title.AutoCompleteCustomSource
        search_by = 0
    End Sub

    Private Sub rb_author_CheckedChanged(sender As Object, e As EventArgs) Handles rb_author.CheckedChanged
        tb_search.AutoCompleteCustomSource = tb_author.AutoCompleteCustomSource
        search_by = 1
    End Sub

    Private Sub rb_section_CheckedChanged(sender As Object, e As EventArgs) Handles rb_section.CheckedChanged
        tb_search.AutoCompleteCustomSource = tb_section.AutoCompleteCustomSource
        search_by = 2
    End Sub

    Private Sub rb_collection_CheckedChanged(sender As Object, e As EventArgs) Handles rb_collection.CheckedChanged
        tb_search.AutoCompleteCustomSource = tb_collection.AutoCompleteCustomSource
        search_by = 3
    End Sub

    'Extracted from https://msdn.microsoft.com/en-us/library/ms996467.aspx
    'Used for alphabetically ordering the list view when the name of the column is clicked
    Private Sub listViewBooks_ColumnClick(sender As Object, e As System.Windows.Forms.ColumnClickEventArgs)
        listView_books.BeginUpdate()
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
        listView_books.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        listView_books.ListViewItemSorter = New ListViewItemComparer(e.Column, listView_books.Sorting)
        listView_books.EndUpdate()
    End Sub

    'Extracted from https://social.msdn.microsoft.com/Forums/vstudio/en-US/8392f4d3-e016-4337-9d37-fb20fecd1425/converting-string-with-accented-characters-to-nonaccented-equivalent?forum=vbgeneral
    'Used for removing accents from strings
    Public Function UnAccent(ByVal aString As String) As String
        Dim toReplace() As Char = "àèìòùÀÈÌÒÙ äëïöüÄËÏÖÜ âêîôûÂÊÎÔÛ áéíóúÁÉÍÓÚðÐýÝ ãñõÃÑÕšŠžŽçÇåÅøØ".ToCharArray
        Dim replaceChars() As Char = "aeiouAEIOU aeiouAEIOU aeiouAEIOU aeiouAEIOUdDyY anoANOsSzZcCaAoO".ToCharArray
        For index As Integer = 0 To toReplace.GetUpperBound(0)
            aString = aString.Replace(toReplace(index), replaceChars(index))
        Next
        Return aString
    End Function
End Class


'Class used for ordering the listview when the title bar is clicked
Class ListViewItemComparer
    Implements IComparer
    Private col As Integer
    Private order As SortOrder

    Public Sub New()
        col = 0
        order = SortOrder.Ascending
    End Sub

    Public Sub New(column As Integer, ord As SortOrder)
        col = column
        order = ord
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim returnVal As Integer = -1
        returnVal = [String].Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
        ' Determine whether the sort order is descending.
        If order = SortOrder.Descending Then
            ' Invert the value returned by String.Compare.
            returnVal *= -1
        End If

        Return returnVal
    End Function
End Class