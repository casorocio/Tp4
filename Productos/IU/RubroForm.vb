Public Class RubroForm
    Dim operacion_ As String
    Dim MiRubro As New RubroClass

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

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

        If operacion_ <> "Insertar" Then
            MiRubro.Id = CInt(Id.Text)
        End If

        MiRubro.Descripcion = Descripcion.Text

        Select Case operacion_

            Case "Insertar"
                RubrosList.InsertarRubro(MiRubro)

            Case "Actualizar"
                RubrosList.ActualizarRubro(MiRubro)

            Case "Eliminar"
                RubrosList.EliminarRubro(MiRubro)

        End Select


        Me.Close()
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
End Class