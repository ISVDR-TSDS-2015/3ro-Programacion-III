Imports [ON]
Imports AD

Public Class RegistrarKioscoLN
    Dim NuevoKiosco As Kiosco
    Public Property ListaCiudades As List(Of Ciudad)
    Dim CiudadSeleccionada As Ciudad

    Public Sub New() 'es un constructor, un metodo que hace que la clase se cree e inicialize
        NuevoKiosco = New Kiosco()
        ListaCiudades = CiudadAD.BuscarTodos

    End Sub

    Public Sub RegistrarKiosco(ByVal _usuario As String, ByVal _pasaword As String, ByVal _nombre As String, ByVal _email As String, ByVal _ciudad As Integer)

        For Each Ciudad In ListaCiudades
            If Ciudad.Id = _ciudad Then
                CiudadSeleccionada = Ciudad
            End If
        Next
        NuevoKiosco = New Kiosco(_usuario, _pasaword, _nombre, _email, CiudadSeleccionada)

        'grabar en la base de datos
        'Dim KioscoAD As New KioscoAD
        'KioscoAD.RegistrarKiosco(NuevoKiosco)

        'con shared en el método RegistrarKiosco
        KioscoAD.RegistrarKiosco(NuevoKiosco)

    End Sub

End Class
