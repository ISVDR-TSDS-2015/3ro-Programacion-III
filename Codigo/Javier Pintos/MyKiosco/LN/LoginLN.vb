Imports [ON]
Imports AD

Public Class LoginLN

    Function validarKiosco(usuario As String, contrasenia As String) As Kiosco

        Return KioscoAD.GetKioscoPorUsuarioPassword(usuario, contrasenia)

    End Function

End Class
