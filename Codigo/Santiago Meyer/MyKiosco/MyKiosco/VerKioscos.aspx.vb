Imports LN


Public Class VerKioscos
    Inherits System.Web.UI.Page
    Dim gestorverkioskos As VerKioscosLN
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            gestorverkioskos = New VerKioscosLN()

            GridView1.DataSource = gestorverkioskos.listaKioscos
            GridView1.DataBind()

        End If
    End Sub

End Class