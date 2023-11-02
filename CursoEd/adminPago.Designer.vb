<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminPago
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCurso_cost = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPago_fecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPago_curso_id = New System.Windows.Forms.TextBox()
        Me.txtPago_usuario_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPago_id = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPago_descuento = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
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
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtPago_descuento)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtCurso_cost)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtPago_fecha)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtPago_curso_id)
        Me.Panel1.Controls.Add(Me.txtPago_usuario_id)
        Me.Panel1.Location = New System.Drawing.Point(29, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(743, 299)
        Me.Panel1.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(106, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 21)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Costo"
        '
        'txtCurso_cost
        '
        Me.txtCurso_cost.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurso_cost.Location = New System.Drawing.Point(171, 156)
        Me.txtCurso_cost.Name = "txtCurso_cost"
        Me.txtCurso_cost.Size = New System.Drawing.Size(533, 29)
        Me.txtCurso_cost.TabIndex = 11
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo4
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(30, 250)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(273, 34)
        Me.btnEliminar.TabIndex = 10
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(81, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Id Curso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(104, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(55, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha"
        '
        'txtPago_fecha
        '
        Me.txtPago_fecha.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago_fecha.Location = New System.Drawing.Point(171, 110)
        Me.txtPago_fecha.Name = "txtPago_fecha"
        Me.txtPago_fecha.Size = New System.Drawing.Size(533, 29)
        Me.txtPago_fecha.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(88, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Id Usuario"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPago_curso_id
        '
        Me.txtPago_curso_id.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago_curso_id.Location = New System.Drawing.Point(171, 66)
        Me.txtPago_curso_id.Name = "txtPago_curso_id"
        Me.txtPago_curso_id.Size = New System.Drawing.Size(533, 29)
        Me.txtPago_curso_id.TabIndex = 6
        '
        'txtPago_usuario_id
        '
        Me.txtPago_usuario_id.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago_usuario_id.Location = New System.Drawing.Point(171, 22)
        Me.txtPago_usuario_id.Name = "txtPago_usuario_id"
        Me.txtPago_usuario_id.Size = New System.Drawing.Size(533, 29)
        Me.txtPago_usuario_id.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Id Pago"
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
        'txtPago_id
        '
        Me.txtPago_id.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago_id.Location = New System.Drawing.Point(130, 70)
        Me.txtPago_id.Name = "txtPago_id"
        Me.txtPago_id.Size = New System.Drawing.Size(157, 29)
        Me.txtPago_id.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(72, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 21)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Descuento"
        '
        'txtPago_descuento
        '
        Me.txtPago_descuento.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago_descuento.Location = New System.Drawing.Point(171, 204)
        Me.txtPago_descuento.Name = "txtPago_descuento"
        Me.txtPago_descuento.Size = New System.Drawing.Size(533, 29)
        Me.txtPago_descuento.TabIndex = 13
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo4
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(414, 250)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(273, 34)
        Me.btnLimpiar.TabIndex = 15
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo3
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegresar.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.ForeColor = System.Drawing.Color.White
        Me.btnRegresar.Location = New System.Drawing.Point(633, 12)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(139, 29)
        Me.btnRegresar.TabIndex = 26
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'adminPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo2
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPago_id)
        Me.Name = "adminPago"
        Me.Text = "adminPago"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPago_fecha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPago_curso_id As TextBox
    Friend WithEvents txtPago_usuario_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPago_id As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCurso_cost As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPago_descuento As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnRegresar As Button
End Class
