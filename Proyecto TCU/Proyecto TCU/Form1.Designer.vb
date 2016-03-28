<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtPatrocinador = New System.Windows.Forms.TextBox()
        Me.txtDonativoOficial = New System.Windows.Forms.TextBox()
        Me.txtDonativoPorSeparado = New System.Windows.Forms.TextBox()
        Me.txtValorEstimado = New System.Windows.Forms.TextBox()
        Me.txtPremioFinal = New System.Windows.Forms.TextBox()
        Me.btnAgregarDonativo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Donativos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patrocinador:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Donativo Oficial:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Donativo Por Separado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Valor Estimado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Premio Final:"
        '
        'txtPatrocinador
        '
        Me.txtPatrocinador.Location = New System.Drawing.Point(88, 28)
        Me.txtPatrocinador.Name = "txtPatrocinador"
        Me.txtPatrocinador.Size = New System.Drawing.Size(164, 20)
        Me.txtPatrocinador.TabIndex = 6
        '
        'txtDonativoOficial
        '
        Me.txtDonativoOficial.Location = New System.Drawing.Point(103, 50)
        Me.txtDonativoOficial.Name = "txtDonativoOficial"
        Me.txtDonativoOficial.Size = New System.Drawing.Size(149, 20)
        Me.txtDonativoOficial.TabIndex = 7
        '
        'txtDonativoPorSeparado
        '
        Me.txtDonativoPorSeparado.Location = New System.Drawing.Point(139, 72)
        Me.txtDonativoPorSeparado.Name = "txtDonativoPorSeparado"
        Me.txtDonativoPorSeparado.Size = New System.Drawing.Size(113, 20)
        Me.txtDonativoPorSeparado.TabIndex = 8
        '
        'txtValorEstimado
        '
        Me.txtValorEstimado.Location = New System.Drawing.Point(98, 95)
        Me.txtValorEstimado.Name = "txtValorEstimado"
        Me.txtValorEstimado.Size = New System.Drawing.Size(154, 20)
        Me.txtValorEstimado.TabIndex = 9
        '
        'txtPremioFinal
        '
        Me.txtPremioFinal.Location = New System.Drawing.Point(85, 117)
        Me.txtPremioFinal.Name = "txtPremioFinal"
        Me.txtPremioFinal.Size = New System.Drawing.Size(167, 20)
        Me.txtPremioFinal.TabIndex = 10
        '
        'btnAgregarDonativo
        '
        Me.btnAgregarDonativo.Location = New System.Drawing.Point(139, 167)
        Me.btnAgregarDonativo.Name = "btnAgregarDonativo"
        Me.btnAgregarDonativo.Size = New System.Drawing.Size(113, 23)
        Me.btnAgregarDonativo.TabIndex = 11
        Me.btnAgregarDonativo.Text = "Agregar Donativo"
        Me.btnAgregarDonativo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 200)
        Me.Controls.Add(Me.btnAgregarDonativo)
        Me.Controls.Add(Me.txtPremioFinal)
        Me.Controls.Add(Me.txtValorEstimado)
        Me.Controls.Add(Me.txtDonativoPorSeparado)
        Me.Controls.Add(Me.txtDonativoOficial)
        Me.Controls.Add(Me.txtPatrocinador)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPatrocinador As System.Windows.Forms.TextBox
    Friend WithEvents txtDonativoOficial As System.Windows.Forms.TextBox
    Friend WithEvents txtDonativoPorSeparado As System.Windows.Forms.TextBox
    Friend WithEvents txtValorEstimado As System.Windows.Forms.TextBox
    Friend WithEvents txtPremioFinal As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregarDonativo As System.Windows.Forms.Button

End Class
