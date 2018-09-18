Imports System.Data.sqlclient
Imports System.math
Imports System.io


Module Module1

    'Public Const SERVER As String = "S1"
    'Public Const SERVER As String = "S1"
    'Public Const SERVER As String = "SQL01"
    Public Const SERVER As String = "Server=tcp:pt2.database.windows.net,1433;Initial Catalog=PT2;Persist Security Info=False;User ID=PTSQL;Password=SQLPT12345!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"

    Public Const PrinterServer As String = "\\SQL01\LASER"
    Public Const Version As String = "2.06.09.18"

    Public ID_ESTACION As String
    Public Path As String
    Public CONN1 As SqlConnection
    Dim cmd1 As New SqlCommand

    Public Const NEGOCIO As String = "PRODUCTOS TERMICOS, S.A."
    Public Const CJ As String = "Céd. Jur. 3-101-440551"
    Public Const TELEFONO As String = "Tel. 2288-2065   Fax. 2289-8818"
    Public Const DIRECCION As String = "Escazú, Costa Rica www.productostermicos.com"

    Public USUARIO_NOMBRE As String
    Public USUARIO_NIVEL As Integer
    Public USUARIO_ID As String
    Public USUARIO_PRECIO As Integer
    Public BUSQUEDA As String
    Public Consulta As Boolean
    Public Prst(3) As String

    Public Function numval(ByVal str As String, ByVal inicio As Boolean) As Integer
        Dim i As Integer = 0
        Dim aux As Integer
        If inicio = True Then
            While IsNumeric(str(i)) And (i <> str.Length - 1)
                aux = aux & str(i)
                i = i + 1
            End While
        Else
            i = Len(str) - 1
            While IsNumeric(str(i))
                aux = aux & str(i)
                i = i - 1
            End While
        End If
        Return aux
    End Function

    Public Sub EjectuarFacturacionElectronica()
        Process.Start("cmd", "/c dotnet c:/FacElec/FacElec.dll")
    End Sub

    Public Sub sqlquery(ByVal sql As String)
        Dim cmd As New SqlCommand
        cmd = New SqlClient.SqlCommand(sql, CONN1)
        cmd.CommandText = sql
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
    End Sub

    Friend Sub Tsort(ByRef DT As DataTable, ByVal OrderBy As String)
        Dim DTn As New DataTable
        Dim Rows() As DataRow
        Dim Row As DataRow

        DTn = DT.Clone
        Rows = DT.Select("", OrderBy)
        For Each Row In Rows
            DTn.ImportRow(Row)
        Next

        DT = DTn
    End Sub

    Public Sub dstable(ByVal dataset As DataSet, ByVal tabla_nombre As String, ByVal sql As String, ByVal Pk As String)
        Try
            Dim dr As SqlDataReader
            Dim drcmd As SqlCommand
            drcmd = New SqlCommand(sql, CONN1)
            dr = drcmd.ExecuteReader()
            Dim schemaTable As DataTable = dr.GetSchemaTable()
            Dim dataTable As DataTable = New DataTable(tabla_nombre)
            Dim intCounter As Integer

            For intCounter = 0 To schemaTable.Rows.Count - 1
                Dim dataRow As DataRow = schemaTable.Rows(intCounter)
                Dim columnName As String = CType(dataRow("ColumnName"), String)
                Dim column As DataColumn = New DataColumn(columnName, CType(dataRow("DataType"), Type))
                dataTable.Columns.Add(column)
            Next

            If Pk <> "" Then dataTable.PrimaryKey = New DataColumn() {dataTable.Columns(Pk)}
            dataset.Tables.Add(dataTable)

            While dr.Read()

                Dim dataRow As DataRow = dataTable.NewRow()

                For intCounter = 0 To dr.FieldCount - 1
                    dataRow(intCounter) = dr.GetValue(intCounter)
                Next
                dataTable.Rows.Add(dataRow)
            End While
            dr.Close()
        Catch myerror As Exception
            ONEX("dsTable", myerror)
        End Try
    End Sub

    Public Function EDATE(ByVal fecha As String) As String
        'Try
        Return fecha.Substring(3, 2) + "/" + fecha.Substring(0, 2) + "/" + fecha.Substring(6, 4)
        'Catch myerror As Exception
        'ONEX("edate", myerror)
        'Return "01/01/2000"
        'End Try
    End Function

    Public Sub AddParams(ByVal cmd As SqlCommand, ByVal ParamArray cols() As String)
        Try
            Dim col As String
            For Each col In cols
                cmd.Parameters.Add("@" + col, SqlDbType.Char, 0, col)
            Next
        Catch myerror As SqlException
            ONEX("AddParams", myerror)
        End Try
    End Sub


    Public Function FACS(ByVal C As String, ByVal Pk As String) As DataTable
        'Try
        Dim Fac As DataTable
        Dim Facx As DataTable
        Dim RecD As DataTable
        Dim Nc As DataTable
        Dim Nd As DataTable

        Dim Trec As Decimal
        Dim TNC As Decimal
        Dim TND As Decimal
        Dim Sld As Decimal

        Dim i As Integer
        Dim j As Integer

        Fac = FAC_S()
        Facx = FACM(C, False, Pk)

        'Dim xSaldo As DataColumn = New DataColumn("Saldo")
        'xSaldo.DataType = System.Type.GetType("System.Decimal")
        'xSaldo.DefaultValue = 0
        'Facx.Columns.Add(xSaldo)

        For i = 0 To Facx.Rows.Count - 1
            With Facx.Rows(i)
                '    'Recibo
                '    Trec = 0.0
                '    RecD = RECA(.Item("id_factura").ToString)
                '    For j = 0 To RecD.Rows.Count - 1
                '        With RecD.Rows(j)
                '            Trec = Trec + .Item("abono")
                '        End With
                '    Next j

                '    'Nota credito
                '    TNC = 0.0
                '    Nc = NCA("id_factura=" + .Item("id_factura").ToString, "")
                '    For j = 0 To Nc.Rows.Count - 1
                '        TNC = TNC + Nc.Rows(j).Item("aplicado")
                '    Next j

                '    'nota debito
                '    TND = 0.0
                '    Nd = NDA("id_factura=" + .Item("id_factura").ToString, "")
                '    For j = 0 To Nd.Rows.Count - 1
                '        TND = TND + Nd.Rows(j).Item("monto")
                '    Next j



                If .Item("saldo") > 0.1 Then
                    Fac.ImportRow(Facx.Rows(i))
                End If

            End With
        Next i

        Return Fac

        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Function

    Public Function FACM(ByVal C As String, ByVal Anulados As Boolean, ByVal PK As String) As DataTable
        Dim sql As String
        sql = "SELECT Factura.Id_Factura, Factura.FECHA, factura.fecha+factura.plazo as vence,Factura.Id_Cliente, CLIENTE.NOMBRE_comercial, factura.id_agente,Factura.Plazo, factura.piv," + _
        "SUM(CASE WHEN factura_detalle.iv = 0 THEN (Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD " + _
        " ELSE  0 END) AS exento," + _
         "SUM(CASE WHEN factura.id_cliente = 61 THEN ((Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD) * 0.95 " + _
        "WHEN factura.id_cliente <> 61 THEN ((Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD) " + _
        "ELSE 0 END) AS GRAVADO," + _
        "SUM(CASE WHEN factura.id_cliente = 61 THEN ((Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD) * 0.95 " + _
        "WHEN factura.id_cliente <> 61 THEN ((Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD) " + _
        "ELSE 0 END) AS SUBTOTAL," + _
        "SUM(CASE WHEN factura_detalle.iv = 1 and factura.id_cliente = 61 THEN ((Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD * FACTURA.PIV) * 0.95 " + _
        "WHEN factura_detalle.iv = 1 and factura.id_cliente <> 61 THEN ((Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD * FACTURA.PIV) " + _
        "ELSE 0 END) AS IV," + _
        "SUM(CASE WHEN factura_detalle.iv = 0 and factura.id_cliente = 61 " + _
        "THEN		((Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD ) * 0.95 " + _
        "WHEN factura_detalle.iv = 0 and factura.id_cliente <> 61 " + _
        "THEN		((Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD ) " + _
        "WHEN factura_detalle.iv = 1 and factura.id_cliente = 61 " + _
        "THEN		((Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento)* factura_detalle.cantidad * (1 + factura.piv)) * 0.95 " + _
        "WHEN factura_detalle.iv = 1 and factura.id_cliente <> 61 " + _
        "THEN		((Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento)* factura_detalle.cantidad * (1 + factura.piv)) " + _
        "END) AS MONTO, " + _
        "SUM(CASE WHEN factura_detalle.iv = 0 and factura.id_cliente = 61" + _
        "THEN		((Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD ) * 0.95 " + _
        "WHEN factura_detalle.iv = 0 and factura.id_cliente <> 61 " + _
        "THEN		((Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD )  " + _
        "WHEN factura_detalle.iv = 1 and factura.id_cliente = 61  " + _
        "THEN		((Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento)* factura_detalle.cantidad * (1 + factura.piv)) * 0.95" + _
        "WHEN factura_detalle.iv = 1 and factura.id_cliente <> 61  " + _
        "THEN		((Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento)* factura_detalle.cantidad * (1 + factura.piv))END)  " + _
        " - (select isnull(sum (R.abono),0) from recibo_Detalle as R where R.id_Factura = FACTURA.id_factura " + _
        " and R.id_Recibo not in (select id_documento as id_recibo from reversion where tipo = 4)) " + _
        " - (select isnull(sum (NC.aplicado),0) from nota_credito_Detalle as NC where NC.id_Factura = FACTURA.id_factura) as SALDO, " + _
        " CASE WHEN NOT EXISTS (SELECT * FROM Reversion WHERE reversion.Tipo = 2 AND reversion.id_documento = factura.id_factura) THEN 0 ELSE 1 END AS anulado" + _
        " FROM Factura INNER JOIN Factura_Detalle ON Factura.Id_Factura = Factura_Detalle.Id_Factura " + _
        IIf(Anulados, "", " and NOT EXISTS (SELECT * FROM Reversion  WHERE reversion.Tipo = 2 and reversion.id_documento=factura.id_factura)") + _
        " INNER JOIN CLIENTE ON Factura.Id_Cliente = CLIENTE.Id_Cliente " + _
          IIf(C = "", "", " and " + C) + _
        " GROUP BY Factura.Id_Factura, Factura.FECHA, Factura.Id_Cliente, CLIENTE.NOMBRE_comercial, factura.id_agente,Factura.Plazo, factura.piv"

        Dim Tbl As DataTable = Table(sql, PK)
        Return Tbl
    End Function

    Public Function FACError(ByVal C As String, ByVal PK As String) As DataTable
        Dim sql As String
        sql = "select id_factura, id_cliente, fecha, codError codigoError, descripcionError" + _
        " from factura where sincronizada = 1 and codError <> 'CodError:00' and notacredito = 0 " + C

        Dim Tbl As DataTable = Table(sql, PK)
        Return Tbl
    End Function

    Public Function FACM1(ByVal C As String, ByVal Anulados As Boolean, ByVal PK As String) As DataTable
        Dim sql As String
        sql = "SELECT Factura.Id_Factura, Factura.FECHA, factura.fecha+factura.plazo as vence,Factura.Id_Cliente, CLIENTE.NOMBRE_comercial, factura.id_agente,Factura.Plazo, factura.piv," + _
        "SUM(CASE WHEN factura_detalle.iv = 0 THEN (Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD " + _
        " ELSE  0 END) AS exento," + _
        "SUM(CASE WHEN factura_detalle.iv = 1 THEN (Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD " + _
        "ELSE  0 END) AS gravado, " + _
        "SUM((Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD) AS subtotal," + _
        "SUM(CASE WHEN factura_detalle.iv = 1 THEN (Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD * FACTURA.PIV " + _
        "ELSE 0 END) AS IV," + _
        "SUM(CASE WHEN factura_detalle.iv = 0 THEN (Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD " + _
        "ELSE (Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento)* factura_detalle.cantidad * (1 + factura.piv) END) AS MONTO, " + _
        " CASE WHEN NOT EXISTS (SELECT * FROM Reversion WHERE reversion.Tipo = 2 AND reversion.id_documento = factura.id_factura) THEN 0 ELSE 1 END AS anulado" + _
        " FROM Factura INNER JOIN Factura_Detalle ON Factura.Id_Factura = Factura_Detalle.Id_Factura " + _
        IIf(Anulados, "", " and NOT EXISTS (SELECT * FROM Reversion  WHERE reversion.Tipo = 2 and reversion.id_documento=factura.id_factura)") + _
        IIf(C = "", "", " and " + C) + _
        " INNER JOIN CLIENTE ON Factura.Id_Cliente = CLIENTE.Id_Cliente " + _
        " GROUP BY Factura.Id_Factura, Factura.FECHA, Factura.Id_Cliente, CLIENTE.NOMBRE_comercial, factura.id_agente,Factura.Plazo, factura.piv"

        Dim Tbl As DataTable = Table(sql, PK)
        Return Tbl
    End Function

    Public Function COMISIONG(ByVal C As String) As DataTable
        Dim sql As String
        sql = "SELECT Factura.Id_Factura, Factura.FECHA, factura.fecha+factura.plazo as vence,Factura.Id_Cliente, CLIENTE.NOMBRE_comercial, factura.id_agente, agente.nombre," + _
        "SUM((Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD) AS SUBTOTAL," + _
        "SUM(CASE WHEN cliente.id_zona=1 then (Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD *.05" + _
        " ELSE (Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD*0.07 end) AS COMISION," + _
        "SUM(CASE WHEN factura_detalle.iv = 0 THEN (Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento) * Factura_Detalle.CANTIDAD " + _
        " ELSE (Factura_Detalle.Precio-factura_detalle.precio*factura_detalle.descuento)* factura_detalle.cantidad * (1 + factura.piv) END) AS MONTO, " + _
        " case when cliente.id_zona=1 then 'C' else 'R' end as zona" + _
        " FROM Factura INNER JOIN Factura_Detalle ON Factura.Id_Factura = Factura_Detalle.Id_Factura " + _
        " and NOT EXISTS (SELECT * FROM Reversion  WHERE reversion.Tipo = 2 and reversion.id_documento=factura.id_factura)" + _
        IIf(C = "", "", " and " + C) + _
        " INNER JOIN CLIENTE ON Factura.Id_Cliente = CLIENTE.Id_Cliente " + _
        " INNER JOIN AGENTE ON Factura.Id_AGENTE = AGENTE.Id_AGENTE " + _
        " GROUP BY Factura.Id_Factura, Factura.FECHA, Factura.Id_Cliente, CLIENTE.NOMBRE_comercial, factura.id_agente,factura.plazo,cliente.Id_zona,agente.nombre"

        Dim Tbl As DataTable = Table(sql, "")
        Return Tbl
    End Function


    Public Function FACP(ByVal C1 As String, ByVal C2 As String) As DataTable
        Dim sql As String
        sql = "SELECT Factura_Detalle.Id_Producto, producto.nombre,factura_detalle.cantidad,factura_detalle.costo*factura_detalle.cantidad as costo," + _
        " case when factura.id_cliente = 61 then " + _
           " (factura_detalle.cantidad*(factura_detalle.precio-factura_detalle.precio*factura_detalle.descuento)) * 0.95 " + _
           " else (factura_detalle.cantidad*(factura_detalle.precio-factura_detalle.precio*factura_detalle.descuento)) " + _
           " end as monto, " + _
        "cliente.id_cliente,cliente.nombre_sociedad as cliente_nombre" + _
        " FROM Factura INNER JOIN Factura_Detalle ON Factura.Id_Factura = Factura_Detalle.Id_Factura" + _
        " and factura.id_Factura not in (SELECT id_documento as id_Factura FROM Reversion  WHERE reversion.Tipo = 2)" + _
         IIf(C1 = "", "", " And " + C1) + _
        " INNER JOIN CLIENTE ON Factura.Id_Cliente = CLIENTE.Id_Cliente " + _
        " INNER JOIN Producto ON Factura_Detalle.Id_Producto = Producto.Id_Producto " + IIf(C2 = "", "", " and " + C2)


        Dim Tbl As DataTable = Table(sql, "")

        Return Tbl
    End Function


    Public Function CACP(ByVal C1 As String, ByVal C2 As String) As DataTable
        Dim sql As String
        sql = "SELECT compra_Detalle.Id_Producto, producto.nombre,compra_detalle.cantidad,compra_detalle.cantidad*(compra_detalle.precio-compra_detalle.precio*compra_detalle.descuento) as monto, " + _
        "proveedor.id_proveedor,proveedor.nombre as proveedor_nombre" + _
        " FROM compra INNER JOIN compra_Detalle ON compra.Id_compra = compra_Detalle.Id_compra" + _
        " and NOT EXISTS (SELECT * FROM Reversion  WHERE reversion.Tipo = 12 and reversion.id_documento=compra.id_compra)" + _
         IIf(C1 = "", "", " And " + C1) + _
        " INNER JOIN proveedor ON compra.Id_proveedor = proveedor.Id_proveedor " + _
        " INNER JOIN Producto ON compra_Detalle.Id_Producto = Producto.Id_Producto " + IIf(C2 = "", "", " and " + C2)


        Dim Tbl As DataTable = Table(sql, "")

        Return Tbl
    End Function



    Public Function RECM(ByVal C As String, ByVal Anulados As Boolean, ByVal PK As String) As DataTable
        Dim sql As String
        sql = "SELECT Recibo.Id_recibo, recibo.FECHA, recibo.fecha_documento,recibo.referencia,recibo.Id_Cliente, CLIENTE.NOMBRE_sociedad,recibo.forma_pago," + _
        " SUM(abono) as monto," + _
        " CASE WHEN NOT EXISTS (SELECT * FROM Reversion WHERE reversion.Tipo = 4 AND reversion.id_documento = recibo.id_recibo) THEN 0 ELSE 1 END AS anulado" + _
        " FROM Recibo INNER JOIN Recibo_Detalle ON recibo.Id_recibo = recibo_Detalle.Id_recibo" + _
        IIf(Anulados, "", " and NOT EXISTS (SELECT * FROM Reversion  WHERE reversion.Tipo = 4 and reversion.id_documento=recibo.id_recibo)") + _
        IIf(C = "", "", " and " + C) + _
        " INNER JOIN CLIENTE ON recibo.Id_Cliente = CLIENTE.Id_Cliente " + _
        " GROUP BY recibo.Id_recibo, recibo.FECHA, recibo.fecha_documento,recibo.referencia,recibo.Id_Cliente, CLIENTE.NOMBRE_sociedad, recibo.forma_pago" + _
        " ORDER BY recibo.Id_recibo "

        Dim Tbl As DataTable = Table(sql, PK)
        Return Tbl
    End Function





    Public Function RECA(ByVal C As String) As DataTable
        Dim sql As String
        sql = "SELECT Recibo_Detalle.id_recibo, Recibo_Detalle.abono, Recibo.fecha" + _
        " FROM Recibo_Detalle INNER JOIN Recibo ON Recibo_Detalle.id_recibo = Recibo.id_recibo" + _
        " and NOT EXISTS (SELECT * FROM Reversion  WHERE reversion.Tipo = 4 and reversion.id_documento=recibo.id_recibo)" + _
        " AND Recibo_Detalle.id_factura =" + C

        Dim RED As DataTable = Table(sql, "")
        Return RED
    End Function


    Public Function DEVP(ByVal C1 As String, ByVal C2 As String) As DataTable
        Dim sql As String
        sql = "SELECT devolucion.fecha,devolucion_Detalle.Id_Producto, producto.nombre,devolucion_detalle.cantidad*-1 as cantidad,factura_detalle.costo*devolucion_detalle.cantidad *-1 as costo ,devolucion_detalle.cantidad*(factura_detalle.precio-factura_detalle.precio*factura_detalle.descuento)*-1 as monto, " + _
        "devolucion.id_cliente,cliente.nombre_sociedad as cliente_nombre" + _
        " FROM devolucion INNER JOIN devolucion_Detalle ON devolucion.Id_devolucion = devolucion_Detalle.Id_devolucion" + _
        " and NOT EXISTS (SELECT * FROM Reversion  WHERE reversion.Tipo = 8 and reversion.id_documento=devolucion.id_devolucion)" + _
         IIf(C1 = "", "", " And " + C1) + _
        " INNER JOIN FACTURA_DETALLE ON devolucion.Id_factura = FACTURA_DETALLE.id_factura and factura_detalle.id_producto=devolucion_detalle.id_producto " + _
        " INNER JOIN CLIENTE ON devolucion.Id_Cliente = cliente.id_cliente " + _
        " INNER JOIN Producto ON devolucion_Detalle.Id_Producto = Producto.Id_producto" + IIf(C2 = "", "", " and " + C2)

        Dim Tbl As DataTable = Table(sql, "")

        Return Tbl
    End Function



    Public Function DEVP2(ByVal C1 As String, ByVal C2 As String) As DataTable
        Dim sql As String
        Dim z As Integer
        Dim Facs As DataTable
        Dim tbl As DataTable
        Dim Devd As DataTable = DEVP_S()



        sql = "SELECT factura_detalle.id_factura,Factura_Detalle.Id_Producto,factura_detalle.costo, (factura_detalle.precio-factura_detalle.precio*factura_detalle.descuento) as precio " + _
        " FROM Factura INNER JOIN Factura_Detalle ON Factura.Id_Factura = Factura_Detalle.Id_Factura" + _
        " and NOT EXISTS (SELECT * FROM Reversion  WHERE reversion.Tipo = 2 and reversion.id_documento=factura.id_factura)" + _
        IIf(C1 = "", "", " and " + C1) + _
        " INNER JOIN Producto ON Factura_Detalle.Id_Producto = Producto.Id_Producto " + IIf(C2 = "", "", " and " + C2)
        Facs = Table(sql, "")

        For z = 0 To Facs.Rows.Count - 1
            sql = "SELECT devolucion_Detalle.Id_Producto, producto.nombre,devolucion_detalle.cantidad,cliente.id_cliente,cliente.nombre_sociedad as cliente_nombre" + _
            " FROM devolucion INNER JOIN devolucion_Detalle ON devolucion.Id_devolucion = devolucion_Detalle.Id_devolucion" + _
            " and NOT EXISTS (SELECT * FROM Reversion  WHERE reversion.Tipo = 8 and reversion.id_documento=devolucion.id_devolucion)" + _
            " and devolucion.id_factura=" + Facs.Rows(z).Item("id_factura").ToString + _
            " INNER JOIN CLIENTE ON devolucion.Id_Cliente = CLIENTE.Id_Cliente " + _
            " INNER JOIN Producto ON devolucion_Detalle.Id_Producto = Producto.Id_Producto and devolucion_detalle.id_producto=" + Facs.Rows(z).Item("id_producto").ToString

            tbl = Table(sql, "")
            If tbl.Rows.Count > 0 Then
                Dim xmonto As DataColumn = New DataColumn("monto")
                xmonto.DataType = System.Type.GetType("System.String")
                xmonto.DefaultValue = 0
                tbl.Columns.Add(xmonto)
                Dim xcosto As DataColumn = New DataColumn("costo")
                xcosto.DataType = System.Type.GetType("System.String")
                xcosto.DefaultValue = 0
                tbl.Columns.Add(xcosto)

                With tbl.Rows(0)
                    .Item("cantidad") = .Item("cantidad") * -1
                    .Item("costo") = Facs.Rows(z).Item("costo") * .Item("cantidad")
                    .Item("monto") = Facs.Rows(z).Item("precio") * .Item("cantidad")
                End With
                Devd.ImportRow(tbl.Rows(0))
            End If
        Next
        Return Devd
    End Function

    Public Function DEVP_S() As DataTable
        Dim T As DataTable = New DataTable("T")

        Dim id_factura As DataColumn = New DataColumn("id_factura")
        id_factura.DataType = System.Type.GetType("System.String")
        id_factura.DefaultValue = 0
        T.Columns.Add(id_factura)

        Dim id_producto As DataColumn = New DataColumn("id_producto")
        id_producto.DataType = System.Type.GetType("System.String")
        id_producto.DefaultValue = 0
        T.Columns.Add(id_producto)

        Dim cantidad As DataColumn = New DataColumn("cantidad")
        cantidad.DataType = System.Type.GetType("System.String")
        cantidad.DefaultValue = 0
        T.Columns.Add(cantidad)

        Dim costo As DataColumn = New DataColumn("costo")
        costo.DataType = System.Type.GetType("System.String")
        costo.DefaultValue = 0
        T.Columns.Add(costo)

        Dim precio As DataColumn = New DataColumn("precio")
        precio.DataType = System.Type.GetType("System.String")
        precio.DefaultValue = 0
        T.Columns.Add(precio)

        Dim nombre As DataColumn = New DataColumn("nombre")
        nombre.DataType = System.Type.GetType("System.String")
        nombre.DefaultValue = ""
        T.Columns.Add(nombre)


        Dim id_cliente As DataColumn = New DataColumn("id_cliente")
        id_cliente.DataType = System.Type.GetType("System.String")
        id_cliente.DefaultValue = 0
        T.Columns.Add(id_cliente)

        Dim cliente_nombre As DataColumn = New DataColumn("cliente_nombre")
        cliente_nombre.DataType = System.Type.GetType("System.String")
        cliente_nombre.DefaultValue = 0
        T.Columns.Add(cliente_nombre)

        Dim monto As DataColumn = New DataColumn("monto")
        monto.DataType = System.Type.GetType("System.String")
        monto.DefaultValue = 0
        T.Columns.Add(monto)

        Return T
    End Function



    Public Function DEVM(ByVal C As String, ByVal Anulados As Boolean, ByVal Pk As String) As DataTable


        'Try

        Dim DTgravado As Decimal
        Dim DTexento As Decimal
        Dim DTiv As Decimal
        Dim DTdescuento As Decimal

        Dim TEX As Decimal
        Dim TGA As Decimal
        Dim TIV As Decimal

        Dim m As Decimal
        Dim mf As Decimal
        Dim d As Decimal


        Dim Dev As DataTable
        Dim DevD As DataTable
        Dim Fac As DataTable
        Dim FacD As DataTable
        Dim rowfd As DataRow

        Dim i As Integer
        Dim j As Integer
        Dim sql As String

        sql = "select devolucion.id_devolucion,devolucion.fecha,devolucion.id_cliente,devolucion.id_factura,devolucion.id_nota_credito,cliente.nombre_sociedad, " + _
        " CASE WHEN NOT EXISTS (SELECT * FROM Reversion WHERE reversion.Tipo = 8 AND reversion.id_documento = devolucion.id_devolucion) THEN 0 ELSE 1 END AS anulado" + _
        " from devolucion inner join cliente on devolucion.id_cliente=cliente.id_cliente " + _
        IIf(C = "", "", " and " + C) + _
        IIf(Anulados, "", " and NOT EXISTS (SELECT * FROM Reversion  WHERE reversion.Tipo = 8 and reversion.id_documento=devolucion.id_devolucion)")


        Dev = Table(sql, Pk)
        Dim exento As DataColumn = New DataColumn("exento")
        exento.DataType = System.Type.GetType("System.Decimal")
        exento.DefaultValue = 0
        Dev.Columns.Add(exento)

        Dim gravado As DataColumn = New DataColumn("gravado")
        gravado.DataType = System.Type.GetType("System.Decimal")
        gravado.DefaultValue = 0
        Dev.Columns.Add(gravado)

        Dim iv As DataColumn = New DataColumn("iv")
        iv.DataType = System.Type.GetType("System.Decimal")
        iv.DefaultValue = 0
        Dev.Columns.Add(iv)

        Dim Monto As DataColumn = New DataColumn("Monto")
        Monto.DataType = System.Type.GetType("System.Decimal")
        Monto.DefaultValue = 0
        Dev.Columns.Add(Monto)


        For i = 0 To Dev.Rows.Count - 1
            With Dev.Rows(i)

                DTgravado = 0.0
                DTexento = 0.0
                DTdescuento = 0.0
                DTiv = 0.0
                TEX = 0
                TGA = 0
                TIV = 0

                DevD = Table("select * from devolucion_detalle where id_devolucion=" + .Item("id_devolucion").ToString + " order by id_producto", "")

                Dim precio As DataColumn = New DataColumn("precio")
                precio.DataType = System.Type.GetType("System.Decimal")
                DevD.Columns.Add(precio)

                Dim descuento As DataColumn = New DataColumn("descuento")
                descuento.DataType = System.Type.GetType("System.Decimal")
                DevD.Columns.Add(descuento)



                Dim ddiv As DataColumn = New DataColumn("ddiv")
                ddiv.DataType = System.Type.GetType("System.Boolean")
                DevD.Columns.Add(ddiv)

                FacD = Table("select * from factura_detalle where id_factura=" + .Item("id_factura").ToString, "id_producto")


                For j = 0 To DevD.Rows.Count - 1
                    With DevD.Rows(j)
                        rowfd = FacD.Rows.Find(.Item("id_producto"))
                        .Item("precio") = rowfd("precio")
                        .Item("descuento") = rowfd("descuento")
                        .Item("ddiv") = rowfd("iv")

                        m = 0
                        mf = 0
                        d = 0


                        m = .Item("precio") * .Item("cantidad")
                        d = m * (.Item("descuento"))
                        mf = m - d
                        If .Item("ddiv") Then
                            DTgravado = DTgravado + mf
                            Dim l As String = Dev.Rows(i).Item("id_factura").ToString
                            Fac = Table("select piv from factura where factura.id_factura=" + Dev.Rows(i).Item("id_factura").ToString, "")
                            DTiv = DTiv + mf * Fac.Rows(0).Item("PIV")

                            TGA = TGA + mf
                            TIV = TIV + mf * Fac.Rows(0).Item("PIV")
                        Else
                            DTexento = DTexento + mf

                            TEX = TEX + mf
                        End If
                        DTdescuento = DTdescuento + d
                    End With
                Next j

                .Item("exento") = TEX
                .Item("gravado") = TGA
                .Item("iv") = TIV
                .Item("monto") = DTexento + DTgravado + DTiv
            End With
        Next i
        Return Dev
        'Catch myerror As Exception
        ' ONEX(Me.Name, myerror)

        'End Try
    End Function


    Public Function NCDIS(ByVal C As String, ByVal Pk As String) As DataTable
        'Try
        Dim NC As DataTable
        Dim sql As String

        sql = "select nota_credito.id_Nota_credito,nota_credito.fecha,nota_credito.id_cliente,nota_credito.gravado,nota_credito.exento,nota_credito.piv,nota_credito.observaciones," + _
        "nota_credito.gravado*nota_credito.piv as iv,nota_credito.exento+nota_credito.gravado+(nota_credito.gravado*nota_credito.piv) as monto," + _
        "cliente.nombre_sociedad " + _
        " FROM nota_credito INNER JOIN cliente ON nota_credito.Id_cliente = cliente.Id_cliente " + _
        " where NOT EXISTS (SELECT * FROM Reversion  WHERE reversion.Tipo = 6 and reversion.id_documento=nota_credito.id_nota_credito)" + _
        " and NOT EXISTS (SELECT * FROM nota_credito_detalle  WHERE nota_credito_detalle.id_nota_credito = nota_credito.id_nota_credito)" + _
        IIf(C = "", "", " And " + C)

        NC = Table(sql, "")


        Return NC
        'Catch myerror As Exception
        ' ONEX(Me.Name, myerror)
        'End Try
    End Function



    Public Function NCA(ByVal C As String, ByVal Pk As String) As DataTable
        'Try
        Dim SQL As String
        Dim NCD As DataTable
        SQL = "select * from nota_credito_detalle where " + C
        NCD = Table(SQL, Pk)
        Return NCD
        'Catch myerror As Exception
        ' ONEX(Me.Name, myerror)
        'End Try
    End Function

    Public Function NDA(ByVal C As String, ByVal Pk As String) As DataTable
        'Try
        Dim SQL As String
        Dim NCD As DataTable
        SQL = "select * from nota_debito_detalle where " & C & " and id_nota_debito not in " & _
        "(select id_documento as id_nota_debito from reversion where tipo = 7)"
        NCD = Table(SQL, Pk)
        Return NCD
        'Catch myerror As Exception
        ' ONEX(Me.Name, myerror)
        'End Try
    End Function

    Public Function NCM(ByVal C As String, ByVal Anulados As Boolean, ByVal Pk As String) As DataTable
        Dim sql As String
        Dim tbl As DataTable
        sql = "select nota_credito.id_Nota_credito,nota_credito.fecha,nota_credito.id_cliente,nota_credito.gravado,nota_credito.exento,nota_credito.piv,nota_credito.observaciones," + _
        "nota_credito.gravado*nota_credito.piv as iv,nota_credito.exento+nota_credito.gravado+(nota_credito.gravado*nota_credito.piv) as monto," + _
        "cliente.nombre_sociedad, cliente.nombre_comercial,  " + _
        "CASE WHEN NOT EXISTS (SELECT * FROM Reversion WHERE reversion.Tipo = 6 AND reversion.id_documento = nota_credito.id_nota_credito) THEN 0 ELSE 1 END AS anulado" + _
        " FROM nota_credito INNER JOIN cliente ON nota_credito.Id_cliente = cliente.Id_cliente " + _
        IIf(Anulados, "", " and NOT EXISTS (SELECT * FROM Reversion  WHERE reversion.Tipo = 6 and reversion.id_documento=nota_credito.id_nota_credito)") + _
        IIf(C = "", "", " and " + C)

        tbl = Table(sql, "")
        Return tbl
    End Function

    Public Function NDM(ByVal C As String, ByVal Anulados As Boolean, ByVal Pk As String) As DataTable
        Dim sql As String
        Dim tbl As DataTable
        sql = "select nota_debito.id_Nota_debito, nota_debito.fecha,nota_debito.id_cliente,nota_debito.observaciones," + _
        "nota_debito_detalle.monto, cliente.nombre_sociedad, cliente.nombre_comercial,  " + _
        "CASE WHEN NOT EXISTS (SELECT * FROM Reversion WHERE reversion.Tipo = 7 AND reversion.id_documento = nota_debito.id_nota_debito) THEN 0 ELSE 1 END AS anulado " + _
        " FROM nota_debito INNER JOIN cliente ON nota_debito.Id_cliente = cliente.Id_cliente inner join nota_Debito_detalle on nota_debito.id_nota_debito = nota_debito_detalle.id_nota_debito " + _
        IIf(Anulados, "", " and NOT EXISTS (SELECT * FROM Reversion  WHERE reversion.Tipo = 7 and reversion.id_documento=nota_debito.id_nota_debito)") + _
        IIf(C = "", "", " and " + C)

        tbl = Table(sql, "")
        Return tbl
    End Function

    Public Function FAC_S() As DataTable
        Dim T As DataTable = New DataTable("T")

        Dim id_factura As DataColumn = New DataColumn("id_factura")
        id_factura.DataType = System.Type.GetType("System.Int32")
        id_factura.DefaultValue = 0
        T.Columns.Add(id_factura)

        Dim fecha As DataColumn = New DataColumn("fecha")
        fecha.DataType = System.Type.GetType("System.DateTime")
        T.Columns.Add(fecha)

        Dim vence As DataColumn = New DataColumn("vence")
        vence.DataType = System.Type.GetType("System.DateTime")
        T.Columns.Add(vence)


        Dim id_cliente As DataColumn = New DataColumn("id_cliente")
        id_cliente.DataType = System.Type.GetType("System.Int32")
        id_cliente.DefaultValue = 0
        T.Columns.Add(id_cliente)


        Dim nombre_sociedad As DataColumn = New DataColumn("nombre_sociedad")
        nombre_sociedad.DataType = System.Type.GetType("System.String")
        nombre_sociedad.DefaultValue = ""
        T.Columns.Add(nombre_sociedad)


        Dim nombre_comercial As DataColumn = New DataColumn("nombre_comercial")
        nombre_comercial.DataType = System.Type.GetType("System.String")
        nombre_comercial.DefaultValue = ""
        T.Columns.Add(nombre_comercial)

        Dim id_agente As DataColumn = New DataColumn("id_agente")
        id_agente.DataType = System.Type.GetType("System.Int32")
        id_agente.DefaultValue = 0
        T.Columns.Add(id_agente)

        Dim plazo As DataColumn = New DataColumn("plazo")
        plazo.DataType = System.Type.GetType("System.Int32")
        plazo.DefaultValue = 0
        T.Columns.Add(plazo)


        Dim exento As DataColumn = New DataColumn("exento")
        exento.DataType = System.Type.GetType("System.Decimal")
        exento.DefaultValue = 0
        T.Columns.Add(exento)

        Dim gravado As DataColumn = New DataColumn("gravado")
        gravado.DataType = System.Type.GetType("System.Decimal")
        gravado.DefaultValue = 0
        T.Columns.Add(gravado)

        Dim iv As DataColumn = New DataColumn("iv")
        iv.DataType = System.Type.GetType("System.Decimal")
        iv.DefaultValue = 0
        T.Columns.Add(iv)


        Dim subtotal As DataColumn = New DataColumn("subtotal")
        subtotal.DataType = System.Type.GetType("System.Decimal")
        subtotal.DefaultValue = 0
        T.Columns.Add(subtotal)

        Dim monto As DataColumn = New DataColumn("monto")
        monto.DataType = System.Type.GetType("System.Decimal")
        monto.DefaultValue = 0
        T.Columns.Add(monto)

        Dim piv As DataColumn = New DataColumn("piv")
        piv.DataType = System.Type.GetType("System.Decimal")
        piv.DefaultValue = 0
        T.Columns.Add(piv)

        Dim anulado As DataColumn = New DataColumn("anulado")
        anulado.DataType = System.Type.GetType("System.Boolean")
        anulado.DefaultValue = 0
        T.Columns.Add(anulado)

        Dim Saldo As DataColumn = New DataColumn("Saldo")
        Saldo.DataType = System.Type.GetType("System.Decimal")
        Saldo.DefaultValue = 0
        T.Columns.Add(Saldo)

        T.PrimaryKey = New DataColumn() {T.Columns("id_factura")}

        Return T
    End Function





    Public Function Numerico(ByVal K As Integer, ByVal T As String, ByVal d As Boolean) As Boolean
        Try
            If K = 46 And InStr(T, ".") > 0 Then
                Numerico = True
                Exit Function
            ElseIf (K < 48 Or K > 57) And K <> IIf(d, 46, 0) And K <> 8 Then
                Numerico = True
            End If
        Catch myerror As SqlException
            ONEX("numerico", myerror)
        End Try
    End Function



    Public Function Table(ByVal Q As String, ByVal Pk As String) As DataTable
        'Try
        If CONN1.State = ConnectionState.Closed Then
            CONN1.Open()
        End If

        Dim command As New SqlCommand(Q, CONN1)
        Dim reader As SqlDataReader = command.ExecuteReader()
        Dim schema As DataTable = reader.GetSchemaTable()
        Dim columns(schema.Rows.Count - 1) As DataColumn
        Dim column As DataColumn


        For i As Integer = 0 To columns.GetUpperBound(0) Step 1
            column = New DataColumn
            column.AllowDBNull = CBool(schema.Rows(i)("AllowDBNull"))
            column.AutoIncrement = CBool(schema.Rows(i)("IsAutoIncrement"))
            column.ColumnName = CStr(schema.Rows(i)("ColumnName"))
            column.DataType = CType(schema.Rows(i)("DataType"), Type)

            If column.DataType Is GetType(String) Then
                column.MaxLength = CInt(schema.Rows(i)("ColumnSize"))
            End If

            column.ReadOnly = CBool(schema.Rows(i)("IsReadOnly"))
            column.Unique = CBool(schema.Rows(i)("IsUnique"))
            columns(i) = column
        Next i

        Dim data As New DataTable
        Dim row As DataRow
        data.Columns.AddRange(columns)

        While reader.Read()
            row = data.NewRow()
            For i As Integer = 0 To columns.GetUpperBound(0)
                row(i) = reader(i)
            Next i
            data.Rows.Add(row)
        End While
        reader.Close()
        If Pk <> "" Then data.PrimaryKey = New DataColumn() {data.Columns(Pk)}
        Return data
        ' Catch myerror As Exception
        'ONEX("Table", myerror)
        'Return Nothing
        'End Try
    End Function
    Public Function cb_buscar(ByVal cb As ComboBox, ByVal T As String) As Integer
        Try
            Dim i As Integer = 0
            Dim Z As Integer
            For Z = 0 To cb.Items.Count - 1
                cb.SelectedIndex = Z
                If IIf(IsNumeric(cb.Text.Substring(1, 1)), cb.Text.Substring(0, 2), cb.Text.Substring(0, 1)) = T Then
                    i = Z
                    Exit For
                End If
            Next
            If i = 0 And cb.Items.Count = 0 Then i = -1
            Return i
        Catch myerror As Exception
            ONEX("cb_buscar", myerror)
            Return -1
        End Try
    End Function




    Public Function CB_crear(ByVal cb As ComboBox, ByVal Tbl As String, ByVal PK As String) As ComboBox
        'Try
        Dim T As DataTable
        T = Table("select " + PK + ",nombre from " + Tbl + " where eliminado=0 order by " + PK, "")
        Dim z As Integer
        For z = 0 To T.Rows.Count - 1
            cb.Items.Add(T.Rows(z).Item(PK).ToString + "-" + T.Rows(z).Item("nombre"))
        Next
        If cb.Items.Count > 0 Then cb.SelectedIndex = 0
        Return cb
        'Catch myerror As Exception
        ' Dim nd As New ComboBox
        ' ONEX("Genera_cb", myerror)
        ' Return nd
        ' End Try
    End Function


    Public Function cbid(ByVal T As String) As String
        Return IIf(IsNumeric(T.Substring(1, 1)), T.Substring(0, 2), T.Substring(0, 1))
    End Function


    Public Function TS(ByVal Tbl As DataTable, ByVal F As String, ByVal Text As String) As DataRow
        Dim Pos As Integer = -1
        Dim z As Integer
        For z = 0 To Tbl.Rows.Count - 1
            With Tbl.Rows(z)
                If .Item(F) = Text Then
                    Pos = z
                    Exit For
                End If
            End With
        Next
        If Pos < 0 Then
            Return Nothing
        Else
            Return Tbl.Rows(Pos)
        End If
    End Function


    Public Function RFile(ByVal FullPath As String, Optional ByRef ErrInfo As String = "") As String
        Try
            Dim strContents As String
            Dim objReader As StreamReader
            objReader = New StreamReader(FullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()
            Return strContents
        Catch Ex As Exception
            Return "0"
        End Try
    End Function


    Public Sub wFile(ByVal strData As String, ByVal FullPath As String)
        Try
            Dim objReader As StreamWriter
            objReader = New StreamWriter(FullPath)
            objReader.Write(strData)
            objReader.Close()
        Catch Ex As Exception
            MsgBox(Ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub ONEX(ByVal ID As String, ByVal e As Exception)
        Try
            Dim T As String = Now.ToString
            Dim FN As String = Path + T.Substring(0, 2) + "." + T.Substring(3, 2) + "." + T.Substring(6, 4) + " " + T.Substring(11, 2) + "." + T.Substring(14, 2) + "." + T.Substring(17, 2) + ".txt"
            wFile(ID + " - " + e.Message, FN)
            MsgBox(e.Message)
        Catch Ex As Exception
            MsgBox(Ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Function chk(ByVal k As Integer) As Boolean
        Try
            If k = 39 Then
                chk = True
                Exit Function
            End If
        Catch myerror As SqlException
            ONEX("chk", myerror)
        End Try
    End Function
End Module