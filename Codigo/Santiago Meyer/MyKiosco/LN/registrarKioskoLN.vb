Imports ObjetosNegocio
Imports AccesoDatos

Public Class registrarKioskoLN
    Dim nuevokiosko As kiosko


    Public Sub New()
        nuevokiosko = New Kiosko()
    End Sub
    Public Sub registrarkiosko(ByVal _usuario As String, ByVal _password As String, _
                               ByVal _nombre As String, ByVal _email As String)

        nuevokiosko = New Kiosko(_usuario, _password, _nombre, _email)
        'grabar en la bd
        'Dim KioskoAD As New KioskoAD()
        'KioskoAD.registrarkiosko(nuevokiosko)

        KioskoAD.registrarkiosko(nuevokiosko)
    End Sub
End Class
