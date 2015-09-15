Imports [ON]
Imports LN
Public Class Productos
    Inherits System.Web.UI.Page
    Dim Gestor As ProductosLN

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            'Recuperar kiosco logueado 
            Dim KioscoLogueado As Kiosco = CType(Session("KioscoLogueado"), Kiosco)

            'Inicializar
            Gestor = New ProductosLN(KioscoLogueado)

            'cargar grilla
            GridView1.DataSource = Gestor.ListaProductos
            GridView1.DataBind()

            'guardar Gestor en Session
            Session("ProductosLN") = Gestor

        Else
            'recuperar el Gestor del Session
            Gestor = CType(Session("ProductosLN"), ProductosLN)

        End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub

    Protected Sub CmdAceptar_Click(sender As Object, e As EventArgs) Handles CmdAceptar.Click
        Gestor.RegistrarNuevoProducto(TxtNombre.Text, Double.Parse(TxtStock.Text), CmbUnidad.Text)

        GridView1.DataSource = Gestor.ListaProductos
        GridView1.DataBind()
        TxtNombre.Text = ""
        TxtStock.Text = ""

        Session("ProductosLN") = Gestor
    End Sub

    Protected Sub CmdCancelar_Click(sender As Object, e As EventArgs) Handles CmdCancelar.Click

    End Sub

    Protected Sub CmdEliminar_Click(sender As Object, e As EventArgs) Handles CmdEliminar.Click

    End Sub
End Class