
' CLASE PARA LOS DATOS DE LOS Videojuegos

Public Class Videojuego

    ' Atributos
    Dim titulo As String
    Dim plataforma As String
    Dim estudio As String
    Dim anioEstreno As Integer ' validar que no sea mayor al año actual (en la ventana principal <eneko>)
    Dim tiempoSpeedrun As Integer ' en segundos
    Dim speedrunner As String

    'Constructor
    Public Sub New(titulo As String, plataforma As String, estudio As String, anioEstreno As Integer, tiempoSpeedrun As Integer, speedrunner As String)
        Me.titulo = titulo
        Me.plataforma = plataforma
        Me.estudio = estudio
        Me.anioEstreno = anioEstreno
        Me.tiempoSpeedrun = tiempoSpeedrun
        Me.speedrunner = speedrunner
    End Sub

    'Getters & Setters
    Public Property PTitulo() As String
        Get
            Return titulo
        End Get
        Set(value As String)
            titulo = value
        End Set
    End Property
    Public Property PPlataforma() As String
        Get
            Return plataforma
        End Get
        Set(value As String)
            plataforma = value
        End Set
    End Property
    Public Property PEstudio() As String
        Get
            Return estudio
        End Get
        Set(value As String)
            estudio = value
        End Set
    End Property
    Public Property PAnioEstreno() As Integer
        Get
            Return anioEstreno
        End Get
        Set(value As Integer)
            anioEstreno = value
        End Set
    End Property
    Public Property PTiempoSpeedrun() As Integer
        Get
            Return tiempoSpeedrun
        End Get
        Set(value As Integer)
            tiempoSpeedrun = value
        End Set
    End Property
    Public Property PSpeedrunner() As String
        Get
            Return speedrunner
        End Get
        Set(value As String)
            speedrunner = value
        End Set
    End Property

    ' Otros métodos


End Class
