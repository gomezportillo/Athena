Public Class Book
    Property title As String
    Property author As String
    Property section As String
    Property units As Integer
    Property dao As DAOBook

    Public Sub New(ByVal title As String, ByVal author As String)
        Me._title = StrConv(title, vbProperCase) 'first of sentence to upper
        Me._author = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(author) 'first of each word to upper
        Me._section = String.Empty
        Me._units = 0
        Me._dao = New DAOBook()
    End Sub

    Public Sub New(ByVal title As String, ByVal author As String, ByVal section As String)
        Me.New(title, author)
        Me._section = StrConv(section, vbProperCase)
    End Sub

    Public Sub New(ByVal title As String, ByVal author As String, ByVal section As String, ByVal units As Integer)
        Me.New(title, author, section)
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
        Return Me.title + " | " + Me.author + " | " + Me.section + " | " + CStr(Me.units)
    End Function

End Class
