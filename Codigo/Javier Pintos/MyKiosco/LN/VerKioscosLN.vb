Imports [ON]
Imports AD

Public Class VerKioscosLN
    Public Property listaKioscos As List(Of Kiosco)

    Public Sub New()
        listaKioscos = KioscoAD.BuscarTodos()
    End Sub
End Class
