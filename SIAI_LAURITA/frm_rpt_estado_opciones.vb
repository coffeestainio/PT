Imports System.Data.sqlclient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_rpt_estado_opciones
    Inherits System.Windows.Forms.Form
    Public V_Estado_Cuenta As DataTable
    Dim Cliente_ID As String
    Dim Vencido As Integer
    Dim Sinvencer As Integer
    Dim rowc As DataRow
    Dim criterio As String
    


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
                BUSQUEDA = "estado_cuenta"
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
        Try

            Dim cliente As DataTable = Table("select * from cliente where id_cliente=" + txtid_cliente.Text, "")
            If cliente.Rows.Count = 0 Then
                MessageBox.Show("Cliente no Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SendKeys.Send("{home}+{end}")
                Exit Sub
            End If
            rowc = cliente.Rows(0)
            lblnombre_cliente.Text = rowc("nombre_comercial")
            Dtpdesde.Focus()
            Cliente_ID = txtid_cliente.Text
            If chkgrupo.Checked Then
                Dim grupo As DataTable = Table("select * from grupo where id_grupo=" + rowc("id_grupo").ToString, "")
                lblgrupo.Text = grupo.Rows(0).Item("nombre")
            End If
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub frm_estado_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            CONN1.Close()
            myForms.frm_principal.ToolStrip.Enabled = True
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub frm_estado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CONN1.Open()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        'Try
        btnaceptar.Enabled = False
        If Val(txtid_cliente.Text) = 0 Then
            MessageBox.Show("Debe Escribir un Código de cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid_cliente.Focus()
            SendKeys.Send("{home}+{end}")
            btnaceptar.Enabled = True
            Exit Sub
        End If

        If Cliente_ID <> txtid_cliente.Text Then
            MessageBox.Show("Escriba de Nuevo el Número de cliente y Presione Enter", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid_cliente.Focus()
            SendKeys.Send("{home}+{end}")
            btnaceptar.Enabled = True
            Exit Sub
        End If

        Dim rParameterDiscreteValue As ParameterDiscreteValue
        Dim rParameterFieldDefinitions As ParameterFieldDefinitions
        Dim rParameterFieldLocation As ParameterFieldDefinition
        Dim rParameterValues As ParameterValues



        Dim Fecha As String = ""
        Dim criterionc As String = ""
        If rowc("id_grupo") > 1 And chkgrupo.Checked Then
            Dim c As DataTable = Table("select id_cliente from cliente where id_grupo=" + rowc("id_grupo").ToString, "")
            Dim i As Integer
            For i = 0 To c.Rows.Count - 1
                With c.Rows(i)
                    If i = 0 Then
                        criterio = "  (id_cliente=" + .Item("id_cliente").ToString
                        criterionc = "  (nota_credito.id_cliente=" + .Item("id_cliente").ToString
               
                    Else
                        criterio = "  (id_cliente=" + .Item("id_cliente").ToString
                        criterionc = "  (nota_credito.id_cliente=" + .Item("id_cliente").ToString
                    End If
                End With
            Next
        Else
            criterio = "id_cliente=" + rowc("id_cliente").ToString
            criterionc = " (nota_credito.id_cliente=" + rowc("id_cliente").ToString
        End If


        criterio = criterio + ")"
        criterionc = criterionc + ")"
        
        Fecha = " and (fecha>='" + EDATE(Dtpdesde.Text) + "' and fecha<='" + EDATE(dtphasta.Text) + "')"

        V_Estado_Cuenta = Table("select * from V_estado_cuenta", "")

        Dim Factura As DataTable
        Dim Recibo As DataTable
        Dim Notac As DataTable


        Factura = FACM("(factura." & criterio + Fecha, True, "")


        Recibo = RECM("(recibo." & criterio + Fecha, True, "")
        Notac = NCM(criterionc + Fecha, True, "")


        V_Estado_Cuenta_cargar(Factura, "Factura", 0)
        V_Estado_Cuenta_cargar(Recibo, "Recibo", 1)
        V_Estado_Cuenta_cargar(Notac, "Nota Crédito", 1)




        Dim Cmper As Decimal = 0
        Dim Dmper As Decimal = 0

        Dim z As Integer
        For z = 0 To V_Estado_Cuenta.Rows.Count - 1
            With V_Estado_Cuenta.Rows(z)
                If .Item("monto") < 0 Then
                    Cmper = Cmper + .Item("monto") * -1
                Else
                    Dmper = Dmper + .Item("monto")
                End If
            End With
        Next

        Dim restado As New rpt_estado


        restado.SetDataSource(V_Estado_Cuenta)
        rParameterFieldDefinitions = restado.DataDefinition.ParameterFields

        rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = NEGOCIO
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("cliente")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = "Cliente: " + txtid_cliente.Text + " - " + rowc("nombre_sociedad")
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("periodo")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = "del " + Dtpdesde.Text + " al " + dtphasta.Text
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("cper")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = FormatNumber(Cmper.ToString, 2)
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("dper")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = FormatNumber(Dmper.ToString, 2)
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("sant")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = 0
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("sact")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = 0
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        Dim rv As New frm_Report_Viewer

        rv.crv.ReportSource = restado
        rv.Text = "Estado de Cuenta"
        rv.Show()


        btnaceptar.Enabled = True
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub V_Estado_Cuenta_cargar(ByVal Tabla As DataTable, ByVal Des As String, ByVal Cr As Boolean)
        Dim reversion As DataTable
        Dim rowe As DataRow
        Dim z As Integer
        Dim Tipo As String = ""
        For z = 0 To Tabla.Rows.Count - 1
            With Tabla.Rows(z)
                rowe = V_Estado_Cuenta.NewRow
                rowe("fecha") = .Item("fecha")
                rowe("referencia") = ""

                Select Case Des
                    Case "Factura"
                        rowe("id_documento") = .Item("id_factura")
                        Tipo = "2"
                    Case "Recibo"
                        rowe("id_documento") = .Item("id_recibo")
                        Tipo = "4"
                    Case "Nota Crédito"
                        rowe("id_documento") = .Item("id_nota_credito")
                        Tipo = "6"
                        rowe("referencia") = .Item("observaciones")
                End Select


                rowe("descripcion") = Des
                rowe("monto") = .Item("monto") * IIf(Cr, -1, 1)

                V_Estado_Cuenta.Rows.Add(rowe)
                If .Item("anulado") Then
                    Dim Sql As String = "select * from reversion where tipo=" + Tipo + " and id_documento=" + rowe("id_documento").ToString
                    

                    reversion = Table(Sql, "")
                    With reversion.Rows(0)
                        rowe = V_Estado_Cuenta.NewRow
                        rowe("fecha") = .Item("fecha")
                        rowe("id_documento") = .Item("id_reversion")
                        rowe("descripcion") = "Reversión " + Des
                        rowe("monto") = Tabla.Rows(z).Item("monto") * IIf(Cr, 1, -1)
                        rowe("referencia") = "# " + .Item("id_documento").ToString
                        V_Estado_Cuenta.Rows.Add(rowe)
                    End With
                End If
            End With
        Next
    End Sub

    
    Private Sub txtid_cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_cliente.TextChanged

    End Sub
End Class