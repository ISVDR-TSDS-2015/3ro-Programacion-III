Public Class Kiosco

    'campos
    Public Property ID As Integer
    Public Property Usuario As String
    Public Property Password As String
    Public Property Nombre As String
    Public Property Activo As Boolean
    Public Property Email As String
    Public Property Ciudad As Ciudades

    'contruto 1
    Public Sub New()
    End Sub
    'contructo 2
    Public Sub New(ByVal _usuario As String, ByVal _password As String, ByVal _nombre As String, ByVal _email As String)
        Usuario = _usuario
        Password = _password
        Nombre = _nombre
        Email = _email
    End Sub

    'contructo 3
    Public Sub New(ByVal _id As Integer, ByVal _usuario As String, ByVal _password As String, ByVal _nombre As String, ByVal _activo As Boolean, ByVal _email As String)
        ID = _id
        Usuario = _usuario
        Password = _password
        Nombre = _nombre
        Activo = _activo
        Email = _email
    End Sub

    Public Sub New(ByVal _usuario As String, ByVal _password As String, ByVal _nombre As String, ByVal _email As String, ByVal _ciudad As Ciudades)
        Usuario = _usuario
        Password = _password
        Nombre = _nombre
        Email = _email
        Ciudad = _ciudad
    End Sub
End Class
