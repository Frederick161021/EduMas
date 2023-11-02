Public Class adminUsuarios
    Private Sub adminUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsuario.Text = ModuleUsuario.usuario_nombre
    End Sub

    Private Sub limpiar()
        txtUsuario_id.Text = ""
        radAdministrador.Checked = False
        radUsuario.Checked = False
        txtUsuario_nombre.Text = ""
        txtUsuario_contraseña.Text = ""
        txtUsuario_contraseña.Text = ""
        txtUsuario_num_tarjeta.Text = ""
        txtUsuario_cvv.Text = ""
        radActivo.Checked = False
        radInactivo.Checked = False
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim uRolId As Integer
        Dim estado As Integer
        If radAdministrador.Checked = True Then
            uRolId = 1
        ElseIf radUsuario.Checked = True Then
            uRolId = 2
        End If
        If radInactivo.Checked = True Then
            estado = 0
        ElseIf radActivo.Checked = True Then
            estado = 1
        End If
        Dim alta As New ClassLibCursoEdu.Usuario
        With alta
            .UsuarioRolId = uRolId
            .UsuarioNombre = txtUsuario_nombre.Text.ToString
            .UsuarioContrasena = txtUsuario_contraseña.Text.ToString
            .UsuarioNumTarjeta = Convert.ToInt32(txtUsuario_num_tarjeta.Text)
            .UsuarioCVV = Convert.ToInt32(txtUsuario_cvv.Text)
            .UsuarioEstado = estado
            If .UsuarioAlta() Then
                MessageBox.Show("El usuario se ah dado de alta!")
                limpiar()
            End If
        End With
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim consulta As New ClassLibCursoEdu.Usuario
        With consulta
    .UsuarioId = txtUsuario_id.Text
    If .UsuarioConsulta() Then
                txtUsuario_nombre.Text = .UsuarioNombre
                txtUsuario_contraseña.Text = .UsuarioContrasena
    If .UsuarioRolId = 1 Then
                    radAdministrador.Checked = True
    ElseIf .UsuarioRolId = 2 Then
                    radUsuario.Checked = True
    End If
                txtUsuario_num_tarjeta.Text = .UsuarioNumTarjeta
                txtUsuario_cvv.Text = .UsuarioCVV
    If .UsuarioEstado = 1 Then
                    radActivo.Checked = True
    Else
                    radInactivo.Checked = True
    End If
    End If
    End With
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim uRolId As Integer
        Dim estado As Integer
        If radAdministrador.Checked = True Then
            uRolId = 1
        ElseIf radUsuario.Checked = True Then
            uRolId = 2
        End If
        If radInactivo.Checked = True Then
            estado = 0
        ElseIf radActivo.Checked = True Then
            estado = 1
        End If
        Dim actualizar As New ClassLibCursoEdu.Usuario
        With actualizar
            .UsuarioId = Convert.ToInt32(txtUsuario_id.Text)
            .UsuarioRolId = uRolId
            .UsuarioNombre = txtUsuario_nombre.Text.ToString
            .UsuarioContrasena = txtUsuario_contraseña.Text.ToString
            .UsuarioNumTarjeta = Convert.ToInt32(txtUsuario_num_tarjeta.Text)
            .UsuarioCVV = Convert.ToInt32(txtUsuario_cvv.Text)
            .UsuarioEstado = estado
            If .UsuarioActualiza Then
                MessageBox.Show("Datos del usuario han sido Actualizados!")
                limpiar()
            End If
        End With
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim uRolId As Integer

        If radAdministrador.Checked = True Then
            uRolId = 1
        ElseIf radUsuario.Checked = True Then
            uRolId = 2
        End If
        Dim actualizar As New ClassLibCursoEdu.Usuario
        With actualizar
            .UsuarioId = Convert.ToInt32(txtUsuario_id.Text)
            .UsuarioRolId = uRolId
            .UsuarioNombre = txtUsuario_nombre.Text.ToString
            .UsuarioContrasena = txtUsuario_contraseña.Text.ToString
            .UsuarioNumTarjeta = Convert.ToInt32(txtUsuario_num_tarjeta.Text)
            .UsuarioCVV = Convert.ToInt32(txtUsuario_cvv.Text)
            .UsuarioEstado = 0
            If .UsuarioActualiza Then
                MessageBox.Show("Se ha marcado el usuario como inactivo!")
                limpiar()
            End If
        End With
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        adminPrincipal.Show()
        Me.Close()
    End Sub
End Class