Public Class Anadir
    Private listado As Listado
    Public Sub Mostrar(listado)
        Me.listado = listado
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtAnio.Text = ""
        txtEstudio.Text = ""
        txtPlat.Text = ""
        txtSpeedrun.Text = ""
        txtSpeedrunner.Text = ""
        txtTit.Text = ""
        btVolver.Focus()
    End Sub

    Private Sub btVolver_Click(sender As Object, e As EventArgs) Handles btVolver.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If String.IsNullOrWhiteSpace(txtAnio.Text) Or String.IsNullOrWhiteSpace(txtEstudio.Text) Or String.IsNullOrWhiteSpace(txtPlat.Text) Or String.IsNullOrWhiteSpace(txtSpeedrun.Text) Or String.IsNullOrWhiteSpace(txtSpeedrunner.Text) Or String.IsNullOrWhiteSpace(txtTit.Text) Then
                MsgBox("Debes rellenar todos los campos!!!")
                Return
            End If
            Dim anio As Integer = Convert.ToInt32(txtAnio.Text)
            Dim speed As Integer = Convert.ToInt32(txtSpeedrun.Text)
            If anio >= 2026 Then
                MsgBox("Año incorrecto!!!")
                Return
            End If
            If speed <= 0 Then
                MsgBox("No puede existir ese tiempo record!!!")
                Return
            End If
            Me.listado.AniadirVideojuego(New Videojuego(txtTit.Text, txtPlat.Text, txtEstudio.Text, anio, speed, txtSpeedrunner.Text))
            MsgBox("Videojuego añadido con exito!")
        Catch ex As Exception
            MsgBox("El año y el tiempo de speedrun debe de ser numerico")
            Return
        End Try
        Button2.PerformClick()
    End Sub

    Private Sub Anadir_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Show()
        Form1.cargarVideojuegos()
    End Sub
End Class