<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvTablaVideojuegos = New DataGridView()
        lbTitulo = New Label()
        btAniadir = New Button()
        btGuardar = New Button()
        colTitVideojuego = New DataGridViewTextBoxColumn()
        colPlataforma = New DataGridViewTextBoxColumn()
        colEstudioDesarrollo = New DataGridViewTextBoxColumn()
        colAnioEstreno = New DataGridViewTextBoxColumn()
        colTiempoSpeedrun = New DataGridViewTextBoxColumn()
        colRecordista = New DataGridViewTextBoxColumn()
        colEliminar = New DataGridViewTextBoxColumn()
        CType(dgvTablaVideojuegos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvTablaVideojuegos
        ' 
        dgvTablaVideojuegos.BackgroundColor = Color.Turquoise
        dgvTablaVideojuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTablaVideojuegos.Columns.AddRange(New DataGridViewColumn() {colTitVideojuego, colPlataforma, colEstudioDesarrollo, colAnioEstreno, colTiempoSpeedrun, colRecordista, colEliminar})
        dgvTablaVideojuegos.Location = New Point(40, 104)
        dgvTablaVideojuegos.MultiSelect = False
        dgvTablaVideojuegos.Name = "dgvTablaVideojuegos"
        dgvTablaVideojuegos.RowHeadersWidth = 51
        dgvTablaVideojuegos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTablaVideojuegos.Size = New Size(927, 406)
        dgvTablaVideojuegos.TabIndex = 0
        ' 
        ' lbTitulo
        ' 
        lbTitulo.AutoSize = True
        lbTitulo.BorderStyle = BorderStyle.FixedSingle
        lbTitulo.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTitulo.Location = New Point(394, 40)
        lbTitulo.Name = "lbTitulo"
        lbTitulo.Size = New Size(223, 43)
        lbTitulo.TabIndex = 1
        lbTitulo.Text = "VIDEOJUEGOS"
        ' 
        ' btAniadir
        ' 
        btAniadir.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btAniadir.Location = New Point(237, 555)
        btAniadir.Name = "btAniadir"
        btAniadir.Size = New Size(167, 48)
        btAniadir.TabIndex = 2
        btAniadir.Text = "AÑADIR"
        btAniadir.UseVisualStyleBackColor = True
        ' 
        ' btGuardar
        ' 
        btGuardar.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btGuardar.Location = New Point(565, 560)
        btGuardar.Name = "btGuardar"
        btGuardar.Size = New Size(168, 43)
        btGuardar.TabIndex = 3
        btGuardar.Text = "GUARDAR"
        btGuardar.UseVisualStyleBackColor = True
        ' 
        ' colTitVideojuego
        ' 
        colTitVideojuego.HeaderText = "Videjuego"
        colTitVideojuego.MinimumWidth = 6
        colTitVideojuego.Name = "colTitVideojuego"
        colTitVideojuego.ReadOnly = True
        colTitVideojuego.Width = 125
        ' 
        ' colPlataforma
        ' 
        colPlataforma.HeaderText = "Plataforma"
        colPlataforma.MinimumWidth = 6
        colPlataforma.Name = "colPlataforma"
        colPlataforma.ReadOnly = True
        colPlataforma.Width = 125
        ' 
        ' colEstudioDesarrollo
        ' 
        colEstudioDesarrollo.HeaderText = "Estudio de Desarrollo"
        colEstudioDesarrollo.MinimumWidth = 6
        colEstudioDesarrollo.Name = "colEstudioDesarrollo"
        colEstudioDesarrollo.ReadOnly = True
        colEstudioDesarrollo.Width = 125
        ' 
        ' colAnioEstreno
        ' 
        colAnioEstreno.HeaderText = "Año de estreno"
        colAnioEstreno.MinimumWidth = 6
        colAnioEstreno.Name = "colAnioEstreno"
        colAnioEstreno.ReadOnly = True
        colAnioEstreno.Width = 125
        ' 
        ' colTiempoSpeedrun
        ' 
        colTiempoSpeedrun.HeaderText = "Tiempo de speedRun (s)"
        colTiempoSpeedrun.MinimumWidth = 6
        colTiempoSpeedrun.Name = "colTiempoSpeedrun"
        colTiempoSpeedrun.ReadOnly = True
        colTiempoSpeedrun.Width = 125
        ' 
        ' colRecordista
        ' 
        colRecordista.HeaderText = "Nombre del Record"
        colRecordista.MinimumWidth = 6
        colRecordista.Name = "colRecordista"
        colRecordista.ReadOnly = True
        colRecordista.Width = 125
        ' 
        ' colEliminar
        ' 
        colEliminar.HeaderText = "Eliminar"
        colEliminar.MinimumWidth = 6
        colEliminar.Name = "colEliminar"
        colEliminar.ReadOnly = True
        colEliminar.Width = 125
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(989, 634)
        Controls.Add(btGuardar)
        Controls.Add(btAniadir)
        Controls.Add(lbTitulo)
        Controls.Add(dgvTablaVideojuegos)
        Name = "Form1"
        Text = "Form1"
        CType(dgvTablaVideojuegos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvTablaVideojuegos As DataGridView
    Friend WithEvents lbTitulo As Label
    Friend WithEvents btAniadir As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents colTitVideojuego As DataGridViewTextBoxColumn
    Friend WithEvents colPlataforma As DataGridViewTextBoxColumn
    Friend WithEvents colEstudioDesarrollo As DataGridViewTextBoxColumn
    Friend WithEvents colAnioEstreno As DataGridViewTextBoxColumn
    Friend WithEvents colTiempoSpeedrun As DataGridViewTextBoxColumn
    Friend WithEvents colRecordista As DataGridViewTextBoxColumn
    Friend WithEvents colEliminar As DataGridViewTextBoxColumn

End Class
