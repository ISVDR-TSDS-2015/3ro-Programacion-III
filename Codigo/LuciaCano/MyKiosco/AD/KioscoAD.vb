Imports [ON]
Imports System.Data.SqlClient

Public Class KioscoAD

    Public Shared Sub RegistrarKiosco(ByVal Kiosco As Kiosco)
        'abrir la base de datos
        Dim conexion As New SqlConnection
        'conexion.ConnectionString = "Data Source=Lucia-Pc;Initial Catalog='MiKiosco';User ID=sa;Password=esea"
        conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("SQLServer").ToString()

        'iniciar una transaccion


        'llamar a la insercion
        Dim comando As SqlCommand
        Dim query As String
        query = "INSERT INTO Kioscos" & _
            "(Kio_usuario, Kio_password, Kio_nombre, Kio_email, Kio_Ciu_id) values " & _
            "(@Kio_usuario, @Kio_password, @Kio_nombre, @Kio_email, @Kio_Ciu_id)"

        conexion.Open()
        comando = New SqlCommand(query, conexion)

        'pasar parámetros de la inserción
        comando.Parameters.AddWithValue("@Kio_usuario", Kiosco.Usuario)
        comando.Parameters.AddWithValue("@Kio_password", Kiosco.Password)
        comando.Parameters.AddWithValue("@Kio_nombre", Kiosco.Nombre)
        comando.Parameters.AddWithValue("@Kio_email", Kiosco.EMail)
        comando.Parameters.AddWithValue("@Kio_Ciu_id", Kiosco.Ciudad.Id)


        'ejecutamos el comando
        comando.ExecuteNonQuery()


        'finalizar transacción


        'cerrar conección a la base de datos
        conexion.Close()

    End Sub

    Public Shared Function BuscarTodos() As List(Of Kiosco)

        'abrir la base de datos
        Dim conexion As New SqlConnection
        'conexion.ConnectionString = "Data Source=Lucia-Pc;Initial Catalog='MiKiosco';User ID=sa;Password=esea"
        conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("SQLServer").ToString()

        'iniciar una transaccion


        'llamar a la insercion
        Dim comando As SqlCommand
        Dim query As String
        query = "SELECT Kio_id, Kio_usuario, Kio_password, Kio_nombre, Kio_activo, Kio_email, Kio_Ciu_id FROM Kioscos ORDER BY Kio_nombre"


        conexion.Open()
        comando = New SqlCommand(query, conexion)

        Dim ListaKioscos As New List(Of Kiosco)
        Dim DataReader As SqlDataReader

        DataReader = comando.ExecuteReader

        While (DataReader.Read())
            ListaKioscos.Add(New Kiosco(DataReader.GetInt32(0), _
                                        DataReader.GetString(1), _
                                        DataReader.GetString(2), _
                                        DataReader.GetString(3), _
                                        DataReader.GetBoolean(4), _
                                        DataReader.GetString(5), CiudadAD.BuscarPorId(DataReader.GetInt32(6))))


        End While

        Return ListaKioscos

    End Function

    Public Shared Function BuscarPorNombre(ByVal nombre As String) As List(Of Kiosco)

        'abrir la base de datos
        Dim conexion As New SqlConnection
        'conexion.ConnectionString = "Data Source=Lucia-Pc;Initial Catalog='MiKiosco';User ID=sa;Password=esea"
        conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("SQLServer").ToString()

        'iniciar una transaccion


        'llamar a la insercion
        Dim comando As SqlCommand
        Dim query As String
        query = "SELECT Kio_id, Kio_usuario, Kio_password, Kio_nombre, Kio_activo, Kio_email, Kio_Ciu_id FROM Kioscos WHERE Kio_Nombre LIKE @nombre ORDER BY Kio_nombre"


        conexion.Open()
        comando = New SqlCommand(query, conexion)
        comando.Parameters.AddWithValue("@nombre", "%" + nombre + "%")

        Dim ListaKioscos As New List(Of Kiosco)
        Dim DataReader As SqlDataReader

        DataReader = comando.ExecuteReader

        While (DataReader.Read())
            ListaKioscos.Add(New Kiosco(DataReader.GetInt32(0), _
                                        DataReader.GetString(1), _
                                        DataReader.GetString(2), _
                                        DataReader.GetString(3), _
                                        DataReader.GetBoolean(4), _
                                        DataReader.GetString(5), CiudadAD.BuscarPorId(DataReader.GetInt32(6))))


        End While

        Return ListaKioscos

    End Function

    Public Shared Function GetKioscoPorUsuarioPassword(ByVal usuario As String, ByVal password As String) As Kiosco
        Dim kiosco As Kiosco = Nothing

        Dim conexion As New SqlConnection
        Dim comando As SqlCommand
        Dim dataReader As SqlDataReader

        'conexion.ConnectionString = "Data Source=WIFILSON;Initial Catalog=MyKiosco;Persist Security Info=True;User ID=sa;Password=sa"

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
End Class
