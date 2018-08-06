Imports System.Data.sqlclient
Imports System.Math

Public Class frm_datos_mantenimiento
    Inherits System.Windows.Forms.Form
    Friend WithEvents Tabparametro As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Tabusuario As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents id_usuario As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Tabproveedor As System.Windows.Forms.TabPage
    Friend WithEvents txtbuscar_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents telefono1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents nombreproveedor As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents id_proveedor As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Vencimiento As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents descuento_introduccion As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents comision As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents valor As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents nombretsprecio As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents id_productotsprecio As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Tabproducto As System.Windows.Forms.TabPage
    Friend WithEvents btneliminar_producto As System.Windows.Forms.Button
    Friend WithEvents btncambiar_producto As System.Windows.Forms.Button
    Friend WithEvents btnincluir_producto As System.Windows.Forms.Button
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents txtbuscar_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents unidad As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents nombreproducto As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents id_producto As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Tabcliente As System.Windows.Forms.TabPage
    Friend WithEvents btneliminar_cliente As System.Windows.Forms.Button
    Friend WithEvents btncambiar_cliente As System.Windows.Forms.Button
    Friend WithEvents btnincluir_cliente As System.Windows.Forms.Button
    Friend WithEvents txtbuscar_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents telefonocliente As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents nombresociedad As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents id_cliente As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Tabagente As System.Windows.Forms.TabPage
    Friend WithEvents btneliminar_agente As System.Windows.Forms.Button
    Friend WithEvents btncambiar_agente As System.Windows.Forms.Button
    Friend WithEvents btnincluir_agente As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Txtbuscar_agente As System.Windows.Forms.TextBox
    Friend WithEvents btnsalir_Agente As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents telefono As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents id_agente As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Tabdatos_mantenimiento As System.Windows.Forms.TabControl
    Friend WithEvents btneliminar_proveedor As System.Windows.Forms.Button
    Friend WithEvents btncambiar_proveedor As System.Windows.Forms.Button
    Friend WithEvents btnincluir_proveedor As System.Windows.Forms.Button
    Friend WithEvents btnmodificar_parametro As System.Windows.Forms.Button
    Friend WithEvents btneliminar_usuario As System.Windows.Forms.Button
    Friend WithEvents btncambiar_usuario As System.Windows.Forms.Button
    Friend WithEvents btnincluir_usuario As System.Windows.Forms.Button

    Public DaAgente As SqlDataAdapter
    Public DsAgente As DataSet
    Public Dvagente As DataView
    Public rowa As DataRow


    Public Dacliente As SqlDataAdapter
    Public Dscliente As DataSet
    Public Dvcliente As DataView
    Public Agente As DataTable
    Dim Grupo As DataTable
    Public rowc As DataRow


    Public DaProveedor As SqlDataAdapter
    Public DsProveedor As DataSet
    Public DvProveedor As DataView
    Public rowprv As DataRow


    Public Dafamilia As SqlDataAdapter
    Public Dsfamilia As DataSet
    Public Dvfamilia As DataView
    Public rowf As DataRow

    Public Daproducto As SqlDataAdapter
    Public Dsproducto As DataSet
    Public Dvproducto As DataView
    Public rowprd As DataRow


    Public LP As DataTable
    Public Bodega As DataTable
    Public Familia As DataTable
    Public Proveedor As DataTable
    Public Producto As DataTable

    Public Dausuario As SqlDataAdapter
    Public Dsusuario As DataSet
    Public Dvusuario As DataView
    Public rowu As DataRow

    Public Daparametro As SqlDataAdapter
    Public Dsparametro As DataSet
    Public rowp As DataRow


    Dim TLPD As DataTable
    Public LPD As DataTable
    Public DvLPD As DataView
    Public rowlpd As DataRow


   

    Dim Building As Boolean

    Private ReadOnly key() As Byte = _
                  {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, _
                  15, 16, 17, 18, 19, 20, 21, 22, 23, 24}
    Private ReadOnly iv() As Byte = {8, 7, 6, 5, 4, 3, 2, 1}

    Private TripleDES As New TripleDES(key, iv)

    Dim cmd As New SqlCommand

    Friend WithEvents lbliv As System.Windows.Forms.Label
    Friend WithEvents lblm1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents dtgagente As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtgcliente As System.Windows.Forms.DataGridView
    Friend WithEvents tsproducto_presentacion As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents tsproducto_nombre As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents tsproducto_id_producto As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dtgproducto As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dtgproveedor As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents dtgusuario As System.Windows.Forms.DataGridView
    Friend WithEvents lblm3 As System.Windows.Forms.Label
    Friend WithEvents dtguusuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents univel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unombre_real As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtguid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uclave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uobseravaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ueliminado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgprvid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prpais As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents premail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prtelefono1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prtelefono2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prtelefono3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prcontacto1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prcontacto2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prcontacto3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents probservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preliminado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgaid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtganombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgatelefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents aidentificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents aobservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgaeliminado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tabfamilia As System.Windows.Forms.TabPage
    Friend WithEvents btncerrar_familia As System.Windows.Forms.Button
    Friend WithEvents dtgfamilia As System.Windows.Forms.DataGridView
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnmodificar_familia As System.Windows.Forms.Button
    Friend WithEvents btnincluir_familia As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtgfid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgprdid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents piv As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents pid_proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pid_familia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pobservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ppresentacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents eliminado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents existencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pid_proverdor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pbarcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtgcid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cnombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTelefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdireccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cidentificacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cplazo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cnombre_sociedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cfax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cemail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cnombre_encargado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctelefono_encargado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents climite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cid_agente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cid_lista As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cobservaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents celiminado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_grupo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents distrito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents canton As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_zona As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblm2 As System.Windows.Forms.Label



