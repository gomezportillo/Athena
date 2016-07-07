Imports Microsoft.VisualBasic

Public Class DDBBBroker
    Private Shared _connection_driver As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Athena.accdb"
    Private Shared _connection As OleDb.OleDbConnection
    Private Shared _instance As DDBBBroker


    Private Sub New()
        DDBBBroker._connection = New OleDb.OleDbConnection(_connection_driver)
        DDBBBroker._connection.Open()
    End Sub


    Public Shared Function getInstance() As DDBBBroker 'Shared == Static
        If _instance Is Nothing Then
            _instance = New DDBBBroker()
        End If
        Return _instance
    End Function


    Public Function read(ByVal sql As String) As OleDb.OleDbDataReader
        Dim command As New OleDb.OleDbCommand(sql, _connection) '== New SqlCommand(sql, _con)
        Return command.ExecuteReader
    End Function


    Public Function change(ByVal sql As String) As Integer
        Dim command As New OleDb.OleDbCommand(sql, _connection)
        Return command.ExecuteNonQuery 'number of changed rows
    End Function

End Class