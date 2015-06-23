Imports LN

Public Class Registro
    Inherits System.Web.UI.Page
    Dim GestorRegistrarKiosco As RegistrarKioscoLN

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            GestorRegistrarKiosco = New RegistrarKioscoLN()
            Session.Add("RegistrarKioscoLN", GestorRegistrarKiosco)
        Else
            GestorRegistrarKiosco = CType(Session("RegistrarKioscoLN"), RegistrarKioscoLN)
        End If
    End Sub

    Protected Sub btnRegistrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRegistrar.Click
        If IsValid Then
            GestorRegistrarKiosco.RegistrarKiosco(txtUsuario.Text, txtPassword.Text, txtNombre.Text, txtEMail.Text)

        End If
    End Sub
End Class