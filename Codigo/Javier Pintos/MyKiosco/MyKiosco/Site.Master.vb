Imports [ON]

Public Class Site
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim kioscoLogueado As Kiosco
        kioscoLogueado = CType(Session("kioscoLogueado"), Kiosco)
        If IsNothing(kioscoLogueado) Then
            cmdLogin.Visible = True
        Else
            cmdLogout.Visible = True
            lblUsuario.Visible = True
            lblUsuario.Text = "Hola " & kioscoLogueado.Nombre & "!!!"
        End If
    End Sub

    Protected Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Response.Redirect("Login.aspx")
    End Sub

    Protected Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        ' Borrar el Kiosco Logueado del Session
        Session.Remove("KioscoLogueado")
        Session.RemoveAll()

        ' Borramos el usuario del Context
        Context.User = Nothing

        ' Creamos una Cookie para pisar la de logueo
        'Nuevo Ticket 
        Dim autTicket As FormsAuthenticationTicket
        autTicket = New FormsAuthenticationTicket(1, "MyKioscoLogin", DateTime.Now, DateTime.Now.AddMinutes(-1), _
                                                  False, "|")
        'Encriptar el ticket
        Dim encrTicket As String = FormsAuthentication.Encrypt(autTicket)
        'Crea una cookie con el ticket encriptado
        Dim autCookie As HttpCookie = New HttpCookie(".MyKiosco", encrTicket)
        'Agrego la Cookie
        Response.Cookies.Add(autCookie)

        ' Redireccionamos el Default.aspx
        Response.Redirect("Default.aspx")

    End Sub
End Class