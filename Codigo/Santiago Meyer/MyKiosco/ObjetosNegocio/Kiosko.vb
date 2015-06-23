Public Class Kiosko
    Public Property id As Integer
    Public Property usuario As String
    Public Property password As String
    Public Property nombre As String
    Public Property activo As Boolean
    Public Property email As String

    'constructor I
    Public Sub New()

    End Sub

    Public Sub New(ByVal _usuario As String, ByVal _password As String, ByVal _nombre As String, ByVal _email As String)
        usuario = _usuario
        password = _password
        nombre = _nombre
        email = _email
    End Sub
End Class
