Public Class frm_devolucion_mantenimiento

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Try
            If Val(txtcantidad.Text) = 0 Then
                pbcantidad.Visible = True
                MessageBox.Show("Debe digitar una cantidad", "Devolución", MessageBoxButtons.OK, MessageBoxIcon.Error)
                pbcantidad.Visible = True
                txtcantidad.Focus()
                Exit Sub
            Else
                pbcantidad.Visible = False
            End If

            With myForms.frm_devolucion
                Dim rowf As DataRow
                rowf = .FD.Rows.Find(txtid_producto.Text)
                If Val(txtcantidad.Text) > rowf("cantidad") Then
                    MessageBox.Show("La cantidad a devolver no puede ser mayor a la cantiad vendida", "Devolución", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtcantidad.Focus()
                    Exit Sub
                End If
                Dim row As DataRow

                row = .devolucion.Rows(.BindingContext(.devolucion).Position())
                row("cantidad") = txtcantidad.Text
            End With
            myForms.frm_devolucion.Totales()
            Me.Close()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            btnaceptar.Focus()
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtcantidad.Text, True)
        End If
    End Sub


    Private Sub txtcantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcantidad.TextChanged

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
End Class