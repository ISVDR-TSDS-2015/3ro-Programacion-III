Imports [ON]
Imports LN

Public Class Login1

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Protected Sub CmdAceptar_Click(sender As Object, e As EventArgs) Handles CmdAceptar.Click

        Dim KioscoLogueado As New Kiosco
        Dim Gestor As New LoginLN

        'Loguear
        KioscoLogueado = Gestor.ValidarKiosco(TxtUsuario.Text, TxtContrasenia.Text)

        'Validar que este logueado
        If IsNothing(KioscoLogueado) Then
            LblResultado.Text = "No Logueado"
        Else

            Dim autTicket As FormsAuthenticationTicket
            autTicket = New FormsAuthenticationTicket(1, "MyKioscoLogin", DateTime.Now, DateTime.Now.AddMinutes(20), False, KioscoLogueado.Usuario & "|" & "USUARIO") 'Username|Rol

            'Encriptar el ticket
            Dim encrTicket As String = FormsAuthentication.Encrypt(autTicket)

            'Crea una cookie con el ticket encriptado
            Dim autCookie As HttpCookie = New HttpCookie(".MyKiosco", encrTicket)

            'Agrego la cookie
            Response.Cookies.Add(autCookie)

            Session.Add("KioscoLogueado", KioscoLogueado)

            If IsNothing(Request.QueryString("ReturnUrl")) Then
                Response.Redirect("Menu.aspx")
            Else
                Response.Redirect(Request.QueryString("ReturnUrl"))
            End If

            LblResultado.Text = "Kiosco Logueado!!! Nombre: " + KioscoLogueado.Nombre

        End If

    End Sub

End Class