Public Class MenuForm
    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Rubro_Click(sender As Object, e As EventArgs) Handles Rubro.Click
        ToolStrip1.Enabled = False

        Dim gridRubros As New RubrosGrid

        gridRubros.MdiParent = Me

        gridRubros.Show()
    End Sub

    Private Sub Articulo_Click(sender As Object, e As EventArgs) Handles Articulo.Click
        ToolStrip1.Enabled = False

        Dim gridArticulos As New ArticulosGrid

        gridArticulos.MdiParent = Me

        gridArticulos.Show()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub
End Class