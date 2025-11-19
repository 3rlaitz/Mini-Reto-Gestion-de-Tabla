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
        Label2 = New Label()
        txtTit = New TextBox()
        txtSpeedrunner = New TextBox()
        Label3 = New Label()
        txtAnio = New TextBox()
        Label4 = New Label()
        txtPlat = New TextBox()
        Label5 = New Label()
        Button2 = New Button()
        btVolver = New Button()
        txtSpeedrun = New TextBox()
        Label6 = New Label()
        txtEstudio = New TextBox()
        Label7 = New Label()
        GroupBox1 = New GroupBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(190, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(288, 38)
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F)
        Label2.Location = New Point(15, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 20)
        Label2.TabIndex = 2
        Label2.Text = "Titulo:"
        ' 
        ' txtTit
        ' 
        txtTit.Font = New Font("Segoe UI", 9F)
        txtTit.Location = New Point(139, 30)
        txtTit.Name = "txtTit"
        txtTit.Size = New Size(125, 27)
        txtTit.TabIndex = 3
        ' 
        ' txtSpeedrunner
        ' 
        txtSpeedrunner.Font = New Font("Segoe UI", 9F)
        txtSpeedrunner.Location = New Point(492, 229)
        txtSpeedrunner.Name = "txtSpeedrunner"
        txtSpeedrunner.Size = New Size(125, 27)
        txtSpeedrunner.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.Location = New Point(325, 229)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 20)
        Label3.TabIndex = 4
        Label3.Text = "Speedrunner:"
        ' 
        ' txtAnio
        ' 
        txtAnio.Font = New Font("Segoe UI", 9F)
        txtAnio.Location = New Point(141, 139)
        txtAnio.Name = "txtAnio"
        txtAnio.Size = New Size(125, 27)
        txtAnio.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F)
        Label4.Location = New Point(15, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 20)
        Label4.TabIndex = 6
        Label4.Text = "Año de estreno:"
        ' 
        ' txtPlat
        ' 
        txtPlat.Font = New Font("Segoe UI", 9F)
        txtPlat.Location = New Point(139, 82)
        txtPlat.Name = "txtPlat"
        txtPlat.Size = New Size(125, 27)
        txtPlat.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F)
        Label5.Location = New Point(15, 82)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 20)
        Label5.TabIndex = 8
        Label5.Text = "Plataforma:"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 10.2F)
        Button2.Location = New Point(266, 312)
        Button2.Name = "Button2"
        Button2.Size = New Size(146, 48)
        Button2.TabIndex = 10
        Button2.Text = "Limpiar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btVolver
        ' 
        btVolver.Font = New Font("Segoe UI", 10.2F)
        btVolver.Location = New Point(483, 312)
        btVolver.Name = "btVolver"
        btVolver.Size = New Size(146, 48)
        btVolver.TabIndex = 11
        btVolver.Text = "Volver"
        btVolver.UseVisualStyleBackColor = True
        ' 
        ' txtSpeedrun
        ' 
        txtSpeedrun.Font = New Font("Segoe UI", 9F)
        txtSpeedrun.Location = New Point(492, 172)
        txtSpeedrun.Name = "txtSpeedrun"
        txtSpeedrun.Size = New Size(125, 27)
        txtSpeedrun.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F)
        Label6.Location = New Point(325, 172)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 20)
        Label6.TabIndex = 14
        Label6.Text = "Speedrun:"
        ' 
        ' txtEstudio
        ' 
        txtEstudio.Font = New Font("Segoe UI", 9F)
        txtEstudio.Location = New Point(492, 120)
        txtEstudio.Name = "txtEstudio"
        txtEstudio.Size = New Size(125, 27)
        txtEstudio.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F)
        Label7.Location = New Point(325, 120)
        Label7.Name = "Label7"
        Label7.Size = New Size(153, 20)
        Label7.TabIndex = 12
        Label7.Text = "Estudio de desarrollo:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtTit)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txtAnio)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(txtPlat)
        GroupBox1.Location = New Point(43, 90)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(586, 203)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        ' 
        ' Anadir
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(678, 414)
        Controls.Add(txtSpeedrun)
        Controls.Add(Label6)
        Controls.Add(txtEstudio)
        Controls.Add(Label7)
        Controls.Add(btVolver)
        Controls.Add(Button2)
        Controls.Add(txtSpeedrunner)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Name = "Anadir"
        Text = "Anadir"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTit As TextBox
    Friend WithEvents txtSpeedrunner As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPlat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btVolver As Button
    Friend WithEvents txtSpeedrun As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEstudio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
