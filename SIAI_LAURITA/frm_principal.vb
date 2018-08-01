Imports System.Data.SqlClient


Public Class frm_principal
    Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "
    <System.STAThread()> _
       Public Shared Sub Main()
        System.Windows.Forms.Application.EnableVisualStyles()
        System.Windows.Forms.Application.Run(New frm_principal)
    End Sub
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents sl1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sl2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents btndatos As System.Windows.Forms.ToolStripButton
    Friend WithEvents btncredito As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents TSMestado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMrecibo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMdevolucion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnbodega As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents TSMbajuste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnreporte As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnmovimiento As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents TSMfactura_anular As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMrecibo_anular As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMdevolucion_reversar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnconsulta As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SLBL1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SLBL2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SLBL3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnpedido As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TSMICuentasxcobrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMnotacredito As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMRNC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btncompra As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsmcreditovencido As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReversarNotaDébitoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_principal))
        Me.sl1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.sl2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.PictureBox11 = New System.Windows.Forms.PictureBox
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.btnpedido = New System.Windows.Forms.ToolStripButton
        Me.btncompra = New System.Windows.Forms.ToolStripButton
        Me.btndatos = New System.Windows.Forms.ToolStripButton
        Me.btncredito = New System.Windows.Forms.ToolStripDropDownButton
        Me.TSMestado = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmcreditovencido = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMICuentasxcobrar = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.TSMrecibo = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TSMnotacredito = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.TSMdevolucion = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmind = New System.Windows.Forms.ToolStripMenuItem
        Me.btnbodega = New System.Windows.Forms.ToolStripDropDownButton
        Me.TSMbajuste = New System.Windows.Forms.ToolStripMenuItem
        Me.btnreporte = New System.Windows.Forms.ToolStripButton
        Me.btnmovimiento = New System.Windows.Forms.ToolStripDropDownButton
        Me.TSMfactura_anular = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMrecibo_anular = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMdevolucion_reversar = New System.Windows.Forms.ToolStripMenuItem
        Me.TSMRNC = New System.Windows.Forms.ToolStripMenuItem
        Me.ReversarNotaDébitoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnconsulta = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.SLBL1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.SLBL2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.SLBL3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label12 = New System.Windows.Forms.Label
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'sl1
        '
        Me.sl1.Name = "sl1"
        Me.sl1.Size = New System.Drawing.Size(1013, 17)
        Me.sl1.Spring = True
        Me.sl1.Text = "Best IT"
        Me.sl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sl2
        '
        Me.sl2.Name = "sl2"
        Me.sl2.Size = New System.Drawing.Size(0, 17)
        '
        'PictureBox11
        '
        Me.PictureBox11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(46, 264)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(934, 240)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 26
        Me.PictureBox11.TabStop = False
        '
        'ToolStrip
        '
        Me.ToolStrip.AutoSize = False
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnpedido, Me.btncompra, Me.btndatos, Me.btncredito, Me.btnbodega, Me.btnreporte, Me.btnmovimiento, Me.btnconsulta})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(1028, 61)
        Me.ToolStrip.TabIndex = 27
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'btnpedido
        '
        Me.btnpedido.Image = CType(resources.GetObject("btnpedido.Image"), System.Drawing.Image)
        Me.btnpedido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnpedido.Name = "btnpedido"
        Me.btnpedido.Size = New System.Drawing.Size(96, 58)
        Me.btnpedido.Text = "Pedidos"
        Me.btnpedido.ToolTipText = "Crear, Cargar, Consultar, Facturar Pedidos"
        '
        'btncompra
        '
        Me.btncompra.Image = CType(resources.GetObject("btncompra.Image"), System.Drawing.Image)
        Me.btncompra.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btncompra.Name = "btncompra"
        Me.btncompra.Size = New System.Drawing.Size(101, 58)
        Me.btncompra.Text = "Compras"
        Me.btncompra.ToolTipText = "Consulta e Re Impresión de Docuementos"
        '
        'btndatos
        '
        Me.btndatos.Image = CType(resources.GetObject("btndatos.Image"), System.Drawing.Image)
        Me.btndatos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndatos.Name = "btndatos"
        Me.btndatos.Size = New System.Drawing.Size(87, 58)
        Me.btndatos.Text = "Datos"
        Me.btndatos.ToolTipText = "Agentes, Clientes, Productos, Listas de Precios, Proveedores, Usuarios, Parámetro" & _
            "s"
        '
        'btncredito
        '
        Me.btncredito.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMestado, Me.tsmcreditovencido, Me.TSMICuentasxcobrar, Me.ToolStripSeparator1, Me.TSMrecibo, Me.ToolStripSeparator2, Me.TSMnotacredito, Me.ToolStripSeparator3, Me.TSMdevolucion, Me.ToolStripSeparator4, Me.tsmind})
        Me.btncredito.Image = CType(resources.GetObject("btncredito.Image"), System.Drawing.Image)
        Me.btncredito.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btncredito.Name = "btncredito"
        Me.btncredito.Size = New System.Drawing.Size(103, 58)
        Me.btncredito.Text = "Crédito"
        '
        'TSMestado
        '
        Me.TSMestado.Name = "TSMestado"
        Me.TSMestado.Size = New System.Drawing.Size(197, 22)
        Me.TSMestado.Text = "Movimientos de Cuenta"
        '
        'tsmcreditovencido
        '
        Me.tsmcreditovencido.Name = "tsmcreditovencido"
        Me.tsmcreditovencido.Size = New System.Drawing.Size(197, 22)
        Me.tsmcreditovencido.Text = "Crédito Vencido"
        '
        'TSMICuentasxcobrar
        '
        Me.TSMICuentasxcobrar.Name = "TSMICuentasxcobrar"
        Me.TSMICuentasxcobrar.Size = New System.Drawing.Size(197, 22)
        Me.TSMICuentasxcobrar.Text = "Cuentas x Cobrar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(194, 6)
        '
        'TSMrecibo
        '
        Me.TSMrecibo.Name = "TSMrecibo"
        Me.TSMrecibo.Size = New System.Drawing.Size(197, 22)
        Me.TSMrecibo.Text = "Recibo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(194, 6)
        '
        'TSMnotacredito
        '
        Me.TSMnotacredito.Name = "TSMnotacredito"
        Me.TSMnotacredito.Size = New System.Drawing.Size(197, 22)
        Me.TSMnotacredito.Text = "Nota de Crédito"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(194, 6)
        '
        'TSMdevolucion
        '
        Me.TSMdevolucion.Name = "TSMdevolucion"
        Me.TSMdevolucion.Size = New System.Drawing.Size(197, 22)
        Me.TSMdevolucion.Text = "Devolución"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(194, 6)
        '
        'tsmind
        '
        Me.tsmind.Name = "tsmind"
        Me.tsmind.Size = New System.Drawing.Size(197, 22)
        Me.tsmind.Text = "Nota Débito"
        '
        'btnbodega
        '
        Me.btnbodega.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMbajuste})
        Me.btnbodega.Image = CType(resources.GetObject("btnbodega.Image"), System.Drawing.Image)
        Me.btnbodega.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnbodega.Name = "btnbodega"
        Me.btnbodega.Size = New System.Drawing.Size(104, 58)
        Me.btnbodega.Text = "Bodega"
        '
        'TSMbajuste
        '
        Me.TSMbajuste.Name = "TSMbajuste"
        Me.TSMbajuste.Size = New System.Drawing.Size(116, 22)
        Me.TSMbajuste.Text = "Ajuste"
        '
        'btnreporte
        '
        Me.btnreporte.Image = CType(resources.GetObject("btnreporte.Image"), System.Drawing.Image)
        Me.btnreporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnreporte.Name = "btnreporte"
        Me.btnreporte.Size = New System.Drawing.Size(103, 58)
        Me.btnreporte.Text = "Reportes"
        Me.btnreporte.ToolTipText = "Reportes Varios"
        '
        'btnmovimiento
        '
        Me.btnmovimiento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMfactura_anular, Me.TSMrecibo_anular, Me.TSMdevolucion_reversar, Me.TSMRNC, Me.ReversarNotaDébitoToolStripMenuItem})
        Me.btnmovimiento.Image = CType(resources.GetObject("btnmovimiento.Image"), System.Drawing.Image)
        Me.btnmovimiento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnmovimiento.Name = "btnmovimiento"
        Me.btnmovimiento.Size = New System.Drawing.Size(127, 58)
        Me.btnmovimiento.Text = "Movimientos"
        '
        'TSMfactura_anular
        '
        Me.TSMfactura_anular.Name = "TSMfactura_anular"
        Me.TSMfactura_anular.Size = New System.Drawing.Size(193, 22)
        Me.TSMfactura_anular.Text = "Anular Factura"
        '
        'TSMrecibo_anular
        '
        Me.TSMrecibo_anular.Name = "TSMrecibo_anular"
        Me.TSMrecibo_anular.Size = New System.Drawing.Size(193, 22)
        Me.TSMrecibo_anular.Text = "Anular Recibo"
        '
        'TSMdevolucion_reversar
        '
        Me.TSMdevolucion_reversar.Name = "TSMdevolucion_reversar"
        Me.TSMdevolucion_reversar.Size = New System.Drawing.Size(193, 22)
        Me.TSMdevolucion_reversar.Text = "Reversar Devolución"
        '
        'TSMRNC
        '
        Me.TSMRNC.Name = "TSMRNC"
        Me.TSMRNC.Size = New System.Drawing.Size(193, 22)
        Me.TSMRNC.Text = "Reversar Nota Crédito"
        '
        'ReversarNotaDébitoToolStripMenuItem
        '
        Me.ReversarNotaDébitoToolStripMenuItem.Name = "ReversarNotaDébitoToolStripMenuItem"
        Me.ReversarNotaDébitoToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ReversarNotaDébitoToolStripMenuItem.Text = "Reversar Nota Débito"
        '
        'btnconsulta
        '
        Me.btnconsulta.Image = CType(resources.GetObject("btnconsulta.Image"), System.Drawing.Image)
        Me.btnconsulta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnconsulta.Name = "btnconsulta"
        Me.btnconsulta.Size = New System.Drawing.Size(101, 58)
        Me.btnconsulta.Text = "Consulta"
        Me.btnconsulta.ToolTipText = "Consulta e Re Impresión de Docuementos"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SLBL1, Me.SLBL2, Me.SLBL3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 559)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1028, 24)
        Me.StatusStrip1.TabIndex = 8
        '
        'SLBL1
        '
        Me.SLBL1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.SLBL1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SLBL1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLBL1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.SLBL1.Name = "SLBL1"
        Me.SLBL1.Size = New System.Drawing.Size(1005, 19)
        Me.SLBL1.Spring = True
        Me.SLBL1.Text = "Software by PJC Software 6059.8238"
        Me.SLBL1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SLBL2
        '
        Me.SLBL2.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.SLBL2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.SLBL2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SLBL2.Name = "SLBL2"
        Me.SLBL2.Size = New System.Drawing.Size(4, 19)
        '
        'SLBL3
        '
        Me.SLBL3.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.SLBL3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.SLBL3.Name = "SLBL3"
        Me.SLBL3.Size = New System.Drawing.Size(4, 19)
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.CausesValidation = False
        Me.Label12.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label12.Location = New System.Drawing.Point(0, 640)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 41)
        Me.Label12.TabIndex = 121
        Me.Label12.Text = "PJC Solutions"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label12.Visible = False
        '
        'frm_principal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1028, 583)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_principal"
        Me.Text = "SIG PT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub frm_principal_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub frm_principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btndatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndatos.Click
        ToolStrip.Enabled = False
        Dim datos_mantenimiento As New frm_datos_mantenimiento
        myForms.frm_datos_mantenimiento = datos_mantenimiento
        myForms.frm_datos_mantenimiento.Owner = Me
        datos_mantenimiento.Show()
    End Sub

    Private Sub TSMestado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMestado.Click
        ToolStrip.Enabled = False
        Dim estado As New frm_rpt_estado_opciones
        myForms.frm_rpt_estado_opciones = estado
        myForms.frm_rpt_estado_opciones.Owner = Me
        estado.Show()
    End Sub

    Private Sub TSMrecibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMrecibo.Click
        ToolStrip.Enabled = False
        Consulta = False
        Dim recibo As New frm_recibo
        myForms.frm_recibo = recibo
        myForms.frm_recibo.Owner = Me
        recibo.Show()

    End Sub



    Private Sub TSMdevolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMdevolucion.Click
        ToolStrip.Enabled = False
        Consulta = False
        Dim devolucion As New frm_devolucion
        myForms.frm_devolucion = devolucion
        myForms.frm_devolucion.Owner = Me
        devolucion.Show()

    End Sub


    Private Sub btnreporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreporte.Click
        ToolStrip.Enabled = False
        Dim reportes_admin As New frm_reportes_admin
        myForms.frm_reportes_admin = reportes_admin
        myForms.frm_reportes_admin.Owner = Me
        reportes_admin.Show()
    End Sub

    Private Sub TSMfactura_anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMfactura_anular.Click
        ToolStrip.Enabled = False
        Dim factura_anular As New frm_factura_anular
        factura_anular.Owner = Me
        factura_anular.Show()
    End Sub

    Private Sub TSMrecibo_anular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMrecibo_anular.Click
        ToolStrip.Enabled = False
        Dim recibo_anular As New frm_recibo_anular
        recibo_anular.Owner = Me
        recibo_anular.Show()
    End Sub



    Private Sub TSMdevolucion_reversar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMdevolucion_reversar.Click
        ToolStrip.Enabled = False
        Consulta = False
        Dim devolucion_reversar As New frm_devolucion_reversar
        devolucion_reversar.Owner = Me
        devolucion_reversar.Show()

    End Sub


    Private Sub TSMbajuste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMbajuste.Click
        ToolStrip.Enabled = False
        Dim bodega_ajuste As New frm_Bodega_ajuste
        myForms.frm_bodega_ajuste = frm_Bodega_ajuste
        myForms.frm_bodega_ajuste.Owner = Me
        frm_Bodega_ajuste.Show()
    End Sub

    Private Sub btnconsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsulta.Click
        ToolStrip.Enabled = False
        Dim consulta_documento As New frm_consulta_documento
        myForms.frm_consulta_documento = consulta_documento
        myForms.frm_consulta_documento.Owner = Me
        consulta_documento.Show()
    End Sub

    Private Sub btnpedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpedido.Click
        ToolStrip.Enabled = False
        Consulta = False
        Dim pedido As New frm_pedido
        myForms.frm_pedido = pedido
        myForms.frm_pedido.Owner = Me
        pedido.Show()
    End Sub


    Private Sub TSMICuentasxcobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMICuentasxcobrar.Click
        ToolStrip.Enabled = False
        Dim pendiente As New frm_rpt_cuentasxcobrar
        myForms.frm_cuentasxcobrar = pendiente
        myForms.frm_cuentasxcobrar.Owner = Me
        pendiente.Show()
    End Sub

    Private Sub TSMnotacredito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMnotacredito.Click
        ToolStrip.Enabled = False
        Consulta = False
        Dim nota_credito As New frm_Nota_Credito
        myForms.frm_nota_credito = nota_credito
        myForms.frm_nota_credito.Owner = Me
        nota_credito.Show()
    End Sub

    Private Sub TSMRNC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMRNC.Click
        ToolStrip.Enabled = False
        Consulta = False
        Dim rnc As New frm_Nota_Credito_Reversar
        rnc.Owner = Me
        rnc.Show()
    End Sub

    Private Sub btncompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncompra.Click
        ToolStrip.Enabled = False
        Consulta = False
        Dim compra As New frm_Compra
        myForms.frm_compra = compra
        myForms.frm_compra.Owner = Me
        compra.Show()
    End Sub

    Private Sub tsmcreditovencido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmcreditovencido.Click
        ToolStrip.Enabled = False
        Dim vencido As New frm_rpt_credito_vencido_opciones
        myForms.frm_rpt_credito_vencido_opciones = vencido
        myForms.frm_rpt_credito_vencido_opciones.Owner = Me
        vencido.Show()
    End Sub

    Private Sub tsmind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmind.Click
        ToolStrip.Enabled = False
        Consulta = False
        Dim nota_debito As New frm_Nota_debito
        myForms.frm_nota_debito = nota_debito
        myForms.frm_nota_debito.Owner = Me
        nota_debito.Show()
    End Sub

    Private Sub ReversarNotaDébitoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReversarNotaDébitoToolStripMenuItem.Click
        ToolStrip.Enabled = False
        Consulta = False
        Dim rnd As New frm_Nota_debito_Reversar
        rnd.Owner = Me
        rnd.Show()
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click

    End Sub
End Class
