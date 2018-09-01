Public Class frm_consulta_documento
    Dim Documento As DataTable
    Dim Dvdocumento As DataView
    Dim TPD As DataTable
    Dim TDD As DataTable
    Dim criterio As String
    Dim tipo As String
    Dim Building As Boolean
    Dim rowc As DataRow
    Dim FIV As Decimal



    Dim cliente As DataTable
    Dim Agente As DataTable
    Dim Bodega As DataTable

    Private Sub frm_consulta_documento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CONN1.Close()
        myForms.frm_principal.ToolStrip.Enabled = True
    End Sub
    Private Sub frm_consulta_documento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        CONN1.Open()
        Building = True
        cbtipo.SelectedIndex = 0
        Documento_crear()
        Building = False
        Filtro()
        
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub
    Private Sub Filtro()
        ' Try

        Select Case cbtipo.SelectedIndex

            Case 0
                If Val(txtid_documento.Text) > 0 Then
                    criterio = " factura.id_factura = " + txtid_documento.Text
                Else
                    criterio = " factura.fecha>='" + EDATE(dtpdesde.Text) + " 00:00:00' and factura.fecha<='" + EDATE(dtphasta.Text) + " 23:59:59'"
                    If Val(txtid_cliente.Text) > 0 Then criterio = criterio + " and factura.id_cliente=" + txtid_cliente.Text
                End If
                Dim Factura As DataTable
                Factura = FACM(criterio, True, "")
                Documento_cargar(Factura, 1)
            Case 1
                If Val(txtid_documento.Text) > 0 Then
                    criterio = "recibo.id_recibo = " + txtid_documento.Text
                Else
                    criterio = "fecha>='" + EDATE(dtpdesde.Text) + "' and fecha<='" + EDATE(dtphasta.Text) + "'"
                    If Val(txtid_cliente.Text) > 0 Then criterio = criterio + " and id_cliente=" + txtid_cliente.Text
                End If
                Dim Recibo As DataTable
                Recibo = RECM(criterio, True, "")
                Documento_cargar(Recibo, 3)

            Case 2
                If Val(txtid_documento.Text) > 0 Then
                    criterio = "devolucion.id_devolucion = " + txtid_documento.Text
                Else
                    criterio = "fecha>='" + EDATE(dtpdesde.Text) + "' and fecha<='" + EDATE(dtphasta.Text) + "'"
                    If Val(txtid_cliente.Text) > 0 Then criterio = criterio + " and id_cliente=" + txtid_cliente.Text
                End If
                Dim devolucion As DataTable
                devolucion = DEVM(criterio, True, "")
                Documento_cargar(devolucion, 7)
            Case 3
                If Val(txtid_documento.Text) > 0 Then
                    criterio = "nota_credito.id_nota_credito = " + txtid_documento.Text
                Else
                    criterio = "fecha>='" + EDATE(dtpdesde.Text) + "' and fecha<='" + EDATE(dtphasta.Text) + "'"
                    If Val(txtid_cliente.Text) > 0 Then criterio = criterio + " and id_cliente=" + txtid_cliente.Text
                End If
                Dim NC As DataTable
                NC = NCM(criterio, True, "")
                Documento_cargar(NC, 9)
            Case 4
                If Val(txtid_documento.Text) > 0 Then
                    criterio = "nota_debito.id_nota_Debito = " + txtid_documento.Text
                Else
                    criterio = "fecha>='" + EDATE(dtpdesde.Text) + "' and fecha<='" + EDATE(dtphasta.Text) + " 11:59:00 pm'"
                    If Val(txtid_cliente.Text) > 0 Then criterio = criterio + " and id_cliente=" + txtid_cliente.Text
                End If
                Dim NC As DataTable
                NC = NDM(criterio, True, "")
                Documento_cargar(NC, 10)
        End Select
        Dvdocumento = New DataView(Documento)
        Dvdocumento.Sort = "fecha, id_documento"
        dtgdocumento.DataSource = Dvdocumento
        'Catch myerror As Exception
        '(Me.Name, myerror)
        ' End Try
    End Sub

   
    Private Sub txtid_cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid_cliente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            If Val(txtid_cliente.Text) = 0 Then
                Me.Close()
            Else
                Identifica_cliente()
            End If
        Else
            If Not IsNumeric(Convert.ToChar(e.KeyChar)) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
                BUSQUEDA = "Consulta_Documento"
                Dim cliente_buscar As New frm_cliente_buscar
                cliente_buscar.Owner = Me
                cliente_buscar.Show()
                cliente_buscar.txtbuscar_cliente.Text = e.KeyChar
            Else

                e.Handled = Numerico(Asc(e.KeyChar), txtid_cliente.Text, False)
            End If
        End If
    End Sub

    Private Sub txtid_cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_cliente.TextChanged

    End Sub

    Public Sub Identifica_cliente()
        Try
            cliente = Table("select * from cliente where id_cliente=" + txtid_cliente.Text, "")
            If cliente.Rows.Count = 0 Then
                MessageBox.Show("Cliente no Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SendKeys.Send("{home}+{end}")
                Exit Sub
            End If
            rowc = cliente.Rows(0)
            lblnombre_cliente.Text = rowc("nombre")
            Filtro()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try

    End Sub

    Private Sub dtgdocumento_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgdocumento.Click
        Muestra_Documento()
    End Sub

    Private Sub Muestra_Documento()
        'Try
        If Documento.Rows.Count = 0 Then
            MessageBox.Show("Nada que Consultar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Consulta = True

        Dim id_documento As String = dtgdocumento.Item("id_documento", dtgdocumento.CurrentRow.Index).Value.ToString
        Dim anulado As Boolean = dtgdocumento.Item("anulado", dtgdocumento.CurrentRow.Index).Value
        Select Case cbtipo.SelectedIndex
            Case 0
                Dim F As DataTable
                Dim FD As DataTable
                Dim rowf As DataRow
                F = Table("select * from factura where id_factura=" + id_documento, "")
                rowf = F.Rows(0)
                FD = Table("select  id_producto,cantidad,costo,precio,descuento,iv from factura_detalle where id_factura=" + id_documento, "")
                Dim Pedido As New frm_pedido
                With Pedido
                    .txtid_cliente.Text = rowf("id_cliente")
                    cliente = Table("select * from cliente where id_cliente=" + rowf("id_cliente").ToString, "")
                    .rowc = cliente.Rows(0)
                    .lblcliente_nombre.Text = .rowc("nombre_comercial")
                    .txtplazo.Text = rowf("plazo").ToString
                    .txttransporte.Text = rowf("transporte")
                    .txt_orden.Text = rowf("orden")
                    .txt_observaciones.text = rowf("observaciones")

                    CB_crear(.cbid_agente, "Agente", "id_agente")
                    .cbid_agente.SelectedIndex = cb_buscar(.cbid_agente, rowf("id_agente"))
                    .PIV = rowf("piv")
                    FIV = rowf("piv")
                    .Fecha = FormatDateTime(rowf("fecha"), DateFormat.ShortDate)
                    TPD_Crear(FD)
                    .TPD = TPD
                    .dtgpedido.DataSource = .TPD


                    .Totales()
                    .FacturaID = rowf("id_factura").ToString
                    .pnencabezado.Enabled = False
                    .botones(False)
                    .btnguardar.Enabled = False
                    .btnimprimir.Visible = True
                    .chkoriginal.Visible = 1
                    .chkcopia.Visible = 1
                    .chkarchivo.Visible = 1
                    .txttransporte.Enabled = False
                    .txt_observaciones.Enabled = False

                    .Show()
                    .Identifica_cliente()
                    .txt_orden.Enabled = False
                End With

            Case 1
                Dim R As DataTable
                Dim RD As DataTable
                Dim rowr As DataRow
                R = Table("select * from recibo where id_recibo=" + id_documento, "")
                rowr = R.Rows(0)
                RD = Table("select id_factura as id_documento,abono as monto from recibo_detalle where id_recibo=" + id_documento, "")
                Dim recibo As New frm_recibo
                With recibo
                    .txtid_cliente.Text = rowr("id_cliente")
                    cliente = Table("select * from cliente where id_cliente=" + rowr("id_cliente").ToString, "")

                    .rowc = cliente.Rows(0)
                    .lblnombre_cliente.Text = .rowc("nombre_comercial")

                    .txtreferencia.Text = rowr("referencia")
                    .cbforma_pago.SelectedIndex = rowr("forma_pago") - 1
                    .ANTERIOR = rowr("anterior")
                    .txtmotivo.text = rowr("motivo")
                    .txtmotivo.enabled = False

                    .Documento = RD
                    .dtgdocumento.DataSource = .Documento
                    .Totales()
                    .ReciboID = rowr("id_recibo").ToString
                    .txtnumero.Text = rowr("id_recibo").ToString
                    .Fecha = FormatDateTime(rowr("fecha"), DateFormat.ShortDate)
                    .btnimprimir.Visible = True
                    .Panel1.Enabled = False
                    .btnagregar.Enabled = False
                    .btneliminar.Enabled = False
                    .btnguardar.Enabled = False
                    .Show()
                End With

            Case 2
                Dim Dev As DataTable
                Dim DEvD As DataTable
                Dim Fac As DataTable
                Dim rowf As DataRow
                Dim rowd As DataRow
                Dev = Table("select * from devolucion where id_devolucion=" + id_documento, "")
                rowd = Dev.Rows(0)
                DEvD = Table("select  * from devolucion_detalle where id_devolucion=" + id_documento, "")
                Fac = FACM("factura.id_factura=" + rowd("id_factura").ToString, True, "")
                rowf = Fac.Rows(0)
                Dim devolucion As New frm_devolucion
                With devolucion


                    cliente = Table("select * from cliente where id_cliente=" + rowd("id_cliente").ToString, "")
                    .rowc = cliente.Rows(0)
                    .txtid_factura.Text = rowd("id_factura").ToString
                    .lblid_cliente.Text = rowd("id_cliente").ToString + " - " + rowc("nombre_comercial")
                    .lblplazo.Text = rowf("plazo").ToString
                    .lblfecha.Text = rowf("fecha")
                    .lblmonto.Text = FormatNumber(rowf("monto").ToString, 2)


                    TDD_crear(DEvD, rowd("id_factura"))

                    .devolucion = TDD
                    .dtgdevolucion.DataSource = .devolucion
                    .PIV = Fac.Rows(0).Item("piv")
                    .Totales()
                    '
                    .DevolucionID = id_documento
                    .Fecha = FormatDateTime(rowd("fecha"), DateFormat.ShortDate)

                    .pnencabezado.Enabled = False
                    .btnimprimir.Visible = True
                    .Show()
                End With


            Case 3
                Dim NC As DataTable
                Dim monto As Decimal
                NC = Table("select * from nota_credito where id_nota_credito=" + id_documento, "")
                Dim frmNC As New frm_Nota_Credito
                With frmNC
                    cliente = Table("select * from cliente where id_cliente=" + NC.Rows(0).Item("id_cliente").ToString, "")
                    .Cliente = cliente
                    .txtid_cliente.Text = NC.Rows(0).Item("id_cliente")
                    .lblid_cliente.Text = cliente.Rows(0).Item("nombre_comercial")
                    .txtexento.Text = FormatNumber(NC.Rows(0).Item("exento"), 2)
                    .txtgravado.Text = FormatNumber(NC.Rows(0).Item("gravado"), 2)
                    .txtiv.Text = FormatNumber(NC.Rows(0).Item("piv") * 100, 2)
                    monto = NC.Rows(0).Item("exento") + NC.Rows(0).Item("gravado") + NC.Rows(0).Item("gravado") * NC.Rows(0).Item("piv")
                    .lblmonto.Text = FormatNumber(monto, 2)


                    .NCID = id_documento
                    .Fecha = FormatDateTime(NC.Rows(0).Item("fecha"), DateFormat.ShortDate)
                    .btnimprimir.Visible = True
                    .chkoriginal.Visible = True
                    .chkcopia.Visible = True

                    .btnaceptar.Enabled = False
                    .btncancelar.Enabled = False
                    .Panel.Enabled = False
                    .Show()

                End With

            Case 4
                Dim NC As DataTable
                Dim NDA As DataTable
                Dim monto As Decimal
                If CONN1.State = ConnectionState.Closed Then CONN1.Open()
                NC = Table("select * from nota_debito where id_nota_debito=" + id_documento, "")
                NDA = Table("select * from nota_Debito_detalle where id_nota_debito = " & NC.Rows(0).Item(0), "")
                Dim frmNC As New frm_Nota_Debito
                With frmNC
                    .consulta = True
                    .txtid_factura.Text = NDA.Rows(0).Item("id_factura")
                    .Identifica_Factura()
                    monto = NDA.Rows(0).Item("monto")
                    .txtnumero.Text = NC.Rows(0).Item("id_documento")
                    .txtmonto.ReadOnly = True
                    .txtnumero.ReadOnly = True
                    .txtid_factura.ReadOnly = True
                    .txtobservaciones.ReadOnly = True
                    .txtmonto.Text = FormatNumber(monto, 2)
                    .txtobservaciones.Text = NC.Rows(0).Item("observaciones")
                    .NDID = NC.Rows(0).Item("id_nota_Debito")
                    .Fecha = FormatDateTime(NC.Rows(0).Item("fecha"), DateFormat.ShortDate)
                    .btnimprimir.Visible = True
                    .chkoriginal.Visible = True
                    .chkcopia.Visible = True

                    .btnaceptar.Enabled = False
                    .btncancelar.Enabled = False
                    .Show()

                End With


        End Select
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        ' End Try
    End Sub
    Private Sub Documento_crear()

        Documento = New DataTable("documento")
        Dim id_documento As DataColumn = New DataColumn("id_documento")
        id_documento.DataType = System.Type.GetType("System.Int32")
        Documento.Columns.Add(id_documento)

        Dim fecha As DataColumn = New DataColumn("fecha")
        fecha.DataType = System.Type.GetType("System.DateTime")
        Documento.Columns.Add(fecha)

        Dim cliente As DataColumn = New DataColumn("cliente")
        cliente.DataType = System.Type.GetType("System.String")
        Documento.Columns.Add(cliente)

        Dim Monto As DataColumn = New DataColumn("Monto")
        Monto.DataType = System.Type.GetType("System.Decimal")
        Documento.Columns.Add(Monto)

        Dim anulado As DataColumn = New DataColumn("anulado")
        anulado.DataType = System.Type.GetType("System.Decimal")
        Documento.Columns.Add(anulado)

    End Sub

    Private Sub Documento_cargar(ByVal Tbl As DataTable, ByVal Tipo As Integer)
        '     Try
        Dim rowd As DataRow
        Documento.Rows.Clear()
        Dim z As Integer
        For z = 0 To Tbl.Rows.Count - 1
            With Tbl.Rows(z)
                cliente = Table("select * from cliente where id_cliente=" + .Item("id_cliente").ToString, "")
                rowc = cliente.Rows(0)
                rowd = Documento.NewRow

                Select Case Tipo
                    Case 1
                        rowd("id_documento") = .Item("id_factura")
                    Case 3
                        rowd("id_documento") = .Item("id_recibo")
                    Case "7"
                        rowd("id_documento") = .Item("id_devolucion")
                    Case 9
                        rowd("id_documento") = .Item("id_nota_credito")
                    Case 10
                        rowd("id_documento") = .Item("id_nota_debito")
                End Select


                rowd("fecha") = .Item("fecha")
                rowd("cliente") = rowc("id_cliente").ToString + "-" + rowc("nombre_comercial")
                rowd("monto") = .Item("monto")
                rowd("anulado") = .Item("anulado")
                Documento.Rows.Add(rowd)
            End With
        Next
        'Catch myerror As Exception
        ' ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub TPD_Crear(ByVal FD As DataTable)

        'Try


        TPD = New DataTable("TPD")
        Dim id_producto As DataColumn = New DataColumn("id_producto")
        id_producto.DataType = System.Type.GetType("System.String")
        TPD.Columns.Add(id_producto)

        Dim nombre As DataColumn = New DataColumn("nombre")
        nombre.DataType = System.Type.GetType("System.String")
        TPD.Columns.Add(nombre)

        Dim cantidad As DataColumn = New DataColumn("cantidad")
        cantidad.DataType = System.Type.GetType("System.Int32")
        TPD.Columns.Add(cantidad)

        Dim presentacion As DataColumn = New DataColumn("presentacion")
        presentacion.DataType = System.Type.GetType("System.String")
        TPD.Columns.Add(presentacion)

        Dim costo As DataColumn = New DataColumn("costo")
        costo.DataType = System.Type.GetType("System.Decimal")
        TPD.Columns.Add(costo)


        Dim precio As DataColumn = New DataColumn("precio")
        precio.DataType = System.Type.GetType("System.Decimal")
        TPD.Columns.Add(precio)

        Dim descuento As DataColumn = New DataColumn("descuento")
        descuento.DataType = System.Type.GetType("System.Decimal")
        descuento.DefaultValue = 0
        TPD.Columns.Add(descuento)

        Dim iv As DataColumn = New DataColumn("iv")
        iv.DataType = System.Type.GetType("System.Boolean")
        TPD.Columns.Add(iv)

        Dim barras As DataColumn = New DataColumn("barcode")
        barras.DataType = System.Type.GetType("System.String")
        barras.DefaultValue = ""
        TPD.Columns.Add(barras)


        Dim Monto As DataColumn = New DataColumn("Monto")
        Monto.DataType = System.Type.GetType("System.Decimal")
        Monto.Expression = "cantidad * precio"
        TPD.Columns.Add(Monto)

        Dim Producto As DataTable

        Dim rowp As DataRow
        Dim rowtpd As DataRow
        Dim z As Integer
        For z = 0 To FD.Rows.Count - 1
            With FD.Rows(z)
                rowtpd = TPD.NewRow
                Producto = Table("select * from producto where id_producto=" + .Item("id_producto").ToString, "")
                rowp = Producto.Rows(0)
                rowtpd("id_producto") = .Item("id_producto")
                rowtpd("cantidad") = .Item("cantidad")
                rowtpd("costo") = .Item("costo")
                rowtpd("precio") = .Item("precio")
                rowtpd("Nombre") = rowp("nombre")
                rowtpd("descuento") = .Item("descuento") * 100
                rowtpd("barcode") = rowp.Item("barcode")
                rowtpd("iv") = .Item("iv")
                TPD.Rows.Add(rowtpd)

                rowtpd("presentacion") = Prst(rowp("Presentacion"))

                rowtpd("nombre") = rowp("nombre")

            End With
        Next
        'Catch myerror As Exception
        ' ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub TDD_crear(ByVal DD As DataTable, ByVal factura_id As Integer)
        'try
        TDD = New DataTable("dd")
        Dim id_producto As DataColumn = New DataColumn("id_producto")
        id_producto.DataType = System.Type.GetType("System.String")
        tdd.Columns.Add(id_producto)

        Dim nombre As DataColumn = New DataColumn("nombre")
        nombre.DataType = System.Type.GetType("System.String")
        tdd.Columns.Add(nombre)

        Dim cantidad As DataColumn = New DataColumn("cantidad")
        cantidad.DataType = System.Type.GetType("System.Int32")
        tdd.Columns.Add(cantidad)

        Dim presentacion As DataColumn = New DataColumn("presentacion")
        presentacion.DataType = System.Type.GetType("System.String")
        tdd.Columns.Add(presentacion)

        Dim costo As DataColumn = New DataColumn("costo")
        costo.DataType = System.Type.GetType("System.Decimal")
        tdd.Columns.Add(costo)

        Dim precio As DataColumn = New DataColumn("precio")
        precio.DataType = System.Type.GetType("System.Decimal")
        TDD.Columns.Add(precio)

        Dim descuento As DataColumn = New DataColumn("descuento")
        descuento.DataType = System.Type.GetType("System.Decimal")
        descuento.DefaultValue = 0
        tdd.Columns.Add(descuento)



        Dim iv As DataColumn = New DataColumn("iv")
        iv.DataType = System.Type.GetType("System.Boolean")
        TDD.Columns.Add(iv)


        Dim Monto As DataColumn = New DataColumn("Monto")
        Monto.DataType = System.Type.GetType("System.Decimal")
        Monto.Expression = "cantidad * precio"
        TDD.Columns.Add(Monto)

        Dim Producto As DataTable
        Dim FD As DataTable
        FD = Table("select * from factura_detalle where id_factura=" + factura_id.ToString + "order by id_producto", "id_producto")

        Dim rowp As DataRow
        Dim rowdd As DataRow
        Dim rowfd As DataRow

        Dim z As Integer
        For z = 0 To DD.Rows.Count - 1
            With DD.Rows(z)
                rowdd = TDD.NewRow
                Producto = Table("select * from producto where id_producto=" + .Item("id_producto").ToString, "")
                rowp = Producto.Rows(0)
                rowfd = FD.Rows.Find(.Item("id_producto"))
                rowdd("id_producto") = .Item("id_producto")
                rowdd("cantidad") = .Item("cantidad")
                rowdd("Presentacion") = rowp("presentacion")
                rowdd("Nombre") = rowp("nombre")
                rowdd("costo") = rowfd("costo")
                rowdd("precio") = rowfd("precio")
                rowdd("descuento") = rowfd("descuento") * 100
                rowdd("iv") = rowfd("iv")
                TDD.Rows.Add(rowdd)
            End With
        Next
        'Catch myerror As Exception
        ' ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub txtid_documento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid_documento.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            Filtro()
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtid_documento.Text, False)
        End If
    End Sub

    Private Sub txtid_documento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_documento.TextChanged

    End Sub

    Private Sub dtpdesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpdesde.ValueChanged
        If Not Building Then Filtro()
    End Sub

    Private Sub dtphasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtphasta.ValueChanged
        If Not Building Then Filtro()
    End Sub

    Private Sub cbtipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbtipo.SelectedIndexChanged
        If Not Building Then Filtro()
    End Sub

End Class