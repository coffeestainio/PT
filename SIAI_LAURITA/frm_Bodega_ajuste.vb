Imports System.Data.SqlClient
Public Class frm_Bodega_ajuste
    Public Bodega As DataTable
    Public Ajuste As DataTable
    Public Producto As DataTable

    Private Sub frm_ajuste_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            CONN1.Close()
            myForms.frm_principal.ToolStrip.Enabled = True
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub


    Private Sub frm_ajuste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try

        Ajuste = New DataTable("Ajuste")

        Dim id_producto As DataColumn = New DataColumn("id_producto")
        id_producto.DataType = System.Type.GetType("System.Int32")
        Ajuste.Columns.Add(id_producto)

        Dim cantidad As DataColumn = New DataColumn("cantidad")
        cantidad.DataType = System.Type.GetType("System.Decimal")
        Ajuste.Columns.Add(cantidad)

        Dim Nombre As DataColumn = New DataColumn("nombre")
        Nombre.DataType = System.Type.GetType("System.String")
        Ajuste.Columns.Add(Nombre)

        Dim presentacion As DataColumn = New DataColumn("presentacion")
        presentacion.DataType = System.Type.GetType("System.String")
        Ajuste.Columns.Add(presentacion)

        Dim tipo As DataColumn = New DataColumn("tipo")
        tipo.DataType = System.Type.GetType("System.String")
        Ajuste.Columns.Add(tipo)

        Dim observaciones As DataColumn = New DataColumn("observaciones")
        observaciones.DataType = System.Type.GetType("System.String")
        Ajuste.Columns.Add(observaciones)

        Ajuste.PrimaryKey = New DataColumn() {Ajuste.Columns("id_producto")}

        dtgajuste.DataSource = Ajuste
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try

    End Sub

    Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
        'Try
        If Ajuste.Rows.Count = 0 Then
            MessageBox.Show("Nada que Eliminar ", "", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Dim row As DataRow = Ajuste.Rows(BindingContext(Ajuste).Position())
        Dim res As DialogResult = MessageBox.Show("Eliminar " + row("nombre"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If res = Windows.Forms.DialogResult.Yes Then
            row.Delete()
        End If
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub btnicluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnicluir.Click
        'Try
        Dim ajuste_mantenimiento As New frm_Bodega_Ajuste_mantenimiento
        myForms.frm_Bodega_Ajuste_mantenimiento = ajuste_mantenimiento
        myForms.frm_Bodega_Ajuste_mantenimiento.Owner = Me
        With myForms.frm_Bodega_Ajuste_mantenimiento

            If CONN1.State = ConnectionState.Closed Then CONN1.Open()
            .cbtipo.SelectedIndex = 0
            .Owner = Me
            .Show()
        End With
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        'Try
        btnguardar.Enabled = False
        If Ajuste.Rows.Count = 0 Then
            MessageBox.Show("No Hay Ajustes que Aplicar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim cmd As New SqlCommand
        cmd.Connection = CONN1
        Dim sql As String
        Dim z As Integer
        For z = 0 To Ajuste.Rows.Count - 1
            With Ajuste.Rows(z)
                sql = "insert into Bodega_ajuste (tipo,id_producto,cantidad,id_usuario,fecha,observaciones) values (" + _
                IIf(.Item("tipo") = "Entrada", "0", "1") + "," + _
                .Item("id_producto").ToString + "," + _
                .Item("cantidad").ToString + "," + _
                USUARIO_ID + "," + _
                "'" + EDATE(Date.Today.ToShortDateString) + "'," + _
                "'" + .Item("observaciones") + "')"

                cmd.CommandText = sql
                cmd.ExecuteNonQuery()

                'se quito la modificacion del campo existencia en la base de datos

                'sql = "update producto set " + _
                '"existencia=existencia" + IIf(.Item("tipo") = "Entrada", "+", "-") + .Item("cantidad").ToString + _
                '" where id_producto=" + .Item("id_producto").ToString

                'cmd.CommandText = sql
                'cmd.ExecuteNonQuery()

            End With
        Next
        Me.Close()
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub lbltitulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltitulo.Click

    End Sub
End Class