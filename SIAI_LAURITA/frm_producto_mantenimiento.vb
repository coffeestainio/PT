Imports System.data.SqlClient
Public Class frm_producto_mantenimiento
    Inherits System.Windows.Forms.Form
    Dim sql As String

#Region " Windows Form Designer generated code "

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
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblid_producto As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbid_proveedor As System.Windows.Forms.ComboBox
    Friend WithEvents cbpresentacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkiv As System.Windows.Forms.CheckBox
    Friend WithEvents txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtbarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbid_familia As System.Windows.Forms.ComboBox
    Friend WithEvents pbprecio1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcosto As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtprecio1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents pbnombre As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblutilidad As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents pbcosto As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtprecio2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents pbprecio2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_producto_mantenimiento))
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cbid_proveedor = New System.Windows.Forms.ComboBox
        Me.cbpresentacion = New System.Windows.Forms.ComboBox
        Me.txtbarcode = New System.Windows.Forms.TextBox
        Me.cbid_familia = New System.Windows.Forms.ComboBox
        Me.txtcosto = New System.Windows.Forms.TextBox
        Me.txtprecio1 = New System.Windows.Forms.TextBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.txtprecio2 = New System.Windows.Forms.TextBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblid_producto = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkiv = New System.Windows.Forms.CheckBox
        Me.txtobservaciones = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.pbprecio1 = New System.Windows.Forms.PictureBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.pbprecio2 = New System.Windows.Forms.PictureBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.pbcosto = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lblutilidad = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.pbnombre = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbprecio1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbprecio2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbnombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltitulo
        '
        Me.lbltitulo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbltitulo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lbltitulo.Location = New System.Drawing.Point(0, 0)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(752, 25)
        Me.lbltitulo.TabIndex = 10
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncancelar
        '
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(387, 473)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(88, 32)
        Me.btncancelar.TabIndex = 9
        Me.btncancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.btncancelar, "No Guardar Datos")
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(278, 473)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(88, 32)
        Me.btnaceptar.TabIndex = 9
        Me.btnaceptar.Text = "Aceptar"
        Me.ToolTip1.SetToolTip(Me.btnaceptar, "Guardar Datos")
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'cbid_proveedor
        '
        Me.cbid_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbid_proveedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbid_proveedor.Location = New System.Drawing.Point(134, 207)
        Me.cbid_proveedor.Name = "cbid_proveedor"
        Me.cbid_proveedor.Size = New System.Drawing.Size(248, 26)
        Me.cbid_proveedor.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.cbid_proveedor, "Seleccione el proveedor del Producto")
        '
        'cbpresentacion
        '
        Me.cbpresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbpresentacion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbpresentacion.Items.AddRange(New Object() {"und", "cjs", "doc"})
        Me.cbpresentacion.Location = New System.Drawing.Point(134, 172)
        Me.cbpresentacion.Name = "cbpresentacion"
        Me.cbpresentacion.Size = New System.Drawing.Size(65, 26)
        Me.cbpresentacion.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.cbpresentacion, "Seleccione la presentacion del Producto")
        '
        'txtbarcode
        '
        Me.txtbarcode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbarcode.Location = New System.Drawing.Point(134, 93)
        Me.txtbarcode.MaxLength = 15
        Me.txtbarcode.Name = "txtbarcode"
        Me.txtbarcode.Size = New System.Drawing.Size(145, 26)
        Me.txtbarcode.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtbarcode, "Digitalice el código de barrar del producto")
        '
        'cbid_familia
        '
        Me.cbid_familia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbid_familia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbid_familia.Location = New System.Drawing.Point(134, 132)
        Me.cbid_familia.Name = "cbid_familia"
        Me.cbid_familia.Size = New System.Drawing.Size(283, 26)
        Me.cbid_familia.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.cbid_familia, "Seleccione la Familia del Producto")
        '
        'txtcosto
        '
        Me.txtcosto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcosto.Location = New System.Drawing.Point(134, 247)
        Me.txtcosto.MaxLength = 14
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Size = New System.Drawing.Size(88, 26)
        Me.txtcosto.TabIndex = 5
        Me.txtcosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtcosto, "Digite el costo del producto")
        '
        'txtprecio1
        '
        Me.txtprecio1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio1.Location = New System.Drawing.Point(134, 288)
        Me.txtprecio1.MaxLength = 14
        Me.txtprecio1.Name = "txtprecio1"
        Me.txtprecio1.Size = New System.Drawing.Size(88, 26)
        Me.txtprecio1.TabIndex = 6
        Me.txtprecio1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtprecio1, "Digite el precio del producto")
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(134, 55)
        Me.txtnombre.MaxLength = 60
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(552, 26)
        Me.txtnombre.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtnombre, "Escriba el nombre de la sociedad")
        '
        'txtprecio2
        '
        Me.txtprecio2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio2.Location = New System.Drawing.Point(134, 329)
        Me.txtprecio2.MaxLength = 14
        Me.txtprecio2.Name = "txtprecio2"
        Me.txtprecio2.Size = New System.Drawing.Size(88, 26)
        Me.txtprecio2.TabIndex = 7
        Me.txtprecio2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtprecio2, "Digite el precio del producto")
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(228, 298)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(8, 8)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nombre"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 24)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Presentación"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 382)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 24)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Observaciones"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Código"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_producto
        '
        Me.lblid_producto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid_producto.Location = New System.Drawing.Point(131, 23)
        Me.lblid_producto.Name = "lblid_producto"
        Me.lblid_producto.Size = New System.Drawing.Size(91, 24)
        Me.lblid_producto.TabIndex = 27
        Me.lblid_producto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Proveedor"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(358, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 24)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "IV"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkiv
        '
        Me.chkiv.Checked = True
        Me.chkiv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkiv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkiv.Location = New System.Drawing.Point(342, 99)
        Me.chkiv.Name = "chkiv"
        Me.chkiv.Size = New System.Drawing.Size(16, 16)
        Me.chkiv.TabIndex = 6
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservaciones.Location = New System.Drawing.Point(134, 382)
        Me.txtobservaciones.MaxLength = 50
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(392, 39)
        Me.txtobservaciones.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 24)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Código Barras"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 24)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Familia"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbprecio1
        '
        Me.pbprecio1.Image = CType(resources.GetObject("pbprecio1.Image"), System.Drawing.Image)
        Me.pbprecio1.Location = New System.Drawing.Point(228, 298)
        Me.pbprecio1.Name = "pbprecio1"
        Me.pbprecio1.Size = New System.Drawing.Size(12, 12)
        Me.pbprecio1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbprecio1.TabIndex = 69
        Me.pbprecio1.TabStop = False
        Me.pbprecio1.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 24)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Costo"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtprecio2)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.pbprecio2)
        Me.Panel1.Controls.Add(Me.txtnombre)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.pbcosto)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lblutilidad)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.pbnombre)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.txtprecio1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtcosto)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.pbprecio1)
        Me.Panel1.Controls.Add(Me.cbid_familia)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtbarcode)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtobservaciones)
        Me.Panel1.Controls.Add(Me.chkiv)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cbpresentacion)
        Me.Panel1.Controls.Add(Me.cbid_proveedor)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblid_producto)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(725, 439)
        Me.Panel1.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 331)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 24)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "Precio 2"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbprecio2
        '
        Me.pbprecio2.Image = CType(resources.GetObject("pbprecio2.Image"), System.Drawing.Image)
        Me.pbprecio2.Location = New System.Drawing.Point(228, 335)
        Me.pbprecio2.Name = "pbprecio2"
        Me.pbprecio2.Size = New System.Drawing.Size(12, 12)
        Me.pbprecio2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbprecio2.TabIndex = 82
        Me.pbprecio2.TabStop = False
        Me.pbprecio2.Visible = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(419, 249)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 24)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "%"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbcosto
        '
        Me.pbcosto.Image = CType(resources.GetObject("pbcosto.Image"), System.Drawing.Image)
        Me.pbcosto.Location = New System.Drawing.Point(228, 255)
        Me.pbcosto.Name = "pbcosto"
        Me.pbcosto.Size = New System.Drawing.Size(12, 12)
        Me.pbcosto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcosto.TabIndex = 79
        Me.pbcosto.TabStop = False
        Me.pbcosto.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(228, 259)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(8, 8)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 78
        Me.PictureBox2.TabStop = False
        '
        'lblutilidad
        '
        Me.lblutilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblutilidad.Location = New System.Drawing.Point(338, 249)
        Me.lblutilidad.Name = "lblutilidad"
        Me.lblutilidad.Size = New System.Drawing.Size(75, 24)
        Me.lblutilidad.TabIndex = 77
        Me.lblutilidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(270, 249)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 24)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Utilidad"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbnombre
        '
        Me.pbnombre.Image = CType(resources.GetObject("pbnombre.Image"), System.Drawing.Image)
        Me.pbnombre.Location = New System.Drawing.Point(694, 63)
        Me.pbnombre.Name = "pbnombre"
        Me.pbnombre.Size = New System.Drawing.Size(12, 12)
        Me.pbnombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbnombre.TabIndex = 75
        Me.pbnombre.TabStop = False
        Me.pbnombre.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(694, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(8, 8)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 290)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 24)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Precio 1"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(228, 335)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(8, 8)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 84
        Me.PictureBox5.TabStop = False
        '
        'frm_producto_mantenimiento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(754, 514)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_producto_mantenimiento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Productos"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbprecio1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbprecio2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbnombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        'Try
        Dim Fi As Boolean = False
        If txtnombre.Text = "" Then
            pbnombre.Visible = True
            Fi = True
        Else
            pbnombre.Visible = False
        End If

        If Val(txtcosto.Text) = 0 Then
            pbcosto.Visible = True
            Fi = True
        Else
            pbcosto.Visible = False
        End If

        If Val(txtprecio1.Text) = 0 Then
            pbprecio1.Visible = True
            Fi = True
        Else
            pbprecio1.Visible = False
        End If


        If Fi Then
            MessageBox.Show("Hay campos requeridos sin completar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        With myForms.frm_datos_mantenimiento
            Dim r As DataRow = TS(.Dsproducto.Tables(0), "nombre", txtnombre.Text)
            If Not (r Is Nothing) Then
                If (lbltitulo.Text = "Incluir Producto") Or (lbltitulo.Text <> "Incluir Producto" And .dtgproducto.Item("dtgprdid", .dtgproducto.CurrentRow.Index).Value <> r("id_producto")) Then
                    MessageBox.Show("Nombre de Producto Ya Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtnombre.Focus()
                    SendKeys.Send("{home}+{end}")
                    Exit Sub
                End If
            End If

            If lbltitulo.Text = "Incluir Producto" Then
                .rowprd = .Dvproducto.Table.NewRow()
            End If
            .rowprd("nombre") = txtnombre.Text
            .rowprd("observaciones") = IIf(txtobservaciones.Text = "", "", txtobservaciones.Text)
            .rowprd("id_proveedor") = cbid_proveedor.Text.Substring(0, 1)
            .rowprd("presentacion") = cbpresentacion.SelectedIndex + 1
            .rowprd("costo") = Val(txtcosto.Text)
            .rowprd("precio1") = Val(txtprecio1.Text)
            .rowprd("precio2") = Val(txtprecio2.Text)
            .rowprd("Iv") = IIf(chkiv.Checked, 1, 0)
            .rowprd("barcode") = txtbarcode.Text
            .rowprd("id_familia") = cbid(cbid_familia.Text)
            If lbltitulo.Text = "Incluir Producto" Then .Dvproducto.Table.Rows.Add(.rowprd)
            .Daproducto.Update(.Dsproducto, "producto")

            Dim cmd As New SqlCommand
            cmd.Connection = CONN1
        End With
        If lbltitulo.Text = "Incluir Producto" Then
            'ultimo index
            Dim tt As DataTable = Table("select top 1 id_producto from producto order by id_producto desc", "")
        End If
        Me.Close()

        'Catch myerror As Exception
        ' ONEX(Me.Name, myerror)
        'End Try
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub





    Private Sub cbpresentacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbpresentacion.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub



    Private Sub cbid_proveedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbid_proveedor.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub



    Private Sub txtobservaciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtobservaciones.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            btnaceptar.Focus()
        Else
            e.Handled = chk(Asc(e.KeyChar))
        End If
    End Sub

    Private Sub chkiv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chkiv.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtbarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbarcode.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub txtbarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbarcode.TextChanged

    End Sub

    Private Sub cbfamilia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbid_familia.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub



    Private Sub txtcosto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcosto.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            lblutilidad.Text = FormatNumber(utilidad() * 100, 2)
            SendKeys.Send("{TAB}")
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtcosto.Text, True)
        End If
    End Sub

    Private Sub txtcosto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcosto.TextChanged

    End Sub

    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            lblutilidad.Text = FormatNumber(utilidad() * 100, 2)
            SendKeys.Send("{TAB}")
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtprecio1.Text, False)
        End If
    End Sub

   
    Public Function utilidad() As Decimal
        utilidad = (Val(txtprecio1.Text) / Val(txtcosto.Text)) - 1
    End Function

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = chk(Asc(e.KeyChar))
        End If
    End Sub

    Private Sub txtprecio2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio2.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            lblutilidad.Text = FormatNumber(utilidad() * 100, 2)
            SendKeys.Send("{TAB}")
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtprecio2.Text, False)
        End If
    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub
End Class
