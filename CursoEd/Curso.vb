Imports ExamenesEducaMas

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

    Private Sub btnExamen_Click(sender As Object, e As EventArgs) Handles btnExamen.Click
        If ModuleCurso.curso_id = 1 Then
            Dim esp1 As New Esp1
            esp1.Show()
        ElseIf ModuleCurso.curso_id = 2 Then
            Dim esp2 As New Esp1
            esp2.Show()
        ElseIf ModuleCurso.curso_id = 3 Then
            Dim esp3 As New Esp1
            esp3.Show()
        ElseIf ModuleCurso.curso_id = 4 Then
            Dim mate1 As New Mate1
            mate1.Show()
        ElseIf ModuleCurso.curso_id = 5 Then
            Dim mate2 As New Mate2
            mate2.Show()
        ElseIf ModuleCurso.curso_id = 6 Then
            Dim mate3 As New Mate3
            mate3.Show()
        ElseIf ModuleCurso.curso_id = 7 Then
            Dim hist1 As New Hist1
            hist1.Show()
        ElseIf ModuleCurso.curso_id = 8 Then
            Dim hist2 As New Hist1
            hist2.Show()
        End If
        Me.Hide
    End Sub
End Class