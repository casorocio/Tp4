Public Class ArticulosGrid
    Dim MiArticulo As New ArticuloClass

    Private Sub Insertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insertar.Click

        ArticuloForm.operacion = "Insertar"
        ArticuloForm.Text = "Insertar Articulo"

        ArticuloForm.Show()
    End Sub

    Private Sub Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar.Click

        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para eliminar.")
            Exit Sub
        End If

        ArticuloForm.operacion = "Eliminar"
        ArticuloForm.Text = "Eliminar  Articulo"
        ArticuloForm.indice = DataGridView1.CurrentRow.Index
        'CursoForm.TituloLable1.text = "Eliminar Curso"
        ArticuloForm.IdRubro = ArticulosList.Item(DataGridView1.CurrentRow.Index).IdRubro

        llenarform()
        ArticuloForm.Show()
    End Sub

    Private Sub Actualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar.Click

        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para modificar.")
            Exit Sub
        End If

        ArticuloForm.operacion = "Modificar"
        ArticuloForm.Text = "Modifica  Articulo"
        ArticuloForm.indice = DataGridView1.CurrentRow.Index

        llenarform()
        ArticuloForm.Show()

        'Selecciono nuevamente la fila para que refresque el contenido, sino no muestra la modificación.
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = False
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Selected = True

    End Sub

    Private Sub llenarform()

        'Número dila seleccionado del datagridview
        Dim fila As Integer = DataGridView1.CurrentRow.Index

        ArticuloForm.Id.Text = ArticulosList.Item(fila).Id
        ArticuloForm.Descripcion.Text = ArticulosList.Item(fila).Descripcion

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click

        MenuForm.Label1.Text = "Productos"
        MenuForm.ToolStrip1.Enabled = True

        Me.Dispose()

    End Sub

    Private Sub CursosGrid_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        MenuForm.Label1.Text = "Productos"
        MenuForm.ToolStrip1.Enabled = True

        Me.Dispose()

    End Sub

    Private Sub ArticulosGrid_Load(sender As Object, e As EventArgs) Handles Me.Load

        ArticulosCollectionBindingSource.DataSource = ArticulosList.TraerArticulos
        'IdRubroComboBox.ComboBox.DataSource = RubrosList.TraerRubro()
        'IdRubroComboBox.ComboBox.DisplayMember = "Descripcion"
        'IdRubroComboBox.ComboBox.ValueMember = "Id"

        'Si la cantidad de filas es mayor a cero, entonces selecciono la primer fila.
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If
    End Sub

    Private Sub Filtro_Click(sender As Object, e As EventArgs) Handles Filtro.Click

        ArticulosCollectionBindingSource.DataSource = ArticulosList.TraerArticulos(IdRubroComboBox.ComboBox.SelectedValue)
    End Sub
End Class