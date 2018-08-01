Public Class frm_Bodega_Ajuste_mantenimiento
    Dim Producto_ID As Integer
    Dim Producto As DataTable
    Private Sub txtid_producto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid_producto.KeyPress
        Try
            If e.KeyChar = Convert.ToChar(Keys.Return) Then
                e.Handled = True
                If Val(txtid_producto.Text) = 0 Then
                    Me.Close()
                Else
                    Identifica_producto()
                End If
            Else
                If Not IsNumeric(Convert.ToChar(e.KeyChar)) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
                    BUSQUEDA = "Bodega_Ajuste"
                    Dim producto_buscar As New frm_producto_buscar
                    producto_buscar.Owner = Me
                    producto_buscar.Show()
                    producto_buscar.txtbuscar_producto.Text = e.KeyChar
                Else
                    e.Handled = Numerico(Asc(e.KeyChar), txtid_producto.Text, False)
                End If
            End If
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Public Sub Identifica_producto()
        'Try
        Producto = Table("select * from producto where eliminado=0 and id_producto=" + txtid_producto.Text, "")
        If Producto.Rows.Count = 0 Then
            MessageBox.Show("Producto no Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If
        With myForms.frm_bodega_ajuste
            Dim row As DataRow = .Ajuste.Rows.Find(txtid_producto.Text)
            If Not (row Is Nothing) Then
                lblproducto_nombre.ForeColor = Color.Red
                lblproducto_nombre.Text = "Producto Ya Existe"
                txtid_producto.Focus()
                SendKeys.Send("{home}+{end}")
                Exit Sub
            End If
        End With

        lblproducto_nombre.Text = Producto.Rows(0).Item("nombre")
        lblpresentacion.Text = Prst(Producto.Rows(0).Item("presentacion"))
        txtcantidad.Focus()
        Producto_ID = txtid_producto.Text
        SendKeys.Send("{home}+{end}")
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub



    Private Sub txtid_producto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_producto.TextChanged

    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        'Try
        If Val(txtid_producto.Text) = 0 Then
            MessageBox.Show("Escriba un código de Producto", "", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
            pbid_producto.Visible = True
            txtid_producto.Focus()
            Exit Sub
        End If
        If Producto_ID <> txtid_producto.Text Then
            MessageBox.Show("Escriba de Nuevo el código del Producto y presione Enter Cantidad ", "", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
            pbid_producto.Visible = True
            txtid_producto.Focus()
            Exit Sub
        End If
        If Val(txtcantidad.Text) = 0 Then
            MessageBox.Show("Escriba una Cantidad ", "", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
            pbcantidad.Visible = True
            txtcantidad.Focus()
            Exit Sub
        End If
        Dim row As DataRow
        With myForms.frm_bodega_ajuste

            row = .Ajuste.NewRow()
            row("id_producto") = txtid_producto.Text
            row("cantidad") = txtcantidad.Text
            row("nombre") = lblproducto_nombre.Text
            row("presentacion") = lblpresentacion.Text
            row("tipo") = cbtipo.Text
            row("observaciones") = txtobservaciones.Text
            .Ajuste.Rows.Add(row)
        End With
        limpiar()
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub limpiar()
        'Try
        txtid_producto.Text = ""
        txtcantidad.Text = ""
        lblproducto_nombre.Text = ""
        lblpresentacion.Text = ""
        cbtipo.SelectedIndex = 0
        txtobservaciones.Text = ""
        txtid_producto.Focus()
        'Catch myerror As Exception
        'MsgBox(myerror.Message)
        'End Try
    End Sub

    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtcantidad.Text, True)
        End If
    End Sub

    Private Sub txtcantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcantidad.TextChanged

    End Sub

    Private Sub frm_ajuste_mantenimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbtipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbtipo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = chk(Asc(e.KeyChar))
        End If
    End Sub

    Private Sub txtobservaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtobservaciones.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            btnaceptar.Focus()
        Else
            e.Handled = chk(Asc(e.KeyChar))
        End If
    End Sub

    Private Sub txtobservaciones_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtobservaciones.TextChanged

    End Sub
End Class