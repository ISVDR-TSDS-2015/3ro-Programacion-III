Public Class Kiosco
    'campos
    Public Property Id As Integer
    Public Property Usuario As String
    Public Property Password As String
    Public Property Nombre As String
    Public Property Activo As Boolean
    Public Property EMail As String

    'constructor 1
    Public Sub New()

    End Sub

    'constructor 2
    Public Sub New(ByVal _usuario As String, ByVal _password As String, ByVal _nombre As String, ByVal _email As String)
        Usuario = _usuario
        Password = _password
        Nombre = _nombre
        EMail = _email
    End Sub

End Class
