<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminPrincipal
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
        Me.btnAdminUsuarios = New System.Windows.Forms.Button()
        Me.btnAdminActividad = New System.Windows.Forms.Button()
        Me.btnAdminContenidos = New System.Windows.Forms.Button()
        Me.btnAdminPagos = New System.Windows.Forms.Button()
        Me.btnAdminCursos = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdminUsuarios
        '
        Me.btnAdminUsuarios.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo1
        Me.btnAdminUsuarios.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminUsuarios.ForeColor = System.Drawing.Color.DimGray
        Me.btnAdminUsuarios.Location = New System.Drawing.Point(150, 155)
        Me.btnAdminUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminUsuarios.Name = "btnAdminUsuarios"
        Me.btnAdminUsuarios.Size = New System.Drawing.Size(299, 59)
        Me.btnAdminUsuarios.TabIndex = 0
        Me.btnAdminUsuarios.Text = "Administrar Usuarios"
        Me.btnAdminUsuarios.UseVisualStyleBackColor = True
        '
        'btnAdminActividad
        '
        Me.btnAdminActividad.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo1
        Me.btnAdminActividad.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminActividad.ForeColor = System.Drawing.Color.DimGray
        Me.btnAdminActividad.Location = New System.Drawing.Point(621, 165)
        Me.btnAdminActividad.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminActividad.Name = "btnAdminActividad"
        Me.btnAdminActividad.Size = New System.Drawing.Size(294, 59)
        Me.btnAdminActividad.TabIndex = 1
        Me.btnAdminActividad.Text = "Administrar Actividad"
        Me.btnAdminActividad.UseVisualStyleBackColor = True
        '
        'btnAdminContenidos
        '
        Me.btnAdminContenidos.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo1
        Me.btnAdminContenidos.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminContenidos.ForeColor = System.Drawing.Color.DimGray
        Me.btnAdminContenidos.Location = New System.Drawing.Point(150, 278)
        Me.btnAdminContenidos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminContenidos.Name = "btnAdminContenidos"
        Me.btnAdminContenidos.Size = New System.Drawing.Size(299, 59)
        Me.btnAdminContenidos.TabIndex = 2
        Me.btnAdminContenidos.Text = "Administrar Contenidos"
        Me.btnAdminContenidos.UseVisualStyleBackColor = True
        '
        'btnAdminPagos
        '
        Me.btnAdminPagos.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo1
        Me.btnAdminPagos.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminPagos.ForeColor = System.Drawing.Color.DimGray
        Me.btnAdminPagos.Location = New System.Drawing.Point(621, 278)
        Me.btnAdminPagos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminPagos.Name = "btnAdminPagos"
        Me.btnAdminPagos.Size = New System.Drawing.Size(294, 59)
        Me.btnAdminPagos.TabIndex = 3
        Me.btnAdminPagos.Text = "Administrar Pagos"
        Me.btnAdminPagos.UseVisualStyleBackColor = True
        '
        'btnAdminCursos
        '
        Me.btnAdminCursos.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo1
        Me.btnAdminCursos.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminCursos.ForeColor = System.Drawing.Color.DimGray
        Me.btnAdminCursos.Location = New System.Drawing.Point(150, 397)
        Me.btnAdminCursos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdminCursos.Name = "btnAdminCursos"
        Me.btnAdminCursos.Size = New System.Drawing.Size(299, 59)
        Me.btnAdminCursos.TabIndex = 4
        Me.btnAdminCursos.Text = "Administrar Cursos"
        Me.btnAdminCursos.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo1
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.DimGray
        Me.btnSalir.Location = New System.Drawing.Point(621, 397)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(294, 59)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.BackColor = System.Drawing.Color.Transparent
        Me.lblAdmin.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(334, 38)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(411, 34)
        Me.lblAdmin.TabIndex = 7
        Me.lblAdmin.Text = "Sistema Administrativo"
        '
        'adminPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo3
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAdminCursos)
        Me.Controls.Add(Me.btnAdminPagos)
        Me.Controls.Add(Me.btnAdminContenidos)
        Me.Controls.Add(Me.btnAdminActividad)
        Me.Controls.Add(Me.btnAdminUsuarios)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "adminPrincipal"
        Me.Text = "adminPrincipal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdminUsuarios As Button
    Friend WithEvents btnAdminActividad As Button
    Friend WithEvents btnAdminContenidos As Button
    Friend WithEvents btnAdminPagos As Button
    Friend WithEvents btnAdminCursos As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblAdmin As Label
End Class
