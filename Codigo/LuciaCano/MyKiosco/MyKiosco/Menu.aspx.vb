Public Class Menu
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Productos_Click(sender As Object, e As EventArgs) Handles Productos.Click
        Response.Redirect("Productos.aspx")
    End Sub
End Class