Public Class Anadir
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
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtAnio.Text = "" And txtEstudio.Text = "" And txtPlat.Text = "" And txtSpeedrun.Text = "" And txtSpeedrunner.Text = "" And txtTit.Text = "" Then
                MsgBox("Debes rellenar todos los campos!!!")
                Return
            End If
            If txtAnio.Text <= 2026 Then
                Convert.ToInt32(txtAnio.Text)
            Else
                MsgBox("Año incorrecto!!!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Button2.PerformClick()
    End Sub
End Class