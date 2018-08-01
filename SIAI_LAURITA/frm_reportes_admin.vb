Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_reportes_admin
    Dim S As String
    Dim rowc As DataRow
    Dim Criterio As String
    Dim Criterionc As String
    Public ds As New DataSet
    Dim bodega As DataTable
    Dim V_LPD As DataTable
    Dim V_venta_neta As DataTable
    Dim V_Bodega_Existencia As DataTable

    Dim rParameterDiscreteValue As ParameterDiscreteValue
    Dim rParameterFieldDefinitions As ParameterFieldDefinitions
    Dim rParameterFieldLocation As ParameterFieldDefinition
    Dim rParameterValues As ParameterValues


    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        'Try
        btnaceptar.Enabled = False
        Select Case S
            Case "rbagente"
                Dim agente As DataTable
                Dim ragente As New rpt_agente
                agente = Table("select * from agente where eliminado=0 order by nombre", "")
                ragente.SetDataSource(agente)

                rParameterFieldDefinitions = ragente.DataDefinition.ParameterFields

                rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = NEGOCIO
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


                Dim rv As New frm_Report_Viewer
                rv.crv.ReportSource = ragente
                rv.Text = "Agentes"
                rv.Show()
            Case "rbcliente"
                Dim cliente As DataTable
                Dim rcliente As New rpt_cliente
                cliente = Table("select * from cliente where eliminado=0 order by nombre_comercial", "")
                rcliente.SetDataSource(cliente)

                rParameterFieldDefinitions = rcliente.DataDefinition.ParameterFields

                rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = NEGOCIO
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

                Dim rv As New frm_Report_Viewer
                rv.crv.ReportSource = rcliente
                rv.Text = "Clientes"
                rv.Show()
            Case "rbproveedor"
                Dim proveedor As DataTable
                Dim rproveedor As New rpt_proveedor
                proveedor = Table("select * from proveedor where eliminado=0 order by nombre", "")
                rproveedor.SetDataSource(proveedor)

                rParameterFieldDefinitions = rproveedor.DataDefinition.ParameterFields

                rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = NEGOCIO
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


                Dim rv As New frm_Report_Viewer
                rv.crv.ReportSource = rproveedor
                rv.Text = "Proveedores"
                rv.Show()
            Case "rbproducto"
                Dim Producto As DataTable
                Dim rProducto As New rpt_producto
                Dim Familia_Id As Integer = IIf(IsNumeric(cbid_familia.Text.Substring(1, 1)), cbid_familia.Text.Substring(0, 2), cbid_familia.Text.Substring(0, 1))
                Dim precio_id As String = IIf(cbprecio.SelectedIndex = 0, "precio1", "precio2")

                Producto = Table("select id_producto,barcode,nombre,presentacion,costo," & precio_id & " as precio,id_proveedor,Iv,Id_familia,observaciones,eliminado from Producto where eliminado=0 and id_familia=" + Familia_Id.ToString + " order by nombre", "")


                'Dim presentacion_nombre As DataColumn = New DataColumn("presentacion_nombre")
                'presentacion_nombre.DataType = System.Type.GetType("System.String")
                'Producto.Columns.Add(presentacion_nombre)



                'Dim z As Integer
                'For z = 0 To Producto.Rows.Count - 1
                'With Producto.Rows(z)
                '.Item("presentacion_nombre") = Prst(.Item("Presentacion"))
                'End With
                'Next

                rProducto.SetDataSource(Producto)

                rParameterFieldDefinitions = rProducto.DataDefinition.ParameterFields

                rParameterFieldLocation = rParameterFieldDefinitions.Item("id_familia")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = "Familia " + cbid_familia.Text
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



                rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = NEGOCIO
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



                Dim rv As New frm_Report_Viewer
                rv.crv.ReportSource = rProducto
                rv.Text = "Productos"
                rv.Show()


                'Case "rbinventario"
                '    Dim Producto As DataTable
                '    Dim rinventario As New rpt_inventario

                '    Dim sql As String = "select producto.id_producto,producto.nombre,producto.costo,producto.existencia,producto.id_familia,familia.nombre as familia_nombre " + _
                '    "from producto inner join familia on familia.id_familia=producto.id_familia and producto.eliminado=0 " + IIf(cbinv_id_familia.SelectedIndex > 0, " and producto.id_familia=" + cbid(cbinv_id_familia.Text), "") + _
                '    " order by producto.nombre"


                '    Producto = Table(sql, "")


                '    'Dim presentacion_nombre As DataColumn = New DataColumn("presentacion_nombre")
                '    'presentacion_nombre.DataType = System.Type.GetType("System.String")
                '    'Producto.Columns.Add(presentacion_nombre)

                '    'Dim z As Integer
                '    'For z = 0 To Producto.Rows.Count - 1
                '    'With Producto.Rows(z)
                '    '.Item("presentacion_nombre") = Prst(.Item("Presentacion"))
                '    'End With
                '    'Next

                '    rinventario.SetDataSource(Producto)

                '    rParameterFieldDefinitions = rinventario.DataDefinition.ParameterFields

                '    rParameterFieldLocation = rParameterFieldDefinitions.Item("id_familia")
                '    rParameterValues = rParameterFieldLocation.CurrentValues
                '    rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                '    rParameterDiscreteValue.Value = "Familia " + cbinv_id_familia.Text
                '    rParameterValues.Add(rParameterDiscreteValue)
                '    rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



                '    rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
                '    rParameterValues = rParameterFieldLocation.CurrentValues
                '    rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                '    rParameterDiscreteValue.Value = NEGOCIO
                '    rParameterValues.Add(rParameterDiscreteValue)
                '    rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



                '    Dim rv As New frm_Report_Viewer
                '    rv.crv.ReportSource = rinventario
                '    rv.Text = "Inventario"
                '    rv.Show()

            Case "rbfactura"
                Dim factura As DataTable
                Dim rfactura As New rpt_facturas
                Criterio = "factura.fecha>='" + EDATE(dtpdesde.Text) + "' and factura.fecha<='" + EDATE(dtphasta.Text) + "'"
                factura = FACM(Criterio, True, "")

                Dim nombre_sociedad As DataColumn = New DataColumn("nombre_sociedad")
                nombre_sociedad.DataType = System.Type.GetType("System.String")
                factura.Columns.Add(nombre_sociedad)
                Dim cliente As DataTable
                Dim z As Integer
                Dim rowc As DataRow

                For z = 0 To factura.Rows.Count - 1
                    With factura.Rows(z)

                        cliente = Table("select * from cliente where id_cliente=" + .Item("id_cliente").ToString, "")
                        rowc = cliente.Rows(0)
                        .Item("nombre_sociedad") = rowc("nombre_sociedad")
                    End With
                Next

                rfactura.SetDataSource(factura)

                rParameterFieldDefinitions = rfactura.DataDefinition.ParameterFields

                rParameterFieldLocation = rParameterFieldDefinitions.Item("rango")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = "Del " + dtpdesde.Text + " al " + dtphasta.Text
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


                rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = NEGOCIO
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



                Dim rv As New frm_Report_Viewer
                rv.crv.ReportSource = rfactura
                rv.Text = "Facturas"
                rv.Show()

            Case "rbrecibo"
                Dim recibo As DataTable
                Dim rrecibo As New rpt_recibos
                Criterio = "recibo.fecha>='" + EDATE(dtpdesde.Text) + "' and recibo.fecha<='" + EDATE(dtphasta.Text) + "'"
                recibo = RECM(Criterio, True, "")





                rrecibo.SetDataSource(recibo)

                rParameterFieldDefinitions = rrecibo.DataDefinition.ParameterFields

                rParameterFieldLocation = rParameterFieldDefinitions.Item("rango")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = "Del " + dtpdesde.Text + " al " + dtphasta.Text
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


                rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = NEGOCIO
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



                Dim rv As New frm_Report_Viewer
                rv.crv.ReportSource = rrecibo
                rv.Text = "Recibos"
                rv.Show()


            Case "rbnc"
                Dim rnc As New rpt_notas_credito
                Criterio = " nota_credito.fecha>='" + EDATE(dtpdesde.Text) + "' and nota_credito.fecha<='" + EDATE(dtphasta.Text) + "'"
                Dim nc As DataTable = NCM(Criterio, True, "")

                rnc.SetDataSource(nc)

                rParameterFieldDefinitions = rnc.DataDefinition.ParameterFields

                rParameterFieldLocation = rParameterFieldDefinitions.Item("rango")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = "Del " + dtpdesde.Text + " al " + dtphasta.Text
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



                rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = NEGOCIO
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



                Dim rv As New frm_Report_Viewer
                rv.crv.ReportSource = rnc
                rv.Text = "Notas de Crédito"
                rv.Show()

            Case "rbnd"
                Dim rnc As New rpt_notas_debito
                Criterio = " fecha>='" + EDATE(dtpdesde.Text) + "' and fecha<='" + EDATE(dtphasta.Text) + " 11:59:00 pm'"
                Dim nc As DataTable = NDM(Criterio, True, "")

                rnc.SetDataSource(nc)

                rParameterFieldDefinitions = rnc.DataDefinition.ParameterFields

                rParameterFieldLocation = rParameterFieldDefinitions.Item("rango")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = "Del " + dtpdesde.Text + " al " + dtphasta.Text
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



                rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = NEGOCIO
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



                Dim rv As New frm_Report_Viewer
                rv.crv.ReportSource = rnc
                rv.Text = "Notas de Débito"
                rv.Show()



            Case "rbnca"
                Dim rnca As New rpt_nota_credito_aplicaciones
                Criterio = " fecha>='" + EDATE(dtpdesde.Text) + "' and fecha<='" + EDATE(dtphasta.Text) + "'"
                Dim nc As DataTable = Table("select * from nota_credito_detalle where " + Criterio, "")

                rnca.SetDataSource(nc)

                rParameterFieldDefinitions = rnca.DataDefinition.ParameterFields

                rParameterFieldLocation = rParameterFieldDefinitions.Item("rango")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = "Del " + dtpdesde.Text + " al " + dtphasta.Text
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



                rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = NEGOCIO
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



                Dim rv As New frm_Report_Viewer
                rv.crv.ReportSource = rnca
                rv.Text = "Notas de Crédito Aplicaciones"
                rv.Show()


            Case "rbbodega_ajuste"
                Dim rbodega_ajuste As New rpt_bodega_ajuste
                Dim Prd As DataTable
                Criterio = "where fecha>='" + EDATE(dtpdesde.Text) + "' and fecha<='" + EDATE(dtphasta.Text) + "'"
                Dim V_Bodega_ajuste As DataTable
                V_Bodega_ajuste = Table("select * from Bodega_Ajuste " + Criterio + " order by fecha,id_producto", "")

                Dim Nombre As DataColumn = New DataColumn("Nombre")
                Nombre.DataType = System.Type.GetType("System.String")
                V_Bodega_ajuste.Columns.Add(Nombre)

                Dim presentacion As DataColumn = New DataColumn("presentacion")
                presentacion.DataType = System.Type.GetType("System.String")
                V_Bodega_ajuste.Columns.Add(presentacion)

                Dim z As Integer
                For z = 0 To V_Bodega_ajuste.Rows.Count - 1
                    With V_Bodega_ajuste.Rows(z)
                        Prd = Table("select * from producto where id_producto=" + .Item("id_producto").ToString, "")

                        .Item("nombre") = Prd.Rows(0).Item("nombre")
                        .Item("presentacion") = Prst(Prd.Rows(0).Item("presentacion"))
                    End With
                Next
                rbodega_ajuste.SetDataSource(V_Bodega_ajuste)

                rParameterFieldDefinitions = rbodega_ajuste.DataDefinition.ParameterFields

                rParameterFieldLocation = rParameterFieldDefinitions.Item("rango")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = "Del " + dtpdesde.Text + " al " + dtphasta.Text
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


                rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = NEGOCIO
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


                Dim rv As New frm_Report_Viewer
                rv.crv.ReportSource = rbodega_ajuste
                rv.Text = "Bodega Ajustes"
                rv.Show()


            Case "rbventa_neta"
                If txtvnid_cliente.Text <> "" And chkventa.Checked <> True Then
                    Dim cliente As DataTable
                    cliente = Table("select * from cliente where id_cliente=" + txtvnid_cliente.Text, "")
                    If cliente.Rows.Count = 0 Then
                        MessageBox.Show("Cliente no Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        SendKeys.Send("{home}+{end}")
                        Exit Sub
                    End If
                End If
                Dim Fecha As String = ""
                Dim ClienteId As String

                If txtvnid_cliente.Text = "" Then
                    Criterio = "fecha>='" + EDATE(dtpdesde.Text) + "' and fecha<='" + EDATE(dtphasta.Text) + "'"
                    Criterionc = "fecha>='" + EDATE(dtpdesde.Text) + "' and fecha<='" + EDATE(dtphasta.Text) + "'"
                Else
                    ClienteId = rowc("id_cliente").ToString + " - " + rowc("nombre_sociedad")
                    If rowc("id_grupo") > 1 And chkventa.Checked Then
                        Dim c As DataTable = Table("select id_cliente from cliente where id_grupo=" + rowc("id_grupo").ToString, "")
                        Dim i As Integer
                        For i = 0 To c.Rows.Count - 1
                            With c.Rows(i)
                                If i = 0 Then
                                    Criterio = "(factura.id_cliente=" + .Item("id_cliente").ToString
                                    Criterionc = "(nota_credito.id_cliente=" + .Item("id_cliente").ToString
                                Else
                                    Criterio = Criterio + " or factura.id_cliente=" + .Item("id_cliente").ToString
                                    Criterionc = Criterionc + " or nota_credito.id_cliente=" + .Item("id_cliente").ToString
                                End If
                            End With
                        Next
                    Else
                        Criterio = "(factura.id_cliente=" + rowc("id_cliente").ToString
                        Criterionc = "(nota_credito.id_cliente=" + rowc("id_cliente").ToString
                    End If
                    Criterio = Criterio + ") and (fecha>='" + EDATE(dtpdesde.Text) + "' and fecha<='" + EDATE(dtphasta.Text) + "')"
                    Criterionc = Criterionc + ") and (fecha>='" + EDATE(dtpdesde.Text) + "' and fecha<='" + EDATE(dtphasta.Text) + "')"
                End If


                Dim rventa_neta As New rpt_venta_neta

                V_Venta_Neta_crear()
                rventa_neta.SetDataSource(V_venta_neta)

                rParameterFieldDefinitions = rventa_neta.DataDefinition.ParameterFields

                rParameterFieldLocation = rParameterFieldDefinitions.Item("rango")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = "Del " + dtpdesde.Text + " al " + dtphasta.Text
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

                rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = NEGOCIO
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)




                Dim rv As New frm_Report_Viewer
                rv.crv.ReportSource = rventa_neta
                rv.Text = "Ventas Netas"
                rv.Show()


            Case "rbdevolucion"
                Dim devolucion As DataTable
                Dim rdevolucion As New rpt_devoluciones
                Criterio = "fecha>='" + EDATE(dtpdesde.Text) + "' and fecha<='" + EDATE(dtphasta.Text) + "'"
                devolucion = DEVM(Criterio, True, "")


                rdevolucion.SetDataSource(devolucion)

                rParameterFieldDefinitions = rdevolucion.DataDefinition.ParameterFields

                rParameterFieldLocation = rParameterFieldDefinitions.Item("rango")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = "Del " + dtpdesde.Text + " al " + dtphasta.Text
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

                rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = NEGOCIO
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


                Dim rv As New frm_Report_Viewer
                rv.crv.ReportSource = rdevolucion
                rv.Text = "Devoluciones"
                rv.Show()

            Case "rb_facturas_cliente_periodo"
                Dim factura As DataTable
                Dim rfacturas_periodo As New rpt_facturas_periodos
                Dim criterioBusqueda As String = "factura.fecha>='" & EDATE(dtpdesde.Text) & "' " & _
                            "and factura.fecha<='" & EDATE(dtphasta.Text) & "' " & _
                            "and factura.id_cliente = " & txtfcp_idcliente.Text & " "

                factura = FACM(criterioBusqueda, False, "")
                Dim nombreCliente As String
                Dim tablaCliente As DataTable
                Try
                    tablaCliente = Table("select * from cliente where id_cliente=" + txtfcp_idcliente.Text, "")
                    nombreCliente = tablaCliente.Rows(0).Item("nombre_comercial").ToString

                    rfacturas_periodo.SetDataSource(factura)

                    rParameterFieldDefinitions = rfacturas_periodo.DataDefinition.ParameterFields

                    rParameterFieldLocation = rParameterFieldDefinitions.Item("rango")
                    rParameterValues = rParameterFieldLocation.CurrentValues
                    rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                    rParameterDiscreteValue.Value = "Del " + dtpdesde.Text + " al " + dtphasta.Text
                    rParameterValues.Add(rParameterDiscreteValue)
                    rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


                    rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
                    rParameterValues = rParameterFieldLocation.CurrentValues
                    rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                    rParameterDiscreteValue.Value = NEGOCIO
                    rParameterValues.Add(rParameterDiscreteValue)
                    rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

                    rParameterFieldLocation = rParameterFieldDefinitions.Item("ID")
                    rParameterValues = rParameterFieldLocation.CurrentValues
                    rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                    rParameterDiscreteValue.Value = txtfcp_idcliente.Text
                    rParameterValues.Add(rParameterDiscreteValue)
                    rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

                    rParameterFieldLocation = rParameterFieldDefinitions.Item("cliente")
                    rParameterValues = rParameterFieldLocation.CurrentValues
                    rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                    rParameterDiscreteValue.Value = nombreCliente
                    rParameterValues.Add(rParameterDiscreteValue)
                    rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

                    Dim rv As New frm_Report_Viewer
                    rv.crv.ReportSource = rfacturas_periodo
                    rv.Text = "Facturas X Periodos"
                    rv.Show()


                Catch ex As Exception
                    MessageBox.Show("No se encontro el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

                
        End Select
        btnaceptar.Enabled = True
        'Catch myerror As Exception
        ' ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub frm_reportes_admin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            CONN1.Close()
            myForms.frm_principal.ToolStrip.Enabled = True
        Catch myerror As SqlException
            MsgBox(myerror.Message)
        End Try
    End Sub

    Private Sub frm_reportes_admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CONN1.Open()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub rbcliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcliente.CheckedChanged
        If rbcliente.Checked Then S = "rbcliente"
        Ocultar()
    End Sub

    Private Sub rbproveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbproveedor.CheckedChanged
        If rbproveedor.Checked Then S = "rbproveedor"
        Ocultar()
    End Sub

    Private Sub rbagente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbagente.CheckedChanged
        If rbagente.Checked Then S = "rbagente"
        Ocultar()
    End Sub

    Private Sub rbfactura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbfactura.CheckedChanged

    End Sub
    Private Sub Ocultar()
        cbid_familia.Visible = False
        txtvnid_cliente.Visible = False
        lblvnid_cliente.Visible = False
        'cbinv_id_familia.Visible = False
        txtfcp_idcliente.Visible = False
        cbprecio.Visible = False
        lblfacxcli.Visible = False
    End Sub

    Public Sub vnIdentifica_cliente()
        ' Try

        Dim CLIENTE As DataTable = Table("select * from cliente where id_cliente=" + txtvnid_cliente.Text, "")
        If Cliente.Rows.Count = 0 Then
            MessageBox.Show("cliente no Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If
        rowc = Cliente.Rows(0)
        lblvncliente_nombre.Text = Cliente.Rows(0).Item("nombre_comercial")
        SendKeys.Send("{tab}")
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub




    Private Sub txtvnid_cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvnid_cliente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            vnIdentifica_cliente()
        Else
            If Not IsNumeric(Convert.ToChar(e.KeyChar)) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
                BUSQUEDA = "venta_neta"
                Dim cliente_buscar As New frm_cliente_buscar
                cliente_buscar.Owner = Me
                cliente_buscar.Show()
                cliente_buscar.txtbuscar_cliente.Text = e.KeyChar
            Else

                e.Handled = Numerico(Asc(e.KeyChar), txtvnid_cliente.Text, False)
            End If
        End If
    End Sub


    Private Sub txtvnid_cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtvnid_cliente.TextChanged

    End Sub




    Private Sub V_Venta_Neta_crear()
        '  Try
        V_venta_neta = Table("select  * from V_venta_neta", "")

        'Dim cliente As DataColumn = New DataColumn("nombre_cliente")
        'cliente.DataType = System.Type.GetType("System.String")
        'V_venta_neta.Columns.Add(cliente)

        Dim Fac As DataTable
        Fac = FACM(Criterio, False, "")
        Dim rowv As DataRow
        Dim z As Integer
        For z = 0 To Fac.Rows.Count - 1
            With Fac.Rows(z)
                rowv = V_venta_neta.NewRow
                rowv("id_documento") = .Item("id_factura")
                rowv("tipo") = 1
                rowv("fecha") = .Item("fecha")
                rowv("exento") = .Item("exento")
                rowv("gravado") = .Item("gravado")
                rowv("iv") = .Item("iv")
                rowv("monto") = .Item("monto")
                rowv("nombre_cliente") = .Item("nombre_comercial")
                V_venta_neta.Rows.Add(rowv)
            End With
        Next

        Dim nc As DataTable
        nc = NCM(Criterionc, False, "")
        Dim rownc As DataRow
        For z = 0 To nc.Rows.Count - 1
            With nc.Rows(z)
                rownc = V_venta_neta.NewRow
                rownc("tipo") = 5
                rownc("id_documento") = .Item("id_nota_credito")
                rownc("fecha") = .Item("fecha")
                rownc("exento") = .Item("exento") * -1
                rownc("gravado") = .Item("gravado") * -1
                rownc("iv") = .Item("iv") * -1
                rownc("monto") = .Item("monto") * -1
                rownc("nombre_cliente") = .Item("nombre_comercial")
                V_venta_neta.Rows.Add(rownc)
            End With
        Next

        'Catch myerror As Exception
        ' ONEX(Me.Name, myerror)
        'End Try

    End Sub


    Private Sub rbventaxproducto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbventaxproducto.Click
        Ocultar()
        If rbventaxproducto.Checked Then
            Dim rpt_venta_producto_opciones As New frm_rpt_venta_producto_opciones
            myForms.frm_rpt_venta_producto_opciones = frm_rpt_venta_producto_opciones
            myForms.frm_rpt_venta_producto_opciones.Owner = Me
            frm_rpt_venta_producto_opciones.Show()
        End If
    End Sub


    Private Sub rbventa_producto_cliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbventa_producto_cliente.Click
        Ocultar()
        If rbventa_producto_cliente.Checked Then
            btnaceptar.Enabled = False
            Dim rpt_venta_producto_cliente_opciones As New frm_rpt_venta_producto_cliente_opciones
            myForms.frm_rpt_venta_producto_cliente_opciones = frm_rpt_venta_producto_cliente_opciones
            myForms.frm_rpt_venta_producto_cliente_opciones.Owner = Me
            frm_rpt_venta_producto_cliente_opciones.Show()
        End If
    End Sub
    Private Sub rbnc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbnc.Click
        If rbnc.Checked Then S = "rbnc"
        Ocultar()
    End Sub



    Private Sub rbinventario_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'Try
        '    If rbinventario.Checked Then
        '        S = "rbinventario"
        '        Ocultar()
        '        cbinv_id_familia.Items.Clear()
        '        CB_crear(cbinv_id_familia, "familia", "id_familia")
        '        cbinv_id_familia.Items.Insert(0, "TODOS")
        '        cbinv_id_familia.Visible = True
        '    End If
        'Catch myerror As Exception
        '    ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub rbproducto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbproducto.Click
        Try
            If rbproducto.Checked Then
                S = "rbproducto"
                Ocultar()
                cbid_familia.Items.Clear()
                Dim fam As DataTable = Table("select * from familia  order by nombre", "")
                CB_crear(cbid_familia, "familia", "id_familia")
                cbid_familia.Visible = True
                cbprecio.Visible = True
                cbprecio.SelectedIndex = 0
            End If
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub rbfactura_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbfactura.Click
        If rbfactura.Checked Then
            S = "rbfactura"
            Ocultar()
        End If
    End Sub

    Private Sub rbrecibo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbrecibo.Click
        If rbrecibo.Checked Then S = "rbrecibo"
        Ocultar()
    End Sub

    Private Sub rbdevolucion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbdevolucion.Click
        If rbdevolucion.Checked Then S = "rbdevolucion"
        Ocultar()
    End Sub

    Private Sub rbbodega_ajuste_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbbodega_ajuste.Click
        If rbbodega_ajuste.Checked Then S = "rbbodega_ajuste"
        Ocultar()
    End Sub

    Private Sub lblvnid_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblvnid_cliente.Click

    End Sub

    Private Sub rbventa_neta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbventa_neta.Click
        If rbventa_neta.Checked Then
            S = "rbventa_neta"
            Ocultar()
            lblvnid_cliente.Visible = True
            txtvnid_cliente.Visible = True
            chkventa.Visible = True
            txtvnid_cliente.Focus()
        End If
    End Sub

    Private Sub rbcomision_Generada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcomisiones.CheckedChanged

    End Sub

    Private Sub rbcomisiones_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbcomisiones.Click
        Ocultar()
        If rbcomisiones.Checked Then
            Dim comisiones As New frm_rpt_comision_opciones
            comisiones.Owner = Me
            comisiones.Show()
        End If
    End Sub

    Private Sub rbcompras_producto_proveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbcompras_producto_proveedor.CheckedChanged

    End Sub

    Private Sub rbcompras_producto_proveedor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbcompras_producto_proveedor.Click
        Ocultar()
        If rbcompras_producto_proveedor.Checked Then
            btnaceptar.Enabled = False
            Dim rpt_compra_producto_proveedor As New frm_rpt_compra_producto_proveedor
            myForms.frm_rpt_compra_producto_proveedor = frm_rpt_compra_producto_proveedor
            myForms.frm_rpt_compra_producto_proveedor.Owner = Me
            frm_rpt_compra_producto_proveedor.Show()
        End If
    End Sub

    Private Sub rbnca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnca.CheckedChanged

    End Sub

    Private Sub rbnca_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbnca.Click
        If rbnca.Checked Then S = "rbnca"
        Ocultar()
    End Sub

    Private Sub rbbodega_existencias_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbbodega_existencias.Click
        Dim rpt_bode As frm_rpt_bodega_existencia_opciones = New frm_rpt_bodega_existencia_opciones
        myForms.frm_rpt_producto_existencias = rpt_bode
        rpt_bode.Show()
        Me.Enabled = False
        Ocultar()
    End Sub

    Private Sub rbnotas_debito_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        S = "rbnd"
        Ocultar()
    End Sub

    Private Sub txtfcp_idcliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfcp_idcliente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            fcpIdentifica_cliente()
        Else
            If Not IsNumeric(Convert.ToChar(e.KeyChar)) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
                BUSQUEDA = "facturas_cliente"
                Dim cliente_buscar As New frm_cliente_buscar
                cliente_buscar.Owner = Me
                cliente_buscar.Show()
                cliente_buscar.txtbuscar_cliente.Text = e.KeyChar
            Else

                e.Handled = Numerico(Asc(e.KeyChar), txtvnid_cliente.Text, False)
            End If
        End If
    End Sub

    Public Sub fcpIdentifica_cliente()
        ' Try

        Dim CLIENTE As DataTable = Table("select * from cliente where id_cliente=" + txtfcp_idcliente.Text, "")
        If CLIENTE.Rows.Count = 0 Then
            MessageBox.Show("cliente no Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If
        rowc = CLIENTE.Rows(0)
        lblfacxcli.Text = CLIENTE.Rows(0).Item("nombre_comercial")
        SendKeys.Send("{tab}")
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub rbFacturas_Cliente_Periodo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbFacturas_Cliente_Periodo.CheckedChanged
        If rbFacturas_Cliente_periodo.Checked Then S = "rb_facturas_cliente_periodo"
        Ocultar()
        txtfcp_idcliente.Visible = True
        lblfacxcli.Visible = True
    End Sub
End Class