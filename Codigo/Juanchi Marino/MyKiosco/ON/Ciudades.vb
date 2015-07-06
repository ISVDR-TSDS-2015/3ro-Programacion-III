Public Class Ciudades
    'campos
    Public Property ID As Integer
    Public Property Nombre As String


    'contruto 1
    Public Sub New()
    End Sub
    'contructo 2
    Public Sub New(ByVal _nombre As String)

        Nombre = _nombre

    End Sub

    'contructo 3
    Public Sub New(ByVal _id As Integer, ByVal _nombre As String)
        ID = _id
        Nombre = _nombre

    End Sub
End Class
