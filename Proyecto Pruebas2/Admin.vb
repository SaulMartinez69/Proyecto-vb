Public Class Admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pedidos As New Pedidos()
        pedidos.Show()
        Me.Hide()
    End Sub
End Class