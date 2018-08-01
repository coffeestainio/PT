Public Class frm_familia_mantenimiento

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
                Dim r As DataRow = TS(.Dsfamilia.Tables(0), "nombre", txtnombre.Text)
                If Not (r Is Nothing) Then
                    If (lbltitulo.Text = "Incluir Familia") Or (lbltitulo.Text <> "Incluir Familia" And .dtgfamilia.Item("dtgfid", .dtgfamilia.CurrentRow.Index).Value <> r("id_Familia")) Then
                        MessageBox.Show("Nombre de Familia Ya Existe", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        txtnombre.Focus()
                        SendKeys.Send("{home}+{end}")
                        Exit Sub
                    End If
                End If

                If lbltitulo.Text = "Incluir Familia" Then
                    .rowprv = .Dvfamilia.Table.NewRow()
                End If
                .rowprv("nombre") = txtnombre.Text

                If lbltitulo.Text = "Incluir Familia" Then .Dvfamilia.Table.Rows.Add(.rowprv)
                .Dafamilia.Update(.Dsfamilia, "Familia")
            End With
            Me.Close()
        Catch myerror As Exception
            ONEX(Me.Name, myerror)
        End Try
    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            e.Handled = chk(Asc(e.KeyChar))
        End If
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Close()
    End Sub
End Class