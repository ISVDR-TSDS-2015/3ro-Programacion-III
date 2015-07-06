Imports [ON]
Imports AD

Public Class VerKioscosLN
    Public Property listaKiosco As List(Of Kiosco)

    Public Sub New()
        listaKiosco = KioscoAD.BuscarTodos()

    End Sub
End Class
