Public Class adminContenido
    Private idContenido As Integer
    Private idCurso As Integer
    Private rutaimg As String
    Private nivel As Integer
    Private Sub setIdCurso()
        If cbxCursos.Text = "Español I" Then
            idCurso = 1
        ElseIf cbxCursos.Text = "Español II" Then
            idCurso = 2
        ElseIf cbxCursos.Text = "Español III" Then
            idCurso = 3
        ElseIf cbxCursos.Text = "Matemáticas I" Then
            idCurso = 4
        ElseIf cbxCursos.Text = "Matemáticas II" Then
            idCurso = 5
        ElseIf cbxCursos.Text = "Matemáticas III" Then
            idCurso = 6
        ElseIf cbxCursos.Text = "Historia I" Then
            idCurso = 7
        ElseIf cbxCursos.Text = "Historia II" Then
            idCurso = 8
        End If

    End Sub

    Private Sub limpiar()
        txtNumModulo.Text = ""
        txtContenidoTitulo.Text = ""
        txtContenido.Text = ""
        picImg.Image = Nothing
        cbxCursos.Text = ""
    End Sub

    Private Sub adminContenido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsuario.Text = ModuleUsuario.usuario_nombre
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        setIdCurso()
        Dim consulta As New ClassLibCursoEdu.Contenido
        With consulta
            .ContenidoCursoId = Convert.ToInt32(txtNumModulo.Text)
            .ContenidoModulo = idCurso
            If .ConenidoCargar() Then
                If .ContenidoId <> 0 Then
                    idContenido = .ContenidoId
                    txtContenidoTitulo.Text = .ContenidoTitulo
                    txtContenido.Text = .ContenidoTexto
                    nivel = .ContenidoNivel
                    picImg.ImageLocation = .ContenidoImagen
                    rutaimg = .ContenidoImagen
                End If
            End If
        End With
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        setIdCurso()
        Dim actualizar As New ClassLibCursoEdu.Contenido
        With actualizar
            .ContenidoId = idContenido
            .ContenidoCursoId = idCurso
            .ContenidoModulo = txtNumModulo.Text
            .ContenidoTitulo = txtContenidoTitulo.Text
            .ContenidoTexto = txtContenido.Text
            .ContenidoNivel = nivel
            .ContenidoImagen = rutaimg
            If .ContenidoActualiza Then
                MessageBox.Show("El contenido del curso ha sido Actualizados!")
                limpiar()
            End If
        End With
    End Sub

    Private Sub btnBuscarImg_Click(sender As Object, e As EventArgs) Handles btnBuscarImg.Click
        Dim openFileDialog1 As New OpenFileDialog()
        With openFileDialog1
            .Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp"
            .FilterIndex = 1
            .Title = "Abrir un archivo de imagen"
        End With
        If openFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                rutaimg = openFileDialog1.FileName
                picImg.Image = Image.FromFile(rutaimg)
                openFileDialog1.Reset()
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK,
               MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        adminPrincipal.Show()
        Me.Hide()
    End Sub
End Class