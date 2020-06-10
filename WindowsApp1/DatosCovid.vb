Imports System.ComponentModel


Public Class DatosCovid
    'Ing Me esfocé mucho :'v
    Dim Cont2, cont1, cont3, cont4 As Integer
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligarorio")
        End If
    End Sub

    Private Sub txtEdad_TextChanged(sender As Object, e As EventArgs) Handles txtEdad.TextChanged

    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating

        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligarorio")
        End If
    End Sub


    Private Sub txtMunicipio_TextChanged(sender As Object, e As EventArgs) Handles txtMunicipio.TextChanged

    End Sub

    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Es un campo obligarorio")
        End If
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip1.SetToolTip(txtNombre, "Ingrese el nombre ")
        ToolTip1.ToolTipTitle = "Nombre"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        ToolTip1.SetToolTip(txtEdad, "Ingrese La edad")
        ToolTip1.ToolTipTitle = "Edad"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip1.SetToolTip(txtMunicipio, "Ingrese el municipio")
        ToolTip1.ToolTipTitle = "Usuario"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chbPositivo_CheckedChanged(sender As Object, e As EventArgs) Handles chbPositivo.CheckedChanged
        If chbPositivo.Checked = True Then
            cont1 = cont1 + 1
        Else
            cont4 = cont4 - 1
        End If
        lblPositivos.Text = cont1

    End Sub

    Private Sub chbActivo_CheckedChanged(sender As Object, e As EventArgs) Handles chbActivo.CheckedChanged
        If chbActivo.Checked = True Then
            cont4 = cont4 + 1
        Else
            cont4 = cont4 - 1
        End If
        lblActivos.Text = cont4
    End Sub
    Private Sub chbMuerto_CheckedChanged(sender As Object, e As EventArgs) Handles chbMuerto.CheckedChanged
        If chbMuerto.Checked = True Then
            chbRecuperado.Enabled = False
            chbActivo.Enabled = False
            cmbEstado.Enabled = False
            Cont2 = Cont2 + 1
        Else
            chbRecuperado.Enabled = True
            chbActivo.Enabled = True
            cmbEstado.Enabled = True
            Cont2 = Cont2 - 1

        End If

        lblFallecidos.Text = Cont2


    End Sub

    Private Sub chbRecuperado_CheckedChanged(sender As Object, e As EventArgs) Handles chbRecuperado.CheckedChanged
        If chbRecuperado.Checked = True Then
            cont3 = cont3 + 1
            chbMuerto.Enabled = False
            chbActivo.Enabled = False
            cmbEstado.Enabled = False
        Else
            chbMuerto.Enabled = True
            chbActivo.Enabled = True
            cmbEstado.Enabled = True
            cont3 = cont3 - 1
        End If


        lblRecup.Text = cont3
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click


        txtMunicipio.Clear()
        txtNombre.Clear()
        txtEdad.Clear()
        txtDepartamentos.Clear()
        chbActivo.Checked = False
        chbMuerto.Checked = False
        chbNegativo.Checked = False
        chbPositivo.Checked = False
        chbRecuperado.Checked = False


    End Sub

    Private Sub chbNegativo_CheckedChanged(sender As Object, e As EventArgs) Handles chbNegativo.CheckedChanged
        If chbNegativo.Checked = True Then
            chbMuerto.Enabled = False
            chbActivo.Enabled = False
            chbRecuperado.Enabled = False
            cmbEstado.Enabled = False

            chbPositivo.Enabled = False
        Else
            chbMuerto.Enabled = True
            chbActivo.Enabled = True
            chbRecuperado.Enabled = True
            cmbEstado.Enabled = True
            chbPositivo.Enabled = True
        End If

    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click



        Dim Estado, resultado, Estado1 As String
        Try
            If Me.ValidateChildren And txtNombre.Text <> String.Empty And txtEdad.Text <> String.Empty And txtMunicipio.Text <> String.Empty Then
                If chbPositivo.Checked = True Then
                    resultado = " Positivo "
                Else
                    If chbNegativo.Checked = True Then
                        resultado = " Negativo "
                        lbxHistorial.Items.Add(txtNombre.Text & "        " & txtMunicipio.Text & "     " & txtDepartamentos.Text & "     " & resultado)
                    End If

                End If

                If chbActivo.Checked = True Then
                    Estado = " Activo "


                    Select Case cmbEstado.SelectedIndex
                        Case 0
                            Estado1 = " Estable "
                        Case 1
                            Estado1 = " Cuidado Intensivo "
                    End Select
                    lbxHistorial.Items.Add(txtNombre.Text & "        " & txtMunicipio.Text & "     " & txtDepartamentos.Text & "     " & resultado & "     " & Estado & " : " & Estado1)
                ElseIf chbMuerto.Checked = True Then
                    Estado = " Fallecido "


                    lbxHistorial.Items.Add(txtNombre.Text & "        " & txtMunicipio.Text & "     " & txtDepartamentos.Text & "     " & resultado & "     " & Estado)
                End If
                If chbRecuperado.Checked = True Then
                    Estado = " Recuperado "


                    lbxHistorial.Items.Add(txtNombre.Text & "        " & txtMunicipio.Text & "     " & txtDepartamentos.Text & "     " & resultado & "     " & Estado)
                End If




            Else
                MessageBox.Show("Revise los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class