#Region " Windows Form Designer generated code "
    <System.STAThread()> _
       Public Shared Sub Main()
        System.Windows.Forms.Application.EnableVisualStyles()

        System.Windows.Forms.Application.Run(New frm_datos_mantenimiento)
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_datos_mantenimiento))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtbuscar_proveedor = New System.Windows.Forms.TextBox
        Me.txtbuscar_producto = New System.Windows.Forms.TextBox
        Me.txtbuscar_cliente = New System.Windows.Forms.TextBox
        Me.btnsalir_Agente = New System.Windows.Forms.Button
        Me.Txtbuscar_agente = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.btnmodificar_parametro = New System.Windows.Forms.Button
        Me.btneliminar_usuario = New System.Windows.Forms.Button
        Me.btncambiar_usuario = New System.Windows.Forms.Button
        Me.btnincluir_usuario = New System.Windows.Forms.Button
        Me.btneliminar_proveedor = New System.Windows.Forms.Button
        Me.btncambiar_proveedor = New System.Windows.Forms.Button
        Me.btnincluir_proveedor = New System.Windows.Forms.Button
        Me.btneliminar_producto = New System.Windows.Forms.Button
        Me.btncambiar_producto = New System.Windows.Forms.Button
        Me.btnincluir_producto = New System.Windows.Forms.Button
        Me.btneliminar_cliente = New System.Windows.Forms.Button
        Me.btncambiar_cliente = New System.Windows.Forms.Button
        Me.btnincluir_cliente = New System.Windows.Forms.Button
        Me.btneliminar_agente = New System.Windows.Forms.Button
        Me.btncambiar_agente = New System.Windows.Forms.Button
        Me.btnincluir_agente = New System.Windows.Forms.Button
        Me.btncerrar_familia = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.btnmodificar_familia = New System.Windows.Forms.Button
        Me.btnincluir_familia = New System.Windows.Forms.Button
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.Tabparametro = New System.Windows.Forms.TabPage
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblm3 = New System.Windows.Forms.Label
        Me.lblm2 = New System.Windows.Forms.Label
        Me.lblm1 = New System.Windows.Forms.Label
        Me.lbliv = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Tabusuario = New System.Windows.Forms.TabPage
        Me.dtgusuario = New System.Windows.Forms.DataGridView
        Me.dtguusuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.univel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.unombre_real = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dtguid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.uclave = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.uobseravaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ueliminado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.id_usuario = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Tabproveedor = New System.Windows.Forms.TabPage
        Me.dtgproveedor = New System.Windows.Forms.DataGridView
        Me.dtgprvid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.prNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.prpais = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.premail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.prtelefono1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.prtelefono2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.prtelefono3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.prcontacto1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.prcontacto2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.prcontacto3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.probservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.preliminado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.telefono1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.nombreproveedor = New System.Windows.Forms.DataGridTextBoxColumn
        Me.id_proveedor = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Vencimiento = New System.Windows.Forms.DataGridTextBoxColumn
        Me.descuento_introduccion = New System.Windows.Forms.DataGridTextBoxColumn
        Me.comision = New System.Windows.Forms.DataGridTextBoxColumn
        Me.valor = New System.Windows.Forms.DataGridTextBoxColumn
        Me.nombretsprecio = New System.Windows.Forms.DataGridTextBoxColumn
        Me.id_productotsprecio = New System.Windows.Forms.DataGridTextBoxColumn
        Me.descripcion = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Tabproducto = New System.Windows.Forms.TabPage
        Me.dtgproducto = New System.Windows.Forms.DataGridView
        Me.dtgprdid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.precio1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.precio2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.piv = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.pid_proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pid_familia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pobservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ppresentacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.eliminado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.existencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pid_proverdor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pbarcode = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.unidad = New System.Windows.Forms.DataGridTextBoxColumn
        Me.nombreproducto = New System.Windows.Forms.DataGridTextBoxColumn
        Me.id_producto = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Tabcliente = New System.Windows.Forms.TabPage
        Me.dtgcliente = New System.Windows.Forms.DataGridView
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.telefonocliente = New System.Windows.Forms.DataGridTextBoxColumn
        Me.nombresociedad = New System.Windows.Forms.DataGridTextBoxColumn
        Me.id_cliente = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Tabagente = New System.Windows.Forms.TabPage
        Me.dtgagente = New System.Windows.Forms.DataGridView
        Me.dtgaid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dtganombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dtgatelefono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.aidentificacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.aobservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dtgaeliminado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.telefono = New System.Windows.Forms.DataGridTextBoxColumn
        Me.nombre = New System.Windows.Forms.DataGridTextBoxColumn
        Me.id_agente = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Tabdatos_mantenimiento = New System.Windows.Forms.TabControl
        Me.tabfamilia = New System.Windows.Forms.TabPage
        Me.dtgfamilia = New System.Windows.Forms.DataGridView
        Me.dtgfid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.tsproducto_presentacion = New System.Windows.Forms.DataGridTextBoxColumn
        Me.tsproducto_nombre = New System.Windows.Forms.DataGridTextBoxColumn
        Me.tsproducto_id_producto = New System.Windows.Forms.DataGridTextBoxColumn
        Me.dtgcid = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cnombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cdireccion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cidentificacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cplazo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cnombre_sociedad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cfax = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cemail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cnombre_encargado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ctelefono_encargado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.climite = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cid_agente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cid_lista = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cobservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.celiminado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_grupo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_precio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.provincia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.distrito = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.canton = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_zona = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tabparametro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Tabusuario.SuspendLayout()
        CType(Me.dtgusuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabproveedor.SuspendLayout()
        CType(Me.dtgproveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabproducto.SuspendLayout()
        CType(Me.dtgproducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabcliente.SuspendLayout()
        CType(Me.dtgcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabagente.SuspendLayout()
        CType(Me.dtgagente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabdatos_mantenimiento.SuspendLayout()
        Me.tabfamilia.SuspendLayout()
        CType(Me.dtgfamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbuscar_proveedor
        '
        Me.txtbuscar_proveedor.AccessibleDescription = ""
        Me.txtbuscar_proveedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar_proveedor.Location = New System.Drawing.Point(272, 544)
        Me.txtbuscar_proveedor.Name = "txtbuscar_proveedor"
        Me.txtbuscar_proveedor.Size = New System.Drawing.Size(232, 26)
        Me.txtbuscar_proveedor.TabIndex = 23
        Me.txtbuscar_proveedor.Tag = ""
        Me.ToolTip1.SetToolTip(Me.txtbuscar_proveedor, "Busqueda de clientes por palabra clave")
        '
        'txtbuscar_producto
        '
        Me.txtbuscar_producto.AccessibleDescription = ""
        Me.txtbuscar_producto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar_producto.Location = New System.Drawing.Point(264, 552)
        Me.txtbuscar_producto.Name = "txtbuscar_producto"
        Me.txtbuscar_producto.Size = New System.Drawing.Size(232, 26)
        Me.txtbuscar_producto.TabIndex = 19
        Me.txtbuscar_producto.Tag = ""
        Me.ToolTip1.SetToolTip(Me.txtbuscar_producto, "Busqueda de productos por palabra clave")
        '
        'txtbuscar_cliente
        '
        Me.txtbuscar_cliente.AccessibleDescription = ""
        Me.txtbuscar_cliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar_cliente.Location = New System.Drawing.Point(270, 549)
        Me.txtbuscar_cliente.Name = "txtbuscar_cliente"
        Me.txtbuscar_cliente.Size = New System.Drawing.Size(240, 26)
        Me.txtbuscar_cliente.TabIndex = 12
        Me.txtbuscar_cliente.Tag = ""
        Me.ToolTip1.SetToolTip(Me.txtbuscar_cliente, "Busqueda de clientes por palabra clave")
        '
        'btnsalir_Agente
        '
        Me.btnsalir_Agente.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir_Agente.Image = CType(resources.GetObject("btnsalir_Agente.Image"), System.Drawing.Image)
        Me.btnsalir_Agente.Location = New System.Drawing.Point(746, 1)
        Me.btnsalir_Agente.Name = "btnsalir_Agente"
        Me.btnsalir_Agente.Size = New System.Drawing.Size(23, 21)
        Me.btnsalir_Agente.TabIndex = 5
        Me.btnsalir_Agente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnsalir_Agente, "Sale de Mantenimiento de Datos")
        '
        'Txtbuscar_agente
        '
        Me.Txtbuscar_agente.AccessibleDescription = ""
        Me.Txtbuscar_agente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbuscar_agente.Location = New System.Drawing.Point(272, 544)
        Me.Txtbuscar_agente.Name = "Txtbuscar_agente"
        Me.Txtbuscar_agente.Size = New System.Drawing.Size(224, 26)
        Me.Txtbuscar_agente.TabIndex = 0
        Me.Txtbuscar_agente.Tag = ""
        Me.ToolTip1.SetToolTip(Me.Txtbuscar_agente, "Busqueda de agentes por palabra clave")
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(748, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 21)
        Me.Button1.TabIndex = 27
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Sale de Mantenimiento de Datos")
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(746, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(23, 21)
        Me.Button2.TabIndex = 31
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Sale de Mantenimiento de Datos")
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(748, 1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(23, 21)
        Me.Button4.TabIndex = 36
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Sale de Mantenimiento de Datos")
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(746, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(23, 21)
        Me.Button5.TabIndex = 40
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button5, "Sale de Mantenimiento de Datos")
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(746, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(23, 21)
        Me.Button6.TabIndex = 37
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button6, "Sale de Mantenimiento de Datos")
        '
        'btnmodificar_parametro
        '
        Me.btnmodificar_parametro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar_parametro.Image = CType(resources.GetObject("btnmodificar_parametro.Image"), System.Drawing.Image)
        Me.btnmodificar_parametro.Location = New System.Drawing.Point(367, 590)
        Me.btnmodificar_parametro.Name = "btnmodificar_parametro"
        Me.btnmodificar_parametro.Size = New System.Drawing.Size(40, 48)
        Me.btnmodificar_parametro.TabIndex = 24
        Me.btnmodificar_parametro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnmodificar_parametro, "Modificar Parámetro")
        Me.btnmodificar_parametro.UseVisualStyleBackColor = True
        '
        'btneliminar_usuario
        '
        Me.btneliminar_usuario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar_usuario.Image = CType(resources.GetObject("btneliminar_usuario.Image"), System.Drawing.Image)
        Me.btneliminar_usuario.Location = New System.Drawing.Point(411, 590)
        Me.btneliminar_usuario.Name = "btneliminar_usuario"
        Me.btneliminar_usuario.Size = New System.Drawing.Size(40, 48)
        Me.btneliminar_usuario.TabIndex = 39
        Me.btneliminar_usuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btneliminar_usuario, "Eliminar Usuario")
        Me.btneliminar_usuario.UseVisualStyleBackColor = True
        '
        'btncambiar_usuario
        '
        Me.btncambiar_usuario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncambiar_usuario.Image = CType(resources.GetObject("btncambiar_usuario.Image"), System.Drawing.Image)
        Me.btncambiar_usuario.Location = New System.Drawing.Point(363, 590)
        Me.btncambiar_usuario.Name = "btncambiar_usuario"
        Me.btncambiar_usuario.Size = New System.Drawing.Size(40, 48)
        Me.btncambiar_usuario.TabIndex = 38
        Me.btncambiar_usuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btncambiar_usuario, "Modificar Usuario")
        Me.btncambiar_usuario.UseVisualStyleBackColor = True
        '
        'btnincluir_usuario
        '
        Me.btnincluir_usuario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnincluir_usuario.Image = CType(resources.GetObject("btnincluir_usuario.Image"), System.Drawing.Image)
        Me.btnincluir_usuario.Location = New System.Drawing.Point(315, 590)
        Me.btnincluir_usuario.Name = "btnincluir_usuario"
        Me.btnincluir_usuario.Size = New System.Drawing.Size(40, 48)
        Me.btnincluir_usuario.TabIndex = 37
        Me.btnincluir_usuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnincluir_usuario, "Incluir Usuario")
        Me.btnincluir_usuario.UseVisualStyleBackColor = True
        '
        'btneliminar_proveedor
        '
        Me.btneliminar_proveedor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar_proveedor.Image = CType(resources.GetObject("btneliminar_proveedor.Image"), System.Drawing.Image)
        Me.btneliminar_proveedor.Location = New System.Drawing.Point(418, 590)
        Me.btneliminar_proveedor.Name = "btneliminar_proveedor"
        Me.btneliminar_proveedor.Size = New System.Drawing.Size(40, 48)
        Me.btneliminar_proveedor.TabIndex = 33
        Me.btneliminar_proveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btneliminar_proveedor, "Eliminar Proveedor")
        Me.btneliminar_proveedor.UseVisualStyleBackColor = True
        '
        'btncambiar_proveedor
        '
        Me.btncambiar_proveedor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncambiar_proveedor.Image = CType(resources.GetObject("btncambiar_proveedor.Image"), System.Drawing.Image)
        Me.btncambiar_proveedor.Location = New System.Drawing.Point(370, 590)
        Me.btncambiar_proveedor.Name = "btncambiar_proveedor"
        Me.btncambiar_proveedor.Size = New System.Drawing.Size(40, 48)
        Me.btncambiar_proveedor.TabIndex = 32
        Me.btncambiar_proveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btncambiar_proveedor, "Modificar Proveedor")
        Me.btncambiar_proveedor.UseVisualStyleBackColor = True
        '
        'btnincluir_proveedor
        '
        Me.btnincluir_proveedor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnincluir_proveedor.Image = CType(resources.GetObject("btnincluir_proveedor.Image"), System.Drawing.Image)
        Me.btnincluir_proveedor.Location = New System.Drawing.Point(322, 590)
        Me.btnincluir_proveedor.Name = "btnincluir_proveedor"
        Me.btnincluir_proveedor.Size = New System.Drawing.Size(40, 48)
        Me.btnincluir_proveedor.TabIndex = 31
        Me.btnincluir_proveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnincluir_proveedor, "Incluir Proveedor")
        Me.btnincluir_proveedor.UseVisualStyleBackColor = True
        '
        'btneliminar_producto
        '
        Me.btneliminar_producto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar_producto.Image = CType(resources.GetObject("btneliminar_producto.Image"), System.Drawing.Image)
        Me.btneliminar_producto.Location = New System.Drawing.Point(411, 590)
        Me.btneliminar_producto.Name = "btneliminar_producto"
        Me.btneliminar_producto.Size = New System.Drawing.Size(40, 48)
        Me.btneliminar_producto.TabIndex = 29
        Me.btneliminar_producto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btneliminar_producto, "Eliminar Producto")
        Me.btneliminar_producto.UseVisualStyleBackColor = True
        '
        'btncambiar_producto
        '
        Me.btncambiar_producto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncambiar_producto.Image = CType(resources.GetObject("btncambiar_producto.Image"), System.Drawing.Image)
        Me.btncambiar_producto.Location = New System.Drawing.Point(363, 590)
        Me.btncambiar_producto.Name = "btncambiar_producto"
        Me.btncambiar_producto.Size = New System.Drawing.Size(40, 48)
        Me.btncambiar_producto.TabIndex = 28
        Me.btncambiar_producto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btncambiar_producto, "Modificar Producto")
        Me.btncambiar_producto.UseVisualStyleBackColor = True
        '
        'btnincluir_producto
        '
        Me.btnincluir_producto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnincluir_producto.Image = CType(resources.GetObject("btnincluir_producto.Image"), System.Drawing.Image)
        Me.btnincluir_producto.Location = New System.Drawing.Point(315, 590)
        Me.btnincluir_producto.Name = "btnincluir_producto"
        Me.btnincluir_producto.Size = New System.Drawing.Size(40, 48)
        Me.btnincluir_producto.TabIndex = 27
        Me.btnincluir_producto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnincluir_producto, "Incluir Producto")
        Me.btnincluir_producto.UseVisualStyleBackColor = True
        '
        'btneliminar_cliente
        '
        Me.btneliminar_cliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar_cliente.Image = CType(resources.GetObject("btneliminar_cliente.Image"), System.Drawing.Image)
        Me.btneliminar_cliente.Location = New System.Drawing.Point(418, 591)
        Me.btneliminar_cliente.Name = "btneliminar_cliente"
        Me.btneliminar_cliente.Size = New System.Drawing.Size(40, 48)
        Me.btneliminar_cliente.TabIndex = 25
        Me.btneliminar_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btneliminar_cliente, "Eliminar Cliente")
        Me.btneliminar_cliente.UseVisualStyleBackColor = True
        '
        'btncambiar_cliente
        '
        Me.btncambiar_cliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncambiar_cliente.Image = CType(resources.GetObject("btncambiar_cliente.Image"), System.Drawing.Image)
        Me.btncambiar_cliente.Location = New System.Drawing.Point(370, 591)
        Me.btncambiar_cliente.Name = "btncambiar_cliente"
        Me.btncambiar_cliente.Size = New System.Drawing.Size(40, 48)
        Me.btncambiar_cliente.TabIndex = 24
        Me.btncambiar_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btncambiar_cliente, "Modificar Cliente")
        Me.btncambiar_cliente.UseVisualStyleBackColor = True
        '
        'btnincluir_cliente
        '
        Me.btnincluir_cliente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnincluir_cliente.Image = CType(resources.GetObject("btnincluir_cliente.Image"), System.Drawing.Image)
        Me.btnincluir_cliente.Location = New System.Drawing.Point(322, 591)
        Me.btnincluir_cliente.Name = "btnincluir_cliente"
        Me.btnincluir_cliente.Size = New System.Drawing.Size(40, 48)
        Me.btnincluir_cliente.TabIndex = 23
        Me.btnincluir_cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnincluir_cliente, "Incluir Cliente")
        Me.btnincluir_cliente.UseVisualStyleBackColor = True
        '
        'btneliminar_agente
        '
        Me.btneliminar_agente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btneliminar_agente.Image = CType(resources.GetObject("btneliminar_agente.Image"), System.Drawing.Image)
        Me.btneliminar_agente.Location = New System.Drawing.Point(419, 590)
        Me.btneliminar_agente.Name = "btneliminar_agente"
        Me.btneliminar_agente.Size = New System.Drawing.Size(40, 48)
        Me.btneliminar_agente.TabIndex = 22
        Me.btneliminar_agente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btneliminar_agente, "Eliminar Agente")
        Me.btneliminar_agente.UseVisualStyleBackColor = True
        '
        'btncambiar_agente
        '
        Me.btncambiar_agente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncambiar_agente.Image = CType(resources.GetObject("btncambiar_agente.Image"), System.Drawing.Image)
        Me.btncambiar_agente.Location = New System.Drawing.Point(371, 590)
        Me.btncambiar_agente.Name = "btncambiar_agente"
        Me.btncambiar_agente.Size = New System.Drawing.Size(40, 48)
        Me.btncambiar_agente.TabIndex = 21
        Me.btncambiar_agente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btncambiar_agente, "Modificar Agente")
        Me.btncambiar_agente.UseVisualStyleBackColor = True
        '
        'btnincluir_agente
        '
        Me.btnincluir_agente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnincluir_agente.Image = CType(resources.GetObject("btnincluir_agente.Image"), System.Drawing.Image)
        Me.btnincluir_agente.Location = New System.Drawing.Point(323, 590)
        Me.btnincluir_agente.Name = "btnincluir_agente"
        Me.btnincluir_agente.Size = New System.Drawing.Size(40, 48)
        Me.btnincluir_agente.TabIndex = 20
        Me.btnincluir_agente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnincluir_agente, "Incluir Agente")
        Me.btnincluir_agente.UseVisualStyleBackColor = True
        '
        'btncerrar_familia
        '
        Me.btncerrar_familia.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar_familia.Image = CType(resources.GetObject("btncerrar_familia.Image"), System.Drawing.Image)
        Me.btncerrar_familia.Location = New System.Drawing.Point(752, 3)
        Me.btncerrar_familia.Name = "btncerrar_familia"
        Me.btncerrar_familia.Size = New System.Drawing.Size(23, 21)
        Me.btncerrar_familia.TabIndex = 42
        Me.btncerrar_familia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btncerrar_familia, "Sale de Mantenimiento de Datos")
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(422, 592)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(40, 48)
        Me.Button7.TabIndex = 40
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button7, "Eliminar Proveedor")
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btnmodificar_familia
        '
        Me.btnmodificar_familia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar_familia.Image = CType(resources.GetObject("btnmodificar_familia.Image"), System.Drawing.Image)
        Me.btnmodificar_familia.Location = New System.Drawing.Point(374, 592)
        Me.btnmodificar_familia.Name = "btnmodificar_familia"
        Me.btnmodificar_familia.Size = New System.Drawing.Size(40, 48)
        Me.btnmodificar_familia.TabIndex = 39
        Me.btnmodificar_familia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnmodificar_familia, "Modificar Proveedor")
        Me.btnmodificar_familia.UseVisualStyleBackColor = True
        '
        'btnincluir_familia
        '
        Me.btnincluir_familia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnincluir_familia.Image = CType(resources.GetObject("btnincluir_familia.Image"), System.Drawing.Image)
        Me.btnincluir_familia.Location = New System.Drawing.Point(326, 592)
        Me.btnincluir_familia.Name = "btnincluir_familia"
        Me.btnincluir_familia.Size = New System.Drawing.Size(40, 48)
        Me.btnincluir_familia.TabIndex = 38
        Me.btnincluir_familia.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnincluir_familia, "Incluir Proveedor")
        Me.btnincluir_familia.UseVisualStyleBackColor = True
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.FalseValue = "No"
        Me.DataGridBoolColumn1.HeaderText = "Pendientes"
        Me.DataGridBoolColumn1.MappingName = "pendiente"
        Me.DataGridBoolColumn1.ReadOnly = True
        Me.DataGridBoolColumn1.TrueValue = "Si"
        Me.DataGridBoolColumn1.Width = 75
        '
        'Tabparametro
        '
        Me.Tabparametro.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Tabparametro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tabparametro.Controls.Add(Me.Button6)
        Me.Tabparametro.Controls.Add(Me.btnmodificar_parametro)
        Me.Tabparametro.Controls.Add(Me.Label12)
        Me.Tabparametro.Controls.Add(Me.GroupBox1)
        Me.Tabparametro.Location = New System.Drawing.Point(4, 28)
        Me.Tabparametro.Name = "Tabparametro"
        Me.Tabparametro.Size = New System.Drawing.Size(776, 648)
        Me.Tabparametro.TabIndex = 4
        Me.Tabparametro.Text = "Parámetros"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label12.Location = New System.Drawing.Point(112, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(208, 40)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Parámetros"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblm3)
        Me.GroupBox1.Controls.Add(Me.lblm2)
        Me.GroupBox1.Controls.Add(Me.lblm1)
        Me.GroupBox1.Controls.Add(Me.lbliv)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(112, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 154)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'lblm3
        '
        Me.lblm3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm3.Location = New System.Drawing.Point(158, 120)
        Me.lblm3.Name = "lblm3"
        Me.lblm3.Size = New System.Drawing.Size(396, 24)
        Me.lblm3.TabIndex = 20
        '
        'lblm2
        '
        Me.lblm2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm2.Location = New System.Drawing.Point(158, 96)
        Me.lblm2.Name = "lblm2"
        Me.lblm2.Size = New System.Drawing.Size(396, 24)
        Me.lblm2.TabIndex = 19
        '
        'lblm1
        '
        Me.lblm1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblm1.Location = New System.Drawing.Point(158, 72)
        Me.lblm1.Name = "lblm1"
        Me.lblm1.Size = New System.Drawing.Size(396, 24)
        Me.lblm1.TabIndex = 18
        '
        'lbliv
        '
        Me.lbliv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliv.Location = New System.Drawing.Point(155, 24)
        Me.lbliv.Name = "lbliv"
        Me.lbliv.Size = New System.Drawing.Size(53, 24)
        Me.lbliv.TabIndex = 17
        Me.lbliv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(205, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 24)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "%"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Mensaje Factura"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 24)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Impuesto de Venta"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tabusuario
        '
        Me.Tabusuario.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Tabusuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tabusuario.Controls.Add(Me.dtgusuario)
        Me.Tabusuario.Controls.Add(Me.Button5)
        Me.Tabusuario.Controls.Add(Me.btneliminar_usuario)
        Me.Tabusuario.Controls.Add(Me.btncambiar_usuario)
        Me.Tabusuario.Controls.Add(Me.btnincluir_usuario)
        Me.Tabusuario.Controls.Add(Me.Label6)
        Me.Tabusuario.Location = New System.Drawing.Point(4, 28)
        Me.Tabusuario.Name = "Tabusuario"
        Me.Tabusuario.Size = New System.Drawing.Size(776, 648)
        Me.Tabusuario.TabIndex = 5
        Me.Tabusuario.Text = "Usuarios"
        '
        'dtgusuario
        '
        Me.dtgusuario.AllowUserToAddRows = False
        Me.dtgusuario.AllowUserToDeleteRows = False
        Me.dtgusuario.AllowUserToResizeColumns = False
        Me.dtgusuario.AllowUserToResizeRows = False
        Me.dtgusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgusuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtguusuario, Me.univel, Me.unombre_real, Me.dtguid, Me.uclave, Me.uobseravaciones, Me.ueliminado})
        Me.dtgusuario.Location = New System.Drawing.Point(149, 55)
        Me.dtgusuario.Name = "dtgusuario"
        Me.dtgusuario.ReadOnly = True
        Me.dtgusuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgusuario.Size = New System.Drawing.Size(469, 514)
        Me.dtgusuario.TabIndex = 41
        '
        'dtguusuario
        '
        Me.dtguusuario.DataPropertyName = "nombre"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtguusuario.DefaultCellStyle = DataGridViewCellStyle1
        Me.dtguusuario.HeaderText = "Usuario"
        Me.dtguusuario.Name = "dtguusuario"
        Me.dtguusuario.ReadOnly = True
        Me.dtguusuario.Width = 120
        '
        'univel
        '
        Me.univel.DataPropertyName = "nivel"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.univel.DefaultCellStyle = DataGridViewCellStyle2
        Me.univel.HeaderText = "Nivel"
        Me.univel.Name = "univel"
        Me.univel.ReadOnly = True
        Me.univel.Width = 50
        '
        'unombre_real
        '
        Me.unombre_real.DataPropertyName = "nombre_real"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unombre_real.DefaultCellStyle = DataGridViewCellStyle3
        Me.unombre_real.HeaderText = "Nombre Real"
        Me.unombre_real.Name = "unombre_real"
        Me.unombre_real.ReadOnly = True
        Me.unombre_real.Width = 250
        '
        'dtguid
        '
        Me.dtguid.DataPropertyName = "id_usuario"
        Me.dtguid.HeaderText = "id_usuario"
        Me.dtguid.Name = "dtguid"
        Me.dtguid.ReadOnly = True
        Me.dtguid.Visible = False
        '
        'uclave
        '
        Me.uclave.DataPropertyName = "clave"
        Me.uclave.HeaderText = "clave"
        Me.uclave.Name = "uclave"
        Me.uclave.ReadOnly = True
        Me.uclave.Visible = False
        '
        'uobseravaciones
        '
        Me.uobseravaciones.DataPropertyName = "observaciones"
        Me.uobseravaciones.HeaderText = "observaciones"
        Me.uobseravaciones.Name = "uobseravaciones"
        Me.uobseravaciones.ReadOnly = True
        Me.uobseravaciones.Visible = False
        '
        'ueliminado
        '
        Me.ueliminado.DataPropertyName = "eliminado"
        Me.ueliminado.HeaderText = "eliminado"
        Me.ueliminado.Name = "ueliminado"
        Me.ueliminado.ReadOnly = True
        Me.ueliminado.Visible = False
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label6.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label6.Location = New System.Drawing.Point(142, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 32)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Usuarios"
        '
        'id_usuario
        '
        Me.id_usuario.Format = ""
        Me.id_usuario.FormatInfo = Nothing
        Me.id_usuario.HeaderText = "Usuario"
        Me.id_usuario.MappingName = "id_usuario"
        Me.id_usuario.Width = 140
        '
        'Tabproveedor
        '
        Me.Tabproveedor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Tabproveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tabproveedor.Controls.Add(Me.Button4)
        Me.Tabproveedor.Controls.Add(Me.dtgproveedor)
        Me.Tabproveedor.Controls.Add(Me.PictureBox3)
        Me.Tabproveedor.Controls.Add(Me.btneliminar_proveedor)
        Me.Tabproveedor.Controls.Add(Me.btncambiar_proveedor)
        Me.Tabproveedor.Controls.Add(Me.btnincluir_proveedor)
        Me.Tabproveedor.Controls.Add(Me.txtbuscar_proveedor)
        Me.Tabproveedor.Controls.Add(Me.Label2)
        Me.Tabproveedor.Location = New System.Drawing.Point(4, 28)
        Me.Tabproveedor.Name = "Tabproveedor"
        Me.Tabproveedor.Size = New System.Drawing.Size(776, 648)
        Me.Tabproveedor.TabIndex = 3
        Me.Tabproveedor.Text = "Proveedores"
        '
        'dtgproveedor
        '
        Me.dtgproveedor.AllowUserToAddRows = False
        Me.dtgproveedor.AllowUserToDeleteRows = False
        Me.dtgproveedor.AllowUserToResizeColumns = False
        Me.dtgproveedor.AllowUserToResizeRows = False
        Me.dtgproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgproveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtgprvid, Me.prNombre, Me.prpais, Me.premail, Me.prtelefono1, Me.prtelefono2, Me.prtelefono3, Me.prcontacto1, Me.prcontacto2, Me.prcontacto3, Me.probservaciones, Me.preliminado})
        Me.dtgproveedor.Location = New System.Drawing.Point(184, 60)
        Me.dtgproveedor.Name = "dtgproveedor"
        Me.dtgproveedor.ReadOnly = True
        Me.dtgproveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgproveedor.Size = New System.Drawing.Size(411, 466)
        Me.dtgproveedor.TabIndex = 35
        '
        'dtgprvid
        '
        Me.dtgprvid.DataPropertyName = "id_proveedor"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgprvid.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtgprvid.HeaderText = "Código"
        Me.dtgprvid.Name = "dtgprvid"
        Me.dtgprvid.ReadOnly = True
        Me.dtgprvid.Width = 65
        '
        'prNombre
        '
        Me.prNombre.DataPropertyName = "Nombre"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prNombre.DefaultCellStyle = DataGridViewCellStyle5
        Me.prNombre.HeaderText = "Nombre"
        Me.prNombre.Name = "prNombre"
        Me.prNombre.ReadOnly = True
        Me.prNombre.Width = 300
        '
        'prpais
        '
        Me.prpais.DataPropertyName = "pais"
        Me.prpais.HeaderText = "pais"
        Me.prpais.Name = "prpais"
        Me.prpais.ReadOnly = True
        Me.prpais.Visible = False
        '
        'premail
        '
        Me.premail.DataPropertyName = "email"
        Me.premail.HeaderText = "premail"
        Me.premail.Name = "premail"
        Me.premail.ReadOnly = True
        Me.premail.Visible = False
        '
        'prtelefono1
        '
        Me.prtelefono1.DataPropertyName = "telefono1"
        Me.prtelefono1.HeaderText = "telefono1"
        Me.prtelefono1.Name = "prtelefono1"
        Me.prtelefono1.ReadOnly = True
        Me.prtelefono1.Visible = False
        '
        'prtelefono2
        '
        Me.prtelefono2.DataPropertyName = "telefono2"
        Me.prtelefono2.HeaderText = "telefono2"
        Me.prtelefono2.Name = "prtelefono2"
        Me.prtelefono2.ReadOnly = True
        Me.prtelefono2.Visible = False
        '
        'prtelefono3
        '
        Me.prtelefono3.DataPropertyName = "telefono3"
        Me.prtelefono3.HeaderText = "telefono3"
        Me.prtelefono3.Name = "prtelefono3"
        Me.prtelefono3.ReadOnly = True
        Me.prtelefono3.Visible = False
        '
        'prcontacto1
        '
        Me.prcontacto1.DataPropertyName = "contacto1"
        Me.prcontacto1.HeaderText = "contacto1"
        Me.prcontacto1.Name = "prcontacto1"
        Me.prcontacto1.ReadOnly = True
        Me.prcontacto1.Visible = False
        '
        'prcontacto2
        '
        Me.prcontacto2.DataPropertyName = "contacto2"
        Me.prcontacto2.HeaderText = "contacto2"
        Me.prcontacto2.Name = "prcontacto2"
        Me.prcontacto2.ReadOnly = True
        Me.prcontacto2.Visible = False
        '
        'prcontacto3
        '
        Me.prcontacto3.DataPropertyName = "contacto3"
        Me.prcontacto3.HeaderText = "contacto3"
        Me.prcontacto3.Name = "prcontacto3"
        Me.prcontacto3.ReadOnly = True
        Me.prcontacto3.Visible = False
        '
        'probservaciones
        '
        Me.probservaciones.DataPropertyName = "observaciones"
        Me.probservaciones.HeaderText = "observaciones"
        Me.probservaciones.Name = "probservaciones"
        Me.probservaciones.ReadOnly = True
        Me.probservaciones.Visible = False
        '
        'preliminado
        '
        Me.preliminado.DataPropertyName = "eliminado"
        Me.preliminado.HeaderText = "eliminado"
        Me.preliminado.Name = "preliminado"
        Me.preliminado.ReadOnly = True
        Me.preliminado.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(242, 546)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 34
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Location = New System.Drawing.Point(177, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(352, 32)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Proveedores"
        '
        'telefono1
        '
        Me.telefono1.Format = ""
        Me.telefono1.FormatInfo = Nothing
        Me.telefono1.HeaderText = "Teléfono1"
        Me.telefono1.MappingName = "telefono1"
        Me.telefono1.Width = 140
        '
        'nombreproveedor
        '
        Me.nombreproveedor.Format = ""
        Me.nombreproveedor.FormatInfo = Nothing
        Me.nombreproveedor.HeaderText = "Nombre"
        Me.nombreproveedor.MappingName = "nombre"
        Me.nombreproveedor.Width = 240
        '
        'id_proveedor
        '
        Me.id_proveedor.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.id_proveedor.Format = "###"
        Me.id_proveedor.FormatInfo = Nothing
        Me.id_proveedor.HeaderText = "Cód"
        Me.id_proveedor.MappingName = "id_proveedor"
        Me.id_proveedor.Width = 55
        '
        'Vencimiento
        '
        Me.Vencimiento.Format = ""
        Me.Vencimiento.FormatInfo = Nothing
        Me.Vencimiento.HeaderText = "Vence"
        Me.Vencimiento.MappingName = "descuento_vencimiento"
        Me.Vencimiento.Width = 85
        '
        'descuento_introduccion
        '
        Me.descuento_introduccion.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.descuento_introduccion.Format = "##.#0"
        Me.descuento_introduccion.FormatInfo = Nothing
        Me.descuento_introduccion.HeaderText = "Descuento Intro"
        Me.descuento_introduccion.MappingName = "descuento_introduccion"
        Me.descuento_introduccion.Width = 55
        '
        'comision
        '
        Me.comision.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.comision.Format = "##.#0"
        Me.comision.FormatInfo = Nothing
        Me.comision.HeaderText = "Comisión"
        Me.comision.MappingName = "comision"
        Me.comision.Width = 55
        '
        'valor
        '
        Me.valor.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.valor.Format = "#,###.#0"
        Me.valor.FormatInfo = Nothing
        Me.valor.HeaderText = "Valor"
        Me.valor.MappingName = "valor"
        Me.valor.Width = 75
        '
        'nombretsprecio
        '
        Me.nombretsprecio.Format = ""
        Me.nombretsprecio.FormatInfo = Nothing
        Me.nombretsprecio.HeaderText = "Nombre"
        Me.nombretsprecio.MappingName = "nombre_producto"
        Me.nombretsprecio.Width = 240
        '
        'id_productotsprecio
        '
        Me.id_productotsprecio.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.id_productotsprecio.Format = "###"
        Me.id_productotsprecio.FormatInfo = Nothing
        Me.id_productotsprecio.HeaderText = "Producto"
        Me.id_productotsprecio.MappingName = "id_producto"
        Me.id_productotsprecio.Width = 55
        '
        'descripcion
        '
        Me.descripcion.Format = ""
        Me.descripcion.FormatInfo = Nothing
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.MappingName = "descripcion"
        Me.descripcion.Width = 190
        '
        'Tabproducto
        '
        Me.Tabproducto.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Tabproducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tabproducto.Controls.Add(Me.Button2)
        Me.Tabproducto.Controls.Add(Me.dtgproducto)
        Me.Tabproducto.Controls.Add(Me.btneliminar_producto)
        Me.Tabproducto.Controls.Add(Me.btncambiar_producto)
        Me.Tabproducto.Controls.Add(Me.btnincluir_producto)
        Me.Tabproducto.Controls.Add(Me.PictureBox5)
        Me.Tabproducto.Controls.Add(Me.txtbuscar_producto)
        Me.Tabproducto.Controls.Add(Me.Label5)
        Me.Tabproducto.Location = New System.Drawing.Point(4, 28)
        Me.Tabproducto.Name = "Tabproducto"
        Me.Tabproducto.Size = New System.Drawing.Size(776, 648)
        Me.Tabproducto.TabIndex = 2
        Me.Tabproducto.Text = "Productos"
        '
        'dtgproducto
        '
        Me.dtgproducto.AllowUserToAddRows = False
        Me.dtgproducto.AllowUserToDeleteRows = False
        Me.dtgproducto.AllowUserToResizeColumns = False
        Me.dtgproducto.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgproducto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dtgproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgproducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtgprdid, Me.pnombre, Me.precio1, Me.precio2, Me.piv, Me.pid_proveedor, Me.pid_familia, Me.pobservaciones, Me.Ppresentacion, Me.eliminado, Me.costo, Me.existencia, Me.pid_proverdor, Me.pbarcode})
        Me.dtgproducto.Location = New System.Drawing.Point(43, 57)
        Me.dtgproducto.Name = "dtgproducto"
        Me.dtgproducto.ReadOnly = True
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgproducto.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dtgproducto.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgproducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgproducto.Size = New System.Drawing.Size(682, 477)
        Me.dtgproducto.TabIndex = 30
        '
        'dtgprdid
        '
        Me.dtgprdid.DataPropertyName = "id_producto"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgprdid.DefaultCellStyle = DataGridViewCellStyle7
        Me.dtgprdid.FillWeight = 65.0!
        Me.dtgprdid.HeaderText = "Código"
        Me.dtgprdid.Name = "dtgprdid"
        Me.dtgprdid.ReadOnly = True
        Me.dtgprdid.Width = 65
        '
        'pnombre
        '
        Me.pnombre.DataPropertyName = "nombre"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnombre.DefaultCellStyle = DataGridViewCellStyle8
        Me.pnombre.FillWeight = 350.0!
        Me.pnombre.HeaderText = "Nombre"
        Me.pnombre.Name = "pnombre"
        Me.pnombre.ReadOnly = True
        Me.pnombre.Width = 350
        '
        'precio1
        '
        Me.precio1.DataPropertyName = "precio1"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.precio1.DefaultCellStyle = DataGridViewCellStyle9
        Me.precio1.HeaderText = "Precio 1"
        Me.precio1.Name = "precio1"
        Me.precio1.ReadOnly = True
        '
        'precio2
        '
        Me.precio2.DataPropertyName = "precio2"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.precio2.DefaultCellStyle = DataGridViewCellStyle10
        Me.precio2.HeaderText = "Precio 2"
        Me.precio2.Name = "precio2"
        Me.precio2.ReadOnly = True
        '
        'piv
        '
        Me.piv.DataPropertyName = "iv"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.NullValue = False
        Me.piv.DefaultCellStyle = DataGridViewCellStyle11
        Me.piv.FillWeight = 20.0!
        Me.piv.HeaderText = "iv"
        Me.piv.Name = "piv"
        Me.piv.ReadOnly = True
        Me.piv.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.piv.Visible = False
        Me.piv.Width = 25
        '
        'pid_proveedor
        '
        Me.pid_proveedor.HeaderText = "id_proveedor"
        Me.pid_proveedor.Name = "pid_proveedor"
        Me.pid_proveedor.ReadOnly = True
        Me.pid_proveedor.Visible = False
        '
        'pid_familia
        '
        Me.pid_familia.DataPropertyName = "id_familia"
        Me.pid_familia.HeaderText = "id_familia"
        Me.pid_familia.Name = "pid_familia"
        Me.pid_familia.ReadOnly = True
        Me.pid_familia.Visible = False
        '
        'pobservaciones
        '
        Me.pobservaciones.DataPropertyName = "observaciones"
        Me.pobservaciones.HeaderText = "observaciones"
        Me.pobservaciones.Name = "pobservaciones"
        Me.pobservaciones.ReadOnly = True
        Me.pobservaciones.Visible = False
        '
        'Ppresentacion
        '
        Me.Ppresentacion.DataPropertyName = "presentacion"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ppresentacion.DefaultCellStyle = DataGridViewCellStyle12
        Me.Ppresentacion.FillWeight = 40.0!
        Me.Ppresentacion.HeaderText = "Prst"
        Me.Ppresentacion.Name = "Ppresentacion"
        Me.Ppresentacion.ReadOnly = True
        Me.Ppresentacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Ppresentacion.Visible = False
        Me.Ppresentacion.Width = 45
        '
        'eliminado
        '
        Me.eliminado.DataPropertyName = "eliminado"
        Me.eliminado.HeaderText = "eliminado"
        Me.eliminado.Name = "eliminado"
        Me.eliminado.ReadOnly = True
        Me.eliminado.Visible = False
        '
        'costo
        '
        Me.costo.DataPropertyName = "costo"
        Me.costo.HeaderText = "costo"
        Me.costo.Name = "costo"
        Me.costo.ReadOnly = True
        Me.costo.Visible = False
        '
        'existencia
        '
        Me.existencia.DataPropertyName = "existencia"
        Me.existencia.HeaderText = "existencia"
        Me.existencia.Name = "existencia"
        Me.existencia.ReadOnly = True
        Me.existencia.Visible = False
        '
        'pid_proverdor
        '
        Me.pid_proverdor.DataPropertyName = "id_proveedor"
        Me.pid_proverdor.HeaderText = "id_proveedor"
        Me.pid_proverdor.Name = "pid_proverdor"
        Me.pid_proverdor.ReadOnly = True
        Me.pid_proverdor.Visible = False
        '
        'pbarcode
        '
        Me.pbarcode.DataPropertyName = "barcode"
        Me.pbarcode.HeaderText = "barcode"
        Me.pbarcode.Name = "pbarcode"
        Me.pbarcode.ReadOnly = True
        Me.pbarcode.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(240, 552)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 24
        Me.PictureBox5.TabStop = False
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label5.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label5.Location = New System.Drawing.Point(46, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 32)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Productos"
        '
        'unidad
        '
        Me.unidad.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.unidad.Format = ""
        Me.unidad.FormatInfo = Nothing
        Me.unidad.HeaderText = "Unidad"
        Me.unidad.MappingName = "unidad"
        Me.unidad.Width = 65
        '
        'nombreproducto
        '
        Me.nombreproducto.Format = ""
        Me.nombreproducto.FormatInfo = Nothing
        Me.nombreproducto.HeaderText = "Nombre"
        Me.nombreproducto.MappingName = "nombre"
        Me.nombreproducto.Width = 240
        '
        'id_producto
        '
        Me.id_producto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.id_producto.Format = "###"
        Me.id_producto.FormatInfo = Nothing
        Me.id_producto.HeaderText = "Cód"
        Me.id_producto.MappingName = "id_producto"
        Me.id_producto.Width = 65
        '
        'Tabcliente
        '
        Me.Tabcliente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Tabcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tabcliente.Controls.Add(Me.dtgcliente)
        Me.Tabcliente.Controls.Add(Me.Button1)
        Me.Tabcliente.Controls.Add(Me.PictureBox2)
        Me.Tabcliente.Controls.Add(Me.btneliminar_cliente)
        Me.Tabcliente.Controls.Add(Me.btncambiar_cliente)
        Me.Tabcliente.Controls.Add(Me.btnincluir_cliente)
        Me.Tabcliente.Controls.Add(Me.txtbuscar_cliente)
        Me.Tabcliente.Controls.Add(Me.Label3)
        Me.Tabcliente.Location = New System.Drawing.Point(4, 28)
        Me.Tabcliente.Name = "Tabcliente"
        Me.Tabcliente.Size = New System.Drawing.Size(776, 648)
        Me.Tabcliente.TabIndex = 1
        Me.Tabcliente.Text = "Clientes"
        '
        'dtgcliente
        '
        Me.dtgcliente.AllowUserToAddRows = False
        Me.dtgcliente.AllowUserToDeleteRows = False
        Me.dtgcliente.AllowUserToResizeColumns = False
        Me.dtgcliente.AllowUserToResizeRows = False
        Me.dtgcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgcliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtgcid, Me.cnombre, Me.cTelefono, Me.cdireccion, Me.cidentificacion, Me.cplazo, Me.cnombre_sociedad, Me.cfax, Me.cemail, Me.cnombre_encargado, Me.ctelefono_encargado, Me.descuento, Me.climite, Me.cid_agente, Me.cid_lista, Me.cobservaciones, Me.celiminado, Me.id_grupo, Me.id_precio, Me.provincia, Me.distrito, Me.canton, Me.id_zona})
        Me.dtgcliente.Location = New System.Drawing.Point(64, 60)
        Me.dtgcliente.Name = "dtgcliente"
        Me.dtgcliente.ReadOnly = True
        Me.dtgcliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgcliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgcliente.Size = New System.Drawing.Size(661, 474)
        Me.dtgcliente.TabIndex = 28
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(240, 551)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Location = New System.Drawing.Point(58, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(352, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Clientes"
        '
        'telefonocliente
        '
        Me.telefonocliente.Format = ""
        Me.telefonocliente.FormatInfo = Nothing
        Me.telefonocliente.HeaderText = "Teléfono"
        Me.telefonocliente.MappingName = "telefono"
        Me.telefonocliente.Width = 85
        '
        'nombresociedad
        '
        Me.nombresociedad.Format = ""
        Me.nombresociedad.FormatInfo = Nothing
        Me.nombresociedad.HeaderText = "Nombre"
        Me.nombresociedad.MappingName = "nombre_sociedad"
        Me.nombresociedad.Width = 240
        '
        'id_cliente
        '
        Me.id_cliente.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.id_cliente.Format = "###"
        Me.id_cliente.FormatInfo = Nothing
        Me.id_cliente.HeaderText = "Cód"
        Me.id_cliente.MappingName = "id_cliente"
        Me.id_cliente.Width = 55
        '
        'Tabagente
        '
        Me.Tabagente.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Tabagente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tabagente.Controls.Add(Me.dtgagente)
        Me.Tabagente.Controls.Add(Me.btneliminar_agente)
        Me.Tabagente.Controls.Add(Me.btncambiar_agente)
        Me.Tabagente.Controls.Add(Me.btnincluir_agente)
        Me.Tabagente.Controls.Add(Me.PictureBox1)
        Me.Tabagente.Controls.Add(Me.Txtbuscar_agente)
        Me.Tabagente.Controls.Add(Me.btnsalir_Agente)
        Me.Tabagente.Controls.Add(Me.Label1)
        Me.Tabagente.Location = New System.Drawing.Point(4, 28)
        Me.Tabagente.Name = "Tabagente"
        Me.Tabagente.Size = New System.Drawing.Size(776, 648)
        Me.Tabagente.TabIndex = 0
        Me.Tabagente.Text = "Agentes"
        '
        'dtgagente
        '
        Me.dtgagente.AllowUserToAddRows = False
        Me.dtgagente.AllowUserToDeleteRows = False
        Me.dtgagente.AllowUserToResizeColumns = False
        Me.dtgagente.AllowUserToResizeRows = False
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgagente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.dtgagente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgagente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtgaid, Me.dtganombre, Me.dtgatelefono, Me.aidentificacion, Me.aobservaciones, Me.dtgaeliminado})
        Me.dtgagente.Location = New System.Drawing.Point(142, 53)
        Me.dtgagente.Name = "dtgagente"
        Me.dtgagente.ReadOnly = True
        Me.dtgagente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgagente.RowsDefaultCellStyle = DataGridViewCellStyle21
        Me.dtgagente.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgagente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgagente.Size = New System.Drawing.Size(491, 473)
        Me.dtgagente.TabIndex = 23
        '
        'dtgaid
        '
        Me.dtgaid.DataPropertyName = "id_agente"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgaid.DefaultCellStyle = DataGridViewCellStyle18
        Me.dtgaid.HeaderText = "Código"
        Me.dtgaid.Name = "dtgaid"
        Me.dtgaid.ReadOnly = True
        Me.dtgaid.Width = 65
        '
        'dtganombre
        '
        Me.dtganombre.DataPropertyName = "nombre"
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtganombre.DefaultCellStyle = DataGridViewCellStyle19
        Me.dtganombre.HeaderText = "Nombre"
        Me.dtganombre.Name = "dtganombre"
        Me.dtganombre.ReadOnly = True
        Me.dtganombre.Width = 300
        '
        'dtgatelefono
        '
        Me.dtgatelefono.DataPropertyName = "telefono"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgatelefono.DefaultCellStyle = DataGridViewCellStyle20
        Me.dtgatelefono.HeaderText = "Teléfono"
        Me.dtgatelefono.Name = "dtgatelefono"
        Me.dtgatelefono.ReadOnly = True
        Me.dtgatelefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dtgatelefono.Width = 80
        '
        'aidentificacion
        '
        Me.aidentificacion.DataPropertyName = "identificacion"
        Me.aidentificacion.HeaderText = "identificacion"
        Me.aidentificacion.Name = "aidentificacion"
        Me.aidentificacion.ReadOnly = True
        Me.aidentificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.aidentificacion.Visible = False
        '
        'aobservaciones
        '
        Me.aobservaciones.DataPropertyName = "observaciones"
        Me.aobservaciones.HeaderText = "observaciones"
        Me.aobservaciones.Name = "aobservaciones"
        Me.aobservaciones.ReadOnly = True
        Me.aobservaciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.aobservaciones.Visible = False
        '
        'dtgaeliminado
        '
        Me.dtgaeliminado.DataPropertyName = "eliminado"
        Me.dtgaeliminado.HeaderText = "eliminado"
        Me.dtgaeliminado.Name = "dtgaeliminado"
        Me.dtgaeliminado.ReadOnly = True
        Me.dtgaeliminado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dtgaeliminado.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(248, 544)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Location = New System.Drawing.Point(136, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 40)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Agentes"
        '
        'telefono
        '
        Me.telefono.Format = ""
        Me.telefono.FormatInfo = Nothing
        Me.telefono.HeaderText = "Teléfono"
        Me.telefono.MappingName = "telefono"
        Me.telefono.Width = 85
        '
        'nombre
        '
        Me.nombre.Format = ""
        Me.nombre.FormatInfo = Nothing
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.MappingName = "nombre"
        Me.nombre.Width = 240
        '
        'id_agente
        '
        Me.id_agente.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.id_agente.Format = "##"
        Me.id_agente.FormatInfo = Nothing
        Me.id_agente.HeaderText = "Cód"
        Me.id_agente.MappingName = "id_agente"
        Me.id_agente.Width = 50
        '
        'Tabdatos_mantenimiento
        '
        Me.Tabdatos_mantenimiento.Controls.Add(Me.Tabagente)
        Me.Tabdatos_mantenimiento.Controls.Add(Me.Tabcliente)
        Me.Tabdatos_mantenimiento.Controls.Add(Me.Tabproducto)
        Me.Tabdatos_mantenimiento.Controls.Add(Me.Tabproveedor)
        Me.Tabdatos_mantenimiento.Controls.Add(Me.tabfamilia)
        Me.Tabdatos_mantenimiento.Controls.Add(Me.Tabusuario)
        Me.Tabdatos_mantenimiento.Controls.Add(Me.Tabparametro)
        Me.Tabdatos_mantenimiento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tabdatos_mantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.Tabdatos_mantenimiento.Multiline = True
        Me.Tabdatos_mantenimiento.Name = "Tabdatos_mantenimiento"
        Me.Tabdatos_mantenimiento.SelectedIndex = 0
        Me.Tabdatos_mantenimiento.Size = New System.Drawing.Size(784, 680)
        Me.Tabdatos_mantenimiento.TabIndex = 1
        '
        'tabfamilia
        '
        Me.tabfamilia.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tabfamilia.Controls.Add(Me.btncerrar_familia)
        Me.tabfamilia.Controls.Add(Me.dtgfamilia)
        Me.tabfamilia.Controls.Add(Me.Button7)
        Me.tabfamilia.Controls.Add(Me.btnmodificar_familia)
        Me.tabfamilia.Controls.Add(Me.btnincluir_familia)
        Me.tabfamilia.Controls.Add(Me.Label4)
        Me.tabfamilia.Location = New System.Drawing.Point(4, 28)
        Me.tabfamilia.Name = "tabfamilia"
        Me.tabfamilia.Size = New System.Drawing.Size(776, 648)
        Me.tabfamilia.TabIndex = 6
        Me.tabfamilia.Text = "Familias"
        '
        'dtgfamilia
        '
        Me.dtgfamilia.AllowUserToAddRows = False
        Me.dtgfamilia.AllowUserToDeleteRows = False
        Me.dtgfamilia.AllowUserToResizeColumns = False
        Me.dtgfamilia.AllowUserToResizeRows = False
        Me.dtgfamilia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgfamilia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtgfid, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn12})
        Me.dtgfamilia.Location = New System.Drawing.Point(188, 62)
        Me.dtgfamilia.Name = "dtgfamilia"
        Me.dtgfamilia.ReadOnly = True
        Me.dtgfamilia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgfamilia.Size = New System.Drawing.Size(411, 466)
        Me.dtgfamilia.TabIndex = 41
        '
        'dtgfid
        '
        Me.dtgfid.DataPropertyName = "id_familia"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgfid.DefaultCellStyle = DataGridViewCellStyle22
        Me.dtgfid.HeaderText = "Código"
        Me.dtgfid.Name = "dtgfid"
        Me.dtgfid.ReadOnly = True
        Me.dtgfid.Width = 65
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "eliminado"
        Me.DataGridViewTextBoxColumn12.HeaderText = "eliminado"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label4.Location = New System.Drawing.Point(181, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(352, 32)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Familias"
        '
        'tsproducto_presentacion
        '
        Me.tsproducto_presentacion.Format = ""
        Me.tsproducto_presentacion.FormatInfo = Nothing
        Me.tsproducto_presentacion.MappingName = "presentacion"
        Me.tsproducto_presentacion.Width = 40
        '
        'tsproducto_nombre
        '
        Me.tsproducto_nombre.Format = ""
        Me.tsproducto_nombre.FormatInfo = Nothing
        Me.tsproducto_nombre.HeaderText = "Nombre"
        Me.tsproducto_nombre.MappingName = "nombre"
        Me.tsproducto_nombre.Width = 240
        '
        'tsproducto_id_producto
        '
        Me.tsproducto_id_producto.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.tsproducto_id_producto.Format = ""
        Me.tsproducto_id_producto.FormatInfo = Nothing
        Me.tsproducto_id_producto.HeaderText = "Cód"
        Me.tsproducto_id_producto.MappingName = "id_producto"
        Me.tsproducto_id_producto.Width = 55
        '
        'dtgcid
        '
        Me.dtgcid.DataPropertyName = "id_cliente"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgcid.DefaultCellStyle = DataGridViewCellStyle14
        Me.dtgcid.HeaderText = "Código"
        Me.dtgcid.Name = "dtgcid"
        Me.dtgcid.ReadOnly = True
        Me.dtgcid.Width = 65
        '
        'cnombre
        '
        Me.cnombre.DataPropertyName = "nombre_comercial"
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnombre.DefaultCellStyle = DataGridViewCellStyle15
        Me.cnombre.HeaderText = "Nombre"
        Me.cnombre.Name = "cnombre"
        Me.cnombre.ReadOnly = True
        Me.cnombre.Width = 450
        '
        'cTelefono
        '
        Me.cTelefono.DataPropertyName = "telefono"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cTelefono.DefaultCellStyle = DataGridViewCellStyle16
        Me.cTelefono.HeaderText = "Teléfono"
        Me.cTelefono.Name = "cTelefono"
        Me.cTelefono.ReadOnly = True
        Me.cTelefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cTelefono.Width = 80
        '
        'cdireccion
        '
        Me.cdireccion.DataPropertyName = "direccion"
        Me.cdireccion.HeaderText = "direccion"
        Me.cdireccion.Name = "cdireccion"
        Me.cdireccion.ReadOnly = True
        Me.cdireccion.Visible = False
        '
        'cidentificacion
        '
        Me.cidentificacion.DataPropertyName = "identificacion"
        Me.cidentificacion.HeaderText = "identificacion"
        Me.cidentificacion.Name = "cidentificacion"
        Me.cidentificacion.ReadOnly = True
        Me.cidentificacion.Visible = False
        '
        'cplazo
        '
        Me.cplazo.DataPropertyName = "plazo"
        Me.cplazo.HeaderText = "plazo"
        Me.cplazo.Name = "cplazo"
        Me.cplazo.ReadOnly = True
        Me.cplazo.Visible = False
        '
        'cnombre_sociedad
        '
        Me.cnombre_sociedad.DataPropertyName = "nombre_sociedad"
        Me.cnombre_sociedad.HeaderText = "nombre_sociedad"
        Me.cnombre_sociedad.Name = "cnombre_sociedad"
        Me.cnombre_sociedad.ReadOnly = True
        Me.cnombre_sociedad.Visible = False
        '
        'cfax
        '
        Me.cfax.DataPropertyName = "fax"
        Me.cfax.HeaderText = "fax"
        Me.cfax.Name = "cfax"
        Me.cfax.ReadOnly = True
        Me.cfax.Visible = False
        '
        'cemail
        '
        Me.cemail.DataPropertyName = "email"
        Me.cemail.HeaderText = "email"
        Me.cemail.Name = "cemail"
        Me.cemail.ReadOnly = True
        Me.cemail.Visible = False
        '
        'cnombre_encargado
        '
        Me.cnombre_encargado.DataPropertyName = "nombre_encargado"
        Me.cnombre_encargado.HeaderText = "nombre_encargado"
        Me.cnombre_encargado.Name = "cnombre_encargado"
        Me.cnombre_encargado.ReadOnly = True
        Me.cnombre_encargado.Visible = False
        '
        'ctelefono_encargado
        '
        Me.ctelefono_encargado.DataPropertyName = "telefono_encargado"
        Me.ctelefono_encargado.HeaderText = "telefono_encargado"
        Me.ctelefono_encargado.Name = "ctelefono_encargado"
        Me.ctelefono_encargado.ReadOnly = True
        Me.ctelefono_encargado.Visible = False
        '
        'descuento
        '
        Me.descuento.DataPropertyName = "descuento"
        Me.descuento.HeaderText = "descuento"
        Me.descuento.Name = "descuento"
        Me.descuento.ReadOnly = True
        Me.descuento.Visible = False
        '
        'climite
        '
        Me.climite.DataPropertyName = "limite_credito"
        Me.climite.HeaderText = "limte_credito"
        Me.climite.Name = "climite"
        Me.climite.ReadOnly = True
        Me.climite.Visible = False
        '
        'cid_agente
        '
        Me.cid_agente.DataPropertyName = "id_agente"
        Me.cid_agente.HeaderText = "id_agente"
        Me.cid_agente.Name = "cid_agente"
        Me.cid_agente.ReadOnly = True
        Me.cid_agente.Visible = False
        '
        'cid_lista
        '
        Me.cid_lista.DataPropertyName = "id_lista"
        Me.cid_lista.HeaderText = "id_lista"
        Me.cid_lista.Name = "cid_lista"
        Me.cid_lista.ReadOnly = True
        Me.cid_lista.Visible = False
        '
        'cobservaciones
        '
        Me.cobservaciones.DataPropertyName = "observaciones"
        Me.cobservaciones.HeaderText = "observaciones"
        Me.cobservaciones.Name = "cobservaciones"
        Me.cobservaciones.ReadOnly = True
        Me.cobservaciones.Visible = False
        '
        'celiminado
        '
        Me.celiminado.DataPropertyName = "eliminado"
        Me.celiminado.HeaderText = "eliminado"
        Me.celiminado.Name = "celiminado"
        Me.celiminado.ReadOnly = True
        Me.celiminado.Visible = False
        '
        'id_grupo
        '
        Me.id_grupo.DataPropertyName = "id_grupo"
        Me.id_grupo.HeaderText = "id_grupo"
        Me.id_grupo.Name = "id_grupo"
        Me.id_grupo.ReadOnly = True
        Me.id_grupo.Visible = False
        '
        'id_precio
        '
        Me.id_precio.DataPropertyName = "id_precio"
        Me.id_precio.HeaderText = "id_precio"
        Me.id_precio.Name = "id_precio"
        Me.id_precio.ReadOnly = True
        Me.id_precio.Visible = False
        '
        'provincia
        '
        Me.provincia.DataPropertyName = "provincia"
        Me.provincia.HeaderText = "provincia"
        Me.provincia.Name = "provincia"
        Me.provincia.ReadOnly = True
        Me.provincia.Visible = False
        '
        'distrito
        '
        Me.distrito.DataPropertyName = "distrito"
        Me.distrito.HeaderText = "distrito"
        Me.distrito.Name = "distrito"
        Me.distrito.ReadOnly = True
        Me.distrito.Visible = False
        '
        'canton
        '
        Me.canton.DataPropertyName = "canton"
        Me.canton.HeaderText = "canton"
        Me.canton.Name = "canton"
        Me.canton.ReadOnly = True
        Me.canton.Visible = False
        '
        'id_zona
        '
        Me.id_zona.DataPropertyName = "id_zona"
        Me.id_zona.HeaderText = "id_zona"
        Me.id_zona.Name = "id_zona"
        Me.id_zona.ReadOnly = True
        Me.id_zona.Visible = False
        '
        'frm_datos_mantenimiento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(792, 679)
        Me.Controls.Add(Me.Tabdatos_mantenimiento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(25, 25)
        Me.Name = "frm_datos_mantenimiento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Datos"
        Me.Tabparametro.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Tabusuario.ResumeLayout(False)
        CType(Me.dtgusuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabproveedor.ResumeLayout(False)
        Me.Tabproveedor.PerformLayout()
        CType(Me.dtgproveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabproducto.ResumeLayout(False)
        Me.Tabproducto.PerformLayout()
        CType(Me.dtgproducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabcliente.ResumeLayout(False)
        Me.Tabcliente.PerformLayout()
        CType(Me.dtgcliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabagente.ResumeLayout(False)
        Me.Tabagente.PerformLayout()
        CType(Me.dtgagente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabdatos_mantenimiento.ResumeLayout(False)
        Me.tabfamilia.ResumeLayout(False)
        CType(Me.dtgfamilia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frm_datos_mantenimiento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            myForms.frm_principal.ToolStrip.Enabled = True
            CONN1.Close()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub frm_datos_mantenimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CONN1.Open()
            Agente_Grid()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub frm_datos_mantenimiento_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        myForms.frm_principal.BringToFront()
    End Sub
    Private Sub Tabdatos_mantenimiento_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tabdatos_mantenimiento.Click
        Try
            Select Case Tabdatos_mantenimiento.SelectedTab.ToString
                Case "TabPage: {Clientes}"
                    Grupo = Table("select * from grupo order by id_grupo", "")
                    Agente = Table("Select id_agente,nombre from Agente where eliminado=0 order by id_agente", "id_agente")
                    Cliente_Grid()
                Case "TabPage: {Proveedores}"
                    Proveedor_Grid()
                Case "TabPage: {Familias}"
                    familia_Grid()
                Case "TabPage: {Productos}"
                    Proveedor = Table("Select id_proveedor,nombre from Proveedor where eliminado=0 order by id_proveedor", "id_Proveedor")
                    Familia = Table("Select * from familia  order by id_familia", "id_familia")
                    Producto_Grid()
                Case "TabPage: {Usuarios}"
                    Usuario_Grid()
                Case "TabPage: {Parámetros}"
                    Daparametro = New SqlDataAdapter("select * from parametro", CONN1)
                    Dsparametro = New DataSet
                    Daparametro.Fill(Dsparametro, "parametro")
                    Parametro_Sql()
                    rowp = Dsparametro.Tables("parametro").Rows(0)
                    lbliv.Text = FormatNumber(rowp("iv") * 100, 2)
                    lblm1.Text = rowp("m1")
                    lblm2.Text = rowp("m2")
                    lblm3.Text = rowp("m3")
            End Select
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub


    '*** Agente

    Private Sub Agente_Sql()
        Try
            ' Insert
            DaAgente.InsertCommand = CONN1.CreateCommand()
            DaAgente.InsertCommand.CommandText = "INSERT INTO Agente(identificacion, nombre, telefono, observaciones)" + _
            "VALUES(@identificacion, @nombre, @telefono,@observaciones); " & _
            "SELECT id_agente, identificacion, nombre, telefono, observaciones FROM Agente WHERE (id_agente = @@IDENTITY)"
            AddParams(DaAgente.InsertCommand, "identificacion", "telefono", "nombre", "observaciones")

            ' Update
            DaAgente.UpdateCommand = CONN1.CreateCommand()
            DaAgente.UpdateCommand.CommandText = _
                "UPDATE agente SET " + _
                "identificacion = @identificacion, nombre = @nombre, telefono = @telefono,observaciones=@observaciones" + _
                " WHERE id_agente = @id_agente"
            AddParams(DaAgente.UpdateCommand, "id_agente", "identificacion", "nombre", "telefono", "observaciones")

        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub Agente_Grid()
        'Try
        DaAgente = New SqlDataAdapter("select * from agente where eliminado=0 order by id_agente", CONN1)
        DsAgente = New DataSet
        DaAgente.Fill(DsAgente, "agente")
        Dvagente = New DataView(DsAgente.Tables("agente"))
        Agente_Sql()
        Dvagente.Sort = "nombre"
        dtgagente.DataSource = Dvagente
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub Txtagente_buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtbuscar_agente.TextChanged
        Dvagente.RowFilter = "nombre Like '%" & Txtbuscar_agente.Text & "%'"
    End Sub
    Private Sub btnsalir_Agente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir_Agente.Click
        Me.Close()
    End Sub
    Private Sub btneliminar_agente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar_agente.Click
        Try
            If Dvagente.Table.Rows.Count = 0 Then
                MessageBox.Show("Nada que Eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            rowa = TS(DsAgente.Tables(0), "Id_agente", dtgagente.Item("dtgaid", dtgagente.CurrentRow.Index).Value)
            Dim res As DialogResult = MessageBox.Show("Elimnar " + rowa("nombre"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = Windows.Forms.DialogResult.Yes Then
                cmd.Connection = CONN1
                cmd.CommandText = "update agente set eliminado=1 where id_agente=" + rowa("id_agente").ToString
                cmd.ExecuteNonQuery()
                Agente_Grid()
            End If
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub btncambiar_agente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncambiar_agente.Click
        'Try
        If Dvagente.Table.Rows.Count = 0 Then
            MessageBox.Show("Nada que Modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        rowa = TS(DsAgente.Tables(0), "Id_agente", dtgagente.Item("dtgaid", dtgagente.CurrentRow.Index).Value)
        Dim Agente_Mantenimiento As New frm_agente_mantenimiento
        With Agente_Mantenimiento
            .Owner = Me
            .lblid_agente.Text = rowa("id_agente").ToString
            .txtidentificacion.Text = rowa("identificacion").ToString.TrimEnd
            .txtnombre.Text = rowa("nombre")
            .txttelefono.Text = rowa("telefono").ToString.TrimEnd
            .txtobservaciones.Text = rowa("observaciones").ToString.TrimEnd

            .lbltitulo.Text = "Modificar Agente"
            .Show()
        End With
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub
    Private Sub btnincluir_agente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnincluir_agente.Click
        Dim Agente_Mantenimiento As New frm_agente_mantenimiento
        Agente_Mantenimiento.lbltitulo.Text = "Incluir Agente"
        Agente_Mantenimiento.Show()
    End Sub


    '*** Cliente
    Private Sub cliente_Sql()
        Try
            ' Insert
            Dacliente.InsertCommand = CONN1.CreateCommand()
            Dacliente.InsertCommand.CommandText = "INSERT INTO cliente(identificacion, nombre_comercial, nombre_sociedad,telefono,fax,email,direccion,nombre_encargado," + _
            "telefono_encargado,descuento,plazo,limite_credito,id_agente,observaciones,id_grupo,id_zona,id_precio, provincia, canton, distrito)" + _
            "values(@identificacion, @nombre_comercial, @nombre_sociedad,@telefono,@fax,@email,@direccion,@nombre_encargado," + _
            "@telefono_encargado,@descuento,@plazo,@limite_credito,@id_agente,@observaciones,@id_grupo,@id_zona,@id_precio, @provincia, @canton, @distrito);" + _
           "SELECT * FROM cliente WHERE (id_cliente = @@IDENTITY)"
            AddParams(Dacliente.InsertCommand, "identificacion", "nombre_comercial", "nombre_sociedad", "telefono", "fax", "email", "direccion", "nombre_encargado", _
            "telefono_encargado", "descuento", "id_agente", "plazo", "limite_credito", "observaciones", "id_grupo", "id_zona", "id_precio", "provincia", "canton", "distrito")

            ' Update
            Dacliente.UpdateCommand = CONN1.CreateCommand()
            Dacliente.UpdateCommand.CommandText = _
                "UPDATE cliente SET " + _
                "identificacion=@identificacion, nombre_comercial=@nombre_comercial, nombre_sociedad=@nombre_sociedad,telefono=@telefono,fax=@fax,email=@email," + _
                "direccion=@direccion,nombre_encargado=@nombre_encargado,telefono_encargado=@telefono_encargado,descuento=@descuento," + _
                "plazo=@plazo,limite_credito=@limite_credito,id_agente=@id_agente,observaciones=@observaciones,id_grupo=@id_grupo, provincia = @provincia, canton = @canton, distrito = @distrito, id_precio = @id_precio, id_zona=@id_zona" + _
                " WHERE id_cliente = @id_cliente"
            AddParams(Dacliente.UpdateCommand, "id_cliente", "identificacion", "nombre_comercial", "nombre_sociedad", "telefono", "fax", "email", "direccion", "nombre_encargado", _
            "telefono_encargado", "descuento", "plazo", "id_agente", "limite_credito", "observaciones", "id_grupo", "id_zona", "id_precio", "provincia", "canton", "distrito")


        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub Cliente_Grid()
        Try
            Dacliente = New SqlDataAdapter("select * from cliente where eliminado=0 order by id_cliente", CONN1)
            Dscliente = New DataSet
            Dacliente.Fill(Dscliente, "cliente")
            Dvcliente = New DataView(Dscliente.Tables("cliente"))
            cliente_Sql()
            Dvcliente.Sort = "nombre_comercial"
            dtgcliente.DataSource = Dvcliente

        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub txtbuscar_cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar_cliente.TextChanged
        Dvcliente.RowFilter = "nombre_comercial Like '%" & txtbuscar_cliente.Text & "%'"
    End Sub
    Private Sub Btnsalir_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub btneliminar_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar_cliente.Click
        Try
            If Dvcliente.Table.Rows.Count = 0 Then
                MessageBox.Show("Nada que Eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            rowc = TS(Dscliente.Tables(0), "Id_cliente", dtgcliente.Item("dtgcid", dtgcliente.CurrentRow.Index).Value)
            Dim res As DialogResult = MessageBox.Show("Elimnar " + rowc("nombre_comercial"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = Windows.Forms.DialogResult.Yes Then
                cmd.Connection = CONN1
                cmd.CommandText = "update cliente set eliminado=1 where id_cliente=" + rowc("id_cliente").ToString
                cmd.ExecuteNonQuery()
                Cliente_Grid()
            End If
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub btncambiar_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncambiar_cliente.Click
        'Try
        If Dvcliente.Table.Rows.Count = 0 Then
            MessageBox.Show("Nada que Modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        rowc = TS(Dscliente.Tables(0), "Id_cliente", dtgcliente.Item("dtgcid", dtgcliente.CurrentRow.Index).Value)
        Dim cliente_Mantenimiento As New frm_cliente_mantenimiento
        With cliente_Mantenimiento
            .Owner = Me
            .PopulateCBAddress()
            .lblid_cliente.Text = rowc("id_cliente").ToString
            .txtidentificacion.Text = rowc("identificacion").ToString.TrimEnd
            .txtnombre_sociedad.Text = rowc("nombre_sociedad")
            .txtnombre_comercial.Text = rowc("nombre_comercial")
            .txtemail.Text = rowc("email").ToString.TrimEnd
            .txtdireccion.Text = rowc("direccion").ToString.TrimEnd
            .txttelefono.Text = rowc("telefono").ToString.TrimEnd
            .txtfax.Text = rowc("fax").ToString.TrimEnd
            .txtlimite_credito.Text = rowc("limite_credito")
            .txtdescuento.Text = FormatNumber(rowc("descuento") * 100, 2)
            .txtplazo.Text = rowc("plazo")
            .txtobservaciones.Text = rowc("observaciones").ToString.TrimEnd
            .txtnombre_encargado.Text = rowc("nombre_encargado").ToString.TrimEnd
            .txttelefono_encargado.Text = rowc("telefono_encargado").ToString.TrimEnd
            .cbprecio.SelectedIndex = rowc("id_precio") - 1
            .cbProvincia.SelectedIndex = rowc("provincia").ToString - 1
            .cbCanton.SelectedIndex = rowc("canton").ToString - 1
            .cbDistrito.SelectedIndex = rowc("distrito").ToString - 1

            CB_crear(.cbid_agente, "Agente", "id_agente")
            .cbid_agente.SelectedIndex = cb_buscar(.cbid_agente, rowc("id_agente").ToString)

            CB_crear(.cbgrupo, "Grupo", "id_grupo")
            .cbgrupo.SelectedIndex = cb_buscar(.cbgrupo, rowc("id_grupo").ToString)

            Dim zona As DataTable = Table("select * from zona", "")
            CB_crear(.cbid_zona, "zona", "id_zona")
            .cbid_zona.SelectedIndex = cb_buscar(.cbid_zona, rowc("id_zona").ToString)



            .lbltitulo.Text = "Modificar Cliente"
            .Show()
        End With
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub
    Private Sub btnincluir_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnincluir_cliente.Click
        Try
            Dim cliente_mantenimiento As New frm_cliente_mantenimiento
            With cliente_mantenimiento
                .Owner = Me
                cliente_mantenimiento.Show()
                .lbltitulo.Text = "Incluir Cliente"
                CB_crear(.cbid_agente, "Agente", "id_agente")
                CB_crear(.cbgrupo, "Grupo", "id_grupo")
                CB_crear(.cbid_zona, "zona", "id_zona")
                .cbprecio.SelectedIndex = 0


            End With
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub


    '*** Producto
    Private Sub Producto_Sql()
        Try
            ' Insert
            Daproducto.InsertCommand = CONN1.CreateCommand()
            Daproducto.InsertCommand.CommandText = "INSERT INTO producto(nombre, presentacion, costo,precio1, precio2,id_proveedor,iv,observaciones,barcode,id_familia)" + _
            "VALUES(@nombre, @presentacion,@costo,@precio1,@precio2, @id_proveedor,@iv,@observaciones,@barcode,@id_familia); " & _
            "SELECT id_producto, nombre,presentacion,id_proveedor, observaciones,barcode,id_familia FROM producto WHERE (id_producto = @@IDENTITY)"
            AddParams(Daproducto.InsertCommand, "nombre", "presentacion", "costo", "precio1", "precio2", "id_proveedor", "observaciones", "barcode", "id_familia")
            Daproducto.InsertCommand.Parameters.Add("@iv", SqlDbType.Bit, 0, "iv")

            ' Update
            Daproducto.UpdateCommand = CONN1.CreateCommand()
            Daproducto.UpdateCommand.CommandText = _
                "UPDATE producto SET " + _
                "nombre = @nombre, presentacion = @presentacion,costo = @costo,precio1 = @precio1, precio2 = @precio2, id_proveedor=@id_proveedor,iv=@iv,observaciones=@observaciones, " + _
                "barcode=@barcode,id_familia=@id_familia WHERE id_producto = @id_producto"
            AddParams(Daproducto.UpdateCommand, "id_producto", "nombre", "presentacion", "costo", "precio1", "precio2", "id_proveedor", "observaciones", "barcode", "id_familia")
            Daproducto.UpdateCommand.Parameters.Add("@iv", SqlDbType.Bit, 0, "iv")

        Catch myerror As SqlException
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub Producto_Grid()
        Try
            Daproducto = New SqlDataAdapter("select * from producto where eliminado=0 order by id_producto", CONN1)
            Dsproducto = New DataSet
            Daproducto.Fill(Dsproducto, "producto")
            Dvproducto = New DataView(Dsproducto.Tables("producto"))

            Producto_Sql()
            Dvproducto.Sort = "nombre"
            dtgproducto.DataSource = Dvproducto
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub txtbuscar_producto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar_producto.TextChanged
        Dvproducto.RowFilter = "nombre Like '%" & txtbuscar_producto.Text & "%'"
    End Sub
    Private Sub btneliminar_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar_producto.Click
        'Try
        If Dvproducto.Table.Rows.Count = 0 Then
            MessageBox.Show("Nada que Eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'rowprd = TS(Dsproducto.Tables(0), "Id_producto", dtgproducto.Item("dtgprdid", dtgproducto.CurrentRow.Index).Value)
        Dim res As DialogResult = MessageBox.Show("Elimnar " + dtgproducto.Item("pnombre", dtgproducto.CurrentRow.Index).Value, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = Windows.Forms.DialogResult.Yes Then
            cmd.Connection = CONN1
            cmd.CommandText = "update producto set eliminado=1 where id_producto=" + dtgproducto.Item("dtgprdid", dtgproducto.CurrentRow.Index).Value.ToString
            cmd.ExecuteNonQuery()
            Producto_Grid()
        End If
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try

    End Sub
    Private Sub btncambiar_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncambiar_producto.Click
        'Try
        If Dvproducto.Table.Rows.Count = 0 Then
            MessageBox.Show("Nada que Modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        rowprd = TS(Dsproducto.Tables(0), "Id_producto", dtgproducto.Item("dtgprdid", dtgproducto.CurrentRow.Index).Value)
        Dim producto_Mantenimiento As New frm_producto_mantenimiento
        With producto_Mantenimiento
            .Owner = Me
            .lblid_producto.Text = rowprd("id_producto").ToString
            .txtnombre.Text = rowprd("nombre")
            .txtcosto.Text = rowprd("costo")
            .txtprecio1.Text = rowprd("precio1")
            .txtprecio2.Text = rowprd("precio2")
            .lblutilidad.Text = FormatNumber(.utilidad() * 100, 2)
            .txtbarcode.Text = rowprd("barcode").ToString.TrimEnd
            .txtobservaciones.Text = rowprd("observaciones").ToString.TrimEnd
            .chkiv.Checked = IIf(rowprd("iv"), True, False)

            CB_crear(.cbid_proveedor, "Proveedor", "id_proveedor")
            .cbid_proveedor.SelectedIndex = cb_buscar(.cbid_proveedor, rowprd("id_proveedor").ToString)

            CB_crear(.cbid_familia, "Familia", "id_familia")
            .cbid_familia.SelectedIndex = cb_buscar(.cbid_familia, rowprd("id_familia").ToString)


            .cbpresentacion.SelectedIndex = rowprd("presentacion") - 1

            .lbltitulo.Text = "Modificar Producto"
            .Show()
        End With
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub
    Private Sub btnincluir_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnincluir_producto.Click
        Try
            Dim producto_Mantenimiento As New frm_producto_mantenimiento
            With producto_Mantenimiento
                .Owner = Me
                .lbltitulo.Text = "Incluir Producto"

                CB_crear(.cbid_proveedor, "Proveedor", "id_proveedor")
                CB_crear(.cbid_familia, "Familia", "id_familia")


                .cbpresentacion.SelectedIndex = 0
                producto_Mantenimiento.Show()
            End With
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub btnsalir_producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    '*** Proveedor
    Private Sub Proveedor_Sql()
        Try
            ' Insert
            DaProveedor.InsertCommand = CONN1.CreateCommand()
            DaProveedor.InsertCommand.CommandText = "INSERT INTO Proveedor(nombre, pais, email,telefono1,telefono2,telefono3,contacto1,contacto2,contacto3,observaciones)" + _
            "VALUES(@nombre, @pais, @email,@telefono1,@telefono2,@telefono3,@contacto1,@contacto2,@contacto3,@observaciones); " & _
            "SELECT id_proveedor, nombre,pais,email, telefono1,telefono2,telefono3,contacto1,contacto2,contacto3, observaciones FROM Proveedor WHERE (id_proveedor = @@IDENTITY)"
            AddParams(DaProveedor.InsertCommand, "nombre", "pais", "email", "telefono1", "telefono2", "telefono3", "contacto1", "contacto2", "contacto3", "observaciones")
            ' Update
            DaProveedor.UpdateCommand = CONN1.CreateCommand()
            DaProveedor.UpdateCommand.CommandText = _
                "UPDATE Proveedor SET " + _
                "nombre = @nombre, pais = @pais,email=@email,telefono1 = @telefono1,telefono2 = @telefono2,telefono3 = @telefono3,contacto1=@contacto1,contacto2=@contacto2,contacto3=@contacto3,observaciones=@observaciones" + _
                " WHERE id_proveedor = @id_proveedor"
            AddParams(DaProveedor.UpdateCommand, "id_proveedor", "nombre", "pais", "email", "telefono1", "telefono2", "telefono3", "contacto1", "contacto2", "contacto3", "observaciones")

        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub Proveedor_Grid()
        Try
            DaProveedor = New SqlDataAdapter("select * from Proveedor where eliminado=0 order by id_proveedor", CONN1)
            DsProveedor = New DataSet
            DaProveedor.Fill(DsProveedor, "Proveedor")
            DvProveedor = New DataView(DsProveedor.Tables("Proveedor"))
            Proveedor_Sql()
            DvProveedor.Sort = "nombre"
            dtgproveedor.DataSource = DvProveedor
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try

    End Sub
    Private Sub btncambiar_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncambiar_proveedor.Click
        'Try
        If DvProveedor.Table.Rows.Count = 0 Then
            MessageBox.Show("Nada que Modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        rowprv = TS(DsProveedor.Tables(0), "Id_proveedor", dtgproveedor.Item("dtgprvid", dtgproveedor.CurrentRow.Index).Value)
        Dim proveedor_Mantenimiento As New frm_proveedor_mantenimiento
        With proveedor_Mantenimiento
            .Owner = Me
            .lblid_proveedor.Text = rowprv("id_proveedor").ToString
            .txtnombre.Text = rowprv("nombre")
            .txtpais.Text = rowprv("pais").ToString.TrimEnd
            .txtemail.Text = rowprv("email").ToString.TrimEnd
            .txttelefono1.Text = rowprv("telefono1").ToString.TrimEnd
            .txttelefono2.Text = rowprv("telefono2").ToString.TrimEnd
            .txttelefono3.Text = rowprv("telefono3").ToString.TrimEnd
            .txtcontacto1.Text = rowprv("contacto1").ToString.TrimEnd
            .txtcontacto2.Text = rowprv("contacto2").ToString.TrimEnd
            .Txtcontacto3.Text = rowprv("contacto3").ToString.TrimEnd
            .txtobservaciones.Text = rowprv("observaciones").ToString.TrimEnd
            .lbltitulo.Text = "Modificar Proveedor"
            .Show()
        End With
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub
    Private Sub btnincluir_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnincluir_proveedor.Click
        Dim Proveedor_Mantenimiento As New frm_proveedor_mantenimiento
        With Proveedor_Mantenimiento
            Proveedor_Mantenimiento.Owner = Me
            .lbltitulo.Text = "Incluir Proveedor"
        End With
        Proveedor_Mantenimiento.Show()
    End Sub
    Private Sub btnsalir_Proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub txtbuscar_proveedor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar_proveedor.TextChanged
        DvProveedor.RowFilter = "nombre Like '%" & txtbuscar_proveedor.Text & "%'"
    End Sub
    Private Sub btneliminar_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar_proveedor.Click
        Try
            If DvProveedor.Table.Rows.Count = 0 Then
                MessageBox.Show("Nada que Eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            rowprd = TS(DsProveedor.Tables(0), "Id_proveedor", dtgproveedor.Item("dtgprvid", dtgproveedor.CurrentRow.Index).Value)
            Dim res As DialogResult = MessageBox.Show("Eliminar " + rowprv("nombre"), "Mantenimiento Proveedores", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = Windows.Forms.DialogResult.Yes Then
                cmd.Connection = CONN1
                cmd.CommandText = "update proveedor set eliminado=1 where id_proveedor=" + rowprv("id_proveedor").ToString
                cmd.ExecuteNonQuery()
                Proveedor_Grid()
            End If
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub



    '*** familia
    Private Sub familia_Sql()
        Try
            ' Insert
            Dafamilia.InsertCommand = CONN1.CreateCommand()
            Dafamilia.InsertCommand.CommandText = "INSERT INTO familia(nombre)" + _
            "VALUES(@nombre); " & _
            "SELECT id_familia, nombre FROM familia WHERE (id_familia = @@IDENTITY)"
            AddParams(Dafamilia.InsertCommand, "nombre")
            ' Update
            Dafamilia.UpdateCommand = CONN1.CreateCommand()
            Dafamilia.UpdateCommand.CommandText = _
                "UPDATE familia SET " + _
                "nombre = @nombre" + _
                " WHERE id_familia = @id_familia"
            AddParams(Dafamilia.UpdateCommand, "id_familia", "nombre")

        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub familia_Grid()
        Try
            Dafamilia = New SqlDataAdapter("select * from familia where eliminado=0 order by id_familia", CONN1)
            Dsfamilia = New DataSet
            Dafamilia.Fill(Dsfamilia, "familia")
            Dvfamilia = New DataView(Dsfamilia.Tables("familia"))
            familia_Sql()
            Dvfamilia.Sort = "nombre"
            dtgfamilia.DataSource = Dvfamilia
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try

    End Sub

    '*** Usuario
    Private Sub Usuario_Sql()
        Try
            ' Insert
            Dausuario.InsertCommand = CONN1.CreateCommand()
            Dausuario.InsertCommand.CommandText = "INSERT INTO usuario (nombre, nombre_real,nivel, clave, observaciones)" + _
            "VALUES(@nombre, @nombre_real,@nivel, @clave, @observaciones);" & _
            "SELECT id_usuario, nombre,nombre_real,nivel,clave,observaciones FROM usuario WHERE (id_usuario = @@IDENTITY)"
            AddParams(Dausuario.InsertCommand, "nombre", "nombre_real", "nivel", "clave", "observaciones")
            ' Update
            Dausuario.UpdateCommand = CONN1.CreateCommand()
            Dausuario.UpdateCommand.CommandText = _
                "UPDATE usuario SET " + _
                "nombre = @nombre, nombre_real = @nombre_real,nivel = @nivel, clave = @clave,observaciones=@observaciones" + _
                " WHERE id_usuario = @id_usuario"
            AddParams(Dausuario.UpdateCommand, "id_usuario", "nombre", "nombre_real", "nivel", "clave", "observaciones")

        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub Usuario_Grid()
        'Try
        Dim Sql As String
        If USUARIO_NIVEL > 2 Then
            Sql = "select * from usuario where eliminado=0 order by id_usuario"
        Else
            Sql = "select * from usuario where id_usuario=" + USUARIO_ID
        End If
        Dausuario = New SqlDataAdapter(Sql, CONN1)
        Dsusuario = New DataSet
        Dausuario.Fill(Dsusuario, "usuario")
        Dvusuario = New DataView(Dsusuario.Tables("usuario"))
        Usuario_Sql()
        Dvusuario.Sort = "nombre"
        dtgusuario.DataSource = Dvusuario

        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try

    End Sub
    Private Sub btnsalir_usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub btncambiar_usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncambiar_usuario.Click
        'Try
        If Dvusuario.Table.Rows.Count = 0 Then
            MessageBox.Show("Nada que Modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        rowu = TS(Dsusuario.Tables(0), "Id_usuario", dtgusuario.Item("dtguid", dtgusuario.CurrentRow.Index).Value)
        Dim usuario_Mantenimiento As New frm_usuario_mantenimiento
        With usuario_Mantenimiento
            .Owner = Me
            .txtnombre.Text = rowu("nombre")
            .txtnombre_real.Text = rowu("nombre_real")
            .cbnivel.SelectedIndex = rowu("nivel") - 1
            .txtclave1.Text = TripleDES.Decrypt(rowu("clave"))
            .txtclave2.Text = TripleDES.Decrypt(rowu("clave"))
            .txtobservaciones.Text = rowu("observaciones").ToString.TrimEnd
            .lbltitulo.Text = "Modificar Usuario"
            If USUARIO_NIVEL < 3 Then
                .txtnombre_real.Visible = False
                .cbnivel.Visible = False
                .txtobservaciones.Visible = False
            End If
            .Show()
        End With
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub
    Private Sub btneliminar_usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar_usuario.Click
        Try
            If Dvusuario.Table.Rows.Count = 0 Then
                MessageBox.Show("Nada que Eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            rowu = TS(Dsusuario.Tables(0), "Id_usuario", dtgusuario.Item("dtguid", dtgusuario.CurrentRow.Index).Value)
            If rowu("id_usuario") = Val(USUARIO_ID) Then
                MessageBox.Show("No Se Puede Eliminar Usuario Activo", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim res As DialogResult = MessageBox.Show("Elimnar " + rowu("nombre"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If res = Windows.Forms.DialogResult.Yes Then
                cmd.Connection = CONN1
                cmd.CommandText = "update usuario set eliminado=1 where id_usuario=" + rowu("id_usuario").ToString
                cmd.ExecuteNonQuery()
                Usuario_Grid()
            End If
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub btnincluir_usuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnincluir_usuario.Click
        Dim usuario_Mantenimiento As New frm_usuario_mantenimiento
        With usuario_Mantenimiento
            usuario_Mantenimiento.Owner = Me
            .lbltitulo.Text = "Incluir Usuario"
            .cbnivel.SelectedIndex = 0
            .Show()
        End With
    End Sub


    '*** Parametro
    Private Sub Parametro_Sql()
        Try
            ' Update
            Daparametro.UpdateCommand = CONN1.CreateCommand()
            Daparametro.UpdateCommand.CommandText = _
                "UPDATE parametro SET " + _
                "iv = @iv, m1 = @m1,m2 = @m2,m3 = @m3"
            AddParams(Daparametro.UpdateCommand, "iv", "m1", "m2", "m3")
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub btncacancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub btnsalir_parametro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub btnmodificar_parametro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar_parametro.Click
        Try
            Dim parametro_Mantenimiento As New frm_parametro_mantenimiento
            With parametro_Mantenimiento
                .Owner = Me
                .txtiv.Text = FormatNumber(rowp("iv") * 100)
                .txtm1.Text = rowp("m1").ToString.TrimEnd
                .txtm2.Text = rowp("m2").ToString.TrimEnd
                .txtm3.Text = rowp("m3").ToString.TrimEnd
                .lbltitulo.Text = "Modificar Parámetros"
                .Show()
            End With
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btncerrar_familia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar_familia.Click
        Me.Close()
    End Sub

    Private Sub btnincluir_familia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnincluir_familia.Click
        Dim familia_Mantenimiento As New frm_familia_mantenimiento
        With familia_Mantenimiento
            familia_Mantenimiento.Owner = Me
            .lbltitulo.Text = "Incluir Familia"
        End With
        familia_Mantenimiento.Show()
    End Sub

    Private Sub btnmodificar_familia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar_familia.Click
        'Try
        If Dvfamilia.Table.Rows.Count = 0 Then
            MessageBox.Show("Nada que Modificar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        rowprv = TS(Dsfamilia.Tables(0), "Id_Familia", dtgfamilia.Item("dtgfid", dtgfamilia.CurrentRow.Index).Value)
        Dim Familia_Mantenimiento As New frm_familia_mantenimiento
        With Familia_Mantenimiento
            .Owner = Me
            .lblid_familia.Text = rowprv("id_Familia").ToString
            .txtnombre.Text = rowprv("nombre")
            .lbltitulo.Text = "Modificar Familia"
            .Show()
        End With
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub
End Class