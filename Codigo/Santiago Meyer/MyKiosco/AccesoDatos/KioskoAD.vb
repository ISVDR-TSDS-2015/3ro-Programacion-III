Imports ObjetosNegocio
Imports System.Data.SqlClient

Public Class KioskoAD

    Public Shared Sub registrarkiosko(ByVal kiosko As Kiosko)
        'abrir bd

        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Data Source=PC1-PC\SQLEXPRESS;Initial Catalog=MyKiosco;User ID=sa;Password=esea"


        'inici transaccion x

        'llamar incersion
        Dim comando As SqlCommand
        Dim query As String
        query = "INSERT INTO KIOScOS " & _
                "(kio_usuario,kio_password,kio_nombre,kio_email)Values" & _
                "(@kio_usuario,@kio_password,@kio_nombre,@kio_email)"

        conexion.Open()
        comando = New SqlCommand(query, conexion)
        comando.Parameters.AddWithValue("@kio_usuario", kiosko.usuario)
        comando.Parameters.AddWithValue("@kio_password", kiosko.password)
        comando.Parameters.AddWithValue("@kio_nombre", kiosko.nombre)
        comando.Parameters.AddWithValue("@kio_email", kiosko.email)
        'pasar parametros incersion
        comando.ExecuteNonQuery()
        conexion.Close()



        'finalizar transac x
        'cerrar conn bd
        conexion.Close()

    End Sub

    Public Shared Function getallkioskos() As List(Of Kiosko)
        Dim conexion As New SqlConnection
        conexion.ConnectionString = "Data Source=PC1-PC\SQLEXPRESS;Initial Catalog=MyKiosco;User ID=sa;Password=esea"
        'inici transaccion x
        'llamar incersion
        Dim comando As SqlCommand
        Dim query As String
        query = "select kio_id,kio_usuario,kio_password,kio_nombre,kio_activo,kio_email " & _
        "from KIOScOS order by kio_nombre"
        conexion.Open()
        comando = New SqlCommand(query, conexion)


        Dim listaKioskos As New List(Of Kiosko)
        Dim datareader As SqlDataReader

        datareader = comando.ExecuteReader()

        While (datareader.Read())
            listaKioskos.Add(New Kiosko(datareader.GetInt32(0), _
                                        datareader.GetString(1), _
                                        datareader.GetString(2), _
                                        datareader.GetString(3), _
                                        datareader.GetBoolean(4), _
                                        datareader.GetString(5)))
            'ciudadAD:getciudadid(datareader.GetInt32(6)))

        End While

        Return listaKioskos

    End Function
End Class
