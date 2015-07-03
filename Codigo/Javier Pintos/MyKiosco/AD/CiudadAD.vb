Imports [ON]
Imports System.Data.SqlClient

Public Class CiudadAD

    Shared Function BuscarTodos() As List(Of Ciudad)
        'Abrir la Base de Datos
        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Data Source=WIFILSON;Initial Catalog=MyKiosco;User ID=sa;Password=sa"

        'llamar a la inserción
        Dim comando As SqlCommand
        Dim query As String

        query = "SELECT ciu_id, ciu_nombre " & _
            "FROM Ciudades ORDER BY ciu_nombre"

        conexion.Open()
        comando = New SqlCommand(query, conexion)

        Dim listaCiudades As New List(Of Ciudad)
        Dim dataReader As SqlDataReader

        dataReader = comando.ExecuteReader()

        While (dataReader.Read())
            listaCiudades.Add(New Ciudad(dataReader.GetInt32(0), _
                                        dataReader.GetString(1)))
        End While

        Return listaCiudades

    End Function

End Class
