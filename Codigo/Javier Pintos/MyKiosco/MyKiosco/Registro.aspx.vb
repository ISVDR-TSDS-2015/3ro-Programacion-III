Imports LN

Public Class Registro
    Inherits System.Web.UI.Page
    Dim gestorRegistrarKiosco As RegistrarKioscoLN

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            gestorRegistrarKiosco = New RegistrarKioscoLN()

            DropDownList1.DataSource = gestorRegistrarKiosco.listaCiudades
            DropDownList1.DataTextField = "Nombre"
            DropDownList1.DataValueField = "Id"
            DropDownList1.DataBind()

            Session.Add("RegistrarKioscoLN", gestorRegistrarKiosco)
        Else
            gestorRegistrarKiosco = CType(Session("RegistrarKioscoLN"), RegistrarKioscoLN)
        End If
    End Sub

    Protected Sub btnRegistrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRegistrar.Click
        If IsValid Then
            gestorRegistrarKiosco.RegistrarKiosco(txtUsuario.Text, txtPassword.Text, _
                                              txtNombre.Text, txtEMail.Text, DropDownList1.SelectedItem.Value)
        End If
    End Sub
End Class