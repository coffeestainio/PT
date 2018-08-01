<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Compra
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Compra))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.pnencabezado = New System.Windows.Forms.Panel
        Me.txtmonto = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtplazo = New System.Windows.Forms.TextBox
        Me.txtfactura = New System.Windows.Forms.TextBox
        Me.txtid_proveedor = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblproveedor_nombre = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblproductos = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dtgcompra = New System.Windows.Forms.DataGridView
        Me.btnincluir = New System.Windows.Forms.Button
        Me.btnguardar = New System.Windows.Forms.Button
        Me.btneliminar = New System.Windows.Forms.Button
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.id_producto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.presentacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tpddescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Costo_nuevo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TPDMonto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tpdiv = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.utilidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.precio_actual = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.costo_actual = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.precio_Nuevo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnencabezado.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgcompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnencabezado
        '
        Me.pnencabezado.Controls.Add(Me.txtmonto)
        Me.pnencabezado.Controls.Add(Me.Label4)
        Me.pnencabezado.Controls.Add(Me.dtpfecha)
        Me.pnencabezado.Controls.Add(Me.Label3)
        Me.pnencabezado.Controls.Add(Me.txtplazo)
        Me.pnencabezado.Controls.Add(Me.txtfactura)
        Me.pnencabezado.Controls.Add(Me.txtid_proveedor)
        Me.pnencabezado.Controls.Add(Me.Label2)
        Me.pnencabezado.Controls.Add(Me.Label1)
        Me.pnencabezado.Controls.Add(Me.lblproveedor_nombre)
        Me.pnencabezado.Controls.Add(Me.Label6)
        Me.pnencabezado.Location = New System.Drawing.Point(8, 31)
        Me.pnencabezado.Name = "pnencabezado"
        Me.pnencabezado.Size = New System.Drawing.Size(967, 64)
        Me.pnencabezado.TabIndex = 74
        '
        'txtmonto
        '
        Me.txtmonto.Enabled = False
        Me.txtmonto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonto.Location = New System.Drawing.Point(705, 35)
        Me.txtmonto.MaxLength = 12
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(145, 26)
        Me.txtmonto.TabIndex = 4
        Me.txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(646, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 24)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Monto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpfecha
        '
        Me.dtpfecha.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(102, 35)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(111, 26)
        Me.dtpfecha.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Fecha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtplazo
        '
        Me.txtplazo.AcceptsReturn = True
        Me.txtplazo.Enabled = False
        Me.txtplazo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplazo.Location = New System.Drawing.Point(318, 35)
        Me.txtplazo.MaxLength = 3
        Me.txtplazo.Name = "txtplazo"
        Me.txtplazo.Size = New System.Drawing.Size(41, 26)
        Me.txtplazo.TabIndex = 2
        Me.txtplazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtplazo, "Escriba el Código del Cliente")
        '
        'txtfactura
        '
        Me.txtfactura.Enabled = False
        Me.txtfactura.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfactura.Location = New System.Drawing.Point(476, 35)
        Me.txtfactura.MaxLength = 12
        Me.txtfactura.Name = "txtfactura"
        Me.txtfactura.Size = New System.Drawing.Size(145, 26)
        Me.txtfactura.TabIndex = 3
        Me.txtfactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtfactura, "Escriba el Código del Cliente")
        '
        'txtid_proveedor
        '
        Me.txtid_proveedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid_proveedor.Location = New System.Drawing.Point(102, 5)
        Me.txtid_proveedor.MaxLength = 3
        Me.txtid_proveedor.Name = "txtid_proveedor"
        Me.txtid_proveedor.Size = New System.Drawing.Size(41, 26)
        Me.txtid_proveedor.TabIndex = 0
        Me.txtid_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtid_proveedor, "Escriba el Código del Cliente")
        '
        'Label2
        '
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(256, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Plazo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(405, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 24)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Factura"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblproveedor_nombre
        '
        Me.lblproveedor_nombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproveedor_nombre.Location = New System.Drawing.Point(175, 5)
        Me.lblproveedor_nombre.Name = "lblproveedor_nombre"
        Me.lblproveedor_nombre.Size = New System.Drawing.Size(387, 24)
        Me.lblproveedor_nombre.TabIndex = 38
        Me.lblproveedor_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 24)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Proveedor"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblproductos
        '
        Me.lblproductos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproductos.Location = New System.Drawing.Point(106, 679)
        Me.lblproductos.Name = "lblproductos"
        Me.lblproductos.Size = New System.Drawing.Size(29, 24)
        Me.lblproductos.TabIndex = 79
        Me.lblproductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 679)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 24)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "Productos"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.dtgcompra)
        Me.Panel1.Controls.Add(Me.btnincluir)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Controls.Add(Me.btneliminar)
        Me.Panel1.Controls.Add(Me.btnmodificar)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Location = New System.Drawing.Point(8, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 561)
        Me.Panel1.TabIndex = 76
        '
        'dtgcompra
        '
        Me.dtgcompra.AllowUserToAddRows = False
        Me.dtgcompra.AllowUserToDeleteRows = False
        Me.dtgcompra.AllowUserToResizeColumns = False
        Me.dtgcompra.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgcompra.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgcompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgcompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_producto, Me.cantidad, Me.presentacion, Me.nombre, Me.tpddescuento, Me.Costo_nuevo, Me.TPDMonto, Me.tpdiv, Me.utilidad, Me.precio_actual, Me.costo_actual, Me.precio_Nuevo})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgcompra.DefaultCellStyle = DataGridViewCellStyle10
        Me.dtgcompra.Location = New System.Drawing.Point(2, 3)
        Me.dtgcompra.Name = "dtgcompra"
        Me.dtgcompra.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgcompra.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dtgcompra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgcompra.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dtgcompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgcompra.Size = New System.Drawing.Size(897, 551)
        Me.dtgcompra.TabIndex = 36
        '
        'btnincluir
        '
        Me.btnincluir.Enabled = False
        Me.btnincluir.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnincluir.Image = CType(resources.GetObject("btnincluir.Image"), System.Drawing.Image)
        Me.btnincluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnincluir.Location = New System.Drawing.Point(907, 3)
        Me.btnincluir.Name = "btnincluir"
        Me.btnincluir.Size = New System.Drawing.Size(56, 48)
        Me.btnincluir.TabIndex = 3
        Me.btnincluir.Text = "Incluir"
        Me.btnincluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnincluir.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Enabled = False
        Me.btnguardar.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.Location = New System.Drawing.Point(909, 174)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(54, 48)
        Me.btnguardar.TabIndex = 6
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Enabled = False
        Me.btneliminar.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar.Image = CType(resources.GetObject("btneliminar.Image"), System.Drawing.Image)
        Me.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btneliminar.Location = New System.Drawing.Point(909, 111)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(54, 48)
        Me.btneliminar.TabIndex = 5
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Enabled = False
        Me.btnmodificar.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.Image = CType(resources.GetObject("btnmodificar.Image"), System.Drawing.Image)
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnmodificar.Location = New System.Drawing.Point(909, 57)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(54, 48)
        Me.btnmodificar.TabIndex = 4
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.CanOverflow = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip1.Enabled = False
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(902, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip1.Size = New System.Drawing.Size(61, 557)
        Me.ToolStrip1.TabIndex = 34
        '
        'lbltitulo
        '
        Me.lbltitulo.BackColor = System.Drawing.Color.SeaGreen
        Me.lbltitulo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbltitulo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.White
        Me.lbltitulo.Location = New System.Drawing.Point(0, 0)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(986, 28)
        Me.lbltitulo.TabIndex = 75
        Me.lbltitulo.Text = "Compras"
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'id_producto
        '
        Me.id_producto.DataPropertyName = "id_producto"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.NullValue = Nothing
        Me.id_producto.DefaultCellStyle = DataGridViewCellStyle3
        Me.id_producto.HeaderText = "Cód"
        Me.id_producto.Name = "id_producto"
        Me.id_producto.ReadOnly = True
        Me.id_producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.id_producto.Width = 60
        '
        'cantidad
        '
        Me.cantidad.DataPropertyName = "cantidad"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.NullValue = Nothing
        Me.cantidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.cantidad.HeaderText = "Cant"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cantidad.Width = 50
        '
        'presentacion
        '
        Me.presentacion.DataPropertyName = "presentacion"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.presentacion.DefaultCellStyle = DataGridViewCellStyle5
        Me.presentacion.HeaderText = ""
        Me.presentacion.Name = "presentacion"
        Me.presentacion.ReadOnly = True
        Me.presentacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.presentacion.Width = 35
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.DefaultCellStyle = DataGridViewCellStyle6
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.nombre.Width = 420
        '
        'tpddescuento
        '
        Me.tpddescuento.DataPropertyName = "descuento"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.tpddescuento.DefaultCellStyle = DataGridViewCellStyle7
        Me.tpddescuento.HeaderText = "%"
        Me.tpddescuento.Name = "tpddescuento"
        Me.tpddescuento.ReadOnly = True
        Me.tpddescuento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.tpddescuento.Width = 50
        '
        'Costo_nuevo
        '
        Me.Costo_nuevo.DataPropertyName = "costo_nuevo"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Costo_nuevo.DefaultCellStyle = DataGridViewCellStyle8
        Me.Costo_nuevo.HeaderText = "Costo"
        Me.Costo_nuevo.Name = "Costo_nuevo"
        Me.Costo_nuevo.ReadOnly = True
        Me.Costo_nuevo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Costo_nuevo.Width = 90
        '
        'TPDMonto
        '
        Me.TPDMonto.DataPropertyName = "Monto"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.TPDMonto.DefaultCellStyle = DataGridViewCellStyle9
        Me.TPDMonto.HeaderText = "Monto"
        Me.TPDMonto.Name = "TPDMonto"
        Me.TPDMonto.ReadOnly = True
        Me.TPDMonto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'tpdiv
        '
        Me.tpdiv.DataPropertyName = "iv"
        Me.tpdiv.HeaderText = "iv"
        Me.tpdiv.Name = "tpdiv"
        Me.tpdiv.ReadOnly = True
        Me.tpdiv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tpdiv.Width = 25
        '
        'utilidad
        '
        Me.utilidad.DataPropertyName = "utilidad"
        Me.utilidad.HeaderText = "utilidad"
        Me.utilidad.Name = "utilidad"
        Me.utilidad.ReadOnly = True
        Me.utilidad.Visible = False
        '
        'precio_actual
        '
        Me.precio_actual.DataPropertyName = "precio_actual"
        Me.precio_actual.HeaderText = "precio_actual"
        Me.precio_actual.Name = "precio_actual"
        Me.precio_actual.ReadOnly = True
        Me.precio_actual.Visible = False
        '
        'costo_actual
        '
        Me.costo_actual.DataPropertyName = "costo_actual"
        Me.costo_actual.HeaderText = "costo_actual"
        Me.costo_actual.Name = "costo_actual"
        Me.costo_actual.ReadOnly = True
        Me.costo_actual.Visible = False
        '
        'precio_Nuevo
        '
        Me.precio_Nuevo.DataPropertyName = "precio_nuevo"
        Me.precio_Nuevo.HeaderText = "precio_nuevo"
        Me.precio_Nuevo.Name = "precio_Nuevo"
        Me.precio_Nuevo.ReadOnly = True
        Me.precio_Nuevo.Visible = False
        '
        'frm_Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 722)
        Me.Controls.Add(Me.pnencabezado)
        Me.Controls.Add(Me.lblproductos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_Compra"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnencabezado.ResumeLayout(False)
        Me.pnencabezado.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtgcompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnencabezado As System.Windows.Forms.Panel
    Friend WithEvents txtfactura As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtid_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblproveedor_nombre As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnincluir As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents lblproductos As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents txtplazo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents dtgcompra As System.Windows.Forms.DataGridView
    Friend WithEvents id_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents presentacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tpddescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo_nuevo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPDMonto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tpdiv As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents utilidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio_actual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo_actual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio_Nuevo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
