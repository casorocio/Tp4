Public Class RubrosGrid
    Dim MiRubro As New RubroClass
    Private Sub Insertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insertar.Click

        RubroForm.operacion = "Insertar"
        RubroForm.Text = "Insertar  Rubro"

        RubroForm.Show()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click

        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para eliminar.")
            Exit Sub
        End If

        RubroForm.operacion = "Eliminar"
        RubroForm.Text = "Eliminar  Rubro"
        RubroForm.indice = DataGridView1.CurrentRow.Index
        'CursoForm.TituloLable1.text = "Eliminar Curso"

        llenarform()
        RubroForm.Show()
    End Sub

    Private Sub Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar.Click

        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para modificar.")
            Exit Sub
        End If

        RubroForm.operacion = "Modificar"
        RubroForm.Text = "Modifica  Rubro"
        RubroForm.indice = DataGridView1.CurrentRow.Index

        llenarform()
        RubroForm.Show()

        'Selecciono nuevamente la fila para que refresque el contenido, sino no muestra la modificación.
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = False
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True

    End Sub

    Private Sub llenarform()

        'Número dila seleccionado del datagridview
        Dim fila As Integer = DataGridView1.CurrentRow.Index

        RubroForm.Id.Text = RubrosList.Item(fila).Id
        RubroForm.Descripcion.Text = RubrosList.Item(fila).Descripcion

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click

        MenuForm.Label1.Text = "Productos"
        MenuForm.ToolStrip1.Enabled = True

        Me.Dispose()

    End Sub

    Private Sub RubosGrid_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        MenuForm.Label1.Text = "Productos"
        MenuForm.ToolStrip1.Enabled = True

        Me.Dispose()

    End Sub

    Private Sub RubrosGrid_Load(sender As Object, e As EventArgs) Handles Me.Load

        RubrosCollectionBindingSource.DataSource = RubrosList.TraerRubro

        'Si la cantidad de filas es mayor a cero, entonces selecciono la primer fila.
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If
    End Sub
End Class