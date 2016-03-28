<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFechaAdopcion = New System.Windows.Forms.TextBox()
        Me.txtNombreAdoptante = New System.Windows.Forms.TextBox()
        Me.txtTelefonoAdoptante = New System.Windows.Forms.TextBox()
        Me.txtNombrePerro = New System.Windows.Forms.TextBox()
        Me.txtSexoPerro = New System.Windows.Forms.TextBox()
        Me.txtEstadoPerro = New System.Windows.Forms.TextBox()
        Me.btnAgregarAdopcion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adopciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha de Adopción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre del Adoptante:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefono del Adoptante:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre del Perro:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sexo del Perro:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Estado del Perro:"
        '
        'txtFechaAdopcion
        '
        Me.txtFechaAdopcion.Location = New System.Drawing.Point(121, 28)
        Me.txtFechaAdopcion.Name = "txtFechaAdopcion"
        Me.txtFechaAdopcion.Size = New System.Drawing.Size(239, 20)
        Me.txtFechaAdopcion.TabIndex = 7
        '
        'txtNombreAdoptante
        '
        Me.txtNombreAdoptante.Location = New System.Drawing.Point(134, 50)
        Me.txtNombreAdoptante.Name = "txtNombreAdoptante"
        Me.txtNombreAdoptante.Size = New System.Drawing.Size(226, 20)
        Me.txtNombreAdoptante.TabIndex = 8
        '
        'txtTelefonoAdoptante
        '
        Me.txtTelefonoAdoptante.Location = New System.Drawing.Point(134, 72)
        Me.txtTelefonoAdoptante.Name = "txtTelefonoAdoptante"
        Me.txtTelefonoAdoptante.Size = New System.Drawing.Size(226, 20)
        Me.txtTelefonoAdoptante.TabIndex = 9
        '
        'txtNombrePerro
        '
        Me.txtNombrePerro.Location = New System.Drawing.Point(110, 94)
        Me.txtNombrePerro.Name = "txtNombrePerro"
        Me.txtNombrePerro.Size = New System.Drawing.Size(250, 20)
        Me.txtNombrePerro.TabIndex = 10
        '
        'txtSexoPerro
        '
        Me.txtSexoPerro.Location = New System.Drawing.Point(97, 116)
        Me.txtSexoPerro.Name = "txtSexoPerro"
        Me.txtSexoPerro.Size = New System.Drawing.Size(263, 20)
        Me.txtSexoPerro.TabIndex = 11
        '
        'txtEstadoPerro
        '
        Me.txtEstadoPerro.Location = New System.Drawing.Point(106, 138)
        Me.txtEstadoPerro.Name = "txtEstadoPerro"
        Me.txtEstadoPerro.Size = New System.Drawing.Size(254, 20)
        Me.txtEstadoPerro.TabIndex = 12
        '
        'btnAgregarAdopcion
        '
        Me.btnAgregarAdopcion.Location = New System.Drawing.Point(225, 178)
        Me.btnAgregarAdopcion.Name = "btnAgregarAdopcion"
        Me.btnAgregarAdopcion.Size = New System.Drawing.Size(135, 43)
        Me.btnAgregarAdopcion.TabIndex = 13
        Me.btnAgregarAdopcion.Text = "Agregar Adopción"
        Me.btnAgregarAdopcion.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 241)
        Me.Controls.Add(Me.btnAgregarAdopcion)
        Me.Controls.Add(Me.txtEstadoPerro)
        Me.Controls.Add(Me.txtSexoPerro)
        Me.Controls.Add(Me.txtNombrePerro)
        Me.Controls.Add(Me.txtTelefonoAdoptante)
        Me.Controls.Add(Me.txtNombreAdoptante)
        Me.Controls.Add(Me.txtFechaAdopcion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFechaAdopcion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreAdoptante As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefonoAdoptante As System.Windows.Forms.TextBox
    Friend WithEvents txtNombrePerro As System.Windows.Forms.TextBox
    Friend WithEvents txtSexoPerro As System.Windows.Forms.TextBox
    Friend WithEvents txtEstadoPerro As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarAdopcion As System.Windows.Forms.Button
End Class
