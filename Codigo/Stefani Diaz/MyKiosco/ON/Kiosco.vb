Public Class Kiosco
    ' campos
    Public Property Id As Integer
    Public Property Usuario As String
    Public Property Password As String
    Public Property Nombre As String
    Public Property Activo As Boolean
    Public Property Email As String
    Public Property ciudad As Ciudad
    'propiedad cuidad del objeto ciudad

    Public ReadOnly Property NombreCiudad() As String
        Get
            Return ciudad.descripcion
        End Get
    End Property

    'constructor 1

    Public Sub New()

    End Sub
    'constructor 2
    'modificar agregando ciudad

    Public Sub New(ByVal _usuario As String, ByVal _password As String, _
                    ByVal _nombre As String, ByVal _email As String, ByVal _ciudad As Ciudad)
        Usuario = _usuario
        Password = _password
        Nombre = _nombre
        Email = _email
        ciudad = _ciudad

    End Sub
    'constructor 3
    'modificar agregando ciudad
    Public Sub New(ByVal _id As Integer, ByVal _usuario As String, ByVal _password As String, _
                  ByVal _nombre As String, ByVal _activo As Boolean, ByVal _email As String, ByVal _ciudad As Ciudad)
        Id = _id
        Usuario = _usuario
        Password = _password
        Nombre = _nombre
        Activo = _activo
        Email = _email
        ciudad = _ciudad


    End Sub

End Class
