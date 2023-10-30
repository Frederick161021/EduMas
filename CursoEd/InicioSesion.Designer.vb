<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InicioSesion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCuenta = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnInicioSesion = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtNombreU = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo1
        Me.Panel1.Controls.Add(Me.btnCuenta)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnInicioSesion)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtContraseña)
        Me.Panel1.Controls.Add(Me.txtNombreU)
        Me.Panel1.Location = New System.Drawing.Point(543, 110)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 407)
        Me.Panel1.TabIndex = 0
        '
        'btnCuenta
        '
        Me.btnCuenta.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo3
        Me.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCuenta.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuenta.ForeColor = System.Drawing.Color.White
        Me.btnCuenta.Location = New System.Drawing.Point(129, 293)
        Me.btnCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCuenta.Name = "btnCuenta"
        Me.btnCuenta.Size = New System.Drawing.Size(227, 36)
        Me.btnCuenta.TabIndex = 17
        Me.btnCuenta.Text = "REGISTRARME"
        Me.btnCuenta.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo4
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(129, 337)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(227, 36)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnInicioSesion
        '
        Me.btnInicioSesion.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo4
        Me.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInicioSesion.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicioSesion.ForeColor = System.Drawing.Color.White
        Me.btnInicioSesion.Location = New System.Drawing.Point(129, 242)
        Me.btnInicioSesion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInicioSesion.Name = "btnInicioSesion"
        Me.btnInicioSesion.Size = New System.Drawing.Size(227, 36)
        Me.btnInicioSesion.TabIndex = 6
        Me.btnInicioSesion.Text = "INICIAR SESIÓN"
        Me.btnInicioSesion.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre de Usuario"
        '
        'txtContraseña
        '
        Me.txtContraseña.AcceptsTab = True
        Me.txtContraseña.AllowDrop = True
        Me.txtContraseña.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtContraseña.Location = New System.Drawing.Point(40, 174)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(411, 42)
        Me.txtContraseña.TabIndex = 3
        '
        'txtNombreU
        '
        Me.txtNombreU.AcceptsTab = True
        Me.txtNombreU.AllowDrop = True
        Me.txtNombreU.BackColor = System.Drawing.Color.White
        Me.txtNombreU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreU.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreU.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNombreU.Location = New System.Drawing.Point(40, 86)
        Me.txtNombreU.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreU.Name = "txtNombreU"
        Me.txtNombreU.Size = New System.Drawing.Size(411, 42)
        Me.txtNombreU.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CursoEd.My.Resources.Resources.img12
        Me.PictureBox1.InitialImage = Global.CursoEd.My.Resources.Resources.img12
        Me.PictureBox1.Location = New System.Drawing.Point(29, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(487, 511)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(664, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 45)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "¡BIENVENIDO!"
        '
        'InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo2
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "InicioSesion"
        Me.Text = "InicioSesion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnInicioSesion As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtNombreU As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCuenta As Button
End Class
