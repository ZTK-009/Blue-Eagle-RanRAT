Public Class User
    Private name As String
    Private password As String
    Private Back As String

    Public Sub New(ByVal name As String, ByVal pass As String)
        Me.name = name
        Me.password = pass
    End Sub
    Public Sub SetBack(ByVal back)
        Me.Back = back
    End Sub
    Public Function getname() As String
        Return name
    End Function
    Public Function getpass() As String
        Dim x As String = password
        Return x
    End Function
End Class
