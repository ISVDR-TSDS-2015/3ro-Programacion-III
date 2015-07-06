Imports [ON]
Imports System.Data.SqlClient
Public Class kioscoAD
    Public Shared Sub registrarkiosco(ByVal _kiosco As Kiosco)
        'Abrir la Base de Dato
        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Data Source=JUANMARINO-PC\SQLEXPRESS;Initial Catalog='My Kiosco';User ID=sa;Password=esea"
        'Llamar a la insercion
        Dim comando As SqlCommand
        Dim query As String
        query = "insert into kioscos (kio_usuario, kio_password, kio_nombre, kio_email, kio_ciu_id) values (@kio_usuario, @kio_password, @kio_nombre, @kio_email, @kio_ciu_id)"

        conexion.Open()
        comando = New SqlCommand(query, conexion)

        'pasar parametros de la incercion
        comando.Parameters.AddWithValue("@kio_usuario", _kiosco.Usuario)
        comando.Parameters.AddWithValue("@kio_password", _kiosco.Password)
        comando.Parameters.AddWithValue("@kio_nombre", _kiosco.Nombre)
        comando.Parameters.AddWithValue("@kio_email", _kiosco.Email)
        comando.Parameters.AddWithValue("@kio_ciu_id", _kiosco.Ciudad.ID)

        'ejecutamos el prametro
        comando.ExecuteNonQuery()

        'Cerrar conexcion a la base de datos
        conexion.Close()


    End Sub


    Public Shared Function BuacarTodos() As List(Of Kiosco)
        'Abrir la Base de Dato
        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Data Source=JUANMARINO-PC\SQLEXPRESS;Initial Catalog='My Kiosco';User ID=sa;Password=esea"
        'Llamar a la insercion
        Dim comando As SqlCommand
        Dim query As String
        query = "select kio_id, kio_usuario, kio_password, kio_nombre, " & _
            "kio_activo,kio_email " & _
        "from kioscos order by kio_nombre"

        conexion.Open()
        comando = New SqlCommand(query, conexion)

        Dim listakiosco As New List(Of Kiosco)
        Dim datareader As SqlDataReader

        datareader = comando.ExecuteReader

        While (datareader.Read)
            listakiosco.Add(New Kiosco(datareader.GetInt32(0), _
                                        datareader.GetString(1), _
                                         datareader.GetString(2), _
                                          datareader.GetString(3), _
                                          datareader.GetBoolean(4), _
                                          datareader.GetString(5)))


        End While

        Return listakiosco
    End Function

End Class
