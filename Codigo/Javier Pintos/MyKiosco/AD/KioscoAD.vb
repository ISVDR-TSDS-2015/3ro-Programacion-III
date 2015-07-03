Imports [ON]
Imports System.Data.SqlClient

Public Class KioscoAD

    Public Shared Sub RegistrarKiosco(ByVal kiosco As Kiosco)
        'Abrir la Base de Datos
        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Data Source=WIFILSON;Initial Catalog=MyKiosco;User ID=sa;Password=sa"

        'llamar a la inserción
        Dim comando As SqlCommand
        Dim query As String

        query = "INSERT INTO Kioscos " & _
            "(kio_usuario, kio_password, kio_nombre, kio_email) VALUES " & _
            "(@kio_usuario, @kio_password, @kio_nombre, @kio_email)"

        conexion.Open()
        comando = New SqlCommand(query, conexion)

        'pasar parametros de la inserción
        comando.Parameters.AddWithValue("@kio_usuario", kiosco.Usuario)
        comando.Parameters.AddWithValue("@kio_password", kiosco.Password)
        comando.Parameters.AddWithValue("@kio_nombre", kiosco.Nombre)
        comando.Parameters.AddWithValue("@kio_email", kiosco.EMail)

        'ejecutamos el comando
        comando.ExecuteNonQuery()

        'cerrar conexión a la Base de Datos
        conexion.Close()
    End Sub

    Public Shared Function BuscarTodos() As List(Of Kiosco)
        'Abrir la Base de Datos
        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Data Source=WIFILSON;Initial Catalog=MyKiosco;User ID=sa;Password=sa"

        'llamar a la inserción
        Dim comando As SqlCommand
        Dim query As String

        query = "SELECT kio_id, kio_usuario, kio_password, kio_nombre, " & _
            "kio_activo, kio_email " & _
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
                                        dataReader.GetString(5), Nothing))

        End While

        Return listaKioscos

    End Function
End Class
