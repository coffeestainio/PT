Public Class frm_Familia_Buscar
    Public Dvlinea As DataView
    Private Sub frm_linea_Buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Select Case BUSQUEDA
                Case "rpt_producto_opciones"
                    Dvlinea = New DataView(myForms.frm_rpt_venta_producto_opciones.familia)
            End Select
            Dvlinea.Sort = "nombre"
            dtglinea.DataSource = Dvlinea
            SendKeys.Send("{right}")
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub



    Private Sub txtbuscar_linea_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar_familia.TextChanged
        Try
            Dvlinea.RowFilter = "nombre Like '%" & txtbuscar_familia.Text & "%'"
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub Asignar_id_linea()
        Try
            Select Case BUSQUEDA

            End Select
            Me.Close()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub dtglinea_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtglinea.Click
        Asignar_id_linea()
    End Sub

    Private Sub dtglinea_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtglinea.CellContentClick
        Asignar_id_linea()
    End Sub
End Class