Public Class ArticuloForm
    Dim operacion_ As String
    Dim IdRubros_ As Integer
    Dim MiArticulo As New ArticuloClass
    Public Property IdRubros() As Integer
        Get
            Return IdRubros_
        End Get
        Set(value As Integer)
            IdRubros_ = value
        End Set
    End Property
    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property

    Dim indice_ As Byte
    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)

            indice_ = value
        End Set
    End Property

    Dim IdRubro_ As Integer
    Public Property IdRubro() As Integer
        Get
            Return IdRubro_
        End Get
        Set(value As Integer)
            IdRubro_ = value
        End Set
    End Property
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

        If operacion_ <> "Insertar" Then
            MiArticulo.Id = CInt(Id.Text)
        End If

        MiArticulo.Descripcion = Descripcion.Text

        Select Case operacion_

            Case "Insertar"
                ArticulosList.InsertarArticulo(MiArticulo)

            Case "Actualizar"
                ArticulosList.ActualizarArticulo(MiArticulo)

            Case "Eliminar"
                ArticulosList.EliminarArticulo(MiArticulo)

        End Select


        Me.Close()
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub ArticuloForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Fuente de datos la coleccion asignaturas_list.
        RubroCombo.DataSource = RubrosList.TraerRubro

        'El miembro de valor es siempre el id.
        RubroCombo.ValueMember = "Id"
        'El valor seleccionado del combo es combo que contiene el idcarrera
        RubroCombo.SelectedValue = RubroCombo
    End Sub
End Class