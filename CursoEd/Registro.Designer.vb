<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCVV = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumTarjeta = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtNombreU = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo1
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnRegistro)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtCVV)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNumTarjeta)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtContraseña)
        Me.Panel1.Controls.Add(Me.txtNombreU)
        Me.Panel1.Location = New System.Drawing.Point(47, 96)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(976, 422)
        Me.Panel1.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo4
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(23, 349)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(411, 36)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnRegistro
        '
        Me.btnRegistro.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo4
        Me.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegistro.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistro.ForeColor = System.Drawing.Color.White
        Me.btnRegistro.Location = New System.Drawing.Point(246, 276)
        Me.btnRegistro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(188, 36)
        Me.btnRegistro.TabIndex = 15
        Me.btnRegistro.Text = "REGISTRARSE"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(95, 249)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "CVV"
        '
        'txtCVV
        '
        Me.txtCVV.AcceptsTab = True
        Me.txtCVV.AllowDrop = True
        Me.txtCVV.BackColor = System.Drawing.Color.White
        Me.txtCVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCVV.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCVV.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCVV.Location = New System.Drawing.Point(23, 276)
        Me.txtCVV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(198, 34)
        Me.txtCVV.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(139, 167)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Número de tarjeta"
        '
        'txtNumTarjeta
        '
        Me.txtNumTarjeta.AcceptsTab = True
        Me.txtNumTarjeta.AllowDrop = True
        Me.txtNumTarjeta.BackColor = System.Drawing.Color.White
        Me.txtNumTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumTarjeta.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumTarjeta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNumTarjeta.Location = New System.Drawing.Point(23, 194)
        Me.txtNumTarjeta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNumTarjeta.Name = "txtNumTarjeta"
        Me.txtNumTarjeta.Size = New System.Drawing.Size(411, 34)
        Me.txtNumTarjeta.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CursoEd.My.Resources.Resources.img3
        Me.PictureBox1.Location = New System.Drawing.Point(484, 37)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(455, 368)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre de Usuario"
        '
        'txtContraseña
        '
        Me.txtContraseña.AcceptsTab = True
        Me.txtContraseña.AllowDrop = True
        Me.txtContraseña.BackColor = System.Drawing.Color.White
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtContraseña.Location = New System.Drawing.Point(21, 123)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(411, 34)
        Me.txtContraseña.TabIndex = 7
        '
        'txtNombreU
        '
        Me.txtNombreU.AcceptsTab = True
        Me.txtNombreU.AllowDrop = True
        Me.txtNombreU.BackColor = System.Drawing.Color.White
        Me.txtNombreU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreU.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreU.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNombreU.Location = New System.Drawing.Point(23, 57)
        Me.txtNombreU.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombreU.Name = "txtNombreU"
        Me.txtNombreU.Size = New System.Drawing.Size(411, 34)
        Me.txtNombreU.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(244, 36)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(563, 45)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "¡ÚNETE A LA FAMILIA EDUCA+!"
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo2
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Registro"
        Me.Text = "Registro"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtNombreU As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumTarjeta As TextBox
    Friend WithEvents btnRegistro As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSalir As Button
End Class
