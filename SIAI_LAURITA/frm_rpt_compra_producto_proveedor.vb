Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_rpt_compra_producto_proveedor
    Dim VCP As DataTable
    Dim Producto As DataTable
    Dim Proveedor As DataTable
    Dim Familia As DataTable
    Dim rowl As DataRow
    Dim rowprv As DataRow
    Dim rowc As DataRow
    Dim rowprd As DataRow

    Dim rParameterDiscreteValue As ParameterDiscreteValue
    Dim rParameterFieldDefinitions As ParameterFieldDefinitions
    Dim rParameterFieldLocation As ParameterFieldDefinition
    Dim rParameterValues As ParameterValues

   
    Public Sub Producto_Identificar()
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

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        btnaceptar.Enabled = False
        Dim C1 As String = ""
        Dim C2 As String = ""


        C1 = "compra.fecha>='" + EDATE(Dtpdesde.Text) + "' and compra.fecha<='" + EDATE(dtphasta.Text) + "'"


        If cbid_proveedor.SelectedIndex > 0 Then
            C1 = C1 + " and compra.id_proveedor=" + cbid(cbid_proveedor.Text)
        End If


        
        If Val(txtid_producto.Text) > 0 Then
            C2 = " Producto.id_producto = " + txtid_producto.Text
        End If



        VCP = CACP(C1, C2)



        
        Dim rCP As New rpt_compra_producto_proveedor

        rCP.SetDataSource(VCP)


        rParameterFieldDefinitions = rCP.DataDefinition.ParameterFields

        rParameterFieldLocation = rParameterFieldDefinitions.Item("rango")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = "Del " + Dtpdesde.Text + " al " + dtphasta.Text
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)



        rParameterFieldLocation = rParameterFieldDefinitions.Item("Proveedor")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = "Proveedor: " + cbid_proveedor.Text
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = NEGOCIO
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)




        Dim rv As New frm_Report_Viewer
        rv.crv.ReportSource = rCP
        rv.Text = "Compra Producto"
        rv.Show()
        btnaceptar.Enabled = True

    End Sub

    Private Sub frm_rpt_venta_producto_proveedor_opciones_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        myForms.frm_reportes_admin.btnaceptar.Enabled = True
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
                BUSQUEDA = "compra_producto"
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

    Private Sub frm_rpt_compra_producto_proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CB_crear(cbid_proveedor, "proveedor", "id_proveedor")
        cbid_proveedor.Items.Insert(0, "TODOS")
        cbid_proveedor.SelectedIndex = 0

    End Sub
End Class