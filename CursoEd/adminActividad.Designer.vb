<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminActividad
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCurso_descripcion = New System.Windows.Forms.TextBox()
        Me.txtCurso_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtActividad_id = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo3
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(633, 70)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(139, 29)
        Me.btnBuscar.TabIndex = 25
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(141, 30)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(72, 22)
        Me.lblUsuario.TabIndex = 24
        Me.lblUsuario.Text = "Usuario"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo1
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnActualizar)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtCurso_descripcion)
        Me.Panel1.Controls.Add(Me.txtCurso_nombre)
        Me.Panel1.Location = New System.Drawing.Point(29, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(743, 299)
        Me.Panel1.TabIndex = 23
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo4
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(249, 248)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(273, 29)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo4
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnActualizar.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(431, 196)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(273, 29)
        Me.btnActualizar.TabIndex = 9
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo4
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(47, 196)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(273, 29)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(100, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 21)
        Me.Label8.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 21)
        Me.Label7.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 21)
        Me.Label6.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(55, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(88, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Id Usuario"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCurso_descripcion
        '
        Me.txtCurso_descripcion.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurso_descripcion.Location = New System.Drawing.Point(154, 131)
        Me.txtCurso_descripcion.Name = "txtCurso_descripcion"
        Me.txtCurso_descripcion.Size = New System.Drawing.Size(533, 29)
        Me.txtCurso_descripcion.TabIndex = 6
        '
        'txtCurso_nombre
        '
        Me.txtCurso_nombre.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurso_nombre.Location = New System.Drawing.Point(154, 87)
        Me.txtCurso_nombre.Name = "txtCurso_nombre"
        Me.txtCurso_nombre.Size = New System.Drawing.Size(533, 29)
        Me.txtCurso_nombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Id Actividad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 21)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Bienvenido: "
        '
        'txtActividad_id
        '
        Me.txtActividad_id.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActividad_id.Location = New System.Drawing.Point(145, 70)
        Me.txtActividad_id.Name = "txtActividad_id"
        Me.txtActividad_id.Size = New System.Drawing.Size(157, 29)
        Me.txtActividad_id.TabIndex = 20
        '
        'adminActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo2
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtActividad_id)
        Me.Name = "adminActividad"
        Me.Text = "adminActividad"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCurso_descripcion As TextBox
    Friend WithEvents txtCurso_nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtActividad_id As TextBox
End Class
