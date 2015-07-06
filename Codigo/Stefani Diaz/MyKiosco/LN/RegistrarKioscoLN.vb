Imports [ON]
Imports AD

Public Class RegistrarKioscoLN
    Dim NuevoKiosco As Kiosco
    Dim ciudadSeleccionada As Ciudad
    Public Property listaCiudades As List(Of Ciudad)
    Public Sub New() ''esto es un constructor
        NuevoKiosco = New Kiosco()
        listaCiudades = CiudadAD.BuscarTodas()
    End Sub

    Public Sub RegistrarKiosco(ByVal _usuario As String, ByVal _password As String, _
                                ByVal _nombre As String, ByVal _email As String, ByVal _ciudad As Integer)
        ''''''''''''''''
        For Each Ciudad In listaCiudades
            If Ciudad.id = _ciudad Then
                ciudadSeleccionada = Ciudad
            End If
        Next


        NuevoKiosco = New Kiosco(_usuario, _password, _nombre, _email, ciudadSeleccionada)

        'grabar en la base de datos

        'Dim KioscoAD As New KioscoAD
        'KioscoAD.RegistrarKiosco(NuevoKiosco)


        ' con shared en el metodo RegistrarKiosco
        KioscoAD.RegistrarKiosco(NuevoKiosco)

    End Sub


End Class
