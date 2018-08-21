Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_rpt_venta_producto_cliente_opciones
    Dim VVP As DataTable
    Dim Producto As DataTable
    Dim Cliente As DataTable
    Dim Proveedor As DataTable
    Dim Familia As DataTable
    Dim rowl As DataRow
    Dim rowprv As DataRow
    Dim rowc As DataRow
    Dim rowprd As DataRow
    Dim identifica As Boolean = False

    Dim rParameterDiscreteValue As ParameterDiscreteValue
    Dim rParameterFieldDefinitions As ParameterFieldDefinitions
    Dim rParameterFieldLocation As ParameterFieldDefinition
    Dim rParameterValues As ParameterValues

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If identifica = True Then
            btnaceptar.Enabled = False
            Dim i As Integer
            Dim C1 As String = ""
            Dim C2 As String = ""


            C1 = "fecha>='" + EDATE(Dtpdesde.Text) + " 00:00:00' and fecha<='" + EDATE(dtphasta.Text) + " 23:59:59'"

            If cbid_grupo.SelectedIndex > 0 Then
                Dim c As DataTable = Table("select id_cliente from cliente where id_grupo=" + cbid(cbid_grupo.Text), "")
                For i = 0 To c.Rows.Count - 1
                    With c.Rows(i)
                        If i = 0 Then
                            C1 = C1 + " and  (id_cliente=" + .Item("id_cliente").ToString
                        Else
                            C1 = C1 + " or id_cliente=" + .Item("id_cliente").ToString
                        End If
                    End With
                Next
                C1 = C1 + ")"

            Else
                If txtid_cliente.Text <> "" Then
                    C1 = C1 + "and id_cliente=" + rowc("id_cliente").ToString
                End If
            End If



            If cbid_familia.SelectedIndex > 0 Then
                C2 = " producto.id_familia=" + cbid(cbid_familia.Text)
            End If

            If Val(txtid_producto.Text) > 0 Then
                C2 = IIf(C2 = "", "", " and ") + " Producto.id_producto = " + txtid_producto.Text
            End If



            VVP = FACP(C1, C2)



            Dim Dev As DataTable = DEVP(C1, C2)
            Dim z As Integer
            For z = 0 To Dev.Rows.Count - 1
                VVP.ImportRow(Dev.Rows(z))
            Next

            Dim rVP As New rpt_Venta_Producto_cliente

            rVP.SetDataSource(VVP)


            rParameterFieldDefinitions = rVP.DataDefinition.ParameterFields

            rParameterFieldLocation = rParameterFieldDefinitions.Item("rango")
            rParameterValues = rParameterFieldLocation.CurrentValues
            rParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue
            rParameterDiscreteValue.Value = "Del " + Dtpdesde.Text + " al " + dtphasta.Text
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
        Else
            MsgBox("Debe digitar un código de cliente y presionar Enter")
        End If
    End Sub

    Private Sub frm_rpt_venta_producto_cliente_opciones_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        myForms.frm_reportes_admin.btnaceptar.Enabled = True
    End Sub

    Private Sub frm_rpt_venta_opciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CB_crear(cbid_familia, "Familia", "id_familia")
        cbid_familia.Items.Insert(0, "Todas")
        cbid_familia.SelectedIndex = 0
        CB_crear(cbid_grupo, "grupo", "id_grupo")


    End Sub

    Public Sub Identifica_cliente()
        ' Try

        Cliente = Table("select * from cliente where id_cliente=" + txtid_cliente.Text, "")
        If Cliente.Rows.Count = 0 Then
            MessageBox.Show("cliente no Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If
        rowc = Cliente.Rows(0)
        lblcliente_nombre.Text = rowc("nombre_comercial")
        SendKeys.Send("{tab}")
        identifica = True
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Public Sub Identifica_Producto()
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


    Private Sub txtid_cliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid_cliente.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            If Val(txtid_cliente.Text) = 0 Then
                SendKeys.Send("{tab}")
            Else
                Identifica_cliente()

            End If
        Else
            If Not IsNumeric(Convert.ToChar(e.KeyChar)) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
                BUSQUEDA = "venta_producto_cliente"
                Dim Cliente_buscar As New frm_cliente_buscar
                Cliente_buscar.Owner = Me
                Cliente_buscar.Show()
                Cliente_buscar.txtbuscar_cliente.Text = e.KeyChar
            Else
                e.Handled = Numerico(Asc(e.KeyChar), txtid_cliente.Text, False)
                identifica = False
            End If
        End If
    End Sub

    Private Sub txtid_producto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid_producto.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            If Val(txtid_producto.Text) = 0 Then
                SendKeys.Send("{tab}")

            Else
                Identifica_Producto()

            End If
        Else
            If Not IsNumeric(Convert.ToChar(e.KeyChar)) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
                BUSQUEDA = "venta_producto_cliente"
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

    Private Sub txtid_cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_cliente.TextChanged

    End Sub

    Private Sub txtid_proveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtid_familia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class