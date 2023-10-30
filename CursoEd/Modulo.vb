Public Class Modulo
    Private Sub Modulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = ModuleContenido.contenido_titulo
        lblContenido.Text = ModuleContenido.contenido_texto
        picImagen.ImageLocation = ModuleContenido.contenido_imagen
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        ModuleContenido.contenido_imagen = ""
        ModuleContenido.contenido_modulo = 0
        ModuleContenido.contenido_nivel = 0
        ModuleContenido.contenido_texto = ""
        ModuleContenido.contenido_titulo = ""
        Curso.Show()
        Me.Close()
    End Sub
End Class