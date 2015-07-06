Imports LN
Public Class VerKioscos1

    Inherits System.Web.UI.Page
    Dim GestorVerKioscos As VerKioscosLN

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            GestorVerKioscos = New VerKioscosLN

            GrlGrilla.DataSource = GestorVerKioscos.listaKiosco
            GrlGrilla.DataBind()

        End If
    End Sub

End Class