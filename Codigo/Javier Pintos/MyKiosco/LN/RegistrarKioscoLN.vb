Imports [ON]
Imports AD

Public Class RegistrarKioscoLN
    Dim NuevoKiosco As Kiosco

    Public Sub New()
        NuevoKiosco = New Kiosco()
    End Sub

    Public Sub RegistrarKiosco(ByVal _usuario As String, ByVal _password As String, _
                               ByVal _nombre As String, ByVal _email As String)

        NuevoKiosco = New Kiosco(_usuario, _password, _nombre, _email)

        'grabar en la base de datos

        'Dim kioscoAD As New KioscoAD
        'kioscoAD.RegistrarKiosco(NuevoKiosco)

        ' con Shared en el metodo RegistrarKiosco
        KioscoAD.RegistrarKiosco(NuevoKiosco)

    End Sub

End Class
