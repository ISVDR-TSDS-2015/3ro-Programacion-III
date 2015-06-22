Imports LN

Public Class Registro
    Inherits System.Web.UI.Page

    Dim gestorRegistrarKiosko As registrarKioskoLN

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            gestorRegistrarKiosko = New registrarKioskoLN()
            Session.Add("registrarKioskoLN", gestorRegistrarKiosko)
        Else
            gestorRegistrarKiosko = CType(Session("registrarKioskoLN"), registrarKioskoLN)
        End If
    End Sub

    Protected Sub btnRegistrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRegistrar.Click
        If IsValid Then
            gestorRegistrarKiosko.registrarkiosko(txtUsuario.Text, txtPassword.Text, _
                                                          txtNombre.Text, txtEMail.Text)
        End If


    End Sub
End Class