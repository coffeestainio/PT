<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_factura_anular
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_factura_anular))
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbid_factura = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.lblmonto = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblplazo = New System.Windows.Forms.Label
        Me.lblfecha = New System.Windows.Forms.Label
        Me.lblid_cliente = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtid_factura = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbid_factura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltitulo
        '
        Me.lbltitulo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lbltitulo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitulo.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lbltitulo.Location = New System.Drawing.Point(0, 0)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(605, 27)
        Me.lbltitulo.TabIndex = 7
        Me.lbltitulo.Text = "Anular Factura"
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.pbid_factura)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.lblmonto)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblplazo)
        Me.Panel1.Controls.Add(Me.lblfecha)
        Me.Panel1.Controls.Add(Me.lblid_cliente)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtid_factura)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(22, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(563, 211)
        Me.Panel1.TabIndex = 8
        '
        'pbid_factura
        '
        Me.pbid_factura.Image = CType(resources.GetObject("pbid_factura.Image"), System.Drawing.Image)
        Me.pbid_factura.Location = New System.Drawing.Point(193, 29)
        Me.pbid_factura.Name = "pbid_factura"
        Me.pbid_factura.Size = New System.Drawing.Size(12, 12)
        Me.pbid_factura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbid_factura.TabIndex = 71
        Me.pbid_factura.TabStop = False
        Me.pbid_factura.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(193, 29)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(8, 8)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 70
        Me.PictureBox3.TabStop = False
        '
        'lblmonto
        '
        Me.lblmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmonto.Location = New System.Drawing.Point(107, 165)
        Me.lblmonto.Name = "lblmonto"
        Me.lblmonto.Size = New System.Drawing.Size(172, 24)
        Me.lblmonto.TabIndex = 31
        Me.lblmonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 24)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Monto"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblplazo
        '
        Me.lblplazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblplazo.Location = New System.Drawing.Point(107, 127)
        Me.lblplazo.Name = "lblplazo"
        Me.lblplazo.Size = New System.Drawing.Size(52, 24)
        Me.lblplazo.TabIndex = 29
        Me.lblplazo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblfecha
        '
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.Location = New System.Drawing.Point(107, 94)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(238, 24)
        Me.lblfecha.TabIndex = 28
        Me.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_cliente
        '
        Me.lblid_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid_cliente.Location = New System.Drawing.Point(107, 56)
        Me.lblid_cliente.Name = "lblid_cliente"
        Me.lblid_cliente.Size = New System.Drawing.Size(449, 38)
        Me.lblid_cliente.TabIndex = 27
        Me.lblid_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Factura"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtid_factura
        '
        Me.txtid_factura.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid_factura.Location = New System.Drawing.Point(111, 20)
        Me.txtid_factura.MaxLength = 7
        Me.txtid_factura.Name = "txtid_factura"
        Me.txtid_factura.Size = New System.Drawing.Size(76, 26)
        Me.txtid_factura.TabIndex = 0
        Me.txtid_factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtid_factura, "Escriba el N�mero de Factura")
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 24)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Plazo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 24)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Fecha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 24)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Cliente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btncancelar
        '
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(294, 256)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(88, 32)
        Me.btncancelar.TabIndex = 10
        Me.btncancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.btncancelar, "No Anular Factura")
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(184, 256)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(88, 32)
        Me.btnaceptar.TabIndex = 9
        Me.btnaceptar.Text = "Aceptar"
        Me.ToolTip1.SetToolTip(Me.btnaceptar, "Anular Factura")
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'frm_factura_anular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 296)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_factura_anular"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbid_factura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtid_factura As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents lblid_cliente As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lblplazo As System.Windows.Forms.Label
    Friend WithEvents lblmonto As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbid_factura As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
