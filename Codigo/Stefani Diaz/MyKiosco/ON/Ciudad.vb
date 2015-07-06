Public Class Ciudad
    Public Property id As Integer
    Public Property descripcion As String

    Public Sub New()


    End Sub

    Public Sub New(ByVal _id As Integer, ByVal _descripcion As String)
        id = _id
        descripcion = _descripcion
    End Sub


End Class
