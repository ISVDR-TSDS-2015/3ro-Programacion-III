Imports [ON]
Imports System.Data.SqlClient
Public Class CiudadAD
    Public Shared Sub registrar(ByVal _ciudad As Ciudades)
        'Abrir la Base de Dato
        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Data Source=JUANMARINO-PC\SQLEXPRESS;Initial Catalog='My Kiosco';User ID=sa;Password=esea"
        'Llamar a la insercion
        Dim comando As SqlCommand
        Dim query As String
        query = "insert into ciudad (ciu_id, ciu_nombre) values (@ciu_id, @ciu_nombre)"

        conexion.Open()
        comando = New SqlCommand(query, conexion)

        'pasar parametros de la incercion
        comando.Parameters.AddWithValue("@ciu_id,", _Ciudad.ID)
        comando.Parameters.AddWithValue("@ciu_nombre", _Ciudad.Nombre)


        'ejecutamos el prametro
        comando.ExecuteNonQuery()

        'Cerrar conexcion a la base de datos
        conexion.Close()


    End Sub
    Public Shared Function BuacarTodos() As List(Of Ciudades)
        'Abrir la Base de Dato
        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Data Source=JUANMARINO-PC\SQLEXPRESS;Initial Catalog='My Kiosco';User ID=sa;Password=esea"
        'Llamar a la insercion
        Dim comando As SqlCommand
        Dim query As String
        query = "select ciu_id, ciu_nombre " & _
        "from ciudades order by ciu_nombre"

        conexion.Open()
        comando = New SqlCommand(query, conexion)

        Dim listaciudades As New List(Of Ciudades)
        Dim datareader As SqlDataReader

        datareader = comando.ExecuteReader

        While (datareader.Read)
            listaciudades.Add(New Ciudades(datareader.GetInt32(0), _
                                        datareader.GetString(1)))



        End While

        Return listaciudades
    End Function
End Class
