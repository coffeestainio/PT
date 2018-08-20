Imports System.Data.sqlclient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.MATH
Public Class frm_pedido
    Inherits System.Windows.Forms.Form

    Const LN As Integer = 21

    Dim rParameterDiscreteValue As ParameterDiscreteValue
    Dim rParameterFieldDefinitions As ParameterFieldDefinitions
    Dim rParameterFieldLocation As ParameterFieldDefinition
    Dim rParameterValues As ParameterValues

    Public TPD As DataTable
    Dim V_Factura As DataTable
    Public Producto As DataTable
    Dim Pedido As DataTable
    Public cliente As DataTable
    Dim Agente As DataTable
    Public rowc As DataRow
    Private ORDEN As Integer


    Dim FS(0) As String

    Dim P(3) As String
    Dim Frm(3) As String


    Dim cliente_ID As String

    Public tGravado As Decimal
    Public tExento As Decimal
    Public tGd As Decimal
    Public tEd As Decimal
    Public tdescuento As Decimal
    Public tiv As Decimal
    Public total As Decimal
    Public Cargandopedidos As Boolean
    Public orden_ruta As String
    Dim Alistar As String
    Public Fecha As String
    Public FacturaID As String
    Public PedidoID As String
    Public PIV As Decimal
    Dim M1 As String
    Dim M2 As String
    Dim M3 As String



    Private Sub frm_pedido_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Consulta Then
            myForms.frm_principal.ToolStrip.Enabled = True
            CONN1.Close()
        End If
    End Sub

    Private Sub frm_pedido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub


    Private Sub frm_pedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Try
        If Not Consulta Then
            CONN1.Open()
            TPD_crear()
            CB_crear(cbid_agente, "Agente", "id_Agente")

            Dim Ptro As DataTable
            Ptro = Table("select * from parametro", "")
            With Ptro.Rows(0)
                PIV = .Item("iv")
                M1 = .Item("m1")
                M2 = .Item("m2")
                M3 = .Item("m3")
            End With

            P(1) = "und"
            P(2) = "cjs"
            P(3) = "doc"
        End If
        Frm(1) = "ORIGINAL -  CLIENTE"
        Frm(2) = "COPIA - CLIENTE"
        Frm(3) = "COPIA - ARCHIVO"
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub


    Public Sub Identifica_cliente()
        ' Try
        '
        If Not Consulta Then
            cliente = Table("select * from cliente where eliminado=0 and id_cliente=" + txtid_cliente.Text, "")

            If cliente.Rows.Count = 0 Then
                MessageBox.Show("Cliente no Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SendKeys.Send("{home}+{end}")
                Exit Sub
            End If
            rowc = cliente.Rows(0)
            lblcliente_nombre.Text = rowc("nombre_comercial")
            txtplazo.Text = rowc("plazo")
            USUARIO_PRECIO = rowc("id_precio")
            Me.lbldescg.Text = FormatNumber(rowc("descuento") * 100, 2)
            'Estado()
            cbid_pedido.Focus()
            Carga_pedidos()
            identifica_pedido()
        End If
        cliente_ID = txtid_cliente.Text
        If cliente_ID = 61 Then
            lbl_orden.Visible = True
            txt_orden.Visible = True
        Else
            lbl_orden.Visible = False
            txt_orden.Visible = False
        End If
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub Carga_pedidos()
        'Try
        Cargandopedidos = True
        Pedido = Table("Select * from pedido where  id_cliente=" + txtid_cliente.Text + " order by id_pedido", "id_pedido")
        cbid_pedido.Items.Clear()
        Dim z As Integer
        For z = 0 To Pedido.Rows.Count - 1
            cbid_pedido.Items.Add(Pedido.Rows(z).Item("id_pedido").ToString)
        Next
        cbid_pedido.Items.Add("Nuevo")
        cbid_pedido.SelectedIndex = 0
        Cargandopedidos = False
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        ' End Try
    End Sub



    Private Sub identifica_pedido()
        'Try
        ToolStrip1.Enabled = True
        If cbid_pedido.Text = "Nuevo" Then
            TPD.Rows.Clear()
            dtgpedido.DataSource = TPD
            txttransporte.text = "Nuestro"
            Producto_Incluir()
        Else
            Dim row As DataRow
            row = Pedido.Rows.Find(cbid_pedido.Text)
            txtplazo.Text = row("plazo")
            txttransporte.Text = row("transporte")
            TPD_cargar()
            Totales()
            dtgpedido.DataSource = TPD
            
        End If
        ' Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        '  End Try
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
            For i = 0 To TPD.Rows.Count - 1
                With TPD.Rows(i)
                    m = .Item("precio") * .Item("cantidad")
                    d = m * (.Item("descuento") / 100)
                    mf = m - d
                    If .Item("iv") Then
                        tGravado = tGravado + mf
                        tiv = tiv + mf * PIV
                    Else
                        tExento = tExento + mf
                    End If
                    tdescuento = tdescuento + d
                    productos = productos + 1
                End With
            Next i
            total = tExento + tGravado + tiv

    
            lblproductos.Text = TPD.Rows.Count
            If cliente_ID = 61 Then
                lbltotal.Text = "¢ " + FormatNumber(total * 0.95, 2)
            Else
                lbltotal.Text = "¢ " + FormatNumber(total, 2)
            End If
            If TPD.Rows.Count > 0 Then
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
            lblcliente_nombre.Text = ""
            txtid_cliente.Text = ""
            txtplazo.Text = ""
            cbid_agente.SelectedIndex = 0
            txttransporte.Text = ""
            cbid_pedido.Items.Clear()
            TPD.Rows.Clear()
            Totales()
            txtid_cliente.Focus()
            ToolStrip1.Enabled = False
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub Producto_Incluir()
        Dim Pedido_mantenimiento As New frm_pedido_mantenimiento
        myForms.frm_pedido_mantenimiento = Pedido_mantenimiento
        myForms.frm_pedido_mantenimiento.Owner = Me
        Pedido_mantenimiento.Show()
        Pedido_mantenimiento.lbltitulo.Text = "Incluir Producto"
    End Sub

    

    Public Sub botones(ByVal e As Boolean)
        btnincluir.Enabled = e
        btnmodificar.Enabled = e
        btneliminar.Enabled = e
        btndescpp.Enabled = e
        btnfacturar.Enabled = e
    End Sub


    Private Sub btntotales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntotales.Click
        Dim pedido_totales As New frm_pedido_totales
        With pedido_totales
            .Owner = Me
            If cliente_ID = 61 Then
                .lblgravado.Text = FormatNumber(tGravado * 0.95, 2)
                .lblexento.Text = FormatNumber(tExento * 0.95, 2)
                .lbldescuento.Text = FormatNumber(tdescuento, 2)
                .lbliv.Text = FormatNumber(tiv * 0.95, 2)
                .lbltotal.Text = "¢ " + FormatNumber(total * 0.95, 2)
            Else
                .lblgravado.Text = FormatNumber(tGravado, 2)
                .lblexento.Text = FormatNumber(tExento, 2)
                .lbldescuento.Text = FormatNumber(tdescuento, 2)
                .lbliv.Text = FormatNumber(tiv, 2)
                .lbltotal.Text = "¢ " + FormatNumber(total, 2)
            End If

        End With
        pedido_totales.Show()
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
                BUSQUEDA = "Pedido"

                Dim cliente_buscar As New frm_cliente_buscar
                cliente_buscar.Owner = Me
                cliente_buscar.Show()
                cliente_buscar.txtbuscar_cliente.Text = e.KeyChar

            Else

                e.Handled = Numerico(Asc(e.KeyChar), txtid_cliente.Text, False)
            End If
        End If

    End Sub

    Private Sub cbid_pedido_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbid_pedido.SelectedIndexChanged
        If Not Cargandopedidos Then identifica_pedido()
    End Sub

    Public Sub TPD_crear()
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


        Dim Barras As DataColumn = New DataColumn("barcode")
        Barras.DataType = System.Type.GetType("System.String")
        TPD.Columns.Add(Barras)

        Dim descuento As DataColumn = New DataColumn("descuento")
        descuento.DataType = System.Type.GetType("System.Decimal")
        descuento.DefaultValue = 0
        TPD.Columns.Add(descuento)



        Dim iv As DataColumn = New DataColumn("iv")
        iv.DataType = System.Type.GetType("System.Boolean")
        TPD.Columns.Add(iv)


        Dim Monto As DataColumn = New DataColumn("Monto")
        Monto.DataType = System.Type.GetType("System.Decimal")
        Monto.Expression = "cantidad * precio"
        Dim l As Integer = Round(5, 0)
        TPD.Columns.Add(Monto)


        TPD.PrimaryKey = New DataColumn() {TPD.Columns("id_producto")}

        'Catch myerror As Exception
        ' ONEX(Me.Name, myerror)
        ' End Try

    End Sub

    Public Sub TPD_cargar()
        'Try
        Dim prd As DataTable
        Dim PD As DataTable
        PD = Table("select * from pedido_detalle where id_pedido=" + cbid_pedido.Text, "")
        Dim z As Integer
        Dim rowtpd As DataRow
        TPD_crear()

        For z = 0 To PD.Rows.Count - 1
            With PD.Rows(z)
                rowtpd = TPD.NewRow
                rowtpd("id_producto") = .Item("id_producto")
                rowtpd("cantidad") = .Item("Cantidad")
                rowtpd("descuento") = .Item("descuento") * 100
                rowtpd("costo") = .Item("costo")
                rowtpd("precio") = .Item("precio")
                prd = Table("select nombre,presentacion,iv,barcode from producto where id_producto=" + .Item("id_producto").ToString, "")
                rowtpd("barcode") = prd.Rows(0).Item("barcode")
                rowtpd("nombre") = prd.Rows(0).Item("nombre")
                rowtpd("iv") = prd.Rows(0).Item("iv")
                rowtpd("presentacion") = P(prd.Rows(0).Item("presentacion"))
                TPD.Rows.Add(rowtpd)
            End With
        Next
        dtgpedido.Focus()
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub btnincluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnincluir.Click
        Producto_Incluir()
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        Producto_Modificar()
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Producto_Eliminar()
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If TPD.Rows.Count = 0 Then
            MessageBox.Show("No Hay Productos que Guardar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Val(txtid_cliente.Text) = 0 Then
            MessageBox.Show("Debe Escribir un Código de cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid_cliente.Focus()
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If
        If cliente_ID <> txtid_cliente.Text Then
            MessageBox.Show("Escriba de Nuevo el código del Cliente y Presione Enter", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid_cliente.Focus()
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If
        Guardar()
        limpiar()
    End Sub


    Private Sub Guardar()
        'Try
      

        Dim cmd As New SqlCommand
        cmd.Connection = CONN1
        Dim Sql As String
        Dim P As DataTable
        If cbid_pedido.Text = "Nuevo" Then
            Sql = "Insert into Pedido (id_cliente,id_agente,fecha,plazo,transporte,id_usuario, ordenCompra, fechaOrden) values (" + _
            txtid_cliente.Text + "," + _
            cbid(cbid_agente.Text) + "," + _
            "getDate()," + _
            Val(txtplazo.Text).ToString + "," + _
            "'" + txttransporte.Text + "'," + _
            USUARIO_ID + "," + _
            "'" + txtOrden.Text + "'," + _
             "'" + dtpOrden.Value.ToString("MM/dd/yyyy") + "')"

            P = Table(Sql + " select @@IDENTITY as id_pedido", "")
            PedidoID = P.Rows(0).Item("id_Pedido")

        Else

            Sql = "Update pedido set " + _
                "id_cliente=" + txtid_cliente.Text + "," + _
                "id_agente=" + cbid(cbid_agente.Text) + "," + _
                "plazo=" + Val(txtplazo.Text).ToString + "," + _
                "transporte='" + txttransporte.Text + "'," + _
                "id_usuario=" + USUARIO_ID + "," + _
                "ordenCompra='" + txtOrden.Text + "'," + _
                "fechaOrden='" + dtpOrden.Value.ToString("MM/dd/yyyy") + "'" + _
                " where id_pedido=" + cbid_pedido.Text

            cmd.CommandText = Sql
            cmd.ExecuteNonQuery()

            PedidoID = cbid_pedido.Text

            cmd.CommandText = "delete from pedido_detalle where id_pedido=" + cbid_pedido.Text
            cmd.ExecuteNonQuery()
        End If

        Dim i As Integer
        For i = 0 To TPD.Rows.Count - 1
            With TPD.Rows(i)
                Sql = "insert into Pedido_detalle (id_pedido,id_producto,cantidad,costo,precio,descuento) values (" + _
                PedidoID + "," + _
                "'" + .Item("id_producto") + "'," + _
                .Item("cantidad").ToString + "," + _
                .Item("costo").ToString + "," + _
                .Item("precio").ToString + "," + _
                (.Item("descuento") / 100).ToString + ")"

            End With
            cmd.CommandText = Sql
            cmd.ExecuteNonQuery()
        Next i

        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub btnfacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfacturar.Click
        'Try
        If txt_orden.Text = "" Then
            Dim i As MsgBoxResult
            i = MsgBox("Desea imprimir la factura sin orden de Compra?", MsgBoxStyle.YesNo, "No orden de compra")
            If i = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        If TPD.Rows.Count = 0 Then
            MessageBox.Show("No Hay Productos que Facturar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Val(txtid_cliente.Text) = 0 Then
            MessageBox.Show("Debe Escribir un Código de cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid_cliente.Focus()
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If
        If cliente_ID <> txtid_cliente.Text Then
            MessageBox.Show("Escriba de Nuevo el código del Cliente y Presione Enter", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid_cliente.Focus()
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If
        If Val(txt_orden.Text) = 0 And cliente_ID = 61 Then
            MessageBox.Show("Favor Ingrese un Numero de Orden Valido", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_orden.Focus()
            txt_orden.SelectAll()

            Exit Sub
        End If
        btnfacturar.Enabled = False

        Facturas_Generar()
        Facturas_imprimir(1)
        Facturas_imprimir(2)
        Facturas_imprimir(3)


        If Not cbid_pedido.Text = "Nuevo" Then
            Dim cmd As New SqlCommand
            cmd.Connection = CONN1

            cmd.CommandText = "delete from Pedido where id_pedido=" + cbid_pedido.Text
            cmd.ExecuteNonQuery()
            cmd.CommandText = "delete from pedido_detalle where id_pedido=" + cbid_pedido.Text
            cmd.ExecuteNonQuery()
        End If

        Me.Close()

        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try




    End Sub

    Private Sub Facturas_Generar()

        'Try
        Dim Sql As String
        Dim cmd As New SqlCommand
        cmd.Connection = CONN1

        Dim F As DataTable

        Dim FGravado As Decimal
        Dim FExento As Decimal
        Dim Fdescuento As Decimal
        Dim Fiv As Decimal


        Dim LI As Integer
        Dim LS As Integer





        'Tsort(TPD, "nombre")


        Dim Facturas As Integer = IIf(TPD.Rows.Count > LN, IIf(TPD.Rows.Count Mod LN > 0, Int(TPD.Rows.Count / LN) + 1, TPD.Rows.Count / LN), 1)
        ReDim FS(Facturas + 1)

        Dim h As Integer

        For h = 1 To Facturas

            FGravado = 0
            FExento = 0
            Fdescuento = 0
            Fiv = 0

            Sql = "INSERT INTO FACTURA (id_cliente,id_agente,fecha,plazo,transporte,piv,id_usuario,observaciones,orden,sincronizada,ordenCompra,fechaOrden) values (" + _
            txtid_cliente.Text + "," + _
            cbid(cbid_agente.Text) + "," + _
            "getDate()," + _
            Val(txtplazo.Text).ToString + "," + _
            "'" + txttransporte.Text + "'," + _
            PIV.ToString + "," + _
            USUARIO_ID + "," + _
            "'" + txt_observaciones.Text + "'," + _
            "'" + txt_orden.Text + "', " + _
            "0, " + _
            "'" + txtOrden.Text + "'," + _
            "'" + dtpOrden.Value.ToString("MM/dd/yyyy") + "')"


            F = Table(Sql + " select @@IDENTITY as id_factura", "")

            FacturaID = F.Rows(0).Item("id_factura")
            FS(h) = FacturaID

            LI = LN * (h - 1)
            LS = IIf((LI + LN - 1) >= TPD.Rows.Count, TPD.Rows.Count - 1, LI + LN - 1)

            Dim z As Integer
            For z = LI To LS

                With TPD.Rows(z)
                    Sql = "insert into Factura_detalle (id_factura,id_producto,cantidad,costo,precio,descuento,iv) values (" + _
                    FacturaID + "," + _
                    "'" + .Item("id_producto") + "'," + _
                    .Item("cantidad").ToString + "," + _
                    .Item("costo").ToString + "," + _
                    .Item("precio").ToString + "," + _
                    (.Item("descuento") / 100).ToString + "," + _
                    IIf(.Item("iv"), "1", "0") + ")"

                    cmd.CommandText = Sql
                    cmd.ExecuteNonQuery()

                    'se quito la modificacion del campo existencia en la base de datos

                    'Sql = "update Producto set existencia=existencia-" + .Item("cantidad").ToString + _
                    '" where id_producto=" + .Item("id_producto").ToString

                    'cmd.CommandText = Sql
                    'cmd.ExecuteNonQuery()
                End With
            Next z

        Next h

        Process.Start("cmd", "/c dotnet c:/FacElec/FacElec.dll")

        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try

    End Sub


    Private Sub Facturas_imprimir(ByVal Doc As String)
        'Try


        Dim FGravado As Decimal
        Dim FExento As Decimal
        Dim Fdescuento As Decimal
        Dim Fiv As Decimal

        Dim mf As Decimal
        Dim m As Decimal
        Dim d As Decimal

        Dim LI As Integer
        Dim LS As Integer

        V_Factura_crear()
        Dim Facturas As Integer = IIf(TPD.Rows.Count > LN, IIf(TPD.Rows.Count Mod LN > 0, Int(TPD.Rows.Count / LN) + 1, TPD.Rows.Count / LN), 1)
        Dim h As Integer

        For h = 1 To Facturas
            V_Factura.Rows.Clear()

            FGravado = 0
            FExento = 0
            Fdescuento = 0
            Fiv = 0

            LI = LN * (h - 1)
            LS = IIf((LI + LN - 1) >= TPD.Rows.Count, TPD.Rows.Count - 1, LI + LN - 1)

            Dim z As Integer
            For z = LI To LS

                With TPD.Rows(z)

                    m = .Item("precio") * .Item("cantidad")
                    d = m * (.Item("descuento") / 100)


                    mf = m - d
                    If .Item("iv") Then
                        FGravado = FGravado + mf
                        'Fiv = Fiv + mf * PIV
                    Else
                        FExento = FExento + mf
                    End If
                    Fdescuento = Fdescuento + d
                End With
                V_Factura.ImportRow(TPD.Rows(z))
            Next z

            Dim DCEDI As Double = 0
            If cliente_ID = 61 Then
                DCEDI = FGravado * 0.05
            End If

            Fiv = (FGravado - DCEDI) * PIV

            Dim rfactura

            If cliente_ID = 61 Then
                rfactura = New rpt_Factura_cedi

            Else

                rfactura = New rpt_Factura

            End If



            rfactura.SetDataSource(V_Factura)



            rParameterFieldDefinitions = rfactura.DataDefinition.ParameterFields


            rParameterFieldLocation = rParameterFieldDefinitions.Item("exento")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            If cliente_ID = 61 Then
                rParameterDiscreteValue.Value = FormatNumber(DCEDI)
            Else
                rParameterDiscreteValue.Value = FormatNumber(FExento, 2)
            End If
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            If cliente_ID = 61 Then
                rParameterFieldLocation = rParameterFieldDefinitions.Item("orden")
                rParameterValues = rParameterFieldLocation.CurrentValues
                rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
                rParameterDiscreteValue.Value = Val(txt_orden.Text)
                rParameterValues.Add(rParameterDiscreteValue)
                rParameterFieldLocation.ApplyCurrentValues(rParameterValues)
            End If


            rParameterFieldLocation = rParameterFieldDefinitions.Item("NEGOCIO")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = NEGOCIO
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("CJ")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = CJ
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("WEB")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = ""
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("NEGOCIO_TELEFONO")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = TELEFONO
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("NEGOCIO_DIRECCION")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = DIRECCION
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("tantos")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = h.ToString + "/" + Facturas.ToString
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



            rParameterFieldLocation = rParameterFieldDefinitions.Item("cliente")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = txtid_cliente.Text + "-" + lblcliente_nombre.Text
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


            rParameterFieldLocation = rParameterFieldDefinitions.Item("direccion")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = rowc("direccion")
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


            rParameterFieldLocation = rParameterFieldDefinitions.Item("fecha")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = "Fecha: " + IIf(Consulta, Fecha, Date.Today.ToShortDateString)
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


            rParameterFieldLocation = rParameterFieldDefinitions.Item("vencimiento")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = "Vence: " + DateAdd(DateInterval.Day, Val(txtplazo.Text), IIf(Consulta, Fecha, Date.Today))
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("forma_pago")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = IIf(Val(txtplazo.Text) > 0, "CREDITO " + txtplazo.Text + " dias", "CONTADO")
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


            rParameterFieldLocation = rParameterFieldDefinitions.Item("%")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = IIf(Fdescuento > 0, "-%", " ")
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


            rParameterFieldLocation = rParameterFieldDefinitions.Item("telefono")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = rowc("telefono")
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("gravado")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = FormatNumber(FGravado, 2)
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("iv")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = FormatNumber(Fiv, 2)
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("Total")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = "¢ " + FormatNumber(FGravado + Fiv + FExento -DCEDI, 2)
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("facturaid")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = "Factura:   " + FacturaID
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("usuario_nombre")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = "hecho por: " + USUARIO_NOMBRE
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



            rParameterFieldLocation = rParameterFieldDefinitions.Item("m1")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = IIf(Consulta, "", M1)
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("m2")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = IIf(Consulta, "", M2)
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("m3")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = IIf(Consulta, "", M3)
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("formulario")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = Frm(Doc)
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("transporte")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = "Transporte: " + txttransporte.Text
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("tdescuento")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = IIf(tdescuento > 0, "Descuento", "")
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("descuento")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = IIf(Fdescuento > 0, FormatNumber(Fdescuento, 2), "")
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

            rParameterFieldLocation = rParameterFieldDefinitions.Item("observaciones")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = txt_observaciones.Text
            rParameterValues.Add(rParameterDiscreteValue)
            rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


            rfactura.PrintOptions.PrinterName = PrinterServer
            rfactura.PrintOptions.PaperOrientation = PaperOrientation.Portrait
            rfactura.PrintToPrinter(1, False, 1, 1)

            'Dim rv As New frm_Report_Viewer
            'rv.crv.ReportSource = rfactura
            'rv.Show()

        Next h
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try


    End Sub


    Public Sub V_Factura_crear()
        'Try

        V_Factura = New DataTable("V_Factura")
        Dim id_producto As DataColumn = New DataColumn("id_producto")
        id_producto.DataType = System.Type.GetType("System.String")
        V_Factura.Columns.Add(id_producto)

        Dim nombre As DataColumn = New DataColumn("nombre")
        nombre.DataType = System.Type.GetType("System.String")
        V_Factura.Columns.Add(nombre)

        Dim cantidad As DataColumn = New DataColumn("cantidad")
        cantidad.DataType = System.Type.GetType("System.Int32")
        V_Factura.Columns.Add(cantidad)

        Dim presentacion As DataColumn = New DataColumn("presentacion")
        presentacion.DataType = System.Type.GetType("System.String")
        V_Factura.Columns.Add(presentacion)


        Dim precio As DataColumn = New DataColumn("precio")
        precio.DataType = System.Type.GetType("System.Decimal")
        V_Factura.Columns.Add(precio)

        Dim Barras As DataColumn = New DataColumn("barcode")
        Barras.DataType = System.Type.GetType("System.String")
        V_Factura.Columns.Add(Barras)

        Dim descuento As DataColumn = New DataColumn("descuento")
        descuento.DataType = System.Type.GetType("System.Decimal")
        descuento.DefaultValue = 0
        V_Factura.Columns.Add(descuento)


        Dim iv As DataColumn = New DataColumn("iv")
        iv.DataType = System.Type.GetType("System.Boolean")
        V_Factura.Columns.Add(iv)


        Dim Monto As DataColumn = New DataColumn("Monto")
        Monto.DataType = System.Type.GetType("System.Decimal")
        Monto.Expression = "cantidad * precio"
        V_Factura.Columns.Add(Monto)


        'V_Factura.PrimaryKey = New DataColumn() {V_Factura.Columns("id_producto")}



        'Catch myerror As Exception
        ' ONEX(Me.Name, myerror)
        ' End Try

    End Sub

    Private Sub txtplazo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtplazo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{tab}")
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtplazo.Text, False)
        End If


    End Sub

    Private Sub txtplazo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtplazo.TextChanged

    End Sub

    Private Sub txtid_cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_cliente.TextChanged

    End Sub

    Private Sub btndescpp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndescpp.Click
        Dim descuento As New frm_Pedido_descproductop
        With descuento
            .Owner = Me
            .Show()
            .lblid_producto.Text = dtgpedido.Item("id_producto", dtgpedido.CurrentRow.Index).Value
            .lblnombre_producto.Text = dtgpedido.Item("nombre", dtgpedido.CurrentRow.Index).Value
        End With
    End Sub

    Private Sub btndescgeneralp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndescgeneralp.Click
        Dim descgen As New frm_pedido_descgeneralp
        descgen.Owner = myForms.frm_principal
        descgen.Show()
    End Sub

    Private Sub dtgpedido_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgpedido.CellContentClick

    End Sub

    Private Sub dtgpedido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtgpedido.KeyDown
        If e.KeyCode = Keys.Insert Then
            Producto_Incluir()
        ElseIf e.KeyCode = Keys.Enter Then
            e.Handled = True
            Producto_Modificar()
        ElseIf e.KeyCode = Keys.Delete Then
            Producto_Eliminar()
        End If
    End Sub

    Private Sub Producto_Modificar()
        Try
            If TPD.Rows.Count = 0 Then
                MessageBox.Show("Nada que Modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim Pedido_mantenimiento As New frm_pedido_mantenimiento
            myForms.frm_pedido_mantenimiento = Pedido_mantenimiento
            With myForms.frm_pedido_mantenimiento
                myForms.frm_pedido_mantenimiento.Owner = Me
                .lbltitulo.Text = "Modificar Producto"
                Dim row As DataRow = TPD.Rows(BindingContext(TPD).Position())
                .Owner = Me

                .txtid_producto.Text = row("id_producto")
                .Identifica_producto()
                .txtcantidad.Text = row("cantidad")
                .Show()
                .txtcantidad.Focus()
                SendKeys.Send("{home}+{end}")
            End With
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub Producto_Eliminar()
        Try
            If TPD.Rows.Count = 0 Then
                MessageBox.Show("Nada que Eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim row As DataRow = TPD.Rows(BindingContext(TPD).Position())
            Dim res As DialogResult = MessageBox.Show("Elimnar " + row("nombre"), "Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = Windows.Forms.DialogResult.Yes Then
                row.Delete()
                Totales()
            End If
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub



    Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
        If chkoriginal.Checked Then Facturas_imprimir(1)
        If chkcopia.Checked Then Facturas_imprimir(2)
        If chkarchivo.Checked Then Facturas_imprimir(3)

    End Sub

    Private Sub chkoriginal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkoriginal.CheckedChanged

    End Sub

    Private Sub txt_orden_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_orden.Click
        txt_orden.SelectAll()
    End Sub

    Private Sub txt_orden_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_orden.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOrden.TextChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
End Class