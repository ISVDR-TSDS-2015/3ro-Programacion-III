Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports [ON]
Imports LN

' Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class WSMyKiosco
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hola a todos"
    End Function

    <WebMethod()> _
    Public Function ListaTodosLosKioscos() As List(Of Kiosco)
        Dim gestor As New VerKioscosLN()
        Return gestor.listaKioscos
    End Function

    <WebMethod()> _
    Public Function ListaKioscosPorNombre(ByVal nombre As String) As List(Of Kiosco)
        Dim gestor As New VerKioscosLN(nombre)
        Return gestor.listaKioscos
    End Function

End Class