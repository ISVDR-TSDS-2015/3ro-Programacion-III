Imports [ON]
Imports AD
Public Class ProductosLN
    'Atributos
    Public Property ListaProductos As List(Of Producto)
    Public Property ProductoSeleccionado As Producto = Nothing
    Private kioscoLogueado As Kiosco


    'Metodos / Acciones / Inteligencia del Gestor

    'Buscar todos los producto del kiosco logueado
    Sub New(Kiosco As Kiosco)
        kioscoLogueado = Kiosco
        ListaProductos = ProductoAD.BuscarProductosPorIdKiosco(kioscoLogueado.Id)
    End Sub

    'Seleccionar un producto

    'Cancelar la seleccion

    'Agregar un nuevo producto
    Sub RegistrarNuevoProducto(Nombre As String, Stock As Double, Unidad As String)
        'creamos el objeto
        Dim Producto As New Producto
        Producto.Nombre = Nombre
        Producto.Stock = Stock
        Producto.Unidad = Unidad

        'registramos en acceso datos
        ProductoAD.RegistrarProducto(Producto, kioscoLogueado.Id)

        'recargamos la lista
        ListaProductos = ProductoAD.BuscarProductosPorIdKiosco(kioscoLogueado.Id)

    End Sub

    'Eliminar un producto



End Class

