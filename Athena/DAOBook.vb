Public Class DAOBook
    Property _books As Collection

    Public Sub New()
        Me._books = New Collection
    End Sub

    Public Sub read(ByRef b As Book)
        Dim comm As String = ""     '"SELECT * FROM Books WHERE IdBooko='" & b.id & "';"
        Dim reader As OleDb.OleDbDataReader = DDBBBroker.getInstance.read(comm)
        reader.Read()
        b.title = reader.GetString(1)
        b.author = reader.GetString(2)
        b.section = reader.GetString(3)
        b.units = CInt(reader.GetString(4))

    End Sub


    Public Function delete(ByVal b As Book) As Integer 'returns # of changed rows (should be 1)
        Dim comm As String = ""     '"DELETE FROM Books WHERE Title=" & b.id & ";"
        Return DDBBBroker.getInstance().change(comm)
    End Function


    Public Function update(ByVal b As Book) As Integer 'returns # of changed rows (should be 1)
        Dim comm As String = ""     '"UPDATE Books SET PrecioBooko='" & System.Convert.ToString(b.price) & "', DescripciónBooko='" & b.description & "' WHERE IdBooko=" & b.id & ";"
        Return DDBBBroker.getInstance().change(comm)
    End Function


    Public Function create(ByVal b As Book) As Integer 'returns # of changed rows (should be 1)
        Dim comm As String = ""     '"INSERT INTO Books VALUES ('" & b.id & "','" & b.description & "', '" & b.price & "');"
        Return DDBBBroker.getInstance().change(comm)
    End Function


    Public Sub readAll(ByRef b As Book) 'returns an OleDBDataReader data structure
        Dim comm As String = "SELECT * FROM Books ORDER BY Title;"
        Dim readerAux As OleDb.OleDbDataReader = DDBBBroker.getInstance().read(comm)

        While readerAux.Read() 'title / author / section
            b.dao._books.Add(New Book(readerAux.GetValue(1), readerAux.GetString(2), readerAux.GetValue(3)))
        End While
    End Sub
End Class