Imports [ON]
Imports System.Data.SqlClient
Public Class ProductoAD
    'Buscar los productos por kiosco
    Shared Function BuscarProductosPorIdKiosco(IdKiosco As Integer) As List(Of Producto)
        'abrir la base de datos
        Dim conexion As New SqlConnection
        'conexion.ConnectionString = "Data Source=Lucia-Pc;Initial Catalog='MiKiosco';User ID=sa;Password=esea"
        conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("SQLServer").ToString()

        'iniciar una transaccion


        'llamar a la insercion
        Dim comando As SqlCommand
        Dim query As String
        query = "SELECT * " & _
            "FROM Productos WHERE Pro_Kio_Id=@Pro_Kio_Id ORDER BY Pro_Nombre"


        conexion.Open()
        comando = New SqlCommand(query, conexion)
        comando.Parameters.AddWithValue("@Pro_Kio_Id", IdKiosco)

        Dim ListaProductos As New List(Of Producto)
        Dim DataReader As SqlDataReader

        DataReader = comando.ExecuteReader

        While (DataReader.Read())

            Dim Producto As New Producto
            Producto.Id = DataReader.GetInt32(0)
            Producto.Nombre = DataReader.GetString(1)
            Producto.Stock = DataReader.GetDecimal(2)
            Producto.Unidad = DataReader.GetString(3)

            ListaProductos.Add(Producto)

        End While

        Return ListaProductos

    End Function

    'Registrar un producto
    Shared Sub RegistrarProducto(Producto As Producto, IdKiosco As Integer)

        'abrir la base de datos
        Dim conexion As New SqlConnection
        'conexion.ConnectionString = "Data Source=Lucia-Pc;Initial Catalog='MiKiosco';User ID=sa;Password=esea"
        conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("SQLServer").ToString()

        'iniciar una transaccion


        'llamar a la insercion
        Dim comando As SqlCommand
        Dim query As String
        query = "INSERT INTO Productos " & _
            "(Pro_Nombre, Pro_Stock, Pro_Unidad, Pro_Kio_Id) VALUES " & _
            "(@Pro_Nombre, @Pro_Stock, @Pro_Unidad, @Pro_Kio_Id)"

        conexion.Open()
        comando = New SqlCommand(query, conexion)

        'pasar parámetros de la inserción
        comando.Parameters.AddWithValue("@Pro_Nombre", Producto.Nombre)
        comando.Parameters.AddWithValue("@Pro_Stock", Producto.Stock)
        comando.Parameters.AddWithValue("@Pro_Unidad", Producto.Unidad)
        comando.Parameters.AddWithValue("@Pro_Kio_Id", Producto.Id)


        'ejecutamos el comando
        comando.ExecuteNonQuery()


        'finalizar transacción


        'cerrar conección a la base de datos
        conexion.Close()
    End Sub

    'Modificar un producto
    'Eliminar un producto

End Class
