Imports [ON]
Imports AD

Public Class VerKioscosLN

    Public Property ListaKioscos As List(Of Kiosco)

    Public Sub New()

        ListaKioscos = KioscoAD.BuscarTodos()

    End Sub

    Public Sub New(nombre As String)

        ListaKioscos = KioscoAD.BuscarPorNombre(nombre)

    End Sub


End Class
