Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_rpt_venta_producto_opciones
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

    Private Sub frm_rpt_venta_producto_opciones_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        myForms.frm_reportes_admin.btnaceptar.Enabled = True
    End Sub

    Private Sub frm_rpt_venta_producto_opciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CB_crear(cbid_familia, "familia", "id_familia")
        cbid_familia.Items.Insert(0, "Todas")
        cbid_familia.SelectedIndex = 0

        CB_crear(cbid_Proveedor, "Proveedor", "id_proveedor")
        cbid_Proveedor.Items.Insert(0, "Todos")
        cbid_Proveedor.SelectedIndex = 0
    End Sub
    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        btnaceptar.Enabled = False
        Dim C1 As String = ""
        Dim C2 As String = ""
        C1 = " fecha>='" + EDATE(Dtpdesde.Text) + "' and fecha<='" + EDATE(dtphasta.Text) + "'"


        If Val(txtid_producto.Text) > 0 Then
            C2 = " Producto.id_producto = " + txtid_producto.Text
        Else

            If cbid_Proveedor.SelectedIndex > 0 Then
                C2 = " producto.id_proveedor=" + cbid(cbid_Proveedor.Text)
            End If

            If cbid_familia.SelectedIndex > 0 Then
                C2 = C2 + IIf(C2 = "", "", " and ") + " producto.id_familia=" + cbid(cbid_familia.Text)
            End If
        End If





        VVP = FACP(C1, C2)
        Dev = DEVP(C1, C2)
        Dim z As Integer
        For z = 0 To Dev.Rows.Count - 1
            VVP.ImportRow(Dev.Rows(z))
        Next

        'Dim tt As DataTable
        'For z = 0 To VVP.Rows.Count - 1
        '    tt = Table("select precio1 from producto where id_producto = " & VVP.Rows(z).Item("id_producto"), "")
        '    VVP.Rows(z).Item("costo") = VVP.Rows(z).Item("cantidad").ToString * tt.Rows(0).Item(0).ToString
        'Next


        Dim rVP As New rpt_venta_producto

        rVP.SetDataSource(VVP)


        rParameterFieldDefinitions = rVP.DataDefinition.ParameterFields

        rParameterFieldLocation = rParameterFieldDefinitions.Item("rango")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = "Del " + Dtpdesde.Text + " al " + dtphasta.Text
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("proveedor")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = "Proveedor: " + cbid_Proveedor.Text
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)


        rParameterFieldLocation = rParameterFieldDefinitions.Item("familia")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = "Familia: " + cbid_familia.Text
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)

        rParameterFieldLocation = rParameterFieldDefinitions.Item("negocio")
        rParameterValues = rParameterFieldLocation.CurrentValues
        rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
        rParameterDiscreteValue.Value = NEGOCIO
        rParameterValues.Add(rParameterDiscreteValue)
        rParameterFieldLocation.ApplyCurrentValues(rParameterValues)




        Dim rv As New frm_Report_Viewer
        rv.crv.ReportSource = rVP
        rv.Text = "Venta Producto"
        rv.Show()
        btnaceptar.Enabled = True

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
                BUSQUEDA = "venta_producto"
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