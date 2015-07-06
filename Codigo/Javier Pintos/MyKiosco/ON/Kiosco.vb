Public Class Kiosco
    'Campos
    Public Property Id As Integer
    Public Property Usuario As String
    Public Property Password As String
    Public Property Nombre As String
    Public Property Activo As Boolean
    Public Property EMail As String
    Public Property Ciudad As Ciudad

    'Contructo 1
    Public Sub New()

    End Sub

    'Contructo 2
    Public Sub New(ByVal _usuario As String, ByVal _password As String, _
                   ByVal _nombre As String, ByVal _email As String, _
                   ByVal _ciudad As Ciudad)
        Usuario = _usuario
        Password = _password
        Nombre = _nombre
        EMail = _email
        Ciudad = _ciudad
    End Sub

    'Contructo 3
    Public Sub New(ByVal _id As Integer, ByVal _usuario As String, _
                   ByVal _password As String, ByVal _nombre As String, _
                   ByVal _activo As Boolean, ByVal _email As String, _
                   ByVal _ciudad As Ciudad)
        Id = _id
        Usuario = _usuario
        Password = _password
        Nombre = _nombre
        Activo = _activo
        EMail = _email
        Ciudad = _ciudad
    End Sub

    Public ReadOnly Property NombreCiudad As String
        Get
            Return Ciudad.Nombre
        End Get
    End Property
End Class
