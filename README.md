# Reto Gestión de Videojuegos
Aplicación enfocada para el **almacenamiento de videojuegos** con los tiempos record de cada speedrun.

## Participantes
- ***[Ieltxu](https://github.com/ieltxuah)***
- **[Eneko](https://github.com/enekoo8)**
- **[Erlaitz](https://github.com/3rlaitz)**
- **[Arkaitz](https://github.com/Arkaaiitz)**
- ~~Beñat~~

## Caracteristicas
- Utilizar Windows 10 o superior
- Poder acceder al [repositorio](https://github.com/3rlaitz/Mini-Reto-Gestion-de-Tabla)
- Tener Internet para instalar para instalar el [exe](https://github.com/3rlaitz/Mini-Reto-Gestion-de-Tabla/releases/tag/v1.0.0).

---
## Tabla de Videojuegos

| Videojuego | Plataforma | Estudio de Desarrollo | Año de Desarrollo | Tiempo de speedRun (S) | Nombre del Record | Eliminar |
| :--------: | :--------: | --------------------- | ----------------: | ---------------------: | :---------------: | -------- |
| Balatro    | PC         | LocalThunk            | 2024              | 8000                   | Erlaitz           | Eliminar |

> Este juegazo es muy recomendable para distraerse un rato

\# No fomentamos la ludopatía

## Imagen del Proyecto
![Captura de la pantalla principal del proyecto](img/Principal.PNG)

## Captura de Codigo
```vb
Private Sub btCargar_Click(sender As Object, e As EventArgs) Handles btCargar.Click
    listado.AniadirVideojuego(New Videojuego("Balatro", "PC", "LocalThunk", 2024, 8000, "Erlaitz"))
    listado.AniadirVideojuego(New Videojuego("God of War", "PS4", "Sony", 2018, 4200, "Beñat"))
    listado.AniadirVideojuego(New Videojuego("Hollow Knight", "PC", "Team Cherry", 2017, 3000, "Arkaitz"))
    listado.AniadirVideojuego(New Videojuego("Minecraft", "PC", "Mojang", 2011, 6000, "Ieltxu"))
    listado.AniadirVideojuego(New Videojuego("The Legend of Zelda", "Nintendo Switch", "Nintendo", 2017, 3600, "Eneko"))
    cargarVideojuegos()
End Sub
```
