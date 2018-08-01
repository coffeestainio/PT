<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Compra_Mantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Compra_Mantenimiento))
        Me.txtcantidad = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtid_producto = New System.Windows.Forms.TextBox
        Me.txtcosto = New System.Windows.Forms.TextBox
        Me.txtdescuento = New System.Windows.Forms.TextBox
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblproducto_nombre = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblutilidad = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblprecio_actual = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtprecio = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblcosto_actual = New System.Windows.Forms.Label
        Me.lblcosto_final = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.lblpresentacion = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.pbcantidad = New System.Windows.Forms.PictureBox
        Me.pbid_producto = New System.Windows.Forms.PictureBox
        Me.lbliv = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.pbcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbid_producto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(129, 45)
        Me.txtcantidad.MaxLength = 15
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(54, 26)
        Me.txtcantidad.TabIndex = 1
        Me.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtcantidad, "Escriba la cantidad del Producto")
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 24)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Costo Actual"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtid_producto
        '
        Me.txtid_producto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid_producto.Location = New System.Drawing.Point(129, 8)
        Me.txtid_producto.MaxLength = 6
        Me.txtid_producto.Name = "txtid_producto"
        Me.txtid_producto.Size = New System.Drawing.Size(62, 26)
        Me.txtid_producto.TabIndex = 0
        Me.txtid_producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtid_producto, "Escriba el Código del Producto")
        '
        'txtcosto
        '
        Me.txtcosto.AcceptsReturn = True
        Me.txtcosto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcosto.Location = New System.Drawing.Point(129, 125)
        Me.txtcosto.MaxLength = 15
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Size = New System.Drawing.Size(116, 26)
        Me.txtcosto.TabIndex = 77
        Me.txtcosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtcosto, "Escriba la cantidad del Producto")
        '
        'txtdescuento
        '
        Me.txtdescuento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescuento.Location = New System.Drawing.Point(265, 125)
        Me.txtdescuento.MaxLength = 6
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(34, 26)
        Me.txtdescuento.TabIndex = 108
        Me.txtdescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtdescuento, "Digitalice el código de barrar del producto")
        '
        'btncancelar
        '
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(454, 306)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(88, 32)
        Me.btncancelar.TabIndex = 20
        Me.btncancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.btncancelar, "No Guardar Datos")
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(341, 306)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(88, 32)
        Me.btnaceptar.TabIndex = 19
        Me.btnaceptar.Text = "Aceptar"
        Me.ToolTip1.SetToolTip(Me.btnaceptar, "Guardar Datos")
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 24)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Cantidad"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblproducto_nombre
        '
        Me.lblproducto_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproducto_nombre.Location = New System.Drawing.Point(229, 9)
        Me.lblproducto_nombre.Name = "lblproducto_nombre"
        Me.lblproducto_nombre.Size = New System.Drawing.Size(572, 23)
        Me.lblproducto_nombre.TabIndex = 42
        Me.lblproducto_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 24)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Código"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltitulo
        '
        Me.lbltitulo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbltitulo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.SeaGreen
        Me.lbltitulo.Location = New System.Drawing.Point(0, 0)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(768, 27)
        Me.lbltitulo.TabIndex = 10
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.lblutilidad)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblprecio_actual)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtprecio)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblcosto_actual)
        Me.Panel1.Controls.Add(Me.lblcosto_final)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.txtdescuento)
        Me.Panel1.Controls.Add(Me.lblpresentacion)
        Me.Panel1.Controls.Add(Me.txtcosto)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.pbcantidad)
        Me.Panel1.Controls.Add(Me.pbid_producto)
        Me.Panel1.Controls.Add(Me.lbliv)
        Me.Panel1.Controls.Add(Me.txtcantidad)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblproducto_nombre)
        Me.Panel1.Controls.Add(Me.txtid_producto)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(25, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(821, 248)
        Me.Panel1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(262, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 24)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "desc"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(501, 162)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 24)
        Me.Label12.TabIndex = 119
        Me.Label12.Text = "%"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblutilidad
        '
        Me.lblutilidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblutilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblutilidad.Location = New System.Drawing.Point(422, 162)
        Me.lblutilidad.Name = "lblutilidad"
        Me.lblutilidad.Size = New System.Drawing.Size(73, 24)
        Me.lblutilidad.TabIndex = 118
        Me.lblutilidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(354, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 24)
        Me.Label11.TabIndex = 117
        Me.Label11.Text = "Utilidad"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblprecio_actual
        '
        Me.lblprecio_actual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblprecio_actual.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprecio_actual.Location = New System.Drawing.Point(129, 162)
        Me.lblprecio_actual.Name = "lblprecio_actual"
        Me.lblprecio_actual.Size = New System.Drawing.Size(116, 24)
        Me.lblprecio_actual.TabIndex = 116
        Me.lblprecio_actual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 24)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Precio Actual"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtprecio
        '
        Me.txtprecio.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.Location = New System.Drawing.Point(129, 200)
        Me.txtprecio.MaxLength = 15
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(116, 26)
        Me.txtprecio.TabIndex = 114
        Me.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 24)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Precio"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcosto_actual
        '
        Me.lblcosto_actual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcosto_actual.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcosto_actual.Location = New System.Drawing.Point(129, 83)
        Me.lblcosto_actual.Name = "lblcosto_actual"
        Me.lblcosto_actual.Size = New System.Drawing.Size(116, 24)
        Me.lblcosto_actual.TabIndex = 112
        Me.lblcosto_actual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblcosto_final
        '
        Me.lblcosto_final.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblcosto_final.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcosto_final.Location = New System.Drawing.Point(424, 127)
        Me.lblcosto_final.Name = "lblcosto_final"
        Me.lblcosto_final.Size = New System.Drawing.Size(116, 24)
        Me.lblcosto_final.TabIndex = 111
        Me.lblcosto_final.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(322, 127)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(96, 24)
        Me.Label27.TabIndex = 110
        Me.Label27.Text = "Costo Final"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblpresentacion
        '
        Me.lblpresentacion.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpresentacion.Location = New System.Drawing.Point(220, 47)
        Me.lblpresentacion.Name = "lblpresentacion"
        Me.lblpresentacion.Size = New System.Drawing.Size(58, 24)
        Me.lblpresentacion.TabIndex = 78
        Me.lblpresentacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 24)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Costo Nuevo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbcantidad
        '
        Me.pbcantidad.Image = CType(resources.GetObject("pbcantidad.Image"), System.Drawing.Image)
        Me.pbcantidad.Location = New System.Drawing.Point(193, 57)
        Me.pbcantidad.Name = "pbcantidad"
        Me.pbcantidad.Size = New System.Drawing.Size(12, 12)
        Me.pbcantidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcantidad.TabIndex = 70
        Me.pbcantidad.TabStop = False
        Me.pbcantidad.Visible = False
        '
        'pbid_producto
        '
        Me.pbid_producto.Image = CType(resources.GetObject("pbid_producto.Image"), System.Drawing.Image)
        Me.pbid_producto.Location = New System.Drawing.Point(201, 14)
        Me.pbid_producto.Name = "pbid_producto"
        Me.pbid_producto.Size = New System.Drawing.Size(12, 12)
        Me.pbid_producto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbid_producto.TabIndex = 69
        Me.pbid_producto.TabStop = False
        Me.pbid_producto.Visible = False
        '
        'lbliv
        '
        Me.lbliv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliv.Location = New System.Drawing.Point(262, 127)
        Me.lbliv.Name = "lbliv"
        Me.lbliv.Size = New System.Drawing.Size(33, 24)
        Me.lbliv.TabIndex = 62
        Me.lbliv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(193, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(8, 8)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(205, 18)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(8, 8)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 56
        Me.PictureBox3.TabStop = False
        '
        'frm_Compra_Mantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 354)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.lbltitulo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_Compra_Mantenimiento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbid_producto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtid_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblproducto_nombre As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents pbcantidad As System.Windows.Forms.PictureBox
    Friend WithEvents pbid_producto As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbliv As System.Windows.Forms.Label
    Friend WithEvents lblpresentacion As System.Windows.Forms.Label
    Friend WithEvents txtcosto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblcosto_final As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtdescuento As System.Windows.Forms.TextBox
    Friend WithEvents lblcosto_actual As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblprecio_actual As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblutilidad As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
