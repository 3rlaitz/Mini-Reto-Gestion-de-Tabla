Imports System.IO

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
            MsgBox("Índice fuera de rango")
            Return
        End If
        listado.RemoveAt(indice)
    End Sub

    Public Sub GuardarListado()
        If listado.Count <= 0 Then
            MsgBox("No hay videojuegos para guardar")
            Return
        End If

        Dim linea = "titulo;plataforma;estudio;anioEstreno;tiempoSpeedrun;speedrunner"
        Try
            Dim sw = New StreamWriter("videojuegos.txt")
            sw.WriteLine(linea)
            For Each videojuego As Videojuego In listado
                linea = $"{videojuego.PTitulo};{videojuego.PPlataforma};{videojuego.PEstudio};{videojuego.PAnioEstreno};{videojuego.PTiempoSpeedrun};{videojuego.PSpeedrunner}"
                sw.WriteLine(linea)
            Next
            sw.Close()
            MsgBox("Guardado con exito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
