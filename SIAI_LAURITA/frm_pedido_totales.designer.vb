<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pedido_totales
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
        Me.lbltotal = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lbliv = New System.Windows.Forms.Label
        Me.lbldescuento = New System.Windows.Forms.Label
        Me.lblexento = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblgravado = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbltotal
        '
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(99, 151)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(139, 24)
        Me.lbltotal.TabIndex = 72
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lbliv)
        Me.Panel1.Controls.Add(Me.lbltotal)
        Me.Panel1.Controls.Add(Me.lbldescuento)
        Me.Panel1.Controls.Add(Me.lblexento)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblgravado)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 198)
        Me.Panel1.TabIndex = 73
        '
        'lbliv
        '
        Me.lbliv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbliv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliv.Location = New System.Drawing.Point(99, 117)
        Me.lbliv.Name = "lbliv"
        Me.lbliv.Size = New System.Drawing.Size(139, 24)
        Me.lbliv.TabIndex = 82
        Me.lbliv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbldescuento
        '
        Me.lbldescuento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbldescuento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescuento.Location = New System.Drawing.Point(99, 12)
        Me.lbldescuento.Name = "lbldescuento"
        Me.lbldescuento.Size = New System.Drawing.Size(139, 24)
        Me.lbldescuento.TabIndex = 80
        Me.lbldescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblexento
        '
        Me.lblexento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblexento.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblexento.Location = New System.Drawing.Point(99, 46)
        Me.lblexento.Name = "lblexento"
        Me.lblexento.Size = New System.Drawing.Size(139, 24)
        Me.lblexento.TabIndex = 79
        Me.lblexento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 24)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Total"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 24)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "IV"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 24)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Desc"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 24)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Exento"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblgravado
        '
        Me.lblgravado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblgravado.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgravado.Location = New System.Drawing.Point(99, 80)
        Me.lblgravado.Name = "lblgravado"
        Me.lblgravado.Size = New System.Drawing.Size(139, 24)
        Me.lblgravado.TabIndex = 73
        Me.lblgravado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 24)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Gravado"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_pedido_totales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 223)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_pedido_totales"
        Me.Opacity = 0.8
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbliv As System.Windows.Forms.Label
    Friend WithEvents lbldescuento As System.Windows.Forms.Label
    Friend WithEvents lblexento As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblgravado As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
