Public Class Registro
    Private Sub Limpiar()
        txtNombreU.Text = ""
        txtContraseña.Text = ""
        txtNumTarjeta.Text = ""
    End Sub



    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        If txtNombreU.Text <> "" And txtContraseña.Text <> "" And txtNumTarjeta.Text <> "" And txtCVV.Text <> "" Then
            Dim agregar As New ClassLibCursoEdu.Usuario
            With agregar
                .UsuarioRolId = 2
                .UsuarioNombre = txtNombreU.Text
                .UsuarioContrasena = txtContraseña.Text
                .UsuarioNumTarjeta = Convert.ToInt32(txtNumTarjeta.Text)
                .UsuarioCVV = Convert.ToInt32(txtCVV.Text)
                .UsuarioEstado = 1
            End With
            If agregar.UsuarioAlta Then
                MessageBox.Show("Usuarario dado de alta exitosamente.")
                Limpiar()
                InicioSesion.Show()
                Me.Hide()
            Else
                MessageBox.Show("Error al dar de alta usuario.")
            End If
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class