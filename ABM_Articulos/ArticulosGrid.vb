Public Class ArticulosGrid



    Private Sub agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agregar.Click


        ArticuloForm.operacion = "agregar"

        ArticuloForm.Text = "Alta de articulo"

        ArticuloForm.Show()


    End Sub


    Private Sub modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modificar.Click
        If lst.Count = 0 Then Exit Sub

        ArticuloForm.operacion = "Modificar"

        ArticuloForm.Text = "Modifica articulo"

        ArticuloForm.indice = DataGridView1.CurrentRow.Index



        LlenarForm()

        ArticuloForm.Show()

    End Sub

    Private Sub eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eliminar.Click

        If lst.Count = 0 Then Exit Sub
        ArticuloForm.operacion = "Eliminar"

        ArticuloForm.Text = "Elimina alumno"

        ArticuloForm.indice = DataGridView1.CurrentRow.Index



        LlenarForm()

        ArticuloForm.Show()
    End Sub


    Private Sub LlenarForm()


        ArticuloForm.TextBox7.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        ArticuloForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        ArticuloForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        'ArticuloForm.ComboBox1.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        ArticuloForm.TextBox3.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        ArticuloForm.TextBox4.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        'ArticuloForm.ComboBox2.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        ArticuloForm.TextBox5.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        ArticuloForm.TextBox6.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString


    End Sub

    Private Sub salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.Click

    End Sub

    Private Sub ArticulosGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        DataGridView1.DataSource = lst


    End Sub

    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click

    End Sub
End Class

