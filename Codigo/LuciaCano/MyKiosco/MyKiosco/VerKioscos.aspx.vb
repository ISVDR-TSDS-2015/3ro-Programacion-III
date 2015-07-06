Imports LN

Public Class VerKioscos
    Inherits System.Web.UI.Page
    Dim GestorVerKioscos As VerKioscosLN

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            GestorVerKioscos = New VerKioscosLN

            Grl_VerKioscos.DataSource = GestorVerKioscos.ListaKioscos
            Grl_VerKioscos.DataBind()

        End If

    End Sub

  
End Class