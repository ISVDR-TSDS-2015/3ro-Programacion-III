Imports System.Web.SessionState
Imports System.Security.Principal

Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al iniciar la aplicación
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al iniciar la sesión
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al comienzo de cada solicitud
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al intentar autenticar el uso

        'Recupero la cookie
        Dim authCookie As HttpCookie = Context.Request.Cookies(".MyKiosco")

        'si no existe termina
        If IsNothing(authCookie) Then
            Return
        End If

        'desencriptamos el ticket
        Dim autTicket As FormsAuthenticationTicket = Nothing
        autTicket = FormsAuthentication.Decrypt(authCookie.Value)

        'separo los roles
        Dim usuario As String() = autTicket.UserData.Split("|") 'Username|Rol



        'Creo un objeto Identity y lo vinculo al Context
        Dim KioscoGenerico As New GenericIdentity(usuario(0))
        Dim Roles As String() = New String() {usuario(1)}
        Dim Principal As New GenericPrincipal(KioscoGenerico, Roles)
        Context.User = Principal

    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando se produce un error
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando finaliza la sesión
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando finaliza la aplicación
    End Sub

End Class