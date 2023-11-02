Public Class adminPrincipal
    Private Sub btnAdminUsuarios_Click(sender As Object, e As EventArgs) Handles btnAdminUsuarios.Click
        adminUsuarios.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdminActividad_Click(sender As Object, e As EventArgs) Handles btnAdminActividad.Click
        adminActividad.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdminContenidos_Click(sender As Object, e As EventArgs) Handles btnAdminContenidos.Click
        adminContenido.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdminPagos_Click(sender As Object, e As EventArgs) Handles btnAdminPagos.Click
        adminPago.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdminCursos_Click(sender As Object, e As EventArgs) Handles btnAdminCursos.Click
        adminCurso.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
End Class