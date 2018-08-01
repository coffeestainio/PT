Imports system.math
Public Class frm_Compra_Mantenimiento
    Public Producto_ID As String
    Dim rowp As DataRow
    Dim producto As DataTable
    Public costo_actual As Decimal
    Public precio_actual As Decimal
    Public presentacion As String

    Public Sub Identifica_producto()
        'Try
        With myForms.frm_compra
            producto = Table("select * from producto where eliminado=0 and id_producto=" + txtid_producto.Text, "")

            If producto.Rows.Count = 0 Then
                MessageBox.Show("Producto no Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SendKeys.Send("{home}+{end}")
                Exit Sub
            End If

            rowp = producto.Rows(0)

            Dim row As DataRow
            row = .TCD.Rows.Find(txtid_producto.Text)
            If Not (row Is Nothing) Then
                If (lbltitulo.Text = "Incluir Producto") Or (lbltitulo.Text <> "Incluir Producto" And .TCD.Rows(.BindingContext(.TCD).Position()).Item("id_producto") <> row("id_producto")) Then
                    MessageBox.Show("Código de Producto Ya Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtid_producto.Focus()
                    SendKeys.Send("{home}+{end}")
                    Exit Sub
                End If
            End If

            lblproducto_nombre.Text = rowp("nombre")
            lbliv.Text = IIf(rowp("iv"), "+ iv", "")
            lblpresentacion.Text = Prst(rowp("Presentacion"))
            txtcosto.Text = rowp("costo")

            txtprecio.Text = rowp("precio1")
            lblcosto_actual.Text = FormatNumber(rowp("costo"), 2)
            costo_actual = rowp("costo")
            lblprecio_actual.Text = FormatNumber(rowp("precio1"), 2)
            precio_actual = rowp("precio1")
            presentacion = Prst(rowp("presentacion"))
            txtcantidad.Focus()
            Producto_ID = txtid_producto.Text
            SendKeys.Send("{home}+{end}")
        End With
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub


    Private Sub txtid_producto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid_producto.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) And Val(txtid_producto.Text) = 0 Then
            e.Handled = True
            Me.Close()
            Exit Sub
        End If


        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            Identifica_producto()
            e.Handled = True
            Exit Sub
        End If

        If Not IsNumeric(Convert.ToChar(e.KeyChar)) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            BUSQUEDA = "Compra"
            Dim producto_buscar As New frm_producto_buscar
            producto_buscar.Owner = Me
            producto_buscar.Show()
            producto_buscar.txtbuscar_producto.Text = e.KeyChar
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtid_producto.Text, False)
        End If


    End Sub



    Private Sub Actualizar()
        'Try
        If Val(txtid_producto.Text) = 0 Then
            pbid_producto.Visible = True
            MessageBox.Show("Debe digitar un código de producto", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pbid_producto.Visible = True
            txtid_producto.Focus()
            SendKeys.Send("{home}+{end}")
            Exit Sub
        Else
            pbid_producto.Visible = False
        End If

        If Producto_ID <> txtid_producto.Text Then
            MessageBox.Show("Escriba de Nuevo el Número de producto y Presione Enter", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pbid_producto.Visible = True
            txtid_producto.Focus()
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If

        If Val(txtcantidad.Text) = 0 Then
            pbcantidad.Visible = True
            MessageBox.Show("Debe digitar una cantidad", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pbcantidad.Visible = True
            txtcantidad.Focus()
            SendKeys.Send("{home}+{end}")
            Exit Sub
        Else
            pbcantidad.Visible = False
        End If

        Dim row As DataRow
        With myForms.frm_compra


            If lbltitulo.Text = "Incluir Producto" Then
                row = .TCD.NewRow()
            Else
                row = .TCD.Rows(.BindingContext(.TCD).Position())
            End If

            row("id_producto") = txtid_producto.Text

            row("nombre") = lblproducto_nombre.Text
            row("presentacion") = presentacion
            row("cantidad") = txtcantidad.Text
            row("costo_actual") = costo_actual
            row("costo_nuevo") = txtcosto.Text
            row("Precio_actual") = precio_actual
            row("Precio_nuevo") = txtprecio.Text
            row("utilidad") = utilidad()
            row("DESCUENTO") = Val(txtdescuento.Text)
            row("iv") = IIf(lbliv.Text = "", 0, 1)


            If lbltitulo.Text = "Incluir Producto" Then
                .TCD.Rows.Add(row)
            End If

            .Totales()
        End With

        If lbltitulo.Text = "Incluir Producto" Then
            limpiar()
        Else
            myForms.frm_compra.Totales()
            Me.Close()
        End If
        'Catch myerror As Exception
        ' ONEX(Me.Name, myerror)
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


    Private Sub limpiar()
        Try
            txtid_producto.Text = ""
            txtcantidad.Text = ""
            lblproducto_nombre.Text = ""
            lbliv.Text = ""
            txtcosto.Text = ""
            txtprecio.Text = ""
            lblcosto_actual.Text = ""
            lblprecio_actual.Text = ""
            lblutilidad.Text = ""
            lblcosto_final.Text = ""
            lblpresentacion.Text = ""
            txtid_producto.Focus()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Public Function costo_final() As Decimal
        Dim d1 As Decimal = Val(txtcosto.Text) * Val(txtdescuento.Text) / 100
        Return Val(txtcosto.Text) - d1
    End Function



    Private Sub txtdesca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescuento.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            lblcosto_final.Text = FormatNumber(costo_final, 2)
            lblutilidad.Text = FormatNumber(utilidad() * 100, 2)
            SendKeys.Send("{TAB}")
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtdescuento.Text, True)
        End If
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Actualizar()
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub


    Public Function utilidad() As Decimal
        utilidad = (Val(txtprecio.Text) / Val(txtcosto.Text)) - 1
    End Function

    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            lblutilidad.Text = FormatNumber(utilidad() * 100, 2)
            SendKeys.Send("{TAB}")
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtprecio.Text, False)
        End If
    End Sub

    Private Sub txtcosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcosto.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            lblcosto_final.Text = FormatNumber(costo_final, 2)
            lblutilidad.Text = FormatNumber(utilidad() * 100, 2)
            SendKeys.Send("{TAB}")
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtcosto.Text, True)
        End If
    End Sub

    Private Sub txtid_producto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_producto.TextChanged

    End Sub

    Private Sub frm_Compra_Mantenimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class