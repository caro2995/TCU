Imports System.Data.SqlClient
Public Class Form1

    Private Sub btnAgregarDonativo_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarDonativo.Click
        Dim conexion As String
        conexion = "Data Source=DELL3521\SQLEXPRESS;Initial Catalog=ProyectoCasitaAzul;Integrated Security=True"
        Dim patrocinador = txtPatrocinador.Text
        Dim donativoOficial = txtDonativoOficial.Text()
        Dim donativoPorSeparado = txtDonativoPorSeparado.Text()
        Dim valorEstimado = txtValorEstimado.Text()
        Dim premioFinal = txtPremioFinal.Text()

        Dim transaccion As String = "INSERT INTO donativos VALUES ('" + patrocinador + "','" + donativoOficial + "','" + donativoPorSeparado + "','" + valorEstimado + "','" + premioFinal + "')"

        Dim adaptador As SqlDataAdapter
        Dim tablaDatos As New DataTable()

        Try
            adaptador = New SqlDataAdapter(transaccion, conexion)
            adaptador.Fill(tablaDatos)
            MsgBox("Registro insertado", MsgBoxStyle.Information)
            'Me.Visible = False
            'Form3.Visible = True
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.AbortRetryIgnore)
        End Try
    End Sub
End Class
