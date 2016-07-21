Public Class Book
    Property title As String
    Property author As String
    Property section As String
    Property collection As String
    Property units As Integer
    Property dao As DAOBook

    Public Sub New(ByVal title As String, ByVal author As String)
        Me._title = Me.FirstToUpper(title)
        Me._author = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(author) 'capitalized first letter of each word
        Me._section = "None"
        Me._collection = "None"
        Me._units = 1
        Me._dao = New DAOBook()
    End Sub

    Public Sub New(ByVal title As String, ByVal author As String, ByVal section As String, ByVal collection As String)
        Me.New(title, author)

        section = If(section <> String.Empty, section, "None")
        Me._section = Me.FirstToUpper(section)

        collection = If(collection <> String.Empty, collection, "None")
        Me._collection = Me.FirstToUpper(collection)
    End Sub

    Public Sub New(ByVal title As String, ByVal author As String, ByVal section As String, ByVal collection As String, ByVal units As Integer)
        Me.New(title, author, section, collection)
        Me.units = units
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

    Overrides Function ToString() As String
        Return Me.title + " | " + Me.author + " | " + Me.section + " | " + Me.collection + " | " + CStr(Me.units)
    End Function

    Private Function FirstToUpper(ByRef name As String) As String
        Return name.Substring(0, 1).ToUpper() + name.Substring(1)
    End Function
End Class
