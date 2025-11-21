Public Class Form1
    Private resultado As DialogResult
    Private listado As New Listado()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarVideojuegos()
        Dim btEliminar As New DataGridViewButtonColumn()
        btEliminar.Name = "colEliminar"
        btEliminar.HeaderText = "Eliminar"
        btEliminar.Text = "Eliminar"
        btEliminar.UseColumnTextForButtonValue = True
        dgvTablaVideojuegos.Columns.Add(btEliminar)
    End Sub

    Private Sub dgvTablaVideojuegos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTablaVideojuegos.CellContentClick
        Dim filaSeleccionada As Integer = e.RowIndex
        Dim mensaje As String = "¿Estás seguro que quieres eliminar este registro?"
        Dim caption As String = "Confirmación Decimal eliminación"

        Try
            If (filaSeleccionada >= 0 AndAlso dgvTablaVideojuegos.Columns(e.ColumnIndex).Name = "colEliminar") Then
                resultado = MessageBox.Show(mensaje, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If (resultado = DialogResult.Yes) Then
                    dgvTablaVideojuegos.Rows.RemoveAt(filaSeleccionada)
                Else
                    MsgBox("Operación cancelada", MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btAniadir_Click(sender As Object, e As EventArgs) Handles btAniadir.Click
        Anadir.Mostrar(listado)
        Me.Hide()
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        listado.GuardarListado()
    End Sub

    Public Sub cargarVideojuegos()
        dgvTablaVideojuegos.Rows.Clear()
        For Each videojuego As Videojuego In Me.listado.PListado
            dgvTablaVideojuegos.Rows.Add(videojuego.PTitulo, videojuego.PPlataforma, videojuego.PEstudio, videojuego.PAnioEstreno, videojuego.PTiempoSpeedrun, videojuego.PSpeedrunner)
        Next
    End Sub

    Private Sub btCargar_Click(sender As Object, e As EventArgs) Handles btCargar.Click
        listado.AniadirVideojuego(New Videojuego("Balatro", "PC", "LocalThunk", 2024, 8000, "Erlaitz"))
        listado.AniadirVideojuego(New Videojuego("God of War", "PS4", "Sony", 2018, 4200, "Beñat"))
        listado.AniadirVideojuego(New Videojuego("Hollow Knight", "PC", "Team Cherry", 2017, 3000, "Arkaitz"))
        listado.AniadirVideojuego(New Videojuego("Minecraft", "PC", "Mojang", 2011, 6000, "Ieltxu"))
        listado.AniadirVideojuego(New Videojuego("The Legend of Zelda", "Nintendo Switch", "Nintendo", 2017, 3600, "Eneko"))
        cargarVideojuegos()
    End Sub
End Class

