Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_rpt_bodega_existencia_opciones
    Dim VVP As DataTable
    Dim Dev As DataTable
    Dim Facs As DataTable
    Public Producto As DataTable
    Public Proveedor As DataTable
    Public familia As DataTable

    Dim rowprv As DataRow
    Dim rowl As DataRow
    Dim rowprd As DataRow

    Dim rParameterDiscreteValue As ParameterDiscreteValue
    Dim rParameterFieldDefinitions As ParameterFieldDefinitions
    Dim rParameterFieldLocation As ParameterFieldDefinition
    Dim rParameterValues As ParameterValues

    Const AR As String = " AND NOT EXISTS ( SELECT * FROM ildi_inventa.dbo.Reversion  WHERE ildi_inventa.dbo.reversion.Tipo = 2 and ildi_inventa.dbo.reversion.id_documento=ildi_inventa.dbo.bodega_ajuste.id_bodega_ajuste)"
    Const MR As String = " AND NOT EXISTS ( SELECT * FROM ildi_inventa.dbo.Reversion  WHERE ildi_inventa.dbo.reversion.Tipo = 4 and ildi_inventa.dbo.reversion.id_documento=ildi_inventa.dbo.bodega_movimiento.id_bodega_movimiento)"

    Private Sub frm_rpt_bodega_existencia_opciones_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        myForms.frm_reportes_admin.Enabled = True
    End Sub

  

    Private Sub frm_rpt_venta_producto_opciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            CB_crear(cbid_familia, "familia", "id_familia")
            cbid_familia.Items.Insert(0, "TODAS")
            cbid_familia.SelectedIndex = 0

        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        btnaceptar.Enabled = False

        Dim rbe As New rpt_bodega_existencia
        Dim producto As String = ""
        Dim TFP As DataTable



        TFP = Table("select id_producto, nombre, existencia = 0  from producto where eliminado = 0 " & IIf(cbid_familia.SelectedIndex > 0, " and producto.id_familia = " & numval(cbid_familia.Text, True) & " ", " ") & _
                    IIf(txtid_producto.Text.Trim = "", "", " and id_producto = " & txtid_producto.Text) & _
                    "union all" & _
                    " select producto.id_producto, producto.nombre, sum(factura_detalle.cantidad *-1) as existencia from factura_detalle " & _
                    "inner join producto on producto.id_producto = factura_detalle.id_producto " & _
                    "where id_factura not in (select id_documento as id_factura from reversion where tipo = 2) " & _
                    "and id_factura in (select id_factura from factura where fecha < '" & EDATE(dtphasta.Text) & " 11:59:00 pm') " & _
                     IIf(txtid_producto.Text.Trim = "", "", " and factura_detalle.id_producto = " & txtid_producto.Text) & _
                     IIf(cbid_familia.SelectedIndex > 0, " and producto.id_familia = " & numval(cbid_familia.Text, True) & " ", " ") & _
                     "and producto.eliminado = 0 " & _
                    " group by producto.nombre, producto.id_producto " & _
                    "UNION ALL select producto.id_producto, producto.nombre, sum(devolucion_detalle.cantidad) as existencia from devolucion_detalle " & _
                    "inner join producto on producto.id_producto = devolucion_detalle.id_producto " & _
                    "where id_devolucion in (select id_devolucion from devolucion where fecha < '" & EDATE(dtphasta.Text) & " 11:59:00 pm') " & _
                    IIf(txtid_producto.Text.Trim = "", "", " and devolucion_detalle.id_producto =  " & txtid_producto.Text) & _
                      IIf(cbid_familia.SelectedIndex > 0, " and producto.id_familia = " & numval(cbid_familia.Text, True) & " ", " ") & _
                     "and producto.eliminado = 0 " & _
                    "group by producto.nombre, producto.id_producto " & _
                    " UNION ALL select producto.id_producto, producto.nombre, sum(case when bodega_ajuste.tipo = 0 then (bodega_ajuste.cantidad) else " & _
                    " (bodega_ajuste.cantidad * -1) end) as existencia from bodega_ajuste  " & _
                    " inner join producto on producto.id_producto = bodega_ajuste.id_producto " & _
                    " where bodega_ajuste.fecha < '" & EDATE(dtphasta.Text) & " 11:59:00 pm' " & _
                    IIf(txtid_producto.Text.Trim = "", "", " and bodega_ajuste.id_producto = " & txtid_producto.Text) & _
                      IIf(cbid_familia.SelectedIndex > 0, " and producto.id_familia = " & numval(cbid_familia.Text, True) & " ", " ") & _
                     "and producto.eliminado = 0 " & _
                    " group by producto.nombre, producto.id_producto " & _
                    " order by producto.id_producto", "")


        Dim costo As DataColumn = New DataColumn("costo")
        costo.DataType = System.Type.GetType("System.Decimal")
        TFP.Columns.Add(costo)

        Dim monto As DataColumn = New DataColumn("monto")
        monto.DataType = System.Type.GetType("System.Decimal")
        TFP.Columns.Add(monto)

        Dim familia As DataColumn = New DataColumn("familia")
        familia.DataType = System.Type.GetType("System.String")
        TFP.Columns.Add(familia)

        Dim tt As DataTable
        Dim i As Integer
        For i = 0 To TFP.Rows.Count - 1
            tt = Table("select costo, familia.nombre as familia, familia.id_familia  from producto " & _
                        " inner join familia on familia.id_familia = producto.id_familia where id_producto = " & TFP.Rows(i).Item("id_producto"), "")

            TFP.Rows(i).Item("familia") = tt.Rows(0).Item("id_familia") & " - " & tt.Rows(0).Item("familia")
            TFP.Rows(i).Item("costo") = tt.Rows(0).Item("costo")
            TFP.Rows(i).Item("monto") = tt.Rows(0).Item("costo") * TFP.Rows(i).Item("existencia")
        Next

        rbe.SetDataSource(TFP)

        rParameterFieldDefinitions = rbe.DataDefinition.ParameterFields


        rParameterFieldLocation = rParameterFieldDefinitions.Item("rango1")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = " al " + dtphasta.Text
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


        rParameterFieldLocation = rParameterFieldDefinitions.Item("familia")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = "Familia: " + cbid_familia.Text
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


        Dim rv As New frm_Report_Viewer
        rv.crv.ReportSource = rbe
        rv.Text = "Bodega Existencia"
        rv.Show()
        btnaceptar.Enabled = True

        Me.Close()

    End Sub



    Public Sub Producto_identificar()
        ' Try
        '
        Producto = Table("select * from producto where id_producto=" + txtid_producto.Text, "")

        If Producto.Rows.Count = 0 Then
            MessageBox.Show("Producto no Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If
        rowprd = Producto.Rows(0)
        lblproducto_nombre.Text = rowprd("nombre")
        SendKeys.Send("{tab}")
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub



    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub txtid_producto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid_producto.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            If Val(txtid_producto.Text) = 0 Then
                SendKeys.Send("{tab}")
            Else
                Producto_identificar()
            End If
        Else
            If Not IsNumeric(Convert.ToChar(e.KeyChar)) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
                BUSQUEDA = "bodega_existencia"
                Dim producto_buscar As New frm_producto_buscar
                producto_buscar.Owner = Me
                producto_buscar.Show()
                producto_buscar.txtbuscar_producto.Text = e.KeyChar
            Else
                e.Handled = Numerico(Asc(e.KeyChar), txtid_producto.Text, False)
            End If
        End If
    End Sub

    Private Sub txtid_producto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_producto.TextChanged

    End Sub
End Class