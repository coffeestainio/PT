<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rpt_comision_opciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_rpt_comision_opciones))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cbid_agente = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbreporte = New System.Windows.Forms.ComboBox
        Me.lblproducto_nombre = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtphasta = New System.Windows.Forms.DateTimePicker
        Me.Dtpdesde = New System.Windows.Forms.DateTimePicker
        Me.lblcliente_nombre = New System.Windows.Forms.Label
        Me.lblprd_linea = New System.Windows.Forms.Label
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnaceptar = New System.Windows.Forms.Button
        Me.lbltitulo = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cbid_agente)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cbreporte)
        Me.Panel1.Controls.Add(Me.lblproducto_nombre)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtphasta)
        Me.Panel1.Controls.Add(Me.Dtpdesde)
        Me.Panel1.Controls.Add(Me.lblcliente_nombre)
        Me.Panel1.Controls.Add(Me.lblprd_linea)
        Me.Panel1.Location = New System.Drawing.Point(23, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(562, 133)
        Me.Panel1.TabIndex = 64
        '
        'cbid_agente
        '
        Me.cbid_agente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbid_agente.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbid_agente.Location = New System.Drawing.Point(102, 44)
        Me.cbid_agente.Name = "cbid_agente"
        Me.cbid_agente.Size = New System.Drawing.Size(425, 26)
        Me.cbid_agente.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 24)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Agente"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbreporte
        '
        Me.cbreporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbreporte.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbreporte.Items.AddRange(New Object() {"Comisión Generada", "Comisión Cobro"})
        Me.cbreporte.Location = New System.Drawing.Point(102, 10)
        Me.cbreporte.Name = "cbreporte"
        Me.cbreporte.Size = New System.Drawing.Size(196, 26)
        Me.cbreporte.TabIndex = 74
        '
        'lblproducto_nombre
        '
        Me.lblproducto_nombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproducto_nombre.Location = New System.Drawing.Point(179, 135)
        Me.lblproducto_nombre.Name = "lblproducto_nombre"
        Me.lblproducto_nombre.Size = New System.Drawing.Size(488, 24)
        Me.lblproducto_nombre.TabIndex = 72
        Me.lblproducto_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(223, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 24)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Hasta"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 86)
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
        Me.dtphasta.Location = New System.Drawing.Point(289, 86)
        Me.dtphasta.Name = "dtphasta"
        Me.dtphasta.Size = New System.Drawing.Size(99, 25)
        Me.dtphasta.TabIndex = 6
        '
        'Dtpdesde
        '
        Me.Dtpdesde.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtpdesde.Location = New System.Drawing.Point(98, 86)
        Me.Dtpdesde.Name = "Dtpdesde"
        Me.Dtpdesde.Size = New System.Drawing.Size(99, 25)
        Me.Dtpdesde.TabIndex = 5
        '
        'lblcliente_nombre
        '
        Me.lblcliente_nombre.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcliente_nombre.Location = New System.Drawing.Point(166, 12)
        Me.lblcliente_nombre.Name = "lblcliente_nombre"
        Me.lblcliente_nombre.Size = New System.Drawing.Size(429, 24)
        Me.lblcliente_nombre.TabIndex = 59
        Me.lblcliente_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblprd_linea
        '
        Me.lblprd_linea.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprd_linea.Location = New System.Drawing.Point(18, 12)
        Me.lblprd_linea.Name = "lblprd_linea"
        Me.lblprd_linea.Size = New System.Drawing.Size(83, 24)
        Me.lblprd_linea.TabIndex = 62
        Me.lblprd_linea.Text = "Reporte"
        Me.lblprd_linea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btncancelar
        '
        Me.btncancelar.Image = CType(resources.GetObject("btncancelar.Image"), System.Drawing.Image)
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(314, 179)
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
        Me.btnaceptar.Location = New System.Drawing.Point(196, 179)
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
        Me.lbltitulo.Location = New System.Drawing.Point(-1, -2)
        Me.lbltitulo.Name = "lbltitulo"
        Me.lbltitulo.Size = New System.Drawing.Size(611, 28)
        Me.lbltitulo.TabIndex = 67
        Me.lbltitulo.Text = "Comisiones"
        Me.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_rpt_comision_opciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 227)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.lbltitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_rpt_comision_opciones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbid_agente As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbreporte As System.Windows.Forms.ComboBox
    Friend WithEvents lblproducto_nombre As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtphasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtpdesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblcliente_nombre As System.Windows.Forms.Label
    Friend WithEvents lblprd_linea As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents lbltitulo As System.Windows.Forms.Label
End Class
