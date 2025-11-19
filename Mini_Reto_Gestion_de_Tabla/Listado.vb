Public Class Listado
    Private listado As ArrayList

    Public Sub New()
        listado = New ArrayList()
    End Sub

    Public Property PListado() As ArrayList
        Get
            Return listado
        End Get
        Set(ByVal value As ArrayList)
            listado = value
        End Set
    End Property

    Public Sub AniadirVideojuego(nuevoVideojuego As Videojuego)
        listado.Add(nuevoVideojuego)
    End Sub

    Public Sub BorrarVideojuego(indice As Integer)
        If indice < 0 OrElse indice >= listado.Count Then
            Throw New ArgumentOutOfRangeException("Índice fuera de rango")
        End If
        listado.RemoveAt(indice)
    End Sub
End Class
