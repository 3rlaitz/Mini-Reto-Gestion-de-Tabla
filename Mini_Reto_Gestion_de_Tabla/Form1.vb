Public Class Form1
    Private resultado As DialogResult

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
                    MsgBox("Operación cancelada")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btAniadir_Click(sender As Object, e As EventArgs) Handles btAniadir.Click
        Anadir.Show()
        Me.Hide()
    End Sub

    'Otros metodos

    Private Sub cargarVideojuegos()
        Dim listado As New Listado()
        dgvTablaVideojuegos.Rows.Clear()

        Dim juego1 As New Videojuego("The Legend of Zelda", "Nintendo Switch", "Nintendo", 2017, 3600, "Eneko")
        Dim juego2 As New Videojuego("God of War", "PS4", "Sony", 2018, 4200, "Ana")
        Dim juego3 As New Videojuego("Cyberpunk 2077", "PC", "CD Projekt", 2020, 5400, "Luis")
        Dim juego4 As New Videojuego("Hollow Knight", "PC", "Team Cherry", 2017, 3000, "Marta")
        Dim juego5 As New Videojuego("Minecraft", "PC", "Mojang", 2011, 6000, "Carlos")
        listado.AniadirVideojuego(juego1)
        listado.AniadirVideojuego(juego2)

        For Each videojuego As Videojuego In listado.PListado
            dgvTablaVideojuegos.Rows.Add(videojuego.PTitulo, videojuego.PPlataforma, videojuego.PEstudio, videojuego.PAnioEstreno, videojuego.PTiempoSpeedrun, videojuego.PSpeedrunner)
        Next
    End Sub
End Class

