<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_reportes_admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_reportes_admin))
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtfcp_idcliente = New System.Windows.Forms.TextBox
        Me.rbFacturas_Cliente_Periodo = New System.Windows.Forms.RadioButton
        Me.rbbodega_existencias = New System.Windows.Forms.RadioButton
        Me.cbprecio = New System.Windows.Forms.ComboBox
        Me.rbnca = New System.Windows.Forms.RadioButton
        Me.rbcompras_producto_proveedor = New System.Windows.Forms.RadioButton
        Me.rbcomisiones = New System.Windows.Forms.RadioButton
        Me.lblvncliente_nombre = New System.Windows.Forms.Label
        Me.rbventa_producto_cliente = New System.Windows.Forms.RadioButton
        Me.rbventaxproducto = New System.Windows.Forms.RadioButton
        Me.chkventa = New System.Windows.Forms.CheckBox
        Me.rbnc = New System.Windows.Forms.RadioButton
        Me.rbdevolucion = New System.Windows.Forms.RadioButton
        Me.lblvnid_cliente = New System.Windows.Forms.Label
        Me.txtvnid_cliente = New System.Windows.Forms.TextBox
        Me.cbid_familia = New System.Windows.Forms.ComboBox
        Me.rbbodega_ajuste = New System.Windows.Forms.RadioButton
        Me.rbrecibo = New System.Windows.Forms.RadioButton
        Me.rbventa_neta = New System.Windows.Forms.RadioButton
        Me.rbfactura = New System.Windows.Forms.RadioButton
        Me.rbproducto = New System.Windows.Forms.RadioButton
        Me.rbproveedor = New System.Windows.Forms.RadioButton
        Me.rbagente = New System.Windows.Forms.RadioButton
        Me.rbcliente = New System.Windows.Forms.RadioButton
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.dtpdesde = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtphasta = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblfacxcli = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltitulo
        '
        Me.lbltitulo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbltitulo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lbltitulo.Location = New System.Drawing.Point(1, 8)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(977, 27)
        Me.lbltitulo.TabIndex = 11
        Me.lbltitulo.Text = "Reportes Administrador"
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblfacxcli)
        Me.Panel1.Controls.Add(Me.txtfcp_idcliente)
        Me.Panel1.Controls.Add(Me.rbFacturas_Cliente_Periodo)
        Me.Panel1.Controls.Add(Me.rbbodega_existencias)
        Me.Panel1.Controls.Add(Me.cbprecio)
        Me.Panel1.Controls.Add(Me.rbnca)
        Me.Panel1.Controls.Add(Me.rbcompras_producto_proveedor)
        Me.Panel1.Controls.Add(Me.rbcomisiones)
        Me.Panel1.Controls.Add(Me.lblvncliente_nombre)
        Me.Panel1.Controls.Add(Me.rbventa_producto_cliente)
        Me.Panel1.Controls.Add(Me.rbventaxproducto)
        Me.Panel1.Controls.Add(Me.chkventa)
        Me.Panel1.Controls.Add(Me.rbnc)
        Me.Panel1.Controls.Add(Me.rbdevolucion)
        Me.Panel1.Controls.Add(Me.lblvnid_cliente)
        Me.Panel1.Controls.Add(Me.txtvnid_cliente)
        Me.Panel1.Controls.Add(Me.cbid_familia)
        Me.Panel1.Controls.Add(Me.rbbodega_ajuste)
        Me.Panel1.Controls.Add(Me.rbrecibo)
        Me.Panel1.Controls.Add(Me.rbventa_neta)
        Me.Panel1.Controls.Add(Me.rbfactura)
        Me.Panel1.Controls.Add(Me.rbproducto)
        Me.Panel1.Controls.Add(Me.rbproveedor)
        Me.Panel1.Controls.Add(Me.rbagente)
        Me.Panel1.Controls.Add(Me.rbcliente)
        Me.Panel1.Location = New System.Drawing.Point(12, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(945, 332)
        Me.Panel1.TabIndex = 12
        '
        'txtfcp_idcliente
        '
        Me.txtfcp_idcliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfcp_idcliente.Location = New System.Drawing.Point(580, 146)
        Me.txtfcp_idcliente.MaxLength = 8
        Me.txtfcp_idcliente.Name = "txtfcp_idcliente"
        Me.txtfcp_idcliente.Size = New System.Drawing.Size(38, 26)
        Me.txtfcp_idcliente.TabIndex = 90
        Me.ToolTip1.SetToolTip(Me.txtfcp_idcliente, "Escriba el Código del Cliente")
        '
        'rbFacturas_Cliente_Periodo
        '
        Me.rbFacturas_Cliente_Periodo.AutoSize = True
        Me.rbFacturas_Cliente_Periodo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFacturas_Cliente_Periodo.Location = New System.Drawing.Point(375, 148)
        Me.rbFacturas_Cliente_Periodo.Name = "rbFacturas_Cliente_Periodo"
        Me.rbFacturas_Cliente_Periodo.Size = New System.Drawing.Size(209, 21)
        Me.rbFacturas_Cliente_Periodo.TabIndex = 89
        Me.rbFacturas_Cliente_Periodo.Text = "Facturas x Cliente x Periodo"
        Me.rbFacturas_Cliente_Periodo.UseVisualStyleBackColor = True
        '
        'rbbodega_existencias
        '
        Me.rbbodega_existencias.AutoSize = True
        Me.rbbodega_existencias.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbbodega_existencias.Location = New System.Drawing.Point(11, 295)
        Me.rbbodega_existencias.Name = "rbbodega_existencias"
        Me.rbbodega_existencias.Size = New System.Drawing.Size(155, 21)
        Me.rbbodega_existencias.TabIndex = 88
        Me.rbbodega_existencias.Text = "Bodega Existencias"
        Me.rbbodega_existencias.UseVisualStyleBackColor = True
        '
        'cbprecio
        '
        Me.cbprecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbprecio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbprecio.Items.AddRange(New Object() {"Precio 1", "Precio 2"})
        Me.cbprecio.Location = New System.Drawing.Point(237, 93)
        Me.cbprecio.Name = "cbprecio"
        Me.cbprecio.Size = New System.Drawing.Size(109, 26)
        Me.cbprecio.TabIndex = 87
        Me.ToolTip1.SetToolTip(Me.cbprecio, "Seleccione la Familia")
        Me.cbprecio.Visible = False
        '
        'rbnca
        '
        Me.rbnca.AutoSize = True
        Me.rbnca.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnca.Location = New System.Drawing.Point(11, 232)
        Me.rbnca.Name = "rbnca"
        Me.rbnca.Size = New System.Drawing.Size(220, 21)
        Me.rbnca.TabIndex = 86
        Me.rbnca.Text = "Notas de Crédito Aplicaciones"
        Me.rbnca.UseVisualStyleBackColor = True
        '
        'rbcompras_producto_proveedor
        '
        Me.rbcompras_producto_proveedor.AutoSize = True
        Me.rbcompras_producto_proveedor.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcompras_producto_proveedor.Location = New System.Drawing.Point(375, 93)
        Me.rbcompras_producto_proveedor.Name = "rbcompras_producto_proveedor"
        Me.rbcompras_producto_proveedor.Size = New System.Drawing.Size(243, 21)
        Me.rbcompras_producto_proveedor.TabIndex = 85
        Me.rbcompras_producto_proveedor.Text = "Compras x Producto x Proveedor"
        Me.rbcompras_producto_proveedor.UseVisualStyleBackColor = True
        '
        'rbcomisiones
        '
        Me.rbcomisiones.AutoSize = True
        Me.rbcomisiones.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcomisiones.Location = New System.Drawing.Point(375, 121)
        Me.rbcomisiones.Name = "rbcomisiones"
        Me.rbcomisiones.Size = New System.Drawing.Size(104, 21)
        Me.rbcomisiones.TabIndex = 84
        Me.rbcomisiones.Text = "Comisiones"
        Me.rbcomisiones.UseVisualStyleBackColor = True
        '
        'lblvncliente_nombre
        '
        Me.lblvncliente_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvncliente_nombre.Location = New System.Drawing.Point(627, 69)
        Me.lblvncliente_nombre.Name = "lblvncliente_nombre"
        Me.lblvncliente_nombre.Size = New System.Drawing.Size(306, 45)
        Me.lblvncliente_nombre.TabIndex = 81
        Me.lblvncliente_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rbventa_producto_cliente
        '
        Me.rbventa_producto_cliente.AutoSize = True
        Me.rbventa_producto_cliente.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbventa_producto_cliente.Location = New System.Drawing.Point(375, 39)
        Me.rbventa_producto_cliente.Name = "rbventa_producto_cliente"
        Me.rbventa_producto_cliente.Size = New System.Drawing.Size(204, 21)
        Me.rbventa_producto_cliente.TabIndex = 80
        Me.rbventa_producto_cliente.Text = "Ventas x Producto x Cliente"
        Me.rbventa_producto_cliente.UseVisualStyleBackColor = True
        '
        'rbventaxproducto
        '
        Me.rbventaxproducto.AutoSize = True
        Me.rbventaxproducto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbventaxproducto.Location = New System.Drawing.Point(375, 12)
        Me.rbventaxproducto.Name = "rbventaxproducto"
        Me.rbventaxproducto.Size = New System.Drawing.Size(144, 21)
        Me.rbventaxproducto.TabIndex = 79
        Me.rbventaxproducto.Text = "Ventas x Producto"
        Me.rbventaxproducto.UseVisualStyleBackColor = True
        '
        'chkventa
        '
        Me.chkventa.AutoSize = True
        Me.chkventa.Location = New System.Drawing.Point(543, 69)
        Me.chkventa.Name = "chkventa"
        Me.chkventa.Size = New System.Drawing.Size(15, 14)
        Me.chkventa.TabIndex = 78
        Me.chkventa.UseVisualStyleBackColor = True
        Me.chkventa.Visible = False
        '
        'rbnc
        '
        Me.rbnc.AutoSize = True
        Me.rbnc.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnc.Location = New System.Drawing.Point(11, 202)
        Me.rbnc.Name = "rbnc"
        Me.rbnc.Size = New System.Drawing.Size(135, 21)
        Me.rbnc.TabIndex = 48
        Me.rbnc.Text = "Notas de Crédito"
        Me.rbnc.UseVisualStyleBackColor = True
        '
        'rbdevolucion
        '
        Me.rbdevolucion.AutoSize = True
        Me.rbdevolucion.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbdevolucion.Location = New System.Drawing.Point(11, 175)
        Me.rbdevolucion.Name = "rbdevolucion"
        Me.rbdevolucion.Size = New System.Drawing.Size(114, 21)
        Me.rbdevolucion.TabIndex = 47
        Me.rbdevolucion.Text = "Devoluciones"
        Me.rbdevolucion.UseVisualStyleBackColor = True
        '
        'lblvnid_cliente
        '
        Me.lblvnid_cliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvnid_cliente.Location = New System.Drawing.Point(485, 63)
        Me.lblvnid_cliente.Name = "lblvnid_cliente"
        Me.lblvnid_cliente.Size = New System.Drawing.Size(58, 24)
        Me.lblvnid_cliente.TabIndex = 46
        Me.lblvnid_cliente.Text = "Cliente"
        Me.lblvnid_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblvnid_cliente.Visible = False
        '
        'txtvnid_cliente
        '
        Me.txtvnid_cliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvnid_cliente.Location = New System.Drawing.Point(564, 64)
        Me.txtvnid_cliente.MaxLength = 8
        Me.txtvnid_cliente.Name = "txtvnid_cliente"
        Me.txtvnid_cliente.Size = New System.Drawing.Size(38, 26)
        Me.txtvnid_cliente.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.txtvnid_cliente, "Escriba el Código del Cliente")
        '
        'cbid_familia
        '
        Me.cbid_familia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbid_familia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbid_familia.Location = New System.Drawing.Point(110, 93)
        Me.cbid_familia.Name = "cbid_familia"
        Me.cbid_familia.Size = New System.Drawing.Size(109, 26)
        Me.cbid_familia.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.cbid_familia, "Seleccione la Familia")
        Me.cbid_familia.Visible = False
        '
        'rbbodega_ajuste
        '
        Me.rbbodega_ajuste.AutoSize = True
        Me.rbbodega_ajuste.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbbodega_ajuste.Location = New System.Drawing.Point(11, 263)
        Me.rbbodega_ajuste.Name = "rbbodega_ajuste"
        Me.rbbodega_ajuste.Size = New System.Drawing.Size(127, 21)
        Me.rbbodega_ajuste.TabIndex = 8
        Me.rbbodega_ajuste.Text = "Bodega Ajustes"
        Me.rbbodega_ajuste.UseVisualStyleBackColor = True
        '
        'rbrecibo
        '
        Me.rbrecibo.AutoSize = True
        Me.rbrecibo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbrecibo.Location = New System.Drawing.Point(11, 148)
        Me.rbrecibo.Name = "rbrecibo"
        Me.rbrecibo.Size = New System.Drawing.Size(80, 21)
        Me.rbrecibo.TabIndex = 7
        Me.rbrecibo.Text = "Recibos"
        Me.rbrecibo.UseVisualStyleBackColor = True
        '
        'rbventa_neta
        '
        Me.rbventa_neta.AutoSize = True
        Me.rbventa_neta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbventa_neta.Location = New System.Drawing.Point(375, 66)
        Me.rbventa_neta.Name = "rbventa_neta"
        Me.rbventa_neta.Size = New System.Drawing.Size(112, 21)
        Me.rbventa_neta.TabIndex = 6
        Me.rbventa_neta.Text = "Ventas Netas"
        Me.rbventa_neta.UseVisualStyleBackColor = True
        '
        'rbfactura
        '
        Me.rbfactura.AutoSize = True
        Me.rbfactura.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbfactura.Location = New System.Drawing.Point(11, 121)
        Me.rbfactura.Name = "rbfactura"
        Me.rbfactura.Size = New System.Drawing.Size(84, 21)
        Me.rbfactura.TabIndex = 5
        Me.rbfactura.Text = "Facturas"
        Me.rbfactura.UseVisualStyleBackColor = True
        '
        'rbproducto
        '
        Me.rbproducto.AutoSize = True
        Me.rbproducto.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbproducto.Location = New System.Drawing.Point(11, 93)
        Me.rbproducto.Name = "rbproducto"
        Me.rbproducto.Size = New System.Drawing.Size(93, 21)
        Me.rbproducto.TabIndex = 3
        Me.rbproducto.Text = "Productos"
        Me.rbproducto.UseVisualStyleBackColor = True
        '
        'rbproveedor
        '
        Me.rbproveedor.AutoSize = True
        Me.rbproveedor.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbproveedor.Location = New System.Drawing.Point(11, 66)
        Me.rbproveedor.Name = "rbproveedor"
        Me.rbproveedor.Size = New System.Drawing.Size(109, 21)
        Me.rbproveedor.TabIndex = 2
        Me.rbproveedor.Text = "Proveedores"
        Me.rbproveedor.UseVisualStyleBackColor = True
        '
        'rbagente
        '
        Me.rbagente.AutoSize = True
        Me.rbagente.Checked = True
        Me.rbagente.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbagente.Location = New System.Drawing.Point(11, 12)
        Me.rbagente.Name = "rbagente"
        Me.rbagente.Size = New System.Drawing.Size(79, 21)
        Me.rbagente.TabIndex = 1
        Me.rbagente.TabStop = True
        Me.rbagente.Text = "Agentes"
        Me.rbagente.UseVisualStyleBackColor = True
        '
        'rbcliente
        '
        Me.rbcliente.AutoSize = True
        Me.rbcliente.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcliente.Location = New System.Drawing.Point(11, 39)
        Me.rbcliente.Name = "rbcliente"
        Me.rbcliente.Size = New System.Drawing.Size(79, 21)
        Me.rbcliente.TabIndex = 0
        Me.rbcliente.Text = "Clientes"
        Me.rbcliente.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(502, 427)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(103, 32)
        Me.btncancelar.TabIndex = 14
        Me.btncancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.btncancelar, "No Emitir Reporte")
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(373, 427)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(103, 32)
        Me.btnaceptar.TabIndex = 13
        Me.btnaceptar.Text = "Aceptar"
        Me.ToolTip1.SetToolTip(Me.btnaceptar, "Emitir Reporte")
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'dtpdesde
        '
        Me.dtpdesde.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdesde.Location = New System.Drawing.Point(367, 383)
        Me.dtpdesde.Name = "dtpdesde"
        Me.dtpdesde.Size = New System.Drawing.Size(111, 26)
        Me.dtpdesde.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(303, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 24)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Desde"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtphasta
        '
        Me.dtphasta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtphasta.Location = New System.Drawing.Point(557, 383)
        Me.dtphasta.Name = "dtphasta"
        Me.dtphasta.Size = New System.Drawing.Size(111, 26)
        Me.dtphasta.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(493, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 24)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Hasta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblfacxcli
        '
        Me.lblfacxcli.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfacxcli.Location = New System.Drawing.Point(637, 137)
        Me.lblfacxcli.Name = "lblfacxcli"
        Me.lblfacxcli.Size = New System.Drawing.Size(306, 45)
        Me.lblfacxcli.TabIndex = 91
        Me.lblfacxcli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblfacxcli.Visible = False
        '
        'frm_reportes_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 464)
        Me.Controls.Add(Me.dtphasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpdesde)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_reportes_admin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents dtpdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtphasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbcliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbagente As System.Windows.Forms.RadioButton
    Friend WithEvents rbfactura As System.Windows.Forms.RadioButton
    Friend WithEvents rbproducto As System.Windows.Forms.RadioButton
    Friend WithEvents rbproveedor As System.Windows.Forms.RadioButton
    Friend WithEvents rbventa_neta As System.Windows.Forms.RadioButton
    Friend WithEvents rbrecibo As System.Windows.Forms.RadioButton
    Friend WithEvents rbbodega_ajuste As System.Windows.Forms.RadioButton
    Friend WithEvents cbid_familia As System.Windows.Forms.ComboBox
    Friend WithEvents txtvnid_cliente As System.Windows.Forms.TextBox
    Friend WithEvents lblvnid_cliente As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents rbnc As System.Windows.Forms.RadioButton
    Friend WithEvents rbdevolucion As System.Windows.Forms.RadioButton
    Friend WithEvents chkventa As System.Windows.Forms.CheckBox
    Friend WithEvents rbventaxproducto As System.Windows.Forms.RadioButton
    Friend WithEvents rbventa_producto_cliente As System.Windows.Forms.RadioButton
    Friend WithEvents lblvncliente_nombre As System.Windows.Forms.Label
    Friend WithEvents rbcomisiones As System.Windows.Forms.RadioButton
    Friend WithEvents rbcompras_producto_proveedor As System.Windows.Forms.RadioButton
    Friend WithEvents rbnca As System.Windows.Forms.RadioButton
    Friend WithEvents cbprecio As System.Windows.Forms.ComboBox
    Friend WithEvents rbbodega_existencias As System.Windows.Forms.RadioButton
    Friend WithEvents txtfcp_idcliente As System.Windows.Forms.TextBox
    Friend WithEvents rbFacturas_Cliente_Periodo As System.Windows.Forms.RadioButton
    Friend WithEvents lblfacxcli As System.Windows.Forms.Label
End Class
