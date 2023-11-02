Public Class adminCurso

    Private Sub limpiar()
        txtCurso_id.Text = ""
        txtCurso_nombre.Text = ""
        txtCurso_descripcion.Text = ""
        txtCurso_cost.Text = ""
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim consulta As New ClassLibCursoEdu.Curso
        With consulta
            .CursoID = txtCurso_id.Text
            If .CursoConsulta() Then
                txtCurso_nombre.Text = .CursoNombre
                txtCurso_descripcion.Text = .CursoDescripcion
                txtCurso_cost.Text = .CursoCosto.ToString
            End If
        End With
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim actualizar As New ClassLibCursoEdu.Curso
        With actualizar
            .CursoID = txtCurso_id.Text
            .CursoNombre = txtCurso_nombre.Text
            .CursoDescripcion = txtCurso_descripcion.Text
            .CursoCosto = txtCurso_cost.Text
            If .CursoActualiza() Then
                MessageBox.Show("Datos del curso Actualizados!")
                limpiar()
            End If
        End With
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) 
        Dim actualizar As New ClassLibCursoEdu.Curso
        With actualizar
            .CursoID = txtCurso_id.Text
            .CursoNombre = txtCurso_nombre.Text
            .CursoDescripcion = txtCurso_descripcion.Text
            .CursoCosto = txtCurso_cost.Text
            If .CursoActualiza() Then
                MessageBox.Show("Se ah eleminado el curso!")
                limpiar()
            End If
        End With
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        adminPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub adminCurso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsuario.Text = ModuleUsuario.usuario_nombre
    End Sub
End Class