<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anadir
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        btVolver = New Button()
        txtSpeedrun = New TextBox()
        txtEstudio = New TextBox()
        Panel1 = New Panel()
        txtTit = New TextBox()
        Label2 = New Label()
        txtPlat = New TextBox()
        txtAnio = New TextBox()
        Label3 = New Label()
        Label6 = New Label()
        txtSpeedrunner = New TextBox()
        Label4 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(182, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(330, 41)
        Label1.TabIndex = 0
        Label1.Text = "AÑADIR VIDEOJUEGO"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 10.2F)
        Button1.Location = New Point(43, 312)
        Button1.Name = "Button1"
        Button1.Size = New Size(146, 48)
        Button1.TabIndex = 1
        Button1.Text = "Añadir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 10.2F)
        Button2.Location = New Point(272, 312)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 48)
        Button2.TabIndex = 10
        Button2.Text = "Limpiar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btVolver
        ' 
        btVolver.Font = New Font("Segoe UI", 10.2F)
        btVolver.Location = New Point(495, 312)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(146, 48)
        btVolver.TabIndex = 11
        btVolver.Text = "Volver"
        btVolver.UseVisualStyleBackColor = True
        ' 
        ' txtSpeedrun
        ' 
        txtSpeedrun.Font = New Font("Segoe UI", 9F)
        txtSpeedrun.Location = New Point(459, 62)
        txtSpeedrun.Name = "txtSpeedrun"
        txtSpeedrun.Size = New Size(125, 27)
        txtSpeedrun.TabIndex = 15
        ' 
        ' txtEstudio
        ' 
        txtEstudio.Font = New Font("Segoe UI", 9F)
        txtEstudio.Location = New Point(459, 13)
        txtEstudio.Name = "txtEstudio"
        txtEstudio.Size = New Size(125, 27)
        txtEstudio.TabIndex = 13
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(txtTit)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtPlat)
        Panel1.Controls.Add(txtAnio)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(txtSpeedrunner)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtEstudio)
        Panel1.Controls.Add(txtSpeedrun)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(43, 114)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(598, 157)
        Panel1.TabIndex = 17
        ' 
        ' txtTit
        ' 
        txtTit.Font = New Font("Segoe UI", 9F)
        txtTit.Location = New Point(122, 13)
        txtTit.Name = "txtTit"
        txtTit.Size = New Size(125, 27)
        txtTit.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F)
        Label2.Location = New Point(3, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 20)
        Label2.TabIndex = 2
        Label2.Text = "Titulo:"
        ' 
        ' txtPlat
        ' 
        txtPlat.Font = New Font("Segoe UI", 9F)
        txtPlat.Location = New Point(122, 62)
        txtPlat.Name = "txtPlat"
        txtPlat.Size = New Size(125, 27)
        txtPlat.TabIndex = 9
        ' 
        ' txtAnio
        ' 
        txtAnio.Font = New Font("Segoe UI", 9F)
        txtAnio.Location = New Point(122, 109)
        txtAnio.Name = "txtAnio"
        txtAnio.Size = New Size(125, 27)
        txtAnio.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.Location = New Point(275, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(178, 20)
        Label3.TabIndex = 4
        Label3.Text = "Nombre del speedrunner:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F)
        Label6.Location = New Point(275, 65)
        Label6.Name = "Label6"
        Label6.Size = New Size(173, 20)
        Label6.TabIndex = 14
        Label6.Text = "Tiempo de speedRun (s):"
        ' 
        ' txtSpeedrunner
        ' 
        txtSpeedrunner.Font = New Font("Segoe UI", 9F)
        txtSpeedrunner.Location = New Point(459, 109)
        txtSpeedrunner.Name = "txtSpeedrunner"
        txtSpeedrunner.Size = New Size(125, 27)
        txtSpeedrunner.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F)
        Label4.Location = New Point(3, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 20)
        Label4.TabIndex = 6
        Label4.Text = "Año de estreno:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F)
        Label7.Location = New Point(275, 16)
        Label7.Name = "Label7"
        Label7.Size = New Size(153, 20)
        Label7.TabIndex = 12
        Label7.Text = "Estudio de desarrollo:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F)
        Label5.Location = New Point(3, 65)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 20)
        Label5.TabIndex = 8
        Label5.Text = "Plataforma:"
        ' 
        ' Anadir
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(678, 414)
        Controls.Add(btVolver)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "Anadir"
        Text = "Anadir"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btVolver As Button
    Friend WithEvents txtSpeedrun As TextBox
    Friend WithEvents txtEstudio As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPlat As TextBox
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents txtSpeedrunner As TextBox
    Friend WithEvents txtTit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
