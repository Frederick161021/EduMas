<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Curso
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
        Me.btnModuloIV = New System.Windows.Forms.Button()
        Me.btnModuloII = New System.Windows.Forms.Button()
        Me.btnModuloIII = New System.Windows.Forms.Button()
        Me.btnModuloI = New System.Windows.Forms.Button()
        Me.lblNombreCurso = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo1
        Me.Panel1.Controls.Add(Me.btnModuloIV)
        Me.Panel1.Controls.Add(Me.btnModuloII)
        Me.Panel1.Controls.Add(Me.btnModuloIII)
        Me.Panel1.Controls.Add(Me.btnModuloI)
        Me.Panel1.Controls.Add(Me.lblNombreCurso)
        Me.Panel1.Location = New System.Drawing.Point(40, 65)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 462)
        Me.Panel1.TabIndex = 0
        '
        'btnModuloIV
        '
        Me.btnModuloIV.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo4
        Me.btnModuloIV.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModuloIV.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModuloIV.ForeColor = System.Drawing.Color.White
        Me.btnModuloIV.Location = New System.Drawing.Point(536, 265)
        Me.btnModuloIV.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModuloIV.Name = "btnModuloIV"
        Me.btnModuloIV.Size = New System.Drawing.Size(407, 129)
        Me.btnModuloIV.TabIndex = 4
        Me.btnModuloIV.Text = "Modulo IV"
        Me.btnModuloIV.UseVisualStyleBackColor = True
        '
        'btnModuloII
        '
        Me.btnModuloII.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo4
        Me.btnModuloII.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModuloII.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModuloII.ForeColor = System.Drawing.Color.White
        Me.btnModuloII.Location = New System.Drawing.Point(536, 100)
        Me.btnModuloII.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModuloII.Name = "btnModuloII"
        Me.btnModuloII.Size = New System.Drawing.Size(407, 129)
        Me.btnModuloII.TabIndex = 3
        Me.btnModuloII.Text = "Modulo II"
        Me.btnModuloII.UseVisualStyleBackColor = True
        '
        'btnModuloIII
        '
        Me.btnModuloIII.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo4
        Me.btnModuloIII.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModuloIII.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModuloIII.ForeColor = System.Drawing.Color.White
        Me.btnModuloIII.Location = New System.Drawing.Point(63, 265)
        Me.btnModuloIII.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModuloIII.Name = "btnModuloIII"
        Me.btnModuloIII.Size = New System.Drawing.Size(407, 129)
        Me.btnModuloIII.TabIndex = 2
        Me.btnModuloIII.Text = "Modulo III"
        Me.btnModuloIII.UseVisualStyleBackColor = True
        '
        'btnModuloI
        '
        Me.btnModuloI.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo4
        Me.btnModuloI.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModuloI.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModuloI.ForeColor = System.Drawing.Color.White
        Me.btnModuloI.Location = New System.Drawing.Point(63, 100)
        Me.btnModuloI.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModuloI.Name = "btnModuloI"
        Me.btnModuloI.Size = New System.Drawing.Size(407, 129)
        Me.btnModuloI.TabIndex = 1
        Me.btnModuloI.Text = "Modulo I"
        Me.btnModuloI.UseVisualStyleBackColor = True
        '
        'lblNombreCurso
        '
        Me.lblNombreCurso.AutoSize = True
        Me.lblNombreCurso.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCurso.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCurso.Location = New System.Drawing.Point(348, 16)
        Me.lblNombreCurso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreCurso.Name = "lblNombreCurso"
        Me.lblNombreCurso.Size = New System.Drawing.Size(260, 36)
        Me.lblNombreCurso.TabIndex = 0
        Me.lblNombreCurso.Text = "Nombre del curso"
        '
        'btnSalir
        '
        Me.btnSalir.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo4
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(835, 15)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(188, 36)
        Me.btnSalir.TabIndex = 17
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 26)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Estado:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.BackColor = System.Drawing.Color.Transparent
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(116, 21)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(115, 26)
        Me.lblEstado.TabIndex = 19
        Me.lblEstado.Text = "En proceso"
        '
        'btnRegresar
        '
        Me.btnRegresar.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo4
        Me.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegresar.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.ForeColor = System.Drawing.Color.White
        Me.btnRegresar.Location = New System.Drawing.Point(628, 15)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(188, 36)
        Me.btnRegresar.TabIndex = 20
        Me.btnRegresar.Text = "REGRESAR"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Curso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CursoEd.My.Resources.Resources.fondo2
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Curso"
        Me.Text = "Curso"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnModuloIV As Button
    Friend WithEvents btnModuloII As Button
    Friend WithEvents btnModuloIII As Button
    Friend WithEvents btnModuloI As Button
    Friend WithEvents lblNombreCurso As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents btnRegresar As Button
End Class
