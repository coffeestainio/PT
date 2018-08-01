Imports System.Data.sqlclient
Imports System.Drawing.Printing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class frm_recibo
    Inherits System.Windows.Forms.Form


    Dim rParameterDiscreteValue As ParameterDiscreteValue
    Dim rParameterFieldDefinitions As ParameterFieldDefinitions
    Dim rParameterFieldLocation As ParameterFieldDefinition
    Dim rParameterValues As ParameterValues

    Public ANTERIOR As Double
    Public cliente As DataTable
    Public rowc As DataRow
    Dim Factura As DataTable
    Public Documento As DataTable
    Dim Total As Decimal
    Dim Cliente_ID As String
    Dim Vencido As Decimal
    Dim Sinvencer As Decimal
    Dim L As Integer
    Dim Formulario As Integer
    Public Fecha As String
    Public ReciboID As String
    Public criterio As String

    
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
                BUSQUEDA = "recibo"
                Dim cliente_buscar As New frm_cliente_buscar
                cliente_buscar.Owner = Me
                cliente_buscar.Show()
                cliente_buscar.txtbuscar_cliente.Text = e.KeyChar
            Else
                e.Handled = Numerico(Asc(e.KeyChar), txtid_cliente.Text, False)
            End If
        End If
    End Sub

    Public Sub Identifica_cliente()
        'Try
        cliente = Table("select * from cliente where eliminado=0 and id_cliente=" + txtid_cliente.Text, "")
        If cliente.Rows.Count = 0 Then
            MessageBox.Show("Cliente no Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If
        rowc = cliente.Rows(0)
        lblnombre_cliente.Text = rowc("nombre_comercial")
        If chkgrupo.Checked Then
            Dim grupo As DataTable = Table("select * from grupo where id_grupo=" + rowc("id_grupo").ToString, "")
            lblgrupo.Text = grupo.Rows(0).Item("nombre")
        End If
        Cliente_ID = txtid_cliente.Text
        Estado()
        dtgfactura.DataSource = Factura
        ToolStrip.Enabled = True
        ' Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub frm_recibo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Not Consulta Then
                myForms.frm_principal.ToolStrip.Enabled = True
                CONN1.Close()
            End If
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub frm_recibo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        If Not Consulta Then
            CONN1.Open()
            documento = New DataTable("documento")

            Dim id_documento As DataColumn = New DataColumn("id_documento")
            id_documento.DataType = System.Type.GetType("System.Decimal")
            id_documento.DefaultValue = 0
            documento.Columns.Add(id_documento)

            Dim monto As DataColumn = New DataColumn("monto")
            monto.DataType = System.Type.GetType("System.Decimal")
            monto.DefaultValue = 0
            Documento.Columns.Add(monto)

            Documento.PrimaryKey = New DataColumn() {Documento.Columns("id_documento")}

            dtgdocumento.DataSource = documento
            cbforma_pago.SelectedIndex = 0
            Fecha = Date.Today.ToShortDateString + "  " + Format(Now, "short Time")
        End If
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub
    
   
    
    Public Sub Totales()
        Try
            Dim Z%
            Total = 0
            For Z = 0 To documento.Rows.Count - 1
                Total = Total + documento.Rows(Z).Item("monto")
            Next
            lbltotal.Text = FormatNumber(Total, 2)
            lblfacturas.Text = documento.Rows.Count.ToString
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub


    Private Sub Estado()
        'Try
        Dim criteriof As String = ""
        Sinvencer = 0.0
        Vencido = 0.0
        If rowc("id_grupo") > 1 And chkgrupo.Checked Then
            Dim c As DataTable = Table("select id_cliente from cliente where id_grupo=" + rowc("id_grupo").ToString, "")
            Dim i As Integer
            For i = 0 To c.Rows.Count - 1
                With c.Rows(i)
                    If i = 0 Then
                        criterio = " nota_credito.id_cliente=" + .Item("id_cliente").ToString
                        criteriof = " cliente.id_cliente=" + .Item("id_cliente").ToString
                    Else
                        criterio = criterio + " or nota_credito.id_cliente=" + .Item("id_cliente").ToString
                        criteriof = criterio + " or cliente.id_cliente=" + .Item("id_cliente").ToString
                    End If
                End With
            Next
        Else
            criterio = "nota_credito.id_cliente=" + rowc("id_cliente").ToString
            criteriof = "CLIENTE.id_cliente=" + rowc("id_cliente").ToString
        End If
        Factura = FACS(criteriof, "id_factura")

        Dim z As Integer
        For z = 0 To Factura.Rows.Count - 1
            With Factura.Rows(z)
                If .Item("vence") > Date.Today Then
                    Sinvencer = Sinvencer + .Item("saldo")
                Else
                    Vencido = Vencido + .Item("saldo")
                End If
            End With
        Next
        Dim ncd As DataTable = NCDIS(criterio, "")
        If ncd.Rows.Count > 0 Then btnnc.Enabled = True
        lblvencido.Text = FormatNumber(Vencido, 2)
        lblsinvencer.Text = FormatNumber(Sinvencer, 2)
        lblsaldototal.Text = FormatNumber(Vencido + Sinvencer, 2)
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub





    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        Try
            Dim rowf As DataRow = Factura.Rows(BindingContext(Factura).Position())
            Dim row As DataRow = documento.Rows.Find(rowf("id_factura"))
            If Not (row Is Nothing) Then
                MessageBox.Show("Factura ya Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim rowa As DataRow = documento.NewRow
            rowa("id_documento") = rowf("id_factura")
            rowa("monto") = rowf("saldo")
            Documento.Rows.Add(rowa)
            txtmotivo.Text = "Cancela Factura # " & rowa("id_documento")
            ANTERIOR = Documento.Rows(0).Item("monto")
            Totales()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try

    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        Try
            If documento.Rows.Count = 0 Then
                MessageBox.Show("Nada que Eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            documento.Rows(BindingContext(documento).Position()).Delete()
            Totales()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        'Try
        If documento.Rows.Count = 0 Then
            MessageBox.Show("No Seleccionó Facturas para Afectar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Val(txtid_cliente.Text) = 0 Then
            MessageBox.Show("Debe Escribir un Código de cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid_cliente.Focus()
            pbid_cliente.Visible = True
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If

        If Cliente_ID <> txtid_cliente.Text Then
            MessageBox.Show("Escriba de Nuevo el Código del Cliente y Presione Enter", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid_cliente.Focus()
            SendKeys.Send("{home}+{end}")
            pbid_cliente.Visible = True
            Exit Sub
        End If

        If documento.Rows.Count = 0 Then
            MessageBox.Show("No selecciono Ninguna Factura", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Val(txtnumero.Text) = 0 Then
            MessageBox.Show("Debe Escribir un número de recibo", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtnumero.Focus()
            pbnumero.Visible = True
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If

        Dim rec As DataTable = Table("select id_recibo from recibo where id_recibo=" + txtnumero.Text, "")

        If rec.Rows.Count > 0 Then
            MessageBox.Show("Número de recibo Ya Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtnumero.Focus()
            pbnumero.Visible = True
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If

        btnguardar.Enabled = False

        Dim NC As New DataTable
        NC = New DataTable("nc")

        Dim id_documento As DataColumn = New DataColumn("id_documento")
        id_documento.DataType = System.Type.GetType("System.Decimal")
        id_documento.DefaultValue = 0
        NC.Columns.Add(id_documento)

        Dim monto As DataColumn = New DataColumn("monto")
        monto.DataType = System.Type.GetType("System.Decimal")
        monto.DefaultValue = 0
        NC.Columns.Add(monto)


        Dim DOC As New DataTable
        DOC = New DataTable("doc")

        Dim Did_documento As DataColumn = New DataColumn("id_documento")
        Did_documento.DataType = System.Type.GetType("System.Decimal")
        Did_documento.DefaultValue = 0
        DOC.Columns.Add(Did_documento)

        Dim Dmonto As DataColumn = New DataColumn("monto")
        Dmonto.DataType = System.Type.GetType("System.Decimal")
        Dmonto.DefaultValue = 0
        DOC.Columns.Add(Dmonto)

        Dim APLICADO As DataColumn = New DataColumn("aplicado")
        APLICADO.DataType = System.Type.GetType("System.Decimal")
        APLICADO.DefaultValue = 0
        DOC.Columns.Add(APLICADO)

        Dim id_nc As DataColumn = New DataColumn("id_nc")
        id_nc.DataType = System.Type.GetType("System.Decimal")
        id_nc.DefaultValue = 0
        DOC.Columns.Add(id_nc)


        Dim z As Integer
        Dim I As Integer

        For z = 0 To Documento.Rows.Count - 1
            If Documento.Rows(z).Item("monto") < 0 Then
                NC.ImportRow(Documento.Rows(z))
            Else
                DOC.ImportRow(Documento.Rows(z))
            End If
        Next

        Dim l As Integer = NC.Rows.Count
        Dim p As Integer = DOC.Rows.Count
        Dim Disp As Integer
        For z = 0 To NC.Rows.Count - 1
            Disp = NC.Rows(z).Item("monto") * -1
            For i = 0 To DOC.Rows.Count - 1
                With DOC.Rows(I)
                    .Item("id_nc") = NC.Rows(z).Item("id_documento")
                    If Disp > .Item("monto") Then
                        .Item("aplicado") = .Item("monto")
                        Disp = Disp - .Item("monto")
                        .Item("monto") = 0
                    Else
                        .Item("aplicado") = Disp
                        .Item("monto") = .Item("monto") - Disp
                        Exit For
                    End If
                End With
            Next
        Next

        Dim cmd As New SqlCommand
        cmd.Connection = CONN1
        Dim sql As String


        sql = "insert into recibo (id_recibo,fecha,fecha_documento,id_cliente,forma_pago,referencia,id_usuario,id_caja,motivo,anterior) values (" + _
        txtnumero.Text + "," + _
        "'" + EDATE(Date.Today.ToShortDateString) + "'," + _
        "'" + EDATE(Dtpfecha.Text) + "'," + _
        txtid_cliente.Text + "," + _
       (cbforma_pago.SelectedIndex + 1).ToString + "," + _
        "'" + txtreferencia.Text + "'," + _
        USUARIO_ID + "," + _
        "0" + "," + _
        "'" + txtmotivo.Text + "'," + _
        ANTERIOR.ToString() + ")"

        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        ReciboID = txtnumero.Text

        For I = 0 To DOC.Rows.Count - 1
            With DOC.Rows(I)
                sql = "insert into recibo_detalle (id_recibo,id_factura,abono) values (" + _
                ReciboID + "," + _
                .Item("id_documento").ToString + "," + _
                .Item("monto").ToString + ")"

                cmd.CommandText = sql
                cmd.ExecuteNonQuery()

                If .Item("aplicado") > 0 Then
                    sql = "insert into nota_credito_detalle (id_nota_credito,id_factura,fecha,aplicado) values (" + _
                    .Item("id_nc").ToString + "," + _
                    .Item("id_documento").ToString + "," + _
                    "'" + EDATE(Date.Today.ToShortDateString) + "'," + _
                    .Item("aplicado").ToString + ")"

                    cmd.CommandText = sql
                    cmd.ExecuteNonQuery()
                End If
            End With
        Next
        'Me.Close()
        If MsgBox("Desea Imprimir el Recibo?", MsgBoxStyle.YesNo, "Sistema Facturacion") = MsgBoxResult.Yes Then
            imprimir()
        Else
            Me.Close()
        End If
        ' Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try

    End Sub

    Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
        'Try
        If Documento.Rows.Count = 0 Then
            MessageBox.Show("Nada que Modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If dtgdocumento.Item("monto", dtgdocumento.CurrentRow.Index).Value < 0 Then
            MessageBox.Show("Documento No se Puede Modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim recibo_mantenimiento As New frm_recibo_mantenimiento
        recibo_mantenimiento.Owner = Me
        With recibo_mantenimiento
            Dim row As DataRow = Documento.Rows(BindingContext(Documento).Position())
            Dim rowf As DataRow = Factura.Rows.Find(row("id_documento"))
            .Owner = Me
            .lblid_factura.Text = row("id_documento")
            .lblsaldo.Text = FormatNumber(rowf("saldo"), 2)
            .Show()
        End With
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub imprimir()
        Dim rfactura As New rpt_recibo

        rParameterFieldDefinitions = rfactura.DataDefinition.ParameterFields


        rParameterFieldLocation = rParameterFieldDefinitions.Item("dia")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = Dtpfecha.Value.Day.ToString()
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("mes")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = Dtpfecha.Value.Month.ToString()
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("anio")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = Dtpfecha.Value.Year.ToString()
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("factura")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = txtmotivo.Text
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("cliente")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = txtid_cliente.Text & " - " & lblnombre_cliente.Text
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("recibo")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = txtnumero.Text
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("monto")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = " ¢ " & lbltotal.Text
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("anterior")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = " ¢ " & FormatNumber(ANTERIOR, 2)
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("abono")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = " ¢ " & FormatNumber(lbltotal.Text, 2)
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("saldo")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = " ¢ " & FormatNumber(Val(ANTERIOR - lbltotal.Text), 2)
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rfactura.PrintOptions.PrinterName = PrinterServer
        rfactura.PrintToPrinter(1, False, 1, 1)

        'Dim rv As New frm_Report_Viewer
        'rv.crv.ReportSource = rfactura
        'rv.Show()

        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
        Me.Close()
    End Sub


    Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'imprimir()
    End Sub



    Private Sub txtreferencia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtreferencia.KeyPress
        e.Handled = chk(Asc(e.KeyChar))
    End Sub

   
    Private Sub txtreferencia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreferencia.TextChanged

    End Sub

    Private Sub txtid_cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_cliente.TextChanged

    End Sub

    Private Sub btnnc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnc.Click
        Dim nc As New frm_nota_credito_buscar
        nc.Owner = Me
        nc.Show()
    End Sub

    Private Sub txtnumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumero.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{tab}")
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtnumero.Text, False)
        End If
    End Sub

    Private Sub btnimprimir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
        imprimir()
    End Sub

    Private Sub btnprovisional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprovisional.Click
        'Try
        If Documento.Rows.Count = 0 Then
            MessageBox.Show("No Seleccionó Facturas para Afectar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Val(txtnumero.Text) = 0 Then
            MessageBox.Show("Debe Escribir un número de recibo", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtnumero.Focus()
            pbnumero.Visible = True
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If

        If (MsgBox("Esta acción no afectará el saldo del cliente. ¿Desea continuar?", MsgBoxStyle.YesNo, "Recibo Provisional") = MsgBoxResult.Yes) Then
            imprimir()
        End If
    End Sub
End Class