Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim btEliminar As New DataGridViewButtonColumn()
        btEliminar.Name = "colEliminar"
        btEliminar.HeaderText = "Eliminar"
        btEliminar.Text = "Eliminar"
        btEliminar.UseColumnTextForButtonValue = True
        dgvTablaVideojuegos.Columns.Add(btEliminar)
    End Sub

    Private Sub dgvTablaVideojuegos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTablaVideojuegos.CellContentClick
        Dim filaSeleccionada As Integer = e.RowIndex

        If (filaSeleccionada > 0 AndAlso dgvTablaVideojuegos.Columns(e.ColumnIndex).Name = "colEliminar") Then
            dgvTablaVideojuegos.Rows.RemoveAt(filaSeleccionada)
        End If

    End Sub
End Class

