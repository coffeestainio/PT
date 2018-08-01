Public Class frm_proveedor_mantenimiento
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txttelefono3 As System.Windows.Forms.TextBox
    Friend WithEvents txttelefono2 As System.Windows.Forms.TextBox
    Friend WithEvents txttelefono1 As System.Windows.Forms.TextBox
    Friend WithEvents txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Txtcontacto3 As System.Windows.Forms.TextBox
    Friend WithEvents txtcontacto2 As System.Windows.Forms.TextBox
    Friend WithEvents txtcontacto1 As System.Windows.Forms.TextBox
    Friend WithEvents txtpais As System.Windows.Forms.TextBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblid_proveedor As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents pbnombre As System.Windows.Forms.PictureBox
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_proveedor_mantenimiento))
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.pbnombre = New System.Windows.Forms.PictureBox
        Me.txttelefono3 = New System.Windows.Forms.TextBox
        Me.txttelefono2 = New System.Windows.Forms.TextBox
        Me.txttelefono1 = New System.Windows.Forms.TextBox
        Me.txtobservaciones = New System.Windows.Forms.TextBox
        Me.Txtcontacto3 = New System.Windows.Forms.TextBox
        Me.txtcontacto2 = New System.Windows.Forms.TextBox
        Me.txtcontacto1 = New System.Windows.Forms.TextBox
        Me.txtpais = New System.Windows.Forms.TextBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblid_proveedor = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.pbnombre, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbltitulo.Size = New System.Drawing.Size(558, 22)
        Me.lbltitulo.TabIndex = 18
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncancelar
        '
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(298, 465)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(88, 32)
        Me.btncancelar.TabIndex = 11
        Me.btncancelar.Text = "Cancelar"
        Me.ToolTip1.SetToolTip(Me.btncancelar, "No Guardar los Datos")
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnaceptar
        '
        Me.btnaceptar.Image = CType(resources.GetObject("btnaceptar.Image"), System.Drawing.Image)
        Me.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar.Location = New System.Drawing.Point(197, 465)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(88, 32)
        Me.btnaceptar.TabIndex = 10
        Me.btnaceptar.Text = "Aceptar"
        Me.ToolTip1.SetToolTip(Me.btnaceptar, "Guardar los Datos")
        Me.btnaceptar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.pbnombre)
        Me.Panel1.Controls.Add(Me.txttelefono3)
        Me.Panel1.Controls.Add(Me.txttelefono2)
        Me.Panel1.Controls.Add(Me.txttelefono1)
        Me.Panel1.Controls.Add(Me.txtobservaciones)
        Me.Panel1.Controls.Add(Me.Txtcontacto3)
        Me.Panel1.Controls.Add(Me.txtcontacto2)
        Me.Panel1.Controls.Add(Me.txtcontacto1)
        Me.Panel1.Controls.Add(Me.txtpais)
        Me.Panel1.Controls.Add(Me.txtemail)
        Me.Panel1.Controls.Add(Me.txtnombre)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblid_proveedor)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(22, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(546, 424)
        Me.Panel1.TabIndex = 0
        '
        'pbnombre
        '
        Me.pbnombre.Image = CType(resources.GetObject("pbnombre.Image"), System.Drawing.Image)
        Me.pbnombre.Location = New System.Drawing.Point(468, 52)
        Me.pbnombre.Name = "pbnombre"
        Me.pbnombre.Size = New System.Drawing.Size(12, 12)
        Me.pbnombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbnombre.TabIndex = 69
        Me.pbnombre.TabStop = False
        Me.pbnombre.Visible = False
        '
        'txttelefono3
        '
        Me.txttelefono3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono3.Location = New System.Drawing.Point(132, 174)
        Me.txttelefono3.MaxLength = 15
        Me.txttelefono3.Name = "txttelefono3"
        Me.txttelefono3.Size = New System.Drawing.Size(149, 26)
        Me.txttelefono3.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txttelefono3, "Escriba el teléfono3 del proveedor")
        '
        'txttelefono2
        '
        Me.txttelefono2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono2.Location = New System.Drawing.Point(132, 142)
        Me.txttelefono2.MaxLength = 15
        Me.txttelefono2.Name = "txttelefono2"
        Me.txttelefono2.Size = New System.Drawing.Size(149, 26)
        Me.txttelefono2.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txttelefono2, "Escriba el teléfono2 del proveedor")
        '
        'txttelefono1
        '
        Me.txttelefono1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono1.Location = New System.Drawing.Point(132, 110)
        Me.txttelefono1.MaxLength = 15
        Me.txttelefono1.Name = "txttelefono1"
        Me.txttelefono1.Size = New System.Drawing.Size(149, 26)
        Me.txttelefono1.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txttelefono1, "Escriba el teléfono1 del proveedor")
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservaciones.Location = New System.Drawing.Point(132, 366)
        Me.txtobservaciones.MaxLength = 50
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(392, 39)
        Me.txtobservaciones.TabIndex = 9
        '
        'Txtcontacto3
        '
        Me.Txtcontacto3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcontacto3.Location = New System.Drawing.Point(132, 310)
        Me.Txtcontacto3.MaxLength = 35
        Me.Txtcontacto3.Name = "Txtcontacto3"
        Me.Txtcontacto3.Size = New System.Drawing.Size(328, 26)
        Me.Txtcontacto3.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.Txtcontacto3, "Escriba el nombre del contacto del proveedor")
        '
        'txtcontacto2
        '
        Me.txtcontacto2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontacto2.Location = New System.Drawing.Point(132, 282)
        Me.txtcontacto2.MaxLength = 35
        Me.txtcontacto2.Name = "txtcontacto2"
        Me.txtcontacto2.Size = New System.Drawing.Size(328, 26)
        Me.txtcontacto2.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.txtcontacto2, "Escriba el nombre del contacto del proveedor")
        '
        'txtcontacto1
        '
        Me.txtcontacto1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontacto1.Location = New System.Drawing.Point(132, 254)
        Me.txtcontacto1.MaxLength = 35
        Me.txtcontacto1.Name = "txtcontacto1"
        Me.txtcontacto1.Size = New System.Drawing.Size(328, 26)
        Me.txtcontacto1.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.txtcontacto1, "Escriba el nombre del contacto del proveedor")
        '
        'txtpais
        '
        Me.txtpais.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpais.Location = New System.Drawing.Point(132, 206)
        Me.txtpais.MaxLength = 20
        Me.txtpais.Name = "txtpais"
        Me.txtpais.Size = New System.Drawing.Size(194, 26)
        Me.txtpais.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.txtpais, "Escriba el país del proveedor")
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(132, 78)
        Me.txtemail.MaxLength = 20
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(194, 26)
        Me.txtemail.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtemail, "Escriba el e-mail del proveedor")
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(132, 46)
        Me.txtnombre.MaxLength = 35
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(328, 26)
        Me.txtnombre.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtnombre, "Escriba el nombre del proveedor")
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Contactos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "E-mail"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 24)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "País"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 24)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Teléfono 3"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 24)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Teléfono 2"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid_proveedor.Location = New System.Drawing.Point(132, 12)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(24, 24)
        Me.lblid_proveedor.TabIndex = 37
        Me.lblid_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 24)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Código"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 24)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Observaciones"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Teléfono 1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(468, 52)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(8, 8)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 40
        Me.PictureBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 24)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Nombre"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_proveedor_mantenimiento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(590, 504)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_proveedor_mantenimiento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Proveedores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbnombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Try
            Dim Fi As Boolean = False

            If txtnombre.Text = "" Then
                pbnombre.Visible = True
                Fi = True
            Else
                pbnombre.Visible = False
            End If
            If Fi Then
                MessageBox.Show("Hay campos requeridos sin completar", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            With myForms.frm_datos_mantenimiento
                Dim r As DataRow = TS(.DsProveedor.Tables(0), "nombre", txtnombre.Text)
                If Not (r Is Nothing) Then
                    If (lbltitulo.Text = "Incluir Proveedor") Or (lbltitulo.Text <> "Incluir Proveedor" And .dtgproveedor.Item("dtgprdid", .dtgproveedor.CurrentRow.Index).Value <> r("id_proveedor")) Then
                        MessageBox.Show("Nombre de Proveedor Ya Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtnombre.Focus()
                        SendKeys.Send("{home}+{end}")
                        Exit Sub
                    End If
                End If

                If lbltitulo.Text = "Incluir Proveedor" Then
                    .rowprv = .DvProveedor.Table.NewRow()
                End If
                .rowprv("nombre") = txtnombre.Text
                .rowprv("pais") = IIf(txtpais.Text = "", "", txtpais.Text)
                .rowprv("email") = IIf(txtemail.Text = "", "", txtemail.Text)
                .rowprv("telefono1") = IIf(txttelefono1.Text = "", "", txttelefono1.Text)
                .rowprv("telefono2") = IIf(txttelefono2.Text = "", "", txttelefono2.Text)
                .rowprv("telefono3") = IIf(txttelefono3.Text = "", "", txttelefono3.Text)
                .rowprv("contacto1") = IIf(txtcontacto1.Text = "", "", txtcontacto1.Text)
                .rowprv("contacto2") = IIf(txtcontacto2.Text = "", "", txtcontacto2.Text)
                .rowprv("contacto3") = IIf(Txtcontacto3.Text = "", "", Txtcontacto3.Text)
                .rowprv("observaciones") = IIf(txtobservaciones.Text = "", "", txtobservaciones.Text)
                If lbltitulo.Text = "Incluir Proveedor" Then .DvProveedor.Table.Rows.Add(.rowprv)
                .DaProveedor.Update(.DsProveedor, "Proveedor")
            End With
            Me.Close()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = chk(Asc(e.KeyChar))
        End If
    End Sub

    Private Sub txtemail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtemail.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = chk(Asc(e.KeyChar))
        End If
    End Sub

    Private Sub txttelefono1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = chk(Asc(e.KeyChar))
        End If
    End Sub

    Private Sub txttelefono2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono2.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = chk(Asc(e.KeyChar))
        End If
    End Sub

    Private Sub txttelefono3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono3.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = chk(Asc(e.KeyChar))
        End If
    End Sub


    Private Sub txtpais_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpais.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = chk(Asc(e.KeyChar))
        End If
    End Sub

    Private Sub txtcontacto1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontacto1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = chk(Asc(e.KeyChar))
        End If
    End Sub


    Private Sub txtcontacto2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontacto2.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = chk(Asc(e.KeyChar))
        End If
    End Sub

    Private Sub Txtcontacto3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtcontacto3.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = chk(Asc(e.KeyChar))
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

   
    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub txtemail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtemail.TextChanged

    End Sub

    Private Sub txttelefono1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttelefono1.TextChanged

    End Sub

    Private Sub txttelefono2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttelefono2.TextChanged

    End Sub

    Private Sub txttelefono3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttelefono3.TextChanged

    End Sub

    Private Sub txtpais_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpais.TextChanged

    End Sub

    Private Sub txtcontacto1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontacto1.TextChanged

    End Sub

    Private Sub txtcontacto2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontacto2.TextChanged

    End Sub

    Private Sub Txtcontacto3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcontacto3.TextChanged

    End Sub

    Private Sub txtobservaciones_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtobservaciones.TextChanged

    End Sub
End Class
