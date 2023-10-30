Public Class Cursos

    Private usuarioConfirmoCompra As Boolean = False

    Private Sub btnEspañol1_Click(sender As Object, e As EventArgs) Handles btnEspañol1.Click
        Dim cursoNombre As String = "Español I"
        Dim cursoCosto As String = "650 pesos" ' Puedes obtener el costo de otra manera

        ' Verifica si el usuario ya confirmó la compra
        If Not usuarioConfirmoCompra Then
            Dim mensaje As String = "Estás a punto de comprar el curso de:" & Environment.NewLine &
                            cursoNombre & Environment.NewLine &
                            "El costo es de " & cursoCosto & Environment.NewLine &
                            "¿Deseas continuar con esta acción?"

            Dim titulo As String = "Confirmación de compra"
            Dim resultado As DialogResult = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OKCancel)

            If resultado = DialogResult.OK Then
                ' El usuario ha hecho clic en Aceptar
                ModuleCurso.curso_id = 1
                ModuleCurso.curso_nombre = cursoNombre
                usuarioConfirmoCompra = True ' Establece la variable de control en Verdadero

                ' Crea una instancia de la clase Pago para registrar el pago
                Dim pago As New ClassLibCursoEdu.Pago
                pago.PagoUsuarioId = ModuleUsuario.usuario_id
                pago.PagoCursoId = ModuleCurso.curso_id ' Usa el ID del curso actual
                pago.PagoFecha = DateTime.Now
                pago.PagoDescuento = 0 ' Puedes modificar el descuento según tus necesidades

                ' Verifica si el usuario ya ha pagado este curso
                If Not pago.UsuarioHaPagadoCurso(ModuleUsuario.usuario_id, ModuleCurso.curso_id) Then
                    ' Intenta guardar el registro de pago
                    If pago.GuardarPago() Then
                        ' Pago exitoso
                        MessageBox.Show("Compra exitosa. Se ha registrado el pago.")
                    Else
                        ' Error al guardar el pago
                        MessageBox.Show("Error al guardar el pago.")
                    End If
                Else
                    ' El usuario ya ha pagado este curso
                    MessageBox.Show("Ya has pagado este curso anteriormente.")
                End If

                ' Mostrar el formulario del curso
                Curso.Show()
                Me.Close()
            End If
        Else
            ' El usuario ya confirmó la compra anteriormente
            ModuleCurso.curso_id = 1
            Curso.Show()
            Me.Close()
        End If
    End Sub





    Private Sub btnEspañol2_Click(sender As Object, e As EventArgs) Handles btnEspañol2.Click
        Dim cursoNombre As String = "Español II"
        Dim cursoCosto As String = "650 pesos" ' Puedes obtener el costo de otra manera

        ' Verifica si el usuario ya confirmó la compra
        If Not usuarioConfirmoCompra Then
            Dim mensaje As String = "Estás a punto de comprar el curso de:" & Environment.NewLine &
                            cursoNombre & Environment.NewLine &
                            "El costo es de " & cursoCosto & Environment.NewLine &
                            "¿Deseas continuar con esta acción?"

            Dim titulo As String = "Confirmación de compra"
            Dim resultado As DialogResult = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OKCancel)

            If resultado = DialogResult.OK Then
                ' El usuario ha hecho clic en Aceptar
                ModuleCurso.curso_id = 2
                ModuleCurso.curso_nombre = cursoNombre
                usuarioConfirmoCompra = True ' Establece la variable de control en Verdadero

                ' Crea una instancia de la clase Pago para registrar el pago
                Dim pago As New ClassLibCursoEdu.Pago
                pago.PagoUsuarioId = ModuleUsuario.usuario_id
                pago.PagoCursoId = ModuleCurso.curso_id ' Usa el ID del curso actual
                pago.PagoFecha = DateTime.Now
                pago.PagoDescuento = 0 ' Puedes modificar el descuento según tus necesidades

                ' Verifica si el usuario ya ha pagado este curso
                If Not pago.UsuarioHaPagadoCurso(ModuleUsuario.usuario_id, ModuleCurso.curso_id) Then
                    ' Intenta guardar el registro de pago
                    If pago.GuardarPago() Then
                        ' Pago exitoso
                        MessageBox.Show("Compra exitosa. Se ha registrado el pago.")
                    Else
                        ' Error al guardar el pago
                        MessageBox.Show("Error al guardar el pago.")
                    End If
                Else
                    ' El usuario ya ha pagado este curso
                    MessageBox.Show("Ya has pagado este curso anteriormente.")
                End If

                ' Mostrar el formulario del curso
                Curso.Show()
                Me.Close()
            End If
        Else
            ' El usuario ya confirmó la compra anteriormente
            ModuleCurso.curso_id = 2
            Curso.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnEspañol3_Click(sender As Object, e As EventArgs) Handles btnEspañol3.Click
        Dim cursoNombre As String = "Español III"
        Dim cursoCosto As String = "650 pesos" ' Puedes obtener el costo de otra manera

        ' Verifica si el usuario ya confirmó la compra
        If Not usuarioConfirmoCompra Then
            Dim mensaje As String = "Estás a punto de comprar el curso de:" & Environment.NewLine &
                            cursoNombre & Environment.NewLine &
                            "El costo es de " & cursoCosto & Environment.NewLine &
                            "¿Deseas continuar con esta acción?"

            Dim titulo As String = "Confirmación de compra"
            Dim resultado As DialogResult = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OKCancel)

            If resultado = DialogResult.OK Then
                ' El usuario ha hecho clic en Aceptar
                ModuleCurso.curso_id = 3
                ModuleCurso.curso_nombre = cursoNombre
                usuarioConfirmoCompra = True ' Establece la variable de control en Verdadero

                ' Crea una instancia de la clase Pago para registrar el pago
                Dim pago As New ClassLibCursoEdu.Pago
                pago.PagoUsuarioId = ModuleUsuario.usuario_id
                pago.PagoCursoId = ModuleCurso.curso_id ' Usa el ID del curso actual
                pago.PagoFecha = DateTime.Now
                pago.PagoDescuento = 0 ' Puedes modificar el descuento según tus necesidades

                ' Verifica si el usuario ya ha pagado este curso
                If Not pago.UsuarioHaPagadoCurso(ModuleUsuario.usuario_id, ModuleCurso.curso_id) Then
                    ' Intenta guardar el registro de pago
                    If pago.GuardarPago() Then
                        ' Pago exitoso
                        MessageBox.Show("Compra exitosa. Se ha registrado el pago.")
                    Else
                        ' Error al guardar el pago
                        MessageBox.Show("Error al guardar el pago.")
                    End If
                Else
                    ' El usuario ya ha pagado este curso
                    MessageBox.Show("Ya has pagado este curso anteriormente.")
                End If

                ' Mostrar el formulario del curso
                Curso.Show()
                Me.Close()
            End If
        Else
            ' El usuario ya confirmó la compra anteriormente
            ModuleCurso.curso_id = 3
            Curso.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnMatematicas1_Click(sender As Object, e As EventArgs) Handles btnMatematicas1.Click
        Dim cursoNombre As String = "Matemáticas I"
        Dim cursoCosto As String = "650 pesos" ' Puedes obtener el costo de otra manera

        ' Verifica si el usuario ya confirmó la compra
        If Not usuarioConfirmoCompra Then
            Dim mensaje As String = "Estás a punto de comprar el curso de:" & Environment.NewLine &
                            cursoNombre & Environment.NewLine &
                            "El costo es de " & cursoCosto & Environment.NewLine &
                            "¿Deseas continuar con esta acción?"

            Dim titulo As String = "Confirmación de compra"
            Dim resultado As DialogResult = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OKCancel)

            If resultado = DialogResult.OK Then
                ' El usuario ha hecho clic en Aceptar
                ModuleCurso.curso_id = 4
                ModuleCurso.curso_nombre = cursoNombre
                usuarioConfirmoCompra = True ' Establece la variable de control en Verdadero

                ' Crea una instancia de la clase Pago para registrar el pago
                Dim pago As New ClassLibCursoEdu.Pago
                pago.PagoUsuarioId = ModuleUsuario.usuario_id
                pago.PagoCursoId = ModuleCurso.curso_id ' Usa el ID del curso actual
                pago.PagoFecha = DateTime.Now
                pago.PagoDescuento = 0 ' Puedes modificar el descuento según tus necesidades

                ' Verifica si el usuario ya ha pagado este curso
                If Not pago.UsuarioHaPagadoCurso(ModuleUsuario.usuario_id, ModuleCurso.curso_id) Then
                    ' Intenta guardar el registro de pago
                    If pago.GuardarPago() Then
                        ' Pago exitoso
                        MessageBox.Show("Compra exitosa. Se ha registrado el pago.")
                    Else
                        ' Error al guardar el pago
                        MessageBox.Show("Error al guardar el pago.")
                    End If
                Else
                    ' El usuario ya ha pagado este curso
                    MessageBox.Show("Ya has pagado este curso anteriormente.")
                End If

                ' Mostrar el formulario del curso
                Curso.Show()
                Me.Close()
            End If
        Else
            ' El usuario ya confirmó la compra anteriormente
            ModuleCurso.curso_id = 4
            Curso.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnMatematicas2_Click(sender As Object, e As EventArgs) Handles btnMatematicas2.Click
        Dim cursoNombre As String = "Matemáticas II"
        Dim cursoCosto As String = "650 pesos" ' Puedes obtener el costo de otra manera

        ' Verifica si el usuario ya confirmó la compra
        If Not usuarioConfirmoCompra Then
            Dim mensaje As String = "Estás a punto de comprar el curso de:" & Environment.NewLine &
                            cursoNombre & Environment.NewLine &
                            "El costo es de " & cursoCosto & Environment.NewLine &
                            "¿Deseas continuar con esta acción?"

            Dim titulo As String = "Confirmación de compra"
            Dim resultado As DialogResult = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OKCancel)

            If resultado = DialogResult.OK Then
                ' El usuario ha hecho clic en Aceptar
                ModuleCurso.curso_id = 5
                ModuleCurso.curso_nombre = cursoNombre
                usuarioConfirmoCompra = True ' Establece la variable de control en Verdadero

                ' Crea una instancia de la clase Pago para registrar el pago
                Dim pago As New ClassLibCursoEdu.Pago
                pago.PagoUsuarioId = ModuleUsuario.usuario_id
                pago.PagoCursoId = ModuleCurso.curso_id ' Usa el ID del curso actual
                pago.PagoFecha = DateTime.Now
                pago.PagoDescuento = 0 ' Puedes modificar el descuento según tus necesidades

                ' Verifica si el usuario ya ha pagado este curso
                If Not pago.UsuarioHaPagadoCurso(ModuleUsuario.usuario_id, ModuleCurso.curso_id) Then
                    ' Intenta guardar el registro de pago
                    If pago.GuardarPago() Then
                        ' Pago exitoso
                        MessageBox.Show("Compra exitosa. Se ha registrado el pago.")
                    Else
                        ' Error al guardar el pago
                        MessageBox.Show("Error al guardar el pago.")
                    End If
                Else
                    ' El usuario ya ha pagado este curso
                    MessageBox.Show("Ya has pagado este curso anteriormente.")
                End If

                ' Mostrar el formulario del curso
                Curso.Show()
                Me.Close()
            End If
        Else
            ' El usuario ya confirmó la compra anteriormente
            ModuleCurso.curso_id = 5
            Curso.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnMatematicas3_Click(sender As Object, e As EventArgs) Handles btnMatematicas3.Click
        Dim cursoNombre As String = "Matemáticas III"
        Dim cursoCosto As String = "650 pesos" ' Puedes obtener el costo de otra manera

        ' Verifica si el usuario ya confirmó la compra
        If Not usuarioConfirmoCompra Then
            Dim mensaje As String = "Estás a punto de comprar el curso de:" & Environment.NewLine &
                            cursoNombre & Environment.NewLine &
                            "El costo es de " & cursoCosto & Environment.NewLine &
                            "¿Deseas continuar con esta acción?"

            Dim titulo As String = "Confirmación de compra"
            Dim resultado As DialogResult = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OKCancel)

            If resultado = DialogResult.OK Then
                ' El usuario ha hecho clic en Aceptar
                ModuleCurso.curso_id = 6
                ModuleCurso.curso_nombre = cursoNombre
                usuarioConfirmoCompra = True ' Establece la variable de control en Verdadero

                ' Crea una instancia de la clase Pago para registrar el pago
                Dim pago As New ClassLibCursoEdu.Pago
                pago.PagoUsuarioId = ModuleUsuario.usuario_id
                pago.PagoCursoId = ModuleCurso.curso_id ' Usa el ID del curso actual
                pago.PagoFecha = DateTime.Now
                pago.PagoDescuento = 0 ' Puedes modificar el descuento según tus necesidades

                ' Verifica si el usuario ya ha pagado este curso
                If Not pago.UsuarioHaPagadoCurso(ModuleUsuario.usuario_id, ModuleCurso.curso_id) Then
                    ' Intenta guardar el registro de pago
                    If pago.GuardarPago() Then
                        ' Pago exitoso
                        MessageBox.Show("Compra exitosa. Se ha registrado el pago.")
                    Else
                        ' Error al guardar el pago
                        MessageBox.Show("Error al guardar el pago.")
                    End If
                Else
                    ' El usuario ya ha pagado este curso
                    MessageBox.Show("Ya has pagado este curso anteriormente.")
                End If

                ' Mostrar el formulario del curso
                Curso.Show()
                Me.Close()
            End If
        Else
            ' El usuario ya confirmó la compra anteriormente
            ModuleCurso.curso_id = 6
            Curso.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnHistoria1_Click(sender As Object, e As EventArgs) Handles btnHistoria1.Click
        Dim cursoNombre As String = "Historia I"
        Dim cursoCosto As String = "650 pesos" ' Puedes obtener el costo de otra manera

        ' Verifica si el usuario ya confirmó la compra
        If Not usuarioConfirmoCompra Then
            Dim mensaje As String = "Estás a punto de comprar el curso de:" & Environment.NewLine &
                            cursoNombre & Environment.NewLine &
                            "El costo es de " & cursoCosto & Environment.NewLine &
                            "¿Deseas continuar con esta acción?"

            Dim titulo As String = "Confirmación de compra"
            Dim resultado As DialogResult = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OKCancel)

            If resultado = DialogResult.OK Then
                ' El usuario ha hecho clic en Aceptar
                ModuleCurso.curso_id = 7
                ModuleCurso.curso_nombre = cursoNombre
                usuarioConfirmoCompra = True ' Establece la variable de control en Verdadero

                ' Crea una instancia de la clase Pago para registrar el pago
                Dim pago As New ClassLibCursoEdu.Pago
                pago.PagoUsuarioId = ModuleUsuario.usuario_id
                pago.PagoCursoId = ModuleCurso.curso_id ' Usa el ID del curso actual
                pago.PagoFecha = DateTime.Now
                pago.PagoDescuento = 0 ' Puedes modificar el descuento según tus necesidades

                ' Verifica si el usuario ya ha pagado este curso
                If Not pago.UsuarioHaPagadoCurso(ModuleUsuario.usuario_id, ModuleCurso.curso_id) Then
                    ' Intenta guardar el registro de pago
                    If pago.GuardarPago() Then
                        ' Pago exitoso
                        MessageBox.Show("Compra exitosa. Se ha registrado el pago.")
                    Else
                        ' Error al guardar el pago
                        MessageBox.Show("Error al guardar el pago.")
                    End If
                Else
                    ' El usuario ya ha pagado este curso
                    MessageBox.Show("Ya has pagado este curso anteriormente.")
                End If

                ' Mostrar el formulario del curso
                Curso.Show()
                Me.Close()
            End If
        Else
            ' El usuario ya confirmó la compra anteriormente
            ModuleCurso.curso_id = 7
            Curso.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnHistoria2_Click(sender As Object, e As EventArgs) Handles btnHistoria2.Click
        Dim cursoNombre As String = "Historia Ii"
        Dim cursoCosto As String = "650 pesos" ' Puedes obtener el costo de otra manera

        ' Verifica si el usuario ya confirmó la compra
        If Not usuarioConfirmoCompra Then
            Dim mensaje As String = "Estás a punto de comprar el curso de:" & Environment.NewLine &
                            cursoNombre & Environment.NewLine &
                            "El costo es de " & cursoCosto & Environment.NewLine &
                            "¿Deseas continuar con esta acción?"

            Dim titulo As String = "Confirmación de compra"
            Dim resultado As DialogResult = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OKCancel)

            If resultado = DialogResult.OK Then
                ' El usuario ha hecho clic en Aceptar
                ModuleCurso.curso_id = 8
                ModuleCurso.curso_nombre = cursoNombre
                usuarioConfirmoCompra = True ' Establece la variable de control en Verdadero

                ' Crea una instancia de la clase Pago para registrar el pago
                Dim pago As New ClassLibCursoEdu.Pago
                pago.PagoUsuarioId = ModuleUsuario.usuario_id
                pago.PagoCursoId = ModuleCurso.curso_id ' Usa el ID del curso actual
                pago.PagoFecha = DateTime.Now
                pago.PagoDescuento = 0 ' Puedes modificar el descuento según tus necesidades

                ' Verifica si el usuario ya ha pagado este curso
                If Not pago.UsuarioHaPagadoCurso(ModuleUsuario.usuario_id, ModuleCurso.curso_id) Then
                    ' Intenta guardar el registro de pago
                    If pago.GuardarPago() Then
                        ' Pago exitoso
                        MessageBox.Show("Compra exitosa. Se ha registrado el pago.")
                    Else
                        ' Error al guardar el pago
                        MessageBox.Show("Error al guardar el pago.")
                    End If
                Else
                    ' El usuario ya ha pagado este curso
                    MessageBox.Show("Ya has pagado este curso anteriormente.")
                End If

                ' Mostrar el formulario del curso
                Curso.Show()
                Me.Close()
            End If
        Else
            ' El usuario ya confirmó la compra anteriormente
            ModuleCurso.curso_id = 8
            Curso.Show()
            Me.Close()
        End If
    End Sub


    Private Sub Cursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblNombreUsuario.Text = ModuleUsuario.usuario_id & " | " & ModuleUsuario.usuario_nombre & " | Fecha de acceso: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")



        ' Registra la actividad de inicio de sesión al cargar el formulario
        Dim agregar As New ClassLibCursoEdu.Actividad()
        agregar.ActividadUsuarioId = 1
        agregar.ActividadFecha = DateTime.Now

        ' Intenta registrar la actividad
        Try
            If agregar.ActividadAlta() Then
                ' Registro exitoso
                Console.WriteLine("Actividad registrada con éxito.")
            Else
                ' Error al registrar la actividad
                Console.WriteLine("Error al registrar la actividad.")
            End If
        Catch ex As Exception
            ' Captura y muestra los detalles del error en la consola
            Console.WriteLine("Error al registrar la actividad: " & ex.Message)
        End Try
    End Sub



    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class