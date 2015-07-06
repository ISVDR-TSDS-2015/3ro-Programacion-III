Imports [ON]
Imports System.Data.SqlClient
Public Class CiudadAD
    Public Shared Function BuscarPorID(ByVal id As Integer) As Ciudad
        'abrir la base de datos 
        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Data Source=STEFANI\SQLEXPRESS;Initial Catalog='MI KIOSCO';User ID=sa;Password=esea"


        'iniciar una transaccion



        'llamar a la insercion
        Dim comando As SqlCommand
        Dim query As String
        query = "SELECT ciu_id, ciu_descripcion FROM Ciudades WHERE ciu_id = @ciu_id Order by ciu_id"

        conexion.Open()
        comando = New SqlCommand(query, conexion)
        comando.Parameters.AddWithValue("@ciu_id", id)

        'pasar lo q trajo a una lista de kioscos
        Dim ciudad As New Ciudad
        Dim datareader As SqlDataReader
        datareader = comando.ExecuteReader

        If datareader.Read() Then
            ciudad = New Ciudad(datareader.GetInt32(0), _
                                        datareader.GetString(1))


        End If
        Return ciudad

    End Function

    Public Shared Function BuscarTodas() As List(Of Ciudad)
        'abrir la base de datos 
        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Data Source=STEFANI\SQLEXPRESS;Initial Catalog='MI KIOSCO';User ID=sa;Password=esea"


        'iniciar una transaccion



        'llamar a la insercion
        Dim comando As SqlCommand
        Dim query As String
        query = "SELECT ciu_id, ciu_descripcion FROM Ciudades Order by ciu_id"

        conexion.Open()
        comando = New SqlCommand(query, conexion)

        'pasar lo q trajo a una lista de kioscos
        Dim listaCiudades As New List(Of Ciudad)
        Dim datareader As SqlDataReader
        datareader = comando.ExecuteReader

        While (datareader.Read())
            listaCiudades.Add(New Ciudad(datareader.GetInt32(0), _
                                        datareader.GetString(1)))


        End While
        Return listaCiudades

    End Function
End Class
