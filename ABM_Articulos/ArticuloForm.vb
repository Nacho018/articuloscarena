Public Class ArticuloForm

    Dim operacion_ As String
    Dim MiArticulo As New ArticuloClass

    Public Property operacion() As String
        Get
            Return operacion_


        End Get

        Set(ByVal value As String)

            operacion_ = value

        End Set



    End Property


    Dim indice_ As Byte

    Public Property indice() As String
        Get
            Return indice_

        End Get
        Set(ByVal value As String)
            indice_ = value

        End Set

    End Property

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click

        Me.Close()

    End Sub


    Private Sub aceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles aceptar.Click



        MiArticulo.articulo = TextBox7.Text

        MiArticulo.Codigo = CInt(TextBox1.Text)


        MiArticulo.Descripcion = (TextBox2.Text)

        MiArticulo.unidad = (ComboBox1.SelectedItem)


        MiArticulo.Stock = CDec(TextBox3.Text)

        MiArticulo.Costo = CDec(TextBox4.Text)

        MiArticulo.Iva = CDec(ComboBox2.SelectedIndex)

        MiArticulo.utilidad = CDec(TextBox5.Text)



        ComboBox2.DataSource = listaiva

        'TextBox6.Text = ""


        'TextBox6.Focus()


        Select operacion_

            Case "agregar"

                lst.Add(MiArticulo)

            Case "Eliminar"


                lst.RemoveAt(indice_)

            Case "Modificar"

                lst.Item(indice_) = MiArticulo





                ArticulosGrid.DataGridView1.Refresh()

        End Select



        Me.Close()







    End Sub




    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then


            e.Handled = True


        End If


    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then

            e.Handled = True


        End If




    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress


        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then


            e.Handled = True

        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then


            e.Handled = True

        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then


            e.Handled = True

        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress


        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then

            e.Handled = True


        End If


    End Sub


    Private Sub ArticuloForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        TextBox6.ReadOnly = True



    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress


        e.Handled = True

    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox2.KeyPress


        e.Handled = True
    End Sub
End Class
