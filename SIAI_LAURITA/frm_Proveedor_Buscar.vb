Public Class frm_Proveedor_Buscar
    Public DvProveedor As DataView


    Private Sub frm_Proveedor_Buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Select Case BUSQUEDA
                Case "Compra"
                    'DvProveedor = New DataView(myForms.frm_Compra.Proveedor)
                Case "rpt_producto_opciones"
                    DvProveedor = New DataView(myForms.frm_rpt_venta_producto_opciones.Proveedor)
            End Select
            DvProveedor.Sort = "nombre"
            dtgProveedor.DataSource = DvProveedor
            SendKeys.Send("{right}")
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub txtbuscar_Proveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar_Proveedor.TextChanged
        Try
            DvProveedor.RowFilter = "nombre Like '%" & txtbuscar_Proveedor.Text & "%'"
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub Asignar_id_Proveedor()
        Try
            Select Case BUSQUEDA
                'Case "Compra"
                'myForms.frm_Compra.txtid_proveedor.Text = dtgproveedor.Item("id_producto", dtgproveedor.CurrentRow.Index).Value
                'myForms.frm_Compra.Identifica_Proveedor()
                
            End Select
            Me.Close()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub dtgProveedor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgproveedor.Click
        Asignar_id_Proveedor()
    End Sub

    Private Sub dtgProveedor_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgproveedor.CellContentClick
        Asignar_id_Proveedor()
    End Sub
End Class