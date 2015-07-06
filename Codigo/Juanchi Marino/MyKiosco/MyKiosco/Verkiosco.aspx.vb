Imports LN
Public Class Verkiosco
    Inherits System.Web.UI.Page

    Dim gestorVerkioscos As VerkioscoLN
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            gestorVerkioscos = New VerkioscoLN()

            GridView1.DataSource = gestorVerkioscos.listakioscos
            GridView1.DataBind()

        End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class