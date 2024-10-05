Public Class DAOBook
    Property _books As Collection

    Public Sub New()
        Me._books = New Collection
    End Sub

    Public Sub read(ByRef b As Book)
        Dim comm As String = "SELECT * FROM Books WHERE Title='" & b.title & "' AND Author='" & b.author & "';"
        Dim reader As OleDb.OleDbDataReader = DDBBBroker.getInstance.read(comm)
        reader.Read()

        b.title = reader.GetValue(reader.GetOrdinal("Title"))
        b.author = reader.GetValue(reader.GetOrdinal("Author"))
        b.section = reader.GetValue(reader.GetOrdinal("Section"))
        b.collection = reader.GetValue(reader.GetOrdinal("Collection"))
        b.units = reader.GetValue(reader.GetOrdinal("Units"))
    End Sub


    Public Function delete(ByVal b As Book) As Integer
        Dim comm As String = "DELETE FROM Books WHERE Title='" & b.title & "' AND Author='" & b.author & "';"
        Return DDBBBroker.getInstance().change(comm)
    End Function


    Public Function update(ByVal b As Book) As Integer
        Dim comm As String = "UPDATE Books SET Section='" & b.section & "', Collection='" & b.collection & "', Units='" & b.units & "' WHERE Title='" & b.title & "' AND Author='" & b.author & "';"
        Return DDBBBroker.getInstance().change(comm)
    End Function


    Public Function create(ByVal b As Book) As Integer
        Dim comm_insert As String = "INSERT INTO Books ([Title], [Author], [Section], [Collection], [Units]) " &
                            "VALUES ('" & b.title & "', '" & b.author & "', '" & b.section & "', '" & b.collection & "', " & b.units & ");"

        Dim returnCode = -1
        Try
            returnCode = DDBBBroker.getInstance().change(comm_insert)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return returnCode

    End Function

    Public Sub readAll(ByRef b As Book) 'returns an OleDBDataReader data structure
        Dim comm As String = "SELECT * FROM Books;"
        Dim reader As OleDb.OleDbDataReader = DDBBBroker.getInstance().read(comm)

        While reader.Read()
            Dim title = reader.GetValue(reader.GetOrdinal("Title"))
            Dim author = reader.GetValue(reader.GetOrdinal("Author"))
            Dim section = reader.GetValue(reader.GetOrdinal("Section"))
            Dim collection = reader.GetValue(reader.GetOrdinal("Collection"))
            Dim units = reader.GetValue(reader.GetOrdinal("Units"))

            Dim tmpBook = New Book(title, author, section, collection, units)
            b.dao._books.Add(tmpBook)
        End While
    End Sub
End Class