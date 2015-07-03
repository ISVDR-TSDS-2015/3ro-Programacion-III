Public Class Ciudad
    Public Property Id As Integer
    Public Property Nombre As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal _id As Integer, ByVal _nombre As String)
        Id = _id
        Nombre = _nombre
    End Sub
End Class
