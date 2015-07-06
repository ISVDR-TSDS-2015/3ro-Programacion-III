Imports LN

Public Class Registro
    Inherits System.Web.UI.Page

    Dim GestorRegistrarKiosco As RegistrarKioscoLN

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            GestorRegistrarKiosco = New RegistrarKioscoLN()

            Cbo_Ciudades.DataSource = GestorRegistrarKiosco.ListaCiudades
            Cbo_Ciudades.DataTextField = "Nombre"
            Cbo_Ciudades.DataValueField = "Id"
            Cbo_Ciudades.DataBind()

            Session.Add("RegistrarKioscoLN", GestorRegistrarKiosco)
        Else
            GestorRegistrarKiosco = CType(Session("RegistrarKioscoLN"), RegistrarKioscoLN)
        End If
    End Sub

    Protected Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        If IsValid Then
            GestorRegistrarKiosco.RegistrarKiosco(txtUsuario.Text, txtPassword.Text, txtNombre.Text, txtEMail.Text, Cbo_Ciudades.SelectedItem.Value)
        End If

        MsgBox("El Kiosco se cargó correctamente", MsgBoxStyle.Information, "Aviso")

    End Sub
End Class