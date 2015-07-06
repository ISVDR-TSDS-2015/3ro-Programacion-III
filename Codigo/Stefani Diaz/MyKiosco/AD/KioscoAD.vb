Imports [ON]
Imports System.Data.SqlClient
Public Class KioscoAD

    Public Shared Sub RegistrarKiosco(ByVal kiosco As Kiosco)
        'abrir la base de datos 
        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Data Source=STEFANI\SQLEXPRESS;Initial Catalog='MI KIOSCO';User ID=sa;Password=esea"


        'iniciar una transaccion



        'llamar a la insercion
        Dim comando As SqlCommand
        Dim query As String
        query = "Insert into Kiosco " & _
            "(kio_usuario, kio_password, kio_nombre, kio_email, kio_ciu_id) values " & _
            "(@kio_usuario, @kio_password, @kio_nombre, @kio_email, @kio_ciu_id)"

        conexion.Open()
        comando = New SqlCommand(query, conexion)


        'pasar paramentros de la insecion

        comando.Parameters.AddWithValue("@kio_usuario", kiosco.Usuario)
        comando.Parameters.AddWithValue("@kio_password", kiosco.Password)
        comando.Parameters.AddWithValue("@kio_nombre", kiosco.Nombre)
        comando.Parameters.AddWithValue("@kio_email", kiosco.Email)
        comando.Parameters.AddWithValue("@kio_ciu_id", kiosco.ciudad.id)


        'ejecutamos el comando
        comando.ExecuteNonQuery()


        'finalizar transaccion


        'cerrar conexion la base de datos

        conexion.Close()

    End Sub

    Public Shared Function BuscarTodos() As List(Of Kiosco)
        'abrir la base de datos 
        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Data Source=STEFANI\SQLEXPRESS;Initial Catalog='MI KIOSCO';User ID=sa;Password=esea"


        'iniciar una transaccion



        'llamar a la insercion
        Dim comando As SqlCommand
        Dim query As String
        query = "SELECT kiosco_id, kio_usuario, kio_password, kio_nombre, kio_activo, kio_email, kio_ciu_id FROM Kiosco Order by kio_nombre"

        conexion.Open()
        comando = New SqlCommand(query, conexion)

        'pasar lo q trajo a una lista de kioscos
        Dim listaKioscos As New List(Of Kiosco)
        Dim datareader As SqlDataReader
        datareader = comando.ExecuteReader

        While (datareader.Read())
            listaKioscos.Add(New Kiosco(datareader.GetInt32(0), _
                                        datareader.GetString(1), _
                                        datareader.GetString(2), _
                                        datareader.GetString(3), _
                                        datareader.GetBoolean(4), _
                                        datareader.GetString(5), _
                                        CiudadAD.BuscarPorID(datareader.GetInt32(6))))


        End While
        Return listaKioscos

    End Function

End Class
