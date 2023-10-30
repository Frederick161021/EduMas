Imports System.Data.SqlClient
Public Class InicioSesion
    Public Sub Limpiar()
        txtNombreU.Text = ""
        txtContraseña.Text = ""
    End Sub
    Private Sub btnInicioSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click
        Dim agregar As New ClassLibCursoEdu.Actividad
        agregar.ActividadUsuarioId = ModuleUsuario.usuario_id
        agregar.ActividadFecha = DateTime.Now

        If agregar.ActividadAlta() Then
            Console.WriteLine("Actividad registrada con éxito.")
        Else
            Console.WriteLine("Error al registrar la actividad.")
        End If


        Dim login As New ClassLibCursoEdu.Usuario
        With login
            .UsuarioNombre = txtNombreU.Text
            .UsuarioContrasena = txtContraseña.Text
            If .UsuarioLogin() Then
                If .UsuarioId <> 0 Then
                    ' Registra la actividad de inicio de sesión en la base de datos


                    ModuleUsuario.usuario_id = .UsuarioId
                    ModuleUsuario.usuario_rol_id = .UsuarioRolId
                    ModuleUsuario.usuario_nombre = .UsuarioNombre
                    ModuleUsuario.usuario_contraseña = .UsuarioContrasena
                    ModuleUsuario.usuario_num_tarjeta = .UsuarioNumTarjeta
                    ModuleUsuario.usuario_cvv = .UsuarioCVV
                    ModuleUsuario.usuario_estado = .UsuarioEstado
                    Cursos.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Usuario o contraseña equivocados.")
                    Limpiar()
                End If
            End If
        End With
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnCuenta_Click(sender As Object, e As EventArgs) Handles btnCuenta.Click
        Registro.Show()
        Me.Hide()
    End Sub
End Class