Imports System.Data.SqlClient
Public Class frm_Nota_debito_Reversar
    Dim cliente As DataTable
    Dim NC As DataTable
    Dim movimiento_ID As String


    Public Sub Identifica_Movimiento()

        'Try

        Dim criterio As String = "nota_debito.id_documento = " + txtid_movimiento.Text

        NC = NDM(criterio, True, "")

        If NC.Rows.Count = 0 Then
            MessageBox.Show("Nota de D�bito No Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtid_movimiento.Focus()
            SendKeys.Send("{home}+{end}")
            Exit Sub
        End If

        With NC.Rows(0)
            If .Item("anulado") Then
                MessageBox.Show("Nota de D�bito Ya Fue Reversada", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtid_movimiento.Focus()
                SendKeys.Send("{home}+{end}")
                Exit Sub
            End If


            'Dim ncd As DataTable = NDA("id_nota_debito=" + .Item("id_nota_debito").ToString, "")

            'If ncd.Rows.Count > 0 Then
            '    MessageBox.Show("Nota de D�bito Ya Fue Aplicada", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    txtid_movimiento.Focus()
            '    SendKeys.Send("{home}+{end}")
            '    Exit Sub
            'End If



            'cliente = Table("Select nombre_comercial from cliente where id_cliente=" + Fac.Rows(0).Item("id_cliente").ToString, "")
            lblid_cliente.Text = .Item("id_cliente").ToString + " - " + .Item("nombre_sociedad")
            movimiento_ID = txtid_movimiento.Text
            lblfecha.Text = .Item("fecha").ToString.Substring(0, 10)

            lblmonto.Text = FormatNumber(.Item("monto"), 2)
        End With
        '        Catch myerror As Exception
        'ONEX(Me.Name, myerror)
        'End Try
    End Sub




    Private Sub frm_descuento_financiero_anular_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            myForms.frm_principal.ToolStrip.Enabled = True
            CONN1.Close()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub frm_descuento_financiero_anular_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CONN1.Open()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub txtid_movimiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid_movimiento.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            If Val(txtid_movimiento.Text) = 0 Then
                Me.Close()
            Else
                Identifica_Movimiento()
            End If
        Else
            e.Handled = Numerico(Asc(e.KeyChar), txtid_movimiento.Text, False)
        End If
    End Sub

    Private Sub txtid_movimiento_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtid_movimiento.TextChanged

    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Try
            If Val(txtid_movimiento.Text) = 0 Then
                MessageBox.Show("Debe Escribir un N�mero de Nota de D�bito", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtid_movimiento.Focus()
                pbid_movimiento.Visible = True
                SendKeys.Send("{home}+{end}")
                Exit Sub
            End If

            If movimiento_ID <> txtid_movimiento.Text Then
                MessageBox.Show("Escriba de Nuevo el N�mero de Nota de D�bito y Presione Enter", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtid_movimiento.Focus()
                SendKeys.Send("{home}+{end}")
                Exit Sub
            End If

            Dim cmd As New SqlCommand
            cmd.Connection = CONN1
            Dim sql As String

            sql = "insert into Reversion (id_documento,tipo,fecha,id_usuario) values (" + _
               txtid_movimiento.Text + "," + _
            "7" + "," + _
            "'" + EDATE(Date.Today.ToShortDateString) + "'," + _
           USUARIO_ID + ")"

            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

            Me.Close()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
End Class