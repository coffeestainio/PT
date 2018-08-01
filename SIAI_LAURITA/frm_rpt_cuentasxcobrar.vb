Imports System.Data.sqlclient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_rpt_cuentasxcobrar
    Public V_Estado_Cuenta As DataTable
    Public cliente As DataTable
    Dim Vencido As Integer
    Dim Sinvencer As Integer
    Dim ClienteID As String
    Dim rowc As DataRow

    Public Sub Identifica_cliente()
        Try
            cliente = Table("select * from cliente where id_cliente=" + txtid_cliente.Text, False)

            If cliente.Rows.Count = 0 Then
                MessageBox.Show("Cliente no Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SendKeys.Send("{home}+{end}")
                Exit Sub
            End If
            rowc = cliente.Rows(0)
            ClienteID = rowc("id_cliente")
            lblnombre_cliente.Text = rowc("nombre_comercial")

            If chkgrupo.Checked Then
                Dim grupo As DataTable = Table("select * from grupo where id_cliente=" + rowc("id_grupo").ToString, "")
                lblgrupo.Text = grupo.Rows(0).Item("nombre")
            End If
            'SendKeys.Send("{tab}")

        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        'Try
        btnaceptar.Enabled = False


        Dim rParameterDiscreteValue As ParameterDiscreteValue
        Dim rParameterFieldDefinitions As ParameterFieldDefinitions
        Dim rParameterFieldLocation As ParameterFieldDefinition
        Dim rParameterValues As ParameterValues

        



        Dim nccriterio As String = ""
        Dim faccriterio As String = ""

        Dim fecha As String = ""
        If txtid_cliente.Text <> "" Then
            If ClienteID <> txtid_cliente.Text Then
                MessageBox.Show("Escriba de Nuevo el N�mero de cliente y Presione Enter", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtid_cliente.Focus()
                SendKeys.Send("{home}+{end}")
                btnaceptar.Enabled = True
                Exit Sub
            End If
            If rowc("id_grupo") > 1 And chkgrupo.Checked Then
                Dim c As DataTable = Table("select id_cliente from cliente where id_grupo=" + rowc("id_grupo").ToString, "")
                Dim i As Integer
                For i = 0 To c.Rows.Count - 1
                    With c.Rows(i)
                        If i = 0 Then
                            nccriterio = " (nota_credito.id_cliente=" + .Item("id_cliente").ToString
                            faccriterio = " (id_cliente=" + .Item("id_cliente").ToString
                        Else
                            nccriterio = nccriterio + " or nota_credito.id_cliente=" + .Item("id_cliente").ToString
                            faccriterio = faccriterio + " or id_cliente=" + .Item("id_cliente").ToString
                        End If
                    End With
                Next
            Else
                nccriterio = " (nota_credito.id_cliente=" + rowc("id_cliente").ToString + ")"
                faccriterio = " (CLIENTE.id_cliente=" + rowc("id_cliente").ToString + ")"

            End If
        End If

        If rbrango.Checked Then
            fecha = " (fecha>='" + EDATE(Dtpdesde.Text) + "' and fecha<='" + EDATE(dtphasta.Text) + "')"
        End If

        nccriterio = nccriterio + fecha
        faccriterio = faccriterio + fecha

        Dim Factura As DataTable


        Factura = FACS(faccriterio, "")
        Dim estado As DataColumn = New DataColumn("estado")
        estado.DataType = System.Type.GetType("System.Int16")
        Factura.Columns.Add(estado)


        Dim vencido As DataColumn = New DataColumn("vencido")
        vencido.DataType = System.Type.GetType("System.Decimal")
        Factura.Columns.Add(vencido)


        Dim sinvencer As DataColumn = New DataColumn("sinvencer")
        sinvencer.DataType = System.Type.GetType("System.Decimal")
        Factura.Columns.Add(sinvencer)

        Dim cliente_nombre As DataColumn = New DataColumn("cliente_nombre")
        cliente_nombre.DataType = System.Type.GetType("System.String")
        Factura.Columns.Add(cliente_nombre)



        Dim z As Integer
        For z = 0 To Factura.Rows.Count - 1
            With Factura.Rows(z)
                cliente = Table("select * from cliente where id_cliente=" + .Item("id_cliente").ToString, "")
                .Item("estado") = DateDiff("d", Date.Today, .Item("vence"))
                .Item("cliente_nombre") = cliente.Rows(0).Item("nombre_sociedad")
                If .Item("estado") > 0 Then
                    .Item("sinvencer") = .Item("saldo")
                Else
                    .Item("Vencido") = .Item("saldo")
                End If

            End With
        Next

        Dim nc As DataTable = NCDIS(nccriterio, "")
        Dim row As DataRow
        For h As Integer = 0 To nc.Rows.Count - 1
            With nc.Rows(h)
                row = Factura.NewRow
                row("id_factura") = .Item("id_nota_credito")
                row("id_cliente") = .Item("id_cliente")
                row("cliente_nombre") = .Item("nombre_sociedad")
                row("fecha") = .Item("fecha")
                row("saldo") = .Item("monto") * -1
                row("vencido") = .Item("monto") * -1
                Factura.Rows.Add(row)
            End With
        Next
        Dim rpendiente As ReportClass


        If CHKDETALLADO.Checked Then
            rpendiente = New rpt_Cuentasxcobrar

        Else
            rpendiente = New rpt_cuentasxcobrar_resumido
        End If


        rpendiente.SetDataSource(Factura)
        rParameterFieldDefinitions = rpendiente.DataDefinition.ParameterFields

        Dim r As String = ""
        If rbrango.Checked Then r = "Del " + Dtpdesde.Text + " al " + dtphasta.Text





        rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = NEGOCIO
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


        


        Dim rv As New frm_Report_Viewer

        rv.crv.ReportSource = rpendiente
        rv.Text = "Cuentas x Cobrar"
        rv.Show()

        btnaceptar.Enabled = True
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub frm_Pendiente_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            CONN1.Close()
            myForms.frm_principal.ToolStrip.Enabled = True
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub frm_Pendiente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CONN1.Open()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub



    Private Sub rbtodo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtodo.CheckedChanged
        If rbtodo.Checked Then
            grp1.Enabled = False
        End If
    End Sub

    Private Sub rbrango_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbrango.CheckedChanged
        If rbrango.Checked Then
            grp1.Enabled = True
        End If
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
                BUSQUEDA = "cuentasxcobrar"
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
End Class