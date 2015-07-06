Imports [ON]
Imports AD

Public Class RegistrarkioscoLN
    Dim nuevokiosco As Kiosco
    Public Property listaciudades As List(Of Ciudades)
    Dim ciudadseleccionada As Ciudades

    Public Sub New()
        nuevokiosco = New Kiosco()
        listaciudades = CiudadAD.BuacarTodos

    End Sub


    Public Sub registrarkiosco(ByVal _usuario As String, ByVal _password As String, _
                               ByVal _nombre As String, ByVal _email As String, ByVal _idciudad As Integer)

        For Each ciudad In listaciudades
            If ciudad.ID = _idciudad Then
                ciudadseleccionada = ciudad
            End If
        Next



        nuevokiosco = New Kiosco(_usuario, _password, _nombre, _email, ciudadseleccionada)

        'grabar en la base de datos

        'Dim kioscoAD As kioscoAD = New kioscoAD
        'kioscoAD.registrarkiosco(nuevokiosco)

        'con shared en el metodo registrarkiosco
        kioscoAD.registrarkiosco(nuevokiosco)
    End Sub
End Class
