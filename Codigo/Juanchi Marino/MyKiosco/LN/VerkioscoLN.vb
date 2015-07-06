Imports [ON]
Imports AD
Public Class VerkioscoLN
    Public Property listakioscos As List(Of Kiosco)
    Public Sub New()
        listakioscos = kioscoAD.BuacarTodos()
    End Sub
End Class
