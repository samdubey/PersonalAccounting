Public Class UserLogin
    Private UserName As String
    Private UserId As String
    Private Password As String
    Private MyLevel As UserLevel
    Public Enum UserLevel
        OPERATOR
        SUPERVISOR
        OWNER
    End Enum
    Public Function GetUserName() As String
        Return UserName
    End Function
    Public Function GetUserID() As String
        Return UserId
    End Function
    Public Function GetUserLevel() As UserLevel
        Return MyLevel
    End Function
    Public Sub New(ByVal UID As String, ByVal UName As String, ByVal Lev As Int16, ByVal Pass As String)
        UserId = UID
        UserName = UName
        Password = Pass
        MyLevel = Lev
    End Sub
End Class
