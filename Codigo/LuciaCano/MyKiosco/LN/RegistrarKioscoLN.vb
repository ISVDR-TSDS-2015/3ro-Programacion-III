Imports [ON]
Imports AD

Public Class RegistrarKioscoLN
    Dim NuevoKiosco As Kiosco

    Public Sub New() 'es un constructor, un metodo que hace que la clase se cree e inicialize
        NuevoKiosco = New Kiosco()
    End Sub

    Public Sub RegistrarKiosco(ByVal _usuario As String, ByVal _pasaword As String, ByVal _nombre As String, ByVal _email As String)

        NuevoKiosco = New Kiosco(_usuario, _pasaword, _nombre, _email)

        'grabar en la base de datos
        'Dim KioscoAD As New KioscoAD
        'KioscoAD.RegistrarKiosco(NuevoKiosco)

        'con shared en el método RegistrarKiosco
        KioscoAD.RegistrarKiosco(NuevoKiosco)

    End Sub

End Class
