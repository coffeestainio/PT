Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frm_devolucion

    Dim rParameterDiscreteValue As ParameterDiscreteValue
    Dim rParameterFieldDefinitions As ParameterFieldDefinitions
    Dim rParameterFieldLocation As ParameterFieldDefinition
    Dim rParameterValues As ParameterValues

    Dim Factura As DataTable
    Public FD As DataTable
    Dim Cliente As DataTable
    Dim Bodega As DataTable

    Public devolucion As DataTable

    Dim Producto As DataTable
    Public rowc As DataRow

    Public TGravado As Decimal
    Public TExento As Decimal
    Public Tdescuento As Decimal
    Public Tiv As Decimal
    Public Total As Decimal


    Dim Frm(2) As String

    Dim L As Integer
    Public Formulario As Integer
    Dim Factura_ID As String
    Public Fecha As String
    Public DevolucionID As String
    Public PIV As Decimal



    Public Sub Identifica_Factura()

        Factura = FACM("factura.id_factura=" + txtid_factura.Text, True, "")

        If Factura.Rows.Count = 0 Then
            MessageBox.Show("Factura No Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid_factura.Focus()
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If

        With Factura.Rows(0)
            If .Item("anulado") Then
                MessageBox.Show("Factura Fue Anulada", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtid_factura.Focus()
                SendKeys.Send("{home}+{end}")
                Exit Sub
            End If

            Cliente = Table("Select * from cliente where id_cliente=" + .Item("id_cliente").ToString, "")
            rowc = Cliente.Rows(0)
            lblid_cliente.Text = .Item("id_cliente").ToString + " - " + rowc("nombre_comercial")
            Factura_ID = txtid_factura.Text
            lblplazo.Text = .Item("plazo")
            lblfecha.Text = .Item("fecha")
            lblmonto.Text = FormatNumber(.Item("Monto").ToString, 2)
            PIV = .Item("piv")


            FD = Table("select id_Producto,cantidad,costo,precio,descuento*100 as descuento,iv from factura_detalle where id_factura=" + .Item("id_factura").ToString + " order by id_producto", "id_producto")
            FD_Completar()
            Devolucion_Crear()

            dtgfactura_detalle.DataSource = FD
            dtgdevolucion.DataSource = devolucion

            ToolStrip.Enabled = True
        End With
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub


    Private Sub frm_devolucion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Not Consulta Then
                myForms.frm_principal.ToolStrip.Enabled = True
                CONN1.Close()
                Fecha = Date.Today.ToShortDateString + "  " + Format(Now, "short Time")
            End If
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub frm_devolucion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Not Consulta Then CONN1.Open()
           
            Frm(1) = "ORIGINAL -  CLIENTE"
            Frm(2) = "COPIA - ARCHIVO"
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub


    Public Sub Totales()
        Try
            Dim mf As Decimal
            Dim m As Decimal = 0
            Dim d As Decimal = 0


            Dim productos As Decimal = 0
            TGravado = 0
            TExento = 0
            Tdescuento = 0
            Tiv = 0
            Total = 0
            Dim i As Integer

            For i = 0 To devolucion.Rows.Count - 1
                With devolucion.Rows(i)
                    m = .Item("precio") * .Item("cantidad")
                    d = m * (.Item("descuento") / 100)
                    mf = m - d
                    If .Item("iv") Then
                        TGravado = TGravado + mf
                        Tiv = Tiv + mf * PIV
                    Else
                        TExento = TExento + mf
                    End If
                    Tdescuento = Tdescuento + d
                    productos = productos + 1
                End With
            Next i

            Total = TExento + TGravado + Tiv
            lblproductos.Text = productos
            lbltotal.Text = "� " + FormatNumber(Total, 2)
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        Try
            Dim rowf As DataRow = FD.Rows(BindingContext(FD).Position())
            Dim row As DataRow = devolucion.Rows.Find(rowf("id_producto"))
            If Not (row Is Nothing) Then
                MessageBox.Show("Producto ya Existe", "Devoluci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim rowd As DataRow = devolucion.NewRow
            rowd("id_producto") = rowf("id_producto")
            rowd("nombre") = rowf("nombre")
            rowd("cantidad") = rowf("cantidad")
            rowd("presentacion") = rowf("presentacion")
            rowd("costo") = rowf("costo")
            rowd("precio") = rowf("precio")
            rowd("descuento") = rowf("descuento")
            rowd("iv") = rowf("iv")
            devolucion.Rows.Add(rowd)
            Totales()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Try
            If devolucion.Rows.Count = 0 Then
                MessageBox.Show("Nada que Eliminar", "Devoluci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            devolucion.Rows(BindingContext(devolucion).Position()).Delete()
            Totales()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        'Try
        If devolucion.Rows.Count = 0 Then
            MessageBox.Show("Nada que Modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim devolucion_mantenimiento As New frm_devolucion_mantenimiento
        devolucion_mantenimiento.Owner = Me
        With devolucion_mantenimiento
            Dim row As DataRow = devolucion.Rows(BindingContext(devolucion).Position())
            .Owner = Me
            .txtid_producto.Text = row("id_producto")
            .lblproducto_nombre.Text = row("nombre")
            .lblprecio.Text = row("precio")
            .lblpresentacion.Text = row("presentacion")
            .txtdescuento.Text = FormatNumber(row("descuento"), 2)
            .lbliv.Text = IIf(row("iv"), "+ iv", "")
            .Show()
        End With
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub



    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        'Try
        If devolucion.Rows.Count = 0 Then
            MessageBox.Show("No Hay Productos que Devolver", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Val(txtid_factura.Text) = 0 Then
            MessageBox.Show("Debe Escribir un N�mero de Factura", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid_factura.Focus()
            pbid_factura.Visible = True
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If
        If Factura_ID <> txtid_factura.Text Then
            MessageBox.Show("Escriba de Nuevo el N�mero de Factura y Presione Enter", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid_factura.Focus()
            pbid_factura.Visible = True
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If

        If devolucion.Rows.Count = 0 Then
            MessageBox.Show("No Seleccion� Ningun Producto", "Devoluci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        btnguardar.Enabled = False
        Dim cmd As New SqlCommand
        cmd.Connection = CONN1
        Dim D As DataTable
        Dim sql As String


        sql = "insert into devolucion (id_factura,fecha,id_cliente,id_usuario) values (" + _
        txtid_factura.Text + "," + _
        "'" + EDATE(Date.Today.ToShortDateString) + "'," + _
        rowc("id_cliente").ToString + "," + _
        USUARIO_ID + ")"

        D = Table(sql + " select @@IDENTITY as id_devolucion", "")
        DevolucionID = D.Rows(0).Item("id_devolucion")

        sql = "insert into Nota_credito (fecha,id_cliente,exento,gravado,piv,observaciones,id_usuario) values (" + _
                "'" + EDATE(Date.Today.ToShortDateString) + "'," + _
                rowc("id_cliente").ToString + "," + _
                (TExento).ToString + "," + _
                (TGravado).ToString + "," + _
                (PIV).ToString + "," + _
                "'DEV " + DevolucionID + "'," + _
                USUARIO_ID + ")"


        Dim T As DataTable = Table(sql + " select @@IDENTITY as id_nota_credito", "")

        sql = "update devolucion set id_nota_credito=" + T.Rows(0).Item("id_nota_credito").ToString + _
        " where id_devolucion=" + DevolucionID

        cmd.CommandText = sql
        cmd.ExecuteNonQuery()

        Dim i As Integer

        For i = 0 To devolucion.Rows.Count - 1
            With devolucion.Rows(i)

                'se quito la modificacion del campo existencia en la base de datos
                'sql = "update producto set existencia=existencia+" + .Item("cantidad").ToString + _
                '" where id_producto=" + .Item("id_producto").ToString

                'cmd.CommandText = sql
                'cmd.ExecuteNonQuery()

                sql = "insert into  devolucion_detalle (id_devolucion,id_producto,cantidad) values (" + _
                DevolucionID + "," + _
                .Item("id_producto").ToString + "," + _
                .Item("cantidad").ToString + ")"


                cmd.CommandText = sql
                cmd.ExecuteNonQuery()



            End With
        Next

        imprimir(1)
        imprimir(2)

        Me.Close()
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub



    Private Sub txtid_factura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid_factura.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            If Val(txtid_factura.Text) = 0 Then
                Me.Close()
            Else
                Identifica_Factura()
            End If
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtid_factura.Text, False)
        End If
    End Sub

    Public Sub FD_Completar()

        Dim presentacion As DataColumn = New DataColumn("presentacion")
        presentacion.DataType = System.Type.GetType("System.String")
        FD.Columns.Add(presentacion)

        Dim nombre As DataColumn = New DataColumn("nombre")
        nombre.DataType = System.Type.GetType("System.String")
        FD.Columns.Add(nombre)

       

        Dim monto As DataColumn = New DataColumn("monto")
        monto.DataType = System.Type.GetType("System.Decimal")
        monto.Expression = "cantidad * precio"
        FD.Columns.Add(monto)

        Dim z As Integer
        For z = 0 To FD.Rows.Count - 1
            With FD.Rows(z)
                Producto = Table("select id_producto,nombre,presentacion from producto where id_producto=" + .Item("id_producto").ToString, "")
                .Item("presentacion") = Producto.Rows(0).Item("Presentacion")
                .Item("nombre") = Producto.Rows(0).Item("nombre")
                .Item("presentacion") = Prst(Producto.Rows(0).Item("presentacion"))
            End With
        Next
    End Sub

    Private Sub Devolucion_Crear()
        devolucion = Table("select id_producto,cantidad,costo,precio,descuento,iv from factura_detalle where id_factura=0", "id_producto")

        Dim presentacion As DataColumn = New DataColumn("presentacion")
        presentacion.DataType = System.Type.GetType("System.String")
        devolucion.Columns.Add(presentacion)

        Dim nombre As DataColumn = New DataColumn("nombre")
        nombre.DataType = System.Type.GetType("System.String")
        devolucion.Columns.Add(nombre)


       

        Dim monto As DataColumn = New DataColumn("monto")
        monto.DataType = System.Type.GetType("System.Decimal")
        monto.Expression = "cantidad * precio"
        devolucion.Columns.Add(monto)
    End Sub

    Private Sub btntotales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntotales.Click
        Try
            Dim devolucion_totales As New frm_pedido_totales
            With devolucion_totales
                .Owner = Me
                .lblgravado.Text = FormatNumber(TGravado, 2)
                .lblexento.Text = FormatNumber(TExento, 2)
                .lbldescuento.Text = FormatNumber(Tdescuento, 2)
                .lbliv.Text = FormatNumber(Tiv, 2)
                .lbltotal.Text = "� " + FormatNumber(Total, 2)
            End With
            devolucion_totales.Show()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub



    Private Sub imprimir(ByVal Doc As String)
        'Try

        Dim rdevolucion As New rpt_devolucion

        rdevolucion.SetDataSource(devolucion)

        rParameterFieldDefinitions = rdevolucion.DataDefinition.ParameterFields


        rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
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
        rParameterDiscreteValue.Value = "WEB"
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio_TELEFONO")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = TELEFONO
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio_DIRECCION")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = DIRECCION
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("factura")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = "Factura: " + txtid_factura.Text
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("devolucionid")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = "Devoluci�n:   " + DevolucionID
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


        rParameterFieldLocation = rParameterFieldDefinitions.Item("cliente")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = "Cliente: " + lblid_cliente.Text
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


        rParameterFieldLocation = rParameterFieldDefinitions.Item("fecha")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = "Fecha: " + IIf(Consulta, Fecha, Date.Today.ToShortDateString)
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


        rParameterFieldLocation = rParameterFieldDefinitions.Item("%")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = IIf(Tdescuento > 0, "-%", "")
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


        rParameterFieldLocation = rParameterFieldDefinitions.Item("gravado")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = FormatNumber(TGravado, 2)
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("iv")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = FormatNumber(Tiv, 2)
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("exento")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = FormatNumber(TExento, 2)
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("Total")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = "� " + FormatNumber(Total, 2)
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


        rParameterFieldLocation = rParameterFieldDefinitions.Item("usuario")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = "hecho por: " + USUARIO_NOMBRE
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



        rParameterFieldLocation = rParameterFieldDefinitions.Item("formulario")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = Frm(Doc)
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

       

        rParameterFieldLocation = rParameterFieldDefinitions.Item("tdescuento")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = IIf(Tdescuento > 0, "Descuento", "")
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("descuento")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = IIf(Tdescuento > 0, FormatNumber(Tdescuento, 2), "")
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rdevolucion.PrintOptions.PrinterName = PrinterServer
        rdevolucion.PrintToPrinter(1, False, 1, 1)

        'Dim rv As New frm_Report_Viewer
        ' rv.crv.ReportSource = rdevolucion
        'rv.Show()
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try


    End Sub


   
    Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
        imprimir(1)
        imprimir(2)
    End Sub
End Class