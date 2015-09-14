Imports LN
Imports [ON]

Public Class Login1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim kioscoLogueado As New Kiosco
        Dim gestor As New LoginLN

        ' Loguear
        kioscoLogueado = gestor.validarKiosco(txtUsuario.Text, txtContrasenia.Text)

        ' Validar que esté logueado
        If IsNothing(kioscoLogueado) Then
            lblResultado.Text = "No Logueado"
        Else

            'Creo un Ticket de Autenticación
            Dim autTicket As FormsAuthenticationTicket
            autTicket = New FormsAuthenticationTicket(1, "MyKioscoLogin", DateTime.Now, DateTime.Now.AddMinutes(20), _
                                                      False, kioscoLogueado.Usuario & "|" & "USUARIO") 'Username | Rol

            'Encriptar el ticket
            Dim encrTicket As String = FormsAuthentication.Encrypt(autTicket)

            'Crea una cookie con el ticket encriptado
            Dim autCookie As HttpCookie = New HttpCookie(".MyKiosco", encrTicket)

            'Agrego la Cookie
            Response.Cookies.Add(autCookie)

            Session.Add("kioscoLogueado", kioscoLogueado)


            If IsNothing(Request.QueryString("ReturnUrl")) Then
                Response.Redirect("Default.aspx")
            Else
                Response.Redirect(Request.QueryString("ReturnUrl"))
            End If

            lblResultado.Text = "Kiosko Logueado!!! Nombre: " + kioscoLogueado.Nombre
        End If

    End Sub
End Class