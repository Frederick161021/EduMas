Imports System.Data.SqlClient

Public Class adminActividad
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim actividadId As Integer
        If Integer.TryParse(txtActividad_id.Text, actividadId) Then
            Dim actividad As New ClassLibCursoEdu.Actividad
            Dim dt As DataTable = actividad.BuscarActividadPorID(actividadId)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                txtCurso_nombre.Text = dt.Rows(0)("actividad_usuario_id").ToString()
                txtCurso_descripcion.Text = dt.Rows(0)("actividad_fecha").ToString()
            Else
                MessageBox.Show("No se encontró ninguna actividad con el ID proporcionado.")
                LimpiarCampos()
            End If
        Else
            MessageBox.Show("Por favor, ingresa un ID válido.")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim actividadId As Integer
        If Integer.TryParse(txtActividad_id.Text, actividadId) Then
            Dim actividad As New ClassLibCursoEdu.Actividad
            Dim resultado As Boolean = actividad.EliminarActividadPorID(actividadId)

            If resultado Then
                MessageBox.Show("La actividad se eliminó con éxito.")
                LimpiarCampos()
            Else
                MessageBox.Show("No se pudo eliminar la actividad. Ocurrió un error.")
            End If
        Else
            MessageBox.Show("Por favor, ingresa un ID válido.")
        End If
    End Sub

    Private Sub LimpiarCampos()
        txtActividad_id.Clear()
        txtCurso_nombre.Clear()
        txtCurso_descripcion.Clear()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        adminPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtActividad_id.Clear()
        txtCurso_nombre.Clear()
        txtCurso_descripcion.Clear()
    End Sub
End Class
