Imports LN
Public Class Registro
    Inherits System.Web.UI.Page
    Dim gestorRegistrarkiosco As RegistrarkioscoLN

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            gestorRegistrarkiosco = New RegistrarkioscoLN
            DropDownList1.DataSource = gestorRegistrarkiosco.listaciudades
            DropDownList1.DataValueField = "Id"
            DropDownList1.DataTextField = "Nombre"
            DropDownList1.DataBind()


            Session.Add("RegistrarkioscoLN", gestorRegistrarkiosco)
        Else
            gestorRegistrarkiosco = CType(Session("RegistrarkioscoLN"), RegistrarkioscoLN)
        End If
    End Sub

    Protected Sub btnRegistrar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRegistrar.Click
        If IsValid Then
            gestorRegistrarkiosco.registrarkiosco(txtNombre.Text, txtPassword.Text, txtUsuario.Text, txtEMail.Text, DropDownList1.SelectedItem.Value)
        End If
    End Sub

    
End Class