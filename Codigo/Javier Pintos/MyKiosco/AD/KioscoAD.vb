Imports [ON]
Imports System.Data.SqlClient

Public Class KioscoAD

    Public Shared Sub RegistrarKiosco(ByVal kiosco As Kiosco)
        'Abrir la Base de Datos
        Dim conexion As New SqlConnection
        conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("SQLServer").ToString()

        'llamar a la inserción
        Dim comando As SqlCommand
        Dim query As String

        query = "INSERT INTO Kioscos " & _
            "(kio_usuario, kio_password, kio_nombre, kio_email, kio_ciu_id) VALUES " & _
            "(@kio_usuario, @kio_password, @kio_nombre, @kio_email, @kio_ciu_id)"

        conexion.Open()
        comando = New SqlCommand(query, conexion)

        'pasar parametros de la inserción
        comando.Parameters.AddWithValue("@kio_usuario", kiosco.Usuario)
        comando.Parameters.AddWithValue("@kio_password", kiosco.Password)
        comando.Parameters.AddWithValue("@kio_nombre", kiosco.Nombre)
        comando.Parameters.AddWithValue("@kio_email", kiosco.EMail)
        comando.Parameters.AddWithValue("@kio_ciu_id", kiosco.Ciudad.Id)

        'ejecutamos el comando
        comando.ExecuteNonQuery()

        'cerrar conexión a la Base de Datos
        conexion.Close()
    End Sub

    Public Shared Function BuscarTodos() As List(Of Kiosco)
        'Abrir la Base de Datos
        Dim conexion As New SqlConnection
        conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("SQLServer").ToString()

        'llamar a la inserción
        Dim comando As SqlCommand
        Dim query As String

        query = "SELECT kio_id, kio_usuario, kio_password, kio_nombre, " & _
            "kio_activo, kio_email, kio_ciu_id " & _
            "FROM Kioscos ORDER BY kio_nombre"

        conexion.Open()
        comando = New SqlCommand(query, conexion)

        Dim listaKioscos As New List(Of Kiosco)
        Dim dataReader As SqlDataReader

        dataReader = comando.ExecuteReader()

        While (dataReader.Read())
            listaKioscos.Add(New Kiosco(dataReader.GetInt32(0), _
                                        dataReader.GetString(1), _
                                        dataReader.GetString(2), _
                                        dataReader.GetString(3), _
                                        dataReader.GetBoolean(4), _
                                        dataReader.GetString(5), _
                                        CiudadAD.BuscarPorId(dataReader.GetInt32(6))))

        End While

        Return listaKioscos

    End Function


    Public Shared Function GetKioscoPorUsuarioPassword(ByVal usuario As String, ByVal password As String) As Kiosco
        Dim kiosco As Kiosco = Nothing

        Dim conexion As New SqlConnection
        Dim comando As SqlCommand
        Dim dataReader As SqlDataReader

        conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("SQLServer").ToString
        conexion.Open()

        comando = New SqlCommand("select kio_id,kio_usuario,kio_password,kio_nombre,kio_activo,kio_email,kio_ciu_id " & _
                                 "FROM kioscos " & _
                                 "WHERE kio_usuario=@kio_usuario " & _
                                 "AND kio_password=@kio_password", conexion)
        comando.Parameters.AddWithValue("@kio_usuario", usuario)
        comando.Parameters.AddWithValue("@kio_password", password)

        dataReader = comando.ExecuteReader()


        If (dataReader.Read()) Then
            kiosco = New Kiosco(dataReader.GetInt32(0), _
                                dataReader.GetString(1), _
                                dataReader.GetString(2), _
                                dataReader.GetString(3), _
                                dataReader.GetBoolean(4), _
                                dataReader.GetString(5), _
                                CiudadAD.BuscarPorId(dataReader.GetInt32(6)))
        End If

        dataReader.Close()
        conexion.Close()

        Return kiosco
    End Function

    Shared Function BuscarPorNombre(nombre As String) As List(Of Kiosco)
        'Abrir la Base de Datos
        Dim conexion As New SqlConnection
        conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("SQLServer").ToString()

        'llamar a la inserción
        Dim comando As SqlCommand
        Dim query As String

        query = "SELECT kio_id, kio_usuario, kio_password, kio_nombre, " & _
            "kio_activo, kio_email, kio_ciu_id " & _
            "FROM Kioscos WHERE kio_nombre LIKE @nombre ORDER BY kio_nombre"

        conexion.Open()
        comando = New SqlCommand(query, conexion)
        comando.Parameters.AddWithValue("@nombre", "%" + nombre + "%")

        Dim listaKioscos As New List(Of Kiosco)
        Dim dataReader As SqlDataReader

        dataReader = comando.ExecuteReader()

        While (dataReader.Read())
            listaKioscos.Add(New Kiosco(dataReader.GetInt32(0), _
                                        dataReader.GetString(1), _
                                        dataReader.GetString(2), _
                                        dataReader.GetString(3), _
                                        dataReader.GetBoolean(4), _
                                        dataReader.GetString(5), _
                                        CiudadAD.BuscarPorId(dataReader.GetInt32(6))))

        End While

        Return listaKioscos
    End Function

End Class
