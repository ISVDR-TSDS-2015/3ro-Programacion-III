Imports [ON]
Imports AD

Public Class VerKioscosLN

    Public Property listaKioscos As List(Of Kiosco)

    Public Sub New()
        listaKioscos = KioscoAD.BuscarTodos()
    End Sub

    Public Sub New(nombre As String)
        listaKioscos = KioscoAD.BuscarPorNombre(nombre)
    End Sub
End Class
