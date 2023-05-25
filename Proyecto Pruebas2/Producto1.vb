Imports System.IO

Public Class Producto1
    Private producto1 As String() = Directory.GetFiles("C:\Users\Saulm\Desktop\Productos\1.Audifonos")

    Public Sub New()
        InitializeComponent()
        PictureBox1.TabStop = False
        PictureBox1.Image = New System.Drawing.Bitmap(producto1(0))
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pedidos
        Global.pedidos.Show()
        Me.Hide()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Global.regreso.Show()
        Me.Hide()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Global.productos.Show()
        Me.Hide()
    End Sub

End Class