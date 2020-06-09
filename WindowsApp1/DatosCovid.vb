Imports System.ComponentModel

Public Class DatosCovid
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Nombre, Edad, Departamento, Municipio As String
        Dim Activo, Muerto, Recuperado, Positivo As Boolean
        Try
            If Me.ValidateChildren And txtNombre.Text <> String.Empty And txtEdad.Text <> String.Empty And txtMunicipio.Text <> String.Empty And txtDepartamento.Text <> String.Empty Then
                Nombre = Val(txtNombre.Text)
                Edad = Val(txtEdad.Text)
                Departamento = Val(txtDepartamento.Text)
                Municipio = Val(txtMunicipio.Text)
                chbPositivo.Checked = Positivo
                If chbNegativo.Checked = True Then
                    chbRecuperado.Checked = False
                    chbMuerto.Checked = False
                    chbActivo.Checked = False
                Else
                    If Positivo = True Then
                        Activo = chbActivo.Checked
                        Muerto = chbMuerto.Checked
                        Recuperado = chbRecuperado.Checked
                        Dim i As Integer
                        Select Case cmbDepartamentos.SelectedIndex

                            Case 0
                                For i = 1 To Positivo Step 1
                                    lbxHistorial.Items.Add(Positivo)
                                Next
                            Case 1

                        End Select


                    End If
                End If
            Else
                MessageBox.Show("Revise los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbDepartamentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamentos.SelectedIndexChanged
        cmbDepartamentos.Items.Add("Francisco Morazán")
        cmbDepartamentos.Items.Add("Comayagua")
    End Sub

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

    Private Sub txtDepartamento_TextChanged(sender As Object, e As EventArgs) Handles txtDepartamento.TextChanged

    End Sub

    Private Sub txtDepartamento_Validating(sender As Object, e As CancelEventArgs) Handles txtDepartamento.Validating
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

    Private Sub txtDepartamento_MouseHover(sender As Object, e As EventArgs) Handles txtDepartamento.MouseHover
        ToolTip1.SetToolTip(txtDepartamento, "Ingrese el departamento")
        ToolTip1.ToolTipTitle = "Usuario"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip1.SetToolTip(txtMunicipio, "Ingrese el municipio")
        ToolTip1.ToolTipTitle = "Usuario"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class