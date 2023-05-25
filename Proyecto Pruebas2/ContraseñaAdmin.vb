Public Class ContraseñaAdmin
    Private contraseña As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contraseña = TextBox1.Text
        If contraseña <> "0000" Then
            MessageBox.Show("CONTRASEÑA INCORRECTA, INTENTALO DE NUEVO O REGRESA AL MENÚ PRINCIPAL")
        Else
            Dim Administrador As Admin
            Administrador.Show()
        End If
    End Sub
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Clientes As PaginaClientes
        Clientes.Show()
        Me.Hide()
    End Sub
End Class