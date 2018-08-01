<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rpt_venta_producto_opciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_rpt_venta_producto_opciones))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cbid_Proveedor = New System.Windows.Forms.ComboBox
        Me.cbid_familia = New System.Windows.Forms.ComboBox
        Me.lblproducto_nombre = New System.Windows.Forms.Label
        Me.txtid_producto = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtphasta = New System.Windows.Forms.DateTimePicker
        Me.Dtpdesde = New System.Windows.Forms.DateTimePicker
        Me.lblprd_linea = New System.Windows.Forms.Label
        Me.lblprd_proveedor = New System.Windows.Forms.Label
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cbid_Proveedor)
        Me.Panel1.Controls.Add(Me.cbid_familia)
        Me.Panel1.Controls.Add(Me.lblproducto_nombre)
        Me.Panel1.Controls.Add(Me.txtid_producto)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtphasta)
        Me.Panel1.Controls.Add(Me.Dtpdesde)
        Me.Panel1.Controls.Add(Me.lblprd_linea)
        Me.Panel1.Controls.Add(Me.lblprd_proveedor)
        Me.Panel1.Location = New System.Drawing.Point(21, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(929, 177)
        Me.Panel1.TabIndex = 64
        '
        'cbid_Proveedor
        '
        Me.cbid_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbid_Proveedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbid_Proveedor.Location = New System.Drawing.Point(102, 12)
        Me.cbid_Proveedor.Name = "cbid_Proveedor"
        Me.cbid_Proveedor.Size = New System.Drawing.Size(493, 26)
        Me.cbid_Proveedor.TabIndex = 74
        '
        'cbid_familia
        '
        Me.cbid_familia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbid_familia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbid_familia.Location = New System.Drawing.Point(102, 49)
        Me.cbid_familia.Name = "cbid_familia"
        Me.cbid_familia.Size = New System.Drawing.Size(493, 26)
        Me.cbid_familia.TabIndex = 73
        '
        'lblproducto_nombre
        '
        Me.lblproducto_nombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproducto_nombre.Location = New System.Drawing.Point(179, 92)
        Me.lblproducto_nombre.Name = "lblproducto_nombre"
        Me.lblproducto_nombre.Size = New System.Drawing.Size(732, 24)
        Me.lblproducto_nombre.TabIndex = 72
        Me.lblproducto_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtid_producto
        '
        Me.txtid_producto.AcceptsReturn = True
        Me.txtid_producto.AcceptsTab = True
        Me.txtid_producto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid_producto.Location = New System.Drawing.Point(102, 90)
        Me.txtid_producto.MaxLength = 8
        Me.txtid_producto.Name = "txtid_producto"
        Me.txtid_producto.Size = New System.Drawing.Size(71, 26)
        Me.txtid_producto.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 24)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Producto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(215, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 24)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Hasta"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Desde"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtphasta
        '
        Me.dtphasta.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtphasta.Location = New System.Drawing.Point(281, 130)
        Me.dtphasta.Name = "dtphasta"
        Me.dtphasta.Size = New System.Drawing.Size(99, 25)
        Me.dtphasta.TabIndex = 6
        '
        'Dtpdesde
        '
        Me.Dtpdesde.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtpdesde.Location = New System.Drawing.Point(102, 130)
        Me.Dtpdesde.Name = "Dtpdesde"
        Me.Dtpdesde.Size = New System.Drawing.Size(99, 25)
        Me.Dtpdesde.TabIndex = 5
        '
        'lblprd_linea
        '
        Me.lblprd_linea.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprd_linea.Location = New System.Drawing.Point(18, 49)
        Me.lblprd_linea.Name = "lblprd_linea"
        Me.lblprd_linea.Size = New System.Drawing.Size(83, 24)
        Me.lblprd_linea.TabIndex = 62
        Me.lblprd_linea.Text = "Familia"
        Me.lblprd_linea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblprd_proveedor
        '
        Me.lblprd_proveedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprd_proveedor.Location = New System.Drawing.Point(18, 12)
        Me.lblprd_proveedor.Name = "lblprd_proveedor"
        Me.lblprd_proveedor.Size = New System.Drawing.Size(83, 24)
        Me.lblprd_proveedor.TabIndex = 61
        Me.lblprd_proveedor.Text = "Proveedor"
        Me.lblprd_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btncancelar
        '
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(415, 227)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(103, 36)
        Me.btncancelar.TabIndex = 66
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(291, 227)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(103, 36)
        Me.btnaceptar.TabIndex = 65
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'lbltitulo
        '
        Me.lbltitulo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbltitulo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lbltitulo.Location = New System.Drawing.Point(-2, -2)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(979, 28)
        Me.lbltitulo.TabIndex = 67
        Me.lbltitulo.Text = "Reporte de Ventas por Producto"
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_rpt_venta_producto_opciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 275)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_rpt_venta_producto_opciones"
        Me.Opacity = 0.9
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblproducto_nombre As System.Windows.Forms.Label
    Friend WithEvents txtid_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtphasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtpdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblprd_linea As System.Windows.Forms.Label
    Friend WithEvents lblprd_proveedor As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents cbid_familia As System.Windows.Forms.ComboBox
    Friend WithEvents cbid_Proveedor As System.Windows.Forms.ComboBox
End Class
