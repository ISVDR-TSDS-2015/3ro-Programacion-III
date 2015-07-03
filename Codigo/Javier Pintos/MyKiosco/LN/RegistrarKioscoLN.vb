Imports [ON]
Imports AD

Public Class RegistrarKioscoLN
    Dim NuevoKiosco As Kiosco
    Public Property listaCiudades As List(Of Ciudad)
    Dim ciudadSeleccionada As Ciudad

    Public Sub New()
        NuevoKiosco = New Kiosco()
        listaCiudades = CiudadAD.BuscarTodos()
    End Sub

    Public Sub RegistrarKiosco(ByVal _usuario As String, ByVal _password As String, _
                               ByVal _nombre As String, ByVal _email As String, _
                               ByVal _idCiudad As Integer)

        For Each ciudad In listaCiudades
            If ciudad.Id = _idCiudad Then
                ciudadSeleccionada = ciudad
            End If
        Next

        NuevoKiosco = New Kiosco(_usuario, _password, _nombre, _
                                 _email, ciudadSeleccionada)

        KioscoAD.RegistrarKiosco(NuevoKiosco)

    End Sub

End Class
