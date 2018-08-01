Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared



Public Class frm_Nota_Debito

    Dim rParameterDiscreteValue As ParameterDiscreteValue
    Dim rParameterFieldDefinitions As ParameterFieldDefinitions
    Dim rParameterFieldLocation As ParameterFieldDefinition
    Dim rParameterValues As ParameterValues

    Dim Fac As DataTable
    Dim cliente As DataTable
    Public frm(2) As String
    Public Fecha As String
    Dim FD As DataTable
    Dim Factura_ID As String
    Public NDID As Integer
    Public consulta As Boolean = True

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

    Public Sub Identifica_Factura()
        'Try

        Fac = FACM("factura.id_factura=" + txtid_factura.Text, True, "")

        If Fac.Rows.Count = 0 Then
            MessageBox.Show("Factura No Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid_factura.Focus()
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If

        With Fac.Rows(0)
            If .Item("anulado") Then
                MessageBox.Show("Factura Ya Anulada", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtid_factura.Focus()
                SendKeys.Send("{home}+{end}")
                Exit Sub
            End If

            cliente = Table("Select id_cliente,nombre_comercial from cliente where id_cliente=" + .Item("id_cliente").ToString, "")
            lblid_cliente.Text = .Item("id_cliente").ToString + " - " + cliente.Rows(0).Item("nombre_comercial")
            Factura_ID = txtid_factura.Text
            lblplazo.Text = .Item("plazo")
            lblfecha.Text = .Item("fecha")
            lblmonto.Text = FormatNumber(.Item("Monto").ToString, 2)
        End With
        SendKeys.Send("{tab}")
        'Catch myerror As Exception
        ' ONEX(Me.Name, myerror)
        ' End Try
    End Sub

    Private Sub Nota_Debito_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If CONN1.State = ConnectionState.Open Then CONN1.Close()
        Try
            myForms.frm_principal.ToolStrip.Enabled = True
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub Nota_Debito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If CONN1.State = ConnectionState.Closed Then CONN1.Open()
        frm(1) = "ORIGINAL -  CLIENTE"
        frm(2) = "COPIA - ARCHIVO"
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        'Try
        If Val(txtid_factura.Text) = 0 Then
            MessageBox.Show("Debe Escribir un Número de Factura", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid_factura.Focus()
            pbid_factura.Visible = True
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If

        If Val(txtnumero.Text) = 0 Then
            MessageBox.Show("Debe Escribir un Número de Nota de Crédito", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtnumero.Focus()
            pbnumero.Visible = True
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If

        If Val(txtmonto.Text) = 0 Then
            MessageBox.Show("Debe Escribir un Monto", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtmonto.Focus()
            pbmonto.Visible = True
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If
        If Factura_ID <> txtid_factura.Text Then
            MessageBox.Show("Escriba de Nuevo el Número de Factura y Presione Enter", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid_factura.Focus()
            pbid_factura.Visible = True
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If

        Dim R As DataTable = Table("select * from nota_Debito where id_documento = " & txtnumero.Text, "")
        If R.Rows.Count > 0 Then
            MessageBox.Show("Número de Nota de Débito ya Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim cmd As New SqlCommand
        cmd.Connection = CONN1
        Dim tt As DataTable

        sqlquery("insert into nota_debito (id_documento,observaciones,id_usuario, id_cliente) values (" & txtnumero.Text & ",'" & txtobservaciones.Text & "'," & USUARIO_ID & "," & cliente.Rows(0).Item("id_cliente") & ")")
        tt = Table("select @@identity as id from nota_Debito", "")
        sqlquery("insert into nota_debito_detalle (id_factura,id_nota_debito,monto) values (" & Factura_ID & "," & tt.Rows(0).Item(0) & "," & txtmonto.Text & ")")

        NDID = tt.Rows(0).Item(0)

        imprimir(1)
        imprimir(2)

        Me.Close()
        'Catch myerror As Exception
        '(Me.Name, myerror)
        'End Try

    End Sub

    Private Sub imprimir(ByVal doc As Integer)
        'Try

        Dim rnota_debito As New rpt_Nota_debito



        rParameterFieldDefinitions = rnota_debito.DataDefinition.ParameterFields

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



        rParameterFieldLocation = rParameterFieldDefinitions.Item("ncid")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = "Nota de Crédito:   " & NDID
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


        'rParameterFieldLocation = rParameterFieldDefinitions.Item("exento")
        'rParameterValues = rParameterFieldLocation.CurrentValues
        'rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        'rParameterDiscreteValue.Value = FormatNumber(Val(txtexento.Text), 2)
        'rParameterValues.Add(rParameterDiscreteValue)
        'rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        'rParameterFieldLocation = rParameterFieldDefinitions.Item("gravado")
        'rParameterValues = rParameterFieldLocation.CurrentValues
        'rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        'rParameterDiscreteValue.Value = FormatNumber(Val(txtgravado.Text), 2)
        'rParameterValues.Add(rParameterDiscreteValue)
        'rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        'rParameterFieldLocation = rParameterFieldDefinitions.Item("iv")
        'rParameterValues = rParameterFieldLocation.CurrentValues
        'rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        'rParameterDiscreteValue.Value = lbliv.Text
        'rParameterValues.Add(rParameterDiscreteValue)
        'rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


        rParameterFieldLocation = rParameterFieldDefinitions.Item("monto")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = FormatNumber(txtmonto.Text, 2)
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("observaciones")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = txtobservaciones.Text
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
        rParameterDiscreteValue.Value = frm(doc)
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("id_Factura")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = txtid_factura.Text
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


        rnota_debito.PrintOptions.PrinterName = PrinterServer
        rnota_debito.PrintToPrinter(1, False, 1, 1)

        'Dim rv As New frm_Report_Viewer
        'rv.crv.ReportSource = rnota_debito
        'rv.Show()

        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try


    End Sub



    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub txtid_factura_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_factura.TextChanged

    End Sub

    Private Sub txtnumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnumero.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{tab}")
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtnumero.Text, False)
        End If
    End Sub

    Private Sub txtnumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnumero.TextChanged

    End Sub

    Private Sub txtmonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmonto.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{tab}")
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtmonto.Text, False)
        End If
    End Sub


    Private Sub txtmonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmonto.TextChanged

    End Sub

    Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
        If chkoriginal.Checked Then imprimir(1)
        If chkcopia.Checked Then imprimir(2)
    End Sub
End Class