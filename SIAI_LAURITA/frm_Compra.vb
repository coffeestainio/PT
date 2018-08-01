Imports System.Data.SqlClient
Imports System.math
Public Class frm_Compra
    
    Public TCD As DataTable
    Public Producto As DataTable
    Public Proveedor As DataTable
    Public rowp As DataRow

    
    Public tGravado As Decimal
    Public tExento As Decimal
    Public tGd As Decimal
    Public tEd As Decimal
    Public tdescuento As Decimal
    Public tiv As Decimal
    Public total As Decimal



    Public Fecha As String
    Public CompraID As String
    Public ProveedorID As String
    Public PIV As Decimal

    Private Sub frm_Compra_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        myForms.frm_principal.ToolStrip.Enabled = True
        CONN1.Close()
    End Sub
    
    Private Sub frm_Compra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        If Not Consulta Then
            CONN1.Open()
            TCD_crear()
            dtgcompra.DataSource = TCD
            Dim Ptro As DataTable
            Ptro = Table("select * from parametro", "")
            With Ptro.Rows(0)
                PIV = .Item("iv")
            End With
        End If
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub
    Public Sub Identifica_Proveedor()
        ' Try
        Proveedor = Table("select * from proveedor where eliminado=0 and id_proveedor=" + txtid_proveedor.Text, "")
        If Proveedor.Rows.Count = 0 Then
            MessageBox.Show("Proveedor no Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If
        rowp = Proveedor.Rows(0)
        'txtplazo.Text = rowp("plazo")
        lblProveedor_nombre.Text = rowp("nombre")
        ProveedorID = txtid_proveedor.Text
        btnincluir.Enabled = True
        SendKeys.Send("{tab}")
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub

    

    Public Sub Totales()
        Try
            Dim mf As Decimal
            Dim m As Decimal = 0
            Dim d As Decimal = 0

            Dim productos As Decimal = 0
            tGravado = 0
            tExento = 0
            tdescuento = 0
            tiv = 0
            total = 0
            Dim i As Integer

            For i = 0 To TCD.Rows.Count - 1
                With TCD.Rows(i)
                    m = .Item("costo_nuevo") * .Item("cantidad")
                    d = m * (.Item("descuento") / 100)

                    mf = m - d
                    If .Item("iv") Then
                        tGravado = tGravado + mf
                        tiv = tiv + mf * PIV
                    Else
                        tExento = tExento + mf
                    End If
                    'tdescuento = tdescuento + d
                    productos = productos + 1
                End With
            Next i

            total = tExento + tGravado + tiv
            lblproductos.Text = productos
            If TCD.Rows.Count > 0 Then
                botones(True)
            Else
                botones(False)
                btnincluir.Enabled = True
            End If
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub limpiar()
        Try
            lblproveedor_nombre.Text = ""
            txtid_proveedor.Text = ""
            txtfactura.Text = ""
            TCD.Rows.Clear()
            Totales()
            txtid_proveedor.Focus()
            ToolStrip1.Enabled = False
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub Incluir_producto()
        Dim Compra_mantenimiento As New frm_Compra_Mantenimiento
        myForms.frm_Compra_Mantenimiento = Compra_mantenimiento
        myForms.frm_Compra_Mantenimiento.Owner = Me
        Compra_mantenimiento.Show()
        Compra_mantenimiento.lbltitulo.Text = "Incluir Producto"
    End Sub

    Private Sub tsbfacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub botones(ByVal e As Boolean)
        btnincluir.Enabled = e
        btnmodificar.Enabled = e
        btneliminar.Enabled = e
        btnguardar.Enabled = e
        
    End Sub


    Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'imprimir()
    End Sub

    Private Sub txtid_Proveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid_proveedor.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            If Val(txtid_proveedor.Text) = 0 Then
                Me.Close()
            Else
                Identifica_Proveedor()
            End If
        Else
            If Not IsNumeric(Convert.ToChar(e.KeyChar)) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
                BUSQUEDA = "Compra"
                Dim Proveedor_buscar As New frm_Proveedor_Buscar
                Proveedor_buscar.Owner = Me
                Proveedor_buscar.Show()
                Proveedor_buscar.txtbuscar_Proveedor.Text = e.KeyChar
            Else
                e.Handled = Numerico(Asc(e.KeyChar), txtid_proveedor.Text, False)
            End If
        End If
    End Sub

   

    Public Sub TCD_crear()
        'Try

        TCD = New DataTable("TCD")
        Dim id_producto As DataColumn = New DataColumn("id_producto")
        id_producto.DataType = System.Type.GetType("System.Int32")
        TCD.Columns.Add(id_producto)

        Dim cantidad As DataColumn = New DataColumn("cantidad")
        cantidad.DataType = System.Type.GetType("System.Decimal")
        cantidad.DefaultValue = 0
        TCD.Columns.Add(cantidad)

        Dim presentacion As DataColumn = New DataColumn("presentacion")
        presentacion.DataType = System.Type.GetType("System.String")
        TCD.Columns.Add(presentacion)

        Dim nombre As DataColumn = New DataColumn("nombre")
        nombre.DataType = System.Type.GetType("System.String")
        TCD.Columns.Add(nombre)


        Dim descuento As DataColumn = New DataColumn("descuento")
        descuento.DataType = System.Type.GetType("System.Decimal")
        descuento.DefaultValue = 0
        TCD.Columns.Add(descuento)

        

        Dim costo_nuevo As DataColumn = New DataColumn("costo_nuevo")
        costo_nuevo.DataType = System.Type.GetType("System.Decimal")
        costo_nuevo.DefaultValue = 0
        TCD.Columns.Add(costo_nuevo)

        Dim Monto As DataColumn = New DataColumn("Monto")
        Monto.DataType = System.Type.GetType("System.Decimal")
        Monto.Expression = "cantidad * costo_nuevo"
        TCD.Columns.Add(Monto)

        Dim iv As DataColumn = New DataColumn("iv")
        iv.DataType = System.Type.GetType("System.Boolean")
        TCD.Columns.Add(iv)

        Dim precio_actual As DataColumn = New DataColumn("precio_actual")
        precio_actual.DataType = System.Type.GetType("System.Decimal")
        TCD.Columns.Add(precio_actual)


        Dim precio_nuevo As DataColumn = New DataColumn("precio_nuevo")
        precio_nuevo.DataType = System.Type.GetType("System.Decimal")
        TCD.Columns.Add(precio_nuevo)


        Dim costo_actual As DataColumn = New DataColumn("costo_actual")
        costo_actual.DataType = System.Type.GetType("System.Decimal")
        TCD.Columns.Add(costo_actual)

       
        Dim utilidad As DataColumn = New DataColumn("utilidad")
        utilidad.DataType = System.Type.GetType("System.Decimal")
        TCD.Columns.Add(utilidad)


        TCD.PrimaryKey = New DataColumn() {TCD.Columns("id_producto")}

        'Catch myerror As Exception
        ' ONEX(Me.Name, myerror)
        ' End Try

    End Sub

    Private Sub btnincluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnincluir.Click
        Incluir_producto()
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        'Try
        Dim Compra_mantenimiento As New frm_Compra_Mantenimiento
        myForms.frm_compra_mantenimiento = Compra_mantenimiento
        With myForms.frm_compra_mantenimiento
            myForms.frm_compra_mantenimiento.Owner = Me
            .lbltitulo.Text = "Modificar Producto"
            Dim row As DataRow = TCD.Rows(BindingContext(TCD).Position())
            .Owner = Me

            .txtid_producto.Text = row("id_producto")
            .lblproducto_nombre.Text = row("nombre")
            .txtcantidad.Text = row("cantidad")
            .presentacion = row("presentacion")
            .lbliv.Text = IIf(row("iv"), "+ iv", "")
            .txtcosto.Text = row("costo_nuevo")
            .costo_actual = row("costo_actual")
            .lblcosto_actual.Text = row("costo_actual")
            .txtprecio.Text = row("precio_nuevo")
            .lblprecio_actual.Text = FormatNumber(row("precio_actual"), 2)
            .precio_actual = row("precio_actual")
            .txtdescuento.Text = row("descuento")
            .lblutilidad.Text = FormatNumber(.utilidad() * 100, 2)
            .lblcosto_final.Text = FormatNumber(.costo_final(), 2)
            .Producto_ID = row("id_producto")
            .Show()
            .txtcantidad.Focus()
            SendKeys.Send("{home}+{end}")
        End With
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Try
            If TCD.Rows.Count = 0 Then
                MessageBox.Show("Nada que Eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim row As DataRow = TCD.Rows(BindingContext(TCD).Position())
            Dim res As DialogResult = MessageBox.Show("Elimnar " + row("nombre"), "Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = Windows.Forms.DialogResult.Yes Then
                row.Delete()
                Totales()
            End If
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If TCD.Rows.Count = 0 Then
            MessageBox.Show("No Hay Productos que Guardar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Val(txtid_proveedor.Text) = 0 Then
            MessageBox.Show("Debe Escribir un C�digo de Proveedor", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid_proveedor.Focus()
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If

        


        If ProveedorID <> txtid_proveedor.Text Then
            MessageBox.Show("Escriba de Nuevo el c�digo del Proveedor y Presione Enter", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid_proveedor.Focus()
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If


        Guardar()
        Me.Close()
    End Sub


    Private Sub Guardar()
        'Try


        Dim cmd As New SqlCommand
        cmd.Connection = CONN1
        Dim Sql As String
        Dim C As DataTable
        Sql = "Insert into Compra (fecha,id_factura,id_Proveedor,plazo,monto,id_usuario) values (" + _
        "'" + EDATE(dtpfecha.Text) + "'," + _
        "' '," + _
        txtid_proveedor.Text + "," + _
        Val(txtplazo.Text).ToString + "," + _
        Val(txtmonto.Text).ToString + "," + _
        USUARIO_ID + ")"

        C = Table(Sql + " select @@IDENTITY as id_Compra", "")
        CompraID = C.Rows(0).Item("id_Compra")


        Dim i As Integer
        For i = 0 To TCD.Rows.Count - 1
            With TCD.Rows(i)
                Sql = "insert into Compra_detalle (id_Compra,id_producto,cantidad,precio,descuento) values (" + _
                CompraID + "," + _
                "'" + .Item("id_producto").ToString + "'," + _
                .Item("cantidad").ToString + "," + _
                .Item("costo_nuevo").ToString + "," + _
                (.Item("descuento") / 100).ToString + ")"

                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                'Sql = "update Producto set existencia=existencia+" + .Item("cantidad").ToString + "," + _
                Sql = "update Producto set costo=" + (.Item("costo_nuevo") - .Item("costo_nuevo") * (.Item("descuento") / 100)).ToString + "," + _
                    "precio1=" + .Item("precio_nuevo").ToString + _
                 " where id_Producto=" + .Item("id_producto").ToString

                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                'ajustes

                Sql = "insert into Bodega_ajuste (tipo,id_producto,cantidad,id_usuario,fecha,observaciones) values (0," + _
               .Item("id_producto").ToString + "," + _
               .Item("cantidad").ToString + "," + _
               USUARIO_ID + "," + _
               "'" + EDATE(Date.Today.ToShortDateString) + "'," + _
               "'Ajuste de Entrada por Compra')"

                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

            End With
        Next i
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub txtid_proveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_proveedor.TextChanged

    End Sub

    Private Sub txtplazo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtplazo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtplazo.Text, False)
        End If

    End Sub

    Private Sub txtfactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfactura.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtfactura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfactura.TextChanged

    End Sub

    Private Sub txtmonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmonto.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            Incluir_producto()
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtmonto.Text, False)
        End If
    End Sub

    Private Sub dtpfecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpfecha.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub dtpfecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpfecha.ValueChanged

    End Sub

    Private Sub txtplazo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtplazo.TextChanged

    End Sub

    Private Sub txtmonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmonto.TextChanged

    End Sub
End Class