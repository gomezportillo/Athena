Public Class Book
    Property title As String
    Property author As String
    Property section As String
    Property units As Integer
    Property dao As DAOBook

    Public Sub New(ByVal title As String, ByVal author As String, ByVal section As String)
        Me._title = title
        Me._author = author
        Me._section = section
        Me._dao = New DAOBook()
    End Sub

    Public Sub New()
        Me._dao = New DAOBook()
    End Sub

    Public Sub read()
        Me._dao.read(Me)
    End Sub

    Public Sub readAll()
        Me._dao.readAll(Me)
    End Sub

    Public Function delete() As Integer
        Return Me._dao.delete(Me)
    End Function

    Public Function update() As Integer
        Return Me._dao.update(Me)
    End Function

    Public Function create() As Integer
        Return Me._dao.create(Me)
    End Function


End Class
