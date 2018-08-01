Public Class frm_cliente_buscar
    Inherits System.Windows.Forms.Form

    Friend WithEvents dtgcliente As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox


    Friend WithEvents id_cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Dim Dvcliente As DataView
    Dim cliente As DataTable

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
    Friend WithEvents txtbuscar_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cliente_buscar))
        Me.txtbuscar_cliente = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtgcliente = New System.Windows.Forms.DataGridView
        Me.id_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        CType(Me.dtgcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbuscar_cliente
        '
        Me.txtbuscar_cliente.AccessibleDescription = ""
        Me.txtbuscar_cliente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar_cliente.Location = New System.Drawing.Point(63, 56)
        Me.txtbuscar_cliente.Name = "txtbuscar_cliente"
        Me.txtbuscar_cliente.Size = New System.Drawing.Size(341, 26)
        Me.txtbuscar_cliente.TabIndex = 23
        Me.txtbuscar_cliente.Tag = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Location = New System.Drawing.Point(0, -2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(576, 35)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Buscar Clientes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtgcliente
        '
        Me.dtgcliente.AllowUserToAddRows = False
        Me.dtgcliente.AllowUserToDeleteRows = False
        Me.dtgcliente.AllowUserToResizeColumns = False
        Me.dtgcliente.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgcliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgcliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgcliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_cliente, Me.nombre})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgcliente.DefaultCellStyle = DataGridViewCellStyle5
        Me.dtgcliente.Location = New System.Drawing.Point(33, 103)
        Me.dtgcliente.Name = "dtgcliente"
        Me.dtgcliente.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgcliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dtgcliente.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgcliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgcliente.Size = New System.Drawing.Size(516, 381)
        Me.dtgcliente.TabIndex = 25
        '
        'id_cliente
        '
        Me.id_cliente.DataPropertyName = "id_cliente"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_cliente.DefaultCellStyle = DataGridViewCellStyle3
        Me.id_cliente.HeaderText = "Cód"
        Me.id_cliente.Name = "id_cliente"
        Me.id_cliente.ReadOnly = True
        Me.id_cliente.Width = 50
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre_comercial"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.DefaultCellStyle = DataGridViewCellStyle4
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 400
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(33, 58)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 26
        Me.PictureBox5.TabStop = False
        '
        'frm_cliente_buscar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(579, 496)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.dtgcliente)
        Me.Controls.Add(Me.txtbuscar_cliente)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_cliente_buscar"
        Me.Opacity = 0.9
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtgcliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frm_cliente_buscar_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub


    Private Sub frm_cliente_buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SendKeys.Send("{right}")

    End Sub
    Private Sub txtbuscar_cliente_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar_cliente.TextChanged
        Try
            cliente = Table("select id_cliente,nombre_comercial from cliente where eliminado=0 and nombre_comercial Like '%" & txtbuscar_cliente.Text & "%'", "")
            Dvcliente = New DataView(cliente)
            Dvcliente.Sort = "nombre_comercial"
            dtgcliente.DataSource = Dvcliente
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub
    Private Sub Asignar_id_cliente()
        'Try
        Select Case BUSQUEDA
            Case "estado_cuenta"
                myForms.frm_rpt_estado_opciones.txtid_cliente.Text = dtgcliente.Item("id_cliente", dtgcliente.CurrentRow.Index).Value
                myForms.frm_rpt_estado_opciones.Identifica_cliente()
            Case "Pedido"
                myForms.frm_pedido.txtid_cliente.Text = dtgcliente.Item("id_cliente", dtgcliente.CurrentRow.Index).Value
                myForms.frm_pedido.Identifica_cliente()
            Case "venta_producto_cliente"
                myForms.frm_rpt_venta_producto_cliente_opciones.txtid_cliente.Text = dtgcliente.Item("id_cliente", dtgcliente.CurrentRow.Index).Value
                myForms.frm_rpt_venta_producto_cliente_opciones.Identifica_cliente()
            Case "venta_neta"
                myForms.frm_reportes_admin.txtvnid_cliente.Text = dtgcliente.Item("id_cliente", dtgcliente.CurrentRow.Index).Value
                myForms.frm_reportes_admin.vnIdentifica_cliente()
            Case "recibo"
                myForms.frm_recibo.txtid_cliente.Text = dtgcliente.Item("id_cliente", dtgcliente.CurrentRow.Index).Value
                myForms.frm_recibo.Identifica_cliente()
            Case "cuentasxcobrar"
                myForms.frm_cuentasxcobrar.txtid_cliente.Text = dtgcliente.Item("id_cliente", dtgcliente.CurrentRow.Index).Value
                myForms.frm_cuentasxcobrar.Identifica_cliente()
            Case "nc"
                myForms.frm_nota_credito.txtid_cliente.Text = dtgcliente.Item("id_cliente", dtgcliente.CurrentRow.Index).Value
                myForms.frm_nota_credito.cliente_Identificar()
            Case "facturas_cliente"
                myForms.frm_reportes_admin.txtfcp_idcliente.Text = dtgcliente.Item("id_cliente", dtgcliente.CurrentRow.Index).Value
                myForms.frm_reportes_admin.fcpIdentifica_cliente()
        End Select
        Me.Close()
        'Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub
    Private Sub dtgcliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgcliente.Click
        Asignar_id_cliente()
    End Sub

    Private Sub dtgcliente_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgcliente.CellContentClick
        Asignar_id_cliente()
    End Sub
End Class
