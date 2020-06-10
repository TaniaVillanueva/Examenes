<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosCovid
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDepartamentos = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.chbActivo = New System.Windows.Forms.CheckBox()
        Me.chbMuerto = New System.Windows.Forms.CheckBox()
        Me.chbRecuperado = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chbNegativo = New System.Windows.Forms.CheckBox()
        Me.chbPositivo = New System.Windows.Forms.CheckBox()
        Me.lbxHistorial = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblFallecidos = New System.Windows.Forms.Label()
        Me.lblRecup = New System.Windows.Forms.Label()
        Me.lblActivos = New System.Windows.Forms.Label()
        Me.lblPositivos = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Departamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Municipio"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDepartamentos)
        Me.GroupBox1.Controls.Add(Me.txtMunicipio)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 320)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'txtDepartamentos
        '
        Me.txtDepartamentos.Location = New System.Drawing.Point(85, 152)
        Me.txtDepartamentos.Name = "txtDepartamentos"
        Me.txtDepartamentos.Size = New System.Drawing.Size(139, 20)
        Me.txtDepartamentos.TabIndex = 8
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(85, 196)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(139, 20)
        Me.txtMunicipio.TabIndex = 7
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(85, 107)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(139, 20)
        Me.txtEdad.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(85, 67)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(139, 20)
        Me.txtNombre.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMostrar)
        Me.GroupBox2.Controls.Add(Me.btnNuevo)
        Me.GroupBox2.Controls.Add(Me.chbActivo)
        Me.GroupBox2.Controls.Add(Me.chbMuerto)
        Me.GroupBox2.Controls.Add(Me.chbRecuperado)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbEstado)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.chbNegativo)
        Me.GroupBox2.Controls.Add(Me.chbPositivo)
        Me.GroupBox2.Location = New System.Drawing.Point(270, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(201, 310)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(18, 264)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 19
        Me.btnMostrar.Text = "Guardar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(105, 264)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'chbActivo
        '
        Me.chbActivo.AutoSize = True
        Me.chbActivo.Location = New System.Drawing.Point(25, 155)
        Me.chbActivo.Name = "chbActivo"
        Me.chbActivo.Size = New System.Drawing.Size(56, 17)
        Me.chbActivo.TabIndex = 9
        Me.chbActivo.Text = "Activo"
        Me.chbActivo.UseVisualStyleBackColor = True
        '
        'chbMuerto
        '
        Me.chbMuerto.AutoSize = True
        Me.chbMuerto.Location = New System.Drawing.Point(25, 132)
        Me.chbMuerto.Name = "chbMuerto"
        Me.chbMuerto.Size = New System.Drawing.Size(68, 17)
        Me.chbMuerto.TabIndex = 8
        Me.chbMuerto.Text = "Fallecido"
        Me.chbMuerto.UseVisualStyleBackColor = True
        '
        'chbRecuperado
        '
        Me.chbRecuperado.AutoSize = True
        Me.chbRecuperado.Location = New System.Drawing.Point(25, 109)
        Me.chbRecuperado.Name = "chbRecuperado"
        Me.chbRecuperado.Size = New System.Drawing.Size(85, 17)
        Me.chbRecuperado.TabIndex = 7
        Me.chbRecuperado.Text = "Recuperado"
        Me.chbRecuperado.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Estado de pasientes positivos"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Estable", "Cuidado Intensivo"})
        Me.cmbEstado.Location = New System.Drawing.Point(22, 222)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(141, 21)
        Me.cmbEstado.TabIndex = 5
        Me.cmbEstado.Text = "Estado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Estado de pasiente Activo"
        '
        'chbNegativo
        '
        Me.chbNegativo.AutoSize = True
        Me.chbNegativo.Location = New System.Drawing.Point(111, 28)
        Me.chbNegativo.Name = "chbNegativo"
        Me.chbNegativo.Size = New System.Drawing.Size(69, 17)
        Me.chbNegativo.TabIndex = 1
        Me.chbNegativo.Text = "Negativo"
        Me.chbNegativo.UseVisualStyleBackColor = True
        '
        'chbPositivo
        '
        Me.chbPositivo.AutoSize = True
        Me.chbPositivo.Location = New System.Drawing.Point(22, 28)
        Me.chbPositivo.Name = "chbPositivo"
        Me.chbPositivo.Size = New System.Drawing.Size(63, 17)
        Me.chbPositivo.TabIndex = 0
        Me.chbPositivo.Text = "Positivo"
        Me.chbPositivo.UseVisualStyleBackColor = True
        '
        'lbxHistorial
        '
        Me.lbxHistorial.FormattingEnabled = True
        Me.lbxHistorial.Location = New System.Drawing.Point(477, 32)
        Me.lbxHistorial.Name = "lbxHistorial"
        Me.lbxHistorial.Size = New System.Drawing.Size(351, 290)
        Me.lbxHistorial.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(477, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Lista"
        '
        'errorValidacion
        '
        Me.errorValidacion.ContainerControl = Me
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(12, 338)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(108, 24)
        Me.btnCerrar.TabIndex = 10
        Me.btnCerrar.Text = "Cerrar Sesión"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(267, 333)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Positivos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(391, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Activos"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(516, 333)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Recuperados"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(661, 333)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Fallecidos"
        '
        'lblFallecidos
        '
        Me.lblFallecidos.AutoSize = True
        Me.lblFallecidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFallecidos.Location = New System.Drawing.Point(676, 352)
        Me.lblFallecidos.Name = "lblFallecidos"
        Me.lblFallecidos.Size = New System.Drawing.Size(2, 15)
        Me.lblFallecidos.TabIndex = 15
        '
        'lblRecup
        '
        Me.lblRecup.AutoSize = True
        Me.lblRecup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecup.Location = New System.Drawing.Point(531, 352)
        Me.lblRecup.Name = "lblRecup"
        Me.lblRecup.Size = New System.Drawing.Size(2, 15)
        Me.lblRecup.TabIndex = 16
        '
        'lblActivos
        '
        Me.lblActivos.AutoSize = True
        Me.lblActivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblActivos.Location = New System.Drawing.Point(391, 352)
        Me.lblActivos.Name = "lblActivos"
        Me.lblActivos.Size = New System.Drawing.Size(2, 15)
        Me.lblActivos.TabIndex = 17
        '
        'lblPositivos
        '
        Me.lblPositivos.AutoSize = True
        Me.lblPositivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPositivos.Location = New System.Drawing.Point(271, 352)
        Me.lblPositivos.Name = "lblPositivos"
        Me.lblPositivos.Size = New System.Drawing.Size(2, 15)
        Me.lblPositivos.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(385, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Nombre"
        '
        'DatosCovid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 374)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPositivos)
        Me.Controls.Add(Me.lblActivos)
        Me.Controls.Add(Me.lblRecup)
        Me.Controls.Add(Me.lblFallecidos)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbxHistorial)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "DatosCovid"
        Me.Text = "Datos Covid"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chbActivo As CheckBox
    Friend WithEvents chbMuerto As CheckBox
    Friend WithEvents chbRecuperado As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chbNegativo As CheckBox
    Friend WithEvents chbPositivo As CheckBox
    Friend WithEvents lbxHistorial As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents errorValidacion As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents txtDepartamentos As TextBox
    Friend WithEvents lblPositivos As Label
    Friend WithEvents lblActivos As Label
    Friend WithEvents lblRecup As Label
    Friend WithEvents lblFallecidos As Label
    Friend WithEvents Label6 As Label
End Class
