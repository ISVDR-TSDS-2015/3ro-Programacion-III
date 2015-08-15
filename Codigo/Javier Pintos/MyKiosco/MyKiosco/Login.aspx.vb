Imports LN
Imports [ON]

Public Class Login1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim kioscoLogueado As New Kiosco
        Dim gestor As New LoginLN

        ' Loguear
        kioscoLogueado = gestor.validarKiosco(txtUsuario.Text, txtContrasenia.Text)

        ' Validar que esté logueado
        If IsNothing(kioscoLogueado) Then
            lblResultado.Text = "No Logueado"
        Else
            lblResultado.Text = "Kiosko Logueado!!! Nombre: " + kioscoLogueado.Nombre
        End If

    End Sub
End Class