Imports System.Data.SqlClient

Public Class frm_consulta_facelec
    Dim Documento As DataTable
    Dim Dvdocumento As DataView
    Dim TPD As DataTable
    Dim TDD As DataTable
    Dim criterio As String
    Dim tipo As String
    Dim Building As Boolean
    Dim rowc As DataRow
    Dim FIV As Decimal



    Dim cliente As DataTable
    Dim Agente As DataTable
    Dim Bodega As DataTable

    Private Sub frm_consulta_documento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CONN1.Close()
        myForms.frm_principal.ToolStrip.Enabled = True
    End Sub
    Private Sub frm_consulta_documento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        CONN1.Open()
        Building = True
        Documento_crear()
        Building = False
        Filtro()
        CONN1.Close()

        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub
    Private Sub Filtro()
        ' Try
        criterio = " and factura.fecha>='" + EDATE(dtpdesde.Text) + " 00:00:00' and factura.fecha<='" + EDATE(dtphasta.Text) + " 23:59:59'"

        Dim Factura As DataTable
        Factura = FACError(criterio, "")

        Documento_cargar(Factura)

        Dvdocumento = New DataView(Documento)
        Dvdocumento.Sort = "fecha, id_documento"
        dtgdocumento.DataSource = Dvdocumento
        'Catch myerror As Exception
        '(Me.Name, myerror)
        ' End Try
    End Sub


    Private Sub Documento_crear()

        Documento = New DataTable("documento")
        Dim id_documento As DataColumn = New DataColumn("id_documento")
        id_documento.DataType = System.Type.GetType("System.Int32")
        Documento.Columns.Add(id_documento)

        Dim fecha As DataColumn = New DataColumn("fecha")
        fecha.DataType = System.Type.GetType("System.DateTime")
        Documento.Columns.Add(fecha)

        Dim cliente As DataColumn = New DataColumn("id_cliente")
        cliente.DataType = System.Type.GetType("System.String")
        Documento.Columns.Add(cliente)

        Dim CodError As DataColumn = New DataColumn("CodigoError")
        CodError.DataType = System.Type.GetType("System.String")
        Documento.Columns.Add(CodError)

        Dim descError As DataColumn = New DataColumn("DescripcionError")
        descError.DataType = System.Type.GetType("System.String")
        Documento.Columns.Add(descError)

    End Sub

    Private Sub Documento_cargar(ByVal Tbl As DataTable)
        Try
            Dim rowd As DataRow
            Documento.Rows.Clear()
            Dim z As Integer
            For z = 0 To Tbl.Rows.Count - 1
                With Tbl.Rows(z)

                    rowd = Documento.NewRow

                    rowd("id_documento") = .Item("id_factura")
                    rowd("fecha") = .Item("fecha")
                    rowd("id_cliente") = .Item("id_cliente")
                    rowd("codigoError") = .Item("codigoError")
                    rowd("descripcionError") = .Item("descripcionError")
                    Documento.Rows.Add(rowd)
                End With
            Next
        Catch myerror As Exception
            MsgBox("Ocurrio un error al consultar las facturas", MsgBoxStyle.Exclamation)
            ONEX(Me.Name, myerror)
        End Try
    End Sub


    Private Sub dtpdesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpdesde.ValueChanged
        If Not Building Then Filtro()
    End Sub

    Private Sub dtphasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtphasta.ValueChanged
        If Not Building Then Filtro()
    End Sub

    Private Sub cbtipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Building Then Filtro()
    End Sub

    Private Sub btnReenviarFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReenviarFacturas.Click
        Try
            If Documento.Rows.Count > 0 Then
                If MsgBox("Desea reenviar las facturas?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    setFacturas()

                    EjectuarFacturacionElectronica()

                    CONN1.Close()
                    myForms.frm_principal.ToolStrip.Enabled = True

                End If
            Else
                MsgBox("No hay nada que reenviar")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub setFacturas()
        Try
            Dim cmd As New SqlCommand
            If CONN1.State = ConnectionState.Closed Then
                CONN1.Open()
            End If

            cmd.Connection = CONN1

            Dim sql As String = "update factura set sincronizada = 0 where id_factura in ("

            For Each factura As DataRow In Documento.Rows
                sql = sql & factura("id_documento").ToString & ","
            Next

            sql = sql & "000)"

            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            CONN1.Close()
        Catch ex As Exception
            MsgBox("Hubo un error al intentar reenviar las facturas", MsgBoxStyle.Information)
            ONEX(Me.Name, ex)

        End Try
    End Sub
End Class