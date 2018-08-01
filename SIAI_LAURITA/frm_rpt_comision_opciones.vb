Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_rpt_comision_opciones
    Dim rParameterDiscreteValue As ParameterDiscreteValue
    Dim rParameterFieldDefinitions As ParameterFieldDefinitions
    Dim rParameterFieldLocation As ParameterFieldDefinition
    Dim rParameterValues As ParameterValues
    Dim Criterio As String

    Private Sub frm_rpt_comision_opciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CB_crear(cbid_agente, "Agente", "id_Agente")
        cbid_agente.Items.Insert(0, "TODOS")
        cbid_agente.SelectedIndex = 0
        cbreporte.SelectedIndex = 0
    End Sub


    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Me.btnaceptar.Enabled = False
        If cbreporte.SelectedIndex = 0 Then
            COMISION_GENERADA()
        Else
            comision_cobro()
        End If
        Me.btnaceptar.Enabled = True
    End Sub
    Private Sub COMISION_COBRO()
        Dim rcomisionc As New rpt_comision_cobro
        Dim Recd As DataTable
        Dim Comg As DataTable
        Dim FM As DataTable

        Dim sql As String
        Dim P As Decimal

        If cbid_agente.SelectedIndex = 0 Then
            sql = "SELECT Recibo_Detalle.id_recibo, recibo_detalle.id_factura,Recibo_Detalle.abono, Recibo.fecha" + _
            " FROM Recibo_Detalle INNER JOIN Recibo ON Recibo_Detalle.id_recibo = Recibo.id_recibo" + _
            " and NOT EXISTS (SELECT * FROM Reversion  WHERE reversion.Tipo = 4 and reversion.id_documento=recibo.id_recibo)" + _
            " AND fecha>='" + EDATE(Dtpdesde.Text) + "' and fecha<='" + EDATE(dtphasta.Text) + "'"
        Else
            sql = "SELECT Recibo_Detalle.id_recibo, recibo_detalle.id_factura,Recibo_Detalle.abono, Recibo.fecha" + _
            " FROM Recibo_Detalle INNER JOIN Recibo ON Recibo_Detalle.id_recibo = Recibo.id_recibo" + _
            " and NOT EXISTS (SELECT * FROM Reversion  WHERE reversion.Tipo = 4 and reversion.id_documento=recibo.id_recibo)" + _
            " AND fecha>='" + EDATE(Dtpdesde.Text) + "' and fecha<='" + EDATE(dtphasta.Text) + "'" + _
            " inner join factura on recibo_detalle.id_factura=factura.id_factura and factura.id_agente=" + cbid(cbid_agente.Text)
        End If

        Recd = Table(sql, "")

        Dim nombre As DataColumn = New DataColumn("nombre")
        nombre.DataType = System.Type.GetType("System.String")
        Recd.Columns.Add(nombre)

        Dim id_agente As DataColumn = New DataColumn("id_agente")
        id_agente.DataType = System.Type.GetType("System.Int32")
        Recd.Columns.Add(id_agente)


        Dim comision As DataColumn = New DataColumn("comision")
        comision.DataType = System.Type.GetType("System.Decimal")
        Recd.Columns.Add(comision)



        For z As Integer = 0 To Recd.Rows.Count - 1
            With Recd.Rows(z)
                Comg = COMISIONG("factura.id_factura=" + .Item("id_factura").ToString)
                FM = FACM("factura.id_factura=" + .Item("id_factura").ToString, True, "")
                P = .Item("abono") / FM.Rows(0).Item("monto")
                .Item("comision") = Comg.Rows(0).Item("comision") * P
                .Item("ID_AGENTE") = Comg.Rows(0).Item("id_agente")
                .Item("nombre") = Comg.Rows(0).Item("nombre")
            End With
        Next

        rcomisionc.SetDataSource(Recd)

        rParameterFieldDefinitions = rcomisionc.DataDefinition.ParameterFields

        rParameterFieldLocation = rParameterFieldDefinitions.Item("rango")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = "Del " + Dtpdesde.Text + " al " + dtphasta.Text
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


        rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = NEGOCIO
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



        Dim rv As New frm_Report_Viewer
        rv.crv.ReportSource = rcomisionc
        rv.Text = "Comisión Cobro"
        rv.Show()
    End Sub
    Private Sub COMISION_GENERADA()
        Dim factura As DataTable
        Dim rcomisiong As New rpt_comision_generada
        Criterio = "factura.fecha>='" + EDATE(Dtpdesde.Text) + "' and factura.fecha<='" + EDATE(dtphasta.Text) + "'" + IIf(cbid_agente.SelectedIndex = 0, "", " and id_agente=" + cbid(cbid_agente.Text))
        factura = COMISIONG(Criterio)


        rcomisiong.SetDataSource(factura)

        rParameterFieldDefinitions = rcomisiong.DataDefinition.ParameterFields

        rParameterFieldLocation = rParameterFieldDefinitions.Item("rango")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = "Del " + Dtpdesde.Text + " al " + dtphasta.Text
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


        rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = NEGOCIO
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



        Dim rv As New frm_Report_Viewer
        rv.crv.ReportSource = rcomisiong
        rv.Text = "Comisión Generada"
        rv.Show()
    End Sub
End Class