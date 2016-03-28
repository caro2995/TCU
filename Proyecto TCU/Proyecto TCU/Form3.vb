Imports System.Data.SqlClient
Public Class Form3

    Private Sub btnAgregarAdopcion_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarAdopcion.Click
        Dim conexion As String
        conexion = "Data Source=DELL3521\SQLEXPRESS;Initial Catalog=ProyectoCasitaAzul;Integrated Security=True"
        Dim fechaAdopcion = txtFechaAdopcion.Text()
        Dim nombreAdoptante = txtNombreAdoptante.Text()
        Dim telefonoAdoptante = txtTelefonoAdoptante.Text()
        Dim nombrePerro = txtNombrePerro.Text()
        Dim sexoPerro = txtSexoPerro.Text()
        Dim estadoPerro = txtEstadoPerro.Text()
        Dim transaccion As String = "INSERT INTO adopcion VALUES ('" + fechaAdopcion + "','" + nombreAdoptante + "','" + telefonoAdoptante + "','" + nombrePerro + "','" + sexoPerro + "','" + estadoPerro + "')"

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