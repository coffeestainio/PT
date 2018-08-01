Imports System.Data.SqlClient
Public Class frm_producto_buscar
    Inherits System.Windows.Forms.Form
    
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents dtgproducto As System.Windows.Forms.DataGridView
    Dim producto As DataTable
    Friend WithEvents id_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Dim Dvproducto As DataView
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar_producto As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_producto_buscar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtbuscar_producto = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.dtgproducto = New System.Windows.Forms.DataGridView
        Me.id_producto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgproducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbuscar_producto
        '
        Me.txtbuscar_producto.AccessibleDescription = ""
        Me.txtbuscar_producto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar_producto.Location = New System.Drawing.Point(61, 57)
        Me.txtbuscar_producto.Name = "txtbuscar_producto"
        Me.txtbuscar_producto.Size = New System.Drawing.Size(318, 26)
        Me.txtbuscar_producto.TabIndex = 26
        Me.txtbuscar_producto.Tag = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(633, 32)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Buscar Productos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(34, 59)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 29
        Me.PictureBox5.TabStop = False
        '
        'dtgproducto
        '
        Me.dtgproducto.AllowUserToAddRows = False
        Me.dtgproducto.AllowUserToDeleteRows = False
        Me.dtgproducto.AllowUserToResizeColumns = False
        Me.dtgproducto.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgproducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgproducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_producto, Me.nombre})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgproducto.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtgproducto.Location = New System.Drawing.Point(34, 105)
        Me.dtgproducto.Name = "dtgproducto"
        Me.dtgproducto.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgproducto.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgproducto.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dtgproducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgproducto.Size = New System.Drawing.Size(560, 403)
        Me.dtgproducto.TabIndex = 30
        '
        'id_producto
        '
        Me.id_producto.DataPropertyName = "id_producto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_producto.DefaultCellStyle = DataGridViewCellStyle2
        Me.id_producto.HeaderText = "Cód"
        Me.id_producto.Name = "id_producto"
        Me.id_producto.ReadOnly = True
        Me.id_producto.Width = 45
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.DefaultCellStyle = DataGridViewCellStyle3
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 450
        '
        'frm_producto_buscar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(633, 520)
        Me.Controls.Add(Me.dtgproducto)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.txtbuscar_producto)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_producto_buscar"
        Me.Opacity = 0.9
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgproducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frm_producto_buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SendKeys.Send("{right}")

    End Sub

    Private Sub Asignar_id_producto()
        'Try
        Select Case BUSQUEDA
            Case "venta_producto"
                myForms.frm_rpt_venta_producto_opciones.txtid_producto.Text = dtgproducto.Item("id_producto", dtgproducto.CurrentRow.Index).Value
                myForms.frm_rpt_venta_producto_opciones.Producto_identificar()
            Case "Pedido"
                myForms.frm_pedido_mantenimiento.txtid_producto.Text = dtgproducto.Item("id_producto", dtgproducto.CurrentRow.Index).Value
                myForms.frm_pedido_mantenimiento.Identifica_producto()
            Case "venta_producto_cliente"
                myForms.frm_rpt_venta_producto_cliente_opciones.txtid_producto.Text = dtgproducto.Item("id_producto", dtgproducto.CurrentRow.Index).Value
                myForms.frm_rpt_venta_producto_cliente_opciones.Identifica_Producto()
            Case "Compra"
                myForms.frm_compra_mantenimiento.txtid_producto.Text = dtgproducto.Item("id_producto", dtgproducto.CurrentRow.Index).Value
                myForms.frm_compra_mantenimiento.Identifica_producto()
            Case "Bodega_Ajuste"
                myForms.frm_Bodega_Ajuste_mantenimiento.txtid_producto.Text = dtgproducto.Item("id_producto", dtgproducto.CurrentRow.Index).Value
                myForms.frm_Bodega_Ajuste_mantenimiento.Identifica_producto()
            Case "compra_producto"
                myForms.frm_rpt_compra_producto_proveedor.txtid_producto.Text = dtgproducto.Item("id_producto", dtgproducto.CurrentRow.Index).Value
                myForms.frm_rpt_compra_producto_proveedor.Producto_Identificar()
            Case "bodega_existencia"
                myForms.frm_rpt_producto_existencias.txtid_producto.Text = dtgproducto.Item("id_producto", dtgproducto.CurrentRow.Index).Value
                myForms.frm_rpt_producto_existencias.Producto_identificar()
        End Select
        Me.Close()
        ' Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        ' End Try
    End Sub

    Private Sub txtbuscar_producto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar_producto.TextChanged
        Try
            producto = Table("select id_producto,nombre from producto where eliminado=0 and nombre Like '%" & txtbuscar_producto.Text & "%'", "")
            Dvproducto = New DataView(producto)
            Dvproducto.Sort = "nombre"
            dtgproducto.DataSource = Dvproducto
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub dtgproducto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgproducto.Click
        Asignar_id_producto()
    End Sub

    Private Sub dtgproducto_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgproducto.CellContentClick
        Asignar_id_producto()
    End Sub
End Class
