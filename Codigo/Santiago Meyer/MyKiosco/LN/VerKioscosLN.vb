Imports ObjetosNegocio
Imports AccesoDatos

Public Class VerKioscosLN
    Public Property listaKioscos As List(Of Kiosko)
    Public Sub New()


        listaKioscos = KioskoAD.getallkioskos()

    End Sub
End Class
