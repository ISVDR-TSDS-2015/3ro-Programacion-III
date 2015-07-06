Imports [ON]
Imports AD

Public Class VerKioscosLN

    Public Property ListaKioscos As List(Of Kiosco)

    Public Sub New()

        ListaKioscos = KioscoAD.BuscarTodos()

    End Sub

End Class
