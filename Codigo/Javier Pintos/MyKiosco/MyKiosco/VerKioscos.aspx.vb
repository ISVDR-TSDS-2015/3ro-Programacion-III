Imports LN

Public Class VerKioscos
    Inherits System.Web.UI.Page
    Dim gestorVerKioscos As VerKioscosLN

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            gestorVerKioscos = New VerKioscosLN()

            GridView1.DataSource = gestorVerKioscos.listaKioscos
            GridView1.DataBind()

        End If
    End Sub

End Class