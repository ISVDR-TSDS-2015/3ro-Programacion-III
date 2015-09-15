Imports [ON]
Imports System.Data.SqlClient
Public Class CiudadAD

    Public Shared Function BuscarTodos() As List(Of Ciudad)

        'abrir la base de datos
        Dim conexion As New SqlConnection
        'conexion.ConnectionString = "Data Source=Lucia-Pc;Initial Catalog='MiKiosco';User ID=sa;Password=esea"
        conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("SQLServer").ToString()

        'iniciar una transaccion


        'llamar a la insercion
        Dim comando As SqlCommand
        Dim query As String
        query = "SELECT ciu_id, ciu_nombre FROM Ciudades ORDER BY ciu_nombre"

        conexion.Open()
        comando = New SqlCommand(query, conexion)
        Dim ListaCiudades As New List(Of Ciudad)
        Dim DataReader As SqlDataReader

        DataReader = comando.ExecuteReader()

        While (DataReader.Read())
            ListaCiudades.Add(New Ciudad(DataReader.GetInt32(0), _
                                         DataReader.GetString(1)))
        End While

        Return ListaCiudades

    End Function

    Shared Function BuscarPorId(id As Integer) As Ciudad

        Dim conexion As New SqlConnection
        'conexion.ConnectionString = "Data Source=Lucia-Pc;Initial Catalog='MiKiosco';User ID=sa;Password=esea"
        conexion.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings("SQLServer").ToString()
        Dim comando As SqlCommand
        Dim query As String
        query = "SELECT ciu_id, ciu_nombre FROM Ciudades WHERE Ciu_id=@Ciu_id ORDER BY Ciu_id"

        conexion.Open()
        comando = New SqlCommand(query, conexion)
        comando.Parameters.AddWithValue("@Ciu_id", id)

        Dim Ciudad As New Ciudad
        Dim DataReader As SqlDataReader

        DataReader = comando.ExecuteReader()

        If DataReader.Read Then
            Ciudad = New Ciudad(DataReader.GetInt32(0), _
                                         DataReader.GetString(1))
        End If

        Return Ciudad

    End Function


End Class
