<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pedido))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkarchivo = New System.Windows.Forms.CheckBox
        Me.chkcopia = New System.Windows.Forms.CheckBox
        Me.chkoriginal = New System.Windows.Forms.CheckBox
        Me.btnimprimir = New System.Windows.Forms.Button
        Me.btndescpp = New System.Windows.Forms.Button
        Me.btnfacturar = New System.Windows.Forms.Button
        Me.btnincluir = New System.Windows.Forms.Button
        Me.btnguardar = New System.Windows.Forms.Button
        Me.btneliminar = New System.Windows.Forms.Button
        Me.btnmodificar = New System.Windows.Forms.Button
        Me.dtgpedido = New System.Windows.Forms.DataGridView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.lblproductos = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lbltotal = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.btntotales = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbid_agente = New System.Windows.Forms.ComboBox
        Me.cbid_pedido = New System.Windows.Forms.ComboBox
        Me.txtid_cliente = New System.Windows.Forms.TextBox
        Me.txtplazo = New System.Windows.Forms.TextBox
        Me.btndescgeneralp = New System.Windows.Forms.Button
        Me.txt_orden = New System.Windows.Forms.TextBox
        Me.txttransporte = New System.Windows.Forms.TextBox
        Me.txt_observaciones = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblcliente_nombre = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lbldescg = New System.Windows.Forms.Label
        Me.pnencabezado = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbl_orden = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.id_producto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.presentacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tpddescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TPDMonto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tpdiv = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.utilidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.barcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.dtgpedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pnencabezado.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitulo
        '
        Me.lbltitulo.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbltitulo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbltitulo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.White
        Me.lbltitulo.Location = New System.Drawing.Point(-1, -2)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(1022, 28)
        Me.lbltitulo.TabIndex = 12
        Me.lbltitulo.Text = "Pedidos"
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.chkarchivo)
        Me.Panel1.Controls.Add(Me.chkcopia)
        Me.Panel1.Controls.Add(Me.chkoriginal)
        Me.Panel1.Controls.Add(Me.btnimprimir)
        Me.Panel1.Controls.Add(Me.btndescpp)
        Me.Panel1.Controls.Add(Me.btnfacturar)
        Me.Panel1.Controls.Add(Me.btnincluir)
        Me.Panel1.Controls.Add(Me.btnguardar)
        Me.Panel1.Controls.Add(Me.btneliminar)
        Me.Panel1.Controls.Add(Me.btnmodificar)
        Me.Panel1.Controls.Add(Me.dtgpedido)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Location = New System.Drawing.Point(20, 137)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(984, 531)
        Me.Panel1.TabIndex = 33
        '
        'chkarchivo
        '
        Me.chkarchivo.AutoSize = True
        Me.chkarchivo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkarchivo.Location = New System.Drawing.Point(919, 457)
        Me.chkarchivo.Name = "chkarchivo"
        Me.chkarchivo.Size = New System.Drawing.Size(65, 19)
        Me.chkarchivo.TabIndex = 85
        Me.chkarchivo.Text = "Archivo"
        Me.chkarchivo.UseVisualStyleBackColor = True
        Me.chkarchivo.Visible = False
        '
        'chkcopia
        '
        Me.chkcopia.AutoSize = True
        Me.chkcopia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkcopia.Location = New System.Drawing.Point(919, 434)
        Me.chkcopia.Name = "chkcopia"
        Me.chkcopia.Size = New System.Drawing.Size(59, 19)
        Me.chkcopia.TabIndex = 84
        Me.chkcopia.Text = "Copia"
        Me.chkcopia.UseVisualStyleBackColor = True
        Me.chkcopia.Visible = False
        '
        'chkoriginal
        '
        Me.chkoriginal.AutoSize = True
        Me.chkoriginal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkoriginal.Location = New System.Drawing.Point(919, 411)
        Me.chkoriginal.Name = "chkoriginal"
        Me.chkoriginal.Size = New System.Drawing.Size(69, 19)
        Me.chkoriginal.TabIndex = 83
        Me.chkoriginal.Text = "Original"
        Me.chkoriginal.UseVisualStyleBackColor = True
        Me.chkoriginal.Visible = False
        '
        'btnimprimir
        '
        Me.btnimprimir.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimprimir.Image = CType(resources.GetObject("btnimprimir.Image"), System.Drawing.Image)
        Me.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnimprimir.Location = New System.Drawing.Point(927, 357)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(54, 48)
        Me.btnimprimir.TabIndex = 80
        Me.btnimprimir.Text = "Imprimir"
        Me.btnimprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnimprimir.UseVisualStyleBackColor = True
        Me.btnimprimir.Visible = False
        '
        'btndescpp
        '
        Me.btndescpp.Enabled = False
        Me.btndescpp.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndescpp.Image = CType(resources.GetObject("btndescpp.Image"), System.Drawing.Image)
        Me.btndescpp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndescpp.Location = New System.Drawing.Point(925, 165)
        Me.btndescpp.Name = "btndescpp"
        Me.btndescpp.Size = New System.Drawing.Size(54, 48)
        Me.btndescpp.TabIndex = 82
        Me.btndescpp.TabStop = False
        Me.btndescpp.Text = "Desc %"
        Me.btndescpp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btndescpp, "Descuento %")
        Me.btndescpp.UseVisualStyleBackColor = True
        '
        'btnfacturar
        '
        Me.btnfacturar.Enabled = False
        Me.btnfacturar.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfacturar.ForeColor = System.Drawing.Color.Red
        Me.btnfacturar.Image = CType(resources.GetObject("btnfacturar.Image"), System.Drawing.Image)
        Me.btnfacturar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnfacturar.Location = New System.Drawing.Point(926, 303)
        Me.btnfacturar.Name = "btnfacturar"
        Me.btnfacturar.Size = New System.Drawing.Size(54, 48)
        Me.btnfacturar.TabIndex = 79
        Me.btnfacturar.Text = "Factura"
        Me.btnfacturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnfacturar.UseVisualStyleBackColor = True
        '
        'btnincluir
        '
        Me.btnincluir.Enabled = False
        Me.btnincluir.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnincluir.Image = CType(resources.GetObject("btnincluir.Image"), System.Drawing.Image)
        Me.btnincluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnincluir.Location = New System.Drawing.Point(924, 3)
        Me.btnincluir.Name = "btnincluir"
        Me.btnincluir.Size = New System.Drawing.Size(56, 48)
        Me.btnincluir.TabIndex = 77
        Me.btnincluir.Text = "Incluir"
        Me.btnincluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnincluir.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.Image = CType(resources.GetObject("btnguardar.Image"), System.Drawing.Image)
        Me.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardar.Location = New System.Drawing.Point(926, 236)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(54, 48)
        Me.btnguardar.TabIndex = 75
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
        Me.btneliminar.Location = New System.Drawing.Point(926, 111)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(54, 48)
        Me.btneliminar.TabIndex = 74
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
        Me.btnmodificar.Location = New System.Drawing.Point(926, 57)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(54, 48)
        Me.btnmodificar.TabIndex = 73
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'dtgpedido
        '
        Me.dtgpedido.AllowUserToAddRows = False
        Me.dtgpedido.AllowUserToDeleteRows = False
        Me.dtgpedido.AllowUserToResizeColumns = False
        Me.dtgpedido.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgpedido.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgpedido.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgpedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgpedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_producto, Me.cantidad, Me.presentacion, Me.nombre, Me.tpddescuento, Me.Precio, Me.TPDMonto, Me.tpdiv, Me.utilidad, Me.costo, Me.barcode})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgpedido.DefaultCellStyle = DataGridViewCellStyle11
        Me.dtgpedido.Location = New System.Drawing.Point(3, 3)
        Me.dtgpedido.Name = "dtgpedido"
        Me.dtgpedido.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgpedido.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dtgpedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgpedido.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dtgpedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgpedido.Size = New System.Drawing.Size(913, 523)
        Me.dtgpedido.TabIndex = 35
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.CanOverflow = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip1.Enabled = False
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(919, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip1.Size = New System.Drawing.Size(61, 527)
        Me.ToolStrip1.TabIndex = 34
        '
        'lblproductos
        '
        Me.lblproductos.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproductos.Location = New System.Drawing.Point(127, 684)
        Me.lblproductos.Name = "lblproductos"
        Me.lblproductos.Size = New System.Drawing.Size(29, 24)
        Me.lblproductos.TabIndex = 60
        Me.lblproductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 684)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 24)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Productos"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lbltotal)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Location = New System.Drawing.Point(605, 672)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(249, 42)
        Me.Panel3.TabIndex = 61
        '
        'lbltotal
        '
        Me.lbltotal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(72, 6)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(170, 24)
        Me.lbltotal.TabIndex = 58
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 24)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Total"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btntotales
        '
        Me.btntotales.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntotales.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btntotales.Location = New System.Drawing.Point(869, 684)
        Me.btntotales.Name = "btntotales"
        Me.btntotales.Size = New System.Drawing.Size(21, 22)
        Me.btntotales.TabIndex = 59
        Me.btntotales.Text = "+"
        Me.ToolTip1.SetToolTip(Me.btntotales, "Ver Sub Totales")
        Me.btntotales.UseVisualStyleBackColor = True
        '
        'cbid_agente
        '
        Me.cbid_agente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbid_agente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbid_agente.Location = New System.Drawing.Point(77, 32)
        Me.cbid_agente.Name = "cbid_agente"
        Me.cbid_agente.Size = New System.Drawing.Size(270, 26)
        Me.cbid_agente.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.cbid_agente, "Seleccione el Agente")
        '
        'cbid_pedido
        '
        Me.cbid_pedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbid_pedido.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbid_pedido.Location = New System.Drawing.Point(817, 4)
        Me.cbid_pedido.Name = "cbid_pedido"
        Me.cbid_pedido.Size = New System.Drawing.Size(128, 26)
        Me.cbid_pedido.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.cbid_pedido, "Seleccione el Número de Pedido")
        '
        'txtid_cliente
        '
        Me.txtid_cliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid_cliente.Location = New System.Drawing.Point(77, 0)
        Me.txtid_cliente.MaxLength = 4
        Me.txtid_cliente.Name = "txtid_cliente"
        Me.txtid_cliente.Size = New System.Drawing.Size(59, 26)
        Me.txtid_cliente.TabIndex = 0
        Me.txtid_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtid_cliente, "Escriba el Código del Cliente")
        '
        'txtplazo
        '
        Me.txtplazo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplazo.Location = New System.Drawing.Point(688, 3)
        Me.txtplazo.MaxLength = 3
        Me.txtplazo.Name = "txtplazo"
        Me.txtplazo.Size = New System.Drawing.Size(41, 26)
        Me.txtplazo.TabIndex = 1
        Me.txtplazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtplazo, "Escriba el Código del Cliente")
        '
        'btndescgeneralp
        '
        Me.btndescgeneralp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndescgeneralp.ForeColor = System.Drawing.Color.Red
        Me.btndescgeneralp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btndescgeneralp.Location = New System.Drawing.Point(914, 34)
        Me.btndescgeneralp.Name = "btndescgeneralp"
        Me.btndescgeneralp.Size = New System.Drawing.Size(34, 22)
        Me.btndescgeneralp.TabIndex = 65
        Me.btndescgeneralp.Text = "- %"
        Me.ToolTip1.SetToolTip(Me.btndescgeneralp, "Descuento General %")
        Me.btndescgeneralp.UseVisualStyleBackColor = True
        '
        'txt_orden
        '
        Me.txt_orden.BackColor = System.Drawing.Color.CornflowerBlue
        Me.txt_orden.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_orden.Location = New System.Drawing.Point(869, 0)
        Me.txt_orden.MaxLength = 12
        Me.txt_orden.Name = "txt_orden"
        Me.txt_orden.Size = New System.Drawing.Size(131, 26)
        Me.txt_orden.TabIndex = 70
        Me.txt_orden.Text = "000"
        Me.txt_orden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txt_orden, "Escriba el numero de orden")
        Me.txt_orden.Visible = False
        '
        'txttransporte
        '
        Me.txttransporte.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttransporte.Location = New System.Drawing.Point(469, 61)
        Me.txttransporte.MaxLength = 35
        Me.txttransporte.Name = "txttransporte"
        Me.txttransporte.Size = New System.Drawing.Size(328, 26)
        Me.txttransporte.TabIndex = 73
        Me.ToolTip1.SetToolTip(Me.txttransporte, "Escriba el Tipo de Transporte")
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_observaciones.Location = New System.Drawing.Point(97, 96)
        Me.txt_observaciones.MaxLength = 35
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(868, 26)
        Me.txt_observaciones.TabIndex = 74
        Me.ToolTip1.SetToolTip(Me.txt_observaciones, "Escriba el Tipo de Transporte")
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 24)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Cliente"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcliente_nombre
        '
        Me.lblcliente_nombre.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblcliente_nombre.Location = New System.Drawing.Point(142, 2)
        Me.lblcliente_nombre.Name = "lblcliente_nombre"
        Me.lblcliente_nombre.Size = New System.Drawing.Size(478, 24)
        Me.lblcliente_nombre.TabIndex = 38
        Me.lblcliente_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 24)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Agente"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(744, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Pedido"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(626, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Plazo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(807, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 24)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Desc "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbldescg
        '
        Me.lbldescg.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescg.ForeColor = System.Drawing.Color.Red
        Me.lbldescg.Location = New System.Drawing.Point(861, 34)
        Me.lbldescg.Name = "lbldescg"
        Me.lbldescg.Size = New System.Drawing.Size(47, 24)
        Me.lbldescg.TabIndex = 66
        Me.lbldescg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnencabezado
        '
        Me.pnencabezado.Controls.Add(Me.Label5)
        Me.pnencabezado.Controls.Add(Me.btndescgeneralp)
        Me.pnencabezado.Controls.Add(Me.lbldescg)
        Me.pnencabezado.Controls.Add(Me.Label4)
        Me.pnencabezado.Controls.Add(Me.txtplazo)
        Me.pnencabezado.Controls.Add(Me.txtid_cliente)
        Me.pnencabezado.Controls.Add(Me.Label2)
        Me.pnencabezado.Controls.Add(Me.cbid_pedido)
        Me.pnencabezado.Controls.Add(Me.Label1)
        Me.pnencabezado.Controls.Add(Me.cbid_agente)
        Me.pnencabezado.Controls.Add(Me.Label3)
        Me.pnencabezado.Controls.Add(Me.lblcliente_nombre)
        Me.pnencabezado.Controls.Add(Me.Label6)
        Me.pnencabezado.Location = New System.Drawing.Point(20, 29)
        Me.pnencabezado.Name = "pnencabezado"
        Me.pnencabezado.Size = New System.Drawing.Size(956, 63)
        Me.pnencabezado.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(353, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 24)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Transporte"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_orden
        '
        Me.lbl_orden.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lbl_orden.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbl_orden.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orden.ForeColor = System.Drawing.Color.White
        Me.lbl_orden.Location = New System.Drawing.Point(777, 2)
        Me.lbl_orden.Name = "lbl_orden"
        Me.lbl_orden.Size = New System.Drawing.Size(97, 24)
        Me.lbl_orden.TabIndex = 62
        Me.lbl_orden.Text = "Orden #:"
        Me.lbl_orden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_orden.Visible = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 24)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Observ."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.nombre.Width = 450
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
        'Precio
        '
        Me.Precio.DataPropertyName = "precio"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Precio.DefaultCellStyle = DataGridViewCellStyle8
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Precio.Width = 80
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
        'costo
        '
        Me.costo.DataPropertyName = "costo"
        Me.costo.HeaderText = "costo"
        Me.costo.Name = "costo"
        Me.costo.ReadOnly = True
        Me.costo.Visible = False
        '
        'barcode
        '
        Me.barcode.DataPropertyName = "barcode"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.barcode.DefaultCellStyle = DataGridViewCellStyle10
        Me.barcode.HeaderText = "barcode"
        Me.barcode.Name = "barcode"
        Me.barcode.ReadOnly = True
        '
        'frm_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 725)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_observaciones)
        Me.Controls.Add(Me.txttransporte)
        Me.Controls.Add(Me.txt_orden)
        Me.Controls.Add(Me.lbl_orden)
        Me.Controls.Add(Me.pnencabezado)
        Me.Controls.Add(Me.btntotales)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblproductos)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_pedido"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtgpedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.pnencabezado.ResumeLayout(False)
        Me.pnencabezado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgpedido As System.Windows.Forms.DataGridView
    Friend WithEvents lblproductos As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btntotales As System.Windows.Forms.Button
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnincluir As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents btnimprimir As System.Windows.Forms.Button
    Friend WithEvents btnfacturar As System.Windows.Forms.Button
    Friend WithEvents btndescpp As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblcliente_nombre As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbid_agente As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbid_pedido As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtid_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txtplazo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbldescg As System.Windows.Forms.Label
    Friend WithEvents btndescgeneralp As System.Windows.Forms.Button
    Friend WithEvents pnencabezado As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkarchivo As System.Windows.Forms.CheckBox
    Friend WithEvents chkcopia As System.Windows.Forms.CheckBox
    Friend WithEvents chkoriginal As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_orden As System.Windows.Forms.Label
    Friend WithEvents txt_orden As System.Windows.Forms.TextBox
    Friend WithEvents txttransporte As System.Windows.Forms.TextBox
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents id_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents presentacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tpddescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPDMonto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tpdiv As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents utilidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents barcode As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
