Public Class DAOBook
    Property _books As Collection

    Public Sub New()
        Me._books = New Collection
    End Sub

    Public Sub read(ByRef b As Book)
        Dim comm As String = "SELECT * FROM Books WHERE Title='" & b.title & "', Author='" & b.author & "';"
        Dim reader As OleDb.OleDbDataReader = DDBBBroker.getInstance.read(comm)
        reader.Read()
        b.title = reader.GetString(1)
        b.author = reader.GetString(2)
        b.section = reader.GetString(3)
        b.units = CInt(reader.GetString(4))

    End Sub


    Public Function delete(ByVal b As Book) As Integer
        Dim comm As String = ""     '"DELETE FROM Books WHERE Title=" & b.id & ";"
        Return DDBBBroker.getInstance().change(comm)
    End Function


    Public Function update(ByVal b As Book) As Integer
        Dim comm As String = "UPDATE Books SET Title='" & b.title & "', Author='" & b.author & "', Section='" & b.section & "', Units='" & b.units & "' WHERE Title=" & b.title & "', Author='" & b.author & "';"
        Return DDBBBroker.getInstance().change(comm)
    End Function


    Public Function create(ByVal b As Book) As Integer
        'try to insert; if exists read number of Units, add 1 and update book

        Dim comm_insert As String = "INSERT INTO Books VALUES ('" & b.title & "','" & b.author & "', '" & b.section & "', '1');"

        Try
            Return DDBBBroker.getInstance().change(comm_insert)
        Catch ex As Exception 'it already exists
            read(b)
            b.units += 1
            Return update(b)
        End Try

    End Function


    Public Sub readAll(ByRef b As Book) 'returns an OleDBDataReader data structure
        Dim comm As String = "SELECT * FROM Books ORDER BY Title;"
        Dim readerAux As OleDb.OleDbDataReader = DDBBBroker.getInstance().read(comm)

        While readerAux.Read() 'title / author / section / units
            b.dao._books.Add(New Book(readerAux.GetValue(0), readerAux.GetString(1), readerAux.GetValue(2), CInt(readerAux.GetValue(3))))
        End While
    End Sub
End Class