Public Class Curso

    Private Sub cargarContenido()
        Dim cargar As New ClassLibCursoEdu.Contenido
        With cargar
            .ContenidoCursoId = ModuleCurso.curso_id
            .ContenidoModulo = ModuleContenido.contenido_modulo
            If .ConenidoCargar() Then
                If .ContenidoId <> 0 Then
                    ModuleContenido.contenido_id = .ContenidoId
                    ModuleContenido.contenido_nivel = .ContenidoNivel
                    ModuleContenido.contenido_titulo = .ContenidoTitulo
                    ModuleContenido.contenido_texto = .ContenidoTexto
                    ModuleContenido.contenido_imagen = .ContenidoImagen
                End If
            End If
        End With
    End Sub


    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Cursos.Show()
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub btnModuloI_Click(sender As Object, e As EventArgs) Handles btnModuloI.Click
        ModuleContenido.contenido_modulo = 1
        cargarContenido()
        Modulo.Show()
        Me.Hide()
    End Sub

    Private Sub btnModuloII_Click(sender As Object, e As EventArgs) Handles btnModuloII.Click
        ModuleContenido.contenido_modulo = 2
        cargarContenido()
        Modulo.Show()
        Me.Hide()
    End Sub

    Private Sub btnModuloIII_Click(sender As Object, e As EventArgs) Handles btnModuloIII.Click
        ModuleContenido.contenido_modulo = 3
        cargarContenido()
        Modulo.Show()
        Me.Hide()
    End Sub

    Private Sub btnModuloIV_Click(sender As Object, e As EventArgs) Handles btnModuloIV.Click
        ModuleContenido.contenido_modulo = 4
        lblEstado.Text = "Terminado"
        cargarContenido()
        Modulo.Show()
        Me.Hide()
    End Sub

    Private Sub Curso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombreCurso.Text = ModuleCurso.curso_nombre
    End Sub
End Class