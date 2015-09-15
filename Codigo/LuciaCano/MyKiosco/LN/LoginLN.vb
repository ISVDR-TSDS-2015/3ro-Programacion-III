Imports [ON]
Imports AD
Public Class LoginLN

    Function ValidarKiosco(Usuario As String, Contrasenia As String) As Kiosco

        Return KioscoAD.GetKioscoPorUsuarioPassword(Usuario, Contrasenia)

    End Function

End Class
