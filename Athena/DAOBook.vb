Public Class DAOBook
    Property _books As Collection

    Public Sub New()
        Me._books = New Collection
    End Sub

    Public Sub read(ByRef b As Book)
        Dim comm As String = "SELECT * FROM Books WHERE Title='" & b.title & "' AND Author='" & b.author & "';"
        Dim reader As OleDb.OleDbDataReader = DDBBBroker.getInstance.read(comm)
        reader.Read()
        b.title = reader.GetValue(0)
        b.author = reader.GetValue(1)
        b.section = reader.GetValue(2)
        b.collection = reader.GetValue(3)
        b.units = CInt(reader.GetValue(4))
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
        'try to insert; if exists then update with +1 units

        Try

            Dim comm_insert As String = "INSERT INTO Books VALUES ('" & b.title & "','" & b.author & "', '" & b.section & "', '" & b.collection & "', '" & b.units & "');"
            Return DDBBBroker.getInstance().change(comm_insert)

        Catch ex As Exception 'it already exists

            Dim comm As String = "UPDATE Books SET Units=Units+1 WHERE Title='" & b.title & "' AND Author='" & b.author & "';"
            Return DDBBBroker.getInstance().change(comm)

        End Try

    End Function

    Public Sub readAll(ByRef b As Book) 'returns an OleDBDataReader data structure
        Dim comm As String = "SELECT * FROM Books;"
        Dim readerAux As OleDb.OleDbDataReader = DDBBBroker.getInstance().read(comm)
        Dim tmpBook As Book
        Dim title, author, section, collection, units As String

        While readerAux.Read()
            title = readerAux.GetValue(0)
            author = readerAux.GetValue(1)
            section = readerAux.GetValue(2)
            collection = readerAux.GetValue(3)
            units = CInt(readerAux.GetValue(4))
            tmpBook = New Book(title, author, section, Collection, units)
            b.dao._books.Add(tmpBook)
        End While
    End Sub
End Class